using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

//Handles user validation against the database
namespace Cafe
{
    class AuthenticationHelperClass
    {
        private static string connString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

        public static (bool isValid, string role) ValidateUser(string username, string password, string requiredRole)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connString))
                {
                    sqlcon.Open();
                    //SQL query checks for matching username/password with specific role and active status
                    string query = @"SELECT Role, Status FROM Users 
                                   WHERE Username = @Username 
                                   AND Password = @Password
                                   AND Role = @Role
                                   AND Status = 'active'";

                    using (SqlCommand cmd = new SqlCommand(query, sqlcon))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", requiredRole);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return (true, requiredRole);
                            }
                        }
                    }
                }
                return (false, null); //Return false if no matching user found
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Authentication error: {ex.Message}");
                return (false, null);
            }
        }
    }
}
    


 
           
    

