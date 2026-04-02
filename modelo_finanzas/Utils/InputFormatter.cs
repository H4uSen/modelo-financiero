using OpenTK.Graphics.ES11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Utils
{
    public static class inputFormatter
    {
        public static void integerFormatter(object? s, EventArgs e, String suffix = "")
        {
            if (s is TextBox textBox)
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    textBox.Text = value.ToString("N0") + suffix;
                }
            }
        }

        public static void decimalFormatter(object? s, EventArgs e, String suffix = "")
        {
            if (s is TextBox textBox)
            {
                if (double.TryParse(textBox.Text, out double value))
                {
                    textBox.Text = (value).ToString($"0.##") + suffix;
                }
            }
        }

        public static void removeFormatOnEdit(object? s, EventArgs e, String remove)
        {
            if(s is TextBox textBox)
            {
                textBox.Text.Replace(remove, "");
            }
        }
    }
}
