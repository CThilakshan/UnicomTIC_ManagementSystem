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
using Unicom_TIC_Management_System.View;

namespace Unicom_TIC_Management_System.Views
{
    public partial class RoomForm : Form
    {
        private RoomController roomController = new RoomController();
        private int selectedRoomId = -1;
        private TimetableForm timetableForm;

        

        public RoomForm(TimetableForm form)
        {
            InitializeComponent();
            timetableForm = form;
            timetableForm.HideTimetablePanel();
            LoadRooms();
        }
        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
            
        }
        private void LoadRooms()
        {
            Room_dataGridView.DataSource = null;
            Room_dataGridView.DataSource = roomController.GetAllRooms();

            // Set column width to fit the content
            Room_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Optional: Adjust row height too
            Room_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Optional: Deselect all rows after loading
            Room_dataGridView.ClearSelection();
        }

        private void RoomDetailslabel_Click(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            Room_textBox.Clear();
            Room_comboBox.SelectedIndex = -1;
            Room_textBox.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string roomName = Room_textBox.Text.Trim();
                string roomType = Room_comboBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(roomName) || string.IsNullOrWhiteSpace(roomType))
                {
                    MessageBox.Show("Please fill in all required fields (Room Name, Type).",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Use controller to insert the room
                roomController.InsertRoom(roomName, roomType);

                LoadRooms();
                ClearForm();
                Room_textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Updat_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRoomId == -1)
                {
                    MessageBox.Show("Please select a room to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string roomName = Room_textBox.Text.Trim();
                string roomType = Room_comboBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(roomName) || string.IsNullOrWhiteSpace(roomType))
                {
                    MessageBox.Show("Please fill in all required fields (Room Name, Type).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                roomController.UpdateRoom(selectedRoomId, roomName, roomType);

                LoadRooms();
                ClearForm();
                selectedRoomId = -1;  // reset after update
                Room_textBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRoomId == -1)
                {
                    MessageBox.Show("Please select a room to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    roomController.DeleteRoom(selectedRoomId);
                    LoadRooms();
                    ClearForm();
                    selectedRoomId = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            string keyword = Search_textBox.Text.Trim();

            List<Room> results;

            if (string.IsNullOrEmpty(keyword))
            {
                // If search box is empty, load all rooms
                results = roomController.GetAllRooms();
            }
            else
            {
                // Search rooms by keyword
                results = roomController.SearchRooms(keyword);
            }

            Room_dataGridView.DataSource = null;
            Room_dataGridView.DataSource = results;

            Room_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Room_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Room_dataGridView.ClearSelection();
        }
        private void Room_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Room_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Room_dataGridView.SelectedRows[0];

                // Assuming your columns are named "Room_ID", "Room_Name", and "Room_Type"
                selectedRoomId = Convert.ToInt32(selectedRow.Cells["Room_ID"].Value);
                Room_textBox.Text = selectedRow.Cells["Room_Name"].Value.ToString();
                Room_comboBox.Text = selectedRow.Cells["Room_Type"].Value.ToString();
            }
            else
            {
                // No row selected — clear form or reset variables
                selectedRoomId = -1;
                Room_textBox.Clear();
                Room_comboBox.SelectedIndex = -1;
            }
        }

        
    }
}
