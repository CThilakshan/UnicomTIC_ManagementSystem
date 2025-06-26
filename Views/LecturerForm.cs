using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.View
{
    public partial class LecturerForm : Form
    {
        private LecturerController lecturerController = new LecturerController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();

        private int selectedUserId = -1;
        private int selectedLecturerId = -1;
        private User currentUser;

        public LecturerForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.Load += LecturerForm_Load; // Properly attach the Load event
            HideStudent();
        }
        private void HideStudent()
        {
            if (currentUser.Role == "Lecturer"|| currentUser.Role == "Staff")
            {
                // Hide specific labels for students
                student_menu_pn.Visible = false;
                lecPasswordpanel.Visible = false;



            }

        }
        private void LecturerForm_Load(object sender, EventArgs e)
        {
            LoadLecturer();
            LoadCourses();
            LoadSubjects();

            // Attach combo box event only once during form load
            CourseName_comboBox.SelectedIndexChanged += CourseName_comboBox_SelectedIndexChanged;
        }

        private void LoadLecturer()
        {
            Lecturer_dataGridView.DataSource = null;
            Lecturer_dataGridView.DataSource = lecturerController.GetAllLecturers();

            // Auto resize
            Lecturer_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Lecturer_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hide columns not needed in UI
            if (Lecturer_dataGridView.Columns["Subject_ID"] != null)
                Lecturer_dataGridView.Columns["Subject_ID"].Visible = false;

            if (Lecturer_dataGridView.Columns["Course_ID"] != null)
                Lecturer_dataGridView.Columns["Course_ID"].Visible = false;

            // Set readable headers
            if (Lecturer_dataGridView.Columns["Lecturer_Name"] != null)
                Lecturer_dataGridView.Columns["Lecturer_Name"].HeaderText = "Name";

            if (Lecturer_dataGridView.Columns["Lecturer_Email"] != null)
                Lecturer_dataGridView.Columns["Lecturer_Email"].HeaderText = "Email";

            if (Lecturer_dataGridView.Columns["Lecturer_Phone_No"] != null)
                Lecturer_dataGridView.Columns["Lecturer_Phone_No"].HeaderText = "Phone No";

            if (Lecturer_dataGridView.Columns["Subject_Name"] != null)
                Lecturer_dataGridView.Columns["Subject_Name"].HeaderText = "Subject";

            if (Lecturer_dataGridView.Columns["Course_Name"] != null)
                Lecturer_dataGridView.Columns["Course_Name"].HeaderText = "Course";

            Lecturer_dataGridView.ClearSelection();
        }

        private void LoadCourses()
        {
            var courses = courseController.GetAllCourses();
            CourseName_comboBox.DataSource = courses;
            CourseName_comboBox.DisplayMember = "Course_Name";
            CourseName_comboBox.ValueMember = "Course_ID";
            CourseName_comboBox.SelectedIndex = -1;
        }
        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            Subject_comboBox.DataSource = subjects;
            Subject_comboBox.DisplayMember = "Subject_Name"; // What the user sees
            Subject_comboBox.ValueMember = "Subject_ID";     // The actual value used internally
            Subject_comboBox.SelectedIndex = -1;             // Deselect initially
        }

        private void CourseName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseName_comboBox.SelectedIndex != -1)
            {
                int selectedCourseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);
                LoadSubjectsByCourseId(selectedCourseId);
            }
            else
            {
                Subject_comboBox.DataSource = null;
            }
        }

        private void LoadSubjectsByCourseId(int courseId)
        {
            var subjects = subjectController.GetSubjectsByCourseId(courseId);
            Subject_comboBox.DataSource = subjects;
            Subject_comboBox.DisplayMember = "Subject_Name";
            Subject_comboBox.ValueMember = "Subject_ID";
            Subject_comboBox.SelectedIndex = -1;
        }
        private void ClearForm()
        {
            LecturerFullname_textBox.Clear();
            LecturerPhoneNo_textBox.Clear();
            LecturerEmail_textBox.Clear();
            LecturerUsername_textBox.Clear();
            LecturerPassword_textBox.Clear();

            CourseName_comboBox.SelectedIndex = -1;
            Subject_comboBox.SelectedIndex = -1;
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string lecturer_name = LecturerFullname_textBox.Text.Trim();
                string lecturer_phoneno = LecturerPhoneNo_textBox.Text.Trim();
                string lecturer_email = LecturerEmail_textBox.Text.Trim();
                string lecturer_username = LecturerUsername_textBox.Text.Trim();
                string lecturer_password = LecturerPassword_textBox.Text.Trim();

                if (CourseName_comboBox.SelectedValue == null || Subject_comboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a course and subject.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);
                int subjectId = Convert.ToInt32(Subject_comboBox.SelectedValue);

                if (string.IsNullOrWhiteSpace(lecturer_name) ||
                    string.IsNullOrWhiteSpace(lecturer_phoneno) ||
                    string.IsNullOrWhiteSpace(lecturer_email) ||
                    string.IsNullOrWhiteSpace(lecturer_username) ||
                    string.IsNullOrWhiteSpace(lecturer_password))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone, Email, Username, Password).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int lecturerId = lecturerController.InsertLecturer(lecturer_name, lecturer_phoneno, lecturer_email, subjectId, courseId);

                if (lecturerId <= 0)
                {
                    MessageBox.Show("Failed to insert lecturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                lecturerController.InsertUser(lecturer_name, "Lecturer", lecturer_username, lecturer_password, courseId, lecturerId);

                LoadLecturer();     // Refresh DataGrid
                ClearForm();        // Clear fields
                LecturerFullname_textBox.Focus(); // Set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LecturerUpdate_button_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Read inputs from form controls
                string lecturer_name = LecturerFullname_textBox.Text.Trim();
                string lecturer_phone = LecturerPhoneNo_textBox.Text.Trim();
                string lecturer_email = LecturerEmail_textBox.Text.Trim();

                // Validate inputs
                if (string.IsNullOrWhiteSpace(lecturer_name) ||
                    string.IsNullOrWhiteSpace(lecturer_phone) ||
                    string.IsNullOrWhiteSpace(lecturer_email))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone, Email).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate combo box selections
                if (Subject_comboBox.SelectedValue == null || CourseName_comboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select both Subject and Course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int subjectId = Convert.ToInt32(Subject_comboBox.SelectedValue);
                int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);

                // Update Lecturer table
                lecturerController.UpdateLecturer(selectedLecturerId, lecturer_name, lecturer_phone, lecturer_email, subjectId, courseId);

                // Update Users table
                lecturerController.UpdateUser(selectedUserId, lecturer_name, "Lecturer", courseId, selectedLecturerId);

                LoadLecturer(); // Refresh DataGridView
                ClearForm();    // Clear form fields

                MessageBox.Show("Lecturer record updated successfully!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Lecturer_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Lecturer_dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = Lecturer_dataGridView.SelectedRows[0];

                selectedLecturerId = Convert.ToInt32(selectedRow.Cells["Lecturer_ID"].Value);

                LecturerFullname_textBox.Text = selectedRow.Cells["Lecturer_Name"].Value?.ToString() ?? "";
                LecturerPhoneNo_textBox.Text = selectedRow.Cells["Lecturer_Phone_No"].Value?.ToString() ?? "";
                LecturerEmail_textBox.Text = selectedRow.Cells["Lecturer_Email"].Value?.ToString() ?? "";

                if (selectedRow.Cells["Course_ID"].Value != null &&
                    int.TryParse(selectedRow.Cells["Course_ID"].Value.ToString(), out int courseId))
                {
                    CourseName_comboBox.SelectedValue = courseId;
                }
                else
                {
                    CourseName_comboBox.SelectedIndex = -1;
                }

                if (selectedRow.Cells["Subject_ID"].Value != null &&
                    int.TryParse(selectedRow.Cells["Subject_ID"].Value.ToString(), out int subjectId))
                {
                    Subject_comboBox.SelectedValue = subjectId;
                }
                else
                {
                    Subject_comboBox.SelectedIndex = -1;
                }

                // You can also populate selectedUserId by querying Users table based on Lecturer_ID if needed
            }
            else
            {
                ClearForm();
                selectedLecturerId = -1;
                selectedUserId = -1;
            }

        }

        private void lecturerDelete_button_Click(object sender, EventArgs e)
        {
            if (Lecturer_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a lecturer to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming the first cell contains the Lecturer_ID
            int lecturerId = Convert.ToInt32(Lecturer_dataGridView.SelectedRows[0].Cells[0].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this lecturer?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    lecturerController.DeleteLecturer(lecturerId); // Call your method
                    LoadLecturer(); // Reload updated lecturer list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}