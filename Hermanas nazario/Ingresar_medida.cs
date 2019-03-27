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
    public partial class Ingresar_medida : Form
    {
        public Ingresar_medida()
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
            int ver = Base_de_datos.validarNomMedida(txtNombreRol.Text);
            if (ver != 1)
            {
                MessageBox.Show("Medida ya existente");
                return;
            }
            String estado;
            if(cmbestado.Text=="Activo")
            {
                estado = "ACT";
            }

            else
            {
                estado = "DSC";
            }

            Base_de_datos.Registro_Medida(txtNombreRol.Text.ToUpper(), estado);
            MessageBox.Show("Registrado con exito");

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ingresar_medida_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }
    }
}
