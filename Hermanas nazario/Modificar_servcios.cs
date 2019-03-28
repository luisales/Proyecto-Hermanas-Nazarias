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
    public partial class Modificar_servcios : Form
    {
        public Modificar_servcios()
        {
            InitializeComponent();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtNombreServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void Modificar_servcios_Load(object sender, EventArgs e)
        {
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarServicio();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreServicio.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            if (!string.IsNullOrEmpty(txtprecio.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios"); 
                return;
            }

            if (Base_de_datos.validarServicioMod(txtNombreServicio.Text, txtCodigo.Text) == 0)
            {
                MessageBox.Show("Servicio ya existente");
                return;

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

            Base_de_datos.Actualizar_Servicio(int.Parse(txtCodigo.Text), txtNombreServicio.Text.ToUpper(), txtDescripcion.Text.ToUpper(), txtprecio.Text, estado);
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarServicio();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
            MessageBox.Show("Modificado con exito");
            txtCodigo.Clear();
            txtNombreServicio.Clear();
            txtprecio.Clear();
            txtDescripcion.Clear();
            btnModificar.Enabled = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigo.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreServicio.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtDescripcion.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtprecio.Text = Convert.ToString(selectedRow.Cells[3].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtNombreServicio.Enabled = false;
            btnModificar.Enabled = false;
            txtDescripcion.Enabled = false;
            txtprecio.Enabled = false;

            if ((!string.IsNullOrEmpty(txtCodigo.Text)))
            {
                txtNombreServicio.Enabled = true;
                txtDescripcion.Enabled = true;
                txtprecio.Enabled = true;

                btnModificar.Enabled = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
