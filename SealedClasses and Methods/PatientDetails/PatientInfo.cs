using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PatientDetails
{
    public sealed class PateintInfo
    {
        //creating the property
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }
        //constructors
        //default Constructor
        public PateintInfo() { }
        //parameterized constructor
        public PateintInfo(string patientID, string name, string fatherName, int bedNo, string nativePlace, string admittedFor)
        {
            PatientID = patientID;
            Name = name;
            FatherName = fatherName;
            BedNo = bedNo;
            NativePlace = nativePlace;
            AdmittedFor = admittedFor;

        }
        //Display details
        public string DisplayInfo()
        {
            return $"PatientID {PatientID}, Name : {Name},FatherName :{FatherName}, BedNo : {BedNo}, NativePlace :{NativePlace}, AdmittedFor :{AdmittedFor}  ";
        }
    }
}