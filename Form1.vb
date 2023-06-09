Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Transactions
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports OfficeOpenXml
Imports System.IO
Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim sqlconn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlquery As String

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "tekkadan"
    Dim database As String = "office_supplies"
    Dim tableName As String = "office_supplies_price"
    Dim bindingSource As New BindingSource()
    Private Bitmap As Bitmap
    Private filePath As String = Path.Combine(Application.StartupPath, "requestNumber.txt")
    Public Shared BindingList1 As New BindingList(Of DataRow)

    Private Sub updatetable()
        sqlconn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        sqlconn.Open()
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandText = "Select Code, Part_number, Description, Unit from office_supplies.office_supplies_price LIMIT 1000"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlconn.Close()
        DataGridView1.DataSource = sqlDt
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
        sqlconn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
    + "password=" + password + ";" + "database=" + database

        sqlconn.Open()
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandText = "Select Code, Part_number, Description, Unit from office_supplies.office_supplies_price"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlconn.Close()
        bindingSource.DataSource = sqlDt
        DataGridView1.DataSource = bindingSource
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 180
        DataGridView1.Columns(3).Width = 120
        DataGridView1.AllowUserToAddRows = False

        DataGridView2.Columns.Add("Date", "Date")
        DataGridView2.Columns.Add("RS_Number", "RS_Number")
        DataGridView2.Columns.Add("Requested_By", "Requested_By")
        DataGridView2.Columns.Add("Line", "Line")
        DataGridView2.Columns.Add("Description", "Description")
        DataGridView2.Columns.Add("Part_Number", "Part_Number")
        DataGridView2.Columns.Add("Unit", "Unit")
        DataGridView2.Columns.Add("Quantity", "Quantity")
        DataGridView2.Columns(0).Width = 150
        DataGridView2.Columns(1).Width = 110
        DataGridView2.Columns(2).Width = 200
        DataGridView2.Columns(3).Width = 150
        DataGridView2.Columns(4).Width = 250
        DataGridView2.Columns(5).Width = 250
        DataGridView2.Columns(6).Width = 80
        DataGridView2.Columns(7).Width = 80
        DataGridView2.AllowUserToAddRows = False
        txtsearch.Focus()
        If File.Exists(filePath) Then
            ' If the file exists, read the request number from it.
            Dim text As String = File.ReadAllText(filePath)
            Dim number As Integer
            If Int32.TryParse(text, number) Then
                txtrs.Text = number.ToString()
            Else
                ' If the file doesn't contain a valid number, start from 1.
                txtrs.Text = "1"
            End If
        Else
            ' If the file doesn't exist, start from 1.
            txtrs.Text = "1"
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtsearch.Text = ""
        txtline.Text = ""
        txtrqty.Text = ""
        txtrby.Text = ""
        txtrs.Text = ""

    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        bindingSource.Filter = "Convert(Code, 'System.String') LIKE '%" & txtsearch.Text & "%' OR Part_number LIKE '%" & txtsearch.Text & "%'"

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ' Check if all TextBoxes are filled
        If String.IsNullOrWhiteSpace(txtrs.Text) OrElse String.IsNullOrWhiteSpace(txtrby.Text) OrElse String.IsNullOrWhiteSpace(txtline.Text) OrElse String.IsNullOrWhiteSpace(txtrqty.Text) Then
            MessageBox.Show("Please fill all information before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As String() = New String() {datepicker.Value.ToShortDateString(), txtrs.Text, txtrby.Text, txtline.Text, DataGridView1.SelectedRows(0).Cells(2).Value.ToString(), DataGridView1.SelectedRows(0).Cells(1).Value.ToString(), DataGridView1.SelectedRows(0).Cells(3).Value.ToString(), txtrqty.Text}
            DataGridView2.Rows.Add(row)
            txtrqty.Text = ""
        Else
            MessageBox.Show("Please select a item in the material list first.")
        End If
    End Sub
    Private Sub txtrqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrqty.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtrs_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrs.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtline.Focus()
        End If
    End Sub

    Private Sub txtline_KeyDown(sender As Object, e As KeyEventArgs) Handles txtline.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrqty.Focus()
        End If
    End Sub
    Private Sub txtrqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrqty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrby.Focus()
        End If
    End Sub
    Private Sub txtrby_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrby.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmit.Focus()
        End If
    End Sub
    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtrs.Focus()
        End If
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView2.SelectedRows
                If Not row.IsNewRow Then
                    DataGridView2.Rows.Remove(row)
                End If
            Next
        Else
            MessageBox.Show("Please select first the entry you want to remove.")
        End If
    End Sub

    Private Sub btnsubmit2_Click(sender As Object, e As EventArgs) Handles btnsubmit2.Click
        Dim number As Integer = Int32.Parse(txtrs.Text)
        number += 1
        File.WriteAllText(filePath, number.ToString())

        ' Update the TextBox with the new request number.
        txtrs.Text = number.ToString()

        sqlconn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
    + "password=" + password + ";" + "database=" + database

        sqlconn.Open()
        sqlCmd.Connection = sqlconn
        Dim transaction As MySqlTransaction = sqlconn.BeginTransaction()
        sqlCmd.Transaction = transaction

        Try
            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow Then
                    Dim dateValue As Date = Date.Parse(row.Cells("Date").Value.ToString())
                    Dim rsNo As String = row.Cells("RS_Number").Value.ToString()
                    Dim requestedBy As String = row.Cells("Requested_By").Value.ToString()
                    Dim line As String = row.Cells("Line").Value.ToString()
                    Dim description As String = row.Cells("Description").Value.ToString()
                    Dim partNumber As String = row.Cells("Part_Number").Value.ToString()
                    Dim unit As String = row.Cells("Unit").Value.ToString()
                    Dim qty As String = row.Cells("Quantity").Value.ToString()

                    sqlCmd.CommandText = "INSERT INTO `office_supplies`.`request_supplies` (`Date`, `Rs_no.`, `Requested_by`, `Line`, `Description`, `Part_number`, `Unit`, `Qty`) " _
    + "VALUES (@date, @rsNo, @requestedBy, @line, @description, @partNumber, @unit, @qty)"

                    sqlCmd.Parameters.AddWithValue("@date", dateValue.ToString("yyyy-MM-dd"))
                    sqlCmd.Parameters.AddWithValue("@rsNo", rsNo)
                    sqlCmd.Parameters.AddWithValue("@requestedBy", requestedBy)
                    sqlCmd.Parameters.AddWithValue("@line", line)
                    sqlCmd.Parameters.AddWithValue("@description", description)
                    sqlCmd.Parameters.AddWithValue("@partNumber", partNumber)
                    sqlCmd.Parameters.AddWithValue("@unit", unit)
                    sqlCmd.Parameters.AddWithValue("@qty", qty)

                    sqlCmd.ExecuteNonQuery()

                    ' Clear the parameters so they can be used again
                    sqlCmd.Parameters.Clear()

                End If
            Next

            transaction.Commit()
            MessageBox.Show("Your request has been submitted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView2.Rows.Clear()
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("An error occurred during submission. No data was inserted. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlconn.Close()
        End Try
    End Sub


End Class
