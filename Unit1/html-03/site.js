
//https://developer.mozilla.org/en-US/docs/Web/API/EventTarget/addEventListener
var form1 = document.getElementById("form1");

form1.addEventListener("submit", function (e) {
   

    var nombre = document.getElementById("nombre1");
    var enviar = true;
    if (nombre.value ==''){
        enviar = false;
        alert("Debe enviar nombre...");
    }

    if(enviar==false){
            //https://developer.mozilla.org/en-US/docs/Web/API/Event/preventDefault
        e.preventDefault();
    }else {
        alert("Enviando...");

    }
    
});


