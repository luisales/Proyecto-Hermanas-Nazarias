﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hermanas_nazario
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_pacientes a = new Registro_pacientes();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void burcarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_de_pacientes a = new Busqueda_de_pacientes();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifcacionPaciente a = new ModifcacionPaciente();
            a.Show();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buscarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Base_de_datos.decis = 3;
            Busqueda_citas a = new Busqueda_citas();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void registrarIngresoDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_medicamento a = new Ingresar_medicamento();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void generarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receta a = new Receta();
            a.Show();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void buscarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_medicamentos a = new Busqueda_medicamentos();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void registrarEgresoDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            venc x = new venc();
            x.Show();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void generarFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Generar_factura a = new Generar_factura();
            a.Show();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void referenciaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Referencia a = new Referencia();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_factura a = new Busqueda_factura();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }
        private void medicamentosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Base_de_datos.b==0)
            {
                Base_de_datos.esta();
                chart1.Series[0].Points.DataBindXY(Base_de_datos.nombremedicamento, Base_de_datos.cantidadmedicamento);
                pictureBox1.Visible = true;
                chart1.Visible = true;
                label1.Visible = true;
                Base_de_datos.b = 1;
            }
            else
            {
                chart1.Series[0].Points.DataBindXY(Base_de_datos.nombremedicamento, Base_de_datos.cantidadmedicamento);
                chart1.Visible = true;
                pictureBox1.Visible = true;
                label1.Visible = true;
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void agregarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_roles a = new Registro_roles();
            a.ShowDialog();
        }

        private void modifcarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificacion_roles a = new Modificacion_roles();
            a.ShowDialog();
        }

        private void ingresarMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_medida a = new Ingresar_medida();
            a.ShowDialog();
        }

        private void modifcarMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificacion_medida a = new Modificacion_medida();
            a.ShowDialog();
        }

        private void generarRecetaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Receta a = new Receta();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            this.Hide();
            Modificar_empleado a = new Modificar_empleado();
            a.Show();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            chart1.Visible = false;
            label1.Visible = false;

        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_empleado a = new Registro_empleado();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void semanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            chart2.Visible = false;
            label1.Visible = false;
        }

        private void pacientesAtendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes_Atendidos a = new Pacientes_Atendidos();
            a.ShowDialog();
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();

        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_empleados a = new Busqueda_empleados();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void generarFacturaDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Factura_servicios a = new Factura_servicios();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_Servicio a = new Ingresar_Servicio();
            a.ShowDialog();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_servcios a = new Modificar_servcios();
            a.ShowDialog();

        }

        private void ingresarNivelEconomicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Nivel a = new Registro_Nivel();
            a.ShowDialog();
        }

        private void modificarNivelEconomicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Nivel a = new Modificar_Nivel();
            a.ShowDialog();
        }

        private void ingresarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_Servicio a = new Ingresar_Servicio();
            a.ShowDialog();
        }

        private void modificarsSerivicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_servcios a = new Modificar_servcios();
            a.ShowDialog();
        }

        private void registrarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Registro_de_usuario a = new Registro_de_usuario();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifiar_usuario a = new Modifiar_usuario();
            a.ShowDialog();

        }

        private void modificarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifcar_medicamento a = new Modifcar_medicamento();
            a.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\ModuloAyuda\index.html";
            proceso.Start();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
