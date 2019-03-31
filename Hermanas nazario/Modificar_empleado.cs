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
    public partial class Modificar_empleado : Form
    {
        
        public Modificar_empleado()
        {
            InitializeComponent();
            txtcodigo_empleado.Text = Base_de_datos.Cod;
            txtnom1.Text = Base_de_datos.nombre1_empleado;
            txtnom2.Text = Base_de_datos.nombre2_empleado;
            txtape1.Text = Base_de_datos.apellido1_empleado;
            txtape2.Text = Base_de_datos.apellido2_empleado;
            txtid.Text = Base_de_datos.numero_identidad_empleado;
            txtcorreo.Text = Base_de_datos.correo_empleado;
            txttel.Text = Base_de_datos.numero_telefono_empleado;
            txtcargo.Text = Base_de_datos.Buscar_codigo_puesto().ToString();
            txtrol.Text = Base_de_datos.Buscar_codigo_rol().ToString();
            if (Base_de_datos.Sexo == "M")
            {
                rdm.Select();
            }

            if (Base_de_datos.Sexo == "F")
            {
                rdf.Select();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int x = 0;
            txtcodigo_empleado.Focus();
            x = Base_de_datos.Validar_Cod_empleado(txtcodigo_empleado.Text);

            if (x == 1)
            {
                txtnom1.Clear();
                txtnom2.Clear();
                txtape1.Clear();
                txtape2.Clear();
                rdf.Checked = false;
                rdm.Checked = false;
                txtid.Clear();
                txtcorreo.Clear();
                txttel.Clear();

                txtnom1.Text = Base_de_datos.nombre1_empleado;
                txtnom2.Text = Base_de_datos.nombre2_empleado;
                txtape1.Text = Base_de_datos.apellido1_empleado;
                txtape2.Text = Base_de_datos.apellido2_empleado;
                if (Base_de_datos.sexo_empleado == "M")
                {
                    rdm.Select();
                }

                if (Base_de_datos.sexo_empleado == "F")
                {
                    rdf.Select();
                }
                txtid.Text = Base_de_datos.numero_identidad_empleado;
                txtcorreo.Text = Base_de_datos.correo_empleado;
                txttel.Text = Base_de_datos.numero_telefono_empleado;
                txtcargo.Text = Base_de_datos.cargo_empleado;
                txtrol.Text = Base_de_datos.codigo_rol;
                

                
                txtnom1.Enabled = true;
                txtnom2.Enabled = true;
                txtape1.Enabled = true;
                txtape2.Enabled = true;
                groupBox1.Enabled = true;
                txtid.Enabled = true;
                txtcorreo.Enabled = true;
                txttel.Enabled = true;
                txtcargo.Enabled = true;
                button1.Enabled = true;
                txtcargo.Enabled = true;


            }

            else
            {
                MessageBox.Show("No existe codigo");

                txtcodigo_empleado.Clear();
                txtcodigo_empleado.Focus();
                txtnom1.Enabled = false;
                txtnom2.Enabled = false;
                txtape1.Enabled = false;
                txtape2.Enabled = false;
                groupBox1.Enabled = false;
                txtid.Enabled = false;
                txtcorreo.Enabled = false;
                txttel.Enabled = false;
                txtcargo.Enabled = false;
                button1.Enabled = false;
                txtcargo.Enabled = false;


                txtnom1.Clear();
                txtnom2.Clear();
                txtape1.Clear();
                txtape2.Clear();
                rdf.Checked = false;
                rdm.Checked = false;
                txtid.Clear();
                txtcorreo.Clear();
                txttel.Clear();
                txtcargo.Clear();

            }
               
            }

        private void button1_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("El campo de identidad debe tener 13 digitos");
                return;
            }
            if (!string.IsNullOrEmpty(txttel.Text) == true)
            {
                if (txttel.TextLength < 8)
                {
                    MessageBox.Show("El campo de telefono solo debe tener 8 digitos");
                    return;
                }
            }


            string sexo;

            if (rdf.Checked == true)
            {
                sexo = "F";
            }

            else
            {
                sexo = "M";
            }

            if (Base_de_datos.validarEmail(txtcorreo.Text) == false)
            {
                MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto");
                return;
            }

            Base_de_datos.Actualizar_empleado(int.Parse(txtcodigo_empleado.Text),txtnom1.Text.ToUpper(), txtnom2.Text.ToUpper(), txtape1.Text.ToUpper(), txtape2.Text.ToUpper(), txtcorreo.Text, txtid.Text, sexo.ToUpper(), txttel.Text, int.Parse(txtrol.Text), int.Parse(txtcargo.Text));
            MessageBox.Show("Empleado guardado con exito");

            txtcodigo_empleado.Clear();
            txtcodigo_empleado.Focus();
            txtnom1.Enabled = false;
            txtnom2.Enabled = false;
            txtape1.Enabled = false;
            txtape2.Enabled = false;
            groupBox1.Enabled = false;
            txtid.Enabled = false;
            txtcorreo.Enabled = false;
            txttel.Enabled = false;
            txtcargo.Enabled = false;
            button1.Enabled = false;


            txtnom1.Clear();
            txtnom2.Clear();
            txtape1.Clear();
            txtape2.Clear();
            rdf.Checked = false;
            rdm.Checked = false;
            txtid.Clear();
            txtcorreo.Clear();
            txttel.Clear();
            txtcargo.Clear();
            this.Hide();
        }


       
        private void rdm_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdf_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcodigo_empleado_TextChanged(object sender, EventArgs e)
        {
           

            if ((!string.IsNullOrEmpty(txtcodigo_empleado.Text)))

                btnbuscar.Enabled = true;
        }

        private void txtnom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtnom2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtcodigo_empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Base_de_datos.accesoci==1)
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                
            }

        }

        private void Modificar_empleado_Load(object sender, EventArgs e)
        {
            btnbuscar.PerformClick();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Base_de_datos a = new Base_de_datos();
            a.BuscarRoles();
            dataGridView1.DataSource = a.Mostrar_Resultados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtrol.Text = Convert.ToString(selectedRow.Cells[0].Value);
            dataGridView1.Visible = false;
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
            txtcargo.Text = Convert.ToString(selectedRow.Cells[0].Value);
            dataGridView2.Visible = false;
        }
    }
    }

