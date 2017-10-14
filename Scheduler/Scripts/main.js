$(document).ready(function () {
    initialize();
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
function makeCalendar() {
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
        eventSources: [

       // your event source
       {
           events: [ // put the array in the `events` property
               {
                   title: 'event1',
                   start: '2017-10-13'
               },
               {
                   title: 'event2',
                   start: '2017-10-20',
                   end: '2017-10-21'
               },
               {
                   title: 'event3',
                   start: '2010-01-09T12:30:00',
               }
           ],
           color: 'black',     // an option!
           textColor: 'yellow' // an option!
       }

       // any other event sources...

        ]
    })
}