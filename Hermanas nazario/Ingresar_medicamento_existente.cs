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
    public partial class Ingresar_medicamentoEx : Form
    {
        public Ingresar_medicamentoEx()
        {
            InitializeComponent();
            timer1.Enabled = true;

            txtcod.Text = Base_de_datos.CodMed;
            txtnom.Text = Base_de_datos.nommedi;
            txtprecio.Text = Base_de_datos.Precio_medicamento(Base_de_datos.CodMed);
            richTextBox1.Text = Base_de_datos.desc;
            txtUnidad.Text = Base_de_datos.unidad;
        }
                
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcant.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (int.Parse(txtcant.Text) == 0)
            {
                MessageBox.Show("Imposible ingresar 0");
                return;
            }

            Base_de_datos.registrar_medicamento(int.Parse(txtcod.Text),txtnom.Text.ToUpper(), richTextBox1.Text.ToUpper(), int.Parse(txtcant.Text) + int.Parse(Base_de_datos.cant), double.Parse(txtprecio.Text), txtUnidad.Text, "ACT", 2);
            Base_de_datos.Ingresar_medicamento(int.Parse(Base_de_datos.CodMed),(int.Parse(txtcant.Text)), dateTimePicker1.Value.ToString("yyyy/MM/dd"), 1, "ING");
            MessageBox.Show("Medicamento ingresado con exito");
            DialogResult = DialogResult.OK;
            Hide();
            
            
            


        }
        string fecha;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fech = DateTime.Now;
            label7.Text = fech.ToString("yyyy/MM/dd");
            fecha = label7.Text.ToString();
        }

        private void Ingresar_medicamentoEx_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            Hide();
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
            Validar.solonumeros(e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
}
