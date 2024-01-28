<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        labelName = New Label()
        inputName = New TextBox()
        inputPassword = New TextBox()
        labelPassword = New Label()
        LoginTitle = New Label()
        submitButton = New Button()
        SuspendLayout()
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelName.Location = New Point(246, 152)
        labelName.Name = "labelName"
        labelName.Size = New Size(39, 15)
        labelName.TabIndex = 0
        labelName.Text = "Name"
        ' 
        ' inputName
        ' 
        inputName.Location = New Point(246, 170)
        inputName.Name = "inputName"
        inputName.Size = New Size(247, 23)
        inputName.TabIndex = 1
        ' 
        ' inputPassword
        ' 
        inputPassword.Location = New Point(246, 240)
        inputPassword.Name = "inputPassword"
        inputPassword.Size = New Size(247, 23)
        inputPassword.TabIndex = 2
        ' 
        ' labelPassword
        ' 
        labelPassword.AutoSize = True
        labelPassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPassword.Location = New Point(246, 222)
        labelPassword.Name = "labelPassword"
        labelPassword.Size = New Size(57, 15)
        labelPassword.TabIndex = 3
        labelPassword.Text = "Password"
        ' 
        ' LoginTitle
        ' 
        LoginTitle.AutoSize = True
        LoginTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginTitle.Location = New Point(326, 70)
        LoginTitle.Name = "LoginTitle"
        LoginTitle.Size = New Size(87, 32)
        LoginTitle.TabIndex = 4
        LoginTitle.Text = "LOGIN"
        ' 
        ' submitButton
        ' 
        submitButton.BackColor = Color.DarkSeaGreen
        submitButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submitButton.ForeColor = SystemColors.ButtonFace
        submitButton.Location = New Point(246, 287)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(247, 24)
        submitButton.TabIndex = 5
        submitButton.Text = "Submit"
        submitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(712, 450)
        Controls.Add(submitButton)
        Controls.Add(LoginTitle)
        Controls.Add(labelPassword)
        Controls.Add(inputPassword)
        Controls.Add(inputName)
        Controls.Add(labelName)
        Name = "login"
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelName As Label
    Friend WithEvents inputName As TextBox
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents labelPassword As Label
    Friend WithEvents LoginTitle As Label
    Friend WithEvents submitButton As Button

End Class
