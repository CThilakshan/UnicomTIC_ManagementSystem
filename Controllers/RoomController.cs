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
    internal class RoomController
    {
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            using (var conn = DBConnection.GetConnection())
            {
                
                var cmd = new SQLiteCommand("SELECT * FROM Rooms", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Room room = new Room
                    {
                        Room_ID = reader.GetInt32(0),
                        Room_Name = reader.GetString(1),
                        Room_Type = reader.GetString(2),
                    };

                    rooms.Add(room);
                }
            }

            return rooms;
        }

        public void InsertRoom(string room_name, string room_type)
        {
            string insertQuery = "INSERT INTO Rooms (Room_Name, Room_Type) VALUES (@Room_Name, @Room_Type)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    // conn.Open();  <-- Remove this line because connection is already opened inside GetConnection()

                    using (var cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_Name", room_name);
                        cmd.Parameters.AddWithValue("@Room_Type", room_type);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Room inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the room:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateRoom(int room_id, string room_name, string room_type)
        {
            string updateQuery = "UPDATE Rooms SET Room_Name = @Room_Name, Room_Type = @Room_Type WHERE Room_ID = @Room_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    // conn.Open(); // Removed because connection is already opened in GetConnection()

                    using (var cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_Name", room_name);
                        cmd.Parameters.AddWithValue("@Room_Type", room_type);
                        cmd.Parameters.AddWithValue("@Room_ID", room_id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No room found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the room:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteRoom(int room_id)
        {
            string deleteQuery = "DELETE FROM Rooms WHERE Room_ID = @Room_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    // conn.Open(); // Removed because GetConnection() already opens the connection

                    using (var cmd = new SQLiteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_ID", room_id);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No room found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the room:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Room> SearchRooms(string keyword)
        {
            var rooms = new List<Room>();

            string query = "SELECT * FROM Rooms WHERE Room_Name LIKE @Keyword OR Room_Type LIKE @Keyword";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    // Use % wildcards for partial matching
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room
                            {
                                Room_ID = reader.GetInt32(0),
                                Room_Name = reader.GetString(1),
                                Room_Type = reader.GetString(2)
                            };
                            rooms.Add(room);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching rooms:\n" + ex.Message,
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rooms;
        }
        public Room GetRoomById(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                // conn.Open(); // Removed, connection is already opened by GetConnection()

                var cmd = new SQLiteCommand("SELECT * FROM Rooms WHERE Room_ID = @Room_ID", conn);
                cmd.Parameters.AddWithValue("@Room_ID", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Room
                        {
                            Room_ID = reader.GetInt32(0),
                            Room_Name = reader.GetString(1),
                            Room_Type = reader.GetString(2)
                        };
                    }
                }
            }

            return null;
        }

    }

}
