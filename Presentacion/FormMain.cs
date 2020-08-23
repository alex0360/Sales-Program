using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormMain : Form
    {
        //Fields
        private Random random;
        private int tempIndex;
        private IconButton currentButton;
        private Form activeForm;

        public FormMain()
        {
            InitializeComponent();
            Constructor();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        public FormMain(string usuario)
        {
            InitializeComponent();
            L_UsuarioConectado.Text = string.Format("Usuario Conectado: {0}", usuario);
            Constructor();
            Console.Write("Hola Mundo");
        }

        private void Constructor()
        {
            random = new Random();
            CustomizeDesign();
            B_CloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region SubMenu
        private void CustomizeDesign()
        {
            P_SubMantenimiento.Visible = false;
            P_SubVenta.Visible = false;
        }

        private void HideSubMenu()
        {
            if (P_SubMantenimiento.Visible == true)
                P_SubMantenimiento.Visible = false;
            if (P_SubVenta.Visible == true)
                P_SubVenta.Visible = false;
        }

        private void ShowSubMenu(System.Windows.Forms.Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;

        }
        #endregion
        #region Sub_Menu_Mantenimento
        private void IB_Mantenimiento_Click(object sender, EventArgs e)
        {
            ShowSubMenu(P_SubMantenimiento);
        }

        private void IB_Cliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Config.Forms.FormCliente(), sender, P_SubMantenimiento);
            //HideSubMenu();
        }

        private void IB_Fabricante_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Config.Forms.FormFabricante(), sender, P_SubMantenimiento);
            //HideSubMenu();
        }

        private void IB_Producto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Config.Forms.FormProducto(), sender, P_SubMantenimiento);
            //HideSubMenu();
        }

        private void IB_Vendedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Config.Forms.FormVendedor(), sender, P_SubMantenimiento);
            //HideSubMenu();
        }
        #endregion

        private void IB_Venta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(P_SubVenta);
        }

        #region Mover_Ventana
        private void P_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void B_CloseChildForm_Click(object sender, EventArgs e)
        {
            Reset(P_SubMantenimiento);
            Reset(P_SubVenta);
        }

        private void B_Close_Click(object sender, EventArgs e) => Application.Exit();

        private void IB_Salir_Click(object sender, EventArgs e) => Close();

        private void B_Minimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void B_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void P_DesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void T_FechaHora_Tick(object sender, EventArgs e)
        {
            L_Fecha.Text = string.Format("Fecha: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            L_Hora.Text = string.Format("Hora: {0}", DateTime.Now.ToString("hh:mm:ss"));

        }

        #region Cambiar Temas
        public void OpenChildForm(Form childForm, object btnSender, Panel subPanel)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender, subPanel);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            P_DesktopPane.Controls.Add(childForm);
            P_DesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            L_Titulo.Text = childForm.Text;
        }
        private Color SelectThemeColor(IconButton currentButton)
        {
            int index = random.Next(Config.ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Config.ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = Config.ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender, Panel subPanel)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton(subPanel);
                    Color color = SelectThemeColor(currentButton);
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    //currentButton.IconColor = Config.Colores.Primary;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Config.ThemeColor.Primary = color;
                    Config.ThemeColor.Secondary = Config.ThemeColor.ChangeColorBrightness(color, -0.3);
                    P_Titulo.BackColor = color;
                    P_Logo.BackColor = Config.ThemeColor.ChangeColorBrightness(color, -0.3);
                    B_CloseChildForm.Visible = true;
                }
            }
        }

        public static void DisableButton(Panel subPanel)
        {
            foreach (Control previousBtn in subPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(64, 112, 147);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void Reset(Panel subPanel)
        {
            if (activeForm != null)
                activeForm.Close();
            DisableButton(subPanel);
            L_Titulo.Text = "INICIO";
            P_Titulo.BackColor = Config.Colores.Primary;
            P_Logo.BackColor = Color.FromArgb(43, 75, 98);
            currentButton = null;
            B_CloseChildForm.Visible = false;
        }
        #endregion

        private void IconButton_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"..\..\..\Ayuda\info.pdf");
            }
            catch
            {
                try { System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"info.pdf"); } catch { }
            }
        }

        private void IconButton_Venta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVenta(), sender, P_SubVenta);
        }
    }
}
