﻿using System;
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
    public partial class Registro_empleado : Form
    {
        public Registro_empleado()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
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
            if (txtid.Text == "    -    -     /")
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtcargo.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtrol.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (txtid.TextLength<13)
            {
                MessageBox.Show("El campo de identidad debe tener 13 digitos");
                return;
            }
            if (txtid.Text.Contains(' ') == true)
            {
                MessageBox.Show("El campo de identidad debe ser de 13 digitos");
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
            
            int b = Base_de_datos.validarIDe(txtid.Text);
            if (b == 0)
            {
                MessageBox.Show("Identidad ya existente");
                return;
            }
            if (!string.IsNullOrEmpty(txtcorreo.Text) == true)
            {
                if (Base_de_datos.validarEmail(txtcorreo.Text) == false)
                {
                    MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto");
                    return;
                }
            }
            

            Base_de_datos.registrar_empleado(txtnom1.Text.ToUpper(), txtnom2.Text.ToUpper(), txtape1.Text.ToUpper(), txtape2.Text.ToUpper(), txtcorreo.Text, txtid.Text, sexo, txttel.Text,txtcargo.Text.ToUpper(), int.Parse(txtrol.Text));
            this.Close();
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

        private void txtnom1_TextChanged(object sender, EventArgs e)
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

        private void txtape1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void Registro_empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void Registro_empleado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            Base_de_datos a = new Base_de_datos();
            a.BuscarPuesto();
            dataGridView2.DataSource = a.Mostrar_Resultados();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
            txtcargo.Text = Convert.ToString(selectedRow.Cells[0].Value);
            dataGridView2.Visible = false;
        }

        private void txtid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txtid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
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
