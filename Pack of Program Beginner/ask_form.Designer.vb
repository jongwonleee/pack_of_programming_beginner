<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ask_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ask_form))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ok_but = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.Label()
        Me.txt5 = New System.Windows.Forms.Label()
        Me.txt6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exp = New System.Windows.Forms.TextBox()
        Me.pic_inter = New System.Windows.Forms.PictureBox()
        Me.ex1 = New System.Windows.Forms.Label()
        Me.ex2 = New System.Windows.Forms.Label()
        Me.ex3 = New System.Windows.Forms.Label()
        Me.ex4 = New System.Windows.Forms.Label()
        Me.ex5 = New System.Windows.Forms.Label()
        Me.ex6 = New System.Windows.Forms.Label()
        Me.ex_inter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pic_inter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Items.AddRange(New Object() {"훈민정.Net 이란?", "프로그램 주요 기능", "인터페이스", "명령문의 생성 및 수정", "Visual Studio 2005란?", "Visual Studio 2005 설치 방법", "제작자"})
        Me.ListBox1.Location = New System.Drawing.Point(11, 84)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 463)
        Me.ListBox1.TabIndex = 0
        '
        'ok_but
        '
        Me.ok_but.BackColor = System.Drawing.SystemColors.GrayText
        Me.ok_but.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ok_but.Location = New System.Drawing.Point(588, 555)
        Me.ok_but.Name = "ok_but"
        Me.ok_but.Size = New System.Drawing.Size(100, 36)
        Me.ok_but.TabIndex = 1
        Me.ok_but.Text = "확인"
        Me.ok_but.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(0, 580)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(5, 5)
        Me.txt1.TabIndex = 3
        Me.txt1.Text = resources.GetString("txt1.Text")
        Me.txt1.Visible = False
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(0, 580)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(5, 5)
        Me.txt2.TabIndex = 4
        Me.txt2.Text = " - 한글로 쉽게 프로그래밍 가능" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 한글화 된 명령문" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 프로그램을 처음 접하는 사람들을 위한 튜토리얼 학습" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 명령문의 특징과 원문" & _
            " 코드 학습" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 한글로 짠 코드를 영문으로 보면서 학습" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 프로그래밍 중 저장과 불러오기" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 직접 만든 프로그램을 'Visual Ba" & _
            "sic2005'로 변환"
        Me.txt2.Visible = False
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(0, 580)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(5, 5)
        Me.txt3.TabIndex = 5
        Me.txt3.Text = resources.GetString("txt3.Text")
        Me.txt3.Visible = False
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(0, 580)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(5, 5)
        Me.txt4.TabIndex = 6
        Me.txt4.Text = resources.GetString("txt4.Text")
        Me.txt4.Visible = False
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(0, 580)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(5, 5)
        Me.txt5.TabIndex = 7
        Me.txt5.Text = resources.GetString("txt5.Text")
        Me.txt5.Visible = False
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(0, 580)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(5, 5)
        Me.txt6.TabIndex = 8
        Me.txt6.Text = "제작자 : 이종원" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "프로그램에 대한 문의나 질문, 수정은" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jong12em@naver.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "으로 보내주시면 빠르게 수정, 답변 드리겠습" & _
            "니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "감사합니다."
        Me.txt6.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "바로가기"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(458, 571)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(282, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 11)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "이 창을 자동실행하지 않습니다."
        '
        'exp
        '
        Me.exp.BackColor = System.Drawing.Color.White
        Me.exp.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.exp.Location = New System.Drawing.Point(200, 84)
        Me.exp.Multiline = True
        Me.exp.Name = "exp"
        Me.exp.ReadOnly = True
        Me.exp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.exp.Size = New System.Drawing.Size(487, 463)
        Me.exp.TabIndex = 12
        '
        'pic_inter
        '
        Me.pic_inter.Image = Global.PackofProginner.My.Resources.Resources.ex_mf
        Me.pic_inter.Location = New System.Drawing.Point(201, 84)
        Me.pic_inter.Name = "pic_inter"
        Me.pic_inter.Size = New System.Drawing.Size(486, 468)
        Me.pic_inter.TabIndex = 13
        Me.pic_inter.TabStop = False
        Me.pic_inter.Visible = False
        '
        'ex1
        '
        Me.ex1.Location = New System.Drawing.Point(0, 580)
        Me.ex1.Name = "ex1"
        Me.ex1.Size = New System.Drawing.Size(5, 5)
        Me.ex1.TabIndex = 15
        Me.ex1.Text = "만드는 프로그램의 첫 화면을 볼 수 있습니다. 구체적으로 프로그램의 배경화면, 배경색, 프로그램의 크기 등이 표시됩니다. 또 명령어를 만들 시에 " & _
            "좌표를 얻어야 할 때가 있는데 그 때 이 화면을 마우스 클릭해서 좌표를 얻습니다."
        Me.ex1.Visible = False
        '
        'ex2
        '
        Me.ex2.Location = New System.Drawing.Point(0, 580)
        Me.ex2.Name = "ex2"
        Me.ex2.Size = New System.Drawing.Size(5, 5)
        Me.ex2.TabIndex = 16
        Me.ex2.Text = resources.GetString("ex2.Text")
        Me.ex2.Visible = False
        '
        'ex3
        '
        Me.ex3.Location = New System.Drawing.Point(0, 580)
        Me.ex3.Name = "ex3"
        Me.ex3.Size = New System.Drawing.Size(5, 5)
        Me.ex3.TabIndex = 17
        Me.ex3.Text = resources.GetString("ex3.Text")
        Me.ex3.Visible = False
        '
        'ex4
        '
        Me.ex4.Location = New System.Drawing.Point(0, 580)
        Me.ex4.Name = "ex4"
        Me.ex4.Size = New System.Drawing.Size(5, 5)
        Me.ex4.TabIndex = 18
        Me.ex4.Text = resources.GetString("ex4.Text")
        Me.ex4.Visible = False
        '
        'ex5
        '
        Me.ex5.Location = New System.Drawing.Point(0, 580)
        Me.ex5.Name = "ex5"
        Me.ex5.Size = New System.Drawing.Size(5, 5)
        Me.ex5.TabIndex = 19
        Me.ex5.Text = "④에서 눌린 곳에 대해 보여줍니다. ④에서 스크립트를 눌러쓰면 명령문들과 변수의 리스트를 볼 수 있고 물체를 눌렀으면 물체의 리스트를 볼 수 있고" & _
            " 또 소리를 눌렀으면 소리의 리스트를 볼 수 있습니다."
        Me.ex5.Visible = False
        '
        'ex6
        '
        Me.ex6.Location = New System.Drawing.Point(0, 580)
        Me.ex6.Name = "ex6"
        Me.ex6.Size = New System.Drawing.Size(5, 5)
        Me.ex6.TabIndex = 20
        Me.ex6.Text = "만들고 있는 프로그램의 코드를 볼 수 있는 곳입니다. 코드에 명령문을 추가, 삭제, 수정, 삽입 등을 할 수 있게 해줍니다. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "명령문의 생성은 " & _
            "'명령문의 생성 및 수정'을 참고하세요."
        Me.ex6.Visible = False
        '
        'ex_inter
        '
        Me.ex_inter.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ex_inter.Location = New System.Drawing.Point(11, 219)
        Me.ex_inter.Multiline = True
        Me.ex_inter.Name = "ex_inter"
        Me.ex_inter.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.ex_inter.Size = New System.Drawing.Size(183, 328)
        Me.ex_inter.TabIndex = 21
        Me.ex_inter.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(479, 555)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 36)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "튜토리얼"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ask_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PackofProginner.My.Resources.Resources.bg_ask1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(700, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ex_inter)
        Me.Controls.Add(Me.ex6)
        Me.Controls.Add(Me.ex5)
        Me.Controls.Add(Me.ex4)
        Me.Controls.Add(Me.ex3)
        Me.Controls.Add(Me.ex2)
        Me.Controls.Add(Me.ex1)
        Me.Controls.Add(Me.pic_inter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.ok_but)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.exp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ask_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pack of Programming"
        CType(Me.pic_inter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ok_but As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.Label
    Friend WithEvents txt4 As System.Windows.Forms.Label
    Friend WithEvents txt5 As System.Windows.Forms.Label
    Friend WithEvents txt6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents exp As System.Windows.Forms.TextBox
    Friend WithEvents pic_inter As System.Windows.Forms.PictureBox
    Friend WithEvents ex1 As System.Windows.Forms.Label
    Friend WithEvents ex2 As System.Windows.Forms.Label
    Friend WithEvents ex3 As System.Windows.Forms.Label
    Friend WithEvents ex4 As System.Windows.Forms.Label
    Friend WithEvents ex5 As System.Windows.Forms.Label
    Friend WithEvents ex6 As System.Windows.Forms.Label
    Friend WithEvents ex_inter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
