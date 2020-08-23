namespace Presentacion
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.P_logo = new System.Windows.Forms.Panel();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.TB_Clave = new System.Windows.Forms.TextBox();
            this.L_Login = new System.Windows.Forms.Label();
            this.IB_Acceder = new FontAwesome.Sharp.IconButton();
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.B_Minimizar = new System.Windows.Forms.Button();
            this.T_Error = new System.Windows.Forms.Timer(this.components);
            this.P_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // P_logo
            // 
            this.P_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.P_logo.Controls.Add(this.PB_Logo);
            this.P_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_logo.Location = new System.Drawing.Point(0, 0);
            this.P_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.P_logo.Name = "P_logo";
            this.P_logo.Size = new System.Drawing.Size(317, 405);
            this.P_logo.TabIndex = 0;
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::Presentacion.Properties.Resources.ventas;
            this.PB_Logo.Location = new System.Drawing.Point(24, 76);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(276, 270);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.TB_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Usuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Usuario.Location = new System.Drawing.Point(411, 97);
            this.TB_Usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Usuario.MaxLength = 15;
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(408, 42);
            this.TB_Usuario.TabIndex = 1;
            this.TB_Usuario.Text = "   USUARIO";
            this.TB_Usuario.Enter += new System.EventHandler(this.TB_Usuario_Enter);
            this.TB_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Usuario_KeyPress);
            this.TB_Usuario.Leave += new System.EventHandler(this.TB_Usuario_Leave);
            // 
            // TB_Clave
            // 
            this.TB_Clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.TB_Clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Clave.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.TB_Clave.Location = new System.Drawing.Point(411, 175);
            this.TB_Clave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Clave.MaxLength = 15;
            this.TB_Clave.Name = "TB_Clave";
            this.TB_Clave.Size = new System.Drawing.Size(408, 42);
            this.TB_Clave.TabIndex = 2;
            this.TB_Clave.Text = "   PASSWORD";
            this.TB_Clave.Enter += new System.EventHandler(this.TB_Clave_Enter);
            this.TB_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Clave_KeyPress);
            this.TB_Clave.Leave += new System.EventHandler(this.TB_Clave_Leave);
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.L_Login.Location = new System.Drawing.Point(549, 9);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(138, 44);
            this.L_Login.TabIndex = 5;
            this.L_Login.Text = "LOGIN";
            // 
            // IB_Acceder
            // 
            this.IB_Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(217)))), ((int)(((byte)(117)))));
            this.IB_Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Acceder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Acceder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Acceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.IB_Acceder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IB_Acceder.IconColor = System.Drawing.Color.Black;
            this.IB_Acceder.IconSize = 16;
            this.IB_Acceder.Location = new System.Drawing.Point(411, 282);
            this.IB_Acceder.Name = "IB_Acceder";
            this.IB_Acceder.Rotation = 0D;
            this.IB_Acceder.Size = new System.Drawing.Size(408, 43);
            this.IB_Acceder.TabIndex = 3;
            this.IB_Acceder.Text = "ACCEDER";
            this.IB_Acceder.UseVisualStyleBackColor = false;
            this.IB_Acceder.Click += new System.EventHandler(this.IB_Acceder_Click);
            // 
            // B_Cerrar
            // 
            this.B_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Cerrar.FlatAppearance.BorderSize = 0;
            this.B_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.B_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cerrar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Cerrar.ForeColor = System.Drawing.Color.Red;
            this.B_Cerrar.Location = new System.Drawing.Point(861, 9);
            this.B_Cerrar.Name = "B_Cerrar";
            this.B_Cerrar.Size = new System.Drawing.Size(37, 29);
            this.B_Cerrar.TabIndex = 0;
            this.B_Cerrar.Text = "X";
            this.B_Cerrar.UseVisualStyleBackColor = true;
            this.B_Cerrar.Click += new System.EventHandler(this.B_Cerrar_Click);
            // 
            // B_Minimizar
            // 
            this.B_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Minimizar.FlatAppearance.BorderSize = 0;
            this.B_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.B_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.B_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Minimizar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.B_Minimizar.Location = new System.Drawing.Point(818, 9);
            this.B_Minimizar.Name = "B_Minimizar";
            this.B_Minimizar.Size = new System.Drawing.Size(37, 29);
            this.B_Minimizar.TabIndex = 4;
            this.B_Minimizar.Text = "-";
            this.B_Minimizar.UseVisualStyleBackColor = true;
            this.B_Minimizar.Click += new System.EventHandler(this.B_Minimizar_Click);
            // 
            // T_Error
            // 
            this.T_Error.Interval = 5000;
            this.T_Error.Tick += new System.EventHandler(this.T_Error_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(910, 405);
            this.Controls.Add(this.B_Cerrar);
            this.Controls.Add(this.B_Minimizar);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.P_logo);
            this.Controls.Add(this.IB_Acceder);
            this.Controls.Add(this.TB_Clave);
            this.Controls.Add(this.TB_Usuario);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.P_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P_logo;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.TextBox TB_Clave;
        private System.Windows.Forms.Label L_Login;
        private FontAwesome.Sharp.IconButton IB_Acceder;
        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Button B_Minimizar;
        private System.Windows.Forms.Timer T_Error;
    }
}