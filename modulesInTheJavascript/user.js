export default class User {
    constructor(userName, userID) {
        this.userName = userName;
        this.userID = userID;
    }
    greeting() {
        console.log(`Hello  user ${this.userName}`);
    }
}