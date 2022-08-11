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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        private void llenarGrid()
        {
            try
            {

                DatosBD datos = new DatosBD();

                if (datos.listarClientes() == null)
                {
                    MessageBox.Show("No se logró acceder a los datos");
                }
                else
                {
                    dglistaUsuarios.DataSource = datos.listarClientes().DefaultView;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form viajar = new Menu();
            viajar.Show();

            this.Hide();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Form viajar = new agregar_Cliente();
            viajar.Show();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            llenarGrid();
            this.Refresh();
            this.textBox1.Clear();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre;
                nombre = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Nombre"].Value);

                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar a " + nombre + " del sistema?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    string ID_eliminar;

                    ID_eliminar = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["IdCliente"].Value);

                    DatosBD deleteMethod = new DatosBD();
                    bool eliminado = deleteMethod.DeleteClient(ID_eliminar);
                    if (eliminado == true)
                    {
                        MessageBox.Show("El usuario se ha eliminado correctamente");
                        llenarGrid();
                        this.Refresh();
                        return;
                    }
                    MessageBox.Show("Ocurrió un error al intentar eliminar el cliente");
                }


            }
            catch (SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
        }

        private void editar_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string id, nombre, Documento_identidad, correo, Estrato, CodP, Direccion, active;
                id = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["IdCliente"].Value);
                nombre = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Nombre"].Value);
                Documento_identidad = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Documento"].Value);
                correo = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Correo_Electronico"].Value);
                Estrato = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Estrato"].Value);
                CodP = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["CodigoPredio"].Value);
                Direccion = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Direccion"].Value);
                active = Convert.ToString(dglistaUsuarios.CurrentRow.Cells["Active"].Value);

                Editar_Cliente.llenarCamposEditables(id, nombre, Documento_identidad, Estrato, CodP, Direccion, correo, active);
            }
            catch (SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
            Form viajar = new Editar_Cliente();
            viajar.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string infoBuscada = textBox1.Text;
            DatosBD datos = new DatosBD();

            if (datos.listarClienteBuscado(infoBuscada) == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                dglistaUsuarios.DataSource = datos.listarClienteBuscado(infoBuscada).DefaultView;
            }
            this.Refresh();
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            if (dglistaUsuarios.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Clientes-" + DateTime.Now.ToString("MM-dd-yyyy");
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
                            PdfPTable pdfTable = new PdfPTable(7);
                            pdfTable.DefaultCell.Padding = 5;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE;
                            iTextSharp.text.Font colorCeldas = FontFactory.GetFont("Calibri", 15, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(101, 115, 162));
                            iTextSharp.text.Font fuenteFecha = FontFactory.GetFont("Calibri", 10, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(101, 115, 162));


                            foreach (DataGridViewColumn column in dglistaUsuarios.Columns)
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

                            for (int row = 0; row < dglistaUsuarios.Rows.Count; ++row)
                            {
                                for (int col = 1; col < 8; ++col)
                                {
                                    object value = dglistaUsuarios.Rows[row].Cells[col].Value;
                                    pdfTable.AddCell(value.ToString());
                                }
                            }

                            Paragraph p = new Paragraph(Width);
                            BaseColor azulTitulo = new BaseColor(101, 115, 162);
                            var colorTitulo = FontFactory.GetFont("Calibri", 30, azulTitulo);

                            p.Font.Size = 30;
                            p.Alignment = Element.ALIGN_CENTER;
                            p.Leading = colorTitulo.Size * 1f;
                            p.SpacingAfter = colorTitulo.Size * 1f;
                            p.Add(new Phrase("Reporte Clientes", colorTitulo));

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
                                Enviar_Reporte.type = "Cliente";

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
    }
}
