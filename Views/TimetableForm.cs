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
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Views;
using static Unicom_TIC_Management_System.Controllers.TimetableController;

namespace Unicom_TIC_Management_System.View
{
    public partial class TimetableForm : Form
    {
        private User currentUser;
        private TimetableController timetableController = new TimetableController();
        private LecturerController lecturerController = new LecturerController();
        private CourseController courseController = new CourseController();
        private SubjectController subjectController = new SubjectController();
        private int selectedTimetableId = -1;


        
        public TimetableForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            HideTimetablePanelIfNotAdmin();
            LoadTimetables();
            LoadCourses();
            LoadLecturers();
            LoadSubjects();
            TTCourse_comboBox.SelectedIndexChanged += TTCourse_comboBox_SelectedIndexChanged;
            TTSubject_comboBox.SelectedIndexChanged += TTSubject_comboBox_SelectedIndexChanged;
        }
        // Hide timetable panel for non-admins
        private void HideTimetablePanelIfNotAdmin()
        {
            if (currentUser != null &&
                (currentUser.Role == "Student" || currentUser.Role == "Lecturer" || currentUser.Role == "Staff"))
            {
                timetable_panel.Visible = false;
            }
        }

        public void HideTimetablePanel()
        {
            timetable_panel.Visible = false;
        }
        public void LoadForm(object formObj)
        {
            if (this.TimeTableCenter_panel.Controls.Count > 0)
            {
                this.TimeTableCenter_panel.Controls.RemoveAt(0);
            }

            if (formObj is Form form)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.TimeTableCenter_panel.Controls.Add(form);
                this.TimeTableCenter_panel.Tag = form;
                form.Show();
                form.BringToFront();
            }

        }
        private void LoadTimetables()
        {
            TTSolt_comboBox.DataSource = SlotManager.GetTimeSlots();
            var allTimetables = timetableController.GetAllTimetables();

            var displayList = allTimetables.Select(t => new
            {
                t.Timetable_ID,
                t.Timetable_Date,
                t.Timetable_Slot,
                t.Subject_Name,
                t.Course_name,
                t.Lecturer_Name,
                t.Room_Name
            }).ToList();

            TimeTabledataGridView.DataSource = null;
            TimeTabledataGridView.DataSource = displayList;

            TimeTabledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TimeTabledataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            TimeTabledataGridView.Columns["Timetable_ID"].HeaderText = "ID";
            TimeTabledataGridView.Columns["Timetable_Date"].HeaderText = "Date";
            TimeTabledataGridView.Columns["Timetable_Slot"].HeaderText = "Slot";
            TimeTabledataGridView.Columns["Subject_Name"].HeaderText = "Subject";
            TimeTabledataGridView.Columns["Course_name"].HeaderText = "Course";
            TimeTabledataGridView.Columns["Lecturer_Name"].HeaderText = "Lecturer";
            TimeTabledataGridView.Columns["Room_Name"].HeaderText = "Room";

            TimeTabledataGridView.ClearSelection();
        }
        private void LoadCourses()
        {
            var courses = courseController.GetAllCourses();
            TTCourse_comboBox.DataSource = courses;
            TTCourse_comboBox.DisplayMember = "Course_Name";
            TTCourse_comboBox.ValueMember = "Course_ID";
            TTCourse_comboBox.SelectedIndex = -1;
        }
        private void LoadLecturers()
        {
            var lecturers = lecturerController.GetAllLecturers();
            TTLecturer_comboBox.DataSource = lecturers;
            TTLecturer_comboBox.DisplayMember = "Lecturer_Name";
            TTLecturer_comboBox.ValueMember = "Lecturer_ID";
            TTLecturer_comboBox.SelectedIndex = -1;
        }

        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            TTSubject_comboBox.DataSource = subjects;
            TTSubject_comboBox.DisplayMember = "Subject_Name";
            TTSubject_comboBox.ValueMember = "Subject_ID";
            TTSubject_comboBox.SelectedIndex = -1;
        }

        private void LoadSubjectsByCourseId(int courseId)
        {
            var subjects = subjectController.GetSubjectsByCourseId(courseId);
            TTSubject_comboBox.DataSource = subjects;
            TTSubject_comboBox.DisplayMember = "Subject_Name";
            TTSubject_comboBox.ValueMember = "Subject_ID";
            TTSubject_comboBox.SelectedIndex = -1;
        }
        
        private void LoadLecturersBySubjectId(int subjectId)
        {
            var lecturers = lecturerController.GetLecturersBySubjectId(subjectId);

            if (lecturers == null || lecturers.Count == 0)
            {
                MessageBox.Show($"No lecturers found for Subject ID {subjectId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TTLecturer_comboBox.DataSource = null;
            TTLecturer_comboBox.DataSource = lecturers;
            TTLecturer_comboBox.DisplayMember = "Lecturer_Name";
            TTLecturer_comboBox.ValueMember = "Lecturer_ID";
            TTLecturer_comboBox.SelectedIndex = -1;
        }

        private void TTCourse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TTCourse_comboBox.SelectedIndex != -1)
            {
                int selectedCourseId = Convert.ToInt32(TTCourse_comboBox.SelectedValue);
                LoadSubjectsByCourseId(selectedCourseId);

                // Clear lecturers when course changes
                TTLecturer_comboBox.DataSource = null;
                TTLecturer_comboBox.Items.Clear();
            }
            else
            {
                TTSubject_comboBox.DataSource = null;
                TTLecturer_comboBox.DataSource = null;
            }
        }
       
         private void TTSubject_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TTSubject_comboBox.SelectedIndex != -1)
            {
                int selectedSubjectId = Convert.ToInt32(TTSubject_comboBox.SelectedValue);
                LoadLecturersBySubjectId(selectedSubjectId);
            }
            else
            {
                TTLecturer_comboBox.DataSource = null;
            }
        }
        


        private void Room_button_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomForm(this));
        }

        private void timetable_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CourseInsert_button_Click(object sender, EventArgs e)
        {
            string selectedDate = TTDate_dateTimePicker.Value.ToString("yyyy-MM-dd");
            string selectedSlot = TTSolt_comboBox.SelectedItem?.ToString();
            int selectedRoomId = Convert.ToInt32(TTRoomName_comboBox.SelectedValue);

            if (string.IsNullOrEmpty(selectedSlot))
            {
                MessageBox.Show("Please select a time slot.");
                return;
            }

            if (!timetableController.IsRoomSlotAvailable(selectedDate, selectedSlot, selectedRoomId))
            {
                MessageBox.Show("This room is already booked at this date and time.", "Room Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Timetable t = new Timetable
            {
                Timetable_Date = selectedDate,
                Timetable_Slot = selectedSlot,
                Subject_ID = Convert.ToInt32(TTSubject_comboBox.SelectedValue),
                Course_ID = Convert.ToInt32(TTCourse_comboBox.SelectedValue),
                Lecturer_ID = Convert.ToInt32(TTLecturer_comboBox.SelectedValue),
                Room_ID = selectedRoomId
            };

            bool success = timetableController.AddTimetable(t);

            if (success)
                MessageBox.Show("Timetable saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to save timetable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    
}
