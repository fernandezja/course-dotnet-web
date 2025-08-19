 const demoElement = document.getElementById('demo');

       demoElement.addEventListener('click', function() {
           demoElement.innerHTML = 'Curso .NET ';
       });

        const formContacto = document.getElementById('formContacto');

        formContacto.addEventListener('submit', function(event) {
            
            event.preventDefault();

            const nombre = document.getElementById('nombre').value;
            const email = document.getElementById('email').value;

            //Validar nombre
            if (!nombre) {
                alert('Por favor, ingresa tu nombre.');
                return;
            }

            // Validar email
            if (!email) {
                alert('Por favor, ingresa tu email.');
                return;
            }

            // Si todo es válido, enviar el formulario
            formContacto.submit();
        });