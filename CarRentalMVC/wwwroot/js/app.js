var signIn = document.querySelector("#sign-in");
var signUp = document.querySelector("#sign-up");
var switchSignIn = document.querySelector("#switch-sign-in");
var switchSignUp = document.querySelector("#switch-sign-up");
var user = {
    id: "",
    Name: "",
    LastName: "",
    Patronymic: "",
    Passwort: "",
    Pasport: "",
    Phone: "",
    DateOfBirth: ""
};
switchSignIn.addEventListener("click", function () {
    signIn.style.display = "block";
    signUp.style.display = "none";
});
switchSignUp.addEventListener("click", function () {
    signIn.style.display = "none";
    signUp.style.display = "block";
});
//# sourceMappingURL=app.js.map