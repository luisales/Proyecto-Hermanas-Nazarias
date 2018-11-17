using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hermanas_nazario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string contra;
            Base_de_datos.acceso(txtusuario.Text);
            contra = Encriptar.EncriptarContra(txtcontraseña.Text);
            int x = 0;
            x=Base_de_datos.Log(txtusuario.Text, contra);
            if (x == 1)
            {
                Base_de_datos.User=txtusuario.Text;
                this.Hide();
                
            }
            else
            {
                txtcontraseña.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recuperar_contrasenia a = new Recuperar_contrasenia();
            a.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
