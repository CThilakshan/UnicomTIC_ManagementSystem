using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.View
{
    public partial class StudentForm : Form
    {
        private StudentController studentController = new StudentController();
        private CourseController courseController = new CourseController();

        // Keep track of selected student and user IDs globally
        private int selectedUserId = -1;
        private int selectedStudentId = -1;

        public StudentForm()
        {
            InitializeComponent();
            LoadStudent();
            Loadcourses();
        }

        private void LoadStudent()
        {
            Student_dataGridView.DataSource = null;
            Student_dataGridView.DataSource = studentController.GetAllStudents();

            // Optional: Auto resize
            Student_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Student_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hide Course_ID column
            if (Student_dataGridView.Columns["Course_ID"] != null)
            {
                Student_dataGridView.Columns["Course_ID"].Visible = false;
            }

            // Optional: Rename header for Course_Name
            if (Student_dataGridView.Columns["Course_Name"] != null)
            {
                Student_dataGridView.Columns["Course_Name"].HeaderText = "Course";
            }

            Student_dataGridView.ClearSelection();
        }

        private void Loadcourses()
        {
            var courses = courseController.GetAllCourses();
            CourseName_comboBox.DataSource = courses;
            CourseName_comboBox.DisplayMember = "Course_Name";  // Show this in dropdown
            CourseName_comboBox.ValueMember = "Course_ID";      // Internal value
            CourseName_comboBox.SelectedIndex = -1;             // Deselect initially
        }

        private void ClearForm()
        {
            StudentFullname_textBox.Clear();
            StudentPhoneNo_textBox.Clear();
            StudentEmail_textBox.Clear();
            StudentUsername_textBox.Clear();
            StudentPassword_textBox.Clear();
            CourseName_comboBox.SelectedIndex = -1;
            selectedStudentId = -1;
            selectedUserId = -1;
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string student_name = StudentFullname_textBox.Text.Trim();
                string student_phoneno = StudentPhoneNo_textBox.Text.Trim();
                string student_email = StudentEmail_textBox.Text.Trim();
                string student_username = StudentUsername_textBox.Text.Trim();
                string student_password = StudentPassword_textBox.Text.Trim();

                if (CourseName_comboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);

                if (string.IsNullOrWhiteSpace(student_name) ||
                    string.IsNullOrWhiteSpace(student_phoneno) ||
                    string.IsNullOrWhiteSpace(student_email) ||
                    string.IsNullOrWhiteSpace(student_username) ||
                    string.IsNullOrWhiteSpace(student_password))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone, Email, Username, Password).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                studentController.InsertStudent(student_name, student_phoneno, student_email, courseId);
                studentController.InsertUser(student_name, "Student", student_username, student_password, courseId);

                LoadStudent();
                ClearForm();
                StudentFullname_textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string student_name = StudentFullname_textBox.Text.Trim();
                string student_phoneno = StudentPhoneNo_textBox.Text.Trim();
                string student_email = StudentEmail_textBox.Text.Trim();
                string student_username = StudentUsername_textBox.Text.Trim();
                string student_password = StudentPassword_textBox.Text.Trim();

                if (CourseName_comboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);

                if (string.IsNullOrWhiteSpace(student_name) ||
                    string.IsNullOrWhiteSpace(student_phoneno) ||
                    string.IsNullOrWhiteSpace(student_email) ||
                    string.IsNullOrWhiteSpace(student_username) ||
                    string.IsNullOrWhiteSpace(student_password))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone, Email, Username, Password).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                studentController.UpdateStudent(selectedStudentId, student_name, student_phoneno, student_email, courseId);
                studentController.UpdateUser(selectedUserId, student_name, "Student", student_username, student_password, courseId);

                LoadStudent();
                ClearForm();
                MessageBox.Show("Student record updated successfully!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Use class-level selectedStudentId (no local variable shadowing)
                if (Student_dataGridView.CurrentRow != null)
                {
                    selectedStudentId = Convert.ToInt32(Student_dataGridView.CurrentRow.Cells["Student_ID"].Value);
                }

                if (selectedStudentId == -1)
                {
                    MessageBox.Show("Please select a student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                studentController.DeleteStudent(selectedStudentId);
                LoadStudent();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the student:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Student_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Student_dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = Student_dataGridView.SelectedRows[0];

                // Update selectedStudentId from the selected row
                selectedStudentId = Convert.ToInt32(selectedRow.Cells["Student_ID"].Value);

                // Populate the form fields from the selected row's data
                StudentFullname_textBox.Text = selectedRow.Cells["Student_Name"].Value?.ToString() ?? "";
                StudentPhoneNo_textBox.Text = selectedRow.Cells["Student_Phone_No"].Value?.ToString() ?? "";
                StudentEmail_textBox.Text = selectedRow.Cells["Student_Email"].Value?.ToString() ?? "";

                // Set the course combo box selected value
                if (selectedRow.Cells["Course_ID"].Value != null)
                {
                    int courseId;
                    if (int.TryParse(selectedRow.Cells["Course_ID"].Value.ToString(), out courseId))
                    {
                        CourseName_comboBox.SelectedValue = courseId;
                    }
                    else
                    {
                        CourseName_comboBox.SelectedIndex = -1; // Deselect if parse fails
                    }
                }
                else
                {
                    CourseName_comboBox.SelectedIndex = -1; // Deselect if no value
                }

                // Clear username and password fields (you may load user info here if needed)
                StudentUsername_textBox.Text = "";
                StudentPassword_textBox.Text = "";

                // Reset selectedUserId if you handle user selection elsewhere
                selectedUserId = -1;
            }
            else
            {
                // No selection, clear the form
                ClearForm();
                selectedStudentId = -1;
                selectedUserId = -1;
            }
        }
    }
}