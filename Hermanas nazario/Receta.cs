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
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
            txtcita.Text = Base_de_datos.cita;
            Base_de_datos.decis = 1;
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarMedNom("");
            dataGridView1.DataSource = busc.Mostrar_Resultados();
            busc.BuscarRiesgo();
            dataGridView3.DataSource = busc.Mostrar_Resultados();

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                txtriesgo.Items.Add(row.Cells[1].Value.ToString());

            }

        }
        public void hola()
        {
            txtcita.Text = Base_de_datos.cita;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Base_de_datos.accesoci = 2;
            Busqueda_citas a = new Busqueda_citas();
            a.ShowDialog();

            if(a.DialogResult==DialogResult.OK)
            {
                txtcita.Text = Base_de_datos.cita;
            }
        }

        private void txtcita_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtmedicamento.Text = dataGridView1[0, i].Value.ToString();
                txtnombre.Text = dataGridView1[1, i].Value.ToString();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nom = Base_de_datos.Nombre_medicamento(txtmedicamento.Text);
            if (!string.IsNullOrEmpty(txtcita.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtmedicamento.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtcantidad.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (int.Parse(txtcantidad.Text) == 0)
            {
                MessageBox.Show("Imposible ingresar 0");
                return;
            }
            int ver=Base_de_datos.VerificarMedicamento(txtmedicamento.Text);
            if(ver!=1)
            {
                MessageBox.Show("No existe el medicamento");
                return;
            }
            txtcita.Enabled = false;
            pictureBox1.Enabled = false;
            int a;
            a=Base_de_datos.validarMed(int.Parse(txtcita.Text),int.Parse(txtmedicamento.Text));
            if(a==1)
            {
                MessageBox.Show("Medicamento ya ingresado");
                return;
            }
            Base_de_datos.validmedi(txtmedicamento.Text);
            if(int.Parse(txtcantidad.Text)>int.Parse(Base_de_datos.cant))
            {
                MessageBox.Show("No hay suficiente medicamento");
                return;
            }
            Base_de_datos.registrar_recetas(int.Parse(txtcita.Text), int.Parse(txtmedicamento.Text), int.Parse(txtcantidad.Text));
            dataGridView2.Rows.Add();

            txtnombre.Text = Nom;
            int contfilas = dataGridView2.Rows.Count - 1;

            dataGridView2[0, contfilas].Value = txtmedicamento.Text;
            dataGridView2[1, contfilas].Value = txtnombre.Text;
            dataGridView2[2, contfilas].Value = txtcantidad.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.RemoveAt(indice);
            Base_de_datos.Quitar(int.Parse(txtcita.Text), a);
            button2.Enabled = false;
        }
        int a;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int i = dataGridView2.CurrentRow.Index;
                a = int.Parse(dataGridView2[0, i].Value.ToString());
                button2.Enabled = true;
            }
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Receta_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            txtnom.Visible = false;
            lblBusqueda.Text = "Código";
           
            txtCod.Enabled = true;
            txtCod.Visible = true;
            txtnom.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtnom.Visible = true;
            lblBusqueda.Text = "Nombre";
            txtCod.Enabled = false;
            txtCod.Visible = false;
            txtCod.Clear();
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            Validar.espacio(e);
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            

            if (radioButton2.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarMedCod(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
                dataGridView1.DataSource = null;

        
        }

        private void txtnom_TextChanged_1(object sender, EventArgs e)
        {
            txtnom.Focus();
            if (radioButton1.Checked && txtnom.TextLength >= 0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarMedNom(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
                dataGridView1.DataSource = null;
        }

        private void txtcita_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtmedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Receta a = new Receta();
            a.Show();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtriesgo.Text != "Alto" && txtriesgo.Text != "Medio" && txtriesgo.Text != "Bajo")
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (txtriesgo.Text == "Alto")
            {
                riesgo = 1;
            }
            if (txtriesgo.Text == "Medio")
            {
                riesgo = 2;
            }
            if (txtriesgo.Text == "Bajo")
            {
                riesgo = 3;
            }
            Base_de_datos.Actualizar_Riesgo(riesgo, txtcita.Text);
            MessageBox.Show("Se ha guardado con exito");
            if (MessageBox.Show("Desea regresar al menu?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        int riesgo;
        private void button5_Click(object sender, EventArgs e)
        {
            if (txtriesgo.Text != "Alto" && txtriesgo.Text != "Medio" && txtriesgo.Text != "Bajo")
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (txtriesgo.Text == "Alto")
            {
                riesgo = 1;
            }
            if (txtriesgo.Text == "Medio")
            {
                riesgo = 2;
            }
            if (txtriesgo.Text == "Bajo")
            {
                riesgo = 3;
            }
            Base_de_datos.Actualizar_Riesgo(riesgo, txtcita.Text);
            Base_de_datos.cita = txtcita.Text;
            Generar_factura a = new Generar_factura();
            a.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtmedicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
