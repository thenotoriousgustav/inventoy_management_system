Public Class playstation

    Private Sub playstation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label4.Text = "1" Then
            Guna2PictureBox1.Image = My.Resources.ps5
            Label4.Text = "2"

        ElseIf Label4.Text = "2" Then
            Guna2PictureBox1.Image = My.Resources.ps5_1
            Label4.Text = "3"

        ElseIf Label4.Text = "3" Then
            Guna2PictureBox1.Image = My.Resources.ps5_2
            Label4.Text = "4"

        ElseIf Label4.Text = "4" Then
            Guna2PictureBox1.Image = My.Resources.cd_1
            Label4.Text = "5"

        ElseIf Label4.Text = "5" Then
            Guna2PictureBox1.Image = My.Resources.cd_2
            Label4.Text = "6"

        ElseIf Label4.Text = "6" Then
            Guna2PictureBox1.Image = My.Resources.cd_3
            Label4.Text = "7"

        ElseIf Label4.Text = "7" Then
            Guna2PictureBox1.Image = My.Resources.cd_4
            Label4.Text = "1"
        End If
    End Sub
End Class