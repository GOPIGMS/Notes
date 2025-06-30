// let customerIdAutoIncrement: number =1001;
// let foodIdAutoIncrement:number = 2001;
// let orderIdAutoIncrement :number =3001;
// let itemIdAutoIncrement :number=4001;

interface Balance {
    walletBalance: number;
}

enum GenderDetails {
    Select = "Select",
    Male = "Male",
    Female = "Female",
    TransGender = "Transgender"
}

enum OrderStatusDetails {
    Ordered = "Ordered",
    Cancelled = "Cancelled",
    Initiated = "Initiated"

}

interface PersonalDetails extends Balance {

    name: string;
    fatherName: string;
    gender: string;
    mobile: string;
    dob: string;
    mailID: string;
    location: string;
    password: string;
}

interface CustomerDetails extends PersonalDetails {
    customerID: number;
}

interface FoodDetails {
    foodID: number;
    foodName: string;
    pricePerQuantity: number;
    quantityAvailable: number;
}

interface OrderDetails {
    orderID: number;
    CustomerID: number;
    TotalPrice: number;
    DateOfOrder: Date;
    OrderStatus: string;
}

interface ItemDetails {
    itemID: number;
    orderID: number;
    foodID: number;
    purchaseCount: number;
    priceOfOrder: number;
}

var currentCustomer: CustomerDetails;
var sign1 = document.getElementById("signin") as HTMLDivElement;
var sign2 = document.getElementById("signup") as HTMLDivElement;
var sign3 = document.getElementById("si") as HTMLDivElement;
var sign4 = document.getElementById("su") as HTMLDivElement;

var homes = document.getElementById("home") as HTMLDivElement;
var menus = document.getElementById("menu") as HTMLDivElement;
var stocks = document.getElementById("stock") as HTMLDivElement;
var purchases = document.getElementById("purchase") as HTMLDivElement;
var historys = document.getElementById("history") as HTMLDivElement;
var topp = document.getElementById("top") as HTMLDivElement;
var showw = document.getElementById("show") as HTMLDivElement;
var carts = document.getElementById("cart") as HTMLDivElement;
var form1 = document.getElementById("form1") as HTMLDivElement;
var customerPage = document.getElementById("customerDetailsPage") as HTMLDivElement;
var itemDetailsPage = document.getElementById("itemDetailsPage") as HTMLDivElement;

var foodid = document.getElementById("foodid") as HTMLInputElement;
var foodName = document.getElementById("foodName") as HTMLInputElement;
var pricePerQuantity = document.getElementById("priceperQuantity") as HTMLInputElement;
var quantity = document.getElementById("quantityAvailable") as HTMLInputElement;

// var temporaryCart: Array<{ cartID: number, productID: number, productName: string, purchaseCount: number, priceOfOrder: number }> = new Array<{ cartID: number, productID: number, productName: string, purchaseCount: number, priceOfOrder: number }>();

function signIn(): void {
    displayNone();
    sign1.style.display = "block";
    sign2.style.display = "none";
    sign3.style.background = "orange";
    sign4.style.background = "none";

}

function signUp(): void {
    displayNone();
    sign1.style.display = "none";
    sign2.style.display = "block";
    sign3.style.background = "none";
    sign4.style.background = "orange";
}

function displayNone() {
    homes.style.display = "none";
    stocks.style.display = "none";
    purchases.style.display = "none";
    historys.style.display = "none";
    topp.style.display = "none";
    showw.style.display = "none";
    carts.style.display = "none";
    form1.style.display = "none";
    customerPage.style.display = "none";
    itemDetailsPage.style.display = "none";


}

async function signUpSubmit(e: Event) {
    e.preventDefault();
    var name = document.getElementById("name") as HTMLInputElement;
    var fathername = document.getElementById("fatherName") as HTMLInputElement;
    var mobile = document.getElementById("mobile") as HTMLInputElement;
    const genderElements = Array.from(document.getElementsByName("gender")) as HTMLInputElement[];
    const gender = genderElements.find(element => element.checked);
    var dob = document.getElementById("dob") as HTMLInputElement;
    var locations = document.getElementById("location") as HTMLInputElement;
    var email = document.getElementById("email") as HTMLInputElement;
    var password = document.getElementById("password") as HTMLInputElement;

    console.log(name.value)
    console.log(fathername.value)
    console.log(mobile.value)
    console.log(gender?.value)
    console.log(dob.value)
    console.log(locations.value)
    console.log(email.value)
    console.log(password.value)
    let isavail = false;
    var UserArrayList = await fetchUsers();
    console.log(UserArrayList);

    UserArrayList.forEach((val) => {
        if (val.mailID.toLowerCase() == email.value.toLowerCase()) {
            alert("you already have an ID. Please Sign In");
            isavail = true;

        }
    })
    console.log("posting")
    if (!isavail) {
        addUser({ customerID: undefined, name: name.value, fatherName: fathername.value, gender: gender.value, dob: dob.value, location: locations.value, mailID: email.value, password: password.value, mobile: mobile.value, walletBalance: 0 })
        alert("Customer Created")
        signIn();
    }


    //   if (file) {
    //     var fileReader = new FileReader();
    //     fileReader.readAsDataURL(file);
    //     fileReader.addEventListener('load', (event) => {
    //       base64 = event.target?.result as string;
    //       if (isavail) {
    //         addUser({ userID: undefined, name: name.value, email: email.value, password: password.value, image: [base64], amount: 0 })
    //         signIn();
    //       }
    //     })

    //   }
    // } else {
    //   var i = document.getElementById("signup") as HTMLDivElement;
    //   i.style.border = "2px solid red";
    // }
}

function signInSubmit(e: Event) {
    e.preventDefault();
    var isavail: boolean = true;
    var email = document.getElementById("email1") as HTMLInputElement;

    var password = document.getElementById("password2") as HTMLInputElement;
    console.log(email)
    console.log(password)


    fetchUsers().then(UserArrayList => {
        UserArrayList.forEach((val) => {
            if (val.mailID.toLowerCase() == email.value.toLowerCase() && val.password == password.value) {
                var a = document.getElementById("box") as HTMLDivElement
                a.style.display = "none";
                var b = document.getElementById("menu") as HTMLDivElement;
                b.style.display = "block"
                console.log(b);
                isavail = false;
                currentCustomer = val;
                home();
                email.value = "";
                password.value = ""

            }
            if (isavail) {
                alert("Invalid Email or Password");
            }
        })
    })
}

function home() {
    displayNone();
    homes.style.display = "block";
    var a = document.getElementById("welcome") as HTMLHeadingElement;
    a.innerHTML = "Welcome " + currentCustomer.name;

}

function showUser() {
    alert("showing User");
    displayNone();
    customerPage.style.display = "block";
    var tbody = document.getElementById("customerBody") as HTMLTableSectionElement;
    tbody.innerHTML = "";
    var row = document.createElement("tr");
    row.innerHTML = `

      <td>${currentCustomer.customerID}</td>
      <td>${currentCustomer.walletBalance}</td>
      <td>${currentCustomer.name}</td>
      <td>${currentCustomer.fatherName}</td>
      <td>${currentCustomer.gender}</td>
      <td>${currentCustomer.mobile}</td>
      <td>${currentCustomer.dob.split("T")[0].split("-").reverse().join("/")}</td>
      <td>${currentCustomer.location}</td>
      <td>${currentCustomer.mailID}</td>
      `
    tbody.appendChild(row);
}

function recharge() {
    displayNone();
    topp.style.display = "block";
    (document.getElementById("curBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentCustomer.walletBalance}`;
}

function show() {
    displayNone();
    showw.style.display = "block";
    var a = document.getElementById("balance") as HTMLHeadingElement;
    a.innerHTML = "Your Balance is " + currentCustomer.walletBalance;

}

async function deposit() {
    var a = document.getElementById("amount") as HTMLInputElement;
    currentCustomer = await updateAmount(currentCustomer.customerID, Number(a.value));

    alert("Amount Deposited Successfully");
    a.value = "";
    (document.getElementById("curBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentCustomer.walletBalance}`;

}

function Logout() {
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display = "none";
    (document.getElementById("box") as HTMLDivElement).style.display = "block";
}

var curIndex: number | null;

async function stock() {
    displayNone();
    stocks.style.display = "block";
    var tbody = document.getElementById("tbody1") as HTMLTableSectionElement;
    tbody.innerHTML = "";
    var bookList = await fetchProducts();
    bookList.forEach((element) => {
        if (element.quantityAvailable > 0) {
            console.log(element.foodID);
            var row = document.createElement("tr");
            row.innerHTML = `
  
        <td>${element.foodID}</td>
        <td>${element.foodName}</td>
        <td>${element.pricePerQuantity}</td>
        <td>${element.quantityAvailable}</td>
         <td>
         
        <button onclick="Edit(${element.foodID},'${element.foodName}',${element.quantityAvailable},${element.pricePerQuantity})">Edit</button>
        <button onclick="deleteProduct(${element.foodID})">Delete</button>
        </td>
        `
            tbody.appendChild(row);
        }
    }
    );
}

//   var foodid = document.getElementById("foodid") as HTMLInputElement;
// var foodName = document.getElementById("foodName") as HTMLInputElement;
// var pricePerQuantity = document.getElementById("priceperQuantity") as HTMLInputElement;
// var quantity = document.getElementById("quantityAvailable") as HTMLInputElement;

function addProductTo() {
    if (curIndex != null) {
        updateProduct(curIndex,
            {
                foodID: curIndex,
                foodName: foodName.value,
                quantityAvailable: Number(quantity.value),
                pricePerQuantity: Number(pricePerQuantity.value),
            })
        curIndex = null;
        foodid.value = "";
        foodName.value = "";
        pricePerQuantity.value = "";
        quantity.value = "";
    }

    else {
        postProduct({
            foodID: 0,
            foodName: foodName.value,
            quantityAvailable: Number(quantity.value),
            pricePerQuantity: Number(pricePerQuantity.value),
        })
    }

}

function addGrocery() {
    form1.style.display = "block";
}


function Edit(id: number, name: string, quan: number, price: number) {
    form1.style.display = "block";
    console.log("id in edit is " + id);
    curIndex = id;
    foodid.value = id + "";
    foodName.value = name;
    pricePerQuantity.value = quan + "";
    quantity.value = price + "";
}

function Delete(id: number) {
    deleteProduct(id);
}

async function deleteProduct(id: number): Promise<void> {
    const response = await fetch(`http://localhost:5105/product/${id}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
    // bookDetails();
    stock();
}


async function updateProduct(id: number, book: FoodDetails): Promise<void> {
    const response = await fetch(`http://localhost:5105/product/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(book)
    });
    if (!response.ok) {
        throw new Error('Failed to update contact');
    }
    stock();
}

async function purchase() {
    displayNone();
    purchases.style.display = "block";
    var tbody = document.getElementById("product-cont") as HTMLDivElement;
    console.log(tbody);

    tbody.innerHTML = "";
    var bookList = await fetchProducts();
    bookList.forEach((element) => {
        if (element.quantityAvailable > 0) {
            var row = document.createElement("div");
            row.className = "product-card";
            row.innerHTML = `
        
        <div class="product-info">
     
            <h2> Name : ${element.foodName}  </h2>
           
            <h2> Available : ${element.quantityAvailable}  </h2>

   
            <h2> Rs: ${element.pricePerQuantity}</h2>
        </div>
        <button onclick="AddCart('${element.foodID}','${element.foodName}','${element.quantityAvailable}','${element.pricePerQuantity}')"  >Add To Cart</button>
        `
            console.log("here  is the quantity " + element.quantityAvailable)
            tbody.appendChild(row);
        }
    }
    );
}
var temporaryCart: Array<{ cartID: number, foodsId: number, foodsName: string, purchaseCount: number, priceOfOrder: number }> = new Array<{ cartID: number, foodsId: number, foodsName: string, purchaseCount: number, priceOfOrder: number }>();

function AddCart(foodID: number, foodName: string, c: number, priceperquantity: number) {
    var count: number = Number(prompt("Enter Quantity"));
    if (count <= c) {
        temporaryCart.push({ cartID: temporaryCart.length + 1, foodsId: foodID, foodsName: foodName, purchaseCount: count, priceOfOrder: count * priceperquantity });
    } else {
        alert(`Entered Qunatity Not Available \n Available Count:${c}`)
    }

    console.log(temporaryCart);
}

async function cart() {
    displayNone();
    carts.style.display = "block";
    var tbody = document.getElementById("tbody3") as HTMLTableSectionElement;
    tbody.innerHTML = "";
    // var bookList= await fetchProducts();
    temporaryCart.forEach((element) => {
        var row = document.createElement("tr");
        row.innerHTML = `
  
        <td>${element.cartID}</td>
        <td>${element.foodsId}</td>
        <td>${element.foodsName}</td>
        <td>${element.priceOfOrder}</td>
        <td>${element.purchaseCount}</td>
        <td>
        <button onclick="deleteID(${element.cartID})">Delete</button>
        </td>
        `
        tbody.appendChild(row);
    }
    );

}
function deleteID(id: number) {
    var a = temporaryCart.findIndex(value => value.cartID == id);
    temporaryCart.splice(a, 1);
    cart();
}

//   async function buy() {
//     var total = 0;
//     temporaryCart.forEach((val) => {
//       total += val.priceOfOrder;
//     })
//             // bookingID: undefined,
//         // customerID: currentUser.userID,
//         // totalPrice: total,
//         // dateOfBooking: new Date().toISOString(),
//         // bookingStatus: "Booked"
//         // orderID: number;
//         // CustomerID: number;
//         // TotalPrice: number;
//         // DateOfOrder: Date;
//         // OrderStatus: string;
//     if (total < currentCustomer.walletBalance) {
//       var book: OrderDetails = await postBooking({
//         orderID: 0,
//         CustomerID :currentCustomer.customerID,
//         TotalPrice : total,
//         DateOfOrder : new Date(),
//         OrderStatus :"Ordered"
//       })
//             // orderID: undefined,
//             // productID: data.productID,
//             // bookingID: book.bookingID,
//             // productName: data.productName,
//             // purchaseCount: data.purchaseCount,
//             // priceOfOrder: data.priceOfOrder
//       temporaryCart.forEach((data) => {
//         postOrder(
//         //   {
//         //     itemID : 0,
//         //     OrderID :

//         //   })
//         updateProductCount(data.foodsId, data.purchaseCount);
//       })
//       currentCustomer = await updateAmount(currentCustomer.customerID, currentCustomer.walletBalance - total);
//       temporaryCart.splice(0, temporaryCart.length);
//       cart();
//       alert("Order placed successfully !");
//     } else {
//       alert("Insufficient Balance");
//     }
//   }

//   async function cancelBooking(id: number) {
//     var bookingList: BookingDetails[] = await fetchBooking();
//     var booking = bookingList.find(value => value.bookingID == id);
//     if (booking!=undefined && booking.customerID == currentUser.userID && booking.bookingStatus == "Booked") 
//     {
//       booking.bookingStatus = "Cancelled";
//       currentUser = await updateAmount(currentUser.userID, currentUser.amount + booking.totalPrice);
//       await updateBooking(id, booking);
//       bookingHistory();
//       stock();
//       alert("Booking Cancelled");
//     }
//   }



//order history

var tbody = document.getElementById("booking-orderID") as HTMLTableElement;

async function bookingHistory() {
    displayNone();
    historys.style.display = "block";
    alert("Viewing booking history");
    tbody.innerHTML = "";
    var bookingList = await fetchBooking();
    console.log(bookingList);
    bookingList.forEach((booking) => {
        if (booking.customerID == currentCustomer.customerID) {
            var row = document.createElement("tr");
            row.innerHTML = `
                <td>${booking.orderID}</td>
                <td>${booking.customerID}</td>
                <td>${booking.totalPrice}</td>
                <td>${new Date(booking.dateOfOrder).toLocaleDateString('en-GB')}</td>
                <td>${booking.orderStatus}</td>
            `;
            tbody.appendChild(row);
        }
    });
}

async function fetchBooking(): Promise<OrderDetails[]> {
    const apiUrl = 'http://localhost:5105/order';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch data');
    }
    return await response.json();
}

async function fetchOrder(): Promise<ItemDetails[]> {
    const apiUrl = 'http://localhost:5105/item';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    return await response.json();
}


async function updateProductCount(id: number, count: number): Promise<void> {
    const response = await fetch(`http://localhost:5105/product/${id}/${count}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    // return await response.json();
}


async function postBooking(product: OrderDetails): Promise<OrderDetails> {
    const response = await fetch('http://localhost:5105/order', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(product)
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    return await response.json();

}

async function postOrder(product: ItemDetails): Promise<void> {
    const response = await fetch('http://localhost:5105/item', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(product)
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
}


async function postProduct(product: FoodDetails): Promise<void> {
    const response = await fetch('http://localhost:5105/product', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(product)
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    stock();
}

async function fetchProducts(): Promise<FoodDetails[]> {
    const apiUrl = 'http://localhost:5105/product';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    alert("product Fetched");
    console.log(response);
    return await response.json();

}



async function fetchUsers(): Promise<CustomerDetails[]> {
    const apiUrl = 'http://localhost:5105/customers';
    const response = await fetch(apiUrl);
    if (!response.ok) {
        throw new Error('Failed to fetch Data');
    }
    return await response.json();
}

async function addUser(user: CustomerDetails): Promise<void> {
    const response = await fetch('http://localhost:5105/customers', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    // renderContacts();
}

async function updateAmount(id: number, amount: number): Promise<CustomerDetails> {
    const response = await fetch(`http://localhost:5105/customers/${id}/${amount}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error('failed to fetch Data');
    }
    return await response.json();
}
