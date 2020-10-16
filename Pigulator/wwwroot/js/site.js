

// Write your JavaScript code.

$(document).ready(function () {
    var max_fields = 5;
    var Add_Button = $(".Button_Add");
    var Customer = $(".Customer_Intputs_Div");
    var Remove = $(".Button_Remove");
    var number = 1;

    $(Add_Button).click(function (e) {
        e.preventDefault();
        
        if (number < max_fields)
        {
            number++;
            $(Customer).append(' <input type = "text" class="form-control" name="Customers[]" placeholder="Enter a Name" />');
        }
    });

    $(Remove).click(function (e) {
        e.preventDefault();
        
        if (number != 1) {
            number--;
            Customer[0].childNodes[total_fields-1].remove();
        }
    });
    return number;
});