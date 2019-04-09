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
    public partial class Busqueda_factura : Form
    {
        public Busqueda_factura()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvcitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtcodigo.TextLength >= 1)
                Base_de_datos.busqueda_factura(int.Parse(txtcodigo.Text), dgvcitas);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
