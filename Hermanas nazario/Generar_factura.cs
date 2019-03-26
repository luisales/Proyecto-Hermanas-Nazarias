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
    public partial class Generar_factura : Form
    {
        float TotalFinal;
        float total;
        float descuento;
        float TotalMedicamentos;
        float totalDescuento;
        String Espace = "\n\n\n\n";
        String Linea = "__________________________";
        String Nombre;

        public Generar_factura()
        {
            InitializeComponent();
            txtCita.Text = Base_de_datos.cita;
            Base_de_datos.decis = 2;
        }

        private void chkIngresar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIngresar.Checked)
            {
                txtIngresar.Enabled = true;
              
            }

            else
            {
                txtIngresar.Enabled = false;
                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Base_de_datos.cita = "";
            this.Hide();
            Receta a = new Receta();
            a.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCita.Text) == false)
            {
                MessageBox.Show("Ingrese el numero de cita");
                return;
            }

            Base_de_datos most = new Base_de_datos();
            
            if (most.BuscarReceta(txtCita.Text) == 0)
            {
                txtValorC.Enabled = false;
                btnPagar.Enabled = false;
                chkIngresar.Enabled = false;
                dataGridView1.DataSource = null;
                btnCancelar.Enabled = false;


            }
            else
            {

                
                most.BuscarReceta(txtCita.Text);
                dataGridView1.DataSource = most.Mostrar_Resultados();
                Base_de_datos.porcentaje_riesgo(txtCita.Text);
               


                total = Base_de_datos.total_medicamentos(txtCita.Text);
                descuento = total * (Base_de_datos.porcentaje_riesgo(txtCita.Text) / 100);
                totalDescuento = total - descuento;

                txtMedicamentos.Text = total.ToString();
                txtDesc.Text = totalDescuento.ToString();
                txtSubTotal.Text = descuento.ToString();

                TotalFinal =  descuento;
                txtTotal.Text = TotalFinal.ToString();

                txtValorC.Enabled = true;
                btnPagar.Enabled = true;
                chkIngresar.Enabled = true;

                btnCancelar.Enabled = true;
            



            }


            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorC.Text) == false)
            {
                MessageBox.Show("Ingrease el valor de la consulta");
                return;
            }

            if (!string.IsNullOrEmpty(txtValorC.Text) == false)
            {
                MessageBox.Show("Ingrease el valor de la consulta");
                return;
            }

            if (!string.IsNullOrEmpty(txtIngresar.Text) == false)
            {
                MessageBox.Show("Ingrese el valor a pagar");
                return;
            }
            int validar;
            validar = Base_de_datos.ValidarFactura(txtCita.Text);
            if(validar==1)
            {
                MessageBox.Show("Esta factura ya esta pagada");
                return;
            }
            if (chkIngresar.Checked)
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
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }


                    int row = dataGridView1.Rows.Count;
                    int cell2 = dataGridView1.Rows[0].Cells.Count;
                    for (int x = 0; x < row; x++)
                    {
                        for (int j = 0; j < cell2; j++)
                        {

                            pdfTable.AddCell(dataGridView1.Rows[x].Cells[j].Value.ToString());
                        }
                    }
                    string Valor;
                    Valor = "Codigo Factura: " + txtCita.Text;
                    Paragraph Cod = new Paragraph(Valor);
                    Cod.Alignment = Element.ALIGN_JUSTIFIED;
                    Valor = "Valor de las medicinas: LPS. " + txtMedicamentos.Text;
                    Paragraph Med = new Paragraph(Valor);
                    Med.Alignment = Element.ALIGN_JUSTIFIED;
                    Valor = "Descuento: LPS. " + txtDesc.Text;
                    Paragraph Desc = new Paragraph(Valor);
                    Desc.Alignment = Element.ALIGN_JUSTIFIED;
                    Valor = "Sub-Total: LPS. " + txtSubTotal.Text;
                    Paragraph Sub = new Paragraph(Valor);
                    Sub.Alignment = Element.ALIGN_JUSTIFIED;
                    Valor = "Consulta: LPS. " + txtConsulta.Text;
                    Paragraph Consulta = new Paragraph(Valor);
                    Consulta.Alignment = Element.ALIGN_JUSTIFIED;
                    Valor = "Total: LPS. " + txtTotal.Text;
                    Paragraph Total = new Paragraph(Valor);
                    Total.Alignment = Element.ALIGN_JUSTIFIED;
                    //Exporting to PDF
                    string folderPath = @"C:\Facturas\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + "Factura_" + txtCita.Text + ".pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 30f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                        pdfDoc.Add(Parrafo);
                        pdfDoc.Add(Espacio);

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(Espacio);
                        pdfDoc.Add(Med);
                        pdfDoc.Add(Desc);
                        pdfDoc.Add(Sub);
                        pdfDoc.Add(Consulta);
                        pdfDoc.Add(Total);
                        pdfDoc.Close();
                        stream.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (MessageBox.Show("Esta seguro desea ingresar la factura","Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Base_de_datos.Ingresar_factura(double.Parse(txtValorC.Text), double.Parse(txtIngresar.Text), int.Parse(txtCita.Text));
                    Base_de_datos most = new Base_de_datos();
                    DataTable a;
                    int i = 0;
                    int bb = Base_de_datos.numero;
                    most.BuscarReceta(txtCita.Text);
                    a = most.Mostrar_Resultados();
                    do
                    {
                        DataRow row = a.Rows[i];
                        Base_de_datos.validmedi(row["Codigo Medicamento"].ToString());
                      
                        Base_de_datos.vencemedi(int.Parse(row["Codigo Medicamento"].ToString()), int.Parse(Base_de_datos.cant) - int.Parse(row["Cantidad"].ToString()));
                     
                        i++;
                    }
                    while (i < bb);



                    txtValorC.Enabled = false;
                    btnPagar.Enabled = false;
                    chkIngresar.Enabled = false;
                    txtIngresar.Enabled = false;
                    chkIngresar.Checked = false;
                    btnCancelar.Enabled = false;
                    dataGridView1.DataSource = null;
                    
                    txtTotal.Text = "0";
                    txtIngresar.Text = "0";
                    txtCita.Text = "";
                    txtCita.Focus();
                    txtValorC.Text = "";
                    txtConsulta.Text = "0";
                    txtDesc.Text = "0";
                    txtMedicamentos.Text = "0";
                    txtSubTotal.Text = "0";
                    Base_de_datos.cita = "";
                }
            }
            else
            {
                if (MessageBox.Show("Esta seguro desea ingresar la factura","Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                        PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }


                        int row = dataGridView1.Rows.Count;
                        int cell2 = dataGridView1.Rows[0].Cells.Count;
                        for (int x = 0; x < row; x++)
                        {
                            for (int j = 0; j < cell2; j++)
                            {

                                pdfTable.AddCell(dataGridView1.Rows[x].Cells[j].Value.ToString());
                            }
                        }
                        string Valor;
                        Valor = "Codigo Factura: " + txtCita.Text;
                        Paragraph Cod = new Paragraph(Valor);
                        Cod.Alignment = Element.ALIGN_JUSTIFIED;
                        Valor = "Valor de las medicinas: LPS. " + txtMedicamentos.Text;
                        Paragraph Med = new Paragraph(Valor);
                        Med.Alignment = Element.ALIGN_JUSTIFIED;
                        Valor = "Descuento: LPS. " + txtDesc.Text;
                        Paragraph Desc = new Paragraph(Valor);
                        Desc.Alignment = Element.ALIGN_JUSTIFIED;
                        Valor = "Sub-Total: LPS. " + txtSubTotal.Text;
                        Paragraph Sub = new Paragraph(Valor);
                        Sub.Alignment = Element.ALIGN_JUSTIFIED;
                        Valor = "Consulta: LPS. " + txtConsulta.Text;
                        Paragraph Consulta = new Paragraph(Valor);
                        Consulta.Alignment = Element.ALIGN_JUSTIFIED;
                        Valor = "Total: LPS. " + txtTotal.Text;
                        Paragraph Total = new Paragraph(Valor);
                        Total.Alignment = Element.ALIGN_JUSTIFIED;
                        //Exporting to PDF
                        string folderPath = @"C:\Facturas\";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        using (FileStream stream = new FileStream(folderPath + "Factura_" + txtCita.Text + ".pdf", FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4.Rotate(), 30f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);

                            pdfDoc.Open();
                            pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                            pdfDoc.Add(Parrafo);
                            pdfDoc.Add(Espacio);

                            pdfDoc.Add(pdfTable);
                            pdfDoc.Add(Espacio);
                            pdfDoc.Add(Med);
                            pdfDoc.Add(Desc);
                            pdfDoc.Add(Sub);
                            pdfDoc.Add(Consulta);
                            pdfDoc.Add(Total);
                            pdfDoc.Close();
                            stream.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Base_de_datos.Ingresar_factura(double.Parse(txtValorC.Text), double.Parse(txtTotal.Text), int.Parse(txtCita.Text));
                    Base_de_datos most = new Base_de_datos();
                    DataTable a;
                    int i = 0;
                    int bb = Base_de_datos.numero;
                    most.BuscarReceta(txtCita.Text);
                    a = most.Mostrar_Resultados();
                    do
                    {
                        DataRow row = a.Rows[i];
                        Base_de_datos.validmedi(row["Codigo Medicamento"].ToString());
                      
                        Base_de_datos.vencemedi(int.Parse(row["Codigo Medicamento"].ToString()), int.Parse(Base_de_datos.cant) - int.Parse(row["Cantidad"].ToString()));
                       
                        i++;
                    }
                    while (i < bb);



                    txtValorC.Enabled = false;
                    btnPagar.Enabled = false;
                    chkIngresar.Enabled = false;

                    txtIngresar.Enabled = false;
                    chkIngresar.Checked = false;
                    btnCancelar.Enabled = false;
                    dataGridView1.DataSource = null;
                    

                    txtTotal.Text = "0";
                    txtIngresar.Text = "0";
                    txtCita.Text = "";
                    txtCita.Focus();
                    txtValorC.Text = "";
                    txtConsulta.Text = "0";
                    txtDesc.Text = "0";
                    txtMedicamentos.Text = "0";
                    txtSubTotal.Text = "0";
                    Base_de_datos.cita = "";
                }
            }
          


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtValorC.Enabled = false;
            btnPagar.Enabled = false;
            chkIngresar.Enabled = false;
            txtIngresar.Enabled = false;
            btnCancelar.Enabled = false;
            chkIngresar.Checked = false;
            txtSubTotal.Text = "0";
            txtMedicamentos.Text = "0";
            txtDesc.Text = "0";
            txtConsulta.Text = "0";
            dataGridView1.DataSource = null;

            txtSubTotal.Text = "0";
            txtTotal.Text = "0";
            txtIngresar.Text = "0";
            txtValorC.Text = "0";
            txtCita.Text = "";
            txtCita.Focus();
        }

        private void txtIngresar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);

        }

        private void txtValorC_TextChanged(object sender, EventArgs e)
        {
            

            if (btnPagar.Enabled == true)
            {
                if (txtValorC.TextLength >= 1)
                { 
                    txtConsulta.Text = txtValorC.Text;
                txtSubTotal.Text = descuento.ToString();
                    txtMedicamentos.Text = total.ToString();
                    txtDesc.Text = totalDescuento.ToString();

        
                    txtTotal.Text = (TotalFinal + int.Parse(txtValorC.Text)).ToString();
                }
                if (txtValorC.TextLength == 0)
                { 
                 txtConsulta.Text = "0";
                 txtDesc.Text = totalDescuento.ToString();
                 txtSubTotal.Text = descuento.ToString();
                 txtMedicamentos.Text = total.ToString();
                 txtTotal.Text = (TotalFinal + 0).ToString();
                }
            }
        }

        private void txtIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
            Validar.espacio(e);
        }

        private void txtCita_TextChanged(object sender, EventArgs e)
        {

            if (btnPagar.Enabled==true)
            {
                txtValorC.Enabled = false;
                btnPagar.Enabled = false;
                chkIngresar.Enabled = false;

                txtIngresar.Enabled = false;
                btnCancelar.Enabled = false;
                chkIngresar.Checked = false;
                dataGridView1.DataSource = null;
                txtTotal.Text = "0";
                txtIngresar.Text = "0";
                txtValorC.Text = "0";
                txtCita.Text = "";
                txtDesc.Text = "0";
                txtMedicamentos.Text = "0";
                txtSubTotal.Text = "0";
                txtConsulta.Text = "0";
                txtCita.Focus();
            }

            if (!string.IsNullOrEmpty(txtCita.Text) == false)
            {
               
                return;
            }

            Base_de_datos most = new Base_de_datos();

            if (most.BuscarReceta(txtCita.Text) == 0)
            {
                txtValorC.Enabled = false;
                btnPagar.Enabled = false;
                chkIngresar.Enabled = false;
                dataGridView1.DataSource = null;
                btnCancelar.Enabled = false;

            }
            else
            {


                most.BuscarReceta(txtCita.Text);
                dataGridView1.DataSource = most.Mostrar_Resultados();
                Base_de_datos.porcentaje_riesgo(txtCita.Text);



                total = Base_de_datos.total_medicamentos(txtCita.Text);
                descuento = total * (Base_de_datos.porcentaje_riesgo(txtCita.Text) / 100);
                totalDescuento = total - descuento;

                txtMedicamentos.Text = total.ToString();
                txtDesc.Text = totalDescuento.ToString();
                txtSubTotal.Text = descuento.ToString();

                TotalFinal = descuento;
                txtTotal.Text = TotalFinal.ToString();

                txtValorC.Enabled = true;
                btnPagar.Enabled = true;
                chkIngresar.Enabled = true;

                btnCancelar.Enabled = true;

            }


        }

        private void Generar_factura_Load(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_citas a = new Busqueda_citas();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void Generar_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.espacio(e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
