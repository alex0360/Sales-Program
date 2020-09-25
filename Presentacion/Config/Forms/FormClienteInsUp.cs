using System;
using System.Drawing;
using System.Windows.Forms;


namespace Presentacion.Config.Forms {

    public partial class FormClienteInsUp : FormBaseInsetUpdate {
        Negocios.Cliente objNegocio;
        Entidades.Cliente objEntidad;

        int id = 0;
        bool changed = true;
        public FormClienteInsUp() {
            InitializeComponent();
            id = 0;
        }

        public FormClienteInsUp(int id) {
            InitializeComponent();
            this.id = id;
            CargarData();
        }

        private void CargarData() {
            if(objNegocio == null) {
                objNegocio = new Negocios.Cliente();
            }
            var data = objNegocio.Buscar(id);

            //luego de buscar el codigo del cliente
            //valida si existe el codigo del cliente
            if(data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
            {
                TB_Nombre.Text = Convert.ToString(data.Rows[0]["NOMB_CLIENTE"]);
                TB_Direccion.Text = Convert.ToString(data.Rows[0]["DIRECCION"]);
                TB_Pais.Text = Convert.ToString(data.Rows[0]["PAIS"]);
                TB_SaldoInicial.Text = Convert.ToString(data.Rows[0]["SALDO_INIC"]);
                TB_SaldoActual.Text = Convert.ToString(data.Rows[0]["SALDO_ACT"]);
                CheckBox_Estatus.Checked = Convert.ToBoolean(data.Rows[0]["Estatus"]);
            }

            TB_Nombre.ForeColor = Color.Black;
            TB_Direccion.ForeColor = Color.Black;
            TB_Pais.ForeColor = Color.Black;
            TB_SaldoInicial.ForeColor = Color.Black;
            TB_SaldoActual.ForeColor = Color.Black;
        }

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

        private void TB_Direccion_Enter(object sender, EventArgs e) {
            if(TB_Direccion.Text == "   Direccion") {
                TB_Direccion.Text = string.Empty;
                TB_Direccion.ForeColor = Color.Black;
            }
        }

        private void TB_Direccion_Leave(object sender, EventArgs e) {
            if(TB_Direccion.Text == string.Empty) {
                TB_Direccion.Text = "   Direccion";
                TB_Direccion.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_Pais_Enter(object sender, EventArgs e) {
            if(TB_Pais.Text == "   Pais") {
                TB_Pais.Text = string.Empty;
                TB_Pais.ForeColor = Color.Black;
            }
        }

        private void TB_Pais_Leave(object sender, EventArgs e) {
            if(TB_Pais.Text == string.Empty) {
                TB_Pais.Text = "   Pais";
                TB_Pais.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e) {
            Config.IsNumero.textBox_KeyPress(sender, e);
        }
        private void TB_TextChanged(object sender, EventArgs e) {
            if(changed == false)
                changed = true;
            else
                Config.IsNumero.textBox_TextChanged(sender, e);
        }
        private void TB_SaldoInicial_Enter(object sender, EventArgs e) {
            if(TB_SaldoInicial.Text == "   Saldo Inicial") {
                changed = false;
                TB_SaldoInicial.Text = string.Empty;
                TB_SaldoInicial.ForeColor = Color.Black;
            }
        }

        private void TB_SaldoInicial_Leave(object sender, EventArgs e) {
            if(TB_SaldoInicial.Text == string.Empty) {
                changed = false;
                TB_SaldoInicial.Text = "   Saldo Inicial";
                TB_SaldoInicial.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_SaldoActual_Enter(object sender, EventArgs e) {
            if(TB_SaldoActual.Text == "   Saldo Actual") {
                changed = false;
                TB_SaldoActual.Text = string.Empty;
                TB_SaldoActual.ForeColor = Color.Black;
            }
        }

        private void TB_SaldoActual_Leave(object sender, EventArgs e) {
            if(TB_SaldoActual.Text == string.Empty) {
                changed = false;
                TB_SaldoActual.Text = "   Saldo Actual";
                TB_SaldoActual.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        #region Click
        protected override void IconButton_Guardar_Click(object sender, EventArgs e) {
            if(TB_Nombre.Text != "   Nombre" && TB_Direccion.Text != "   Direccion" && TB_Pais.Text != "   Pais" && TB_SaldoInicial.Text != "   Saldo Inicial" && TB_SaldoActual.Text != "   Saldo Actual") {
                if(objNegocio == null) {
                    objNegocio = new Negocios.Cliente();
                }
                var validar = objNegocio.ValidarRecord(id);

                if(validar)
                    Actualizar();
                else
                    Agregar();
            } else {
                ErrorData();
            }
        }

        private void ErrorData() {
            if(TB_Nombre.Text == "   Nombre") {
                TB_Nombre.ForeColor = Color.Red;
            }

            if(TB_Direccion.Text == "   Direccion") {
                TB_Direccion.ForeColor = Color.Red;
            }

            if(TB_Pais.Text == "   Pais") {
                TB_Pais.ForeColor = Color.Red;
            }

            if(TB_SaldoInicial.Text == "   Saldo Inicial") {
                TB_SaldoInicial.ForeColor = Color.Red;
            }

            if(TB_SaldoActual.Text == "   Saldo Actual") {
                TB_SaldoActual.ForeColor = Color.Red;
            }

            Timer_Error.Start();

        }
        private void Timer_Error_Tick(object sender, EventArgs e) {
            if(TB_Nombre.Text == "   Nombre" || TB_Nombre.Text == string.Empty) {
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Direccion.Text == "   Direccion" || TB_Direccion.Text == string.Empty) {
                TB_Direccion.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Pais.Text == "   Pais" || TB_Pais.Text == string.Empty) {
                TB_Pais.ForeColor = Config.Colores.Secudary;

            }

            if(TB_SaldoInicial.Text == "   Saldo Inicial" || TB_SaldoInicial.Text == string.Empty) {
                TB_SaldoInicial.ForeColor = Config.Colores.Secudary;
            }

            if(TB_SaldoActual.Text == "   Saldo Actual" || TB_SaldoActual.Text == string.Empty) {
                TB_SaldoActual.ForeColor = Config.Colores.Secudary;
            }

            Timer_Error.Stop();
        }
        protected override void IconButton_Clear_Click(object sender, EventArgs e) => Clear();

        private void Clear() {
            if(TB_Nombre.Text != string.Empty) {
                TB_Nombre.Text = "   Nombre";
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Direccion.Text != string.Empty) {
                TB_Direccion.Text = "   Direccion";
                TB_Direccion.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Pais.Text != string.Empty) {
                TB_Pais.Text = "   Pais";
                TB_Pais.ForeColor = Config.Colores.Secudary;
            }

            if(TB_SaldoInicial.Text != string.Empty) {
                changed = false;
                TB_SaldoInicial.Text = "   Saldo Inicial";
                TB_SaldoInicial.ForeColor = Config.Colores.Secudary;
            }

            if(TB_SaldoActual.Text != string.Empty) {
                changed = false;
                TB_SaldoActual.Text = "   Saldo Actual";
                TB_SaldoActual.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        private void Actualizar() {
            if(objEntidad == null) {
                objEntidad = new Entidades.Cliente();
            }
            objEntidad.IdCliente = id;
            objEntidad.NombreCliente = TB_Nombre.Text;
            objEntidad.Direccion = TB_Direccion.Text;
            objEntidad.Pais = TB_Pais.Text;
            objEntidad.SaldoInicial = float.Parse(TB_SaldoInicial.Text);
            objEntidad.SaldoActual = float.Parse(TB_SaldoActual.Text);
            objEntidad.Estatus = Convert.ToByte(CheckBox_Estatus.Checked);

            if(objNegocio == null) {
                objNegocio = new Negocios.Cliente();
            }
            objNegocio.Actualizar(objEntidad);

            MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
            Close();
        }

        private void Agregar() {
            if(objEntidad == null) {
                objEntidad = new Entidades.Cliente();
            }
            objEntidad.NombreCliente = TB_Nombre.Text;
            objEntidad.Direccion = TB_Direccion.Text;
            objEntidad.Pais = TB_Pais.Text;
            objEntidad.SaldoInicial = float.Parse(TB_SaldoInicial.Text);
            objEntidad.SaldoActual = float.Parse(TB_SaldoActual.Text);
            objEntidad.Estatus = Convert.ToByte(CheckBox_Estatus.Checked);

            if(objNegocio == null) {
                objNegocio = new Negocios.Cliente();
            }
            objNegocio.Registrar(objEntidad);

            MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
        }

        private void IconButton_Cerrar_Click(object sender, EventArgs e) {

        }
    }
}
