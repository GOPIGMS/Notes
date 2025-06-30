using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public interface IPersonalInfo
    {
        //getting the properties of PersonalInfo
        public string AadharNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }

    }
}