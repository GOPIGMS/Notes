import * as Player from './music.js';
import User from './user.js';

const userObject = new User("Gopi",1000000000000);
userObject.greeting();

console.log(Player.flute());
console.log(Player.guitar());
console.log(Player.piano());

const hello ={
    constructor(){
        title = "hi";
        number = 23;
    }

};
const a = new hello();
console.log(a)