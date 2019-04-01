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
    public partial class Ingreso_ropa : Form
    {
        public Ingreso_ropa()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarCategoriaNom("");
            dataGridView1.DataSource = busc.Mostrar_Resultados();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                txtUnidad.Items.Add(row.Cells[1].Value.ToString());

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Ingreso_ropa_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnom.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtcant.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtUnidad.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            Base_de_datos.Registro_Ropa(1, txtnom.Text, int.Parse(txtcant.Text), txtUnidad.SelectedItem.ToString());
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            string c;
            c = txtnom.Text;
            if (c.StartsWith(" "))
            {
                MessageBox.Show("No se puede ingresar con espacio");
                txtnom.Text = "";
                return;
            }
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {

            string c;
            c = txtcant.Text;
            if (c.StartsWith(" "))
            {
                MessageBox.Show("No se puede ingresar con espacio");
                txtcant.Text = "";
                return;
            }
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
