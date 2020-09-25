using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion.Config {
    public partial class FormBaseBuscar : Form {
        public FormBaseBuscar() {
            InitializeComponent();
            LoadTheme();
        }

        private void IconButton_Cerrar_Click(object sender, EventArgs e) {
            Close();
        }

        protected virtual void IconButton_Codigo_Click(object sender, EventArgs e) {

        }

        #region Mover_Ventana
        private void Panel_Titulo_MouseMove(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        protected virtual void DGV_Data_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        protected virtual void DGV_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

        }

        protected void LoadTheme() {

            foreach(Control control in this.Controls) {
                DataGridView dataGridView;
                if(control.GetType() == typeof(DataGridView)) {
                    dataGridView = (DataGridView)control;
                    dataGridView.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Secondary, -0.5);

                    dataGridView.RowsDefaultCellStyle.BackColor = ThemeColor.Primary;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.2);

                    dataGridView.RowHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.5);

                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.5);
                    dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.Primary, -0.5);
                }

            }
        }

        protected virtual void FormBaseBuscar_Load(object sender, EventArgs e) {

        }
    }
}
