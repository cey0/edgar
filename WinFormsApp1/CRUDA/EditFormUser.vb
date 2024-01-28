Imports MySql.Data.MySqlClient

Public Class EditFormUser

    ' Define properties to hold the data
    Private Property Id As Integer
    Private Overloads Property name As String
    Private Property password As String

    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)

    ' Constructor to receive the data
    Public Sub New(id As Integer, name As String, password As String)
        InitializeComponent()

        ' Save the data in properties
        Me.Id = id
        Me.name = name
        Me.password = password

        ' Populate the form controls with the data
        userInput.Text = name
        passwordInput.Text = password.ToString()
    End Sub
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Try
            Dim query = "UPDATE users SET name=@NM, password=@PW WHERE id=@id"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@NM", userInput.Text)
            cmd.Parameters.AddWithValue("@PW", passwordInput.Text)
            cmd.Parameters.AddWithValue("@id", Id)

            c.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Updated")


        Catch ex As Exception
            MsgBox("Cant Do That:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub
End Class