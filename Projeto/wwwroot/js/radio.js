$(document).ready(function () {

    $('input:radio[name="Pf_Pj"]').change(function () {
        if ($(this).val() == 'true') {
            $("#div_cpf").show();
            $("#div_cnpj").hide();
        } else {
            $("#div_cnpj").show();
            $("#div_cpf").hide();
        }
    });
});