const time = document.getElementById("time"),
      greeting = document.getElementById("greeting"),
      focus = document.getElementById("focus"),
      name = document.getElementById("name");
const showAMPM=true;

function showTime(){
    let today=new Date(),
        hour=today.getHours(),
        min=today.getMinutes(),
        sec=today.getSeconds();

    console.log("${today}");
    const amPm = hour >=12? 'PM':'AM';

    //12 Hr Format
    hour= hour%12||12;


    //output Time
    time.innerHTML=hour+"<span>:</span>"+addZero(min)+"<span>:</span>"+addZero(sec)+" "+(showAMPM?amPm:"");

    setTimeout(showTime,1000);
}

// Add Zero
function addZero(n){
    return (parseInt(n,10)<10?'0':'')+n;
}


function setBgGreet() {
    let today=new Date(),
        hour=today.getHours();

    if(hour>=6&&hour<12){
        //morning
        document.body.style.backgroundImage="url('./img/morning.jpg')";
                document.body.style.backgroundSize="cover";

        greeting.textContent="Good Morning";
    }
    else if(hour>=12&&hour<18){
        //afternoon
        document.body.style.backgroundImage="url('./img/afternoon.jpg'";
                document.body.style.backgroundSize="cover";

        greeting.textContent="Good Afternoon";
    } else {
        //afternoon
        document.body.style.backgroundImage="url('./img/night.jpg'";
        document.body.style.backgroundSize="cover";
        greeting.textContent="Good Evening";
        document.body.style.color="white";

    }
    
}
function setName( e) {
    if(e.type==='keypress'){
        if(e.which===13||e.keyCode===13){
            localStorage.setItem('name',e.target.innerText);
            e.blur();
        }
    }else{
        localStorage.setItem('name',e.target.innerText);
    }
}
function setFocus( e) {
    if(e.type==='keypress'){
        if(e.which===13||e.keyCode===13){
            localStorage.setItem('focus',e.target.innerText);
            e.blur();
        }
    }else{
        localStorage.setItem('focus',e.target.innerText);
    }
}
function getName(){
    if(localStorage.getItem('name')===null){
        name.textContent='[Enter Name]';
    }
    else{
        name.textContent=localStorage.getItem('name');
    }
}
function getFocus(){
    if(localStorage.getItem('focus')===null){
        focus.textContent='[Enter Focus]';
    }
    else{
        focus.textContent=localStorage.getItem('focus');
    }
}

name.addEventListener("keypress",setName);
name.addEventListener("blur",setName);
focus.addEventListener("keypress",setFocus);
focus.addEventListener("blur",setFocus);

showTime();
setBgGreet();
getName();
getFocus();