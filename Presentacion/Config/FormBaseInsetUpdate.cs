using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion.Config
{
    public partial class FormBaseInsetUpdate : Form
    {
        public FormBaseInsetUpdate()
        {
            InitializeComponent();
        }

        private void IconButton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Mover_Ventana
        private void Panel_Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        protected virtual void IconButton_Guardar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void IconButton_Clear_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
