


Public Class Utils

    Public Shared Sub EnviarEmail(Destinatarios As List(Of String), mensaje As String, asunto As String)


        EnviarEmail(Destinatarios, mensaje, asunto, True)
    End Sub
    Private Shared Sub EnviarEmail(
                                   destinatarios As List(Of String),
                                   mensaje As String,
                                   asunto As String,
                                   isbodyhtml As Boolean)


        Dim cliente As New System.Net.Mail.SmtpClient
        cliente.Host = "smtp.gmail.com"
        cliente.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
        cliente.Port = 25
        cliente.EnableSsl = True
        cliente.UseDefaultCredentials = False
        cliente.Credentials = New System.Net.NetworkCredential("scorderochavez@gmail.com", "xeakordero")
        Dim mail As New System.Net.Mail.MailMessage

        For Each dest In destinatarios
            mail.To.Add(New System.Net.Mail.MailAddress(dest))
        Next

        mail.From = New System.Net.Mail.MailAddress("scorderochavez@gmail.com", "Sistema Siesco", Text.Encoding.UTF8)
        mail.Body = mensaje
        mail.Subject = asunto
        mail.IsBodyHtml = isbodyhtml
        Try
            cliente.Send(mail)
        Catch ex As Exception

        End Try
    End Sub
End Class
