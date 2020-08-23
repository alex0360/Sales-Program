namespace Presentacion.Config
{
    partial class FormBaseBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseBuscar));
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.IconButton_Codigo = new FontAwesome.Sharp.IconButton();
            this.TextBox_Buscar = new System.Windows.Forms.TextBox();
            this.IconButton_Cerrar = new FontAwesome.Sharp.IconButton();
            this.Panel_Titulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.Panel_Titulo.SuspendLayout();
            this.SuspendLayout();
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
            this.DGV_Data.Location = new System.Drawing.Point(0, 124);
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
            this.DGV_Data.Size = new System.Drawing.Size(313, 326);
            this.DGV_Data.StandardTab = true;
            this.DGV_Data.TabIndex = 30;
            this.DGV_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellContentClick);
            this.DGV_Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellDoubleClick);
            // 
            // IconButton_Codigo
            // 
            this.IconButton_Codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Codigo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Codigo.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IconButton_Codigo.IconColor = System.Drawing.Color.Black;
            this.IconButton_Codigo.IconSize = 32;
            this.IconButton_Codigo.Location = new System.Drawing.Point(195, 77);
            this.IconButton_Codigo.Name = "IconButton_Codigo";
            this.IconButton_Codigo.Rotation = 0D;
            this.IconButton_Codigo.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Codigo.TabIndex = 32;
            this.IconButton_Codigo.UseVisualStyleBackColor = true;
            this.IconButton_Codigo.Click += new System.EventHandler(this.IconButton_Codigo_Click);
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Buscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TextBox_Buscar.Location = new System.Drawing.Point(55, 77);
            this.TextBox_Buscar.Margin = new System.Windows.Forms.Padding(200, 4, 3, 4);
            this.TextBox_Buscar.MaxLength = 15;
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(119, 28);
            this.TextBox_Buscar.TabIndex = 31;
            this.TextBox_Buscar.Text = "   Nombre";
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
            this.IconButton_Cerrar.Location = new System.Drawing.Point(232, 3);
            this.IconButton_Cerrar.Name = "IconButton_Cerrar";
            this.IconButton_Cerrar.Rotation = 0D;
            this.IconButton_Cerrar.Size = new System.Drawing.Size(78, 62);
            this.IconButton_Cerrar.TabIndex = 1;
            this.IconButton_Cerrar.Text = "Cerrar";
            this.IconButton_Cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IconButton_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconButton_Cerrar.UseVisualStyleBackColor = true;
            this.IconButton_Cerrar.Click += new System.EventHandler(this.IconButton_Cerrar_Click);
            // 
            // Panel_Titulo
            // 
            this.Panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.Panel_Titulo.Controls.Add(this.IconButton_Cerrar);
            this.Panel_Titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Titulo.Name = "Panel_Titulo";
            this.Panel_Titulo.Size = new System.Drawing.Size(313, 68);
            this.Panel_Titulo.TabIndex = 33;
            this.Panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Titulo_MouseMove);
            // 
            // FormBaseBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_Titulo);
            this.Controls.Add(this.IconButton_Codigo);
            this.Controls.Add(this.TextBox_Buscar);
            this.Controls.Add(this.DGV_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(313, 450);
            this.Name = "FormBaseBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaseBuscar";
            this.Load += new System.EventHandler(this.FormBaseBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.Panel_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView DGV_Data;
        protected FontAwesome.Sharp.IconButton IconButton_Codigo;
        protected System.Windows.Forms.TextBox TextBox_Buscar;
        protected FontAwesome.Sharp.IconButton IconButton_Cerrar;
        protected System.Windows.Forms.Panel Panel_Titulo;
    }
}