Imports MySql.Data.MySqlClient

Public Class auth

    Dim con As New MySqlConnection("server=localhost; user id=root; password=; database=inventory_management_system; SslMode=none;")

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2Transition1.HideSync(form_login)
        form_login.SendToBack()
        Guna2Transition1.ShowSync(form_register)
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2Transition1.HideSync(form_register)
        form_register.SendToBack()
        Guna2Transition1.ShowSync(form_login)
    End Sub


    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If txt_username.Text = "" Then
            MsgBox("Username has not been filled in", MsgBoxStyle.Information)
        ElseIf txt_password.Text = "" Then
            MsgBox("Please input the Password", MsgBoxStyle.Information)
        ElseIf txt_confirm.Text = "" Then
            MsgBox("Please Confirm the Password", MsgBoxStyle.Information)
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New MySqlCommand("INSERT INTO user(username, password) VALUES(?,?)", con)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Selamat anda telah terdaftar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txtUsername.Text = "" Then
            MsgBox("Please input the Username", MsgBoxStyle.Information)
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please input the Password", MsgBoxStyle.Information)
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New MySqlCommand("SELECT * FROM user WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'", con)
            Dim rd As MySqlDataReader = cmd.ExecuteReader
            If rd.HasRows Then
                sidebar.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Username or Password", MsgBoxStyle.Critical)
            End If
            rd.Close()
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txt_confirm.TextChanged
        If (txt_password.Text = txt_confirm.Text) Then
            lbl_confirm.Text = ""
            lbl_confirm.ForeColor = Color.WhiteSmoke
            btn_register.Enabled = True
        Else
            lbl_confirm.Text = "Password doesn't matched"
            lbl_confirm.ForeColor = Color.Red
            btn_register.Enabled = False

        End If
    End Sub

    Private Sub auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
