//console.log("Hola mundo");
//debugger;


const formContacto = document.getElementById("form-contacto");

formContacto.addEventListener("submit", function (event) {
    
    //
    event.preventDefault();

    const name = formContacto.querySelector('input[name="nombre"]').value;

    var esValido = true;

    if(name === null 
        || name === '') {

        esValido = false;
            //acciones
    }

    alert("Demo: " + name);
});