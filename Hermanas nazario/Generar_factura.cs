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
    public partial class Generar_factura : Form
    {
        float TotalFinal;
        float total;
        float descuento;

        public Generar_factura()
        {
            InitializeComponent();
            txtCita.Text = Base_de_datos.cita;
            Base_de_datos.decis = 2;
        }

        private void chkIngresar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIngresar.Checked)
            {
                txtIngresar.Enabled = true;
              
            }

            else
            {
                txtIngresar.Enabled = false;
                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Base_de_datos.cita = "";
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCita.Text) == false)
            {
                MessageBox.Show("Ingrese el numero de cita");
                return;
            }

            Base_de_datos most = new Base_de_datos();
            
            if (most.BuscarReceta(txtCita.Text) == 0)
            {
                txtValorC.Enabled = false;
                btnPagar.Enabled = false;
                chkIngresar.Enabled = false;
                dataGridView1.DataSource = null;
                btnCancelar.Enabled = false;
             
                btnBuscar.Enabled = true;


            }
            else
            {

                
                most.BuscarReceta(txtCita.Text);
                dataGridView1.DataSource = most.Mostrar_Resultados();
                Base_de_datos.porcentaje_riesgo(txtCita.Text);
               


                total = Base_de_datos.total_medicamentos(txtCita.Text);
                descuento = total * (Base_de_datos.porcentaje_riesgo(txtCita.Text) / 100);

                txtSubTotal.Text = descuento.ToString();

                TotalFinal =  descuento;
                txtTotal.Text = TotalFinal.ToString();

                txtValorC.Enabled = true;
                btnPagar.Enabled = true;
                chkIngresar.Enabled = true;

                btnCancelar.Enabled = true;
            
                btnBuscar.Enabled = false;


            }


            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorC.Text) == false)
            {
                MessageBox.Show("Ingrease el valor de la consulta");
                return;
            }

            if (!string.IsNullOrEmpty(txtValorC.Text) == false)
            {
                MessageBox.Show("Ingrease el valor de la consulta");
                return;
            }

            if (!string.IsNullOrEmpty(txtIngresar.Text) == false)
            {
                MessageBox.Show("Ingrese el valor a pagar");
                return;
            }

            if(chkIngresar.Checked)
            {
                if (MessageBox.Show("Esta seguro desea ingresar la factura","Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Base_de_datos.Ingresar_factura(double.Parse(txtValorC.Text), double.Parse(txtIngresar.Text), int.Parse(txtCita.Text));
                    Base_de_datos most = new Base_de_datos();
                    DataTable a;
                    int i = 0;
                    int bb = Base_de_datos.numero;
                    most.BuscarReceta(txtCita.Text);
                    a = most.Mostrar_Resultados();
                    do
                    {
                        DataRow row = a.Rows[i];
                        Base_de_datos.validmedi(row["Codigo Medicamento"].ToString());
                      
                        Base_de_datos.vencemedi(int.Parse(row["Codigo Medicamento"].ToString()), int.Parse(Base_de_datos.cant) - int.Parse(row["Cantidad"].ToString()));
                     
                        i++;
                    }
                    while (i < bb);



                    txtValorC.Enabled = false;
                    btnPagar.Enabled = false;
                    chkIngresar.Enabled = false;
                    btnBuscar.Enabled = true;
                    txtIngresar.Enabled = false;
                    chkIngresar.Checked = false;
                    btnCancelar.Enabled = false;
                    dataGridView1.DataSource = null;
                    
                    txtTotal.Text = "0";
                    txtIngresar.Text = "0";
                    txtCita.Text = "";
                    txtCita.Focus();
                    txtValorC.Text = "";
                    Base_de_datos.cita = "";
                }
            }
            else
            {
                if (MessageBox.Show("Esta seguro desea ingresar la factura","Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Base_de_datos.Ingresar_factura(double.Parse(txtValorC.Text), double.Parse(txtTotal.Text), int.Parse(txtCita.Text));
                    Base_de_datos most = new Base_de_datos();
                    DataTable a;
                    int i = 0;
                    int bb = Base_de_datos.numero;
                    most.BuscarReceta(txtCita.Text);
                    a = most.Mostrar_Resultados();
                    do
                    {
                        DataRow row = a.Rows[i];
                        Base_de_datos.validmedi(row["Codigo Medicamento"].ToString());
                      
                        Base_de_datos.vencemedi(int.Parse(row["Codigo Medicamento"].ToString()), int.Parse(Base_de_datos.cant) - int.Parse(row["Cantidad"].ToString()));
                       
                        i++;
                    }
                    while (i < bb);



                    txtValorC.Enabled = false;
                    btnPagar.Enabled = false;
                    chkIngresar.Enabled = false;
                    btnBuscar.Enabled = true;
                    txtIngresar.Enabled = false;
                    chkIngresar.Checked = false;
                    btnCancelar.Enabled = false;
                    dataGridView1.DataSource = null;
                    

                    txtTotal.Text = "0";
                    txtIngresar.Text = "0";
                    txtCita.Text = "";
                    txtCita.Focus();
                    txtValorC.Text = "";
                    Base_de_datos.cita = "";
                }
            }
          


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtValorC.Enabled = false;
            btnPagar.Enabled = false;
            chkIngresar.Enabled = false;
            btnBuscar.Enabled = true;
            txtIngresar.Enabled = false;
            btnCancelar.Enabled = false;
            chkIngresar.Checked = false;
            txtSubTotal.Text = "0";
            
            dataGridView1.DataSource = null;

            txtSubTotal.Text = "0";
            txtTotal.Text = "0";
            txtIngresar.Text = "0";
            txtValorC.Text = "0";
            txtCita.Text = "";
            txtCita.Focus();
        }

        private void txtIngresar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtValorC_TextChanged(object sender, EventArgs e)
        {
            

            if (btnPagar.Enabled == true)
            {
                if (txtValorC.TextLength >= 1)
                { 
                    txtConsulta.Text = txtValorC.Text;
                txtSubTotal.Text = descuento.ToString();
        
                    txtTotal.Text = (TotalFinal + int.Parse(txtValorC.Text)).ToString();
                }
                if (txtValorC.TextLength == 0)
                { 
                    txtConsulta.Text = "0";
                 txtSubTotal.Text = descuento.ToString();
                txtTotal.Text = (TotalFinal + 0).ToString();
                }
            }
        }

        private void txtIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtCita_TextChanged(object sender, EventArgs e)
        {
            if (btnPagar.Enabled==true)
            {
                txtValorC.Enabled = false;
                btnPagar.Enabled = false;
                chkIngresar.Enabled = false;
                btnBuscar.Enabled = true;
                txtIngresar.Enabled = false;
                btnCancelar.Enabled = false;
                chkIngresar.Checked = false;
                dataGridView1.DataSource = null;
                txtTotal.Text = "0";
                txtIngresar.Text = "0";
                txtValorC.Text = "0";
                txtCita.Text = "";
                txtCita.Focus();
            }
            
        }

        private void Generar_factura_Load(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_citas a = new Busqueda_citas();
            a.Show();
        }
    }
}
