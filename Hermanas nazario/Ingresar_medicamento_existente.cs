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
          
            txtcodigo.Text = Base_de_datos.CodMed;
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


            Base_de_datos.Ingresar_medicamento(int.Parse(txtcodigo.Text),int.Parse(txtcant.Text),fecha, dateTimePicker1.Value.ToString("MM/dd/yyyy"), int.Parse(txtcodigo.Text));
            MessageBox.Show("Medicamentos ingresados correctamente");
            Close();
            Busqueda_medicamentos a = new Busqueda_medicamentos();
            a.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        string fecha;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fech = DateTime.Now;
            label7.Text = fech.ToString("MM/dd/yyyy hh:mm:ss");
            fecha = label7.Text.ToString();
        }

        private void Ingresar_medicamentoEx_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
            Busqueda_medicamentos a = new Busqueda_medicamentos();
            a.Show();
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}
