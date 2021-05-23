using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    public class AddressBookManagement
    { 
        /* UC1:- Address Book ServiceDB
                 - Use SQL Client to create DB and DB Records.
   */
        public static string connectionString = @"Data Source=DESKTOP-D8GLB66\SQLEXPRESS;Initial Catalog=AddressBookDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"; //Specifying the connection string from the sql server connection.

        SqlConnection connection = new SqlConnection(connectionString); // Establishing the connection using the Sqlconnection.  

        public void DataBaseConnection()
        {
            try
            {
                DateTime now = DateTime.Now; //create object DateTime class //DateTime.Now class access system date and time 
                connection.Open(); // open connection
                using (connection)  //using SqlConnection
                {
                    Console.WriteLine($"Connection is created Successful {now}"); //print msg

                }
                connection.Close(); //close connection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}