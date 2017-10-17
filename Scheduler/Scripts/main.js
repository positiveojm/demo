
$(document).ready(function () {
    initialize();
    //$("#backcolors").minicolors();
    //$("#fontcolors").minicolors();
});


function initialize() {
    $.ajax({
        method: "GET",
        url: "/Home/FetchData",
        success: onSuccess,
        dataType: "JSON"
    });

    $("a").click(function () {
        $('#myModal').modal();

    })
}

function onSuccess(data) {
    //console.log(data);
    makeCalendar(data);
}
function makeCalendar(data) {
    $('#calendar').fullCalendar({
        height:$(window).height()*0.95,
        header: {
            left: "title",
            //center: "",
            right: "prev, next, today"
        },
        editable: true,
        selectable: true,
        eventClick: function (calEvent, jsEvent, view) {
            $.ajax({
                method: "GET",
                url: "/Tasks/Edit/" + String(calEvent.taskid),
                success: showModal
            });
        },
        dayClick: function (date, jsEvent, view) {
            var dateString = date.format("MM/DD/YYYY");
            console.log("you clicked");
            $.ajax({
                method: "GET",
                url: "/Tasks/Create/"+dateString,
                success: showModal
            });

        },
        events: data
    });
}

function showModal(event) {
    debugger;
    console.log(event);
    $("#modal").html(event);
    $("#myModal").modal();
}