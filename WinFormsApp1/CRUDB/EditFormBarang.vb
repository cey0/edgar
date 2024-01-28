Imports MySql.Data.MySqlClient

Public Class EditFormBarang

    ' Define properties to hold the data
    Private Property Id As Integer
    Private Property NamaBarang As String
    Private Property Stock As Integer
    Private Property Harga As Double

    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)

    ' Constructor to receive the data
    Public Sub New(id As Integer, namaBarang As String, stock As Integer, harga As Double)
        InitializeComponent()

        ' Save the data in properties
        Me.Id = id
        Me.NamaBarang = namaBarang
        Me.Stock = stock
        Me.Harga = harga

        ' Populate the form controls with the data
        barangInput.Text = namaBarang
        stockInput.Text = stock.ToString()
        hargaInput.Text = harga.ToString()
    End Sub
    Private Sub EditFormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs)
        Try


            Dim query = "UPDATE barang SET nama_barang=@NM, harga=@HG, stock=@ST WHERE id_barang=@id"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@NM", barangInput.Text)
            cmd.Parameters.AddWithValue("@HG", stockInput.Text)
            cmd.Parameters.AddWithValue("@ST", hargaInput.Text)
            cmd.Parameters.AddWithValue("@ID", Id)
            c.Open()
            cmd.ExecuteNonQuery()
            MsgBox("berhasil update")


        Catch ex As Exception
            MsgBox("gabisa bang:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub

    Private Sub submitButton_Click_1(sender As Object, e As EventArgs) Handles submitButton.Click

    End Sub
End Class