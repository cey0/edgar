Imports MySql.Data.MySqlClient

Public Class CreateFormUser

    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Try
            c.Open()
            Dim query As String = "INSERT INTO users (name,password) VALUES(@NM,@PW)"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@NM", userInput.Text)
            cmd.Parameters.AddWithValue("@PR", passwordInput.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully inserted")
            Dim barang As New barang()
            Me.Hide()
            barang.Show()


        Catch ex As Exception
            MsgBox("Did not work:" & ex.Message)

        Finally
            c.Close()
        End Try
    End Sub
End Class