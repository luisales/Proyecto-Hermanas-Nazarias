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
    public partial class Modifiar_usuario : Form
    {
       
        public Modifiar_usuario()
        {
           
            InitializeComponent();
        }

        private void Modifiar_usuario_Load(object sender, EventArgs e)
        {

            Base_de_datos busc = new Base_de_datos();
            busc.BuscarUsuario();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigoUsuario.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreUsuario.Text = Convert.ToString(selectedRow.Cells[1].Value);
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            int ver = Base_de_datos.validarNomUsuario(txtNombreUsuario.Text, txtCodigoUsuario.Text);
            if (ver != 1)
            {
                MessageBox.Show("Usuario ya existente");
                return;
            }

            Base_de_datos.Actualizar_usuario(int.Parse(txtCodigoUsuario.Text), txtNombreUsuario.Text);

            MessageBox.Show("Usuario modificado.");

            Base_de_datos busc = new Base_de_datos();
            busc.BuscarUsuario();
            dataGridView1.DataSource = busc.Mostrar_Resultados();

            txtCodigoUsuario.Clear();
            txtNombreUsuario.Clear();
            btnModificar.Enabled = false;



        }

        private void txtCodigoUsuario_TextChanged(object sender, EventArgs e)
        {
            txtNombreUsuario.Enabled = false;
      
            btnModificar.Enabled = false;

            if ((!string.IsNullOrEmpty(txtCodigoUsuario.Text)))
            {
                txtNombreUsuario.Enabled = true;
                
                btnModificar.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkIngresar_CheckedChanged(object sender, EventArgs e)
        {
           
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
                    }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
