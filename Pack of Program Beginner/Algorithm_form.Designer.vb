<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Algorithm_form
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
        Me.codetxt = New System.Windows.Forms.TextBox()
        Me.butC = New System.Windows.Forms.Label()
        Me.butVB = New System.Windows.Forms.Label()
        Me.butJS = New System.Windows.Forms.Label()
        Me.colortimer = New System.Windows.Forms.Timer(Me.components)
        Me.but_com = New System.Windows.Forms.Label()
        Me.but_exe = New System.Windows.Forms.Label()
        Me.but_end = New System.Windows.Forms.Label()
        Me.but_load = New System.Windows.Forms.Label()
        Me.but_save = New System.Windows.Forms.Label()
        Me.openfile = New System.Windows.Forms.OpenFileDialog()
        Me.savefile = New System.Windows.Forms.SaveFileDialog()
        Me.but_src = New System.Windows.Forms.Label()
        Me.Saveexe = New System.Windows.Forms.SaveFileDialog()
        Me.but_stu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'codetxt
        '
        Me.codetxt.Location = New System.Drawing.Point(1, 72)
        Me.codetxt.Multiline = True
        Me.codetxt.Name = "codetxt"
        Me.codetxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.codetxt.Size = New System.Drawing.Size(554, 593)
        Me.codetxt.TabIndex = 0
        '
        'butC
        '
        Me.butC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.butC.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.butC.Location = New System.Drawing.Point(558, 73)
        Me.butC.Name = "butC"
        Me.butC.Size = New System.Drawing.Size(130, 40)
        Me.butC.TabIndex = 1
        Me.butC.Text = "C Sharp"
        Me.butC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'butVB
        '
        Me.butVB.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.butVB.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.butVB.Location = New System.Drawing.Point(558, 116)
        Me.butVB.Name = "butVB"
        Me.butVB.Size = New System.Drawing.Size(130, 40)
        Me.butVB.TabIndex = 2
        Me.butVB.Text = "Visual Basic"
        Me.butVB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'butJS
        '
        Me.butJS.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.butJS.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.butJS.Location = New System.Drawing.Point(558, 159)
        Me.butJS.Name = "butJS"
        Me.butJS.Size = New System.Drawing.Size(130, 40)
        Me.butJS.TabIndex = 3
        Me.butJS.Text = "Java Script"
        Me.butJS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'colortimer
        '
        Me.colortimer.Interval = 1
        '
        'but_com
        '
        Me.but_com.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.but_com.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_com.Location = New System.Drawing.Point(558, 537)
        Me.but_com.Name = "but_com"
        Me.but_com.Size = New System.Drawing.Size(130, 40)
        Me.but_com.TabIndex = 4
        Me.but_com.Text = "실행"
        Me.but_com.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_exe
        '
        Me.but_exe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.but_exe.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_exe.Location = New System.Drawing.Point(558, 580)
        Me.but_exe.Name = "but_exe"
        Me.but_exe.Size = New System.Drawing.Size(130, 40)
        Me.but_exe.TabIndex = 5
        Me.but_exe.Text = "EXE 변환"
        Me.but_exe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_end
        '
        Me.but_end.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.but_end.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_end.Location = New System.Drawing.Point(558, 623)
        Me.but_end.Name = "but_end"
        Me.but_end.Size = New System.Drawing.Size(130, 40)
        Me.but_end.TabIndex = 6
        Me.but_end.Text = "종료"
        Me.but_end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_load
        '
        Me.but_load.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.but_load.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_load.Location = New System.Drawing.Point(558, 494)
        Me.but_load.Name = "but_load"
        Me.but_load.Size = New System.Drawing.Size(130, 40)
        Me.but_load.TabIndex = 8
        Me.but_load.Text = "불러오기"
        Me.but_load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_save
        '
        Me.but_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but_save.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_save.Location = New System.Drawing.Point(558, 451)
        Me.but_save.Name = "but_save"
        Me.but_save.Size = New System.Drawing.Size(130, 40)
        Me.but_save.TabIndex = 7
        Me.but_save.Text = "저장"
        Me.but_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openfile
        '
        Me.openfile.Filter = "PAlgorithming 저장 파일(*. valg)|*.valg"
        '
        'savefile
        '
        Me.savefile.Filter = "PAlgorithming 저장 파일(*. valg)|*.valg"
        '
        'but_src
        '
        Me.but_src.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.but_src.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_src.Location = New System.Drawing.Point(558, 365)
        Me.but_src.Name = "but_src"
        Me.but_src.Size = New System.Drawing.Size(130, 40)
        Me.but_src.TabIndex = 9
        Me.but_src.Text = "소스보기"
        Me.but_src.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Saveexe
        '
        Me.Saveexe.Filter = "응용 프로그램(*.exe)|*.exe"
        '
        'but_stu
        '
        Me.but_stu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but_stu.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_stu.Location = New System.Drawing.Point(558, 408)
        Me.but_stu.Name = "but_stu"
        Me.but_stu.Size = New System.Drawing.Size(130, 40)
        Me.but_stu.TabIndex = 10
        Me.but_stu.Text = "기본학습"
        Me.but_stu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Algorithm_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.PackofProginner.My.Resources.Resources.bg_al
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(692, 666)
        Me.Controls.Add(Me.but_stu)
        Me.Controls.Add(Me.but_src)
        Me.Controls.Add(Me.but_load)
        Me.Controls.Add(Me.but_save)
        Me.Controls.Add(Me.but_end)
        Me.Controls.Add(Me.but_exe)
        Me.Controls.Add(Me.but_com)
        Me.Controls.Add(Me.butJS)
        Me.Controls.Add(Me.butVB)
        Me.Controls.Add(Me.butC)
        Me.Controls.Add(Me.codetxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Algorithm_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pack of Algorithming"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents codetxt As System.Windows.Forms.TextBox
    Friend WithEvents butC As System.Windows.Forms.Label
    Friend WithEvents butVB As System.Windows.Forms.Label
    Friend WithEvents butJS As System.Windows.Forms.Label
    Friend WithEvents colortimer As System.Windows.Forms.Timer
    Friend WithEvents but_com As System.Windows.Forms.Label
    Friend WithEvents but_exe As System.Windows.Forms.Label
    Friend WithEvents but_end As System.Windows.Forms.Label
    Friend WithEvents but_load As System.Windows.Forms.Label
    Friend WithEvents but_save As System.Windows.Forms.Label
    Friend WithEvents openfile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents savefile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents but_src As System.Windows.Forms.Label
    Friend WithEvents Saveexe As System.Windows.Forms.SaveFileDialog
    Friend WithEvents but_stu As System.Windows.Forms.Label
End Class
