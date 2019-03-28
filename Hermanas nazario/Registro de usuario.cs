using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermanas_nazario
{
    public partial class Registro_de_usuario : Form
    {
        public Registro_de_usuario()
        {
            InitializeComponent();
        }

        private void txtemp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string contra;
            string prof;
            if (!string.IsNullOrEmpty(txtusu.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtcontra.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtemp.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if(txtcontra.Text!=txtconf.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            int b = Base_de_datos.validarIDu(txtusu.Text);
            if (b == 0)
            {
                MessageBox.Show("Usuario ya existente");
                return;
            }
            contra = Encriptar.EncriptarContra(txtcontra.Text);
            prof= Encriptar.EncriptarContra(txtprof.Text.ToUpper());
            Base_de_datos.registrar_usuario(txtusu.Text, contra, int.Parse(txtemp.Text), prof.ToUpper());
            this.Close();
            menu a = new menu();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Base_de_datos a = new Base_de_datos();
            a.BuscarEmpleado();
            dataGridView1.DataSource = a.Mostrar_Resultados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtemp.Text = Convert.ToString(selectedRow.Cells[0].Value);
            dataGridView1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtprof_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprof_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
            Validar.espacio(e);
            Validar.sololetras(e);
        }

        private void txtusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txtconf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void Registro_de_usuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
