
let display = document.getElementById("displayer");
console.log(display);
function toAppendValue(input){
    display.value+=input;
    console.log(display)
}

function calculate(){
    display.value= eval(display.value);
}

function clears(){
    display.value="";
}