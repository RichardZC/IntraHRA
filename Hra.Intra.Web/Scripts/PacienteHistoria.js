var btnBuscar = document.getElementById("btnBuscar");

btnBuscar.onclick = function () {
    var historia = document.getElementById("txtHIstoriaC").value;
    var dni = document.getElementById("txtDNI").value;
    BuscarHistoria(historia);
    BuscarPaciente(dni);  
}

function BuscarPaciente(dni) {

    $.get("Historia/Paciente?dni=" + dni, function (data) {
        if (data == "") {
            $("#dni").hide();
            $('#lblReniec').text("Registro No Existe en RENIEC");
        } else {
            $.data(document.body, 'personaReniec', data);
            crearReniec(data);
            $("#dni").show();
        }
    });
}function BuscarHistoria(nro) {
    $('#lblReniec').text("");
    $('#lblHistoria').text("");
    $('#txtHIstoriaC').val("");

    $.get("Historia/ObtenerHistoria?historia=" + nro, function (data) {
        if (data == "") {
            $("#tabla,#dni").hide();
            $('#lblHistoria').text("Historia No Existe");
        } else {
            //$('#lblHistoria').text(data.NroHistoriaClinica + " " + data.Nombre + " " + data.NroDocumento + " " + data.Nacimiento);
            $.data(document.body, 'pacienteId', data.IdPaciente)
            crearListado(data);
            $("#tabla").show();
            
            if (data.NroDocumento != null) {
                BuscarPaciente(data.NroDocumento);
                //$("#tabla").show();
            
            }
        }

    });
}

function crearListado(data) {
    var contenido = "";
    contenido += "<table class='table' >";
    contenido += "<tbody>";
    contenido += "<tr>";
    contenido += "  <td >Identificación</td>";
    contenido += "  <td >" + data.IdPaciente + "</td>";
    contenido += "</tr>";
    contenido += "  <td >DNI</td>";
    contenido += "  <td >" + data.NroDocumento + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Paciente</td>";
    contenido += "  <td >" + data.Nombre + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Nro Historia</td>";
    contenido += "  <td >" + data.NroHistoriaClinica + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Fecha Nacimiento</td>";
    contenido += "  <td >" + data.Nacimiento + "</td>";
    contenido += "</tr>";
    contenido += "</tbody>";
    contenido += "</table>";
    document.getElementById("tabla").innerHTML = contenido;
}

function crearReniec(data) {
    var contenido = "";
    contenido += "<table class='table' >";
    contenido += "<tbody>";
    contenido += "<tr>";
    contenido += "  <td >DNI</td>";
    contenido += "  <td >" + data.Documento + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Nombres</td>";
    contenido += "  <td >" + data.Nombre + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Apellidos Paterno</td>";
    contenido += "  <td >" + data.Paterno + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Apellidos Materno</td>";
    contenido += "  <td >" + data.Materno + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Fecha Nacimiento</td>";
    contenido += "  <td >" + data.FechaNacimientoCadena + "</td>";
    contenido += "</tr>";
    contenido += "<tr>";
    contenido += "  <td >Sexo</td>";
    contenido += "  <td >" + data.Sexo + "</td>";
    contenido += "</tr>";
    contenido += "</tbody>";
    contenido += "</table>";
    document.getElementById("dni").innerHTML = contenido;
}

//function Actualizar(data) {
//    var contenido = "";
//    contenido += "<table class='table' >";
//    contenido += "<tbody>";
//    contenido += "<tr>";
//    contenido += "  <td >DNI</td>";
//    contenido += "  <td >" + data.Documento + "</td>";
//    contenido += "</tr>";
//    contenido += "<tr>";
//    contenido += "  <td >Nombres</td>";
//    contenido += "  <td >" + data.Nombre + "</td>";
//    contenido += "</tr>";
//    contenido += "<tr>";
//    contenido += "  <td >Apellidos Paterno</td>";
//    contenido += "  <td >" + data.Paterno + "</td>";
//    contenido += "</tr>";
//    contenido += "<tr>";
//    contenido += "  <td >Apellidos Materno</td>";
//    contenido += "  <td >" + data.Materno + "</td>";
//    contenido += "</tr>";
//    contenido += "<tr>";
//    contenido += "  <td >Fecha Nacimiento</td>";
//    contenido += "  <td >" + data.FechaNacimientoCadena + "</td>";
//    contenido += "</tr>";
//    contenido += "<tr>";
//    contenido += "  <td >Sexo</td>";
//    contenido += "  <td >" + data.Sexo + "</td>";
//    contenido += "</tr>";
//    contenido += "</tbody>";
//    contenido += "</table>";
//    document.getElementById("dni").innerHTML = contenido;
//}
