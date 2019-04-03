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
    public partial class Modificar_ropa : Form
    {
        public Modificar_ropa()
        {

            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarCategoriaNom("");
            dataGridView1.DataSource = busc.Mostrar_Resultados();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                txtUnidad.Items.Add(row.Cells[1].Value.ToString());

            }

            txtcod.Text = Base_de_datos.CodMed;
            txtnom.Text = Base_de_datos.nommedi;
            txtUnidad.Text = Base_de_datos.cate;
            if (Base_de_datos.estadoE == "ACT")
            {
                cmbestado.Text = "Activo";
            }
            else
            {
                cmbestado.Text = "Inactivo";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnom.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtUnidad.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            int ver = Base_de_datos.validarRopaMod(txtnom.Text, txtcod.Text);
            if (ver != 1)
            {
                MessageBox.Show("Prenda ya existente");
                return;
            }
            String estado;
            if (cmbestado.Text == "Activo")
            {
                estado = "ACT";
            }

            else
            {
                estado = "INC";
            }

            Base_de_datos.actualizar_ropa(int.Parse(txtcod.Text), txtnom.Text, int.Parse(Base_de_datos.cant), txtUnidad.SelectedItem.ToString(), estado);
            MessageBox.Show("Prenda modificada.");
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
