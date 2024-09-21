let list = document.querySelectorAll(".navigation li");

function activeLink() {
    list.forEach((item) => {
        item.classList.remove("hovered");
    });
    this.classList.add("hovered");
}

function removeActiveLink() {
    this.classList.remove("hovered");
}

list.forEach((item) => {
    item.addEventListener("mouseover", activeLink);
    item.addEventListener("mouseleave", removeActiveLink);
});