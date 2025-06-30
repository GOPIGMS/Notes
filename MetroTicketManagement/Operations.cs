using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Threading.Tasks;
using MetroTicketManagement.Models;

namespace MetroTicketManagement
{
    public class Operations
    {
        //setting the global list for each class
        public static CustomList<UserDetails> Users = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> TravelHistorys = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> Tickets = new CustomList<TicketFairDetails>();
        public static UserDetails CurrentUser;
        //creating Global grid for displaying datas
        public static Grid<UserDetails> userGrid = new Grid<UserDetails>();
        public static Grid<TravelDetails> travelGrid = new Grid<TravelDetails>();
        public static Grid<TicketFairDetails> ticketGrid = new Grid<TicketFairDetails>();

        //reading from the csv
        public static void ReadFromFile()
        {
            Users = FileHandling<UserDetails>.ReadFromCSV(Users);
            TravelHistorys = FileHandling<TravelDetails>.ReadFromCSV(TravelHistorys);
            Tickets = FileHandling<TicketFairDetails>.ReadFromCSV(Tickets);

        }
        public static void DefaultData()
        {
            //loading default datas of user
            Users.Add(new UserDetails("CMRL1001", 100, "Ravi", 9848812345));
            Users.Add(new UserDetails("CMRL1002", 100, "Baskaran", 9948854321));
            //loading the default datas of the  Travel history
            TravelHistorys.Add(new TravelDetails("TID2001", "CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55));
            TravelHistorys.Add(new TravelDetails("TID2002", "CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32));
            TravelHistorys.Add(new TravelDetails("TID2003", "CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 40));
            TravelHistorys.Add(new TravelDetails("TID2004", "CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25));
            //loading the default datas of the Ticket fair
            Tickets.Add(new TicketFairDetails("MR3001", "Airport", "Egmore", 55));
            Tickets.Add(new TicketFairDetails("MR3002", "Airport", "Koyambedu", 25));
            Tickets.Add(new TicketFairDetails("MR3003", "Alandur", "Koyambedu", 40));
            Tickets.Add(new TicketFairDetails("MR3004", "Egmore", "Koyembedu", 32));
            Tickets.Add(new TicketFairDetails("MR3005", "Vadapalani", "Egmore", 45));
            Tickets.Add(new TicketFairDetails("MR3006", "Arumbakkam", "Egmore", 30));
            Tickets.Add(new TicketFairDetails("MR3007", "Vadapalani", "Koyambedu", 20));
            Tickets.Add(new TicketFairDetails("MR3008", "Egmore", "Thirumangalam", 25));

        }
        //showing main menu
        public static void MainMenu()
        {
            bool isMainMenuContinue = true;
            try
            {
                int option;
                do
                {
                    Console.WriteLine($"---------------------------Main Menu---------------------------");
                    Console.WriteLine($"Enter the Options\n1.	Customer Registration\n2.	Customer Login\n3.	Exit");
                    Console.WriteLine($"---------------------------------------------------------------");

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
                                    //register the user
                                    Register();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case 2:
                            {
                                try
                                {
                                    //Login the user
                                    Login();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case 3:
                            {
                                try
                                {
                                    //terminate main menu
                                    isMainMenuContinue = false;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        default:
                            {
                                try
                                {
                                    Console.WriteLine($"Invalid Input");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
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
        //register user
        public static void Register()
        {
            //getting the details from the user
            Console.WriteLine($"Enter the user name :");
            string userName = Console.ReadLine();
            Console.WriteLine($"Enter the phone number:");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the balance :");
            double balance = Convert.ToDouble(Console.ReadLine());
            UserDetails user = new UserDetails(balance, userName, phoneNumber);
            Users.Add(user);
            Console.WriteLine($"Customer Registration successful and your  Card Number : {user.CardNumber}");

        }
        //login 
        public static void Login()
        {
            Console.WriteLine($"Enter the Card Number :");
            string userEnteredCardNumber = Console.ReadLine();
            //getting customer
            BinarySearch<UserDetails> customerBinarySearch = new BinarySearch<UserDetails>();
            UserDetails user = customerBinarySearch.Search(Users, userEnteredCardNumber, "CardNumber");
            //if present
            if (user != null)
            {
                try
                {
                    CurrentUser = user;
                    SubMenu();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"The problem is {ex.Message}");
                }

            }
            //if not present
            else
            {
                Console.WriteLine($"Invalid Customer ID");
            }
        }
        //submenu 
        public static void SubMenu()
        {
            bool isSubMenuContinue = true;
            try
            {
                string option;
                do
                {
                    //submenu operation
                    Console.WriteLine($"---------------------------Sub Menu---------------------------");
                    Console.WriteLine($"Enter the Options\na.BalanceCheck\nb.Rechange\nc.ViewTravelHistory\nd.Travel\ne.Exit");
                    Console.WriteLine($"---------------------------------------------------------------");

                    try
                    {
                        option = Console.ReadLine().ToLower();
                    }
                    catch (Exception)
                    {
                        option = "";
                    }
                    switch (option)
                    {
                        case "a":
                            {
                                try
                                {
                                    //showing Balance
                                    BalanceCheck();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "b":
                            {
                                try
                                {
                                    //Recharge
                                    Recharge();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "c":
                            {
                                try
                                {
                                    //View Travel History
                                    ViewTravelHistory();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "d":
                            {
                                try
                                {
                                    //Make Travel
                                    Travel();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "e":
                            {
                                try
                                {
                                    //terminate main menu
                                    isSubMenuContinue = false;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        default:
                            {
                                try
                                {
                                    Console.WriteLine($"Invalid Input");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
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
        //creating the travel
        public static void Travel()
        {
            ticketGrid.ShowTable(Tickets);
            Console.WriteLine($"Enter the Ticket ID you want to travel");
            string userEnteredTicketID = Console.ReadLine();
            BinarySearch<TicketFairDetails> ticketSearch = new BinarySearch<TicketFairDetails>();
            TicketFairDetails ticket = ticketSearch.Search(Tickets, userEnteredTicketID, "TicketID");
            if (ticket != null)
            {
                //checking if the user had the needed balance
                if (CurrentUser.Balance >= ticket.TicketPrice)
                {
                    TravelDetails newTravel = new TravelDetails(CurrentUser.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now, ticket.TicketPrice);
                    CurrentUser.DeductBalance(ticket.TicketPrice);
                    TravelHistorys.Add(newTravel);
                    Console.WriteLine($"Ticket Booked");
                }
                else
                {
                    Console.WriteLine($"Insufficient balance");

                }
            }
            //if the travel id is not present
            else
            {
                Console.WriteLine($"Please Enter valid travel id");

            }



        }
        //Travel history
        public static void ViewTravelHistory()
        {
            CustomList<TravelDetails> travelHistory = new CustomList<TravelDetails>();
            foreach (TravelDetails travel in TravelHistorys)
            {
                if (travel.CardNumber.Equals(CurrentUser.CardNumber))
                {
                    travelHistory.Add(travel);
                }
            }
            if (travelHistory != null && travelHistory.Count > 0)
            {

                travelGrid.ShowTable(travelHistory);

            }


            //no order
            else
            {
                Console.WriteLine($"You haven't traveled yet");

            }

        }
        //wallet recharge
        public static void Recharge()
        {
            //recharge the wallet
            Console.WriteLine($"Enter the amount to recharge");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Balance is {CurrentUser.WalletRecharge(amount)}");


        }
        //show user Balance
        public static void BalanceCheck()
        {
            //checking balance
            Console.WriteLine($"The walletBalance Balance is {CurrentUser.Balance}");

        }
        public static void WriteToFile()
        {
            //writing the datas to the file
            FileHandling<UserDetails>.WriteToCSV(Users);
            FileHandling<TravelDetails>.WriteToCSV(TravelHistorys);
            FileHandling<TicketFairDetails>.WriteToCSV(Tickets);
        }

    }
}