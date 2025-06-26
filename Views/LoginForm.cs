using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.View
{
    public partial class LoginForm : Form
    {
        private readonly LoginController loginController;
        private readonly AttendanceController attendanceController;

        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            attendanceController = new AttendanceController();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = Username_textBox.Text.Trim();
            string password = Password_textBox.Text.Trim();

            var user = loginController.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Name}! Role: {user.Role}");

                try
                {
                    if (user.Role == "Student")
                    {
                        
                        string attendanceName = user.Name;
                        string attendanceRole = user.Role;
                        string attendanceTime = DateTime.Now.ToString();
                        int studentId = user.Student_ID;
                        int courseId = user.Course_ID;
                        int lecturerId = user.Lecturer_ID;

                        attendanceController.InsertAttendance(attendanceName, attendanceRole, attendanceTime, courseId, studentId, lecturerId);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error recording attendance:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
