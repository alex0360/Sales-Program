using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentacion.Config {
    public class IsNumero {
        public static void SoloNumeros(KeyPressEventArgs keyPressEventArgs) {
            if(Char.IsNumber(keyPressEventArgs.KeyChar)) {
                keyPressEventArgs.Handled = true;
            }
        }

        private const char SignoDecimal = '.'; // Carácter separador decimal
        private static string _prevTextBoxValue; // Variable que almacena el valor anterior del Textbox

        public static void textBox_TextChanged(object sender, EventArgs e) {
            var textBox = (TextBox)sender;
            // Comprueba si el valor del TextBox se ajusta a un valor válido
            if(Regex.IsMatch(textBox.Text, @"^(?:\d+\.?\d*)?$")) {
                // Si es válido se almacena el valor actual en la variable privada
                _prevTextBoxValue = textBox.Text;
            } else {
                // Si no es válido se recupera el valor de la variable privada con el valor anterior
                // Calcula el nº de caracteres después del cursor para dejar el cursor en la misma posición
                var charsAfterCursor = textBox.TextLength - textBox.SelectionStart - textBox.SelectionLength;
                // Recupera el valor anterior
                textBox.Text = _prevTextBoxValue;
                // Posiciona el cursor en la misma posición
                textBox.SelectionStart = Math.Max(0, textBox.TextLength - charsAfterCursor);
            }
        }

        public static void textBox_KeyPress(object sender, KeyPressEventArgs e) {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        && (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                            || textBox.SelectionStart == 0
                            || textBox.Text.Contains(SignoDecimal));
        }
    }
}
