using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RegistrosSocios:ClaseMaestra
    {
        Conexion conexion = new Conexion();
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public double Cedula { get; set; }
        public int Codigo { get; set; }
        public double Hectareas { get; set; }
        public int Fertilizantes { get; set; }
        public int SocioId { get; set; }


        public RegistrosSocios()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.Cedula = 0;
            this.Codigo = 0;
            this.Hectareas = 0;
            this.Fertilizantes = 0;
            this.SocioId = 0;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
               retorno = conexion.Ejecutar(String.Format("Insert Into Socios(Nombre, Apellido, Direccion, Cedula, Codigo, Hectareas, Fertilizantes) Values('{0}', '{1}', '{2}', {3}, {4}, {5}, {6})", this.Nombre, this.Apellido, this.Direccion, this.Cedula, this.Codigo, this.Hectareas, this.Fertilizantes));
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
                retorno = conexion.Ejecutar(String.Format("Update Socios Set Nombre='{0}', Apellido='{1}', Direccion='{2}', Cedula={3}, Hectareas={4}, Fertilizantes={5} where SocioId={6}", this.Nombre, this.Apellido, this.Direccion, this.Cedula, this.Hectareas, this.Fertilizantes, this.SocioId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Borrar()
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
                    //this.Cedula = (double)dt.Rows[0]["Cedula"];
                    this.Codigo = (int)dt.Rows[0]["Codigo"];
                    this.Hectareas = (double)dt.Rows[0]["Hectareas"];
                    this.Fertilizantes = (int)dt.Rows[0]["Fertilizantes"];
                }

            return dt.Rows.Count > 0;
            

        }

        public override DataTable Listar(string campos, string Filtro)
        {
            throw new NotImplementedException();
        }
    }
}
