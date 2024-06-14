using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using ReportAdminStaff.Models;

namespace ReportAdminStaff.Data
{
    public class UsersDAO
    {

        User FoundUser = null;

        string connectionString = @"Data Source=DESKTOP-903SGBM\SQLEXPRESS;Initial Catalog=FastFoodDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public User FindUserByNameAndPassword(User user)
        {
            string sql = "SELECT * FROM Users where Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar, 30).Value = user.Username;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 30).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        FoundUser = new User
                        {
                            UserId = (int)reader["UserId"],
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            UserType = reader["UserType"].ToString()
                        };
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return FoundUser;
        }
    }
}
