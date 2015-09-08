Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Disponibilidad() As JsonResult
        Dim disponibilidades As New List(Of EventCalendar)
        Using db As New Entities
            Dim disponibilidadEmpleados = db.DisponibilidadEmpleado.ToList
            Dim disponibilidadesActivos = db.DisponibilidadActivo.ToList
            Dim idevento = 0


            If disponibilidadEmpleados.Count > 0 And disponibilidadesActivos.Count > 0 Then
                For Each disponibilidadActivo In disponibilidadesActivos
                    For Each disponibilidadEmpleado In disponibilidadEmpleados
                        If disponibilidadEmpleado.fechaInicio.Value.Day = disponibilidadActivo.fechaInicio.Day Then

                            Dim start As String
                            Dim fin As String


                            If disponibilidadEmpleado.fechaInicio >= disponibilidadActivo.fechaInicio Then
                                start = Convert.ToDateTime(disponibilidadEmpleado.fechaInicio).ToString("s")
                            Else
                                start = Convert.ToDateTime(disponibilidadActivo.fechaInicio).ToString("s")
                            End If

                            If disponibilidadEmpleado.fechaTermino <= disponibilidadActivo.fechaTermino Then
                                fin = Convert.ToDateTime(disponibilidadEmpleado.fechaTermino).ToString("s")
                            Else
                                fin = Convert.ToDateTime(disponibilidadActivo.fechaTermino).ToString("s")
                            End If
                            idevento = idevento + 1

                            Dim id = "c_" + idevento.ToString
                            Dim evento As New EventCalendar With {.id = id,
                                                                    .start = start,
                                                                    .end = fin,
                                                                    .color = "green",
                                                                    .rendering = "background"}



                            disponibilidades.Add(evento)

                        End If
                    Next

                Next


            End If

        End Using
        Return Json(disponibilidades, JsonRequestBehavior.AllowGet)
    End Function


End Class
