namespace Presentacion.Config.Forms
{
    partial class FormCliente
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
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.TB_Pais = new System.Windows.Forms.TextBox();
            this.L_Registros = new System.Windows.Forms.Label();
            this.IB_Buscar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Nombre.Location = new System.Drawing.Point(100, 12);
            this.TB_Nombre.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Nombre.MaxLength = 15;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(119, 28);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.Text = "   Nombre";
            this.TB_Nombre.Enter += new System.EventHandler(this.TB_Nombre_Enter);
            this.TB_Nombre.Leave += new System.EventHandler(this.TB_Nombre_Leave);
            // 
            // TB_ID
            // 
            this.TB_ID.BackColor = System.Drawing.SystemColors.Control;
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_ID.Location = new System.Drawing.Point(224, 11);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_ID.MaxLength = 15;
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(119, 28);
            this.TB_ID.TabIndex = 3;
            this.TB_ID.Text = "   Codigo";
            this.TB_ID.Enter += new System.EventHandler(this.TB_ID_Enter);
            this.TB_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ID_KeyPress);
            this.TB_ID.Leave += new System.EventHandler(this.TB_ID_Leave);
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Direccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Direccion.Location = new System.Drawing.Point(346, 11);
            this.TB_Direccion.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Direccion.MaxLength = 15;
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.Size = new System.Drawing.Size(119, 28);
            this.TB_Direccion.TabIndex = 4;
            this.TB_Direccion.Text = "   Direccion";
            this.TB_Direccion.Enter += new System.EventHandler(this.TB_Direccion_Enter);
            this.TB_Direccion.Leave += new System.EventHandler(this.TB_Direccion_Leave);
            // 
            // TB_Pais
            // 
            this.TB_Pais.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Pais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Pais.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Pais.Location = new System.Drawing.Point(469, 12);
            this.TB_Pais.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Pais.MaxLength = 15;
            this.TB_Pais.Name = "TB_Pais";
            this.TB_Pais.Size = new System.Drawing.Size(119, 28);
            this.TB_Pais.TabIndex = 5;
            this.TB_Pais.Text = "   Pais";
            this.TB_Pais.Enter += new System.EventHandler(this.TB_Pais_Enter);
            this.TB_Pais.Leave += new System.EventHandler(this.TB_Pais_Leave);
            // 
            // L_Registros
            // 
            this.L_Registros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_Registros.AutoSize = true;
            this.L_Registros.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.L_Registros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.L_Registros.Location = new System.Drawing.Point(12, 15);
            this.L_Registros.Name = "L_Registros";
            this.L_Registros.Size = new System.Drawing.Size(45, 21);
            this.L_Registros.TabIndex = 10;
            this.L_Registros.Text = "Hola";
            this.L_Registros.Visible = false;
            // 
            // IB_Buscar
            // 
            this.IB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Buscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IB_Buscar.IconColor = System.Drawing.Color.Black;
            this.IB_Buscar.IconSize = 32;
            this.IB_Buscar.Location = new System.Drawing.Point(594, 13);
            this.IB_Buscar.Name = "IB_Buscar";
            this.IB_Buscar.Rotation = 0D;
            this.IB_Buscar.Size = new System.Drawing.Size(62, 27);
            this.IB_Buscar.TabIndex = 6;
            this.IB_Buscar.UseVisualStyleBackColor = true;
            this.IB_Buscar.Click += new System.EventHandler(this.IB_Buscar_Click);
            this.IB_Buscar.Resize += new System.EventHandler(this.IB_Buscar_Resize);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 437);
            this.Controls.Add(this.IB_Buscar);
            this.Controls.Add(this.L_Registros);
            this.Controls.Add(this.TB_Pais);
            this.Controls.Add(this.TB_Direccion);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.TB_Nombre);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.Resize += new System.EventHandler(this.FormCliente_Resize);
            this.Controls.SetChildIndex(this.TB_Nombre, 0);
            this.Controls.SetChildIndex(this.TB_ID, 0);
            this.Controls.SetChildIndex(this.TB_Direccion, 0);
            this.Controls.SetChildIndex(this.TB_Pais, 0);
            this.Controls.SetChildIndex(this.L_Registros, 0);
            this.Controls.SetChildIndex(this.IB_Buscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.TextBox TB_Pais;
        private System.Windows.Forms.Label L_Registros;
        private FontAwesome.Sharp.IconButton IB_Buscar;
    }
}