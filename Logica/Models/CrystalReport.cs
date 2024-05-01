using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class CrystalReport
    {
        public  ReportDocument Reporte {  get; set; }   
        public DataTable dt {  get; set; }

        public CrystalReport(ReportDocument pRpt)
        {
            Reporte = pRpt;
        }

        public ReportDocument GenerarReporte()
        {
            if (dt.Rows.Count > 0)
            {
                Reporte.SetDataSource(dt);

                return Reporte;
            }
            else
            { return null; }
        }



    }


}
