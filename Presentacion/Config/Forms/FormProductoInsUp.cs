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
    public partial class FormProductoInsUp : FormBaseInsetUpdate
    {
        Negocios.Producto objNegocio;
        Entidades.Producto objEntidad;

        private int id = 0;
        private bool changed = true;
        private int idFabricante = 0;

        public FormProductoInsUp()
        {
            InitializeComponent();
            id = 0;
            Listar_Fabricante();
        }

        public FormProductoInsUp(int id)
        {
            InitializeComponent();
            this.id = id;
            Listar_Fabricante();
            CargarData();
        }

        private void CargarData()
        {
            if (objNegocio == null)
            {
                objNegocio = new Negocios.Producto();
            }
            var data = objNegocio.Buscar(id);

            //luego de buscar el codigo
            //valida si existe el codigo
            if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
            {
                TB_Descripcion.Text = Convert.ToString(data.Rows[0][1]);
                CB_NombreFabricante.Text = Convert.ToString(data.Rows[0][2]);
                TB_Costo.Text = Convert.ToString(data.Rows[0][3]);
                TB_Precio.Text = Convert.ToString(data.Rows[0][4]);
                TextBox_Cantidad.Text = Convert.ToString(data.Rows[0][5]);
                CB_NombreFabricante.SelectedValue = idFabricante = Convert.ToInt32(data.Rows[0][6]);
            }

            TB_Descripcion.ForeColor = Color.Black;
            CB_NombreFabricante.ForeColor = Color.Black;
            TB_Costo.ForeColor = Color.Black;
            TB_Precio.ForeColor = Color.Black;
            TextBox_Cantidad.ForeColor = Color.Black;
        }

        #region Eventos Enter y Leave
        private void TB_Descripcion_Enter(object sender, EventArgs e)
        {
            if (TB_Descripcion.Text == "   Descripcion")
            {
                TB_Descripcion.Text = string.Empty;
                TB_Descripcion.ForeColor = Color.Black;
            }
        }

        private void TB_Descripcion_Leave(object sender, EventArgs e)
        {
            if (TB_Descripcion.Text == string.Empty)
            {
                TB_Descripcion.Text = "   Descripcion";
                TB_Descripcion.ForeColor = Config.Colores.Secudary;
            }
        }

        private void CB_NombreFabricante_Enter(object sender, EventArgs e)
        {
            if (CB_NombreFabricante.Text == "   Nombre del Fabricante")
            {
                CB_NombreFabricante.Text = string.Empty;
                CB_NombreFabricante.ForeColor = Color.Black;
            }
        }

        private void CB_NombreFabricante_Leave(object sender, EventArgs e)
        {
            if (CB_NombreFabricante.Text == string.Empty)
            {
                CB_NombreFabricante.Text = "   Nombre del Fabricante";
                CB_NombreFabricante.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Config.IsNumero.textBox_KeyPress(sender, e);
        }
        private void TB_TextChanged(object sender, EventArgs e)
        {
            if (changed == false)
                changed = true;
            else
                Config.IsNumero.textBox_TextChanged(sender, e);
        }

        private void TB_Costo_Enter(object sender, EventArgs e)
        {
            if (TB_Costo.Text == "   Costo")
            {
                changed = false;
                TB_Costo.Text = string.Empty;
                TB_Costo.ForeColor = Color.Black;
            }
        }

        private void TB_Costo_Leave(object sender, EventArgs e)
        {
            if (TB_Costo.Text == string.Empty)
            {
                changed = false;
                TB_Costo.Text = "   Costo";
                TB_Costo.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_Precio_Enter(object sender, EventArgs e)
        {
            if (TB_Precio.Text == "   Precio")
            {
                changed = false;
                TB_Precio.Text = string.Empty;
                TB_Precio.ForeColor = Color.Black;
            }
        }

        private void TB_Precio_Leave(object sender, EventArgs e)
        {
            if (TB_Precio.Text == string.Empty)
            {
                changed = false;
                TB_Precio.Text = "   Precio";
                TB_Precio.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TextBox_Cantidad_Enter(object sender, EventArgs e)
        {
            if (TextBox_Cantidad.Text == "   Cantidad en Inventario")
            {
                changed = false;
                TextBox_Cantidad.Text = string.Empty;
                TextBox_Cantidad.ForeColor = Color.Black;
            }
        }

        private void TextBox_Cantidad_Leave(object sender, EventArgs e)
        {
            if (TextBox_Cantidad.Text == string.Empty)
            {
                changed = false;
                TextBox_Cantidad.Text = "   Cantidad en Inventario";
                TextBox_Cantidad.ForeColor = Config.Colores.Secudary;
            }
        }
        #endregion

        #region Click
        protected override void IconButton_Guardar_Click(object sender, EventArgs e)
        {
            if (TB_Descripcion.Text != "   Descripcion" && CB_NombreFabricante.Text != "   Nombre del Fabricante" && TB_Costo.Text != "   Costo" && TB_Precio.Text != "   Precio" && TextBox_Cantidad.Text != "   Cantidad en Inventario")
            {
                if (objNegocio == null)
                {
                    objNegocio = new Negocios.Producto();
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
            if (TB_Descripcion.Text == "   Descripcion")
            {
                TB_Descripcion.ForeColor = Color.Red;
            }

            if (CB_NombreFabricante.Text == "   Nombre del Fabricante")
            {
                CB_NombreFabricante.ForeColor = Color.Red;
            }

            if (TB_Costo.Text == "   Costo")
            {
                TB_Costo.ForeColor = Color.Red;
            }

            if (TB_Precio.Text == "   Precio")
            {
                TB_Precio.ForeColor = Color.Red;
            }
            
            if (TextBox_Cantidad.Text == "   Cantidad en Inventario")
            {
                TextBox_Cantidad.ForeColor = Color.Red;
            }

            Timer_Error.Start();

        }
        private void Timer_Error_Tick(object sender, EventArgs e)
        {
            if (TB_Descripcion.Text == "   Descripcion" || TB_Descripcion.Text == string.Empty)
            {
                TB_Descripcion.ForeColor = Config.Colores.Secudary;
            }

            if (CB_NombreFabricante.Text == "   Nombre del Fabricante" || CB_NombreFabricante.Text == string.Empty)
            {
                CB_NombreFabricante.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Costo.Text == "   Costo" || TB_Costo.Text == string.Empty)
            {
                TB_Costo.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Precio.Text == "   Precio" || TB_Precio.Text == string.Empty)
            {
                TB_Precio.ForeColor = Config.Colores.Secudary;
            }            
            
            if (TextBox_Cantidad.Text == "   Cantidad en Inventario" || TextBox_Cantidad.Text == string.Empty)
            {
                TextBox_Cantidad.ForeColor = Config.Colores.Secudary;
            }

            Timer_Error.Stop();
        }

        protected override void IconButton_Clear_Click(object sender, EventArgs e) => Clear();

        #endregion
        private void Clear()
        {
            if (TB_Descripcion.Text != string.Empty)
            {
                TB_Descripcion.Text = "   Descripcion";
                TB_Descripcion.ForeColor = Config.Colores.Secudary;
            }

            if (CB_NombreFabricante.Text != string.Empty)
            {
                CB_NombreFabricante.Text = "   Nombre del Fabricante";
                CB_NombreFabricante.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Costo.Text != string.Empty)
            {
                changed = false;
                TB_Costo.Text = "   Costo";
                TB_Costo.ForeColor = Config.Colores.Secudary;
            }

            if (TB_Precio.Text != string.Empty)
            {
                changed = false;
                TB_Precio.Text = "   Precio";
                TB_Precio.ForeColor = Config.Colores.Secudary;
            }

            if (TextBox_Cantidad.Text != string.Empty)
            {
                changed = false;
                TextBox_Cantidad.Text = "   Cantidad en Inventario";
                TextBox_Cantidad.ForeColor = Config.Colores.Secudary;
            }
        }

        private void Listar_Fabricante()
        {
            Negocios.Fabricante fabricante = new Negocios.Fabricante();
            DataSet dataSet = new DataSet();
            dataSet = fabricante.Mostrar();

            CB_NombreFabricante.DataSource = dataSet.Tables[0];
            CB_NombreFabricante.DisplayMember = "NOMB_FABRICANTE";
            CB_NombreFabricante.ValueMember = "ID_FABRICANTE";

            CB_NombreFabricante.SelectedIndex = -1;
            CB_NombreFabricante.Text = "   Nombre del Fabricante";

        }

        private void Actualizar()
        {
            if (objEntidad == null)
            {
                objEntidad = new Entidades.Producto();
            }
            objEntidad.IdProducto = id;
            objEntidad.DescProducto = TB_Descripcion.Text;
            objEntidad.IdFabricante = int.Parse(CB_NombreFabricante.SelectedValue.ToString());
            objEntidad.NombreFabricante = CB_NombreFabricante.Text;
            objEntidad.Costo = float.Parse(TB_Costo.Text);
            objEntidad.Precio = float.Parse(TB_Precio.Text);
            objEntidad.Cantidad = int.Parse(TextBox_Cantidad.Text);

            if (objNegocio == null)
            {
                objNegocio = new Negocios.Producto();
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
                objEntidad = new Entidades.Producto();
            }
            objEntidad.DescProducto = TB_Descripcion.Text;
            objEntidad.NombreFabricante = CB_NombreFabricante.Text;
            objEntidad.Costo = float.Parse(TB_Costo.Text);
            objEntidad.Precio = float.Parse(TB_Precio.Text);
            objEntidad.Cantidad = int.Parse(TextBox_Cantidad.Text);
            objEntidad.IdFabricante = int.Parse(CB_NombreFabricante.SelectedValue.ToString());

            objNegocio.Registrar(objEntidad);

            MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Clear();
        }

        private void CB_NombreFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void IconButton_Guardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
