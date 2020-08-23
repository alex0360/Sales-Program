namespace Presentacion.Config.Forms
{
    partial class FormVendedorInsUp
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
            this.TB_Comision = new System.Windows.Forms.TextBox();
            this.TB_Oficina = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.Timer_Error = new System.Windows.Forms.Timer(this.components);
            this.Panel_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconButton_Cerrar
            // 
            this.IconButton_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // IconButton_Limpiar
            // 
            this.IconButton_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // IconButton_Guardar
            // 
            this.IconButton_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // TB_Comision
            // 
            this.TB_Comision.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Comision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Comision.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Comision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Comision.Location = new System.Drawing.Point(22, 168);
            this.TB_Comision.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Comision.MaxLength = 8;
            this.TB_Comision.Name = "TB_Comision";
            this.TB_Comision.Size = new System.Drawing.Size(194, 28);
            this.TB_Comision.TabIndex = 11;
            this.TB_Comision.Text = "   Comision";
            this.TB_Comision.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Comision.Enter += new System.EventHandler(this.TB_Comision_Enter);
            this.TB_Comision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_Comision.Leave += new System.EventHandler(this.TB_Comision_Leave);
            // 
            // TB_Oficina
            // 
            this.TB_Oficina.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Oficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Oficina.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Oficina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Oficina.Location = new System.Drawing.Point(22, 132);
            this.TB_Oficina.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Oficina.MaxLength = 60;
            this.TB_Oficina.Name = "TB_Oficina";
            this.TB_Oficina.Size = new System.Drawing.Size(401, 28);
            this.TB_Oficina.TabIndex = 8;
            this.TB_Oficina.Text = "   Oficina";
            this.TB_Oficina.Enter += new System.EventHandler(this.TB_Oficina_Enter);
            this.TB_Oficina.Leave += new System.EventHandler(this.TB_Oficina_Leave);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Nombre.Location = new System.Drawing.Point(22, 96);
            this.TB_Nombre.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Nombre.MaxLength = 45;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(194, 28);
            this.TB_Nombre.TabIndex = 7;
            this.TB_Nombre.Text = "   Nombre";
            this.TB_Nombre.Enter += new System.EventHandler(this.TB_Nombre_Enter);
            this.TB_Nombre.Leave += new System.EventHandler(this.TB_Nombre_Leave);
            // 
            // Timer_Error
            // 
            this.Timer_Error.Interval = 2000;
            // 
            // FormVendedorInsUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Controls.Add(this.TB_Comision);
            this.Controls.Add(this.TB_Oficina);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "FormVendedorInsUp";
            this.Text = "FormVendedorInsUp";
            this.Controls.SetChildIndex(this.Panel_Titulo, 0);
            this.Controls.SetChildIndex(this.TB_Nombre, 0);
            this.Controls.SetChildIndex(this.TB_Oficina, 0);
            this.Controls.SetChildIndex(this.TB_Comision, 0);
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Comision;
        private System.Windows.Forms.TextBox TB_Oficina;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Timer Timer_Error;
    }
}