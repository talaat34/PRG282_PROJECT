using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG282_PROJECT_Military_Simulations
{
    class FileHandler
    {
        static string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = PROJECT_PRG282; Integrated Security = SSPI";
        SqlConnection conn = new SqlConnection(connection);
        SqlCommand cmd;
        SqlDataReader reader;
        public bool insertUser(string name, string surname)
        {
            bool status = selectUser(name, surname);
            if (status == true)
            {
                return false;
            }
            else
            {
                string sqlInsert = @"INSERT INTO users(name, surname) VALUES('"+name+"', '"+surname+"')";
                SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn);
                cmdInsert.ExecuteNonQuery();
                return true;
            }
        }

        public bool selectUser(string name, string surname)
        {
            bool status;
            string sqlSelect = @"Select * from users where name = '" + name + "' and surname = '" + surname + "'";
            cmd = new SqlCommand(sqlSelect, conn);
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            reader.Close();
            return status;
        }
    }
}
