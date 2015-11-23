using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Exportacion : ClaseMaestra
    {
        Conexion conexion = new Conexion();

        public int ExportacionId { get; set; }
        public int DestinoId { get; set; }
        public int LoteId { get; set; }
        public int CertificacionId { get; set; }
        public double CantidadToneladas { get; set; }
        public string Fecha { get; set; }
        public string Resumen { get; set; }

        public List<Lotes>Lotes{ set; get;}
    public Exportacion()
        {
            this.ExportacionId = 0;
            this.DestinoId = 0;
            this.CantidadToneladas = 0;
            this.CertificacionId = 0;
            this.Fecha = "";
            this.LoteId = 0;
            this.Resumen = "";
            Lotes = new List<BLL.Lotes>();
        }
        public void AgregarLotes(int LoteId, string CodigoLote)
        {
            this.Lotes.Add(new Lotes(LoteId, CodigoLote));
        }

        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert into Exportaciones(DestinoId, CantidadToneladas, CertificacionId, Fecha, Resumen) values({0}, {1}, {2}, '{3}', '{4}')", this.DestinoId, this.CantidadToneladas, this.CertificacionId, this.Fecha, this.Resumen));
                if (retorno) 
                {
                        this.ExportacionId = (int)conexion.getDatos("Select Max(ExportacionId) as ExportacionId from Exportaciones").Rows[0]["ExportacionId"];
                    foreach (var lote in this.Lotes)
                    {
                        Comando.AppendLine(String.Format("Insert Into LotesExportes (LoteId, ExportacionId, CodigoLote) Values({0},{1},'{2}')",lote.LoteId,this.ExportacionId, lote.CodigoLote));
                    }
                    retorno = conexion.Ejecutar(Comando.ToString());
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }
        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }
        
        public override DataTable Listar(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
