using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Recepcion : ClaseMaestra
    {
        Conexion conexion = new Conexion();

        public int RecepcionId { get; set; }
        public string CodigoLote { get; set; }
        public int SocioId { get; set; }
        public int LoteId { get; set; }
        public int CertificacionId { get; set; }
        public int TipoCacaoId { get; set; }
        public string Fecha { get; set; }
        public double CantidadPesada { get; set; }
        public string Observacion { get; set; }
        public string RecibidoPor { get; set; }

        public Recepcion()
        {
            this.RecepcionId = 0;
            this.CodigoLote = "";
            this.SocioId = 0;
            this.LoteId = 0;
            this.CertificacionId = 0;
            this.TipoCacaoId = 0;
            this.Fecha = "";
            this.CantidadPesada = 0;
            this.Observacion = "";
            this.RecibidoPor = "";
        }

        public Recepcion(int RecepcionId, int CertificacionId, string Fecha, double CantidadPesada, string Observacion)
        {
            this.RecepcionId = RecepcionId;
            
            this.CertificacionId = CertificacionId;
            this.TipoCacaoId = TipoCacaoId;
            this.Fecha = Fecha;
            this.CantidadPesada = CantidadPesada;
            this.Observacion = Observacion;
            

        }
        public override bool Insertar()
                {
                    bool retorno = false;
                    try
                    {
                        retorno = conexion.Ejecutar(String.Format("insert into Recepcionnes(socioId, CodigoLote, LoteId, CertificacionId, TipoCacaoId, Fecha, CantidadesPesada, Observacion, RecibidoPor) values({0}, '{1}',{2}, {3}, {4}, '{5}', {6}, '{7}','{8}')", this.SocioId,this.CodigoLote,  this.LoteId, this.CertificacionId, this.TipoCacaoId, this.Fecha, this.CantidadPesada, this.Observacion, this.RecibidoPor));
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
                retorno = conexion.Ejecutar(String.Format("Update Recepciones set SocioId={0}, CertificacionId = {1}, TipoCacaoId={2}, Fecha = '{3}', CantidadPesada={4}, Observacion='{5}', RecibidoPor='{6}' where RecepcionId={7}", this.SocioId, this.CertificacionId, this.TipoCacaoId, this.Fecha, this.CantidadPesada, this.Observacion, this.RecibidoPor, this.RecepcionId));
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
                retorno = conexion.Ejecutar(String.Format("delete from Recepciones where RecepcionId = {0}", this.RecepcionId));
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

            dt = conexion.getDatos(String.Format("select *Recepciones Lotes where RecepcionId= {0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.RecepcionId= (int)dt.Rows[0]["RecepcionId"];
                this.SocioId = (int)dt.Rows[0]["SocioId"];
                this.CertificacionId = (int)dt.Rows[0]["CertificacionId"];
                this.TipoCacaoId = (int)dt.Rows[0]["TipoCacaoId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.CantidadPesada = (double)dt.Rows[0]["CantidadPesada"];
                this.Observacion = dt.Rows[0]["Observacion"].ToString();
                this.RecibidoPor = dt.Rows[0]["RecibidoPor"].ToString();

            }

            return dt.Rows.Count > 0;
        }
       
        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = " ";
            if (!Orden.Equals(""))
                ordenFinal = " Orden By " + Orden;


            return conexion.getDatos(" Select " + Campos + " from Recepciones where "+Condicion+ordenFinal);
        }
    }
}
