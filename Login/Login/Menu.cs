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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }
        public static bool Admin_Profile;
        public static bool Digitador_Profile;
        public static bool Facturador_Profile;
        private void Menu_Load(object sender, EventArgs e)
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
        private void label4_Click(object sender, EventArgs e)
        {
            //ACERCA DE
            Form Viajar = new Acerca_de();
            Viajar.Show();

            this.Hide();
        }
        private void ClientesLabel_Click(object sender, EventArgs e)
        {
            //CLIENTES
            Form viajar = new Clientes();
            viajar.Show();

            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //LOGIN
            Form Inicio = new Login();
            Inicio.Show();
            Admin_Profile = false;
            Digitador_Profile = false;
            Facturador_Profile = false;

            this.Hide();
        }
        //IMPRIMIR FACTURA
        private void Imprimirlabel_Click(object sender, EventArgs e)
        {
            Form viajar = new Imprimir_Factura();
            viajar.Show();

            this.Hide();
        }
        private void UsuariosLabel_Click(object sender, EventArgs e)
        {
            //USUARIOS


            Form Usuarios = new Usuarios();
            Usuarios.Show();

            this.Hide();

        }
        private void Calcularlabel_Click(object sender, EventArgs e)
        {
            //CONSUMO
            Form viajar = new Consumo_o_Registros();
            viajar.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void Calcularlabel_DragLeave(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void panelclientes_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panelclientes.Visible = true;
            ClientesLabel.Visible = true;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            UsuariosLabel.Visible = true;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;
            label4.Visible = true;
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Consumolabel.Visible = true;
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Imprimirlabel.Visible = true;
        }
        private void ClientesLabel_MouseHover(object sender, EventArgs e)
        {

        }
        private void panelclientes_MouseLeave(object sender, EventArgs e)
        {
            panelclientes.Visible = false;
            ClientesLabel.Visible = false;
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            UsuariosLabel.Visible = false;
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Consumolabel.Visible = false;
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Imprimirlabel.Visible = false;
        }
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            label4.Visible = false;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }
        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }


    }

}
