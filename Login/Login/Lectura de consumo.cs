using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Lectura_de_consumo : Form
    {
        public Lectura_de_consumo()
        {
            InitializeComponent();
        }

        private void HoraLabel_TextChanged(object sender, EventArgs e)
        {

        }
        public string Estratosocialactual;
        public void llenarCampos(string departamento, string ciudad, string CodigoPredio, string Cliente, string Estrato)
        {
            this.txtciudad.Text = ciudad;
            this.txtdepartamento.Text = departamento;
            this.txtnamecliente.Text = Cliente;
            this.txtxcodigopredio.Text = CodigoPredio;
            Estratosocialactual = Estrato;

        }
        private void btn_verificar_Click(object sender, EventArgs e)
        {


           
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form viajar = new Consumo_o_Registros();
            viajar.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string MesAño_Consumo, Direccion, CodigoPredio, Cliente, Estrato, Observaciones, Impreso, Departamento, Ciudad, QRruta;

            QRruta = "";
            string fechaNumerica = DateTime.Now.ToString("MM-yyyy");
            string[] arreglo = fechaNumerica.Split('-');
            string mes = arreglo[0];

            switch (mes)
            {
                case "01":
                    mes = "Enero";
                    break;
                case "02":
                    mes = "Febrero";
                    break;
                case "03":
                    mes = "Marzo";
                    break;
                case "04":
                    mes = "Abril";
                    break;
                case "05":
                    mes = "Mayo";
                    break;
                case "06":
                    mes = "Junio";
                    break;
                case "07":
                    mes = "Julio";
                    break;
                case "08":
                    mes = "Agosto";
                    break;
                case "09":
                    mes = "Septiembre";
                    break;
                case "10":
                    mes = "Octubre";
                    break;
                case "11":
                    mes = "Noviembre";
                    break;
                case "12":
                    mes = "Diciembre";
                    break;
            }
            int Consumo = 0;
            int Valor_Total = 0;

            MesAño_Consumo = mes + ' ' + arreglo[1];
            Consumo = int.Parse(txtconsumo.Text);
            Direccion = txtdireccion.Text;
            CodigoPredio = txtxcodigopredio.Text;
            Cliente = txtnamecliente.Text;
            Estrato = Estratosocialactual;
            Observaciones = txtObservaciones.Text;
            Impreso = "false";
            Departamento = txtdepartamento.Text;
            Ciudad = txtciudad.Text;
            if (Estrato == "1")
            {
                if (Consumo <= 30)
                {
                    Valor_Total = Consumo * 2000;
                }
                if (Consumo > 30)
                {
                    Valor_Total = Consumo * 2500;
                }
            }
            else if (Estrato == "2")
            {
                if (Consumo <= 30)
                {
                    Valor_Total = Consumo * 3000;
                }
                if (Consumo > 30)
                {
                    Valor_Total = Consumo * 4000;
                }
            }
            
            try
            {
                ConexionBD conex = new ConexionBD();
                string sql = "SELECT* FROM ConsumoTable WHERE Direccion = '" + txtdireccion.Text + "' AND MesAño_Consumo = '" + MesAño_Consumo + "'";
                SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    MessageBox.Show("Ya existe un registro de consumo para este cliente en este mes");
                    return;
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo conectar con la base de datos" + error);
                return;
            }
            //MessageBox.Show(Valor_Total.ToString());
            try
            {
                var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", Valor_Total, "150", "150");
                WebResponse response = default(WebResponse);
                Stream remoteStream = default(Stream);
                StreamReader readStream = default(StreamReader);
                WebRequest request = WebRequest.Create(url);
                response = request.GetResponse();
                remoteStream = response.GetResponseStream();
                readStream = new StreamReader(remoteStream);
                System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);
                img.Save(Application.StartupPath + @"\QrCode\" + Cliente + ".png");
                QRruta = Cliente + ".png";
                response.Close();
                remoteStream.Close();
                readStream.Close();
                //MessageBox.Show("QR generado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                ConexionBD con = new ConexionBD();
                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO ConsumoTable(MesAño_Consumo, Consumo, Direccion, Valor_Total, CodigoPredio, Cliente, Estrato, Observaciones, Impreso, Departamento, Ciudad, QRdireccion)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", MesAño_Consumo, Consumo, Direccion, Valor_Total, CodigoPredio, Cliente, Estrato, Observaciones, Impreso, Departamento, Ciudad, QRruta), con.conectar());

                comando.ExecuteNonQuery();

                con.desconectar();
                MessageBox.Show("Registro guardado exitosamente");

                DialogResult resul = MessageBox.Show("¿Desea realizar otro registro?", "Generar registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    Form viajar = new Lectura_de_consumo();
                    viajar.Show();
                    this.Hide();
                }
                else
                {
                    Form viajar = new Consumo_o_Registros();
                    viajar.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar el registro " + ex.ToString());
            }
           

        }

        private void txtdireccion_Leave(object sender, EventArgs e)
        {
            try
            {
                string depto;
                string Ciuda;
                string codP;
                string Client;
                string estrato;

                ConexionBD conex = new ConexionBD();
                string sql = "SELECT* FROM ClientesTable WHERE Direccion = '" + txtdireccion.Text + "'";
                SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    depto = leer["Departamento"].ToString();
                    Ciuda = leer["Ciudad"].ToString();
                    codP = leer["CodigoPredio"].ToString();
                    Client = leer["Nombre"].ToString();
                    estrato = leer["Estrato"].ToString();
                }
                else
                {
                    if (txtdireccion.Text != string.Empty)
                    {
                        MessageBox.Show("No se pudo encontrar un cliente con esa dirección");
                        return;
                    }
                    return;
                    
                }
                llenarCampos(depto, Ciuda, codP, Client, estrato);
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo conectar con la base de datos" + error);
                return;
            }
            try
            {
                string promedioconsumo;
                ConexionBD conex = new ConexionBD();
                string sql = "SELECT AVG(Consumo) AS PromedioConsumo FROM ConsumoTable WHERE Direccion = '" + txtdireccion.Text + "'";
                SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                SqlDataReader leer = comandocorreo.ExecuteReader();
                if (leer.Read() == true)
                {
                    promedioconsumo = leer["PromedioConsumo"].ToString();
                    this.txtConsumoAnterior.Text = promedioconsumo + " m³";
                }
                else
                {
                    this.txtConsumoAnterior.Text = "Este cliente no tiene consumos anteriores";
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar el consumo anterior");
            }
            string city = txtciudad.Text;
            string departamento = txtdepartamento.Text;
            string direccion = txtdireccion.Text;
            string[] arreglo = direccion.Split('#');
            string direccionArreglo = arreglo[0].ToString() + arreglo[1].ToString();
            try
            {
                StringBuilder queryaddress = new StringBuilder();

                queryaddress.Append("http://maps.google.com/maps?q=");
                if (direccionArreglo != string.Empty)
                {
                    queryaddress.Append(direccionArreglo + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                if (departamento != string.Empty)
                {
                    queryaddress.Append(departamento + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());



               
                this.btn_guardar.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al verificar el cliente " + error.ToString());
            }
        }
    }
}
