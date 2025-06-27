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
    internal class UserController
    {
        public List<User> GetAllUsers()
        {
            var userList = new List<User>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT u.User_ID, u.Name, u.Role, u.Username, u.Password, 
                           u.Student_ID, s.Student_Name, 
                           u.Lecturer_ID, l.Lecturer_Name, 
                           u.Course_ID, c.Course_Name
                    FROM Users u
                    LEFT JOIN Students s ON u.Student_ID = s.Student_ID
                    LEFT JOIN Lecturers l ON u.Lecturer_ID = l.Lecturer_ID
                    LEFT JOIN Courses c ON u.Course_ID = c.Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userList.Add(new User
                        {
                            User_ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Role = reader.GetString(2),
                            Username = reader.GetString(3),
                            Password = reader.GetString(4),
                            Student_ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            Student_Name = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Lecturer_ID = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                            Lecturer_Name = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Course_ID = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                            Course_Name = reader.IsDBNull(10) ? null : reader.GetString(10)
                        });
                    }
                }
            }

            return userList;
        }
        public void UpdateUserDetails(int user_id, string username, string password)
        {
            string updateQuery = "UPDATE Users SET Username = @Username, Password = @Password WHERE User_ID = @User_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@User_ID", user_id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteUser(int user_id)
        {
            string deleteQuery = "DELETE FROM Users WHERE User_ID = @User_ID";
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    // conn.Open(); // Removed because GetConnection() already opens the connection
                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@User_ID", user_id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No User found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the User:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public List<User> SearchUsers(string keyword)
        {
            var users = new List<User>();
            string query = "SELECT * FROM Users WHERE Username LIKE @Keyword";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                User_ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Username = reader.GetString(2),
                                Password = reader.GetString(3)
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching users:\n" + ex.Message,
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return users;
        }


    }
}
    
    