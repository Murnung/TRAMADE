using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMADE.Clases_Reporte
{
    internal class clsReportItem
    {
        public string TipoReporte { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdSucursal { get; set; }
    }
}
