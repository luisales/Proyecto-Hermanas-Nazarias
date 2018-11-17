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
    public partial class Ingresar_medicamento : Form
    {
        public Ingresar_medicamento()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!string.IsNullOrEmpty(txtnom.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(richTextBox1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtcant.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtprecio.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            int ver = Base_de_datos.validarNomMed(txtnom.Text);
            if (ver != 1)
            {
                MessageBox.Show("Medicamento ya existente");
                return;
            }
            if (txtUnidad.Text != "Frasco" && txtUnidad.Text != "Unidad" && txtUnidad.Text != "Caja")
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (int.Parse(txtcant.Text) == 0)
            {
                MessageBox.Show("Imposible ingresar 0");
                return;
            }


            Base_de_datos.registrar_medicamento(txtnom.Text, richTextBox1.Text, int.Parse(txtcant.Text), double.Parse(txtprecio.Text), txtUnidad.Text);
            codigo = Base_de_datos.codigo_medicamento();
            Base_de_datos.Ingresar_medicamento(codigo, int.Parse(txtcant.Text), fecha, dateTimePicker1.Value.ToString("MM/dd/yyyy"), Base_de_datos.cod_empleado);
            this.Hide();
            menu men = new menu();
            men.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }
        string fecha;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fech = DateTime.Now;
            label7.Text = fech.ToString("MM/dd/yyyy hh:mm:ss");
            fecha = label7.Text.ToString();
        }

        private void Ingresar_medicamento_Load(object sender, EventArgs e)
        {

        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}

