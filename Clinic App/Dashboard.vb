Imports MySql.Data.MySqlClient
Imports ShowMessage
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=clinic_db"

        Try
            TabControl1.Appearance = TabAppearance.FlatButtons
            TabControl1.ItemSize = New Size(0, 1)
            TabControl1.SizeMode = TabSizeMode.Fixed
        Catch ex As Exception

        End Try

        load_table()
        medload()
        patient()

    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        TabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub patientBtn_Click(sender As Object, e As EventArgs) Handles patientBtn.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
    Private Sub employeeBtn_Click(sender As Object, e As EventArgs) Handles employeeBtn.Click
        TabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub medInvBtn_Click(sender As Object, e As EventArgs) Handles medInvBtn.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub clinicEqBtn_Click(sender As Object, e As EventArgs) Handles clinicEqBtn.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click

        Try
            sql = "insert into admin_tb(username, password, adminName)values('" & unametxt.Text & "', '" & passTxt.Text & "', '" & nameTxt.Text & "')"
            connect()
            MsgShow("Admin Has Been Added", MsgType.Success, MsgLanguage.English)



        Catch ex As Exception
            MsgShow("Error Adding New Admin", MsgType.Critical, MsgLanguage.English)
        End Try
        conn.Close()

    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            If MsgShow("Sure to Update Admin?", MsgType.Question, MsgButton.YesNo, MsgLanguage.English) = DialogResult.Yes Then

                sql = "update clinic_db.admin_tb set username = '" & unametxt.Text & "',password ='" & passTxt.Text & "', adminName ='" & nameTxt.Text & "'  where adminID = '" & adminIDtxt.Text & "'"
                connect()
                MsgShow("Updated Successfuly", MsgType.Success, MsgLanguage.English)



            End If
        Catch ex As Exception
            MsgShow("Error Updating", MsgType.Information, MsgLanguage.English)






        End Try
        conn.Close()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        Try
            If MsgShow("Are You Sure To Delete Admin?", MsgType.Critical, MsgButton.YesNo, MsgLanguage.English) = DialogResult.Yes Then

                sql = "delete from clinic_db.admin_tb where adminID = '" & adminIDtxt.Text & "'"
                connect()
                MsgShow("Deleted Succesfull", MsgType.Success, MsgLanguage.English)


            End If
        Catch ex As Exception
            MsgShow("Error Deleting", MsgType.Exclamation, MsgLanguage.English)

        End Try
        conn.Close()
    End Sub

    Private Sub signoutBtn_Click(sender As Object, e As EventArgs) Handles signoutBtn.Click
        If MsgShow("Are you Sure You To Sign Out?", MsgType.Critical, MsgButton.YesNo, MsgLanguage.English) = DialogResult.Yes Then
            Me.Hide()
            conn.Close()
            Login.Show()
        End If
    End Sub

    Private Sub Guna2DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView2.CellContentClick


    End Sub
    Public Sub load_table()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query As String

        Try
            conn.Open()
            query = "Select adminId, username, adminName from admin_tb"
            cmd = New MySqlCommand(query, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            Guna2DataGridView2.DataSource = bSource
            SDA.Update(dbDataSet)
            dr.Close()


        Catch ex As Exception
            MsgShow("Error Loading Table", MsgType.Exclamation, MsgLanguage.English)

        End Try
        conn.Close()
    End Sub
    Private Sub refBtn_Click(sender As Object, e As EventArgs) Handles refBtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query As String

        Try
            conn.Open()
            query = "Select adminId, username, adminName from admin_tb"
            cmd = New MySqlCommand(query, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            Guna2DataGridView2.DataSource = bSource
            SDA.Update(dbDataSet)



        Catch ex As Exception
            MsgShow("Error Loading Table", MsgType.Exclamation, MsgLanguage.English)
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub Guna2HtmlLabel8_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel8.Click

    End Sub




    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles descriptTxt.TextChanged

    End Sub

    Public Sub medload()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query As String

        Try

            query = "Select inID, product_name, description, available, expiry_date from medInventory_tb"
            cmd = New MySqlCommand(query, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            Guna2DataGridView3.DataSource = bSource
            SDA.Update(dbDataSet)



        Catch ex As Exception
            'MsgShow("Error Loading Table", MsgType.Exclamation, MsgLanguage.English)
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub
    Private Sub medAddBtn_Click(sender As Object, e As EventArgs) Handles medAddBtn.Click
        Dim medAvail As Integer = CInt(medAvailTxt.Text)
        Try
            sql = "insert into medinventory_tb(product_name, description, available, expiry_date) values('" & medNameTxt.Text & "', '" & descriptTxt.Text & "', '" & medAvail & "', '" & medDateTxt.Text & "' )"
            connect()
            MsgShow("Medicine Added", MsgType.Success, MsgLanguage.English)


        Catch ex As Exception
            MsgShow("Error Adding Medicine", MsgType.Critical, MsgLanguage.English)
            MsgBox(ex.Message)



        End Try
        conn.Close()
    End Sub

    Private Sub medUpBtn_Click(sender As Object, e As EventArgs) Handles medUpBtn.Click
        Dim medAvail As Integer = CInt(medAvailTxt.Text)
        Try
            If MsgShow("Update Medicine?", MsgType.Exclamation, MsgButton.YesNo, MsgLanguage.English) = DialogResult.Yes Then
                sql = "update medinventory_tb set product_name = '" & medNameTxt.Text & "', description = '" & descriptTxt.Text & "', available = '" & medAvail & "',  expiry_date ='" & medDateTxt.Text & "' where inID = '" & medIDTxt.Text & "' "
                connect()
                MsgShow("Medicine Update", MsgType.Success, MsgLanguage.English)


            End If
        Catch ex As Exception
            MsgShow("Error Adding Medicine", MsgType.Critical, MsgLanguage.English)
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub medRevBtn_Click(sender As Object, e As EventArgs) Handles medRevBtn.Click
        Try
            If MsgShow("Delete Medicine?", MsgType.Exclamation, MsgButton.YesNo, MsgLanguage.English) = DialogResult.Yes Then
                sql = "delete from clinic_db.medinventory_tb where inID= '" & medIDTxt.Text & "'"
                connect()
                MsgShow("Medicine Deleted", MsgType.Success, MsgLanguage.English)



            End If
        Catch ex As Exception
            MsgShow("Error Deleting Medicine", MsgType.Information, MsgLanguage.English)
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub medRefBtn_Click(sender As Object, e As EventArgs) Handles medRefBtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query As String

        Try

            query = "Select inID, product_name, description, available, expiry_date from medInventory_tb"
            cmd = New MySqlCommand(query, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            Guna2DataGridView3.DataSource = bSource
            SDA.Update(dbDataSet)


            dr.Close()

        Catch ex As Exception
            MsgShow("Error Loading Table", MsgType.Exclamation, MsgLanguage.English)
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles updatepatBtn.Click

    End Sub

    Public Sub patient()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query As String

        Try

            query = "Select patientID, fname, lname, patientType, age, address from patients_tb"
            cmd = New MySqlCommand(query, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            patientList.DataSource = bSource
            SDA.Update(dbDataSet)



        Catch ex As Exception
            'MsgShow("Error Loading Table", MsgType.Exclamation, MsgLanguage.English)
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Guna2DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView3.CellContentClick

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles bckupDBbtn.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "D:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim con2 As MySqlConnection = New MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=clinic_db")
            Dim cmd2 As MySqlCommand = New MySqlCommand
            cmd2.Connection = con2
            con2.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd2)
            mb.ExportToFile(backup.FileName)
            con2.Close()
            MsgShow("Database Backup Successfull", MsgType.Success, MsgLanguage.English)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub refreshpatbtn_Click(sender As Object, e As EventArgs) Handles refreshpatbtn.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim query As String

        Try

            query = "Select patientID, fname, lname, patientType, age, address from patients_tb"
            cmd = New MySqlCommand(query, conn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            patientList.DataSource = bSource
            SDA.Update(dbDataSet)


            dr.Close()

        Catch ex As Exception
            MsgShow("Error Loading Table", MsgType.Exclamation, MsgLanguage.English)
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub importPatBtn_Click(sender As Object, e As EventArgs) Handles importPatBtn.Click
        ImportPatientForm.ShowDialog()

    End Sub
End Class