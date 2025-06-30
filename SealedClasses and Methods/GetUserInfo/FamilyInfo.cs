using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GetUserInfo
{
    public class FamilyInfo : PersonalInfo
    {
        //getting the properties
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSibling { get; set; }
        public string NativePlace { get; set; }
        //constructors
        public FamilyInfo() { }
        public FamilyInfo(string fatherName, string motherName, int noOfSibling, string nativePlace)
        {
            FatherName = fatherName;
            MotherName = motherName;
            NoOfSibling = noOfSibling;
            NativePlace = nativePlace;
        }
        //overring virtual
        public sealed override string Update()
        {
            return "";
        }
        //creating display Info
        public sealed override string DisplayInfo()
        {
            return $"FatherName : {FatherName}, MotherName : {MotherName},No of Sibling : {NoOfSibling},NativePlace {NativePlace}";
        }
    }
}