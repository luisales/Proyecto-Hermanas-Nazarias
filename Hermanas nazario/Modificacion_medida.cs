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
    public partial class Modificacion_medida : Form
    {
        public Modificacion_medida()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modificacion_medida_Load(object sender, EventArgs e)
        {
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarMedida();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoRol.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            if (!string.IsNullOrEmpty(txtNombreRol.Text) == false)
            {
                MessageBox.Show("Llene el nombre de medida");
                return;
            }

            int ver = Base_de_datos.validarNomMedidaMod(txtNombreRol.Text, txtCodigoRol.Text);
            if (ver != 1)
            {
                MessageBox.Show("Medida ya existente");
                return;
            }

            string estado;

            if (cmbestado.Text == "Activo")
            {
                estado = "ACT";
            }

            else
            {
                estado = "DSC";
            }

            Base_de_datos.Actualizar_Medida(int.Parse(txtCodigoRol.Text), txtNombreRol.Text.ToUpper(),estado);

            MessageBox.Show("Medida modificada.");

            Base_de_datos busc = new Base_de_datos();
            busc.BuscarMedida();
            dataGridView1.DataSource = busc.Mostrar_Resultados();

            txtCodigoRol.Clear();
            txtNombreRol.Clear();
            
            btnModificar.Enabled = false;
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigoRol.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreRol.Text = Convert.ToString(selectedRow.Cells[1].Value);
            cmbestado.Text= Convert.ToString(selectedRow.Cells[2].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);

        }
    }
}
