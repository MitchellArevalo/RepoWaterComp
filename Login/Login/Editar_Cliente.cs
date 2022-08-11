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
    public partial class Editar_Cliente : Form
    {
        public Editar_Cliente()
        {
            InitializeComponent();
        }
        public static string id_buscado, doc, name, mail, predio, direcc, Estrato_p, rolUpdate;
        public static bool activo = false;
        public static void llenarCamposEditables(string id, string nombre, string Documento_identidad, string Estrato, string CodP, string Direccion, string correo, string active)
        { //llenarCamposEditables(id,nombre,Documento_identidad,Estrato, CodP, Direccion,correo,active);
            id_buscado = id;
            doc = Documento_identidad;
            name = nombre;
            mail = correo;
            Estrato_p = Estrato;
            predio = CodP;
            direcc = Direccion;
            if (active == "True")
            {
                activo = true;
            }
            else
            {
                activo = false;
            }

        }
        private void Editar_Cliente_Load(object sender, EventArgs e)
        {
            this.txt_documento.Text = doc;
            this.txt_nombre.Text = name;
            this.txtx_codpredio.Text = predio;
            this.txt_email.Text = mail;
            this.txt_direccion.Text = direcc;
            this.estratobox.Text = Estrato_p;
            this.ActiveCheckbox.Checked = activo;
            
        }

        
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            try
            {
                bool validado = true;
                DatosBD validaciones = new DatosBD();
                if (txt_documento.Text != doc)
                {
                    validado = validaciones.validarDocCliente(txt_documento.Text);
                }
                if (txtx_codpredio.Text != predio)
                {
                    validado = validaciones.validarPredio(txtx_codpredio.Text);
                }
                if (txt_email.Text != mail)
                {
                    validado = validaciones.validarClientEmail(txt_email.Text);
                }
                if (txt_direccion.Text != direcc)
                {
                    validado = validaciones.validarClientAdress(txt_direccion.Text);
                }
                if (validado == false)
                {
                    return;
                }
                int ID = int.Parse(id_buscado);
                if (txt_documento.Text == string.Empty || txt_nombre.Text == string.Empty || estratobox.Text.Length == 0 || txt_email.Text == string.Empty || txt_direccion.Text == string.Empty || txtx_codpredio.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                    return;
                }

                string activeclient;

                if (ActiveCheckbox.Checked == true)
                {
                    activeclient = "True";
                }
                else
                {
                    activeclient = "False";
                }
                if (DatosBD.ComprobarFormatoEmail(txt_email.Text) == false)
                {
                    MessageBox.Show("El correo electrónico no existe");
                    txt_email.Text = "Dirección no valida";
                    txt_email.ForeColor = Color.Red;
                    return;
                }

                try
                {
                    if (DatosBD.UpdateClientes(ID, txt_nombre.Text, txt_documento.Text, estratobox.Text, txtx_codpredio.Text, txt_direccion.Text, txt_email.Text, activeclient) == false)
                    {
                        MessageBox.Show("Hubo un error al intentar actualizar el usuario");
                        return;
                    }
                    MessageBox.Show("Usuario actualizado");
                    this.Close();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al intentar actualizar el usuario " + ex);
                }



            }
            catch (SqlException ex1)
            {

                MessageBox.Show("Error Generated. Details: " + ex1.ToString());
            }
        }
    }
}
