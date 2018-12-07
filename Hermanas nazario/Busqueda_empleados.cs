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
    public partial class Busqueda_empleados : Form
    {
        public Busqueda_empleados()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void txtape_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarE(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void Busqueda_de_pacientes_Load(object sender, EventArgs e)
        {

        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
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
            pictureBox2.Visible = true;
            label1.Text = "Primer Nombre: ";
            txtId.Enabled = false;
            txtId.Visible = false;
            dataGridView1.DataSource = null;
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
            pictureBox2.Visible = false;
            label1.Text = "Identidad: ";
            txtId.Enabled = true;
            txtId.Visible = true;
            dataGridView1.DataSource = null;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked && txtId.TextLength == 13)
            {

                Base_de_datos busc = new Base_de_datos();
                busc.BuscarE(txtId.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();

            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void btnGencita_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtGencita_TextChanged(object sender, EventArgs e)
        {
        }
        string fecha;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fech = DateTime.Now;
            label2.Text = fech.ToString("MM/dd/yyyy HH:mm:ss");
            fecha = label2.Text.ToString();
        }

        private void txtId_Click(object sender, EventArgs e)
        {
        }

        private void txtGencita_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            Base_de_datos.Cod = Convert.ToString(selectedRow.Cells[0].Value);

            this.Hide();
            ModifcacionPaciente a = new ModifcacionPaciente();
            a.Show();
        }

        private void txtape_TextChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarEE(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void Busqueda_empleados_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked && txtId.TextLength == 13)
            {

                Base_de_datos busc = new Base_de_datos();
                busc.BuscarEE(txtId.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();

            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtnom.Visible = true;
            txtape.Enabled = true;
            txtape.Visible = true;
            label3.Visible = true;
            txtape.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
            pictureBox2.Visible = true;
            label1.Text = "Primer Nombre: ";
            txtId.Enabled = false;
            txtId.Visible = false;
            dataGridView1.DataSource = null;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            txtnom.Visible = false;
            txtape.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
            txtape.Enabled = false;
            txtape.Visible = false;
            label3.Visible = false;
            pictureBox2.Visible = false;
            label1.Text = "Identidad: ";
            txtId.Enabled = true;
            txtId.Visible = true;
            dataGridView1.DataSource = null;
        }

        private void txtnom_TextChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarEE(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}

