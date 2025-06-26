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
    internal class LecturerController
    {
        public List<Lecturer> GetAllLecturers()
        {
            var lecturerList = new List<Lecturer>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT l.Lecturer_ID, l.Lecturer_Name, l.Lecturer_Phone_No, l.Lecturer_Email,
                           l.Subject_ID, sub.Subject_Name, l.Course_ID, c.Course_Name
                    FROM Lecturers l
                    JOIN Subjects sub ON l.Subject_ID = sub.Subject_ID
                    JOIN Courses c ON l.Course_ID = c.Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturerList.Add(new Lecturer
                        {
                            Lecturer_ID = reader.GetInt32(0),
                            Lecturer_Name = reader.GetString(1),
                            Lecturer_Phone_No = reader.GetString(2),
                            Lecturer_Email = reader.GetString(3),
                            Subject_ID = reader.GetInt32(4), // assuming your model now uses int
                            Subject_Name = reader.GetString(5),
                            Course_ID = reader.GetInt32(6),
                            Course_Name = reader.GetString(7),
                        });
                    }
                }
            }

            return lecturerList;
        }
        public List<Lecturer> GetLecturersBySubjectId(int subjectId)
        {
            var lecturers = new List<Lecturer>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT DISTINCT l.Lecturer_ID, l.Lecturer_Name, l.Lecturer_Phone_No, l.Lecturer_Email,
                                    l.Subject_ID, sub.Subject_Name, l.Course_ID, c.Course_Name
                    FROM Lecturers l
                    JOIN Subjects sub ON l.Subject_ID = sub.Subject_ID
                    JOIN Courses c ON l.Course_ID = c.Course_ID
                    WHERE l.Subject_ID = @Subject_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lecturers.Add(new Lecturer
                            {
                                Lecturer_ID = reader.GetInt32(0),
                                Lecturer_Name = reader.GetString(1),
                                Lecturer_Phone_No = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Lecturer_Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Subject_ID = reader.GetInt32(4),
                                Subject_Name = reader.IsDBNull(5) ? null : reader.GetString(5),
                                Course_ID = reader.GetInt32(6),
                                Course_Name = reader.IsDBNull(7) ? null : reader.GetString(7)
                            });
                        }
                    }
                }
            }

            return lecturers;
        }
        public int InsertLecturer(string name, string phone, string email, int subjectId, int courseId)
        {
            int lecturerId = -1;

            string insertQuery = @"
            INSERT INTO Lecturers (Lecturer_Name, Lecturer_Phone_No, Lecturer_Email, Subject_ID, Course_ID)
            VALUES (@Name, @Phone, @Email, @Subject_ID, @Course_ID);
            SELECT last_insert_rowid();";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);

                    lecturerId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                MessageBox.Show("Lecturer inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting Lecturer:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lecturerId;
        }

        public void InsertUser(string name, string role, string username, string password, int courseId, int lecturerId)
        {
            // Adjust this query only if both Course_ID and Lecturer_ID exist in the Users table
            string insertQuery = @"
                INSERT INTO Users (Name, Role, Username, Password, Course_ID, Lecturer_ID) 
                VALUES (@Name, @Role, @Username, @Password, @Course_ID, @Lecturer_ID)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); 
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Lecturer_ID", lecturerId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateLecturer(int lecturerId, string name, string phone, string email, int subjectId, int courseId)
        {
            string updateQuery = @"
                UPDATE Lecturers 
                SET Lecturer_Name = @Name, 
                    Lecturer_Phone_No = @Phone, 
                    Lecturer_Email = @Email, 
                    Subject_ID = @Subject_ID, 
                    Course_ID = @Course_ID 
                WHERE Lecturer_ID = @LecturerID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@LecturerID", lecturerId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lecturer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the lecturer:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateUser(int userId, string name, string role, int courseId, int lecturerId)
        {
            string updateQuery = @"
                UPDATE Users 
                SET 
                    Name = @Name,
                    Role = @Role,
                    Course_ID = @Course_ID,
                    Lecturer_ID = @Lecturer_ID
                WHERE 
                    User_ID = @User_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Lecturer_ID", lecturerId);
                    cmd.Parameters.AddWithValue("@User_ID", userId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the user:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteLecturer(int lecturerId)
        {
            string deleteLecturerQuery = "DELETE FROM Lecturers WHERE Lecturer_ID = @Lecturer_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(deleteLecturerQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Lecturer_ID", lecturerId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Lecturer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No lecturer found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the lecturer:\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Lecturer GetLecturerById(int lecturerId)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT Lecturer_ID, Lecturer_Name, Lecturer_Phone_No, Lecturer_Email, Subject_ID, Course_ID 
                    FROM Lecturers 
                    WHERE Lecturer_ID = @LecturerID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LecturerID", lecturerId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Lecturer
                            {
                                Lecturer_ID = reader.GetInt32(0),
                                Lecturer_Name = reader.GetString(1),
                                Lecturer_Phone_No = reader.GetString(2),
                                Lecturer_Email = reader.GetString(3),
                                Subject_ID = reader.GetInt32(4),
                                Course_ID = reader.GetInt32(5)
                            };
                        }
                    }
                }
            }

            return null; 
        }



    }

}
