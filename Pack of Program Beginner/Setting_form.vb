

Public Class Setting_form
    Private sx, sy, fnum As Integer
    Private srgb As Color
    Private simg As Image
    Private simgname As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_bgcolor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
            srgb = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_bgimg.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            simgname = OpenFileDialog1.FileName
            TextBox4.Text = simgname
            simg = Image.FromFile(simgname)
            piccom.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_but.Click
        Main_form.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_but.Click
        If xnum.Text <> "" And ynum.Text <> "" Then
            sx = xnum.Text
            sy = ynum.Text
            If sx <= 1024 And sx >= 500 And sy <= 720 And sy >= 150 Then
                xx = bgx
                xy = bgy
                bgx = sx
                bgy = sy
                If simgname <> "" Then
                    bgimgname = simgname
                    bgimg = simg
                    Main_form.display.BackgroundImage = bgimg
                    Select Case piccom.SelectedItem
                        Case "기본"
                            Main_form.display.BackgroundImageLayout = ImageLayout.None
                            bglayout = 1
                        Case "타일"
                            Main_form.display.BackgroundImageLayout = ImageLayout.Tile
                            bglayout = 2
                        Case "중앙"
                            Main_form.display.BackgroundImageLayout = ImageLayout.Center
                            bglayout = 3
                        Case "늘리기"
                            Main_form.display.BackgroundImageLayout = ImageLayout.Stretch
                            bglayout = 4
                        Case "확대"
                            Main_form.display.BackgroundImageLayout = ImageLayout.Zoom
                            bglayout = 5
                    End Select
                End If
                Main_form.Enabled = True
                bgcolor = srgb
                If Not bgx = xx And Not bgy = xy Then
                    Main_form.display.Width = bgx
                    cngnum = 1
                    Main_form.display.Height = bgy
                ElseIf bgx <> xx And bgy = xy Then
                    cngnum = 1
                    Main_form.display.Width = bgx
                ElseIf bgx = xx And bgy <> xy Then
                    cngnum = 1
                    Main_form.display.Height = bgy
                End If
                Main_form.display.BackColor = bgcolor
                Me.Close()
            Else
                MessageBox.Show("길이 최소 500픽셀, 최대 1024픽셀,너비 최소 150픽셀, 최대 720픽셀로 재설정 해주십시요")
                Dim num As Integer
                num = ynum.Text
                If num > 720 Or num < 150 Then
                    ynum.Text = ""
                    ynum.Focus()
                End If
                num = xnum.Text
                If num > 1024 Or num < 150 Then
                    xnum.Text = ""
                    xnum.Focus()
                End If
            End If
        Else
            MessageBox.Show("길이 또는 너비를 입력해주십시요")
            If xnum.Text = "" Then
                xnum.Focus()
            ElseIf ynum.Text = "" Then
                ynum.Focus()
            End If
        End If
dasi:
    End Sub

    Private Sub Setting_form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        bmpcnt = 0
    End Sub

    Private Sub Setting_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xnum.Text = bgx
        ynum.Text = bgy
        TextBox4.Text = bgimgname
        simgname = bgimgname
        simg = bgimg
        piccom.Enabled = False
        If Not (TextBox4.Text = "") Then
            piccom.Enabled = True
        End If
        PictureBox1.BackColor = bgcolor
        srgb = bgcolor
        Select Case Main_form.display.BackgroundImageLayout
            Case ImageLayout.None
                piccom.SelectedItem = "기본"
            Case ImageLayout.Tile
                piccom.SelectedItem = "타일"
            Case ImageLayout.Stretch
                piccom.SelectedItem = "늘리기"
            Case ImageLayout.Center
                piccom.SelectedItem = "중앙"
            Case ImageLayout.Zoom
                piccom.SelectedItem = "확대"
        End Select
    End Sub

    Private Sub xnum_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xnum.KeyDown
        If e.KeyValue = 8 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
        Else
            MessageBox.Show("숫자만 입력 가능합니다")
            xnum.Text = ""
            xnum.Focus()
        End If
    End Sub

    Private Sub ynum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ynum.KeyDown
        If e.KeyValue = 8 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
        Else
            MessageBox.Show("숫자만 입력 가능합니다")
            ynum.Text = ""
            ynum.Focus()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simgname = ""
        TextBox4.Text = "'"
        piccom.Enabled = False
    End Sub
End Class