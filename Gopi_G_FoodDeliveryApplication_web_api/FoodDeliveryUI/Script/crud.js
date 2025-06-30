// let customerIdAutoIncrement: number =1001;
// let foodIdAutoIncrement:number = 2001;
// let orderIdAutoIncrement :number =3001;
// let itemIdAutoIncrement :number=4001;
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g = Object.create((typeof Iterator === "function" ? Iterator : Object).prototype);
    return g.next = verb(0), g["throw"] = verb(1), g["return"] = verb(2), typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (g && (g = 0, op[0] && (_ = 0)), _) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
var GenderDetails;
(function (GenderDetails) {
    GenderDetails["Select"] = "Select";
    GenderDetails["Male"] = "Male";
    GenderDetails["Female"] = "Female";
    GenderDetails["TransGender"] = "Transgender";
})(GenderDetails || (GenderDetails = {}));
var OrderStatusDetails;
(function (OrderStatusDetails) {
    OrderStatusDetails["Ordered"] = "Ordered";
    OrderStatusDetails["Cancelled"] = "Cancelled";
    OrderStatusDetails["Initiated"] = "Initiated";
})(OrderStatusDetails || (OrderStatusDetails = {}));
var currentCustomer;
var sign1 = document.getElementById("signin");
var sign2 = document.getElementById("signup");
var sign3 = document.getElementById("si");
var sign4 = document.getElementById("su");
var homes = document.getElementById("home");
var menus = document.getElementById("menu");
var stocks = document.getElementById("stock");
var purchases = document.getElementById("purchase");
var historys = document.getElementById("history");
var topp = document.getElementById("top");
var showw = document.getElementById("show");
var carts = document.getElementById("cart");
var form1 = document.getElementById("form1");
var customerPage = document.getElementById("customerDetailsPage");
var itemDetailsPage = document.getElementById("itemDetailsPage");
var foodid = document.getElementById("foodid");
var foodName = document.getElementById("foodName");
var pricePerQuantity = document.getElementById("priceperQuantity");
var quantity = document.getElementById("quantityAvailable");
// var temporaryCart: Array<{ cartID: number, productID: number, productName: string, purchaseCount: number, priceOfOrder: number }> = new Array<{ cartID: number, productID: number, productName: string, purchaseCount: number, priceOfOrder: number }>();
function signIn() {
    displayNone();
    sign1.style.display = "block";
    sign2.style.display = "none";
    sign3.style.background = "orange";
    sign4.style.background = "none";
}
function signUp() {
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
function signUpSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var name, fathername, mobile, genderElements, gender, dob, locations, email, password, isavail, UserArrayList;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    e.preventDefault();
                    name = document.getElementById("name");
                    fathername = document.getElementById("fatherName");
                    mobile = document.getElementById("mobile");
                    genderElements = Array.from(document.getElementsByName("gender"));
                    gender = genderElements.find(function (element) { return element.checked; });
                    dob = document.getElementById("dob");
                    locations = document.getElementById("location");
                    email = document.getElementById("email");
                    password = document.getElementById("password");
                    console.log(name.value);
                    console.log(fathername.value);
                    console.log(mobile.value);
                    console.log(gender === null || gender === void 0 ? void 0 : gender.value);
                    console.log(dob.value);
                    console.log(locations.value);
                    console.log(email.value);
                    console.log(password.value);
                    isavail = false;
                    return [4 /*yield*/, fetchUsers()];
                case 1:
                    UserArrayList = _a.sent();
                    console.log(UserArrayList);
                    UserArrayList.forEach(function (val) {
                        if (val.mailID.toLowerCase() == email.value.toLowerCase()) {
                            alert("you already have an ID. Please Sign In");
                            isavail = true;
                        }
                    });
                    console.log("posting");
                    if (!isavail) {
                        addUser({ customerID: undefined, name: name.value, fatherName: fathername.value, gender: gender.value, dob: dob.value, location: locations.value, mailID: email.value, password: password.value, mobile: mobile.value, walletBalance: 0 });
                        alert("Customer Created");
                        signIn();
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function signInSubmit(e) {
    e.preventDefault();
    var isavail = true;
    var email = document.getElementById("email1");
    var password = document.getElementById("password2");
    console.log(email);
    console.log(password);
    fetchUsers().then(function (UserArrayList) {
        UserArrayList.forEach(function (val) {
            if (val.mailID.toLowerCase() == email.value.toLowerCase() && val.password == password.value) {
                var a = document.getElementById("box");
                a.style.display = "none";
                var b = document.getElementById("menu");
                b.style.display = "block";
                console.log(b);
                isavail = false;
                currentCustomer = val;
                home();
                email.value = "";
                password.value = "";
            }
            if (isavail) {
                alert("Invalid Email or Password");
            }
        });
    });
}
function home() {
    displayNone();
    homes.style.display = "block";
    var a = document.getElementById("welcome");
    a.innerHTML = "Welcome " + currentCustomer.name;
}
function showUser() {
    alert("showing User");
    displayNone();
    customerPage.style.display = "block";
    var tbody = document.getElementById("customerBody");
    tbody.innerHTML = "";
    var row = document.createElement("tr");
    row.innerHTML = "\n\n      <td>".concat(currentCustomer.customerID, "</td>\n      <td>").concat(currentCustomer.walletBalance, "</td>\n      <td>").concat(currentCustomer.name, "</td>\n      <td>").concat(currentCustomer.fatherName, "</td>\n      <td>").concat(currentCustomer.gender, "</td>\n      <td>").concat(currentCustomer.mobile, "</td>\n      <td>").concat(currentCustomer.dob.split("T")[0].split("-").reverse().join("/"), "</td>\n      <td>").concat(currentCustomer.location, "</td>\n      <td>").concat(currentCustomer.mailID, "</td>\n      ");
    tbody.appendChild(row);
}
function recharge() {
    displayNone();
    topp.style.display = "block";
    document.getElementById("curBalance").innerHTML = "Available Balance :".concat(currentCustomer.walletBalance);
}
function show() {
    displayNone();
    showw.style.display = "block";
    var a = document.getElementById("balance");
    a.innerHTML = "Your Balance is " + currentCustomer.walletBalance;
}
function deposit() {
    return __awaiter(this, void 0, void 0, function () {
        var a;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    a = document.getElementById("amount");
                    return [4 /*yield*/, updateAmount(currentCustomer.customerID, Number(a.value))];
                case 1:
                    currentCustomer = _a.sent();
                    alert("Amount Deposited Successfully");
                    a.value = "";
                    document.getElementById("curBalance").innerHTML = "Available Balance :".concat(currentCustomer.walletBalance);
                    return [2 /*return*/];
            }
        });
    });
}
function Logout() {
    displayNone();
    document.getElementById("menu").style.display = "none";
    document.getElementById("box").style.display = "block";
}
var curIndex;
function stock() {
    return __awaiter(this, void 0, void 0, function () {
        var tbody, bookList;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    stocks.style.display = "block";
                    tbody = document.getElementById("tbody1");
                    tbody.innerHTML = "";
                    return [4 /*yield*/, fetchProducts()];
                case 1:
                    bookList = _a.sent();
                    bookList.forEach(function (element) {
                        if (element.quantityAvailable > 0) {
                            console.log(element.foodID);
                            var row = document.createElement("tr");
                            row.innerHTML = "\n  \n        <td>".concat(element.foodID, "</td>\n        <td>").concat(element.foodName, "</td>\n        <td>").concat(element.pricePerQuantity, "</td>\n        <td>").concat(element.quantityAvailable, "</td>\n         <td>\n         \n        <button onclick=\"Edit(").concat(element.foodID, ",'").concat(element.foodName, "',").concat(element.quantityAvailable, ",").concat(element.pricePerQuantity, ")\">Edit</button>\n        <button onclick=\"deleteProduct(").concat(element.foodID, ")\">Delete</button>\n        </td>\n        ");
                            tbody.appendChild(row);
                        }
                    });
                    return [2 /*return*/];
            }
        });
    });
}
//   var foodid = document.getElementById("foodid") as HTMLInputElement;
// var foodName = document.getElementById("foodName") as HTMLInputElement;
// var pricePerQuantity = document.getElementById("priceperQuantity") as HTMLInputElement;
// var quantity = document.getElementById("quantityAvailable") as HTMLInputElement;
function addProductTo() {
    if (curIndex != null) {
        updateProduct(curIndex, {
            foodID: curIndex,
            foodName: foodName.value,
            quantityAvailable: Number(quantity.value),
            pricePerQuantity: Number(pricePerQuantity.value),
        });
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
        });
    }
}
function addGrocery() {
    form1.style.display = "block";
}
function Edit(id, name, quan, price) {
    form1.style.display = "block";
    console.log("id in edit is " + id);
    curIndex = id;
    foodid.value = id + "";
    foodName.value = name;
    pricePerQuantity.value = quan + "";
    quantity.value = price + "";
}
function Delete(id) {
    deleteProduct(id);
}
function deleteProduct(id) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5105/product/".concat(id), {
                        method: 'DELETE'
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to delete contact');
                    }
                    // bookDetails();
                    stock();
                    return [2 /*return*/];
            }
        });
    });
}
function updateProduct(id, book) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5105/product/".concat(id), {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(book)
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to update contact');
                    }
                    stock();
                    return [2 /*return*/];
            }
        });
    });
}
function purchase() {
    return __awaiter(this, void 0, void 0, function () {
        var tbody, bookList;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    purchases.style.display = "block";
                    tbody = document.getElementById("product-cont");
                    console.log(tbody);
                    tbody.innerHTML = "";
                    return [4 /*yield*/, fetchProducts()];
                case 1:
                    bookList = _a.sent();
                    bookList.forEach(function (element) {
                        if (element.quantityAvailable > 0) {
                            var row = document.createElement("div");
                            row.className = "product-card";
                            row.innerHTML = "\n        \n        <div class=\"product-info\">\n     \n            <h2> Name : ".concat(element.foodName, "  </h2>\n           \n            <h2> Available : ").concat(element.quantityAvailable, "  </h2>\n\n   \n            <h2> Rs: ").concat(element.pricePerQuantity, "</h2>\n        </div>\n        <button onclick=\"AddCart('").concat(element.foodID, "','").concat(element.foodName, "','").concat(element.quantityAvailable, "','").concat(element.pricePerQuantity, "')\"  >Add To Cart</button>\n        ");
                            console.log("here  is the quantity " + element.quantityAvailable);
                            tbody.appendChild(row);
                        }
                    });
                    return [2 /*return*/];
            }
        });
    });
}
var temporaryCart = new Array();
function AddCart(foodID, foodName, c, priceperquantity) {
    var count = Number(prompt("Enter Quantity"));
    if (count <= c) {
        temporaryCart.push({ cartID: temporaryCart.length + 1, foodsId: foodID, foodsName: foodName, purchaseCount: count, priceOfOrder: count * priceperquantity });
    }
    else {
        alert("Entered Qunatity Not Available \n Available Count:".concat(c));
    }
    console.log(temporaryCart);
}
function cart() {
    return __awaiter(this, void 0, void 0, function () {
        var tbody;
        return __generator(this, function (_a) {
            displayNone();
            carts.style.display = "block";
            tbody = document.getElementById("tbody3");
            tbody.innerHTML = "";
            // var bookList= await fetchProducts();
            temporaryCart.forEach(function (element) {
                var row = document.createElement("tr");
                row.innerHTML = "\n  \n        <td>".concat(element.cartID, "</td>\n        <td>").concat(element.foodsId, "</td>\n        <td>").concat(element.foodsName, "</td>\n        <td>").concat(element.priceOfOrder, "</td>\n        <td>").concat(element.purchaseCount, "</td>\n        <td>\n        <button onclick=\"deleteID(").concat(element.cartID, ")\">Delete</button>\n        </td>\n        ");
                tbody.appendChild(row);
            });
            return [2 /*return*/];
        });
    });
}
function deleteID(id) {
    var a = temporaryCart.findIndex(function (value) { return value.cartID == id; });
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
var tbody = document.getElementById("booking-orderID");
function bookingHistory() {
    return __awaiter(this, void 0, void 0, function () {
        var bookingList;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    historys.style.display = "block";
                    alert("Viewing booking history");
                    tbody.innerHTML = "";
                    return [4 /*yield*/, fetchBooking()];
                case 1:
                    bookingList = _a.sent();
                    console.log(bookingList);
                    bookingList.forEach(function (booking) {
                        if (booking.customerID == currentCustomer.customerID) {
                            var row = document.createElement("tr");
                            row.innerHTML = "\n                <td>".concat(booking.orderID, "</td>\n                <td>").concat(booking.customerID, "</td>\n                <td>").concat(booking.totalPrice, "</td>\n                <td>").concat(new Date(booking.dateOfOrder).toLocaleDateString('en-GB'), "</td>\n                <td>").concat(booking.orderStatus, "</td>\n            ");
                            tbody.appendChild(row);
                        }
                    });
                    return [2 /*return*/];
            }
        });
    });
}
function fetchBooking() {
    return __awaiter(this, void 0, void 0, function () {
        var apiUrl, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiUrl = 'http://localhost:5105/order';
                    return [4 /*yield*/, fetch(apiUrl)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to fetch data');
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function fetchOrder() {
    return __awaiter(this, void 0, void 0, function () {
        var apiUrl, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiUrl = 'http://localhost:5105/item';
                    return [4 /*yield*/, fetch(apiUrl)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function updateProductCount(id, count) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5105/product/".concat(id, "/").concat(count), {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function postBooking(product) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch('http://localhost:5105/order', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(product)
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function postOrder(product) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch('http://localhost:5105/item', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(product)
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function postProduct(product) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch('http://localhost:5105/product', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(product)
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    stock();
                    return [2 /*return*/];
            }
        });
    });
}
function fetchProducts() {
    return __awaiter(this, void 0, void 0, function () {
        var apiUrl, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiUrl = 'http://localhost:5105/product';
                    return [4 /*yield*/, fetch(apiUrl)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    alert("product Fetched");
                    console.log(response);
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function fetchUsers() {
    return __awaiter(this, void 0, void 0, function () {
        var apiUrl, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiUrl = 'http://localhost:5105/customers';
                    return [4 /*yield*/, fetch(apiUrl)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to fetch Data');
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function addUser(user) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch('http://localhost:5105/customers', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        body: JSON.stringify(user)
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function updateAmount(id, amount) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5105/customers/".concat(id, "/").concat(amount), {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('failed to fetch Data');
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
