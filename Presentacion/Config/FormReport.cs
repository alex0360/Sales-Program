using System;
using System.Windows.Forms;

namespace Presentacion.Config.Forms
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        protected virtual void FormReport_Load(object sender, EventArgs e)
        {

        }

        protected virtual void Report_Load()
        {
            this.ReportViewer_Reporte.RefreshReport();
        }
        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Minimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void B_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
