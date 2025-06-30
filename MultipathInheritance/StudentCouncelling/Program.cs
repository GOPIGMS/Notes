using System;

namespace StudentCounselling;

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 2; i++)
        {
            //getting the properties as Input
            Console.WriteLine($"Getting the Details of Councelling {i + 1}");
            Console.WriteLine($"Enter the ApplicantID");
            string applicationID = Console.ReadLine();
            Console.WriteLine($"Enter the Date Of Application");
            DateTime dateOfApplication = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the Fees Status");
            FeeStatusDetails feeStatus = Enum.Parse<FeeStatusDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the aadharNumber");
            string aadharNumber = Console.ReadLine();
            Console.WriteLine($"Enter the Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the father Name");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the phone");
            string phone = Console.ReadLine();
            Console.WriteLine($"Enter the Date Of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the Gender Details");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the HSC MarkSheetNumber");
            string hscMarksheetNumber = Console.ReadLine();
            Console.WriteLine($"Enter the physics Marks");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Chemistry Marks");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Maths Marks");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the UG MarkSheetNumber");
            string ugMarksheetnumber = Console.ReadLine();
            Console.WriteLine($"Enter the sem1 mark");
            double sem1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the sem2 mark");
            double sem2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the sem3 mark");
            double sem3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the sem4 mark");
            double sem4 = Convert.ToDouble(Console.ReadLine());
            //creating the object
            PGCouncelling pgCouncellingObject = new PGCouncelling(applicationID, dateOfApplication, feeStatus, aadharNumber, name, fatherName, phone, dob, gender, hscMarksheetNumber, physics, chemistry, maths, ugMarksheetnumber, sem1, sem2, sem3, sem4);
            Console.WriteLine($"Showing the user details:\n{pgCouncellingObject.ShowDetails()}");
            Console.WriteLine($"The Hsc marks total :{pgCouncellingObject.HSCTotal()}");
            Console.WriteLine($"The Hsc Percentage :{pgCouncellingObject.HSCPercentage()}");
            Console.WriteLine($"The UG marks total :{pgCouncellingObject.Total()}");
            Console.WriteLine($"The Hsc Percentage :{pgCouncellingObject.Percentage()}");
            bool result = false;
            //payment processing
            while (!result)
            {
                Console.WriteLine($"Pay the fees 500 to register");
                double amount = Convert.ToDouble(Console.ReadLine());
                result = pgCouncellingObject.PayFees(amount);
            }
        }
    }
}