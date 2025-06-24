using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Mark
    {
        public int Mark_ID {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Student_ID {  get; set; }
        public string Student_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Exam_ID {  get; set; }
        public string Exam_Name { get;  set; }
        /// <summary>
        /// 
        /// </summary>
        public int Subject_ID {  get; set; }
        public string Subject_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Exam_Marks {  get; set; }
        public string Grade {  get; set; }
        public string Mark_Release_Date {  get; set; }




    }
}
