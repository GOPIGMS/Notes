using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using OnlineFoodDeliveryApplication.Enums;
using OnlineFoodDeliveryApplication.Models;

namespace OnlineFoodDeliveryApplication
{
    public class Operations
    {
        //creating the global list value for storing datas for each class
        public static List<CustomerDetails> Customers = new List<CustomerDetails>();
        public static List<FoodDetails> Foods = new List<FoodDetails>();
        public static List<OrderDetails> Orders = new List<OrderDetails>();
        public static List<ItemsDetails> Items = new List<ItemsDetails>();
        public static CustomerDetails currentUser;
        //reading from the csv
        public static void ReadFromFile()
        {
            //reading the files and storing it in the list
            Customers = FileHandling<CustomerDetails>.ReadFromCSV(Customers);
            Foods = FileHandling<FoodDetails>.ReadFromCSV(Foods);
            Orders = FileHandling<OrderDetails>.ReadFromCSV(Orders);
            Items = FileHandling<ItemsDetails>.ReadFromCSV(Items);

        }
        public static void DefaultData()
        {
            //loading default customer list
            Customers.Add(new CustomerDetails("CID1001", 10000, "Ravi", "Ettapparajan", GenderDetails.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai"));
            Customers.Add(new CustomerDetails("CID1002", 15000, "Bhaskaran", "Sethurajan", GenderDetails.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai"));
            //loading default adding the  food details
            Foods.Add(new FoodDetails("FID2001", "Chicken Briyani 1Kg", 100, 12));
            Foods.Add(new FoodDetails("FID2002", "Mutton Briyani 1Kg", 150, 10));
            Foods.Add(new FoodDetails("FID2003", "Veg Full Meals", 80, 30));
            Foods.Add(new FoodDetails("FID2004", "Noodles", 100, 40));
            Foods.Add(new FoodDetails("FID2005", "Dosa", 40, 40));
            Foods.Add(new FoodDetails("FID2006", "Idly (2 pieces)", 20, 50));
            Foods.Add(new FoodDetails("FID2007", "Pongal", 40, 20));
            Foods.Add(new FoodDetails("FID2008", "Vegetable Briyani", 80, 15));
            Foods.Add(new FoodDetails("FID2009", "Lemon Rice", 50, 30));
            Foods.Add(new FoodDetails("FID2010", "Veg Pulav", 120, 30));
            Foods.Add(new FoodDetails("FID2011", "Chicken 65 (200 Grams)", 75, 30));
            //loading default orderDetails
            Orders.Add(new OrderDetails("OID3001", "CID1001", 580, new DateTime(2022, 11, 26), OrderStatusDetails.Ordered));
            Orders.Add(new OrderDetails("OID3002", "CID1002", 870, new DateTime(2022, 11, 26), OrderStatusDetails.Ordered));
            Orders.Add(new OrderDetails("OID3003", "CID1001", 820, new DateTime(2022, 11, 26), OrderStatusDetails.Cancelled));
            //loading default itemDetails
            Items.Add(new ItemsDetails("ITID4001", "OID3001", "FID2001", 2, 200));
            Items.Add(new ItemsDetails("ITID4002", "OID3001", "FID2002", 2, 300));
            Items.Add(new ItemsDetails("ITID4003", "OID3001", "FID2003", 1, 80));
            Items.Add(new ItemsDetails("ITID4004", "OID3002", "FID2001", 1, 100));
            Items.Add(new ItemsDetails("ITID4005", "OID3002", "FID2002", 4, 600));
            Items.Add(new ItemsDetails("ITID4006", "OID3002", "FID2010", 1, 120));
            Items.Add(new ItemsDetails("ITID4007", "OID3002", "FID2009", 1, 50));
            Items.Add(new ItemsDetails("ITID4008", "OID3003", "FID2002", 2, 300));
            Items.Add(new ItemsDetails("ITID4009", "OID3003", "FID2008", 4, 320));
            Items.Add(new ItemsDetails("ITID4010", "OID3003", "FID2001", 2, 200));
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
            Console.WriteLine($"Enter the customer name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the customer father name");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the customer Gender");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the mobil number");
            long mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the Date Of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the mailID");
            string mailID = Console.ReadLine();
            //creating object
            CustomerDetails customer = new CustomerDetails(name, fatherName, gender, mobile, dob, mailID);
            Customers.Add(customer);
            Console.WriteLine($"Customer Registration successful and your  Customer ID : {customer.CustomerID}");

        }
        //login 
        public static void Login()
        {
            //getting the customer id
            Console.WriteLine($"Enter the customer ID :");
            string enteredCustomerID = Console.ReadLine();
            // BinarySearch<CustomerDetails> customerBinarySearch = new BinarySearch<CustomerDetails>();
            // CustomerDetails customer = customerBinarySearch.Search(Customers, enteredCustomerID, "CustomerID");
            var customer = (CustomerDetails)(from emp in Customers
                                             where emp.CustomerID == enteredCustomerID
                                             select emp).SingleOrDefault();
            if (customer != null)
            {
                try
                {
                    //storing the customer to global value
                    currentUser = customer;
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
                    Console.WriteLine($"Enter the Options\ni.	Show Profile\nii.	Order Food\niii.	Cancel Order\niv.	Modify Order\nv.	Order History\nvi.	Recharge Wallet\nvii.	Show Wallet Balance\nviii.	Exit");
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
                        case "i":
                            {
                                try
                                {
                                    //showing  the user profile
                                    Console.WriteLine($"Show profile");
                                    ShowProfile();

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"The problem is {ex.Message}");
                                }

                                break;
                            }
                        case "ii":
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
                        case "iii":
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
                        case "iv":
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
                        case "v":
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
                        case "vi":
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
                        case "vii":
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
                        case "viii":
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
            List<CustomerDetails> customerDetails = new List<CustomerDetails>();
            customerDetails.Add(currentUser);
            //displaying the details
            Grid<CustomerDetails> customerGrid = new Grid<CustomerDetails>();
            customerGrid.ShowTable(customerDetails);
        }
        // //orderFood
        public static void OrderFood()
        {
            //creating the order
            OrderDetails order = new OrderDetails(currentUser.CustomerID, 0, DateTime.Now, OrderStatusDetails.Initiated);
            List<ItemsDetails> localItemList = new List<ItemsDetails>();
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
                FoodDetails food = (from foodSelected in Foods
                                    where foodSelected.FoodID == foodID
                                    select foodSelected).SingleOrDefault();
                if (food != null)
                {
                    //checking for the quantity
                    if (food.QuantityAvailable >= quantity)
                    {
                        total = quantity * food.PricePerQuantity;
                        food.QuantityAvailable -= quantity;
                        ItemsDetails item = new ItemsDetails(order.OrderID, food.FoodID, quantity, total);
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
                            if (currentUser.WalletBalance > total)
                            {
                                foreach (ItemsDetails item in localItemList)
                                {
                                    Items.Add(item);
                                }
                                //creating the order
                                currentUser.DeductBalance(order.TotalPrice);
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
                                            currentUser.WalletRecharge(amount);
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
                                                        food.QuantityAvailable += item.PurchaseCount;
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
                                        food.QuantityAvailable += item.PurchaseCount;
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
            List<OrderDetails> orderHistory = new List<OrderDetails>();
            // foreach (OrderDetails order in Orders)
            // {
            //     if (order.CustomerID.Equals(currentUser.CustomerID) && order.OrderStatus.Equals(OrderStatusDetails.Ordered))
            //     {
            //         orderHistory.Add(order);
            //     }
            // }
            //implementing linq
            orderHistory = (from order in Orders
                            where order.CustomerID == currentUser.CustomerID && order.OrderStatus == OrderStatusDetails.Ordered
                            select order).ToList();
            //checking the user had any previous purchase
            if (orderHistory != null && orderHistory.Count > 0)
            {

                Grid<OrderDetails> orderGrid = new Grid<OrderDetails>();
                orderGrid.ShowTable(orderHistory);
                Console.WriteLine($"Enter the orderID to cancel");
                string enteredOrderID = Console.ReadLine();
                // BinarySearch<OrderDetails> orderBinarySearch = new BinarySearch<OrderDetails>();
                // OrderDetails order1 = orderBinarySearch.Search(Orders, enteredOrderID, "OrderID");

                //linq implementation
                OrderDetails order1 = (from order in Orders
                                       where order.OrderID == enteredOrderID
                                       select order).SingleOrDefault();
                if (order1 != null)
                {
                    order1.OrderStatus = OrderStatusDetails.Cancelled;
                    double refundAmount = order1.TotalPrice;
                    currentUser.WalletRecharge(refundAmount);
                    //returnin the items
                    foreach (ItemsDetails item in Items)
                    {
                        if (item.OrderID.Equals(order1.OrderID))
                        {
                            //adding the count
                            // BinarySearch<FoodDetails> foodBinarySearch = new BinarySearch<FoodDetails>();
                            // FoodDetails resultFood = foodBinarySearch.Search(Foods, item.FoodID, "FoodID");
                            FoodDetails resultFood = (from food in Foods
                                                      where item.FoodID == food.FoodID
                                                      select food).SingleOrDefault();
                            resultFood.QuantityAvailable += item.PurchaseCount;

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
            List<OrderDetails> orderHistory = new List<OrderDetails>();
            orderHistory = (from order in Orders
                            where order.CustomerID == currentUser.CustomerID && order.OrderStatus == OrderStatusDetails.Ordered
                            select order).ToList();
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
                    List<ItemsDetails> itemInOrders = new List<ItemsDetails>();
                    itemInOrders = (from currentitem in Items
                                    where currentitem.OrderID == order1.OrderID
                                    select currentitem).ToList();
                    //displaying the items
                    Grid<ItemsDetails> itemGrid = new Grid<ItemsDetails>();
                    itemGrid.ShowTable(itemInOrders);
                    Console.WriteLine($"Enter the  Item ID");
                    string itemID = Console.ReadLine();
                    ItemsDetails item = (from currentitem in itemInOrders
                                         where itemID == currentitem.ItemID
                                         select currentitem).SingleOrDefault();
                    if (item != null)
                    {
                        FoodDetails food = (from currentfood in Foods
                                            where item.FoodID == currentfood.FoodID
                                            select currentfood).SingleOrDefault();
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
                                                if (food.PricePerQuantity * quantity > currentUser.WalletBalance)
                                                {
                                                    Console.WriteLine($"Insufficient Balance do you want to  Recharge to continue press yes ");
                                                    string userCondition = Console.ReadLine().ToLower();
                                                    if (userCondition == "yes")
                                                    {
                                                        Console.WriteLine($"Enter the amount to recharge");
                                                        double amount = Convert.ToDouble(Console.ReadLine());
                                                        currentUser.WalletRecharge(amount);
                                                    }
                                                    else
                                                    {
                                                        //exiting payment
                                                        isPaymentAddingContinue = false;
                                                    }

                                                }
                                                else
                                                {
                                                    //modifying the data
                                                    food.QuantityAvailable -= quantity;
                                                    currentUser.DeductBalance(food.PricePerQuantity * quantity);
                                                    order1.TotalPrice += food.PricePerQuantity * quantity;
                                                    item.PurchaseCount += quantity;
                                                    item.PriceOfOrder += food.PricePerQuantity * quantity;
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
                                        if (quantity > item.PurchaseCount)
                                        {
                                            Console.WriteLine($"Invalid Quantity");

                                        }
                                        else
                                        {
                                            //modifying the purchased values                                          
                                            food.QuantityAvailable += quantity;
                                            currentUser.WalletRecharge(food.PricePerQuantity * quantity);
                                            order1.TotalPrice -= food.PricePerQuantity * quantity;
                                            item.PurchaseCount -= quantity;
                                            item.PriceOfOrder -= food.PricePerQuantity * quantity;
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
            List<OrderDetails> orderHistory = new List<OrderDetails>();
            //linq implementation
            orderHistory = (from order in Orders
                            where order.CustomerID == currentUser.CustomerID
                            select order).ToList();
            //if he has previous order
            if (orderHistory != null && orderHistory.Count > 0)
            {

                Grid<OrderDetails> orderGrid = new Grid<OrderDetails>();
                orderGrid.ShowTable(orderHistory);
                Console.WriteLine($"Enter the order id to display the items");
                string userEnteredOrderID = Console.ReadLine();
                //linq changes
                OrderDetails order = (from orderSelected in orderHistory
                                      where orderSelected.OrderID == userEnteredOrderID
                                      select orderSelected).SingleOrDefault();
                List<ItemsDetails> userOrderedItems = new List<ItemsDetails>();
                if (order != null)
                {
                    userOrderedItems = (from item in Items
                                        where item.OrderID == order.OrderID
                                        select item).ToList();
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
            Console.WriteLine($"The Balance is {currentUser.WalletRecharge(amount)}");


        }
        //show Wallet Balance
        public static void ShowWalletBalance()
        {
            //displaying the balance
            Console.WriteLine($"The walletBalance Balance is {currentUser.WalletBalance}");

        }
        public static void WriteToFile()
        {
            //writing the file to the csv
            FileHandling<CustomerDetails>.WriteToCSV(Customers);
            FileHandling<ItemsDetails>.WriteToCSV(Items);
            FileHandling<OrderDetails>.WriteToCSV(Orders);
            FileHandling<FoodDetails>.WriteToCSV(Foods);
        }
    }
}