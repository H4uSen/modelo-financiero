using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Utils
{
    public static class ChildForm
    {
        public static void Open(Form childForm, Point position, Panel panel)
        {
            // Close previous form if exists
            //if (activeForm != null)
            //    activeForm.Close();

            //activeForm = childForm;

            // Important settings
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;

            // Add to panel
            //panel2.Controls.Clear();
            //panel2.Tag = childForm;

            //Set the position
            childForm.Location = position;

            panel.Controls.Add(childForm);


            childForm.BringToFront();
            childForm.Show();
        }
        
    }
}
