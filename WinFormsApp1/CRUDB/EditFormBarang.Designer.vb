<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFormBarang
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
        submitButton = New Button()
        hargaInput = New TextBox()
        stockInput = New TextBox()
        barangInput = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' submitButton
        ' 
        submitButton.Location = New Point(528, 359)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(277, 30)
        submitButton.TabIndex = 0
        submitButton.Text = "Submit"
        submitButton.UseVisualStyleBackColor = True
        ' 
        ' hargaInput
        ' 
        hargaInput.Location = New Point(528, 295)
        hargaInput.Name = "hargaInput"
        hargaInput.Size = New Size(277, 23)
        hargaInput.TabIndex = 1
        ' 
        ' stockInput
        ' 
        stockInput.Location = New Point(528, 240)
        stockInput.Name = "stockInput"
        stockInput.Size = New Size(277, 23)
        stockInput.TabIndex = 2
        ' 
        ' barangInput
        ' 
        barangInput.Location = New Point(528, 180)
        barangInput.Name = "barangInput"
        barangInput.Size = New Size(277, 23)
        barangInput.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(528, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 4
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(528, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 5
        Label2.Text = "Stock"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(528, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 6
        Label3.Text = "Harga"
        ' 
        ' EditFormBarang
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1289, 517)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(barangInput)
        Controls.Add(stockInput)
        Controls.Add(hargaInput)
        Controls.Add(submitButton)
        Name = "EditFormBarang"
        Text = "EditFormBarang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents submitButton As Button
    Friend WithEvents hargaInput As TextBox
    Friend WithEvents stockInput As TextBox
    Friend WithEvents barangInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
