using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class agregar_usuario : Form
    {
        public agregar_usuario()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }
        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void CheckContra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckContra.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            } else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
        
        
        string ImgLocation = "NOGUARDANADANUEVO";
        private void Img_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG)|*.BMP;*.JPG;*.GIF;*.JPEG|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                ImgLocation = openFileDialog1.FileName;
            }
        }


        private void btn_guardar_usuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_documento.Text == string.Empty || txt_nombre.Text == string.Empty || checkedListBox1.SelectedItems.Count == 0 || txt_email.Text == string.Empty || txt_password.Text == string.Empty || txt_username.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                }
                else
                {

                    string Documento_identidad, nombre, correo, contra, user, rol, activo, imagen;


                    Documento_identidad = txt_documento.Text;
                    nombre = txt_nombre.Text;
                    correo = txt_email.Text;
                    rol = checkedListBox1.SelectedItem.ToString();
                    contra = txt_password.Text;
                    user = txt_username.Text;
                    activo = "";
                    imagen = Path.GetFileName(pictureBox1.ImageLocation);
                    if (ActiveCheckbox.Checked == true)
                    {
                        activo = "True";
                    }
                    else
                    {
                        activo = "False";
                    }

                    ConexionBD conex = new ConexionBD();
                    string sql = "SELECT* FROM UsersTable WHERE Correo_Electronico = '" + correo + "' OR Documento = '" + Documento_identidad + "'OR Usuario = '" + user + "'OR Foto_Ubicacion = '" + imagen + "'";
                    SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                    SqlDataReader leer = comandocorreo.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        correo = leer["Correo_Electronico"].ToString();
                        if (correo == txt_email.Text)
                        {
                            MessageBox.Show("El correo electrónico " + correo + " ya existe en nuestro sistema");
                            this.txt_email.Clear();
                        }

                        Documento_identidad = leer["Documento"].ToString();
                        if (Documento_identidad == txt_documento.Text)
                        {
                            MessageBox.Show("El documento de identidad " + Documento_identidad + " ya existe en nuestro sistema");
                            this.txt_documento.Clear();
                        }

                        user = leer["Usuario"].ToString();
                        if (user == txt_username.Text)
                        {
                            MessageBox.Show("El nombre de usuario " + user + " ya existe en nuestro sistema");
                            this.txt_username.Clear();
                        }
                        imagen = leer["Foto_Ubicacion"].ToString();
                        if (imagen == Path.GetFileName(pictureBox1.ImageLocation))
                        {
                            MessageBox.Show("La foto de perfil ya se encuentra en nuestro sistema");
                            this.pictureBox1.Image = null;
                        }
                        conex.desconectar();
                    }
                    else
                    {

                        conex.desconectar();
                        
                        try
                        {
                            
                            if (DatosBD.ComprobarFormatoEmail(correo) == false)
                            {
                                MessageBox.Show("El correo electrónico no existe");
                                txt_email.Text = "Dirección no valida";
                                txt_email.ForeColor = Color.Red;
                                return;
                            }
                        
                            if (ImgLocation == "NOGUARDANADANUEVO")
                            {
                                MessageBox.Show("Debe seleccionar una foto de perfil");
                                return;
                            }
                            
                            File.Copy(ImgLocation, Application.StartupPath + @"\UsersImage\" + Path.GetFileName(pictureBox1.ImageLocation));

                            DatosBD misdatos = new DatosBD();
                            misdatos.insertUsuarios(Documento_identidad, nombre,correo, rol, contra, user, imagen, activo);
                        }
                        catch (Exception exxx)
                        {
                            MessageBox.Show("Ocurrió un error al guardar el usuario " + exxx.ToString());
                            return;
                        }
                        MessageBox.Show("Usuario creado con exito");
                        this.txt_documento.Clear();
                        this.txt_nombre.Clear();
                        this.txt_email.Clear();
                        this.txt_password.Clear();
                        this.txt_username.Clear();
                        this.pictureBox1.Image = null;
                        this.Close();
                    }
                }
            }
            catch (SqlException ex1)
            {
                MessageBox.Show("Error al intentar crear el usuario " + ex1.ToString());
            }
        }

        private void Expandir_Checkbox_CheckedChanged(object sender, EventArgs e)
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

        private void agregar_usuario_Load(object sender, EventArgs e)
        {
           

        }

        private void list_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void txt_documento_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ActiveCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

