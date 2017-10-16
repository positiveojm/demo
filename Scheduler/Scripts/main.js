
$(document).ready(function () {
    initialize();
    $("#backcolors").minicolors();
    $("#fontcolors").minicolors();

});

$("a").click(function(){
    $('#myModal').modal();

})

function initialize() {
    $.ajax({
        method: "GET",
        url: "/Home/FetchData",
        success: onSuccess,
        dataType: "JSON"
    });
}

function onSuccess(data) {
    //console.log(data);
    makeCalendar(data);
}
function makeCalendar(data) {
    $('#calendar').fullCalendar({
        header: {
            left: "prev, next, today",
            center: "title"
            //right: "month, agendaWeek"
        },
        editable: true,
        selectable: true,
        eventClick: function (calEvent, jsEvent, view) {
        },
        dayClick: function (date, jsEvent, view) {
            debugger;
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