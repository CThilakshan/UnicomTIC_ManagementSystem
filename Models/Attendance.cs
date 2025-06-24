using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Attendance
    {
        public int Attendance_ID { get; set; }
        public string Attendance_Name { get; set; }
        public string Attendance_Role { get; set; }
        public string Attendance_Time {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Student_ID {  get; set; }
        public string Student_Name { get; set; }
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public int Lecturer_ID {  get; set; }
        public string Lecturer_Name { get;set; }


    }
}
