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
    public partial class Recuperar_contrasenia : Form
    {
        public Recuperar_contrasenia()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            int b;
            string prof;
            prof = Encriptar.EncriptarContra(txtprof.Text.ToUpper());
            Restablecimiento a = new Restablecimiento();
            b = Base_de_datos.Recuperar(txtusuario.Text,prof);
            Base_de_datos.contra=txtusuario.Text;
            if(b==1)
            {
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("No encontrado");
                return;
            }

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }
    }
}
