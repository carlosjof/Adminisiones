    $.ajax({
        url: "/Registrousuario/Sectores",
        type: "GET",
        dataType: "json",
        data: { provincia: document.getElementById("provincia").value },
        success: function (resp) {
            console.log(resp);
        }
    });

$("#provincia").change(function () { console.log("algo"); });