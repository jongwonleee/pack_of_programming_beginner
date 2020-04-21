<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class study_form
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(study_form))
        Me.Colortimer = New System.Windows.Forms.Timer(Me.components)
        Me.detectimer = New System.Windows.Forms.Timer(Me.components)
        Me.but_end = New System.Windows.Forms.Label()
        Me.but_sub9 = New System.Windows.Forms.Label()
        Me.but_sub8 = New System.Windows.Forms.Label()
        Me.but_sub7 = New System.Windows.Forms.Label()
        Me.but_sub6 = New System.Windows.Forms.Label()
        Me.but_sub5 = New System.Windows.Forms.Label()
        Me.but_sub4 = New System.Windows.Forms.Label()
        Me.but_sub3 = New System.Windows.Forms.Label()
        Me.but_sub2 = New System.Windows.Forms.Label()
        Me.but_sub1 = New System.Windows.Forms.Label()
        Me.exp = New System.Windows.Forms.TextBox()
        Me._msg = New System.Windows.Forms.Label()
        Me._val = New System.Windows.Forms.Label()
        Me._str = New System.Windows.Forms.Label()
        Me._abs = New System.Windows.Forms.Label()
        Me._dim = New System.Windows.Forms.Label()
        Me._trim = New System.Windows.Forms.Label()
        Me._inst = New System.Windows.Forms.Label()
        Me._lca = New System.Windows.Forms.Label()
        Me._uca = New System.Windows.Forms.Label()
        Me._len = New System.Windows.Forms.Label()
        Me._mid = New System.Windows.Forms.Label()
        Me._do = New System.Windows.Forms.Label()
        Me._for = New System.Windows.Forms.Label()
        Me._goto = New System.Windows.Forms.Label()
        Me._sel = New System.Windows.Forms.Label()
        Me._if = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._pri = New System.Windows.Forms.Label()
        Me._mod = New System.Windows.Forms.Label()
        Me._q1 = New System.Windows.Forms.Label()
        Me._q2 = New System.Windows.Forms.Label()
        Me._q3 = New System.Windows.Forms.Label()
        Me._q4 = New System.Windows.Forms.Label()
        Me._q5 = New System.Windows.Forms.Label()
        Me._q6 = New System.Windows.Forms.Label()
        Me._q7 = New System.Windows.Forms.Label()
        Me._q8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Colortimer
        '
        Me.Colortimer.Interval = 1
        '
        'detectimer
        '
        Me.detectimer.Enabled = True
        Me.detectimer.Interval = 1
        '
        'but_end
        '
        Me.but_end.BackColor = System.Drawing.Color.Black
        Me.but_end.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_end.ForeColor = System.Drawing.Color.White
        Me.but_end.Location = New System.Drawing.Point(328, 460)
        Me.but_end.Name = "but_end"
        Me.but_end.Size = New System.Drawing.Size(72, 40)
        Me.but_end.TabIndex = 7
        Me.but_end.Text = "종료"
        Me.but_end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub9
        '
        Me.but_sub9.BackColor = System.Drawing.Color.White
        Me.but_sub9.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub9.Location = New System.Drawing.Point(328, 417)
        Me.but_sub9.Name = "but_sub9"
        Me.but_sub9.Size = New System.Drawing.Size(72, 40)
        Me.but_sub9.TabIndex = 8
        Me.but_sub9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub8
        '
        Me.but_sub8.BackColor = System.Drawing.Color.White
        Me.but_sub8.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub8.Location = New System.Drawing.Point(328, 374)
        Me.but_sub8.Name = "but_sub8"
        Me.but_sub8.Size = New System.Drawing.Size(72, 40)
        Me.but_sub8.TabIndex = 9
        Me.but_sub8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub7
        '
        Me.but_sub7.BackColor = System.Drawing.Color.White
        Me.but_sub7.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub7.Location = New System.Drawing.Point(328, 331)
        Me.but_sub7.Name = "but_sub7"
        Me.but_sub7.Size = New System.Drawing.Size(72, 40)
        Me.but_sub7.TabIndex = 10
        Me.but_sub7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub6
        '
        Me.but_sub6.BackColor = System.Drawing.Color.White
        Me.but_sub6.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub6.Location = New System.Drawing.Point(328, 288)
        Me.but_sub6.Name = "but_sub6"
        Me.but_sub6.Size = New System.Drawing.Size(72, 40)
        Me.but_sub6.TabIndex = 11
        Me.but_sub6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub5
        '
        Me.but_sub5.BackColor = System.Drawing.Color.White
        Me.but_sub5.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub5.Location = New System.Drawing.Point(328, 245)
        Me.but_sub5.Name = "but_sub5"
        Me.but_sub5.Size = New System.Drawing.Size(72, 40)
        Me.but_sub5.TabIndex = 12
        Me.but_sub5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub4
        '
        Me.but_sub4.BackColor = System.Drawing.Color.White
        Me.but_sub4.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub4.Location = New System.Drawing.Point(328, 202)
        Me.but_sub4.Name = "but_sub4"
        Me.but_sub4.Size = New System.Drawing.Size(72, 40)
        Me.but_sub4.TabIndex = 13
        Me.but_sub4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub3
        '
        Me.but_sub3.BackColor = System.Drawing.Color.White
        Me.but_sub3.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub3.Location = New System.Drawing.Point(328, 159)
        Me.but_sub3.Name = "but_sub3"
        Me.but_sub3.Size = New System.Drawing.Size(72, 40)
        Me.but_sub3.TabIndex = 14
        Me.but_sub3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub2
        '
        Me.but_sub2.BackColor = System.Drawing.Color.White
        Me.but_sub2.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub2.Location = New System.Drawing.Point(328, 116)
        Me.but_sub2.Name = "but_sub2"
        Me.but_sub2.Size = New System.Drawing.Size(72, 40)
        Me.but_sub2.TabIndex = 15
        Me.but_sub2.Text = "예제"
        Me.but_sub2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sub1
        '
        Me.but_sub1.BackColor = System.Drawing.Color.White
        Me.but_sub1.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_sub1.Location = New System.Drawing.Point(328, 73)
        Me.but_sub1.Name = "but_sub1"
        Me.but_sub1.Size = New System.Drawing.Size(72, 40)
        Me.but_sub1.TabIndex = 16
        Me.but_sub1.Text = "명령어"
        Me.but_sub1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exp
        '
        Me.exp.BackColor = System.Drawing.Color.White
        Me.exp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.exp.Location = New System.Drawing.Point(5, 73)
        Me.exp.Multiline = True
        Me.exp.Name = "exp"
        Me.exp.ReadOnly = True
        Me.exp.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.exp.Size = New System.Drawing.Size(320, 427)
        Me.exp.TabIndex = 17
        Me.exp.WordWrap = False
        '
        '_msg
        '
        Me._msg.Location = New System.Drawing.Point(12, 9)
        Me._msg.Name = "_msg"
        Me._msg.Size = New System.Drawing.Size(5, 5)
        Me._msg.TabIndex = 33
        Me._msg.Text = resources.GetString("_msg.Text")
        Me._msg.Visible = False
        '
        '_val
        '
        Me._val.Location = New System.Drawing.Point(12, 9)
        Me._val.Name = "_val"
        Me._val.Size = New System.Drawing.Size(5, 5)
        Me._val.TabIndex = 32
        Me._val.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Val - 문자 형식의 데이터를 수로 변환" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atoi( 문자열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Val( 문자열" & _
            " )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number( 문자열 )"
        Me._val.Visible = False
        '
        '_str
        '
        Me._str.Location = New System.Drawing.Point(12, 9)
        Me._str.Name = "_str"
        Me._str.Size = New System.Drawing.Size(5, 5)
        Me._str.TabIndex = 31
        Me._str.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Str - 숫자 형식의 데이터를 문자로 변환" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ultoa( 값, 문자열, 값의 진수 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic " & _
            "- " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Str( 값 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "String( 값 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "값.toString()"
        Me._str.Visible = False
        '
        '_abs
        '
        Me._abs.Location = New System.Drawing.Point(12, 9)
        Me._abs.Name = "_abs"
        Me._abs.Size = New System.Drawing.Size(5, 5)
        Me._abs.TabIndex = 30
        Me._abs.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abs - 값의 절대값을 구함" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abs( 값 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abs( 값 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaSc" & _
            "ript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Math.Abs( 값 )"
        Me._abs.Visible = False
        '
        '_dim
        '
        Me._dim.Location = New System.Drawing.Point(12, 9)
        Me._dim.Name = "_dim"
        Me._dim.Size = New System.Drawing.Size(5, 5)
        Me._dim.TabIndex = 29
        Me._dim.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "변수 선언 - 프로그램에서 사용할 변수의 자료형와 이름을 선언" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C#, JavaScript -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "자료형 변수명1, 변수명2, " & _
            "... ;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "자료형 변수명1 = 초기값" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dim 변수명1, 변수명2, ... As 자료형" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dim 변수명1 As" & _
            " 자료형 = 초기값"
        Me._dim.Visible = False
        '
        '_trim
        '
        Me._trim.Location = New System.Drawing.Point(12, 9)
        Me._trim.Name = "_trim"
        Me._trim.Size = New System.Drawing.Size(5, 5)
        Me._trim.TabIndex = 28
        Me._trim.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trim - 문자열의 좌우 공백을 제거" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "*C#은 별도의 명령어가 없음" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trim( 문자열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문자열.trim()"
        Me._trim.Visible = False
        '
        '_inst
        '
        Me._inst.Location = New System.Drawing.Point(12, 9)
        Me._inst.Name = "_inst"
        Me._inst.Size = New System.Drawing.Size(5, 5)
        Me._inst.TabIndex = 27
        Me._inst.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instr - 문자열에서 찾을 문자의 위치값을 구함" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "strchr( 문자열, ""찾을문자"")" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasi" & _
            "c - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instr( 시작위치, 문자열, ""찾을문자"" )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " *시작위치를 지정하지 않으면 처음부터 문자를 찾음" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문자열.IndexOf(""찾을문자"")"
        Me._inst.Visible = False
        '
        '_lca
        '
        Me._lca.Location = New System.Drawing.Point(12, 9)
        Me._lca.Name = "_lca"
        Me._lca.Size = New System.Drawing.Size(5, 5)
        Me._lca.TabIndex = 26
        Me._lca.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lcase - 문자열을 소문자로 변경" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "strlwr( 문자열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lcase( 문자" & _
            "열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문자열.toLowerCase()"
        Me._lca.Visible = False
        '
        '_uca
        '
        Me._uca.Location = New System.Drawing.Point(12, 9)
        Me._uca.Name = "_uca"
        Me._uca.Size = New System.Drawing.Size(5, 5)
        Me._uca.TabIndex = 25
        Me._uca.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ucase - 문자열을 대문자로 변경" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "strupr( 문자열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ucase( 문자" & _
            "열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문자열.toUpperCase()"
        Me._uca.Visible = False
        '
        '_len
        '
        Me._len.Location = New System.Drawing.Point(12, 9)
        Me._len.Name = "_len"
        Me._len.Size = New System.Drawing.Size(5, 5)
        Me._len.TabIndex = 24
        Me._len.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Len - 문자열의 길이(단어의 개수)를 구함" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "strlen( 문자열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Len(" & _
            " 문자열 )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JavaScript - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문자열.length()"
        Me._len.Visible = False
        '
        '_mid
        '
        Me._mid.Location = New System.Drawing.Point(12, 9)
        Me._mid.Name = "_mid"
        Me._mid.Size = New System.Drawing.Size(5, 5)
        Me._mid.TabIndex = 23
        Me._mid.Text = resources.GetString("_mid.Text")
        Me._mid.Visible = False
        '
        '_do
        '
        Me._do.Location = New System.Drawing.Point(12, 9)
        Me._do.Name = "_do"
        Me._do.Size = New System.Drawing.Size(5, 5)
        Me._do.TabIndex = 22
        Me._do.Text = resources.GetString("_do.Text")
        Me._do.Visible = False
        '
        '_for
        '
        Me._for.Location = New System.Drawing.Point(12, 9)
        Me._for.Name = "_for"
        Me._for.Size = New System.Drawing.Size(5, 5)
        Me._for.TabIndex = 21
        Me._for.Text = resources.GetString("_for.Text")
        Me._for.Visible = False
        '
        '_goto
        '
        Me._goto.Location = New System.Drawing.Point(12, 9)
        Me._goto.Name = "_goto"
        Me._goto.Size = New System.Drawing.Size(5, 5)
        Me._goto.TabIndex = 20
        Me._goto.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Goto - 잘 쓰이는 명령문은 아니지만 쓰기가 간단" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "* Java Script에선 사용 불가" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C# - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "" & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(지점 이름):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "goto (지점 이름):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(지점 이름):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "goto (지점 이름)"
        Me._goto.Visible = False
        '
        '_sel
        '
        Me._sel.Location = New System.Drawing.Point(12, 9)
        Me._sel.Name = "_sel"
        Me._sel.Size = New System.Drawing.Size(5, 5)
        Me._sel.TabIndex = 19
        Me._sel.Text = resources.GetString("_sel.Text")
        Me._sel.Visible = False
        '
        '_if
        '
        Me._if.Location = New System.Drawing.Point(12, 9)
        Me._if.Name = "_if"
        Me._if.Size = New System.Drawing.Size(5, 5)
        Me._if.TabIndex = 18
        Me._if.Text = resources.GetString("_if.Text")
        Me._if.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 427)
        Me.Label1.TabIndex = 34
        '
        '_pri
        '
        Me._pri.Location = New System.Drawing.Point(12, 9)
        Me._pri.Name = "_pri"
        Me._pri.Size = New System.Drawing.Size(5, 5)
        Me._pri.TabIndex = 35
        Me._pri.Text = resources.GetString("_pri.Text")
        Me._pri.Visible = False
        '
        '_mod
        '
        Me._mod.Location = New System.Drawing.Point(12, 9)
        Me._mod.Name = "_mod"
        Me._mod.Size = New System.Drawing.Size(5, 5)
        Me._mod.TabIndex = 36
        Me._mod.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mod - 나머지를 구함" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<사용법>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C#, JavaScript -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "수 % 나눌 값" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VisualBasic - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "수 mod 나눌 " & _
            "값"
        Me._mod.Visible = False
        '
        '_q1
        '
        Me._q1.Location = New System.Drawing.Point(12, 9)
        Me._q1.Name = "_q1"
        Me._q1.Size = New System.Drawing.Size(5, 5)
        Me._q1.TabIndex = 37
        Me._q1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 1 - 1에서 100 사이의 모든 수를 더해서 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5050"
        Me._q1.Visible = False
        '
        '_q2
        '
        Me._q2.Location = New System.Drawing.Point(12, 9)
        Me._q2.Name = "_q2"
        Me._q2.Size = New System.Drawing.Size(5, 5)
        Me._q2.TabIndex = 38
        Me._q2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 2 - 1에서 100 사이의 모든 4의 배수를 더해서 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1300"
        Me._q2.Visible = False
        '
        '_q3
        '
        Me._q3.Location = New System.Drawing.Point(12, 9)
        Me._q3.Name = "_q3"
        Me._q3.Size = New System.Drawing.Size(5, 5)
        Me._q3.TabIndex = 39
        Me._q3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 3 - *로 이루어진 높이 6의 삼각형 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "**" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "***" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "****" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*****" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "******"
        Me._q3.Visible = False
        '
        '_q4
        '
        Me._q4.Location = New System.Drawing.Point(12, 9)
        Me._q4.Name = "_q4"
        Me._q4.Size = New System.Drawing.Size(5, 5)
        Me._q4.TabIndex = 40
        Me._q4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 4 - 같은 층은 같은 숫자로 이루어진 높이 6의 삼각형 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "333" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4444" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "55555" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "666" & _
            "666"
        Me._q4.Visible = False
        '
        '_q5
        '
        Me._q5.Location = New System.Drawing.Point(12, 9)
        Me._q5.Name = "_q5"
        Me._q5.Size = New System.Drawing.Size(5, 5)
        Me._q5.TabIndex = 41
        Me._q5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 5 - 맨 앞의 수의 배수로 이루어진 6 x 6 짜리 사각형 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" & Global.Microsoft.VisualBasic.ChrW(9) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "3" & Global.Microsoft.VisualBasic.ChrW(9) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "6" & Global.Microsoft.VisualBasic.ChrW(9) & "8" & Global.Microsoft.VisualBasic.ChrW(9) & "10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(9) & "6" & _
            "" & Global.Microsoft.VisualBasic.ChrW(9) & "9" & Global.Microsoft.VisualBasic.ChrW(9) & "12" & Global.Microsoft.VisualBasic.ChrW(9) & "15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "8" & Global.Microsoft.VisualBasic.ChrW(9) & "12" & Global.Microsoft.VisualBasic.ChrW(9) & "16" & Global.Microsoft.VisualBasic.ChrW(9) & "20" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(9) & "10" & Global.Microsoft.VisualBasic.ChrW(9) & "15" & Global.Microsoft.VisualBasic.ChrW(9) & "20" & Global.Microsoft.VisualBasic.ChrW(9) & "25"
        Me._q5.Visible = False
        '
        '_q6
        '
        Me._q6.Location = New System.Drawing.Point(12, 9)
        Me._q6.Name = "_q6"
        Me._q6.Size = New System.Drawing.Size(5, 5)
        Me._q6.TabIndex = 42
        Me._q6.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 6 - 5 x 5 짜리 마방진 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "17" & Global.Microsoft.VisualBasic.ChrW(9) & "24" & Global.Microsoft.VisualBasic.ChrW(9) & "1" & Global.Microsoft.VisualBasic.ChrW(9) & "8" & Global.Microsoft.VisualBasic.ChrW(9) & "15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "23" & Global.Microsoft.VisualBasic.ChrW(9) & "5" & Global.Microsoft.VisualBasic.ChrW(9) & "7" & Global.Microsoft.VisualBasic.ChrW(9) & "14" & Global.Microsoft.VisualBasic.ChrW(9) & "16" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "6" & Global.Microsoft.VisualBasic.ChrW(9) & "13" & Global.Microsoft.VisualBasic.ChrW(9) & "20" & Global.Microsoft.VisualBasic.ChrW(9) & "22" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" & _
            "0" & Global.Microsoft.VisualBasic.ChrW(9) & "12" & Global.Microsoft.VisualBasic.ChrW(9) & "19" & Global.Microsoft.VisualBasic.ChrW(9) & "21" & Global.Microsoft.VisualBasic.ChrW(9) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "11" & Global.Microsoft.VisualBasic.ChrW(9) & "18" & Global.Microsoft.VisualBasic.ChrW(9) & "25" & Global.Microsoft.VisualBasic.ChrW(9) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "9"
        Me._q6.Visible = False
        '
        '_q7
        '
        Me._q7.Location = New System.Drawing.Point(12, 9)
        Me._q7.Name = "_q7"
        Me._q7.Size = New System.Drawing.Size(5, 5)
        Me._q7.TabIndex = 43
        Me._q7.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 7 - 숫자가 달팽이 등껍질 모양으로 이루어진 5 x 5 짜리 사각형 출력 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1" & Global.Microsoft.VisualBasic.ChrW(9) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "3" & Global.Microsoft.VisualBasic.ChrW(9) & "4" & Global.Microsoft.VisualBasic.ChrW(9) & "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16" & Global.Microsoft.VisualBasic.ChrW(9) & "17" & Global.Microsoft.VisualBasic.ChrW(9) & "18" & Global.Microsoft.VisualBasic.ChrW(9) & _
            "19" & Global.Microsoft.VisualBasic.ChrW(9) & "6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "15" & Global.Microsoft.VisualBasic.ChrW(9) & "24" & Global.Microsoft.VisualBasic.ChrW(9) & "25" & Global.Microsoft.VisualBasic.ChrW(9) & "20" & Global.Microsoft.VisualBasic.ChrW(9) & "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "14" & Global.Microsoft.VisualBasic.ChrW(9) & "23" & Global.Microsoft.VisualBasic.ChrW(9) & "22" & Global.Microsoft.VisualBasic.ChrW(9) & "21" & Global.Microsoft.VisualBasic.ChrW(9) & "8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "13" & Global.Microsoft.VisualBasic.ChrW(9) & "12" & Global.Microsoft.VisualBasic.ChrW(9) & "11" & Global.Microsoft.VisualBasic.ChrW(9) & "10" & Global.Microsoft.VisualBasic.ChrW(9) & "9"
        Me._q7.Visible = False
        '
        '_q8
        '
        Me._q8.Location = New System.Drawing.Point(12, 9)
        Me._q8.Name = "_q8"
        Me._q8.Size = New System.Drawing.Size(5, 5)
        Me._q8.TabIndex = 44
        Me._q8.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "문제 8 - 구구단 7단 출력" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<출력 예>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 1 = 7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 2 = 14" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 3 = 21" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 4 = 28" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 " & _
            "x 5 = 35" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 6 = 42" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 7 = 49" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 8 = 56" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7 x 9 = 63"
        Me._q8.Visible = False
        '
        'study_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.PackofProginner.My.Resources.Resources.bg_stydy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(400, 503)
        Me.Controls.Add(Me._q8)
        Me.Controls.Add(Me._q7)
        Me.Controls.Add(Me._q6)
        Me.Controls.Add(Me._q5)
        Me.Controls.Add(Me._q4)
        Me.Controls.Add(Me._q3)
        Me.Controls.Add(Me._q2)
        Me.Controls.Add(Me._q1)
        Me.Controls.Add(Me._mod)
        Me.Controls.Add(Me._pri)
        Me.Controls.Add(Me._msg)
        Me.Controls.Add(Me._val)
        Me.Controls.Add(Me._str)
        Me.Controls.Add(Me._abs)
        Me.Controls.Add(Me._dim)
        Me.Controls.Add(Me._trim)
        Me.Controls.Add(Me._inst)
        Me.Controls.Add(Me._lca)
        Me.Controls.Add(Me._uca)
        Me.Controls.Add(Me._len)
        Me.Controls.Add(Me._mid)
        Me.Controls.Add(Me._do)
        Me.Controls.Add(Me._for)
        Me.Controls.Add(Me._goto)
        Me.Controls.Add(Me._sel)
        Me.Controls.Add(Me._if)
        Me.Controls.Add(Me.exp)
        Me.Controls.Add(Me.but_sub1)
        Me.Controls.Add(Me.but_sub2)
        Me.Controls.Add(Me.but_sub3)
        Me.Controls.Add(Me.but_sub4)
        Me.Controls.Add(Me.but_sub5)
        Me.Controls.Add(Me.but_sub6)
        Me.Controls.Add(Me.but_sub7)
        Me.Controls.Add(Me.but_sub8)
        Me.Controls.Add(Me.but_sub9)
        Me.Controls.Add(Me.but_end)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "study_form"
        Me.Text = "Pack of Algorithming"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Colortimer As System.Windows.Forms.Timer
    Friend WithEvents detectimer As System.Windows.Forms.Timer
    Friend WithEvents but_end As System.Windows.Forms.Label
    Friend WithEvents but_sub9 As System.Windows.Forms.Label
    Friend WithEvents but_sub8 As System.Windows.Forms.Label
    Friend WithEvents but_sub7 As System.Windows.Forms.Label
    Friend WithEvents but_sub6 As System.Windows.Forms.Label
    Friend WithEvents but_sub5 As System.Windows.Forms.Label
    Friend WithEvents but_sub4 As System.Windows.Forms.Label
    Friend WithEvents but_sub3 As System.Windows.Forms.Label
    Friend WithEvents but_sub2 As System.Windows.Forms.Label
    Friend WithEvents but_sub1 As System.Windows.Forms.Label
    Friend WithEvents exp As System.Windows.Forms.TextBox
    Friend WithEvents _msg As System.Windows.Forms.Label
    Friend WithEvents _val As System.Windows.Forms.Label
    Friend WithEvents _str As System.Windows.Forms.Label
    Friend WithEvents _abs As System.Windows.Forms.Label
    Friend WithEvents _dim As System.Windows.Forms.Label
    Friend WithEvents _trim As System.Windows.Forms.Label
    Friend WithEvents _inst As System.Windows.Forms.Label
    Friend WithEvents _lca As System.Windows.Forms.Label
    Friend WithEvents _uca As System.Windows.Forms.Label
    Friend WithEvents _len As System.Windows.Forms.Label
    Friend WithEvents _mid As System.Windows.Forms.Label
    Friend WithEvents _do As System.Windows.Forms.Label
    Friend WithEvents _for As System.Windows.Forms.Label
    Friend WithEvents _goto As System.Windows.Forms.Label
    Friend WithEvents _sel As System.Windows.Forms.Label
    Friend WithEvents _if As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _pri As System.Windows.Forms.Label
    Friend WithEvents _mod As System.Windows.Forms.Label
    Friend WithEvents _q1 As System.Windows.Forms.Label
    Friend WithEvents _q2 As System.Windows.Forms.Label
    Friend WithEvents _q3 As System.Windows.Forms.Label
    Friend WithEvents _q4 As System.Windows.Forms.Label
    Friend WithEvents _q5 As System.Windows.Forms.Label
    Friend WithEvents _q6 As System.Windows.Forms.Label
    Friend WithEvents _q7 As System.Windows.Forms.Label
    Friend WithEvents _q8 As System.Windows.Forms.Label
End Class
