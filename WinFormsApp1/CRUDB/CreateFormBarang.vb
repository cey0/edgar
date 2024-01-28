Imports MySql.Data.MySqlClient

Public Class CreateFormUsers


    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)



    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Try
            c.Open()
            Dim query As String = "INSERT INTO barang (nama_barang,harga,stock) VALUES(@NM,@PR,@ST)"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@NM", barangInput.Text)
            cmd.Parameters.AddWithValue("@PR", stockInput.Text)
            cmd.Parameters.AddWithValue("@ST", hargaInput.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully inserted")
            Dim barang As New barang()
            Me.Hide()
            barang.Show()


        Catch ex As Exception
            MsgBox("tidak berhasil:" & ex.Message)

        Finally
            c.Close()
        End Try
    End Sub
End Class