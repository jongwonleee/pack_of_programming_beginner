<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Code_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Code_form))
        Me.back_but = New System.Windows.Forms.PictureBox()
        Me.user_but = New System.Windows.Forms.Label()
        Me.first_but = New System.Windows.Forms.Label()
        Me.Codebox = New System.Windows.Forms.TextBox()
        CType(Me.back_but, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back_but
        '
        Me.back_but.Image = Global.PackofProginner.My.Resources.Resources.backbut
        Me.back_but.Location = New System.Drawing.Point(605, 73)
        Me.back_but.Name = "back_but"
        Me.back_but.Size = New System.Drawing.Size(27, 27)
        Me.back_but.TabIndex = 0
        Me.back_but.TabStop = False
        '
        'user_but
        '
        Me.user_but.BackColor = System.Drawing.SystemColors.GrayText
        Me.user_but.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.user_but.Location = New System.Drawing.Point(2, 73)
        Me.user_but.Name = "user_but"
        Me.user_but.Size = New System.Drawing.Size(297, 27)
        Me.user_but.TabIndex = 3
        Me.user_but.Text = "사용자 생성 코드"
        Me.user_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'first_but
        '
        Me.first_but.BackColor = System.Drawing.SystemColors.Control
        Me.first_but.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.first_but.Location = New System.Drawing.Point(305, 73)
        Me.first_but.Name = "first_but"
        Me.first_but.Size = New System.Drawing.Size(297, 27)
        Me.first_but.TabIndex = 4
        Me.first_but.Text = "초기 설정 코드"
        Me.first_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Codebox
        '
        Me.Codebox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Codebox.Location = New System.Drawing.Point(2, 103)
        Me.Codebox.Multiline = True
        Me.Codebox.Name = "Codebox"
        Me.Codebox.ReadOnly = True
        Me.Codebox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Codebox.Size = New System.Drawing.Size(630, 445)
        Me.Codebox.TabIndex = 5
        Me.Codebox.WordWrap = False
        '
        'Code_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.PackofProginner.My.Resources.Resources.bg_code
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(635, 560)
        Me.Controls.Add(Me.Codebox)
        Me.Controls.Add(Me.first_but)
        Me.Controls.Add(Me.user_but)
        Me.Controls.Add(Me.back_but)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Code_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = """"
        Me.Text = "Pack of Programming"
        CType(Me.back_but, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back_but As System.Windows.Forms.PictureBox
    Friend WithEvents user_but As System.Windows.Forms.Label
    Friend WithEvents first_but As System.Windows.Forms.Label
    Friend WithEvents Codebox As System.Windows.Forms.TextBox
End Class
