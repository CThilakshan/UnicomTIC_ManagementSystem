using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    // Data Grid View for Courses
    internal class CourseController
    {
        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>(); // Variable name corrected to lowercase "courses"

            using (var conn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course // Changed variable name from "student" to "course"
                    {
                        Course_ID = reader.GetInt32(0),
                        Course_Name = reader.GetString(1),
                    };

                    courses.Add(course); // Fixed incorrect casing and variable name
                }
            }

            return courses;
        }
        // insert course method
        public void InsertCourse(string course_name)
        {
            string insertQuery = "INSERT INTO Courses (Course_Name) VALUES (@Course_Name)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Course_Name", course_name);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Course inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the course:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Update course method
        public void UpdateCourse(int courseId, string courseName)
        {
            string updateQuery = "UPDATE Courses SET Course_Name = @Course_Name WHERE Course_ID = @Course_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Course_Name", courseName);
                        cmd.Parameters.AddWithValue("@Course_ID", courseId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No course found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the course:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //delete course method
        public void DeleteCourse(int courseId)
        {
            string deleteQuery = "DELETE FROM Courses WHERE Course_ID = @Course_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Course_ID", courseId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No course found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the course:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // select course by ID method
        public Course GetCourseById(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses WHERE Course_ID = @Course_ID", conn);
                cmd.Parameters.AddWithValue("@Course_ID", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Course
                        {
                            Course_ID = reader.GetInt32(0),
                            Course_Name = reader.GetString(1)
                        };
                    }
                }
            }

            return null;
        }
        public List<Course> SearchCoursesByName(string keyword)
        {
            string searchQuery = "SELECT * FROM Courses WHERE Course_Name LIKE @Course_Name";
            List<Course> courseList = new List<Course>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(searchQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Course_Name", "%" + keyword + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                courseList.Add(new Course
                                {
                                    Course_ID = reader.GetInt32(reader.GetOrdinal("Course_ID")),
                                    Course_Name = reader.GetString(reader.GetOrdinal("Course_Name"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for courses:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return courseList;
        }

    }
}
