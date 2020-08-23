namespace Presentacion.Config.Forms
{
    partial class FormProductoInsUp
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
            this.TB_Precio = new System.Windows.Forms.TextBox();
            this.TB_Costo = new System.Windows.Forms.TextBox();
            this.TB_Descripcion = new System.Windows.Forms.TextBox();
            this.Timer_Error = new System.Windows.Forms.Timer(this.components);
            this.TextBox_Cantidad = new System.Windows.Forms.TextBox();
            this.CB_NombreFabricante = new System.Windows.Forms.ComboBox();
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
            this.IconButton_Guardar.Click += new System.EventHandler(this.IconButton_Guardar_Click_1);
            // 
            // TB_Precio
            // 
            this.TB_Precio.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Precio.Location = new System.Drawing.Point(22, 204);
            this.TB_Precio.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Precio.MaxLength = 8;
            this.TB_Precio.Name = "TB_Precio";
            this.TB_Precio.Size = new System.Drawing.Size(208, 28);
            this.TB_Precio.TabIndex = 11;
            this.TB_Precio.Text = "   Precio";
            this.TB_Precio.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Precio.Enter += new System.EventHandler(this.TB_Precio_Enter);
            this.TB_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_Precio.Leave += new System.EventHandler(this.TB_Precio_Leave);
            // 
            // TB_Costo
            // 
            this.TB_Costo.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Costo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Costo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Costo.Location = new System.Drawing.Point(22, 168);
            this.TB_Costo.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Costo.MaxLength = 8;
            this.TB_Costo.Name = "TB_Costo";
            this.TB_Costo.Size = new System.Drawing.Size(208, 28);
            this.TB_Costo.TabIndex = 10;
            this.TB_Costo.Text = "   Costo";
            this.TB_Costo.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Costo.Enter += new System.EventHandler(this.TB_Costo_Enter);
            this.TB_Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TB_Costo.Leave += new System.EventHandler(this.TB_Costo_Leave);
            // 
            // TB_Descripcion
            // 
            this.TB_Descripcion.BackColor = System.Drawing.SystemColors.Control;
            this.TB_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Descripcion.Location = new System.Drawing.Point(22, 96);
            this.TB_Descripcion.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TB_Descripcion.MaxLength = 45;
            this.TB_Descripcion.Name = "TB_Descripcion";
            this.TB_Descripcion.Size = new System.Drawing.Size(383, 28);
            this.TB_Descripcion.TabIndex = 7;
            this.TB_Descripcion.Text = "   Descripcion";
            this.TB_Descripcion.Enter += new System.EventHandler(this.TB_Descripcion_Enter);
            this.TB_Descripcion.Leave += new System.EventHandler(this.TB_Descripcion_Leave);
            // 
            // Timer_Error
            // 
            this.Timer_Error.Interval = 2000;
            // 
            // TextBox_Cantidad
            // 
            this.TextBox_Cantidad.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Cantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TextBox_Cantidad.Location = new System.Drawing.Point(22, 240);
            this.TextBox_Cantidad.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TextBox_Cantidad.MaxLength = 8;
            this.TextBox_Cantidad.Name = "TextBox_Cantidad";
            this.TextBox_Cantidad.Size = new System.Drawing.Size(208, 28);
            this.TextBox_Cantidad.TabIndex = 11;
            this.TextBox_Cantidad.Text = "   Cantidad en Inventario";
            this.TextBox_Cantidad.Enter += new System.EventHandler(this.TextBox_Cantidad_Enter);
            this.TextBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            this.TextBox_Cantidad.Leave += new System.EventHandler(this.TextBox_Cantidad_Leave);
            // 
            // CB_NombreFabricante
            // 
            this.CB_NombreFabricante.BackColor = System.Drawing.SystemColors.Control;
            this.CB_NombreFabricante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_NombreFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_NombreFabricante.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.CB_NombreFabricante.FormattingEnabled = true;
            this.CB_NombreFabricante.Location = new System.Drawing.Point(22, 132);
            this.CB_NombreFabricante.Name = "CB_NombreFabricante";
            this.CB_NombreFabricante.Size = new System.Drawing.Size(383, 29);
            this.CB_NombreFabricante.TabIndex = 12;
            this.CB_NombreFabricante.Text = "   Nombre del Fabricante";
            this.CB_NombreFabricante.SelectedIndexChanged += new System.EventHandler(this.CB_NombreFabricante_SelectedIndexChanged);
            this.CB_NombreFabricante.Enter += new System.EventHandler(this.CB_NombreFabricante_Enter);
            this.CB_NombreFabricante.Leave += new System.EventHandler(this.CB_NombreFabricante_Leave);
            // 
            // FormProductoInsUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Controls.Add(this.CB_NombreFabricante);
            this.Controls.Add(this.TextBox_Cantidad);
            this.Controls.Add(this.TB_Precio);
            this.Controls.Add(this.TB_Costo);
            this.Controls.Add(this.TB_Descripcion);
            this.Name = "FormProductoInsUp";
            this.Text = "FormProductoInsUp";
            this.Controls.SetChildIndex(this.Panel_Titulo, 0);
            this.Controls.SetChildIndex(this.TB_Descripcion, 0);
            this.Controls.SetChildIndex(this.TB_Costo, 0);
            this.Controls.SetChildIndex(this.TB_Precio, 0);
            this.Controls.SetChildIndex(this.TextBox_Cantidad, 0);
            this.Controls.SetChildIndex(this.CB_NombreFabricante, 0);
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Precio;
        private System.Windows.Forms.TextBox TB_Costo;
        private System.Windows.Forms.TextBox TB_Descripcion;
        private System.Windows.Forms.Timer Timer_Error;
        private System.Windows.Forms.TextBox TextBox_Cantidad;
        private System.Windows.Forms.ComboBox CB_NombreFabricante;
    }
}