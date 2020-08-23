namespace Presentacion.Config.Forms
{
    partial class FormClienteInsUp
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
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Pais = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.TB_SaldoInicial = new System.Windows.Forms.TextBox();
            this.TB_SaldoActual = new System.Windows.Forms.TextBox();
            this.CheckBox_Estatus = new System.Windows.Forms.CheckBox();
            this.Timer_Error = new System.Windows.Forms.Timer(this.components);
            this.Panel_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconButton_Cerrar
            // 
            this.IconButton_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Cerrar.Click += new System.EventHandler(this.IconButton_Cerrar_Click);
            // 
            // IconButton_Limpiar
            // 
            this.IconButton_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Limpiar.TabIndex = 8;
            this.IconButton_Limpiar.Click += new System.EventHandler(this.IconButton_Clear_Click);
            // 
            // IconButton_Guardar
            // 
            this.IconButton_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Guardar.TabIndex = 9;
            this.IconButton_Guardar.Click += new System.EventHandler(this.IconButton_Guardar_Click);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Nombre.Location = new System.Drawing.Point(3, 109);
            this.TB_Nombre.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Nombre.MaxLength = 45;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(194, 28);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.Text = "   Nombre";
            this.TB_Nombre.Enter += new System.EventHandler(this.TB_Nombre_Enter);
            this.TB_Nombre.Leave += new System.EventHandler(this.TB_Nombre_Leave);
            // 
            // TB_Pais
            // 
            this.TB_Pais.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Pais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Pais.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Pais.Location = new System.Drawing.Point(3, 181);
            this.TB_Pais.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Pais.MaxLength = 20;
            this.TB_Pais.Name = "TB_Pais";
            this.TB_Pais.Size = new System.Drawing.Size(401, 28);
            this.TB_Pais.TabIndex = 4;
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
            this.TB_Direccion.Location = new System.Drawing.Point(3, 145);
            this.TB_Direccion.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Direccion.MaxLength = 60;
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(401, 28);
            this.TB_Direccion.TabIndex = 3;
            this.TB_Direccion.Text = "   Direccion";
            this.TB_Direccion.Enter += new System.EventHandler(this.TB_Direccion_Enter);
            this.TB_Direccion.Leave += new System.EventHandler(this.TB_Direccion_Leave);
            // 
            // TB_SaldoInicial
            // 
            this.TB_SaldoInicial.BackColor = System.Drawing.SystemColors.Control;
            this.TB_SaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_SaldoInicial.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SaldoInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_SaldoInicial.Location = new System.Drawing.Point(3, 217);
            this.TB_SaldoInicial.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_SaldoInicial.MaxLength = 8;
            this.TB_SaldoInicial.Name = "TB_SaldoInicial";
            this.TB_SaldoInicial.Size = new System.Drawing.Size(194, 28);
            this.TB_SaldoInicial.TabIndex = 5;
            this.TB_SaldoInicial.Text = "   Saldo Inicial";
            this.TB_SaldoInicial.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_SaldoInicial.Enter += new System.EventHandler(this.TB_SaldoInicial_Enter);
            this.TB_SaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_SaldoInicial.Leave += new System.EventHandler(this.TB_SaldoInicial_Leave);
            // 
            // TB_SaldoActual
            // 
            this.TB_SaldoActual.BackColor = System.Drawing.SystemColors.Control;
            this.TB_SaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_SaldoActual.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SaldoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_SaldoActual.Location = new System.Drawing.Point(3, 253);
            this.TB_SaldoActual.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_SaldoActual.MaxLength = 8;
            this.TB_SaldoActual.Name = "TB_SaldoActual";
            this.TB_SaldoActual.Size = new System.Drawing.Size(194, 28);
            this.TB_SaldoActual.TabIndex = 6;
            this.TB_SaldoActual.Text = "   Saldo Actual";
            this.TB_SaldoActual.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_SaldoActual.Enter += new System.EventHandler(this.TB_SaldoActual_Enter);
            this.TB_SaldoActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_SaldoActual.Leave += new System.EventHandler(this.TB_SaldoActual_Leave);
            // 
            // CheckBox_Estatus
            // 
            this.CheckBox_Estatus.AutoSize = true;
            this.CheckBox_Estatus.Checked = true;
            this.CheckBox_Estatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Estatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_Estatus.Location = new System.Drawing.Point(3, 299);
            this.CheckBox_Estatus.Name = "CheckBox_Estatus";
            this.CheckBox_Estatus.Size = new System.Drawing.Size(96, 29);
            this.CheckBox_Estatus.TabIndex = 7;
            this.CheckBox_Estatus.Text = "Estatus";
            this.CheckBox_Estatus.UseVisualStyleBackColor = true;
            // 
            // Timer_Error
            // 
            this.Timer_Error.Interval = 2000;
            this.Timer_Error.Tick += new System.EventHandler(this.Timer_Error_Tick);
            // 
            // FormClienteInsUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Controls.Add(this.CheckBox_Estatus);
            this.Controls.Add(this.TB_SaldoActual);
            this.Controls.Add(this.TB_SaldoInicial);
            this.Controls.Add(this.TB_Pais);
            this.Controls.Add(this.TB_Direccion);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "FormClienteInsUp";
            this.Text = "FormClienteInsUp";
            this.Controls.SetChildIndex(this.Panel_Titulo, 0);
            this.Controls.SetChildIndex(this.TB_Nombre, 0);
            this.Controls.SetChildIndex(this.TB_Direccion, 0);
            this.Controls.SetChildIndex(this.TB_Pais, 0);
            this.Controls.SetChildIndex(this.TB_SaldoInicial, 0);
            this.Controls.SetChildIndex(this.TB_SaldoActual, 0);
            this.Controls.SetChildIndex(this.CheckBox_Estatus, 0);
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Pais;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.TextBox TB_SaldoInicial;
        private System.Windows.Forms.TextBox TB_SaldoActual;
        private System.Windows.Forms.CheckBox CheckBox_Estatus;
        private System.Windows.Forms.Timer Timer_Error;
    }
}