using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Config.Forms {
    public partial class FormVendedorInsUp : FormBaseInsetUpdate {
        Negocios.Vendedor objNegocio;
        Entidades.Vendedor objEntidad;

        int id = 0;
        bool changed = true;
        public FormVendedorInsUp() {
            InitializeComponent();
            id = 0;
        }
        public FormVendedorInsUp(int id) {
            InitializeComponent();
            this.id = id;
            CargarData();
        }

        private void CargarData() {
            if(objNegocio == null) {
                objNegocio = new Negocios.Vendedor();
            }
            var data = objNegocio.Buscar(id);

            //luego de buscar el codigo del cliente
            //valida si existe el codigo del cliente
            if(data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
            {
                TB_Nombre.Text = Convert.ToString(data.Rows[0][1]);
                TB_Oficina.Text = Convert.ToString(data.Rows[0][3]);
                TB_Comision.Text = Convert.ToString(data.Rows[0][4]);
            }

            TB_Nombre.ForeColor = Color.Black;
            TB_Oficina.ForeColor = Color.Black;
            TB_Comision.ForeColor = Color.Black;
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

        private void TB_KeyPress(object sender, KeyPressEventArgs e) {
            Config.IsNumero.textBox_KeyPress(sender, e);
        }
        private void TB_TextChanged(object sender, EventArgs e) {
            if(changed == false)
                changed = true;
            else
                Config.IsNumero.textBox_TextChanged(sender, e);
        }

        private void TB_Comision_Enter(object sender, EventArgs e) {
            if(TB_Comision.Text == "   Comision") {
                changed = false;
                TB_Comision.Text = string.Empty;
                TB_Comision.ForeColor = Color.Black;
            }
        }

        private void TB_Comision_Leave(object sender, EventArgs e) {
            if(TB_Comision.Text == string.Empty) {
                changed = false;
                TB_Comision.Text = "   Comision";
                TB_Comision.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        #region Click
        protected override void IconButton_Guardar_Click(object sender, EventArgs e) {
            if(TB_Nombre.Text != "   Nombre" && TB_Oficina.Text != "   Oficina" && TB_Comision.Text != "   Comision") {
                if(objNegocio == null) {
                    objNegocio = new Negocios.Vendedor();
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

            if(TB_Oficina.Text == "   Oficina") {
                TB_Oficina.ForeColor = Color.Red;
            }

            if(TB_Comision.Text == "   Comision") {
                TB_Comision.ForeColor = Color.Red;
            }

            Timer_Error.Start();

        }
        private void Timer_Error_Tick(object sender, EventArgs e) {
            if(TB_Nombre.Text == "   Nombre" || TB_Nombre.Text == string.Empty) {
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Oficina.Text == "   Oficina" || TB_Oficina.Text == string.Empty) {
                TB_Oficina.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Comision.Text == "   Comision" || TB_Comision.Text == string.Empty) {
                TB_Comision.ForeColor = Config.Colores.Secudary;
            }

            Timer_Error.Stop();
        }
        protected override void IconButton_Clear_Click(object sender, EventArgs e) => Clear();

        private void Clear() {
            if(TB_Nombre.Text != string.Empty) {
                TB_Nombre.Text = "   Nombre";
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Oficina.Text != string.Empty) {
                TB_Oficina.Text = "   Oficina";
                TB_Oficina.ForeColor = Config.Colores.Secudary;
            }

            if(TB_Comision.Text != string.Empty) {
                changed = false;
                TB_Comision.Text = "   Comision";
                TB_Comision.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        private void Actualizar() {
            if(objEntidad == null) {
                objEntidad = new Entidades.Vendedor();
            }
            objEntidad.IdVendedor = id;
            objEntidad.NombreVendedor = TB_Nombre.Text;
            objEntidad.Oficina = TB_Oficina.Text;
            objEntidad.Comision = float.Parse(TB_Comision.Text);

            if(objNegocio == null) {
                objNegocio = new Negocios.Vendedor();
            }
            objNegocio.Actualizar(objEntidad);

            MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
            Close();
        }

        private void Agregar() {
            if(objEntidad == null) {
                objEntidad = new Entidades.Vendedor();
            }
            objEntidad.NombreVendedor = TB_Nombre.Text;
            objEntidad.Oficina = TB_Oficina.Text;
            objEntidad.Comision = float.Parse(TB_Comision.Text);

            if(objNegocio == null) {
                objNegocio = new Negocios.Vendedor();
            }
            objNegocio.Registrar(objEntidad);

            MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
        }
    }
}
