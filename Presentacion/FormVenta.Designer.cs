namespace Presentacion
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.TextBox_Vendedor = new System.Windows.Forms.TextBox();
            this.Label_Vendedor = new System.Windows.Forms.Label();
            this.TextBox_Cliente = new System.Windows.Forms.TextBox();
            this.Label_Cliente = new System.Windows.Forms.Label();
            this.IconButton_Cliente = new FontAwesome.Sharp.IconButton();
            this.IconButton_Vendedor = new FontAwesome.Sharp.IconButton();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.TextBox_Codigo = new System.Windows.Forms.TextBox();
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.IconButton_Codigo = new FontAwesome.Sharp.IconButton();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Label_Existencia = new System.Windows.Forms.Label();
            this.TextBox_Cantidad = new System.Windows.Forms.TextBox();
            this.Label_Cantidad = new System.Windows.Forms.Label();
            this.Label_MostrarPrecio = new System.Windows.Forms.Label();
            this.Label_TotalPagar = new System.Windows.Forms.Label();
            this.Label_MostrarTotalPagar = new System.Windows.Forms.Label();
            this.IconButton_Procesar = new FontAwesome.Sharp.IconButton();
            this.IconButton_Add = new FontAwesome.Sharp.IconButton();
            this.IconButton_Menos = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.Label_Titulo.Location = new System.Drawing.Point(13, 13);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(103, 25);
            this.Label_Titulo.TabIndex = 0;
            this.Label_Titulo.Text = "Generales";
            // 
            // TextBox_Vendedor
            // 
            this.TextBox_Vendedor.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Vendedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Vendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TextBox_Vendedor.Location = new System.Drawing.Point(97, 42);
            this.TextBox_Vendedor.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TextBox_Vendedor.MaxLength = 15;
            this.TextBox_Vendedor.Name = "TextBox_Vendedor";
            this.TextBox_Vendedor.Size = new System.Drawing.Size(119, 28);
            this.TextBox_Vendedor.TabIndex = 26;
            // 
            // Label_Vendedor
            // 
            this.Label_Vendedor.AutoSize = true;
            this.Label_Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Vendedor.Location = new System.Drawing.Point(14, 45);
            this.Label_Vendedor.Name = "Label_Vendedor";
            this.Label_Vendedor.Size = new System.Drawing.Size(79, 20);
            this.Label_Vendedor.TabIndex = 27;
            this.Label_Vendedor.Text = "Vendedor";
            // 
            // TextBox_Cliente
            // 
            this.TextBox_Cliente.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Cliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TextBox_Cliente.Location = new System.Drawing.Point(408, 41);
            this.TextBox_Cliente.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TextBox_Cliente.MaxLength = 15;
            this.TextBox_Cliente.Name = "TextBox_Cliente";
            this.TextBox_Cliente.Size = new System.Drawing.Size(119, 28);
            this.TextBox_Cliente.TabIndex = 26;
            // 
            // Label_Cliente
            // 
            this.Label_Cliente.AutoSize = true;
            this.Label_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Cliente.Location = new System.Drawing.Point(350, 44);
            this.Label_Cliente.Name = "Label_Cliente";
            this.Label_Cliente.Size = new System.Drawing.Size(58, 20);
            this.Label_Cliente.TabIndex = 27;
            this.Label_Cliente.Text = "Cliente";
            // 
            // IconButton_Cliente
            // 
            this.IconButton_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Cliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Cliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IconButton_Cliente.IconColor = System.Drawing.Color.Black;
            this.IconButton_Cliente.IconSize = 32;
            this.IconButton_Cliente.Location = new System.Drawing.Point(533, 41);
            this.IconButton_Cliente.Name = "IconButton_Cliente";
            this.IconButton_Cliente.Rotation = 0D;
            this.IconButton_Cliente.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Cliente.TabIndex = 28;
            this.IconButton_Cliente.UseVisualStyleBackColor = true;
            this.IconButton_Cliente.Click += new System.EventHandler(this.IconButton_Cliente_Click);
            this.IconButton_Cliente.Resize += new System.EventHandler(this.IconButton_Vendedor_Cliente_Codigo_Resize);
            // 
            // IconButton_Vendedor
            // 
            this.IconButton_Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Vendedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Vendedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IconButton_Vendedor.IconColor = System.Drawing.Color.Black;
            this.IconButton_Vendedor.IconSize = 32;
            this.IconButton_Vendedor.Location = new System.Drawing.Point(222, 42);
            this.IconButton_Vendedor.Name = "IconButton_Vendedor";
            this.IconButton_Vendedor.Rotation = 0D;
            this.IconButton_Vendedor.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Vendedor.TabIndex = 28;
            this.IconButton_Vendedor.UseVisualStyleBackColor = true;
            this.IconButton_Vendedor.Click += new System.EventHandler(this.IconButton_Vendedor_Click);
            this.IconButton_Vendedor.Resize += new System.EventHandler(this.IconButton_Vendedor_Cliente_Codigo_Resize);
            // 
            // DGV_Data
            // 
            this.DGV_Data.AllowUserToAddRows = false;
            this.DGV_Data.AllowUserToDeleteRows = false;
            this.DGV_Data.AllowUserToOrderColumns = true;
            this.DGV_Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Data.EnableHeadersVisualStyles = false;
            this.DGV_Data.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Data.Location = new System.Drawing.Point(0, 191);
            this.DGV_Data.MultiSelect = false;
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.ReadOnly = true;
            this.DGV_Data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Data.RowHeadersVisible = false;
            this.DGV_Data.RowHeadersWidth = 5;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Data.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Data.Size = new System.Drawing.Size(657, 264);
            this.DGV_Data.StandardTab = true;
            this.DGV_Data.TabIndex = 29;
            // 
            // TextBox_Codigo
            // 
            this.TextBox_Codigo.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Codigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TextBox_Codigo.Location = new System.Drawing.Point(97, 90);
            this.TextBox_Codigo.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TextBox_Codigo.MaxLength = 15;
            this.TextBox_Codigo.Name = "TextBox_Codigo";
            this.TextBox_Codigo.Size = new System.Drawing.Size(119, 28);
            this.TextBox_Codigo.TabIndex = 26;
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.AutoSize = true;
            this.Label_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Codigo.Location = new System.Drawing.Point(14, 93);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.Size = new System.Drawing.Size(59, 20);
            this.Label_Codigo.TabIndex = 27;
            this.Label_Codigo.Text = "Codigo";
            // 
            // IconButton_Codigo
            // 
            this.IconButton_Codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Codigo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Codigo.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IconButton_Codigo.IconColor = System.Drawing.Color.Black;
            this.IconButton_Codigo.IconSize = 32;
            this.IconButton_Codigo.Location = new System.Drawing.Point(224, 91);
            this.IconButton_Codigo.Name = "IconButton_Codigo";
            this.IconButton_Codigo.Rotation = 0D;
            this.IconButton_Codigo.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Codigo.TabIndex = 28;
            this.IconButton_Codigo.UseVisualStyleBackColor = true;
            this.IconButton_Codigo.Click += new System.EventHandler(this.IconButton_Codigo_Click);
            this.IconButton_Codigo.Resize += new System.EventHandler(this.IconButton_Vendedor_Cliente_Codigo_Resize);
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Precio.Location = new System.Drawing.Point(352, 93);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(53, 20);
            this.Label_Precio.TabIndex = 27;
            this.Label_Precio.Text = "Precio";
            // 
            // Label_Existencia
            // 
            this.Label_Existencia.AutoSize = true;
            this.Label_Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Existencia.Location = new System.Drawing.Point(613, 93);
            this.Label_Existencia.Name = "Label_Existencia";
            this.Label_Existencia.Size = new System.Drawing.Size(23, 20);
            this.Label_Existencia.TabIndex = 27;
            this.Label_Existencia.Text = "Si";
            // 
            // TextBox_Cantidad
            // 
            this.TextBox_Cantidad.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Cantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TextBox_Cantidad.Location = new System.Drawing.Point(530, 90);
            this.TextBox_Cantidad.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TextBox_Cantidad.MaxLength = 15;
            this.TextBox_Cantidad.Name = "TextBox_Cantidad";
            this.TextBox_Cantidad.Size = new System.Drawing.Size(67, 28);
            this.TextBox_Cantidad.TabIndex = 26;
            this.TextBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ID_KeyPress);
            // 
            // Label_Cantidad
            // 
            this.Label_Cantidad.AutoSize = true;
            this.Label_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Cantidad.Location = new System.Drawing.Point(454, 92);
            this.Label_Cantidad.Name = "Label_Cantidad";
            this.Label_Cantidad.Size = new System.Drawing.Size(73, 20);
            this.Label_Cantidad.TabIndex = 27;
            this.Label_Cantidad.Text = "Cantidad";
            // 
            // Label_MostrarPrecio
            // 
            this.Label_MostrarPrecio.AutoSize = true;
            this.Label_MostrarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_MostrarPrecio.Location = new System.Drawing.Point(411, 93);
            this.Label_MostrarPrecio.Name = "Label_MostrarPrecio";
            this.Label_MostrarPrecio.Size = new System.Drawing.Size(18, 20);
            this.Label_MostrarPrecio.TabIndex = 27;
            this.Label_MostrarPrecio.Text = "0";
            // 
            // Label_TotalPagar
            // 
            this.Label_TotalPagar.AutoSize = true;
            this.Label_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_TotalPagar.Location = new System.Drawing.Point(542, 138);
            this.Label_TotalPagar.Name = "Label_TotalPagar";
            this.Label_TotalPagar.Size = new System.Drawing.Size(103, 20);
            this.Label_TotalPagar.TabIndex = 27;
            this.Label_TotalPagar.Text = "Total a Pagar";
            // 
            // Label_MostrarTotalPagar
            // 
            this.Label_MostrarTotalPagar.AutoSize = true;
            this.Label_MostrarTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_MostrarTotalPagar.Location = new System.Drawing.Point(542, 158);
            this.Label_MostrarTotalPagar.Name = "Label_MostrarTotalPagar";
            this.Label_MostrarTotalPagar.Size = new System.Drawing.Size(18, 20);
            this.Label_MostrarTotalPagar.TabIndex = 27;
            this.Label_MostrarTotalPagar.Text = "0";
            // 
            // IconButton_Procesar
            // 
            this.IconButton_Procesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Procesar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Procesar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.IconButton_Procesar.IconColor = System.Drawing.Color.Black;
            this.IconButton_Procesar.IconSize = 32;
            this.IconButton_Procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconButton_Procesar.Location = new System.Drawing.Point(18, 138);
            this.IconButton_Procesar.Name = "IconButton_Procesar";
            this.IconButton_Procesar.Rotation = 0D;
            this.IconButton_Procesar.Size = new System.Drawing.Size(89, 47);
            this.IconButton_Procesar.TabIndex = 28;
            this.IconButton_Procesar.Text = "Procesar";
            this.IconButton_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_Procesar.UseVisualStyleBackColor = true;
            this.IconButton_Procesar.Click += new System.EventHandler(this.IconButton_Procesar_Click);
            // 
            // IconButton_Add
            // 
            this.IconButton_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconButton_Add.IconColor = System.Drawing.Color.Black;
            this.IconButton_Add.IconSize = 32;
            this.IconButton_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconButton_Add.Location = new System.Drawing.Point(338, 137);
            this.IconButton_Add.Name = "IconButton_Add";
            this.IconButton_Add.Rotation = 0D;
            this.IconButton_Add.Size = new System.Drawing.Size(89, 47);
            this.IconButton_Add.TabIndex = 28;
            this.IconButton_Add.Text = "Mas";
            this.IconButton_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_Add.UseVisualStyleBackColor = true;
            this.IconButton_Add.Click += new System.EventHandler(this.IconButton_Add_Click);
            // 
            // IconButton_Menos
            // 
            this.IconButton_Menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Menos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Menos.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IconButton_Menos.IconColor = System.Drawing.Color.Black;
            this.IconButton_Menos.IconSize = 32;
            this.IconButton_Menos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconButton_Menos.Location = new System.Drawing.Point(438, 137);
            this.IconButton_Menos.Name = "IconButton_Menos";
            this.IconButton_Menos.Rotation = 0D;
            this.IconButton_Menos.Size = new System.Drawing.Size(89, 47);
            this.IconButton_Menos.TabIndex = 28;
            this.IconButton_Menos.Text = "Menos";
            this.IconButton_Menos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_Menos.UseVisualStyleBackColor = true;
            this.IconButton_Menos.Click += new System.EventHandler(this.IconButton_Menos_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 455);
            this.Controls.Add(this.DGV_Data);
            this.Controls.Add(this.IconButton_Menos);
            this.Controls.Add(this.IconButton_Add);
            this.Controls.Add(this.IconButton_Procesar);
            this.Controls.Add(this.IconButton_Codigo);
            this.Controls.Add(this.IconButton_Vendedor);
            this.Controls.Add(this.IconButton_Cliente);
            this.Controls.Add(this.Label_Cliente);
            this.Controls.Add(this.Label_MostrarTotalPagar);
            this.Controls.Add(this.Label_MostrarPrecio);
            this.Controls.Add(this.Label_Existencia);
            this.Controls.Add(this.Label_TotalPagar);
            this.Controls.Add(this.Label_Precio);
            this.Controls.Add(this.Label_Cantidad);
            this.Controls.Add(this.Label_Codigo);
            this.Controls.Add(this.Label_Vendedor);
            this.Controls.Add(this.TextBox_Cliente);
            this.Controls.Add(this.TextBox_Cantidad);
            this.Controls.Add(this.TextBox_Codigo);
            this.Controls.Add(this.TextBox_Vendedor);
            this.Controls.Add(this.Label_Titulo);
            this.Name = "FormVenta";
            this.Text = "Factura de Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.Resize += new System.EventHandler(this.FormVenta_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.TextBox TextBox_Vendedor;
        private System.Windows.Forms.Label Label_Vendedor;
        private System.Windows.Forms.TextBox TextBox_Cliente;
        private System.Windows.Forms.Label Label_Cliente;
        private FontAwesome.Sharp.IconButton IconButton_Cliente;
        private FontAwesome.Sharp.IconButton IconButton_Vendedor;
        protected System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.TextBox TextBox_Codigo;
        private System.Windows.Forms.Label Label_Codigo;
        private FontAwesome.Sharp.IconButton IconButton_Codigo;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.Label Label_Existencia;
        private System.Windows.Forms.TextBox TextBox_Cantidad;
        private System.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.Label Label_MostrarPrecio;
        private System.Windows.Forms.Label Label_TotalPagar;
        private System.Windows.Forms.Label Label_MostrarTotalPagar;
        private FontAwesome.Sharp.IconButton IconButton_Procesar;
        private FontAwesome.Sharp.IconButton IconButton_Add;
        private FontAwesome.Sharp.IconButton IconButton_Menos;
    }
}