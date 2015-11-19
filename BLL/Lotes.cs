using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    class Lotes : ClaseMaestra
    {
        Conexion conexion = new Conexion();

        public int LoteId { get; set; }
        public double Total { get; set; }
        public int RecepcionId { get; set; }
        public int CertificacionId { get; set; }
        public string Fecha { get; set; }

        public List<Recepcion>recepcion { get; set; }
        public List<Certificaciones> Certificacion { get; set; }

        public Lotes()
        {
            this.LoteId = 0;
            this.Total = 0;
            this.RecepcionId = 0;
            this.CertificacionId = 0;
            this.Fecha = "";
            recepcion = new List<Recepcion>();
            Certificacion = new List<Certificaciones>();
        }
        public void AgregarRecepcion(int RecepcionId, int CertificacionId, string Fecha, double CantidadPesada, string Observacion)
        {
            this.recepcion.Add(new Recepcion(RecepcionId, CertificacionId, Fecha, CantidadPesada, Observacion));
        }

        public void AgregarCertificacion(int CertificacionId, string Descripcion)
        {
            this.Certificacion.Add(new Certificaciones(CertificacionId, Descripcion));
        }

        public override bool Insertar()
        {
            StringBuilder comando = new StringBuilder();
           
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Lotes(Total, RecepcionId, CertificacionId, Fecha) values({0}, {1}, {2}, '{4}')", this.Total, this.RecepcionId, this.CertificacionId, this.Fecha));
                if (retorno)
                {
                    this.LoteId = (int)conexion.getDatos("Select Max(LoteId) as LoteId from Lotes").Rows[0]["LoteId"];
                    foreach (var Recepcion in this.recepcion)
                    {
                        comando.AppendLine(String.Format("Insert Into RecepcionLotes (RecepcionId, CertificacionId, Fecha, CantidadesPesada, Observacion) values({0}, {1}, '{2}', {3}, '{4}'); ", Recepcion.RecepcionId, Recepcion.CertificacionId, Recepcion.Fecha, Recepcion.CantidadPesada, Recepcion.Observacion));

                    }

                    foreach (var Certificacion in this.Certificacion)
                    {
                        comando.AppendLine(String.Format("Insert into CertificacionLotes(CertificacionId, Descripcion) values ({0}, '{1}')", Certificacion.CertificacionID, Certificacion.Descripcion));
                    }

                    retorno = conexion.Ejecutar(comando.ToString());
                    
                }
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public override bool Editar()
        {
            StringBuilder comando = new StringBuilder();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Lotes set Total={0}, RecepcionId = {1}, CertificacionId = {2}, Fecha='{3}' where LoteId = {4}", this.Total, this.RecepcionId, this.CertificacionId, this.Fecha, this.LoteId));
                if (retorno)
                {
                    conexion.Ejecutar("Delete From Lotes Where LotesId =" + this.LoteId);
                    foreach (var Recepcion in this.recepcion)
                    {
                        comando.AppendLine(String.Format("Insert Into RecepcionLotes (RecepcionId, CertificacionId, Fecha, CantidadesPesada, Observacion) values({0}, {1}, '{2}', {3}, '{4}'); ", Recepcion.RecepcionId, Recepcion.CertificacionId, Recepcion.Fecha, Recepcion.CantidadPesada, Recepcion.Observacion));
                    }

                    foreach (var Certificacion in this.Certificacion)
                    {
                        comando.AppendLine(String.Format("Insert into CertificacionLotes (CertificacionId, Descripcion) values({0}, '{1}')", Certificacion.CertificacionID, Certificacion.Descripcion));
                    }
                    retorno = conexion.Ejecutar(comando.ToString());
                }
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
                retorno = conexion.Ejecutar(String.Format("Delete From Lotes where LoteId={0}", this.LoteId,";"+
                    "Delete from RecepcionLote where RecepcionId={0}", this.RecepcionId,";" + "Delete from CertificacionLote where CertificacionId={0}", this.CertificacionId));
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

            dt = conexion.getDatos(String.Format("select *from Lotes where SocioId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.LoteId = (int)dt.Rows[0]["LotesId"];
                this.Total = (double)dt.Rows[0]["Total"];
                this.RecepcionId = (int)dt.Rows[0]["RecepcionId"];
                this.CertificacionId = (int)dt.Rows[0]["CertificacionId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                
            }

            return dt.Rows.Count > 0;


        }

        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = " ";
            if (Orden == "")
                ordenFinal = " Orden By " + Orden;


            return conexion.getDatos("Select " + Campos + " from Lotes where " + Condicion + ordenFinal);
        }
    }
        
    }
