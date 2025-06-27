using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Unicom_TIC_Management_System.Repositories
{
    internal class DatabaseManager
    {
        public static void CreateTables()
        {
            using (var conn = DBConnection.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Attendances ( 
                        Attendance_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Attendance_Name TEXT NOT NULL,
                        Attendance_Role TEXT NOT NULL,
                        Attendance_Time TEXT NOT NULL,
                        Student_ID INTEGER,
                        Course_ID INTEGER ,
                        Lecturer_ID INTEGER,
                        FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID),
                        FOREIGN KEY (Lecturer_ID) REFERENCES Lecturers(Lecturer_ID)
                    );
                    CREATE TABLE IF NOT EXISTS Courses (
                        Course_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Course_Name TEXT NOT NULL
                    );
                    CREATE TABLE IF NOT EXISTS Exams (
                        Exam_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Exam_Name TEXT NOT NULL,
                        Exam_Date TEXT NOT NULL,
                        Subject_ID INTEGER NOT NULL,
                        Course_ID INTEGER NOT NULL,
                        FOREIGN KEY (Subject_ID) REFERENCES Subjects(Subject_ID),
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
                    );
                    CREATE TABLE IF NOT EXISTS Lecturers (
                        Lecturer_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Lecturer_Name TEXT NOT NULL,
                        Lecturer_Phone_No TEXT NOT NULL,
                        Lecturer_Email TEXT NOT NULL,
                        Subject_ID INTEGER NOT NULL,
                        Course_ID INTEGER NOT NULL,
                        FOREIGN KEY (Subject_ID) REFERENCES Subjects(Subject_ID),
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
                    );
                    CREATE TABLE IF NOT EXISTS Marks (
                        Mark_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Exam_Marks INTEGER NOT NULL,
                        Student_ID INTEGER NOT NULL,
                        Course_ID INTEGER NOT NULL,
                        Exam_ID INTEGER NOT NULL,
                        Subject_ID INTEGER NOT NULL,
                        FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID),
                        FOREIGN KEY (Exam_ID) REFERENCES Exams(Exam_ID),
                        FOREIGN KEY (Subject_ID) REFERENCES Subjects(Subject_ID)
                    );  
                    CREATE TABLE IF NOT EXISTS Rooms (
                        Room_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Room_Name TEXT NOT NULL,
                        Room_Type TEXT NOT NULL
                    );
                    CREATE TABLE IF NOT EXISTS Staffs (
                        Staff_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Staff_Name TEXT NOT NULL,
                        Staff_Phone_No TEXT NOT NULL,
                        Staff_Email TEXT NOT NULL
                    );
                    CREATE TABLE IF NOT EXISTS Students (
                        Student_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Student_Name TEXT NOT NULL,
                        Student_Phone_No TEXT NOT NULL,
                        Student_Email TEXT NOT NULL,
                        Course_ID INTEGER NOT NULL,
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
                    ); 
                    CREATE TABLE IF NOT EXISTS Subjects (
                        Subject_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Subject_Name TEXT NOT NULL,
                        Course_ID INTEGER NOT NULL,
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
                    );
                    CREATE TABLE IF NOT EXISTS Timetables (
                        Timetable_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Timetable_Date TEXT NOT NULL,
                        Timetable_Slot TEXT NOT NULL,
                        Subject_ID INTEGER NOT NULL,
                        Course_ID INTEGER NOT NULL,
                        Room_ID INTEGER NOT NULL,
                        Lecturer_ID INTEGER NOT NULL,
                        FOREIGN KEY (Subject_ID) REFERENCES Subjects(Subject_ID),
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID),
                        FOREIGN KEY (Lecturer_ID) REFERENCES Lecturers(Lecturer_ID),
                        FOREIGN KEY (Room_ID) REFERENCES Rooms(Room_ID)
                    );

                      CREATE TABLE IF NOT EXISTS Users (
                        User_ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Student_ID INTEGER,
                        Lecturer_ID INTEGER,
                        Course_ID INTEGER,
                        FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
                        FOREIGN KEY (Lecturer_ID) REFERENCES Lecturers(Lecturer_ID),
                        FOREIGN KEY (Course_ID) REFERENCES Courses(Course_ID)
                    );
                     CREATE TABLE IF NOT EXISTS StudentLecturer (
                        Student_ID INTEGER,
                        Lecturer_ID INTEGER,
                        PRIMARY KEY (Student_ID, Lecturer_ID),
                        FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
                        FOREIGN KEY (Lecturer_ID) REFERENCES Lecturers(Lecturer_ID)
                    );
                    CREATE TABLE IF NOT EXISTS StudentSubject (
                        Student_ID INTEGER,
                        Subject_ID INTEGER,
                        PRIMARY KEY (Student_ID, Subject_ID),
                        FOREIGN KEY (Student_ID) REFERENCES Students(Student_ID),
                        FOREIGN KEY (Subject_ID) REFERENCES Subjects(Subject_ID)
                    );
                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
