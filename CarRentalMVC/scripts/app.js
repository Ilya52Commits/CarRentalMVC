if (!window["signIn"]) {
    var signIn_1 = document.querySelector("#sign-in");
    window["signIn"] = signIn_1;
}
if (!window["signUp"]) {
    var signUp_1 = document.querySelector("#sign-up");
    window["signUp"] = signUp_1;
}
if (!window["switchSignIn"]) {
    var switchSignIn_1 = document.querySelector("#switch-sign-in");
    window["switchSignIn"] = switchSignIn_1;
}
if (!window["switchSignUp"]) {
    var switchSignUp_1 = document.querySelector("#switch-sign-up");
    window["switchSignUp"] = switchSignUp_1;
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