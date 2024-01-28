<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kasir
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
        Label11 = New Label()
        Label10 = New Label()
        kembalianInput = New TextBox()
        tunaiInput = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        inputKasir = New TextBox()
        userKasir = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        printButton = New Button()
        diskonInput = New TextBox()
        totalBarangInput = New TextBox()
        totalInput = New TextBox()
        subInput = New TextBox()
        itemGrid = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        nama_barang = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        harga = New DataGridViewTextBoxColumn()
        buttonSubmit = New Button()
        qtyInput = New TextBox()
        itemCombos = New ComboBox()
        itemSearch = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        CType(itemGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(898, 300)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 15)
        Label11.TabIndex = 58
        Label11.Text = "Kembalian"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(899, 247)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 15)
        Label10.TabIndex = 57
        Label10.Text = "Tunai"
        ' 
        ' kembalianInput
        ' 
        kembalianInput.Location = New Point(899, 316)
        kembalianInput.Name = "kembalianInput"
        kembalianInput.ReadOnly = True
        kembalianInput.Size = New Size(241, 23)
        kembalianInput.TabIndex = 56
        ' 
        ' tunaiInput
        ' 
        tunaiInput.Location = New Point(899, 265)
        tunaiInput.Name = "tunaiInput"
        tunaiInput.Size = New Size(241, 23)
        tunaiInput.TabIndex = 55
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(667, 481)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 54
        Label9.Text = "Kasir"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(666, 437)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 53
        Label8.Text = "User Kasir"
        ' 
        ' inputKasir
        ' 
        inputKasir.Location = New Point(730, 477)
        inputKasir.Name = "inputKasir"
        inputKasir.ReadOnly = True
        inputKasir.Size = New Size(139, 23)
        inputKasir.TabIndex = 52
        inputKasir.Text = "Main Register"
        ' 
        ' userKasir
        ' 
        userKasir.Location = New Point(730, 434)
        userKasir.Name = "userKasir"
        userKasir.ReadOnly = True
        userKasir.Size = New Size(139, 23)
        userKasir.TabIndex = 51
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(185, 485)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 50
        Label7.Text = "Total"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(185, 445)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 49
        Label6.Text = "Sub Total"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(38, 485)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 48
        Label5.Text = "Diskon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 442)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 47
        Label4.Text = "Total Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 423)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 46
        ' 
        ' printButton
        ' 
        printButton.Location = New Point(899, 371)
        printButton.Name = "printButton"
        printButton.Size = New Size(241, 23)
        printButton.TabIndex = 45
        printButton.Text = "Print Struk"
        printButton.UseVisualStyleBackColor = True
        ' 
        ' diskonInput
        ' 
        diskonInput.Location = New Point(116, 482)
        diskonInput.Name = "diskonInput"
        diskonInput.Size = New Size(41, 23)
        diskonInput.TabIndex = 44
        diskonInput.Text = "0%"
        ' 
        ' totalBarangInput
        ' 
        totalBarangInput.Enabled = False
        totalBarangInput.Location = New Point(116, 439)
        totalBarangInput.Name = "totalBarangInput"
        totalBarangInput.Size = New Size(41, 23)
        totalBarangInput.TabIndex = 43
        totalBarangInput.Text = "0"
        ' 
        ' totalInput
        ' 
        totalInput.Enabled = False
        totalInput.Location = New Point(246, 482)
        totalInput.Name = "totalInput"
        totalInput.Size = New Size(136, 23)
        totalInput.TabIndex = 42
        totalInput.Text = "Total"
        ' 
        ' subInput
        ' 
        subInput.Enabled = False
        subInput.Location = New Point(246, 442)
        subInput.Name = "subInput"
        subInput.Size = New Size(136, 23)
        subInput.TabIndex = 41
        subInput.Text = "Sub Total"
        ' 
        ' itemGrid
        ' 
        itemGrid.AllowUserToAddRows = False
        itemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        itemGrid.Columns.AddRange(New DataGridViewColumn() {Column1, nama_barang, quantity, harga})
        itemGrid.Location = New Point(26, 56)
        itemGrid.Name = "itemGrid"
        itemGrid.Size = New Size(843, 363)
        itemGrid.TabIndex = 40
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "No"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 30
        ' 
        ' nama_barang
        ' 
        nama_barang.HeaderText = "Item"
        nama_barang.Name = "nama_barang"
        nama_barang.ReadOnly = True
        nama_barang.Width = 500
        ' 
        ' quantity
        ' 
        quantity.HeaderText = "Quantity"
        quantity.Name = "quantity"
        quantity.ReadOnly = True
        quantity.Width = 120
        ' 
        ' harga
        ' 
        harga.HeaderText = "Harga"
        harga.Name = "harga"
        harga.ReadOnly = True
        harga.Width = 150
        ' 
        ' buttonSubmit
        ' 
        buttonSubmit.Location = New Point(899, 209)
        buttonSubmit.Name = "buttonSubmit"
        buttonSubmit.Size = New Size(241, 23)
        buttonSubmit.TabIndex = 39
        buttonSubmit.Text = "Submit"
        buttonSubmit.UseVisualStyleBackColor = True
        ' 
        ' qtyInput
        ' 
        qtyInput.Location = New Point(1040, 148)
        qtyInput.Name = "qtyInput"
        qtyInput.Size = New Size(100, 23)
        qtyInput.TabIndex = 38
        ' 
        ' itemCombos
        ' 
        itemCombos.DropDownStyle = ComboBoxStyle.DropDownList
        itemCombos.FormattingEnabled = True
        itemCombos.Location = New Point(899, 167)
        itemCombos.Name = "itemCombos"
        itemCombos.Size = New Size(123, 23)
        itemCombos.TabIndex = 37
        ' 
        ' itemSearch
        ' 
        itemSearch.Location = New Point(899, 148)
        itemSearch.Name = "itemSearch"
        itemSearch.Size = New Size(123, 23)
        itemSearch.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1040, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 35
        Label2.Text = "Quantitas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(899, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 34
        Label1.Text = "Item"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(26, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 30
        Button1.Text = "Kasir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' kasir
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 531)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(kembalianInput)
        Controls.Add(tunaiInput)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(inputKasir)
        Controls.Add(userKasir)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(printButton)
        Controls.Add(diskonInput)
        Controls.Add(totalBarangInput)
        Controls.Add(totalInput)
        Controls.Add(subInput)
        Controls.Add(itemGrid)
        Controls.Add(buttonSubmit)
        Controls.Add(qtyInput)
        Controls.Add(itemCombos)
        Controls.Add(itemSearch)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "kasir"
        Text = "kasir"
        CType(itemGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents kembalianInput As TextBox
    Friend WithEvents tunaiInput As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents inputKasir As TextBox
    Friend WithEvents userKasir As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents printButton As Button
    Friend WithEvents diskonInput As TextBox
    Friend WithEvents totalBarangInput As TextBox
    Friend WithEvents totalInput As TextBox
    Friend WithEvents subInput As TextBox
    Friend WithEvents itemGrid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents buttonSubmit As Button
    Friend WithEvents qtyInput As TextBox
    Friend WithEvents itemCombos As ComboBox
    Friend WithEvents itemSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
