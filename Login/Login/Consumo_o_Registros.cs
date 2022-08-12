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

        private void Btn_Lectura_Click(object sender, EventArgs e)
        {
            Form Viajar = new Lectura_de_consumo();
            Viajar.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Viajar = new Menu();
            Viajar.Show();

            this.Hide();
        }
    }
}
