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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            Base_de_datos.BuscarPermisos(Base_de_datos.rol.ToString());

            if (Base_de_datos.Permisos.Contains("A"))
            {
                pacientesToolStripMenuItem.Enabled = true;
            }
            else
                pacientesToolStripMenuItem.Enabled = false;

            if (Base_de_datos.Permisos.Contains("B"))
            {
                registarEmpleadoToolStripMenuItem.Enabled = true;
            }
            else
                registarEmpleadoToolStripMenuItem.Enabled = false;

            if (Base_de_datos.Permisos.Contains("C"))
            {
                registrarUsuarioToolStripMenuItem.Enabled = true;
            }
            else
                registrarUsuarioToolStripMenuItem.Enabled = false;

            if (Base_de_datos.Permisos.Contains("D"))
            {
                facturacionToolStripMenuItem.Enabled = true;
            }
            else
                facturacionToolStripMenuItem.Enabled = false;

            if (Base_de_datos.Permisos.Contains("E"))
            {
                inventarioToolStripMenuItem.Enabled = true;
            }
            else
                inventarioToolStripMenuItem.Enabled = false;

            if (Base_de_datos.Permisos.Contains("F"))
            {
                documentosMedicosToolStripMenuItem.Enabled = true;
            }
            else
                documentosMedicosToolStripMenuItem.Enabled = false;


            if (Base_de_datos.Permisos.Contains("G"))
            {
                mantenimientosToolStripMenuItem.Enabled = true;
            }
            else
                mantenimientosToolStripMenuItem.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_pacientes a = new Registro_pacientes();
            a.Show();
        }

        private void burcarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_de_pacientes a = new Busqueda_de_pacientes();
            a.Show();
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifcacionPaciente a = new ModifcacionPaciente();
            a.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_usuario a = new Registro_de_usuario();
            a.Show();
        }

        private void registarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_empleado a = new Registro_empleado();
            a.Show();
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buscarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Base_de_datos.decis = 3;
            this.Hide();
            Busqueda_citas a = new Busqueda_citas();
            a.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login();
            a.Show();
        }

        private void registrarIngresoDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_medicamento a = new Ingresar_medicamento();
            a.Show();
        }

        private void generarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receta a = new Receta();
            a.Show();
        }

        private void buscarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_medicamentos a = new Busqueda_medicamentos();
            a.Show();
        }

        private void registrarEgresoDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            venc x = new venc();
            x.Show();
        }

        private void generarFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Generar_factura a = new Generar_factura();
            a.Show();
        }

        private void referenciaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Referencia a = new Referencia();
            a.Show();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_factura a = new Busqueda_factura();
            a.Show();
        }
        private void medicamentosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Base_de_datos.b==0)
            {
                Base_de_datos.esta();
                chart1.Series[0].Points.DataBindXY(Base_de_datos.nombremedicamento, Base_de_datos.cantidadmedicamento);
                chart1.Visible = true;
                Base_de_datos.b = 1;
            }
            else
            {
                chart1.Series[0].Points.DataBindXY(Base_de_datos.nombremedicamento, Base_de_datos.cantidadmedicamento);
                chart1.Visible = true;

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
            this.Hide();
            Receta a = new Receta();
            a.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            this.Hide();
            Modificar_empleado a = new Modificar_empleado();
            a.Show();
        }
    
    }
}
