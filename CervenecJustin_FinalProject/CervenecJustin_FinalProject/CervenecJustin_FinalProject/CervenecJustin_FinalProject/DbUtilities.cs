using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CervenecJustin_FinalProject
{
    class DbUtilities
    {
        public static string BuildConnection()
        {
            string serverIP = "";
            string port = "";

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\VFW\connect.txt"))
                {
                    //read data in connect text file
                    serverIP = sr.ReadLine();
                    port = sr.ReadLine();


                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            return "server = " + serverIP + ";uid=dbsAdmin;password=password;database=Final Project;SslMode=none;port=" + port;
        }

        public static MySqlConnection Connect(string MyConnectString)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn.ConnectionString = MyConnectString;
                conn.Open();

                //Debug Connection
               //  MessageBox.Show("Connected");
            }
            catch (MySqlException e)
            {

                switch (e.Number)
                {
                    case 1042:
                        MessageBox.Show("Can not resolve host address.\n" + MyConnectString);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username or password.");
                        break;

                    default:
                        MessageBox.Show(e.ToString() + "\n" + MyConnectString);
                        break;
                }
            }
            return conn;
        }
    }
}
