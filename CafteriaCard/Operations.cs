using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Threading.Tasks;
using CafeteriaCard.Enums;
using CafeteriaCard.Models;

using OnlineFoodDeliveryApplication.Models;

namespace CafeteriaCard
{
    public class Operations
    {
        //creating the global list value for storing datas for each class
        public static CustomList<UserDetails> Users = new CustomList<UserDetails>();
        public static CustomList<FoodDetails> Foods = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> Orders = new CustomList<OrderDetails>();
        public static CustomList<ItemsDetails> Items = new CustomList<ItemsDetails>();
        public static UserDetails CurrentUser;
        //reading from the csv
        public static void ReadFromFile()
        {
            //reading the files and storing it in the list
            Users = FileHandling<UserDetails>.ReadFromCSV(Users);
            Foods = FileHandling<FoodDetails>.ReadFromCSV(Foods);
            Orders = FileHandling<OrderDetails>.ReadFromCSV(Orders);
            Items = FileHandling<ItemsDetails>.ReadFromCSV(Items);

        }
        public static void DefaultData()
        {
            //loading default customer list
            Users.Add(new UserDetails("SF1001", "WS101", 400, "Ravichandran", "Ettapparajan", GenderDetails.Male, 8857777575, "ravi@gmail.com"));
            Users.Add(new UserDetails("SF1002", "WS105", 500, "Baskaran", "Sethurajan", GenderDetails.Male, 9577747744, "baskaran@gmail.com"));
            //loading default adding the  food details
            Foods.Add(new FoodDetails("FID101", "Coffee", 20, 100));
            Foods.Add(new FoodDetails("FID102", "Tea", 15, 100));
            Foods.Add(new FoodDetails("FID103", "Biscuit", 10, 100));
            Foods.Add(new FoodDetails("FID104", "Juice", 50, 100));
            Foods.Add(new FoodDetails("FID105", "Puff", 40, 100));
            Foods.Add(new FoodDetails("FID106", "Milk", 10, 100));
            Foods.Add(new FoodDetails("FID107", "Popcorn", 20, 20));
            // //loading default orderDetails
            Orders.Add(new OrderDetails("OID1001", "SF1001", new DateTime(2022, 06, 15), 70, OrderStatusDetails.Ordered));
            Orders.Add(new OrderDetails("OID1002", "SF1002", new DateTime(2022, 06, 15), 100, OrderStatusDetails.Ordered));
            //loading default itemDetails
            Items.Add(new ItemsDetails("ITID101", "OID1001", "FID101", 20, 1));
            Items.Add(new ItemsDetails("ITID102", "OID1001", "FID103", 10, 1));
            Items.Add(new ItemsDetails("ITID103", "OID1001", "FID105", 40, 1));
            Items.Add(new ItemsDetails("ITID104", "OID1002", "FID103", 10, 1));
            Items.Add(new ItemsDetails("ITID105", "OID1002", "FID104", 50, 1));
            Items.Add(new ItemsDetails("ITID106", "OID1002", "FID105", 40, 1));
        }
        //showing main menu
        public static void MainMenu()
        {
            bool isMainMenuContinue = true;
            try
            {
                //displaying and performing the operation in  the menu
                int option;
                do
                {
                    Console.WriteLine($"---------------------------Main Menu---------------------------");
                    Console.WriteLine($"Enter the Options\n1.	Customer Registration\n2.	Customer Login\n3.	Exit");
                    Console.WriteLine($"---------------------------------------------------------------");
                    //Getting  the input values for the main menu
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
                                    //execute if the data is invalid
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
            //getting the input values
            Console.WriteLine($"Enter the user name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the workstation number");
            string workStationNumber = Console.ReadLine();
            Console.WriteLine($"Enter the Balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the customer father name");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the customer Gender");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the mobil number");
            long mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the mailID");
            string mailID = Console.ReadLine();
            //creating object
            UserDetails user = new UserDetails(workStationNumber, balance, name, fatherName, gender, mobile, mailID);
            Users.Add(user);
            Console.WriteLine($"Customer Registration successful and your  User ID : {user.UserID}");

        }
        //login 
        public static void Login()
        {
            //getting the customer id
            Console.WriteLine($"Enter the customer ID :");
            string enteredCustomerID = Console.ReadLine();
            BinarySearch<UserDetails> customerBinarySearch = new BinarySearch<UserDetails>();
            UserDetails user = customerBinarySearch.Search(Users, enteredCustomerID, "UserID");
            if (user != null)
            {
                try
                {
                    //storing the customer to global value
                    CurrentUser = user;
                    SubMenu();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"The problem is {ex.Message}");
                }

            }
            //if the enter customer id is invalid
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
                //performing the sub menu operation
                string option;
                do
                {
                    Console.WriteLine($"---------------------------Sub Menu---------------------------");
                    Console.WriteLine($"Enter the Options\na.	 Show My Profile\nb.	 Food Order\nc.	 Modify Order\nd.	 Cancel Order\ne.	 Order History\nf.	 Wallet Recharge\ng.	 Show WalletBalance\nh.	 Exit");
                    Console.WriteLine($"---------------------------------------------------------------");
                    //getting the input
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
                                    //showing  the user profile
                                    ShowProfile();
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
                                    //OrderFood
                                    OrderFood();
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
                                    //Modify order
                                    ModifyOrder();

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
                                    //Cancel Order
                                    CancelOrder();
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
                                    //OrderHistory
                                    OrderHistory();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "f":
                            {
                                try
                                {
                                    //Recharge wallet of the user
                                    RechargeWallet();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "g":
                            {
                                try
                                {
                                    //show Wallet Balance
                                    ShowWalletBalance();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "h":
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
        //Show Profile
        public static void ShowProfile()
        {
            // showing the user profile
            CustomList<UserDetails> userDetails = new CustomList<UserDetails>();
            userDetails.Add(CurrentUser);
            //displaying the details
            Grid<UserDetails> userGrid = new Grid<UserDetails>();
            userGrid.ShowTable(userDetails);
        }
        //orderFood
        public static void OrderFood()
        {
            //creating the order
            OrderDetails order = new OrderDetails(CurrentUser.UserID,  DateTime.Now,0, OrderStatusDetails.Initiated);
            CustomList<ItemsDetails> localItemList = new CustomList<ItemsDetails>();
            double total = 0;
            bool isProcessContinue = true;
            do
            {
                //displaying the grid
                Grid<FoodDetails> foodGrid = new Grid<FoodDetails>();
                foodGrid.ShowTable(Foods);
                Console.WriteLine($"Enter the foodID");
                string foodID = Console.ReadLine();
                Console.WriteLine($"Enter the quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                //getting the foodDetails
                BinarySearch<FoodDetails> foodSearch = new BinarySearch<FoodDetails>();
                FoodDetails food = foodSearch.Search(Foods, foodID, "FoodID");
                if (food != null)
                {
                    //checking for the quantity
                    if (food.QuantityAvailable >= quantity)
                    {
                        total = quantity * food.Price;
                        food.QuantityAvailable -= quantity;
                        ItemsDetails item = new ItemsDetails(order.OrderID, food.FoodID,total, quantity);
                        localItemList.Add(item);
                        order.TotalPrice += total;

                    }
                    //if quantity is sufficient
                    else
                    {
                        Console.WriteLine($"Quantity you have entered is not available");
                    }
                }
                //invalid food id
                else
                {
                    Console.WriteLine($"The food is not available");
                }
                Console.WriteLine($"Do you want to add more press yes else press no");
                string optionToAddMore = Console.ReadLine().ToLower();
                switch (optionToAddMore)
                {
                    case "yes":
                        {
                            //by default it will continue
                            break;
                        }
                    case "no":
                        {
                            //exiting the main menu
                            isProcessContinue = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Invalid Input");
                            break;
                        }
                }

            } while (isProcessContinue);
            //performing the payment operation
            bool isPaymentProcessContinue = true;
            do
            {
                //Do you want to continue for payment
                Console.WriteLine($"Do you want to confirm purchase enter yes else press no");
                string option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "yes":
                        {
                            if (CurrentUser.WalletBalance >= total)
                            {
                                foreach (ItemsDetails item in localItemList)
                                {
                                    Items.Add(item);
                                }
                                //creating the order
                                CurrentUser.DeductBalance(order.TotalPrice);
                                order.OrderStatus = OrderStatusDetails.Ordered;
                                Orders.Add(order);
                                Console.WriteLine($"Order Successful");
                                isPaymentProcessContinue = false;

                            }
                            //if the balance is insufficient
                            else
                            {
                                Console.WriteLine($"Insufficient Balance. Do you want to recharge the wallet press yes else press no ");
                                string rechargeOption = Console.ReadLine().ToLower();
                                switch (rechargeOption)
                                {
                                    case "yes":
                                        {
                                            Console.WriteLine($"Enter the amount to recharge");
                                            double amount = Convert.ToDouble(Console.ReadLine());
                                            CurrentUser.WalletRecharge(amount);
                                            break;
                                        }
                                    case "no":
                                        {
                                            foreach (ItemsDetails item in localItemList)
                                            {
                                                foreach (FoodDetails food in Foods)
                                                {
                                                    if (item.FoodID.Equals(food.FoodID))
                                                    {
                                                        food.QuantityAvailable += item.OrderQuantity;
                                                    }
                                                }
                                            }
                                            isPaymentProcessContinue = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine($"Invalid Input");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "no":
                        {
                            foreach (ItemsDetails item in localItemList)
                            {
                                foreach (FoodDetails food in Foods)
                                {
                                    if (item.FoodID.Equals(food.FoodID))
                                    {
                                        food.QuantityAvailable += item.OrderQuantity;
                                    }
                                }
                            }
                            isPaymentProcessContinue = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Invalid Input");
                            break;
                        }
                }


            } while (isPaymentProcessContinue);


        }
        //cancel Order
        public static void CancelOrder()
        {
            //orderHistory
            CustomList<OrderDetails> orderHistory = new CustomList<OrderDetails>();
            foreach (OrderDetails order in Orders)
            {
                if (order.UserID.Equals(CurrentUser.UserID) && order.OrderStatus.Equals(OrderStatusDetails.Ordered))
                {
                    orderHistory.Add(order);
                }
            }
            //checking the user had any previous purchase
            if (orderHistory != null && orderHistory.Count > 0)
            {

                Grid<OrderDetails> orderGrid = new Grid<OrderDetails>();
                orderGrid.ShowTable(orderHistory);
                Console.WriteLine($"Enter the orderID to cancel");
                string enteredOrderID = Console.ReadLine();
                BinarySearch<OrderDetails> orderBinarySearch = new BinarySearch<OrderDetails>();
                OrderDetails order1 = orderBinarySearch.Search(Orders, enteredOrderID, "OrderID");
                if (order1 != null)
                {
                    order1.OrderStatus = OrderStatusDetails.Cancelled;
                    double refundAmount = order1.TotalPrice;
                    CurrentUser.WalletRecharge(refundAmount);
                    //returnin the items
                    foreach (ItemsDetails item in Items)
                    {
                        if (item.OrderID.Equals(order1.OrderID))
                        {
                            //adding the count
                            BinarySearch<FoodDetails> foodBinarySearch = new BinarySearch<FoodDetails>();
                            FoodDetails resultFood = foodBinarySearch.Search(Foods, item.FoodID, "FoodID");
                            resultFood.QuantityAvailable = item.OrderQuantity;
                        }
                    }
                    Console.WriteLine($"OrderCancelled");
                }
                //Invalid OrderID
                else
                {
                    Console.WriteLine($"Invalid OrderID");

                }
            }
            //no order
            else
            {
                Console.WriteLine($"You haven't made any order yet");
            }
        }

        //modify Data
        public static void ModifyOrder()
        {
            //orderHistory
            CustomList<OrderDetails> orderHistory = new CustomList<OrderDetails>();
            foreach (OrderDetails order in Orders)
            {
                if (order.UserID.Equals(CurrentUser.UserID) && order.OrderStatus.Equals(OrderStatusDetails.Ordered))
                {
                    orderHistory.Add(order);
                }
            }
            if (orderHistory != null && orderHistory.Count > 0)
            {
                //creating the order grid
                Grid<OrderDetails> orderGrid = new Grid<OrderDetails>();
                orderGrid.ShowTable(orderHistory);
                Console.WriteLine($"Enter the orderID to Modify");
                string enteredOrderID = Console.ReadLine();
                //searching for order
                BinarySearch<OrderDetails> orderBinarySearch = new BinarySearch<OrderDetails>();
                OrderDetails order1 = orderBinarySearch.Search(Orders, enteredOrderID, "OrderID");
                if (order1 != null)
                {

                    //returning the items
                    CustomList<ItemsDetails> itemInOrders = new CustomList<ItemsDetails>();
                    foreach (ItemsDetails currentitem in Items)
                    {
                        if (currentitem.OrderID.Equals(order1.OrderID))
                        {
                            itemInOrders.Add(currentitem);
                        }
                    }
                    //displaying the items
                    Grid<ItemsDetails> itemGrid = new Grid<ItemsDetails>();
                    itemGrid.ShowTable(itemInOrders);
                    Console.WriteLine($"Enter the  Item ID");
                    string itemID = Console.ReadLine();
                    BinarySearch<ItemsDetails> itemBinarySearch = new BinarySearch<ItemsDetails>();
                    ItemsDetails item = itemBinarySearch.Search(Items, itemID, "ItemID");
                    if (item != null)
                    {
                        BinarySearch<FoodDetails> foodSearch = new BinarySearch<FoodDetails>();
                        FoodDetails food = foodSearch.Search(Foods, item.FoodID, "FoodID");
                        Console.WriteLine($"Enter \n1.Increase Quantity and \n2.Decrease the quantity");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            //increase the order
                            case 1:
                                {
                                    try
                                    {
                                        Console.WriteLine($"Enter the quantity to increase");
                                        int quantity = Convert.ToInt32(Console.ReadLine());
                                        if (quantity > food.QuantityAvailable)
                                        {
                                            Console.WriteLine($"Quantity not available");

                                        }
                                        else
                                        {
                                            bool isPaymentAddingContinue = true;
                                            do
                                            {
                                                if (food.Price * quantity > CurrentUser.WalletBalance)
                                                {
                                                    Console.WriteLine($"Insufficient Balance do you want to  Recharge to continue press yes ");
                                                    string userCondition = Console.ReadLine().ToLower();
                                                    if (userCondition == "yes")
                                                    {
                                                        Console.WriteLine($"Enter the amount to recharge");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        CurrentUser.WalletRecharge(amount);
                                                    }
                                                    else
                                                    {
                                                        isPaymentAddingContinue = false;
                                                    }

                                                }
                                                else
                                                {
                                                    //modifying the data
                                                    food.QuantityAvailable -= quantity;
                                                    CurrentUser.DeductBalance(food.Price * quantity);
                                                    order1.TotalPrice += food.Price * quantity;
                                                    item.OrderQuantity += quantity;
                                                    isPaymentAddingContinue = false;
                                                    Console.WriteLine($"The {order1.OrderID} modified successfully");

                                                }
                                            } while (isPaymentAddingContinue);
                                        }

                                    }
                                    catch (System.Exception ex)
                                    {
                                        Console.WriteLine($"The problem is {ex.Message}");

                                    }
                                    break;
                                }
                            //decreasing or deleting the order
                            case 2:
                                {
                                    try
                                    {
                                        Console.WriteLine($"Enter the quantity to Decrease");
                                        int quantity = Convert.ToInt32(Console.ReadLine());
                                        if (quantity > item.OrderQuantity)
                                        {
                                            Console.WriteLine($"Invalid Quantity");

                                        }
                                        else
                                        {
                                            //modifying the purchased values                                          
                                            food.QuantityAvailable += quantity;
                                            CurrentUser.WalletRecharge(food.Price * quantity);
                                            order1.TotalPrice -= food.Price * quantity;
                                            item.OrderQuantity -= quantity;
                                            Console.WriteLine($"The {order1.OrderID} modified successfully");
                                        }
                                    }
                                    catch (System.Exception ex)
                                    {
                                        Console.WriteLine($"The problem is {ex.Message}");
                                    }
                                    break;
                                }
                        }

                    }
                    //item id is invalid
                    else
                    {
                        Console.WriteLine($"Please enter valid item id");

                    }
                }
                //Invalid OrderID
                else
                {
                    Console.WriteLine($"Invalid OrderID");
                }
            }
            //no order
            else
            {
                Console.WriteLine($"You haven't made any order yet");
            }
        }
        
        //order history
        public static void OrderHistory()
        {
            //creating the order history
            CustomList<OrderDetails> orderHistory = new CustomList<OrderDetails>();
            foreach (OrderDetails order in Orders)
            {
                if (order.UserID.Equals(CurrentUser.UserID))
                {
                    orderHistory.Add(order);
                }
            }
            //if he has previous order
            if (orderHistory != null && orderHistory.Count > 0)
            {

                Grid<OrderDetails> orderGrid = new Grid<OrderDetails>();
                orderGrid.ShowTable(orderHistory);
                Console.WriteLine($"Enter the order id to display the items");
                string userEnteredOrderID = Console.ReadLine();
                BinarySearch<OrderDetails> orderBinarySearch = new BinarySearch<OrderDetails>();
                OrderDetails order = orderBinarySearch.Search(orderHistory, userEnteredOrderID, "OrderID");
                CustomList<ItemsDetails> userOrderedItems = new CustomList<ItemsDetails>();
                if (order != null)
                {
                    foreach (ItemsDetails item in Items)
                    {
                        if (item.OrderID.Equals(order.OrderID))
                        {
                            userOrderedItems.Add(item);
                        }
                    }
                    Grid<ItemsDetails> itemGrid = new Grid<ItemsDetails>();
                    itemGrid.ShowTable(userOrderedItems);
                }
                else
                {
                    Console.WriteLine($"Please Ebter valid order ID");

                }

            }
            //no order
            else
            {
                Console.WriteLine($"You haven't made any order yet");

            }

        }
        //wallet recharge
        public static void RechargeWallet()
        {
            //getting amount to recharge
            Console.WriteLine($"Enter the amount to recharge");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Balance is {CurrentUser.WalletRecharge(amount)}");


        }
        //show Wallet Balance
        public static void ShowWalletBalance()
        {
            //displaying the balance
            Console.WriteLine($"The walletBalance Balance is {CurrentUser.WalletBalance}");

        }
        //         public static void WriteToFile()
        //     //     {
        //     //         //writing the file to the csv
        //     //         FileHandling<CustomerDetails>.WriteToCSV(Customers);
        //     //         FileHandling<ItemsDetails>.WriteToCSV(Items);
        //     //         FileHandling<OrderDetails>.WriteToCSV(Orders);
        //     //         FileHandling<FoodDetails>.WriteToCSV(Foods);
        //     //     }
    }
}