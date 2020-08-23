namespace Presentacion.Config.Forms.Report
{
    partial class FormClienteReport
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
            this.components = new System.ComponentModel.Container();
            this.ClienteReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.P_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Minimizar
            // 
            this.B_Minimizar.FlatAppearance.BorderSize = 0;
            this.B_Minimizar.Location = new System.Drawing.Point(710, 3);
            // 
            // B_Maximizar
            // 
            this.B_Maximizar.FlatAppearance.BorderSize = 0;
            this.B_Maximizar.Location = new System.Drawing.Point(753, 3);
            // 
            // B_Close
            // 
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.Location = new System.Drawing.Point(796, 3);
            // 
            // ClienteReportBindingSource
            // 
            this.ClienteReportBindingSource.DataMember = "clientes";
            this.ClienteReportBindingSource.DataSource = typeof(Negocios.ClienteReport);
            // 
            // FormClienteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 661);
            this.Name = "FormClienteReport";
            this.Text = "Reportes de Clientes";
            this.Load += new System.EventHandler(this.FormClienteReport_Load);
            this.P_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ClienteReportBindingSource;
    }
}