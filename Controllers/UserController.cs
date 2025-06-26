using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



    }
}
