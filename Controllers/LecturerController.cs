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
        public void InsertLecturer(string name, string phone, string email, int subjectId, int courseId)
        {
            string insertQuery = @"
                INSERT INTO Lecturers (Lecturer_Name, Lecturer_Phone_No, Lecturer_Email, Subject_ID, Course_ID)
                VALUES (@Name, @Phone, @Email, @Subject_ID, @Course_ID)";

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
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lecturer inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting Lecturer:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                WHERE Lecturer_ID = @Lecturer_ID";

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
                    cmd.Parameters.AddWithValue("@Lecturer_ID", lecturerId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lecturer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the lecturer:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateUser(int userId, string name, string role, string username, string password, int courseId, int lecturerId)
        {
            string updateQuery = @"
                UPDATE Users 
                SET Name = @Name,
                    Role = @Role,
                    Username = @Username,
                    Password = @Password,
                    Course_ID = @Course_ID,
                    Lecturer_ID = @Lecturer_ID
                WHERE User_ID = @User_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Consider hashing
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Lecturer_ID", lecturerId);
                    cmd.Parameters.AddWithValue("@User_ID", userId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteLecturerAndUser(int lecturerId)
        {
            string deleteUserQuery = "DELETE FROM Users WHERE Lecturer_ID = @Lecturer_ID";
            string deleteLecturerQuery = "DELETE FROM Lecturers WHERE Lecturer_ID = @Lecturer_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        using (var cmdUser = new SQLiteCommand(deleteUserQuery, conn))
                        {
                            cmdUser.Parameters.AddWithValue("@Lecturer_ID", lecturerId);
                            cmdUser.ExecuteNonQuery();
                        }

                        using (var cmdLecturer = new SQLiteCommand(deleteLecturerQuery, conn))
                        {
                            cmdLecturer.Parameters.AddWithValue("@Lecturer_ID", lecturerId);
                            cmdLecturer.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Lecturer and user deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting lecturer and user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
