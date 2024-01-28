<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFormUsers
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        stockInput = New TextBox()
        hargaInput = New TextBox()
        barangInput = New TextBox()
        submitButton = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(474, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 13
        Label3.Text = "Harga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(474, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 12
        Label2.Text = "Stock"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(474, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 11
        Label1.Text = "Nama Barang"
        ' 
        ' stockInput
        ' 
        stockInput.Location = New Point(474, 206)
        stockInput.Name = "stockInput"
        stockInput.Size = New Size(305, 23)
        stockInput.TabIndex = 10
        ' 
        ' hargaInput
        ' 
        hargaInput.Location = New Point(474, 274)
        hargaInput.Name = "hargaInput"
        hargaInput.Size = New Size(305, 23)
        hargaInput.TabIndex = 9
        ' 
        ' barangInput
        ' 
        barangInput.Location = New Point(474, 142)
        barangInput.Name = "barangInput"
        barangInput.Size = New Size(305, 23)
        barangInput.TabIndex = 8
        ' 
        ' submitButton
        ' 
        submitButton.Location = New Point(474, 329)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(305, 33)
        submitButton.TabIndex = 7
        submitButton.Text = "Submit"
        submitButton.UseVisualStyleBackColor = True
        ' 
        ' CreateFormBarang
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 486)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(stockInput)
        Controls.Add(hargaInput)
        Controls.Add(barangInput)
        Controls.Add(submitButton)
        Name = "CreateFormBarang"
        Text = "CreateFormBarang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents stockInput As TextBox
    Friend WithEvents hargaInput As TextBox
    Friend WithEvents barangInput As TextBox
    Friend WithEvents submitButton As Button
End Class
