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
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using Image = iTextSharp.text.Image;

namespace Login
{
    public partial class Imprimir_Factura : Form
    {
        public Imprimir_Factura()
        {
            InitializeComponent();
        }

        public static bool Admin_Profile;
        public static bool Digitador_Profile;
        public static bool Facturador_Profile;

        private void Imprimir_Factura_Load(object sender, EventArgs e)
        {
            string usuario_actual;
            usuario_actual = DatosBD.username_session;
            DatosBD permisos = new DatosBD();
            bool admin = permisos.PermisosDeAdmin(usuario_actual);
            bool facturador = permisos.PermisosDeFacturador(usuario_actual);
            bool digitador = permisos.PermisosDeDigitador(usuario_actual);
            if (admin == true)
            {
                Admin_Profile = true;
            }
            if (facturador == true)
            {
                Facturador_Profile = true;
            }
            if (digitador == true)
            {
                Digitador_Profile = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DatosBD misdatos = new DatosBD();

                string direccion = TxtDireccion.Text;
                string cliente = TxtNombre.Text;
                string mail = misdatos.ClienteMailFactura(txtDocCliente.Text);
                string fechanumero = Fecha_Factura.Text;
                string[] arreglo1 = fechanumero.Split('/');
                string mes1 = arreglo1[0];

                switch (mes1)
                {
                    case "01":
                        mes1 = "Enero"; //31 dias

                        break;
                    case "02":
                        mes1 = "Febrero";//28 dias

                        break;
                    case "03":
                        mes1 = "Marzo";//31 dias

                        break;
                    case "04":
                        mes1 = "Abril";//30 dias

                        break;
                    case "05":
                        mes1 = "Mayo";//31 dias

                        break;
                    case "06":
                        mes1 = "Junio";//30 dias

                        break;
                    case "07":
                        mes1 = "Julio";//31 dias

                        break;
                    case "08":
                        mes1 = "Agosto";//31 dias

                        break;
                    case "09":
                        mes1 = "Septiembre";//30 dias

                        break;
                    case "10":
                        mes1 = "Octubre";//31 dias

                        break;
                    case "11":
                        mes1 = "Noviembre";//30 dias

                        break;
                    case "12":
                        mes1 = "Diciembre";//31 dias

                        break;
                }
                string fechaFacturaSolicitada = mes1 + " " + arreglo1[1];

                string consumo = misdatos.ClienteConsumoFactura(fechaFacturaSolicitada, direccion);
                string Total = misdatos.ClienteValorFactura(fechaFacturaSolicitada, direccion);
                if (consumo == null || Total == null)
                {
                    MessageBox.Show("No existe una factura para el mes solicitado");
                    return;
                }
                int totalnumerico = int.Parse(Total);
                int consumonumerico = int.Parse(consumo);
                int preciopormetronumero = totalnumerico / consumonumerico;
                string precioXmetro = preciopormetronumero.ToString();

                string ultimoDiaDelMes = "";
                string fechaNumerica = DateTime.Now.ToString("dd-MM-yyyy");
                string[] arreglo = fechaNumerica.Split('-');
                string mes = arreglo[1];

                switch (mes)
                {
                    case "01":
                        mes = "Enero"; //31 dias
                        ultimoDiaDelMes = "31";
                        break;
                    case "02":
                        mes = "Febrero";//28 dias
                        ultimoDiaDelMes = "28";
                        break;
                    case "03":
                        mes = "Marzo";//31 dias
                        ultimoDiaDelMes = "31";
                        break;
                    case "04":
                        mes = "Abril";//30 dias
                        ultimoDiaDelMes = "30";
                        break;
                    case "05":
                        mes = "Mayo";//31 dias
                        ultimoDiaDelMes = "31";
                        break;
                    case "06":
                        mes = "Junio";//30 dias
                        ultimoDiaDelMes = "30";
                        break;
                    case "07":
                        mes = "Julio";//31 dias
                        ultimoDiaDelMes = "31";
                        break;
                    case "08":
                        mes = "Agosto";//31 dias
                        ultimoDiaDelMes = "31";
                        break;
                    case "09":
                        mes = "Septiembre";//30 dias
                        ultimoDiaDelMes = "30";
                        break;
                    case "10":
                        mes = "Octubre";//31 dias
                        ultimoDiaDelMes = "31";
                        break;
                    case "11":
                        mes = "Noviembre";//30 dias
                        ultimoDiaDelMes = "30";
                        break;
                    case "12":
                        mes = "Diciembre";//31 dias
                        ultimoDiaDelMes = "31";
                        break;
                }
                string MesAño_Consumo = arreglo[0] + " / " + mes + " / " + arreglo[2];
                string qr = Application.StartupPath + @"\QrCode\" + misdatos.ClienteQRFactura(fechaFacturaSolicitada, direccion);
              

                //estilos CSS
                string h1 = "color: #646a9c;";
                string padding_left = "padding-left: 50px;";
                //estilos CSS

                StringBuilder sb = new StringBuilder();
                /////////////////////////////////////////HEADER///////////////////////////////////////////////////
                sb.Append("<header class='clearfix'>");
                sb.Append("<br>");
                sb.Append("<br>");
                sb.Append("<h1 style='" + h1 + padding_left + "'><strong>Factura</strong></h1>");
                sb.Append("<div style='" + padding_left + "'>");
                sb.Append("<h2 style='" + padding_left + "'>WaterComp</h2>");
                sb.Append("<br>");
                sb.Append("<div style='" + padding_left + "'>Carrera 29a # 5h-40,<br /> Paseo de la Italia, Palmira, Valle del cauca, Colombia</div>");
                sb.Append("<div style='" + padding_left + "'>+57(313)722-8485</div>");
                sb.Append("<div style='" + padding_left + "'>watercomp@hotmail.com</div>");
                sb.Append("</div>");
                sb.Append("<div id='project'>");
                sb.Append("<br>");
                sb.Append("<br>");
                sb.Append("<div style='" + padding_left + "'><strong>Cliente: </strong> " + cliente + "</div>");
                sb.Append("<div style='" + padding_left + "'><strong>Dirección: </strong> " + direccion + "</div>");
                sb.Append("<div style='" + padding_left + "'><strong>Email: </strong> " + mail + "</div>");
                sb.Append("<div style='" + padding_left + "'><strong>Fecha de Facturación: </strong> " + MesAño_Consumo + "</div>");
                sb.Append("<div style='" + padding_left + "'><strong>Fecha de vencimiento: </strong>" + ultimoDiaDelMes + " / " + mes + " / " + arreglo[2] + "</div>");
                sb.Append("<br>");
                sb.Append("<br>");
                sb.Append("</div>");
                sb.Append("</header>");
                /////////////////////////////////////////HEADER///////////////////////////////////////////////////

                sb.Append("<main>");
                /////////////////////////////////////////TABLE///////////////////////////////////////////////////
                sb.Append("<table style='" + padding_left + "'>");
                sb.Append("<thead>");
                sb.Append("<tr>");
                sb.Append("<strong><th class='service'>Servicio</th></strong>");
                sb.Append("<strong><th class='desc'>Consumo</th></strong>");
                sb.Append("<strong><th>Precio/M³</th></strong>");
                sb.Append("<strong><th>TOTAL</th></strong>");
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<tbody>");
                sb.Append("<tr>");
                sb.Append("<td class='service'>Consumo mensual de agua</td>");
                sb.Append("<td class='desc'>" + consumo + " M³</td>");
                sb.Append("<td class='qty'>" + precioXmetro + "</td>");
                sb.Append("<td class='total'>$" + Total + "</td>");
                sb.Append("</tr>");

                sb.Append("<tr>");
                sb.Append("<td> </td>");
                sb.Append("<td> </td>");
                sb.Append("<td> </td>");
                sb.Append("<td> </td>");
                sb.Append("</tr>");

                sb.Append("<tr>");
                sb.Append("<td><strong><h3>Total a pagar</h3></strong></td>");
                sb.Append("<td></td>");
                sb.Append("<td></td>");
                sb.Append("<td><h2><strong>$" + Total + "</strong></h2></td>");
                sb.Append("</tr>");

                sb.Append("</tbody>");
                sb.Append("</table>");
                sb.Append("<br>");
                sb.Append("<br>");
                sb.Append("<br>");
                sb.Append("<br>");
                sb.Append("<br>");
                /////////////////////////////////////////TABLE///////////////////////////////////////////////////
                sb.Append("<div style='" + padding_left + "'>");
                sb.Append("<p style='" + padding_left + "'>Firma del gerente:</p>");
                sb.Append("<img style='" + padding_left + "' src=\"https://derechovenezolano.files.wordpress.com/2020/04/firma.png?w=326\" alt=\"Logo\"width=\"150px\">");
                sb.Append("<img style='float:rigth;' src = '" + qr + "'>");
                sb.Append("</div>");
                sb.Append("</main>");
                /////////////////////////////////////////FOOTER///////////////////////////////////////////////////
                sb.Append("<footer>");
                sb.Append("<div style='" + padding_left + "'>Advertencia:</div>");
                sb.Append("<div style='" + padding_left + "'>Si despues de la fecha de vencimiento no se registra el pago, <strong> WATERCOMP S.A.S </strong> se verá obligado a suspender sus servicios. Muchas gracias</div>");
                sb.Append("</footer>");
                /////////////////////////////////////////FOOTER///////////////////////////////////////////////////

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Factura-" + cliente + " " + DateTime.Now.ToString("MM-dd-yyyy");
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

                            Image watermark = Image.GetInstance(Application.StartupPath + @"\UsersImage\" + "LogoSinFondo.png");

                            watermark.ScaleToFit(300, 300);

                            watermark.SetAbsolutePosition(300, 530);


                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                StringReader sr = new StringReader(sb.ToString());
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 30f, 30f);
                                HTMLWorker htmlparser = new HTMLWorker(pdfDoc);


                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();
                                pdfDoc.NewPage();
                                htmlparser.Parse(sr);
                                pdfDoc.Add(watermark);

                                pdfDoc.Close();
                                stream.Close();
                            }
                            DialogResult resul = MessageBox.Show("¿Desea enviar una copia de la factura al correo electrónico?", "Enviar Reporte", MessageBoxButtons.YesNo);
                            if (resul == DialogResult.Yes)
                            {
                                Form viajar = new Enviar_Reporte();
                                viajar.Show();
                                Enviar_Reporte.archivo = ReportUser;
                                Enviar_Reporte.type = "Factura";
                                Enviar_Reporte.cliente = cliente;

                            }
                            else
                            {
                                MessageBox.Show("Exportado correctamente");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtDocCliente_Leave(object sender, EventArgs e)
        {
            DatosBD misdatos = new DatosBD();
            this.TxtDireccion.Text = misdatos.ClienteDireccionFactura(txtDocCliente.Text);
            this.TxtNombre.Text = misdatos.ClienteNombreFactura(txtDocCliente.Text);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (Admin_Profile == true)
            {
                Form Usuarios = new Menu();
                Usuarios.Show();
                Admin_Profile = false;
                Digitador_Profile = false;
                Facturador_Profile = false;
                this.Hide();
            }
            if (Facturador_Profile == true)
            {
                Form Usuarios = new Menu_Facturador();
                Usuarios.Show();
                Admin_Profile = false;
                Digitador_Profile = false;
                Facturador_Profile = false;
                this.Hide();
            }
            if (Digitador_Profile == true)
            {
                Form Usuarios = new Menu_Digitador();
                Usuarios.Show();
                Admin_Profile = false;
                Digitador_Profile = false;
                Facturador_Profile = false;
                this.Hide();
            }
        }
    }
}
