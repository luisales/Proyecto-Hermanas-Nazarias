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
    public partial class venc : Form
    {
        public static int canti;
        public venc()
        {

            InitializeComponent();
            
           
          
        }

        private void vencimineto_inventario_Load(object sender, EventArgs e)
        {
            txtcod.Text = Base_de_datos.CodMed;

            int x = 0;
            x = Base_de_datos.validmedi((txtcod.Text));
            txtnom.Text = Base_de_datos.nommedi;
            txtcant.Text = Base_de_datos.cant;
            txtdesc.Text = Base_de_datos.desc;
            txtUnidad.Text = Base_de_datos.unidad;
            txtUnidad.Text = Base_de_datos.unidad;

            txtrem.Enabled = true;
            txtcod.Enabled = false;
            button2.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtrem.Text) == false)
            {
                MessageBox.Show("Ingrese la cantidad a modificar");
                return;

            }

            if (int.Parse(txtrem.Text) == 0)
            {
                MessageBox.Show("Imposible ingresar 0");
                return;
            }

            if (int.Parse(Base_de_datos.cant)> int.Parse(txtrem.Text))
            {
                canti = (int.Parse(Base_de_datos.cant)) - (int.Parse(txtrem.Text));
                Base_de_datos.vencemedi(int.Parse(txtcod.Text), canti);
                txtrem.Enabled = false;
                txtcod.Enabled = true;
                txtcod.Clear();
                txtcant.Clear();
                txtnom.Clear();
                txtdesc.Clear();
                txtrem.Clear();

                txtcod.Focus();


                MessageBox.Show("Cantidad Modificada Correctamente");

            }
            else
            {

                MessageBox.Show("Valor invalido");
                txtrem.Focus();
            }

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);

        }

        private void txtrem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Busqueda_medicamentos a = new Busqueda_medicamentos();
            a.Show();

        }
    }

}