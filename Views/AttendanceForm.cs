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

namespace Unicom_TIC_Management_System.Views
{
    public partial class AttendanceForm : Form
    {
        private readonly AttendanceController attendanceController = new AttendanceController();
        public AttendanceForm()
        {
            InitializeComponent();
            LoadAttendance(); // Load attendance data when the form is initialized
        }
        private void LoadAttendance()
        {
            var attendances = attendanceController.GetAllAttendances();

            if (attendances != null && attendances.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = attendances;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Hide ID columns
                if (dataGridView1.Columns["Student_ID"] != null)
                    dataGridView1.Columns["Student_ID"].Visible = false;

                if (dataGridView1.Columns["Lecturer_ID"] != null)
                    dataGridView1.Columns["Lecturer_ID"].Visible = false;

                if (dataGridView1.Columns["Course_ID"] != null)
                    dataGridView1.Columns["Course_ID"].Visible = false;

                // Rename headers for display clarity
                if (dataGridView1.Columns["Student_Name"] != null)
                    dataGridView1.Columns["Student_Name"].HeaderText = "Student";

                if (dataGridView1.Columns["Lecturer_Name"] != null)
                    dataGridView1.Columns["Lecturer_Name"].HeaderText = "Lecturer";

                if (dataGridView1.Columns["Course_Name"] != null)
                    dataGridView1.Columns["Course_Name"].HeaderText = "Course";

                if (dataGridView1.Columns["Attendance_Name"] != null)
                    dataGridView1.Columns["Attendance_Name"].HeaderText = "Name";

                if (dataGridView1.Columns["Attendance_Role"] != null)
                    dataGridView1.Columns["Attendance_Role"].HeaderText = "Role";

                if (dataGridView1.Columns["Attendance_Time"] != null)
                    dataGridView1.Columns["Attendance_Time"].HeaderText = "Time";

                dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void Search_Textbox_Click(object sender, EventArgs e)
        {
            string searchTerm = Search_textBox.Text.Trim();
            var attendances = attendanceController.SearchAttendances(searchTerm);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = attendances;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Hide ID columns
            if (dataGridView1.Columns["Student_ID"] != null)
                dataGridView1.Columns["Student_ID"].Visible = false;
            if (dataGridView1.Columns["Lecturer_ID"] != null)
                dataGridView1.Columns["Lecturer_ID"].Visible = false;
            if (dataGridView1.Columns["Course_ID"] != null)
                dataGridView1.Columns["Course_ID"].Visible = false;

            // Rename headers
            if (dataGridView1.Columns["Student_Name"] != null)
                dataGridView1.Columns["Student_Name"].HeaderText = "Student";
            if (dataGridView1.Columns["Lecturer_Name"] != null)
                dataGridView1.Columns["Lecturer_Name"].HeaderText = "Lecturer";
            if (dataGridView1.Columns["Course_Name"] != null)
                dataGridView1.Columns["Course_Name"].HeaderText = "Course";
            if (dataGridView1.Columns["Attendance_Name"] != null)
                dataGridView1.Columns["Attendance_Name"].HeaderText = "Name";
            if (dataGridView1.Columns["Attendance_Role"] != null)
                dataGridView1.Columns["Attendance_Role"].HeaderText = "Role";
            if (dataGridView1.Columns["Attendance_Time"] != null)
                dataGridView1.Columns["Attendance_Time"].HeaderText = "Time";

            dataGridView1.ClearSelection();
        }
    }
}
