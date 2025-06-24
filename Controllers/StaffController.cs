using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Model;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controllers
{
    internal class StaffController
    {
        public List<Staff> GetAllStaff()
        {
            var staffList = new List<Staff>();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT Staff_ID, Staff_Name, Staff_Phone_No, Staff_Email FROM Staffs";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Staff staff = new Staff
                                {
                                    Staff_ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                    Staff_Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                                    Staff_Phone_No = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    Staff_Email = reader.IsDBNull(3) ? "" : reader.GetString(3)
                                };

                                staffList.Add(staff);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving staff data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return staffList;
        }

        // Insert new staff
        public void InsertStaff(string name, string phone, string email)
        {
            string insertQuery = "INSERT INTO Staffs (Staff_Name, Staff_Phone_No, Staff_Email) VALUES (@Name, @Phone, @Email)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Staff inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting staff:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insert User record into Users table
        public void InsertUser(string name, string role, string username, string password)
        {
            string insertQuery = "INSERT INTO Users (Name, Role, Username, Password) VALUES (@Name, @Role, @Username, @Password)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateStaff(int staffId, string name, string phone, string email)
        {
            string updateQuery = "UPDATE Staffs SET Staff_Name = @Name, Staff_Phone_No = @Phone, Staff_Email = @Email WHERE Staff_ID = @StaffID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@StaffID", staffId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateUser(int userId, string name, string username, string password)
        {
            string updateQuery = "UPDATE Users SET Name = @Name, Username = @Username, Password = @Password WHERE User_ID = @UserID AND Role = 'Staff'";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteStaff(int staffId)
        {
            string deleteQuery = "DELETE FROM Staffs WHERE Staff_ID = @StaffID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Staff deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No staff record found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteUser(int userId)
        {
            string deleteQuery = "DELETE FROM Users WHERE User_ID = @UserID AND Role = 'Staff'";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No user record found to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Get staff by ID
        public Staff GetStaffById(int staffId)
        {
            Staff staff = null;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    string query = "SELECT Staff_ID, Staff_Name, Staff_Phone_No, Staff_Email FROM Staffs WHERE Staff_ID = @StaffID";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                staff = new Staff
                                {
                                    Staff_ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                    Staff_Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                                    Staff_Phone_No = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    Staff_Email = reader.IsDBNull(3) ? "" : reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving staff by ID:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return staff;
        }
    }
}
