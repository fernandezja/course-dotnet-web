//https://developer.mozilla.org/en-US/docs/Web/API/EventTarget/addEventListener
var form1 = document.getElementById("myForm");


form1.addEventListener("submit", function(event) {
    event.preventDefault();
    validarFormulario();
});

function validarFormulario() {

    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;

    if (name === "") {
        alert("Name is required.");
        return;
    }
    if (email === "") {
        alert("Email is required.");
        return;
    }

    alert("Gracias por enviar el formulario!");
}