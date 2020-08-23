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
    public partial class FormFabricanteInsUp : FormBaseInsetUpdate
    {
        public FormFabricanteInsUp()
        {
            InitializeComponent();
            id = 0;
        }

        Negocios.Fabricante objNegocio;
        Entidades.Fabricante objEntidad;

        int id = 0;

        public FormFabricanteInsUp(int id)
        {
            InitializeComponent();
            this.id = id;
            CargarData();
        }

        private void CargarData()
        {
            if (objNegocio == null)
            {
                objNegocio = new Negocios.Fabricante();
            }
            var data = objNegocio.Buscar(id);

            //luego de buscar el codigo del cliente
            //valida si existe el codigo del cliente
            if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
            {
                TB_Nombre.Text = Convert.ToString(data.Rows[0][1]);
                TB_Direccion.Text = Convert.ToString(data.Rows[0][2]);
                TB_Pais.Text = Convert.ToString(data.Rows[0][3]);
            }

            TB_Nombre.ForeColor = Color.Black;
            TB_Direccion.ForeColor = Color.Black;
            TB_Pais.ForeColor = Color.Black;
        }

        #region Eventos Enter y Leave
        private void TB_Nombre_Enter(object sender, EventArgs e)
        {
            if (TB_Nombre.Text == "   Nombre")
            {
                TB_Nombre.Text = string.Empty;
                TB_Nombre.ForeColor = Color.Black;
            }
        }

        private void TB_Nombre_Leave(object sender, EventArgs e)
        {
            if (TB_Nombre.Text == string.Empty)
            {
                TB_Nombre.Text = "   Nombre";
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_Direccion_Enter(object sender, EventArgs e)
        {
            if (TB_Direccion.Text == "   Direccion")
            {
                TB_Direccion.Text = string.Empty;
                TB_Direccion.ForeColor = Color.Black;
            }
        }

        private void TB_Direccion_Leave(object sender, EventArgs e)
        {
            if (TB_Direccion.Text == string.Empty)
            {
                TB_Direccion.Text = "   Direccion";
                TB_Direccion.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_Pais_Enter(object sender, EventArgs e)
        {
            if (TB_Pais.Text == "   Pais")
            {
                TB_Pais.Text = string.Empty;
                TB_Pais.ForeColor = Color.Black;
            }
        }

        private void TB_Pais_Leave(object sender, EventArgs e)
        {
            if (TB_Pais.Text == string.Empty)
            {
                TB_Pais.Text = "   Pais";
                TB_Pais.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        #region Click
        protected override void IconButton_Guardar_Click(object sender, EventArgs e)
        {
            if (TB_Nombre.Text != "   Nombre" && TB_Direccion.Text != "   Direccion" && TB_Pais.Text != "   Pais")
            {
                if (objNegocio == null)
                {
                    objNegocio = new Negocios.Fabricante();
                }
                var validar = objNegocio.ValidarRecord(id);

                if (validar)
                    Actualizar();
                else
                    Agregar();
            }
            else
            {
                ErrorData();
            }
        }

        private void ErrorData()
        {
            if (TB_Nombre.Text == "   Nombre")
            {
                TB_Nombre.ForeColor = Color.Red;
            }

            if (TB_Direccion.Text == "   Direccion")
            {
                TB_Direccion.ForeColor = Color.Red;
            }

            if (TB_Pais.Text == "   Pais")
            {
                TB_Pais.ForeColor = Color.Red;
            }
            Timer_Error.Start();

        }
        private void Timer_Error_Tick(object sender, EventArgs e)
        {
            if (TB_Nombre.Text == "   Nombre" || TB_Nombre.Text == string.Empty)
            {
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Direccion.Text == "   Direccion" || TB_Direccion.Text == string.Empty)
            {
                TB_Direccion.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Pais.Text == "   Pais" || TB_Pais.Text == string.Empty)
            {
                TB_Pais.ForeColor = Config.Colores.Secudary;

            }

            Timer_Error.Stop();
        }
        protected override void IconButton_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            if (TB_Nombre.Text != string.Empty)
            {
                TB_Nombre.Text = "   Nombre";
                TB_Nombre.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Direccion.Text != string.Empty)
            {
                TB_Direccion.Text = "   Direccion";
                TB_Direccion.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Pais.Text != string.Empty)
            {
                TB_Pais.Text = "   Pais";
                TB_Pais.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        private void Actualizar()
        {
            if (objEntidad == null)
            {
                objEntidad = new Entidades.Fabricante();
            }
            objEntidad.IdFabricante = id;
            objEntidad.NombreFabricante = TB_Nombre.Text;
            objEntidad.Direccion = TB_Direccion.Text;
            objEntidad.Pais = TB_Pais.Text;

            if (objNegocio == null)
            {
                objNegocio = new Negocios.Fabricante();
            }
            objNegocio.Actualizar(objEntidad);

            MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
            Close();
        }

        private void Agregar()
        {
            if (objEntidad == null)
            {
                objEntidad = new Entidades.Fabricante();
            }
            objEntidad.NombreFabricante = TB_Nombre.Text;
            objEntidad.Direccion = TB_Direccion.Text;
            objEntidad.Pais = TB_Pais.Text;

            if (objNegocio == null)
            {
                objNegocio = new Negocios.Fabricante();
            }
            objNegocio.Registrar(objEntidad);

            MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
        }
    }
}
