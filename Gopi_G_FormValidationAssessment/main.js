//getting all the elements
const form = document.getElementById("myForm");
const firstname = document.getElementById("firstname");
const lastname = document.getElementById("lastname");
const email = document.getElementById("email");
const phone = document.getElementById("phone");
const password = document.getElementById("password");
const confirmPassword = document.getElementById("confirmpassword");
// const gender = document.getElementsByName("gender-details");
const presentAddressTextArea = document.getElementById("present-address");
const presentAddressPinCode = document.getElementById("pincode");
const presentAddressState = document.getElementById("state");
const permanentAddressTextArea = document.getElementById("permanent-address");
const permanentAddressPincode = document.getElementById("permanent-pincode");
const permanentAddressState = document.getElementById("permanent-state");
const birthdate = document.getElementById("birthdate");
const birthtime = document.getElementById("birthtime");
const checkboxGroup = document.getElementsByName("language");
const sameAddress = document.getElementById("same");
const genderGroup = document.getElementsByName("gender");
const interestGroup = document.getElementById("interest");
const imageElement = document.getElementById("image");
const resumeElement = document.getElementById("resume");
let isSameCheck =false;

console.log(resumeElement);
console.log(imageElement);


//getting all the elements value
// form.style.backgroundColor = "grey";
// firstname.style.backgroundColor = "blue";
let firstnameValue = firstname.value ?? " ";
let lastnameValue = lastname.value ?? " ";
let emailValue = email.value ?? " ";
let phoneValue = phone.value ?? " ";
let passwordValue = password.value ?? " ";
let confirmPasswordValue = confirmPassword.value ?? " ";
// let genderValue = gender.value??" ";
let presentAddressTextAreaValue = presentAddressTextArea.value ?? " ";
let presentAddressPinCodeValue = presentAddressPinCode.value ?? " ";
let presentAddressStateValue = presentAddressPinCode.value ?? " ";
let permanentAddressTextAreaValue = permanentAddressTextArea.value ?? " ";
let PermanentAddressPincodeValue = permanentAddressPincode.value ?? " ";
let PermanentAddressStateValue = permanentAddressState.value ?? " ";
let birthdateValue = birthdate.value ?? " ";
let birthtimeValue = birthtime.value ?? " ";
let languageSelectedValue = [];
let genderValue = " ";
let interestSelectedValue = [];
let resumeElementValue = " ";
let imageElementValue = " ";
let imageName;
let resumeName;


// lastname.style.backgroundColor = "blue";

//adding the event listners
form.addEventListener('submit', (e) => {
    e.preventDefault();
    if(globalValidator()){
        console.log("form submitted")
    }
    else{
        console.log("Invalid form")
    }
   
});

firstname.addEventListener('blur', (e) => {

    validatefirstName(firstname);
});
lastname.addEventListener('blur', (e) => {

    validatelastName(lastname);
});
email.addEventListener('blur', (e) => {

    validateEmail(email);
});
phone.addEventListener('blur', (e) => {

    validatePhone(phone);
});
password.addEventListener('blur', (e) => {
    validatePassword(password);
});
confirmPassword.addEventListener('blur', (e) => {
    validateConfirmPassword(confirmPassword);
});

presentAddressTextArea.addEventListener('blur', (e) => {
    validatePresentAddressText(presentAddressTextArea);
});
presentAddressPinCode.addEventListener('blur', (e) => {
    validatePresentAddressPinCode(presentAddressPinCode);
});
presentAddressState.addEventListener('blur', (e) => {
    validatePresentAddressState(presentAddressState);
});

permanentAddressTextArea.addEventListener('blur', (e) => {
    validatePermanentAddressText(permanentAddressTextArea);
});
permanentAddressPincode.addEventListener('blur', (e) => {
    validatePermanenetAddressPinCode(permanentAddressPincode);
});
permanentAddressState.addEventListener('blur', (e) => {
    validatePermanentAddressState(permanentAddressState);
});
birthdate.addEventListener('blur', (e) => {
    validateBirthDate(birthdate);
});
birthtime.addEventListener('blur', (e) => {
    validateBirthTime(birthtime);
});
function selectMultiple(){
    checkboxGroup.forEach(element => {
        element.addEventListener('blur', (e) => {
            validateCheckboxLanguage(element)
        });
    });
}
selectMultiple();

sameAddress.addEventListener('click', (e) => {
    makePermanentAddressSame();
})
interestGroup.addEventListener('click', (e) => {
    interestChecking();

})
resumeElement.addEventListener('blur', (e) => {
    let result = validateResume();
    const f = e.target.files[0];
    if (result) {
        const f = e.target.files[0];
        resumeName = f.name;
    }
});
imageElement.addEventListener('blur', (e) => {
    let result = validateImage();
    if (result) {
        const f = e.target.files[0];
        imageName = f.name
    }

});

function globalValidator() {
   let  isFirstnameVaid = validatefirstName(firstname);
   let  isLastnameValid = validatelastName(lastname);
   let  isEmailValid = validateEmail(email);
   let  isPhoneValid = validatePhone(phone);
   let  isPasswordValid = validatePassword(password);
   let  isConfirmPasswordValid = validateConfirmPassword(confirmPassword);
   let  isPresentAddressTextArea = validatePresentAddressText(presentAddressTextArea);
   let  isPresentAddressPincode = validatePresentAddressPinCode(presentAddressPinCode);
   let  isPresentAddressState =validatePresentAddressState(presentAddressState);
   let  isPermanentAddressTextArea = validatePermanentAddressText(permanentAddressTextArea);
   let  isPermanentAddressState = validatePermanentAddressState(permanentAddressState);
   let  isPermanentAddressPincode = validatePermanenetAddressPinCode(permanentAddressPincode);
   let  isGenderValue =genderChecking();
   let isBirthdate =validateBirthDate(birthdate);
   let isBirthtime =validateBirthTime(birthtime);
   let islanguage = validateCheckboxLanguage(checkboxGroup[0]);
   let isinterestChoice= interestChecking();
   let isvalidResume = validateResume();
   let isvalidImage = validateImage();

    if (isFirstnameVaid && isLastnameValid && isEmailValid && isPhoneValid && isPasswordValid && isConfirmPasswordValid && isPresentAddressTextArea && isPresentAddressPincode && isPresentAddressState
        && isPermanentAddressTextArea && isPermanentAddressState && isPermanentAddressPincode && isGenderValue 
        && isBirthdate && isBirthtime && islanguage  && isinterestChoice && isvalidImage && isvalidResume ) {
        console.log("Valid Username")
        let firstnameValue = firstname.value ?? " ";
        console.log(`firstnameValue : ${firstnameValue}`)
        console.log(`lastnameValue : ${lastnameValue}`)
        console.log(`emailValue : ${emailValue}`)
        console.log(`phoneValue : ${phoneValue}`)
        console.log(`passwordValue : ${passwordValue}`)
        console.log(`confirmPasswordValue : ${confirmPasswordValue}`)
        console.log(`presentAddressTextAreaValue : ${presentAddressTextAreaValue}`)
        console.log(`presentAddressPinCodeValue : ${presentAddressPinCodeValue}`)
        console.log(`presentAddressStateValue : ${presentAddressStateValue}`)
        console.log(`permanentAddressTextAreaValue : ${permanentAddressTextAreaValue}`)
        console.log(`PermanentAddressPincodeValue : ${PermanentAddressPincodeValue}`)
        console.log(`PermanentAddressStateValue : ${PermanentAddressStateValue}`)
        console.log(`birthdateValue : ${birthdateValue}`)
        console.log(`birthtimeValue : ${birthtimeValue}`)
        console.log(`languageSelectedValue : ${languageSelectedValue}`)
        console.log(`genderValue : ${genderValue}`)
        console.log(`interestSelectedValue : ${interestSelectedValue}`)
        console.log(`imageName : ${imageName}`)
        console.log(`resumeName : ${resumeName}`)
        loadDatas();
        showTable();
        return true
    }
    return false
}

//name validator
function validatefirstName(user) {
    let uservalue = user.value;
    let regexName = /^[a-zA-Z ]+$/
    if (regexName.test(uservalue)) {
        setSuccess(user)
        firstnameValue = uservalue;
        return true;
    }
    else {
        setError(user, "*Field must contain letter")
        return false
    }

}
function validatelastName(user) {
    let uservalue = user.value;
    let regexName = /^[a-zA-Z ]+$/
    if (regexName.test(uservalue)) {
        setSuccess(user);
        lastnameValue = uservalue;
        return true
    }
    else {
        setError(user, "*LastName is Required")
        return false
    }

}
function validateEmail(email) {
    let emailvalue = email.value;
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (emailRegex.test(emailvalue)) {
        emailValue = emailvalue
        setSuccess(email)
        return true
    }
    else {
        setError(email, "*Enter Valid EmailID")
        return false
    }

}
function validatePhone(phone) {
    let phonevalue = phone.value;
    const phoneregex = /^[+ 0-9].{2,12}$/;
    if (phoneregex.test(phonevalue)) {
        phoneValue = phonevalue;
        setSuccess(phone)
        return true
    }
    else {
        setError(phone, "*Enter Valid Phone number")
        return false
    }

}
function validatePassword(password) {
    let passwordvalue = password.value;
    const passwordregex = /[^\s]{8,20}$/;
    if (passwordregex.test(passwordvalue)) {
        passwordValue = passwordvalue;
        setSuccess(password)
        return true
    }
    else {
        setError(password, "*Enter Valid Password")
        return false
    }

}
function validateConfirmPassword(confirmpassword) {
    let confirmpasswordvalue = confirmpassword.value;

    if (confirmpasswordvalue.trim() != "" && passwordValue == confirmpasswordvalue) {
        confirmPasswordValue = confirmpasswordvalue;
        setSuccess(confirmpassword)
        return true
    }
    else {
        setError(confirmpassword, "*Enter Valid Confirm password")
        return false
    }

}
function validateGender(gender) {
    if (gender.trim() != "") {

        setSuccess(gender)
        return true
    }
    else {
        setError(gender, "*Enter Valid Confirm password")
        return false
    }

}

function validatePresentAddressText(presentaddressTextArea) {
    let valuesProvided = presentaddressTextArea.value;
    if (valuesProvided.trim() != "") {
        presentAddressTextAreaValue=valuesProvided
        setSuccessSingleParent(presentAddressTextArea)
        return true;
    }
    else {
        setErrorSingleParent(presentAddressTextArea, "*Please Enter your Present Address")
        return false;
    }
}
function validatePermanentAddressText(permanentaddressTextArea) {
    let valuesProvided = permanentaddressTextArea.value;
    if (valuesProvided.trim() != "") {
       permanentAddressTextAreaValue= valuesProvided
       console.log(permanentAddressTextAreaValue);
        setSuccessSingleParent(permanentAddressTextArea)
        return true;
    }
    else {
        setErrorSingleParent(permanentAddressTextArea, "*Please Enter your Permanent Address")
        return false;
    }
}
function validatePresentAddressPinCode(element) {
    let regexName = /^[0-9]{6}$/;
    let valuesProvided = element.value;
    if (valuesProvided.trim() != "" && regexName.test(valuesProvided)) {
        presentAddressPinCodeValue=valuesProvided
        setSuccess(element);
        return true;
    }
    else {
        setError(element, "*Please Enter your Pincode ")
        return false;
    }
}
function validatePermanenetAddressPinCode(element) {
    let regexName = /^[0-9]{6}$/;
    let valuesProvided = element.value;
    if (valuesProvided.trim() != "" && regexName.test(valuesProvided)) {
        PermanentAddressPincodeValue=valuesProvided
        setSuccess(element);
        return true;
    }
    else {
        setError(element, "*Please Enter your Pincode ")
        return false;
    }
}

function validatePresentAddressState(element) {

    let valuesProvided = element.options;
    let selectedIndex = valuesProvided.selectedIndex;
    let selectedValue = element[selectedIndex].value;
    if (selectedValue == "no-state") {
        setError(element, "*Please select your present state");
        return false;
    }
    else {
        presentAddressStateValue= selectedValue;
        setSuccess(element);
        return true;
    }
}
function validatePermanentAddressState(element) {
   
    let valuesProvided = element.options;
    let selectedIndex = valuesProvided.selectedIndex;
    let selectedValue = element[selectedIndex].value;
    if (selectedValue == "no-state") {
        setError(element, "*Please select your present state");
        return false;
    }
    else {
        PermanentAddressStateValue =selectedValue
        setSuccess(element);
        return true;
    }
}


function validateBirthDate(element) {
    const currentElementValue = element.value;
    const currentDate = new Date();

    if (currentElementValue.trim() === "") {
        setError(element, "*Date of Birth is required");
        return false;
    }

    const inputDate = new Date(currentElementValue);
    inputDate.setHours(0, 0, 0, 0);
    currentDate.setHours(0, 0, 0, 0);

    if (inputDate > currentDate) {
        setError(element, "*Valid Date is required");
        return false;
    } else {
        birthdateValue=currentElementValue
        setSuccess(element);
        return true;
    }
}

function validateBirthTime(element) {
    const currentElementValue = element.value;
    if (currentElementValue.trim() == "") {
        setError(element, "*Please Select Birth Time")
        return false;
    }
    else {
        birthtimeValue= currentElementValue
        setSuccess(element);
        return true;
    }
}


function validateCheckboxLanguage(element) {
    isValueAvailable = false;
    languageSelectedValue = []
    checkboxGroup.forEach(elements => {
        if (elements.checked) {
            isValueAvailable = true;
            languageSelectedValue.push(elements.value);
        }

    });
    console.log(languageSelectedValue);
    if (isValueAvailable) {
        setSuccessMessage(element)
        return true;
    }
    else {
        setFailureMessage(element, "*choose One")
        return false;
    }
}
let i=0;
function makePermanentAddressSame() {
  
    if (i==0){
        isSameCheck=true;
        permanentAddressTextArea.value = presentAddressTextArea.value;
        permanentAddressPincode.value = presentAddressPinCode.value;
        permanentAddressState.value = presentAddressState.value;
        validatePermanentAddressState(permanentAddressState);
        validatePermanentAddressText(permanentAddressTextArea);
        validatePermanenetAddressPinCode(permanentAddressPincode);
        permanentAddressState.disabled = true;
        permanentAddressPincode.disabled = true;
        permanentAddressTextArea.disabled =true;
        i+=1
    }
    else{
        i-=1;
        permanentAddressState.disabled = false;
        permanentAddressPincode.disabled = false;
        permanentAddressTextArea.disabled =false;
        isSameCheck= false;
    }

}

function genderChecking() {
    let isGenderSelected = false;
    genderGroup.forEach((element) => {
        console.log(element.value);

        if (element.checked) {
            isGenderSelected = true;
            genderValue = element.value;

        }
    })
    if (isGenderSelected) {
        setSuccessMessage(genderGroup[0]);
        return true;
    }
    else {
        setFailureMessage(genderGroup[0], "*Gender is required");
        return false;
    }
}

function interestChecking() {
    interestSelectedValue = Array.from(interestGroup.options).filter(option => option.selected).map(option => option.value);
    console.log(interestSelectedValue);
    if (interestSelectedValue[0] == "default-value") {
        interestSelectedValue.shift()
    }
    if (interestSelectedValue.length > 0) {
        setSuccess(interestGroup);
        return true;
    }
    else {
        setError(interestGroup, "*Please select atleast one field of interest");
        return false;
    }
}

function validateImage() {
    let elementValue = imageElement.value;
    if (elementValue.trim() == "") {
        setError(imageElement, "*Please Upload a photo")
        return false;
    }
    setSuccess(imageElement);
    console.log(elementValue);
    return true;
}

function validateResume() {
    let elementValue = resumeElement.value;
    if (elementValue.trim() == "") {
        setError(resumeElement, "*Please Upload your resume")
        return false;
    }
    setSuccess(resumeElement);
    console.log(elementValue);
    return true;

}

//set error
function setError(element, message) {
    const inputGroup = element.parentNode.parentNode;
    const errorElement = inputGroup.querySelector("#errormessage");
    errorElement.textContent = message;
    element.classList.add('error');
    element.classList.remove('success');

}
function setErrorSingleParent(element, message) {
    const inputGroup = element.parentNode;
    const errorElement = inputGroup.querySelector("#errormessage");
    errorElement.textContent = message;
    element.classList.add('error');
    element.classList.remove('success');

}
function setSuccess(element) {
    const inputGroup = element.parentNode.parentNode;
    const errorElement = inputGroup.querySelector("#errormessage");
    errorElement.textContent = '';
    element.classList.remove('error');
    element.classList.add('success');

}
function setSuccessSingleParent(element) {
    const inputGroup = element.parentNode.parentNode;
    const errorElement = inputGroup.querySelector("#errormessage");
    errorElement.textContent = '';
    element.classList.remove('error');
    element.classList.add('success');
}


function setSuccessMessage(element) {

    const inputGroup = element.parentNode.parentNode;
    const errorElement = inputGroup.querySelector("#errormessage");
    errorElement.textContent = '';

}

function setFailureMessage(element, message) {
    const inputGroup = element.parentNode.parentNode;
    const errorElement = inputGroup.querySelector("#errormessage");
    errorElement.textContent = message;
}


//showing the datas in the table

// let firstnameValue = firstname.value ?? " ";
// let lastnameValue = lastname.value ?? " ";
// let emailValue = email.value ?? " ";
// let phoneValue = phone.value ?? " ";
// let passwordValue = password.value ?? " ";
// let confirmPasswordValue = confirmPassword.value ?? " ";
// // let genderValue = gender.value??" ";
// let presentAddressTextAreaValue = presentAddressTextArea.value ?? " ";
// let presentAddressPinCodeValue = presentAddressPinCode.value ?? " ";
// let presentAddressStateValue = presentAddressPinCode.value ?? " ";
// let permanentAddressTextAreaValue = permanentAddressTextArea.value ?? " ";
// let PermanentAddressPincodeValue = permanentAddressPincode.value ?? " ";
// let PermanentAddressStateValue = permanentAddressState.value ?? " ";
// let birthdateValue = birthdate.value ?? " ";
// let birthtimeValue = birthtime.value ?? " ";
// let languageSelectedValue = [];
// let genderValue = " ";
// let interestSelectedValue = [];
// let resumeElementValue = " ";
// let imageElementValue = " ";
// let imageName;
// let resumeName;

function loadDatas(){
    
document.getElementById("print-name").textContent= `${firstnameValue} ${lastnameValue}`;
document.getElementById("print-email").textContent= `${emailValue} `;   
document.getElementById("print-phone").textContent= `${phoneValue}`;
let hashedPassword = "";
for(let j=0; j<passwordValue.length;j++){

    hashedPassword+='*'
}
document.getElementById("print-password").textContent= `${hashedPassword} `;
document.getElementById("print-gender").textContent= `${genderValue} `;
if(isSameCheck){
document.getElementById("print-address").textContent= `${presentAddressTextAreaValue}, ${presentAddressStateValue}, ${presentAddressPinCodeValue}`;

}
else{
document.getElementById("print-address").textContent= ` Present address :${presentAddressTextAreaValue}, ${presentAddressStateValue}, ${presentAddressPinCodeValue} \n Permanent Address : ${permanentAddressTextAreaValue}, ${PermanentAddressStateValue} ,${PermanentAddressPincodeValue}`;

}
document.getElementById("print-dob").textContent= `${birthdateValue} `;
document.getElementById("print-time").textContent= `${birthtimeValue} `;
document.getElementById("print-language").textContent= `${languageSelectedValue.join(',')} `;
document.getElementById("print-interest").textContent= `${interestSelectedValue.join(',')} `;
let imagepath =`./assets/${imageName}`
document.getElementById("my-image").src=imagepath;
console.log(imagepath);
let resumePath =`./assets/${resumeName}`
document.getElementById("resumes").href=resumePath;
console.log(resumePath);
}

let formComponent =document.getElementById("main-form-wrapper");

let tableComponent = document.getElementById("table-component");


function showTable(){
    formComponent.style.display="none"
    tableComponent.style.display="block";
}

function showForm(){
    tableComponent.style.display="none";
    formComponent.style.display="block";
}
