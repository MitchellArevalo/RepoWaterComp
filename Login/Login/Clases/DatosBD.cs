using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    internal class DatosBD
    {

        public static string username_session;

        //VALIDACIONES GLOBALES//
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
        public static void EnviarCorreo(string correo_recuperado, string path, string type)
        {
            string destinatario, user;
            destinatario = "";
            user = "";

            if (type == "Usuario")
            {
                ConexionBD conex = new ConexionBD();
                string sql = "SELECT* FROM UsersTable WHERE Correo_Electronico = '" + correo_recuperado + "'";
                SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                SqlDataReader leer = comandocorreo.ExecuteReader();
                if (leer.Read() == true)
                {
                    destinatario = leer["Correo_Electronico"].ToString();
                    user = leer["Usuario"].ToString();
                }
                else
                {
                    MessageBox.Show("El correo electrónico no se encuentra en el sistema");
                    return;
                }
                SendReportEmail(destinatario, user, path);
                return;
            }
            if (type == "Cliente")
            {
                ConexionBD conex = new ConexionBD();
                string sql = "SELECT* FROM UsersTable WHERE Correo_Electronico = '" + correo_recuperado + "'";
                SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                SqlDataReader leer = comandocorreo.ExecuteReader();
                if (leer.Read() == true)
                {
                    destinatario = leer["Correo_Electronico"].ToString();
                    user = leer["Usuario"].ToString();
                }
                else
                {
                    MessageBox.Show("El correo electrónico no se encuentra en el sistema");
                    return;
                }

                SendReportClientEmail(destinatario, user, path);
                return;
            }
            if (type == "RecuperarContra")
            {
                string contra;
                contra = "";
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

                SendMailRecuperarContra(destinatario, contra, user);

                return;
            }



        }


        //PERMISOS DE USUARIOS//
        public bool PermisosDeAdmin(string user)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Rol FROM UsersTable WHERE Usuario = '" + user + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string doc_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    doc_select = leer["Rol"].ToString();
                    if (doc_select == "Administrador")
                    {
                        return true;
                    }

                    conex.desconectar();

                }
            }

            return false;
        }
        public bool PermisosDeFacturador(string user)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Rol FROM UsersTable WHERE Usuario = '" + user + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string doc_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    doc_select = leer["Rol"].ToString();
                    if (doc_select == "Administrador")
                    {
                        return true;
                    }

                    conex.desconectar();

                }
            }

            return false;
        }
        public bool PermisosDeDigitador(string user)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Rol FROM UsersTable WHERE Usuario = '" + user + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string doc_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    doc_select = leer["Rol"].ToString();
                    if (doc_select == "Digitador")
                    {
                        return true;
                    }

                    conex.desconectar();

                }
            }

            return false;
        }


        //CRUD Usuarios//
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
                SqlCommand comandoeliminar = new SqlCommand(string.Format("DELETE UsersTable WHERE IdUsuarios = " + ID_eliminar ), bd.conectar());
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
            username_session = username;
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
        public bool validarDocumento(string Documento_identidad)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Documento FROM UsersTable WHERE Documento = '" + Documento_identidad + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string doc_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    doc_select = leer["Documento"].ToString();
                    if (Documento_identidad == doc_select)
                    {
                        MessageBox.Show("El documento de identidad " + Documento_identidad + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
        }
        public bool validarUsuario(string Usuario)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Usuario FROM UsersTable WHERE Usuario = '" + Usuario + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string data_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    data_select = leer["Usuario"].ToString();
                    if (Usuario == data_select)
                    {
                        MessageBox.Show("El nombre de usuario " + Usuario + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
        }
        public bool validarEmail(string Email)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Usuario FROM UsersTable WHERE Usuario = '" + Email + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string data_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    data_select = leer["Usuario"].ToString();
                    if (Email == data_select)
                    {
                        MessageBox.Show("El coreeo elecntrónico " + Email + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
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
            catch (Exception)
            {
                return null;
            }
        }
        public static void SendMailRecuperarContra(string correo, string contra, string user)
        { 

            string bodymessage =
               " <center><h1>¡Hola " + user + "!</ h1 >" +
               "<h2> Se ha hecho una solicitud para recuperar tu contraseña</h2>" +
               "<h2> tu contraseña es: " + contra + " </h2>" +
               "<strong><p> Att:</p></strong>" +
              "<img id=LogoAgua src=\"https://lh3.googleusercontent.com/jONhY5syUZpcJCTjbCe7uQI0antqANjjpUMY2LxDcFVSMfss4Y1YPIStVhQtGhBYl8PN=s85\" alt=\"Logo\"width=\"150px\"></center>";

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
        public static void SendReportEmail(string correo, string user, string path)
        {

            string bodymessage =
               " <center><h1>¡Hola " + user + "!</ h1 >" +
               "<h2> Comparto contigo el siguiente reporte generado en la fecha: " + DateTime.Now.ToString("MM-dd-yyyy") + "</h2>" +
               "<strong><p> Att:</p></strong>" +
               "<img id=LogoAgua src=\"https://lh3.googleusercontent.com/jONhY5syUZpcJCTjbCe7uQI0antqANjjpUMY2LxDcFVSMfss4Y1YPIStVhQtGhBYl8PN=s85\" alt=\"Logo\"width=\"150px\"></center>";

            try
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("mitchella2002@hotmail.es");
                message.To.Add(new MailAddress(correo));
                message.Subject = "Reporte Usuarios WaterComp";
                message.IsBodyHtml = true;
                message.Body = bodymessage;
                Attachment adjunto = new Attachment(path);
                message.Attachments.Add(adjunto);
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


        //CRUD CLIENTES//

        public DataTable listarClientes()
        {
            try
            {
                ConexionBD con1 = new ConexionBD();
                string sql = "SELECT * FROM ClientesTable";
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
        public DataTable listarClienteBuscado(string infoBuscada)
        {
            try
            {

                ConexionBD con1 = new ConexionBD();
                string sql = "SELECT * FROM ClientesTable WHERE Correo_Electronico LIKE '%" + infoBuscada + "%' OR Documento LIKE '%" + infoBuscada + "%' OR Nombre LIKE '%" + infoBuscada + "%' OR Estrato LIKE '%" + infoBuscada + "%' OR Active LIKE '%" + infoBuscada + "%' OR Direccion LIKE '%" + infoBuscada + "%'OR CodigoPredio LIKE '%" + infoBuscada + "%'";
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
        public void insertClientes(string nombre, string Documento_identidad, string Estrato, string CodigoPredio, string direccion, string correo, string activo)
        {

            ConexionBD con = new ConexionBD();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO ClientesTable(Nombre, Documento, Estrato, CodigoPredio, Direccion, Correo_Electronico, Active)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nombre, Documento_identidad, Estrato, CodigoPredio, direccion, correo, activo), con.conectar());

            comando.ExecuteNonQuery();

            con.desconectar();

        }
        public static bool UpdateClientes(int ID, string nombre, string Documento_identidad, string Estrato, string CodigoPredio, string direccion, string correo, string activo)
        {
            try
            {
                ConexionBD con = new ConexionBD();
                SqlCommand comando = new SqlCommand("Update ClientesTable set Documento=@Documento, Nombre=@Nombre, Estrato=@Estrato, CodigoPredio=@CodigoPredio, Direccion=@Direccion, Correo_Electronico=@Correo_Electronico, Active=@Active where IdCliente=@IdCliente", con.conectar());
                comando.Parameters.AddWithValue("@IdCliente", ID);
                comando.Parameters.AddWithValue("@Documento", Documento_identidad);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Estrato", Estrato);
                comando.Parameters.AddWithValue("@CodigoPredio", CodigoPredio);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Correo_Electronico", correo);
                comando.Parameters.AddWithValue("@Active", activo);
                comando.ExecuteNonQuery();
                con.desconectar();

                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool DeleteClient(string ID_eliminar)
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                SqlCommand comandoeliminar = new SqlCommand(string.Format("DELETE ClientesTable WHERE IdCliente = " + ID_eliminar ), bd.conectar());
                comandoeliminar.ExecuteNonQuery();
                bd.desconectar();

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool validarDocCliente(string Documento_identidad)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Documento FROM ClientesTable WHERE Documento = '" + Documento_identidad + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string doc_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    doc_select = leer["Documento"].ToString();
                    if (Documento_identidad == doc_select)
                    {
                        MessageBox.Show("El documento de identidad " + Documento_identidad + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
        }
        public bool validarPredio(string CodP)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT CodigoPredio FROM ClientesTable WHERE CodigoPredio = '" + CodP + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string CodP_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    CodP_select = leer["CodigoPredio"].ToString();
                    if (CodP == CodP_select)
                    {
                        MessageBox.Show("El codigo de predio " + CodP + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
        }
        public bool validarClientEmail(string Email)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Correo_Electronico FROM ClientesTable WHERE Correo_Electronico = '" + Email + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string Email_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    Email_select = leer["Correo_Electronico"].ToString();
                    if (Email == Email_select)
                    {
                        MessageBox.Show("El correo electrónico " + Email + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
        }
        public bool validarClientAdress(string Direccion)
        {
            ConexionBD conex = new ConexionBD();
            string sql = "SELECT Direccion FROM ClientesTable WHERE Direccion = '" + Direccion + "'";
            SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());

            SqlDataAdapter tabla = new SqlDataAdapter(comandocorreo);
            DataTable miTabla = new DataTable();

            tabla.Fill(miTabla);
            string Direccion_select;
            if (miTabla.Rows.Count > 0)
            {
                //MessageBox.Show(miTabla.Rows.Count.ToString());
                SqlDataReader leer = comandocorreo.ExecuteReader();

                if (leer.Read() == true)
                {
                    Direccion_select = leer["Direccion"].ToString();
                    if (Direccion == Direccion_select)
                    {
                        MessageBox.Show("La dirección " + Direccion + " ya existe en nuestro sistema");
                    }
                    conex.desconectar();

                    return false;

                }
            }

            return true;
        }
        public static void SendReportClientEmail(string correo, string user, string path)
        {

            string bodymessage =
               " <center><h1>¡Hola " + user + "!</ h1 >" +
               "<h2> Comparto contigo el siguiente reporte generado en la fecha: " + DateTime.Now.ToString("MM-dd-yyyy") + "</h2>" +
               "<strong><p> Att:</p></strong>" +
               "<img id=LogoAgua src=\"https://lh3.googleusercontent.com/jONhY5syUZpcJCTjbCe7uQI0antqANjjpUMY2LxDcFVSMfss4Y1YPIStVhQtGhBYl8PN=s85\" alt=\"Logo\"width=\"150px\"></center>";

            try
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("mitchella2002@hotmail.es");
                message.To.Add(new MailAddress(correo));
                message.Subject = "Reporte Clientes WaterComp";
                message.IsBodyHtml = true;
                message.Body = bodymessage;
                Attachment adjunto = new Attachment(path);
                message.Attachments.Add(adjunto);
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

    }
}
