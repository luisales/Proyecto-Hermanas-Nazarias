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
    public partial class Mostrar_Diagnostico : Form
    {
        public Mostrar_Diagnostico()
        {
            InitializeComponent();
            richTextBox1.Text = Base_de_datos.diagnostico;
            richTextBox2.Text = Base_de_datos.tratamiento;
            label3.Text = Base_de_datos.nombre_cita;
        }

        private void Mostrar_Diagnostico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
}
