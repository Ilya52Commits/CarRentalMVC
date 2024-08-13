const signIn = document.querySelector("#sign-in") as HTMLAnchorElement;
const signUp = document.querySelector("#sign-up") as HTMLAnchorElement;
const switchSignIn = document.querySelector("#switch-sign-in") as HTMLAnchorElement;
const switchSignUp = document.querySelector("#switch-sign-up") as HTMLAnchorElement;

let user = {
    id: "",
    Name: "",
    LastName: "",
    Patronymic: "",
    Passwort: "",
    Pasport: "",
    Phone: "",
    DateOfBirth: ""
}

switchSignIn.addEventListener("click", () => {
    signIn.style.display = "block";
    signUp.style.display = "none";
})

switchSignUp.addEventListener("click", () => {
    signIn.style.display = "none";
    signUp.style.display = "block";
})