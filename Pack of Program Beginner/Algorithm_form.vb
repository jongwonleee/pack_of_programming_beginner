Imports System.CodeDom.Compiler
Public Class Algorithm_form
    Private Structure clr
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
    End Structure
    Dim nowc, newc As clr
    Dim lastpg, nowpg, type, cmode As Integer

    Private Sub getc(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer)
        nowc.r = Me.BackColor.R
        nowc.g = Me.BackColor.G
        nowc.b = Me.BackColor.B
        newc.r = r
        newc.g = g
        newc.b = b
        colortimer.Enabled = True
    End Sub
    Dim source As String

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

    Private Sub Algorithm_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmode = 1
        but_src.Visible = False
        stuclr = 1
    End Sub

    Private Sub butC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butC.Click
        getc(192, 192, 255)
        cmode = 1
        stuclr = 1
    End Sub

    Private Sub butVB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVB.Click
        getc(160, 160, 255)
        cmode = 2
        stuclr = 2
    End Sub

    Private Sub butJS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butJS.Click
        getc(128, 128, 255)
        cmode = 3
        stuclr = 3
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_end.Click
        Me.Close()
        study_form.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_save.Click
        Dim fp, fn As String
        If savefile.ShowDialog = DialogResult.OK Then
            fp = savefile.FileName
            fn = getname(fp)
            Dim saving As String = System.AppDomain.CurrentDomain.DynamicDirectory & fp
            If My.Computer.FileSystem.FileExists(saving) = True Then
                My.Computer.FileSystem.DeleteFile(saving)
            End If
            Dim objWriter As New System.IO.StreamWriter(saving)
            objWriter.Write(cmode & vbCrLf)
            objWriter.Write(codetxt.Text)
            objWriter.Close()
            MessageBox.Show(Code_form.Tag & fn & "valg" & Code_form.Tag & " 로 저장되었습니다.")
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

    Private Sub but_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_load.Click
        Dim fp, reads As String
        If openfile.ShowDialog = DialogResult.OK Then
            fp = openfile.FileName
            Dim loading As String = System.AppDomain.CurrentDomain.DynamicDirectory & fp
            Dim objReader As New System.IO.StreamReader(loading)
            reads = "0"
            cmode = Val(Mid(objReader.ReadLine, 1, 1))
            reads = objReader.ReadToEnd
            codetxt.Text = reads
            Select Case cmode
                Case 1
                    getc(192, 192, 255)
                Case 2
                    getc(160, 160, 255)
                Case 3
                    getc(128, 128, 255)
            End Select
            objReader.Close()
        End If
    End Sub

    Private Sub but_com_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_com.Click
        Dim opt As New CodeDom.Compiler.CompilerParameters
        Dim provider
        Select Case cmode
            Case 1
                provider = VBCodeProvider.CreateProvider("CSharp")
            Case 2
                provider = VBCodeProvider.CreateProvider("VisualBasic")
            Case 3
                provider = VBCodeProvider.CreateProvider("JScript")
        End Select

        opt.GenerateExecutable = True
        opt.OutputAssembly = "C:\test.exe" '저장되는 장소
        source = codetxt.Text
        Dim err = provider.CompileAssemblyFromSource(opt, source)
        If err.Errors.Count > 0 Then
            codetxt.Text = ""
            For i = 0 To err.Errors.Count - 1
                codetxt.Text = codetxt.Text & err.Errors(i).ToString & vbCrLf
            Next
            but_src.Visible = True
        Else
            Process.Start("C:\test.exe")
        End If
    End Sub

    Private Sub but_src_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_src.Click
        codetxt.Text = source
        but_src.Visible = False
        source = ""
    End Sub

    Private Sub but_exe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_exe.Click
        Dim fp, fn As String
        If Saveexe.ShowDialog = DialogResult.OK Then
            fp = Saveexe.FileName
            fn = getname(fp)
            Dim opt As New CodeDom.Compiler.CompilerParameters
            Dim provider
            Select Case cmode
                Case 1
                    provider = VBCodeProvider.CreateProvider("CSharp")
                Case 2
                    provider = VBCodeProvider.CreateProvider("VisualBasic")
                Case 3
                    provider = VBCodeProvider.CreateProvider("JScript")
            End Select
            opt.GenerateExecutable = True
            opt.OutputAssembly = fp
            source = codetxt.Text
            Dim err = provider.CompileAssemblyFromSource(opt, source)
            If err.Errors.Count > 0 Then
                codetxt.Text = ""
                For i = 0 To err.Errors.Count - 1
                    codetxt.Text = codetxt.Text & err.Errors(i).ToString & vbCrLf
                Next
                but_src.Visible = True
            Else
                MessageBox.Show(Code_form.Tag & fn & ".exe" & Code_form.Tag & " 로 저장되었습니다.")
            End If


        End If
    End Sub

    Private Sub but_stu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_stu.Click
        study_form.Show()
        Dim x As Integer = Me.Location.X + Me.Width
        Dim y As Integer = Me.Location.Y + Me.Height / 2 - 250
        study_form.Location = New Point(x, y)
    End Sub
End Class