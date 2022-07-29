function createForm(situacoesEmpregoData, estadoCivilData, familiaData) {
 

    //Tab - Strip START
    //Tab - Strip START

    $("#tabstrip").kendoTabStrip({
        animation: {
            open: {
                effects: "fadeOn"
            }
        }
    });
    //Tab - Strip END
    //Tab - Strip END


    // Date START
    // Date START
    // create DatePicker from input HTML element
    

    $("#monthpicker").kendoDatePicker({
        // defines the start view
        start: "year",

        // defines when the calendar should return date
        depth: "year",

        // display month and year in the input
        format: "MMMM yyyy",

        // specifies that DateInput is used for masking the input element
        dateInput: true
    });

    // Date END
    // Date END

    // Masked Text START
    // Masked Text START

    $("#phone_number").kendoMaskedTextBox({
        mask: "(##) # #### - ####"
    });

    $("#tel_number").kendoMaskedTextBox({
        mask: "(##) #### - ####"
    });

    $("#credit_card").kendoMaskedTextBox({
        mask: "#### #### #### ####"
    });

    $("#ssn").kendoMaskedTextBox({
        mask: "###-##-####"
    });

    $("#postcode").kendoMaskedTextBox({
        mask: "L0L 0LL"
    });

    // Masked Text END
    // Masked Text END

    $('#situacao-emprego').kendoComboBox({
        dataTextField: "Descricao",
        dataValueField: "Id",
        dataSource: situacoesEmpregoData,
        filter: "contains",
        suggest: true,
        index: 0
    });

    $('#estado-civil').kendoComboBox({
        dataTextField: "Descricao",
        dataValueField: "Id",
        dataSource: estadoCivilData,
        filter: "contains",
        suggest: true,
        index: 0
    });

    $('#nome').kendoMaskedTextBox({
        value:familiaData.Responsavel.Nome,
        //limitando a 100 caracteres
        mask: "????????????????????????????????????????????????????????????????????????????????????????????????????"
    });

    $('#rg').kendoMaskedTextBox({
        value:familiaData.Rg,
        //limitando a  caracteres
        mask: ""
    });
    $('#cpf').kendoMaskedTextBox({
        value:familiaData.Cpf,
        //limitando a  caracteres
        mask: ""
    });
    $("#data-nascimento").kendoDatePicker({
        value:familiaData.Responsavel.DataNascimento,
    });
    $('#phone_number').kendoMaskedTextBox({
        value:familiaData.Celular,
        //limitando a  caracteres
        mask: ""
    });
    $('#tel_number').kendoMaskedTextBox({
        value:familiaData.Telefone,
        //limitando a  caracteres
        mask:""
    });
    $('#sexoMasculino').kendoMaskedTextBox({
        value:familiaData.Sexo,
        //limitando a  caracteres
        mask: ""
    });
    $('#batismo').kendoMaskedTextBox({
        value:familiaData.Batizado,
        //limitando a  caracteres
        mask: ""
    });
    $('#crisma').kendoMaskedTextBox({
        value:familiaData.Crismado,
        //limitando a  caracteres
        mask: ""
    });
    $('#eucaristia').kendoMaskedTextBox({
        value:familiaData.Eucaristia,
        //limitando a  caracteres
        mask: ""
    });
    $('#matrimonio').kendoMaskedTextBox({
        value:familiaData.Matrimonio,
        //limitando a  caracteres
        mask: ""
    });
    $('#profissao').kendoMaskedTextBox({
        value:familiaData.Profissao,
        //limitando a  caracteres
        mask: ""
    });
    $('#estado-civil').kendoMaskedTextBox({
        value:familiaData.EstadoCivil,
        //limitando a  caracteres
        mask: ""
    });
    $('#situacao-emprego').kendoMaskedTextBox({
        value:familiaData.SituacaoEmprego.Id,
        //limitadatando a  caracteres
        mask: ""
    });






    $('#endereco').kendoMaskedTextBox({
        value: familiaData.Endereco,
        //limitando a 150 caracteres
        mask: "??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"
    });



}