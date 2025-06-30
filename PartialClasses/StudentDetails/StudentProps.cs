using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public partial class StudentInfo
    {
        //creating student Property
        public string StudentID { get; set; }
        public string Name { get; set; }
        public GenderDetails Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
    }

}