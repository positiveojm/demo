
$(document).ready(function () {
    initialize();
    $("#backcolors").minicolors();
    $("#fontcolors").minicolors();

});

$("#modal").on("resize", function () {
    alert("modal populated");
});





function initialize() {
    $.ajax({
        method: "GET",
        url: "/Home/FetchData",
        success: onSuccess,
        dataType: "JSON"
    });


}

function onSuccess(data) {
    console.log(data);
    makeCalendar(data);
}
function makeCalendar(data) {
    $('#calendar').fullCalendar({
        header: {
            left: "prev, next today",
            center: "title",
            right: "month, agendaWeek"
        },
        editable: true,
        selectable: true,
        eventClick: function (calEvent, jsEvent, view) {
            alert("You clicked on eventid: " + calEvent.id + "\nAnd the title is: " + calEvent.title);
        },
        events: data
    })
}