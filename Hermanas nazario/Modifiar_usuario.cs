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
    }
}
