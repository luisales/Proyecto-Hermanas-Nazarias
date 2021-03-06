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
    public partial class Ingresar_Servicio : Form
    {
        public Ingresar_Servicio()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreServicio.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            if (!string.IsNullOrEmpty(txtprecio.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            if(Base_de_datos.validarServicio(txtNombreServicio.Text) == 0)
            {
                MessageBox.Show("Servicio ya existente");
                return;

            }

            

            Base_de_datos.Registro_Servicio(txtNombreServicio.Text.ToUpper(), txtDescripcion.Text.ToUpper(), txtprecio.Text.ToUpper());
            MessageBox.Show("Registrado con exito");
            this.Hide();
        }

        private void Ingresar_Servicio_Load(object sender, EventArgs e)
        {

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNombreServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreServicio_TextChanged(object sender, EventArgs e)
        {

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
