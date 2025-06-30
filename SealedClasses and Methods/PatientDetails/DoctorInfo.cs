using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetails
{
    public class DoctorInfo : PateintInfo
    {
        //properties
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        //constructors
        public DoctorInfo() { }
        public DoctorInfo(string doctorID, string name, string fatherName)
        {
            DoctorID = doctorID;
            Name = name;
            FatherName = fatherName;
        }
        //DisplayInfo
        public string DisplayInfo()
        {
            return $"DoctorID : {DoctorID}, Name : {Name}, FatherName : {FatherName} ";
        }

    }
}