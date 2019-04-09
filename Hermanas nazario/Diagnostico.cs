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
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
            label3.Text = Base_de_datos.nombre_cita;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(richTextBox2.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            Base_de_datos.Actualizar_cita(int.Parse(Base_de_datos.cita), richTextBox1.Text, richTextBox2.Text);
            MessageBox.Show("Guardado con exito");
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            button2.Enabled = true;
        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receta a = new Receta();
            a.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
