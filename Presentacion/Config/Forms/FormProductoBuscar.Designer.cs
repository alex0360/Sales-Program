namespace Presentacion.Config.Forms
{
    partial class FormProductoBuscar
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
            this.Panel_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconButton_Codigo
            // 
            this.IconButton_Codigo.Location = new System.Drawing.Point(198, 76);
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.Location = new System.Drawing.Point(73, 75);
            this.TextBox_Buscar.Text = "";
            this.TextBox_Buscar.TextChanged += new System.EventHandler(this.TextBox_Buscar_TextChanged);
            // 
            // IconButton_Cerrar
            // 
            this.IconButton_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // FormProductoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Name = "FormProductoBuscar";
            this.Text = "FormProductoBuscar";
            this.Load += new System.EventHandler(this.FormProductoBuscar_Load);
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}