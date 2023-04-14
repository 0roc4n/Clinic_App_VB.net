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


End Class