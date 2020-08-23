namespace Presentacion.Config.Forms
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.P_Titulo = new System.Windows.Forms.Panel();
            this.B_Minimizar = new System.Windows.Forms.Button();
            this.B_Maximizar = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.ReportViewer_Reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.P_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Titulo
            // 
            this.P_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.P_Titulo.Controls.Add(this.B_Minimizar);
            this.P_Titulo.Controls.Add(this.B_Maximizar);
            this.P_Titulo.Controls.Add(this.B_Close);
            this.P_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Titulo.Location = new System.Drawing.Point(0, 0);
            this.P_Titulo.Name = "P_Titulo";
            this.P_Titulo.Size = new System.Drawing.Size(845, 35);
            this.P_Titulo.TabIndex = 2;
            // 
            // B_Minimizar
            // 
            this.B_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Minimizar.FlatAppearance.BorderSize = 0;
            this.B_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Minimizar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Minimizar.ForeColor = System.Drawing.Color.Black;
            this.B_Minimizar.Location = new System.Drawing.Point(719, 3);
            this.B_Minimizar.Name = "B_Minimizar";
            this.B_Minimizar.Size = new System.Drawing.Size(37, 29);
            this.B_Minimizar.TabIndex = 1;
            this.B_Minimizar.Text = "-";
            this.B_Minimizar.UseVisualStyleBackColor = true;
            this.B_Minimizar.Click += new System.EventHandler(this.B_Minimizar_Click);
            // 
            // B_Maximizar
            // 
            this.B_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Maximizar.FlatAppearance.BorderSize = 0;
            this.B_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Maximizar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Maximizar.ForeColor = System.Drawing.Color.Black;
            this.B_Maximizar.Location = new System.Drawing.Point(762, 3);
            this.B_Maximizar.Name = "B_Maximizar";
            this.B_Maximizar.Size = new System.Drawing.Size(37, 29);
            this.B_Maximizar.TabIndex = 1;
            this.B_Maximizar.Text = "O";
            this.B_Maximizar.UseVisualStyleBackColor = true;
            this.B_Maximizar.Click += new System.EventHandler(this.B_Maximizar_Click);
            // 
            // B_Close
            // 
            this.B_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Close.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.Black;
            this.B_Close.Location = new System.Drawing.Point(805, 3);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(37, 29);
            this.B_Close.TabIndex = 1;
            this.B_Close.Text = "X";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // ReportViewer_Reporte
            // 
            this.ReportViewer_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer_Reporte.Location = new System.Drawing.Point(0, 35);
            this.ReportViewer_Reporte.Name = "ReportViewer_Reporte";
            this.ReportViewer_Reporte.ServerReport.BearerToken = null;
            this.ReportViewer_Reporte.Size = new System.Drawing.Size(845, 649);
            this.ReportViewer_Reporte.TabIndex = 3;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(845, 684);
            this.ControlBox = false;
            this.Controls.Add(this.ReportViewer_Reporte);
            this.Controls.Add(this.P_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(861, 700);
            this.Name = "FormReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Report";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.P_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel P_Titulo;
        protected System.Windows.Forms.Button B_Minimizar;
        protected System.Windows.Forms.Button B_Maximizar;
        protected System.Windows.Forms.Button B_Close;
        protected Microsoft.Reporting.WinForms.ReportViewer ReportViewer_Reporte;
    }
}