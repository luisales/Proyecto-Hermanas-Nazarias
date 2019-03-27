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
    public partial class Modificar_Nivel : Form
    {
        public Modificar_Nivel()
        {
            InitializeComponent();
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
            if (!string.IsNullOrEmpty(textBox1.Text) == false)
            {
                MessageBox.Show("Llene el porcentaje");
                return;
            }
            int ver = Base_de_datos.validarNomNivelMod(txtNombreRol.Text, txtCodigoRol.Text);
            if (ver != 1)
            {
                MessageBox.Show("Nivel ya existente");
                return;
            }
            Base_de_datos.Actualizar_Nivel(int.Parse(txtCodigoRol.Text), txtNombreRol.Text.ToUpper(), float.Parse(textBox1.Text));

            MessageBox.Show("Nivel modificada.");

            Base_de_datos busc = new Base_de_datos();
            busc.BuscarNivel();
            dataGridView1.DataSource = busc.Mostrar_Resultados();

            txtCodigoRol.Clear();
            txtNombreRol.Clear();
            textBox1.Clear();
            btnModificar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Modificar_Nivel_Load(object sender, EventArgs e)
        {
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarNivel();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigoRol.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreRol.Text = Convert.ToString(selectedRow.Cells[1].Value);
        }

        private void txtCodigoRol_TextChanged(object sender, EventArgs e)
        {
            txtNombreRol.Enabled = false;
            btnModificar.Enabled = false;
            textBox1.Enabled = false;

            if ((!string.IsNullOrEmpty(txtCodigoRol.Text)))
            {
                txtNombreRol.Enabled = true;
                btnModificar.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
