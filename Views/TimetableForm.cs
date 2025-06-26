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
        private RoomController roomController = new RoomController();
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
            LoadRooms();
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
            LoadCourses();
            LoadSubjects();

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
                t.Subject_ID,       // Include ID for internal use
                t.Course_name,
                t.Course_ID,        // Include ID for internal use
                t.Lecturer_Name,
                t.Lecturer_ID,      // Include ID for internal use
                t.Room_Name,
                t.Room_ID           // Include ID for internal use
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

            // Hide ID columns to keep UI clean
            TimeTabledataGridView.Columns["Subject_ID"].Visible = false;
            TimeTabledataGridView.Columns["Course_ID"].Visible = false;
            TimeTabledataGridView.Columns["Lecturer_ID"].Visible = false;
            TimeTabledataGridView.Columns["Room_ID"].Visible = false;


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
        private void LoadRooms()
        {
            var rooms = roomController.GetAllRooms();
            TTRoomName_comboBox.DataSource = rooms;
            TTRoomName_comboBox.DisplayMember = "Room_Name";
            TTRoomName_comboBox.ValueMember = "Room_ID";
            TTRoomName_comboBox.SelectedIndex = -1;
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
            try
            {
                string selectedDate = TTDate_dateTimePicker.Value.ToString("yyyy-MM-dd");
                string selectedSlot = TTSolt_comboBox.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedSlot))
                {
                    MessageBox.Show("Please select a time slot.");
                    return;
                }

                if (TTSubject_comboBox.SelectedValue == null ||
                    TTCourse_comboBox.SelectedValue == null ||
                    TTLecturer_comboBox.SelectedValue == null ||
                    TTRoomName_comboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select all required dropdowns.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(TTRoomName_comboBox.SelectedValue.ToString(), out int selectedRoomId) ||
                    !int.TryParse(TTSubject_comboBox.SelectedValue.ToString(), out int subjectId) ||
                    !int.TryParse(TTCourse_comboBox.SelectedValue.ToString(), out int courseId) ||
                    !int.TryParse(TTLecturer_comboBox.SelectedValue.ToString(), out int lecturerId))
                {
                    MessageBox.Show("Invalid selection in one of the dropdowns.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Subject_ID = subjectId,
                    Course_ID = courseId,
                    Lecturer_ID = lecturerId,
                    Room_ID = selectedRoomId
                };

                bool success = timetableController.AddTimetable(t);
                LoadTimetables();

                if (success)
                    MessageBox.Show("Timetable saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to save timetable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\n" +
                                "Message: " + ex.Message + "\n\n" +
                                "Source: " + ex.Source + "\n\n" +
                                "Stack Trace:\n" + ex.StackTrace,
                                "Unhandled Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TTUpdate_button_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TTDate_dateTimePicker.Text) ||
                string.IsNullOrEmpty(TTSolt_comboBox.SelectedItem?.ToString()) ||
                TTSubject_comboBox.SelectedValue == null ||
                TTCourse_comboBox.SelectedValue == null ||
                TTLecturer_comboBox.SelectedValue == null ||
                TTRoomName_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Timetable t = new Timetable
                {
                    Timetable_ID = selectedTimetableId,
                    Timetable_Date = TTDate_dateTimePicker.Value.ToString("yyyy-MM-dd"),
                    Timetable_Slot = TTSolt_comboBox.SelectedItem.ToString(),
                    Subject_ID = Convert.ToInt32(TTSubject_comboBox.SelectedValue),
                    Course_ID = Convert.ToInt32(TTCourse_comboBox.SelectedValue),
                    Lecturer_ID = Convert.ToInt32(TTLecturer_comboBox.SelectedValue),
                    Room_ID = Convert.ToInt32(TTRoomName_comboBox.SelectedValue)
                };

                bool updated = timetableController.UpdateTimetable(t);

                if (updated)
                    MessageBox.Show("Timetable updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update timetable. Record might not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void TimeTabledataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TimeTabledataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = TimeTabledataGridView.SelectedRows[0];

                    if (selectedRow.Cells["Timetable_ID"].Value != null &&
                        int.TryParse(selectedRow.Cells["Timetable_ID"].Value.ToString(), out int timetableId))
                    {
                        selectedTimetableId = timetableId;
                    }
                    else
                    {
                        selectedTimetableId = -1;
                        return;
                    }

                    // Set Date
                    if (selectedRow.Cells["Timetable_Date"].Value != null &&
                        DateTime.TryParse(selectedRow.Cells["Timetable_Date"].Value.ToString(), out DateTime date))
                    {
                        TTDate_dateTimePicker.Value = date;
                    }
                    else
                    {
                        TTDate_dateTimePicker.Value = DateTime.Today;
                    }

                    // Set Slot
                    string slot = selectedRow.Cells["Timetable_Slot"].Value?.ToString();
                    TTSolt_comboBox.SelectedItem = !string.IsNullOrEmpty(slot) ? slot : null;

                    // Parse IDs
                    int.TryParse(selectedRow.Cells["Course_ID"]?.Value?.ToString(), out int courseId);
                    int.TryParse(selectedRow.Cells["Subject_ID"]?.Value?.ToString(), out int subjectId);
                    int.TryParse(selectedRow.Cells["Lecturer_ID"]?.Value?.ToString(), out int lecturerId);
                    int.TryParse(selectedRow.Cells["Room_ID"]?.Value?.ToString(), out int roomId);

                    // Temporarily remove events to prevent overwriting
                    TTCourse_comboBox.SelectedIndexChanged -= TTCourse_comboBox_SelectedIndexChanged;
                    TTSubject_comboBox.SelectedIndexChanged -= TTSubject_comboBox_SelectedIndexChanged;

                    // Set Course
                    TTCourse_comboBox.SelectedValue = courseId;

                    // Load and set Subject for course
                    LoadSubjectsByCourseId(courseId);
                    TTSubject_comboBox.SelectedValue = subjectId;

                    // Load and set Lecturer for subject
                    LoadLecturersBySubjectId(subjectId);
                    TTLecturer_comboBox.SelectedValue = lecturerId;

                    // Set Room
                    TTRoomName_comboBox.SelectedValue = roomId;

                    // Reattach events
                    TTCourse_comboBox.SelectedIndexChanged += TTCourse_comboBox_SelectedIndexChanged;
                    TTSubject_comboBox.SelectedIndexChanged += TTSubject_comboBox_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading selected timetable details:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                selectedTimetableId = -1;
                TTDate_dateTimePicker.Value = DateTime.Today;
                TTSolt_comboBox.SelectedIndex = -1;
                TTSubject_comboBox.SelectedIndex = -1;
                TTCourse_comboBox.SelectedIndex = -1;
                TTLecturer_comboBox.SelectedIndex = -1;
                TTRoomName_comboBox.SelectedIndex = -1;
            }
        }

        private void TTDelete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTimetableId == -1)
                {
                    MessageBox.Show("Please select a timetable entry to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this timetable entry?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool deleted = timetableController.DeleteTimetable(selectedTimetableId);

                    if (deleted)
                    {
                        MessageBox.Show("Timetable entry deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedTimetableId = -1;
                        LoadTimetables();

                        // Optionally reset form fields
                        TTDate_dateTimePicker.Value = DateTime.Today;
                        TTSolt_comboBox.SelectedIndex = -1;
                        TTSubject_comboBox.SelectedIndex = -1;
                        TTCourse_comboBox.SelectedIndex = -1;
                        TTLecturer_comboBox.SelectedIndex = -1;
                        TTRoomName_comboBox.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete timetable entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while deleting.\n\nDetails: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TTSearch_button_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = TTSearch_textBox.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Please enter a keyword to search.", "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var allTimetables = timetableController.GetAllTimetables();

                var filtered = allTimetables.Where(t =>
                    (!string.IsNullOrEmpty(t.Subject_Name) && t.Subject_Name.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(t.Course_name) && t.Course_name.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(t.Lecturer_Name) && t.Lecturer_Name.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(t.Room_Name) && t.Room_Name.ToLower().Contains(keyword))
                ).Select(t => new
                {
                    t.Timetable_ID,
                    t.Timetable_Date,
                    t.Timetable_Slot,
                    t.Subject_Name,
                    t.Subject_ID,
                    t.Course_name,
                    t.Course_ID,
                    t.Lecturer_Name,
                    t.Lecturer_ID,
                    t.Room_Name,
                    t.Room_ID
                }).ToList();

                TimeTabledataGridView.DataSource = null;
                TimeTabledataGridView.DataSource = filtered;

                TimeTabledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                TimeTabledataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                TimeTabledataGridView.Columns["Timetable_ID"].HeaderText = "ID";
                TimeTabledataGridView.Columns["Timetable_Date"].HeaderText = "Date";
                TimeTabledataGridView.Columns["Timetable_Slot"].HeaderText = "Slot";
                TimeTabledataGridView.Columns["Subject_Name"].HeaderText = "Subject";
                TimeTabledataGridView.Columns["Course_name"].HeaderText = "Course";
                TimeTabledataGridView.Columns["Lecturer_Name"].HeaderText = "Lecturer";
                TimeTabledataGridView.Columns["Room_Name"].HeaderText = "Room";

                // Hide internal use columns
                TimeTabledataGridView.Columns["Subject_ID"].Visible = false;
                TimeTabledataGridView.Columns["Course_ID"].Visible = false;
                TimeTabledataGridView.Columns["Lecturer_ID"].Visible = false;
                TimeTabledataGridView.Columns["Room_ID"].Visible = false;

                TimeTabledataGridView.ClearSelection();

                if (filtered.Count == 0)
                {
                    MessageBox.Show("No matching results found for: " + keyword, "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching.\n\nDetails: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

    
}
