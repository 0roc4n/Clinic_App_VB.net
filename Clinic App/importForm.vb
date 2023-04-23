Imports MySql.Data.MySqlClient
Imports ShowMessage
Public Class ImportPatientForm
    Private Sub ImportPatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function savedata(sql As String)
        Dim mysqlConn As MySqlConnection = New MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=clinic_db")
        Dim mysqlcmd As MySqlCommand
        Dim mysqlRes As Boolean

        Try
            mysqlConn.Open()
            mysqlcmd = New MySqlCommand
            With mysqlcmd
                .Connection = mysqlConn
                .CommandText = sql
                mysqlRes = .ExecuteNonQuery
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Close()
        End Try
        Return mysqlRes
    End Function

    Private Sub brwsFile_Click(sender As Object, e As EventArgs) Handles brwsFile.Click
        Dim openFileDialog As New OpenFileDialog
        Dim conn As OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim dataAdapter As New OleDb.OleDbDataAdapter
        Dim dataTable As New DataTable

        Try
            With openFileDialog
                .Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import Data From Excel File"

                If openFileDialog.ShowDialog = DialogResult.OK Then
                    txtFileLoc.Text = openFileDialog.FileName
                    conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & IO.Path.GetDirectoryName(txtFileLoc.Text) & ";Extended Properties='text;HDR=No;FMT=Delimited'")

                    conn.Open()
                    With cmd
                        .Connection = conn
                        .CommandText = "SELECT * FROM [" & IO.Path.GetFileName(txtFileLoc.Text) & "]"

                    End With
                    dataAdapter.SelectCommand = cmd
                    dataAdapter.Fill(dataTable)
                    imprtDGW.DataSource = dataTable

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub upFileBtn_Click(sender As Object, e As EventArgs) Handles upFileBtn.Click
        Dim conn As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & IO.Path.GetDirectoryName(txtFileLoc.Text) & ";Extended Properties='text;HDR=No;FMT=Delimited'")
        Dim cmd As New OleDb.OleDbCommand
        Dim dataAdapt As New OleDb.OleDbDataAdapter
        Dim dTable As New DataTable
        Dim result As Boolean
        Dim sql As String

        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = "SELECT * FROM [" & IO.Path.GetFileName(txtFileLoc.Text) & "]"

            End With
            dataAdapt.SelectCommand = cmd
            dataAdapt.Fill(dTable)



            For Each r As DataRow In dTable.Rows
                sql = "INSERT INTO patients_tb(fname, lname, patientType, age, address) values('" & r(0).ToString & "', '" & r(1).ToString & "', '" & r(2).ToString & "', '" & r(3).ToString & "', '" & r(4).ToString & "')"
                result = savedata(sql)
                If result Then
                    ProgStat.Start()
                End If



            Next
        Catch ex As Exception
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub impProgBar_ValueChanged(sender As Object, e As EventArgs) Handles impProgBar.ValueChanged
    End Sub

    Private Sub ProgStat_Tick(sender As Object, e As EventArgs) Handles ProgStat.Tick
        If impProgBar.Value = 100 Then
            ProgStat.Stop()
            'mss
            MsgShow("Data Successfully Imported", MsgType.Success, MsgLanguage.English)

            impProgBar.Value = 0
        Else
            impProgBar.Value += 1
        End If
    End Sub
End Class