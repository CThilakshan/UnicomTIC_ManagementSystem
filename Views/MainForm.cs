using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.View;
using Unicom_TIC_Management_System.Views;

namespace Unicom_TIC_Management_System
{
    public partial class MainForm : Form
    {

        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserDetails();
            
        }
        
        private void LoadUserDetails()
        {
            // student access restrictions
            if (currentUser.Role == "Student")
            {
                Course_label.Enabled = false;
                Attendance_label.Enabled = false;
                UserDetails_label.Enabled = false;
                lecturer_label.Enabled = false;
                Staff_Label.Enabled = false;
                lbmark.Enabled = false;
                lbexam.Enabled = false;
            }
            else if (currentUser.Role == "Lecturer")
            {
                Course_label.Enabled = false;
                Attendance_label.Enabled = false;
                UserDetails_label.Enabled = false;
                Staff_Label.Enabled = false;
                lbmark.Enabled = false;
                lbexam.Enabled = false;
                lbstudent.Enabled = false;

            }
            else if (currentUser.Role == "Staff")
            {
                Course_label.Enabled = false;
                Attendance_label.Enabled = false;
                UserDetails_label.Enabled = false;
                lbmark.Enabled = false;
                lbexam.Enabled = false;
            }
            
        }
        public void LoadForm(object formObj)
        {
            if (this.Centerpanel.Controls.Count > 0)
            {
                this.Centerpanel.Controls.RemoveAt(0);
            }

            if (formObj is Form form)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.Centerpanel.Controls.Add(form);
                this.Centerpanel.Tag = form;
                form.Show();
                form.BringToFront();
            }

        }

        private void lbtimetable_Click(object sender, EventArgs e)
        {
            var timetableForm = new TimetableForm(currentUser);
            LoadForm(timetableForm);
        }

        private void lbexam_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamForm());
        }

        private void lbmark_Click(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }

        private void lbCourse_Click(object sender, EventArgs e)
        {
            LoadForm(new CourseForm());
        }

        private void lbstudent_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm(currentUser);
            LoadForm(studentForm);
        }

        private void lblecturer_Click(object sender, EventArgs e)
        {
            var lecturerForm = new LecturerForm(currentUser);
            LoadForm(lecturerForm);
        }

        private void lbstaff_Click(object sender, EventArgs e)
        {
            var staffForm = new StaffForm(currentUser);
            LoadForm(staffForm);
        }

        private void Logoutlabel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Attendance_label_Click(object sender, EventArgs e)
        {
            LoadForm(new AttendanceForm());
        }

        private void User_label_Click(object sender, EventArgs e)
        {
            LoadForm(new UserDetails());
        }
    }
}
