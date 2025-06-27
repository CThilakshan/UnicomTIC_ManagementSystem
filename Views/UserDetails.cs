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
        private int selectedUserId; // This should be set when a user is selected from a grid or list

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

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (UserDetailsdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected user ID from DataGridView
            int userId = Convert.ToInt32(UserDetailsdataGridView.SelectedRows[0].Cells["User_ID"].Value);

            // Get values from input fields
            string username = Ususername_textBox.Text.Trim();
            string password = Uspassword_textBox.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm before update
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this user's details?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                userController.UpdateUserDetails(userId, username, password);
                LoadUser();
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (UserDetailsdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the User_ID of the selected row
            int userId = Convert.ToInt32(UserDetailsdataGridView.SelectedRows[0].Cells["User_ID"].Value);

            // Confirm delete action with the user
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Call your method to delete user
                userController.DeleteUser(userId);

                // Optional: Reload user list or refresh DataGridView after deletion
                LoadUser();  // Make sure you have this method implemented
            }
        }

        private void UserDetailsdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UserDetailsdataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = UserDetailsdataGridView.SelectedRows[0];

                // Make sure the cells are not null and contain values
                if (selectedRow.Cells["Username"].Value != null && selectedRow.Cells["Password"].Value != null)
                {
                    Usname_textBox.Text = selectedRow.Cells["Name"].Value.ToString();
                    Ususername_textBox.Text = selectedRow.Cells["Username"].Value.ToString();
                    Uspassword_textBox.Text = selectedRow.Cells["Password"].Value.ToString();
                }
            }
            else
            {
                // Clear textboxes if no row selected
                Usname_textBox.Clear();
                Ususername_textBox.Clear();
                Uspassword_textBox.Clear();
            }
        }
    }
}
