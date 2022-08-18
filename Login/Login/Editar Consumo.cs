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
    public partial class Editar_Consumo : Form
    {
        public Editar_Consumo()
        {
            InitializeComponent();
        }
        public static string id_act;
        public static string consumo_act;
        public static string comentarios_act;
        public static string adress_act;
        public static string Estratosocialactual;
        public void llenarCampos(string departamento, string ciudad, string CodigoPredio, string Cliente, string Estrato)
        {
            this.txtciudad.Text = ciudad;
            this.txtdepartamento.Text = departamento;
            this.txtnamecliente.Text = Cliente;
            this.txtxcodigopredio.Text = CodigoPredio;
            Estratosocialactual = Estrato;
            
        }
        private void txtdireccion_Leave(object sender, EventArgs e)
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
        }

        private void Editar_Consumo_Load(object sender, EventArgs e)
        {
            this.txtdireccion.Text = adress_act;
            this.txtconsumo.Text = consumo_act;
            this.txtObservaciones.Text = comentarios_act;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(id_act);
                int valor = 0;
                int Consumo = 0;
                Consumo = int.Parse(txtconsumo.Text);
                if (txtnamecliente.Text == string.Empty || txtconsumo.Text == string.Empty || txtdireccion.Text == string.Empty || txtObservaciones.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                    return;
                }
                if (txtdireccion.Text != adress_act)
                {
                    DialogResult resul = MessageBox.Show("¿Esta seguro que desea cambiar la dirección de residencia?", "Cambiar dirección", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.No)
                    {
                        MessageBox.Show("Operación cancelada");
                        this.Hide();
                        return;
                    }
                }
                if (Estratosocialactual == "1")
                {
                    if (Consumo < 30)
                    {
                        valor = Consumo * 2000;
                    }
                    if (Consumo > 30)
                    {
                        valor = Consumo * 2500;
                    }
                }
                else if (Estratosocialactual == "2")
                {
                    if (Consumo < 30)
                    {
                        valor = Consumo * 3000;
                    }
                    if (Consumo > 30)
                    {
                        valor = Consumo * 4000;
                    }
                }
                try
                {
                    if (DatosBD.UpdateConsumo(ID, Consumo, txtdireccion.Text,valor,txtxcodigopredio.Text,txtnamecliente.Text,Estratosocialactual,txtObservaciones.Text,txtdepartamento.Text,txtciudad.Text) == false)
                    {
                        MessageBox.Show("Hubo un error al intentar actualizar el consumo");
                        return;
                    }
                    MessageBox.Show("Consumo actualizado");

                    this.Close();

                }
                catch (Exception re1)
                {
                    MessageBox.Show(re1.ToString());
                }
            }
            catch (Exception re)
            {
                MessageBox.Show(re.ToString());
            }
        }
        

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
