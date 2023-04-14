Imports ShowMessage
Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=clinic_db"

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        sql = "Select * from admin_tb where username ='" & unametxtbox.Text & "' and password = '" & passtxtbox.Text & "'"
        connect()

        If dr.Read Then
            MsgShow("Login Successful", MsgType.Success, MsgLanguage.English)
            Me.Hide()
            conn.Close()
            Dashboard.Show()
        Else
            MsgShow("Invalid Username/Password", MsgType.Critical, MsgLanguage.English)

        End If
        conn.Close()
    End Sub
End Class
