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
    public partial class Modificar_puesto : Form
    {
        public Modificar_puesto()
        {
            InitializeComponent();
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarPuesto();
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String estado;
            if (cmbestado.Text == "Activo")
            {
                estado = "ACT";
            }

            else
            {
                estado = "INC";
            }
            Base_de_datos.Actualizar_Puesto(int.Parse(txtCodigoRol.Text), txtNombreRol.Text, estado);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string est;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtCodigoRol.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtNombreRol.Text = Convert.ToString(selectedRow.Cells[1].Value);
            est = Convert.ToString(selectedRow.Cells[6].Value);
            if (est == "ACT")
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
    }
}
