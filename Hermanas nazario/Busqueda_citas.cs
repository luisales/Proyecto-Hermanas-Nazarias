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
            txtcodigo.Text = Base_de_datos.Cod;
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
            if(Base_de_datos.accesoci==1)
            {
                this.Hide();
                Busqueda_de_pacientes b = new Busqueda_de_pacientes();
                b.Show();
            }
            if (Base_de_datos.accesoci == 2)
            {
                this.Hide();
                Busqueda_de_pacientes b = new Busqueda_de_pacientes();
                b.Show();
            }
            else
            {
                this.Hide();
                
            }       
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
           
            if(txtcodigo.TextLength>=1)
            Base_de_datos.busqueda_citas(int.Parse(txtcodigo.Text), dgvcitas);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtcodigo_Click(object sender, EventArgs e)
        {
        }

        private void dgvcitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcitas.DataSource != null)
            {
                if (Base_de_datos.decis==1)
                {
                    int i = dgvcitas.CurrentRow.Index;
                    Base_de_datos.cita = dgvcitas[0, i].Value.ToString();
                    Receta a = new Receta();
                    a.txtcita.Text = Base_de_datos.cita;
                    this.Hide();

                }
                else if(Base_de_datos.decis == 2)
                {
                    int i = dgvcitas.CurrentRow.Index;
                    Base_de_datos.cita = dgvcitas[0, i].Value.ToString();
                    this.Hide();
                    Generar_factura b = new Generar_factura();
                    b.Show();
                }
                else if(Base_de_datos.decis==3)
                {
                    int val;
                    int i = dgvcitas.CurrentRow.Index;
                    Base_de_datos.cita = dgvcitas[0, i].Value.ToString();
                    val = Base_de_datos.Validar_cita(Base_de_datos.cita);
                    if (val == 1)
                    {
                        this.Hide();
                        Diagnostico c = new Diagnostico();
                        c.Show();
                    }
                    else
                    {
                        Base_de_datos.Extraer_diagnostico(Base_de_datos.cita);
                        this.Hide();
                        Mostrar_Diagnostico d = new Mostrar_Diagnostico();
                        d.Show();
                    }
                    
                }

                

            }
        }

        private void dgvcitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Busqueda_citas_Load(object sender, EventArgs e)
        {

        }

        private void Busqueda_citas_Resize(object sender, EventArgs e)
        {

        }
    }
}
