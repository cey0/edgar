<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barang
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
        history = New Button()
        akun = New Button()
        Button1 = New Button()
        Kasir = New Button()
        tableBarang = New DataGridView()
        createButton = New Button()
        editButton = New Button()
        deleteButton = New Button()
        CType(tableBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' history
        ' 
        history.Location = New Point(294, 12)
        history.Name = "history"
        history.Size = New Size(75, 23)
        history.TabIndex = 7
        history.Text = "Laporan"
        history.UseVisualStyleBackColor = True
        ' 
        ' akun
        ' 
        akun.Location = New Point(194, 12)
        akun.Name = "akun"
        akun.Size = New Size(94, 23)
        akun.TabIndex = 6
        akun.Text = "CRUD Akun"
        akun.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(94, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 23)
        Button1.TabIndex = 5
        Button1.Text = "CRUD Barang"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Kasir
        ' 
        Kasir.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Kasir.Location = New Point(13, 12)
        Kasir.Name = "Kasir"
        Kasir.Size = New Size(75, 23)
        Kasir.TabIndex = 4
        Kasir.Text = "Kasir"
        Kasir.UseVisualStyleBackColor = True
        ' 
        ' tableBarang
        ' 
        tableBarang.AllowUserToAddRows = False
        tableBarang.AllowUserToDeleteRows = False
        tableBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tableBarang.Location = New Point(13, 60)
        tableBarang.Name = "tableBarang"
        tableBarang.Size = New Size(1201, 349)
        tableBarang.TabIndex = 8
        ' 
        ' createButton
        ' 
        createButton.Location = New Point(14, 415)
        createButton.Name = "createButton"
        createButton.Size = New Size(105, 23)
        createButton.TabIndex = 9
        createButton.Text = "Create"
        createButton.UseVisualStyleBackColor = True
        ' 
        ' editButton
        ' 
        editButton.Location = New Point(125, 415)
        editButton.Name = "editButton"
        editButton.Size = New Size(105, 23)
        editButton.TabIndex = 10
        editButton.Text = "Edit"
        editButton.UseVisualStyleBackColor = True
        ' 
        ' deleteButton
        ' 
        deleteButton.Location = New Point(236, 415)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(105, 23)
        deleteButton.TabIndex = 11
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = True
        ' 
        ' barang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1226, 450)
        Controls.Add(deleteButton)
        Controls.Add(editButton)
        Controls.Add(createButton)
        Controls.Add(tableBarang)
        Controls.Add(history)
        Controls.Add(akun)
        Controls.Add(Button1)
        Controls.Add(Kasir)
        Name = "barang"
        Text = "barang"
        CType(tableBarang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents history As Button
    Friend WithEvents akun As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Kasir As Button
    Friend WithEvents tableBarang As DataGridView
    Friend WithEvents createButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
End Class
