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

namespace Unicom_TIC_Management_System.View
{
    
    public partial class MarkForm : Form
    {
        private MarkController markController = new MarkController();
        private ExamController examController = new ExamController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();
        private StudentController studentController = new StudentController();
        private int selectedMarkId = -1;
        public MarkForm()
        {
            InitializeComponent();
            LoadMarks();
            LoadCourses();
            LoadExams();
            this.CourseName_comboBox.SelectedIndexChanged += new System.EventHandler(this.CourseName_comboBox_SelectedIndexChanged);
            

        }
        private void LoadMarks()
        {
            Mark_dataGridView.DataSource = null;
            Mark_dataGridView.DataSource = markController.GetAllMarks(); // assumes GetAllMarks() returns List<Mark>

            Mark_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Mark_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hide internal IDs if you want to keep UI cleaner
            if (Mark_dataGridView.Columns["Mark_ID"] != null)
                Mark_dataGridView.Columns["Mark_ID"].Visible = false;

            if (Mark_dataGridView.Columns["Exam_ID"] != null)
                Mark_dataGridView.Columns["Exam_ID"].Visible = false;

            if (Mark_dataGridView.Columns["Course_ID"] != null)
                Mark_dataGridView.Columns["Course_ID"].Visible = false;

            if (Mark_dataGridView.Columns["Subject_ID"] != null)
                Mark_dataGridView.Columns["Subject_ID"].Visible = false;

            if (Mark_dataGridView.Columns["Student_ID"] != null)
                Mark_dataGridView.Columns["Student_ID"].Visible = false;

            // Set readable headers for user-friendly display
            if (Mark_dataGridView.Columns["Student_Name"] != null)
                Mark_dataGridView.Columns["Student_Name"].HeaderText = "Student";

            if (Mark_dataGridView.Columns["Exam_Name"] != null)
                Mark_dataGridView.Columns["Exam_Name"].HeaderText = "Exam";

            if (Mark_dataGridView.Columns["Subject_Name"] != null)
                Mark_dataGridView.Columns["Subject_Name"].HeaderText = "Subject";

            if (Mark_dataGridView.Columns["Course_Name"] != null)
                Mark_dataGridView.Columns["Course_Name"].HeaderText = "Course";

            if (Mark_dataGridView.Columns["Exam_Marks"] != null)
                Mark_dataGridView.Columns["Exam_Marks"].HeaderText = "Marks";

            Mark_dataGridView.ClearSelection();
        }
        private void ClearMarkForm()
        {
            // Reset combo boxes
            Student_comboBox.SelectedIndex = -1;
            ExamName_comboBox.SelectedIndex = -1;
            Subjectname_comboBox.SelectedIndex = -1;
            CourseName_comboBox.SelectedIndex = -1;
            ExamMark_textBox.Clear();
            Student_comboBox.Focus();

        }
        private void LoadExams()
        {
            var exams = examController.GetAllExams();
            ExamName_comboBox.DataSource = null;
            ExamName_comboBox.DataSource = exams;
            ExamName_comboBox.DisplayMember = "Exam_Name";
            ExamName_comboBox.ValueMember = "Exam_ID";
            ExamName_comboBox.SelectedIndex = -1;
        }
        private bool isCourseLoading = false;
        private void LoadCourses()
        {
            isCourseLoading = true;

            var courses = courseController.GetAllCourses();
            CourseName_comboBox.DataSource = courses;
            CourseName_comboBox.DisplayMember = "Course_Name";
            CourseName_comboBox.ValueMember = "Course_ID";
            CourseName_comboBox.SelectedIndex = -1;

            isCourseLoading = false;
        }

        private void CourseName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCourseLoading || CourseName_comboBox.SelectedIndex == -1 || CourseName_comboBox.SelectedItem == null)
                return; // Don't do anything if loading or invalid

            if (int.TryParse(CourseName_comboBox.SelectedValue.ToString(), out int selectedCourseId))
            {
                LoadSubjectsByCourseId(selectedCourseId); // Load relevant subjects
                LoadStudentsByCourseId(selectedCourseId); // Load relevant students
            }
        }

        private void LoadSubjectsByCourseId(int courseId)
        {
            var subjects = subjectController.GetSubjectsByCourseId(courseId);
            Subjectname_comboBox.DataSource = null;
            Subjectname_comboBox.DataSource = subjects;
            Subjectname_comboBox.DisplayMember = "Subject_Name";
            Subjectname_comboBox.ValueMember = "Subject_ID";
            Subjectname_comboBox.SelectedIndex = -1;
        }

        private void LoadStudentsByCourseId(int courseId)
        {
            var students = studentController.GetStudentsByCourseId(courseId);
            Student_comboBox.DataSource = null;
            Student_comboBox.DataSource = students;
            Student_comboBox.DisplayMember = "Student_Name";
            Student_comboBox.ValueMember = "Student_ID";
            Student_comboBox.SelectedIndex = -1;
        }

        private void Subjectname_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MarkInsert_button_Click(object sender, EventArgs e)
        {
            // Validate that all combo boxes and text fields are properly selected/filled
            if (CourseName_comboBox.SelectedIndex == -1 ||
                Subjectname_comboBox.SelectedIndex == -1 ||
                ExamName_comboBox.SelectedIndex == -1 ||
                Student_comboBox.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(ExamMark_textBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing mark to an integer
            if (!int.TryParse(ExamMark_textBox.Text.Trim(), out int examMarks))
            {
                MessageBox.Show("Please enter a valid numeric value for marks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect selected values
            int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);
            int subjectId = Convert.ToInt32(Subjectname_comboBox.SelectedValue);
            int examId = Convert.ToInt32(ExamName_comboBox.SelectedValue);
            int studentId = Convert.ToInt32(Student_comboBox.SelectedValue);

            // Insert the mark
            bool success = markController.InsertMark(examId, studentId, subjectId, courseId, examMarks);

            if (success)
            {
                MessageBox.Show("Mark inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();           // Reload marks into the grid
                ClearMarkForm();       // Reset the form for next entry
            }
            else
            {
                MessageBox.Show("Failed to insert mark. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MarkUpdate_button_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark record to update.");
                return;
            }

            if (Student_comboBox.SelectedValue == null ||
                ExamName_comboBox.SelectedValue == null ||
                Subjectname_comboBox.SelectedValue == null ||
                CourseName_comboBox.SelectedValue == null ||
                string.IsNullOrWhiteSpace(ExamMark_textBox.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            if (!int.TryParse(ExamMark_textBox.Text, out int examMarks))
            {
                MessageBox.Show("Please enter a valid number for marks.");
                return;
            }

            int studentId = Convert.ToInt32(Student_comboBox.SelectedValue);
            int examId = Convert.ToInt32(ExamName_comboBox.SelectedValue);
            int subjectId = Convert.ToInt32(Subjectname_comboBox.SelectedValue);
            int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);

            bool success = markController.UpdateMark(selectedMarkId, examId, studentId, subjectId, courseId, examMarks);

            if (success)
            {
                MessageBox.Show("Mark updated successfully.");
                LoadMarks();          // Refresh grid
                ClearMarkForm();      // Clear input fields
                selectedMarkId = -1;  // Reset selection
            }
            else
            {
                MessageBox.Show("Failed to update mark.");
            }
        }

        private void Mark_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Mark_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Mark_dataGridView.SelectedRows[0];

                // Assuming columns: "Mark_ID", "Exam_ID", "Student_ID", "Subject_ID", "Course_ID", "Exam_Marks"
                selectedMarkId = Convert.ToInt32(selectedRow.Cells["Mark_ID"].Value);

                // Set combo boxes by their ValueMember (IDs)
                
                ExamName_comboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells["Exam_ID"].Value);
                CourseName_comboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells["Course_ID"].Value);
                Subjectname_comboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells["Subject_ID"].Value);
                Student_comboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells["Student_ID"].Value);

                // Set marks textbox
                ExamMark_textBox.Text = selectedRow.Cells["Exam_Marks"].Value.ToString();
            }
            else
            {
                selectedMarkId = -1;
                ClearMarkForm(); // Optional: method to clear all input fields
            }
        }

        private void MarkDelete_button_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete the selected mark?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    markController.DeleteMark(selectedMarkId);
                    MessageBox.Show("Mark deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadMarks();        // Refresh the grid
                    ClearMarkForm();    // Clear the input fields
                    selectedMarkId = -1; // Reset selected ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting mark: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
