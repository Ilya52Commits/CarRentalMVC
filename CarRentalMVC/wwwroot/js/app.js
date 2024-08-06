if (!window["signIn"]) {
    var signIn = document.querySelector("#sign-in");
    window["signIn"] = signIn;
}
if (!window["signUp"]) {
    var signUp = document.querySelector("#sign-up");
    window["signUp"] = signUp;
}
if (!window["switchSignIn"]) {
    var switchSignIn = document.querySelector("#switch-sign-in");
    window["switchSignIn"] = switchSignIn;
}
if (!window["switchSignUp"]) {
    var switchSignUp = document.querySelector("#switch-sign-up");
    window["switchSignUp"] = switchSignUp;
}
window["switchSignIn"].addEventListener("click", function () {
    window["signIn"].style.display = "block";
    window["signUp"].style.display = "none";
});
window["switchSignUp"].addEventListener("click", function () {
    window["signIn"].style.display = "none";
    window["signUp"].style.display = "block";
});
//# sourceMappingURL=app.js.map