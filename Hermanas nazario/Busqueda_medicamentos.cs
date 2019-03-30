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
    public partial class Busqueda_medicamentos : Form
    {
        public Busqueda_medicamentos()
        {
            Base_de_datos busc = new Base_de_datos();
            InitializeComponent();
            busc.BuscarMedNom("");
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtnom.Visible = true;
            label1.Text = "Nombre";
            txtCod.Enabled = false;
            txtCod.Visible = false;
            txtCod.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            txtnom.Visible = false;
            label1.Text = "Código";
            txtCod.Enabled = true;
            txtCod.Visible = true;
            txtnom.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Base_de_datos.CodMed = lblCod.Text;
            this.Hide();
            venc a = new venc();
            a.Show();

        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            Base_de_datos.CodMed = lblCod.Text;
            Base_de_datos.nommedi = lblNom.Text;
            Base_de_datos.cant = lblCan.Text;
            Base_de_datos.desc = txtUnidad.Text;
            Base_de_datos.unidad = label10.Text;
           
            Ingresar_medicamentoEx a = new Ingresar_medicamentoEx();
            a.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                lblCod.Text = Convert.ToString(selectedRow.Cells[0].Value);
                lblNom.Text = Convert.ToString(selectedRow.Cells[1].Value);
                lblCan.Text = Convert.ToString(selectedRow.Cells[2].Value);
                lblDes.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txtUnidad.Text = Convert.ToString(selectedRow.Cells[4].Value);
                label10.Text = Convert.ToString(selectedRow.Cells[5].Value);
            }
            if (radioButton2.Checked)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                lblCod.Text = Convert.ToString(selectedRow.Cells[0].Value);
                lblNom.Text = Convert.ToString(selectedRow.Cells[1].Value);
                lblCan.Text = Convert.ToString(selectedRow.Cells[2].Value);
                lblDes.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txtUnidad.Text = Convert.ToString(selectedRow.Cells[4].Value);
                label10.Text = Convert.ToString(selectedRow.Cells[5].Value);
            }



            btnIng.Enabled = true;
            btnSac.Enabled = true;
        }

        private void txtnom_TextChanged_1(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked && txtnom.TextLength>=0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarMedNom(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else if (radioButton2.Checked && txtCod.TextLength == 0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarMedNom("");
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else if (radioButton2.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarMedCod(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            dataGridView1.DataSource = null;
            lblCan.Text = "*";
            lblNom.Text = "*";
            lblDes.Text = "*";
            lblCod.Text = "*";
            txtUnidad.Text = "*";
            label10.Text = "*";
            
            btnIng.Enabled = false;
            btnSac.Enabled = false;
        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
