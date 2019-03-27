using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Hermanas_nazario
{
    public partial class ModifcacionPaciente : Form
    {
        public ModifcacionPaciente()
        {
            InitializeComponent();
            txtExpediente.Text = Base_de_datos.Cod;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int x = 0;
            x = Base_de_datos.ValidarExp(txtExpediente.Text);

            if (x == 1)
            {

                txtnom1.Clear();
                txtnom2.Clear();
                txtape1.Clear();
                txtape2.Clear();
                rdf.Checked = false;
                rdm.Checked = false;
                txtid.Clear();
                txtlugar.Clear();
                txtmadre.Clear();
                txtpadre.Clear();
                txtOcupacion.Clear();
                txtDireccion.Clear();
                txttel.Clear();
                txtTelEmer.Clear();
                txtLugarTrabajo.Clear();
               

                txtnom1.Text = Base_de_datos.Nombre1;
                txtnom2.Text = Base_de_datos.Nombre2;
                txtape1.Text = Base_de_datos.Apellido1;
                txtape2.Text = Base_de_datos.Apellid2;
                txtid.Text = Base_de_datos.Identidad;
                txtlugar.Text = Base_de_datos.Lugar;
                txtmadre.Text = Base_de_datos.NombreM;
                txtpadre.Text = Base_de_datos.NombreP;
                txtdia.Text = Base_de_datos.dia;
                txtmes.Text = Base_de_datos.mes;
                txtanio.Text = Base_de_datos.anio;
                txtOcupacion.Text = Base_de_datos.Ocupacion;
                txtLugarTrabajo.Text = Base_de_datos.LugarT;
                txtDireccion.Text = Base_de_datos.Direccion;
                txttel.Text = Base_de_datos.tel;
                txtTelEmer.Text = Base_de_datos.telE;
                

                if (Base_de_datos.Sexo == "M")
                {
                    rdm.Select();
                }

                if (Base_de_datos.Sexo == "F")
                {
                    rdf.Select();
                }


                if (int.Parse(Base_de_datos.Riesgo) == 1)
                {
                    txtriesgo.Text = "Alto";
                }
                if (int.Parse(Base_de_datos.Riesgo) == 2)
                {
                    txtriesgo.Text = "Medio";
                }
                if (int.Parse(Base_de_datos.Riesgo) == 3)
                {
                    txtriesgo.Text = "Bajo";
                }

                txtnom1.Enabled = true;
                txtnom2.Enabled = true;
                txtape1.Enabled = true;
                txtape2.Enabled = true;
                groupBox1.Enabled = true;
                txtid.Enabled = true;
                txtlugar.Enabled = true;
                txtdia.Enabled = true;
                txtmes.Enabled = true;
                txtanio.Enabled = true;
                txtmadre.Enabled = true;
                txtpadre.Enabled = true;
                txtriesgo.Enabled = true;
                txtOcupacion.Enabled = true;
                txtDireccion.Enabled = true;
                txttel.Enabled = true;
                txtTelEmer.Enabled = true;
                txtlugar.Enabled = true;
                btnModificar.Enabled = true;
                txtLugarTrabajo.Enabled = true;
            }

            else
            {
                MessageBox.Show("No existe expediente");

                txtExpediente.Clear();
                txtExpediente.Focus();
                txtnom1.Enabled = false;
                txtnom2.Enabled = false;
                txtape1.Enabled = false;
                txtape2.Enabled = false;
                groupBox1.Enabled = false;
                txtid.Enabled = false;
                txtlugar.Enabled = false;
                txtdia.Enabled = false;
                txtmes.Enabled = false;
                txtanio.Enabled = false;
                txtmadre.Enabled = false;
                txtpadre.Enabled = false;
                txtriesgo.Enabled = false;
                txtOcupacion.Enabled = false;
                txtDireccion.Enabled = false;
                txttel.Enabled = false;
                txtTelEmer.Enabled = false;
                txtlugar.Enabled = false;
                btnModificar.Enabled = false;
                txtLugarTrabajo.Enabled = false;

                txtnom1.Clear();
                txtnom2.Clear();
                txtape1.Clear();
                txtape2.Clear();
                rdf.Checked = false;
                rdm.Checked = false;
                txtid.Clear();
                txtlugar.Clear();
                txtmadre.Clear();
                txtpadre.Clear();
                txtOcupacion.Clear();
                txtDireccion.Clear();
                txttel.Clear();
                txtTelEmer.Clear();
                txtlugar.Clear();
                txtLugarTrabajo.Clear();
               
            }
              
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
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
            
            if (rdf.Checked == false && rdm.Checked == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtid.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (txtid.TextLength < 13)
            {
                MessageBox.Show("El campo de de identidad debe ser de 13 digitos");
                return;
            }
            if (txtriesgo.Text != "Alto" && txtriesgo.Text != "Medio" && txtriesgo.Text != "Bajo")
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
            if ((int.Parse(txtanio.Text)) < 1900 || (int.Parse(txtanio.Text)) > 2018)
            {
                MessageBox.Show("El año tiene que ser 1900-2018 ");
                return;
            }

            int b = Base_de_datos.validarIDp2(txtid.Text, txtExpediente.Text);
            if (b == 0)
            {
                MessageBox.Show("Identidad ya existente");
                return;
            }
            DateTime fech = DateTime.Now;

            if ((int.Parse(txtanio.Text)) < 1900 || (int.Parse(txtanio.Text)) > int.Parse(fech.Year.ToString()))
            {
                MessageBox.Show("El año tiene que ser 1900-" + fech.Year.ToString());
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

            Base_de_datos.Actualizar_P(int.Parse(txtExpediente.Text), txtnom1.Text.ToUpper(), txtnom2.Text.ToUpper(), txtape1.Text.ToUpper(), txtape2.Text.ToUpper(), txtlugar.Text, txtdia.Text + "/" + txtmes.Text + "/" + txtanio.Text, txtpadre.Text, txtmadre.Text, txtid.Text, sexo, riesgo, txtOcupacion.Text.ToUpper(), txtLugarTrabajo.Text.ToUpper(), txtDireccion.Text.ToUpper(), txttel.Text.ToUpper(), txtTelEmer.Text.ToUpper());

            MessageBox.Show("Expediente modificado.");

            txtnom1.Enabled = false;
            txtnom2.Enabled = false;
            txtape1.Enabled = false;
            txtape2.Enabled = false;
            groupBox1.Enabled = false;
            txtid.Enabled = false;
            txtlugar.Enabled = false;
            txtdia.Enabled = false;
            txtmes.Enabled = false;
            txtanio.Enabled = false;
            txtmadre.Enabled = false;
            txtpadre.Enabled = false;
            txtriesgo.Enabled = false;
            txtOcupacion.Enabled = false;
            txtDireccion.Enabled = false;
            txttel.Enabled = false;
            txtTelEmer.Enabled = false;
            txtlugar.Enabled = false;
            txtLugarTrabajo.Enabled = false;

            btnModificar.Enabled = false;

            txtnom1.Clear();
            txtnom2.Clear();
            txtape1.Clear();
            txtape2.Clear();
            txtid.Clear();
            txtlugar.Clear();
            txtdia.Clear();
            txtmes.Clear();
            txtanio.Clear();
            txtmadre.Clear();
            txtpadre.Clear();
            txtOcupacion.Clear();
            txtDireccion.Clear();
            txttel.Clear();
            txtTelEmer.Clear();
            txtlugar.Clear();
            txtLugarTrabajo.Clear();
            




        }

        private void txtnom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            
        }



        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        private void txtnom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            
        }

        private void txtape1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            

        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
            
        }

        private void txtmadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);

        }

        private void txtpadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Base_de_datos.accesoci==1)
            {
                this.Hide();
                Base_de_datos.Cod = "";
                Busqueda_de_pacientes b = new Busqueda_de_pacientes();
                b.Show();
            }
            else
            {
                this.Hide();
                Base_de_datos.Cod = "";
                menu a = new menu();
                a.Show();
            }

        }

        private void txtdia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        private void txtmes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
           
        }

        private void txtanio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        string sexo;
        private void rdm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdm.Checked)
            {
                sexo = "M";
            }
        }

        private void rdf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdf.Checked)
            {
                sexo = "F";
            }
        }

        int riesgo = 0;
        private void txtriesgo_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void txtExpediente_Click(object sender, EventArgs e)
        {
           
        }

        private void txtExpediente_TextChanged(object sender, EventArgs e)
        {
            

            
                btnBuscar.Enabled = false;
                txtnom1.Enabled = false;
                txtnom2.Enabled = false;
                txtape1.Enabled = false;
                txtape2.Enabled = false;
                groupBox1.Enabled = false;
                txtid.Enabled = false;
                txtlugar.Enabled = false;
                txtdia.Enabled = false;
                txtmes.Enabled = false;
                txtanio.Enabled = false;
                txtmadre.Enabled = false;
                txtpadre.Enabled = false;
                txtriesgo.Enabled = false;
                txtOcupacion.Enabled = false;
                txtDireccion.Enabled = false;
                txttel.Enabled = false;
                txtTelEmer.Enabled = false;
                txtlugar.Enabled = false;
                txtLugarTrabajo.Enabled = false;

            btnModificar.Enabled = false;

                txtnom1.Clear();
                txtnom2.Clear();
                txtape1.Clear();
                txtape2.Clear();
                txtid.Clear();
                txtlugar.Clear();
                txtdia.Clear();
                txtmes.Clear();
                txtanio.Clear();
                txtmadre.Clear();
                txtpadre.Clear();
                txtOcupacion.Clear();
                txtDireccion.Clear();
                txttel.Clear();
                txtTelEmer.Clear();
                txtlugar.Clear();
                txtLugarTrabajo.Clear();
      

            if ((!string.IsNullOrEmpty(txtExpediente.Text)))

                btnBuscar.Enabled = true;
           
                
        }

        private void txtExpediente_CursorChanged(object sender, EventArgs e)
        {
        }

        private void ModifcacionPaciente_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
           
        }

        private void txtTelEmer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txtnom2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
