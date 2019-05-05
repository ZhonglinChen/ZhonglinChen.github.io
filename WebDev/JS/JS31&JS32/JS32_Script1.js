window.onload = function () {
    var oBtn1 = document.getElementById("btn1");
    var oBtn2 = document.getElementById("btn2");
    var oBtn3 = document.getElementById("btn3");
    var oBtn4 = document.getElementById("btn4");
    var oP = document.getElementById("p1");

    var num = 14;
    oBtn1.onclick = function () {
        num -= 2;
        oP.style.fontSize = num + "px";

    };
    oBtn2.onclick = function () {
        num += 2;
        oP.style.fontSize = num + "px";

    };

    oBtn3.onclick = function () {
        oP.style.color="red";

    };

    oBtn4.onclick = function () {
        oP.style.color="yellow";

    };



};