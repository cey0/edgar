<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Kasir = New Button()
        barang = New Button()
        akun = New Button()
        history = New Button()
        Label1 = New Label()
        Label2 = New Label()
        itemSearch = New TextBox()
        itemCombos = New ComboBox()
        qtyInput = New TextBox()
        buttonSubmit = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        itemGrid = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        nama_barang = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        harga = New DataGridViewTextBoxColumn()
        subInput = New TextBox()
        totalInput = New TextBox()
        totalBarangInput = New TextBox()
        diskonInput = New TextBox()
        printButton = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        userKasir = New TextBox()
        inputKasir = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        tunaiInput = New TextBox()
        kembalianInput = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        CType(itemGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Kasir
        ' 
        Kasir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Kasir.Location = New Point(12, 12)
        Kasir.Name = "Kasir"
        Kasir.Size = New Size(75, 23)
        Kasir.TabIndex = 0
        Kasir.Text = "Kasir"
        Kasir.UseVisualStyleBackColor = True
        ' 
        ' barang
        ' 
        barang.Location = New Point(93, 12)
        barang.Name = "barang"
        barang.Size = New Size(94, 23)
        barang.TabIndex = 1
        barang.Text = "CRUD Barang"
        barang.UseVisualStyleBackColor = True
        ' 
        ' akun
        ' 
        akun.Location = New Point(193, 12)
        akun.Name = "akun"
        akun.Size = New Size(94, 23)
        akun.TabIndex = 2
        akun.Text = "CRUD Akun"
        akun.UseVisualStyleBackColor = True
        ' 
        ' history
        ' 
        history.Location = New Point(293, 12)
        history.Name = "history"
        history.Size = New Size(75, 23)
        history.TabIndex = 3
        history.Text = "Laporan"
        history.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(885, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 4
        Label1.Text = "Item"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1026, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 5
        Label2.Text = "Quantitas"' 
        ' itemSearch
        ' 
        itemSearch.Location = New Point(885, 141)
        itemSearch.Name = "itemSearch"
        itemSearch.Size = New Size(123, 23)
        itemSearch.TabIndex = 6
        ' 
        ' itemCombos
        ' 
        itemCombos.DropDownStyle = ComboBoxStyle.DropDownList
        itemCombos.FormattingEnabled = True
        itemCombos.Location = New Point(885, 160)
        itemCombos.Name = "itemCombos"
        itemCombos.Size = New Size(123, 23)
        itemCombos.TabIndex = 7
        ' 
        ' qtyInput
        ' 
        qtyInput.Location = New Point(1026, 141)
        qtyInput.Name = "qtyInput"
        qtyInput.Size = New Size(100, 23)
        qtyInput.TabIndex = 8
        ' 
        ' buttonSubmit
        ' 
        buttonSubmit.Location = New Point(885, 202)
        buttonSubmit.Name = "buttonSubmit"
        buttonSubmit.Size = New Size(241, 23)
        buttonSubmit.TabIndex = 9
        buttonSubmit.Text = "Submit"
        buttonSubmit.UseVisualStyleBackColor = True
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' itemGrid
        ' 
        itemGrid.AllowUserToAddRows = False
        itemGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        itemGrid.Columns.AddRange(New DataGridViewColumn() {Column1, nama_barang, quantity, harga})
        itemGrid.Location = New Point(12, 49)
        itemGrid.Name = "itemGrid"
        itemGrid.Size = New Size(843, 363)
        itemGrid.TabIndex = 11
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
        ' subInput
        ' 
        subInput.Enabled = False
        subInput.Location = New Point(232, 435)
        subInput.Name = "subInput"
        subInput.Size = New Size(136, 23)
        subInput.TabIndex = 12
        subInput.Text = "Sub Total"' 
        ' totalInput
        ' 
        totalInput.Enabled = False
        totalInput.Location = New Point(232, 475)
        totalInput.Name = "totalInput"
        totalInput.Size = New Size(136, 23)
        totalInput.TabIndex = 13
        totalInput.Text = "Total"' 
        ' totalBarangInput
        ' 
        totalBarangInput.Enabled = False
        totalBarangInput.Location = New Point(102, 432)
        totalBarangInput.Name = "totalBarangInput"
        totalBarangInput.Size = New Size(41, 23)
        totalBarangInput.TabIndex = 14
        totalBarangInput.Text = "0"' 
        ' diskonInput
        ' 
        diskonInput.Location = New Point(102, 475)
        diskonInput.Name = "diskonInput"
        diskonInput.Size = New Size(41, 23)
        diskonInput.TabIndex = 15
        diskonInput.Text = "0%"' 
        ' printButton
        ' 
        printButton.Location = New Point(885, 364)
        printButton.Name = "printButton"
        printButton.Size = New Size(241, 23)
        printButton.TabIndex = 16
        printButton.Text = "Print Struk"
        printButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 416)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 435)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 18
        Label4.Text = "Total Barang"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 478)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 19
        Label5.Text = "Diskon"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(171, 438)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 20
        Label6.Text = "Sub Total"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(171, 478)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 21
        Label7.Text = "Total"' 
        ' userKasir
        ' 
        userKasir.Location = New Point(716, 427)
        userKasir.Name = "userKasir"
        userKasir.ReadOnly = True
        userKasir.Size = New Size(139, 23)
        userKasir.TabIndex = 22
        ' 
        ' inputKasir
        ' 
        inputKasir.Location = New Point(716, 470)
        inputKasir.Name = "inputKasir"
        inputKasir.ReadOnly = True
        inputKasir.Size = New Size(139, 23)
        inputKasir.TabIndex = 23
        inputKasir.Text = "Main Register"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(652, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 24
        Label8.Text = "User Kasir"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(653, 474)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 25
        Label9.Text = "Kasir"' 
        ' tunaiInput
        ' 
        tunaiInput.Location = New Point(885, 258)
        tunaiInput.Name = "tunaiInput"
        tunaiInput.Size = New Size(241, 23)
        tunaiInput.TabIndex = 26
        ' 
        ' kembalianInput
        ' 
        kembalianInput.Location = New Point(885, 309)
        kembalianInput.Name = "kembalianInput"
        kembalianInput.ReadOnly = True
        kembalianInput.Size = New Size(241, 23)
        kembalianInput.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(885, 240)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 15)
        Label10.TabIndex = 28
        Label10.Text = "Tunai"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(884, 293)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 15)
        Label11.TabIndex = 29
        Label11.Text = "Kembalian"' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 522)
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
        Controls.Add(history)
        Controls.Add(akun)
        Controls.Add(barang)
        Controls.Add(Kasir)
        Name = "admin"
        Text = "admin"
        CType(itemGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Kasir As Button
    Friend WithEvents barang As Button
    Friend WithEvents akun As Button
    Friend WithEvents history As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents itemSearch As TextBox
    Friend WithEvents itemCombos As ComboBox
    Friend WithEvents qtyInput As TextBox
    Friend WithEvents buttonSubmit As Button
    Friend WithEvents buttonCreate As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents deleteItemButton As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents itemGrid As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents subInput As TextBox
    Friend WithEvents totalInput As TextBox
    Friend WithEvents diskonInput As TextBox
    Friend WithEvents totalBarangInput As TextBox
    Friend WithEvents printButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents userKasir As TextBox
    Friend WithEvents inputKasir As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tunaiInput As TextBox
    Friend WithEvents kembalianInput As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
End Class
