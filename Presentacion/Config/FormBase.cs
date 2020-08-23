using FontAwesome.Sharp;
using System.Windows.Forms;

namespace Presentacion.Config
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

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

        ~FormBase()
        {
            Close();
        }

        protected virtual void DGV_Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void DGV_Data_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        protected virtual void DGV_Data_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        protected virtual void IconButton_Insertar_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void DGV_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void IconButton_Actualizar_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void IconButton_Delete_Click(object sender, System.EventArgs e)
        {

        }

        protected virtual void IconButton_Imprimir_Click(object sender, System.EventArgs e)
        {

        }
    }
}
