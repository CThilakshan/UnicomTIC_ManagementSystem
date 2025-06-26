using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    internal class LoginController
    {
        public User Login(string username, string password)
        {
            // Hardcoded Admin Check
            if (username == "admin" && password == "admin123")
            {
                return new User
                {
                    Name = "Administrator",
                    Role = "Admin"
                };
            }

            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            using (var conn = DBConnection.GetConnection())
            {
                
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();

                            var user = new User
                            {
                                Name = reader["Name"].ToString(),
                                Role = role
                            };

                            if (role == "Student")
                            {
                                user.Student_ID = Convert.ToInt32(reader["Student_ID"]);
                                user.Course_ID = Convert.ToInt32(reader["Course_ID"]);
                            }
                            else if (role == "Lecturer")
                            {
                                user.Lecturer_ID = Convert.ToInt32(reader["Lecturer_ID"]);
                                user.Course_ID = Convert.ToInt32(reader["Course_ID"]);
                            }

                            return user;
                        }
                    }
                }
            }

            return null;
        }



    }
}

