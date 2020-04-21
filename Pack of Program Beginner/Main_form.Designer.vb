<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_form
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("선택")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("프로그램이 실행됬을 때", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("선택")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_form))
        Me.script = New System.Windows.Forms.TreeView()
        Me.but_object = New System.Windows.Forms.Label()
        Me.but_sound = New System.Windows.Forms.Label()
        Me.colortimer = New System.Windows.Forms.Timer(Me.components)
        Me.slist = New System.Windows.Forms.ListBox()
        Me.nobox = New System.Windows.Forms.Label()
        Me.setbox = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.setex1 = New System.Windows.Forms.Label()
        Me.setok = New System.Windows.Forms.Button()
        Me.setlab1 = New System.Windows.Forms.Label()
        Me.settxt2 = New System.Windows.Forms.TextBox()
        Me.settxt1 = New System.Windows.Forms.TextBox()
        Me.setcom = New System.Windows.Forms.ComboBox()
        Me.setlab2 = New System.Windows.Forms.Label()
        Me.setlab3 = New System.Windows.Forms.Label()
        Me.but_script = New System.Windows.Forms.Label()
        Me.openobj = New System.Windows.Forms.OpenFileDialog()
        Me.obbox = New System.Windows.Forms.Panel()
        Me.obread = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.obtxt3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.obtxt4 = New System.Windows.Forms.TextBox()
        Me.obpic1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.obok = New System.Windows.Forms.Button()
        Me.oblab1 = New System.Windows.Forms.Label()
        Me.obtxt2 = New System.Windows.Forms.TextBox()
        Me.obtxt1 = New System.Windows.Forms.TextBox()
        Me.oblab2 = New System.Windows.Forms.Label()
        Me.oblab3 = New System.Windows.Forms.Label()
        Me.sndbox = New System.Windows.Forms.Panel()
        Me.sndlab5 = New System.Windows.Forms.Label()
        Me.sndlab4 = New System.Windows.Forms.Label()
        Me.sndpic1 = New System.Windows.Forms.PictureBox()
        Me.sndpic2 = New System.Windows.Forms.PictureBox()
        Me.sndtxt3 = New System.Windows.Forms.TextBox()
        Me.sndbar = New System.Windows.Forms.TrackBar()
        Me.sndplay = New AxMediaPlayer.AxMediaPlayer()
        Me.sndread = New System.Windows.Forms.Button()
        Me.sndtxt2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sndok = New System.Windows.Forms.Button()
        Me.sndlab1 = New System.Windows.Forms.Label()
        Me.sndtxt1 = New System.Windows.Forms.TextBox()
        Me.sndlab2 = New System.Windows.Forms.Label()
        Me.sndlab3 = New System.Windows.Forms.Label()
        Me.actbox = New System.Windows.Forms.Panel()
        Me.actbut = New System.Windows.Forms.Button()
        Me.actex4 = New System.Windows.Forms.Label()
        Me.acthow = New System.Windows.Forms.Label()
        Me.actex3 = New System.Windows.Forms.Label()
        Me.actuse = New System.Windows.Forms.Label()
        Me.actex2 = New System.Windows.Forms.Label()
        Me.actex1 = New System.Windows.Forms.Label()
        Me.actok = New System.Windows.Forms.Button()
        Me.actcom2 = New System.Windows.Forms.ComboBox()
        Me.actcom1 = New System.Windows.Forms.ComboBox()
        Me.acttxt2 = New System.Windows.Forms.TextBox()
        Me.acttxt1 = New System.Windows.Forms.TextBox()
        Me.actlab2 = New System.Windows.Forms.Label()
        Me.actlab1 = New System.Windows.Forms.Label()
        Me.actkor = New System.Windows.Forms.Label()
        Me.opensnd = New System.Windows.Forms.OpenFileDialog()
        Me.colorcng = New System.Windows.Forms.ColorDialog()
        Me.nodadd = New System.Windows.Forms.Label()
        Me.noddel = New System.Windows.Forms.Label()
        Me.savefile = New System.Windows.Forms.SaveFileDialog()
        Me.openfile = New System.Windows.Forms.OpenFileDialog()
        Me.transfile = New System.Windows.Forms.FolderBrowserDialog()
        Me.destext = New System.Windows.Forms.Label()
        Me.but_com = New System.Windows.Forms.PictureBox()
        Me.picblack = New System.Windows.Forms.PictureBox()
        Me.listbar = New System.Windows.Forms.PictureBox()
        Me.but_set = New System.Windows.Forms.PictureBox()
        Me.but_load = New System.Windows.Forms.PictureBox()
        Me.but_save = New System.Windows.Forms.PictureBox()
        Me.but_code = New System.Windows.Forms.PictureBox()
        Me.but_ask = New System.Windows.Forms.PictureBox()
        Me.hruler = New System.Windows.Forms.PictureBox()
        Me.vruler = New System.Windows.Forms.PictureBox()
        Me.display = New System.Windows.Forms.PictureBox()
        Me.setbox.SuspendLayout()
        Me.obbox.SuspendLayout()
        CType(Me.obpic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sndbox.SuspendLayout()
        CType(Me.sndpic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sndpic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sndbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sndplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.actbox.SuspendLayout()
        CType(Me.but_com, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picblack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_set, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_load, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_ask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hruler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vruler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'script
        '
        Me.script.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.script.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.script.CausesValidation = False
        Me.script.HideSelection = False
        Me.script.HotTracking = True
        Me.script.ItemHeight = 15
        Me.script.LabelEdit = True
        Me.script.Location = New System.Drawing.Point(851, 503)
        Me.script.Name = "script"
        TreeNode1.Name = "노드1"
        TreeNode1.Text = "선택"
        TreeNode2.Name = "00"
        TreeNode2.Tag = "0"
        TreeNode2.Text = "프로그램이 실행됬을 때"
        TreeNode3.Name = ""
        TreeNode3.Text = "선택"
        Me.script.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Me.script.ShowNodeToolTips = True
        Me.script.Size = New System.Drawing.Size(282, 219)
        Me.script.TabIndex = 5
        '
        'but_object
        '
        Me.but_object.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.but_object.Font = New System.Drawing.Font("맑은 고딕", 14.75!, System.Drawing.FontStyle.Bold)
        Me.but_object.Location = New System.Drawing.Point(945, 45)
        Me.but_object.Name = "but_object"
        Me.but_object.Size = New System.Drawing.Size(90, 40)
        Me.but_object.TabIndex = 16
        Me.but_object.Text = "물체"
        Me.but_object.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'but_sound
        '
        Me.but_sound.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.but_sound.Font = New System.Drawing.Font("맑은 고딕", 14.75!, System.Drawing.FontStyle.Bold)
        Me.but_sound.Location = New System.Drawing.Point(1043, 45)
        Me.but_sound.Name = "but_sound"
        Me.but_sound.Size = New System.Drawing.Size(90, 40)
        Me.but_sound.TabIndex = 17
        Me.but_sound.Text = "소리"
        Me.but_sound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'colortimer
        '
        Me.colortimer.Interval = 1
        '
        'slist
        '
        Me.slist.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.slist.FormattingEnabled = True
        Me.slist.ItemHeight = 17
        Me.slist.Items.AddRange(New Object() {"만약 ＿＿가 ＿＿라면", "만약 ＿＿가 ＿＿이상이라면", "만약 ＿＿가 ＿＿이하라면", "만약 ＿＿가 ＿＿초과라면", "만약 ＿＿가 ＿＿미만이라면", "만약 (마우스)＿＿가 클릭되었을 때", "만약 (마우스)＿＿가 더블클릭되었을 때", "(키보드)＿＿가 눌렸을 때", "＿＿초 후에"})
        Me.slist.Location = New System.Drawing.Point(851, 114)
        Me.slist.Name = "slist"
        Me.slist.Size = New System.Drawing.Size(282, 378)
        Me.slist.TabIndex = 6
        '
        'nobox
        '
        Me.nobox.BackColor = System.Drawing.Color.White
        Me.nobox.Font = New System.Drawing.Font("맑은 고딕", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.nobox.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.nobox.Location = New System.Drawing.Point(2, 536)
        Me.nobox.Name = "nobox"
        Me.nobox.Size = New System.Drawing.Size(843, 186)
        Me.nobox.TabIndex = 35
        Me.nobox.Text = "(활동을 설정해 주세요)"
        Me.nobox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'setbox
        '
        Me.setbox.BackColor = System.Drawing.Color.White
        Me.setbox.Controls.Add(Me.Label1)
        Me.setbox.Controls.Add(Me.setex1)
        Me.setbox.Controls.Add(Me.setok)
        Me.setbox.Controls.Add(Me.setlab1)
        Me.setbox.Controls.Add(Me.settxt2)
        Me.setbox.Controls.Add(Me.settxt1)
        Me.setbox.Controls.Add(Me.setcom)
        Me.setbox.Controls.Add(Me.setlab2)
        Me.setbox.Controls.Add(Me.setlab3)
        Me.setbox.Location = New System.Drawing.Point(2, 536)
        Me.setbox.Name = "setbox"
        Me.setbox.Size = New System.Drawing.Size(843, 186)
        Me.setbox.TabIndex = 36
        Me.setbox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(242, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 11)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "변수명은 문자로 이루어져야 합니다"
        '
        'setex1
        '
        Me.setex1.AutoSize = True
        Me.setex1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.setex1.ForeColor = System.Drawing.Color.Gray
        Me.setex1.Location = New System.Drawing.Point(242, 73)
        Me.setex1.Name = "setex1"
        Me.setex1.Size = New System.Drawing.Size(270, 11)
        Me.setex1.TabIndex = 33
        Me.setex1.Text = "작은 정수는 -32768에서 32767 사이에 있어야 합니다"
        '
        'setok
        '
        Me.setok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.setok.BackColor = System.Drawing.Color.White
        Me.setok.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.setok.Location = New System.Drawing.Point(721, 148)
        Me.setok.Name = "setok"
        Me.setok.Size = New System.Drawing.Size(97, 30)
        Me.setok.TabIndex = 32
        Me.setok.Text = "확인"
        Me.setok.UseVisualStyleBackColor = False
        '
        'setlab1
        '
        Me.setlab1.BackColor = System.Drawing.Color.White
        Me.setlab1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.setlab1.Location = New System.Drawing.Point(3, 20)
        Me.setlab1.Name = "setlab1"
        Me.setlab1.Size = New System.Drawing.Size(127, 23)
        Me.setlab1.TabIndex = 26
        Me.setlab1.Text = "변수명"
        Me.setlab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'settxt2
        '
        Me.settxt2.Enabled = False
        Me.settxt2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.settxt2.Location = New System.Drawing.Point(136, 108)
        Me.settxt2.Name = "settxt2"
        Me.settxt2.Size = New System.Drawing.Size(218, 27)
        Me.settxt2.TabIndex = 31
        '
        'settxt1
        '
        Me.settxt1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.settxt1.Location = New System.Drawing.Point(136, 19)
        Me.settxt1.Name = "settxt1"
        Me.settxt1.Size = New System.Drawing.Size(100, 27)
        Me.settxt1.TabIndex = 27
        '
        'setcom
        '
        Me.setcom.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.setcom.FormattingEnabled = True
        Me.setcom.Items.AddRange(New Object() {"작은 수", "큰 수", "실수", "문자열"})
        Me.setcom.Location = New System.Drawing.Point(136, 62)
        Me.setcom.Name = "setcom"
        Me.setcom.Size = New System.Drawing.Size(100, 28)
        Me.setcom.TabIndex = 30
        Me.setcom.Text = "(선택)"
        '
        'setlab2
        '
        Me.setlab2.BackColor = System.Drawing.Color.White
        Me.setlab2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.setlab2.Location = New System.Drawing.Point(3, 64)
        Me.setlab2.Name = "setlab2"
        Me.setlab2.Size = New System.Drawing.Size(127, 25)
        Me.setlab2.TabIndex = 28
        Me.setlab2.Text = "변수 종류"
        Me.setlab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'setlab3
        '
        Me.setlab3.BackColor = System.Drawing.Color.White
        Me.setlab3.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.setlab3.Location = New System.Drawing.Point(3, 110)
        Me.setlab3.Name = "setlab3"
        Me.setlab3.Size = New System.Drawing.Size(127, 23)
        Me.setlab3.TabIndex = 29
        Me.setlab3.Text = "초기 변수값"
        Me.setlab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'but_script
        '
        Me.but_script.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.but_script.Font = New System.Drawing.Font("맑은 고딕", 14.25!, System.Drawing.FontStyle.Bold)
        Me.but_script.Location = New System.Drawing.Point(848, 45)
        Me.but_script.Name = "but_script"
        Me.but_script.Size = New System.Drawing.Size(90, 40)
        Me.but_script.TabIndex = 15
        Me.but_script.Text = "스크립트"
        Me.but_script.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openobj
        '
        Me.openobj.Filter = "BMP 이미지(*.bmp)|*.bmp훈민정Net 전용 물체(*.hobj)|*.hobj|"
        '
        'obbox
        '
        Me.obbox.BackColor = System.Drawing.Color.White
        Me.obbox.Controls.Add(Me.obread)
        Me.obbox.Controls.Add(Me.Label4)
        Me.obbox.Controls.Add(Me.obtxt3)
        Me.obbox.Controls.Add(Me.Label3)
        Me.obbox.Controls.Add(Me.obtxt4)
        Me.obbox.Controls.Add(Me.obpic1)
        Me.obbox.Controls.Add(Me.Label2)
        Me.obbox.Controls.Add(Me.obok)
        Me.obbox.Controls.Add(Me.oblab1)
        Me.obbox.Controls.Add(Me.obtxt2)
        Me.obbox.Controls.Add(Me.obtxt1)
        Me.obbox.Controls.Add(Me.oblab2)
        Me.obbox.Controls.Add(Me.oblab3)
        Me.obbox.Location = New System.Drawing.Point(2, 536)
        Me.obbox.Name = "obbox"
        Me.obbox.Size = New System.Drawing.Size(843, 186)
        Me.obbox.TabIndex = 38
        Me.obbox.Visible = False
        '
        'obread
        '
        Me.obread.Location = New System.Drawing.Point(360, 66)
        Me.obread.Name = "obread"
        Me.obread.Size = New System.Drawing.Size(66, 27)
        Me.obread.TabIndex = 41
        Me.obread.Text = "불러오기"
        Me.obread.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(247, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "높이"
        '
        'obtxt3
        '
        Me.obtxt3.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.obtxt3.Location = New System.Drawing.Point(288, 108)
        Me.obtxt3.Name = "obtxt3"
        Me.obtxt3.Size = New System.Drawing.Size(65, 27)
        Me.obtxt3.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(143, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "폭"
        '
        'obtxt4
        '
        Me.obtxt4.Enabled = False
        Me.obtxt4.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.obtxt4.Location = New System.Drawing.Point(136, 64)
        Me.obtxt4.Name = "obtxt4"
        Me.obtxt4.ReadOnly = True
        Me.obtxt4.Size = New System.Drawing.Size(218, 27)
        Me.obtxt4.TabIndex = 36
        '
        'obpic1
        '
        Me.obpic1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.obpic1.BackColor = System.Drawing.SystemColors.Control
        Me.obpic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.obpic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.obpic1.Location = New System.Drawing.Point(571, 6)
        Me.obpic1.Name = "obpic1"
        Me.obpic1.Size = New System.Drawing.Size(266, 135)
        Me.obpic1.TabIndex = 35
        Me.obpic1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(134, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 11)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "비트맵 이미지 파일만 불러올 수 있습니다."
        '
        'obok
        '
        Me.obok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.obok.BackColor = System.Drawing.Color.White
        Me.obok.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.obok.Location = New System.Drawing.Point(721, 148)
        Me.obok.Name = "obok"
        Me.obok.Size = New System.Drawing.Size(97, 30)
        Me.obok.TabIndex = 32
        Me.obok.Text = "확인"
        Me.obok.UseVisualStyleBackColor = False
        '
        'oblab1
        '
        Me.oblab1.BackColor = System.Drawing.Color.White
        Me.oblab1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.oblab1.Location = New System.Drawing.Point(3, 20)
        Me.oblab1.Name = "oblab1"
        Me.oblab1.Size = New System.Drawing.Size(127, 23)
        Me.oblab1.TabIndex = 26
        Me.oblab1.Text = "물체명"
        Me.oblab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'obtxt2
        '
        Me.obtxt2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.obtxt2.Location = New System.Drawing.Point(169, 108)
        Me.obtxt2.Name = "obtxt2"
        Me.obtxt2.Size = New System.Drawing.Size(65, 27)
        Me.obtxt2.TabIndex = 31
        '
        'obtxt1
        '
        Me.obtxt1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.obtxt1.Location = New System.Drawing.Point(136, 19)
        Me.obtxt1.Name = "obtxt1"
        Me.obtxt1.Size = New System.Drawing.Size(100, 27)
        Me.obtxt1.TabIndex = 27
        '
        'oblab2
        '
        Me.oblab2.BackColor = System.Drawing.Color.White
        Me.oblab2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.oblab2.Location = New System.Drawing.Point(3, 64)
        Me.oblab2.Name = "oblab2"
        Me.oblab2.Size = New System.Drawing.Size(127, 25)
        Me.oblab2.TabIndex = 28
        Me.oblab2.Text = "물체 불러오기"
        Me.oblab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'oblab3
        '
        Me.oblab3.BackColor = System.Drawing.Color.White
        Me.oblab3.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.oblab3.Location = New System.Drawing.Point(3, 110)
        Me.oblab3.Name = "oblab3"
        Me.oblab3.Size = New System.Drawing.Size(127, 23)
        Me.oblab3.TabIndex = 29
        Me.oblab3.Text = "물체 크기"
        Me.oblab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sndbox
        '
        Me.sndbox.BackColor = System.Drawing.Color.White
        Me.sndbox.Controls.Add(Me.sndlab5)
        Me.sndbox.Controls.Add(Me.sndlab4)
        Me.sndbox.Controls.Add(Me.sndpic1)
        Me.sndbox.Controls.Add(Me.sndpic2)
        Me.sndbox.Controls.Add(Me.sndtxt3)
        Me.sndbox.Controls.Add(Me.sndbar)
        Me.sndbox.Controls.Add(Me.sndplay)
        Me.sndbox.Controls.Add(Me.sndread)
        Me.sndbox.Controls.Add(Me.sndtxt2)
        Me.sndbox.Controls.Add(Me.Label6)
        Me.sndbox.Controls.Add(Me.sndok)
        Me.sndbox.Controls.Add(Me.sndlab1)
        Me.sndbox.Controls.Add(Me.sndtxt1)
        Me.sndbox.Controls.Add(Me.sndlab2)
        Me.sndbox.Controls.Add(Me.sndlab3)
        Me.sndbox.Location = New System.Drawing.Point(2, 536)
        Me.sndbox.Name = "sndbox"
        Me.sndbox.Size = New System.Drawing.Size(843, 186)
        Me.sndbox.TabIndex = 40
        Me.sndbox.Visible = False
        '
        'sndlab5
        '
        Me.sndlab5.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndlab5.Location = New System.Drawing.Point(135, 114)
        Me.sndlab5.Name = "sndlab5"
        Me.sndlab5.Size = New System.Drawing.Size(220, 23)
        Me.sndlab5.TabIndex = 61
        Me.sndlab5.Text = "눈의 꽃(15:13)"
        Me.sndlab5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sndlab4
        '
        Me.sndlab4.BackColor = System.Drawing.Color.White
        Me.sndlab4.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndlab4.Location = New System.Drawing.Point(3, 154)
        Me.sndlab4.Name = "sndlab4"
        Me.sndlab4.Size = New System.Drawing.Size(127, 23)
        Me.sndlab4.TabIndex = 60
        Me.sndlab4.Text = "소리 볼륨"
        Me.sndlab4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sndpic1
        '
        Me.sndpic1.Image = Global.PackofProginner.My.Resources.Resources.sndplay
        Me.sndpic1.Location = New System.Drawing.Point(360, 114)
        Me.sndpic1.Name = "sndpic1"
        Me.sndpic1.Size = New System.Drawing.Size(45, 30)
        Me.sndpic1.TabIndex = 59
        Me.sndpic1.TabStop = False
        '
        'sndpic2
        '
        Me.sndpic2.Image = Global.PackofProginner.My.Resources.Resources.sndstop
        Me.sndpic2.Location = New System.Drawing.Point(411, 114)
        Me.sndpic2.Name = "sndpic2"
        Me.sndpic2.Size = New System.Drawing.Size(45, 30)
        Me.sndpic2.TabIndex = 58
        Me.sndpic2.TabStop = False
        '
        'sndtxt3
        '
        Me.sndtxt3.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.sndtxt3.Location = New System.Drawing.Point(136, 152)
        Me.sndtxt3.Name = "sndtxt3"
        Me.sndtxt3.Size = New System.Drawing.Size(34, 27)
        Me.sndtxt3.TabIndex = 57
        '
        'sndbar
        '
        Me.sndbar.AutoSize = False
        Me.sndbar.Location = New System.Drawing.Point(169, 154)
        Me.sndbar.Maximum = 0
        Me.sndbar.Minimum = -10000
        Me.sndbar.Name = "sndbar"
        Me.sndbar.Size = New System.Drawing.Size(193, 23)
        Me.sndbar.TabIndex = 56
        Me.sndbar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'sndplay
        '
        Me.sndplay.Location = New System.Drawing.Point(501, 59)
        Me.sndplay.Name = "sndplay"
        Me.sndplay.OcxState = CType(resources.GetObject("sndplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sndplay.Size = New System.Drawing.Size(286, 225)
        Me.sndplay.TabIndex = 55
        Me.sndplay.Visible = False
        '
        'sndread
        '
        Me.sndread.Location = New System.Drawing.Point(361, 67)
        Me.sndread.Name = "sndread"
        Me.sndread.Size = New System.Drawing.Size(66, 27)
        Me.sndread.TabIndex = 54
        Me.sndread.Text = "불러오기"
        Me.sndread.UseVisualStyleBackColor = True
        '
        'sndtxt2
        '
        Me.sndtxt2.Enabled = False
        Me.sndtxt2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndtxt2.Location = New System.Drawing.Point(137, 65)
        Me.sndtxt2.Name = "sndtxt2"
        Me.sndtxt2.ReadOnly = True
        Me.sndtxt2.Size = New System.Drawing.Size(218, 27)
        Me.sndtxt2.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(135, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 11)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "사운드 파일만 불러올 수 있습니다."
        '
        'sndok
        '
        Me.sndok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sndok.BackColor = System.Drawing.Color.White
        Me.sndok.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndok.Location = New System.Drawing.Point(722, 149)
        Me.sndok.Name = "sndok"
        Me.sndok.Size = New System.Drawing.Size(97, 30)
        Me.sndok.TabIndex = 47
        Me.sndok.Text = "확인"
        Me.sndok.UseVisualStyleBackColor = False
        '
        'sndlab1
        '
        Me.sndlab1.BackColor = System.Drawing.Color.White
        Me.sndlab1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndlab1.Location = New System.Drawing.Point(4, 21)
        Me.sndlab1.Name = "sndlab1"
        Me.sndlab1.Size = New System.Drawing.Size(127, 23)
        Me.sndlab1.TabIndex = 42
        Me.sndlab1.Text = "소리명"
        Me.sndlab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sndtxt1
        '
        Me.sndtxt1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndtxt1.Location = New System.Drawing.Point(137, 20)
        Me.sndtxt1.Name = "sndtxt1"
        Me.sndtxt1.Size = New System.Drawing.Size(100, 27)
        Me.sndtxt1.TabIndex = 43
        '
        'sndlab2
        '
        Me.sndlab2.BackColor = System.Drawing.Color.White
        Me.sndlab2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndlab2.Location = New System.Drawing.Point(4, 65)
        Me.sndlab2.Name = "sndlab2"
        Me.sndlab2.Size = New System.Drawing.Size(127, 25)
        Me.sndlab2.TabIndex = 44
        Me.sndlab2.Text = "소리 불러오기"
        Me.sndlab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sndlab3
        '
        Me.sndlab3.BackColor = System.Drawing.Color.White
        Me.sndlab3.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sndlab3.Location = New System.Drawing.Point(4, 114)
        Me.sndlab3.Name = "sndlab3"
        Me.sndlab3.Size = New System.Drawing.Size(127, 23)
        Me.sndlab3.TabIndex = 45
        Me.sndlab3.Text = "소리 정보"
        Me.sndlab3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'actbox
        '
        Me.actbox.BackColor = System.Drawing.Color.White
        Me.actbox.Controls.Add(Me.actbut)
        Me.actbox.Controls.Add(Me.actex4)
        Me.actbox.Controls.Add(Me.acthow)
        Me.actbox.Controls.Add(Me.actex3)
        Me.actbox.Controls.Add(Me.actuse)
        Me.actbox.Controls.Add(Me.actex2)
        Me.actbox.Controls.Add(Me.actex1)
        Me.actbox.Controls.Add(Me.actok)
        Me.actbox.Controls.Add(Me.actcom2)
        Me.actbox.Controls.Add(Me.actcom1)
        Me.actbox.Controls.Add(Me.acttxt2)
        Me.actbox.Controls.Add(Me.acttxt1)
        Me.actbox.Controls.Add(Me.actlab2)
        Me.actbox.Controls.Add(Me.actlab1)
        Me.actbox.Controls.Add(Me.actkor)
        Me.actbox.Location = New System.Drawing.Point(2, 536)
        Me.actbox.Name = "actbox"
        Me.actbox.Size = New System.Drawing.Size(843, 186)
        Me.actbox.TabIndex = 41
        Me.actbox.Visible = False
        '
        'actbut
        '
        Me.actbut.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.actbut.Location = New System.Drawing.Point(9, 152)
        Me.actbut.Name = "actbut"
        Me.actbut.Size = New System.Drawing.Size(30, 30)
        Me.actbut.TabIndex = 71
        Me.actbut.Text = "③"
        Me.actbut.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.actbut.UseVisualStyleBackColor = True
        '
        'actex4
        '
        Me.actex4.AutoSize = True
        Me.actex4.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actex4.ForeColor = System.Drawing.Color.Black
        Me.actex4.Location = New System.Drawing.Point(494, 60)
        Me.actex4.Name = "actex4"
        Me.actex4.Size = New System.Drawing.Size(29, 12)
        Me.actex4.TabIndex = 70
        Me.actex4.Text = "설명"
        '
        'acthow
        '
        Me.acthow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.acthow.Font = New System.Drawing.Font("굴림", 8.0!)
        Me.acthow.Location = New System.Drawing.Point(491, 74)
        Me.acthow.Name = "acthow"
        Me.acthow.Size = New System.Drawing.Size(218, 104)
        Me.acthow.TabIndex = 69
        Me.acthow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'actex3
        '
        Me.actex3.AutoSize = True
        Me.actex3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actex3.ForeColor = System.Drawing.Color.Black
        Me.actex3.Location = New System.Drawing.Point(265, 60)
        Me.actex3.Name = "actex3"
        Me.actex3.Size = New System.Drawing.Size(69, 12)
        Me.actex3.TabIndex = 68
        Me.actex3.Text = "코드 사용법"
        '
        'actuse
        '
        Me.actuse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.actuse.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actuse.Location = New System.Drawing.Point(262, 74)
        Me.actuse.Name = "actuse"
        Me.actuse.Size = New System.Drawing.Size(218, 104)
        Me.actuse.TabIndex = 67
        Me.actuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'actex2
        '
        Me.actex2.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actex2.ForeColor = System.Drawing.Color.Gray
        Me.actex2.Location = New System.Drawing.Point(47, 154)
        Me.actex2.Name = "actex2"
        Me.actex2.Size = New System.Drawing.Size(209, 22)
        Me.actex2.TabIndex = 66
        Me.actex2.Text = "변수 또는 일정 숫자 중 선택해 주세요"
        '
        'actex1
        '
        Me.actex1.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actex1.ForeColor = System.Drawing.Color.Gray
        Me.actex1.Location = New System.Drawing.Point(47, 100)
        Me.actex1.Name = "actex1"
        Me.actex1.Size = New System.Drawing.Size(209, 22)
        Me.actex1.TabIndex = 62
        Me.actex1.Text = "변수 중에 선택해 주세요"
        '
        'actok
        '
        Me.actok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actok.BackColor = System.Drawing.Color.White
        Me.actok.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actok.Location = New System.Drawing.Point(722, 147)
        Me.actok.Name = "actok"
        Me.actok.Size = New System.Drawing.Size(97, 30)
        Me.actok.TabIndex = 62
        Me.actok.Text = "확인"
        Me.actok.UseVisualStyleBackColor = False
        '
        'actcom2
        '
        Me.actcom2.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.actcom2.FormattingEnabled = True
        Me.actcom2.Location = New System.Drawing.Point(116, 123)
        Me.actcom2.Name = "actcom2"
        Me.actcom2.Size = New System.Drawing.Size(121, 28)
        Me.actcom2.TabIndex = 65
        '
        'actcom1
        '
        Me.actcom1.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.actcom1.FormattingEnabled = True
        Me.actcom1.Location = New System.Drawing.Point(116, 70)
        Me.actcom1.Name = "actcom1"
        Me.actcom1.Size = New System.Drawing.Size(121, 28)
        Me.actcom1.TabIndex = 64
        '
        'acttxt2
        '
        Me.acttxt2.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.acttxt2.Location = New System.Drawing.Point(49, 123)
        Me.acttxt2.Name = "acttxt2"
        Me.acttxt2.Size = New System.Drawing.Size(64, 27)
        Me.acttxt2.TabIndex = 63
        '
        'acttxt1
        '
        Me.acttxt1.Font = New System.Drawing.Font("맑은 고딕", 11.25!)
        Me.acttxt1.Location = New System.Drawing.Point(49, 70)
        Me.acttxt1.Name = "acttxt1"
        Me.acttxt1.Size = New System.Drawing.Size(64, 27)
        Me.acttxt1.TabIndex = 62
        '
        'actlab2
        '
        Me.actlab2.BackColor = System.Drawing.Color.White
        Me.actlab2.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actlab2.Location = New System.Drawing.Point(11, 122)
        Me.actlab2.Name = "actlab2"
        Me.actlab2.Size = New System.Drawing.Size(41, 23)
        Me.actlab2.TabIndex = 46
        Me.actlab2.Text = "② ="
        Me.actlab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'actlab1
        '
        Me.actlab1.BackColor = System.Drawing.Color.White
        Me.actlab1.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actlab1.Location = New System.Drawing.Point(11, 71)
        Me.actlab1.Name = "actlab1"
        Me.actlab1.Size = New System.Drawing.Size(41, 25)
        Me.actlab1.TabIndex = 45
        Me.actlab1.Text = "① ="
        Me.actlab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'actkor
        '
        Me.actkor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.actkor.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.actkor.Location = New System.Drawing.Point(9, 7)
        Me.actkor.Name = "actkor"
        Me.actkor.Size = New System.Drawing.Size(828, 48)
        Me.actkor.TabIndex = 0
        Me.actkor.Text = "만약 ①가 ②라면"
        Me.actkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'opensnd
        '
        Me.opensnd.Filter = "WAV 사운드 파일(*. wav)|*.wav|MP3 형식 사운드(*.mp3)|*.mp3훈민정Net 전용 소리(*.hsnd)|.hsnd|"
        '
        'nodadd
        '
        Me.nodadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.nodadd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.nodadd.Location = New System.Drawing.Point(1083, 503)
        Me.nodadd.Name = "nodadd"
        Me.nodadd.Size = New System.Drawing.Size(33, 23)
        Me.nodadd.TabIndex = 43
        Me.nodadd.Text = "추가"
        Me.nodadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'noddel
        '
        Me.noddel.BackColor = System.Drawing.Color.Silver
        Me.noddel.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.noddel.Location = New System.Drawing.Point(1050, 503)
        Me.noddel.Name = "noddel"
        Me.noddel.Size = New System.Drawing.Size(33, 23)
        Me.noddel.TabIndex = 44
        Me.noddel.Text = "삭제"
        Me.noddel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'savefile
        '
        Me.savefile.Filter = "PProgramming 저장 파일(*. vprog)|*.vprog"
        '
        'openfile
        '
        Me.openfile.FileName = "OpenFileDialog1"
        Me.openfile.Filter = "PProgramming 저장 파일(*. vprog)|*.vprog"
        '
        'destext
        '
        Me.destext.Location = New System.Drawing.Point(818, 510)
        Me.destext.Name = "destext"
        Me.destext.Size = New System.Drawing.Size(1, 1)
        Me.destext.TabIndex = 45
        Me.destext.Text = resources.GetString("destext.Text")
        '
        'but_com
        '
        Me.but_com.Image = Global.PackofProginner.My.Resources.Resources.undobut
        Me.but_com.Location = New System.Drawing.Point(851, 0)
        Me.but_com.Name = "but_com"
        Me.but_com.Size = New System.Drawing.Size(47, 36)
        Me.but_com.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.but_com.TabIndex = 42
        Me.but_com.TabStop = False
        '
        'picblack
        '
        Me.picblack.Location = New System.Drawing.Point(835, 523)
        Me.picblack.Name = "picblack"
        Me.picblack.Size = New System.Drawing.Size(2, 2)
        Me.picblack.TabIndex = 39
        Me.picblack.TabStop = False
        Me.picblack.Tag = """"
        Me.picblack.Visible = False
        '
        'listbar
        '
        Me.listbar.BackColor = System.Drawing.Color.Transparent
        Me.listbar.Image = Global.PackofProginner.My.Resources.Resources.jobar
        Me.listbar.Location = New System.Drawing.Point(851, 94)
        Me.listbar.Name = "listbar"
        Me.listbar.Size = New System.Drawing.Size(282, 20)
        Me.listbar.TabIndex = 24
        Me.listbar.TabStop = False
        '
        'but_set
        '
        Me.but_set.Image = Global.PackofProginner.My.Resources.Resources.setbut
        Me.but_set.Location = New System.Drawing.Point(898, 0)
        Me.but_set.Name = "but_set"
        Me.but_set.Size = New System.Drawing.Size(47, 36)
        Me.but_set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.but_set.TabIndex = 23
        Me.but_set.TabStop = False
        '
        'but_load
        '
        Me.but_load.Image = Global.PackofProginner.My.Resources.Resources.loadbut3
        Me.but_load.Location = New System.Drawing.Point(1039, 0)
        Me.but_load.Name = "but_load"
        Me.but_load.Size = New System.Drawing.Size(47, 36)
        Me.but_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.but_load.TabIndex = 22
        Me.but_load.TabStop = False
        '
        'but_save
        '
        Me.but_save.Image = Global.PackofProginner.My.Resources.Resources.savebut
        Me.but_save.Location = New System.Drawing.Point(992, 0)
        Me.but_save.Name = "but_save"
        Me.but_save.Size = New System.Drawing.Size(47, 36)
        Me.but_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.but_save.TabIndex = 21
        Me.but_save.TabStop = False
        '
        'but_code
        '
        Me.but_code.Image = Global.PackofProginner.My.Resources.Resources.codebut
        Me.but_code.Location = New System.Drawing.Point(945, 0)
        Me.but_code.Name = "but_code"
        Me.but_code.Size = New System.Drawing.Size(47, 36)
        Me.but_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.but_code.TabIndex = 20
        Me.but_code.TabStop = False
        '
        'but_ask
        '
        Me.but_ask.Image = Global.PackofProginner.My.Resources.Resources.askbut
        Me.but_ask.Location = New System.Drawing.Point(1086, 0)
        Me.but_ask.Name = "but_ask"
        Me.but_ask.Size = New System.Drawing.Size(47, 36)
        Me.but_ask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.but_ask.TabIndex = 18
        Me.but_ask.TabStop = False
        '
        'hruler
        '
        Me.hruler.Image = CType(resources.GetObject("hruler.Image"), System.Drawing.Image)
        Me.hruler.Location = New System.Drawing.Point(-2, 499)
        Me.hruler.Name = "hruler"
        Me.hruler.Size = New System.Drawing.Size(802, 31)
        Me.hruler.TabIndex = 11
        Me.hruler.TabStop = False
        '
        'vruler
        '
        Me.vruler.Image = CType(resources.GetObject("vruler.Image"), System.Drawing.Image)
        Me.vruler.Location = New System.Drawing.Point(800, 0)
        Me.vruler.Name = "vruler"
        Me.vruler.Size = New System.Drawing.Size(45, 502)
        Me.vruler.TabIndex = 10
        Me.vruler.TabStop = False
        '
        'display
        '
        Me.display.BackColor = System.Drawing.Color.White
        Me.display.Location = New System.Drawing.Point(0, 0)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(800, 500)
        Me.display.TabIndex = 1
        Me.display.TabStop = False
        '
        'Main_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1136, 726)
        Me.Controls.Add(Me.actbox)
        Me.Controls.Add(Me.destext)
        Me.Controls.Add(Me.noddel)
        Me.Controls.Add(Me.nodadd)
        Me.Controls.Add(Me.but_com)
        Me.Controls.Add(Me.sndbox)
        Me.Controls.Add(Me.picblack)
        Me.Controls.Add(Me.obbox)
        Me.Controls.Add(Me.setbox)
        Me.Controls.Add(Me.nobox)
        Me.Controls.Add(Me.listbar)
        Me.Controls.Add(Me.but_set)
        Me.Controls.Add(Me.but_load)
        Me.Controls.Add(Me.but_save)
        Me.Controls.Add(Me.but_code)
        Me.Controls.Add(Me.but_ask)
        Me.Controls.Add(Me.but_sound)
        Me.Controls.Add(Me.but_object)
        Me.Controls.Add(Me.but_script)
        Me.Controls.Add(Me.hruler)
        Me.Controls.Add(Me.vruler)
        Me.Controls.Add(Me.slist)
        Me.Controls.Add(Me.script)
        Me.Controls.Add(Me.display)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pack of Programming"
        Me.setbox.ResumeLayout(False)
        Me.setbox.PerformLayout()
        Me.obbox.ResumeLayout(False)
        Me.obbox.PerformLayout()
        CType(Me.obpic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sndbox.ResumeLayout(False)
        Me.sndbox.PerformLayout()
        CType(Me.sndpic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sndpic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sndbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sndplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.actbox.ResumeLayout(False)
        Me.actbox.PerformLayout()
        CType(Me.but_com, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picblack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_set, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_load, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_ask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hruler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vruler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents display As System.Windows.Forms.PictureBox
    Friend WithEvents vruler As System.Windows.Forms.PictureBox
    Friend WithEvents hruler As System.Windows.Forms.PictureBox
    Friend WithEvents but_object As System.Windows.Forms.Label
    Friend WithEvents but_sound As System.Windows.Forms.Label
    Friend WithEvents colortimer As System.Windows.Forms.Timer
    Friend WithEvents but_ask As System.Windows.Forms.PictureBox
    Friend WithEvents but_code As System.Windows.Forms.PictureBox
    Friend WithEvents but_save As System.Windows.Forms.PictureBox
    Friend WithEvents but_load As System.Windows.Forms.PictureBox
    Friend WithEvents but_set As System.Windows.Forms.PictureBox
    Friend WithEvents slist As System.Windows.Forms.ListBox
    Friend WithEvents listbar As System.Windows.Forms.PictureBox
    Friend WithEvents nobox As System.Windows.Forms.Label
    Friend WithEvents setbox As System.Windows.Forms.Panel
    Friend WithEvents setok As System.Windows.Forms.Button
    Friend WithEvents setlab1 As System.Windows.Forms.Label
    Friend WithEvents settxt2 As System.Windows.Forms.TextBox
    Friend WithEvents settxt1 As System.Windows.Forms.TextBox
    Friend WithEvents setcom As System.Windows.Forms.ComboBox
    Friend WithEvents setlab2 As System.Windows.Forms.Label
    Friend WithEvents setlab3 As System.Windows.Forms.Label
    Friend WithEvents but_script As System.Windows.Forms.Label
    Friend WithEvents setex1 As System.Windows.Forms.Label
    Friend WithEvents openobj As System.Windows.Forms.OpenFileDialog
    Friend WithEvents obbox As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents obtxt3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents obtxt4 As System.Windows.Forms.TextBox
    Friend WithEvents obpic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents obok As System.Windows.Forms.Button
    Friend WithEvents oblab1 As System.Windows.Forms.Label
    Friend WithEvents obtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents obtxt1 As System.Windows.Forms.TextBox
    Friend WithEvents oblab2 As System.Windows.Forms.Label
    Friend WithEvents oblab3 As System.Windows.Forms.Label
    Friend WithEvents obread As System.Windows.Forms.Button
    Friend WithEvents picblack As System.Windows.Forms.PictureBox
    Friend WithEvents sndbox As System.Windows.Forms.Panel
    Friend WithEvents sndplay As AxMediaPlayer.AxMediaPlayer
    Friend WithEvents sndread As System.Windows.Forms.Button
    Friend WithEvents sndtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sndok As System.Windows.Forms.Button
    Friend WithEvents sndlab1 As System.Windows.Forms.Label
    Friend WithEvents sndtxt1 As System.Windows.Forms.TextBox
    Friend WithEvents sndlab2 As System.Windows.Forms.Label
    Friend WithEvents sndlab3 As System.Windows.Forms.Label
    Friend WithEvents sndpic1 As System.Windows.Forms.PictureBox
    Friend WithEvents sndpic2 As System.Windows.Forms.PictureBox
    Friend WithEvents sndtxt3 As System.Windows.Forms.TextBox
    Friend WithEvents sndbar As System.Windows.Forms.TrackBar
    Friend WithEvents opensnd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sndlab5 As System.Windows.Forms.Label
    Friend WithEvents sndlab4 As System.Windows.Forms.Label
    Friend WithEvents actbox As System.Windows.Forms.Panel
    Friend WithEvents actkor As System.Windows.Forms.Label
    Friend WithEvents actex2 As System.Windows.Forms.Label
    Friend WithEvents actex1 As System.Windows.Forms.Label
    Friend WithEvents actok As System.Windows.Forms.Button
    Friend WithEvents actcom2 As System.Windows.Forms.ComboBox
    Friend WithEvents actcom1 As System.Windows.Forms.ComboBox
    Friend WithEvents acttxt2 As System.Windows.Forms.TextBox
    Friend WithEvents acttxt1 As System.Windows.Forms.TextBox
    Friend WithEvents actlab2 As System.Windows.Forms.Label
    Friend WithEvents actlab1 As System.Windows.Forms.Label
    Friend WithEvents actex4 As System.Windows.Forms.Label
    Friend WithEvents acthow As System.Windows.Forms.Label
    Friend WithEvents actex3 As System.Windows.Forms.Label
    Friend WithEvents actuse As System.Windows.Forms.Label
    Friend WithEvents colorcng As System.Windows.Forms.ColorDialog
    Friend WithEvents actbut As System.Windows.Forms.Button
    Friend WithEvents script As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents but_com As System.Windows.Forms.PictureBox
    Friend WithEvents nodadd As System.Windows.Forms.Label
    Friend WithEvents noddel As System.Windows.Forms.Label
    Friend WithEvents savefile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openfile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents destext As System.Windows.Forms.Label
    Friend WithEvents transfile As System.Windows.Forms.FolderBrowserDialog

End Class
