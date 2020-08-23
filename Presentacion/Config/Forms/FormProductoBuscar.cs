using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Config.Forms
{
    public partial class FormProductoBuscar : FormBaseBuscar
    {
        string textBuscar;
        Negocios.Producto obj;
        public FormProductoBuscar(string param)
        {
            InitializeComponent();
            textBuscar = param;
        }

        private void TextBox_Buscar_Enter(object sender, EventArgs e)
        {
            if (TextBox_Buscar.Text == "   Desc  o ID")
            {
                TextBox_Buscar.Text = string.Empty;
                TextBox_Buscar.ForeColor = Color.Black;
            }
        }

        private void TextBox_Buscar_Leave(object sender, EventArgs e)
        {
            if (TextBox_Buscar.Text == string.Empty)
            {
                TextBox_Buscar.Text = "   Desc  o ID";
                TextBox_Buscar.ForeColor = Config.Colores.Secudary;
            }
        }

        protected override void IconButton_Codigo_Click(object sender, EventArgs e)
        {
            if (TextBox_Buscar.Text != "   Desc  o ID")
            {
                CargarValor();
                Close();
            }
        }

        private void CargarValor()
        {
            int fila = DGV_Data.CurrentRow.Index;
            FormVenta.idProducto = int.Parse(DGV_Data.Rows[fila].Cells[0].Value.ToString());
            FormVenta.Concepto = DGV_Data.Rows[fila].Cells[1].Value.ToString();
            FormVenta.Precio = int.Parse(DGV_Data.Rows[fila].Cells[4].Value.ToString());
            FormVenta.Cantidad = int.Parse(DGV_Data.Rows[fila].Cells[5].Value.ToString());
        }

        public void CargarDGV()
        {
            if (obj == null)
            {
                obj = new Negocios.Producto();
            }
            var data = obj.MostrarBuscar(textBuscar);

            DGV_Data.Columns.Clear();

            DGV_Data.ScrollBars = ScrollBars.Both;

            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "ID_PRODUCTO";
            IdColumn.HeaderText = "ID#";
            IdColumn.Frozen = true;
            IdColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(IdColumn);
            IdColumn.Width = 25;

            DataGridViewTextBoxColumn DescProductColumn = new DataGridViewTextBoxColumn();
            DescProductColumn.DataPropertyName = "DESC_PRODUCTO";
            DescProductColumn.HeaderText = "Descripcion";
            DescProductColumn.Frozen = true;
            DescProductColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(DescProductColumn);

            DGV_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DGV_Data.DataSource = data;
        }

        private void FormProductoBuscar_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void TextBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (obj == null)
            {
                obj = new Negocios.Producto();
            }
            DGV_Data.DataSource = obj.MostrarBuscar(TextBox_Buscar.Text);
        }

        protected override void DGV_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => SelectToEditItem();
        protected void SelectToEditItem()
        {
            try
            {
               
                if (DGV_Data.Rows.Count != 0)
                {
                    CargarValor();
                    Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista",
                        "Información del Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
