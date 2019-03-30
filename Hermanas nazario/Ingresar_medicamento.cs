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
            int codigo, medida=0;
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
            if (txtUnidad.Text == "Caja")
            {
                medida = 1;
            }
            if (txtUnidad.Text == "Unidad")
            {
                medida = 2;
            }
            if (txtUnidad.Text == "Frasco")
            {
                medida = 3;
            }

           

            Base_de_datos.registrar_medicamento(txtnom.Text.ToUpper(), richTextBox1.Text.ToUpper(), int.Parse(txtcant.Text), double.Parse(txtprecio.Text), medida,"ACT", 1);
            codigo = Base_de_datos.codigo_medicamento();
            Base_de_datos.Ingresar_medicamento(codigo, int.Parse(txtcant.Text), fecha, dateTimePicker1.Value.ToString("MM/dd/yyyy"), Base_de_datos.cod_empleado);
            this.Hide();
            menu men = new menu();
            men.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        string fecha;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fech = DateTime.Now;
            label7.Text = fech.ToString("MM/dd/yyyy HH:mm:ss");
            fecha = label7.Text.ToString();
        }

        private void Ingresar_medicamento_Load(object sender, EventArgs e)
        {

        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            Validar.espacio(e);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

