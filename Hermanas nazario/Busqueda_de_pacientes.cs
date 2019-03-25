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
    public partial class Busqueda_de_pacientes : Form
    {
        public Busqueda_de_pacientes()
        {
            InitializeComponent();
            timer1.Enabled = true;
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
                txtGencita.Text = "";
            }

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
                txtGencita.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Base_de_datos.accesoci = 0;
            this.Hide();
            
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
            btnGencita.Enabled = false;
            btnModificar.Enabled = false;
            txtGencita.Text = "";
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
            btnGencita.Enabled = false;
            btnModificar.Enabled = false;
            txtGencita.Text = "";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
           
            if (radioButton2.Checked &&txtId.TextLength==13 )
            {
                
                    Base_de_datos busc = new Base_de_datos();
                    busc.Buscar(txtId.Text);
                    dataGridView1.DataSource = busc.Mostrar_Resultados();
               
            }
            else
            {
                dataGridView1.DataSource = null;
                txtGencita.Text = "";
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void btnGencita_Click(object sender, EventArgs e)
        {
            Base_de_datos.Ingresar_cita(int.Parse(txtGencita.Text),fecha);
            MessageBox.Show("Cita ingresada");
            btnGencita.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.DataSource != null)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtGencita.Text = dataGridView1[0, i].Value.ToString();
                btnGencita.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void txtGencita_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtGencita.Text)))
            {
                btnGencita.Enabled = true;
                txtir.Enabled = true;
            }
            else
            {
                btnGencita.Enabled = false;
                txtir.Enabled = false;
            }
                
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
            Base_de_datos.accesoci = 1;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            Base_de_datos.Cod = Convert.ToString(selectedRow.Cells[0].Value);

            this.Hide();
            ModifcacionPaciente a = new ModifcacionPaciente();
            a.Show();
        }

        private void txtir_Click(object sender, EventArgs e)
        {
            Base_de_datos.accesoci = 1;
            Base_de_datos.decis = 3;
            Base_de_datos.Cod = txtGencita.Text;
            this.Hide();
            Busqueda_citas a = new Busqueda_citas();
            a.Show();
        }
    }
        
}
