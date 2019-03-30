using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Hermanas_nazario
{
    public partial class Factura_servicios : Form
    {
        int CodigoS, a=0;
        String Espace = "\n\n\n\n";
        String Linea = "__________________________";
        String Nombre;

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
            if (txtnom.Text == " ")
                txtdescripcion.Text = " ";


        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            if (txtnom.Text == " ")
                txtdescripcion.Text = " ";

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
            if (txtCantidad.Text=="0")
            {
                MessageBox.Show("Ingrese un numero mayor a 0");
                return;
            }
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
            if (Base_de_datos.ValidarFacturaDetalle(lblCodigoFacturaSer.Text,a.ToString())== 1)
            {
                Base_de_datos.Detalle_Servicio(int.Parse(lblCodigoFacturaSer.Text), CodigoS, int.Parse(txtCantidad.Text));
                Base_de_datos busc = new Base_de_datos();
                busc.BuscarDetalle(lblCodigoFacturaSer.Text);
                dataGridView2.DataSource = busc.Mostrar_Resultados();
                btnGuardar.Enabled = true;
                a= int.Parse(dataGridView2[1, 0].Value.ToString());
            }
            else
            MessageBox.Show("Servicio ya Ingresado");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Anio, Mes, Dia;
            btnAgregar.Enabled = true;       
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
            a = int.Parse((selectedRow.Cells[0].Value).ToString());
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
                String Titulo = "Dispensario Médico Hermana Nazaria";
                String Titulo2 = "\nAguas del Padre, Siguatepeque, Comayagua\n";
                String Head;

                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                String Fecha = "";
                int Mes = DateTime.Now.Month;
                switch (Mes)
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
                Head = (Titulo + Titulo2 + Fecha + "\n");
                Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                try
                {
                    //Poner direccion bien y agregar fecha


                    Paragraph Parrafo = new Paragraph(Head);
                    Parrafo.Alignment = Element.ALIGN_CENTER;

                    Paragraph Espacio = new Paragraph(Espace);

                    //Creating iTextSharp Table from the DataTable data
                    PdfPTable pdfTable = new PdfPTable(dataGridView2.ColumnCount);

                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn column in dataGridView2.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }


                    int row = dataGridView2.Rows.Count;
                    int cell2 = dataGridView2.Rows[0].Cells.Count;
                    for (int x = 0; x < row; x++)
                    {
                        for (int j = 0; j < cell2; j++)
                        {

                            pdfTable.AddCell(dataGridView2.Rows[x].Cells[j].Value.ToString());
                        }
                    }
                    string Valor;
                    Valor = "Codigo Factura: " + lblCodigoFacturaSer.Text;
                    Paragraph Cod = new Paragraph(Valor);
                    Cod.Alignment = Element.ALIGN_JUSTIFIED;

                    //Exporting to PDF
                    string folderPath = @"C:\Facturas\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + "Factura_Servicios_" + lblCodigoFacturaSer.Text + ".pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 30f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                        pdfDoc.Add(Parrafo);
                        pdfDoc.Add(Espacio);

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(Espacio);
                        pdfDoc.Close();
                        stream.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Hide();
               
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lblCodigoFacturaSer.Text == "*")
            {
                this.Hide();
            }
            else if ((MessageBox.Show("Esta seguro desea cancelar la factura", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes) )
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
            }
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.RemoveAt(indice);
            Base_de_datos.Quitar_Detalle(int.Parse(lblCodigoFacturaSer.Text), a);
            btnQuitar.Enabled = false;
            if (dataGridView2.Rows.Count == 0)
                btnGuardar.Enabled = false;
                
        }
        
      
    }
    
}
