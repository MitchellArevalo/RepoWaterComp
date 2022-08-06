using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login
{
    class ConexionBD
    {

        public SqlConnection conectionlink = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");

        public SqlConnection conectar()
        {
            try
            {
                conectionlink.Open();
                return conectionlink;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public bool desconectar()
        {
            try
            {
                conectionlink.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
