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
    public partial class Busqueda_ropa : Form
    {
        public Busqueda_ropa()
        {
            InitializeComponent();
            Base_de_datos busc = new Base_de_datos();
            busc.BuscarRopaNom1("");
            dataGridView1.DataSource = busc.Mostrar_Resultados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_de_datos.CodMed = lblCod.Text;
            Base_de_datos.nommedi = lblNom.Text;
            Base_de_datos.cant = lblCan.Text;
            Base_de_datos.cate = label10.Text;
            Base_de_datos.estadoE = lblDes.Text;
            Modificar_ropa a = new Modificar_ropa();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1("");
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else if (radioButton2.Checked && txtCod.TextLength == 0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1("");
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else if (radioButton2.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
                dataGridView1.DataSource = null;
            lblCan.Text = "*";
            lblNom.Text = "*";
            lblDes.Text = "*";
            lblCod.Text = "*";
            label10.Text = "*";
            btnIng.Enabled = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                lblCod.Text = Convert.ToString(selectedRow.Cells[0].Value);
                lblNom.Text = Convert.ToString(selectedRow.Cells[1].Value);
                lblCan.Text = Convert.ToString(selectedRow.Cells[2].Value);
                lblDes.Text = Convert.ToString(selectedRow.Cells[8].Value);
                label10.Text = Convert.ToString(selectedRow.Cells[7].Value);
            }
            if (radioButton2.Checked)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                lblCod.Text = Convert.ToString(selectedRow.Cells[0].Value);
                lblNom.Text = Convert.ToString(selectedRow.Cells[1].Value);
                lblCan.Text = Convert.ToString(selectedRow.Cells[2].Value);
                lblDes.Text = Convert.ToString(selectedRow.Cells[8].Value);
                label10.Text = Convert.ToString(selectedRow.Cells[7].Value);
            }



            btnIng.Enabled = true;
            
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            Base_de_datos.CodMed = lblCod.Text;
            Base_de_datos.nommedi = lblNom.Text;
            Base_de_datos.cant = lblCan.Text;
            dataGridView1.DataSource = null;
            lblCan.Text = "*";
            lblNom.Text = "*";
            lblDes.Text = "*";
            lblCod.Text = "*";
            label10.Text = "*";
            txtCod.Text = "";
            txtnom.Text = "";
            btnIng.Enabled = false;
            
            ingresoPrendaExisntente a = new ingresoPrendaExisntente();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1("");
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1(txtnom.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else if (radioButton2.Checked && txtCod.TextLength == 0)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1("");
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else if (radioButton2.Checked && txtCod.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarRopaNom1(txtCod.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
                dataGridView1.DataSource = null;
            lblCan.Text = "*";
            lblNom.Text = "*";
            lblDes.Text = "*";
            lblCod.Text = "*";
            label10.Text = "*";

            btnIng.Enabled = false;
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCod_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
}
