using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public class AppointmentDetails
    {
        //fields
        /// <summary>
        ///  Field stores the  s_appointmentID  and auto increment  <see cref="AppointmentDetails"/>
        /// </summary>
        private static int s_appointmentID = 500;
        //properties
        /// <summary>
        ///  Property used to store AppointmentID <see cref="AppointmentDetails"/>
        /// </summary>
        public string AppointmentID { get; set; }
        /// <summary>
        /// Property used to store PatientID <see cref="AppointmentDetails"/>
        /// </summary>
        public string PatientID { get; set; }
        /// <summary>
        /// Property used to store DoctorID <see cref="AppointmentDetails"/>
        /// </summary>
        public string DoctorID { get; set; }
        /// <summary>
        /// Property used to store AppointmentDate <see cref="AppointmentDetails"/>
        /// </summary>
        public DateTime AppointmentDate { get; set; }
        /// <summary>
        /// Property used to store AppointmentStatus <see cref="AppointmentDetails"/>
        /// </summary>
        public string Slot { get; set; }
        public AppointmentStatus Status { get; set; }
        /// <summary>
        /// Property used to store Fees <see cref="AppointmentDetails"/>
        /// </summary>
        public double Fees { get; set; }
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="AppointmentDetails"/>
        /// </summary>
        public AppointmentDetails() { }
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="appointmetmentID">appointmetmentID is a string used to initialize the property appointmetmentID</param>
        /// <param name="patientID">patientID is a string used to initialize the property patientID</param>
        /// <param name="doctorID">doctorID is a string used to initialize the property doctorID</param>
        /// <param name="appointmentDate">appointmentDate is a DateTime used to initialize the property appointmentDate</param>
        /// <param name="slot">slot is a string used to initialize the property slot</param>
        /// <param name="status">status is a string used to initialize the property status</param>
        /// <param name="fees">fees is a string used to initialize the property customerID</param>
        public AppointmentDetails(string appointmetmentID, string patientID, string doctorID, DateTime appointmentDate, string slot, AppointmentStatus status, double fees)
        {
            AppointmentID = appointmetmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            AppointmentDate = appointmentDate;
            Slot = slot;
            Status = status;
            Fees = fees;
            ++s_appointmentID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public AppointmentDetails(string details)
        {
            string[] values = details.Split(',');
            AppointmentID = values[0];
            PatientID = values[1];
            DoctorID = values[2];
            AppointmentDate = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            Slot = values[4];
            Status = Enum.Parse<AppointmentStatus>(values[5], true);
            Fees = Convert.ToDouble(values[6]);
            ++s_appointmentID;
        }
        /// <summary>
        /// Parameterized constructor  used to initialize the class <see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="appointmetmentID">appointmetmentID is a string used to initialize the property appointmetmentID</param>
        /// <param name="patientID">patientID is a string used to initialize the property patientID</param>
        /// <param name="doctorID">doctorID is a string used to initialize the property doctorID</param>
        /// <param name="appointmentDate">appointmentDate is a DateTime used to initialize the property appointmentDate</param>
        /// <param name="slot">slot is a string used to initialize the property slot</param>
        /// <param name="status">status is a string used to initialize the property status</param>
        /// <param name="fees">fees is a string used to initialize the property customerID</param>
        public AppointmentDetails(string patientID, string doctorID, DateTime appointmentDate, string slot, AppointmentStatus status, double fees)
        {
            AppointmentID = $"AID{++s_appointmentID}";
            PatientID = patientID;
            DoctorID = doctorID;
            AppointmentDate = appointmentDate;
            Slot = slot;
            Status = status;
            Fees = fees;
        }
    }
}