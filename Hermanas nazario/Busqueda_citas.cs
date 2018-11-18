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
    public partial class Busqueda_citas : Form
    {
        public Busqueda_citas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new Hermanas_nazario.menu();
            a.Show();
            
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtcodigo.TextLength>=1)
            Base_de_datos.busqueda_citas(int.Parse(txtcodigo.Text), dgvcitas);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtcodigo_Click(object sender, EventArgs e)
        {
        }

        private void dgvcitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcitas.DataSource != null)
            {
                if(Base_de_datos.decis==1)
                {
                    int i = dgvcitas.CurrentRow.Index;
                    Base_de_datos.cita = dgvcitas[0, i].Value.ToString();
                    this.Hide();
                    Receta a = new Receta();
                    a.Show();
                }
                else if(Base_de_datos.decis == 2)
                {
                    int i = dgvcitas.CurrentRow.Index;
                    Base_de_datos.cita = dgvcitas[0, i].Value.ToString();
                    this.Hide();
                    Generar_factura b = new Generar_factura();
                    b.Show();
                }
                

            }
        }

        private void dgvcitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
