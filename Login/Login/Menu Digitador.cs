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
    public partial class Menu_Digitador : Form
    {
        public Menu_Digitador()
        {
            InitializeComponent();
        }
        public static bool Admin_Profile;
        public static bool Digitador_Profile;
        public static bool Facturador_Profile;
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;
            label4.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            label4.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //ACERCA DE
            Form Viajar = new Acerca_de();
            Viajar.Show();

            this.Hide();
        }

        private void Consumolabel_Click(object sender, EventArgs e)
        {
            //CONSUMO
            Form viajar = new Consumo_o_Registros();
            viajar.Show();

            this.Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Consumolabel.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Consumolabel.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LOGIN
            Form Inicio = new Login();
            Inicio.Show();
            ingreso.Digitador_Profile = false;
            ingreso.Admin_Profile = false;
            ingreso.Facturador_Profile = false;

            this.Hide();
        }
    }
}
