function button() {
    let vaha = document.getElementById("vaha").value;
    let vyska = document.getElementById("vyska").value / 100;
    document.getElementById("result").innerHTML = (vaha / (vyska * vyska)).toFixed(2);
}

function zmena() {
    let znamka = document.getElementById("znamka").value;
    console.log(znamka);
    

    if (znamka > 2) {
        document.getElementById("img").src = "https://th.bing.com/th/id/OIP.6RcnW-Qb_jvGWrV3xkd6OAHaHa?w=201&h=201&c=7&r=0&o=7&pid=1.7&rm=3";
    } else {
        document.getElementById("img").src = "https://th.bing.com/th/id/OIP.5TEejgnFmxE59jWvqe-PYwHaHa?w=216&h=216&c=7&r=0&o=7&pid=1.7&rm=3";
    }
}

// function change(value) {
//     if (value == 'sad') {
//         document.getElementById("img").src = "https://th.bing.com/th/id/OIP.6RcnW-Qb_jvGWrV3xkd6OAHaHa?w=201&h=201&c=7&r=0&o=7&pid=1.7&rm=3";
//     } else {
//         document.getElementById("img").src = "https://th.bing.com/th/id/OIP.5TEejgnFmxE59jWvqe-PYwHaHa?w=216&h=216&c=7&r=0&o=7&pid=1.7&rm=3";
//     }
// }

// function happy() {
//     let img = document.getElementById("img");
//     img.src = "https://th.bing.com/th/id/OIP.5TEejgnFmxE59jWvqe-PYwHaHa?w=216&h=216&c=7&r=0&o=7&pid=1.7&rm=3";
// }

// function sad() {
//     let img = document.getElementById("img");
//     img.src = "https://th.bing.com/th/id/OIP.6RcnW-Qb_jvGWrV3xkd6OAHaHa?w=201&h=201&c=7&r=0&o=7&pid=1.7&rm=3";
// }