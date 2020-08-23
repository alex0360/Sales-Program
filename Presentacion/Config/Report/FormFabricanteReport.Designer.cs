namespace Presentacion.Config.Report
{
    partial class FormFabricanteReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Minimizar
            // 
            this.B_Minimizar.FlatAppearance.BorderSize = 0;
            this.B_Minimizar.Location = new System.Drawing.Point(716, 3);
            // 
            // B_Maximizar
            // 
            this.B_Maximizar.FlatAppearance.BorderSize = 0;
            this.B_Maximizar.Location = new System.Drawing.Point(759, 3);
            // 
            // B_Close
            // 
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.Location = new System.Drawing.Point(802, 3);
            // 
            // ReportViewer_Reporte
            // 
            this.ReportViewer_Reporte.ServerReport.BearerToken = null;
            this.ReportViewer_Reporte.Size = new System.Drawing.Size(845, 626);
            // 
            // FormFabricanteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 661);
            this.Name = "FormFabricanteReport";
            this.Text = "Reporte de Fabricante";
            this.P_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}