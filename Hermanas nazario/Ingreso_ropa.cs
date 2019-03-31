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
            Base_de_datos.Registro_Ropa(1, txtnom.Text, int.Parse(txtcant.Text), txtUnidad.SelectedItem.ToString());
        }
    }
}
