@ModelType siesco.DisponibilidadEmpleado
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Disponibilidad empleado</h2>
<script type="text/javascript">

        $(document).ready(function () {

            $('#calendar').fullCalendar({
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                minTime: '08:00:00',
                maxTime: '22:00:00',
                monthNamesShort: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio',
                         'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mier', 'Jue', 'Vie', 'Sab'],
                columnFormat: 'ddd D/MMM',
                allDaySlot: false,
                defaultDate: '2015-09-03',
                defaultView: 'agendaWeek',
                editable: true,
                events: '/Empleado/ObtenerDisponibilidadEmpleado',
                selectable: true, 
                select: function (start, end, view) {
                  
                    var Dia = moment(start).format('DD');
                    var Mes= moment(start).format('MM');
                    var Año = moment(start).format('YYYY');
                    var Hora = moment(start).format('HH');
                    var Minuto = moment(start).format('mm');
                    
                    var DiaTermino = moment(end).format('DD');
                    var MesTermino = moment(end).format('MM');
                    var AñoTermino = moment(end).format('YYYY');
                    var HoraTermino = moment(end).format('HH');
                    var MinutoTermino = moment(end).format('mm');
  
                    $.ajax({
                        url: '/Empleado/GuardarDisponibilidadEmpleado',
                        data: {
                            Dia: Dia,
                            Mes: Mes,
                            Año: Año,
                            Hora: Hora,
                            Minuto: Minuto,
                            DiaTermino: DiaTermino,
                            MesTermino: MesTermino,
                            AñoTermino: AñoTermino,
                            HoraTermino: HoraTermino,
                            MinutoTermino: MinutoTermino
                        },
                        type: 'POST',
                        dataType: 'json',
                        success: function (response) {
                            $("#calendar").fullCalendar('refetchEvents');
                        }
                    });
                   
                    
                }

          
            });

        });

</script>

    @Html.AntiForgeryToken()

    <div class="col-md-12">
           
            <div id="calendar">

            </div>
        </div>
   




@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
