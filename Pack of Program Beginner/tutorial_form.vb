Public Class tutorial_form

    Private Structure clr
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
    End Structure
    Dim nowc, newc As clr
    Dim lastpg, nowpg, type As Integer

    Private Sub exit_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_exit.Click
        Me.Close()
    End Sub

    Private Sub tutorial_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        but_next.Parent = display
        but_next.BringToFront()
        but_prev.Parent = display
        but_prev.BringToFront()
        colortimer.Enabled = False
    End Sub

    Private Sub getc(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer)
        nowc.r = Me.BackColor.R
        nowc.g = Me.BackColor.G
        nowc.b = Me.BackColor.B
        newc.r = r
        newc.g = g
        newc.b = b
        colortimer.Enabled = True
    End Sub

    Private Sub colortimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colortimer.Tick
        If nowc.r > newc.r Then
            nowc.r = nowc.r - 1
        ElseIf nowc.r < newc.r Then
            nowc.r = nowc.r + 1
        End If
        If nowc.g > newc.g Then
            nowc.g = nowc.g - 1
        ElseIf nowc.g < newc.g Then
            nowc.g = nowc.g + 1
        End If
        If nowc.b > newc.b Then
            nowc.b = nowc.b - 1
        ElseIf nowc.b < newc.b Then
            nowc.b = nowc.b + 1
        End If
        If nowc.r = newc.r And nowc.g = newc.g And nowc.b = newc.b Then
            colortimer.Enabled = False
        Else
            Me.BackColor = Color.FromArgb(nowc.r, nowc.g, nowc.b)
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_front.Click
        getc(224, 224, 224)
        display.Visible = False
        but_prev.Visible = False
        but_next.Visible = False
        but_geth.Visible = True
        but_objsnd.Visible = True
        but_cal.Visible = True
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_cal.Click
        getc(192, 255, 255)
        display.Visible = True
        but_next.Visible = True
        but_geth.Visible = False
        but_objsnd.Visible = False
        but_cal.Visible = False
        nowpg = 1
        type = 3
        lastpg = 20
        display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\calculator\1.jpg")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_objsnd.Click
        getc(192, 255, 192)
        display.Visible = True
        but_next.Visible = True
        but_geth.Visible = False
        but_objsnd.Visible = False
        but_cal.Visible = False
        nowpg = 1
        type = 2
        lastpg = 13
        display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\objsnd\1.jpg")
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_geth.Click
        getc(255, 255, 192)
        display.Visible = True
        but_next.Visible = True
        but_geth.Visible = False
        but_objsnd.Visible = False
        but_cal.Visible = False
        lastpg = 9
        nowpg = 1
        type = 1
        display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\get highest\1.jpg")
    End Sub

    Private Sub but_next_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles but_next.MouseLeave
        but_next.Image = My.Resources.next100
    End Sub

    Private Sub but_next_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but_next.MouseMove
        but_next.Image = My.Resources.next70
    End Sub

    Private Sub but_prev_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles but_prev.MouseLeave
        but_prev.Image = My.Resources.prev100
    End Sub

    Private Sub but_prev_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but_prev.MouseMove
        but_prev.Image = My.Resources.prev70
    End Sub

    Private Sub but_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_next.Click
        If nowpg < lastpg Then
            nowpg = nowpg + 1
            If nowpg > 1 Then
                but_prev.Visible = True
            End If
            Select Case type
                Case 1
                    display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\get highest\" & nowpg & ".jpg")
                Case 2
                    display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\objsnd\" & nowpg & ".jpg")
                Case 3
                    display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\calculator\" & nowpg & ".jpg")
            End Select
        End If
        If nowpg = lastpg Then
            but_next.Visible = False
        End If
    End Sub

    Private Sub but_prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_prev.Click
        If nowpg > 1 Then
            nowpg = nowpg - 1
            If nowpg = 1 Then
                but_prev.Visible = False
            End If
            Select Case type
                Case 1
                    display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\get highest\" & nowpg & ".jpg")
                Case 2
                    display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\objsnd\" & nowpg & ".jpg")
                Case 3
                    display.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\calculator\" & nowpg & ".jpg")
            End Select
        End If
    End Sub
End Class