$(document).ready(function () {

    $('.form').validate({

        rules: {
            Nome: {
                required: true,
                minlength: 3
            },
            Cpf: {
                required: true,
                minlength: 11
            },
            Cnpj: {
                required: true,
                minlength: 14
            },
            DataCadastro: {
                required: true
            },
            Telefone: {
                required: true,
                minlength: 10
            }
        },
        messages: {
            Nome: {
                required: "o campo NOME é Obrigatório",
                minlength: "minimo permitido é 3 caracteres"
            },
            Cpf: {
                required: "o campo CPF é Obrigatório",
                minlength: "preencha os campos completamente"
            },
            Cnpj: {
                required: "o campo CNPJ é Obrigatório",
                minlength: "preencha os campos completamente"
            },
            DataCadastro: {
                required: "o compo DATA DE CADASTRO é obrigatória"
            },
            Telefone: {
                required: "O campo TELEFONE é obrigatório",
                minlength: "Prencha os compo completamente"
            }
        }
    });
});