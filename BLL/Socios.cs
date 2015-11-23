using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Socios:ClaseMaestra
    {
        Conexion conexion = new Conexion();
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public int CertificacionId { get; set; }
        public double CantidadTerreno { get; set; }
        public int Fertilizantes { get; set; }
        


        public Socios()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.Cedula = "";
            this.CertificacionId = 0;
            this.CantidadTerreno = 0;
            this.Fertilizantes = 0;
            this.SocioId = 0;
        }

        

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
               retorno = conexion.Ejecutar(String.Format("Insert Into Socios(Nombre, Apellido, Direccion, Cedula, CertificacionId, CantidadTerreno, Fertilizantes) Values('{0}', '{1}', '{2}', {3}, {4}, {5}, {6})", this.Nombre, this.Apellido, this.Direccion, this.Cedula, this.CertificacionId, this.CantidadTerreno, this.Fertilizantes));
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
                retorno = conexion.Ejecutar(String.Format("Update Socios Set Nombre='{0}', Apellido='{1}', Direccion='{2}', Cedula={3}, CertificacionId={4}, CantidadTerreno={5}, Fertilizantes={6} where SocioId={7}", this.Nombre, this.Apellido, this.Direccion, this.Cedula, this.CertificacionId, this.CantidadTerreno, this.Fertilizantes, this.SocioId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Delete from Socios where SocioId={0}", this.SocioId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt;
            
                dt = conexion.getDatos(String.Format("select *from Socios where SocioId= {0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.Nombre = dt.Rows[0]["Nombre"].ToString();
                    this.Apellido = dt.Rows[0]["Apellido"].ToString();
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();
                    this.Cedula = dt.Rows[0]["Cedula"].ToString();
                    this.CantidadTerreno = (double)dt.Rows[0]["CantidadTerreno"];
                    this.Fertilizantes = (int)dt.Rows[0]["Fertilizantes"];
                }

            return dt.Rows.Count > 0;
            

        }

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;
            return conexion.getDatos(" Select " + Campos + " from Socios where " + Condicion + ""+ ordenFinal);
        }
    }
}
