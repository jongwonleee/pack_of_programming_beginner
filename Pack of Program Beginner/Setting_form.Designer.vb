<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting_form))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.xnum = New System.Windows.Forms.TextBox()
        Me.ynum = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.but_bgimg = New System.Windows.Forms.Button()
        Me.but_bgcolor = New System.Windows.Forms.Button()
        Me.cancel_but = New System.Windows.Forms.Button()
        Me.ok_but = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.piccom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(45, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 11)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(너비값 500 ~ 1024,길이값 150 ~ 720을 벗어날 수 없습니다)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "화면 크기"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "배경 색"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "배경 그림"
        '
        'xnum
        '
        Me.xnum.Location = New System.Drawing.Point(116, 79)
        Me.xnum.Name = "xnum"
        Me.xnum.Size = New System.Drawing.Size(50, 21)
        Me.xnum.TabIndex = 5
        '
        'ynum
        '
        Me.ynum.Location = New System.Drawing.Point(211, 79)
        Me.ynum.Name = "ynum"
        Me.ynum.Size = New System.Drawing.Size(50, 21)
        Me.ynum.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(96, 168)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(163, 21)
        Me.TextBox4.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "길이"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "너비"
        '
        'but_bgimg
        '
        Me.but_bgimg.Location = New System.Drawing.Point(261, 167)
        Me.but_bgimg.Name = "but_bgimg"
        Me.but_bgimg.Size = New System.Drawing.Size(62, 23)
        Me.but_bgimg.TabIndex = 11
        Me.but_bgimg.Text = "불러오기"
        Me.but_bgimg.UseVisualStyleBackColor = True
        '
        'but_bgcolor
        '
        Me.but_bgcolor.Location = New System.Drawing.Point(123, 131)
        Me.but_bgcolor.Name = "but_bgcolor"
        Me.but_bgcolor.Size = New System.Drawing.Size(43, 23)
        Me.but_bgcolor.TabIndex = 12
        Me.but_bgcolor.Text = "설정"
        Me.but_bgcolor.UseVisualStyleBackColor = True
        '
        'cancel_but
        '
        Me.cancel_but.Location = New System.Drawing.Point(279, 246)
        Me.cancel_but.Name = "cancel_but"
        Me.cancel_but.Size = New System.Drawing.Size(75, 23)
        Me.cancel_but.TabIndex = 13
        Me.cancel_but.Text = "취소"
        Me.cancel_but.UseVisualStyleBackColor = True
        '
        'ok_but
        '
        Me.ok_but.Location = New System.Drawing.Point(184, 246)
        Me.ok_but.Name = "ok_but"
        Me.ok_but.Size = New System.Drawing.Size(75, 23)
        Me.ok_but.TabIndex = 14
        Me.ok_but.Text = "확인"
        Me.ok_but.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPEG 이미지(*.jpg)|*.jpg|PNG 이미지(*.png)|*.png|BMP 이미지(*.bmp)|*.bmp"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(97, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'piccom
        '
        Me.piccom.FormattingEnabled = True
        Me.piccom.Items.AddRange(New Object() {"기본", "타일", "중앙", "늘리기", "확대"})
        Me.piccom.Location = New System.Drawing.Point(211, 195)
        Me.piccom.Name = "piccom"
        Me.piccom.Size = New System.Drawing.Size(116, 20)
        Me.piccom.TabIndex = 16
        Me.piccom.Text = "(선택)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("굴림", 8.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(130, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 11)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "그림 배열 방식"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "삭제"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Setting_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(366, 281)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.piccom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ok_but)
        Me.Controls.Add(Me.cancel_but)
        Me.Controls.Add(Me.but_bgcolor)
        Me.Controls.Add(Me.but_bgimg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ynum)
        Me.Controls.Add(Me.xnum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setting_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pack of Programming"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents xnum As System.Windows.Forms.TextBox
    Friend WithEvents ynum As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents but_bgimg As System.Windows.Forms.Button
    Friend WithEvents but_bgcolor As System.Windows.Forms.Button
    Friend WithEvents cancel_but As System.Windows.Forms.Button
    Friend WithEvents ok_but As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents piccom As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
