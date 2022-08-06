using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    internal class DatosBD
    {
        public void insertUsuarios(string Documento_identidad, string nombre, string correo, string rol, string contra, string user, string imagen, string activo)
        {

            ConexionBD con = new ConexionBD();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO UsersTable(Documento, Nombre, Usuario, Rol, Password, Correo_Electronico, Foto_Ubicacion, Active)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Documento_identidad, nombre, user, rol, contra, correo, imagen, activo), con.conectar());

            comando.ExecuteNonQuery();

            con.desconectar();


        }
        public  static bool UpdateUsuarios(int ID, string Documento, string Nombre, string Usuario, string rolUpdate, string contraseña, string mail,string foto,string activeuser)
        {
            try
            {
                ConexionBD con = new ConexionBD();
                SqlCommand comando = new SqlCommand("Update UsersTable set Documento=@Documento, Nombre=@Nombre, Usuario=@Usuario, Rol=@Rol, Password=@Password, Correo_Electronico=@Correo_Electronico, Foto_Ubicacion=@Foto_Ubicacion, Active=@Active where IdUsuarios=@IdUsuarios", con.conectar());
                comando.Parameters.AddWithValue("@IdUsuarios", ID);
                comando.Parameters.AddWithValue("@Documento", Documento);
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Rol", rolUpdate);
                comando.Parameters.AddWithValue("@Password", contraseña);
                comando.Parameters.AddWithValue("@Correo_Electronico", mail);
                comando.Parameters.AddWithValue("@Foto_Ubicacion", foto);
                comando.Parameters.AddWithValue("@Active", activeuser);
                comando.ExecuteNonQuery();
                con.desconectar();
               
            return true;

            }
            catch (Exception)
            {
            return false;
            }
           
            
        }
        public bool DeleteUser(string ID_eliminar)
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                SqlCommand comandoeliminar = new SqlCommand(string.Format("DELETE UsersTable WHERE IdUsuarios = " + ID_eliminar), bd.conectar());
                comandoeliminar.ExecuteNonQuery();
                bd.desconectar();

                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public bool validarInicioDeSesion(string username, string password)
        {
            bool ingresoExitoso;

            ConexionBD connection = new ConexionBD();
            string validar = "SELECT * FROM UsersTable WHERE Usuario = '" + username + "' AND Password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(validar, connection.conectar());

            DataTable DB = new DataTable();
            sda.Fill(DB);
            if (DB.Rows.Count > 0)
            {
                ingresoExitoso = true;
            }
            else
            {
                ingresoExitoso = false;
            }
            connection.desconectar();

            return ingresoExitoso;
        }
       
        public DataTable listarConFoto()
        {
            try
            {
                ConexionBD conn = new ConexionBD();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM UsersTable"), conn.conectar());
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    row["Foto"] = File.ReadAllBytes(Application.StartupPath + @"\UsersImage\" + Path.GetFileName(row["Foto_Ubicacion"].ToString()));

                }
                conn.desconectar();
                return dt;
                
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable listar()
        {
            try
            {
                ConexionBD con1 = new ConexionBD();
                string sql = "SELECT * FROM UsersTable";
                Console.WriteLine(sql);
                SqlCommand comando = new SqlCommand(sql, con1.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con1.desconectar();

                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }
       
        public DataTable listarBuscado(string infoBuscada)
        {
            try
            {
                ConexionBD conn = new ConexionBD();
                string query = "SELECT * FROM UsersTable WHERE Correo_Electronico LIKE '%" + infoBuscada + "%' OR Documento LIKE '%" + infoBuscada + "%' OR Nombre LIKE '%" + infoBuscada + "%' OR Rol LIKE '%" + infoBuscada + "%'OR Usuario LIKE '%" + infoBuscada + "%'";
                SqlCommand cmd = new SqlCommand(query, conn.conectar());
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    row["Foto"] = File.ReadAllBytes(Application.StartupPath + @"\UsersImage\" + Path.GetFileName(row["Foto_Ubicacion"].ToString()));

                }
                return dt;


            }
            catch (Exception ee)
            {
                return null;
            }
        }
        public static void correoRecuperarContra(string correo_recuperado)
        {
            string destinatario, contra, user;
            destinatario = "";
            contra = "";
            user = "";

            ConexionBD conex = new ConexionBD();
            string sql = "SELECT* FROM UsersTable WHERE Correo_Electronico = '" + correo_recuperado + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
            SqlDataReader leer = comandocorreo.ExecuteReader();
            if (leer.Read() == true)
            {
                destinatario = leer["Correo_Electronico"].ToString();
                contra = leer["Password"].ToString();
                user = leer["Usuario"].ToString();
            }
            else
            {
                MessageBox.Show("El correo electrónico no se encuentra en el sistema");
            }

            SendMail(destinatario, contra, user);

        }
        public static void SendMail(string correo, string contra, string user)
        {

            string bodymessage =
               " <center><h1>¡Hola " + user + "!</ h1 >" +
               "<h2> Se ha hecho una solicitud para recuperar tu contraseña</h2>" +
               "<h2> tu contraseña es: " + contra + " </h2>" +
               "<strong><p> Att:</p></strong>" +
               "<img id=LogoAgua src=\"https://franchiasoc.com.ar/ecoblogger/cuidemos-el-agua/cuidemos-el-agua.jpg\" alt=\"Logo\"></center>";


            try
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("mitchella2002@hotmail.es");
                message.To.Add(new MailAddress(correo));
                message.Subject = "Recuperación de contraseña";
                message.IsBodyHtml = true;
                message.Body = bodymessage;
                smtp.Port = 587;
                smtp.Host = "smtp.office365.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("mitchella2002@hotmail.es", "andru3005");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("El correo se ha enviado correctamente a la dirección " + correo);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar el correo electronico" + ex);


            }
        }
        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        { 
            String sFormato; 
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato)) 
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0) 
                { 
                    return true; 
                } 
                else
                { 
                    return false; 
                } 
            } 
            else
            { 
                return false;
            }
        }


    }
}
