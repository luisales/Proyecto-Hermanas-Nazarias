using System;
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
    public partial class NuevoMenu : Form
    {
        public NuevoMenu()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Base_de_datos.BuscarPermisos(Base_de_datos.rol.ToString());
            if (Base_de_datos.paca == 1)
            {
                pictureBox2.Visible = true;



            }
            if (Base_de_datos.Permisos.Contains("A"))
            {
                bunifuFlatButton1.Enabled = true;
            }
            else
                bunifuFlatButton1.Enabled = false;

            if (Base_de_datos.Permisos.Contains("B"))
            {
                bunifuFlatButton2.Enabled = true;
            }
            else
                bunifuFlatButton2.Enabled = false;

            if (Base_de_datos.Permisos.Contains("C"))
            {
                bunifuFlatButton3.Enabled = true;
            }
            else
                bunifuFlatButton3.Enabled = false;

            if (Base_de_datos.Permisos.Contains("D"))
            {
                bunifuFlatButton4.Enabled = true;
            }
            else
                bunifuFlatButton4.Enabled = false;

            if (Base_de_datos.Permisos.Contains("E"))
            {
                bunifuFlatButton5.Enabled = true;
            }
            else
                bunifuFlatButton5.Enabled = false;

            if (Base_de_datos.Permisos.Contains("F"))
            {
                bunifuFlatButton11.Enabled = true;
            }
            else
                bunifuFlatButton11.Enabled = false;


            if (Base_de_datos.Permisos.Contains("G"))
            {
                bunifuFlatButton12.Enabled = true;
            }
            else
                bunifuFlatButton12.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel5.Visible == true)
            {
                panel5.Visible = false;
            }
            else
            {
                panel5.Visible = true;
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel6.Visible == true)
            {
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = true;
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Registro_pacientes a = new Registro_pacientes();
            a.Left = 415;
            a.Top = 90;
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();

        }

        private void bunifuFlatButton28_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel8.Visible == true)
            {
                panel8.Visible = false;
            }
            else
            {
                panel8.Visible = true;
            }
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel7.Visible == true)
            {
                panel7.Visible = false;
            }
            else
            {
                panel7.Visible = true;
            }
        }

        private void bunifuFlatButton26_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
            if (panel10.Visible == true)
            {
                panel10.Visible = false;
            }
            else
            {
                panel10.Visible = true;
            }
        }

        private void bunifuFlatButton27_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            if (panel11.Visible == true)
            {
                panel11.Visible = false;
            }
            else
            {
                panel11.Visible = true;
            }
        }

        private void bunifuFlatButton24_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            if (panel9.Visible == true)
            {
                panel9.Visible = false;
            }
            else
            {
                panel9.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea salir del sistema?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Login a = new Login();
                a.Show();
                Base_de_datos.paca = 0;
                Base_de_datos.nombrePacientes.Clear();
                Base_de_datos.cantidadPacientes.Clear();
            }
                
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Factura_servicios a = new Factura_servicios();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Busqueda_de_pacientes a = new Busqueda_de_pacientes();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Base_de_datos.decis = 3;
            Busqueda_citas a = new Busqueda_citas();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Registro_empleado a = new Registro_empleado();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Busqueda_empleados a = new Busqueda_empleados();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Registro_de_usuario a = new Registro_de_usuario();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Modifiar_usuario a = new Modifiar_usuario();
            a.ShowDialog();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Receta a = new Receta();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Busqueda_factura a = new Busqueda_factura();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Ingresar_medicamento a = new Ingresar_medicamento();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Ingreso_ropa a = new Ingreso_ropa();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();

        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Busqueda_medicamentos a = new Busqueda_medicamentos();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton25_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;

            Referencia a = new Referencia();
            a.ShowDialog();
            Base_de_datos.paca = 0;
            Base_de_datos.nombrePacientes.Clear();
            Base_de_datos.cantidadPacientes.Clear();
        }

        private void bunifuFlatButton30_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Ingresar_medida a = new Ingresar_medida();
            a.ShowDialog();
        }

        private void bunifuFlatButton29_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Modificacion_medida a = new Modificacion_medida();
            a.ShowDialog();
        }

        private void bunifuFlatButton36_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Ingresar_Servicio a = new Ingresar_Servicio();
            a.ShowDialog();
        }

        private void bunifuFlatButton35_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Modificar_servcios a = new Modificar_servcios();
            a.ShowDialog();
        }

        private void bunifuFlatButton31_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Modificar_Nivel a = new Modificar_Nivel();
            a.ShowDialog();
        }

        private void bunifuFlatButton32_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Modificar_Nivel a = new Modificar_Nivel();
            a.ShowDialog();
        }

        private void bunifuFlatButton34_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Registro_roles a = new Registro_roles();
            a.ShowDialog();
        }

        private void bunifuFlatButton33_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            Modificacion_roles a = new Modificacion_roles();
            a.ShowDialog();
        }

        private void bunifuFlatButton1_MouseHover(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_MouseUp(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\ModuloAyuda\index.html";
            proceso.Start();
        }

        private void bunifuFlatButton32_Click_1(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Registro_Nivel a = new Registro_Nivel();
            a.ShowDialog();
        }

        private void NuevoMenu_SizeChanged(object sender, EventArgs e)
        {
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton23_Click(object sender, EventArgs e)
        {
            Busqueda_ropa a = new Busqueda_ropa();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura_ropa a = new Factura_ropa();
            a.ShowDialog();

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Factura_ropa a = new Factura_ropa();
            a.ShowDialog();
        }
    }
}
