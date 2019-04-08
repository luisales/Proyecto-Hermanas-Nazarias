using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;


namespace Hermanas_nazario
{
    public partial class Registro_pacientes : Form
    {

        public Registro_pacientes()
        {

            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string sexo;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdm.Checked)
            {
                sexo = "M";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtnom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            

        }

        private void txtnom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);

        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtmadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras1(e);
        }

        private void txtpadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras1(e);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now; 

            if (!string.IsNullOrEmpty(txtnom1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtape1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtlugar.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtdia.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtmes.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtanio.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (rdf.Checked == false && rdm.Checked == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (txtid.Text == "    -    -")
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (txtid.TextLength < 13)
            {
                MessageBox.Show("El campo de identidad debe ser de 13 digitos");
                return;
            }

            if (int.Parse(txtmes.Text) == 2 && int.Parse(txtdia.Text) > 29)
            {
                MessageBox.Show("Fecha invalida: no existe el dia");
                return;
            }
            if ((int.Parse(txtmes.Text) == 4 && int.Parse(txtdia.Text) > 30) || (int.Parse(txtmes.Text) == 6 && int.Parse(txtdia.Text) > 30) || (int.Parse(txtmes.Text) == 9 && int.Parse(txtdia.Text) > 30) || (int.Parse(txtmes.Text) == 11 && int.Parse(txtdia.Text) > 30))
            {
                MessageBox.Show("Fecha invalida: no existe el dia");
                return;
            }
            if ((int.Parse(txtdia.Text)) <= 0 || (int.Parse(txtdia.Text)) > 31)
            {
                MessageBox.Show("El dia tiene que ser 1-31");
                return;
            }
            if ((int.Parse(txtmes.Text)) <= 0 || (int.Parse(txtmes.Text)) > 12)
            {
                MessageBox.Show("El mes tiene que ser 1-12");
                return;
            }
            DateTime fech = DateTime.Now;

            if ((hoy.Year - (int.Parse(txtanio.Text)) > 100) || (int.Parse(txtanio.Text)) > int.Parse(fech.Year.ToString()))
            {
                MessageBox.Show("El año tiene que ser "+(hoy.Year - 100) +"-" + fech.Year.ToString());
                return;
            }
            DateTime actual = DateTime.Now;
            DateTime compar = Convert.ToDateTime((txtdia.Text + "/" + txtmes.Text + "/" + txtanio.Text).Trim(), new CultureInfo("en-GB"));

            if (compar > actual)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual");
                return;
            }
            if (txttel.TextLength < 8 && (!string.IsNullOrEmpty(txttel.Text) == true))
            {
                MessageBox.Show("El campo de telefono debe ser de 8 digitos");
                return;
            }
            if (txtTelEmer.TextLength < 8 && (!string.IsNullOrEmpty(txtTelEmer.Text) == true))
            {
                MessageBox.Show("El campo de telefono de emergencia debe ser de 8 digitos");
                return;
            }

            int b = Base_de_datos.validarIDp(txtid.Text);
            if(b==0)
            {
                MessageBox.Show("Identidad ya existente");
                return;
            }

            Base_de_datos.Registro(txtnom1.Text.ToUpper(), txtnom2.Text.ToUpper(), txtape1.Text.ToUpper(), txtape2.Text.ToUpper(), txtlugar.Text, txtmes.Text + "/"+ txtdia.Text + "/"+txtanio.Text, txtpadre.Text, txtmadre.Text, txtid.Text, sexo, 3, txtOcupacion.Text.ToUpper(), txtLugarTrabajo.Text.ToUpper(),txtDireccion.Text.ToUpper(), txttel.Text.ToUpper(), txtTelEmer.Text.ToUpper());

            Base_de_datos.expediente(txtid.Text);
            this.Close();



        }

       
        private void txtriesgo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtnom1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdf.Checked)
            {
                sexo = "F";
            }
        }

        private void txtlugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtTelEmer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtape1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtOcupacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtlugar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmadre_TextChanged(object sender, EventArgs e)
        {
            string c;
            c = txtmadre.Text;
            if (c.StartsWith(" "))
            {
                MessageBox.Show("No se puede ingresar con espacio");
                txtmadre.Text = "";
                return;
            }
        }

        private void txtpadre_TextChanged(object sender, EventArgs e)
        {
            string c;
            c = txtpadre.Text;
            if (c.StartsWith(" "))
            {
                MessageBox.Show("No se puede ingresar con espacio");
                txtpadre.Text = "";
                return;
            }
        }

        private void txtid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
