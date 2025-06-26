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

namespace Unicom_TIC_Management_System.Views
{
    public partial class UserDetails : Form
    {
        private readonly UserController userController = new UserController();
        
        public UserDetails()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            var users = userController.GetAllUsers();

            if (users != null && users.Count > 0)
            {
                UserDetailsdataGridView.DataSource = null;
                UserDetailsdataGridView.DataSource = users;

                UserDetailsdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                UserDetailsdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Hide the ID columns
                if (UserDetailsdataGridView.Columns["Student_ID"] != null)
                    UserDetailsdataGridView.Columns["Student_ID"].Visible = false;

                if (UserDetailsdataGridView.Columns["Lecturer_ID"] != null)
                    UserDetailsdataGridView.Columns["Lecturer_ID"].Visible = false;

                if (UserDetailsdataGridView.Columns["Course_ID"] != null)
                    UserDetailsdataGridView.Columns["Course_ID"].Visible = false;

                // Optional: Rename headers for display clarity
                if (UserDetailsdataGridView.Columns["Student_Name"] != null)
                    UserDetailsdataGridView.Columns["Student_Name"].HeaderText = "Student";

                if (UserDetailsdataGridView.Columns["Lecturer_Name"] != null)
                    UserDetailsdataGridView.Columns["Lecturer_Name"].HeaderText = "Lecturer";

                if (UserDetailsdataGridView.Columns["Course_Name"] != null)
                    UserDetailsdataGridView.Columns["Course_Name"].HeaderText = "Course";

                UserDetailsdataGridView.ClearSelection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
