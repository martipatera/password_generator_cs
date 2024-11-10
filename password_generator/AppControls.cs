using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace password_generator
{
    public sealed class AppControls : Form //dedim abych mohl pouzivat Control, sealed = nemuze byt prepsana nebo dedena
    {
        public static void Exit()
        {

            Application.Exit();
        }

        public static void HideAllBtns(Form form) //Form trida .NET, form je lokalni promenna
        {
            foreach(Control control in form.Controls)
            {
                control.Visible = false;
            }
        }

        public static void ShowAllBtns(Form form) //Form trida .NET, form je lokalni promenna
        {
            foreach (Control control in form.Controls)
            {
                control.Visible = true;
            }
        }

    }
}
