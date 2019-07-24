var Contra = document.getElementById("Contra").value;
var confirmacionContra = document.getElementById("confirmacionContra").value;

function ConfrimacionContrasena() {
    if ($("#Contra").val() == $("#confirmacionContra")) {
        alert("Correcto");
    } else {
        alert("Las contraseñas deben de ser iguales");
    }
}

