using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Config.Forms {
    public partial class FormClienteBuscar : FormBaseBuscar {
        string textBuscar;
        Negocios.Cliente obj;
        public FormClienteBuscar(string param) {
            InitializeComponent();
            textBuscar = param;
        }

        private void TextBox_Buscar_Enter(object sender, EventArgs e) {
            if(TextBox_Buscar.Text == "   Desc  o ID") {
                TextBox_Buscar.Text = string.Empty;
                TextBox_Buscar.ForeColor = Color.Black;
            }
        }

        private void TextBox_Buscar_Leave(object sender, EventArgs e) {
            if(TextBox_Buscar.Text == string.Empty) {
                TextBox_Buscar.Text = "   Desc  o ID";
                TextBox_Buscar.ForeColor = Config.Colores.Secudary;
            }
        }

        protected override void IconButton_Codigo_Click(object sender, EventArgs e) {
            if(TextBox_Buscar.Text != "   Desc  o ID") {
                int fila = DGV_Data.CurrentRow.Index;

                FormVenta.idCliente = int.Parse(DGV_Data.Rows[fila].Cells[0].Value.ToString());
                Close();
            }
        }

        public void CargarDGV() {
            if(obj == null) {
                obj = new Negocios.Cliente();
            }
            var data = obj.MostrarBuscar(textBuscar);

            DGV_Data.Columns.Clear();

            //DGV_Data.ScrollBars = ScrollBars.Both;

            DataGridViewTextBoxColumn IdClienteColumn = new DataGridViewTextBoxColumn();
            IdClienteColumn.DataPropertyName = "ID_CLIENTE";
            IdClienteColumn.HeaderText = "ID#";
            IdClienteColumn.Frozen = true;
            IdClienteColumn.ValueType = typeof(int);
            DGV_Data.Columns.Add(IdClienteColumn);


            DataGridViewTextBoxColumn NombClienteColumn = new DataGridViewTextBoxColumn();
            NombClienteColumn.DataPropertyName = "NOMB_CLIENTE";
            NombClienteColumn.HeaderText = "Nombre";
            NombClienteColumn.Width = 250;
            NombClienteColumn.Frozen = true;
            NombClienteColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(NombClienteColumn);

            DGV_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DGV_Data.DataSource = data;
        }

        protected override void FormBaseBuscar_Load(object sender, EventArgs e) {
            CargarDGV();
        }

        private void TextBox_Buscar_TextChanged(object sender, EventArgs e) {
            if(obj == null) {
                obj = new Negocios.Cliente();
            }
            DGV_Data.DataSource = obj.MostrarBuscar(TextBox_Buscar.Text);
        }

        protected override void DGV_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => SelectToEditItem();
        protected void SelectToEditItem() {
            try {
                int fila = DGV_Data.CurrentRow.Index;

                if(DGV_Data.Rows.Count != 0) {
                    FormVenta.idCliente = int.Parse(DGV_Data.Rows[fila].Cells[0].Value.ToString());
                    Close();
                } else {
                    MessageBox.Show("Debe seleccionar un elemento de la lista",
                        "Información del Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Información del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
