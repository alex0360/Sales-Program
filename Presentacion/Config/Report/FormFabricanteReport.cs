using Presentacion.Config.Forms;

namespace Presentacion.Config.Report
{
    public partial class FormFabricanteReport : FormReport
    {
        public FormFabricanteReport()
        {
            InitializeComponent();
            Report_Load();
        }

        protected override void Report_Load()
        {
            Negocios.FabricanteReport reportModel = new Negocios.FabricanteReport();

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new
                Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Fabricante", reportModel.CreateReport());

            ReportViewer_Reporte.LocalReport.ReportEmbeddedResource =
                "Presentacion.Config.Report.Report_Fabricante.rdlc";

            ReportViewer_Reporte.LocalReport.DataSources.Clear();
            ReportViewer_Reporte.LocalReport.DataSources.Add(reportDataSource);
            base.Report_Load();
        }
    }
}
