function toggle() {
    if ($(".main-menu").css("width") != "250px") {
        $('.main-menu').css("width", "250px");
        $('.main-menu').css("overflow", "visible");
    }
    else {
        $('.main-menu').css("width", "60px");
        $('.main-menu').css("overflow", "hidden");
    }
}

function toggleCadastro() {
    if ($("#subMenuCadastro").css("display") == "block") {
        $('#subMenuCadastro').css("display", "none");
    }
    else {
        $('#subMenuCadastro').css("display", "block");
    }
}

function toggleSeguranca() {
    if ($("#submenuSeguranca").css("display") == "block") {
        $('#submenuSeguranca').css("display", "none");
    }
    else {
        $('#submenuSeguranca').css("display", "block");
    }
}

function toggleAtendimento() {
    if ($("#submenuAtendimento").css("display") == "block") {
        $('#submenuAtendimento').css("display", "none");
    }
    else {
        $('#submenuAtendimento').css("display", "block");
    }
}