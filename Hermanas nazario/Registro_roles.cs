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
    public partial class Registro_roles : Form
    {
        public Registro_roles()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string Permisos = "";
            if (!string.IsNullOrEmpty(txtNombreRol.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (chkPacientes.Checked)
            {
                Permisos = (Permisos + "A");
            }
            if (chkEmpleados.Checked)
            {
                Permisos = (Permisos + "B");
            }
            if (chkUsuarios.Checked)
            {
                Permisos = (Permisos + "C");
            }
            if (chkFacturacion.Checked)
            {
                Permisos = (Permisos + "D");
            }
            if (chkInventario.Checked)
            {
                Permisos = (Permisos + "E");
            }
            if (chkDocumentos.Checked)
            {
                Permisos = (Permisos + "F");
            }
            if (chkMantenimientos.Checked)
            {
                Permisos = (Permisos + "G");
            }

            Base_de_datos.Registro_Rol(txtNombreRol.Text.ToUpper(), Permisos);

            this.Hide();

        }

        private void Registro_roles_Load(object sender, EventArgs e)
        {

        }
    }
}
