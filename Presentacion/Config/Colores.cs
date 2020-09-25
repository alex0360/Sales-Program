
using System.Drawing;

namespace Presentacion.Config {
    public class Colores {
        public static Color Primary = System.Drawing.Color.FromArgb(253, 242, 209);

        public static Color Secudary = System.Drawing.Color.FromArgb(64, 112, 147);
    }

    public static class ThemeColor {
        public static Color Primary { get; set; }
        public static Color Secondary { get; set; }

        public static System.Collections.Generic.List<string> ColorList =
            new System.Collections.Generic.List<string>() {
                "#a1a1e6","#83ddb3","#9cffc9","#b2bdcc","#F84D50","#FFE177","#87A863",
                "#79D1BE","#C2A0BF","#A9E0FE","#A6EFA9","#EAAC8B","#FFF2AC","#FAC7AA",
                "#F9ACAC","#e0d68f","#07C7F2","#D9B5AD","#FCEF87","#F9DB49","#A7BDD9",
                "#77ff77","#0094BC","#E4126B","#43B76E","#7BCFE9","#B71C46"
            };
        public static Color ChangeColorBrightness(Color color, double correctionFactor) {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if(correctionFactor < 0) {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
