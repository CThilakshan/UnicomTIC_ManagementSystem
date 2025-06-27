using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controller
{
    internal class StudentController
    {
        public List<Student> GetAllStudents()
        {
            var studentList = new List<Student>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                SELECT s.Student_ID, s.Student_Name, s.Student_Phone_No, s.Student_Email,
                        s.Course_ID, c.Course_Name
                FROM Students s
                JOIN Courses c ON s.Course_ID = c.Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentList.Add(new Student
                        {
                            Student_ID = reader.GetInt32(0),
                            Student_Name = reader.GetString(1),
                            Student_Phone_No = reader.GetString(2),
                            Student_Email = reader.GetString(3),
                            Course_ID = reader.GetInt32(4).ToString(), // string in model
                            Course_Name = reader.GetString(5)
                        });
                    }
                }
            }

            return studentList;
        }

        // Insert new Student
        public void InsertStudent(string name, string phone, string email, int courseId)
        {
            string insertQuery = "INSERT INTO Students (Student_Name, Student_Phone_No, Student_Email, Course_ID) VALUES (@Name, @Phone, @Email, @Course_ID)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Student inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting Student:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insert User record into Users table
        public void InsertUser(string name, string role, string username, string password, int courseId,int studentId)
        {
            // Ensure your Users table actually has a Course_ID column or remove this parameter
            string insertQuery = "INSERT INTO Users (Name, Role, Username, Password, Course_ID,Student_ID) VALUES (@Name, @Role, @Username, @Password, @Course_ID,@Student_ID)";

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
                    cmd.Parameters.AddWithValue("@Student_ID", studentId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateStudent(int studentId, string name, string phone, string email, int courseId)
        {
            string updateQuery = "UPDATE Students SET Student_Name = @Name, Student_Phone_No = @Phone, Student_Email = @Email, Course_ID = @Course_ID WHERE Student_ID = @StudentID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the student:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateUser(int userId, string name, string role,  int courseId, int studentId)
        {
            string updateQuery = "UPDATE Users SET Name = @Name, Role = @Role,  Course_ID = @Course_ID,Student_ID =@Student_ID WHERE User_ID = @UserID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Student_ID", studentId);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteStudent(int studentId)
        {
            string deleteQuery = "DELETE FROM Students WHERE Student_ID = @StudentID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No student record found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Search students by name using LIKE operator
        public List<Student> SearchStudentsByName(string keyword)
        {
            string searchQuery = "SELECT * FROM Students WHERE Student_Name LIKE @Student_Name";
            List<Student> studentList = new List<Student>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open(); // Open the connection before executing commands

                    using (var cmd = new SQLiteCommand(searchQuery, conn))
                    {
                        // Parameter name must match the query, and add % for LIKE wildcard
                        cmd.Parameters.AddWithValue("@Student_Name", "%" + keyword + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentList.Add(new Student
                                {
                                    Student_ID = reader.GetInt32(reader.GetOrdinal("Student_ID")),
                                    Student_Name = reader.GetString(reader.GetOrdinal("Student_Name"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for students:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return studentList;
        }


        // Get a single student by ID
        public Student GetStudentById(int studentId)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = "SELECT Student_ID, Student_Name, Student_Phone_No, Student_Email, Course_ID FROM Students WHERE Student_ID = @StudentID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                Student_ID = reader.GetInt32(0),
                                Student_Name = reader.GetString(1),
                                Student_Phone_No = reader.GetString(2),
                                Student_Email = reader.GetString(3),
                                Course_ID = reader.GetInt32(4).ToString()

                            };
                        }
                    }
                }
            }

            return null;
        }
        public List<Student> GetStudentsByCourseId(int courseId)
        {
            var students = new List<Student>();

            using (var conn = DBConnection.GetConnection())
            {
                const string query = "SELECT Student_ID, Student_Name FROM Students WHERE Course_ID = @Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student
                            {
                                Student_ID = reader.GetInt32(reader.GetOrdinal("Student_ID")),
                                Student_Name = reader.IsDBNull(reader.GetOrdinal("Student_Name")) ? "" : reader.GetString(reader.GetOrdinal("Student_Name"))
                                // Add other student properties here if needed
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }


    }
}
