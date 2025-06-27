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

        }
    }
}
