using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class borrador
    {
        /*class Program
        {
            static void Main(string[] args)
            {
                string connectionString = "Server=.;Database=blobstore;Trusted_Connection=True;";

                int id = 1;
                string name = @"C:\source\a.jpg";
                byte[] blob = File.ReadAllBytes(name); 
                int len = blob.Length;

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var cmd = new SqlCommand();

                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;

                    //USE [blobstore]
                    //GO

                    //CREATE TABLE [dbo].[store](
                    //    [id] [int] NOT NULL,
                    //    [name] [nvarchar](2000) NULL,
                    //    [blob] [varbinary](max) NULL,
                    //    [length] [int] NULL
                    //) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

                    //GO

                    cmd.CommandText = "insert into store (id, name, blob, length) values (@id, @name, @blob, @length)";

                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@blob", SqlDbType.VarBinary).Value = blob;
                    cmd.Parameters.Add("@length", SqlDbType.Int).Value = len;

                    cmd.ExecuteNonQuery();
                }
            }
        }*/
    }
}
