window.onload=function(){
    var oBtn=document.getElementById('btn1');
    var oText=document.getElementById('text1');
    var oImg=document.getElementById('img1');

    oBtn.onclick=function(){
        oImg.src=oText.value;
    }
};