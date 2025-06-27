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
    internal class MarkController
    {
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        m.Mark_ID,
                        m.Exam_ID,
                        m.Course_ID,
                        m.Subject_ID,
                        m.Student_ID,
                        st.Student_Name,
                        e.Exam_Name,
                        s.Subject_Name,
                        c.Course_Name,
                        m.Exam_Marks
                    FROM Marks m
                    INNER JOIN Students st ON m.Student_ID = st.Student_ID
                    INNER JOIN Exams e ON m.Exam_ID = e.Exam_ID
                    INNER JOIN Subjects s ON m.Subject_ID = s.Subject_ID
                    INNER JOIN Courses c ON m.Course_ID = c.Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mark = new Mark
                        {
                            Mark_ID = reader.GetInt32(0),
                            Exam_ID = reader.GetInt32(1),
                            Course_ID = reader.GetInt32(2),
                            Subject_ID = reader.GetInt32(3),
                            Student_ID = reader.GetInt32(4),
                            Student_Name = reader.GetString(5),
                            Exam_Name = reader.GetString(6),
                            Subject_Name = reader.GetString(7),
                            Course_Name = reader.GetString(8),
                            Exam_Marks = reader.GetInt32(9)
                        };

                        marks.Add(mark);
                    }
                }
            }

            return marks;
        }
        public List<Mark> GetMarksBySubjectId(int subjectId)
        {
            var marks = new List<Mark>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        m.Mark_ID,
                        m.Exam_ID,
                        m.Course_ID,
                        m.Subject_ID,
                        m.Student_ID,
                        st.Student_Name,
                        e.Exam_Name,
                        s.Subject_Name,
                        c.Course_Name,
                        m.Exam_Marks
                    FROM Marks m
                    JOIN Students st ON m.Student_ID = st.Student_ID
                    JOIN Exams e ON m.Exam_ID = e.Exam_ID
                    JOIN Subjects s ON m.Subject_ID = s.Subject_ID
                    JOIN Courses c ON m.Course_ID = c.Course_ID
                    WHERE m.Subject_ID = @Subject_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marks.Add(new Mark
                            {
                                Mark_ID = reader.GetInt32(0),
                                Exam_ID = reader.GetInt32(1),
                                Course_ID = reader.GetInt32(2),
                                Subject_ID = reader.GetInt32(3),
                                Student_ID = reader.GetInt32(4),
                                Student_Name = reader.IsDBNull(5) ? null : reader.GetString(5),
                                Exam_Name = reader.IsDBNull(6) ? null : reader.GetString(6),
                                Subject_Name = reader.IsDBNull(7) ? null : reader.GetString(7),
                                Course_Name = reader.IsDBNull(8) ? null : reader.GetString(8),
                                Exam_Marks = reader.IsDBNull(9) ? 0 : reader.GetInt32(9)
                            });
                        }
                    }
                }
            }

            return marks;
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
                            students.Add(new Student
                            {
                                Student_ID = reader.GetInt32(0),
                                Student_Name = reader.IsDBNull(1) ? "" : reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return students;
        }
        public bool InsertMark(int examId, int studentId, int subjectId, int courseId, int examMarks)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    INSERT INTO Marks (Exam_ID, Student_ID, Subject_ID, Course_ID, Exam_Marks)
                    VALUES (@Exam_ID, @Student_ID, @Subject_ID, @Course_ID, @Exam_Marks)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Exam_ID", examId);
                    cmd.Parameters.AddWithValue("@Student_ID", studentId);
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Exam_Marks", examMarks);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to insert mark: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public bool UpdateMark(int markId, int examId, int studentId, int subjectId, int courseId, int examMarks)
        {
            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                UPDATE Marks
                SET Exam_ID = @Exam_ID,
                    Student_ID = @Student_ID,
                    Subject_ID = @Subject_ID,
                    Course_ID = @Course_ID,
                    Exam_Marks = @Exam_Marks
                WHERE Mark_ID = @Mark_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Exam_ID", examId);
                    cmd.Parameters.AddWithValue("@Student_ID", studentId);
                    cmd.Parameters.AddWithValue("@Subject_ID", subjectId);
                    cmd.Parameters.AddWithValue("@Course_ID", courseId);
                    cmd.Parameters.AddWithValue("@Exam_Marks", examMarks);
                    cmd.Parameters.AddWithValue("@Mark_ID", markId);

                    try
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating mark: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public Mark GetMarkById(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                var query = @"
                    SELECT 
                        m.Mark_ID,
                        m.Exam_ID,
                        e.Exam_Name,
                        e.Exam_Date,
                        m.Student_ID,
                        st.Student_Name,
                        m.Subject_ID,
                        s.Subject_Name,
                        m.Course_ID,
                        c.Course_Name,
                        m.Exam_Marks
                    FROM Marks m
                    JOIN Students st ON m.Student_ID = st.Student_ID
                    JOIN Exams e ON m.Exam_ID = e.Exam_ID
                    JOIN Subjects s ON m.Subject_ID = s.Subject_ID
                    JOIN Courses c ON m.Course_ID = c.Course_ID
                    WHERE m.Mark_ID = @Mark_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Mark_ID", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Mark
                            {
                                Mark_ID = reader.GetInt32(0),
                                Exam_ID = reader.GetInt32(1),
                                Exam_Name = reader.GetString(2),
                                // Optional: store or parse Exam_Date if you want
                                Student_ID = reader.GetInt32(4),
                                Student_Name = reader.GetString(5),
                                Subject_ID = reader.GetInt32(6),
                                Subject_Name = reader.GetString(7),
                                Course_ID = reader.GetInt32(8),
                                Course_Name = reader.GetString(9),
                                Exam_Marks = reader.GetInt32(10)
                            };
                        }
                    }
                }
            }

            return null;
        }
        public void DeleteMark(int markId)
        {
            string deleteQuery = "DELETE FROM Marks WHERE Mark_ID = @Mark_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Mark_ID", markId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mark deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No mark found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the mark:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
