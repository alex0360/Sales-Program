using FontAwesome.Sharp;
using Negocios;
using Presentacion.Config;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormVenta : Form
    {
        Entidades.Producto Producto;
        public static int idProducto = 0;
        public static string Concepto;
        public static int Precio = 0;
        public static int Cantidad = 0;

        Entidades.Vendedor Vendedor;
        public static int idVendedor = 0;
        public static string VendedorNombre;

        Entidades.Cliente Cliente;
        public static int idCliente = 0;

        Entidades.Venta VentaEntidad;
        Negocios.Venta VentaNegocio;

        Negocios.Impresora Impresora;
        Negocios.Ticket Ticket;

        public FormVenta()
        {
            InitializeComponent();
            _ReSize();
        }
        private void FormVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            LoadTheme();
            ReSize._get_initial_size();
            SetupColumnsCargadas();
        }
        #region ReSize
        private ReSize ReSize;
        private void _ReSize()
        {
            ReSize = new ReSize(this);
            this.Load += FormVenta_Load;
            this.Resize += _Resize;
        }
        private void _Resize(object sender, EventArgs e) => ReSize._resize();
        #endregion
        protected void LoadTheme(Label Titulo = null, Label SubTitulo = null, Label SubTitulo2 = null)
        {

            foreach(Control control in this.Controls)
            {
                Button button; IconButton iconButton; IconPictureBox iconPictureBox; DataGridView dataGridView;
                if(control.GetType() == typeof(Button))
                {
                    button = (Button)control;
                    button.BackColor = ThemeColor.Primary;
                    button.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);
                    button.FlatAppearance.BorderColor = ThemeColor.Secondary;
                }

                if(control.GetType() == typeof(IconButton))
                {
                    iconButton = (IconButton)control;
                    iconButton.BackColor = ThemeColor.Primary;
                    iconButton.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);
                    iconButton.FlatAppearance.BorderColor = ThemeColor.Secondary;
                    iconButton.IconColor = ThemeColor.Secondary;
                }

                if(control.GetType() == typeof(IconPictureBox))
                {
                    iconPictureBox = (IconPictureBox)control;
                    iconPictureBox.BackColor = ThemeColor.Primary;
                    iconPictureBox.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);
                    iconPictureBox.IconColor = ThemeColor.Secondary;
                }

                if(control.GetType() == typeof(DataGridView))
                {
                    dataGridView = (DataGridView)control;
                    dataGridView.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);

                    dataGridView.RowsDefaultCellStyle.BackColor = ThemeColor.Primary;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.2);

                    dataGridView.RowHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.5);

                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.5);
                    dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.5);
                }

            }
            if(Titulo != null)
                Titulo.ForeColor = ThemeColor.Secondary;
            if(SubTitulo != null)
                SubTitulo.ForeColor = ThemeColor.Primary;
            if(SubTitulo2 != null)
                SubTitulo2.ForeColor = ThemeColor.Primary;
        }

        private void IconButton_Vendedor_Click(object sender, EventArgs e)
        {
            if(Vendedor == null)
            {
                Vendedor = new Entidades.Vendedor();
            }

            Config.Forms.FormVendedorBuscar form = new Config.Forms.FormVendedorBuscar(TextBox_Vendedor.Text)
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowInTaskbar = false
            };

            form.ShowDialog();

            if(idVendedor == 0)
            {
                TextBox_Vendedor.Text = string.Empty;
            }
            else
            {
                TextBox_Vendedor.Text = idVendedor.ToString();
            }
        }

        private void IconButton_Codigo_Click(object sender, EventArgs e)
        {
            if(Producto == null)
            {
                Producto = new Entidades.Producto();
            }

            Config.Forms.FormProductoBuscar form = new Config.Forms.FormProductoBuscar(TextBox_Codigo.Text)
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowInTaskbar = false
            };

            form.ShowDialog();

            if(idProducto == 0)
            {
                TextBox_Codigo.Text = string.Empty;
            }
            else
            {
                TextBox_Codigo.Text = idProducto.ToString();
                Label_MostrarPrecio.Text = Precio.ToString();
                TextBox_Cantidad.Text = string.Format("1");
            }
        }

        private void IconButton_Cliente_Click(object sender, EventArgs e)
        {
            if(Cliente == null)
            {
                Cliente = new Entidades.Cliente();
            }

            Config.Forms.FormClienteBuscar form = new Config.Forms.FormClienteBuscar(TextBox_Cliente.Text)
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowInTaskbar = false
            };

            form.ShowDialog();

            if(idCliente == 0)
            {
                TextBox_Cliente.Text = string.Empty;
            }
            else
            {
                TextBox_Cliente.Text = idCliente.ToString();
            }
        }

        private void IconButton_Add_Click(object sender, EventArgs e)
        {
            if(TextBox_Cantidad.Text == string.Empty)
            {
                return;
            }

            if(int.Parse(TextBox_Cantidad.Text) > Cantidad)
            {
                MessageBox.Show("Cantidad a Despachar es mayor que la existencia");
                TextBox_Cantidad.Focus();
            }
            else
            {

                try
                {
                    if(TextBox_Codigo.Text == "")
                    {
                        MessageBox.Show("Debes seleccionar un codigo de Producto");
                        TextBox_Codigo.Focus();
                    }
                    else
                    {
                        var total = (Convert.ToInt16(Label_MostrarPrecio.Text) * Convert.ToInt16(TextBox_Cantidad.Text)).ToString();

                        AgragarDGV(TextBox_Codigo.Text, Concepto, TextBox_Cantidad.Text, Label_MostrarPrecio.Text, total.ToString());

                        LimpiarProductos();
                    }
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
        private void IconButton_Menos_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.DGV_Data.Rows.Count > 0)
                {

                    if(MessageBox.Show("¿Está seguro de restaurar quitar de la lista el producto con el codigo " + DGV_Data.Rows[DGV_Data.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Quitar Concepto de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DGV_Data.Rows.RemoveAt(DGV_Data.CurrentRow.Index);

                        Label_MostrarTotalPagar.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("No existen Conceptos registrados, para eliminar");

                    Calcular();
                }
            }
            catch(Exception)
            {

                throw;
            }
        }

        #region DataGridView

        private void SetupColumnsCargadas()
        {
            DGV_Data.Columns.Clear();

            DGV_Data.ScrollBars = ScrollBars.Both;

            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "CodProducto";
            IdColumn.HeaderText = "ID#";
            IdColumn.Frozen = true;
            IdColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(IdColumn);
            IdColumn.Width = 25;

            DataGridViewTextBoxColumn DescProductColumn = new DataGridViewTextBoxColumn();
            DescProductColumn.DataPropertyName = "Concepto";
            DescProductColumn.HeaderText = "Concepto";
            DescProductColumn.Frozen = true;
            DescProductColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(DescProductColumn);

            DataGridViewTextBoxColumn CantidadColumn = new DataGridViewTextBoxColumn();
            CantidadColumn.DataPropertyName = "Cantidad";
            CantidadColumn.HeaderText = "Cantidad";
            CantidadColumn.Frozen = true;
            CantidadColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(CantidadColumn);

            DataGridViewTextBoxColumn PrecioColumn = new DataGridViewTextBoxColumn();
            PrecioColumn.DataPropertyName = "Precio";
            PrecioColumn.HeaderText = "Precio";
            PrecioColumn.Frozen = true;
            PrecioColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(PrecioColumn);

            DataGridViewTextBoxColumn TotalColumn = new DataGridViewTextBoxColumn();
            TotalColumn.DataPropertyName = "Total";
            TotalColumn.HeaderText = "Total";
            TotalColumn.Frozen = true;
            TotalColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(TotalColumn);

            DGV_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void AgragarDGV(String CodProducto, String Concepto, String Cantidad, String Precio, String Total)
        {
            int go = 1;

            if(this.DGV_Data.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in DGV_Data.Rows)
                {
                    if(row.Cells[0].Value.ToString() == CodProducto)
                    {
                        go = 0;
                        row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + int.Parse(Cantidad);
                        MessageBox.Show("El articulo " + row.Cells[1].Value.ToString() + " ya esta agregado,");
                    }
                }
            }
            if(go == 1)
            {
                DGV_Data.Rows.Add();

                int fila = this.DGV_Data.Rows.Count - 1;
                DGV_Data.Rows[fila].Cells[0].Value = CodProducto;
                DGV_Data.Rows[fila].Cells[1].Value = Concepto;
                DGV_Data.Rows[fila].Cells[2].Value = Cantidad;
                DGV_Data.Rows[fila].Cells[3].Value = Precio;
            }

            Calcular();
        }

        private void LimpiarProductos()
        {
            TextBox_Codigo.Text = string.Empty;
            TextBox_Cantidad.Text = string.Empty;
            Label_MostrarPrecio.Text = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Concepto = string.Empty;

        }

        private void Calcular()
        {
            var productoIDs = "";
            var productoscant = "";

            if(this.DGV_Data.Rows.Count > 0)
            {
                double total = 0;
                CultureInfo culture2 = new CultureInfo("en-US");

                foreach(DataGridViewRow row in DGV_Data.Rows)
                {
                    productoIDs += row.Cells[0].Value.ToString().Trim() + ",";
                    productoscant += row.Cells[2].Value.ToString() + ",";
                    double cant = double.Parse(row.Cells[2].Value.ToString(), culture2);
                    double costo = double.Parse(row.Cells[3].Value.ToString(), culture2);
                    double subtotal = cant * costo;
                    total += subtotal;
                    row.Cells[4].Value = String.Format(culture2, "{0:n}", subtotal);
                }

                Label_MostrarTotalPagar.Text = String.Format(culture2, "{0:n}", total);
            }
        }

        #endregion
        private string Factura()
        {
            return Negocios.Encriptacion.MD5(
                TextBox_Cliente.Text + TextBox_Vendedor.Text +
                TextBox_Codigo.Text + TextBox_Cantidad.Text +
                DateTime.Now.ToString()).Substring(1, 6);
        }

        private void IconButton_Procesar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void FormVenta_Resize(object sender, EventArgs e)
        {
            IconButton_Procesar.Height = 47;
            IconButton_Add.Height = 47;
            IconButton_Menos.Height = 47;
        }
        private void TB_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void IconButton_Vendedor_Cliente_Codigo_Resize(object sender, EventArgs e)
        {
            IconButton_Cliente.Height = 27;
            IconButton_Vendedor.Height = 27;
            IconButton_Codigo.Height = 27;
        }

        //--------------------------
        //CODIGO DEL BOTON DE GRABAR
        //--------------------------

        private void Grabar()
        {

            try
            {
                if(TextBox_Vendedor.Text == string.Empty
                    && TextBox_Cliente.Text == string.Empty)
                {
                    MessageBox.Show("Agregar Vendedor y Cliente");
                }

                var controls = new Control[]
                    { TextBox_Vendedor, TextBox_Cliente, TextBox_Codigo, TextBox_Cantidad};

                var sale = new Negocios.Seller(controls, DGV_Data);

                VentaEntidad = sale.SaleEntity;
                VentaNegocio = sale.SaleBusiness;

                string invoice = Biller.GenerateInvoice(
                    TextBox_Cliente.Text + TextBox_Vendedor.Text +
                    TextBox_Codigo.Text + TextBox_Cantidad.Text +
                    DateTime.Now.ToString()
                );

                sale.Post(invoice);

                TicketFactura();
                SetupColumnsCargadas();
                LimpiarProductos();

                TextBox_Cliente.Text = string.Empty;
                TextBox_Vendedor.Text = string.Empty;
                Label_MostrarTotalPagar.Text = string.Empty;

                MessageBox.Show("Gracias por preferirnos");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void TicketFactura()
        {
            if(VentaEntidad == null)
            {
                VentaEntidad = new Entidades.Venta();
            }
            if(Ticket == null)
            {
                Ticket = new Negocios.Ticket();
            }
            Ticket.TextoCentro("**********************************");
            Ticket.TextoCentro("*          Empresa xxxxx         *");
            Ticket.TextoCentro("**********************************");
            Ticket.TextoCentro("**********************************");

            Ticket.TextoIzquierda("Dirc: xxxx");
            Ticket.TextoIzquierda("Tel: xxxx ");
            Ticket.TextoIzquierda("Rnc: xxxx");
            Ticket.TextoIzquierda("");
            Ticket.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket.TextoIzquierda("No Fac: " + VentaEntidad.Factura.ToString());
            Ticket.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToShortTimeString());
            Ticket.TextoIzquierda("Le Atendio: " + VendedorNombre);
            Ticket.TextoIzquierda("");
            Negocios.Ticket.LineasGuion();//-------------------------

            Negocios.Ticket.EncabezadoVenta();
            Negocios.Ticket.LineasGuion();
            //Detalle de la factura
            foreach(DataGridViewRow rows in DGV_Data.Rows)
            {
                if(rows.Cells[1].Value.ToString().Length > 15)
                {
                    Ticket.AgregaArticulo(articulo: rows.Cells[1].Value.ToString().Substring(0, 15).ToLower(),
                    int.Parse(rows.Cells[2].Value.ToString()),//Cantidad
                    int.Parse(rows.Cells[3].Value.ToString()),//Precio 
                    double.Parse(rows.Cells[4].Value.ToString())); //SubTotal
                }
                else
                {
                    Ticket.AgregaArticulo(articulo: rows.Cells[1].Value.ToString().ToLower(),
                    int.Parse(rows.Cells[2].Value.ToString()),//Cantidad
                    int.Parse(rows.Cells[3].Value.ToString()),//Precio 
                    double.Parse(rows.Cells[4].Value.ToString())); //SubTotal
                }
            }

            Negocios.Ticket.LineasGuion();
            Ticket.AgregaTotales("Sub-Total", double.Parse(Label_MostrarTotalPagar.Text)); // imprime linea con Subtotal
            Ticket.AgregaTotales("Descuento", double.Parse("000")); // imprime linea con decuento total
            Ticket.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
            Ticket.TextoIzquierda(" ");
            Ticket.AgregaTotales("Total", double.Parse(Label_MostrarTotalPagar.Text)); // imprime linea con total
            Ticket.TextoIzquierda(" ");
            Ticket.AgregaTotales("Efectivo Entregado: ", double.Parse(Label_MostrarTotalPagar.Text));
            Ticket.AgregaTotales("Efectivo Devuelto: ", double.Parse("000"));

            // Ticket1.LineasTotales(); // imprime linea 

            Ticket.TextoIzquierda(" ");
            Ticket.TextoCentro("**********************************");
            Ticket.TextoCentro("*     Gracias por preferirnos    *");
            Ticket.TextoCentro("**********************************");
            Ticket.TextoIzquierda(" ");

            if(Impresora == null)
            {
                Impresora = new Negocios.Impresora();
            }

            if(Impresora.impresoraDisponible.Count > 0)
                Ticket.ImprimirTiket();
        }
    }
}