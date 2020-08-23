namespace Presentacion
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.P_Menu = new System.Windows.Forms.Panel();
            this.IconButton_Ayuda = new FontAwesome.Sharp.IconButton();
            this.IB_Salir = new FontAwesome.Sharp.IconButton();
            this.P_SubVenta = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IconButton_Venta = new FontAwesome.Sharp.IconButton();
            this.IB_Venta = new FontAwesome.Sharp.IconButton();
            this.P_SubMantenimiento = new System.Windows.Forms.Panel();
            this.IB_Vendedor = new FontAwesome.Sharp.IconButton();
            this.IB_Producto = new FontAwesome.Sharp.IconButton();
            this.IB_Fabricante = new FontAwesome.Sharp.IconButton();
            this.IB_Cliente = new FontAwesome.Sharp.IconButton();
            this.IB_Mantenimiento = new FontAwesome.Sharp.IconButton();
            this.P_Logo = new System.Windows.Forms.Panel();
            this.L_Logo = new System.Windows.Forms.Label();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.P_Titulo = new System.Windows.Forms.Panel();
            this.B_Minimizar = new System.Windows.Forms.Button();
            this.B_Maximizar = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.B_CloseChildForm = new System.Windows.Forms.Button();
            this.L_Titulo = new System.Windows.Forms.Label();
            this.P_DesktopPane = new System.Windows.Forms.Panel();
            this.P_Floot = new System.Windows.Forms.Panel();
            this.L_Hora = new System.Windows.Forms.Label();
            this.L_Fecha = new System.Windows.Forms.Label();
            this.L_UsuarioConectado = new System.Windows.Forms.Label();
            this.T_FechaHora = new System.Windows.Forms.Timer(this.components);
            this.P_Menu.SuspendLayout();
            this.P_SubVenta.SuspendLayout();
            this.P_SubMantenimiento.SuspendLayout();
            this.P_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.P_Titulo.SuspendLayout();
            this.P_DesktopPane.SuspendLayout();
            this.P_Floot.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Menu
            // 
            this.P_Menu.AutoScroll = true;
            this.P_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.P_Menu.Controls.Add(this.IconButton_Ayuda);
            this.P_Menu.Controls.Add(this.IB_Salir);
            this.P_Menu.Controls.Add(this.P_SubVenta);
            this.P_Menu.Controls.Add(this.IB_Venta);
            this.P_Menu.Controls.Add(this.P_SubMantenimiento);
            this.P_Menu.Controls.Add(this.IB_Mantenimiento);
            this.P_Menu.Controls.Add(this.P_Logo);
            this.P_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Menu.Location = new System.Drawing.Point(0, 0);
            this.P_Menu.Name = "P_Menu";
            this.P_Menu.Size = new System.Drawing.Size(230, 601);
            this.P_Menu.TabIndex = 0;
            // 
            // IconButton_Ayuda
            // 
            this.IconButton_Ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconButton_Ayuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IconButton_Ayuda.FlatAppearance.BorderSize = 0;
            this.IconButton_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Ayuda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Ayuda.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton_Ayuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.IconButton_Ayuda.IconColor = System.Drawing.Color.Black;
            this.IconButton_Ayuda.IconSize = 32;
            this.IconButton_Ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconButton_Ayuda.Location = new System.Drawing.Point(0, 521);
            this.IconButton_Ayuda.Name = "IconButton_Ayuda";
            this.IconButton_Ayuda.Rotation = 0D;
            this.IconButton_Ayuda.Size = new System.Drawing.Size(230, 40);
            this.IconButton_Ayuda.TabIndex = 6;
            this.IconButton_Ayuda.Text = "Ayuda";
            this.IconButton_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_Ayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton_Ayuda.UseVisualStyleBackColor = true;
            this.IconButton_Ayuda.Click += new System.EventHandler(this.IconButton_Ayuda_Click);
            // 
            // IB_Salir
            // 
            this.IB_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IB_Salir.FlatAppearance.BorderSize = 0;
            this.IB_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Salir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Salir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Salir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IB_Salir.IconColor = System.Drawing.Color.Black;
            this.IB_Salir.IconSize = 16;
            this.IB_Salir.Location = new System.Drawing.Point(0, 561);
            this.IB_Salir.Name = "IB_Salir";
            this.IB_Salir.Rotation = 0D;
            this.IB_Salir.Size = new System.Drawing.Size(230, 40);
            this.IB_Salir.TabIndex = 5;
            this.IB_Salir.Text = "Salir";
            this.IB_Salir.UseVisualStyleBackColor = true;
            this.IB_Salir.Click += new System.EventHandler(this.IB_Salir_Click);
            // 
            // P_SubVenta
            // 
            this.P_SubVenta.Controls.Add(this.iconButton4);
            this.P_SubVenta.Controls.Add(this.IconButton_Venta);
            this.P_SubVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_SubVenta.Location = new System.Drawing.Point(0, 327);
            this.P_SubVenta.Name = "P_SubVenta";
            this.P_SubVenta.Size = new System.Drawing.Size(230, 163);
            this.P_SubVenta.TabIndex = 4;
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 40);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(230, 40);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.Text = "Reporte de Ventas";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // IconButton_Venta
            // 
            this.IconButton_Venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconButton_Venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconButton_Venta.FlatAppearance.BorderSize = 0;
            this.IconButton_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton_Venta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton_Venta.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.IconButton_Venta.IconColor = System.Drawing.Color.Black;
            this.IconButton_Venta.IconSize = 30;
            this.IconButton_Venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_Venta.Location = new System.Drawing.Point(0, 0);
            this.IconButton_Venta.Name = "IconButton_Venta";
            this.IconButton_Venta.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.IconButton_Venta.Rotation = 0D;
            this.IconButton_Venta.Size = new System.Drawing.Size(230, 40);
            this.IconButton_Venta.TabIndex = 0;
            this.IconButton_Venta.Text = "Venta";
            this.IconButton_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_Venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton_Venta.UseVisualStyleBackColor = true;
            this.IconButton_Venta.Click += new System.EventHandler(this.IconButton_Venta_Click);
            // 
            // IB_Venta
            // 
            this.IB_Venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.IB_Venta.FlatAppearance.BorderSize = 0;
            this.IB_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Venta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Venta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Venta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IB_Venta.IconColor = System.Drawing.Color.Black;
            this.IB_Venta.IconSize = 34;
            this.IB_Venta.Location = new System.Drawing.Point(0, 277);
            this.IB_Venta.Name = "IB_Venta";
            this.IB_Venta.Rotation = 0D;
            this.IB_Venta.Size = new System.Drawing.Size(230, 50);
            this.IB_Venta.TabIndex = 3;
            this.IB_Venta.Text = "Venta";
            this.IB_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Venta.UseVisualStyleBackColor = true;
            this.IB_Venta.Click += new System.EventHandler(this.IB_Venta_Click);
            // 
            // P_SubMantenimiento
            // 
            this.P_SubMantenimiento.Controls.Add(this.IB_Vendedor);
            this.P_SubMantenimiento.Controls.Add(this.IB_Producto);
            this.P_SubMantenimiento.Controls.Add(this.IB_Fabricante);
            this.P_SubMantenimiento.Controls.Add(this.IB_Cliente);
            this.P_SubMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_SubMantenimiento.Location = new System.Drawing.Point(0, 114);
            this.P_SubMantenimiento.Name = "P_SubMantenimiento";
            this.P_SubMantenimiento.Size = new System.Drawing.Size(230, 163);
            this.P_SubMantenimiento.TabIndex = 2;
            // 
            // IB_Vendedor
            // 
            this.IB_Vendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Vendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.IB_Vendedor.FlatAppearance.BorderSize = 0;
            this.IB_Vendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Vendedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Vendedor.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.IB_Vendedor.IconColor = System.Drawing.Color.Black;
            this.IB_Vendedor.IconSize = 30;
            this.IB_Vendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Vendedor.Location = new System.Drawing.Point(0, 120);
            this.IB_Vendedor.Name = "IB_Vendedor";
            this.IB_Vendedor.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.IB_Vendedor.Rotation = 0D;
            this.IB_Vendedor.Size = new System.Drawing.Size(230, 40);
            this.IB_Vendedor.TabIndex = 3;
            this.IB_Vendedor.Text = "Vendedores";
            this.IB_Vendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Vendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IB_Vendedor.UseVisualStyleBackColor = true;
            this.IB_Vendedor.Click += new System.EventHandler(this.IB_Vendedor_Click);
            // 
            // IB_Producto
            // 
            this.IB_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.IB_Producto.FlatAppearance.BorderSize = 0;
            this.IB_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Producto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Producto.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.IB_Producto.IconColor = System.Drawing.Color.Black;
            this.IB_Producto.IconSize = 30;
            this.IB_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Producto.Location = new System.Drawing.Point(0, 80);
            this.IB_Producto.Name = "IB_Producto";
            this.IB_Producto.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.IB_Producto.Rotation = 0D;
            this.IB_Producto.Size = new System.Drawing.Size(230, 40);
            this.IB_Producto.TabIndex = 2;
            this.IB_Producto.Text = "Productos";
            this.IB_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IB_Producto.UseVisualStyleBackColor = true;
            this.IB_Producto.Click += new System.EventHandler(this.IB_Producto_Click);
            // 
            // IB_Fabricante
            // 
            this.IB_Fabricante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Fabricante.Dock = System.Windows.Forms.DockStyle.Top;
            this.IB_Fabricante.FlatAppearance.BorderSize = 0;
            this.IB_Fabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Fabricante.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Fabricante.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.IB_Fabricante.IconColor = System.Drawing.Color.Black;
            this.IB_Fabricante.IconSize = 30;
            this.IB_Fabricante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Fabricante.Location = new System.Drawing.Point(0, 40);
            this.IB_Fabricante.Name = "IB_Fabricante";
            this.IB_Fabricante.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.IB_Fabricante.Rotation = 0D;
            this.IB_Fabricante.Size = new System.Drawing.Size(230, 40);
            this.IB_Fabricante.TabIndex = 1;
            this.IB_Fabricante.Text = "Fabricantes";
            this.IB_Fabricante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Fabricante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IB_Fabricante.UseVisualStyleBackColor = true;
            this.IB_Fabricante.Click += new System.EventHandler(this.IB_Fabricante_Click);
            // 
            // IB_Cliente
            // 
            this.IB_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.IB_Cliente.FlatAppearance.BorderSize = 0;
            this.IB_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Cliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Cliente.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.IB_Cliente.IconColor = System.Drawing.Color.Black;
            this.IB_Cliente.IconSize = 30;
            this.IB_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Cliente.Location = new System.Drawing.Point(0, 0);
            this.IB_Cliente.Name = "IB_Cliente";
            this.IB_Cliente.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.IB_Cliente.Rotation = 0D;
            this.IB_Cliente.Size = new System.Drawing.Size(230, 40);
            this.IB_Cliente.TabIndex = 0;
            this.IB_Cliente.Text = "Clientes";
            this.IB_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IB_Cliente.UseVisualStyleBackColor = true;
            this.IB_Cliente.Click += new System.EventHandler(this.IB_Cliente_Click);
            // 
            // IB_Mantenimiento
            // 
            this.IB_Mantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IB_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.IB_Mantenimiento.FlatAppearance.BorderSize = 0;
            this.IB_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IB_Mantenimiento.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IB_Mantenimiento.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IB_Mantenimiento.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IB_Mantenimiento.IconColor = System.Drawing.Color.Black;
            this.IB_Mantenimiento.IconSize = 34;
            this.IB_Mantenimiento.Location = new System.Drawing.Point(0, 64);
            this.IB_Mantenimiento.Name = "IB_Mantenimiento";
            this.IB_Mantenimiento.Rotation = 0D;
            this.IB_Mantenimiento.Size = new System.Drawing.Size(230, 50);
            this.IB_Mantenimiento.TabIndex = 1;
            this.IB_Mantenimiento.Text = "Mantenimiento";
            this.IB_Mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IB_Mantenimiento.UseVisualStyleBackColor = true;
            this.IB_Mantenimiento.Click += new System.EventHandler(this.IB_Mantenimiento_Click);
            // 
            // P_Logo
            // 
            this.P_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.P_Logo.Controls.Add(this.L_Logo);
            this.P_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Logo.Location = new System.Drawing.Point(0, 0);
            this.P_Logo.Name = "P_Logo";
            this.P_Logo.Size = new System.Drawing.Size(230, 64);
            this.P_Logo.TabIndex = 0;
            // 
            // L_Logo
            // 
            this.L_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Logo.AutoSize = true;
            this.L_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L_Logo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Logo.ForeColor = System.Drawing.Color.Black;
            this.L_Logo.Location = new System.Drawing.Point(62, 16);
            this.L_Logo.Name = "L_Logo";
            this.L_Logo.Size = new System.Drawing.Size(93, 28);
            this.L_Logo.TabIndex = 0;
            this.L_Logo.Text = "VXProg";
            // 
            // PB_Logo
            // 
            this.PB_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Logo.Image = global::Presentacion.Properties.Resources.ventas;
            this.PB_Logo.Location = new System.Drawing.Point(224, 87);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(357, 336);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // P_Titulo
            // 
            this.P_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.P_Titulo.Controls.Add(this.B_Minimizar);
            this.P_Titulo.Controls.Add(this.B_Maximizar);
            this.P_Titulo.Controls.Add(this.B_Close);
            this.P_Titulo.Controls.Add(this.B_CloseChildForm);
            this.P_Titulo.Controls.Add(this.L_Titulo);
            this.P_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Titulo.Location = new System.Drawing.Point(230, 0);
            this.P_Titulo.Name = "P_Titulo";
            this.P_Titulo.Size = new System.Drawing.Size(831, 64);
            this.P_Titulo.TabIndex = 1;
            this.P_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_Titulo_MouseDown);
            // 
            // B_Minimizar
            // 
            this.B_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Minimizar.FlatAppearance.BorderSize = 0;
            this.B_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Minimizar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Minimizar.ForeColor = System.Drawing.Color.Black;
            this.B_Minimizar.Location = new System.Drawing.Point(705, 3);
            this.B_Minimizar.Name = "B_Minimizar";
            this.B_Minimizar.Size = new System.Drawing.Size(37, 34);
            this.B_Minimizar.TabIndex = 1;
            this.B_Minimizar.Text = "-";
            this.B_Minimizar.UseVisualStyleBackColor = true;
            this.B_Minimizar.Click += new System.EventHandler(this.B_Minimizar_Click);
            // 
            // B_Maximizar
            // 
            this.B_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Maximizar.FlatAppearance.BorderSize = 0;
            this.B_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Maximizar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Maximizar.ForeColor = System.Drawing.Color.Black;
            this.B_Maximizar.Location = new System.Drawing.Point(748, 3);
            this.B_Maximizar.Name = "B_Maximizar";
            this.B_Maximizar.Size = new System.Drawing.Size(37, 34);
            this.B_Maximizar.TabIndex = 1;
            this.B_Maximizar.Text = "O";
            this.B_Maximizar.UseVisualStyleBackColor = true;
            this.B_Maximizar.Click += new System.EventHandler(this.B_Maximizar_Click);
            // 
            // B_Close
            // 
            this.B_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Close.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.Black;
            this.B_Close.Location = new System.Drawing.Point(791, 3);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(37, 34);
            this.B_Close.TabIndex = 1;
            this.B_Close.Text = "X";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_CloseChildForm
            // 
            this.B_CloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_CloseChildForm.FlatAppearance.BorderSize = 0;
            this.B_CloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CloseChildForm.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_CloseChildForm.ForeColor = System.Drawing.Color.White;
            this.B_CloseChildForm.Location = new System.Drawing.Point(6, 3);
            this.B_CloseChildForm.Name = "B_CloseChildForm";
            this.B_CloseChildForm.Size = new System.Drawing.Size(49, 34);
            this.B_CloseChildForm.TabIndex = 1;
            this.B_CloseChildForm.Text = "<>";
            this.B_CloseChildForm.UseVisualStyleBackColor = true;
            this.B_CloseChildForm.Click += new System.EventHandler(this.B_CloseChildForm_Click);
            // 
            // L_Titulo
            // 
            this.L_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Titulo.AutoSize = true;
            this.L_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L_Titulo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Titulo.ForeColor = System.Drawing.Color.Black;
            this.L_Titulo.Location = new System.Drawing.Point(331, 16);
            this.L_Titulo.Name = "L_Titulo";
            this.L_Titulo.Size = new System.Drawing.Size(82, 28);
            this.L_Titulo.TabIndex = 0;
            this.L_Titulo.Text = "INICIO";
            // 
            // P_DesktopPane
            // 
            this.P_DesktopPane.Controls.Add(this.P_Floot);
            this.P_DesktopPane.Controls.Add(this.PB_Logo);
            this.P_DesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_DesktopPane.Location = new System.Drawing.Point(230, 64);
            this.P_DesktopPane.Name = "P_DesktopPane";
            this.P_DesktopPane.Size = new System.Drawing.Size(831, 537);
            this.P_DesktopPane.TabIndex = 2;
            this.P_DesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.P_DesktopPane_Paint);
            // 
            // P_Floot
            // 
            this.P_Floot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.P_Floot.Controls.Add(this.L_Hora);
            this.P_Floot.Controls.Add(this.L_Fecha);
            this.P_Floot.Controls.Add(this.L_UsuarioConectado);
            this.P_Floot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.P_Floot.Location = new System.Drawing.Point(0, 497);
            this.P_Floot.Name = "P_Floot";
            this.P_Floot.Size = new System.Drawing.Size(831, 40);
            this.P_Floot.TabIndex = 2;
            // 
            // L_Hora
            // 
            this.L_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Hora.AutoSize = true;
            this.L_Hora.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.L_Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.L_Hora.Location = new System.Drawing.Point(631, 8);
            this.L_Hora.Name = "L_Hora";
            this.L_Hora.Size = new System.Drawing.Size(57, 25);
            this.L_Hora.TabIndex = 0;
            this.L_Hora.Text = "Hora";
            // 
            // L_Fecha
            // 
            this.L_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Fecha.AutoSize = true;
            this.L_Fecha.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.L_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.L_Fecha.Location = new System.Drawing.Point(421, 8);
            this.L_Fecha.Name = "L_Fecha";
            this.L_Fecha.Size = new System.Drawing.Size(66, 25);
            this.L_Fecha.TabIndex = 0;
            this.L_Fecha.Text = "Fecha";
            // 
            // L_UsuarioConectado
            // 
            this.L_UsuarioConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_UsuarioConectado.AutoSize = true;
            this.L_UsuarioConectado.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.L_UsuarioConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.L_UsuarioConectado.Location = new System.Drawing.Point(6, 9);
            this.L_UsuarioConectado.Name = "L_UsuarioConectado";
            this.L_UsuarioConectado.Size = new System.Drawing.Size(55, 25);
            this.L_UsuarioConectado.TabIndex = 0;
            this.L_UsuarioConectado.Text = "Hola";
            // 
            // T_FechaHora
            // 
            this.T_FechaHora.Enabled = true;
            this.T_FechaHora.Interval = 1000;
            this.T_FechaHora.Tick += new System.EventHandler(this.T_FechaHora_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 601);
            this.Controls.Add(this.P_DesktopPane);
            this.Controls.Add(this.P_Titulo);
            this.Controls.Add(this.P_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.P_Menu.ResumeLayout(false);
            this.P_SubVenta.ResumeLayout(false);
            this.P_SubMantenimiento.ResumeLayout(false);
            this.P_Logo.ResumeLayout(false);
            this.P_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.P_Titulo.ResumeLayout(false);
            this.P_Titulo.PerformLayout();
            this.P_DesktopPane.ResumeLayout(false);
            this.P_Floot.ResumeLayout(false);
            this.P_Floot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Menu;
        private System.Windows.Forms.Panel P_Logo;
        private System.Windows.Forms.Panel P_SubVenta;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IconButton_Venta;
        private FontAwesome.Sharp.IconButton IB_Venta;
        private System.Windows.Forms.Panel P_SubMantenimiento;
        private FontAwesome.Sharp.IconButton IB_Vendedor;
        private FontAwesome.Sharp.IconButton IB_Producto;
        private FontAwesome.Sharp.IconButton IB_Fabricante;
        private FontAwesome.Sharp.IconButton IB_Cliente;
        private FontAwesome.Sharp.IconButton IB_Salir;
        private FontAwesome.Sharp.IconButton IB_Mantenimiento;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Panel P_Titulo;
        private System.Windows.Forms.Label L_Titulo;
        private System.Windows.Forms.Panel P_DesktopPane;
        private System.Windows.Forms.Button B_CloseChildForm;
        private System.Windows.Forms.Button B_Minimizar;
        private System.Windows.Forms.Button B_Maximizar;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Label L_Logo;
        private System.Windows.Forms.Panel P_Floot;
        private System.Windows.Forms.Label L_UsuarioConectado;
        private System.Windows.Forms.Label L_Hora;
        private System.Windows.Forms.Label L_Fecha;
        private System.Windows.Forms.Timer T_FechaHora;
        private FontAwesome.Sharp.IconButton IconButton_Ayuda;
    }
}