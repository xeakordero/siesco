<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    @Scripts.Render("~/bundles/moment")
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

  
    <script type="text/javascript"> 


        $(document).ready(function () {

            $('#calendar').fullCalendar({
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                defaultDate: '2014-06-12',
                defaultView: 'agendaWeek',
                editable: true,
                events: [
                    {
                        title: 'All Day Event',
                        start: '2014-06-01'
                    },
                    {
                        title: 'Long Event',
                        start: '2014-06-07',
                        end: '2014-06-10',
                        color: 'red'
                    },
                    {
                        id: 999,
                        title: 'Repeating Event',
                        start: '2014-06-09T16:00:00'
                    },
                    {
                        id: 999,
                        title: 'Repeating Event',
                        start: '2014-06-16T16:00:00'
                    },
                    {
                        title: 'Meeting',
                        start: '2014-06-12T10:30:00',
                        end: '2014-06-12T12:30:00'
                    },
                    {
                        title: 'Lunch',
                        start: '2014-06-12T12:00:00'
                    },
                    {
                        title: 'Birthday Party',
                        start: '2014-06-13T07:00:00'
                    },
                    {
                        title: 'Click for Google',
                        url: 'http://google.com/',
                        start: '2014-06-28'
                    }
                ]
            });

        });


     
       
        </script>

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Nombre de aplicación", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                    <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()

        <div id="calendar"></div>
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/calendar")
    @Styles.Render("~/Content/calendar")


    @RenderSection("scripts", required:=False)
</body>
</html>
