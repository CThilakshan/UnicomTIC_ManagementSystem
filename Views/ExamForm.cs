using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;

namespace Unicom_TIC_Management_System.View
{
    public partial class ExamForm : Form
    {
        private ExamController examController=new ExamController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();
        private int selectedExamId = -1;
        public ExamForm()
        {
            InitializeComponent();
            Exam_dateTimePicker.Format = DateTimePickerFormat.Custom;
            Exam_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            LoadExams();
            LoadCourses();
            this.CourseName_comboBox.SelectedIndexChanged += new System.EventHandler(this.CourseName_comboBox_SelectedIndexChanged);

        }
        private void LoadExams()
        {
            Exam_dataGridView.DataSource = null;
            Exam_dataGridView.DataSource = examController.GetAllExams(); // assumes GetAllExams() returns List<Exam>

            Exam_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Exam_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hide internal IDs
            if (Exam_dataGridView.Columns["Subject_ID"] != null)
                Exam_dataGridView.Columns["Subject_ID"].Visible = false;

            if (Exam_dataGridView.Columns["Course_ID"] != null)
                Exam_dataGridView.Columns["Course_ID"].Visible = false;

            // Set readable headers
            if (Exam_dataGridView.Columns["Exam_Name"] != null)
                Exam_dataGridView.Columns["Exam_Name"].HeaderText = "Exam Name";

            if (Exam_dataGridView.Columns["Exam_Date"] != null)
                Exam_dataGridView.Columns["Exam_Date"].HeaderText = "Date";

            if (Exam_dataGridView.Columns["Subject_Name"] != null)
                Exam_dataGridView.Columns["Subject_Name"].HeaderText = "Subject";

            if (Exam_dataGridView.Columns["Course_Name"] != null)
                Exam_dataGridView.Columns["Course_Name"].HeaderText = "Course";

            Exam_dataGridView.ClearSelection();
        }
        private void ClearExamForm()
        {                           
            Examname_textBox.Text = string.Empty;
            Exam_dateTimePicker.Value = DateTime.Today;     
            Subjectname_comboBox.SelectedIndex = -1;               
            CourseName_comboBox.SelectedIndex = -1;                 
        }
        private void LoadCourses()
        {
            var courses = courseController.GetAllCourses();
            CourseName_comboBox.DataSource = courses;
            CourseName_comboBox.DisplayMember = "Course_Name";
            CourseName_comboBox.ValueMember = "Course_ID";
            CourseName_comboBox.SelectedIndex = -1;
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
                Subjectname_comboBox.DataSource = null;
            }
        }
        private void LoadSubjectsByCourseId(int courseId)
        {
            var subjects = subjectController.GetSubjectsByCourseId(courseId);
            Subjectname_comboBox.DataSource = subjects;
            Subjectname_comboBox.DisplayMember = "Subject_Name";
            Subjectname_comboBox.ValueMember = "Subject_ID";
            Subjectname_comboBox.SelectedIndex = -1;
        }
        private void ExamInsert_button_Click(object sender, EventArgs e)
        {
            string examName = Examname_textBox.Text.Trim();
            string examDate = Exam_dateTimePicker.Value.ToString("yyyy-MM-dd");
            int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);
            int subjectId = Convert.ToInt32(Subjectname_comboBox.SelectedValue);
            

            if (string.IsNullOrEmpty(examName))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            bool isSuccess = examController.InsertExam(examName, examDate, subjectId, courseId);

            if (isSuccess)
            {
                MessageBox.Show("Exam inserted successfully.");
                // Optionally clear the form or refresh the exam list
            }
            else
            {
                MessageBox.Show("Failed to insert exam.");
            }
            LoadExams();
        }

        private void ExamUpdate_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExamId == -1)
                {
                    MessageBox.Show("Please select an exam to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string examName = Examname_textBox.Text.Trim();
                string examDate = Exam_dateTimePicker.Value.ToString("yyyy-MM-dd"); // or include time if needed
                int subjectId = Convert.ToInt32(Subjectname_comboBox.SelectedValue);
                int courseId = Convert.ToInt32(CourseName_comboBox.SelectedValue);

                if (string.IsNullOrWhiteSpace(examName))
                {
                    MessageBox.Show("Please enter the exam name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool updated = examController.UpdateExam(selectedExamId, examName, examDate, subjectId, courseId);

                if (updated)
                {
                    MessageBox.Show("Exam updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExams();     // Refresh DataGridView or list
                    ClearExamForm(); // Reset form fields
                    selectedExamId = -1;
                    Examname_textBox.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update exam.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exam_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Exam_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Exam_dataGridView.SelectedRows[0];

                // Assuming your columns are named "Exam_ID", "Exam_Name", "Exam_Date", "Subject_ID", and "Course_ID"
                selectedExamId = Convert.ToInt32(selectedRow.Cells["Exam_ID"].Value);
                Examname_textBox.Text = selectedRow.Cells["Exam_Name"].Value.ToString();
                Exam_dateTimePicker.Value = DateTime.Parse(selectedRow.Cells["Exam_Date"].Value.ToString());
                CourseName_comboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells["Course_ID"].Value);
                Subjectname_comboBox.SelectedValue = Convert.ToInt32(selectedRow.Cells["Subject_ID"].Value);
                
            }
            else
            {
                // No row selected — clear form or reset variables
                selectedExamId = -1;
                ClearExamForm(); // Resets all fields
            }
        }

        private void ExamDelete_button_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                examController.DeleteExam(selectedExamId);
                LoadExams();       
                selectedExamId = -1;
            }
        }
    }
}
