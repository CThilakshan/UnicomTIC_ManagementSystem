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

namespace Unicom_TIC_Management_System.View
{
    public partial class StaffForm : Form
    {
        private StaffController staffController = new StaffController();
        private int selectedUserId = -1;
        private int selectedStaffId = -1;
        private User currentUser;


        public StaffForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadStaff();
            Hideuser();
        }
        private void Hideuser()
        {
            if (currentUser.Role == "Student" || currentUser.Role == "Lecturer"|| currentUser.Role == "Staff")
            {
                // Hide specific labels for students
                student_menu_pn.Visible = false;
                stupaswordpanel.Visible = false;


            }

        }

        private void LoadStaff()
        {
            StaffdataGridView.DataSource = null;
            StaffdataGridView.DataSource = staffController.GetAllStaff();
            StaffdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            StaffdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StaffdataGridView.ClearSelection();
        }

        private void ClearForm()
        {
            StaffFullname_textBox.Text = "";
            StaffPhoneNo_textBox.Text = "";
            StaffEmail_textBox.Text = "";
            StaffUsername_textBox.Text = "";
            StaffPassword_textBox.Text = "";
            selectedStaffId = -1;
            selectedUserId = -1;
        }

        private void StaffInsert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string staff_name = StaffFullname_textBox.Text.Trim();
                string staff_phoneno = StaffPhoneNo_textBox.Text.Trim();
                string staff_email = StaffEmail_textBox.Text.Trim();
                string staff_username = StaffUsername_textBox.Text.Trim();
                string staff_password = StaffPassword_textBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(staff_name) ||
                    string.IsNullOrWhiteSpace(staff_phoneno) ||
                    string.IsNullOrWhiteSpace(staff_email) ||
                    string.IsNullOrWhiteSpace(staff_username) ||
                    string.IsNullOrWhiteSpace(staff_password))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone, Email, Username, Password).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert into Staffs and Users tables
                staffController.InsertStaff(staff_name, staff_phoneno, staff_email); // Inserts into "Staffs"
                staffController.InsertUser(staff_name, "Staff", staff_username, staff_password); // Inserts into "Users"

                LoadStaff();
                ClearForm();
                StaffFullname_textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffUpdate_button_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff member to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string staff_name = StaffFullname_textBox.Text.Trim();
                string staff_phoneno = StaffPhoneNo_textBox.Text.Trim();
                string staff_email = StaffEmail_textBox.Text.Trim();
                string staff_username = StaffUsername_textBox.Text.Trim();
                string staff_password = StaffPassword_textBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(staff_name) ||
                    string.IsNullOrWhiteSpace(staff_phoneno) ||
                    string.IsNullOrWhiteSpace(staff_email) ||
                    string.IsNullOrWhiteSpace(staff_username) ||
                    string.IsNullOrWhiteSpace(staff_password))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Phone, Email, Username, Password).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update Staff and User records
                staffController.UpdateStaff(selectedStaffId, staff_name, staff_phoneno, staff_email);
                staffController.UpdateUser(selectedUserId, staff_name, staff_username, staff_password);

                LoadStaff();
                ClearForm();
                MessageBox.Show("Staff record updated successfully!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffDelete_button_Click(object sender, EventArgs e)
        {

            

            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this staff member?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Delete user first to avoid foreign key or dependency issues
                    staffController.DeleteUser(selectedUserId);
                    staffController.DeleteStaff(selectedStaffId);

                    LoadStaff();    // Refresh the table
                    ClearForm();    // Clear inputs

                    MessageBox.Show("Staff record deleted successfully!", "Delete Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StaffdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (StaffdataGridView.SelectedRows.Count > 0)
            {
                if (StaffdataGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = StaffdataGridView.SelectedRows[0];

                    // Update selectedStaffId from the selected row
                    selectedStaffId = Convert.ToInt32(selectedRow.Cells["Staff_ID"].Value);

                    // Populate the form fields from the selected row's data
                    StaffFullname_textBox.Text = selectedRow.Cells["Staff_Name"].Value?.ToString() ?? "";
                    StaffPhoneNo_textBox.Text = selectedRow.Cells["Staff_Phone_No"].Value?.ToString() ?? "";
                    StaffEmail_textBox.Text = selectedRow.Cells["Staff_Email"].Value?.ToString() ?? "";

                    // Clear username and password fields since we're not loading user info here
                    StaffUsername_textBox.Text = "";
                    StaffPassword_textBox.Text = "";

                    // Reset selectedUserId because we're not setting it here
                    selectedUserId = -1;
                }
                else
                {
                    // No selection, clear the form
                    ClearForm();
                }
            }
        }
    }
}   
