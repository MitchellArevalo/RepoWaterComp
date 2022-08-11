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
    public partial class agregar_Cliente : Form
    {
        public agregar_Cliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_documento.Text == string.Empty || txt_nombre.Text == string.Empty || estratobox.Text.Length == 0 || txt_email.Text == string.Empty || txt_direccion.Text == string.Empty || txtx_codpredio.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                }
                else
                {
                    string nombre, Documento_identidad, Direccion,correo, activo, Estrato, CodP;

                    nombre = txt_nombre.Text;
                    Documento_identidad = txt_documento.Text;
                    Estrato = estratobox.Text;
                    CodP = txtx_codpredio.Text;
                    correo = txt_email.Text;
                    Direccion = txt_direccion.Text;
                    activo = "";
                    
                    if (ActiveCheckbox.Checked == true)
                    {
                        activo = "True";
                    }
                    else
                    {
                        activo = "False";
                    }

                    ConexionBD conex = new ConexionBD();
                    string sql = "SELECT* FROM ClientesTable WHERE Correo_Electronico = '" + correo + "' OR Documento = '" + Documento_identidad + "'OR Direccion = '" + Direccion + "'OR CodigoPredio = '" + CodP + "'";
                    SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                    SqlDataReader leer = comandocorreo.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        correo = leer["Correo_Electronico"].ToString();
                        if (correo == txt_email.Text)
                        {
                            MessageBox.Show("El correo electrónico " + correo + " ya existe en nuestro sistema");
                            this.txt_email.Clear();
                        }

                        Documento_identidad = leer["Documento"].ToString();
                        if (Documento_identidad == txt_documento.Text)
                        {
                            MessageBox.Show("El documento de identidad " + Documento_identidad + " ya existe en nuestro sistema");
                            this.txt_documento.Clear();
                        }

                        Direccion = leer["Direccion"].ToString();
                        if (Direccion == txt_direccion.Text)
                        {
                            MessageBox.Show("La dirección " + Direccion + " ya existe en nuestro sistema");
                            this.txt_direccion.Clear();
                        }
                        CodP = leer["CodigoPredio"].ToString();
                        if (CodP == txtx_codpredio.Text)
                        {
                            MessageBox.Show("El codigo de predio " + CodP + " ya se encuentra en nuestro sistema");
                            this.txtx_codpredio.Clear();
                        }
                        conex.desconectar();
                    }
                    else
                    {

                        conex.desconectar();

                        try
                        {

                            if (DatosBD.ComprobarFormatoEmail(correo) == false)
                            {
                                MessageBox.Show("El correo electrónico no existe");
                                txt_email.Text = "Dirección no valida";
                                txt_email.ForeColor = Color.Red;
                                return;
                            }

                            DatosBD misdatos = new DatosBD();
                            misdatos.insertClientes(txt_nombre.Text, txt_documento.Text, Estrato, CodP, txt_direccion.Text, txt_email.Text, activo);
                        }
                        catch (Exception exxx)
                        {
                            MessageBox.Show("Ocurrió un error al guardar el cliente " + exxx.ToString());
                            return;
                        }
                        MessageBox.Show("Usuario creado con exito");
                        this.txt_documento.Clear();
                        this.txt_nombre.Clear();
                        this.txt_email.Clear();
                        this.txtx_codpredio.Clear();
                        this.txt_direccion.Clear();
                        this.estratobox.Text = null;
                        this.Close();
                    }
                }
            }
            catch (SqlException ex1)
            {
                MessageBox.Show("Error al intentar crear el cliente " + ex1.ToString());
            }
            
        }

        private void agregar_Cliente_Load(object sender, EventArgs e)
        {
            this.estratobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void estratobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtx_codpredio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ActiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
