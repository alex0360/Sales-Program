namespace Presentacion.Config
{
    partial class FormBaseInsetUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseInsetUpdate));
            this.Panel_Titulo = new System.Windows.Forms.Panel();
            this.IconButton_Limpiar = new FontAwesome.Sharp.IconButton();
            this.IconButton_Guardar = new FontAwesome.Sharp.IconButton();
            this.IconButton_Cerrar = new FontAwesome.Sharp.IconButton();
            this.Panel_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Titulo
            // 
            this.Panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.Panel_Titulo.Controls.Add(this.IconButton_Limpiar);
            this.Panel_Titulo.Controls.Add(this.IconButton_Guardar);
            this.Panel_Titulo.Controls.Add(this.IconButton_Cerrar);
            this.Panel_Titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Titulo.Name = "Panel_Titulo";
            this.Panel_Titulo.Size = new System.Drawing.Size(444, 68);
            this.Panel_Titulo.TabIndex = 0;
            this.Panel_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Titulo_Paint);
            this.Panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Titulo_MouseMove);
            // 
            // IconButton_Limpiar
            // 
            this.IconButton_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Limpiar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Limpiar.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.IconButton_Limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.IconButton_Limpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Limpiar.IconSize = 42;
            this.IconButton_Limpiar.Location = new System.Drawing.Point(87, 0);
            this.IconButton_Limpiar.Name = "IconButton_Limpiar";
            this.IconButton_Limpiar.Rotation = 0D;
            this.IconButton_Limpiar.Size = new System.Drawing.Size(78, 62);
            this.IconButton_Limpiar.TabIndex = 1;
            this.IconButton_Limpiar.Text = "Limpiar";
            this.IconButton_Limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconButton_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconButton_Limpiar.UseVisualStyleBackColor = true;
            this.IconButton_Limpiar.Click += new System.EventHandler(this.IconButton_Clear_Click);
            // 
            // IconButton_Guardar
            // 
            this.IconButton_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Guardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Guardar.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.IconButton_Guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IconButton_Guardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Guardar.IconSize = 42;
            this.IconButton_Guardar.Location = new System.Drawing.Point(3, 0);
            this.IconButton_Guardar.Name = "IconButton_Guardar";
            this.IconButton_Guardar.Rotation = 0D;
            this.IconButton_Guardar.Size = new System.Drawing.Size(78, 62);
            this.IconButton_Guardar.TabIndex = 1;
            this.IconButton_Guardar.Text = "Guardar";
            this.IconButton_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconButton_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconButton_Guardar.UseVisualStyleBackColor = true;
            this.IconButton_Guardar.Click += new System.EventHandler(this.IconButton_Guardar_Click);
            // 
            // IconButton_Cerrar
            // 
            this.IconButton_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconButton_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IconButton_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IconButton_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Cerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Cerrar.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.IconButton_Cerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IconButton_Cerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.IconButton_Cerrar.IconSize = 42;
            this.IconButton_Cerrar.Location = new System.Drawing.Point(363, 0);
            this.IconButton_Cerrar.Name = "IconButton_Cerrar";
            this.IconButton_Cerrar.Rotation = 0D;
            this.IconButton_Cerrar.Size = new System.Drawing.Size(78, 62);
            this.IconButton_Cerrar.TabIndex = 1;
            this.IconButton_Cerrar.Text = "Cerrar";
            this.IconButton_Cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconButton_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconButton_Cerrar.UseVisualStyleBackColor = true;
            this.IconButton_Cerrar.Click += new System.EventHandler(this.IconButton_Cancelar_Click);
            // 
            // FormBaseInsetUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Controls.Add(this.Panel_Titulo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(444, 364);
            this.MinimumSize = new System.Drawing.Size(444, 364);
            this.Name = "FormBaseInsetUpdate";
            this.Text = "FormBaseInsetUpdate";
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel Panel_Titulo;
        protected FontAwesome.Sharp.IconButton IconButton_Cerrar;
        protected FontAwesome.Sharp.IconButton IconButton_Limpiar;
        protected FontAwesome.Sharp.IconButton IconButton_Guardar;
    }
}