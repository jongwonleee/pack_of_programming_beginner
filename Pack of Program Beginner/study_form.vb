Public Class study_form
    Private Structure clr
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
    End Structure
    Dim nowc, newc As clr
    Dim lastpg, nowpg, onf(9), mode As Integer
    Dim but(10) As Label

    Private Sub getc(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer)
        nowc.r = Me.BackColor.R
        nowc.g = Me.BackColor.G
        nowc.b = Me.BackColor.B
        newc.r = r
        newc.g = g
        newc.b = b
        colortimer.Enabled = True
    End Sub
    Private Sub mdcng(ByVal m As Integer)
        Select Case m
            Case 0
                onf(1) = 1
                onf(2) = 1
                but(1).Text = "명령문"
                but(2).Text = "예제"
                For i = 3 To 9
                    onf(i) = 2
                Next
            Case 1
                but(1).Text = "뒤로"
                but(2).Text = "조건문"
                but(3).Text = "반복문"
                but(4).Text = "문자열"
                but(5).Text = "기타"
                For i = 1 To 5
                    onf(i) = 1
                Next
                For i = 6 To 9
                    onf(i) = 2
                Next
            Case 2
                but(1).Text = "뒤로"
                For i = 2 To 9
                    Dim a As Integer = i - 1
                    Dim n As String = a
                    but(i).Text = "문제 " & a
                Next
                For i = 1 To 9
                    onf(i) = 1
                Next
            Case 11
                but(1).Text = "뒤로"
                but(2).Text = "If"
                but(3).Text = "Switc"
                For i = 1 To 3
                    onf(i) = 1
                Next
                For i = 4 To 9
                    onf(i) = 2
                Next
            Case 12
                but(1).Text = "뒤로"
                but(2).Text = "Goto"
                but(3).Text = "For"
                but(4).Text = "Do"
                For i = 1 To 4
                    onf(i) = 1
                Next
                For i = 5 To 9
                    onf(i) = 2
                Next
            Case 13
                but(1).Text = "뒤로"
                but(2).Text = "Mid"
                but(3).Text = "Len"
                but(4).Text = "Ucase"
                but(5).Text = "Lcase"
                but(6).Text = "Instr"
                but(7).Text = "Trim"
                For i = 1 To 7
                    onf(i) = 1
                Next
                For i = 8 To 9
                    onf(i) = 2
                Next
            Case 14
                but(1).Text = "뒤로"
                but(2).Text = "선언"
                but(4).Text = "Abs"
                but(5).Text = "Mod"
                but(6).Text = "Str"
                but(7).Text = "Val"
                but(8).Text = "Msg"
                but(3).Text = "출력"
                For i = 1 To 7
                    onf(i) = 1
                Next
                For i = 8 To 9
                    onf(i) = 2
                Next
            Case 111
                but(1).Text = "뒤로"
                exp.Text = _if.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 112
                but(1).Text = "뒤로"
                exp.Text = _sel.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 121
                but(1).Text = "뒤로"
                exp.Text = _goto.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 122
                but(1).Text = "뒤로"
                exp.Text = _for.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 123
                but(1).Text = "뒤로"
                exp.Text = _do.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 131
                but(1).Text = "뒤로"
                exp.Text = _mid.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 132
                but(1).Text = "뒤로"
                exp.Text = _len.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 133
                but(1).Text = "뒤로"
                exp.Text = _uca.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 134
                but(1).Text = "뒤로"
                exp.Text = _lca.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 135
                but(1).Text = "뒤로"
                exp.Text = _inst.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 136
                but(1).Text = "뒤로"
                exp.Text = _trim.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 141
                but(1).Text = "뒤로"
                exp.Text = _dim.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 143
                but(1).Text = "뒤로"
                exp.Text = _abs.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 142
                but(1).Text = "뒤로"
                exp.Text = _pri.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 144
                but(1).Text = "뒤로"
                exp.Text = _mod.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 145
                but(1).Text = "뒤로"
                exp.Text = _str.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 146
                but(1).Text = "뒤로"
                exp.Text = _val.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 21
                but(1).Text = "뒤로"
                exp.Text = _q1.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 22
                but(1).Text = "뒤로"
                exp.Text = _q2.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 23
                but(1).Text = "뒤로"
                exp.Text = _q3.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 24
                but(1).Text = "뒤로"
                exp.Text = _q4.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 25
                but(1).Text = "뒤로"
                exp.Text = _q5.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 26
                but(1).Text = "뒤로"
                exp.Text = _q6.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 27
                but(1).Text = "뒤로"
                exp.Text = _q7.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
            Case 28
                but(1).Text = "뒤로"
                exp.Text = _q8.Text
                onf(1) = 1
                For i = 2 To 9
                    onf(i) = 2
                Next
        End Select
        If mode < 20 Then
            exp.Text = ""
        End If
    End Sub
    Private Sub study_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case Algorithm_form.BackColor
            Case Color.FromArgb(192, 192, 255)
                Me.BackColor = Color.FromArgb(255, 192, 255)
            Case Color.FromArgb(160, 160, 255)
                Me.BackColor = Color.FromArgb(255, 128, 255)
            Case Color.FromArgb(128, 128, 255)
                Me.BackColor = Color.Fuchsia
        End Select
        but(1) = but_sub1
        but(2) = but_sub2
        but(3) = but_sub3
        but(4) = but_sub4
        but(5) = but_sub5
        but(6) = but_sub6
        but(7) = but_sub7
        but(8) = but_sub8
        but(9) = but_sub9
        For i = 3 To 9
            but(i).Left = 402
        Next

    End Sub
    Private Sub colortimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colortimer.Tick
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

    Private Sub detectimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detectimer.Tick
        Select Case stuclr
            Case 1
                If Not (Me.BackColor.G = 192) Then
                    getc(255, 192, 255)
                End If
            Case 2
                If Not (Me.BackColor.G = 160) Then
                    getc(255, 160, 255)
                End If
            Case 3
                If Not (Me.BackColor.B = 128) Then
                    getc(255, 128, 255)
                End If
        End Select
        For i = 1 To 9
            If onf(i) = 1 Then
                If but(i).Left > 330 Then
                    but(i).Left = but(i).Left - 4
                ElseIf but(i).Left > 328 Then
                    but(i).Left = but(i).Left - 2
                Else
                    onf(i) = 0
                End If
            ElseIf onf(i) = 2 Then
                If but(i).Left < 402 Then
                    but(i).Left = but(i).Left + 4
                Else
                    but(i).Left = 402
                    onf(i) = 0
                End If
            End If
        Next
    End Sub

    Private Sub but_sub1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub1.Click
        If mode = 0 Then
            mode = 1
        Else
            If mode = (1 Or 2) Then
                mode = 0
            Else
                Dim n As String
                n = mode
                mode = Val(Mid(n, 1, Len(n) - 1))
            End If

        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub2.Click
        If mode = 0 Then
            mode = 2
        ElseIf mode = 1 Then
            mode = 11
        ElseIf mode = 2 Then
            mode = 21
        ElseIf mode = 11 Then
            mode = 111
        ElseIf mode = 12 Then
            mode = 121
        ElseIf mode = 13 Then
            mode = 131
        ElseIf mode = 14 Then
            mode = 141
        End If
        mdcng(mode)
    End Sub

    Private Sub but_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_end.Click
        Me.Close()
    End Sub

    Private Sub but_sub3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub3.Click
        If mode = 1 Then
            mode = 12
        ElseIf mode = 2 Then
            mode = 22
        ElseIf mode = 11 Then
            mode = 112
        ElseIf mode = 12 Then
            mode = 122
        ElseIf mode = 13 Then
            mode = 132
        ElseIf mode = 14 Then
            mode = 142
        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub4.Click
        If mode = 1 Then
            mode = 13
        ElseIf mode = 2 Then
            mode = 23
        ElseIf mode = 12 Then
            mode = 123
        ElseIf mode = 13 Then
            mode = 133
        ElseIf mode = 14 Then
            mode = 143
        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub5.Click
        If mode = 1 Then
            mode = 14
        ElseIf mode = 2 Then
            mode = 24
        ElseIf mode = 13 Then
            mode = 134
        ElseIf mode = 14 Then
            mode = 144
        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub6.Click
        If mode = 13 Then
            mode = 135
        ElseIf mode = 2 Then
            mode = 25
        ElseIf mode = 14 Then
            mode = 145
        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub7.Click
        If mode = 13 Then
            mode = 136
        ElseIf mode = 2 Then
            mode = 26
        ElseIf mode = 14 Then
            mode = 146
        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub8.Click
        If mode = 2 Then
            mode = 27
        End If
        mdcng(mode)
    End Sub

    Private Sub but_sub9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sub9.Click
        If mode = 2 Then
            mode = 28
        End If
        mdcng(mode)
    End Sub
End Class