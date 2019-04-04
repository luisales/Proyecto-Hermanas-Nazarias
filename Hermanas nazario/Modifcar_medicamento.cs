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
    public partial class Modifcar_medicamento : Form
    {
        public Modifcar_medicamento()
        {
            InitializeComponent();
            codigomed.Text = Base_de_datos.CodMed;
            txtnom.Text = Base_de_datos.nommedi;
            txtprecio.Text = Base_de_datos.Precio_medicamento(Base_de_datos.CodMed);
            richTextBox1.Text = Base_de_datos.desc;
            dataGridView1.AllowUserToAddRows = false;
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarMedida();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
            txtcant.Text = Base_de_datos.vcant;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                txtUnidad.Items.Add(row.Cells[1].Value.ToString());

            }
            txtUnidad.Text = Base_de_datos.unidad;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            codigomed.Focus();
            x = Base_de_datos.Validar_Cod_Medicamento(codigomed.Text);

            if (x == 1)
            {
                txtnom.Clear();
                txtprecio.Clear();
                txtcant.Clear();
                richTextBox1.Clear();

                txtnom.Text = Base_de_datos.vnom;
                txtprecio.Text = Base_de_datos.vprecio;
                txtcant.Text = Base_de_datos.vcant;
                richTextBox1.Text = Base_de_datos.vdesc;




                txtnom.Enabled = true;
                txtprecio.Enabled = true;
                txtcant.Enabled = true;
                richTextBox1.Enabled = true;
                txtUnidad.Enabled = true;

                codigomed.Enabled = false;
            }

            else
            {
                MessageBox.Show("No existe codigo");

                codigomed.Clear();
                codigomed.Focus();
                txtnom.Enabled = false;
                txtprecio.Enabled = false;
                txtcant.Enabled = false;
                richTextBox1.Enabled = false;
                txtUnidad.Enabled = false;

                txtnom.Clear();
                txtprecio.Clear();
                txtcant.Clear();
                richTextBox1.Clear();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Base_de_datos.Actualizar_Medicamento(int.Parse(codigomed.Text), txtnom.Text.ToUpper(), txtcant.Text.ToUpper(), richTextBox1.Text.ToUpper(), txtprecio.Text.ToUpper(), txtUnidad.SelectedItem.ToString());
            MessageBox.Show("Medicamento guardado con exito");
            this.Hide();
            codigomed.Clear();
            codigomed.Focus();
            txtnom.Enabled = false;
            txtcant.Enabled = false;
            richTextBox1.Enabled = false;
            txtprecio.Enabled = false;
            txtUnidad.Enabled = false;


            txtnom.Clear();
            codigomed.Clear();
            richTextBox1.Clear();
            txtcant.Clear();
            txtprecio.Clear();
            codigomed.Enabled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void codigomed_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void codigomed_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modifcar_medicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string c;
            c = richTextBox1.Text;
            if (c.StartsWith(" "))
            {
                MessageBox.Show("No se puede ingresar con espacio");
                richTextBox1.Text = "";
                return;
            }
        }
    }
}
