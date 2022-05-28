Imports MessagingToolkit
Public Class qrCodeForm
    Private Sub qrCodeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "QR Code Generator"

        Dim rnd As New Random

        Dim dayArray(0 To 2) As String
        dayArray(0) = "Hi there! I'm Tuan Chung" & vbCrLf & "Have a nice day!"
        dayArray(1) = "Hi there! I'm Tuan Chung" & vbCrLf & "Good day!"
        dayArray(2) = "Hi there! I'm Tuan Chung" & vbCrLf & "How are you today?"

        Dim nightArray(0 To 2) As String
        nightArray(0) = "Hi there! I'm Tuan Chung" & vbCrLf & "Good evening!"
        nightArray(1) = "Hi there! I'm Tuan Chung" & vbCrLf & "How was your day!"
        nightArray(2) = "Hi there! I'm Tuan Chung" & vbCrLf & "Goodnight!"

        Dim hours = Now.TimeOfDay.TotalHours
        If (hours <= 5.5 And hours >= 17.5) Then
            genQRCode(dayArray(rnd.Next(0, 3)))
        Else
            genQRCode(nightArray(rnd.Next(0, 3)))
        End If
    End Sub

    Private Sub generateQR_Click(sender As Object, e As EventArgs) Handles generateQR.Click
        If (contentQR.Text = "") Then
            MsgBox("Your QR Code content is empty", vbExclamation, "Notification")
        Else
            genQRCode(contentQR.Text)
        End If
    End Sub

    Private Sub saveQR_Click(sender As Object, e As EventArgs) Handles saveQR.Click
        If (Not qrIMG.Image Is Nothing) Then
            saveQRCode()
        Else
            MsgBox("Your QR Code is empty", vbExclamation, "Notification")
        End If
    End Sub

    Private Sub qrIMG_Click(sender As Object, e As EventArgs) Handles qrIMG.Click

    End Sub

    Private Sub SaveQRCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveQRCodeToolStripMenuItem.Click
        If (Not qrIMG.Image Is Nothing) Then
            saveQRCode()
        Else
            MsgBox("Your QR Code is empty", vbExclamation, "Notification")
        End If
    End Sub
End Class