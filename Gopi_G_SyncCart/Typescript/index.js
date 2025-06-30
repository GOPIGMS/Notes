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
var customerIDAutoIncrement = 3001;
var ProductIDAutoIncrement = 2001;
var OrderIDAutoIncrement = 1001;
var OrderStatusDetails;
(function (OrderStatusDetails) {
    OrderStatusDetails["Initiated"] = "Initiated";
    OrderStatusDetails["Ordered"] = "Ordered";
    OrderStatusDetails["Cancelled"] = "Cancelled";
})(OrderStatusDetails || (OrderStatusDetails = {}));
var CustomerDetails = /** @class */ (function () {
    function CustomerDetails(name, city, mobileNumber, walletBalance, email, password) {
        this.WalletBalance = 0;
        this.CustomerID = "CID" + customerIDAutoIncrement++;
        this.CustomerName = name;
        this.City = city;
        this.MobileNumber = mobileNumber;
        this.WalletBalance = walletBalance;
        this.EmailID = email;
        this.Password = password;
    }
    return CustomerDetails;
}());
var ProductDetails = /** @class */ (function () {
    function ProductDetails(productName, stock, price, shippingDuration) {
        this.ProductID = "PID" + ProductIDAutoIncrement++;
        this.ProductName = productName;
        this.Stock = stock;
        this.Price = price;
        this.ShippingDuration = shippingDuration;
    }
    return ProductDetails;
}());
var OrderDetails = /** @class */ (function () {
    function OrderDetails(customerID, productID, totalPrice, purchaseDate, quantity, orderStatus) {
        this.OrderID = "OID" + OrderIDAutoIncrement++;
        this.CustomerID = customerID;
        this.ProductID = productID;
        this.TotalPrice = totalPrice;
        this.PurchaseDate = purchaseDate;
        this.Quantity = quantity;
        this.OrderStatus = orderStatus;
    }
    return OrderDetails;
}());
var CustomerArrayList = new Array();
CustomerArrayList.push(new CustomerDetails("Ravi", "Chennai", "98885858588", 50000, "ravi@mail.com", "1234"));
CustomerArrayList.push(new CustomerDetails("Baskaran", "Chennai", "9888475757", 60000, "baskaran@mail.com", "1234"));
console.log(CustomerArrayList);
var ProductArrayList = new Array();
ProductArrayList.push(new ProductDetails("Mobile (Samsung)", 10, 10000, 3));
ProductArrayList.push(new ProductDetails("Tablet (Lenovo)", 5, 15000, 2));
ProductArrayList.push(new ProductDetails("Camara (Sony)", 3, 20000, 4));
ProductArrayList.push(new ProductDetails("iPhone", 5, 50000, 6));
ProductArrayList.push(new ProductDetails("Laptop (Lenovo I3)", 3, 40000, 3));
ProductArrayList.push(new ProductDetails("HeadPhone (Boat)", 5, 1000, 2));
ProductArrayList.push(new ProductDetails("Speakers (Boat)", 4, 500, 2));
console.log(ProductArrayList);
var OrderArrayList = new Array();
OrderArrayList.push(new OrderDetails("CID3001", "PID2001", 20000, new Date(), 2, OrderStatusDetails.Ordered));
OrderArrayList.push(new OrderDetails("CID3002", "PID2003", 40000, new Date(), 2, OrderStatusDetails.Ordered));
console.log(OrderArrayList);
var currentCustomer;
var homePage = document.getElementById("homePage");
var purchasePage = document.getElementById("purchasePage");
var topPage = document.getElementById("topUpPage");
var orderPage = document.getElementById("orderPage");
var showorderPage = document.getElementById("showorderPage");
var signInForm = document.getElementById("signIn");
var signUpForm = document.getElementById("signUp");
var signInButton = document.getElementById("signInButton");
var signUpButton = document.getElementById("signUpButton");
var displayWalletBalance = document.getElementById("balance-page");
function signIn() {
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}
function signUp() {
    signInForm.style.display = "none";
    signUpForm.style.display = "block";
    signInButton.style.background = "none";
    signUpButton.style.background = "orange";
}
function signUpSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var name, email, password, phone, city, walletBalance, isavail, customer, i;
        return __generator(this, function (_a) {
            e.preventDefault();
            name = document.getElementById("name");
            email = document.getElementById("email");
            password = document.getElementById("password");
            phone = document.getElementById("phone");
            city = document.getElementById("city");
            walletBalance = document.getElementById("walletbalance");
            isavail = true;
            CustomerArrayList.forEach(function (val) {
                if (val.EmailID.toLowerCase() == email.value.toLowerCase()) {
                    alert("you already have an ID. Please Sign In");
                    isavail = false;
                }
            });
            if (isavail) {
                customer = new CustomerDetails(name.value, city.value, phone.value, parseFloat(walletBalance.value), email.value, password.value);
                console.log(customer);
                CustomerArrayList.push(customer);
                alert("Your User ID is " + customer.CustomerID);
                isavail = false;
            }
            else {
                i = document.getElementById("signup");
                i.style.border = "2px solid red";
            }
            return [2 /*return*/];
        });
    });
}
function signInSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var isavail, email, password;
        return __generator(this, function (_a) {
            e.preventDefault();
            isavail = true;
            email = document.getElementById("email1");
            password = document.getElementById("password2");
            CustomerArrayList.forEach(function (val) {
                if (val.EmailID.toLowerCase() == email.value.toLowerCase() && val.Password == password.value) {
                    var a = document.getElementById("box");
                    a.style.display = "none";
                    var b = document.getElementById("menu");
                    b.style.display = "block";
                    isavail = false;
                    currentCustomer = val;
                    console.log("You are logged in ");
                    home();
                    email.value = "";
                    password.value = "";
                    alert("You are logged in ");
                }
            });
            if (isavail) {
                alert("Invalid Email or Password");
            }
            return [2 /*return*/];
        });
    });
}
function home() {
    return __awaiter(this, void 0, void 0, function () {
        var welcome;
        return __generator(this, function (_a) {
            displayNone();
            homePage.style.display = "block";
            welcome = document.getElementById("welcome");
            welcome.innerHTML = "Welcome " + currentCustomer.CustomerName;
            return [2 /*return*/];
        });
    });
}
function displayNone() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            homePage.style.display = "none";
            purchasePage.style.display = "none";
            topPage.style.display = "none";
            displayWalletBalance.style.display = "none";
            orderPage.style.display = "none";
            showorderPage.style.display = "none";
            document.getElementById("addEditMedicineForm").style.display = "none";
            return [2 /*return*/];
        });
    });
}
function displayBalance() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            displayWalletBalance.style.display = "block";
            document.getElementById("displayBalance").innerHTML = "Available Balance :".concat(currentCustomer.WalletBalance);
            return [2 /*return*/];
        });
    });
}
function topup() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            topPage.style.display = "block";
            document.getElementById("currentBalance").innerHTML = "Available Balance :".concat(currentCustomer.WalletBalance);
            return [2 /*return*/];
        });
    });
}
function deposit() {
    return __awaiter(this, void 0, void 0, function () {
        var amount;
        return __generator(this, function (_a) {
            amount = document.getElementById("amount");
            currentCustomer.WalletBalance += Number(amount.value);
            alert("Amount Dposited Successfully");
            amount.value = "";
            document.getElementById("currentBalance").innerHTML = "Available Balance :".concat(currentCustomer.WalletBalance);
            return [2 /*return*/];
        });
    });
}
function logout() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            document.getElementById("menu").style.display = "none";
            document.getElementById("box").style.display = "block";
            return [2 /*return*/];
        });
    });
}
function order() {
    return __awaiter(this, void 0, void 0, function () {
        var orderTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            orderPage.style.display = "block";
            orderTable = document.getElementById("orderTable");
            len = orderTable.getElementsByTagName("tr").length;
            if (orderTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    orderTable.removeChild(orderTable.children[i]);
                }
            }
            OrderArrayList.forEach(function (order) {
                if (order.CustomerID == currentCustomer.CustomerID && order.OrderStatus == OrderStatusDetails.Ordered) {
                    var row = document.createElement("tr");
                    row.innerHTML = "<td>".concat(order.OrderID, "</td> <td>").concat(order.CustomerID, "</td> <td>").concat(order.ProductID, "</td> <td>").concat(order.TotalPrice, "</td> <td>").concat(order.PurchaseDate.toLocaleDateString(), "</td> \n            <td>").concat(order.Quantity, "</td> <td>").concat(order.OrderStatus, "</td>\n            <td><button id=\"cancelbtn\" onclick=\"cancelOrder('").concat(order.OrderID, "')\">Cancel</button></td>");
                    orderTable.appendChild(row);
                }
            });
            return [2 /*return*/];
        });
    });
}
function showorder() {
    return __awaiter(this, void 0, void 0, function () {
        var orderTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            showorderPage.style.display = "block";
            orderTable = document.getElementById("ordersTable");
            len = orderTable.getElementsByTagName("tr").length;
            if (orderTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    orderTable.removeChild(orderTable.children[i]);
                }
            }
            OrderArrayList.forEach(function (order) {
                if (order.CustomerID == currentCustomer.CustomerID) {
                    var row = document.createElement("tr");
                    row.innerHTML = "<td>".concat(order.OrderID, "</td> <td>").concat(order.CustomerID, "</td> <td>").concat(order.ProductID, "</td> <td>").concat(order.TotalPrice, "</td> <td>").concat(order.PurchaseDate.toLocaleDateString(), "</td> \n            <td>").concat(order.Quantity, "</td> <td>").concat(order.OrderStatus, "</td>");
                    orderTable.appendChild(row);
                }
            });
            return [2 /*return*/];
        });
    });
}
function cancelOrder(orderID) {
    return __awaiter(this, void 0, void 0, function () {
        var orderData, productID, product;
        return __generator(this, function (_a) {
            orderData = OrderArrayList.find(function (o) { return o.OrderID == orderID && o.CustomerID == currentCustomer.CustomerID && o.OrderStatus == OrderStatusDetails.Ordered; });
            if (orderData) {
                orderData.OrderStatus = OrderStatusDetails.Cancelled;
                currentCustomer.WalletBalance += orderData.TotalPrice;
                productID = orderData.ProductID;
                product = ProductArrayList.find(function (prod) { return prod.ProductID == productID; });
                if (product) {
                    product.Stock += orderData.Quantity;
                }
                alert("Order : ".concat(orderID, " Cancelled successfully "));
                order();
            }
            else {
                alert("Order not found");
            }
            return [2 /*return*/];
        });
    });
}
function purchase() {
    return __awaiter(this, void 0, void 0, function () {
        var purchaseTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            purchasePage.style.display = "block";
            purchaseTable = document.getElementById("purchaseTable");
            len = purchaseTable.getElementsByTagName("tr").length;
            if (purchaseTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    purchaseTable.removeChild(purchaseTable.children[i]);
                }
            }
            ProductArrayList.forEach(function (product) {
                var row = document.createElement("tr");
                row.innerHTML = "<td>".concat(product.ProductID, " </td>  <td> ").concat(product.ProductName, " </td> <td> ").concat(product.Stock, " </td> <td>").concat(product.Price, " </td> \n        <td>").concat(product.ShippingDuration, " </td>\n        <td>\n            <button onclick=\"buy('").concat(product.ProductID, "')\">Buy</button>\n        </td>");
                purchaseTable.appendChild(row);
            });
            return [2 /*return*/];
        });
    });
}
function buy(productID) {
    return __awaiter(this, void 0, void 0, function () {
        var getProduct, countValue, count, totalBuyingAmount, newOrder, result;
        return __generator(this, function (_a) {
            getProduct = ProductArrayList.find(function (prod) { return prod.ProductID === productID; });
            if (getProduct) {
                countValue = prompt("Please enter your name:", "0");
                count = Number(countValue);
                if (getProduct.Stock >= count && count > 0) {
                    totalBuyingAmount = getProduct.Price * count + 50;
                    if (currentCustomer.WalletBalance >= totalBuyingAmount) {
                        getProduct.Stock -= Number(count);
                        currentCustomer.WalletBalance -= totalBuyingAmount;
                        newOrder = new OrderDetails(currentCustomer.CustomerID, getProduct.ProductID, totalBuyingAmount, new Date(), count, OrderStatusDetails.Ordered);
                        OrderArrayList.push(newOrder);
                        alert("Your Order Placed Successfully.Order ID : ".concat(newOrder.OrderID));
                        result = new Date();
                        result.setDate(newOrder.PurchaseDate.getDate() + getProduct.ShippingDuration);
                        alert("Your Order will be deliveried on  ".concat(result));
                        order();
                    }
                    else {
                        alert("Insufficient balance to make this purchase.");
                    }
                }
                else {
                    alert("Invalid Stock count.");
                }
            }
            else {
                alert("Product not found.");
            }
            return [2 /*return*/];
        });
    });
}
