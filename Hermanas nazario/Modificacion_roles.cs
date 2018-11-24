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
    public partial class Modificacion_roles : Form
    {
        public Modificacion_roles()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Modificacion_roles_Load(object sender, EventArgs e)
        {
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarRoles();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Permisos="";
            if (!string.IsNullOrEmpty(txtCodigoRol.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            if (!string.IsNullOrEmpty(txtNombreRol.Text) == false)
            {
                MessageBox.Show("Llene el nombre del rol");
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
            

            Base_de_datos.Actualizar_Rol(int.Parse(txtCodigoRol.Text), txtNombreRol.Text.ToUpper(), Permisos );

           MessageBox.Show("Rol modificado.");
            
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarRoles();
            dataGridView1.DataSource = busc.Mostrar_Resultados();

            txtCodigoRol.Clear();
            txtNombreRol.Clear();
            btnModificar.Enabled = false;
            
        }

        private void txtCodigoRol_TextChanged(object sender, EventArgs e)
        {
            txtNombreRol.Enabled = false;
            btnModificar.Enabled = false;

            if ((!string.IsNullOrEmpty(txtCodigoRol.Text)))
            {
                txtNombreRol.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigoRol.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreRol.Text = Convert.ToString(selectedRow.Cells[1].Value);
        }
    }
}
