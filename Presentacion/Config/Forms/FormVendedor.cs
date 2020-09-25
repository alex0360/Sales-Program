using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Config.Forms {
    public partial class FormVendedor : FormBase {
        Negocios.Vendedor obj;
        DataSet dataSet;
        int id = 0;
        public FormVendedor() {
            InitializeComponent();

            _ReSize();
        }

        private void FormVendedor_Load(object sender, EventArgs e) {
            this.Top = 0;
            this.Left = 0;
            LoadTheme(L_Registros);
            MostrarTodoslosRegistrosCargados();
            ReSize._get_initial_size();
        }

        #region ReSize
        private ReSize ReSize;
        private void _ReSize() {
            ReSize = new ReSize(this);
            this.Load += FormVendedor_Load;
            this.Resize += _Resize;
        }

        private void _Resize(object sender, EventArgs e) => ReSize._resize();

        private void IB_Buscar_Resize(object sender, EventArgs e) {
            IB_Buscar.Height = TB_ID.Size.Height;
        }
        #endregion

        #region DataGridView
        private void MostrarTodoslosRegistrosCargados() {
            try {
                if(obj == null) {
                    obj = new Negocios.Vendedor();
                }
                //DSQL.Tables["VerRecord"].Clear();
                DGV_Data.AutoGenerateColumns = false;

                dataSet = obj.Mostrar();
                SetupColumnsCargadas(dataSet);
                DGV_Data.DataSource = dataSet;

                DGV_Data.DataMember = "VerRecord";
                //lbl_total.Visible = true;

            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetupColumnsCargadas(DataSet dataSet) {
            DGV_Data.Columns.Clear();

            DGV_Data.ScrollBars = ScrollBars.Both;

            //DGV_Data.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows.

            // Set the row and column header styles.

            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "ID_VENDEDOR";
            IdColumn.HeaderText = "ID#";
            IdColumn.Frozen = true;
            IdColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(IdColumn);
            IdColumn.Width = 25;

            DataGridViewTextBoxColumn NombreVendedorColumn = new DataGridViewTextBoxColumn();
            NombreVendedorColumn.DataPropertyName = "NOMB_VENDEDOR";
            NombreVendedorColumn.HeaderText = "Nombre";
            NombreVendedorColumn.Frozen = true;
            NombreVendedorColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(NombreVendedorColumn);

            DataGridViewTextBoxColumn OficinaColumn = new DataGridViewTextBoxColumn();
            OficinaColumn.DataPropertyName = "OFICINA";
            OficinaColumn.HeaderText = "Oficina";
            OficinaColumn.Frozen = true;
            OficinaColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(OficinaColumn);

            DataGridViewTextBoxColumn ComisionColumn = new DataGridViewTextBoxColumn();
            ComisionColumn.DataPropertyName = "COMISION";
            ComisionColumn.HeaderText = "Comision";
            ComisionColumn.Frozen = true;
            ComisionColumn.ValueType = typeof(string);
            DGV_Data.Columns.Add(ComisionColumn);

            DGV_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

        #region Eventos Enter y Leave
        private void TB_Nombre_Enter(object sender, EventArgs e) {
            if(TB_Nombre.Text == "   Nombre") {
                TB_Nombre.Text = string.Empty;
                TB_Nombre.ForeColor = Color.Black;
            }
        }

        private void TB_Nombre_Leave(object sender, EventArgs e) {
            if(TB_Nombre.Text == string.Empty) {
                TB_Nombre.Text = "   Nombre";
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_ID_Enter(object sender, EventArgs e) {
            if(TB_ID.Text == "   Codigo") {
                TB_ID.Text = string.Empty;
                TB_ID.ForeColor = Color.Black;
            }
        }

        private void TB_ID_Leave(object sender, EventArgs e) {
            if(TB_ID.Text == string.Empty) {
                TB_ID.Text = "   Codigo";
                TB_ID.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_Oficina_Enter(object sender, EventArgs e) {
            if(TB_Oficina.Text == "   Oficina") {
                TB_Oficina.Text = string.Empty;
                TB_Oficina.ForeColor = Color.Black;
            }
        }

        private void TB_Oficina_Leave(object sender, EventArgs e) {
            if(TB_Oficina.Text == string.Empty) {
                TB_Oficina.Text = "   Oficina";
                TB_Oficina.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_ID_KeyPress(object sender, KeyPressEventArgs e) {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) {
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void IB_Buscar_Click(object sender, EventArgs e) {
            string parametro = "";
            int VARIABLE = 0;
            obj = new Negocios.Vendedor();
            try {
                DGV_Data.Refresh();

                if(TB_ID.Text != "   Codigo" && TB_ID.Text != "") {
                    if(VARIABLE != 1) {
                        parametro = " ID_VENDEDOR=" + TB_ID.Text;
                    }
                    VARIABLE = 1;
                }

                if(TB_Nombre.Text != "   Nombre" && TB_Nombre.Text != "") {
                    if(VARIABLE != 1) {
                        parametro = " NOMB_VENDEDOR LIKE '%" + TB_Nombre.Text + "%'";
                    } else {
                        parametro = parametro + " AND NOMB_VENDEDOR  LIKE '%" + TB_Nombre.Text + "%'";
                    }
                    VARIABLE = 1;
                }

                if(TB_Oficina.Text != " Oficina" && TB_Oficina.Text != "") {
                    if(VARIABLE != 1) {
                        parametro = " OFICINA LIKE '%" + TB_Oficina.Text + "%'";
                    } else {
                        parametro = parametro + " AND OFICINA LIKE '%" + TB_Oficina.Text + "%'";
                    }
                    VARIABLE = 1;
                }

                string SQL = @"SELECT TOP (1000) [ID_VENDEDOR],[NOMB_VENDEDOR],[ID_JEFE],[OFICINA],[COMISION]" +
                              " FROM [BD_VENTAS].[dbo].[VENDEDOR]";

                if(VARIABLE == 1) {
                    parametro = SQL + " WHERE " + parametro;

                    dataSet.Clear();
                    dataSet = obj.BuscarRecord(parametro);
                    DGV_Data.AutoGenerateColumns = false;
                    //SetupColumns(DSQL);
                    DGV_Data.DataSource = dataSet;

                    DGV_Data.DataMember = "VerRecord";
                    L_Registros.Visible = true;
                    L_Registros.Text = string.Format("R: {0}", dataSet.Tables["VerRecord"].Rows.Count.ToString());
                } else {
                    MostrarTodoslosRegistrosCargados();
                    DGV_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    L_Registros.Visible = false;
                }

            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        #region Insertar_actualizar_Eliminar_Reporte
        protected override void IconButton_Insertar_Click(object sender, EventArgs e) {
            FormVendedorInsUp form = new FormVendedorInsUp(id);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
            form.ShowDialog();

            MostrarTodoslosRegistrosCargados();
        }

        protected override void IconButton_Actualizar_Click(object sender, EventArgs e) => SelectToEditItem();

        protected override void IconButton_Delete_Click(object sender, EventArgs e) {
            int fila = DGV_Data.CurrentRow.Index;

            if(DGV_Data.Rows.Count != 0) {
                id = Convert.ToInt32(DGV_Data.Rows[fila].Cells[0].Value);
                if(obj == null)
                    obj = new Negocios.Vendedor();
                if(obj.ValidarRecord(id)) {
                    if(MessageBox.Show("Deseas Eliminar este Registro?", "Eliminar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        obj.Eliminar(id);

                        MessageBox.Show("Registro Eliminado correctamente");
                        MostrarTodoslosRegistrosCargados();
                    }
                }
            }
        }

        protected override void IconButton_Imprimir_Click(object sender, EventArgs e) {
            Config.Report.FormVendedorReport form = new Config.Report.FormVendedorReport();
            form.ShowDialog();
        }

        #endregion
        protected override void DGV_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if(DGV_Data.CurrentRow != null) {

            }
        }

        protected override void DGV_Data_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            e.Control.KeyPress -= AllowNumbersOnly;
            if(DGV_Data.CurrentCell.ColumnIndex == 4) {
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        protected override void DGV_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => SelectToEditItem();
        protected void SelectToEditItem() {
            try {
                int fila = DGV_Data.CurrentRow.Index;

                if(DGV_Data.Rows.Count != 0) {
                    id = Convert.ToInt32(DGV_Data.Rows[fila].Cells[0].Value);

                    FormVendedorInsUp form = new FormVendedorInsUp(id);
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                    id = 0;
                    MostrarTodoslosRegistrosCargados();
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
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
