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
    public partial class Referencia : Form
    {
        public Referencia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            txtnom.Visible = false;
            txtape.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
            txtape.Enabled = false;
            txtape.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            label1.Text = "Identidad: ";
            txtId.Enabled = true;
            txtId.Visible = true;
            dataGridView1.DataSource = null;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtnom.Visible = true;
            txtape.Enabled = true;
            txtape.Visible = true;
            label3.Visible = true;
            txtape.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
            pictureBox1.Visible = true;
            label1.Text = "Primer Nombre: ";
            txtId.Enabled = false;
            txtId.Visible = false;
            dataGridView1.DataSource = null;
            
        }

        private void txtape_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.Buscar(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
                
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.Buscar(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
                
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked && txtId.TextLength == 13)
            {

                Base_de_datos busc = new Base_de_datos();
                busc.Buscar(txtId.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();

            }
            else
            {
                dataGridView1.DataSource = null;
             
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.DataSource != null)
            {
                int i = dataGridView1.CurrentRow.Index;
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String Titulo = "\t\tDispensario Médico Hermana Nazaria";
            String Titulo2 = "\n\tAguas del Padre, Siguatepeque, Comayagua";
            txtTitulo.Text = (Titulo+Titulo2);
            
        }
    }
}
