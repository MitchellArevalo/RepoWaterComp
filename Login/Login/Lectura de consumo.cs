using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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


            try
            {
                string depto, Ciuda, codP, Client, estrato;

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
                    MessageBox.Show("No se pudo encontrar un cliente con esa dirección");
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



                this.btn_verificar.Visible = false;
                this.btn_guardar.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al verificar el cliente " + error.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form viajar = new Consumo_o_Registros();
            viajar.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string MesAño_Consumo, Direccion, CodigoPredio, Cliente, Estrato, Observaciones, Impreso, Departamento, Ciudad;
            
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
                if (Consumo < 30)
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
                if (Consumo < 30)
                {
                    Valor_Total = Consumo * 3000;
                }
                if (Consumo > 30)
                {
                    Valor_Total = Consumo * 4000;
                }
            }
            //MessageBox.Show(Valor_Total.ToString());
            try
            {
                ConexionBD con = new ConexionBD();
                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO ConsumoTable(MesAño_Consumo, Consumo, Direccion, Valor_Total, CodigoPredio, Cliente, Estrato, Observaciones, Impreso, Departamento, Ciudad)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", MesAño_Consumo, Consumo, Direccion, Valor_Total, CodigoPredio, Cliente, Estrato, Observaciones, Impreso, Departamento, Ciudad), con.conectar());

                comando.ExecuteNonQuery();

                con.desconectar();
                MessageBox.Show("Registro guardado exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar el registro " + ex.ToString());
            }
            
        }
    }
}
