Public Class start

    Private Sub start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form1.ListBox1.Items.Clear()
        laatta.laatta = 0

        laatta.Axe = 0
        laatta.Key = 0
        laatta.Coke = 0
        laatta.Screwdriver = 0
        laatta.Brick = 0

        laatta.Fridge = 0
        laatta.Computer = 0
        laatta.Bath_door = 0
        laatta.Toilet = 0
        laatta.Shower = 0
        laatta.TvOpen = 0
        laatta.Bed = 0
        Form1.TextBox1.Text = ""
        Form1.PictureBox1.Image = My.Resources.minimap0
        Form1.Show() 'This opens game window
        Me.Hide() 'Hides start window
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Help.Show() 'show help window
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class