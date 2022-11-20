using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelist.boundary
{
    public static class ColorTheme
    {
        public static List<string> ColorList = new List<string>() {
            "#4a2275",
            "#223775",
            "#206e5f",
            "#6b2221",
            "#216b28",
            "#831F6D",
            "#1F8361",
            "#611F83",
            "#403E41"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            // if corr < 0, darken then
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }

            // if corr > 0, brighten then
            else
            {
                red = (255 - red) * correctionFactor;
                green = (255 - red) * correctionFactor;
                blue = (255 - blue) * correctionFactor;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
