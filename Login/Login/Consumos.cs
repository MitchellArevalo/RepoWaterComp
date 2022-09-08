using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using System.Runtime.CompilerServices;
using System.Collections;
using System.util;
using System.Reflection;
using iTextSharp.text.factories;
using iTextSharp.text.pdf.codec;

namespace Login
{
    public partial class Consumos : Form
    {
        public Consumos()
        {
            InitializeComponent();
        }
        private void llenarGrid()
        {
            try
            {

                DatosBD datos = new DatosBD();

                if (datos.listarConsumos() == null)
                {
                    MessageBox.Show("No se logró acceder a los datos");
                }
                else
                {
                    dglistaConsumos.DataSource = datos.listarConsumos().DefaultView;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }
        private void Consumos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre;
                nombre = Convert.ToString(dglistaConsumos.CurrentRow.Cells["Cliente"].Value);

                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el consumo de " + nombre + " del sistema?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    string ID_eliminar;

                    ID_eliminar = Convert.ToString(dglistaConsumos.CurrentRow.Cells["IdConsumo"].Value);

                    DatosBD deleteMethod = new DatosBD();
                    bool eliminado = deleteMethod.DeleteConsumo(ID_eliminar);
                    if (eliminado == true)
                    {
                        MessageBox.Show("El consumo se ha eliminado correctamente");
                        llenarGrid();
                        this.Refresh();
                        return;
                    }
                    MessageBox.Show("Ocurrió un error al intentar eliminar el consumo");
                }


            }
            catch (SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form viajar = new Consumo_o_Registros();
            viajar.Show();

            this.Hide();
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            if (dglistaConsumos.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Consumos-" + DateTime.Now.ToString("MM-dd-yyyy");
                string ReportUser;

                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            ReportUser = sfd.FileName;
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Ocurrió un error al intentar guardar" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            ReportUser = sfd.FileName;
                            PdfPTable pdfTable = new PdfPTable(8);
                            pdfTable.DefaultCell.Padding = 5;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE;
                            iTextSharp.text.Font colorCeldas = FontFactory.GetFont("Calibri", 15, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(101, 115, 162));
                            iTextSharp.text.Font fuenteFecha = FontFactory.GetFont("Calibri", 10, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(101, 115, 162));


                            foreach (DataGridViewColumn column in dglistaConsumos.Columns)
                            {
                                if (column.Visible == true)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, colorCeldas));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    cell.PaddingBottom = 8;
                                    cell.PaddingTop = 8;
                                    pdfTable.AddCell(cell);
                                }
                            }

                            for (int row = 0; row < dglistaConsumos.Rows.Count; ++row)
                            {
                                for (int col = 1; col < 9; ++col)
                                {
                                    if (col == 4)
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[4].Value;
                                        pdfTable.AddCell("$" + value.ToString());
                                    }
                                    else if (col == 2)
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[2].Value;
                                        pdfTable.AddCell(value.ToString() + " m³");
                                    }
                                    else if (col == 5)
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[6].Value;
                                        pdfTable.AddCell(value.ToString());
                                    }
                                    else if (col == 6)
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[8].Value;
                                        pdfTable.AddCell(value.ToString());
                                    }
                                    else if (col == 7)
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[10].Value;
                                        pdfTable.AddCell(value.ToString());
                                    }
                                    else if (col == 8)
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[11].Value;
                                        pdfTable.AddCell(value.ToString());
                                    }
                                    else
                                    {
                                        object value = dglistaConsumos.Rows[row].Cells[col].Value;
                                        pdfTable.AddCell(value.ToString());
                                    }
                                    
                                }
                            }

                            Paragraph p = new Paragraph(Width);
                            BaseColor azulTitulo = new BaseColor(101, 115, 162);
                            var colorTitulo = FontFactory.GetFont("Calibri", 30, azulTitulo);

                            p.Font.Size = 30;
                            p.Alignment = Element.ALIGN_CENTER;
                            p.Leading = colorTitulo.Size * 1f;
                            p.SpacingAfter = colorTitulo.Size * 1f;
                            p.Add(new Phrase("Reporte consumos", colorTitulo));

                            Paragraph date = new Paragraph(Width);

                            date.Font.Size = 30;
                            date.Alignment = Element.ALIGN_LEFT;
                            date.Leading = colorTitulo.Size * 0f;
                            date.SpacingAfter = colorTitulo.Size * 0f;
                            date.Add(new Phrase(DateTime.Now.ToString(), fuenteFecha));

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A3, 15f, 15f, 30f, 30f);



                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();
                                pdfDoc.NewPage();

                                Image watermark = Image.GetInstance(Application.StartupPath + @"\UsersImage\" + "LogoSinFondo.png");

                                watermark.ScaleToFit(400, 400);

                                watermark.SetAbsolutePosition(215, 500);

                                pdfDoc.Add(watermark);
                                pdfDoc.Add(date);
                                pdfDoc.Add(new Paragraph(p));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            //File.Copy(ReportUser, Application.StartupPath + @"\ReportsUsuarios\" + Path.GetFileName(sfd.FileName));
                            DialogResult resul = MessageBox.Show("¿Desea enviar una copia del reporte al correo electrónico?", "Enviar Reporte", MessageBoxButtons.YesNo);
                            if (resul == DialogResult.Yes)
                            {
                                Form viajar = new Enviar_Reporte();
                                viajar.Show();
                                Enviar_Reporte.archivo = ReportUser;
                                Enviar_Reporte.type = "Consumos";

                            }
                            else
                            {
                                MessageBox.Show("Exportado correctamente");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay nada por guardar");
            }

        }

        private void editar_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string id, consumo,  Observa, Direcc,qr;
                id = Convert.ToString(dglistaConsumos.CurrentRow.Cells["IdConsumo"].Value);
                consumo = Convert.ToString(dglistaConsumos.CurrentRow.Cells["Consumo"].Value);
                Observa = Convert.ToString(dglistaConsumos.CurrentRow.Cells["Observaciones"].Value);
                Direcc = Convert.ToString(dglistaConsumos.CurrentRow.Cells["Direccion"].Value);
                qr = Convert.ToString(dglistaConsumos.CurrentRow.Cells["QRdireccion"].Value);


                Editar_Consumo.qr = qr;
                Editar_Consumo.id_act = id;
                Editar_Consumo.consumo_act = consumo;
                Editar_Consumo.comentarios_act = Observa;
                Editar_Consumo.adress_act = Direcc;
            }
            catch (SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
            Form viajar = new Editar_Consumo();
            viajar.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string infoBuscada = textBox1.Text;

            DatosBD datos = new DatosBD();

            if (datos.listarConsumoBuscado(infoBuscada) == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                dglistaConsumos.DataSource = datos.listarConsumoBuscado(infoBuscada).DefaultView;
            }
            this.Refresh();
        }
    }
}
