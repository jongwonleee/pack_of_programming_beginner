Imports System.IO
Imports System.Windows
Imports System.Drawing.Graphics


Public Class Main_form
    Dim fmcolor, nowfm, num1, num2, dison, fmx, fmy, lfmx, lfmy, listn, plyn, barn, actd, actx, acty, actr, actg, actb, dblclk, dbldbclk, kp, tb, eos, tbd(200000, 2), endneed(200000, 2), kran, n, mx, myy, mmon As Integer
    Dim sectxt, seccom, trdtxt, trdcom, firn, secn, trdn, firnn, secnn, trdnn, nn(10), des, cod, fr(200000) As String
    Dim actclr As Color
    Dim bmp As New Bitmap(1024, 700)
    Dim show_form As New Form

    Private Sub Main_form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tutorial_form.Close()
        ask_form.Close()
        Code_form.Close()
        Setting_form.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        slist.Enabled = False
        obread.Enabled = True
        picblack.Visible = False
        hruler.Top = display.Top + display.Height
        hruler.Width = display.Width
        vruler.Left = display.Left + display.Width
        vruler.Height = display.Height
        fmcolor = 1
        nowfm = 1
        num1 = 128
        kran = 96
        num2 = 128
        dison = 0
        bgcolor = display.BackColor
        bgx = display.Width
        bgy = display.Height
        bgimg = display.BackgroundImage
        fmx = Me.Width
        fmy = Me.Height
        lfmx = Me.Width
        lfmy = Me.Height
        display.Width = 800
        hruler.Top = display.Top + display.Height
        hruler.Width = display.Width + 2
        vruler.Left = display.Left + display.Width
        vruler.Height = display.Height
        cngnum = 0
        setbox.Visible = False
        setbox.Enabled = False
        slist.Items.Clear()
        slist.Items.Add("만약 ＿＿가 ＿＿라면")
        slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
        slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
        slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
        slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
        slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
        slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
        slist.Items.Add("키보드가 눌렸을 때")
        slist.Items.Add("(키보드)＿＿가 눌렸을 때")
        slist.Items.Add("＿＿초 후에")
        slist.Items.Add("")
        For i = 1 To 100
            vall(i).nam = ""
        Next
        barn = 1
        listn = 0
        dblclk = 0
        dbldbclk = 0
        kp = 0
        scr(100, 1, 1) = 0
        For a = 1 To 6
            sz(a) = -1
        Next
        openask()
        example()
    End Sub

    Private Sub example()
        Dim exam As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\PProgramming\Examples\Calculator\1.bmp"
        Dim saving As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Dim folder As String = My.Application.Info.DirectoryPath & "\PProgramming"
        If My.Computer.FileSystem.FileExists(exam) = False Then
            My.Computer.FileSystem.CopyDirectory(folder, Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\PProgramming", True)
            My.Computer.FileSystem.CopyDirectory(folder, "C:\PProgramming", True)
        End If
    End Sub

    Private Sub openask()
        Dim check As String = My.Application.Info.DirectoryPath & "\readfirst.dat"
        If My.Computer.FileSystem.FileExists(check) = False Then
            Me.Enabled = False
            ask_form.Show()
            ask_form.TopMost = True
        End If
    End Sub

    Private Sub PictureBox2_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles display.ClientSizeChanged '디스플레이 사이즈 변환시
        sizecng()
    End Sub
    Private Sub but_script_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_script.Click  '스크립트 창 버튼
        If Not fmcolor = 1 Then
            colortimer.Enabled = True
            nowfm = fmcolor
            fmcolor = 1
        End If
        slist.Enabled = False
        listbar.Enabled = True
        listbar.Visible = True
        actbox.Enabled = True
        setbox.Enabled = True
        obbox.Visible = False
        sndbox.Visible = False
        listbar.Image = My.Resources.jobar '조건
        slist.Items.Clear()
        slist.Items.Add("만약 ＿＿가 ＿＿라면")
        slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
        slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
        slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
        slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
        slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
        slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
        slist.Items.Add("키보드가 눌렸을 때")
        slist.Items.Add("(키보드)＿＿가 눌렸을 때")
        slist.Items.Add("＿＿초 후에")
        slist.Items.Add("")
        barn = 1
    End Sub

    Private Sub but_object_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_object.Click '물체 창 버튼
        If Not fmcolor = 2 Then
            colortimer.Enabled = True
            nowfm = fmcolor
            fmcolor = 2
        End If
        setbox.Visible = False
        listbar.Visible = False
        obbox.Enabled = True
        sndbox.Visible = False
        actbox.Visible = False
        slist.Enabled = True
        slist.Items.Clear()
        For i = 1 To obn
            slist.Items.Add(obj(i).nam)
        Next
        slist.Items.Add("(추가)")
        slist.Items.Add("")
    End Sub
    Private Sub but_sound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_sound.Click '소리 창 버튼
        If Not fmcolor = 3 Then
            colortimer.Enabled = True
            nowfm = fmcolor
            fmcolor = 3
        End If
        setbox.Visible = False
        listbar.Visible = False
        obbox.Visible = False
        sndbox.Enabled = True
        actbox.Visible = False
        slist.Enabled = True
        slist.Items.Clear()
        For i = 1 To sndn
            slist.Items.Add(snd(i).nam)
        Next
        slist.Items.Add("(추가)")
        slist.Items.Add("")
    End Sub

    Private Sub colortimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colortimer.Tick '배경 색 변환
        If nowfm = 1 Then '스크립트
            If fmcolor = 2 Then
                If num2 < 255 Then
                    num2 = num2 + 8
                    If num2 > 255 Then
                        num2 = 255
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                ElseIf num2 >= 255 Then
                    colortimer.Enabled = False
                End If
            ElseIf fmcolor = 3 Then
                If num1 < 255 Then
                    num1 = num1 + 8
                    If num1 > 255 Then
                        num1 = 255
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                ElseIf num1 >= 255 Then
                    colortimer.Enabled = False
                End If
            End If
        ElseIf nowfm = 2 Then ' 물체
            If fmcolor = 1 Then
                If num2 > 128 Then
                    num2 = num2 - 8
                    If num2 < 128 Then
                        num2 = 128
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                ElseIf num2 <= 128 Then
                    colortimer.Enabled = False
                End If
            ElseIf fmcolor = 3 Then
                If num1 < 255 Then
                    num1 = num1 + 8
                    If num1 > 255 Then
                        num1 = 255
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                End If
                If num2 > 128 Then
                    num2 = num2 - 8
                    If num2 < 128 Then
                        num2 = 128
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                End If
                If num1 >= 255 And num2 <= 128 Then
                    colortimer.Enabled = False
                End If
            End If
        ElseIf nowfm = 3 Then '소리
            If fmcolor = 1 Then
                If num1 > 128 Then
                    num1 = num1 - 8
                    If num1 < 128 Then
                        num1 = 128
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                ElseIf num1 <= 128 Then
                    colortimer.Enabled = False
                End If
            ElseIf fmcolor = 2 Then
                If num1 > 128 Then
                    num1 = num1 - 8
                    If num1 < 128 Then
                        num1 = 128
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                End If
                If num2 < 255 Then
                    num2 = num2 + 8
                    If num2 > 255 Then
                        num2 = 255
                    End If
                    Me.BackColor = Color.FromArgb(num1, 255, num2)
                End If
                If num1 <= 128 And num2 >= 255 Then
                    colortimer.Enabled = False
                End If
            End If
        End If
    End Sub


    Private Sub but_ask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_ask.Click '실행 버튼
        Me.Enabled = False
        ask_form.Show()
    End Sub

    Private Sub but_set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_set.Click '설정버튼
        Me.Enabled = False
        Setting_form.Show()

    End Sub

    Private Sub PictureBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listbar.MouseClick
        Dim selenod As TreeNode
        If script.SelectedNode Is Nothing Then
        Else
            selenod = script.SelectedNode
        End If
        If (e.Y > 2) Or (e.Y <= 21) Then
            If e.X > 210 And e.X <= 210 + 59 Then
                slist.Enabled = True
                listbar.Image = My.Resources.dimbar '변수
                slist.Items.Clear()
                For i = 1 To valn
                    slist.Items.Add(vall(i).nam)
                Next
                slist.Items.Add("(추가)")
                slist.Items.Add("")
                barn = 4
            Else
            End If
        End If

        If (e.Y > 2) Or (e.Y <= 21) Then
            If e.X > 15 And e.X <= 15 + 59 Then
                listbar.Image = My.Resources.jobar '조건
                If selenod Is Nothing Then
                    slist.Items.Clear()
                    slist.Items.Add("만약 ＿＿가 ＿＿라면")
                    slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
                    slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
                    slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
                    slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
                    slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
                    slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
                    slist.Items.Add("키보드가 눌렸을 때")
                    slist.Items.Add("(키보드)＿＿가 눌렸을 때")
                    'slist.Items.Add("＿＿초 후에")
                    slist.Items.Add("")
                    barn = 1
                Else
                    If selenod.Parent Is Nothing Then
                        slist.Items.Clear()
                        slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
                        slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
                        slist.Items.Add("키보드가 눌렸을 때")
                        slist.Items.Add("")
                        barn = 1
                    Else
                        slist.Items.Clear()
                        slist.Items.Add("만약 ＿＿가 ＿＿라면")
                        slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
                        slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
                        slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
                        slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
                        slist.Items.Add("(키보드)＿＿가 눌렸을 때")
                        'slist.Items.Add("＿＿초 후에")
                        slist.Items.Add("")
                        barn = 1
                    End If
                    If selenod.Parent Is Nothing And Not (selenod.Text = "선택") Then
                        slist.Enabled = False
                    End If
                End If
            End If
        End If
        If Not (selenod Is Nothing) Then
            If Not (selenod.Parent Is Nothing) Then
                If e.X > 80 And e.X <= 80 + 59 Then
                    listbar.Image = My.Resources.actbar '동작
                    slist.Items.Clear()
                    slist.Items.Add("＿＿를 보이기")
                    slist.Items.Add("＿＿를 숨기기")
                    slist.Items.Add("＿＿를 x축으로 ＿＿만큼 이동")
                    slist.Items.Add("＿＿를 y축으로 ＿＿만큼 이동")
                    slist.Items.Add("＿＿를 ＿＿에 이동")
                    slist.Items.Add("'＿＿'라고 ＿＿에 타이핑 ")
                    slist.Items.Add("＿＿ 소리 1회 재생")
                    slist.Items.Add("＿＿ 소리 재생 멈추기")
                    slist.Items.Add("＿＿사진으로 배경화면 만들기")
                    slist.Items.Add("＿＿ 색으로 배경색 만들기")
                    slist.Items.Add("＿＿ = ＿＿")
                    slist.Items.Add("＿＿ = ＿＿ + ＿＿")
                    slist.Items.Add("＿＿ = ＿＿ - ＿＿")
                    slist.Items.Add("＿＿ = ＿＿ * ＿＿")
                    slist.Items.Add("＿＿ = ＿＿ / ＿＿")
                    slist.Items.Add("프로그램 종료")
                    slist.Items.Add("")
                    barn = 2
                End If
                If e.X > 145 And e.X <= 145 + 59 Then
                    listbar.Image = My.Resources.silbar '실행
                    slist.Items.Clear()
                    slist.Items.Add("＿＿가 ＿＿일 때 반복")
                    slist.Items.Add("＿＿가 ＿＿아닐 때 반복")
                    slist.Items.Add("＿＿가 ＿＿이상일 때 반복")
                    slist.Items.Add("＿＿가 ＿＿이하일 때 반복")
                    slist.Items.Add("＿＿가 ＿＿초과일 때 반복")
                    slist.Items.Add("＿＿가 ＿＿미만일 때 반복")
                    slist.Items.Add("＿＿번 반복")
                    slist.Items.Add("")
                    barn = 3
                End If
            End If
        End If

    End Sub

    Private Sub slist_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles slist.MouseClick
        If fmcolor = 1 Then
            If barn = 1 Then
                If slist.SelectedItem = "만약 ＿＿가 ＿＿라면" Then
                    listn = 1
                ElseIf slist.SelectedItem = "만약 ＿＿가 ＿＿이상이라면" Then
                    listn = 2
                ElseIf slist.SelectedItem = "만약 ＿＿가 ＿＿이하라면" Then
                    listn = 3
                ElseIf slist.SelectedItem = "만약 ＿＿가 ＿＿초과라면" Then
                    listn = 4
                ElseIf slist.SelectedItem = "만약 ＿＿가 ＿＿미만이라면" Then
                    listn = 5
                ElseIf slist.SelectedItem = "만약 (마우스)＿＿가 클릭되었을 때" Then
                    listn = 6
                ElseIf slist.SelectedItem = "만약 (마우스)＿＿가 더블클릭되었을 때" Then
                    listn = 7
                ElseIf slist.SelectedItem = "키보드가 눌렸을 때" Then
                    listn = 8
                ElseIf slist.SelectedItem = "(키보드)＿＿가 눌렸을 때" Then
                    listn = 9
                End If
                actshow(listn)
            ElseIf barn = 2 Then
                If slist.SelectedItem = "＿＿를 보이기" Then
                    listn = 11
                ElseIf slist.SelectedItem = "＿＿를 숨기기" Then
                    listn = 12
                ElseIf slist.SelectedItem = "＿＿를 x축으로 ＿＿만큼 이동" Then
                    listn = 13
                ElseIf slist.SelectedItem = "＿＿를 y축으로 ＿＿만큼 이동" Then
                    listn = 14
                ElseIf slist.SelectedItem = "＿＿를 ＿＿에 이동" Then
                    listn = 15
                ElseIf slist.SelectedItem = "'＿＿'라고 ＿＿에 타이핑 " Then
                    listn = 16
                ElseIf slist.SelectedItem = "＿＿ 소리 1회 재생" Then
                    listn = 17
                ElseIf slist.SelectedItem = "＿＿ 소리 재생 멈추기" Then
                    listn = 18
                ElseIf slist.SelectedItem = "＿＿사진으로 배경화면 만들기" Then
                    listn = 19
                ElseIf slist.SelectedItem = "＿＿ 색으로 배경색 만들기" Then
                    listn = 20
                ElseIf slist.SelectedItem = "＿＿ = ＿＿" Then
                    listn = 21
                ElseIf slist.SelectedItem = "＿＿ = ＿＿ + ＿＿" Then
                    listn = 22
                ElseIf slist.SelectedItem = "＿＿ = ＿＿ - ＿＿" Then
                    listn = 23
                ElseIf slist.SelectedItem = "＿＿ = ＿＿ * ＿＿" Then
                    listn = 24
                ElseIf slist.SelectedItem = "＿＿ = ＿＿ / ＿＿" Then
                    listn = 25
                ElseIf slist.SelectedItem = "프로그램 종료" Then
                    listn = 26
                End If
                If listn = (15 Or 16) Then
                    mmon = 1
                Else
                    mmon = 0
                End If
                actshow(listn)
            ElseIf barn = 3 Then
                If slist.SelectedItem = "＿＿가 ＿＿일 때 반복" Then
                    listn = 31
                ElseIf slist.SelectedItem = "＿＿가 ＿＿아닐 때 반복" Then
                    listn = 32
                ElseIf slist.SelectedItem = "＿＿가 ＿＿이상일 때 반복" Then
                    listn = 33
                ElseIf slist.SelectedItem = "＿＿가 ＿＿이하일 때 반복" Then
                    listn = 34
                ElseIf slist.SelectedItem = "＿＿가 ＿＿초과일 때 반복" Then
                    listn = 35
                ElseIf slist.SelectedItem = "＿＿가 ＿＿미만일 때 반복" Then
                    listn = 36
                ElseIf slist.SelectedItem = "＿＿번 반복" Then
                    listn = 37
                End If
                actshow(listn)
                mmon = 0
            ElseIf barn = 4 Then
                If slist.SelectedItem = "(추가)" Then
                    listn = 41
                    setbox.Enabled = True
                    setbox.Visible = True
                    settxt1.Enabled = True
                    settxt2.Enabled = False
                    actbox.Visible = False
                    setlab1.Text = "변수명"
                    setlab2.Text = "변수 종류"
                    setlab3.Text = "초기 변수값"
                    settxt1.Text = ""
                    settxt2.Text = ""
                    setex1.Text = "변수는 최대 100개 생성 가능합니다"
                    setok.Text = "추가"
                    setcom.Items.Clear()
                    setcom.Items.Add("작은 정수")
                    setcom.Items.Add("큰 정수")
                    setcom.Items.Add("실수")
                    setcom.Items.Add("문자열")
                    setcom.Text = "(선택)"
                ElseIf slist.SelectedIndex <= valn - 1 Then
                    Dim seln As Integer
                    listn = 42
                    seln = slist.SelectedIndex + 1
                    setbox.Enabled = True
                    setbox.Visible = True
                    actbox.Visible = False
                    settxt1.Enabled = False
                    settxt2.Enabled = False
                    setlab1.Text = "변수명"
                    setlab2.Text = "변수 종류"
                    setlab3.Text = "초기 변수값"
                    setex1.Text = "변수는 최대 100개 생성 가능합니다"
                    settxt1.Text = vall(seln).nam
                    settxt2.Text = vall(seln).first
                    setok.Text = "수정"
                    setcom.Items.Clear()
                    setcom.Items.Add("작은 정수")
                    setcom.Items.Add("큰 정수")
                    setcom.Items.Add("실수")
                    setcom.Items.Add("문자열")
                    setcom.SelectedIndex = vall(seln).type
                End If
                mmon = 0
            End If
        ElseIf fmcolor = 2 Then
            mmon = 0
            If slist.SelectedItem = "(추가)" Then
                listn = 1
                obbox.Visible = True
                obbox.Enabled = True
                obtxt1.Enabled = True
                obok.Text = "추가"
                obpic1.BackgroundImage = picblack.BackgroundImage
                obtxt1.Text = ""
                obtxt2.Text = ""
                obtxt3.Text = ""
                obtxt4.Text = ""
            ElseIf slist.SelectedIndex <= obn - 1 Then
                Dim seln As Integer
                listn = 2
                obbox.Visible = True
                obbox.Enabled = True
                obtxt1.Enabled = False
                seln = slist.SelectedIndex + 1
                obtxt1.Text = obj(seln).nam
                obtxt2.Text = obj(seln).x
                obtxt3.Text = obj(seln).y
                obtxt4.Text = obj(seln).save
                obpic1.BackgroundImage = Image.FromFile(obj(seln).save)
                obok.Text = "수정"
            End If
        ElseIf fmcolor = 3 Then
            mmon = 0
            If slist.SelectedItem = "(추가)" Then
                listn = 1
                sndbox.Visible = True
                sndbox.Enabled = True
                sndtxt1.Enabled = True
                sndtxt1.Text = ""
                sndtxt2.Text = ""
                sndtxt3.Text = ""
                sndlab5.Text = ""
                sndbar.Value = -5000
                sndbar.Enabled = False
                sndtxt3.Enabled = False
                sndplay.FileName = ""
                sndok.Text = "추가"
            ElseIf slist.SelectedIndex <= sndn - 1 Then
                Dim seln As Integer
                Dim sndt, sndn As String
                seln = slist.SelectedIndex + 1
                listn = 2
                sndbox.Visible = True
                sndbox.Enabled = True
                sndbar.Enabled = True
                sndtxt1.Enabled = False
                sndtxt3.Enabled = True
                sndtxt1.Text = snd(seln).nam
                sndtxt2.Text = snd(seln).save
                sndbar.Value = snd(seln).vol
                sndtxt3.Text = Int((sndbar.Value + 10000) / 100)
                sndplay.FileName = snd(seln).save
                sndplay.Stop()

                sndn = getname(snd(seln).save)
                sndt = gettime()
                sndlab5.Text = sndn & sndt
                plyn = 0
                sndpic1.Image = My.Resources.sndplay
                sndok.Text = "수정"
            End If
        End If
        If slist.SelectedItem = "" Then
            listn = 0
            setbox.Visible = False
            obbox.Visible = False
            sndbox.Visible = False
            actbox.Visible = False
        End If
    End Sub

    Private Sub setok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setok.Click
        If fmcolor = 1 Then
            If listn <= 42 And listn > 40 Then
                If settxt1.Text = "" Then
                    MessageBox.Show("변수명을 정해주세요")
                    settxt1.Focus()
                    GoTo Dasi
                End If
                If setcom.SelectedItem = "(선택)" Then
                    MessageBox.Show("변수 종류를 선택해주세요")
                    GoTo Dasi
                ElseIf setcom.SelectedItem = "작은 정수" Then
                    If settxt2.Text = "" Or settxt2.Text > 32767 Or settxt2.Text < -32768 Then
                        MessageBox.Show("작은 정수는 -32768에서 32767 사이에 있어야 합니다")
                        settxt2.Text = ""
                        settxt2.Focus()
                        GoTo dasi
                    End If
                ElseIf setcom.SelectedItem = " 큰 정수" Then
                    If settxt2.Text = "" Or settxt2.Text > 2147483687 Or settxt2.Text < -2147483648 Then
                        MessageBox.Show("큰 정수는 -2147483648에서 2147483687 사이에 있어야 합니다")
                        settxt2.Text = ""
                        settxt2.Focus()
                        GoTo dasi
                    End If
                End If
                For i = 1 To valn
                    If settxt1.Text = vall(valn).nam Then
                        MessageBox.Show("변수명이 중복됩니다.")
                        settxt1.Text = ""
                        settxt1.Focus()
                        GoTo dasi
                    End If
                Next
                If listn = 42 Then
                    Dim seln As Integer
                    seln = slist.SelectedIndex + 1
                    vall(seln).nam = settxt1.Text
                    vall(seln).type = setcom.SelectedIndex
                    vall(seln).first = settxt2.Text
                    slist.Items.Clear()
                    For i = 1 To valn
                        slist.Items.Add(vall(i).nam)
                    Next
                    slist.Items.Add("(추가)")
                    slist.Items.Add("")
                    MessageBox.Show("변수 " & vall(seln).nam & "(이)가 수정되었습니다.")
                End If
                If listn = 41 Then
                    valn = valn + 1
                    vall(valn).nam = settxt1.Text
                    vall(valn).type = setcom.SelectedIndex
                    vall(valn).first = settxt2.Text
                    slist.Items.Clear()
                    For i = 1 To valn
                        slist.Items.Add(vall(i).nam)
                    Next
                    slist.Items.Add("(추가)")
                    slist.Items.Add("")
                    If listn = 1 Then MessageBox.Show("변수 " & vall(valn).nam & "(이)가 추가되었습니다.")
                    settxt1.Text = ""
                    settxt2.Text = ""
                    setcom.Text = "(선택)"

                End If
Dasi:
            End If
        End If
    End Sub

    Private Sub setcom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles setcom.KeyPress
        e.Handled = True
    End Sub

    Private Sub setcom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setcom.SelectedIndexChanged
        If listn <= 42 And listn > 40 And fmcolor = 1 Then
            settxt2.Enabled = True
            If setcom.SelectedIndex = 0 Then setex1.Text = "작은 정수는 -32768에서 32767 사이의 정수 입니다."
            If setcom.SelectedIndex = 1 Then setex1.Text = "큰 정수는 -2147483648에서 2147483687 사이의 정수 입니다."
            If setcom.SelectedIndex = 2 Then setex1.Text = "실수는 소수점을 포함한 수 입니다."
            If setcom.SelectedIndex = 3 Then setex1.Text = "문자열은 문자를 포함할 수 있습니다."
        End If
    End Sub

    Private Sub settxt2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles settxt2.KeyDown
        If listn <= 42 And listn > 40 And fmcolor = 1 Then
            If Not setcom.SelectedItem = "문자열" Then
                If e.KeyValue = 8 Or e.KeyValue = 189 Or e.KeyValue = 109 Or e.KeyValue = 46 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
                Else
                    MessageBox.Show("숫자만 입력 가능합니다")
                    settxt2.Text = ""
                    settxt2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub obread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obread.Click
        If fmcolor = 2 And listn <= 2 Then
            Dim imgl As String
            Dim nimg As Image
            If openobj.ShowDialog = DialogResult.OK Then
                imgl = openobj.FileName
                nimg = Image.FromFile(imgl)
                obtxt4.Text = imgl
                obtxt2.Text = nimg.Width
                obtxt3.Text = nimg.Height
                obpic1.BackgroundImage = nimg
            End If
        End If
    End Sub

    Private Sub obok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obok.Click
        If fmcolor = 2 And listn <= 2 Then
            If obtxt1.Text = "" Then
                MessageBox.Show("물체명을 정해주세요.")
                obtxt1.Focus()
                GoTo dasi
            End If
            If obtxt4.Text = "" Then
                MessageBox.Show("물체의 이미지를 불러오세요.")
                obread.Focus()
                GoTo dasi
            End If
            If obtxt2.Text = "" Then
                MessageBox.Show("물체의 폭을 정해주세요.")
                obtxt2.Focus()
                GoTo dasi
            End If
            If obtxt3.Text = "" Then
                MessageBox.Show("물체의 높이를 정해주세요.")
                obtxt3.Focus()
                GoTo dasi
            End If
            If listn = 1 Then
                obn = obn + 1
                obj(obn).nam = obtxt1.Text
                obj(obn).save = obtxt4.Text
                obj(obn).x = Val(obtxt2.Text)
                obj(obn).y = Val(obtxt3.Text)
                slist.Items.Clear()
                For i = 1 To obn
                    slist.Items.Add(obj(i).nam)
                Next
                slist.Items.Add("(추가)")
                slist.Items.Add("")
                MessageBox.Show("물체 " & obj(obn).nam & "(이)가 추가되었습니다")
            End If
            If listn = 2 Then
                Dim seln As Integer
                seln = slist.SelectedIndex + 1
                obj(seln).nam = obtxt1.Text
                obj(seln).save = obtxt4.Text
                obj(seln).x = obtxt2.Text
                obj(seln).y = obtxt3.Text
                slist.Items.Clear()
                For i = 1 To obn
                    slist.Items.Add(obj(i).nam)
                Next
                slist.Items.Add("(추가)")
                slist.Items.Add("")
                MessageBox.Show("물체 " & obj(seln).nam & "(이)가 수정되었습니다")
            End If
            obbox.Visible = True
            obbox.Enabled = True
            obtxt1.Enabled = True
            obok.Text = "추가"
            obpic1.BackgroundImage = picblack.BackgroundImage
            obtxt1.Text = ""
            obtxt2.Text = ""
            obtxt3.Text = ""
            obtxt4.Text = ""
dasi:
        End If
    End Sub

    Private Sub obtxt2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles obtxt2.KeyDown
        If fmcolor = 2 And listn <= 2 Then
            If e.KeyValue = 8 Or e.KeyValue = 189 Or e.KeyValue = 109 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            Else
                MessageBox.Show("숫자만 입력 가능합니다")
                obtxt2.Text = obpic1.BackgroundImage.Width
                obtxt2.Focus()
            End If
        End If
    End Sub

    Private Sub obtxt3_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles obtxt3.KeyDown
        If fmcolor = 2 And listn <= 2 Then
            If e.KeyValue = 8 Or e.KeyValue = 189 Or e.KeyValue = 109 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            Else
                MessageBox.Show("숫자만 입력 가능합니다")
                obtxt3.Text = obpic1.BackgroundImage.Height
                obtxt3.Focus()
            End If
        End If
    End Sub

    Private Sub sndread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sndread.Click
        If fmcolor = 3 And listn <= 2 Then
            Dim imgl, sndn, sndt As String

            If opensnd.ShowDialog = DialogResult.OK Then
                imgl = opensnd.FileName
                sndtxt2.Text = imgl
                sndplay.FileName = imgl
                sndbar.Value = -5000
                sndbar.Enabled = True
                sndtxt3.Enabled = True
                sndplay.Volume = sndbar.Value
                sndtxt3.Text = Int((sndbar.Value + 10000) / 100)
                sndplay.Stop()

                sndn = getname(imgl)
                sndt = gettime()
                sndlab5.Text = sndn & sndt
            End If
        End If
    End Sub

    Private Sub sndpic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sndpic1.Click
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt2.Text = "" Then
                MessageBox.Show("소리를 불러와주세요")
            Else
                If plyn = 0 Then
                    sndplay.Play()
                    plyn = 1
                    sndpic1.Image = My.Resources.sndpause
                ElseIf plyn = 1 Then
                    sndplay.Pause()
                    plyn = 0
                    sndpic1.Image = My.Resources.sndplay
                End If
            End If
        End If
    End Sub

    Private Sub sndpic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sndpic2.Click
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt2.Text = "" Then
                MessageBox.Show("소리를 불러와주세요")
            Else
                sndplay.Stop()
                sndplay.CurrentPosition = 0
                sndpic1.Image = My.Resources.sndplay
                plyn = 0
            End If
        End If
    End Sub

    Private Sub sndtxt3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sndtxt3.KeyDown
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt2.Text = "" Then
            Else
                If e.KeyValue = 8 Or e.KeyValue = 189 Or e.KeyValue = 109 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
                Else
                    MessageBox.Show("숫자만 입력 가능합니다")
                    sndtxt3.Text = Int((sndbar.Value + 10000) / 100)
                    sndtxt3.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub sndtxt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sndtxt3.TextChanged
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt2.Text = "" Then
            Else
                If Val(sndtxt3.Text) > 100 Then
                    sndtxt3.Text = Int((sndbar.Value + 10000) / 100)
                Else
                    sndbar.Value = Val(sndtxt3.Text) * 100 - 10000
                    sndplay.Volume = sndbar.Value
                End If
            End If
        End If
    End Sub

    Private Sub sndbar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sndbar.ValueChanged
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt2.Text = "" Then
            Else
                sndtxt3.Text = Int((sndbar.Value + 10000) / 100)
                sndplay.Volume = sndbar.Value
            End If
        End If
    End Sub

    Private Sub sndok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sndok.Click
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt1.Text = "" Then
                MessageBox.Show("소리명을 정해주세요")
                sndtxt1.Focus()
                GoTo dasi
            End If
            If sndtxt2.Text = "" Then
                MessageBox.Show("소리를 불러와주세요")
                sndread.Focus()
                GoTo dasi
            End If
            If listn = 1 Then
                sndn = sndn + 1
                snd(sndn).nam = sndtxt1.Text
                snd(sndn).vol = sndbar.Value
                snd(sndn).save = sndtxt2.Text
                sndtxt1.Text = ""
                sndtxt2.Text = ""
                sndtxt3.Text = ""
                sndlab5.Text = ""
                slist.Items.Clear()
                sndtxt3.Enabled = False
                sndbar.Value = -5000
                sndbar.Enabled = False
                sndplay.FileName = ""
                slist.Items.Clear()
                For i = 1 To sndn
                    slist.Items.Add(snd(i).nam)
                Next
                slist.Items.Add("(추가)")
                slist.Items.Add("")
                MessageBox.Show("소리 " & snd(sndn).nam & "(이)가 추가되었습니다")
            ElseIf listn = 2 Then
                Dim seln As Integer
                seln = slist.SelectedIndex + 1
                snd(seln).nam = sndtxt1.Text
                snd(seln).vol = sndbar.Value
                snd(seln).save = sndtxt2.Text
                sndtxt1.Text = ""
                sndtxt2.Text = ""
                sndtxt3.Text = ""
                sndlab5.Text = ""
                sndtxt3.Enabled = False
                sndbar.Value = -5000
                sndbar.Enabled = False
                sndplay.FileName = ""
                slist.Items.Clear()
                For i = 1 To sndn
                    slist.Items.Add(snd(i).nam)
                Next
                slist.Items.Add("(추가)")
                slist.Items.Add("")
                MessageBox.Show("소리 " & snd(seln).nam & "(이)가 수정되었습니다")
            End If
            plyn = 0
            sndpic1.Image = My.Resources.sndplay
        End If
dasi:
    End Sub

    Private Sub sndplay_EndOfStream(ByVal sender As Object, ByVal e As AxMediaPlayer._MediaPlayerEvents_EndOfStreamEvent) Handles sndplay.EndOfStream
        If fmcolor = 3 And listn <= 2 Then
            If sndtxt2.Text = "" Then
            Else
                plyn = 0
                sndpic1.Image = My.Resources.sndplay
            End If
        End If
    End Sub
    Private Function getname(ByVal strPath As String) As String

        Dim nLen As Integer
        Dim nFind As Integer
        Dim strTitle As String

        nLen = Len(strPath)
        nFind = strPath.LastIndexOf("\")
        strTitle = Mid(strPath, nFind + 2)
        strTitle = Mid(strTitle, 1, strTitle.Length - 4)

        Return strTitle

    End Function
    Private Function gettime() As String

        Dim sndt, sndm, snds As Integer
        Dim sndtot As String

        sndt = Int(sndplay.SelectionEnd)
        sndm = Int(sndt / 60)
        snds = sndt Mod 60
        sndtot = "(" & sndm & ":" & snds & ")"

        Return sndtot

    End Function
    Private Function actcut() As Action
        setbox.Visible = False
        obbox.Visible = False
        sndbox.Visible = False
        actbox.Visible = True
        actcom1.Text = ""
        actcom2.Text = ""
        acttxt1.Text = ""
        actbut.Enabled = False
        actbut.Visible = False
        sectxt = ""
        seccom = ""
        trdtxt = ""
        trdcom = ""
        actbut.Text = "③"
        acttxt2.Text = ""
        actcom1.Items.Clear()
        actcom2.Items.Clear()
        firn = 0
        secn = 0
        trdn = 0
        actx = 0
        acty = 0
        actr = 0
        actg = 0
        actb = 0
        If acttxt1.Enabled = False Then
            acttxt1.BackColor = SystemColors.Control
        Else
            acttxt1.BackColor = SystemColors.Window
        End If
    End Function

    Private Sub actcom1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles actcom1.Click
        If listn = 20 And barn = 2 Then
            If colorcng.ShowDialog = Windows.Forms.DialogResult.OK Then
                actclr = colorcng.Color
                actr = colorcng.Color.R
                actg = colorcng.Color.G
                actb = colorcng.Color.B
                acttxt1.BackColor = actclr
            End If
        End If
    End Sub

    Private Sub actcom1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles actcom1.KeyPress
        e.Handled = True
    End Sub

    Private Sub actcom1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actcom1.SelectedIndexChanged
        If actcom1.SelectedItem = "(일정한 수)" Then
            acttxt1.Enabled = True
        Else
            acttxt1.Text = ""
            acttxt1.Enabled = False
        End If
    End Sub

    Private Sub actcom2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles actcom2.KeyPress
        e.Handled = True
    End Sub
    Private Sub actcom2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actcom2.SelectedIndexChanged
        If actcom2.SelectedItem = "(일정한 수)" Then
            acttxt2.Enabled = True
        Else
            acttxt1.Text = ""
            acttxt2.Enabled = False
        End If
    End Sub

    Private Sub display_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles display.MouseClick
        If fmcolor = 1 Then
            If barn = 2 Then
                If slist.SelectedItem = "＿＿를 ＿＿에 이동" Or slist.SelectedItem = "'＿＿'라고 ＿＿에 타이핑 " Or mmon = 1 Then
                    acttxt2.Text = e.X & "," & e.Y
                    actx = e.X
                    acty = e.Y
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actbut.Click
        If barn = 2 And listn >= 22 And listn <= 25 Then
            If actbut.Text = "③" Then
                actbut.Text = "②"
                actlab2.Text = "③ ="
                sectxt = acttxt2.Text
                seccom = actcom2.SelectedItem
                acttxt2.Text = trdtxt
                If Not (trdcom = "") Then
                    actcom2.SelectedItem = trdcom
                    actcom2.Text = trdcom
                Else
                    actcom2.Text = ""
                End If
            Else
                actbut.Text = "③"
                actlab2.Text = "② ="
                trdtxt = acttxt2.Text
                trdcom = actcom2.SelectedItem
                acttxt2.Text = sectxt
                If Not (seccom = "") Then
                    actcom2.SelectedItem = seccom
                    actcom2.Text = seccom
                Else
                    actcom2.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub acttxt1_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles acttxt1.EnabledChanged
        If acttxt1.Enabled = False Then
            acttxt1.BackColor = SystemColors.Control
        Else
            acttxt1.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub nodloc(ByVal selnod As TreeNode) '012,34,56
        Dim i(9), ir(9), n, scrn(3) As Integer
        Dim nodnam, crn(3) As String
        Dim fp As TreeNode
        For k = 1 To 6
            i(k) = -1
        Next
        fp = script.SelectedNode
        n = 0
        Do
            n = n + 1
            If n > 6 Then
                MessageBox.Show("이 프로그램으론 상위로 6줄 이상 쓸 수 없습니다.")
                selnod.Remove()
                GoTo dasi
            End If
            If (fp.Index > 10) And Not (fp.Parent Is Nothing) Then
                MessageBox.Show("이 프로그램으론 한 조건 내에 동급 명령을 10줄 이상 쓸 수 없습니다.")
                selnod.Remove()
                GoTo dasi
            Else
                ir(n) = fp.Index
            End If

            If fp.Parent Is Nothing Then
                Exit Do
            Else
                fp = fp.Parent

            End If
        Loop

        For k = 1 To n
            i(n + 1 - k) = ir(k)
        Next

        If i(1) < 10 Then
            selnod.Name = "0"
            For k = 1 To 6
                If i(k) = -1 Then
                    Exit For
                Else
                    selnod.Name = selnod.Name & i(k)
                End If
            Next
        Else
            selnod.Name = ""
            For k = 1 To 6
                If i(k) = -1 Then
                    Exit For
                Else
                    selnod.Name = selnod.Name & i(k)
                End If
            Next
        End If
        nodnam = selnod.Name
        scrn(1) = 1 & Mid(nodnam, 1, 3)
        scrn(2) = 1 & Mid(nodnam, 4, 2)
        scrn(3) = 1 & Mid(nodnam, 6, 2)
        crn(1) = scrn(1)
        crn(2) = scrn(2)
        crn(3) = scrn(3)
        scr(scrn(1), scrn(2), scrn(3)) = selnod.Tag
        If sz(1) < Mid(crn(1), 2, 2) Then
            sz(1) = Mid(crn(1), 2, 2)
        End If
        If Len(crn(1)) > 3 Then
            If sz(2) < Mid(crn(1), 4, 1) Then
                sz(2) = Mid(crn(1), 4, 1)
            End If
        End If
        If Len(crn(2)) > 1 Then
            If sz(3) < Mid(crn(2), 2, 1) Then
                sz(3) = Mid(crn(2), 2, 1)
            End If
        End If
        If Len(crn(2)) > 2 Then
            If sz(4) < Mid(crn(2), 3, 1) Then
                sz(4) = Mid(crn(2), 3, 1)
            End If
        End If
        If Len(crn(3)) > 1 Then
            If sz(5) < Mid(crn(3), 2, 1) Then
                sz(5) = Mid(crn(3), 2, 1)
            End If
        End If
        If Len(crn(3)) > 2 Then
            If sz(6) < Mid(crn(3), 3, 1) Then
                sz(6) = Mid(crn(3), 3, 1)
            End If
        End If

        nodins()
dasi:
    End Sub


    Private Sub actok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actok.Click
        If listn = 1 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = "만약 " & firn & " 가  " & secn & " 라면"
            script.SelectedNode.ToolTipText = "If " & firn & " = " & secn & " Then"

            addsun()
        ElseIf listn = 2 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = "만약 " & firn & " 가  " & secn & " 이상이라면"
            script.SelectedNode.ToolTipText = "If " & firn & " >= " & secn & " Then"
            addsun()
        ElseIf listn = 3 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = "만약 " & firn & " 가  " & secn & " 이하라면"
            script.SelectedNode.ToolTipText = "If " & firn & "<= " & secn & " Then"
            addsun()
        ElseIf listn = 4 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = "만약 " & firn & " 가  " & secn & " 초과라면"
            script.SelectedNode.ToolTipText = "If " & firn & "> " & secn & " Then"
            addsun()
        ElseIf listn = 5 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = "만약 " & firn & " 가  " & secn & " 미만이라면"
            script.SelectedNode.ToolTipText = "If " & firn & "< " & secn & " Then"
            addsun()
        ElseIf listn = 6 Then
            Dim selnod As String
            selnod = script.SelectedNode.FullPath

            If selnod.IndexOf("\") = -1 Then
                'If dblclk = 0 Then
                actsim(2)
                If actd = 1 Then
                    actd = 0
                    GoTo dasi
                End If
                script.SelectedNode.Tag = listn & "," & firnn
                script.SelectedNode.Text = "만약 (마우스) " & firn & " 가 클릭되었을 때"
                script.SelectedNode.ToolTipText = "Private Sub " & firn & "_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles " & firn & "_Click"
                addsun()
                dblclk = 1
                'Else
                'MessageBox.Show("같은 Sub문은 한번만 쓸 수 있습니다.")
                'GoTo dasi
                'End If
            Else
                MessageBox.Show("Sub문은 맨 처음만 쓸 수 있습니다.")
                GoTo dasi
            End If
        ElseIf listn = 7 Then
            Dim selnod As String
            selnod = script.SelectedNode.FullPath
            If selnod.IndexOf("\") = -1 Then
                'If dbldbclk = 0 Then
                actsim(2)
                If actd = 1 Then
                    actd = 0
                    GoTo dasi
                End If
                script.SelectedNode.Tag = listn & "," & firnn
                script.SelectedNode.Text = "만약 (마우스) " & firn & " 가 더블클릭되었을 때"
                script.SelectedNode.ToolTipText = "Private Sub " & firn & "_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles " & firn & "_DoubleClick"
                addsun()
                dbldbclk = 1
                'Else
                'MessageBox.Show("같은 Sub문은 한번만 쓸 수 있습니다.")
                'GoTo dasi
                ' End If
            Else
                MessageBox.Show("Sub문은 맨 처음에만 쓸 수 있습니다.")
            End If
        ElseIf listn = 8 Then
            Dim selnod As String
            selnod = script.SelectedNode.FullPath
            If selnod.IndexOf("\") = -1 Then
                If kp = 0 Then
                    script.SelectedNode.Tag = listn
                    script.SelectedNode.Text = "키보드가 눌렸을 때"
                    script.SelectedNode.ToolTipText = "Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown"
                    addsun()
                    kp = 1
                Else
                    MessageBox.Show("같은 Sub문은 한번만 쓸 수 있습니다.")
                    GoTo dasi
                End If
            Else
                MessageBox.Show("Sub문은 맨 처음에만 쓸 수 있습니다.")
            End If
        ElseIf listn = 9 Then
            If kp = 1 And intxt() = True Then
                actsim(4)
                If actd = 1 Then
                    actd = 0
                    GoTo dasi
                End If
                script.SelectedNode.Tag = listn & "," & firnn
                script.SelectedNode.Text = "(키보드) " & firn & " 가 눌렸을 때"
                script.SelectedNode.ToolTipText = "If e.KeyCode = asc( " & firn & ") Then "
                addsun()
            Else
                MessageBox.Show("이 조건문은 '키보드가 눌렸을 때' 서브문 내에서만 사용 가능합니다.")
                GoTo dasi
            End If
            '       ElseIf listn = 9 Then
            '           actsim(3)
            '           If actd = 1 Then
            '           actd = 0
            '           GoTo dasi
            '           End If
            '           script.SelectedNode.Tag = listn & "," & firnn
            '           script.SelectedNode.Text = firn & " 초 후에"
            '           script.SelectedNode.ToolTipText = "If TimeCnt >= " & firn & " Then "
            '
            '            addsun()

        ElseIf listn = 11 Then
            actsim(2)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn
            script.SelectedNode.Text = firn & "를 보이기"
            script.SelectedNode.ToolTipText = firn & ".Visible = True "
        ElseIf listn = 12 Then
            actsim(2)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn
            script.SelectedNode.Text = firn & "를 숨기기"
            script.SelectedNode.ToolTipText = firn & ".Visible = False "
        ElseIf listn = 13 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 를 x축으로 " & secn & " 만큼 이동"
            script.SelectedNode.ToolTipText = firn & ".Left = " & firn & ".Left + " & secn
        ElseIf listn = 14 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 를 y축으로 " & secn & " 만큼 이동"
            script.SelectedNode.ToolTipText = firn & ".Top = " & firn & ".Top + " & secn
        ElseIf listn = 15 Then
            actsim(7)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & actx & "," & acty
            script.SelectedNode.Text = firn & " 를 (" & secn & ") 에 이동"
            script.SelectedNode.ToolTipText = firn & ".Top = " & acty & ", " & firn & ".Left = " & actx
        ElseIf listn = 16 Then
            actsim(7)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & actx & "," & acty
            script.SelectedNode.Text = "' " & firn & "' 라고 (" & secn & ") 에 타이핑"
            script.SelectedNode.ToolTipText = "Label1.Text = " & firn & ", Label1.Top = " & acty & ", Label1.Left = " & actx
        ElseIf listn = 17 Then
            actsim(2)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn
            script.SelectedNode.Text = firn & " 소리 1회 재생"
            script.SelectedNode.ToolTipText = firn & ".Play()"
        ElseIf listn = 18 Then
            actsim(2)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn
            script.SelectedNode.Text = firn & " 소리 재생 멈추기"
            script.SelectedNode.ToolTipText = firn & ".Stop()"
        ElseIf listn = 19 Then
            actsim(2)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn
            script.SelectedNode.Text = firn & " 사진으로 배경화면 만들기"
            script.SelectedNode.ToolTipText = "Me.BackgroundImage = Image.FromFile( " & firn & "의 경로)"
        ElseIf listn = 20 Then
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & actr & "," & actg & "," & actb
            script.SelectedNode.Text = "RGB(" & actr & "," & actg & "," & actb & ") " & "로 배경색 만들기"
            script.SelectedNode.ToolTipText = "Me.Backcolor = Color.FromArgb(" & actr & "," & actg & "," & actb & ")"
        ElseIf listn = 21 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " = " & secn
            script.SelectedNode.ToolTipText = firn & " = " & secn
        ElseIf listn = 22 Then
            actsim(6)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn & "," & trdnn
            script.SelectedNode.Text = firn & " = " & secn & " + " & trdn
            script.SelectedNode.ToolTipText = firn & " = " & secn & " + " & trdn
        ElseIf listn = 23 Then
            actsim(6)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn & "," & trdnn
            script.SelectedNode.Text = firn & " = " & secn & " - " & trdn
            script.SelectedNode.ToolTipText = firn & " = " & secn & " - " & trdn
        ElseIf listn = 24 Then
            actsim(6)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn & "," & trdnn
            script.SelectedNode.Text = firn & " = " & secn & " * " & trdn
            script.SelectedNode.ToolTipText = firn & " = " & secn & " * " & trdn
        ElseIf listn = 25 Then
            actsim(6)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn & "," & trdnn
            script.SelectedNode.Text = firn & " = " & secn & " / " & trdn
            script.SelectedNode.ToolTipText = firn & " = " & secn & " / " & trdn
        ElseIf listn = 26 Then
            script.SelectedNode.Tag = listn
            script.SelectedNode.Text = "프로그램 종료"
            script.SelectedNode.ToolTipText = "Me.Close()"
        ElseIf listn = 31 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 가  " & secn & " 일 때 반복"
            script.SelectedNode.ToolTipText = "Do While " & firn & " = " & secn
            addsun()

        ElseIf listn = 32 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 가  " & secn & " 아닐 때 반복"
            script.SelectedNode.ToolTipText = "Do While Not ( " & firn & " = " & secn & " )"
            addsun()

        ElseIf listn = 33 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 가  " & secn & " 이상일 때 반복"
            script.SelectedNode.ToolTipText = "Do While " & firn & " >= " & secn
            addsun()

        ElseIf listn = 34 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 가  " & secn & " 이하일 때 반복"
            script.SelectedNode.ToolTipText = "Do While " & firn & " <= " & secn
            addsun()

        ElseIf listn = 35 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 가  " & secn & " 초과일 때 반복"
            script.SelectedNode.ToolTipText = "Do While " & firn & " > " & secn
            addsun()

        ElseIf listn = 36 Then
            actsim(1)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn & "," & secnn
            script.SelectedNode.Text = firn & " 가  " & secn & " 미만일 때 반복"
            script.SelectedNode.ToolTipText = "Do While " & firn & " < " & secn
            addsun()

        ElseIf listn = 37 Then
            actsim(3)
            If actd = 1 Then
                actd = 0
                GoTo dasi
            End If
            script.SelectedNode.Tag = listn & "," & firnn
            script.SelectedNode.Text = firn & " 번 반복"
            script.SelectedNode.ToolTipText = "For i = 1 to " & firn
            addsun()

        End If
        nodloc(script.SelectedNode)
        actcut()
        okaft()
dasi:
    End Sub

    Private Function actsim(ByVal i As Integer) As Action
        If i = 1 Then
            If actcom1.SelectedItem = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
            Else
                firn = actcom1.SelectedItem
                firnn = actcom1.SelectedItem
            End If
            If actcom2.SelectedItem = "" Then
                MessageBox.Show("②을 지정해 주세요")
                actcom2.Focus()
                actd = 1
            Else
                secn = actcom2.SelectedItem
                secnn = actcom2.SelectedItem
            End If
            If actcom2.SelectedItem = "(일정한 수)" Then
                If acttxt2.Text = "" Then
                    MessageBox.Show("②을 지정해 주세요")
                    acttxt2.Focus()
                    actd = 1
                End If
                secn = acttxt2.Text
                secnn = "★∴" & acttxt2.Text
            End If

        ElseIf i = 2 Then
            If actcom1.SelectedItem = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
            Else
                firn = actcom1.SelectedItem
                firnn = actcom1.SelectedItem
            End If

        ElseIf i = 3 Then
            If actcom1.SelectedItem = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
            Else
                firn = actcom1.SelectedItem
                firnn = actcom1.SelectedItem
            End If
            If actcom1.SelectedItem = "(일정한 수)" Then
                If acttxt1.Text = "" Then
                    MessageBox.Show("①을 지정해 주세요")
                    acttxt1.Focus()
                    actd = 1
                End If
                firn = acttxt1.Text
                firnn = "★∴" & acttxt1.Text
            End If

        ElseIf i = 4 Then
            If acttxt1.Text = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
            Else
                firn = acttxt1.Text
                firnn = acttxt1.Text
            End If

        ElseIf i = 5 Then
            If actcom1.SelectedItem = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
            Else
                firn = actcom1.SelectedItem
                firnn = actcom1.SelectedItem
            End If
            If acttxt2.Text = "" Then
                MessageBox.Show("②을 지정해 주세요")
                acttxt2.Focus()
                actd = 1
            Else
                secn = acttxt2.Text
                secnn = acttxt2.Text
            End If

        ElseIf i = 6 Then
            If actcom1.SelectedItem = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
                GoTo dasi
            Else
                firn = actcom1.SelectedItem
                firnn = actcom1.SelectedItem
            End If

            If actbut.Text = "③" Then
                sectxt = acttxt2.Text
                seccom = actcom2.SelectedItem
            Else
                trdtxt = acttxt2.Text
                trdcom = actcom2.SelectedItem
            End If

            If seccom = "" Then
                MessageBox.Show("②을 지정해 주세요")
                If actbut.Text = "②" Then
                    actbut.Text = "③"
                    actlab2.Text = "② ="
                    trdtxt = acttxt2.Text
                    trdcom = actcom2.SelectedItem
                    acttxt2.Text = sectxt
                    If Not (seccom = "") Then
                        actcom2.SelectedItem = seccom
                        actcom2.Text = seccom
                    Else
                        actcom2.Text = ""
                        acttxt2.Enabled = False
                    End If
                Else
                    actcom2.Focus()
                End If
                actd = 1
                GoTo dasi
            Else
                secn = seccom
                secnn = seccom
                If seccom = "(일정한 수)" Then
                    If sectxt = "" Then
                        MessageBox.Show("②을 지정해 주세요")
                        If actbut.Text = "②" Then
                            actbut.Text = "③"
                            actlab2.Text = "② ="
                            trdtxt = acttxt2.Text
                            trdcom = actcom2.SelectedItem
                            acttxt2.Text = sectxt
                            If Not (seccom = "") Then
                                actcom2.SelectedItem = seccom
                                actcom2.Text = seccom
                            Else
                                actcom2.Text = ""
                                acttxt2.Enabled = False
                            End If
                        Else
                            acttxt2.Focus()
                        End If
                        actd = 1
                        GoTo dasi
                    Else
                        secn = sectxt
                        secnn = "★∴" & sectxt
                    End If
                End If
            End If

            If trdcom = "" Then
                MessageBox.Show("③을 지정해 주세요")
                If actbut.Text = "③" Then
                    actbut.Text = "②"
                    actlab2.Text = "③ ="
                    sectxt = acttxt2.Text
                    seccom = actcom2.SelectedItem
                    acttxt2.Text = trdtxt
                    If Not (trdcom = "") Then
                        actcom2.SelectedItem = trdcom
                        actcom2.Text = trdcom
                    Else
                        actcom2.Text = ""
                        acttxt2.Enabled = False
                    End If
                Else
                    actbut.Focus()
                End If
                actd = 1
                GoTo dasi
            Else
                trdn = trdcom
                trdnn = trdcom
                If trdcom = "(일정한 수)" Then
                    If trdtxt = "" Then
                        MessageBox.Show("③을 지정해 주세요")
                        If actbut.Text = "③" Then
                            actbut.Text = "②"
                            actlab2.Text = "③ ="
                            sectxt = acttxt2.Text
                            seccom = actcom2.SelectedItem
                            acttxt2.Text = trdtxt
                            If Not (trdcom = "") Then
                                actcom2.SelectedItem = trdcom
                                actcom2.Text = trdcom
                            Else
                                actcom2.Text = ""
                                acttxt2.Enabled = False
                            End If
                        Else
                            actbut.Focus()
                        End If
                        actd = 1
                        GoTo dasi
                    Else
                        trdn = trdtxt
                        trdnn = "★∴" & trdtxt
                    End If
                End If
            End If

        ElseIf i = 7 Then
            If actcom1.SelectedItem = "" Then
                MessageBox.Show("①을 지정해 주세요")
                actcom1.Focus()
                actd = 1
            Else
                firn = actcom1.SelectedItem
                firnn = actcom1.SelectedItem
            End If
            If acttxt2.Text = "" Then
                MessageBox.Show("②을 지정해 주세요")
                acttxt2.Focus()
                actd = 1
            Else
                secn = acttxt2.Text
                secnn = acttxt2.Text
            End If
        End If
dasi:
    End Function

    Private Sub settxt1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles settxt1.KeyDown
        If e.KeyValue = 189 Or e.KeyValue = 109 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            MessageBox.Show("문자만 입력 가능합니다")
            settxt1.Text = ""
            settxt1.Focus()
        Else
        End If
    End Sub


    Private Sub acttxt2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acttxt2.KeyDown
        If actcom2.SelectedItem = "(일정한 수)" Then
            If e.KeyValue = 8 Or e.KeyValue = 189 Or e.KeyValue = 109 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            Else
                MessageBox.Show("숫자만 입력 가능합니다")
                acttxt2.Text = ""
                acttxt2.Focus()
            End If
        End If
    End Sub

    Private Sub acttxt1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acttxt1.KeyDown
        If actcom1.SelectedItem = "(일정한 수)" Then
            If e.KeyValue = 8 Or e.KeyValue = 189 Or e.KeyValue = 109 Or (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Then
            Else
                MessageBox.Show("숫자만 입력 가능합니다")
                acttxt1.Text = ""
                acttxt1.Focus()
            End If
        End If
        If listn = 9 Then
            If Len(acttxt1.Text) > 0 Then
                MessageBox.Show("한 글자만 입력 가능합니다")
                acttxt1.Text = Mid(acttxt1.Text, 1, 1)
                acttxt1.Focus()
            End If
        End If
        If listn = 8 Then
            acttxt1.Text = ""
            acttxt1.Text = e.KeyCode
        End If
    End Sub

    Private Function gettag(ByVal tag As String) As action

        Dim a As Integer
        Dim nFind, nlast As Integer
        For i = 1 To 10
            nn(i) = ""
        Next

        a = 0
        nFind = tag.IndexOf(",")
        nlast = tag.LastIndexOf(",")
        If nFind = -1 Then
            nn(1) = tag
        Else
            Do While nFind < nlast
                a = a + 1
                nn(a) = Mid(tag, 1, nFind)
                tag = Mid(tag, nFind + 2)
                nFind = tag.IndexOf(",")
                nlast = tag.LastIndexOf(",")

            Loop

            If nFind = nlast Then
                a = a + 1
                nn(a) = Mid(tag, 1, nFind)
                a = a + 1
                nn(a) = Mid(tag, nFind + 2)
            End If
        End If

    End Function

    Private Function actshow(ByVal i As Integer) As action
        If i = 1 Then

            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "만약 ①가 ②라면"
            actuse.Text = "If ① = ② then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End If"
            acthow.Text = "If문의 가장 기본적인 형태"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 2 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "만약 ①가 ②이상이라면"
            actuse.Text = "If ① >= ② then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End If"
            acthow.Text = "If의 가장 기본적인 형태"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 3 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "만약 ①가 ②이하라면"
            actuse.Text = "If ① <= ② then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End If"
            acthow.Text = "If의 가장 기본적인 형태"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 4 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "만약 ①가 ②초과라면"
            actuse.Text = "If ① > ② then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End If"
            acthow.Text = "If의 가장 기본적인 형태"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 5 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "만약 ①가 ②미만이라면"
            actuse.Text = "If ① < ② then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End If"
            acthow.Text = "If의 가장 기본적인 형태"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 6 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "만약 (마우스)①가 클릭되었을 때"
            actuse.Text = "Private Sub ①_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ①.Click" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End Sub"
            acthow.Text = "Sub문은 제일 앞에다가 써야 함" & Chr(13) & Chr(10) & "Sub문 안에 If문을 여러번 쓸 수는 있지만 같은 조건의 Sub문을 여러번 중복할 수는 없음"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = ""
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 7 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "만약 (마우스)①가 더블클릭되었을 때"
            actuse.Text = "Private Sub ①_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ①.DoubleClick" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End Sub"
            acthow.Text = "Sub문은 제일 앞에다가 써야 함" & Chr(13) & Chr(10) & "Sub문 안에 If문을 여러번 쓸 수는 있지만 같은 조건의 Sub문을 여러번 중복할 수는 없음"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = ""
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 8 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = False
            actcom2.Enabled = False
            actkor.Text = "키보드가 눌렸을 때"
            actuse.Text = "Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "End Sub"
            acthow.Text = "Sub문은 제일 앞에다가 써야 함" & Chr(13) & Chr(10) & "Sub문 안에 If문을 여러번 쓸 수는 있지만 같은 조건의 Sub문을 여러번 중복할 수는 없음" & Chr(13) & Chr(10)
            actex1.Text = ""
            actex2.Text = ""
        ElseIf i = 9 Then
            actcut()
            acttxt1.Enabled = True
            acttxt2.Enabled = False
            actcom1.Enabled = False
            actcom2.Enabled = False
            actkor.Text = "(키보드)①가 눌렸을 때"
            actuse.Text = "If e.KeyCode = keys.① Then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "   End If"
            acthow.Text = "Form1_KeyDown 서브문 안에서만 사용 가능" & Chr(13) & Chr(10) & "e.KeyCode는 눌린 키보드의 Ascii 코드 값" & Chr(13) & Chr(10) & "asc() 함수는 괄호 안의 글자를 Ascii코드 값으로 변환"
            actex1.Text = "키보드 키 하나를 눌러주세요"
            actex2.Text = ""
            'ElseIf i = 9 Then
            '    actcut()
            '    acttxt1.Enabled = False
            '    acttxt2.Enabled = False
            '    actcom1.Enabled = True
            '    actcom2.Enabled = False
            '    actkor.Text = "①초 후에"
            '    actuse.Text = "Private Sub Timer1_Timer()" & Chr(13) & Chr(10) & "  TimeCnt = TimeCnt + 1 " & Chr(13) & Chr(10) & "  If TimeCnt >= ① Then" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "   End If" & Chr(13) & Chr(10) & "End Sub"
            '    acthow.Text = "Sub문 안에 If문이 들어가 있는 형태" & Chr(13) & Chr(10) & "Sub문은 제일 앞에다가 써야 함" & Chr(13) & Chr(10) & "Sub문 안에 If문을 여러번 쓸 수는 있지만 같은 조건의 Sub문을 여러번 중복할 수는 없음" & Chr(13) & Chr(10) & "TimeCnt는 임의의 변수 임으로 이름을 바꿔도 됨"
            '    actex1.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            '    actex2.Text = ""
            '    For i = 1 To valn
            '       If Not (vall(i).type = 3) Then
            '            actcom1.Items.Add(vall(i).nam)
            '       End If
            '    Next
            actcom1.Items.Add("(일정한 수)")
        ElseIf i = 11 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "①를 보이기"
            actuse.Text = "①.Visible = True"
            acthow.Text = "그림을 보여주는 Picturebox의 속성 중 하나"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = ""
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 12 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "①를 숨기기"
            actuse.Text = "①.Visible = False"
            acthow.Text = "그림을 보여주는 Picturebox의 속성 중 하나"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = ""
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 13 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①를 x축으로 ②만큼 이동"
            actuse.Text = "①.Left = ①.Left + ②"
            acthow.Text = "그림을 보여주는 Picturebox의 속성 중 하나" & Chr(13) & Chr(10) & "Picturebox의 왼쪽 끝이 기준" & Chr(13) & Chr(10) & "②가 양수이면 오른쪽, 음수이면 왼쪽"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 14 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①를 y축으로 ②만큼 이동"
            actuse.Text = "①.Top = ①.Top + ②"
            acthow.Text = "그림을 보여주는 Picturebox의 속성 중 하나" & Chr(13) & Chr(10) & "Picturebox의 윗쪽 끝이 기준" & Chr(13) & Chr(10) & "②가 양수이면 아래쪽, 음수이면 위쪽"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 15 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "①를 ②에 이동"
            actuse.Text = "①.Location = New Point( ②-1, ②-2) "
            acthow.Text = "그림을 보여주는 Picturebox의 속성 중 하나" & Chr(13) & Chr(10) & "Picturebox의 윗쪽 끝과 왼쪽 끝이 기준" & Chr(13) & Chr(10) & "마우스로 선택한 위치의 우측 아래에 그림이 나옴" & Chr(13) & Chr(10) & "new Point(, )는 위치를 나타내는 함수" & Chr(13) & Chr(10) & "②-1은 x값, ②-2는 y값"
            actex1.Text = "물체 중에 선택해 주세요"
            actex2.Text = "윗 화면에서 위치를 마우스로 클릭 해주세요"
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 16 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "'①'라고 ②에 타이핑"
            actuse.Text = "Label1.Text = ①" & Chr(13) & Chr(10) & "Label1.Location = New Point( ②-1, ②-2) "
            acthow.Text = "글을 보여주는 Label의 속성 중 하나" & Chr(13) & Chr(10) & "Label1은 임의의 Label 이름으로 수정 가능" & Chr(13) & Chr(10) & "이 프로그램은 한번에 최대 10개의 다른 글들을 타이핑할 수 있지만" & Chr(13) & Chr(10) & " 실제 프로그램으론 무제한으로 생성 가능" & Chr(13) & Chr(10) & "Textbox의 윗쪽 끝과 왼쪽 끝이 기준" & Chr(13) & Chr(10) & "마우스로 선택한 위치의 우측 아래에 글이 나옴" & Chr(13) & Chr(10) & "New Point(, )는 위치를 나타내는 함수" & Chr(13) & Chr(10) & "②-1은 x값, ②-2는 y값"
            actex1.Text = "변수 중에서 선택해 주세요"
            actex2.Text = "윗 화면에서 위치를 마우스로 클릭 해주세요"
            For i = 1 To valn
                actcom1.Items.Add(vall(i).nam)
            Next
        ElseIf i = 17 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "① 소리 1회 재생"
            actuse.Text = "①.Play()"
            acthow.Text = "Windows Media Player 컨트롤을 따로 추가해야 함"
            actex1.Text = "소리 중에서 선택해 주세요"
            actex2.Text = ""
            For i = 1 To sndn
                actcom1.Items.Add(snd(i).nam)
            Next
        ElseIf i = 18 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "① 소리 재생 멈추기"
            actuse.Text = "①.Stop()"
            acthow.Text = "Windows Media Player 컨트롤을 따로 추가해야 함"
            actex1.Text = "소리 중에서 선택해 주세요"
            actex2.Text = ""
            For i = 1 To sndn
                actcom1.Items.Add(snd(i).nam)
            Next
        ElseIf i = 19 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "①사진으로 배경화면 만들기"
            actuse.Text = "Me.BackgroundImage = Image.FromFile(①의 경로)"
            acthow.Text = "프로그램의 바탕이 되는 Form의 속성 중 하나" & Chr(13) & Chr(10) & "Me는 프로그램이 진행 중인 현재의 폼" & Chr(13) & Chr(10) & "Image.FromFile 함수는 사진을 외부 파일로 부터 가져올 때 사용"
            actex1.Text = "물체 중에서 선택해 주세요"
            actex2.Text = ""
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 20 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "①색으로 배경색 만들기"
            actuse.Text = "Me.Backcolor = Color.FromArgb(①)"
            acthow.Text = "프로그램의 바탕이 되는 Form의 속성 중 하나" & Chr(13) & Chr(10) & "Me는 프로그램이 진행 중인 현재의 폼" & Chr(13) & Chr(10) & "Color.FromARGB 함수는 색을 RGB코드로 부터 얻을 때 사용"
            actex1.Text = "눌러서 색을 지정해 주세요"
            actex2.Text = ""
            actcom1.Text = "(눌러주세요)"
            For i = 1 To obn
                actcom1.Items.Add(obj(i).nam)
            Next
        ElseIf i = 21 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "① = ②"
            actuse.Text = "① = ②"
            acthow.Text = "가장 간단한 함수식"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 22 Then
            actcut()
            actbut.Enabled = True
            actbut.Visible = True
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "① = ② + ③"
            actuse.Text = "① = ② + ③"
            acthow.Text = "가장 간단한 함수식"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 23 Then
            actcut()
            actbut.Enabled = True
            actbut.Visible = True
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "① = ② - ③"
            actuse.Text = "① = ② - ③"
            acthow.Text = "가장 간단한 함수식"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 24 Then
            actcut()
            actbut.Enabled = True
            actbut.Visible = True
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "① = ② * ③"
            actuse.Text = "① = ② * ③"
            acthow.Text = "가장 간단한 함수식"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 25 Then
            actcut()
            actbut.Enabled = True
            actbut.Visible = True
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "① = ② / ③"
            actuse.Text = "① = ② / ③"
            acthow.Text = "가장 간단한 함수식"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 26 Then
            actcut()
            actbut.Enabled = True
            actbut.Visible = True
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = False
            actcom2.Enabled = False
            actkor.Text = "프로그램 종료"
            actuse.Text = "Me.Close()"
            acthow.Text = "Me는 프로그램이 진행 중인 현재의 폼" & Chr(13) & Chr(10) & "Close는 현재의 폼을 종료시키는 명령어"
            actex1.Text = ""
            actex2.Text = ""
        ElseIf i = 31 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①가 ②일 때 반복"
            actuse.Text = "Do While ① = ②" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Loop"
            acthow.Text = "Do ~ While 함수는 조건을 충족할 때 까지 계속 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "잘못 쓰면 프로그램이 멈추는 일도 비일비재함"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 32 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①가 ② 아닐 때 반복"
            actuse.Text = "Do While Not (① = ②)" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Loop"
            acthow.Text = "Do While ~ Loop 함수는 조건을 충족할 때 까지 계속 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "잘못 쓰면 프로그램이 멈추는 일도 비일비재함"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 33 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①가 ② 이상일 때 반복"
            actuse.Text = "Do While ① >= ②" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Loop"
            acthow.Text = "Do While ~ Loop 함수는 조건을 충족할 때 까지 계속 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "잘못 쓰면 프로그램이 멈추는 일도 비일비재함"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 34 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①가 ② 이하일 때 반복"
            actuse.Text = "Do While ① <= ②" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Loop"
            acthow.Text = "Do While ~ Loop 함수는 조건을 충족할 때 까지 계속 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "잘못 쓰면 프로그램이 멈추는 일도 비일비재함"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 35 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①가 ② 초과일 때 반복"
            actuse.Text = "Do While ① > ②" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Loop"
            acthow.Text = "Do While ~ Loop 함수는 조건을 충족할 때 까지 계속 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "잘못 쓰면 프로그램이 멈추는 일도 비일비재함"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 36 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = True
            actkor.Text = "①가 ② 미만일 때 반복"
            actuse.Text = "Do While ① < ②" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Loop"
            acthow.Text = "Do While ~ Loop 함수는 조건을 충족할 때 까지 계속 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "잘못 쓰면 프로그램이 멈추는 일도 비일비재함"
            actex1.Text = "상수형 변수 중에 선택해 주세요"
            actex2.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                    actcom2.Items.Add(vall(i).nam)
                End If
            Next
            actcom2.Items.Add("(일정한 수)")
        ElseIf i = 37 Then
            actcut()
            acttxt1.Enabled = False
            acttxt2.Enabled = False
            actcom1.Enabled = True
            actcom2.Enabled = False
            actkor.Text = "①번 반복"
            actuse.Text = "For i = 1 to ①" & Chr(13) & Chr(10) & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Next"
            acthow.Text = "For ~ Next 함수는 i가 1에서 ①가 될 때 까지 i에 1씩 더하면서 그 사이의 함수들만 실행" & Chr(13) & Chr(10) & "i는 임의의 변수이며 변경 가능함" & Chr(13) & Chr(10) & "For ~ Next 사이에서 i는 1씩 더해진 그 수로 사용 가능"
            actex1.Text = "상수형 변수 또는 일정한 수 중에 선택해 주세요"
            actex2.Text = ""
            For i = 1 To valn
                If Not (vall(i).type = 3) Then
                    actcom1.Items.Add(vall(i).nam)
                End If
            Next
            actcom1.Items.Add("(일정한 수)")
        End If

    End Function

    Private Sub script_BeforeLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles script.BeforeLabelEdit
        e.CancelEdit = True
    End Sub


    Private Sub script_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles script.NodeMouseDoubleClick
        Dim selnod As TreeNode
        selnod = script.SelectedNode

        If selnod.Text = "선택" Then
            If selnod.Parent Is Nothing And barn = 1 Then
                slist.Items.Clear()
                slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
                slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
                slist.Items.Add("키보드가 눌렸을 때")
                slist.Items.Add("")
                slist.Enabled = True
                listbar.Enabled = True
                actcut()
                actbox.Visible = False
            ElseIf barn = 1 Then
                slist.Items.Clear()
                slist.Items.Add("만약 ＿＿가 ＿＿라면")
                slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
                slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
                slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
                slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
                slist.Items.Add("(키보드)＿＿가 눌렸을 때")
                slist.Items.Add("")
                slist.Enabled = True
                listbar.Enabled = True
                actcut()
                actbox.Visible = False
            End If
            mmon = 0
        Else
            Dim tag As String
            tag = selnod.Tag
            If Not (tag = "" Or tag = "0") Then
                gettag(tag)
            End If
            Dim ltn As Integer
            ltn = Val(nn(1))
            actshow(ltn)
            If ltn >= 1 And ltn <= 5 Then
                actread(1)
            ElseIf ltn = 6 Or ltn = 7 Then
                actread(2)
            ElseIf ltn = 8 Then
                actread(4)
            ElseIf ltn = 9 Then
                actread(3)
            ElseIf ltn = 11 Or ltn = 12 Then
                actread(2)
            ElseIf ltn = 13 Or ltn = 14 Then
                actread(1)
            ElseIf ltn = 15 Or ltn = 16 Then
                actread(4)
            ElseIf ltn >= 17 And ltn <= 19 Then
                actread(2)
            ElseIf ltn = 20 Then
                Dim r, g, b As Integer
                r = Val(nn(2))
                g = Val(nn(3))
                b = Val(nn(4))
                acttxt1.BackColor = Color.FromArgb(r, g, b)
            ElseIf ltn = 21 Then
                actread(1)
            ElseIf ltn >= 22 And ltn <= 25 Then
                actread(6)
            ElseIf ltn >= 31 And ltn <= 36 Then
                actread(1)
            ElseIf ltn = 37 Then
                actread(3)
            End If
            If ltn = 15 Or ltn = 16 Then
                mmon = 1
            Else
                mmon = 0
            End If
        End If
    End Sub

    Private Function actread(ByVal i As Integer) As Action
        If i = 1 Then
            actcom1.SelectedItem = nn(2)
            Dim bef, aft As String
            bef = Mid(nn(3), 1, 2)
            aft = Mid(nn(3), 3)
            If bef = "★∴" And Val(aft) > 0 Then
                actcom2.SelectedItem = "(일정한 수)"
                acttxt2.Text = aft
            Else
                actcom2.SelectedItem = nn(3)
            End If

        ElseIf i = 2 Then
            actcom1.SelectedItem = nn(2)

        ElseIf i = 3 Then
            Dim bef, aft As String
            bef = Mid(nn(2), 1, 2)
            aft = Mid(nn(2), 3)
            If bef = "★∴" And Val(aft) > 0 Then
                actcom1.SelectedItem = "(일정한 수)"
                acttxt1.Text = aft
            Else
                actcom1.SelectedItem = nn(2)
            End If

        ElseIf i = 4 Then
            actcom1.SelectedItem = nn(2)
            acttxt2.Text = nn(3) & "," & nn(4)
            actx = nn(3)
            acty = nn(4)

        ElseIf i = 5 Then
            actcom1.SelectedItem = nn(2)
            acttxt2.Text = nn(3)

        ElseIf i = 6 Then
            actcom1.SelectedItem = nn(2)
            actbut.Text = "③"
            Dim bef, aft As String
            bef = Mid(nn(3), 1, 2)
            aft = Mid(nn(3), 3)
            If bef = "★∴" And Val(aft) > 0 Then
                actcom2.SelectedItem = "(일정한 수)"
                acttxt2.Text = aft
                sectxt = aft
                seccom = "(일정한 수)"
            Else
                actcom2.SelectedItem = nn(3)
                seccom = nn(3)
            End If
            bef = Mid(nn(4), 1, 2)
            aft = Mid(nn(4), 3)
            If bef = "★∴" And Val(aft) > 0 Then
                trdtxt = aft
                trdcom = "(일정한 수)"
            Else
                trdcom = nn(4)
            End If
        End If
    End Function

    Private Sub but_code_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_code.Click
        Code_form.Show()
        Me.Enabled = False
    End Sub

    Private Sub noddel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noddel.Click
        Dim num(6), k, st(6) As Integer
        Dim nu(3) As String
        Dim selnod As TreeNode
        If script.SelectedNode.IsSelected = False Then
            MessageBox.Show("삭제 할 줄을 선택 해 주세요")
        Else
            If script.SelectedNode.Index = 0 Then
                If script.SelectedNode.Text = "선택" Then
                    MessageBox.Show("삭제 할 수 없습니다")
                    GoTo dasi
                End If
                If Not (script.SelectedNode.Parent Is Nothing) Then
                    If script.SelectedNode.Parent.LastNode.Index = 0 Then
                        MessageBox.Show("삭제 할 수 없습니다")
                        GoTo dasi
                    End If
                End If
            End If
            If Not (script.SelectedNode.Text = "선택") Then
                Dim nodnam As String
                For i = 1 To 6
                    num(i) = sz(i)
                    st(i) = -1
                Next
                num(1) = 99
                k = -1
                nodnam = script.SelectedNode.Name()
                Do
                    k = k + 1
                    num(k) = Mid(nodnam, 1, 1)
                    st(k) = num(k)
                    If Len(nodnam) = 1 Then
                        Exit Do
                    Else
                        nodnam = Mid(nodnam, 2)
                    End If
                Loop

                num(1) = num(0) * 10 + num(1)
                st(1) = num(1)
                For a = st(1) To num(1)
                    For b = st(2) To num(2)
                        For c = st(3) To num(3)
                            For d = st(4) To num(4)
                                For h = st(5) To num(5)
                                    For f = st(6) To num(6)
                                        If a < 10 Then
                                            nu(1) = "10" & gsp(a) & gsp(b)
                                        Else
                                            nu(1) = "1" & gsp(a) & gsp(b)
                                        End If
                                        If gsp(c) = "" Then
                                            nu(2) = "1" & gsp(c)
                                        Else
                                            nu(2) = "1" & gsp(c) & gsp(d)
                                        End If
                                        If gsp(h) = "" Then
                                            nu(3) = "1" & gsp(h)
                                        Else
                                            nu(3) = "1" & gsp(h) & gsp(f)
                                        End If
                                        scr(nu(1), nu(2), nu(3)) = ""
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next



            End If
            script.SelectedNode.Remove()
        End If
dasi:
    End Sub

    Private Sub nodadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nodadd.Click

        If script.SelectedNode.IsSelected = False Then
            MessageBox.Show("추가 할 줄의 위를 선택 해 주세요")
        Else
            If script.SelectedNode.Text = "선택" Then
                MessageBox.Show("추가 할 필요가 없습니다")
            Else
                If script.SelectedNode.Parent Is Nothing Then
                    Dim kk As Integer = 0
                    Do
                        kk = kk + 1
                        If script.Nodes.Item(kk).NextNode Is Nothing Then
                            Exit Do
                        End If
                    Loop
                    If script.SelectedNode.Index = kk Then
                        script.Nodes.Add("선택")
                        Exit Sub
                    End If
                ElseIf script.SelectedNode Is script.SelectedNode.Parent.LastNode Then
                    script.SelectedNode.Parent.Nodes.Add("선택")
                    Exit Sub
                Else
                    nodins()
                    Dim num(6), k, st(6) As Integer
                    Dim nodnam As String
                    Dim selnod As TreeNode
                    For i = 1 To 6
                        num(i) = sz(i)
                        st(i) = -1
                    Next
                    num(1) = 99
                    k = -1
                    nodnam = script.SelectedNode.Name()
                    Do
                        k = k + 1
                        num(k) = Mid(nodnam, 1, 1)
                        st(k) = num(k)
                        If Len(nodnam) = 1 Then
                            Exit Do
                        Else
                            nodnam = Mid(nodnam, 2)
                        End If
                    Loop
                    num(1) = num(0) * 10 + num(1)
                    st(k) = st(k) + 1

                    For a = st(1) To num(1)
                        For b = st(2) To num(2)
                            For c = st(3) To num(3)
                                For d = st(4) To num(4)
                                    For h = st(5) To num(5)
                                        For f = st(6) To num(6)
                                            If b = -1 Then
                                                selnod = script.Nodes.Item(a)
                                                nodloc(selnod)
                                            ElseIf c = -1 Then
                                                selnod = script.Nodes.Item(a).Nodes.Item(b)
                                                nodloc(selnod)
                                            ElseIf d = -1 Then
                                                selnod = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c)
                                                nodloc(selnod)
                                            ElseIf h = -1 Then
                                                selnod = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d)
                                                nodloc(selnod)
                                            ElseIf f = -1 Then
                                                selnod = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d).Nodes.Item(h)
                                                nodloc(selnod)
                                            Else
                                                selnod = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d).Nodes.Item(h).Nodes.Item(f)
                                                nodloc(selnod)
                                            End If
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                End If
            End If
        End If
    End Sub
    '        If script.SelectedNode.IsSelected = False Then
    ' MessageBox.Show("추가 할 줄의 위를 선택 해 주세요")
    ' Else
    ' If script.SelectedNode.Text = "선택" Then
    ' MessageBox.Show("추가 할 필요가 없습니다")
    ' Else
    ' If script.SelectedNode.NextNode Is Nothing Then
    ' script.Nodes.Insert(script.SelectedNode.Index + 1, "선택")
    ' Else
    ' If script.SelectedNode.NextNode.Text = "선택" Then
    ' MessageBox.Show("추가 할 필요가 없습니다")
    ' Else
    ' script.Nodes.Insert(script.SelectedNode.Index + 1, "선택")
    'End If
    'End If
    'End If
    'End If


    Private Function nodins() As action

        Dim cnt As Integer
        cnt = 0

        Dim selnod As String
        selnod = script.SelectedNode.FullPath
        If selnod.IndexOf("\") = -1 Then
            script.Nodes.Insert(script.SelectedNode.Index + 1, "선택")
        Else
            script.SelectedNode.Parent.Nodes.Insert(script.SelectedNode.Index + 1, "선택")
        End If

        If script.SelectedNode.Parent Is Nothing Then
            Dim selno As System.Windows.Forms.TreeNodeCollection = script.Nodes
            For Each Nodes As System.Windows.Forms.TreeNode In selno
                If Nodes.Text = "선택" Then
                    cnt = cnt + 1
                    If cnt = 2 Then
                        Nodes.Remove()
                    End If
                End If
            Next
        Else
            Dim selno As System.Windows.Forms.TreeNodeCollection = script.SelectedNode.Parent.Nodes
            For Each Nodes As System.Windows.Forms.TreeNode In selno
                If Nodes.Text = "선택" Then
                    cnt = cnt + 1
                    If cnt = 2 Then
                        Nodes.Remove()
                    End If
                End If
            Next
        End If


    End Function

    Private Function intxt() As Boolean
        Dim str As String
        Dim nod As TreeNode
        Dim bol As Boolean
        nod = script.SelectedNode
dasi:
        str = nod.FullPath
        If str.IndexOf("\") = -1 Then
            If nod.Text = "키보드가 눌렸을 때" Then
                bol = True
            Else
                bol = False
            End If
        Else
            nod = nod.Parent
            GoTo dasi
        End If

        Return bol
    End Function

    Private Function okaft() As action
        actcom1.Items.Clear()
        actcom2.Items.Clear()
        actcom1.Text = ""
        actcom2.Text = ""
        acttxt1.Text = ""
        acttxt2.Text = ""
        actbox.Visible = False
        Dim g As Graphics = display.CreateGraphics
        g.Clear(Color.White)
    End Function

    Private Sub but_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_load.Click
        Dim fp, loadcnt, reads As String
        If openfile.ShowDialog = DialogResult.OK Then
            obn = 0
            valn = 0
            sndn = 0
            For a = 1000 To 2000
                For b = 100 To 200
                    For c = 100 To 200
                        scr(a, b, c) = ""
                    Next
                Next
            Next
            For a = 1 To 100
                obj(a).nam = ""
                obj(a).save = ""
                obj(a).x = 0
                obj(a).y = 0
                snd(a).nam = ""
                snd(a).save = ""
                snd(a).vol = 0
                vall(a).first = ""
                vall(a).nam = ""
                vall(a).type = 0
            Next
            For a = 1 To 6
                sz(a) = -1
            Next
            fp = openfile.FileName
            Dim loading As String = System.AppDomain.CurrentDomain.DynamicDirectory & fp
            Dim objReader As New System.IO.StreamReader(loading)
            reads = "0"
            While Not (reads Is Nothing)
                reads = objReader.ReadLine
                If reads Is Nothing Then
                    Exit While
                End If
                If reads = "!-setting" Then
                    loadcnt = 1
                    GoTo dasi
                ElseIf reads = "!-sounds" Then
                    loadcnt = 2
                    GoTo dasi
                ElseIf reads = "!-objects" Then
                    loadcnt = 3
                    GoTo dasi
                ElseIf reads = "!-variables" Then
                    loadcnt = 4
                    GoTo dasi
                ElseIf reads = "!-scripts" Then
                    loadcnt = 5
                    GoTo dasi
                End If
                loadtask(loadcnt, reads)
dasi:
            End While
            objReader.Close()
            setmake()
            scrmake()
            listbar.Image = My.Resources.jobar '조건
            slist.Items.Clear()
            slist.Items.Add("만약 ＿＿가 ＿＿라면")
            slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
            slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
            slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
            slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
            slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
            slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
            slist.Items.Add("키보드가 눌렸을 때")
            slist.Items.Add("(키보드)＿＿가 눌렸을 때")
            slist.Items.Add("")
            barn = 1
        End If
    End Sub

    Private Sub scrmake()
        Dim nownode As TreeNode
        script.Nodes.Clear()
        Dim num(3), tag, nonam As String
        For a = 0 To sz(1)
            For b = -1 To sz(2)
                For c = -1 To sz(3)
                    For d = -1 To sz(4)
                        For h = -1 To sz(5)
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
                                    If gsp(h) = "" Then
                                        num(3) = "1" & gsp(h)
                                    Else
                                        num(3) = "1" & gsp(h) & gsp(f)
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
                                        If nonam = Mid(num(1), 2) & Mid(num(2), 2) & Mid(num(3), 2) Then
                                            Exit For
                                        End If
                                        nonam = Mid(num(1), 2) & Mid(num(2), 2) & Mid(num(3), 2)
                                        If b = -1 Then
                                            script.Nodes.Insert(a, "")
                                            nownode = script.Nodes.Item(a)
                                            nownode.Name = nonam
                                            tag = scr(num(1), num(2), num(3))
                                            inscrmake(nownode, tag)
                                        ElseIf c = -1 Then
                                            script.Nodes.Item(a).Nodes.Insert(b, "")
                                            nownode = script.Nodes.Item(a).Nodes.Item(b)
                                            nownode.Name = nonam
                                            tag = scr(num(1), num(2), num(3))
                                            inscrmake(nownode, tag)
                                        ElseIf d = -1 Then
                                            script.Nodes.Item(a).Nodes.Item(b).Nodes.Insert(c, "")
                                            nownode = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c)
                                            nownode.Name = nonam
                                            tag = scr(num(1), num(2), num(3))
                                            inscrmake(nownode, tag)
                                        ElseIf h = -1 Then
                                            script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Insert(d, "")
                                            nownode = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d)
                                            nownode.Name = nonam
                                            tag = scr(num(1), num(2), num(3))
                                            inscrmake(nownode, tag)
                                        ElseIf f = -1 Then
                                            script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d).Nodes.Insert(h, "")
                                            nownode = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d).Nodes.Item(h)
                                            nownode.Name = nonam
                                            tag = scr(num(1), num(2), num(3))
                                            inscrmake(nownode, tag)
                                        Else
                                            script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d).Nodes.Item(h).Nodes.Insert(f, "")
                                            nownode = script.Nodes.Item(a).Nodes.Item(b).Nodes.Item(c).Nodes.Item(d).Nodes.Item(h).Nodes.Item(f)
                                            nownode.Name = nonam
                                            tag = scr(num(1), num(2), num(3))
                                            inscrmake(nownode, tag)
                                        End If

                                    End If
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next



    End Sub

    Private Sub inscrmake(ByVal an As TreeNode, ByVal tag As String)
        Dim n(10), ln, fir As String
        Dim a, k As Integer
        Dim nFind, nlast As Integer

        fir = tag
        ln = ""
        For i = 1 To 10
            n(i) = ""
        Next

        If tag = "0" Then

        End If
        k = 96
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
            an.Tag = fir
            an.Text = "프로그램이 실행됬을 때"
            an.ToolTipText = "Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load"
        ElseIf n(1) = 1 Then
            an.Tag = fir
            an.Text = "만약 " & n(2) & " 가  " & n(3) & " 라면"
            an.ToolTipText = "If " & n(2) & " = " & n(3) & " Then"

        ElseIf n(1) = 2 Then

            an.Tag = fir
            an.Text = "만약 " & n(2) & " 가  " & n(3) & " 이상이라면"
            an.ToolTipText = "If " & n(2) & " >= " & n(3) & " Then"

        ElseIf n(1) = 3 Then

            an.Tag = fir
            an.Text = "만약 " & n(2) & " 가  " & n(3) & " 이하라면"
            an.ToolTipText = "If " & n(2) & "<= " & n(3) & " Then"

        ElseIf n(1) = 4 Then

            an.Tag = fir
            an.Text = "만약 " & n(2) & " 가  " & n(3) & " 초과라면"
            an.ToolTipText = "If " & n(2) & "> " & n(3) & " Then"

        ElseIf n(1) = 5 Then

            an.Tag = fir
            an.Text = "만약 " & n(2) & " 가  " & n(3) & " 미만이라면"
            an.ToolTipText = "If " & n(2) & "< " & n(3) & " Then"

        ElseIf n(1) = 6 Then

            an.Tag = fir
            an.Text = "만약 (마우스) " & n(2) & " 가 클릭되었을 때"
            an.ToolTipText = "Private Sub " & n(2) & "_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles " & n(2) & "_Click"

        ElseIf n(1) = 7 Then

            an.Tag = fir
            an.Text = "만약 (마우스) " & n(2) & " 가 더블클릭되었을 때"
            an.ToolTipText = "Private Sub " & n(2) & "_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles " & n(2) & "_DoubleClick"

        ElseIf n(1) = 8 Then

            an.Tag = fir
            an.Text = "키보드가 눌렸을 때"
            an.ToolTipText = "Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown"


        ElseIf n(1) = 9 Then

            an.Tag = fir
            an.Text = "(키보드) " & n(2) & " 가 눌렸을 때"
            an.ToolTipText = "If e.KeyCode = keys." & n(2) & ") Then "

            '       ElseIf n(1) = 9 Then
            '           
            '           an.Tag = n(1) & "," & n(2)n
            '           an.Text = n(2) & " 초 후에"
            '           an.ToolTipText = "If TimeCnt >= " & n(2) & " Then "
            '
            '            
        ElseIf n(1) = 11 Then

            an.Tag = fir
            an.Text = n(2) & "를 보이기"
            an.ToolTipText = n(2) & ".Visible = True "

        ElseIf n(1) = 12 Then

            an.Tag = fir
            an.Text = n(2) & "를 숨기기"
            an.ToolTipText = n(2) & ".Visible = False "

        ElseIf n(1) = 13 Then

            an.Tag = fir
            an.Text = n(2) & " 를 x축으로 " & n(3) & " 만큼 이동"
            an.ToolTipText = n(2) & ".Left = " & n(2) & ".Left + " & n(3)

        ElseIf n(1) = 14 Then

            an.Tag = fir
            an.Text = n(2) & " 를 y축으로 " & n(3) & " 만큼 이동"
            an.ToolTipText = n(2) & ".Top = " & n(2) & ".Top + " & n(3)

        ElseIf n(1) = 15 Then

            an.Tag = fir
            an.Text = n(2) & " 를 (" & n(3) & "," & n(4) & ") 에 이동"
            an.ToolTipText = n(2) & ".Location = New Point(" & n(3) & ", " & n(4) & ") "

        ElseIf n(1) = 16 Then

            an.Tag = fir
            an.Text = "' " & n(2) & "' 라고 (" & n(3) & "," & n(4) & ") 에 타이핑"
            an.ToolTipText = "Label1.Text = " & n(2) & ", Label1.Location = New Point(" & actx & ", " & n(4) & ") "

        ElseIf n(1) = 17 Then

            an.Tag = fir
            an.Text = n(2) & " 소리 1회 재생"
            an.ToolTipText = n(2) & ".Play()"

        ElseIf n(1) = 18 Then

            an.Tag = fir
            an.Text = n(2) & " 소리 재생 멈추기"
            an.ToolTipText = n(2) & ".Stop()"

        ElseIf n(1) = 19 Then

            an.Tag = fir
            an.Text = n(2) & " 사진으로 배경화면 만들기"
            an.ToolTipText = "Me.BackgroundImage = Image.FromFile( " & n(2) & "의 경로)"

        ElseIf n(1) = 20 Then

            an.Tag = fir
            an.Text = "RGB(" & n(2) & "," & n(3) & "," & n(4) & ") " & "로 배경색 만들기"
            an.ToolTipText = "Me.Backcolor = Color.FromArgb(" & n(2) & "," & n(3) & "," & n(4) & ")"

        ElseIf n(1) = 21 Then

            an.Tag = fir
            an.Text = n(2) & " = " & n(3)
            an.ToolTipText = n(2) & " = " & n(3)

        ElseIf n(1) = 22 Then

            an.Tag = fir
            an.Text = n(2) & " = " & n(3) & " + " & n(4)
            an.ToolTipText = n(2) & " = " & n(3) & " + " & n(4)

        ElseIf n(1) = 23 Then

            an.Tag = fir
            an.Text = n(2) & " = " & n(3) & " - " & n(4)
            an.ToolTipText = n(2) & " = " & n(3) & " - " & n(4)

        ElseIf n(1) = 24 Then

            an.Tag = fir
            an.Text = n(2) & " = " & n(3) & " * " & n(4)
            an.ToolTipText = n(2) & " = " & n(3) & " * " & n(4)

        ElseIf n(1) = 25 Then

            an.Tag = fir
            an.Text = n(2) & " = " & n(3) & " / " & n(4)
            an.ToolTipText = n(2) & " = " & n(3) & " / " & n(4)

        ElseIf n(1) = 26 Then

            an.Tag = fir
            an.Text = "프로그램 종료"
            an.ToolTipText = "Me.Close()"

        ElseIf n(1) = 31 Then

            an.Tag = fir
            an.Text = n(2) & " 가  " & n(3) & " 일 때 반복"
            an.ToolTipText = "Do While " & n(2) & " = " & n(3)


        ElseIf n(1) = 32 Then

            an.Tag = fir
            an.Text = n(2) & " 가  " & n(3) & " 아닐 때 반복"
            an.ToolTipText = "Do While Not ( " & n(2) & " = " & n(3) & " )"

        ElseIf n(1) = 33 Then

            an.Tag = fir
            an.Text = n(2) & " 가  " & n(3) & " 이상일 때 반복"
            an.ToolTipText = "Do While " & n(2) & " >= " & n(3)

        ElseIf n(1) = 34 Then

            an.Tag = fir
            an.Text = n(2) & " 가  " & n(3) & " 이하일 때 반복"
            an.ToolTipText = "Do While " & n(2) & " <= " & n(3)

        ElseIf n(1) = 35 Then

            an.Tag = fir
            an.Text = n(2) & " 가  " & n(3) & " 초과일 때 반복"
            an.ToolTipText = "Do While " & n(2) & " > " & n(3)

        ElseIf n(1) = 36 Then

            an.Tag = fir
            an.Text = n(2) & " 가  " & n(3) & " 미만일 때 반복"
            an.ToolTipText = "Do While " & n(2) & " < " & n(3)

        ElseIf n(1) = 37 Then

            an.Tag = fir
            an.Text = n(2) & " 번 반복"
            an.ToolTipText = "For i = 1 to " & n(2)

        End If
    End Sub

    Private Sub setmake()
        xx = display.Width
        xy = display.Height
        display.Width = bgx
        display.Height = bgy
        display.BackColor = bgcolor
        If Not (bgimgname = "") Then
            If My.Computer.FileSystem.FileExists(bgimgname) = False Then
                display.BackgroundImage = My.Resources.imgerror
                bgimgname = "C:\PProgramming\Examples\imgerror.jpg"
            Else
                bgimg = Image.FromFile(bgimgname)
                display.BackgroundImage = bgimg
            End If
        End If
            cngnum = 1
            sizecng()
            Select Case bglayout
                Case 1
                    display.BackgroundImageLayout = ImageLayout.None
                Case 2
                    display.BackgroundImageLayout = ImageLayout.Tile
                Case 3
                    display.BackgroundImageLayout = ImageLayout.Center
                Case 4
                    display.BackgroundImageLayout = ImageLayout.Stretch
                Case 5
                    display.BackgroundImageLayout = ImageLayout.Zoom
            End Select
    End Sub

    Private Sub loadtask(ByVal n As Integer, ByVal read As String)
        Dim cut(10) As String
        Dim k, fir, las As Integer
        k = 0
        fir = read.IndexOf("|")
        las = read.LastIndexOf("|")
        If fir = -1 Then
            cut(1) = read
        ElseIf fir = las Then
            k = k + 1
            cut(k) = Mid(read, 1, fir)
            k = k + 1
            cut(k) = Mid(read, fir + 2)
        Else
            Do While fir < las
                k = k + 1
                fir = read.IndexOf("|")
                las = read.LastIndexOf("|")
                If fir = las Then
                    cut(k) = Mid(read, 1, fir)
                    k = k + 1
                    cut(k) = Mid(read, fir + 2)
                Else
                    cut(k) = Mid(read, 1, fir)
                    read = Mid(read, fir + 2)
                End If
            Loop

        End If
        If n = 1 Then
            Select Case cut(1)
                Case "①" 'x,y,이미지형태
                    bgx = cut(2)
                    bgy = cut(3)
                    bglayout = cut(4)
                Case "②" '이미지이름
                    bgimgname = cut(2)
                Case "③" '배경색
                    bgcolor = Color.FromArgb(cut(2), cut(3), cut(4))
            End Select
        ElseIf n = 2 Then
            sndn = sndn + 1
            snd(sndn).nam = cut(1)
            snd(sndn).save = cut(2)
            snd(sndn).vol = cut(3)
        ElseIf n = 3 Then
            obn = obn + 1
            obj(obn).nam = cut(1)
            If My.Computer.FileSystem.FileExists(cut(2)) = False Then
                obj(obn).save = "C:\PProgramming\Examples\imgerror.jpg"
            Else
                obj(obn).save = cut(2)
            End If
            obj(obn).x = cut(3)
            obj(obn).y = cut(4)
        ElseIf n = 4 Then
            valn = valn + 1
            vall(valn).nam = cut(1)
            vall(valn).type = cut(2)
            vall(valn).first = cut(3)
        ElseIf n = 5 Then
            scr(cut(1), cut(2), cut(3)) = cut(4)
            If sz(1) < Mid(cut(1), 2, 2) Then
                sz(1) = Mid(cut(1), 2, 2)
            End If
            If Len(cut(1)) > 3 Then
                If sz(2) < Mid(cut(1), 4, 1) Then
                    sz(2) = Mid(cut(1), 4, 1)
                End If
            End If
            If Len(cut(2)) > 1 Then
                If sz(3) < Mid(cut(2), 2, 1) Then
                    sz(3) = Mid(cut(2), 2, 1)
                End If
            End If
            If Len(cut(2)) > 2 Then
                If sz(4) < Mid(cut(2), 3, 1) Then
                    sz(4) = Mid(cut(2), 3, 1)
                End If
            End If
            If Len(cut(3)) > 1 Then
                If sz(5) < Mid(cut(3), 2, 1) Then
                    sz(5) = Mid(cut(3), 2, 1)
                End If
            End If
            If Len(cut(3)) > 2 Then
                If sz(6) < Mid(cut(3), 3, 1) Then
                    sz(6) = Mid(cut(3), 3, 1)
                End If
            End If
        End If
    End Sub

    Private Sub but_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_save.Click
        Dim tg, num(3), fn, fp, read As String
        If savefile.ShowDialog = DialogResult.OK Then
            fp = savefile.FileName
            fn = getname(fp)
            Dim saving As String = System.AppDomain.CurrentDomain.DynamicDirectory & fp
            If My.Computer.FileSystem.FileExists(saving) = True Then
                My.Computer.FileSystem.DeleteFile(saving)
            End If
            If obn > 0 Then
                Dim objs As String = "C:\PProgramming\" & fn & "\물체\"
                For a = 1 To obn
                    My.Computer.FileSystem.CopyFile(obj(a).save, objs & obj(a).nam & ".hobj", True)
                    obj(a).save = objs & obj(a).nam & ".hobj"
                Next
            End If
            If sndn > 0 Then
                Dim snds As String = "C:\PProgramming\" & fn & "\소리\"
                For a = 1 To sndn
                    My.Computer.FileSystem.CopyFile(snd(a).save, snds & snd(a).nam & ".hsnd", True)
                    snd(a).save = snds & snd(a).nam & ".hsnd"
                Next
            End If
            Dim objWriter As New System.IO.StreamWriter(saving)
            saving = "!-setting" & Chr(13) & Chr(10)
            objWriter.Write(saving)
            saving = "①|" & bgx & "|" & bgy & "|" & bglayout & Chr(13) & Chr(10) & "②|" & bgimgname & Chr(13) & Chr(10) & "③|" & bgcolor.R & "|" & bgcolor.G & "|" & bgcolor.B & Chr(13) & Chr(10)
            objWriter.Write(saving)
            saving = "!-sounds" & Chr(13) & Chr(10)
            objWriter.Write(saving)
            For a = 1 To sndn
                saving = snd(a).nam & "|" & snd(a).save & "|" & snd(a).vol & Chr(13) & Chr(10)
                objWriter.Write(saving)
            Next
            saving = "!-objects" & Chr(13) & Chr(10)
            objWriter.Write(saving)
            For a = 1 To obn
                saving = obj(a).nam & "|" & obj(a).save & "|" & obj(a).x & "|" & obj(a).y & Chr(13) & Chr(10)
                objWriter.Write(saving)
            Next
            saving = "!-variables" & Chr(13) & Chr(10)
            objWriter.Write(saving)
            For a = 1 To valn
                saving = vall(a).nam & "|" & vall(a).type & "|" & vall(a).first & Chr(13) & Chr(10)
                objWriter.Write(saving)
            Next
            saving = "!-scripts" & Chr(13) & Chr(10)
            objWriter.Write(saving)
            For a = 0 To sz(1)
                For b = -1 To sz(2)
                    For c = -1 To sz(3)
                        For d = -1 To sz(4)
                            For h = -1 To sz(5)
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
                                        If gsp(h) = "" Then
                                            num(3) = "1" & gsp(h)
                                        Else
                                            num(3) = "1" & gsp(h) & gsp(f)
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
                                            If read = num(1) & "|" & num(2) & "|" & num(3) & "|" & tg & Chr(13) & Chr(10) Then
                                                Exit For
                                            End If
                                            read = num(1) & "|" & num(2) & "|" & num(3) & "|" & tg & Chr(13) & Chr(10)
                                            objWriter.Write(read)
                                        End If
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next

            objWriter.Close()
            My.Computer.FileSystem.CopyFile(System.AppDomain.CurrentDomain.DynamicDirectory & fp, "C:\PProgramming\" & fn & "\" & fn & ".vdb", True)
            MessageBox.Show(Code_form.Tag & fn & ".vdb" & Code_form.Tag & " 로 저장되었습니다.")
        End If

    End Sub

    Private Sub addsun()
        Dim cnt As Integer
        cnt = 0
        script.SelectedNode.Nodes.Add("선택")
        If script.SelectedNode.Parent Is Nothing Then
            Dim selno As System.Windows.Forms.TreeNodeCollection = script.SelectedNode.Nodes
            For Each ChildNode As System.Windows.Forms.TreeNode In selno
                If ChildNode.Text = "선택" Then
                    cnt = cnt + 1
                    If cnt = 2 Then
                        ChildNode.Remove()
                    End If
                End If
            Next
        End If
    End Sub


    Private Sub script_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles script.MouseClick
        If script.SelectedNode Is Nothing Then
        Else
            Dim selnod As TreeNode
            selnod = script.SelectedNode
            If selnod.Parent Is Nothing And barn = 1 Then
                If selnod.Text = "선택" Then
                    slist.Items.Clear()
                    slist.Items.Add("만약 (마우스)＿＿가 클릭되었을 때")
                    slist.Items.Add("만약 (마우스)＿＿가 더블클릭되었을 때")
                    slist.Items.Add("키보드가 눌렸을 때")
                    slist.Items.Add("")
                    slist.Enabled = True
                    listbar.Enabled = True
                    actcut()
                    actbox.Visible = False
                End If
            ElseIf barn = 1 Then
                slist.Items.Clear()
                slist.Items.Add("만약 ＿＿가 ＿＿라면")
                slist.Items.Add("만약 ＿＿가 ＿＿이상이라면")
                slist.Items.Add("만약 ＿＿가 ＿＿이하라면")
                slist.Items.Add("만약 ＿＿가 ＿＿초과라면")
                slist.Items.Add("만약 ＿＿가 ＿＿미만이라면")
                slist.Items.Add("(키보드)＿＿가 눌렸을 때")
                slist.Items.Add("")
            End If
        End If
    End Sub

    Private Sub acttxt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles acttxt1.KeyPress
        If listn = 6 Then
            If Len(acttxt1.Text) > 1 Then
                MessageBox.Show("한 글자만 입력 가능합니다")
                acttxt1.Text = Mid(acttxt1.Text, 1, 1)
                acttxt1.Focus()
            End If
        End If
    End Sub

    Private Sub sizecng()
        If cngnum = 1 Then
            hruler.Width = display.Width + 2
            vruler.Left = display.Left + display.Width
            hruler.Top = display.Top + display.Height
            vruler.Height = display.Height
            Dim gapx, gapy As Integer
            gapx = bgx - xx
            gapy = bgy - xy
            listbar.Image = My.Resources.jobar '조건

            Me.Height = Me.Height + gapy
            Me.Width = Me.Width + gapx
            but_ask.Left = but_ask.Left + gapx
            but_com.Left = but_com.Left + gapx
            but_set.Left = but_set.Left + gapx
            but_code.Left = but_code.Left + gapx
            but_save.Left = but_save.Left + gapx
            but_load.Left = but_load.Left + gapx
            but_script.Left = but_script.Left + gapx
            but_object.Left = but_object.Left + gapx
            but_sound.Left = but_sound.Left + gapx
            slist.Left = slist.Left + gapx
            script.Left = script.Left + gapx
            listbar.Left = slist.Left
            slist.Height = slist.Height + gapy
            script.Top = script.Top + gapy
            listbar.Top = slist.Top - listbar.Height
            setbox.Width = setbox.Width + gapx
            obbox.Width = obbox.Width + gapx
            nobox.Width = nobox.Width + gapx
            sndbox.Width = sndbox.Width + gapx
            actbox.Width = actbox.Width + gapx
            actkor.Width = actkor.Width + gapx
            actuse.Width = actuse.Width + gapx / 2
            acthow.Left = actuse.Left + actuse.Width + 25
            actex4.Left = acthow.Left
            acthow.Width = acthow.Width + gapx / 2
            setbox.Top = setbox.Top + gapy
            obbox.Top = obbox.Top + gapy
            nobox.Top = nobox.Top + gapy
            sndbox.Top = sndbox.Top + gapy
            actbox.Top = actbox.Top + gapy
            noddel.Left = noddel.Left + gapx
            noddel.Top = noddel.Top + gapy
            nodadd.Left = nodadd.Left + gapx
            nodadd.Top = nodadd.Top + gapy
            cngnum = 0

        End If
    End Sub

    Private Sub but_com_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_com.Click
        Dim fp As String
        Dim msg As Integer
        If transfile.ShowDialog = DialogResult.OK Then
            fp = transfile.SelectedPath
            designmake()
            sourcemake()
            Dim savefolder As String = System.AppDomain.CurrentDomain.DynamicDirectory & fp & "\PProgramming_Application"
            Dim folder As String = My.Application.Info.DirectoryPath & "\savebase"
            My.Computer.FileSystem.CopyDirectory(folder, savefolder, True)
            Dim designer As String = savefolder & "\Form1.Designer.vb"
            If My.Computer.FileSystem.FileExists(designer) = True Then
                My.Computer.FileSystem.DeleteFile(designer)
            End If
            Dim objWriter1 As New System.IO.StreamWriter(designer, False, System.Text.Encoding.Unicode)
            objWriter1.Write(des)
            objWriter1.Close()
            Dim codes As String = savefolder & "\Form1.vb"
            If My.Computer.FileSystem.FileExists(codes) = True Then
                My.Computer.FileSystem.DeleteFile(codes)
            End If
            Dim objWriter2 As New System.IO.StreamWriter(codes, False, System.Text.Encoding.Unicode)
            objWriter2.Write(cod)
            objWriter2.Close()

            msg = MessageBox.Show("성공적으로 변환되었습니다." & vbCrLf & "바로 실행하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If msg = 6 Then
                Dim proc As New Process

                With proc.StartInfo
                    .FileName = savefolder & "\WindowsApplication1.vbproj"
                    .UseShellExecute = True
                    .Verb = "open"
                End With
                proc.Start()
            End If
        End If

    End Sub

    Private Sub sourcemake()
        Dim befcod As String
        cod = ""
        cod = cod & "Public Class Form1" & Chr(13) & Chr(10) & Chr(13) & Chr(10)
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
            cod = cod & tab(tb) & " Dim aa, bb, cc, dd, ee, ff, gg, hh, ii, jj, kk, ll, mm, nn, oo, pp, qq, rr, ss, tt, uu, vv, ww, xx, yy, zz as Integer" & Chr(13) & Chr(10)
            If inte <> "" Then
                cod = cod & tab(tb) & "Dim " & Mid(inte, 2) & " As Integer" & Chr(13) & Chr(10)
            End If
            If lon <> "" Then
                cod = cod & tab(tb) & "Dim " & Mid(lon, 2) & " As Long" & Chr(13) & Chr(10)
            End If
            If sin <> "" Then
                cod = cod & tab(tb) & "Dim " & Mid(sin, 2) & " As Single" & Chr(13) & Chr(10)
            End If
            If str <> "" Then
                cod = cod & tab(tb) & "Dim " & Mid(str, 2) & " As String" & Chr(13) & Chr(10)
            End If
        End If

        befcod = cod
        usecode()

        If befcod = cod Then
            cod = cod & "Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load" & Chr(13) & Chr(10)
            informset()
            cod = cod & "End Sub" & Chr(13) & Chr(10)
        End If


        tb = tb - 1
        cod = cod & "End Class" & Chr(13) & Chr(10)
    End Sub




    Private Function usecode() As action
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
                                        tb = Len(nonam)
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

        ending(1)

        endnod()

        For i = 1 To n
            cod = cod & fr(i)
            If Not (fr(i).IndexOf("Private Sub Form1_Load") = -1) Then
                informset()
            End If
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
            ln = Chr(13) & Chr(10) & "Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load"
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
            ln = Chr(13) & Chr(10) & "Private Sub " & n(2) & "_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles " & n(2) & ".Click"
            eos = 4
        ElseIf n(1) = 7 Then
            ln = Chr(13) & Chr(10) & "Private Sub " & n(2) & "_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles " & n(2) & ".DoubleClick"
            eos = 4
        ElseIf n(1) = 8 Then
            ln = Chr(13) & Chr(10) & "Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown"
            eos = 4
        ElseIf n(1) = 9 Then
            ln = "If e.KeyCode = keys." & n(2) & " Then "
            eos = 1

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




    Private Sub informset()

        If bgimgname <> "" Then
            cod = cod & tab(tb) & "Me.BackgroundImage = Image.FromFile(" & Code_form.Tag & bgimgname & Code_form.Tag & ")" & Chr(13) & Chr(10)
            Select Case display.BackgroundImageLayout
                Case ImageLayout.None
                    cod = cod & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.None" & Chr(13) & Chr(10)
                Case ImageLayout.Center
                    cod = cod & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Center" & Chr(13) & Chr(10)
                Case ImageLayout.Stretch
                    cod = cod & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Stretch" & Chr(13) & Chr(10)
                Case ImageLayout.Tile
                    cod = cod & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Tile" & Chr(13) & Chr(10)
                Case ImageLayout.Zoom
                    cod = cod & tab(tb) & "Me.BackgroundImageLayout = ImageLayout.Stretch " & Chr(13) & Chr(10)
            End Select
            cod = cod & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        End If

        If obn > 0 Then
            For i = 1 To obn
                cod = cod & tab(tb) & obj(i).nam & ".BackgroundImage = Image.FromFile(" & Code_form.Tag & obj(i).save & Code_form.Tag & ")" & Chr(13) & Chr(10)
            Next
            cod = cod & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                cod = cod & tab(tb) & snd(i).nam & ".FileName = " & Code_form.Tag & snd(i).save & Code_form.Tag & Chr(13) & Chr(10)
            Next
            cod = cod & Chr(13) & Chr(10) & Chr(13) & Chr(10)
        End If

        If valn > 0 Then
            For i = 1 To valn
                If vall(i).type = 3 Then
                    cod = cod & tab(tb) & vall(i).nam & " = " & Code_form.Tag & vall(i).first & Code_form.Tag & Chr(13) & Chr(10)
                Else
                    cod = cod & tab(tb) & vall(i).nam & " = " & vall(i).first & "" & Chr(13) & Chr(10)
                End If
            Next
        End If

    End Sub



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


    Private Sub designmake()
        des = ""

        des = destext.Text & Chr(13) & Chr(10)

        For i = 1 To 1
            des = des & vbTab & "Me.Label" & i & " = New System.Windows.Forms.Label" & Chr(13) & Chr(10)
        Next

        If sndn > 0 Then
            For i = 1 To sndn
                des = des & vbTab & "Me." & snd(i).nam & " = New AxMediaPlayer.AxMediaPlayer" & Chr(13) & Chr(10)
            Next
        End If



        If obn > 0 Then
            For i = 1 To obn
                des = des & vbTab & "Me." & obj(i).nam & " = New System.Windows.Forms.PictureBox" & Chr(13) & Chr(10)
            Next
            For i = 1 To obn
                des = des & vbTab & "CType(Me." & obj(i).nam & ", System.ComponentModel.ISupportInitialize).BeginInit()" & Chr(13) & Chr(10)
            Next
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                des = des & vbTab & "CType(Me." & snd(i).nam & ", System.ComponentModel.ISupportInitialize).BeginInit()" & Chr(13) & Chr(10)
            Next
        End If
        des = des & vbTab & "Me.SuspendLayout()" & Chr(13) & Chr(10)
        des = des & vbTab & Chr(13) & Chr(10) & Chr(13) & Chr(10)

        For i = 1 To 1
            des = des & vbTab & "Me.Label" & i & ".AutoSize = True " & Chr(13) & Chr(10)
            des = des & vbTab & "Me.Label" & i & ".Location = New System.Drawing.Point(-50,-50) " & Chr(13) & Chr(10)
            des = des & vbTab & "Me.Label" & i & ".Name = " & Code_form.Tag & "Label" & i & Code_form.Tag & Chr(13) & Chr(10)
            des = des & vbTab & "Me.Label" & i & ".Size = New System.Drawing.Size(42, 12) " & Chr(13) & Chr(10)
            des = des & vbTab & "Me.Label" & i & ".TabIndex =" & i - 1 & Chr(13) & Chr(10)
            des = des & vbTab & "Me.Label" & i & ".Text = """ & Code_form.Tag & Chr(13) & Chr(10)
            des = des & vbTab & "Me.Label" & i & ".Visible = true " & Chr(13) & Chr(10)
            des = des & vbTab & Chr(13) & Chr(10)
        Next

        If obn > 0 Then
            For i = 1 To obn
                des = des & vbTab & "Me." & obj(i).nam & ".BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch" & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & obj(i).nam & ".Location = New System.Drawing.Point(-" & obj(obn).x & ", -" & obj(obn).y & ") " & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & obj(i).nam & ".Name = " & Code_form.Tag & obj(i).nam & Code_form.Tag & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & obj(i).nam & ".Size = New System.Drawing.Size(" & obj(obn).x & ", " & obj(obn).y & ")" & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & obj(i).nam & ".TabIndex = " & 9 + i & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & obj(i).nam & ".TabStop = False" & Chr(13) & Chr(10)
                des = des & vbTab & Chr(13) & Chr(10)
            Next
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                des = des & vbTab & "Me." & snd(i).nam & ".Location = New System.Drawing.Point(-300, -300)" & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & snd(i).nam & ".Name = " & Code_form.Tag & snd(i).nam & Code_form.Tag & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & snd(i).nam & ".OcxState = CType(Resources.GetObject(" & Code_form.Tag & "AxMediaPlayer1.OcxState" & Code_form.Tag & "), System.Windows.Forms.AxHost.State)" & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & snd(i).nam & ".Size = New System.Drawing.Size(30, 30) " & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & snd(i).nam & ".TabIndex = " & 9 + obn + i & Chr(13) & Chr(10)
                des = des & vbTab & "Me." & snd(i).nam & ".Visible = False" & Chr(13) & Chr(10)
                des = des & vbTab & Chr(13) & Chr(10)
            Next
        End If


        des = des & vbTab & Chr(13) & Chr(10) & Chr(13) & Chr(10)

        des = des & vbTab & "Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)" & Chr(13) & Chr(10)
        des = des & vbTab & "Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font" & Chr(13) & Chr(10)
        des = des & vbTab & "Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(" & bgcolor.R & ", Byte), Integer), CType(CType(" & bgcolor.G & ", Byte), Integer), CType(CType(" & bgcolor.B & ", Byte), Integer))" & Chr(13) & Chr(10)
        des = des & vbTab & "Me.ClientSize = New System.Drawing.Size(" & display.Width & "," & display.Height & ")" & Chr(13) & Chr(10)
        If sndn > 0 Then
            For i = 1 To sndn
                des = des & vbTab & "Me.Controls.Add(Me." & snd(i).nam & ")" & Chr(13) & Chr(10)
            Next
        End If

        For i = 1 To 1
            des = des & vbTab & "Me.Controls.Add(Me.Label" & i & ")" & Chr(13) & Chr(10)
        Next

        If obn > 0 Then
            For i = 1 To obn
                des = des & vbTab & "Me.Controls.Add(Me." & obj(i).nam & ")" & Chr(13) & Chr(10)
            Next
        End If

        des = des & vbTab & "Me.Name = " & Code_form.Tag & "Form1" & Code_form.Tag & Chr(13) & Chr(10)
        des = des & vbTab & "Me.Text = " & Code_form.Tag & "Form1" & Code_form.Tag & Chr(13) & Chr(10)

        If obn > 0 Then
            For i = 1 To obn
                des = des & vbTab & "CType(Me." & obj(i).nam & ", System.ComponentModel.ISupportInitialize).EndInit()" & Chr(13) & Chr(10)
            Next
        End If

        If sndn > 0 Then
            For i = 1 To sndn
                des = des & vbTab & "CType(Me." & snd(i).nam & ", System.ComponentModel.ISupportInitialize).EndInit()" & Chr(13) & Chr(10)
            Next
        End If


        des = des & vbTab & "Me.ResumeLayout(False)" & Chr(13) & Chr(10)
        des = des & vbTab & "Me.PerformLayout()" & Chr(13) & Chr(10)
        des = des & vbTab & "End Sub" & Chr(13) & Chr(10)

        For a = 1 To 1
            des = des & vbTab & "Friend WithEvents Label" & a & " As System.Windows.Forms.Label" & Chr(13) & Chr(10)
        Next
        If sndn > 0 Then
            For i = 1 To sndn
                des = des & vbTab & "Friend WithEvents " & snd(i).nam & " As AxMediaPlayer.AxMediaPlayer" & Chr(13) & Chr(10)
            Next
        End If
        If obn > 0 Then
            For i = 1 To obn
                des = des & vbTab & "Friend WithEvents " & obj(i).nam & " As System.Windows.Forms.PictureBox" & Chr(13) & Chr(10)
            Next
        End If
        des = des & "End Class"

    End Sub

    Private Sub griding(ByVal mx As Integer, ByVal myy As Integer)
        Dim grid As String = "(" & mx & ", " & myy & ")"
        display.BackgroundImage = display.BackgroundImage
        Dim gh As Bitmap = New Bitmap(bgx, bgy)
        Dim g As Graphics = display.CreateGraphics
        Dim npen As New Pen(Color.Black, 1)
        Dim point1 As New PointF(mx, 0)
        Dim point2 As New PointF(mx, bgy)
        Dim point3 As New PointF(0, myy)
        Dim point4 As New PointF(bgx, myy)
        Dim point5 As New PointF(mx + 10, myy + 3)
        Dim anst As New Bitmap(bgx, bgy)
        g.DrawImage(bmp, 0, 0)
        g.DrawLine(npen, point1, point2)
        g.DrawLine(npen, point3, point4)
        g.DrawString(grid, slist.Font, Brushes.BlueViolet, point5)
        g.Dispose()
        gh.Dispose()
    End Sub

    Private Sub bmpset()
        Me.Refresh()
        Setting_form.Visible = False
        display.Image = display.Image
        display.BackgroundImage = display.BackgroundImage
        display.BackColor = display.BackColor
        Dim g As Graphics
        g = Graphics.FromImage(bmp)
        g.CopyFromScreen(PointToScreen(display.Location), New Point(0, 0), bmp.Size, System.Drawing.CopyPixelOperation.MergeCopy)
        bmpcnt = 1
    End Sub

    Private Sub display_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles display.MouseLeave
        display.Image = display.Image
        bmpset()
    End Sub

    Private Sub display_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles display.MouseMove
        If fmcolor = 1 Then
            If barn = 2 Then
                If slist.SelectedItem = "＿＿를 ＿＿에 이동" Or slist.SelectedItem = "'＿＿'라고 ＿＿에 타이핑 " Or mmon = 1 Then
                    If bmpcnt = 0 Then
                        bmpset()
                    End If
                    griding(e.X, e.Y)
                End If
            End If
        End If


    End Sub

    Private Sub vruler_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles vruler.MouseMove
        display.Image = display.Image
        bmpset()
    End Sub

    Private Sub hruler_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles hruler.MouseMove
        display.Image = display.Image
        bmpset()
    End Sub



    Private Sub Main_form_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        Dim x As Integer = Me.Location.X + Me.Width
        Dim y As Integer = Me.Location.Y + Me.Height / 2 - 250
        tutorial_form.Location = New Point(x, y)
    End Sub
End Class
