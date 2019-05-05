/*
    Attribute:
    Value:

    Element.Attribute

 */
window.onload=function(){
    var oText=document.getElementById("text1");
    // console.log(oText.id);
    // oText.id="txt";
    // oText.type="password";

    var oBtn=document.getElementById("btn1");
    var oSelect=document.getElementById("select1");

    // oBtn.onclick=function(){
    //     // console.log(oText.value+" "+oSelect.value);
    //     // oText.value=oSelect.value;
    //
    // };

    var oP=document.getElementById("p1");
    oBtn.onclick=function(){
        oP.innerHTML=oText.value;
        // alert(oText.innerText);
    }

};
