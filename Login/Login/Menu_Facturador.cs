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
    public partial class Menu_Facturador : Form
    {
        public Menu_Facturador()
        {
            InitializeComponent();
        }
        public static bool Admin_Profile;
        public static bool Digitador_Profile;
        public static bool Facturador_Profile;

        private void Menu_Facturador_Load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            //LOGIN
            Form Inicio = new Login();
            Inicio.Show();
            ingreso.Admin_Profile = false;
            ingreso.Digitador_Profile = false;
            ingreso.Facturador_Profile = false;

            this.Hide();
        }

        private void Imprimirlabel_Click(object sender, EventArgs e)
        {
            Form viajar = new Imprimir_Factura();
            viajar.Show();

            this.Hide();
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Imprimirlabel.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Imprimirlabel.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;
            label4.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //ACERCA DE
            Form Viajar = new Acerca_de();
            Viajar.Show();

            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }
    }
}
