namespace Presentacion.Config.Forms
{
    partial class FormFabricanteInsUp
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
            this.Timer_Error = new System.Windows.Forms.Timer(this.components);
            this.TB_Pais = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
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
            this.IconButton_Limpiar.Click += new System.EventHandler(this.IconButton_Clear_Click);
            // 
            // IconButton_Guardar
            // 
            this.IconButton_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Guardar.Click += new System.EventHandler(this.IconButton_Guardar_Click);
            // 
            // Timer_Error
            // 
            this.Timer_Error.Interval = 2000;
            // 
            // TB_Pais
            // 
            this.TB_Pais.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Pais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Pais.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Pais.Location = new System.Drawing.Point(3, 160);
            this.TB_Pais.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Pais.MaxLength = 20;
            this.TB_Pais.Name = "TB_Pais";
            this.TB_Pais.Size = new System.Drawing.Size(401, 28);
            this.TB_Pais.TabIndex = 9;
            this.TB_Pais.Text = "   Pais";
            this.TB_Pais.Enter += new System.EventHandler(this.TB_Pais_Enter);
            this.TB_Pais.Leave += new System.EventHandler(this.TB_Pais_Leave);
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Direccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Direccion.Location = new System.Drawing.Point(3, 124);
            this.TB_Direccion.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Direccion.MaxLength = 60;
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(401, 28);
            this.TB_Direccion.TabIndex = 8;
            this.TB_Direccion.Text = "   Direccion";
            this.TB_Direccion.Enter += new System.EventHandler(this.TB_Direccion_Enter);
            this.TB_Direccion.Leave += new System.EventHandler(this.TB_Direccion_Leave);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Nombre.Location = new System.Drawing.Point(3, 88);
            this.TB_Nombre.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Nombre.MaxLength = 45;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(194, 28);
            this.TB_Nombre.TabIndex = 7;
            this.TB_Nombre.Text = "   Nombre";
            this.TB_Nombre.Enter += new System.EventHandler(this.TB_Nombre_Enter);
            this.TB_Nombre.Leave += new System.EventHandler(this.TB_Nombre_Leave);
            // 
            // FormFabricanteInsUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Controls.Add(this.TB_Pais);
            this.Controls.Add(this.TB_Direccion);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "FormFabricanteInsUp";
            this.Text = "FormFabricanteInsUp";
            this.Controls.SetChildIndex(this.Panel_Titulo, 0);
            this.Controls.SetChildIndex(this.TB_Nombre, 0);
            this.Controls.SetChildIndex(this.TB_Direccion, 0);
            this.Controls.SetChildIndex(this.TB_Pais, 0);
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer_Error;
        private System.Windows.Forms.TextBox TB_Pais;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.TextBox TB_Nombre;
    }
}