if (!window["signIn"]) {
    const signIn = document.querySelector("#sign-in") as HTMLAnchorElement;
    window["signIn"] = signIn;
}
if (!window["signUp"]) {
    const signUp = document.querySelector("#sign-up") as HTMLAnchorElement;
    window["signUp"] = signUp;
}
if (!window["switchSignIn"]) {
    const switchSignIn = document.querySelector("#switch-sign-in") as HTMLAnchorElement;
    window["switchSignIn"] = switchSignIn;
}
if (!window["switchSignUp"]) {
    const switchSignUp = document.querySelector("#switch-sign-up") as HTMLAnchorElement;
    window["switchSignUp"] = switchSignUp;
}


(window["switchSignIn"] as HTMLAnchorElement).addEventListener("click", () => {
    (window["signIn"] as HTMLAnchorElement).style.display = "block";
    (window["signUp"] as HTMLAnchorElement).style.display = "none";
});

(window["switchSignUp"] as HTMLAnchorElement).addEventListener("click", () => {
    (window["signIn"] as HTMLAnchorElement).style.display = "none";
    (window["signUp"] as HTMLAnchorElement).style.display = "block";
});
