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
    public partial class Consumo_o_Registros : Form
    {
        public Consumo_o_Registros()
        {
            InitializeComponent();
        }
        public static bool Admin_Profile;
        public static bool Digitador_Profile;
        public static bool Facturador_Profile;
        private void Btn_Lectura_Click(object sender, EventArgs e)
        {
            Form Viajar = new Lectura_de_consumo();
            Viajar.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Btn_consumo_Click(object sender, EventArgs e)
        {
            Form Viajar = new Consumos();
            Viajar.Show();

            this.Hide();
        }

        private void Consumo_o_Registros_Load(object sender, EventArgs e)
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
    }
}
