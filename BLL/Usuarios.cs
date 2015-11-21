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
        

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.NombreUsuario = "";
            this.Contrasena = "";
            
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
        public override bool Eliminar()
        {
            return conexion.Ejecutar(String.Format("Delete From Usuarios where UsuarioId = {0}", this.UsuarioId));
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("Update Usuarios Set Nombres='{0}', Apellidos='{1}', Direccion='{2}', NombreUsuario='{3}', Contraseña='{4}' where UsuarioId={5}", this.Nombre, this.Apellido, this.Direccion, this.NombreUsuario, this.Contrasena));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
               retorno = conexion.Ejecutar(String.Format("Insert Into Usuarios(Nombres, Apellidos, Direccion, NombreUsuario, Contrasena) Values('{0}', '{1}', '{2}', '{3}', '{4}')", this.Nombre, this.Apellido, this.Direccion, this.NombreUsuario, this.Contrasena));
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            return retorno;
        }

        public override DataTable Listar(string campos, string condicion, string Filtro)
        {
            throw new NotImplementedException();
        }
    }
}
