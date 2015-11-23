using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        Conexion conexion = new Conexion();

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Contrasena1 { get; set; }


        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.NombreUsuario = "";
            this.Contrasena = "";
            this.Contrasena1 = "";

        }

       

        public bool Login()
        {
            DataTable dt = new DataTable ();
            try
            {
                dt = conexion.getDatos(String.Format("Select NombreUsuario, Contrasena from Usuarios where NombreUsuario='{0}' and Contrasena='{1}'", this.NombreUsuario, this.Contrasena));
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
            }
            catch (Exception)
            {
                
                return false;
            }
            return true;

        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Usuarios(Nombres, Apellidos, Direccion, NombreUsuario, Contrasena, Contrasena1) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", this.Nombre, this.Apellido, this.Direccion, this.NombreUsuario, this.Contrasena, this.Contrasena1));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }


        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Usuarios Set Nombres='{0}', Apellidos='{1}', Direccion='{2}', NombreUsuario='{3}', Contrasena='{4}, Contrasena1='{5}' where UsuarioId={6}", this.Nombre, this.Apellido, this.Direccion, this.NombreUsuario, this.Contrasena, this.Contrasena1, this.UsuarioId));

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public override bool Eliminar()
        {
            return conexion.Ejecutar(String.Format("Delete From Usuarios where UsuarioId = {0}", this.UsuarioId));
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt;

            dt = conexion.getDatos(String.Format("select *from Usuarios where UsuarioId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Nombre = dt.Rows[0]["Nombres"].ToString();
                this.Apellido = dt.Rows[0]["Apellidos"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena1 = dt.Rows[0]["Contrasena1"].ToString();
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;
            return conexion.getDatos(" Select " + Campos + " From Usuarios Where " + Condicion + " " + ordenFinal);
        }
    }
}
