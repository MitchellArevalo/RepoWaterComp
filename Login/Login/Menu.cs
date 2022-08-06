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
            Calcularlabel.Visible = true;
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
            Calcularlabel.Visible = false;
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
       
        private void Menu_Load(object sender, EventArgs e)
        {
                
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void ClientesLabel_Click(object sender, EventArgs e)
        {
           

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ;


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

        private void button1_Click(object sender, EventArgs e)
        {
            Form Inicio = new Login();
            Inicio.Show();

            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void panelclientes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UsuariosLabel_Click(object sender, EventArgs e)
        {
            Form Usuarios = new Usuarios();
            Usuarios.Show();

            this.Hide();

        }
    }
    
}
