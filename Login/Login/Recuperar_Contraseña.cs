using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Data.SqlClient;


namespace Login
{
    public partial class Recuperar_Contraseña : Form
    {
        public Recuperar_Contraseña()
        {
            InitializeComponent();
        }
               
        private void button2_Click(object sender, EventArgs e)
        {

            Form viajar = new ingreso();
            viajar.Show();

            this.Hide();
        }

        private void RecuperarPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string correo_recuperado;

                correo_recuperado = CorreoRecuperar.Text;
                DatosBD.EnviarCorreo(correo_recuperado, "null", "RecuperarContra");               

            }
            catch (Exception a)
            {
                
                MessageBox.Show(a.Message+a.StackTrace);
            }
        }

        private void CorreoRecuperar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recuperar_Contraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
