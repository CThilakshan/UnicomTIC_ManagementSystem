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
    internal class TimetableController
    {
        public static class SlotManager
        {
            public static List<string> GetTimeSlots()
            {
                return new List<string>
                {
                    "08:00AM - 10:00AM",
                    "10:00AM - 12:00PM",
                    "01:00PM - 03:00PM",
                    "03:00PM - 05:00PM"
                };
            }
        }

        public List<Timetable> GetAllTimetables()
        {
            var timetables = new List<Timetable>();

            using (var conn = DBConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        t.Timetable_ID,
                        t.Timetable_Date,
                        t.Timetable_Slot,
                        t.Subject_ID,
                        s.Subject_Name,
                        t.Course_ID,
                        c.Course_Name,
                        t.Lecturer_ID,
                        l.Lecturer_Name,
                        t.Room_ID,
                        r.Room_Name
                    FROM Timetables t
                    JOIN Subjects s ON t.Subject_ID = s.Subject_ID
                    JOIN Courses c ON t.Course_ID = c.Course_ID
                    JOIN Lecturers l ON t.Lecturer_ID = l.Lecturer_ID
                    JOIN Rooms r ON t.Room_ID = r.Room_ID";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var timetable = new Timetable
                        {
                            Timetable_ID = reader.GetInt32(0),
                            Timetable_Date = reader.GetString(1),
                            Timetable_Slot = reader.GetString(2),
                            Subject_ID = reader.GetInt32(3),
                            Subject_Name = reader.GetString(4),
                            Course_ID = reader.GetInt32(5),
                            Course_name = reader.GetString(6),
                            Lecturer_ID = reader.GetInt32(7),
                            Lecturer_Name = reader.GetString(8),
                            Room_ID = reader.GetInt32(9),
                            Room_Name = reader.GetString(10)
                        };
                        timetables.Add(timetable);
                    }
                }
            }

            return timetables;
        }

        public bool IsSlotTaken(string date, string slot)
        {
            string query = @"
                SELECT COUNT(*) FROM Timetables 
                WHERE Timetable_Date = @Date AND Timetable_Slot = @Slot";

            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Slot", slot);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool IsRoomSlotTaken(string date, string slot, int roomId)
        {
            string query = @"
                SELECT COUNT(*) FROM Timetables 
                WHERE Timetable_Date = @Date AND Timetable_Slot = @Slot AND Room_ID = @RoomId";

            using (var conn = DBConnection.GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Slot", slot);
                cmd.Parameters.AddWithValue("@RoomId", roomId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool IsSlotAvailable(string date, string slot)
        {
            return !IsSlotTaken(date, slot);
        }

        public bool IsRoomSlotAvailable(string date, string slot, int roomId)
        {
            return !IsRoomSlotTaken(date, slot, roomId);
        }

        public bool AddTimetable(Timetable t)
        {
            string insertQuery = @"
                INSERT INTO Timetables 
                (Timetable_Date, Timetable_Slot, Subject_ID, Course_ID, Lecturer_ID, Room_ID) 
                VALUES 
                (@Date, @Slot, @Subject_ID, @Course_ID, @Lecturer_ID, @Room_ID)";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", t.Timetable_Date);
                    cmd.Parameters.AddWithValue("@Slot", t.Timetable_Slot);
                    cmd.Parameters.AddWithValue("@Subject_ID", t.Subject_ID);
                    cmd.Parameters.AddWithValue("@Course_ID", t.Course_ID);
                    cmd.Parameters.AddWithValue("@Lecturer_ID", t.Lecturer_ID);
                    cmd.Parameters.AddWithValue("@Room_ID", t.Room_ID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateTimetable(Timetable t)
        {
            string updateQuery = @"
                UPDATE Timetables 
                SET 
                    Timetable_Date = @Date,
                    Timetable_Slot = @Slot,
                    Subject_ID = @Subject_ID,
                    Course_ID = @Course_ID,
                    Lecturer_ID = @Lecturer_ID,
                    Room_ID = @Room_ID
                WHERE Timetable_ID = @Timetable_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", t.Timetable_Date);
                    cmd.Parameters.AddWithValue("@Slot", t.Timetable_Slot);
                    cmd.Parameters.AddWithValue("@Subject_ID", t.Subject_ID);
                    cmd.Parameters.AddWithValue("@Course_ID", t.Course_ID);
                    cmd.Parameters.AddWithValue("@Lecturer_ID", t.Lecturer_ID);
                    cmd.Parameters.AddWithValue("@Room_ID", t.Room_ID);
                    cmd.Parameters.AddWithValue("@Timetable_ID", t.Timetable_ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error occurred while updating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteTimetable(int timetableId)
        {
            string deleteQuery = "DELETE FROM Timetables WHERE Timetable_ID = @Timetable_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Timetable_ID", timetableId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error occurred while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Timetable SearchTimetableById(int timetableId)
        {
            string searchQuery = "SELECT * FROM Timetables WHERE Timetable_ID = @Timetable_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(searchQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Timetable_ID", timetableId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Timetable
                            {
                                Timetable_ID = Convert.ToInt32(reader["Timetable_ID"]),
                                Timetable_Date = reader["Timetable_Date"].ToString(),
                                Timetable_Slot = reader["Timetable_Slot"].ToString(),
                                Subject_ID = Convert.ToInt32(reader["Subject_ID"]),
                                Course_ID = Convert.ToInt32(reader["Course_ID"]),
                                Lecturer_ID = Convert.ToInt32(reader["Lecturer_ID"]),
                                Room_ID = Convert.ToInt32(reader["Room_ID"])
                            };
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Timetable GetTimetableById(int timetableId)
        {
            string query = "SELECT Timetable_ID, Timetable_Date, Timetable_Slot, Subject_ID, Course_ID, Lecturer_ID, Room_ID FROM Timetables WHERE Timetable_ID = @Timetable_ID";

            try
            {
                using (var conn = DBConnection.GetConnection())
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Timetable_ID", timetableId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idxDate = reader.GetOrdinal("Timetable_Date");
                            int idxSlot = reader.GetOrdinal("Timetable_Slot");

                            return new Timetable
                            {
                                Timetable_ID = reader.GetInt32(reader.GetOrdinal("Timetable_ID")),
                                Timetable_Date = reader.IsDBNull(idxDate) ? null : reader.GetString(idxDate),
                                Timetable_Slot = reader.IsDBNull(idxSlot) ? null : reader.GetString(idxSlot),
                                Subject_ID = reader.GetInt32(reader.GetOrdinal("Subject_ID")),
                                Course_ID = reader.GetInt32(reader.GetOrdinal("Course_ID")),
                                Lecturer_ID = reader.GetInt32(reader.GetOrdinal("Lecturer_ID")),
                                Room_ID = reader.GetInt32(reader.GetOrdinal("Room_ID"))
                            };
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error while retrieving timetable:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while retrieving timetable:\n" + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }


    
}
