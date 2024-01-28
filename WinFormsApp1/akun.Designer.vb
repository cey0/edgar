<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class akun
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
        deleteButton = New Button()
        editButton = New Button()
        createButton = New Button()
        tableBarang = New DataGridView()
        history = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Kasir = New Button()
        CType(tableBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' deleteButton
        ' 
        deleteButton.Location = New Point(235, 416)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(105, 23)
        deleteButton.TabIndex = 19
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = True
        ' 
        ' editButton
        ' 
        editButton.Location = New Point(124, 416)
        editButton.Name = "editButton"
        editButton.Size = New Size(105, 23)
        editButton.TabIndex = 18
        editButton.Text = "Edit"
        editButton.UseVisualStyleBackColor = True
        ' 
        ' createButton
        ' 
        createButton.Location = New Point(13, 416)
        createButton.Name = "createButton"
        createButton.Size = New Size(105, 23)
        createButton.TabIndex = 17
        createButton.Text = "Create"
        createButton.UseVisualStyleBackColor = True
        ' 
        ' tableBarang
        ' 
        tableBarang.AllowUserToAddRows = False
        tableBarang.AllowUserToDeleteRows = False
        tableBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tableBarang.Location = New Point(12, 61)
        tableBarang.Name = "tableBarang"
        tableBarang.Size = New Size(1233, 349)
        tableBarang.TabIndex = 16
        ' 
        ' history
        ' 
        history.Location = New Point(293, 13)
        history.Name = "history"
        history.Size = New Size(75, 23)
        history.TabIndex = 15
        history.Text = "Laporan"
        history.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(193, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 23)
        Button1.TabIndex = 14
        Button1.Text = "CRUD Akun"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(93, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 23)
        Button2.TabIndex = 13
        Button2.Text = "CRUD Barang"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Kasir
        ' 
        Kasir.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Kasir.Location = New Point(12, 13)
        Kasir.Name = "Kasir"
        Kasir.Size = New Size(75, 23)
        Kasir.TabIndex = 12
        Kasir.Text = "Kasir"
        Kasir.UseVisualStyleBackColor = True
        ' 
        ' akun
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1257, 460)
        Controls.Add(deleteButton)
        Controls.Add(editButton)
        Controls.Add(createButton)
        Controls.Add(tableBarang)
        Controls.Add(history)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Kasir)
        Name = "akun"
        Text = "akun"
        CType(tableBarang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents createButton As Button
    Friend WithEvents tableBarang As DataGridView
    Friend WithEvents history As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Kasir As Button
End Class
