using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace modelo_finanzas.Utils
{
    public static class InputValidator
    {
        public static void integerValidation(TextBox textBox,KeyPressEventArgs e, bool includeNegatives = false)
        {
            if (textBox.Text.Contains('-') && !includeNegatives && textBox.Text.Length == 1)
            {
                e.Handled = true;
                return;
            }
            string integerPattern = (includeNegatives) ? @"^-?\d*$" : @"^\d*$";

            bool isValid = Regex.IsMatch(textBox.Text + e.KeyChar, integerPattern);

            if (!isValid && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public static void decimalValidation(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (textBox.Text.Contains('.') || textBox.Text.Length == 0))
            {
                e.Handled = true;
            }


        }

        public static void removeFormat(object? sender, EventArgs e)
        {
            if(sender is TextBox textBox)
            {
                if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string valorLimpio = textBox.Text.Replace("$", "")
                                                 .Replace("%", "")
                                                 .Replace(",", "")
                                                 .Trim();
                    textBox.Text = valorLimpio;
                }
            }
            
        }
    }
}
