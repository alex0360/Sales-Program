using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        int intentoAcceso = 0;

        private void FormLogin_Load(object sender, EventArgs e) {

        }
        #region Mover la ventana
        private void FormLogin_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        private void B_Cerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        #region Funcionalidad de TextBox
        private void TB_Usuario_Enter(object sender, EventArgs e) {
            if(TB_Usuario.Text == "   USUARIO") {
                TB_Usuario.Text = string.Empty;
                TB_Usuario.ForeColor = Color.Black;
            }
        }

        private void TB_Clave_Enter(object sender, EventArgs e) {
            if(TB_Clave.Text == "   PASSWORD") {
                TB_Clave.Text = string.Empty;
                TB_Clave.PasswordChar = '*';
                TB_Clave.ForeColor = Color.Black;
            }
        }

        private void TB_Usuario_Leave(object sender, EventArgs e) {
            if(TB_Usuario.Text == string.Empty) {
                TB_Usuario.Text = "   USUARIO";
                TB_Usuario.ForeColor = Config.Colores.Secudary;
            }
        }

        private void TB_Clave_Leave(object sender, EventArgs e) {
            if(TB_Clave.Text == string.Empty) {
                TB_Clave.Text = "   PASSWORD";
                TB_Clave.PasswordChar = (char)0;
                TB_Clave.ForeColor = Config.Colores.Secudary;
            }
        }

        #endregion

        private void IB_Acceder_Click(object sender, EventArgs e) {
            if((TB_Usuario.Text != "   USUARIO" && TB_Usuario.Text != string.Empty)
                && (TB_Clave.Text != "   PASSWORD" && TB_Clave.Text != string.Empty)) {
                if(Negocios.Usuario.VerificarUsuario(TB_Usuario.Text, TB_Clave.Text)) {
                    Hide();
                    FormMain formMain = new FormMain(TB_Usuario.Text);
                    formMain.FormClosed += Loguot;
                    formMain.ShowDialog();

                } else {
                    L_Login.ForeColor = Color.Red;
                    TB_Usuario.ForeColor = Color.Red;
                    TB_Clave.ForeColor = Color.Red;
                    T_Error.Start();
                    Cerrar();
                }
            } else {
                L_Login.ForeColor = Color.Red;
                TB_Usuario.ForeColor = Color.Red;
                TB_Clave.ForeColor = Color.Red;
                T_Error.Start();
            }
        }

        private void Loguot(object sender, FormClosedEventArgs e) {
            TB_Usuario.Text = "   USUARIO";
            TB_Usuario.ForeColor = Config.Colores.Secudary;
            TB_Clave.Text = "   PASSWORD";
            TB_Clave.ForeColor = Config.Colores.Secudary;
            TB_Clave.PasswordChar = (char)0;
            B_Cerrar.Focus();
            Show();
        }

        private void T_Error_Tick(object sender, EventArgs e) {
            TB_Usuario.ForeColor = Config.Colores.Secudary;
            TB_Clave.ForeColor = Config.Colores.Secudary;
            L_Login.ForeColor = Config.Colores.Secudary;
            T_Error.Stop();
        }

        private void B_Minimizar_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void TB_Usuario_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == '\r') {
                e.Handled = true;
                TB_Clave.Focus();
            }
        }

        private void TB_Clave_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == '\r') {
                e.Handled = true;
                IB_Acceder.Focus();
            }
        }

        private void Cerrar() {
            if(intentoAcceso >= 3) {
                Application.Exit();
            }
            intentoAcceso++;
        }
    }
}
