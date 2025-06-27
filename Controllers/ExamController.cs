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
    internal class ExamController
    {
        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        e.Exam_ID,
                        e.Exam_Name,
                        e.Exam_Date,
                        s.Subject_ID,
                        s.Subject_Name,
                        c.Course_ID,
                        c.Course_Name
                    FROM Exams e
                    INNER JOIN Subjects s ON e.Subject_ID = s.Subject_ID
                    INNER JOIN Courses c ON e.Course_ID = c.Course_ID";

                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Exam exam = new Exam
                    {
                        Exam_ID = reader.GetInt32(0),
                        Exam_Name = reader.GetString(1),
                        Exam_Date = reader.GetString(2), // Consider DateTime if DB stores actual date
                        Subject_ID = reader.GetInt32(3),
                        Subject_Name = reader.GetString(4),
                        Course_ID = reader.GetInt32(5),
                        Course_Name = reader.GetString(6)
                    };

                    exams.Add(exam);
                }
            }

            return exams;
        }
        public List<Exam> GetExamsBySubjectId(int subjectId)
        {
            var exams = new List<Exam>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT e.Exam_ID, e.Exam_Name, e.Exam_Date,
                           s.Subject_ID, s.Subject_Name,
                           c.Course_ID, c.Course_Name
                    FROM Exams e
                    JOIN Subjects s ON e.Subject_ID = s.Subject_ID
                    JOIN Courses c ON e.Course_ID = c.Course_ID
                    WHERE e.Subject_ID = @Subject_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exams.Add(new Exam
                            {
                                Exam_ID = reader.GetInt32(0),
                                Exam_Name = reader.GetString(1),
                                Exam_Date = reader.IsDBNull(2) ? null : reader.GetString(2), // use DateTime if needed
                                Subject_ID = reader.GetInt32(3),
                                Subject_Name = reader.IsDBNull(4) ? null : reader.GetString(4),
                                Course_ID = reader.GetInt32(5),
                                Course_Name = reader.IsDBNull(6) ? null : reader.GetString(6)
                            });
                        }
                    }
                }
            }

            return exams;
        }
        public bool InsertExam(string examName, string examDate, int subjectId, int courseId)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
            INSERT INTO Exams (Exam_Name, Exam_Date, Subject_ID, Course_ID)
            VALUES (@Exam_Name, @Exam_Date, @Subject_ID, @Course_ID)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Exam_Name", examName);
                    cmd.Parameters.AddWithValue("@Exam_Date", examDate); 
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to insert exam: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public bool UpdateExam(int examId, string examName, string examDate, int subjectId, int courseId)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
            UPDATE Exams
            SET Exam_Name = @Exam_Name,
                Exam_Date = @Exam_Date,
                Subject_ID = @Subject_ID,
                Course_ID = @Course_ID
            WHERE Exam_ID = @Exam_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Exam_Name", examName);
                    cmd.Parameters.AddWithValue("@Exam_Date", examDate);
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Exam_ID", examId);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating exam: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public Exam GetExamById(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                var query = @"
                    SELECT 
                        e.Exam_ID, 
                        e.Exam_Name, 
                        e.Exam_Date, 
                        s.Subject_ID, 
                        s.Subject_Name, 
                        c.Course_ID, 
                        c.Course_Name
                    FROM Exams e
                    JOIN Subjects s ON e.Subject_ID = s.Subject_ID
                    JOIN Courses c ON e.Course_ID = c.Course_ID
                    WHERE e.Exam_ID = @Exam_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Exam_ID", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Exam
                            {
                                Exam_ID = reader.GetInt32(0),
                                Exam_Name = reader.GetString(1),
                                Exam_Date = reader.GetString(2), // Use DateTime if needed
                                Subject_ID = reader.GetInt32(3),
                                Subject_Name = reader.GetString(4),
                                Course_ID = reader.GetInt32(5),
                                Course_Name = reader.GetString(6)
                            };
                        }
                    }
                }
            }

            return null;
        }
        public void DeleteExam(int exam_id)
        {
            string deleteQuery = "DELETE FROM Exams WHERE Exam_ID = @Exam_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Exam_ID", exam_id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Exam deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No exam found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the exam:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
