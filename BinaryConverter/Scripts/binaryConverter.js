var bc = document.getElementById("bc");

bc.addEventListener("animationend", setMinSize);

function setMinSize() {
    if (bc.offsetTop === 65) {
        bc.style.minWidth = "320px";
        bc.children[0].style.visibility = "visible";
    }
}
