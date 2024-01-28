Imports MySql.Data.MySqlClient
Public Class barang
    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)
    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' SQL query to retrieve data
        Dim query As String = "SELECT id_barang,nama_barang,stock,harga FROM barang"

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
        Dim query As String = "SELECT id_barang,nama_barang,stock,harga FROM barang"

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
            Dim rs As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Get data from the selected row
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id_barang").Value)
            Dim namaBarang As String = Convert.ToString(selectedRow.Cells("nama_barang").Value)
            Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value)
            Dim harga As Double = Convert.ToDouble(selectedRow.Cells("harga").Value)
            If System.Windows.Forms.DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM barang WHERE id_barang=@ID"
                    Dim cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@ID", id)

                    c.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil menghapus data")
                    RefreshData()
                Catch ex As MySqlException
                    MsgBox("Error deleting data: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    c.Close()
                End Try

            Else
                MsgBox("Silakan pilih baris yang ingin dihapus.")
            End If
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        ' Check if any row is selected
        If tableBarang.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = tableBarang.SelectedRows(0)

            ' Get data from the selected row
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id_barang").Value)
            Dim namaBarang As String = Convert.ToString(selectedRow.Cells("nama_barang").Value)
            Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("stock").Value)
            Dim harga As Double = Convert.ToDouble(selectedRow.Cells("harga").Value)

            ' Open the EditForm and pass the data
            Me.Hide()
            Dim editForm As New EditFormBarang(id, namaBarang, stock, harga)
            editForm.ShowDialog()
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub createButton_Click(sender As Object, e As EventArgs) Handles createButton.Click
        Me.Hide()
        Dim create As New CreateFormUsers()
        create.Show()

    End Sub

    Private Sub tableBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableBarang.CellContentClick

    End Sub

    Private Sub akun_Click(sender As Object, e As EventArgs) Handles akun.Click
        Me.Hide()
        Dim akun As New akun()
        akun.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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