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
    public partial class Ingreso_puesto : Form
    {
        public Ingreso_puesto()
        {
            InitializeComponent();
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreRol.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            int ver = Base_de_datos.validarNomPuesto(txtNombreRol.Text);
            if (ver >= 1)
            {
                MessageBox.Show("Puesto ya existente");
                return;
                
            }
            
                Base_de_datos.Registro_Puesto(txtNombreRol.Text.ToUpper());
                MessageBox.Show("Registrado con exito");

                this.Hide();

           
        }

        private void Ingreso_puesto_Load(object sender, EventArgs e)
        {
            txtNombreRol.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
}
