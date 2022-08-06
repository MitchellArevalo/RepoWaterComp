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
                    Form Menu = new Menu();
                    Menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son erroneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ingreso_Load(object sender, EventArgs e)
        {

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
                        Form Menu = new Menu();
                        Menu.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son erroneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
