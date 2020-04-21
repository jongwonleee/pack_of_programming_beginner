Imports System.IO
Imports System.Windows
Public Class ask_form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell("explorer http://www.microsoft.com/korea/msdn/vstudio/express/support/install/", vbMaximizedFocus)
    End Sub

    Private Sub ok_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_but.Click
        Dim check As String = My.Application.Info.DirectoryPath & "\readfirst.dat"
        If CheckBox1.Checked = True Then
            Dim objWriter1 As New System.IO.StreamWriter(check)
            objWriter1.Write("")
            objWriter1.Close()
        Else
            If My.Computer.FileSystem.FileExists(check) = True Then
                My.Computer.FileSystem.DeleteFile(check)
            End If
        End If
        Main_form.Enabled = True
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "훈민정.Net 이란?" Then
            exp.Text = txt1.Text
            Button1.Visible = False
        ElseIf ListBox1.SelectedItem = "프로그램 주요 기능" Then
            exp.Text = txt2.Text
            Button1.Visible = False
        ElseIf ListBox1.SelectedItem = "인터페이스" Then
            Button1.Visible = False
        ElseIf ListBox1.SelectedItem = "명령문의 생성 및 수정" Then
            exp.Text = txt3.Text
            Button1.Visible = False
        ElseIf ListBox1.SelectedItem = "Visual Studio 2005란?" Then
            exp.Text = txt4.Text
            Button1.Visible = False
        ElseIf ListBox1.SelectedItem = "Visual Studio 2005 설치 방법" Then
            exp.Text = txt5.Text
            Button1.Visible = True
        ElseIf ListBox1.SelectedItem = "제작자" Then
            exp.Text = txt6.Text
            Button1.Visible = False
        End If
        If ListBox1.SelectedItem = "인터페이스" Then
            ex_inter.Visible = True
            ex_inter.Enabled = True
            pic_inter.Visible = True
            pic_inter.Enabled = True
        Else
            ex_inter.Visible = False
            ex_inter.Enabled = False
            pic_inter.Visible = False
            pic_inter.Enabled = False
        End If
    End Sub

    Private Sub ask_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim check As String = My.Application.Info.DirectoryPath & "\readfirst.dat"
        If My.Computer.FileSystem.FileExists(check) = True Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub pic_inter_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic_inter.MouseMove
        If e.X < 343 And e.Y > 54 And e.Y < 311 Then
            ex_inter.Text = ex1.Text
        End If
        If e.X < 362 And e.Y > 327 And e.Y < 407 Then
            ex_inter.Text = ex2.Text
        End If
        If e.X < 487 Then
            If e.X > 350 Then
                If e.Y > 54 And e.Y < 70 Then
                    ex_inter.Text = ex3.Text
                End If
                If e.Y > 74 And e.Y < 91 Then
                    ex_inter.Text = ex4.Text
                End If
            End If
            If e.X > 365 Then
                If e.Y > 96 And e.Y < 301 Then
                    ex_inter.Text = ex5.Text
                End If
                If e.Y > 313 And e.Y < 407 Then
                    ex_inter.Text = ex6.Text
                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Main_form.Enabled = True
        Me.Close()
        tutorial_form.Show()
        Dim x As Integer = Main_form.Location.X + Main_form.Width
        Dim y As Integer = Main_form.Location.Y + Main_form.Height / 2 - 250
        tutorial_form.Location = New Point(x, y)
    End Sub
End Class