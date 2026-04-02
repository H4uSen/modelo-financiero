using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Utils
{
    public static class FormValidator
    {
        public static bool ValidateRequired(Control parent, ErrorProvider errorProvider)
        {
            bool isValid = true;

            foreach (Control control in parent.Controls)
            {
                if (control is TextBox tb)
                {
                    if(tb.Tag == null)
                    {
                        if (string.IsNullOrWhiteSpace(tb.Text))
                        {
                            errorProvider.SetError(tb, "Es campo no puede estar vacío");
                            isValid = false;
                        }
                        else
                        {
                            errorProvider.SetError(tb, "");
                        }
                    }
                }

                if (control.HasChildren)
                {
                    if (!ValidateRequired(control, errorProvider))
                        isValid = false;
                }
            }
            

            return isValid;
        }
    }
}
