using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermanas_nazario
{
    public partial class Restablecimiento : Form
    {
        public Restablecimiento()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string a;
            if(txtcontra.Text!=txtconf.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            a=Encriptar.EncriptarContra(txtcontra.Text);
            Base_de_datos.Restablecer(Base_de_datos.contra, a);
            MessageBox.Show("Restablecida con exito");
            this.Hide();
            Login b = new Login();
            b.Show();
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtcontra.Text)) && (!string.IsNullOrEmpty(txtconf.Text)))

                btningresar.Enabled = true;

            else

                btningresar.Enabled = false;
        }

        private void txtconf_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtcontra.Text)) && (!string.IsNullOrEmpty(txtconf.Text)))

                btningresar.Enabled = true;

            else

                btningresar.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recuperar_contrasenia a = new Recuperar_contrasenia();
            a.Show();
        }
    }
}
