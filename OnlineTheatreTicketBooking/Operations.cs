using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using OnlineTheatreTicketBooking.Enums;
using OnlineTheatreTicketBooking.Models;

namespace OnlineTheatreTicketBooking
{
    public class Operations
    {
        //global dictionary creation
        public static MyDictionary<string, TheatreDetails> Theaters = new MyDictionary<string, TheatreDetails>();
        public static MyDictionary<string, UserDetails> Users = new MyDictionary<string, UserDetails>();
        public static MyDictionary<string, MovieDetails> Movies = new MyDictionary<string, MovieDetails>();
        public static MyDictionary<string, ScreeningDetails> Screens = new MyDictionary<string, ScreeningDetails>();
        public static MyDictionary<string, BookingDetails> Bookings = new MyDictionary<string, BookingDetails>();
        // global user object
        public static UserDetails CurrentUser = null;
        //reading from the file
        public static void ReadFromFile()
        {
            Bookings = FileHandling<string, BookingDetails>.ReadFromCSV(Bookings, "BookingID");
            Movies = FileHandling<string, MovieDetails>.ReadFromCSV(Movies, "MovieID");
            Screens = FileHandling<string, ScreeningDetails>.ReadFromCSV(Screens, "ScreeningID");
            Users = FileHandling<string, UserDetails>.ReadFromCSV(Users, "UserID");
            Theaters = FileHandling<string, TheatreDetails>.ReadFromCSV(Theaters, "TheatreID");
        }
        //loading the default data
        public static void DefaultData()
        {
            //entering user details and creating the object
            UserDetails user1 = new UserDetails("UID1001", 1000, "Ravichandran", 30, 859948800, GenderDetails.Male);
            Users.Add(user1.UserID, user1);
            UserDetails user2 = new UserDetails("UID1002", 2000, "Baskaran", 30, 9857747327, GenderDetails.Male);
            Users.Add(user2.UserID, user2);

            //entering theatre details
            TheatreDetails theatre1 = new TheatreDetails("TID301", "Inox", "Anna Nagar");
            Theaters.Add(theatre1.TheatreID, theatre1);
            TheatreDetails theatre2 = new TheatreDetails("TID302", "Ega Theatre", "Chetpet");
            Theaters.Add(theatre2.TheatreID, theatre2);
            TheatreDetails theatre3 = new TheatreDetails("TID303", "kamala", "Vadapalani");
            Theaters.Add(theatre3.TheatreID, theatre3);
            // entering movie details and creating the object
            MovieDetails movie1 = new MovieDetails("MID501", "Bagubali 2", "Telugu");
            Movies.Add(movie1.MovieID, movie1);
            MovieDetails movie2 = new MovieDetails("MID502", "Ponniyin Selvan", "Tamil");
            Movies.Add(movie2.MovieID, movie2);
            MovieDetails movie3 = new MovieDetails("MID503", "Cobra", "Tamil");
            Movies.Add(movie3.MovieID, movie3);
            MovieDetails movie4 = new MovieDetails("MID504", "Vikram", "Hindi (Dubbed)");
            Movies.Add(movie4.MovieID, movie4);
            MovieDetails movie5 = new MovieDetails("MID505", "Vikram", "Tamil");
            Movies.Add(movie5.MovieID, movie5);
            MovieDetails movie6 = new MovieDetails("MID506", "Beast", "English");
            Movies.Add(movie1.MovieID, movie1);
            //entering screen details and creating the object
            ScreeningDetails screen1 = new ScreeningDetails("MID501", "TID301", 5, 200);
            Screens.Add(screen1.ScreeningID, screen1);
            ScreeningDetails screen2 = new ScreeningDetails("MID502", "TID301", 2, 300);
            Screens.Add(screen2.ScreeningID, screen2);
            ScreeningDetails screen3 = new ScreeningDetails("MID506", "TID301", 1, 50);
            Screens.Add(screen3.ScreeningID, screen3);
            ScreeningDetails screen4 = new ScreeningDetails("MID501", "TID302", 11, 400);
            Screens.Add(screen4.ScreeningID, screen4);
            ScreeningDetails screen5 = new ScreeningDetails("MID505", "TID302", 20, 300);
            Screens.Add(screen5.ScreeningID, screen5);
            ScreeningDetails screen6 = new ScreeningDetails("MID504", "TID302", 2, 500);
            Screens.Add(screen6.ScreeningID, screen6);
            ScreeningDetails screen7 = new ScreeningDetails("MID505", "TID303", 11, 100);
            Screens.Add(screen7.ScreeningID, screen7);
            ScreeningDetails screen8 = new ScreeningDetails("MID502", "TID303", 20, 200);
            Screens.Add(screen8.ScreeningID, screen8);
            ScreeningDetails screen9 = new ScreeningDetails("MID504", "TID303", 2, 350);
            Screens.Add(screen9.ScreeningID, screen9);
            //creating and adding default booking and creating object
            BookingDetails booking1 = new BookingDetails("BID7001", "UID1001", "MID501", "TID301", 1, 236, BookingStatusDetails.Booked);
            Bookings.Add(booking1.BookingID, booking1);
            BookingDetails booking2 = new BookingDetails("BID7002", "UID1001", "MID504", "TID302", 1, 472, BookingStatusDetails.Booked);
            Bookings.Add(booking2.BookingID, booking2);
            BookingDetails booking3 = new BookingDetails("BID7003", "UID1002", "MID505", "TID302", 1, 354, BookingStatusDetails.Booked);
            Bookings.Add(booking3.BookingID, booking3);


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
                                    LoginAndPurChase();
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
                                    //catching wrong output
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
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the balance:");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Phone number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the gender");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            UserDetails user = new UserDetails(balance, name, age, phoneNumber, gender);
            //creating object
            Users.Add(user.UserID, user);
            Console.WriteLine($"The User is created and the ID : {user.UserID}");

        }
        public static void LoginAndPurChase()
        {
            try
            {
                //login module
                Console.WriteLine($"Enter the User ID");
                string enteredUserID = Console.ReadLine().ToUpper();
                //performing binary search on id
                BinarySearch<string, UserDetails> userSearch = new BinarySearch<string, UserDetails>();
                UserDetails user = userSearch.Search(Users, enteredUserID, "UserID");

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
                    Console.WriteLine($"Enter the option \na.Ticket Booking\nb.Ticket Cancellation \nc.Booking History\nd.Wallet Recharge\ne.Show Wallet balance.\nf.Exit ");
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
                                    //calling TicketBooking method
                                    TicketBooking();
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
                                    //calling TicketCancellation method
                                    TicketCancellation();
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
                                    //calling BookingHistory method
                                    BookingHistory();
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
                                    //calling WalletRecharge method
                                    WalletRecharge();
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
                                    //calling ShowWallet Balance method
                                    ShowWalletBalance();
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
                                    //Exiting mainmenu
                                    isSubMenuContinue = false;
                                    Console.WriteLine($"Exiting Sub Menu");
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
        public static void TicketBooking()
        {
            //booking ticket
            Console.WriteLine($"Displaying the theatre Details");
            Grid<string, TheatreDetails> theatreGrid = new Grid<string, TheatreDetails>();
            theatreGrid.ShowTables(Theaters);
            Console.WriteLine($"Enter the Theater ID");
            //theater input
            string userEnteredTheaterID = Console.ReadLine();
            //searching theatre
            BinarySearch<string, TheatreDetails> theatreSearch = new BinarySearch<string, TheatreDetails>();
            TheatreDetails theater = theatreSearch.Search(Theaters, userEnteredTheaterID, "TheatreID");
            if (theater != null)
            {
                //selecting the screen
                MyDictionary<string, ScreeningDetails> availableScreen = new MyDictionary<string, ScreeningDetails>();
                foreach (KeyValue<string, ScreeningDetails> screen in Screens)
                {
                    if (screen.Value.TheatreID.Equals(theater.TheatreID))
                    {
                        availableScreen.Add(screen.Value.ScreeningID, screen.Value);
                    }
                }
                if (availableScreen != null && availableScreen.Count >= 0)
                {
                    // Grid<string, ScreeningDetails> screenGrid = new Grid<string, ScreeningDetails>();
                    // screenGrid.ShowTables(availableScreen);
                    Console.WriteLine($"Text");
                    MyDictionary<string, MovieDetails> availableMovies = new MyDictionary<string, MovieDetails>();
                    foreach (KeyValue<string, ScreeningDetails> screen in Screens)
                    {
                        BinarySearch<string, MovieDetails> movieSearch = new BinarySearch<string, MovieDetails>();
                        MovieDetails movie = movieSearch.Search(Movies, screen.Value.MovieID, "MovieID");
                        if (movie != null)
                        {
                            availableMovies.Add(movie.MovieID, movie);
                        }
                    }
                    //printing movie details
                    Grid<string, MovieDetails> movieGrid = new Grid<string, MovieDetails>();
                    movieGrid.ShowTables(availableMovies);
                    Console.WriteLine($"Enter the Movie ID");
                    string userEnteredMovieID = Console.ReadLine();
                    BinarySearch<string, MovieDetails> movieSearching = new BinarySearch<string, MovieDetails>();
                    MovieDetails movieSelected = movieSearching.Search(Movies, userEnteredMovieID, "MovieID");
                    //checking movie
                    if (movieSelected != null)
                    {
                        Console.WriteLine($"Enter Number of seats needed");
                        int userEnteredNumberOfSeats = Convert.ToInt32(Console.ReadLine());
                        //getting the screen Count
                        BinarySearch<string, ScreeningDetails> screenSearch = new BinarySearch<string, ScreeningDetails>();
                        ScreeningDetails screenedValue = screenSearch.Search(availableScreen, movieSelected.MovieID, "MovieID");
                        //checking seats
                        if (userEnteredNumberOfSeats < screenedValue.NoOfSeatsAvailable)
                        {
                            double amountBeforeGST = userEnteredNumberOfSeats * screenedValue.TicketPrice;
                            double amount = amountBeforeGST + amountBeforeGST * 18 / 100;
                            //checking walletBalance
                            if (amount < CurrentUser.WalletBalance)
                            {
                                CurrentUser.DeductBalance(amount);
                                screenedValue.NoOfSeatsAvailable -= userEnteredNumberOfSeats;
                                BookingDetails book = new BookingDetails(CurrentUser.UserID, movieSelected.MovieID, theater.TheatreID, userEnteredNumberOfSeats, amount, BookingStatusDetails.Booked);
                                Bookings.Add(book.BookingID, book);
                                Console.WriteLine($"Booking Successful");
                            }
                            //if not balance
                            else
                            {
                                Console.WriteLine($"Insuffcient Wallet Balance Please Recharge your Wallet");
                            }
                        }
                        // if no seats
                        else
                        {
                            Console.WriteLine($"Seats are not available");

                        }
                    }
                    //no movies then
                    else
                    {
                        Console.WriteLine($"Please Enter valid movie ID");
                    }

                }
                
            }
            else
            {
                Console.WriteLine($"Please Enter Valid TheaterID");
            }
        }
        //cancelling the ticket
        public static void TicketCancellation()
        {
            //showing the booking history to the user
            MyDictionary<string, BookingDetails> userBooking = new MyDictionary<string, BookingDetails>();
            foreach (KeyValue<string, BookingDetails> booking in Bookings)
            {
                if (CurrentUser.UserID.Equals(booking.Value.UserID) && booking.Value.BookingStatus.Equals(BookingStatusDetails.Booked))
                {
                    userBooking.Add(booking.Key, booking.Value);
                }
            }
            //checking user made a booking already
            if (userBooking != null && userBooking.Count > 0)
            {
                Grid<string, BookingDetails> bookingGrid = new Grid<string, BookingDetails>();
                bookingGrid.ShowTables(userBooking);
                Console.WriteLine($"Enter the booking ID");
                string userEnteredBookingID = Console.ReadLine();
                BinarySearch<string, BookingDetails> bookingSearch = new BinarySearch<string, BookingDetails>();
                BookingDetails bookingMadeByUser = bookingSearch.Search(userBooking, userEnteredBookingID, "BookingID");
                //getting booking to cancel
                if (bookingMadeByUser != null)
                {
                    //refunding and cancelling
                    CurrentUser.RechargeWallet(bookingMadeByUser.TotalAmount - 20);
                    bookingMadeByUser.BookingStatus = BookingStatusDetails.Cancelled;
                    Console.WriteLine($"Booking Cancelled");
                }
                //if invalid booking id
                else
                {
                    Console.WriteLine($"Please Enter valid booking ID");
                }
            }
            //if no booking exists
            else
            {
                Console.WriteLine($"You haven't made any booking yet");

            }

        }
        //checking for the booking history
        public static void BookingHistory()
        {
            //checking for previous booking
            MyDictionary<string, BookingDetails> userBooking = new MyDictionary<string, BookingDetails>();
            foreach (KeyValue<string, BookingDetails> booking in Bookings)
            {
                if (CurrentUser.UserID.Equals(booking.Value.UserID))
                {
                    userBooking.Add(booking.Key, booking.Value);
                }
            }
            if (userBooking != null && userBooking.Count > 0)
            {
                Grid<string, BookingDetails> bookingGrid = new Grid<string, BookingDetails>();
                bookingGrid.ShowTables(userBooking);
            }
            //if he has no previous booking
            else
            {
                Console.WriteLine($"You haven't made any booking yet");

            }
        }
        public static void WalletRecharge()
        {
            //recharging the wallet
            Console.WriteLine($"Enter the amount to recharge");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Balance after recharge : {CurrentUser.RechargeWallet(amount)}");


        }
        public static void ShowWalletBalance()
        {
            //showing wallet balance
            Console.WriteLine($"The Wallet Balance  : {CurrentUser.WalletBalance}");
        }
        public static void WriteToFile()
        {
            //writing the data to the file
            FileHandling<string, UserDetails>.WriteToCSV(Users);
            FileHandling<string, BookingDetails>.WriteToCSV(Bookings);
            FileHandling<string, MovieDetails>.WriteToCSV(Movies);
            FileHandling<string, ScreeningDetails>.WriteToCSV(Screens);
            FileHandling<string, TheatreDetails>.WriteToCSV(Theaters);
        }
    }
}