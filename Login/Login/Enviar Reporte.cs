using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Enviar_Reporte : Form
    {
        public Enviar_Reporte()
        {
            InitializeComponent();
        }
        public static string archivo;
        public static string type;
        private void RecuperarPassword_Click(object sender, EventArgs e)
        {
            string correo;
            correo = CorreoRecuperar.Text;
            if (type == "Usuario")
            {
                DatosBD.EnviarCorreo(correo, archivo, "Usuario");
                this.Close();
                
                return;
            }
            if (type == "Cliente")
            {
                DatosBD.EnviarCorreo(correo, archivo, "Cliente");
                this.Close();
                
                return;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Enviar_Reporte_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
