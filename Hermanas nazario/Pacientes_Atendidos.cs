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
    public partial class Pacientes_Atendidos : Form
    {
        public Pacientes_Atendidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_de_datos.fecha1Pa = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            Base_de_datos.fecha2Pa = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            Base_de_datos.paca = 1;
            this.Hide();
            menu a = new menu();
            a.Show();
        }
    }
}
