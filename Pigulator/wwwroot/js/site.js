// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//$(document).ready(function () {
//    var max_fields = 10; //maximum input boxes allowed
//    var wrapper = $(".input_fields_wrap"); //Fields wrapper
//    var add_button = $(".add_field_button"); //Add button ID
//
//    var x = 1; //initlal text box count
//    $(add_button).click(function (e) { //on add input button click
//        e.preventDefault();
//        if (x < max_fields) { //max input box allowed
//            x++; //text box increment
//            $(wrapper).append('<div><input type="text" name="mytext[]"/><a href="#" class="remove_field">Remove</a></div>'); //add input box
//        }
//    });
//
//    $(wrapper).on("click", ".remove_field", function (e) { //user click on remove text
//        e.preventDefault(); $(this).parent('div').remove(); x--;
//    })
//});

$(document).ready(function () {
    var max_fields = 6;
    var Add_Button = $(".Button_Add");
    var Customer = $(".Customer_Intputs_Div");
    var Remove = $(".Button_Remove");

    $(Add_Button).click(function (e) {
        e.preventDefault();
        var total_fields = Customer[0].childNodes.length;
        if (total_fields < max_fields)
        {
            
            $(Customer).append('<input type="text" class="form-control" name="Customers[]" placeholder = "Enter a Name"/>');
        }
    });

    $(Remove).click(function (e) {
        e.preventDefault();
        var total_fields = Customer[0].childNodes.length;
        if (total_fields > 1) {

            Customer[0].childNodes[total_fields-1].remove();
        }
    });
});