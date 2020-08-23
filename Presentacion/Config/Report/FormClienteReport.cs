using Microsoft.Reporting.WinForms;
using System;

namespace Presentacion.Config.Forms.Report
{
    public partial class FormClienteReport : FormReport
    {
        public FormClienteReport()
        {
            InitializeComponent();
        }

        private void FormClienteReport_Load(object sender, EventArgs e)
        {
            Report_Load();
        }

        protected override void Report_Load()
        {
            Negocios.ClienteReport reportModel = new Negocios.ClienteReport();

            ReportDataSource reportDataSource = new ReportDataSource("DataSet_Cliente", reportModel.CreateReport());

            ReportViewer_Reporte.LocalReport.ReportEmbeddedResource =
                "Presentacion.Config.Report.Report_Cliente.rdlc";

            ReportViewer_Reporte.LocalReport.DataSources.Clear();
            ReportViewer_Reporte.LocalReport.DataSources.Add(reportDataSource);
            base.Report_Load();
        }
    }
}
