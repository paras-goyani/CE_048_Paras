var par = document.getElementsByClassName("body-change-index");

for (var i = 0; i < par.length; i++) {
    par[i].innerHTML = par[i].textContent;
    par[i].innerHTML = par[i].textContent.substring(0, 150);
}

var body = document.getElementById("body-change");
body.innerHTML = body.textContent;