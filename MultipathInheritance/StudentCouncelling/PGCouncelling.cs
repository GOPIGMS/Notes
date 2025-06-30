using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCounselling
{
    public class PGCouncelling : IHSCInfo, IUGInfo
    {
        //decalring the properties
        public string ApplicationID { get; set; }
        public DateTime DateOfApplication { get; set; }
        public FeeStatusDetails FeeStatus { get; set; }
        //getting the properties of PersonalInfo
        public string AadharNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }
        public string HSCMarkSheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public double HSCTotalMarks { get; set; }
        public double HSCPercentageOfMarks { get; set; }
        public string UGMarkSheetNumber { get; set; }
        public double Sem1 { get; set; }
        public double Sem2 { get; set; }
        public double Sem3 { get; set; }
        public double Sem4 { get; set; }
        public double TotalMarks { get; set; }
        public double PercentageOfMarks { get; set; }
        //creating the default constructor
        public PGCouncelling() { }
        //creating the parameterized constructor
        public PGCouncelling(string applicationID, DateTime dateOfApplication, FeeStatusDetails feeStatus, string aadharNumber,
        string name, string fatherName, string phone, DateTime dob, GenderDetails gender, string hscMarksheetNumber,
        int physics, int chemistry, int maths,
        string ugMarksheetnumber, double sem1, double sem2, double sem3, double sem4)
        {
            ApplicationID = applicationID;
            DateOfApplication = dateOfApplication;
            FeeStatus = feeStatus;
            AadharNumber = aadharNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
            HSCMarkSheetNumber = hscMarksheetNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            HSCTotalMarks = HSCTotal();
            HSCPercentageOfMarks = HSCPercentage();
            UGMarkSheetNumber = ugMarksheetnumber;
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
            TotalMarks = Total();
            PercentageOfMarks = Percentage();
        }
        //calculating hsc total
        public double HSCTotal()
        {
            return Physics + Chemistry + Maths;
        }
        //calculating hsc percentage
        public double HSCPercentage()
        {
            return HSCTotal() / 3;
        }
        //adding the sem total
        public double Total()
        {
            return Sem1 + Sem2 + Sem3 + Sem4;
        }
        //adding the percentage of sem
        public double Percentage()
        {
            return Total() / 4;
        }
        //paying the fees
        public bool PayFees(double amount)
        {
            if (amount < 500)
            {
                Console.WriteLine($"Please Pay 500 rupees to complete the status");
                return false;
            }
            else
            {
                Console.WriteLine($"Payment successfull You paid the fees amount Status :Paid ");
                FeeStatus = FeeStatusDetails.Paid;
                return true;
            }

        }
        //displaying the details
        public string ShowDetails()
        {
            return $" Application ID : {ApplicationID}, Date Of Application :{DateOfApplication},FeeStatus : {FeeStatus},\n AadharNumber :{AadharNumber},Name : {Name},Father Name :{FatherName},Phone :{Phone},DOB :{DOB},Gender : {Gender},\nHSCMarksheet :{HSCMarkSheetNumber},Physics :{Physics},Chemistry : {Chemistry},Maths : {Maths},\nUG MarkSheet : {UGMarkSheetNumber},Sem1 :{Sem1},Sem2 : {Sem2},Sem3 : {Sem3},Sem4 : {Sem4}";
        }
    }
}