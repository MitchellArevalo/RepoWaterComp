using ExcelDataReader;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
        private void llenarGrid()
        {
            try
            {
                
                DatosBD datos = new DatosBD();

                if (datos.listarConFoto() == null)
                {
                    MessageBox.Show("No se logró acceder a los datos");
                }
                else
                {
                    dglista2.DataSource = datos.listarConFoto().DefaultView;
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form viajar = new Menu();
            viajar.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form viajar = new agregar_usuario();
            viajar.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {
                llenarGrid();
                this.Refresh();
                this.textBox1.Clear();   
        }
       

        private void Deletebutton_Click_1(object sender, EventArgs e)
        {

            try
            {
                string nombre, imagen;
                nombre = Convert.ToString(dglista2.CurrentRow.Cells["Nombre"].Value);
                imagen = Convert.ToString(dglista2.CurrentRow.Cells["Foto_Ubicacion"].Value);

                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar a " + nombre + " del sistema?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    string ID_eliminar;

                    ID_eliminar = Convert.ToString(dglista2.CurrentRow.Cells["IdUsuarios"].Value);

                    DatosBD deleteMethod = new DatosBD();
                    bool eliminado = deleteMethod.DeleteUser(ID_eliminar);
                    if (eliminado == true)
                    {
                        MessageBox.Show("El usuario se ha eliminado correctamente");
                        File.Delete(Application.StartupPath + @"\UsersImage\" + imagen);
                        llenarGrid();
                        this.Refresh();
                        return;
                    }
                    MessageBox.Show("Ocurrió un error al intentar eliminar el usuario"); 
                }

                
            }
            catch(SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
        }

        private void editar_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string id, nombre, Documento_identidad, correo, user, rol, contra, Foto, active;
                id = Convert.ToString(dglista2.CurrentRow.Cells["IdUsuarios"].Value);
                nombre = Convert.ToString(dglista2.CurrentRow.Cells["Nombre"].Value);
                Documento_identidad = Convert.ToString(dglista2.CurrentRow.Cells["Documento"].Value);
                correo = Convert.ToString(dglista2.CurrentRow.Cells["Correo_Electronico"].Value);
                user = Convert.ToString(dglista2.CurrentRow.Cells["Usuario"].Value);
                rol = Convert.ToString(dglista2.CurrentRow.Cells["Rol"].Value);
                contra = Convert.ToString(dglista2.CurrentRow.Cells["Password"].Value);
                Foto = Convert.ToString(dglista2.CurrentRow.Cells["Foto_Ubicacion"].Value);
                active = Convert.ToString(dglista2.CurrentRow.Cells["Active"].Value);
                

                Editar_usuario.llenarCamposEditables(id, Documento_identidad, nombre, correo, contra, user, rol, Foto, active);
            }
            catch (SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
            Form viajar = new Editar_usuario();
            viajar.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string infoBuscada = textBox1.Text;

            DatosBD datos = new DatosBD();

            if (datos.listarBuscado(infoBuscada) == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                dglista2.DataSource = datos.listarBuscado(infoBuscada).DefaultView;
            }
            this.Refresh();
        }
        public void refrescar()
        {
            llenarGrid();
            this.Refresh();
        }

        private void dglista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {


        }


        private void button3_Click(object sender, EventArgs e)
         {
           

             if (dglista2.Rows.Count > 0)
              {
                  SaveFileDialog sfd = new SaveFileDialog();
                  sfd.Filter = "PDF (*.pdf)|*.pdf";
                  sfd.FileName = "Usuarios-" + DateTime.Now.ToString("MM-dd-yyyy" );
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


                            foreach (DataGridViewColumn column in dglista2.Columns)
                                {
                                    if (column.Visible == true)
                                    {       
                                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, colorCeldas));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        cell.PaddingBottom = 8;
                                        cell.PaddingTop = 8;
                                        pdfTable.AddCell(cell);
                                    }
                                }
                          
                            for (int row = 0; row < dglista2.Rows.Count; ++row)
                            {
                                for (int col = 1; col < 10; ++col)
                                {
                                    if (col != 6)
                                    {
                                        if (col == 9)
                                        {
                                            object value = dglista2.Rows[row].Cells[9].Value;

                                            pdfTable.AddCell(value.ToString());
                                        }
                                        else
                                        {
                                            if (col == 1)
                                            {
                                                var logo = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\UsersImage\" + dglista2.Rows[row].Cells[8].Value);
                                                logo.ScaleAbsoluteWidth(90);
                                                logo.ScaleAbsoluteHeight(90);
                                                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                                                var imageCelda = new PdfPCell(logo);
                                                imageCelda.Padding = 3;
                                                imageCelda.BorderWidth = 1;
                                                imageCelda.BorderColor = BaseColor.BLACK;
                                                imageCelda.HorizontalAlignment = iTextSharp.text.Image.ALIGN_CENTER;
                                                pdfTable.AddCell(imageCelda);
                                                
                                            }
                                            else
                                            {
                                                object value = dglista2.Rows[row].Cells[col].Value;
                                                
                                                pdfTable.AddCell(value.ToString());
                                            }
                                        
                                        }
                                        
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
                            p.Add(new Phrase("Reporte Usuarios", colorTitulo));

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
                                
                                watermark.SetAbsolutePosition(215,500);

                                pdfDoc.Add(watermark);
                                pdfDoc.Add(date);
                                pdfDoc.Add(new Paragraph(p));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                              }
                            //File.Copy(ReportUser, Application.StartupPath + @"\ReportsUsuarios\" + Path.GetFileName(sfd.FileName));
                            DialogResult resul = MessageBox.Show("¿Desea enviar una copia del reporte al correo electrónico?","Enviar Reporte", MessageBoxButtons.YesNo);
                            if (resul == DialogResult.Yes)
                            {
                                Form viajar = new Enviar_Reporte();
                                viajar.Show();
                                Enviar_Reporte.archivo = ReportUser;
                                Enviar_Reporte.type = "Usuario";

                            }
                            else
                            {
                                MessageBox.Show("Exportado correctamente");
                                return;
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
