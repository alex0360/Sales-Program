using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Config
{
    public class Tema
    {
        private Random random;
        private int tempIndex;

        public Tema()
        {
            random = new Random();
        }

        public Form OpenChildForm(Form activeForm, Form childForm, object btnSender, Panel P_DesktopPane, Panel subPanel, IconButton currentButton, Panel Panel_Titulo = null, Panel Panel_Logo = null, Button Button_Deshabilitar = null)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender, subPanel, currentButton, Panel_Titulo, Panel_Logo, Button_Deshabilitar);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            P_DesktopPane.Controls.Add(childForm);
            P_DesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Panel_Titulo.Text = childForm.Text;

            return activeForm;
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

        private void ActivateButton(object btnSender, Panel subPanel, IconButton currentButton, Panel Panel_Titulo = null, Panel Panel_Logo = null, Button Button_Deshabilitar = null)
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
                    if (Panel_Titulo != null)
                        Panel_Titulo.BackColor = color;
                    if (Panel_Logo != null)
                        Panel_Logo.BackColor = Config.ThemeColor.ChangeColorBrightness(color, -0.3);
                    if (Button_Deshabilitar != null)
                        Button_Deshabilitar.Visible = true;
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

        public Form Reset(Form activeForm, Panel subPanel, Label Label_Titulo, Panel Panel_Titulo, Panel Panel_Logo, IconButton IconButton_currentButton, Button Button_Deshabilitar, string Text_Label_Titulo = "HOME")
        {
            if (activeForm != null)
                activeForm.Close();
            DisableButton(subPanel);
            Label_Titulo.Text = Text_Label_Titulo;
            Panel_Titulo.BackColor = Config.Colores.Primary;
            Panel_Logo.BackColor = Color.FromArgb(43, 75, 98);
            IconButton_currentButton = null;
            Button_Deshabilitar.Visible = false;

            return activeForm;
        }

    }

}
