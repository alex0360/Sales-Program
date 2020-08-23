using FontAwesome.Sharp;
using Presentacion.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        Entidades.Cliente Cliente;
        public static int idCliente = 0;

        Negocios.Venta VentaNegocio;
        Entidades.Venta VentaEntidad;
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

            foreach (Control control in this.Controls)
            {
                Button button; IconButton iconButton; IconPictureBox iconPictureBox; DataGridView dataGridView;
                if (control.GetType() == typeof(Button))
                {
                    button = (Button)control;
                    button.BackColor = ThemeColor.Primary;
                    button.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);
                    button.FlatAppearance.BorderColor = ThemeColor.Secondary;
                }
                if (control.GetType() == typeof(IconButton))
                {
                    iconButton = (IconButton)control;
                    iconButton.BackColor = ThemeColor.Primary;
                    iconButton.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);
                    iconButton.FlatAppearance.BorderColor = ThemeColor.Secondary;
                    iconButton.IconColor = ThemeColor.Secondary;
                }
                if (control.GetType() == typeof(IconPictureBox))
                {
                    iconPictureBox = (IconPictureBox)control;
                    iconPictureBox.BackColor = ThemeColor.Primary;
                    iconPictureBox.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);
                    iconPictureBox.IconColor = ThemeColor.Secondary;
                }
                if (control.GetType() == typeof(DataGridView))
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
            if (Titulo != null)
                Titulo.ForeColor = ThemeColor.Secondary;
            if (SubTitulo != null)
                SubTitulo.ForeColor = ThemeColor.Primary;
            if (SubTitulo2 != null)
                SubTitulo2.ForeColor = ThemeColor.Primary;
        }

        private void IconButton_Vendedor_Click(object sender, EventArgs e)
        {
            if (Vendedor == null)
            {
                Vendedor = new Entidades.Vendedor();
            }
            Config.Forms.FormVendedorBuscar form = new Config.Forms.FormVendedorBuscar(TextBox_Vendedor.Text);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
            form.ShowDialog();

            if (idVendedor == 0) TextBox_Vendedor.Text = string.Empty;
            else TextBox_Vendedor.Text = idVendedor.ToString();
        }

        private void IconButton_Codigo_Click(object sender, EventArgs e)
        {
            if (Producto == null)
            {
                Producto = new Entidades.Producto();
            }
            Config.Forms.FormProductoBuscar form = new Config.Forms.FormProductoBuscar(TextBox_Codigo.Text);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
            form.ShowDialog();

            if (idProducto == 0) TextBox_Codigo.Text = string.Empty;
            else
            {
                TextBox_Codigo.Text = idProducto.ToString();
                Label_MostrarPrecio.Text = Precio.ToString();
                TextBox_Cantidad.Text = string.Format("1");
            }
        }

        private void IconButton_Cliente_Click(object sender, EventArgs e)
        {
            if (Cliente == null)
            {
                Cliente = new Entidades.Cliente();
            }
            Config.Forms.FormClienteBuscar form = new Config.Forms.FormClienteBuscar(TextBox_Cliente.Text);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
            form.ShowDialog();

            if (idCliente == 0) TextBox_Cliente.Text = string.Empty;
            else TextBox_Cliente.Text = idCliente.ToString();
        }

        private void IconButton_Add_Click(object sender, EventArgs e)
        {
            if (TextBox_Cantidad.Text != string.Empty)
                if (int.Parse(TextBox_Cantidad.Text) > Cantidad)
                {
                    MessageBox.Show("Cantidad a Despachar es mayor que la existencia");
                    TextBox_Cantidad.Focus();
                }
                else
                {

                    try
                    {
                        if (TextBox_Codigo.Text == "")
                        {
                            MessageBox.Show("Debes seleccionar un codigo de Producto");
                            TextBox_Codigo.Focus();
                        }
                        else
                        {
                            //validar = ExisteDatoEnGrid(Convert.ToInt16(Txt_CodProducto.Text));
                            var total = (Convert.ToInt16(Label_MostrarPrecio.Text) * Convert.ToInt16(TextBox_Cantidad.Text)).ToString();
                            AgragarDGV(TextBox_Codigo.Text, Concepto, TextBox_Cantidad.Text, Label_MostrarPrecio.Text, total.ToString());
                            //Txt_CodProducto.Clear();
                            //Txt_Cant.Clear();
                            //Lbl_MensConcepto.Visible = false;
                            //Lbl_MensPrec.Visible = false;
                            LimpiarProductos();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
        }
        private void IconButton_Menos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DGV_Data.Rows.Count > 0)
                {

                    if (MessageBox.Show("¿Está seguro de restaurar quitar de la lista el producto con el codigo " + DGV_Data.Rows[DGV_Data.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Quitar Concepto de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

            catch (Exception)
            {

                throw;
            }
        }

        #region DataGridView

        private void SetupColumnsCargadas()
        {
            DGV_Data.Columns.Clear();

            DGV_Data.ScrollBars = ScrollBars.Both;

            //DGV_Data.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows.

            // Set the row and column header styles.

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
            if (this.DGV_Data.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Data.Rows)
                {
                    if (row.Cells[0].Value.ToString() == CodProducto)
                    {
                        go = 0;
                        row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + int.Parse(Cantidad);
                        MessageBox.Show("El articulo " + row.Cells[1].Value.ToString() + " ya esta agregado,");
                    }
                }
            }
            if (go == 1)
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

        string productoIDs;
        string productoscant;
        private void Calcular()
        {
            productoIDs = "";
            productoscant = "";
            if (this.DGV_Data.Rows.Count > 0)
            {
                double total = 0;
                CultureInfo culture2 = new CultureInfo("en-US");

                foreach (DataGridViewRow row in DGV_Data.Rows)
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
                //calcdesc();
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
                if (VentaNegocio == null)
                {
                    VentaNegocio = new Negocios.Venta();
                }
                string factura = Factura();

                //Verificar si existe el No. de Record

                bool valida = false;

                valida = Convert.ToBoolean(VentaNegocio.MostrarBuscar(factura));

                if (TextBox_Vendedor.Text == string.Empty && TextBox_Cliente.Text == string.Empty)
                    MessageBox.Show("Agregar Vendedor y Cliente");
                else
                {
                    if (DGV_Data.Rows.Count > 0)
                    {
                        if (VentaEntidad == null)
                        {
                            VentaEntidad = new Entidades.Venta();
                        }

                        VentaEntidad.Factura = factura;
                        VentaEntidad.Fecha = DateTime.Now;
                        VentaEntidad.IdCliente = int.Parse(TextBox_Cliente.Text);
                        VentaEntidad.IdVendedor = int.Parse(TextBox_Vendedor.Text);
                        for (int i = 0; i <= DGV_Data.Rows.Count - 1; i++)
                        {
                            VentaEntidad.IdProduccto = Convert.ToInt16(DGV_Data.Rows[i].Cells[0].Value.ToString());
                            VentaEntidad.Cantidad = Convert.ToInt16(DGV_Data.Rows[i].Cells[2].Value.ToString());

                            VentaNegocio.InsertarVentas(VentaEntidad);
                        }
                        SetupColumnsCargadas();
                        LimpiarProductos();

                        TextBox_Cliente.Text = string.Empty;
                        TextBox_Vendedor.Text = string.Empty;
                        MessageBox.Show("Venta Realizada Correctamente");
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show("Error:" + ex); }
        }
    }
}