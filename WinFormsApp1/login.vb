Imports MySql.Data.MySqlClient


Public Enum Role
    admin
    kasir
End Enum

Public Class login
    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"


    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim name As String = inputName.Text
        Dim password As String = inputPassword.Text

        If Authenticate(name, password, Role.admin) Then
            MessageBox.Show("Login Successful")
            Globals.loggedInUserID = GetUserID(name, password)
            OpenAdmin()
        ElseIf Authenticate(name, password, Role.kasir) Then
            MessageBox.Show("Login Successful")
            Globals.loggedInUserID = GetUserID(name, password)
            OpenKasir()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub
    Private Function GetUserID(name As String, password As String) As Integer
        Using c As New MySqlConnection(cs)
            Using q As New MySqlCommand("SELECT id FROM users WHERE name=@name AND password=@password", c)
                q.Parameters.AddWithValue("@name", name)
                q.Parameters.AddWithValue("@password", password)

                Try
                    c.Open()
                    Return Convert.ToInt32(q.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error retrieving user ID: " & ex.Message)
                    Return -1
                End Try
            End Using
        End Using
    End Function
    Private Sub OpenAdmin()
        Dim admin As New admin()
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub OpenKasir()
        Dim kasir As New kasir()
        Me.Hide()
        kasir.Show()
    End Sub
    Private Function Authenticate(name As String, password As String, role As Role) As Boolean
        Using c As New MySqlConnection(cs)
            Using q As New MySqlCommand("SELECT COUNT(*) FROM users WHERE name=@name AND password=@password AND level=@role", c)
                q.Parameters.AddWithValue("@name", name)
                q.Parameters.AddWithValue("@password", password)
                q.Parameters.AddWithValue("@role", role.ToString())

                Try
                    c.Open()

                    ' Debugging statements
                    Console.WriteLine("Generated SQL Query: " & q.CommandText)
                    Console.WriteLine("Username Parameter: " & q.Parameters("@name").Value)
                    Console.WriteLine("Password Parameter: " & q.Parameters("@password").Value)
                    Console.WriteLine("Role Parameter: " & q.Parameters("@role").Value)

                    Dim rs As Integer = Convert.ToInt32(q.ExecuteScalar())
                    Return rs > 0
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function
End Class
