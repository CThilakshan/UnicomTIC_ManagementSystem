using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Timetable
    {
        public int Timetable_ID {  get; set; }
        public string Timetable_Date { get; set; }
        public string Timetable_Slot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Subject_ID {  get; set; }
        public string Subject_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Course_ID {  get; set; }
        public string Course_name {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Lecturer_ID {  get; set; }
        public string Lecturer_Name { get; set; }
        public int Room_ID {  get; set; }
        public string Room_Name { get;set; }


    }
}
