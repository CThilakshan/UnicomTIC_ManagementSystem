using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Models
{
    internal class StudentSubject
    {
        public int Student_ID { get; set; } // Foreign key to Students table
        public int Subject_ID { get; set; } // Foreign key to Subjects table
       
    }
}
