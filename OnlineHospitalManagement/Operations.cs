using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace OnlineHospitalManagement
{
    public static class Operations
    {
        //creating the custom list to store data
        public static CustomList<DoctorDetails> Doctors = new CustomList<DoctorDetails>();
        public static CustomList<SlotDetails> Slots = new CustomList<SlotDetails>();
        public static CustomList<PatientDetails> Patients = new CustomList<PatientDetails>();
        public static CustomList<AppointmentDetails> Appointments = new CustomList<AppointmentDetails>();
        //creating global user object
        public static PatientDetails currentPatient;
        //reading data form csv
        public static void ReadDataFromCSV()
        {
            try
            {
                //read the datas in the file and store in the respective object
                Doctors = FileHandling<DoctorDetails>.ReadFromCSV(Doctors);
                Slots = FileHandling<SlotDetails>.ReadFromCSV(Slots);
                Patients = FileHandling<PatientDetails>.ReadFromCSV(Patients);
                Appointments = FileHandling<AppointmentDetails>.ReadFromCSV(Appointments);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The problem in reading the file is {ex.Message}");

            }

        }
        //adding default data
        public static void DefaultData()
        {
            //adding the default doctor details
            Doctors.Add(new DoctorDetails("DID301", "John", "Joe", GenderDetails.Male, 89877, 33, 20, "General", 200));
            Doctors.Add(new DoctorDetails("DID302", "Saravanan", "Mani", GenderDetails.Male, 98776, 39, 30, "Heart", 500));
            Doctors.Add(new DoctorDetails("DID303", "Kavi", "Karthi", GenderDetails.Male, 77886, 34, 40, "Ortho", 100));
            //adding the default slot data
            Slots.Add(new SlotDetails("DID301", "SL101", "6.00-6.30"));
            Slots.Add(new SlotDetails("DID301", "SL102", "6.30-7.00"));
            Slots.Add(new SlotDetails("DID301", "SL103", "7.00-7.30"));
            Slots.Add(new SlotDetails("DID301", "SL104", "7.30-8.00"));
            Slots.Add(new SlotDetails("DID301", "SL105", "8.00-8.30"));
            Slots.Add(new SlotDetails("DID301", "SL106", "8.30-9.00"));
            Slots.Add(new SlotDetails("DID302", "SL101", "6.00-6.30"));
            Slots.Add(new SlotDetails("DID302", "SL102", "6.30-7.00"));
            Slots.Add(new SlotDetails("DID302", "SL103", "7.00-7.30"));
            Slots.Add(new SlotDetails("DID302", "SL104", "7.30-8.00"));
            Slots.Add(new SlotDetails("DID303", "SL104", "7.30-8.00"));
            Slots.Add(new SlotDetails("DID303", "SL105", "8.00-8.30"));
            Slots.Add(new SlotDetails("DID303", "SL106", "8.30-9.00"));
            //adding the default patient data
            Patients.Add(new PatientDetails("PID1001", "Arun", "Mani", 75757, 45, GenderDetails.Male, 1000));
            Patients.Add(new PatientDetails("PID1002", "Kumar", "Suresh", 57755, 50, GenderDetails.Male, 500));
            Patients.Add(new PatientDetails("PID1003", "Malar", "Ganesh", 58855, 30, GenderDetails.Female, 100));
            Patients.Add(new PatientDetails("PID1004", "Selvi", "Pandi", 58858, 20, GenderDetails.Female, 50));
            //appointment Details loading
            Appointments.Add(new AppointmentDetails("AID501", "PID1001", "DID301", new DateTime(2022, 04, 27), "SL101", AppointmentStatus.Booked, 200));
            Appointments.Add(new AppointmentDetails("AID502", "PID1002", "DID302", new DateTime(2022, 04, 27), "SL102", AppointmentStatus.Booked, 500));
            Appointments.Add(new AppointmentDetails("AID503", "PID1003", "DID303", new DateTime(2022, 04, 27), "SL104", AppointmentStatus.Booked, 100));
            Appointments.Add(new AppointmentDetails("AID504", "PID1001", "DID303", new DateTime(2022, 04, 27), "SL106", AppointmentStatus.Cancelled, 100));
        }
        //main menu
        public static void MainMenu()
        {
            bool isMainMenuContinue = true;
            int option;
            try
            {
                do
                {
                    //displaying the menu
                    Console.WriteLine($"------------------ Main Menu------------------ ");
                    Console.WriteLine($"Enter the option \n1.Patient Registration\n2.User Login\n3.Exit");
                    Console.WriteLine($"---------------------------------------------- ");
                    //getting the option from the user
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        option = 0;
                    }
                    switch (option)
                    {
                        case 1:
                            {
                                //registering user
                                try
                                {
                                    Register();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 2:
                            {
                                //login in user
                                try
                                {
                                    Login();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 3:
                            {

                                try
                                {
                                    //terminate main  menu
                                    isMainMenuContinue = false;
                                    Console.WriteLine($"Exiting the main menu");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        default:
                            {
                                try
                                {
                                    //retry if user enter invalid input
                                    Console.WriteLine($"Invalid Input");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                    }

                } while (isMainMenuContinue);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"The problem is {ex.Message}");
            }

        }
        //registering the user
        public static void Register()
        {
            //Registering the data of the patient
            Console.WriteLine($"Registering");
            Console.WriteLine($"Enter the Patient Name :");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the Father Name :");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the Gender Details :");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the Phone Number :");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Wallet Balance :");
            double walletBalance = Convert.ToDouble(Console.ReadLine());
            //cretating the object and storing the data
            PatientDetails patient = new PatientDetails(name, fatherName, phone, age, gender, walletBalance);
            Patients.Add(patient);
            Console.WriteLine($"The Registration Successful and the Patient ID is :{patient.PatientID}");


        }
        //login method
        public static void Login()
        {
            //user Login
            Console.WriteLine($"Login");
            Console.WriteLine($"Enter the Patient ID");
            string enteredPatientID = Console.ReadLine();
            //binary search on patient
            BinarySearch<PatientDetails> patientBinarySearch = new BinarySearch<PatientDetails>();
            currentPatient = patientBinarySearch.Search(Patients, enteredPatientID, "PatientID");
            if (currentPatient != null)
            {
                SubMenu();
            }
            //if not present
            else
            {
                Console.WriteLine($"Please Enter valid Patient ID");
            }
        }
        //creating submenu
        public static void SubMenu()
        {
            Console.WriteLine($"Sub menu");
            bool isSubMenuContinue = true;
            int option;
            try
            {
                do
                {
                    //displaying the menu
                    Console.WriteLine($"------------------ Sub Menu------------------ ");
                    Console.WriteLine($"Enter the option \n1.Book Appointment\n2.Appointment History\n3.Cancel Appointment\n4.Wallet Recharge\n5.Show Balance\n6.Exit\n");
                    Console.WriteLine($"---------------------------------------------- ");
                    //getting the option from the user
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        option = 0;
                    }
                    switch (option)
                    {
                        case 1:
                            {
                                try
                                {
                                    //booking the new appointment
                                    BookAppointment();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 2:
                            {
                                try
                                {
                                    //current user appointment history
                                    AppointmentHistory();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 3:
                            {
                                try
                                {
                                    //cancel appointment made
                                    CancelAppointment();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 4:
                            {
                                try
                                {
                                    //recharge wallet
                                    WalletRecharge();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 5:
                            {
                                try
                                {
                                    //showing the balance
                                    ShowBalance();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        case 6:
                            {
                                try
                                {
                                    //terminating sub menu
                                    isSubMenuContinue = false;
                                    Console.WriteLine($"Exiting the main meny");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                        default:
                            {
                                try
                                {
                                    //retry if the user enter the invalid input
                                    Console.WriteLine($"Invalid Input");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The poblem is {ex.Message}");
                                }
                                break;
                            }
                    }

                } while (isSubMenuContinue);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"The problem is {ex.Message}");
            }
        }
        //writing the data to csv file
        public static void BookAppointment()
        {
            //displaying doctorGrid
            Grid<DoctorDetails> doctorGrid = new Grid<DoctorDetails>();
            doctorGrid.ShowTable(Doctors);
            Console.WriteLine($"Book Appointment");
            //getting doctor id
            Console.WriteLine($"Enter the DoctorID");
            string doctorID = Console.ReadLine();
            Console.WriteLine($"Enter the Appointment Date");
            DateTime appointmentDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            BinarySearch<DoctorDetails> doctorSearch = new BinarySearch<DoctorDetails>();
            DoctorDetails doctor = doctorSearch.Search(Doctors, doctorID, "DoctorID");
            //getting if the doctor has appointment on that day
            if (doctor != null && appointmentDate.Date >= DateTime.Now.Date)
            {
                //Displaying the slots
                CustomList<SlotDetails> doctorAvailableSlots = new CustomList<SlotDetails>();
                foreach (SlotDetails slot in Slots)
                {
                    if (slot.DoctorID.Equals(doctorID))
                    {
                        doctorAvailableSlots.Add(slot);
                    }
                }
                //slot is not null
                if (doctorAvailableSlots != null)
                {
                    //displaying slot
                    Grid<SlotDetails> slotGrid = new Grid<SlotDetails>();
                    slotGrid.ShowTable(doctorAvailableSlots);
                    Console.WriteLine($"Enter the slot :");
                    string enteredSlotID = Console.ReadLine();
                    bool isDoctorAvailable = true;
                    //checking slot id is valid
                    BinarySearch<SlotDetails> slotdataValidity = new BinarySearch<SlotDetails>();
                    SlotDetails slotAvailable = slotdataValidity.Search(doctorAvailableSlots, enteredSlotID, "SlotID");
                    //traversing to find the appointment
                    foreach (AppointmentDetails appointment in Appointments)
                    {
                        //creating the condition
                        bool condition1 = (appointment.DoctorID.Equals(doctorID));
                        bool condition2 = (appointment.AppointmentDate.ToString("dd/MM/yyyy").Equals(appointmentDate.ToString("dd/MM/yyyy")));
                        bool condition3 = (appointment.Slot.Equals(enteredSlotID));
                        bool condition4 = (slotAvailable != null);
                        bool condition5 = appointment.Status.Equals(AppointmentStatus.Booked);

                        if (condition1 && condition2 && condition3 && condition4 && condition5)
                        {
                            isDoctorAvailable = false;
                        }
                    }
                    if (isDoctorAvailable)
                    {
                        //checking balance 
                        if (doctor.Fees <= currentPatient.WalletBalance)
                        {
                            currentPatient.DeductBalance(doctor.Fees);
                            AppointmentDetails appointment = new AppointmentDetails(currentPatient.PatientID, doctor.DoctorID, DateTime.Now, enteredSlotID, AppointmentStatus.Booked, doctor.Fees);
                            Appointments.Add(appointment);
                            Console.WriteLine($"Appintment Booked and the appointment id is {appointment.AppointmentID}");

                        }
                        //insufficient balance
                        else
                        {
                            Console.WriteLine($"Insufficient Balance");
                        }
                        // if doctor not  available
                    }
                    else
                    {
                        Console.WriteLine($"Doctor is not  Available in that slot on that day");

                    }
                }
                //no slot available
                else
                {
                    Console.WriteLine($"No Slots Available");

                }
                //enter valid date
            }
            else
            {
                Console.WriteLine($"Please Enter valid DoctorID Or Please provide valid Date");

            }

        }
        //showing appointment history
        public static void AppointmentHistory()
        {
            //showing user appointment history
            bool isAppointmentAvailable = false;
            CustomList<AppointmentDetails> currentUserAppointment = new CustomList<AppointmentDetails>();
            foreach (AppointmentDetails appointment in Appointments)
            {
                if (appointment.PatientID.Equals(currentPatient.PatientID))
                {
                    isAppointmentAvailable = true;
                    currentUserAppointment.Add(appointment);
                }
            }
            //checking if there any appointment
            if (isAppointmentAvailable)
            {
                Grid<AppointmentDetails> appointmentGrid = new Grid<AppointmentDetails>();
                appointmentGrid.ShowTable(currentUserAppointment);
            }
            //if not appointment present
            else
            {
                Console.WriteLine($"You havent made any appointment yet");

            }
        }
        //cancel appointment
        public static void CancelAppointment()
        {

            CustomList<AppointmentDetails> currentUserAppointments = new CustomList<AppointmentDetails>();
            foreach (AppointmentDetails appointment in Appointments)
            {
                if (appointment.PatientID.Equals(currentPatient.PatientID) && appointment.Status.Equals(AppointmentStatus.Booked))
                {
                    currentUserAppointments.Add(appointment);
                }
            }
            //displaying appointment
            Grid<AppointmentDetails> appointmentGrid = new Grid<AppointmentDetails>();
            appointmentGrid.ShowTable(currentUserAppointments);
            if (currentUserAppointments != null && currentUserAppointments.Count > 0)
            {
                Console.WriteLine($"Enter the appointment Id to cancel");
                string entertedAppointmentID = Console.ReadLine();
                BinarySearch<AppointmentDetails> binarySearch = new BinarySearch<AppointmentDetails>();
                AppointmentDetails appointment = binarySearch.Search(currentUserAppointments, entertedAppointmentID, "AppointmentID");
                //checking appointment details
                if (appointment != null)
                {
                    appointment.Status = AppointmentStatus.Cancelled;
                    currentPatient.Recharge(appointment.Fees);
                    Console.WriteLine($"Appoinment Cancelled successfully");
                }
                //if invalid appointment id
                else
                {
                    Console.WriteLine($"Invalid Appointment ID");

                }
            }
            //if no appointment
            else
            {
                Console.WriteLine($"There is no appointment");

            }

        }
        //wallet recharging 
        public static void WalletRecharge()
        {
            //recharging wallet
            Console.WriteLine($"Enter the recharge amount");
            double amount = Convert.ToDouble(Console.ReadLine());
            double balance = currentPatient.Recharge(amount);
            Console.WriteLine($"The Balance is {balance}");
        }
        //showing balance
        public static void ShowBalance()
        {
            //showing wallet balance
            Console.WriteLine($"The balance amount is {currentPatient.WalletBalance}");
        }
        //writing data to csv
        public static void WriteDataToCSV()
        {
            //writing the datas to csv
            FileHandling<DoctorDetails>.WriteToCSV(Doctors);
            FileHandling<SlotDetails>.WriteToCSV(Slots);
            FileHandling<PatientDetails>.WriteToCSV(Patients);
            FileHandling<AppointmentDetails>.WriteToCSV(Appointments);
        }

    }
}