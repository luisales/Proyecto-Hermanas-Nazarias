using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace Hermanas_nazario
{
    public partial class Referencia : Form
    {
        string NombrePaciente;
        String Espace = "\n\n\n\n";
        String Linea = "__________________________";
        String Nombre;

        public Referencia()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = false;
            txtnom.Visible = false;
            txtape.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
            txtape.Enabled = false;
            txtape.Visible = false;
            label3.Visible = false;
            
            label1.Text = "Identidad: ";
            txtId.Enabled = true;
            txtId.Visible = true;
            dataGridView1.DataSource = null;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtnom.Enabled = true;
            txtnom.Visible = true;
            txtape.Enabled = true;
            txtape.Visible = true;
            label3.Visible = true;
            txtape.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
            
            label1.Text = "Primer Nombre: ";
            txtId.Enabled = false;
            txtId.Visible = false;
            dataGridView1.DataSource = null;
            
        }

        private void txtape_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.Buscar(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
                
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && txtnom.TextLength >= 1 && txtape.TextLength >= 1)
            {
                Base_de_datos busc = new Base_de_datos();
                busc.Buscar(txtnom.Text.ToUpper(), txtape.Text.ToUpper());
                dataGridView1.DataSource = busc.Mostrar_Resultados();
            }
            else
            {
                dataGridView1.DataSource = null;
                
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked && txtId.TextLength == 13)
            {

                Base_de_datos busc = new Base_de_datos();
                busc.Buscar(txtId.Text);
                dataGridView1.DataSource = busc.Mostrar_Resultados();

            }
            else
            {
                dataGridView1.DataSource = null;
             
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.DataSource != null)
            {   
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                NombrePaciente = (Convert.ToString(selectedRow.Cells[1].Value)+" "+ Convert.ToString(selectedRow.Cells[2].Value) + " " + Convert.ToString(selectedRow.Cells[3].Value));
                lblSeleccion.Text = NombrePaciente;
                String Titulo = "Dispensario Médico Hermana Nazaria";
                String Titulo2 = "\nAguas del Padre, Siguatepeque, Comayagua\n";
                Nombre = Base_de_datos.Referencia();
                txtTitulo.Text = (Titulo + Titulo2 + Nombre);
                String Fecha="";
                int Mes=DateTime.Now.Month;
                switch(Mes)
                {
                    case 1:
                        Fecha = (DateTime.Now.Day.ToString() + " Enero del " + DateTime.Now.Year.ToString());
                    break;
                    case 2:
                        Fecha = (DateTime.Now.Day.ToString() + " Febrero del " + DateTime.Now.Year.ToString());
                    break;
                    case 3:
                        Fecha = (DateTime.Now.Day.ToString() + " Marzo del " + DateTime.Now.Year.ToString());
                    break;
                    case 4:
                        Fecha = (DateTime.Now.Day.ToString() + " Abril del " + DateTime.Now.Year.ToString());
                    break;
                    case 5:
                        Fecha = (DateTime.Now.Day.ToString() + " Mayo del " + DateTime.Now.Year.ToString());
                    break;
                    case 6:
                        Fecha = (DateTime.Now.Day.ToString() + " Junio del " + DateTime.Now.Year.ToString());
                    break;
                    case 7:
                        Fecha = (DateTime.Now.Day.ToString() + " Julio del " + DateTime.Now.Year.ToString());
                    break;
                    case 8:
                        Fecha = (DateTime.Now.Day.ToString() + " Agosto del " + DateTime.Now.Year.ToString());
                    break;
                    case 9:
                        Fecha = (DateTime.Now.Day.ToString() + " Septiembre del " + DateTime.Now.Year.ToString());
                    break;
                    case 10:
                        Fecha = (DateTime.Now.Day.ToString() + " Octubre del " + DateTime.Now.Year.ToString());
                    break;
                    case 11:
                        Fecha = (DateTime.Now.Day.ToString() + " Noviembre del " + DateTime.Now.Year.ToString());
                    break;
                    case 12:
                        Fecha = (DateTime.Now.Day.ToString() + " Diciembre del " + DateTime.Now.Year.ToString());

                    break;

                }
       
                String Cuerpo = ("Aguas del Padre, "+Fecha);
                String Cuerpo2 = ("\nNombre del (a)Paciente: " + NombrePaciente);
                txtCuerpo.Text = (Cuerpo + Cuerpo2);
                txtFirma.Text = (Linea +"\n"+ Nombre);
                 

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            try
            {
                //Poner direccion bien y agregar fecha
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Facturas\Text.pdf", FileMode.Create));
                doc.Open();
                
                Paragraph Parrafo = new Paragraph(txtTitulo.Text);
                Parrafo.Alignment = Element.ALIGN_CENTER;
                doc.Add(Parrafo);
                Paragraph Espacio = new Paragraph(Espace);
                doc.Add(Espacio);
                Paragraph Parrafo2 = new Paragraph(txtCuerpo.Text);
                Parrafo2.Alignment = Element.ALIGN_LEFT;
                doc.Add(Parrafo2);
                doc.Add(Espacio);
                doc.Add(Espacio);
                doc.Add(Espacio);
                doc.Add(Espacio);
                doc.Add(Espacio);
                doc.Add(Espacio);
                Paragraph Parrafo3 = new Paragraph(txtFirma.Text);
                Parrafo3.Alignment = Element.ALIGN_CENTER;
                doc.Add(Parrafo3);
                

                doc.Close();
                MessageBox.Show("Guardado con exito");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModificar.Checked==true)
            {
                txtTitulo.Enabled = true;
                txtCuerpo.Enabled = true;
                txtFirma.Enabled = true;
            }
            if (checkModificar.Checked == false)
            {
                txtTitulo.Enabled = false;
                txtCuerpo.Enabled = false;
                txtFirma.Enabled = false;
            }

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validar.solonumeros(e);
            


        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validar.sololetras(e);
            


        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validar.sololetras(e);
            

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
