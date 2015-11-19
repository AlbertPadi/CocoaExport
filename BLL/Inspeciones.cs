using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Inspeciones : ClaseMaestra
    {
        Conexion conexion = new Conexion();
        public int InspeccionId { get; set; }
        public int SocioId { get; set; }
        public string Fecha { get; set; }
        public int Fertilizantes { get; set; }
        public string MaterialSiembra { get; set; }
        public int CrianzaAnimales { get; set; }
        public string ControlPlagas { get; set; }
        public string ResumenInspeccion { get; set; }

        public Inspeciones()
        {
            this.InspeccionId = 0;
            this.SocioId = 0;
            this.Fecha = "";
            this.Fertilizantes = 0;
            this.MaterialSiembra = "";
            this.CrianzaAnimales = 0;
            this.ControlPlagas = "";
            this.ResumenInspeccion = "";
        }


        public Inspeciones(int inspeccionid, int socioid, string fecha, int fertilizantes, string materialsiembra, int crianzaanimales, string controlplagas, string resumeninspeccion)
        {
            this.InspeccionId = inspeccionid;
            this.SocioId = socioid;
            this.Fecha = fecha;
            this.Fertilizantes = fertilizantes;
            this.MaterialSiembra = materialsiembra;
            this.CrianzaAnimales = crianzaanimales;
            this.ControlPlagas = controlplagas;
            this.ResumenInspeccion = resumeninspeccion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Inspecciones(InspeccionId, SocioId, Fecha, Fertilizantes, MaterialSiembra, CrianzaAnimales, ControlPlagas, ResumenInspeccion) Values({0}, {1}, '{2}', {3}, '{4}', {5}, '{6}', '{7}')", this.SocioId, this.Fecha, this.Fertilizantes, this.MaterialSiembra, this.CrianzaAnimales, this.ControlPlagas, this.ResumenInspeccion));
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
                retorno = conexion.Ejecutar(String.Format("Delete from Inspecciones where InspeccionId={0}", this.InspeccionId));
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

            dt = conexion.getDatos(String.Format("select *from Inspecciones where InspeccionId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Fertilizantes = (int)dt.Rows[0]["Fertilizantes"];
                this.MaterialSiembra = dt.Rows[0]["MaterialSiembra"].ToString();
                this.CrianzaAnimales = (int)dt.Rows[0]["CrianzaAnimales"];
                this.ControlPlagas = dt.Rows[0]["ControlPlagas"].ToString();
                this.ResumenInspeccion = dt.Rows[0]["ResumenInspeccion"].ToString();
                
                
            }

            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Inspecciones Set Fecha='{0}', Fertilizantes={1}, MaterialSiembra='{2}', CrianzaAnimales={3}, ControlPlagas='{4}', ResumenInspeccion='{5}' where InspeccionId={6}", this.Fecha, this.Fertilizantes, this.MaterialSiembra, this.CrianzaAnimales, this.ControlPlagas, this.ResumenInspeccion, this.InspeccionId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;
            return conexion.getDatos("Select " + Campos + " from Inspecciones where " + Condicion + Orden);
        }
    }
}
