namespace Presentacion.Config.Forms
{
    partial class FormProducto
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
            this.IB_Buscar = new FontAwesome.Sharp.IconButton();
            this.L_Registros = new System.Windows.Forms.Label();
            this.TB_Descripcion = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Fabricante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IB_Buscar
            // 
            this.IB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Buscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IB_Buscar.IconColor = System.Drawing.Color.Black;
            this.IB_Buscar.IconSize = 32;
            this.IB_Buscar.Location = new System.Drawing.Point(579, 14);
            this.IB_Buscar.Name = "IB_Buscar";
            this.IB_Buscar.Rotation = 0D;
            this.IB_Buscar.Size = new System.Drawing.Size(62, 27);
            this.IB_Buscar.TabIndex = 21;
            this.IB_Buscar.UseVisualStyleBackColor = true;
            this.IB_Buscar.Click += new System.EventHandler(this.IB_Buscar_Click);
            this.IB_Buscar.Resize += new System.EventHandler(this.IB_Buscar_Resize);
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
            this.L_Registros.TabIndex = 22;
            this.L_Registros.Text = "Hola";
            this.L_Registros.Visible = false;
            // 
            // TB_Descripcion
            // 
            this.TB_Descripcion.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Descripcion.Location = new System.Drawing.Point(196, 13);
            this.TB_Descripcion.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Descripcion.MaxLength = 15;
            this.TB_Descripcion.Name = "TB_Descripcion";
            this.TB_Descripcion.Size = new System.Drawing.Size(119, 28);
            this.TB_Descripcion.TabIndex = 19;
            this.TB_Descripcion.Text = "   Descripcion";
            this.TB_Descripcion.Enter += new System.EventHandler(this.TB_Descripcion_Enter);
            this.TB_Descripcion.Leave += new System.EventHandler(this.TB_Descripcion_Leave);
            // 
            // TB_ID
            // 
            this.TB_ID.BackColor = System.Drawing.SystemColors.Control;
            this.TB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_ID.Location = new System.Drawing.Point(322, 13);
            this.TB_ID.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_ID.MaxLength = 15;
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(119, 28);
            this.TB_ID.TabIndex = 18;
            this.TB_ID.Text = "   Codigo";
            this.TB_ID.Enter += new System.EventHandler(this.TB_ID_Enter);
            this.TB_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ID_KeyPress);
            this.TB_ID.Leave += new System.EventHandler(this.TB_ID_Leave);
            // 
            // TB_Fabricante
            // 
            this.TB_Fabricante.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Fabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Fabricante.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Fabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Fabricante.Location = new System.Drawing.Point(445, 13);
            this.TB_Fabricante.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Fabricante.MaxLength = 15;
            this.TB_Fabricante.Name = "TB_Fabricante";
            this.TB_Fabricante.Size = new System.Drawing.Size(119, 28);
            this.TB_Fabricante.TabIndex = 17;
            this.TB_Fabricante.Text = "   Fabricante";
            this.TB_Fabricante.Enter += new System.EventHandler(this.TB_Fabricante_Enter);
            this.TB_Fabricante.Leave += new System.EventHandler(this.TB_Fabricante_Leave);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 437);
            this.Controls.Add(this.IB_Buscar);
            this.Controls.Add(this.L_Registros);
            this.Controls.Add(this.TB_Descripcion);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.TB_Fabricante);
            this.Name = "FormProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.Controls.SetChildIndex(this.TB_Fabricante, 0);
            this.Controls.SetChildIndex(this.TB_ID, 0);
            this.Controls.SetChildIndex(this.TB_Descripcion, 0);
            this.Controls.SetChildIndex(this.L_Registros, 0);
            this.Controls.SetChildIndex(this.IB_Buscar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton IB_Buscar;
        private System.Windows.Forms.Label L_Registros;
        private System.Windows.Forms.TextBox TB_Descripcion;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Fabricante;
    }
}