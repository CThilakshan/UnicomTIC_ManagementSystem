using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Model;


namespace Unicom_TIC_Management_System.View
{
    public partial class CourseForm : Form
    {
        private CourseController courseController = new CourseController();
        private SubjectController subjectController= new SubjectController();
        private int selectedCourseId = -1;
        private int selectedSubjectId = -1;

        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
            Loadcourses();
            LoadSubjects();

        }
        private void LoadCourses()
        {
            CoursedataGridView.DataSource = null;
            CoursedataGridView.DataSource = courseController.GetAllCourses();

            // Set column width to fit the content
            CoursedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Optional: Adjust row height too
            CoursedataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Optional: Deselect all rows after loading
            CoursedataGridView.ClearSelection();
        }
        private void LoadSubjects()
        {
            Subject_dataGridView.DataSource = null;
            Subject_dataGridView.DataSource = subjectController.GetAllSubjects();

            Subject_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Subject_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set column headers
            Subject_dataGridView.Columns["Subject_ID"].HeaderText = "Subject ID";
            Subject_dataGridView.Columns["Subject_Name"].HeaderText = "Subject Name";
            Subject_dataGridView.Columns["Course_Name"].HeaderText = "Course Name";

            // ✅ Hide Course_ID column
            if (Subject_dataGridView.Columns.Contains("Course_ID"))
            {
                Subject_dataGridView.Columns["Course_ID"].Visible = false;
            }

            Subject_dataGridView.ClearSelection();
        }
        private void Loadcourses()
        {
            var courses = courseController.GetAllCourses();
            Course_NamecomboBox.DataSource = courses;
            Course_NamecomboBox.DisplayMember = "Course_Name";  // Show this in the dropdown
            Course_NamecomboBox.ValueMember = "Course_ID";      // This is the internal value
        }


        private void ClearForm()
        {
            Course_name_textBox.Clear();
            
        }

        private void student_menu_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CourseInsert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName =Course_name_textBox.Text.Trim();

                if (string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Please enter a course name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CourseController incourse = new CourseController();
                incourse.InsertCourse(courseName);

                // Optional: clear the textbox after insertion
                LoadCourses();
                ClearForm();

                Course_name_textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            Course_name_textBox.Text = "";
            
        }
        private void CoursedataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CoursedataGridView.SelectedRows.Count > 0)
            {
                var row = CoursedataGridView.SelectedRows[0];
                var courseView = row.DataBoundItem as Course;

                if (courseView != null)
                {
                    selectedCourseId = courseView.Course_ID;

                    var course = courseController.GetCourseById(selectedCourseId);
                    if (course != null)
                    {
                        Course_name_textBox.Text = course.Course_Name;
                    }
                }
            }
            else
            {
                ClearInputs();
                selectedCourseId = -1;
            }

        }

        private void CourseUpdate_button_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = Course_name_textBox.Text.Trim();

                if (string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Please enter a course name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedCourseId <= 0)
                {
                    MessageBox.Show("Please select a course to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CourseController courseController = new CourseController();
                courseController.UpdateCourse(selectedCourseId, courseName);
                LoadCourses();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CourseDelete_button_Click(object sender, EventArgs e)
        {
            if (selectedCourseId <= 0)
            {
                MessageBox.Show("Please select a course to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CourseController courseController = new CourseController();
                courseController.DeleteCourse(selectedCourseId);
                LoadCourses();
                ClearForm(); // Optional: clear form after delete
                             // RefreshDataGridView(); // Optional: if you're showing the list
            }
        }

        private void CourseSearch_button_Click(object sender, EventArgs e)
        {
            string keyword = Course_name_textBox.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CourseController courseController = new CourseController();
            var searchResults = courseController.SearchCoursesByName(keyword);

            CoursedataGridView.DataSource = searchResults; // Display search results
            LoadCourses();
        }
        private void clearinputs()
        {
            Subject_NametextBox.Clear();                     // Clear subject name textbox
            Course_NamecomboBox.SelectedIndex = -1;          // Deselect combo box
            selectedSubjectId = -1;                          // Reset selected subject ID
            Subject_dataGridView.ClearSelection();           // Deselect any selected rows
        }
        private void SubjectInsert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string subjectName = Subject_NametextBox.Text.Trim();

                if (string.IsNullOrEmpty(subjectName))
                {
                    MessageBox.Show("Please enter a subject name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Course_NamecomboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int courseId = Convert.ToInt32(Course_NamecomboBox.SelectedValue);

                SubjectController insubject = new SubjectController();
                insubject.InsertSubject(subjectName, courseId);

                clearinputs();
                
                Subject_NametextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Subject_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Subject_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Subject_dataGridView.SelectedRows.Count > 0)
            {
                var row = Subject_dataGridView.SelectedRows[0];
                var subject = row.DataBoundItem;

                if (subject != null)
                {
                    // Use reflection to extract dynamic object values
                    selectedSubjectId = (int)subject.GetType().GetProperty("Subject_ID").GetValue(subject);
                    string subjectName = (string)subject.GetType().GetProperty("Subject_Name").GetValue(subject);
                    int courseId = (int)subject.GetType().GetProperty("Course_ID").GetValue(subject);

                    Subject_NametextBox.Text = subjectName;
                    Course_NamecomboBox.SelectedValue = courseId;
                }
            }
            else
            {
                clearinputs();
                selectedSubjectId = -1;
            }
        }

        private void SubjectUpdate_button_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string subjectName = Subject_NametextBox.Text.Trim();

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please enter a subject name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Course_NamecomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId = Convert.ToInt32(Course_NamecomboBox.SelectedValue);

            try
            {
                subjectController.UpdateSubject(selectedSubjectId, subjectName, courseId);
                LoadSubjects(); // Refresh DataGridView
                clearinputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubjectDelete_button_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    subjectController.DeleteSubject(selectedSubjectId);
                    LoadSubjects();      // Refresh the DataGridView
                    clearinputs();       // Clear inputs and reset selection
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
