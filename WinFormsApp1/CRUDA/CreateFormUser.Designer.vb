<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFormUser
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
        Label2 = New Label()
        Label1 = New Label()
        userInput = New TextBox()
        passwordInput = New TextBox()
        submitButton = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(508, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 12
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(508, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' userInput
        ' 
        userInput.Location = New Point(508, 196)
        userInput.Name = "userInput"
        userInput.Size = New Size(277, 23)
        userInput.TabIndex = 10
        ' 
        ' passwordInput
        ' 
        passwordInput.Location = New Point(508, 256)
        passwordInput.Name = "passwordInput"
        passwordInput.Size = New Size(277, 23)
        passwordInput.TabIndex = 9
        ' 
        ' submitButton
        ' 
        submitButton.Location = New Point(508, 318)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(277, 30)
        submitButton.TabIndex = 7
        submitButton.Text = "Submit"
        submitButton.UseVisualStyleBackColor = True
        ' 
        ' CreateFormUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1286, 529)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(userInput)
        Controls.Add(passwordInput)
        Controls.Add(submitButton)
        Name = "CreateFormUser"
        Text = "CreateFormUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents userInput As TextBox
    Friend WithEvents passwordInput As TextBox
    Friend WithEvents submitButton As Button
End Class
