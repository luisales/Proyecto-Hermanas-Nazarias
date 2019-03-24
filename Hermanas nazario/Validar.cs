using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermanas_nazario
{
   public class Validar
    {
            public static void sololetras(KeyPressEventArgs v)
            {
                if (Char.IsLetter(v.KeyChar))
                {
                    v.Handled = false;
                }
            else if (char.IsWhiteSpace(v.KeyChar))
            {
                v.Handled = true;
            }
            else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                    MessageBox.Show("Permitido solo letras");
                }

            }
        

                public static void solonumeros(KeyPressEventArgs v)
                {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if(char.IsWhiteSpace(v.KeyChar))
            {
                v.Handled = true;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Permitido solo numeros");
            }
                }


        public static void espacio(KeyPressEventArgs v)
        {
           
            if (char.IsWhiteSpace(v.KeyChar))
            {
                v.Handled = true;
        }

    }
}
}

