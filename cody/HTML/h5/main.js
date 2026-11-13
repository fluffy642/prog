// let firstName = prompt("Kak zvat?", "Dolbaeb");
// let res = confirm("Ti krasav4ik?");

// if (res) {
//     alert(firstName + ", nu ti libo real krasav4ik libo pizdabol");
// } else {
//     alert("Bistro metnulsya za gazyavoj podsos");    
//     do {
//         let res = confirm("Uzhe prines?");
//         if (res) {
//             alert("Krasav4ik nefor ebaniy");
//             break;
//         } else {
//             alert("Jebat ti hujesos");
//         }
//     } while (true);
// }

function setText() {
    document.getElementById("text").innerText = document.getElementById("vstup").value;
}

function setColor() {
    document.getElementById("colored").style.backgroundColor = document.getElementById("vstupColor").value;
}

function calcNumber() {
    if (document.getElementById("vstupCislo").value % 2 == 0) {
        document.getElementById("number").innerText = "Cislo " + document.getElementById("vstupCislo").value + " je sude";
    } else {
        document.getElementById("number").innerText = "Cislo " + document.getElementById("vstupCislo").value + " je liche";
    }
    
}

// alert("Jsem JS!");
// document.write("Hello, " + prompt("Zadej jmeno"));

// const heslo = "marek";
// while (true) {
//     if (prompt("Odhadni heslo: ") == heslo) {
//         alert("Prihlaseni Povoleno");
//         break;
//     }
// }