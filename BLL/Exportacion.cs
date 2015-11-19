using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Exportacion : ClaseMaestra
    {

    
        public int ExportacionId { get; set; }
        public int DestinoId { get; set; }
        public double CantidadToneladas { get; set; }
        public int Certificacion { get; set; }
        public string Fecha { get; set; }
        public int LoteId { get; set; }
        public string Resumen { get; set; }

        public override bool Insertar()
        {
            throw new NotImplementedException();
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
