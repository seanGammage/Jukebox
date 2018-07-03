using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jukebox
{
    class UserDB
    {
        // create a varable for the data source
        private static string dbString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\private\CIS 310\final\Jukebox\Jukebox\userDB.mdf;Integrated Security=True";

        public static List<string> login(string name, string pass)
        {
            SqlConnection conn = new SqlConnection(dbString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Users.Username FROM Users WHERE Users.Username = '" + name + "' AND Users.Password = '" + pass + "' Collate SQL_Latin1_General_CP1_CS_AS", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null && reader.Read())
            {
                List<string> newUser = new List<string>();

                newUser.Add((string)reader[0]);

                conn.Close();

                return newUser;
            }
            else
            {
                conn.Close();
                return null;
            }
        }
    }
}
