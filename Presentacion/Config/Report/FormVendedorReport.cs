using Presentacion.Config.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Config.Report
{
    public partial class FormVendedorReport : FormReport
    {
        public FormVendedorReport()
        {
            Report_Load();
        }

        protected override void Report_Load()
        {
            Negocios.VendedorReport reportModel = new Negocios.VendedorReport();

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new
                Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Vendedor", reportModel.CreateReport());

            ReportViewer_Reporte.LocalReport.ReportEmbeddedResource =
                "Presentacion.Config.Report.Report_Vendedor.rdlc";

            ReportViewer_Reporte.LocalReport.DataSources.Clear();
            ReportViewer_Reporte.LocalReport.DataSources.Add(reportDataSource);
            base.Report_Load();
        }
    }
}
