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
                 sfd.FileName = "Usuarios.pdf";
                 bool fileError = false;
                 if (sfd.ShowDialog() == DialogResult.OK)
                 {
                     if (File.Exists(sfd.FileName))
                     {
                         try
                         {
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
                             PdfPTable pdfTable = new PdfPTable(dglista2.Columns.Count);
                             pdfTable.DefaultCell.Padding = 5;
                             pdfTable.WidthPercentage = 100;
                             pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                             foreach (DataGridViewColumn column in dglista2.Columns)
                             {
                                 if (column.Visible)
                                 {
                                     PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                     pdfTable.AddCell(cell);
                                 }

                             }

                             foreach (DataGridViewRow row in dglista2.Rows)
                             {
                                 foreach (DataGridViewCell cell in row.Cells)
                                 {
                                     pdfTable.AddCell(cell.Value.ToString());
                                 }
                             }

                             using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                             {
                                 Document pdfDoc = new Document(PageSize.A4, 10f, 30f, 30f, 10f);
                                 PdfWriter.GetInstance(pdfDoc, stream);
                                 pdfDoc.Open();

                                 pdfDoc.Add(pdfTable);
                                 pdfDoc.Close();
                                 stream.Close();
                             }

                             MessageBox.Show("Exportado correctamente");
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
