using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Unicom_TIC_Management_System.Model
{
    internal class Exam
    {
        public int Exam_ID {  get; set; }
        public string Exam_Name { get; set; }
        public string Exam_Date {  get; set; }
        public int Subject_ID { get;set; }
        public string Subject_Name { get; set; }
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
    }
}
