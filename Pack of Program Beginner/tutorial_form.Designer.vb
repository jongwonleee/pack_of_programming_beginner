<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutorial_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tutorial_form))
        Me.but_exit = New System.Windows.Forms.Label()
        Me.display = New System.Windows.Forms.PictureBox()
        Me.but_geth = New System.Windows.Forms.Label()
        Me.but_objsnd = New System.Windows.Forms.Label()
        Me.but_cal = New System.Windows.Forms.Label()
        Me.but_front = New System.Windows.Forms.Label()
        Me.colortimer = New System.Windows.Forms.Timer(Me.components)
        Me.but_next = New System.Windows.Forms.PictureBox()
        Me.but_prev = New System.Windows.Forms.PictureBox()
        CType(Me.display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_prev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'but_exit
        '
        Me.but_exit.BackColor = System.Drawing.SystemColors.GrayText
        Me.but_exit.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_exit.Location = New System.Drawing.Point(318, 460)
        Me.but_exit.Name = "but_exit"
        Me.but_exit.Size = New System.Drawing.Size(76, 36)
        Me.but_exit.TabIndex = 23
        Me.but_exit.Text = "종료"
        Me.but_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'display
        '
        Me.display.BackColor = System.Drawing.Color.Transparent
        Me.display.Location = New System.Drawing.Point(5, 75)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(390, 380)
        Me.display.TabIndex = 26
        Me.display.TabStop = False
        Me.display.Visible = False
        '
        'but_geth
        '
        Me.but_geth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.but_geth.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_geth.Location = New System.Drawing.Point(12, 162)
        Me.but_geth.Name = "but_geth"
        Me.but_geth.Size = New System.Drawing.Size(376, 47)
        Me.but_geth.TabIndex = 27
        Me.but_geth.Text = "최댓값 구하기"
        Me.but_geth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'but_objsnd
        '
        Me.but_objsnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.but_objsnd.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_objsnd.Location = New System.Drawing.Point(12, 245)
        Me.but_objsnd.Name = "but_objsnd"
        Me.but_objsnd.Size = New System.Drawing.Size(376, 47)
        Me.but_objsnd.TabIndex = 28
        Me.but_objsnd.Text = "물체와 소리의 이용"
        Me.but_objsnd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'but_cal
        '
        Me.but_cal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but_cal.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_cal.Location = New System.Drawing.Point(12, 326)
        Me.but_cal.Name = "but_cal"
        Me.but_cal.Size = New System.Drawing.Size(376, 47)
        Me.but_cal.TabIndex = 29
        Me.but_cal.Text = "더하기 계산기"
        Me.but_cal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'but_front
        '
        Me.but_front.BackColor = System.Drawing.Color.White
        Me.but_front.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.but_front.Location = New System.Drawing.Point(236, 460)
        Me.but_front.Name = "but_front"
        Me.but_front.Size = New System.Drawing.Size(76, 36)
        Me.but_front.TabIndex = 30
        Me.but_front.Text = "처음"
        Me.but_front.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'colortimer
        '
        Me.colortimer.Interval = 1
        '
        'but_next
        '
        Me.but_next.BackColor = System.Drawing.Color.Transparent
        Me.but_next.Image = Global.PackofProginner.My.Resources.Resources.next100
        Me.but_next.Location = New System.Drawing.Point(357, 343)
        Me.but_next.Name = "but_next"
        Me.but_next.Size = New System.Drawing.Size(22, 30)
        Me.but_next.TabIndex = 32
        Me.but_next.TabStop = False
        Me.but_next.Visible = False
        '
        'but_prev
        '
        Me.but_prev.Image = Global.PackofProginner.My.Resources.Resources.prev100
        Me.but_prev.Location = New System.Drawing.Point(326, 343)
        Me.but_prev.Name = "but_prev"
        Me.but_prev.Size = New System.Drawing.Size(22, 30)
        Me.but_prev.TabIndex = 33
        Me.but_prev.TabStop = False
        Me.but_prev.Visible = False
        '
        'tutorial_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.PackofProginner.My.Resources.Resources.bg_tut
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.but_prev)
        Me.Controls.Add(Me.but_next)
        Me.Controls.Add(Me.but_front)
        Me.Controls.Add(Me.but_cal)
        Me.Controls.Add(Me.but_objsnd)
        Me.Controls.Add(Me.but_geth)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.but_exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tutorial_form"
        Me.Text = "Pack of Programming"
        CType(Me.display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_prev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents but_exit As System.Windows.Forms.Label
    Friend WithEvents display As System.Windows.Forms.PictureBox
    Friend WithEvents but_geth As System.Windows.Forms.Label
    Friend WithEvents but_objsnd As System.Windows.Forms.Label
    Friend WithEvents but_cal As System.Windows.Forms.Label
    Friend WithEvents but_front As System.Windows.Forms.Label
    Friend WithEvents colortimer As System.Windows.Forms.Timer
    Friend WithEvents but_next As System.Windows.Forms.PictureBox
    Friend WithEvents but_prev As System.Windows.Forms.PictureBox
End Class
