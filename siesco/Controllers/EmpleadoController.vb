Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity

Namespace Controllers
    <Authorize(Roles:="Empleado")>
    Public Class EmpleadoController
        Inherits Controller

        ' GET: Empleado
        Function Index() As ActionResult
            Return View()
        End Function

        Function ObtenerDisponibilidadEmpleado() As JsonResult
            Dim UsuarioId As String = User.Identity.GetUserId
            Dim eventos As New List(Of EventCalendar)
            Using db As New Entities
                Dim empleado = db.Empleados.Where(Function(x) x.AspNetUsers = UsuarioId).ToList
                If empleado.Count > 0 Then
                    Dim empleadoid = empleado(0).Id
                    Dim disponibilidades = db.DisponibilidadEmpleado.Where(Function(x) x.Empleado = empleadoid).ToList
                    If disponibilidades.Count > 0 Then
                        For Each item In disponibilidades
                            Dim start = Convert.ToDateTime(item.fechaInicio).ToString("s")
                            Dim fin = Convert.ToDateTime(item.fechaTermino).ToString("s")
                            Dim id = "c_" + item.id.ToString
                            Dim evento As New EventCalendar With {.id = id,
                                                                    .start = start,
                                                                    .end = fin,
                                                                    .color = "green",
                                                                    .rendering = "background"}
                            eventos.Add(evento)
                        Next
                    End If
                End If
            End Using

            Return Json(eventos.ToArray, JsonRequestBehavior.AllowGet)

        End Function
        <Authorize(Roles:="Empleado")>
        Function GuardarDisponibilidadEmpleado(form As FormCollection) As JsonResult
            Dim UsuarioId As String = User.Identity.GetUserId

            Dim dia = Convert.ToInt32(form("Dia"))
            Dim mes = Convert.ToInt32(form("Mes"))
            Dim año = Convert.ToInt32(form("Año"))
            Dim hora = Convert.ToInt32(form("Hora"))
            Dim minuto = Convert.ToInt32(form("Minuto"))

            Dim diaTermino = Convert.ToInt32(form("DiaTermino"))
            Dim mesTermino = Convert.ToInt32(form("MesTermino"))
            Dim añoTermino = Convert.ToInt32(form("AñoTermino"))
            Dim horaTermino = Convert.ToInt32(form("HoraTermino"))
            Dim minutoTermino = Convert.ToInt32(form("minutoTermino"))

            Dim inicio As New Date(año, mes, dia, hora, minuto, 0)
            Dim termino As New Date(añoTermino, mesTermino, diaTermino, horaTermino, minutoTermino, 0)

            Using db As New Entities

                Dim empleado = db.Empleados.Where(Function(x) x.AspNetUsers = UsuarioId).ToList
                If empleado.Count > 0 Then
                    Dim Disponibilidad As New DisponibilidadEmpleado

                    Disponibilidad.fechaInicio = inicio
                    Disponibilidad.fechaTermino = termino
                    Disponibilidad.Empleado = empleado(0).Id
                    db.DisponibilidadEmpleado.Add(Disponibilidad)
                    db.SaveChanges()

                End If

            End Using

            Return Json("", JsonRequestBehavior.AllowGet)

        End Function
    End Class
End Namespace