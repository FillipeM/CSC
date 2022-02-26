$(document).ready(function () {
    // Inicialzia o Editor
    //$('.textarea-editor').wysihtml5();
    $('.textarea-editor').summernote(
        {
            height: 300,                 // define a altura do editor
            minHeight: null,           // define a altura minima
            maxHeight: null,          // define a altura máxima
            focus: true                  // define o foco na área editável apos a inicialização
        });
});