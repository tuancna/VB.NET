Module allFunction
    Public Function genQRCode(content As String)
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White
        Generator.LabelFont = New Font("Arial", 11, FontStyle.Regular)
        Generator.IncludeLabel = True
        Generator.CustomLabel = content

        Try
            qrCodeForm.qrIMG.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, content))
            qrCodeForm.qrIMG.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Notification")
            Exit Function
        End Try
    End Function

    Public Function saveQRCode()
        Dim SaveDialog As New SaveFileDialog
        SaveDialog.FileName = "YourQRCode"
        SaveDialog.Filter = "PNG Files Only (*.png)|*.png"
        If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                qrCodeForm.qrIMG.Image.Save(SaveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MsgBox("Your QR Code has been saved successfully!", MsgBoxStyle.Information, "Notification")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Notification")
            End Try
        End If
    End Function
End Module
