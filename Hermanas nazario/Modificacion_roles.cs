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
            string Permisos = "";
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
            if (int.Parse(txtCodigoRol.Text) == 1)
            {
                MessageBox.Show("No puede modificar el administrador");
            }
            else
            {
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


                String estado;
                if (cmbestado.Text == "Activo")
                {
                    estado = "ACT";
                }

                else
                {
                    estado = "DSC";
                }

                int x=Base_de_datos.Actualizar_Rol(int.Parse(txtCodigoRol.Text), txtNombreRol.Text.ToUpper(), Permisos, estado);
                if (x == 1)
                {


                    MessageBox.Show("Rol modificado.");

                    Base_de_datos busc = new Base_de_datos();
                    busc.BuscarRoles();
                    dataGridView1.DataSource = busc.Mostrar_Resultados();

                    txtCodigoRol.Clear();
                    txtNombreRol.Clear();
                    
                    btnModificar.Enabled = false;
                    this.Hide();
                }
                else
                {
                    txtCodigoRol.Clear();
                    txtNombreRol.Clear();
                    chkDocumentos.Checked = false;
                    chkEmpleados.Checked = false;
                    chkFacturacion.Checked = false;
                    chkInventario.Checked = false;
                    chkMantenimientos.Checked = false;
                    chkPacientes.Checked = false;
                    chkUsuarios.Checked = false;
                }
            }
               
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
            string per,est;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigoRol.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreRol.Text = Convert.ToString(selectedRow.Cells[1].Value);
            est = Convert.ToString(selectedRow.Cells[2].Value);
            textBox1.Text = Convert.ToString(selectedRow.Cells[3].Value);
            if(est=="ACT")
            {
                cmbestado.Text = "Activo";
            }
            else
            {
                cmbestado.Text = "Inactivo";
            }
            if (textBox1.Text.Contains('A') == true)
            {
                chkPacientes.Checked = true;
            }
            if (textBox1.Text.Contains('B') == true)
            {
                chkEmpleados.Checked = true;
            }
            if (textBox1.Text.Contains('C') == true)
            {
                chkUsuarios.Checked = true;
            }
            if (textBox1.Text.Contains('D') == true)
            {
                chkFacturacion.Checked = true;
            }
            if (textBox1.Text.Contains('E') == true)
            {
                chkInventario.Checked = true;
            }
            if (textBox1.Text.Contains('F') == true)
            {
                chkDocumentos.Checked = true;
            }
            if (textBox1.Text.Contains('G') == true)
            {
                chkMantenimientos.Checked = true;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkPacientes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEmpleados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('A') == true)
            {
                chkPacientes.Checked = true;
            }
            if (textBox1.Text.Contains('B') == true)
            {
                chkEmpleados.Checked = true;
            }
            if (textBox1.Text.Contains('C') == true)
            {
                chkUsuarios.Checked = true;
            }
            if (textBox1.Text.Contains('D') == true)
            {
                chkFacturacion.Checked = true;
            }
            if (textBox1.Text.Contains('E') == true)
            {
                chkInventario.Checked = true;
            }
            if (textBox1.Text.Contains('F') == true)
            {
                chkDocumentos.Checked = true;
            }
            if (textBox1.Text.Contains('G') == true)
            {
                chkMantenimientos.Checked = true;
            }
            

            chkDocumentos.Checked = false;
            chkEmpleados.Checked = false;
            chkFacturacion.Checked = false;
            chkInventario.Checked = false;
            chkMantenimientos.Checked = false;
            chkPacientes.Checked = false;
            chkUsuarios.Checked = false;

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
