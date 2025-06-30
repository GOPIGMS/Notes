let customerIDAutoIncrement  :number=3001;
let ProductIDAutoIncrement :number =2001;
let OrderIDAutoIncrement :number =1001;

enum OrderStatusDetails{
    Initiated="Initiated",
    Ordered ="Ordered",
    Cancelled="Cancelled"

}

class CustomerDetails{
    CustomerID :string;
    CustomerName :string;
    City :string;
    MobileNumber : string;
    WalletBalance : number =0;
    EmailID :string ;
    Password : string;
    constructor( name :string, city : string, mobileNumber :string, walletBalance : number, email : string, password : string){
        this.CustomerID="CID" + customerIDAutoIncrement++ ;
        this.CustomerName =name;
        this.City=city;
        this.MobileNumber=mobileNumber;
        this.WalletBalance=walletBalance;
        this.EmailID = email;
        this.Password = password;
    }
}
class ProductDetails{
    ProductID :string;
    ProductName :string;
    Stock :number;
    Price : number;
    ShippingDuration : number;
    constructor( productName : string, stock : number, price : number,shippingDuration :number){
        this.ProductID ="PID" + ProductIDAutoIncrement++;
        this.ProductName=productName;
        this.Stock=stock;
        this.Price=price;
         this.ShippingDuration =shippingDuration;
    }
}



class OrderDetails{
    OrderID : string;
    CustomerID :string;
    ProductID :string;
    TotalPrice :number;
    PurchaseDate :Date;
    Quantity :number;
    OrderStatus : OrderStatusDetails;

    constructor(customerID : string ,productID : string, totalPrice : number, purchaseDate : Date,quantity : number,orderStatus :OrderStatusDetails ){
       this.OrderID ="OID" + OrderIDAutoIncrement++;
       this.CustomerID =customerID;
       this.ProductID =productID;
       this.TotalPrice =totalPrice;
       this.PurchaseDate =purchaseDate;
       this.Quantity =quantity;
       this.OrderStatus =orderStatus;

    }
}

let CustomerArrayList :  Array<CustomerDetails> = new Array<CustomerDetails>();

CustomerArrayList.push(new CustomerDetails("Ravi", "Chennai", "98885858588",50000,"ravi@mail.com","1234"));
CustomerArrayList.push(new CustomerDetails("Baskaran", "Chennai", "9888475757",60000,"baskaran@mail.com","1234"));
console.log(CustomerArrayList);

let ProductArrayList : Array<ProductDetails> = new Array<ProductDetails>();
ProductArrayList.push(new ProductDetails("Mobile (Samsung)",10,	10000,	3));
ProductArrayList.push(new ProductDetails("Tablet (Lenovo)",	5,15000,	2));
ProductArrayList.push(new ProductDetails("Camara (Sony)",3,20000,4));
ProductArrayList.push(new ProductDetails("iPhone", 	5,	50000,	6));
ProductArrayList.push(new ProductDetails("Laptop (Lenovo I3)",	3,	40000,	3));
ProductArrayList.push(new ProductDetails("HeadPhone (Boat)",	5,	1000,	2));
ProductArrayList.push(new ProductDetails("Speakers (Boat)",	4	,500	,2));

console.log(ProductArrayList);

let OrderArrayList : Array<OrderDetails> = new Array<OrderDetails>();

OrderArrayList.push(new OrderDetails("CID3001",	"PID2001",	20000, new Date()	,	2,	OrderStatusDetails.Ordered));
OrderArrayList.push(new OrderDetails("CID3002",	"PID2003",	40000, new Date()	,	2,	OrderStatusDetails.Ordered));

console.log(OrderArrayList);

var currentCustomer:CustomerDetails;
var homePage = document.getElementById("homePage") as HTMLDivElement;
var productPage = document.getElementById("ProductPage") as HTMLDivElement;
var topPage = document.getElementById("topUpPage") as HTMLDivElement;
var orderPage = document.getElementById("orderPage") as HTMLDivElement;
var showorderPage = document.getElementById("showorderPage") as HTMLDivElement;
var Proform =document.getElementById("showorderPage") as HTMLDivElement;
var signInForm = document.getElementById("signIn") as HTMLDivElement;
var signUpForm = document.getElementById("signUp") as HTMLDivElement;
var signInButton = document.getElementById("signInButton") as HTMLDivElement;
var signUpButton = document.getElementById("signUpButton") as HTMLDivElement;
var displayWalletBalance = document.getElementById("balance-page") as HTMLDivElement;
var medicinePage = document.getElementById("medicinePage") as HTMLDivElement;

function signIn(): void {
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}

function signUp(): void {
    signInForm.style.display = "none";
    signUpForm.style.display = "block";
    signInButton.style.background = "none";
    signUpButton.style.background = "orange";
}

async function signUpSubmit(e) {
    e.preventDefault();
    var name = document.getElementById("name") as HTMLInputElement;
    var email = document.getElementById("email") as HTMLInputElement;
    var password = document.getElementById("password") as HTMLInputElement;
    var phone = document.getElementById("phone") as HTMLInputElement;
    var city = document.getElementById("city") as HTMLInputElement;
    var walletBalance = document.getElementById("walletbalance") as HTMLInputElement;


    var isavail: boolean = true;
    CustomerArrayList.forEach((val) => {
        if (val.EmailID.toLowerCase() == email.value.toLowerCase()) {
            alert("you already have an ID. Please Sign In");
            isavail = false;
        }
    });
    
    if (isavail) {
        let customer: CustomerDetails = new CustomerDetails(name.value,city.value,phone.value,parseFloat(walletBalance.value),email.value,password.value);
        console.log(customer)
        CustomerArrayList.push(customer);
        alert("Your User ID is " + customer.CustomerID)
        isavail = false;

    }
    else {
        var i = document.getElementById("signup") as HTMLDivElement;
        i.style.border = "2px solid red";
    }
}

async function signInSubmit(e) {
    e.preventDefault();
    var isavail: boolean = true;
    var email = document.getElementById("email1") as HTMLInputElement;
    var password = document.getElementById("password2") as HTMLInputElement;

    CustomerArrayList.forEach((val) => {
        if (val.EmailID.toLowerCase() == email.value.toLowerCase() && val.Password == password.value) {
            var a = document.getElementById("box") as HTMLDivElement
            a.style.display = "none";
            var b = document.getElementById("menu") as HTMLDivElement;
            b.style.display = "block";
            isavail = false;
            currentCustomer=val;
           console.log("You are logged in ");
           home();
            email.value = "";
            password.value = "";
            alert("You are logged in ")
        }
    })
    if (isavail) {
        alert("Invalid Email or Password");
    }

}

async function home() {
    displayNone();
    homePage.style.display = "block";
    var welcome = document.getElementById("welcome") as HTMLHeadingElement;
    welcome.innerHTML = "Welcome " + currentCustomer.CustomerName;
}

async function displayNone() {
    homePage.style.display = "none";
    medicinePage.style.display = "none";
    productPage.style.display = "none";
    topPage.style.display = "none";
    displayWalletBalance.style.display="none";
    orderPage.style.display = "none";
    showorderPage.style.display ="none";

    (document.getElementById("addEditMedicineForm") as HTMLDivElement).style.display = "none";
}

async function displayBalance() {
     displayNone();
     displayWalletBalance.style.display="block";
     (document.getElementById("displayBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentCustomer.WalletBalance}`;

}
async function topup() {
    displayNone();
    topPage.style.display = "block";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentCustomer.WalletBalance}`;
}

async function deposit() {
    var amount = document.getElementById("amount") as HTMLInputElement;
    currentCustomer.WalletBalance += Number(amount.value);
    alert("Amount Dposited Successfully");
    amount.value = "";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentCustomer.WalletBalance}`;

}


async function logout() {
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display = "none";
    (document.getElementById("box") as HTMLDivElement).style.display = "block";
    //currentUser = null;
}

async function order() {
    displayNone();
    orderPage.style.display = "block";
    var orderTable = document.getElementById("orderTable") as HTMLTableElement;
    var len = orderTable.getElementsByTagName("tr").length;
    if (orderTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            orderTable.removeChild(orderTable.children[i]);
        }
    }

    OrderArrayList.forEach((order) => {
        if (order.CustomerID == currentCustomer.CustomerID && order.OrderStatus ==OrderStatusDetails.Ordered) {
            var row = document.createElement("tr") as HTMLTableRowElement;
            row.innerHTML= `<td>${order.OrderID}</td> <td>${order.CustomerID}</td> <td>${order.ProductID}</td> <td>${order.TotalPrice}</td> <td>${order.PurchaseDate.toLocaleDateString()}</td> 
            <td>${order.Quantity}</td> <td>${order.OrderStatus}</td>
            <td><button id="cancelbtn" onclick="cancelOrder('${order.OrderID}')">Cancel</button></td>`;
            orderTable.appendChild(row);
        }
    })
}
async function showorder() {
    displayNone();
    showorderPage.style.display = "block";
    var orderTable = document.getElementById("ordersTable") as HTMLTableElement;
    var len = orderTable.getElementsByTagName("tr").length;
    if (orderTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            orderTable.removeChild(orderTable.children[i]);
        }
    }

    OrderArrayList.forEach((order) => {
        if (order.CustomerID == currentCustomer.CustomerID) {
            var row = document.createElement("tr") as HTMLTableRowElement;
            row.innerHTML= `<td>${order.OrderID}</td> <td>${order.CustomerID}</td> <td>${order.ProductID}</td> <td>${order.TotalPrice}</td> <td>${order.PurchaseDate.toLocaleDateString()}</td> 
            <td>${order.Quantity}</td> <td>${order.OrderStatus}</td>`;
            orderTable.appendChild(row);
           
        }
    })
}

async function cancelOrder(orderID: string) {
    var orderData = OrderArrayList.find(o => o.OrderID == orderID && o.CustomerID == currentCustomer.CustomerID && o.OrderStatus == OrderStatusDetails.Ordered);
    if (orderData) {
   
        orderData.OrderStatus = OrderStatusDetails.Cancelled;
            currentCustomer.WalletBalance += orderData.TotalPrice;
            var productID = orderData.ProductID;
            var product = ProductArrayList.find(prod => prod.ProductID== productID);
            if (product) {
                product.Stock += orderData.Quantity;
            }
            alert(`Order : ${orderID} Cancelled successfully `);
            order();
        }
        else {
            alert("Order not found");
        }
}



async function showmedicine() {
    displayNone();
    medicinePage.style.display = "block";
    var table = document.getElementById("medicineTable") as HTMLTableElement;
    var len = table.getElementsByTagName("tr").length;
    if (table.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            table.removeChild(table.children[i]);
        }
    }


   
    ProductArrayList.forEach((product) => {
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${product.ProductID} </td>  <td> ${product.ProductName} </td> <td> ${product.Stock} </td> <td>${product.Price} </td> 
        <td>${product.ShippingDuration} </td>
        <td>
            <button onclick="editMedicine('${medicine.MedicineId}')">Edit</button>
            <button onclick="deleteMedicine('${medicine.MedicineId}')">Delete</button>
        </td>`;
        table.appendChild(row);
    });
}

let editMedicineID :string;
async function deleteMedicine(medicineID: string) {
    var index = MedicineList.findIndex((val) => val.MedicineId == medicineID);
    MedicineList.splice(index, 1);
    showmedicine();
}

async function addMedicine() {
    (document.getElementById("addEditMedicineForm") as HTMLDivElement).style.display = "block";
    editMedicineID = "";
}
async function editMedicine(medicineID: string) {
    (document.getElementById("addEditMedicineForm") as HTMLDivElement).style.display = "block";
     var medicine = MedicineList.find((val) => val.MedicineId == medicineID);
     if (medicine) {
        var name = document.getElementById("medicineName") as HTMLInputElement;
        var count = document.getElementById("medicineCount") as HTMLInputElement;
        var price = document.getElementById("medicinePrice") as HTMLInputElement;
        var expiryDate = document.getElementById("expiryDate") as HTMLInputElement;
        name.value = medicine.MedicineName;
        count.value = medicine.MedicineCount.toString();
        price.value = medicine.MedicinePrice.toString();
        expiryDate.value = medicine.ExpiryDate.toISOString().split('T')[0];
        editMedicineID = medicine.MedicineId;
    }
}

async function addEditMedicine() {
    var name = document.getElementById("medicineName") as HTMLInputElement;
    var count = document.getElementById("medicineCount") as HTMLInputElement;
    var price = document.getElementById("medicinePrice") as HTMLInputElement;
    var expiryDate = document.getElementById("expiryDate") as HTMLInputElement;
    var dateSplit: string[] = expiryDate.value.split("-");

    var medicineData = MedicineList.find(val => val.MedicineId == editMedicineID);
    if(medicineData)
    {
        medicineData.MedicineName = name.value;
        medicineData.MedicineCount = Number(count.value);
        medicineData.MedicinePrice = Number(price.value);
        medicineData.ExpiryDate = new Date(Number(dateSplit[0]), (Number(dateSplit[1]) - 1), (Number(dateSplit[2])));
        alert("Medicine details updated successfully");
        editMedicineID="";
    }
    else 
    {
        if (name.value.trim() != "") {
            MedicineList.push(new MedicineInfo(name.value, Number(count.value), Number(price.value), new Date(Number(dateSplit[0]), (Number(dateSplit[1]) - 1), Number(dateSplit[2]))));
            alert("Medicine details added successfully");
            editMedicineID="";
        }
    }
    name.value = "";
    count.value = "";
    price.value = "";
    expiryDate.value = "";
    showmedicine();
}
