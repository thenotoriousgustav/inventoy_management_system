Imports MySql.Data.MySqlClient

Public Class dashboard
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=inventory_management_system; SslMode=none;")

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalproduct()
        negativestock()
        totaluser()
    End Sub

    Sub totalproduct()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`ID`) from tbl_inventory ", conn)
            label_product.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub totaluser()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select count(`id`) from user ", conn)
            label_user.Text = cmd.ExecuteScalar.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub negativestock()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("select * from tbl_inventory where Amount=0", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Name"), dr.Item("Amount"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label_time.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
End Class