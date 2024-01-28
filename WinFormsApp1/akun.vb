Imports MySql.Data.MySqlClient

Public Class akun
    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)
    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' SQL query to retrieve data
        Dim query As String = "SELECT id,name,password FROM users"

        ' Create a SqlConnection and a SqlDataAdapter
        Dim cm As New MySqlCommand(query, c)

        Dim adapter As New MySqlDataAdapter(cm)
        ' Create a DataTable to hold the data
        Dim dataTable As New DataTable()


        ' Fill the DataTable with data from the database
        adapter.Fill(dataTable)

        ' Bind the DataTable to the DataGridView
        tableBarang.DataSource = dataTable
        tableBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill



    End Sub
    Private Sub RefreshData()
        ' SQL query to retrieve data
        Dim query As String = "SELECT id,name,password FROM users"

        ' Create a SqlConnection and a SqlDataAdapter
        Dim cm As New MySqlCommand(query, c)

        Dim adapter As New MySqlDataAdapter(cm)
        ' Create a DataTable to hold the data
        Dim dataTable As New DataTable()

        ' Fill the DataTable with data from the database
        adapter.Fill(dataTable)

        ' Bind the DataTable to the DataGridView
        tableBarang.DataSource = dataTable
    End Sub
    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If tableBarang.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = tableBarang.SelectedRows(0)
            Dim rs As DialogResult = MessageBox.Show("Are you sure you ant to delete this?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Get data from the selected row
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
            Dim namaBarang As String = Convert.ToString(selectedRow.Cells("name").Value)
            Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("password").Value)
            If System.Windows.Forms.DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM users WHERE id=@ID"
                    Dim cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@ID", id)

                    c.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfully deleted data")
                    RefreshData()
                Catch ex As MySqlException
                    MsgBox("Error deleting data: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    c.Close()
                End Try

            Else
                MsgBox("Please select a row to delete.")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If

    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        ' Check if any row is selected
        If tableBarang.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = tableBarang.SelectedRows(0)

            ' Get data from the selected row
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
            Dim name As String = Convert.ToString(selectedRow.Cells("name").Value)
            Dim password As Integer = Convert.ToInt32(selectedRow.Cells("password").Value)

            ' Open the EditForm and pass the data
            Me.Hide()
            Dim editForm As New EditFormUser(id, name, password)
            editForm.ShowDialog()
        Else
            MessageBox.Show("Please select a row to edit.")
        End If


    End Sub

    Private Sub createButton_Click(sender As Object, e As EventArgs) Handles createButton.Click
        Me.Hide()
        Dim create As New CreateFormUser()
        create.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim akun As New akun()
        akun.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim barang As New barang()
        barang.Show()
    End Sub

    Private Sub Kasir_Click(sender As Object, e As EventArgs) Handles Kasir.Click
        Me.Hide()
        Dim admin As New admin()
        admin.Show()
    End Sub
End Class