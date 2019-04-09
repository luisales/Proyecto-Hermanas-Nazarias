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
    public partial class Registro_Nivel : Form
    {
        public Registro_Nivel()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreRol.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            int ver = Base_de_datos.validarNomNivel(txtNombreRol.Text);
                if (ver != 1)
                {
                    MessageBox.Show("Nivel ya existente");
                    return;
                }

            
            Base_de_datos.Registro_Nivel(txtNombreRol.Text, float.Parse(textBox1.Text));
                MessageBox.Show("Registrado con exito");

                this.Hide();
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
           // Validar.espacio(e);
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Registro_Nivel_Load(object sender, EventArgs e)
        {
            txtNombreRol.Focus();
        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {
            string c;
            c = txtNombreRol.Text;
            if (c.StartsWith(" "))
            {
                MessageBox.Show("No se puede ingresar con espacio");
                txtNombreRol.Text = "";
                return;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
    }
