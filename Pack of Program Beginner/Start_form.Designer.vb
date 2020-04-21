<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Image = Global.PackofProginner.My.Resources.Resources.st_pro
        Me.Label1.Location = New System.Drawing.Point(30, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 60)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Image = Global.PackofProginner.My.Resources.Resources.st_alg
        Me.Label2.Location = New System.Drawing.Point(30, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 60)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Image = Global.PackofProginner.My.Resources.Resources.st_exit
        Me.Label3.Location = New System.Drawing.Point(30, 500)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(440, 60)
        Me.Label3.TabIndex = 2
        '
        'Start_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PackofProginner.My.Resources.Resources.st_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 600)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pack of Program Beginner"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
