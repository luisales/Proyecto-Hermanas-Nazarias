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
    public partial class ingresoPrendaExisntente : Form
    {
        public int cat, cant;
        public ingresoPrendaExisntente()
        {
            InitializeComponent();
        }

        private void ingresoPrendaExisntente_Load(object sender, EventArgs e)
        {
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarPrenda();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtcod.Text = Convert.ToString(selectedRow.Cells[0].Value);
            textBox1.Text = Convert.ToString(selectedRow.Cells[1].Value);
            cant = int.Parse(Convert.ToString(selectedRow.Cells[2].Value));
            cat = int.Parse(Convert.ToString(selectedRow.Cells[3].Value));
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;

            if ((!string.IsNullOrEmpty(txtcod.Text)))
            {
               btnBuscar.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcant.Text) == false)
            {
                MessageBox.Show("Llene la cantidad");
                return;
            }

            if(int.Parse(txtcant.Text)<=0)
            {
                MessageBox.Show("La cantidad no pueder ser menor a 1");
                return;
            }

            Base_de_datos.Registro_RopaEx(int.Parse(txtcod.Text), textBox1.Text.ToUpper(), (int.Parse(txtcant.Text)+cant), cat);
            Base_de_datos.movimientoRopaIng(int.Parse(txtcod.Text), textBox1.Text.ToUpper(), int.Parse(txtcant.Text));

            MessageBox.Show("Prenda Ingresada.");

            Base_de_datos busc = new Base_de_datos();
            busc.BuscarPrenda();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
            txtcod.Clear();
            textBox1.Clear();
            txtcant.Clear();

            DialogResult = DialogResult.OK;
            
            this.Hide();

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }
    }
}
