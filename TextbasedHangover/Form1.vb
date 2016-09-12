Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Help.Show() 'shows help window
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'auto scroll for textbox
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Pohjoinen
        Liikunta(laatta.laatta, 1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Länsi
        Liikunta(laatta.laatta, 4)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Etelä
        Liikunta(laatta.laatta, 3)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Itä
        Liikunta(laatta.laatta, 2)
    End Sub


    Private Sub Liikunta(ByRef laatta, ByVal b) 'vaihtaa laatan yhtä isommaksi tai pienemmäksi, tai sitten pudottaa rotkoon

        Select Case laatta

            Case 0 'Where you are
                If b = 1 Then 'where you go if you press north

                    Return
                End If
                If b = 2 Then 'where you go if you press east
                    PictureBox1.Image = My.Resources.minimap1x
                    laatta = 1
                    TextBox1.Text = TextBox1.Text + "You stand up" & vbCrLf & vbCrLf
                    ListBox1.Items.Add("Bed")
                    Return
                End If
                If b = 3 Then 'where you go if you press south
                    PictureBox1.Image = My.Resources.minimap0
                    Return
                End If
                If b = 4 Then 'where you go if you press west
                    PictureBox1.Image = My.Resources.minimap0
                    Return
                End If


            Case 1
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap2y
                    laatta = 2
                    ListBox1.Items.Remove("Bed")
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap10x
                    laatta = 10
                    ListBox1.Items.Add("Computer")
                    TextBox1.Text = TextBox1.Text + "You see computer in front of you" & vbCrLf & vbCrLf
                    ListBox1.Items.Remove("Bed")
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap1y
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap1x
                    Return
                End If


            Case 2
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap3y
                    laatta = 3
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap9x
                    laatta = 9
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap1y
                    laatta = 1
                    ListBox1.Items.Add("Bed")
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap2x
                    Return
                End If


            Case 3
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap6y
                    laatta = 6
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap8x
                    laatta = 8
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap2y
                    laatta = 2
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap4x
                    laatta = 4
                    Return
                End If


            Case 4
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap5y
                    TextBox1.Text = TextBox1.Text + "You see something on the floor" & vbCrLf & vbCrLf
                    laatta = 5
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap3x
                    laatta = 3
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap4y
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap4x

                    Return
                End If



            Case 5
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap5y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap6x
                    laatta = 6
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap4y
                    laatta = 4
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap5x

                    Return
                End If



            Case 6
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap6y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap7x
                    laatta = 7
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap3y
                    laatta = 3
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap5x
                    TextBox1.Text = TextBox1.Text + "You see something on the floor" & vbCrLf & vbCrLf
                    laatta = 5
                    Return
                End If




            Case 7
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap7y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap7x
                    If laatta = 7 Then
                        Randomize()
                        stairNum = CStr(Int(Rnd() * 12))
                        If stairNum = 1 Then
                            laatta = 41
                            TextBox1.Text = TextBox1.Text + "You did unbelievable parkour backflip frontside ollie over the railing to downstairs" & vbCrLf & vbCrLf
                        Else
                            TextBox1.Text = TextBox1.Text + "Ouch! You hit the railing" & vbCrLf & vbCrLf
                        End If
                    End If
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap8y
                    laatta = 8
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap6x
                    laatta = 6
                    Return
                End If



            Case 8

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap7y
                    laatta = 7
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap12x
                    laatta = 12
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap9y
                    laatta = 9
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap3x
                    laatta = 3
                    Return
                End If



            Case 9

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap8y
                    laatta = 8
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap11x
                    laatta = 11
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap10y
                    laatta = 10
                    ListBox1.Items.Add("Computer")
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap2x
                    laatta = 2
                    Return
                End If


            Case 10

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap9y
                    laatta = 9
                    ListBox1.Items.Remove("Computer")
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap10x
                    TextBox1.Text = TextBox1.Text + "You ran into the computer" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap10y
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap1x
                    laatta = 1
                    ListBox1.Items.Remove("Computer")
                    ListBox1.Items.Add("Bed")
                    Return
                End If


            Case 11

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap12y
                    laatta = 12
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap11x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap11y
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap9x
                    laatta = 9
                    Return
                End If



            Case 12

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap41y
                    laatta = 41
                    TextBox1.Text = TextBox1.Text + "You went downstairs" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap12x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap11y
                    laatta = 11
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap8x
                    laatta = 8
                    Return
                End If

            Case 41

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap12y
                    laatta = 12
                    TextBox1.Text = TextBox1.Text + "You went upstairs" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap41x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimaps3
                    laatta = 48
                    TextBox1.Text = TextBox1.Text + "You sat onto the couch" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap34x
                    laatta = 34
                    Return
                End If


            Case 48

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap41y
                    laatta = 41
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimaps3
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimaps3
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimaps2
                    laatta = 47
                    Return
                End If


            Case 39

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap39y
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap39x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap38y
                    laatta = 38
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap36x
                    laatta = 36
                    Return
                End If



            Case 38

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap39y
                    laatta = 39
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap38x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap38y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap37x
                    laatta = 37
                    Return
                End If



            Case 37

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap36y
                    laatta = 36
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap38x
                    laatta = 38
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap37y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap29x
                    laatta = 29
                    Return
                End If



            Case 36

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap36y
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap39x
                    laatta = 39
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap37y
                    laatta = 37
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap30x
                    laatta = 30
                    Return
                End If



            Case 47

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap34y
                    laatta = 34
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimaps3
                    laatta = 48
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimaps2
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimaps1
                    laatta = 46
                    Return
                End If



            Case 34

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap34y
                    TextBox1.Text = TextBox1.Text + "The TV in front of you doens't seem to be working. With a screwdriver you could get it open and see whats wrong." & vbCrLf & vbCrLf
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap41x
                    laatta = 41
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimaps2
                    laatta = 47
                    TextBox1.Text = TextBox1.Text + "You sat onto couch" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap32x
                    laatta = 32
                    Return
                End If



            Case 33

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap33y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap33x
                    TextBox1.Text = TextBox1.Text + "The TV in front of you doesn't seem to be working. With a screwdriver you could get it open and see whats wrong." & vbCrLf & vbCrLf
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap32y
                    laatta = 32
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap33x

                    Return
                End If



            Case 32

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap33y
                    laatta = 33
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap34x
                    laatta = 34
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimaps1
                    laatta = 46
                    TextBox1.Text = TextBox1.Text + "You sat onto couch" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap44x
                    laatta = 44
                    Return
                End If



            Case 46

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap32y
                    laatta = 32
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimaps2
                    laatta = 47
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimaps1
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimaps1
                    Return
                End If



            Case 30

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap30y
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap36x
                    laatta = 36
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap29y
                    laatta = 29
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap28x
                    laatta = 28
                    Return
                End If



            Case 29

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap30y
                    laatta = 30
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap37x
                    laatta = 37
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap29y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap29x

                    Return
                End If




            Case 44

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap44y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap32x
                    laatta = 32
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap27y
                    laatta = 27
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap44x

                    Return
                End If



            Case 27

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap44y
                    laatta = 44
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap27x
                    laatta = 27
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap28y
                    laatta = 28
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap14x
                    laatta = 14
                    Return
                End If



            Case 28

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap27y
                    laatta = 27
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap30x
                    laatta = 30
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap28y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap13x
                    laatta = 13
                    Return
                End If



            Case 14

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap14y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap27x
                    laatta = 27
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap13y
                    laatta = 13
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap15x
                    laatta = 15
                    Return
                End If



            Case 13

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap14y
                    laatta = 14
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap28x
                    laatta = 28
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap43y
                    laatta = 43
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap16x
                    laatta = 16
                    Return
                End If



            Case 43

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap13y
                    laatta = 13
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap43x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap50y
                    laatta = 50
                    TextBox1.Text = TextBox1.Text + "You went to the basement" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap17x
                    laatta = 17
                    Return
                End If



            Case 18

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap17y
                    laatta = 17
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap18x
                    If laatta = 18 Then
                        Randomize()
                        stairNum = CStr(Int(Rnd() * 15))
                        If stairNum = 1 Then
                            laatta = 50
                            TextBox1.Text = TextBox1.Text + "You did unbelievable parkour backflip frontside ollie over the railing to Basement" & vbCrLf & vbCrLf
                        Else
                            TextBox1.Text = TextBox1.Text + "Ouch! You hit the railing" & vbCrLf & vbCrLf
                        End If
                    End If
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap18y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap18x

                    Return
                End If



            Case 17

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap16y
                    laatta = 16
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap43x
                    laatta = 43
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap18y
                    laatta = 18
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap17x

                    Return
                End If



            Case 16

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap15y
                    laatta = 15
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap13x
                    laatta = 13
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap17y
                    laatta = 17
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap19x
                    laatta = 19
                    Return
                End If



            Case 15

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap45y
                    laatta = 45
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap14x
                    laatta = 14
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap16y
                    laatta = 16
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap15x

                    Return
                End If



            Case 45

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap45y
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap45x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap15y
                    laatta = 15
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap45x

                    Return
                End If



            Case 19

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap19y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap16x
                    laatta = 16
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap19y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap20x
                    laatta = 20
                    Return
                End If



            Case 20

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap25y
                    laatta = 25
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap19x
                    laatta = 19
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap21y
                    laatta = 21
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap23x
                    laatta = 23
                    Return
                End If



            Case 21

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap20y
                    laatta = 20
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap21x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap21y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap21x

                    Return
                End If



            Case 23

                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap24y
                    laatta = 24
                    ListBox1.Items.Add("Fridge")
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap20x
                    laatta = 20
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap23y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap23x
                    Return
                End If

            Case 50
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap43y
                    laatta = 43
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap50x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap51y
                    laatta = 51
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap53x
                    laatta = 53
                    Return
                End If



            Case 51
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap50y
                    laatta = 50
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap51x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap52y
                    laatta = 52
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap54x
                    laatta = 54
                    Return
                End If



            Case 52
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap51y
                    laatta = 51
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap58x
                    laatta = 58
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap52y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap55x
                    laatta = 55
                    Return
                End If



            Case 53
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap53y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap50x
                    laatta = 50
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap54y
                    laatta = 54
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap49x
                    laatta = 49
                    TextBox1.Text = TextBox1.Text + "You went to the shower" & vbCrLf & vbCrLf
                    ListBox1.Items.Add("Shower")


                    Return
                End If



            Case 49
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap49y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap53x
                    ListBox1.Items.Remove("Shower")
                    laatta = 53
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap56y
                    laatta = 56
                    ListBox1.Items.Remove("Shower")
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap49x
                    TextBox1.Text = TextBox1.Text + "You ram into the shower" & vbCrLf & vbCrLf

                    Return
                End If



            Case 54
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap53y
                    laatta = 53
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap51x
                    laatta = 51
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap55y
                    laatta = 55
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap56x
                    laatta = 56
                    Return
                End If



            Case 55
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap54y
                    laatta = 54
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap52x
                    laatta = 52
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap55y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap57x
                    laatta = 57
                    Return
                End If



            Case 56
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap49y
                    laatta = 49
                    TextBox1.Text = TextBox1.Text + "You went to the shower" & vbCrLf & vbCrLf
                    ListBox1.Items.Add("Shower")

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap54x
                    laatta = 54
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap57y
                    laatta = 57
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap56x

                    Return
                End If



            Case 57
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap56y
                    laatta = 56
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap55x
                    laatta = 55
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap57y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap57x

                    Return
                End If



            Case 58
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap58y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap59x
                    laatta = 59
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap58y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap52x
                    laatta = 52
                    Return
                End If



            Case 59
                If b = 1 Then


                    If Bath_door = 0 Then
                        PictureBox1.Image = My.Resources.minimap59y
                        TextBox1.Text = TextBox1.Text + " DAMN! Door is locked. I should break the lock somehow..." & vbCrLf & vbCrLf
                    ElseIf Bath_door = 1 Then
                        PictureBox1.Image = My.Resources.minimap60y
                        TextBox1.Text = TextBox1.Text + "You went to toilet and closed the door behind you" & vbCrLf & vbCrLf
                        laatta = 60

                    End If
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap59x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap59y

                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap58y
                    laatta = 58
                    Return
                End If



            Case 60
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap61
                    laatta = 61
                    TextBox1.Text = TextBox1.Text + "you sat on a toilet." & vbCrLf & vbCrLf
                    ListBox1.Items.Add("Toilet")

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap60x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap59y
                    laatta = 59
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap60x

                    Return
                End If



            Case 61
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap61
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap61

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap60y
                    laatta = 60
                    ListBox1.Items.Remove("Toilet")
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap61

                    Return
                End If



            Case 24
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap24y
                    TextBox1.Text = TextBox1.Text + "it is a fridge" & vbCrLf & vbCrLf
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap25x
                    ListBox1.Items.Remove("Fridge")
                    laatta = 25
                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap23y
                    ListBox1.Items.Remove("Fridge")
                    laatta = 23
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap24x

                    Return
                End If



            Case 25
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap26y
                    laatta = 26
                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap25x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap20y
                    laatta = 20
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap24x
                    laatta = 24
                    ListBox1.Items.Add("Fridge")

                    Return
                End If



            Case 26
                If b = 1 Then
                    PictureBox1.Image = My.Resources.minimap26y

                    Return
                End If
                If b = 2 Then
                    PictureBox1.Image = My.Resources.minimap26x

                    Return
                End If
                If b = 3 Then
                    PictureBox1.Image = My.Resources.minimap25y
                    laatta = 25
                    Return
                End If
                If b = 4 Then
                    PictureBox1.Image = My.Resources.minimap26x

                    Return
                End If

        End Select
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        inven.Show()
        inven.Label1.Visible = False 'hide item not found text
        inven.TextBox1.Text = ""
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        If ListBox1.SelectedItem = "Axe" And laatta.laatta = 59 Then 'AXE 
            TextBox1.Text = TextBox1.Text + "You smashed the doors lock" & vbCrLf & vbCrLf
            Bath_door = 1
        ElseIf ListBox1.SelectedItem = "Axe" Then
            TextBox1.Text = TextBox1.Text + "HULK SMASH!" & vbCrLf & vbCrLf


        ElseIf ListBox1.SelectedItem = "Shower" And laatta.laatta = 49 Then 'Shower thoughts
            Randomize() 'randomize numbers
            showerNum = CStr(Int(Rnd() * 6)) 'gives number between 1-6
            If showerNum = 1 Then
                TextBox1.Text = TextBox1.Text + "You turn the water on and scream like a little girl because it's so cold" & vbCrLf & vbCrLf
            ElseIf showerNum = 2 Then
                TextBox1.Text = TextBox1.Text + "You took a shower like a boss" & vbCrLf & vbCrLf
            ElseIf showerNum = 3 Then
                TextBox1.Text = TextBox1.Text + "You turn the water on and start thinking...  Can one Simply walk into mordor?" & vbCrLf & vbCrLf
            ElseIf showerNum = 4 Then
                TextBox1.Text = TextBox1.Text + "You turn the water on and start thinking...  Atoms and particles behave in probabilistic ways, but our mind is made of atoms and particles... How can free will exist?" & vbCrLf & vbCrLf
            ElseIf showerNum = 5 Then
                TextBox1.Text = TextBox1.Text + "You turn the water on and start thinking...  So, if guns don't kill people, people kill people... does that mean toasters don't toast toast, toast toast toast?" & vbCrLf & vbCrLf
            End If


        ElseIf ListBox1.SelectedItem = "Computer" And laatta.laatta = 10 Then 'Computer googling
            TextBox1.Text = TextBox1.Text + "It seems that you have been googling 'how to fix TV with an axe'. The screwdriver must be somewhere around here." & vbCrLf + "How drunk i was last night?" & vbCrLf & vbCrLf


        ElseIf ListBox1.SelectedItem = "Screwdriver" And laatta.laatta = 33 Then 'Open TV
            TextBox1.Text = TextBox1.Text + "You open your TV and see axe inside there" & vbCrLf & vbCrLf
            laatta.TvOpen = 1
        ElseIf ListBox1.SelectedItem = "Screwdriver" And laatta.laatta = 34 And laatta.Axe = 0 Then 'Open TV
            TextBox1.Text = TextBox1.Text + "You open your TV and see axe inside there" & vbCrLf & vbCrLf
            laatta.TvOpen = 1
        ElseIf ListBox1.SelectedItem = "Screwdriver" And laatta.laatta = 34 And laatta.Axe = 1 Then 'look TV
            TextBox1.Text = TextBox1.Text + "Oh dog your TV is permanently broken" & vbCrLf & vbCrLf

        ElseIf ListBox1.SelectedItem = "Screwdriver" Then
            TextBox1.Text = TextBox1.Text + "You can't use that here" & vbCrLf & vbCrLf


        ElseIf ListBox1.SelectedItem = "Fridge" And laatta.laatta = 24 Then 'Fridge lock
            If laatta.Fridge = 0 Then
                TextBox1.Text = TextBox1.Text + "It seems that somebody has locked the fridge with chain" & vbCrLf & vbCrLf
            ElseIf laatta.Fridge = 1 Then
                laatta.Fridge = 1
                TextBox1.Text = TextBox1.Text + "Hurray! You see the Coke inside the fridge" & vbCrLf & vbCrLf
            End If



        ElseIf ListBox1.SelectedItem = "Toilet" And laatta.laatta = 61 Then 'Toilet Magic
            laatta.Toilet = 1
            If Brick = 0 Then
                TextBox1.Text = TextBox1.Text + "When you see it you will shit Brick. Literally." & vbCrLf & vbCrLf
            ElseIf Brick = 1 Then
                TextBox1.Text = TextBox1.Text + "You already shat a Brick" & vbCrLf & vbCrLf
            End If

        ElseIf ListBox1.SelectedItem = "Key" And laatta.laatta = 24 Then 'Fridge key
            laatta.Fridge = 1
            TextBox1.Text = TextBox1.Text + "You unlocked the fridge" & vbCrLf & vbCrLf
        ElseIf ListBox1.SelectedItem = "Key" Then
            TextBox1.Text = TextBox1.Text + "What are you trying to open?" & vbCrLf & vbCrLf

        ElseIf ListBox1.SelectedItem = "Coke" Then
            TextBox1.Text = TextBox1.Text + "*glug* *glug*" & vbCrLf & vbCrLf
            laatta.Coke = 1

        ElseIf ListBox1.SelectedItem = "Brick" Then 'Brick note
            TextBox1.Text = TextBox1.Text + "Somebody has drawn a couch and key there. What could it mean?" & vbCrLf & vbCrLf

        ElseIf ListBox1.SelectedItem = "Bed" And laatta.Coke = 1 And laatta.Toilet = 1 And laatta.laatta = 1 Then
            Me.Hide()
            victory.Show()
        ElseIf ListBox1.SelectedItem = "Bed" And laatta.Coke = 0 And laatta.Toilet = 1 And laatta.laatta = 1 Then
            TextBox1.Text = TextBox1.Text + "I should go get something to drink..." & vbCrLf & vbCrLf
        ElseIf ListBox1.SelectedItem = "Bed" And laatta.Coke = 1 And laatta.Toilet = 0 And laatta.laatta = 1 Then
            TextBox1.Text = TextBox1.Text + "I should go to the toilet..." & vbCrLf & vbCrLf
        ElseIf ListBox1.SelectedItem = "Bed" And laatta.Coke = 0 And laatta.Toilet = 0 And laatta.laatta = 1 Then
            TextBox1.Text = TextBox1.Text + "I should go get something to drink..." & vbCrLf & vbCrLf
        End If
    End Sub

End Class
