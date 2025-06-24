using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.View;
using Unicom_TIC_Management_System.Views;

namespace Unicom_TIC_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
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
            LoadForm(new TimetableForm());
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
            LoadForm(new StudentForm());
        }

        private void lblecturer_Click(object sender, EventArgs e)
        {
            LoadForm(new LecturerForm());
        }

        private void lbstaff_Click(object sender, EventArgs e)
        {
            LoadForm(new StaffForm());
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
