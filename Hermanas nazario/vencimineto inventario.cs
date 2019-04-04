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

            if (int.Parse(txtcant.Text)> int.Parse(txtrem.Text))
            {
                int x, y;
                x = int.Parse(Base_de_datos.cant);
                y = int.Parse(txtrem.Text);
                Base_de_datos.registrar_medicamento(int.Parse(Base_de_datos.CodMed),txtnom.Text.ToUpper(), txtdesc.Text.ToUpper(),x-y, double.Parse(Base_de_datos.Precio_medicamento(Base_de_datos.CodMed)), txtUnidad.Text, "ACT", 2);
                Base_de_datos.Ingresar_medicamento(int.Parse(Base_de_datos.CodMed), (int.Parse(txtrem.Text)), "", 1, "EGR");
                MessageBox.Show("Egreso de medicamento exitoso");
               txtrem.Enabled = false;
                txtcod.Enabled = true;

                txtcod.Clear();
                txtcant.Clear();
                txtnom.Clear();
                txtdesc.Clear();
                txtrem.Clear();

                txtcod.Focus();
                
                Hide();
                
               


            }
            else
            {

                MessageBox.Show("Valor invalido cantidad no disponible");
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
            Validar.espacio(e);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Hide();
            

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}