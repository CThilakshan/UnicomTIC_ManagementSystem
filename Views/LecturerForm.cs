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
    public partial class LecturerForm : Form
    {
        private LecturerController lecturerController = new LecturerController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();

        private int selectedUserId = -1;
        private int selectedLecturerId = -1;

        public LecturerForm()
        {
            InitializeComponent();
            this.Load += LecturerForm_Load; // Properly attach the Load event
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

        private void Insert_button_Click(object sender, EventArgs e)
        {
            // Placeholder for inserting lecturer logic
            // You should validate input and call lecturerController.InsertLecturer(...)
        }
    }
}
