using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    
    internal class SubjectController
    {
        public List<dynamic> GetAllSubjects()
        {
            var subjectList = new List<dynamic>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                SELECT s.Subject_ID, s.Subject_Name, s.Course_ID, c.Course_Name 
                FROM Subjects s 
                JOIN Courses c ON s.Course_ID = c.Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjectList.Add(new
                            {
                                Subject_ID = reader.GetInt32(0),
                                Subject_Name = reader.GetString(1),
                                Course_ID = reader.GetInt32(2),
                                Course_Name = reader.GetString(3)
                            });
                        }
                    }
                }
            }

            return subjectList;
        }
        public List<Subject> GetSubjectsByCourseId(int courseId)
        {
            var subjects = new List<Subject>();
            string query = "SELECT Subject_ID, Subject_Name FROM Subjects WHERE Course_ID = @CourseID";

            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CourseID", courseId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Subject_ID = reader.GetInt32(0),
                            Subject_Name = reader.GetString(1)
                        });
                    }
                }
            }

            return subjects;
        }
        public void InsertSubject(string subject_name,int course_id)
        {
            string insertQuery = "INSERT INTO Subjects (Subject_Name,Course_ID) VALUES (@Subject_Name,@Course_ID)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Subject_Name", subject_name);
                        cmd.Parameters.AddWithValue("@Course_ID",course_id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Subject inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the subject:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateSubject(int subjectId, string subjectName, int courseId)
        {
            string updateQuery = "UPDATE Subjects SET Subject_Name = @Subject_Name, Course_ID = @Course_ID WHERE Subject_ID = @Subject_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Subject_Name", subjectName);
                        cmd.Parameters.AddWithValue("@Course_ID", courseId);
                        cmd.Parameters.AddWithValue("@Subject_ID", subjectId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Subject not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the subject:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteSubject(int subjectId)
        {
            string deleteQuery = "DELETE FROM Subjects WHERE Subject_ID = @Subject_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Subject deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Subject not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the subject:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Subject GetSubjectById(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects WHERE Subject_ID = @Subject_ID", conn);
                cmd.Parameters.AddWithValue("@Subject_ID", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Subject
                        {
                            Subject_ID = reader.GetInt32(0),
                            Subject_Name = reader.GetString(1),
                            Course_ID = reader.GetInt32(2)
                        };
                    }
                }
            }

            return null;
        }
    }
}
