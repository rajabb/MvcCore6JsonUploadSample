$(function() {

    $("#btnSubmit").click(function() {
        var jsonStr = $("#txtJson").val();
        postData(jsonStr);
    });


});


function postData(strJson) {
    $.ajax({
        url: "/home/PostDataTest",
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        //contentType: "application/json",
        //data: JSON.stringify( { 'Name': 'value1', 'Id': 1 }),
        data: strJson,
        success: function (result) {
            // when call is sucessfull
        },
        error: function (err) {
            // check the err for error details
        }
    }); 
}