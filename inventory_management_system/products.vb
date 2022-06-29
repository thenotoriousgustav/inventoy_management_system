Public Class products

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label4.Text = "1" Then
            Guna2PictureBox1.Image = My.Resources.oculus_slider1
            Label4.Text = "2"

        ElseIf Label4.Text = "2" Then
            Guna2PictureBox1.Image = My.Resources.oculus_slider2
            Label4.Text = "3"

        ElseIf Label4.Text = "3" Then
            Guna2PictureBox1.Image = My.Resources.gameboy_slider1
            Label4.Text = "4"

        ElseIf Label4.Text = "4" Then
            Guna2PictureBox1.Image = My.Resources.gameboy_slider2
            Label4.Text = "5"

        ElseIf Label4.Text = "5" Then
            Guna2PictureBox1.Image = My.Resources.nintendo_slider1
            Label4.Text = "6"

        ElseIf Label4.Text = "6" Then
            Guna2PictureBox1.Image = My.Resources.nintendo_slider2
            Label4.Text = "7"

        ElseIf Label4.Text = "7" Then
            Guna2PictureBox1.Image = My.Resources.nintendo_slider3
            Label4.Text = "1"
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class