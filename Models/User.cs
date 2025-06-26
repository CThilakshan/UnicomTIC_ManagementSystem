
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    public class User
    {
        public int User_ID {  get; set; }
        public string Name { get; set; }
        public string Role {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int  Student_ID {  get; set; }
        public string Student_Name { get;  set; }
        /// <summary>
        /// 
        /// </summary>
        public int Lecturer_ID { get; set; }
        public string Lecturer_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Course_ID { get; set; }
        public string Course_Name { get;set; }
    }
}
