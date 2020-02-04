$(document).ready(function () {

    $('#Telefone').mask('(00)0000-0000');

    $('input:radio[name="Pf_Pj"]').change(function () {
        if ($(this).val() == 'true') {
            $('#Documento').mask('000.000.000-00');
            $('#Documento').prop('placeholder', '000.000.000-00');
        } else {
            $('#Documento').mask('00.000.000/0000-00');
            $('#Documento').prop('placeholder', '00.000.000/0000-00');

        }
    });
});