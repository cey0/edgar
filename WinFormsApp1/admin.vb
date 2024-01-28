Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports System.Text
Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class admin
    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)
    Dim userID As Integer = Globals.loggedInUserID


    Dim originalItems As New List(Of Object)

    Private Sub UpdateStockWithStoredProc(itemIdsString As String, quantitiesBoughtString As String)
        Try
            Using c As New MySqlConnection(cs)
                c.Open()

                ' Your SQL query to call the stored procedure
                Dim query As String = "CALL UpdateStockForBarang(@itemIds, @quantitiesBought)"

                Using cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@itemIds", itemIdsString)
                    cmd.Parameters.AddWithValue("@quantitiesBought", quantitiesBoughtString)

                    ' Execute the stored procedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that might occur during the process
            MessageBox.Show("Error updating stock with stored procedure: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ItemCombo()
        Dim q As String = "SELECT * FROM barang"
        Using c As New MySqlConnection(cs)
            Using cm As New MySqlCommand(q, c)
                Try
                    c.Open()

                    Using r As MySqlDataReader = cm.ExecuteReader()
                        itemCombos.Items.Clear()
                        While r.Read()
                            Dim itemName As String = r("nama_barang").ToString()
                            Dim stock As Integer = Convert.ToInt32(r("stock"))

                            If stock > 0 Then
                                itemCombos.Items.Add(itemName)
                            Else
                                ' Disable the item with 0 stock
                                itemCombos.Items.Add($"[{itemName} - Out of Stock]")
                            End If

                            originalItems.Add(itemName)
                        End While
                    End Using

                    If itemCombos.Items.Count > 0 Then
                        itemCombos.SelectedIndex = 0
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error fetching data from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    ' Function to get the combined item ID and generate JSON representation
    Private Function GetCombinedItemIDsAndJSON() As String
        Dim itemsList As New List(Of ItemInfo)

        For Each row As DataGridViewRow In itemGrid.Rows
            If Not row.IsNewRow Then
                Dim itemName As String = row.Cells("nama_barang").Value.ToString()
                Dim idBarang As Integer = NameToIdBarang(itemName)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)

                ' Create ItemInfo object for JSON
                Dim itemInfo As New ItemInfo() With {
                    .ItemName = itemName,
                    .ItemID = idBarang,
                    .Quantity = quantity
                }
                itemsList.Add(itemInfo)
            End If
        Next

        ' Populate arrays with id_barang and quantity values
        Dim idBarangArray As New List(Of Integer)
        Dim quantityArray As New List(Of Integer)

        For Each row As DataGridViewRow In itemGrid.Rows
            If Not row.IsNewRow Then
                Dim idBarang As Integer = NameToIdBarang(row.Cells("nama_barang").Value.ToString())
                Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)
                idBarangArray.Add(idBarang)
                quantityArray.Add(quantity)
            End If
        Next

        ' Return the generated JSON string
        Return JsonConvert.SerializeObject(itemsList)
    End Function

    ' Class to represent item information for JSON
    Private Class ItemInfo
        Public Property ItemName As String
        Public Property ItemID As Integer
        Public Property Quantity As Integer
    End Class


    Private Function NameToIdBarang(NamaBarang As String) As Integer
        Dim idBarang As Integer = -1

        Try
            Dim q As String = "SELECT id_barang From barang where nama_barang = @nama"
            Dim cm As New MySqlCommand(q, c)
            cm.Parameters.AddWithValue("@nama", NamaBarang)

            c.Open()
            idBarang = Convert.ToInt32(cm.ExecuteScalar())

        Catch ex As Exception
            MsgBox("error geting id_user: " & ex.Message)
        Finally
            c.Close()

        End Try
        Return idBarang

    End Function



    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Debugging statement
            Console.WriteLine($"Logged In User ID: {Globals.loggedInUserID}")

            ItemCombo()

            Dim q As String = "SELECT * FROM users WHERE id = @id"
            Using cm As New MySqlCommand(q, c)
                cm.Parameters.AddWithValue("@id", userID)

                Try
                    c.Open()
                    Dim r As MySqlDataReader = cm.ExecuteReader

                    If r.Read() Then
                        ' Debugging statement
                        Console.WriteLine($"User Name from Database: {r("name")}")

                        userKasir.Text = Convert.ToString(r("name"))
                    Else
                        ' Debugging statement
                        Console.WriteLine("No data found for the user.")
                    End If
                Catch ex As Exception
                    ' Debugging statement
                    Console.WriteLine($"Error: {ex.Message}")
                End Try
            End Using
        Catch ex As Exception
            ' Debugging statement
            Console.WriteLine($"Error in admin_Load: {ex.Message}")
        Finally
            c.Close()
        End Try
    End Sub




    Private Sub CalculateTotalQuantity()
        Dim totalQuantity As Integer = 0

        For Each row As DataGridViewRow In itemGrid.Rows
            If Not row.IsNewRow Then ' Skip the new row at the end of DataGridView
                totalQuantity += Convert.ToInt32(row.Cells("quantity").Value) ' Replace "QuantityColumn" with the actual column name
            End If
        Next

        totalBarangInput.Text = totalQuantity.ToString()
    End Sub

    Private Sub CalculateTotalHarga()
        Dim totalQuantity As Decimal = 0
        Dim diskonInputText As String = diskonInput.Text.TrimEnd("%"c)
        Dim diskon As Decimal
        Dim total As Decimal

        If Decimal.TryParse(diskonInputText, diskon) Then
            diskon /= 100
        Else
            MessageBox.Show("Invalid diskon value. Please enter a valid percentage.")
            Return
        End If

        For Each row As DataGridViewRow In itemGrid.Rows
            If Not row.IsNewRow Then
                totalQuantity += Convert.ToDecimal(row.Cells("harga").Value)
            End If
        Next

        subInput.Text = totalQuantity.ToString()

        If diskon = 0 Then
            total = totalQuantity
        Else
            total = totalQuantity - (totalQuantity * diskon)
        End If

        totalInput.Text = total.ToString()
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click, buttonDelete.Click

    End Sub

    Private Sub deleteItemButton_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub RecalculateTotalPrice()
        Dim price As Decimal
        Dim qty As Integer
        Dim total As Decimal
        Dim namaBarang As String = itemCombos.Text
        Dim diskonInputText As String = diskonInput.Text.TrimEnd("%"c)
        Dim diskon As Decimal

        If Decimal.TryParse(diskonInputText, diskon) Then
            diskon /= 100
        Else
            MessageBox.Show("Invalid diskon value. Please enter a valid percentage.")
            Return
        End If

        Dim idBarang As Integer = NameToIdBarang(namaBarang)

        Dim q As String = "SELECT * FROM barang WHERE id_barang = @id_barang"
        Using cm As New MySqlCommand(q, c)
            cm.Parameters.AddWithValue("@id_barang", idBarang)

            Try
                c.Open()
                Dim r As MySqlDataReader = cm.ExecuteReader

                If r.Read() Then
                    Dim harga As Decimal = Convert.ToDecimal(r("harga"))
                    Dim subtotal As Decimal = Convert.ToDecimal(subInput.Text)

                    qty = Convert.ToInt32(qtyInput.Text)
                    price = harga

                    Dim totalHargaBarang As Decimal = qty * harga
                    If diskon = 0 Then
                        total = subtotal
                    Else
                        total = subtotal - (subtotal * diskon)
                    End If
                    totalInput.Text = total.ToString()
                Else

                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                c.Close()
            End Try
        End Using
    End Sub


    Private Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim price As Decimal
        Dim qty As Integer
        Dim namaBarang As String = itemCombos.Text
        Dim diskonInputText As String = diskonInput.Text.TrimEnd("%"c)
        Dim diskon As Decimal



        If Decimal.TryParse(diskonInputText, diskon) Then
            diskon /= 100
        Else
            MessageBox.Show("Invalid diskon value. Please enter a valid percentage.")
            Return
        End If

        Dim no As Integer = itemGrid.Rows.Count + 1 ' Increment based on the existing rows

        If String.IsNullOrWhiteSpace(qtyInput.Text) Then
            MessageBox.Show("Quantity is zero or empty")
            Return
        End If

        Dim idBarang As Integer = NameToIdBarang(namaBarang)

        ' Check if the selected item is disabled (stock is 0)
        If itemCombos.Enabled = False Then
            MessageBox.Show("Selected item is out of stock.")
            Return
        End If

        ' Check the stock of the selected item
        Dim stock As Integer = GetStockByIdBarang(idBarang)

        If Not Integer.TryParse(qtyInput.Text, qty) Then
            MessageBox.Show("Invalid quantity input. Please enter a valid number.")
            Return
        End If

        If qty > stock Then
            MessageBox.Show("Quantity exceeds available stock. Please enter a valid quantity.")
            Return
        End If

        Dim q As String = "SELECT * FROM barang WHERE id_barang = @id_barang"
        Using cm As New MySqlCommand(q, c)
            cm.Parameters.AddWithValue("@id_barang", idBarang)

            Try
                c.Open()
                Dim r As MySqlDataReader = cm.ExecuteReader

                If r.Read() Then
                    Dim harga As Decimal = Convert.ToDecimal(r("harga"))

                    qty = Convert.ToInt32(qtyInput.Text)
                    price = harga

                    Dim totalHargaBarang As Decimal = qty * harga

                    itemGrid.Rows.Add(no, namaBarang, qty, totalHargaBarang)
                    CalculateTotalHarga()
                    CalculateTotalQuantity()
                Else
                    MessageBox.Show("Item not found")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                c.Close()
            End Try
        End Using
    End Sub


    Private Sub itemCombos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemCombos.SelectedIndexChanged
        ' Check and disable the ComboBox item if the stock is 0
        Dim idBarang As Integer = NameToIdBarang(itemCombos.Text)
        Dim stock As Integer = GetStockByIdBarang(idBarang)


    End Sub

    Private Sub itemSearch_TextChanged(sender As Object, e As EventArgs) Handles itemSearch.TextChanged
        ' Get the search text from the TextBox
        Dim searchText As String = itemSearch.Text.Trim().ToLower()

        ' Clear existing items in the ComboBox
        itemCombos.Items.Clear()

        ' If the search text is empty, fill the ComboBox with all original items
        If String.IsNullOrEmpty(searchText) Then
            For Each originalItem In originalItems
                itemCombos.Items.Add(originalItem)
            Next
        Else
            ' Filter the original items based on the search text and add matching items to the ComboBox
            For Each originalItem In originalItems
                Dim itemName As String = originalItem.ToString().ToLower()
                If itemName.StartsWith(searchText) Then
                    itemCombos.Items.Add(originalItem)
                End If
            Next
        End If

        ' Set the first item as the default selected item
        If itemCombos.Items.Count > 0 Then
            itemCombos.SelectedIndex = 0
        End If
    End Sub

    Private Sub diskonInput_TextChanged(sender As Object, e As EventArgs) Handles totalBarangInput.TextChanged

    End Sub

    Private Sub diskonInput_TextChanged_1(sender As Object, e As EventArgs) Handles diskonInput.TextChanged
        RecalculateTotalPrice()
    End Sub

    Private Sub itemGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles itemGrid.CellContentClick

    End Sub


    ' Function to get the stock of an item by its ID
    Private Function GetStockByIdBarang(idBarang As Integer) As Integer
        Dim stock As Integer = 0
        Try
            Dim q As String = "SELECT stock FROM barang WHERE id_barang = @id_barang"
            Using cm As New MySqlCommand(q, c)
                cm.Parameters.AddWithValue("@id_barang", idBarang)
                c.Open()
                stock = Convert.ToInt32(cm.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching stock: " & ex.Message)
        Finally
            c.Close()
        End Try
        Return stock
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Function GetCombinedItemID() As String
        Dim combinedItemID As New StringBuilder()

        For Each row As DataGridViewRow In itemGrid.Rows
            If Not row.IsNewRow Then
                Dim itemName As String = row.Cells("nama_barang").Value.ToString()
                Dim idBarang As Integer = NameToIdBarang(itemName)

                ' Combine item IDs into a string with comma separator
                combinedItemID.Append(idBarang.ToString()).Append(",")
            End If
        Next

        ' Remove the trailing comma if there are items
        If combinedItemID.Length > 0 Then
            combinedItemID.Length -= 1
        End If

        ' Return the combined item ID
        Return combinedItemID.ToString()
    End Function
    Dim WithEvents PD As New PrintDocument
    Dim ppd As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub pd_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 600, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        Try

            ' Your existing code to get user and item details
            Dim userID As Integer = Globals.loggedInUserID
            Dim itemJSON As String = GetCombinedItemIDsAndJSON()
            Dim totalBarang As Integer = Integer.Parse(totalBarangInput.Text)
            Dim diskon As Decimal = Decimal.Parse(diskonInput.Text.TrimEnd("%"c))
            Dim subTotal As Decimal = Decimal.Parse(subInput.Text)
            Dim total As Decimal = Decimal.Parse(totalInput.Text)

            ' Populate arrays with id_barang and quantity values
            Dim idBarangArray As New List(Of Integer)
            Dim quantityArray As New List(Of Integer)

            For Each row As DataGridViewRow In itemGrid.Rows
                If Not row.IsNewRow Then
                    Dim idBarang As Integer = NameToIdBarang(row.Cells("nama_barang").Value.ToString())
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)
                    idBarangArray.Add(idBarang)
                    quantityArray.Add(quantity)
                End If
            Next

            UpdateStockWithStoredProc(GetCombinedItemID(), String.Join(",", quantityArray))


            ' Assuming you have tunaiInput and kembalianInput TextBox controls
            Dim tunai As Decimal = Decimal.Parse(tunaiInput.Text)
            Dim kembalian As Decimal = Decimal.Parse(kembalianInput.Text)

            Using c As New MySqlConnection(cs)
                c.Open()

                ' Your SQL query to insert data into the 'struk' table
                Dim query As String = "INSERT INTO struk (id, items, id_barang, jumlah_barang, diskon, total, jumlah_total, tunai, kembalian) " &
                                      "VALUES (@userID, @items, @idBarang, @jumlahBarang, @diskon, @subtotal, @jumlahTotal, @tunai, @kembalian)"

                Using cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@userID", userID)
                    cmd.Parameters.AddWithValue("@items", itemJSON)
                    cmd.Parameters.AddWithValue("@idBarang", String.Join(",", idBarangArray))
                    cmd.Parameters.AddWithValue("@jumlahBarang", totalBarang)
                    cmd.Parameters.AddWithValue("@diskon", diskon)
                    cmd.Parameters.AddWithValue("@subtotal", subTotal)
                    cmd.Parameters.AddWithValue("@jumlahTotal", total)
                    cmd.Parameters.AddWithValue("@tunai", tunai)
                    cmd.Parameters.AddWithValue("@kembalian", kembalian)

                    ' Execute the query
                    cmd.ExecuteNonQuery()



                    ' Optionally, you can display a success message
                    MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            End Using
            changelongpaper()
            ppd.Document = PD
            ppd.ShowDialog()
            'PD.Print()  'Direct Print
        Catch ex As Exception
            ' Handle any exceptions that might occur during the process
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = itemGrid.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Private Function FindRowByItemName(dataGridView As DataGridView, itemName As String) As DataGridViewRow
        For Each row As DataGridViewRow In dataGridView.Rows
            If Not row.IsNewRow Then
                Dim rowItemName As String = row.Cells("nama_barang").Value.ToString()
                If rowItemName = itemName Then
                    Return row
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub tunaiInput_TextChanged(sender As Object, e As EventArgs) Handles tunaiInput.TextChanged
        Try
            ' Check if the tunaiInput is not empty
            If Not String.IsNullOrEmpty(tunaiInput.Text) Then
                ' Parse the values from totalInput and tunaiInput
                Dim total As Decimal = Decimal.Parse(totalInput.Text)
                Dim tunai As Decimal = Decimal.Parse(tunaiInput.Text)

                ' Calculate kembalian and update kembalianInput
                Dim kembalian As Decimal = tunai - total
                kembalianInput.Text = kembalian.ToString()
            Else
                ' If tunaiInput is empty, set kembalianInput to 0
                kembalianInput.Text = "0"
            End If
        Catch ex As Exception
            ' Handle any exceptions that might occur during the process
            MessageBox.Show("Error calculating kembalian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub barang_Click(sender As Object, e As EventArgs) Handles barang.Click
        Dim barang As New barang()

        Me.Hide()
        barang.Show()

    End Sub

    Private Sub akun_Click(sender As Object, e As EventArgs) Handles akun.Click
        Dim akun As New akun()
        Me.Hide()
        akun.Show()

    End Sub

    Private Sub history_Click(sender As Object, e As EventArgs) Handles history.Click
        ' Dim history As New history()
        Me.Hide()
        history.Show()
    End Sub
    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        'menyimpan font kedalam variabel
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width - PD.DefaultPageSettings.Margins.Right

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "*******************************************************************************************************************************"
        Dim tall As Integer = 10

        ' Header
        e.Graphics.DrawString("GUSHOP", f14, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("PARUNG", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("oleh: " & userKasir.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, tall, center)

        ' DetailHeader
        tall += 20
        e.Graphics.DrawString("Barang", f8, Brushes.Black, leftmargin, tall)
        e.Graphics.DrawString("Harga", f8, Brushes.Black, leftmargin + 80, tall)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin + 50, tall, right)
        tall += 20
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, tall, center)


        ' Content
        For Each erow As DataGridViewRow In itemGrid.Rows
            tall += 20
            ' Adjust the following line based on your DataGridView columns
            e.Graphics.DrawString($"{erow.Cells("nama_barang").Value}", f8, Brushes.Black, leftmargin, tall)
            e.Graphics.DrawString($"{erow.Cells("quantity").Value}", f8, Brushes.Black, leftmargin + 80, tall)
            e.Graphics.DrawString($"{erow.Cells("harga").Value}", f8, Brushes.Black, leftmargin + 300, tall)
        Next
        tall += 20
        e.Graphics.DrawString("------------------------------------", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("Total Pembelian: " & totalBarangInput.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("subtotal: " & subInput.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("diskon: " & diskonInput.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("------------------------------------", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("total: " & totalInput.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("tunai: " & tunaiInput.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("kembali: " & kembalianInput.Text, f10, Brushes.Black, centermargin, tall, center)


    End Sub


End Class
