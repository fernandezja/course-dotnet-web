console.log('NET');

var form = document.getElementById("formContacto");

form.addEventListener('submit', function(e){
    
    e.preventDefault();
    
    enviar();
});


function enviar(){
    //form.getElementById('nombre').value;
    const nombre = form.querySelector('input[name="nombre"]').value;

    var esValido = true;

    if(nombre === null 
        || nombre===''){
        esValido = false;
    }      

    if(esValido){
        console.log('Enviado...');
    }else{
        alert("Complete los datos...");
    }
    
}


console.log(form);