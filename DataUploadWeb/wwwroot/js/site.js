$(function() {

    $("#btnSubmit").click(function() {
        var strJson = $("#txtJson").val();
        $.ajax({
            url: "/home/PostDataTest",
            type: "POST",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: strJson,
            success: function (result) {
                $("#txtJsonReturned").val(JSON.stringify(result));
            },
            error: function (err) {
                $("#txtJsonReturned").val("Error while uploading data: \n\n" + err);
            }
        }); 
    });


});
