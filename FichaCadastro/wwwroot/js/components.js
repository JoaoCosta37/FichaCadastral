$(document).ready(function () {

    //Tab - Strip START
    //Tab - Strip START

    $("#tabstrip").kendoTabStrip({
        animation: {
            open: {
                effects: "fadeIn"
            }
        }
    });
    //Tab - Strip END
    //Tab - Strip END


    // Date START
    // Date START
    // create DatePicker from input HTML element
    $("#datepicker").kendoDatePicker();

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

    $("#credit_card").kendoMaskedTextBox({
        mask: "#### #### #### ####"
    });

    $("#ssn").kendoMaskedTextBox({
        mask: "###-##-####"
    });

    $("#postcode").kendoMaskedTextBox({
        mask: "L0L 0LL"
    });

    $("#rg").kendoMaskedTextBox({
        mask: "## ### ### - #"
    });

    $("#cpf").kendoMaskedTextBox({
        mask: "### ### ### - ##"
    });

    // Masked Text END
    // Masked Text END

})