<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qrCodeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qrCodeForm))
        Me.qrIMG = New System.Windows.Forms.PictureBox()
        Me.saveMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveQRCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contentQR = New System.Windows.Forms.TextBox()
        Me.generateQR = New System.Windows.Forms.Button()
        Me.saveQR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.qrIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.saveMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'qrIMG
        '
        Me.qrIMG.BackColor = System.Drawing.Color.White
        Me.qrIMG.ContextMenuStrip = Me.saveMenu
        Me.qrIMG.Location = New System.Drawing.Point(12, 45)
        Me.qrIMG.Name = "qrIMG"
        Me.qrIMG.Size = New System.Drawing.Size(400, 299)
        Me.qrIMG.TabIndex = 0
        Me.qrIMG.TabStop = False
        '
        'saveMenu
        '
        Me.saveMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.saveMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveQRCodeToolStripMenuItem})
        Me.saveMenu.Name = "saveMenu"
        Me.saveMenu.Size = New System.Drawing.Size(173, 28)
        '
        'SaveQRCodeToolStripMenuItem
        '
        Me.SaveQRCodeToolStripMenuItem.Name = "SaveQRCodeToolStripMenuItem"
        Me.SaveQRCodeToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.SaveQRCodeToolStripMenuItem.Text = "Save QR Code"
        '
        'contentQR
        '
        Me.contentQR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.contentQR.Location = New System.Drawing.Point(12, 12)
        Me.contentQR.Name = "contentQR"
        Me.contentQR.Size = New System.Drawing.Size(400, 20)
        Me.contentQR.TabIndex = 1
        Me.contentQR.Text = "Text here..."
        '
        'generateQR
        '
        Me.generateQR.Location = New System.Drawing.Point(12, 350)
        Me.generateQR.Name = "generateQR"
        Me.generateQR.Size = New System.Drawing.Size(149, 49)
        Me.generateQR.TabIndex = 3
        Me.generateQR.Text = "&Generate"
        Me.generateQR.UseVisualStyleBackColor = True
        '
        'saveQR
        '
        Me.saveQR.Location = New System.Drawing.Point(263, 350)
        Me.saveQR.Name = "saveQR"
        Me.saveQR.Size = New System.Drawing.Size(149, 49)
        Me.saveQR.TabIndex = 4
        Me.saveQR.Text = "&Save"
        Me.saveQR.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "___________________________________________________________________"
        '
        'qrCodeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(425, 407)
        Me.Controls.Add(Me.saveQR)
        Me.Controls.Add(Me.generateQR)
        Me.Controls.Add(Me.contentQR)
        Me.Controls.Add(Me.qrIMG)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "qrCodeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "qrCodeForm"
        CType(Me.qrIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.saveMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents qrIMG As PictureBox
    Friend WithEvents contentQR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents generateQR As Button
    Friend WithEvents saveQR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents saveMenu As ContextMenuStrip
    Friend WithEvents SaveQRCodeToolStripMenuItem As ToolStripMenuItem
End Class
