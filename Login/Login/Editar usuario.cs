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
using System.IO;

namespace Login
{
    public partial class Editar_usuario : Form
    {
        public Editar_usuario()
        {
            InitializeComponent();
        }
        public static string id_buscado, doc, name, mail, password, usuario, Ruta_Imagen, rol_p, rolUpdate;
        public static bool activo = false;
        
        
        string ruta = "NOGUARDANADANUEVO";

        public static void llenarCamposEditables(string id, string Documento_identidad, string nombre, string correo, string contra, string user, string rol, string Foto, string activousuario) { 
            id_buscado = id;
            doc = Documento_identidad;
            name = nombre;
            mail = correo;
            rol_p = rol;
            password = contra;
            usuario = user;
            Ruta_Imagen = Foto;
            if (activousuario == "True")
            {
                activo = true;
            }
            else
            {
                activo = false;
            }
            
        }

        private void Expandir_Checkbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Expandir_Checkbox.Checked == true)
            {
                checkedListBox1.Size = new Size(332, 82);
            }
            else
            {
                checkedListBox1.Size = new Size(332, 29);
            }
        }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Editar_usuario_Load(object sender, EventArgs e)
        {
            this.txt_documento.Text = doc;
            this.txt_nombre.Text = name;
            this.txt_email.Text = mail;
            if (rol_p == "Administrador")
            {
                checkedListBox1.Items.Add("Administrador", true);
                checkedListBox1.Items.Add("Digitador");
                checkedListBox1.Items.Add("Facturador");
            }
            else
            {
                if (rol_p == "Digitador")
                {
                    checkedListBox1.Items.Add("Administrador");
                    checkedListBox1.Items.Add("Digitador", true);
                    checkedListBox1.Items.Add("Facturador");
                }
                else
                {
                    if (rol_p == "Facturador")
                    {
                        checkedListBox1.Items.Add("Administrador");
                        checkedListBox1.Items.Add("Digitador");
                        checkedListBox1.Items.Add("Facturador", true);

                    }
                }
            }
            this.txt_password.Text = password;
            this.txt_username.Text = usuario;
            this.ActiveCheckbox.Checked = activo;
            pictureBox1.ImageLocation = Application.StartupPath + @"\UsersImage\" + Ruta_Imagen;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
                
            
        }

        private void Img_Button_Click(object sender, EventArgs e)
        {



            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                ruta = openFileDialog1.FileName;

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void btn_guardar_usuario_Click(object sender, EventArgs e)
        {
            
            string Documento, Nombre, Usuario, Email, foto, contraseña;

            Documento = txt_documento.Text;
            Nombre = txt_nombre.Text;
            Usuario = txt_username.Text;
            Email = txt_email.Text;
            foto = Path.GetFileName(pictureBox1.ImageLocation);
            contraseña = txt_password.Text;
            try
            {
                bool validado = true;
                DatosBD validaciones = new DatosBD();
                if (txt_documento.Text != doc )
                {
                    validado = validaciones.validarDocumento(Documento);
                }
                if (txt_username.Text != usuario)
                {
                    validado = validaciones.validarUsuario(Usuario);
                }
                if (txt_email.Text != mail)
                {
                    validado = validaciones.validarEmail(Email);
                }
                if (validado == false)
                {
                    return;
                }
                int ID = int.Parse(id_buscado);
                if (txt_documento.Text == string.Empty || txt_nombre.Text == string.Empty || checkedListBox1.Items.Count == 0 || txt_email.Text == string.Empty || txt_password.Text == string.Empty || txt_username.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                    return;
                }

                if (checkedListBox1.CheckedItems.Count > 1)
                {
                    MessageBox.Show("No se puede seleccionar más de un rol");
                    return;
                }
                string activeuser;

                foreach(var item in checkedListBox1.CheckedItems)
                {
                    rolUpdate = item.ToString();
                    
                }

                if (ActiveCheckbox.Checked == true)
                {
                    activeuser = "True";
                }
                else
                {
                    activeuser = "False";
                }
                if (DatosBD.ComprobarFormatoEmail(Email) == false)
                {
                    MessageBox.Show("El correo electrónico no existe");
                    txt_email.Text = "Dirección no valida";
                    txt_email.ForeColor = Color.Red;
                    return;
                }

                try
                {
                    if(DatosBD.UpdateUsuarios(ID, Documento, Nombre, Usuario, rolUpdate, contraseña, Email, foto, activeuser) == false)
                    {
                        MessageBox.Show("Hubo un error al intentar actualizar el usuario");
                        return;
                    }
                MessageBox.Show("Usuario actualizado");
                if (ruta != "NOGUARDANADANUEVO")
                {
                    File.Copy(ruta, Application.StartupPath + @"\UsersImage\" + Path.GetFileName(pictureBox1.ImageLocation));
                }
                this.Close();
                Usuarios updateTable = new Usuarios();
                updateTable.refrescar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al intentar actualizar el usuario " + ex); 
                }

                
                
            }
            catch (SqlException ex1)
            {
                
                MessageBox.Show("Error Generated. Details: " + ex1.ToString());
            }
        }

        private void CheckContra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckContra.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }


    }
}
