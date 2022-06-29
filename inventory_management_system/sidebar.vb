Public Class sidebar

    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True

    Private Sub sidebar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Size = Panel1.MinimumSize
    End Sub

    Sub switchPanel(ByVal Panel As Form)
        Guna2Panel4.Controls.Clear()
        Panel.TopLevel = False
        Guna2Panel4.Controls.Add(Panel)
        Panel.Show()
    End Sub

    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        switchPanel(dashboard)
        If dashboard_btn.Checked = True Then
            products_btn.Checked = False
            playstation_btn.Checked = False
            nintendo_btn.Checked = False
        End If
    End Sub

    Private Sub inventory_btn_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        switchPanel(inventory)
        If inventory_btn.Checked = True Then
            products_btn.Checked = False
            playstation_btn.Checked = False
            nintendo_btn.Checked = False
        End If
    End Sub

    Private Sub products_btn_Click(sender As Object, e As EventArgs) Handles products_btn.Click
        switchPanel(products)
        isCollapsed2 = False

        Timer2.Start()

        If products_btn.Checked = True Then
            inventory_btn.Checked = False
            dashboard_btn.Checked = False
        End If

    End Sub

    Private Sub playstation_btn_Click(sender As Object, e As EventArgs) Handles playstation_btn.Click
        switchPanel(playstation)
        If playstation_btn.Checked = True Then
            inventory_btn.Checked = False
            dashboard_btn.Checked = False
        End If
    End Sub

    Private Sub nintendo_btn_Click(sender As Object, e As EventArgs) Handles nintendo_btn.Click
        switchPanel(nintendo)
        If nintendo_btn.Checked = True Then
            inventory_btn.Checked = False
            dashboard_btn.Checked = False
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        auth.Show()
    End Sub

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


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed Then
            Panel1.Height += 10
            If Panel1.Size = Panel1.MaximumSize Then
                Timer2.Stop()
                isCollapsed = False
            End If
        Else
            Panel1.Height -= 10
            If Panel1.Size = Panel1.MinimumSize Then
                Timer2.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

End Class