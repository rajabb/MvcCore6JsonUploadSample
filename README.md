# MvcCore6JsonUploadSample
There are some changes required to send JSON data to ASP.NET Core 6 Controller Action. Here I have created a sample with all changes required and test JSON data send via AJAX


#First your controller action should look like following

[HttpPost]
[Consumes("application/json")]
public IActionResult PostDataTest([FromBody] Employee[] employees)
{
    return Json(employees);
}


#and Ajax method will look something like 

var jsonData = [{"id":0,"name":"Very Long Employee Name with Many Characters 0","doj":"2022-08-21T11:23:24.1220131+05:30"},{"id":1,"name":"Very Long Employee Name with Many Characters 1","doj":"2022-08-20T11:23:24.1236139+05:30"},{"id":2,"name":"Very Long Employee Name with Many Characters 2","doj":"2022-08-19T11:23:24.1236164+05:30"},{"id":3,"name":"Very Long Employee Name with Many Characters 3","doj":"2022-08-18T11:23:24.1236167+05:30"},{"id":4,"name":"Very Long Employee Name with Many Characters 4","doj":"2022-08-17T11:23:24.123617+05:30"}];

var strJson = JSON.stringify(jsonData);

$.ajax({
        url: "/home/PostDataTest",
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: strJson,
        success: function (result) {
            $("#txtJsonReturned").val(result);
        },
        error: function (err) {
            $("#txtJsonReturned").val("Error while uploading data: \n\n" + err);
        }
    }); 
