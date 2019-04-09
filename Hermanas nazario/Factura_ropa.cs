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
    public partial class Factura_ropa : Form
    {
        int CodigoS, a = 0;
        int Cant = 0;
        
        public Factura_ropa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            if (txtnom.Text == " ")
                txtdescripcion.Text = " ";

            if (radioSerNombre.Checked && txtnom.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }

            else
                dataGridView1.DataSource = null;


            txtdescripcion.Clear(); 
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

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtnom.Text == " ")
                txtdescripcion.Text = " ";


            if (radioSerCodigo.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaCod(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
                dataGridView1.DataSource = null;

            txtdescripcion.Clear();

        }

        private void btnFacturaNueva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                MessageBox.Show("Ingrese un numero mayor a 0");
                return;
            }
            if (!string.IsNullOrEmpty(txtdescripcion.Text) == false)

            {
                MessageBox.Show("Seleccione una prenda");
                return;
            }
            if (!string.IsNullOrEmpty(txtCantidad.Text) == false)

            {
                MessageBox.Show("Seleccione una Cantidad");
                return;
            }

            if(int.Parse(txtCantidad.Text) > Cant)
            {
                MessageBox.Show("Ingrese una cantidad existente");
                return;
            }

            bool exist = dataGridView2.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["nombre"].Value) == txtdescripcion.Text);

            if (!exist)
            {

                dataGridView2.Rows.Add(txtdescripcion.Text, txtCantidad.Text);
                btnGuardar.Enabled = true;
                

            }

            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.RemoveAt(indice);
            
            if (dataGridView2.Rows.Count == 0)
                btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea realizar el egreso", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView2.AllowUserToAddRows = false;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    Base_de_datos.Egreso_ropa_mov(Base_de_datos.Buscar_codigo_ropa(row.Cells[0].Value.ToString()), row.Cells[0].Value.ToString(), int.Parse(row.Cells[1].Value.ToString()));
                    MessageBox.Show((Base_de_datos.Buscar_cantidad_ropa(row.Cells[0].Value.ToString()).ToString()));
                    MessageBox.Show(row.Cells[1].Value.ToString());
                    MessageBox.Show((Base_de_datos.Buscar_cantidad_ropa(row.Cells[0].Value.ToString()) - int.Parse(row.Cells[1].Value.ToString())).ToString());
                    Base_de_datos.Egreso_ropa(Base_de_datos.Buscar_codigo_ropa(row.Cells[0].Value.ToString()),row.Cells[0].Value.ToString(), (Base_de_datos.Buscar_cantidad_ropa(row.Cells[0].Value.ToString()) - int.Parse(row.Cells[1].Value.ToString())), Base_de_datos.Buscar_categoria_ropa(row.Cells[0].Value.ToString())); 
                }
                dataGridView2.AllowUserToAddRows = true;
            }
            

            this.Close();
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtdescripcion.Text = Convert.ToString(selectedRow.Cells[1].Value);
            CodigoS = int.Parse((selectedRow.Cells[0].Value).ToString());
            Cant = int.Parse((selectedRow.Cells[2].Value).ToString());
            a = int.Parse((selectedRow.Cells[0].Value).ToString());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
}
