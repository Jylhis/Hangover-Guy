Public Class inven
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'AXE voi ottaa 2 paikkaa
        If TextBox1.Text = "Axe" And laatta.laatta = 33 And laatta.Axe = 0 And laatta.TvOpen = 1 Then
            Form1.ListBox1.Items.Add("Axe")
            laatta.Axe = 1
            Me.Hide()
        ElseIf TextBox1.Text = "Axe" And laatta.laatta = 34 And laatta.Axe = 0 And laatta.TvOpen = 1 Then
            Form1.ListBox1.Items.Add("Axe")
            laatta.Axe = 1
            Me.Hide()

            'KEY
        ElseIf TextBox1.Text = "Key" And laatta.laatta = 47 And laatta.Key = 0 Then
            Form1.ListBox1.Items.Add("Key")
            laatta.Key = 1
            Me.Hide()

            'SCREWDRIVER
        ElseIf TextBox1.Text = "Screwdriver" And laatta.laatta = 5 And laatta.Screwdriver = 0 Then
            Form1.ListBox1.Items.Add("Screwdriver")
            laatta.Screwdriver = 1
            Me.Hide()

            'Brick
        ElseIf TextBox1.Text = "Brick" And laatta.laatta = 61 And laatta.Brick = 0 Then
            Form1.ListBox1.Items.Add("Brick")
            laatta.Brick = 1
            Me.Hide()

            'Coke
        ElseIf TextBox1.Text = "Coke" And laatta.laatta = 24 And laatta.Coke = 0 And laatta.Fridge = 1 Then
            Form1.ListBox1.Items.Add("Coke")
            laatta.Coke = 1
            Me.Hide()
        Else
            Label1.Visible = True
        End If
    End Sub
End Class