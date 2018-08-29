Imports System.Net
Imports System.Net.Mail

Public Class Correo
    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ParamArray ruta() As String)
        Try
            Dim correos As New MailMessage
            Dim envios As New SmtpClient

            'correos.IsBodyHtml = True

            'End If

            correos.From = New MailAddress(emisor)
            correos.To.Add(Trim(destinatario))
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            For i As Integer = 0 To ruta.GetUpperBound(0)
                If ruta(i) <> "" Then
                    Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta(i))
                    correos.Attachments.Add(archivo)
                End If
            Next
            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587

            envios.DeliveryMethod = SmtpDeliveryMethod.Network
            'envios.UseDefaultCredentials = False
            envios.Credentials = New NetworkCredential(emisor, password)
            envios.EnableSsl = True
            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
