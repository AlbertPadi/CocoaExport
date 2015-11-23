using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
     public class Lotes : ClaseMaestra
    {
        Conexion conexion = new Conexion();

        public int LoteId { get; set; }
        public double Total { get; set; }
        public string CodigoLote { get; set; }
        public int CertificacionId { get; set; }
        public string Fecha { get; set; }
        public int ExportacionId { get; set; }

        public DataTable obtener(string Lote)
        {
            return conexion.getDatos(String.Format("select LoteId from Lotes where CodigoLote = {0}", Lote));
        }
        public Lotes()
        {
            this.LoteId = 0;
            this.Total = 0;
            this.CodigoLote = "";
            this.CertificacionId = 0;
            this.Fecha = "";
            this.ExportacionId = 0;

        }
        public Lotes(int loteId, string codigoLote)
        {
            this.LoteId = loteId;
            this.CodigoLote = codigoLote;
            
        }

        

        public override bool Insertar()
        {
            StringBuilder comando = new StringBuilder();
           
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Lotes(CodigoLote, Total, CertificacionId, Fecha) values('{0}', {1}, {2}, '{3}')",this.CodigoLote, this.Total, this.CertificacionId, this.Fecha));
               
               
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
                retorno = conexion.Ejecutar(String.Format("Update Lotes set Total={0}, CertificacionId = {2}, Fecha='{3}' where LoteId = {4}", this.Total,  this.CertificacionId, this.Fecha, this.LoteId));
                
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
                retorno = conexion.Ejecutar(String.Format("Delete from Lotes where LoteId={0}", this.LoteId));
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

            dt = conexion.getDatos(String.Format("select *from Lotes where LoteId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.LoteId = (int)dt.Rows[0]["LoteId"];
                this.CodigoLote = dt.Rows[0]["CodigoLote"].ToString();
                this.Total = (double)dt.Rows[0]["Total"];
                this.CertificacionId = (int)dt.Rows[0]["CertificacionId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                
            }

            return dt.Rows.Count > 0;


        }
        

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
             string ordenFinal = "";
             if (!Orden.Equals(""))
                 ordenFinal = " Orden By " + Orden;
             return conexion.getDatos(String.Format(" Select " + Campos + " From Lotes Where " + Condicion + " " + ordenFinal));
            
        }
    }
}  
