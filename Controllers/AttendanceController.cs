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
    internal class AttendanceController
    {
        public List<Attendance> GetAllAttendances()
        {
            var attendanceList = new List<Attendance>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT a.Attendance_ID, a.Attendance_Name, a.Attendance_Role, a.Attendance_Time,
                           a.Student_ID, s.Student_Name,
                           a.Lecturer_ID, l.Lecturer_Name,
                           a.Course_ID, c.Course_Name
                    FROM Attendances a
                    LEFT JOIN Students s ON a.Student_ID = s.Student_ID
                    LEFT JOIN Lecturers l ON a.Lecturer_ID = l.Lecturer_ID
                    LEFT JOIN Courses c ON a.Course_ID = c.Course_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        attendanceList.Add(new Attendance
                        {
                            Attendance_ID = reader.GetInt32(0),
                            Attendance_Name = reader.GetString(1),
                            Attendance_Role = reader.GetString(2),
                            Attendance_Time = reader.GetString(3),
                            Student_ID = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            Student_Name = reader.IsDBNull(5) ? null : reader.GetString(5),
                            Lecturer_ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                            Lecturer_Name = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Course_ID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                            Course_Name = reader.IsDBNull(9) ? null : reader.GetString(9)
                        });
                    }
                }
            }

            return attendanceList;
        }

        public void InsertAttendance(string name, string role, string time, int courseId, int student_ID, int lecturer_ID)
        {
            string insertQuery = @"INSERT INTO Attendances 
                                   (Attendance_Name, Attendance_Role, Attendance_Time, Student_ID, Course_ID, Lecturer_ID) 
                                   VALUES (@Attendance_Name, @Attendance_Role, @Attendance_Time, @Student_ID, @Course_ID, @Lecturer_ID)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    // conn.Open();  -- removed because GetConnection() already opens the connection

                    // Check if attendance already marked for today
                    using (var checkCmd = new SQLiteCommand(
                        @"SELECT COUNT(*) FROM Attendances 
                          WHERE Student_ID = @Student_ID 
                            AND date(Attendance_Time) = date(@Attendance_Time)", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Student_ID", student_ID);
                        checkCmd.Parameters.AddWithValue("@Attendance_Time", time);

                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Attendance already marked for today.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Insert attendance
                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Attendance_Name", name);
                        cmd.Parameters.AddWithValue("@Attendance_Role", role);
                        cmd.Parameters.AddWithValue("@Attendance_Time", time);
                        cmd.Parameters.AddWithValue("@Student_ID", student_ID);
                        cmd.Parameters.AddWithValue("@Course_ID", courseId);
                        cmd.Parameters.AddWithValue("@Lecturer_ID", lecturer_ID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Attendance inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting attendance:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Attendance> SearchAttendances(string searchTerm)
        {
            var attendanceList = new List<Attendance>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT a.Attendance_ID, a.Attendance_Name, a.Attendance_Role, a.Attendance_Time,
                           a.Student_ID, s.Student_Name,
                           a.Lecturer_ID, l.Lecturer_Name,
                           a.Course_ID, c.Course_Name
                    FROM Attendances a
                    LEFT JOIN Students s ON a.Student_ID = s.Student_ID
                    LEFT JOIN Lecturers l ON a.Lecturer_ID = l.Lecturer_ID
                    LEFT JOIN Courses c ON a.Course_ID = c.Course_ID
                    WHERE 
                        a.Attendance_Name LIKE @term OR
                        a.Attendance_Role LIKE @term OR
                        a.Attendance_Time LIKE @term OR
                        s.Student_Name LIKE @term OR
                        l.Lecturer_Name LIKE @term OR
                        c.Course_Name LIKE @term";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@term", "%" + searchTerm + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            attendanceList.Add(new Attendance
                            {
                                Attendance_ID = reader.GetInt32(0),
                                Attendance_Name = reader.GetString(1),
                                Attendance_Role = reader.GetString(2),
                                Attendance_Time = reader.GetString(3),
                                Student_ID = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                                Student_Name = reader.IsDBNull(5) ? null : reader.GetString(5),
                                Lecturer_ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                Lecturer_Name = reader.IsDBNull(7) ? null : reader.GetString(7),
                                Course_ID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8),
                                Course_Name = reader.IsDBNull(9) ? null : reader.GetString(9)
                            });
                        }
                    }
                }
            }

            return attendanceList;
        }

    }
}
