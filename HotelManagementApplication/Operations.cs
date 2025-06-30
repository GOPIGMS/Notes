using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementApplication.Models;
using HotelManagementApplication.Enums;
using System.ComponentModel;
using System.Threading;
using System.Runtime.Intrinsics.Arm;
using System.Net.WebSockets;
using System.Runtime;
using System.Runtime.InteropServices;
using System.IO;

namespace HotelManagementApplication
{
    public class Operations
    {
        //declaring the global lists
        public static CustomList<UserDetails> Users = new CustomList<UserDetails>();
        public static CustomList<RoomDetails> Rooms = new CustomList<RoomDetails>();
        public static CustomList<RoomSelectionDetails> Selections = new CustomList<RoomSelectionDetails>();
        public static CustomList<BookingDetails> Bookings = new CustomList<BookingDetails>();
        //global object
        public static UserDetails CurrentUser;
        //addding default data
        public static void DefaultData()
        {
            //adding the default data of user
            Users.Add(new UserDetails("SF1001", "Ravichandran", 995875777, 347777378383, "Chennai", Enums.FoodTypeDetails.Veg, Enums.GenderDetails.Male, 5000));
            Users.Add(new UserDetails("SF1002", "Baskaran", 448844848, 474777477477, "Chennai", Enums.FoodTypeDetails.NonVeg, Enums.GenderDetails.Male, 6000));
            //adding the default Data of room detail
            Rooms.Add(new RoomDetails("RID101", Enums.RoomTypeDetails.Standard, 2, 500));
            Rooms.Add(new RoomDetails("RID102", Enums.RoomTypeDetails.Standard, 4, 700));
            Rooms.Add(new RoomDetails("RID103", Enums.RoomTypeDetails.Standard, 2, 500));
            Rooms.Add(new RoomDetails("RID104", Enums.RoomTypeDetails.Standard, 2, 500));
            Rooms.Add(new RoomDetails("RID105", Enums.RoomTypeDetails.Standard, 2, 500));
            Rooms.Add(new RoomDetails("RID106", Enums.RoomTypeDetails.Delux, 2, 1000));
            Rooms.Add(new RoomDetails("RID107", Enums.RoomTypeDetails.Delux, 2, 1000));
            Rooms.Add(new RoomDetails("RID108", Enums.RoomTypeDetails.Delux, 4, 1400));
            Rooms.Add(new RoomDetails("RID109", Enums.RoomTypeDetails.Delux, 4, 1400));
            Rooms.Add(new RoomDetails("RID110", Enums.RoomTypeDetails.Suit, 2, 2000));
            Rooms.Add(new RoomDetails("RID111", Enums.RoomTypeDetails.Suit, 2, 2000));
            Rooms.Add(new RoomDetails("RID112", Enums.RoomTypeDetails.Suit, 2, 2000));
            Rooms.Add(new RoomDetails("RID113", Enums.RoomTypeDetails.Suit, 4, 2500));
            //Entering room Selection Details
            Selections.Add(new RoomSelectionDetails("SID1001", "BID101", "RID101", new DateTime(2022, 11, 11), new DateTime(2022, 11, 12), 750, 1.5, BookingStatusDetails.Booked));
            Selections.Add(new RoomSelectionDetails("SID1002", "BID101", "RID102", new DateTime(2022, 11, 11), new DateTime(2022, 11, 12), 700, 1, BookingStatusDetails.Booked));
            Selections.Add(new RoomSelectionDetails("SID1003", "BID102", "RID103", new DateTime(2022, 11, 12), new DateTime(2022, 11, 13), 500, 1, BookingStatusDetails.Cancelled));
            Selections.Add(new RoomSelectionDetails("SID1004", "BID102", "RID106", new DateTime(2022, 11, 12), new DateTime(2022, 11, 13), 1500, 1, BookingStatusDetails.Cancelled));
            //adding booking default Data
            Bookings.Add(new BookingDetails("BID101", "SF1001", 1450, new DateTime(2022 / 11 / 10), BookingStatusDetails.Booked));
            Bookings.Add(new BookingDetails("BID102", "SF1002", 2000, new DateTime(2022 / 11 / 10), BookingStatusDetails.Cancelled));
        }
        //reading from CSv
        public static void ReadFromFiles()
        {
            Users = FileHandling<UserDetails>.ReadFromCSV(Users);
            Rooms = FileHandling<RoomDetails>.ReadFromCSV(Rooms);
            Selections = FileHandling<RoomSelectionDetails>.ReadFromCSV(Selections);
            Bookings = FileHandling<BookingDetails>.ReadFromCSV(Bookings);
        }
        //MainMenu creation
        public static void MainMenu()
        {
            try
            {
                //creating the main menu
                bool isMainMenuContinue = true;
                int option;
                do
                {
                    Console.WriteLine($"--------------------Main Menu--------------------");
                    Console.WriteLine($"Enter the option \n1.User Registration\n2.User Login\n3.Exit");
                    Console.WriteLine($"-------------------------------------------------");
                    //getting the input option
                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        option = 0;
                    }
                    switch (option)
                    {
                        case 1:
                            {
                                try
                                {
                                    //calling Register method
                                    Register();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 2:
                            {
                                try
                                {
                                    //calling Login method
                                    Login();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 3:
                            {
                                try
                                {
                                    //Exiting mainmenu
                                    isMainMenuContinue = false;
                                    Console.WriteLine($"Exiting Main Menu");
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        default:
                            {
                                try
                                {
                                    Console.WriteLine($"Invalid Input");
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
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
        public static void Register()
        {
            //getting the data from the user
            Console.WriteLine($"Enter the User Name :");
            string userName = Console.ReadLine();
            Console.WriteLine($"Enter the Mobile number");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the Aadhar number");
            long aadharNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the address :");
            string address = Console.ReadLine();
            Console.WriteLine($"Enter the food Type");
            FoodTypeDetails foodType = Enum.Parse<FoodTypeDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the Gender Details");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the wallet Balance");
            double walletBalance = Convert.ToDouble(Console.ReadLine());
            //creating the object
            UserDetails user = new UserDetails(userName, mobileNumber, aadharNumber, address, foodType, gender, walletBalance);
            Users.Add(user);
            Console.WriteLine($"The user is created and the user id is {user.UserID}");
        }
        public static void Login()
        {
            try
            {
                //login module
                Console.WriteLine($"Enter the User ID");
                string enteredUserID = Console.ReadLine().ToUpper();
                //performing binary search on id
                BinarySearch<UserDetails> userBinarySearch = new BinarySearch<UserDetails>();
                UserDetails user = userBinarySearch.Search(Users, enteredUserID, "UserID");
                //checking user avialbale
                if (user != null)
                {
                    CurrentUser = user;
                    SubMenu();
                }
                //user not available
                else
                {
                    Console.WriteLine($"Invalid UserID please Enter valid User ID");

                }


            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"The problem is {ex.Message}");

            }

        }
        public static void SubMenu()
        {

            try
            {
                //creating the main menu
                bool isSubMenuContinue = true;
                char option;
                do
                {
                    Console.WriteLine($"--------------------Sub Menu--------------------");
                    Console.WriteLine($"Enter the option \na.View Customer Profile\nb.Book Room\nc.Modify Booking\nd.Cancel Booking\ne.Booking History\nf.Wallet Recharge\ng.Show WalletBalance\nh.Exit ");
                    Console.WriteLine($"-------------------------------------------------");
                    //getting the input option
                    try
                    {
                        option = Convert.ToChar(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        option = ' ';
                    }
                    switch (option)
                    {
                        case 'a':
                            {
                                try
                                {
                                    //calling ViewCustomerProfile method
                                    ViewCustomerProfile();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'b':
                            {
                                try
                                {
                                    //calling BookRoom method
                                    BookRoom();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'c':
                            {
                                try
                                {
                                    //calling ModifyBooking method
                                    ModifyBooking();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'd':
                            {
                                try
                                {
                                    //calling Cancel method
                                    CancelBooking();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'e':
                            {
                                try
                                {
                                    //calling Booking History method
                                    BookingHistory();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'f':
                            {
                                try
                                {
                                    //calling wallet Recharge method
                                    WalletRecharge();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'g':
                            {
                                try
                                {
                                    //calling show wallet balance method
                                    ShowWalletBalance();
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        case 'h':
                            {
                                try
                                {
                                    //Exiting mainmenu
                                    isSubMenuContinue = false;
                                    Console.WriteLine($"Exiting Main Menu");
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
                                }
                                break;
                            }
                        default:
                            {
                                try
                                {
                                    Console.WriteLine($"Invalid Input");
                                }
                                catch (System.Exception ex)
                                {
                                    Console.WriteLine($"The Problem is {ex.Message}");
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
        public static void ViewCustomerProfile()
        {
            CustomList<UserDetails> user = new CustomList<UserDetails>();
            //adding the current user
            user.Add(CurrentUser);
            Grid<UserDetails> userGrid = new Grid<UserDetails>();
            userGrid.ShowTables(user);
        }
        public static void BookRoom()
        {
            //creating a temporary object
            BookingDetails booking = new BookingDetails(CurrentUser.UserID, 0, DateTime.Now, BookingStatusDetails.Initiated);
            //temporary local room session
            CustomList<RoomSelectionDetails> temporaryNotAvailableSelection = new CustomList<RoomSelectionDetails>();
            //asking the user for Date
            Console.WriteLine($"Enter from the Date to Book the room");
            DateTime userEnteredFromDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter to the Date to Book the room");
            DateTime userEnteredToDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            TimeSpan difference = userEnteredToDate - userEnteredFromDate;

            //getting the Selected rooms
            foreach (RoomSelectionDetails selectedRoom in Selections)
            {
                //user can chekin after his checkout
                if (userEnteredFromDate.Date > selectedRoom.StayingDateTo && selectedRoom.BookingStatus.Equals(BookingStatusDetails.Booked))
                {
                    temporaryNotAvailableSelection.Add(selectedRoom);
                }

            }
            //Entering the available 
            CustomList<RoomDetails> availableRoom = new CustomList<RoomDetails>();
            foreach (RoomDetails room in Rooms)
            {
                bool isPresent = false;

                foreach (RoomSelectionDetails currentRoom in temporaryNotAvailableSelection)
                {
                    if (currentRoom.RoomID.Equals(room.RoomID))
                    {
                        isPresent = true;
                    }
                }
                if (!isPresent)
                {
                    //if the room is free we are adding it
                    availableRoom.Add(room);
                }
            }
            //displaying the available room
            Grid<RoomDetails> roomGrid = new Grid<RoomDetails>();
            roomGrid.ShowTables(availableRoom);
            //getting the room id
            bool isprocessRepeat = true;
            // Creating a temporaryList to accept more than one room details
            CustomList<RoomSelectionDetails> userSelectedRooms = new CustomList<RoomSelectionDetails>();
            double total = 0;

            do
            {
                Console.WriteLine($"Enter the RoomID");
                string enteredRoomID = Console.ReadLine().ToUpper();
                //getting the room data
                BinarySearch<RoomDetails> roomBinarySearch = new BinarySearch<RoomDetails>();
                RoomDetails obtainedRoom = roomBinarySearch.Search(availableRoom, enteredRoomID, "RoomID");
                if (obtainedRoom != null)
                {

                    double value = difference.Days;
                    double price = value * obtainedRoom.PricePerDay;
                    total += price;
                    RoomSelectionDetails selectedRoom = new RoomSelectionDetails(booking.BookingID, obtainedRoom.RoomID, userEnteredFromDate, userEnteredToDate, price, (double)value, BookingStatusDetails.Booked);
                    userSelectedRooms.Add(selectedRoom);
                    //removing from available room
                    CustomList<RoomDetails> newavailableRoom = new CustomList<RoomDetails>();
                    foreach (RoomDetails room in availableRoom)
                    {
                        if (room.RoomID != selectedRoom.RoomID)
                        {
                            newavailableRoom.Add(room);
                        }
                    }
                    //creating the available room
                    availableRoom = newavailableRoom;

                }
                else
                {
                    Console.WriteLine($"Please Enter valid Room ID");
                }
                Console.WriteLine($"Do you want to continue booking enter yes else enter no");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "yes":
                        {
                            Grid<RoomDetails> newroomGrid = new Grid<RoomDetails>();
                            newroomGrid.ShowTables(availableRoom);
                            break;
                        }
                    case "no":
                        {
                            isprocessRepeat = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Invalid Input");
                            break;
                        }
                }
            } while (isprocessRepeat);
            //continue untill user Recharge or cancel order
            bool isPaymentContinue = true;
            do
            {
                //checking the balance
                if (total < CurrentUser.WalletBalance)
                {
                    BookingDetails newBooking = new BookingDetails(CurrentUser.UserID, total, DateTime.Now, BookingStatusDetails.Booked);
                    Bookings.Add(newBooking);
                    Console.WriteLine($"Successfully booked");

                    break;
                }
                else
                {
                    Console.WriteLine($"You dont have enough money do you want to recharge and Continue press yes ");
                    string confirmationForRecharge = Console.ReadLine().ToLower();
                    //if yes recharging the wallet
                    if (confirmationForRecharge == "yes")
                    {
                        WalletRecharge();
                    }
                    else
                    {
                        isPaymentContinue = false;
                        //making the selection as cancelled
                        foreach (RoomSelectionDetails room in userSelectedRooms)
                        {
                            room.BookingStatus = BookingStatusDetails.Cancelled;
                        }
                    }

                }
            } while (isPaymentContinue);
        }
        public static void ModifyBooking()
        {

            //getting the booking Details
            CustomList<BookingDetails> userBookingHistory = new CustomList<BookingDetails>();
            foreach (BookingDetails booking in Bookings)
            {
                //checking for user booked details
                if (booking.UserID.Equals(CurrentUser.UserID) && booking.BookingStatus.Equals(BookingStatusDetails.Booked))
                {
                    userBookingHistory.Add(booking);
                }
            }
            //checking if user has any booking history
            if (userBookingHistory != null && userBookingHistory.Count > 0)
            {
                //Display Data in Grid
                Grid<BookingDetails> bookingDetailsGrid = new Grid<BookingDetails>();
                bookingDetailsGrid.ShowTables(userBookingHistory);
                //getting the booking id from the user
                Console.WriteLine($"Enter the Booking id");
                string enteredBookingID = Console.ReadLine();
                BinarySearch<BookingDetails> bookingSearch = new BinarySearch<BookingDetails>();
                BookingDetails bookedData = bookingSearch.Search(userBookingHistory, enteredBookingID, "BookingID");
                if (bookedData != null)
                {
                    //getting the data of selection
                    CustomList<RoomSelectionDetails> userSlectedRooms = new CustomList<RoomSelectionDetails>();
                    foreach (RoomSelectionDetails selectedRoom in Selections)
                    {
                        if (selectedRoom.BookingID.Equals(bookedData.BookingID))
                        {
                            userSlectedRooms.Add(selectedRoom);
                        }
                    }
                    //displaying data in grid
                    Grid<RoomSelectionDetails> selectionGrid = new Grid<RoomSelectionDetails>();
                    selectionGrid.ShowTables(userSlectedRooms);
                    //getting the selected room id from the user
                    Console.WriteLine($"Enter the current selection room id");
                    string userEnterSelectionRoom = Console.ReadLine();
                    //getting selection id
                    RoomSelectionDetails currentSelection = null;
                    foreach (RoomSelectionDetails room in userSlectedRooms)
                    {
                        if (room.SelectionID.Equals(userEnterSelectionRoom))
                        {
                            currentSelection = room;
                            break;
                        }
                    }
                    if (currentSelection != null)
                    {

                        Console.WriteLine($"Enter the option \n1. To Cancel \n2. Add new room");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                {
                                    try
                                    {

                                        //cancelling 
                                        double amount = currentSelection.Price;
                                        currentSelection.BookingStatus = BookingStatusDetails.Cancelled;
                                        bookedData.TotalPrice -= amount;
                                        Console.WriteLine($"Order Cancelled Successfully");

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
                                        DateTime startingDate = currentSelection.StayingDateFrom;
                                        DateTime endingDate = currentSelection.StayingDateTo;
                                        TimeSpan differenceInTime = endingDate - startingDate;
                                        double time = differenceInTime.Days;

                                        //temporary local room session
                                        CustomList<RoomSelectionDetails> temporaryNotAvailableSelection = new CustomList<RoomSelectionDetails>();
                                        //asking the user for Date
                                        Console.WriteLine($"Enter the from Date to Book the room");
                                        DateTime userEnteredFromDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                                        Console.WriteLine($"Enter the to Date to Book the room");
                                        DateTime userEnteredToDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                                        TimeSpan difference = userEnteredToDate - userEnteredFromDate;

                                        //getting the Selected rooms
                                        foreach (RoomSelectionDetails selectedRoom in Selections)
                                        {
                                            //user can chekin after his checkout
                                            if (userEnteredFromDate.Date > selectedRoom.StayingDateTo && selectedRoom.BookingStatus.Equals(BookingStatusDetails.Booked))
                                            {
                                                temporaryNotAvailableSelection.Add(selectedRoom);
                                            }

                                        }
                                        //Entering the available 
                                        CustomList<RoomDetails> availableRoom = new CustomList<RoomDetails>();
                                        foreach (RoomDetails room in Rooms)
                                        {
                                            bool isPresent = false;

                                            foreach (RoomSelectionDetails currentRoom in temporaryNotAvailableSelection)
                                            {
                                                if (currentRoom.RoomID.Equals(room.RoomID))
                                                {
                                                    isPresent = true;
                                                }
                                            }
                                            if (!isPresent)
                                            {
                                                //if the room is free we are adding it
                                                availableRoom.Add(room);
                                            }
                                        }
                                        //displaying the available room
                                        Grid<RoomDetails> roomGrid = new Grid<RoomDetails>();
                                        roomGrid.ShowTables(availableRoom);
                                        Console.WriteLine($"Enter the RoomID");
                                        string enteredRoomID = Console.ReadLine();
                                        //getting the room data
                                        BinarySearch<RoomDetails> roomBinarySearch = new BinarySearch<RoomDetails>();
                                        RoomDetails obtainedRoom = roomBinarySearch.Search(availableRoom, enteredRoomID, "RoomID");
                                        double amount = time * obtainedRoom.PricePerDay;
                                        if (obtainedRoom != null)
                                        {
                                            RoomSelectionDetails selectedRoom = new RoomSelectionDetails(bookedData.BookingID, obtainedRoom.RoomID, startingDate, endingDate, amount, time, BookingStatusDetails.Booked);
                                            //if user has the balance
                                            if (amount < CurrentUser.WalletBalance)
                                            {
                                                Console.WriteLine($"Booking Successful");
                                                Selections.Add(selectedRoom);
                                            }
                                            else
                                            {
                                                //if insufficient balance cancelling the order
                                                Console.WriteLine($"InsufficientBalance");
                                                selectedRoom.BookingStatus = BookingStatusDetails.Cancelled;
                                            }
                                        }

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
                    }
                    //if not valid selection id
                    else
                    {
                        Console.WriteLine($"Please Enter valid Selection ID");
                    }
                }
                //invalid book id
                else
                {
                    Console.WriteLine($"Enter Valid BookingID");
                }

            }
            //if not present
            else
            {
                Console.WriteLine($"You haven't made any booking yet");
            }

        }
        public static void CancelBooking()
        {
            CustomList<BookingDetails> userBookingHistory = new CustomList<BookingDetails>();
            foreach (BookingDetails booking in Bookings)
            {
                if (booking.UserID.Equals(CurrentUser.UserID) && booking.BookingStatus.Equals(BookingStatusDetails.Booked))
                {
                    userBookingHistory.Add(booking);
                }
            }
            //checking if user has any booking history
            if (userBookingHistory != null && userBookingHistory.Count > 0)
            {
                //Display Data in Grid
                Grid<BookingDetails> bookingDetailsGrid = new Grid<BookingDetails>();
                bookingDetailsGrid.ShowTables(userBookingHistory);
                //getting the booking id from the user
                Console.WriteLine($"Enter the Booking id");
                string enteredBookingID = Console.ReadLine();
                BinarySearch<BookingDetails> bookingSearch = new BinarySearch<BookingDetails>();
                BookingDetails bookedData = bookingSearch.Search(userBookingHistory, enteredBookingID, "BookingID");
                if (bookedData != null)
                {
                    //refunding and changing the state to cancel
                    CurrentUser.WalletRecharge(bookedData.TotalPrice);
                    bookedData.BookingStatus = BookingStatusDetails.Cancelled;
                    Console.WriteLine($"The Booking Cancelled Successfully");
                    //cancelling the selection booking
                    //getting the data of selection
                    //making the cancellation in Selection
                    foreach (RoomSelectionDetails selectedRoom in Selections)
                    {
                        if (selectedRoom.BookingID.Equals(bookedData.BookingID))
                        {
                            selectedRoom.BookingStatus = BookingStatusDetails.Cancelled;
                        }
                    }
                }
                //invalid book id
                else
                {
                    Console.WriteLine($"Enter Valid BookingID");

                }

            }
            //if not present
            else
            {
                Console.WriteLine($"You haven't made any booking yet");

            }

        }
        public static void BookingHistory()
        {
            //getting the booking Details
            CustomList<BookingDetails> userBookingHistory = new CustomList<BookingDetails>();
            foreach (BookingDetails booking in Bookings)
            {
                if (booking.UserID.Equals(CurrentUser.UserID))
                {
                    userBookingHistory.Add(booking);
                }
            }
            //checking if user has any booking history
            if (userBookingHistory != null && userBookingHistory.Count > 0)
            {
                //Display Data in Grid
                Grid<BookingDetails> bookingDetailsGrid = new Grid<BookingDetails>();
                bookingDetailsGrid.ShowTables(userBookingHistory);
                //getting the booking id from the user
                Console.WriteLine($"Enter the Booking id");
                string enteredBookingID = Console.ReadLine();
                BinarySearch<BookingDetails> bookingSearch = new BinarySearch<BookingDetails>();
                BookingDetails bookedData = bookingSearch.Search(userBookingHistory, enteredBookingID, "BookingID");
                if (bookedData != null)
                {
                    //getting the data of selection
                    CustomList<RoomSelectionDetails> userSlectedRooms = new CustomList<RoomSelectionDetails>();
                    foreach (RoomSelectionDetails selectedRoom in Selections)
                    {
                        if (selectedRoom.BookingID.Equals(bookedData.BookingID))
                        {
                            userSlectedRooms.Add(selectedRoom);
                        }
                    }
                    //displaying data in grid
                    Grid<RoomSelectionDetails> selectionGrid = new Grid<RoomSelectionDetails>();
                    selectionGrid.ShowTables(userSlectedRooms);
                }
                //invalid book id
                else
                {
                    Console.WriteLine($"Enter Valid BookingID");
                }

            }
            //if not present
            else
            {
                Console.WriteLine($"You haven't made any booking yet");
            }
        }
        public static void WalletRecharge()
        {
            //getting amount and recharge
            Console.WriteLine($"Enter the amount to recharge");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Current Balance is {CurrentUser.WalletRecharge(amount)}");
        }
        public static void ShowWalletBalance()
        {
            //showing the user wallet balance
            Console.WriteLine($"The user Wallet Balance is {CurrentUser.WalletBalance}");

        }
        //writes the datas to files
        public static void WriteToFiles()
        {
            //writing all the datas
            FileHandling<BookingDetails>.WriteToCSV(Bookings);
            FileHandling<UserDetails>.WriteToCSV(Users);
            FileHandling<RoomDetails>.WriteToCSV(Rooms);
            FileHandling<RoomSelectionDetails>.WriteToCSV(Selections);
        }


    }
}