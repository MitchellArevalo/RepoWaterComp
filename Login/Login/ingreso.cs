using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }
        public static bool Admin_Profile = false;
        public static bool Digitador_Profile = false;
        public static bool Facturador_Profile = false;
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form Form1 = new Login();
            Form1.Show();
            this.Hide();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string username, password;

            username = Username_Text_Box.Text;
            password = Password_TextBox.Text;

            try
            {
                ConexionBD connection = new ConexionBD();

                DatosBD datos = new DatosBD();
                bool validado = datos.validarInicioDeSesion(username, password);

                if (validado == true)
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
                    if (Admin_Profile == true)
                    {
                        Form Usuarios = new Menu();
                        Usuarios.Show();

                        this.Hide();
                        return;
                    }
                    if (Facturador_Profile == true)
                    {
                        Form Usuarios = new Menu_Facturador();
                        Usuarios.Show();

                        this.Hide();
                        return;
                    }
                    if (Digitador_Profile == true)
                    {
                        Form Usuarios = new Menu_Digitador();
                        Usuarios.Show();

                        this.Hide();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son erroneos o el usuario se encuentra inactivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username_Text_Box.Clear();
                    Password_TextBox.Clear();
                    Username_Text_Box.Focus();
                }
                connection.desconectar();
            }
            catch (Exception error)
            {
                MessageBox.Show("Inicio de sesion invalido " + error.ToString());
            }

        }

        private void ingreso_Load(object sender, EventArgs e)
        {
            Admin_Profile = false;
            Digitador_Profile = false;
            Facturador_Profile = false;
        }

        private void BtnIngresar_Enter(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string username, password;

                username = Username_Text_Box.Text;
                password = Password_TextBox.Text;


                try
                {
                    ConexionBD connection = new ConexionBD();

                    DatosBD datos = new DatosBD();
                    bool validado = datos.validarInicioDeSesion(username, password);

                    if (validado == true)
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
                        if (Admin_Profile == true)
                        {
                            Form Usuarios = new Menu();
                            Usuarios.Show();

                            this.Hide();
                            return;
                        }
                        if (Facturador_Profile == true)
                        {
                            Form Usuarios = new Menu_Facturador();
                            Usuarios.Show();

                            this.Hide();
                            return;
                        }
                        if (Digitador_Profile == true)
                        {
                            Form Usuarios = new Menu_Digitador();
                            Usuarios.Show();

                            this.Hide();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son erroneos o el usuario se encuentra inactivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Username_Text_Box.Clear();
                        Password_TextBox.Clear();
                        Username_Text_Box.Focus();
                    }
                    connection.desconectar();
                }
                catch
                {
                    MessageBox.Show("Inicio de sesion invalido");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form viaje = new Recuperar_Contraseña();
            viaje.Show();

            this.Hide();
        }

        private void Label_Password_Click(object sender, EventArgs e)
        {

        }

        private void Label_Username_Click(object sender, EventArgs e)
        {

        }

        private void Username_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
