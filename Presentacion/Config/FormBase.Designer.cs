namespace Presentacion.Config
{
    partial class FormBase
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
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.IconButton_Insertar = new FontAwesome.Sharp.IconButton();
            this.IconButton_Imprimir = new FontAwesome.Sharp.IconButton();
            this.IconButton_Delete = new FontAwesome.Sharp.IconButton();
            this.IconButton_Actualizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
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
            this.DGV_Data.Location = new System.Drawing.Point(0, 83);
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
            this.DGV_Data.Size = new System.Drawing.Size(649, 354);
            this.DGV_Data.StandardTab = true;
            this.DGV_Data.TabIndex = 7;
            this.DGV_Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellDoubleClick);
            this.DGV_Data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellValueChanged);
            this.DGV_Data.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_Data_EditingControlShowing);
            this.DGV_Data.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGV_Data_UserDeletingRow);
            // 
            // IconButton_Insertar
            // 
            this.IconButton_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Insertar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Insertar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IconButton_Insertar.IconColor = System.Drawing.Color.Black;
            this.IconButton_Insertar.IconSize = 28;
            this.IconButton_Insertar.Location = new System.Drawing.Point(12, 50);
            this.IconButton_Insertar.Name = "IconButton_Insertar";
            this.IconButton_Insertar.Rotation = 0D;
            this.IconButton_Insertar.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Insertar.TabIndex = 8;
            this.IconButton_Insertar.UseVisualStyleBackColor = true;
            this.IconButton_Insertar.Click += new System.EventHandler(this.IconButton_Insertar_Click);
            // 
            // IconButton_Imprimir
            // 
            this.IconButton_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Imprimir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.IconButton_Imprimir.IconColor = System.Drawing.Color.Black;
            this.IconButton_Imprimir.IconSize = 28;
            this.IconButton_Imprimir.Location = new System.Drawing.Point(216, 50);
            this.IconButton_Imprimir.Name = "IconButton_Imprimir";
            this.IconButton_Imprimir.Rotation = 0D;
            this.IconButton_Imprimir.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Imprimir.TabIndex = 8;
            this.IconButton_Imprimir.UseVisualStyleBackColor = true;
            this.IconButton_Imprimir.Click += new System.EventHandler(this.IconButton_Imprimir_Click);
            // 
            // IconButton_Delete
            // 
            this.IconButton_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.IconButton_Delete.IconColor = System.Drawing.Color.Black;
            this.IconButton_Delete.IconSize = 28;
            this.IconButton_Delete.Location = new System.Drawing.Point(148, 50);
            this.IconButton_Delete.Name = "IconButton_Delete";
            this.IconButton_Delete.Rotation = 0D;
            this.IconButton_Delete.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Delete.TabIndex = 8;
            this.IconButton_Delete.UseVisualStyleBackColor = true;
            this.IconButton_Delete.Click += new System.EventHandler(this.IconButton_Delete_Click);
            // 
            // IconButton_Actualizar
            // 
            this.IconButton_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Actualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Actualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.IconButton_Actualizar.IconColor = System.Drawing.Color.Black;
            this.IconButton_Actualizar.IconSize = 32;
            this.IconButton_Actualizar.Location = new System.Drawing.Point(80, 50);
            this.IconButton_Actualizar.Name = "IconButton_Actualizar";
            this.IconButton_Actualizar.Rotation = 0D;
            this.IconButton_Actualizar.Size = new System.Drawing.Size(62, 27);
            this.IconButton_Actualizar.TabIndex = 8;
            this.IconButton_Actualizar.UseVisualStyleBackColor = true;
            this.IconButton_Actualizar.Click += new System.EventHandler(this.IconButton_Actualizar_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 437);
            this.Controls.Add(this.IconButton_Insertar);
            this.Controls.Add(this.IconButton_Imprimir);
            this.Controls.Add(this.IconButton_Delete);
            this.Controls.Add(this.IconButton_Actualizar);
            this.Controls.Add(this.DGV_Data);
            this.Name = "FormBase";
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.DataGridView DGV_Data;
        private FontAwesome.Sharp.IconButton IconButton_Actualizar;
        private FontAwesome.Sharp.IconButton IconButton_Insertar;
        private FontAwesome.Sharp.IconButton IconButton_Delete;
        private FontAwesome.Sharp.IconButton IconButton_Imprimir;
    }
}