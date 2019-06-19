$("#iniciosesionform").validate({
    rules:{
        nombre_usuario: {required: true},
        contrasenia: {required: true}
    },
    messages:{
        nombre_usuario: "El nombre de Usuario es obligatorio.",
        contrasenia: "La contraseña es obligatoria."
    }
})