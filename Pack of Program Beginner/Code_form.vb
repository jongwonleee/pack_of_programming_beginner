Public Class Code_form
    Dim fir, user, fr(200000) As String
    Dim tb, eos, tbd(200000, 2), endneed(200000, 2), n As Integer
    Dim kran As Integer

    Private Sub Code_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kran = 96
        fircode()
        usecode()
        Codebox.Text = user
        Me.Focus()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_but.Click
        Main_form.Enabled = True
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_but.Click
        user_but.BackColor = SystemColors.GrayText
        first_but.BackColor = SystemColors.Control
        Codebox.Text = user
    End Sub

    Private Sub first_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_but.Click
        user_but.BackColor = SystemColors.Control
        first_but.BackColor = SystemColors.GrayText
        Codebox.Text = fir
    End Sub

    Private Function fircode() As action
        fir = "' 이 이하는 Designer.vb 부분에 삽입되는 함수입니다" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10)
        fir = fir & "' 변수의 타이핑을 가능하게 해줄 Label 1개 생성" & Chr(13) & Chr(10)
        For i = 1 To 1
            fir = fir & "Me.Label" & i & " = New System.Windows.Forms.Label" & Chr(13) & Chr(10)
        Next

        If sndn > 0 Then
            fir = fir & "' 각 소리에 관한 미디어 플레이어 생성" & Chr(13) & Chr(10)
            For i = 1 To sndn
                fir = fir & "Me." & snd(i).nam & " = New AxMediaPlayer.AxMediaPlayer" & Chr(13) & Chr(10)
            Next
        End If



        If obn > 0 Then
            fir = fir & "' 각 물체에 관한 Picturebox 생성" & Chr(13) & Chr(10)
            For i = 1 To obn
                fir = fir & "Me." & obj(i).nam & " = New System.Windows.Forms.PictureBox" & Chr(13) & Chr(10)
            Next
            For i = 1 To obn
                fir = fir & "CType(Me." & obj(i).nam & ", System.ComponentModel.ISupportInitialize).BeginInit()" & Chr(13) & Chr(10)
            Next
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                fir = fir & "CType(Me." & snd(i).nam & ", System.ComponentModel.ISupportInitialize).BeginInit()" & Chr(13) & Chr(10)
            Next
        End If
        fir = fir & "Me.SuspendLayout()" & Chr(13) & Chr(10)
        fir = fir & Chr(13) & Chr(10) & Chr(13) & Chr(10)

        For i = 1 To 1
            fir = fir & "Me.Label" & i & ".AutoSize = True ' 이 Label의 크기가 문자열의 길이에 바뀌게 함" & Chr(13) & Chr(10)
            fir = fir & "Me.Label" & i & ".Location = New System.Drawing.Point(0,0) ' 이 Label은 (0,0)에 나타남" & Chr(13) & Chr(10)
            fir = fir & "Me.Label" & i & ".Name = " & Me.Tag & "Label" & i & Me.Tag & Chr(13) & Chr(10)
            fir = fir & "Me.Label" & i & ".Size = New System.Drawing.Size(42, 12) ' 이 Label의 크기는 (42,12)" & Chr(13) & Chr(10)
            fir = fir & "Me.Label" & i & ".TabIndex =" & i - 1 & Chr(13) & Chr(10)
            fir = fir & "Me.Label" & i & ".Text = "" ' 이 Label에는 아무것도 쓰여있지 않음" & Chr(13) & Chr(10)
            fir = fir & "Me.Label" & i & ".Visible = False ' 이 Label은 보이지 않음" & Chr(13) & Chr(10)
            fir = fir & Chr(13) & Chr(10)
        Next

        If obn > 0 Then
            For i = 1 To obn
                fir = fir & "Me." & obj(i).nam & ".Location = New System.Drawing.Point(0,0) ' 이 Picturebox은 (0,0)에 나타남" & Chr(13) & Chr(10)
                fir = fir & "Me." & obj(i).nam & ".Name = " & Me.Tag & obj(i).nam & Me.Tag & Chr(13) & Chr(10)
                fir = fir & "Me." & obj(i).nam & ".Size = New System.Drawing.Size(" & obj(obn).x & obj(obn).y & ") ' 이 Picturebox의 크기는 (" & obj(obn).x & obj(obn).y & ")" & Chr(13) & Chr(10)
                fir = fir & "Me." & obj(i).nam & ".TabIndex = " & 9 + i & Chr(13) & Chr(10)
                fir = fir & "Me." & obj(i).nam & ".TabStop = False" & Chr(13) & Chr(10)
                fir = fir & "Me." & obj(i).nam & ".Sizemode = StretchImage ' 이 Picturebox의 이미지를 Picturebox의 크기에 맞춤" & Chr(13) & Chr(10)
                fir = fir & Chr(13) & Chr(10)
            Next
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                fir = fir & "Me.AxMediaPlayer" & i & ".Location = New System.Drawing.Point(0, 0) ' 이 미디어플레이어는 (0,0)에 나타남" & Chr(13) & Chr(10)
                fir = fir & "Me.AxMediaPlayer" & i & ".Name = " & Me.Tag & snd(i).nam & Me.Tag & " ' 이 미디어플레이어의 이름은 " & snd(i).nam & Chr(13) & Chr(10)
                fir = fir & "Me.AxMediaPlayer" & i & ".OcxState = CType(Resources.GetObject(" & Me.Tag & "AxMediaPlayer1.OcxState" & Me.Tag & "), System.Windows.Forms.AxHost.State)" & Chr(13) & Chr(10)
                fir = fir & "Me.AxMediaPlayer" & i & ".Size = New System.Drawing.Size(286, 126) ' 이 미디어플레이어의 크기는 (286,126) " & Chr(13) & Chr(10)
                fir = fir & "Me.AxMediaPlayer" & i & ".TabIndex = " & 9 + obn + i & Chr(13) & Chr(10)
                fir = fir & "Me.AxMediaPlayer" & i & ".Visible = False ' 이 미디어플레이어는 보이지 않음" & Chr(13) & Chr(10)
                fir = fir & Chr(13) & Chr(10)
            Next
        End If


        fir = fir & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        If sndn > 0 Then
            For i = 1 To sndn
                fir = fir & "Me.Controls.Add(Me." & snd(i).nam & ") ' 미디어 플레이어 컨트롤을 추가함" & Chr(13) & Chr(10)
            Next
        End If

        For i = 1 To 1
            fir = fir & "Me.Controls.Add(Me.Label" & i & ") ' Label" & i & " 컨트롤을 추가함" & Chr(13) & Chr(10)
        Next

        If obn > 0 Then
            For i = 1 To obn
                fir = fir & "Me.Controls.Add(Me." & obj(i).nam & ") ' " & obj(i).nam & " 컨트롤을 추가함" & Chr(13) & Chr(10)
            Next
        End If

        fir = fir & "Me.Name = Form1 '폼의 이름은 Form1" & Chr(13) & Chr(10)
        fir = fir & "Me.Text = Form1 '폼의 캡션은 Form1" & Chr(13) & Chr(10)

        If obn > 0 Then
            For i = 1 To obn
                fir = fir & "CType(Me." & obj(i).nam & ", System.ComponentModel.ISupportInitialize).EndInit()" & Chr(13) & Chr(10)
            Next
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                fir = fir & "CType(Me." & snd(i).nam & ", System.ComponentModel.ISupportInitialize).EndInit()" & Chr(13) & Chr(10)
            Next
        End If


        fir = fir & Chr(13) & Chr(10) & "'이 이하는 Form1.vb 부분에 삽입되는 함수입니다" & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10)

        fir = fir & "Public Class Form1" & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        tb = tb + 1

        If valn > 0 Then
            Dim inte, sin, lon, str As String
            inte = ""
            sin = ""
            lon = ""
            str = ""
            For i = 1 To valn
                Select Case vall(i).type
                    Case 0
                        inte = inte & ", " & vall(i).nam
                    Case 1
                        lon = lon & ", " & vall(i).nam
                    Case 2
                        sin = sin & ", " & vall(i).nam
                    Case 3
                        str = str & ", " & vall(i).nam
                End Select
            Next
            If inte <> "" Then
                fir = fir & tab(tb) & "Dim " & Mid(inte, 2) & " As Integer ' 작은 정수형 변수 선언" & Chr(13) & Chr(10)
            End If
            If lon <> "" Then
                fir = fir & tab(tb) & "Dim " & Mid(lon, 2) & " As Long ' 큰 정수형 변수 선언" & Chr(13) & Chr(10)
            End If
            If sin <> "" Then
                fir = fir & tab(tb) & "Dim " & Mid(sin, 2) & " As Single ' 실수형 변수 선언" & Chr(13) & Chr(10)
            End If
            If str <> "" Then
                fir = fir & tab(tb) & "Dim " & Mid(str, 2) & " As String ' 문자형 변수 선언" & Chr(13) & Chr(10)
            End If
        End If

        fir = fir & tab(tb) & "Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' Form1이 실행될 때" & Chr(13) & Chr(10)
        tb = tb + 1
        fir = fir & tab(tb) & "Me.Width = " & Main_form.display.Width & " ' 이 폼의 폭은 " & Main_form.display.Width & Chr(13) & Chr(10)
        fir = fir & tab(tb) & "Me.Height = " & Main_form.display.Height & " '이 폼의 높이는 " & Main_form.display.Height & Chr(13) & Chr(10)
        fir = fir & tab(tb) & "Me.Backcolor = Color.FromArgb(" & bgcolor.R & "," & bgcolor.G & "," & bgcolor.B & ") ' 이 폼의 배경색은 RGB(" & bgcolor.R & "," & bgcolor.G & "," & bgcolor.B & ")이다" & Chr(13) & Chr(10)
        If bgimgname <> "" Then
            fir = fir & tab(tb) & "Me.BackgroundImage = Image.FromFile(" & Me.Tag & bgimgname & Me.Tag & ") '이 폼의 배경그림은 " & bgimgname & "에서 가져온다" & Chr(13) & Chr(10)
            Select Case Main_form.display.BackgroundImageLayout
                Case ImageLayout.None
                    fir = fir & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.None ' 이 폼의 배경그림이 좌측 상단부터 나타남" & Chr(13) & Chr(10)
                Case ImageLayout.Center
                    fir = fir & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Center ' 이 폼의 배경그림이 폼 크기에 맞게 늘림" & Chr(13) & Chr(10)
                Case ImageLayout.Stretch
                    fir = fir & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Stretch ' 이 폼의 배경그림이 우측 상단부터 나타남" & Chr(13) & Chr(10)
                Case ImageLayout.Tile
                    fir = fir & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Tile ' 이 폼의 배경그림이 바둑판 식으로 배열됨" & Chr(13) & Chr(10)
                Case ImageLayout.Zoom
                    fir = fir & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Stretch ' 이 폼의 배경그림이 폼 크기에 맞게 확대됨" & Chr(13) & Chr(10)
            End Select
            fir = fir & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        End If

        If obn > 0 Then
            For i = 1 To obn
                fir = fir & tab(tb) & obj(i).nam & ".Image = Image.FromFile(" & Me.Tag & obj(i).save & Me.Tag & ") ' 이 Picturebox의 그림을 " & obj(i).save & " 에서 가져옴" & Chr(13) & Chr(10)
            Next
            fir = fir & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                fir = fir & tab(tb) & snd(i).nam & ".FileName = " & Me.Tag & snd(i).save & Me.Tag & " ' 이 미디어플레이어의 소리를 " & snd(i).save & " 에서 가져옴" & Chr(13) & Chr(10)
            Next
            fir = fir & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        End If

        If valn > 0 Then
            For i = 1 To valn
                If vall(i).type = 3 Then
                    fir = fir & tab(tb) & vall(i).nam & " = " & Me.Tag & vall(i).first & Me.Tag & "' 이 변수의 초기 값 지정" & Chr(13) & Chr(10)
                Else
                    fir = fir & tab(tb) & vall(i).nam & " = " & vall(i).first & "' 이 변수의 초기 값 지정" & Chr(13) & Chr(10)
                End If
            Next
        End If

        fir = fir & tab(tb) & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10)
        tb = tb - 1
        fir = fir & tab(tb) & "End Sub" & Chr(13) & Chr(10)
        tb = tb - 1
        fir = fir & tab(tb) & "End Class" & Chr(13) & Chr(10)


    End Function

    Private Function tab(ByVal k As Integer) As String
        Dim tabbed As String
        tabbed = ""
        If k > 0 Then
            For i = 1 To k
                tabbed = tabbed & vbTab
            Next

        End If
        Return tabbed
    End Function

    Private Function usecode() As action
        user = "'이 이하는 Form1.vb 부분에 삽입되는 함수입니다" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10) & "'" & Chr(13) & Chr(10)
        tb = 0
        Dim tg, nonam, num(3) As String
        n = 0
        For a = 0 To sz(1)
            For b = -1 To sz(2)
                For c = -1 To sz(3)
                    For d = -1 To sz(4)
                        For e = -1 To sz(5)
                            For f = -1 To sz(6)
                                For g = 1 To 1
                                    If a < 10 Then
                                        num(1) = "10" & gsp(a) & gsp(b)
                                    Else
                                        num(1) = "1" & gsp(a) & gsp(b)
                                    End If
                                    If gsp(c) = "" Then
                                        num(2) = "1" & gsp(c)
                                    Else
                                        num(2) = "1" & gsp(c) & gsp(d)
                                    End If
                                    If gsp(e) = "" Then
                                        num(3) = "1" & gsp(e)
                                    Else
                                        num(3) = "1" & gsp(e) & gsp(f)
                                    End If
                                    If Len(num(1)) < 4 And Len(num(2)) > 1 Then
                                        Exit For
                                    End If
                                    If Len(num(2)) < 3 And Len(num(3)) > 1 Then
                                        Exit For
                                    End If
                                    If scr(num(1), num(2), num(3)) = "" Then
                                        Exit For
                                    Else
                                        tg = scr(num(1), num(2), num(3))
                                        If nonam = Mid(num(1), 2) & Mid(num(2), 2) & Mid(num(3), 2) Then
                                            Exit For
                                        End If
                                        nonam = Mid(num(1), 2) & Mid(num(2), 2) & Mid(num(3), 2)
                                        tb = Len(nonam) - 2
                                        n = n + 1
                                        tbd(n, 1) = tb


                                        If tbd(n, 1) < tbd(n - 1, 1) And Not (tbd(n - 1, 2) = 0) Then
                                            fr(n) = Chr(13) & Chr(10)
                                            tbd(n, 2) = 0
                                            tbd(n, 1) = tbd(n - 1, 1)
                                            endneed(n, 2) = tbd(n - 1, 2)
                                            endneed(n, 1) = tbd(n - 1, 1)
                                            n = n + 1
                                        End If
                                        Do While tb < tbd(n - 1, 1)
                                            fr(n) = Chr(13) & Chr(10)
                                            tbd(n, 2) = 0
                                            For i = n - 2 To 1 Step -1
                                                If tbd(n - 1, 1) - 1 = tbd(i, 1) Then
                                                    endneed(n, 1) = tbd(i, 1)
                                                    endneed(n, 2) = tbd(i, 2)
                                                    Exit For
                                                End If
                                            Next
                                            tbd(n, 1) = endneed(n, 1)
                                            n = n + 1
                                        Loop

                                        fr(n) = tab(tb) & useline(tg) & Chr(13) & Chr(10)
                                        tbd(n, 1) = tb
                                        tbd(n, 2) = eos



                                    End If
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next

        ending(0)

        endnod()

        For i = 1 To n
            user = user & fr(i)
        Next


    End Function

    Private Sub ending(ByVal k As Integer)

        Do While tbd(n, 1) >= k
            If Not (tbd(n, 2) = 0) Then
                n = n + 1
                tbd(n, 1) = tbd(n - 1, 1)
                tbd(n, 2) = 0
                endneed(n, 1) = tbd(n - 1, 1)
                endneed(n, 2) = tbd(n - 1, 2)
                fr(n) = tab(endneed(n, 1)) & Chr(13) & Chr(10)
            Else
                n = n + 1
                For i = n - 2 To 1 Step -1
                    If tbd(n - 1, 1) - 1 = tbd(i, 1) Then
                        endneed(n, 1) = tbd(i, 1)
                        endneed(n, 2) = tbd(i, 2)
                        Exit For
                    End If
                Next
                fr(n) = tab(endneed(n, 1)) & Chr(13) & Chr(10)
                tbd(n, 2) = 0
                tbd(n, 1) = tbd(n - 1, 1) - 1

            End If
        Loop
    End Sub



    Private Sub endnod()

        Dim cnt As Integer
        Dim fin As String
        cnt = 1
        fin = ""

        Do While cnt <= n
            cnt = cnt + 1
            If Not (endneed(cnt, 2) = 0) Then
                If endneed(cnt, 2) = 1 Then
                    fin = "End If"
                ElseIf endneed(cnt, 2) = 2 Then
                    fin = "Loop"
                ElseIf endneed(cnt, 2) = 3 Then
                    fin = "Next"
                ElseIf endneed(cnt, 2) = 4 Then
                    fin = "End Sub"
                End If
                fr(cnt) = tab(endneed(cnt, 1)) & fin & Chr(13) & Chr(10)
            End If

        Loop

    End Sub



    Private Function useline(ByVal tag As String) As String
        Dim n(10), ln As String
        Dim a As Integer
        Dim nFind, nlast As Integer

        ln = ""
        eos = 0
        For i = 1 To 10
            n(i) = ""
        Next

        If tag = "0" Then

        End If
        a = 0
        nFind = tag.IndexOf(",")
        nlast = tag.LastIndexOf(",")
        If Not (nlast = -1) Then
            Do While nFind < nlast
                a = a + 1
                n(a) = Mid(tag, 1, nFind)
                tag = Mid(tag, nFind + 2)
                nFind = tag.IndexOf(",")
                nlast = tag.LastIndexOf(",")

            Loop
            If nFind = nlast Then
                a = a + 1
                n(a) = Mid(tag, 1, nFind)
                a = a + 1
                n(a) = Mid(tag, nFind + 2)
            End If

            For i = 1 To a
                If Mid(n(i), 1, 2) = "★∴" Then
                    n(i) = Mid(n(i), 3)
                End If
            Next
        ElseIf (nlast = -1) And (nFind = -1) Then
            n(1) = tag
        End If

        If n(1) = 0 Then
            ln = Chr(13) & Chr(10) & "Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load ' Form1이 실행될 때"
            eos = 4 ' End Sub
        ElseIf n(1) = 1 Then
            ln = "If " & n(2) & " = " & n(3) & " Then"
            eos = 1 ' End If
        ElseIf n(1) = 2 Then
            ln = "If " & n(2) & " >= " & n(3) & " Then"
            eos = 1 ' End If
        ElseIf n(1) = 3 Then
            ln = "If " & n(2) & " <= " & n(3) & " Then"
            eos = 1 ' End If

        ElseIf n(1) = 4 Then
            ln = "If " & n(2) & " > " & n(3) & " then"
            eos = 1 ' End If

        ElseIf n(1) = 5 Then
            ln = "If " & n(2) & " < " & n(3) & " then"
            eos = 1 ' End If

        ElseIf n(1) = 6 Then
            ln = Chr(13) & Chr(10) & "Private Sub " & n(2) & "_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles " & n(2) & "_Click"
            eos = 4
        ElseIf n(1) = 7 Then
            ln = Chr(13) & Chr(10) & "Private Sub " & n(2) & "_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles " & n(2) & ".DoubleClick"
            eos = 4
        ElseIf n(1) = 8 Then
            ln = Chr(13) & Chr(10) & "Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown"
            eos = 4
        ElseIf n(1) = 9 Then
            ln = "If e.KeyCode = keys." & n(2) & " Then "
            eos = 1 ' End If

        ElseIf n(1) = 11 Then
            ln = n(2) & ".Visible = True"
        ElseIf n(1) = 12 Then
            ln = n(2) & ".Visible = False"
        ElseIf n(1) = 13 Then
            ln = n(2) & ".Left = " & n(2) & ".Left + " & n(3)
        ElseIf n(1) = 14 Then
            ln = n(2) & ".Top = " & n(2) & ".Top + " & n(3)
        ElseIf n(1) = 15 Then
            ln = n(2) & ".Location = New Point(" & n(3) & ", " & n(4) & ") "
        ElseIf n(1) = 16 Then
            ln = "Label1.Text = " & n(2) & Chr(13) & Chr(10) & tab(tb) & "Label1.Location = New Point(" & n(3) & ", " & n(4) & ") "
        ElseIf n(1) = 17 Then
            ln = n(2) & ".Play()"
        ElseIf n(1) = 18 Then
            ln = n(2) & ".Stop()"
        ElseIf n(1) = 19 Then
            Dim loc As Integer
            For i = 1 To obn
                If obj(i).nam = n(2) Then
                    loc = i
                End If
            Next
            ln = "Me.BackgroundImage = Image.FromFile(" & obj(loc).save & ")"
        ElseIf n(1) = 20 Then
            ln = "Me.Backcolor = Color.FromArgb(" & n(2) & ", " & n(3) & ", " & n(4) & ")"
        ElseIf n(1) = 21 Then
            ln = n(2) & " = " & n(3)
        ElseIf n(1) = 22 Then
            ln = n(2) & " = " & n(3) & " + " & n(4)
        ElseIf n(1) = 23 Then
            ln = n(2) & " = " & n(3) & " - " & n(4)
        ElseIf n(1) = 24 Then
            ln = n(2) & " = " & n(3) & " * " & n(4)
        ElseIf n(1) = 25 Then
            ln = n(2) & " = " & n(3) & " / " & n(4)
        ElseIf n(1) = 26 Then
            ln = "Me.Close()"
        ElseIf n(1) = 31 Then
            ln = "Do While " & n(2) & " = " & n(3)
            eos = 2 ' Loop
        ElseIf n(1) = 32 Then
            ln = "Do While Not (" & n(2) & " = " & n(3) & ")"
            eos = 2 ' Loop
        ElseIf n(1) = 33 Then
            ln = "Do While " & n(2) & " >= " & n(3)
            eos = 2 ' Loop
        ElseIf n(1) = 34 Then
            ln = "Do While " & n(2) & " <= " & n(3)
            eos = 2 ' Loop
        ElseIf n(1) = 35 Then
            ln = "Do While " & n(2) & " > " & n(3)
            eos = 2 ' Loop
        ElseIf n(1) = 36 Then
            ln = "Do While " & n(2) & " < " & n(3)
            eos = 2 ' Loop
        ElseIf n(1) = 37 Then
            Dim ran As String
            kran = kran + 1
            If kran > 122 Then
                kran = 97
            End If
            ran = Chr(kran)
            ln = "For " & ran & ran & " = 1 to " & n(2)
            eos = 3 ' Next
        End If
        Return ln

    End Function


End Class