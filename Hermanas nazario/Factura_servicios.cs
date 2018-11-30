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
    public partial class Factura_servicios : Form
    {
        int CodigoS, a;
        public Factura_servicios()
        {
            InitializeComponent();
        }

        private void txtCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

            if (radioSerNombre.Checked && txtnom.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarSerNom(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }

            else if (radioSerCodigo.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarSerCod(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
                dataGridView1.DataSource = null;
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
           if (radioSerNombre.Checked && txtnom.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarSerNom(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }

            else if (radioSerCodigo.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarSerCod(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else

                dataGridView1.DataSource = null;
        }

       

        private void radioSerNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtnom.Visible = true;
            label1.Text = "Nombre";
            txtCod.Enabled = false;
            txtCod.Visible = false;
            txtCod.Clear();
        }

        private void radioSerCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            txtnom.Visible = false;
            label1.Text = "Código";
            txtCod.Enabled = true;
            txtCod.Visible = true;
            txtnom.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdescripcion.Text) == false)

            {
                MessageBox.Show("Seleccione un Servicio");
                return;
            }
            if (!string.IsNullOrEmpty(txtCantidad.Text) == false)

            {
                MessageBox.Show("Seleccione una Cantidad");
                return;
            }
            if (Base_de_datos.ValidarFacturaDetalle(lblCodigoFacturaSer.Text)== 1)
            {
                Base_de_datos.Detalle_Servicio(int.Parse(lblCodigoFacturaSer.Text), CodigoS, int.Parse(txtCantidad.Text));
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarDetalle(lblCodigoFacturaSer.Text);
                dataGridView2.DataSource = busc.Mostrar_Resultados();
            }
            else
            MessageBox.Show("Servicio ya Ingresado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Anio, Mes, Dia;
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            DateTime actual = DateTime.Now;
            Anio = DateTime.Parse(actual.ToString()).Year.ToString();
            Mes = DateTime.Parse(actual.ToString()).Month.ToString();
            Dia = DateTime.Parse(actual.ToString()).Day.ToString();
            lblCodigoFacturaSer.Text=Base_de_datos.Factura_Servicios(Anio+"-"+Mes+"-"+Dia).ToString();
            lblFecha.Text = (Anio + "-" + Mes + "-" + Dia);
            btnFacturaNueva.Enabled = false;
           
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtdescripcion.Text = Convert.ToString(selectedRow.Cells[1].Value);
             CodigoS = int.Parse((selectedRow.Cells[0].Value).ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                a = int.Parse((selectedRow.Cells[1].Value).ToString());
                btnQuitar.Enabled = true;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea cancelar la factura", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Base_de_datos.Cancelar_Factura(int.Parse(lblCodigoFacturaSer.Text));
                btnCancelar.Enabled = false;
                lblCodigoFacturaSer.Text = "*";
                lblFecha.Text = "*";
                btnFacturaNueva.Enabled = true;
                btnAgregar.Enabled = false;
                dataGridView2.DataSource = null;
                txtCantidad.Clear();
                txtdescripcion.Clear();
                txtCod.Clear();
                txtnom.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea ingresar la factura", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea cancelar la factura", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Base_de_datos.Cancelar_Factura(int.Parse(lblCodigoFacturaSer.Text));
                btnCancelar.Enabled = false;
                lblCodigoFacturaSer.Text = "*";
                lblFecha.Text = "*";
                btnFacturaNueva.Enabled = true;
                btnAgregar.Enabled = false;
                dataGridView2.DataSource = null;
                txtCantidad.Clear();
                txtdescripcion.Clear();
                txtCod.Clear();
                txtnom.Clear();
                this.Hide();
                menu a = new menu();
                a.Show();
            }
           
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.RemoveAt(indice);
            Base_de_datos.Quitar_Detalle(int.Parse(lblCodigoFacturaSer.Text), a);
            btnQuitar.Enabled = false;
        }
        
      
    }
    
}
