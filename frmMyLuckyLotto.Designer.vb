<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyLuckyLotto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNumber3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblNumber4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblNumber5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblNumber6 = New System.Windows.Forms.Label()
        Me.btnRollIt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LuckyPickID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeRolled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LottoType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLottoType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLottoType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltimer = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDrawDate = New System.Windows.Forms.Label()
        Me.btnViewDraw = New System.Windows.Forms.Button()
        Me.btnGotMessage = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblNumber1)
        Me.Panel1.Location = New System.Drawing.Point(17, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(85, 80)
        Me.Panel1.TabIndex = 0
        '
        'lblNumber1
        '
        Me.lblNumber1.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNumber1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber1.Font = New System.Drawing.Font("Poor Richard", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.ForeColor = System.Drawing.Color.Gold
        Me.lblNumber1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblNumber1.Location = New System.Drawing.Point(0, 0)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(85, 80)
        Me.lblNumber1.TabIndex = 0
        Me.lblNumber1.Text = "Roll1"
        Me.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lblNumber2)
        Me.Panel2.Location = New System.Drawing.Point(127, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(85, 80)
        Me.Panel2.TabIndex = 1
        '
        'lblNumber2
        '
        Me.lblNumber2.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNumber2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber2.Font = New System.Drawing.Font("Poor Richard", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.ForeColor = System.Drawing.Color.Gold
        Me.lblNumber2.Location = New System.Drawing.Point(0, 0)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(85, 80)
        Me.lblNumber2.TabIndex = 1
        Me.lblNumber2.Text = "Roll2"
        Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.lblNumber3)
        Me.Panel3.Location = New System.Drawing.Point(237, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(85, 80)
        Me.Panel3.TabIndex = 1
        '
        'lblNumber3
        '
        Me.lblNumber3.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNumber3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber3.Font = New System.Drawing.Font("Poor Richard", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber3.ForeColor = System.Drawing.Color.Gold
        Me.lblNumber3.Location = New System.Drawing.Point(0, 0)
        Me.lblNumber3.Name = "lblNumber3"
        Me.lblNumber3.Size = New System.Drawing.Size(85, 80)
        Me.lblNumber3.TabIndex = 2
        Me.lblNumber3.Text = "Roll3"
        Me.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.lblNumber4)
        Me.Panel4.Location = New System.Drawing.Point(347, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(85, 80)
        Me.Panel4.TabIndex = 1
        '
        'lblNumber4
        '
        Me.lblNumber4.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNumber4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber4.Font = New System.Drawing.Font("Poor Richard", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber4.ForeColor = System.Drawing.Color.Gold
        Me.lblNumber4.Location = New System.Drawing.Point(0, 0)
        Me.lblNumber4.Name = "lblNumber4"
        Me.lblNumber4.Size = New System.Drawing.Size(85, 80)
        Me.lblNumber4.TabIndex = 3
        Me.lblNumber4.Text = "Roll4"
        Me.lblNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.lblNumber5)
        Me.Panel5.Location = New System.Drawing.Point(457, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(85, 80)
        Me.Panel5.TabIndex = 2
        '
        'lblNumber5
        '
        Me.lblNumber5.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNumber5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber5.Font = New System.Drawing.Font("Poor Richard", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber5.ForeColor = System.Drawing.Color.Gold
        Me.lblNumber5.Location = New System.Drawing.Point(0, 0)
        Me.lblNumber5.Name = "lblNumber5"
        Me.lblNumber5.Size = New System.Drawing.Size(85, 80)
        Me.lblNumber5.TabIndex = 4
        Me.lblNumber5.Text = "Roll5"
        Me.lblNumber5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Controls.Add(Me.lblNumber6)
        Me.Panel6.Location = New System.Drawing.Point(567, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(85, 80)
        Me.Panel6.TabIndex = 3
        '
        'lblNumber6
        '
        Me.lblNumber6.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNumber6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber6.Font = New System.Drawing.Font("Poor Richard", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber6.ForeColor = System.Drawing.Color.Gold
        Me.lblNumber6.Location = New System.Drawing.Point(0, 0)
        Me.lblNumber6.Name = "lblNumber6"
        Me.lblNumber6.Size = New System.Drawing.Size(85, 80)
        Me.lblNumber6.TabIndex = 5
        Me.lblNumber6.Text = "Roll6"
        Me.lblNumber6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRollIt
        '
        Me.btnRollIt.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRollIt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRollIt.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollIt.ForeColor = System.Drawing.Color.DarkRed
        Me.btnRollIt.Location = New System.Drawing.Point(6, 173)
        Me.btnRollIt.Name = "btnRollIt"
        Me.btnRollIt.Size = New System.Drawing.Size(109, 71)
        Me.btnRollIt.TabIndex = 4
        Me.btnRollIt.Text = "Roll My Lucky Number"
        Me.btnRollIt.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LuckyPickID, Me.DateTimeRolled, Me.Number1, Me.Number2, Me.Number3, Me.Number4, Me.Number5, Me.Number6, Me.LottoType})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(653, 84)
        Me.DataGridView1.TabIndex = 5
        '
        'LuckyPickID
        '
        Me.LuckyPickID.DataPropertyName = "luckypickid"
        Me.LuckyPickID.HeaderText = "LuckyPickID"
        Me.LuckyPickID.Name = "LuckyPickID"
        Me.LuckyPickID.ReadOnly = True
        Me.LuckyPickID.Visible = False
        Me.LuckyPickID.Width = 93
        '
        'DateTimeRolled
        '
        Me.DateTimeRolled.DataPropertyName = "DateAndTime"
        Me.DateTimeRolled.HeaderText = "DateTimeRolled"
        Me.DateTimeRolled.Name = "DateTimeRolled"
        Me.DateTimeRolled.ReadOnly = True
        Me.DateTimeRolled.Width = 108
        '
        'Number1
        '
        Me.Number1.DataPropertyName = "1stNumber"
        Me.Number1.HeaderText = "Number1"
        Me.Number1.Name = "Number1"
        Me.Number1.ReadOnly = True
        Me.Number1.Width = 75
        '
        'Number2
        '
        Me.Number2.DataPropertyName = "2ndNumber"
        Me.Number2.HeaderText = "Number2"
        Me.Number2.Name = "Number2"
        Me.Number2.ReadOnly = True
        Me.Number2.Width = 75
        '
        'Number3
        '
        Me.Number3.DataPropertyName = "3rdNumber"
        Me.Number3.HeaderText = "Number3"
        Me.Number3.Name = "Number3"
        Me.Number3.ReadOnly = True
        Me.Number3.Width = 75
        '
        'Number4
        '
        Me.Number4.DataPropertyName = "4thNumber"
        Me.Number4.HeaderText = "Number4"
        Me.Number4.Name = "Number4"
        Me.Number4.ReadOnly = True
        Me.Number4.Width = 75
        '
        'Number5
        '
        Me.Number5.DataPropertyName = "5thNumber"
        Me.Number5.HeaderText = "Number5"
        Me.Number5.Name = "Number5"
        Me.Number5.ReadOnly = True
        Me.Number5.Width = 75
        '
        'Number6
        '
        Me.Number6.DataPropertyName = "6thNumber"
        Me.Number6.HeaderText = "Number6"
        Me.Number6.Name = "Number6"
        Me.Number6.ReadOnly = True
        Me.Number6.Width = 75
        '
        'LottoType
        '
        Me.LottoType.DataPropertyName = "LottoType"
        Me.LottoType.HeaderText = "LT"
        Me.LottoType.Name = "LottoType"
        Me.LottoType.ReadOnly = True
        Me.LottoType.Width = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.GreenYellow
        Me.GroupBox1.Location = New System.Drawing.Point(121, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 103)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recent Saved Lucky Number"
        '
        'lblLottoType
        '
        Me.lblLottoType.AutoSize = True
        Me.lblLottoType.BackColor = System.Drawing.Color.Transparent
        Me.lblLottoType.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLottoType.ForeColor = System.Drawing.Color.Gold
        Me.lblLottoType.Location = New System.Drawing.Point(606, -2)
        Me.lblLottoType.Name = "lblLottoType"
        Me.lblLottoType.Size = New System.Drawing.Size(180, 38)
        Me.lblLottoType.TabIndex = 7
        Me.lblLottoType.Text = "LottoType"
        Me.lblLottoType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Choose Lotto Type:"
        '
        'cmbLottoType
        '
        Me.cmbLottoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLottoType.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLottoType.FormattingEnabled = True
        Me.cmbLottoType.Items.AddRange(New Object() {"6/58", "6/55", "6/49", "6/45"})
        Me.cmbLottoType.Location = New System.Drawing.Point(178, 11)
        Me.cmbLottoType.Name = "cmbLottoType"
        Me.cmbLottoType.Size = New System.Drawing.Size(136, 30)
        Me.cmbLottoType.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mistral", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(599, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Developed By: Kenth Joshua Espina"
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'lbltimer
        '
        Me.lbltimer.AutoSize = True
        Me.lbltimer.Location = New System.Drawing.Point(430, 12)
        Me.lbltimer.Name = "lbltimer"
        Me.lbltimer.Size = New System.Drawing.Size(33, 13)
        Me.lbltimer.TabIndex = 11
        Me.lbltimer.Text = "Timer"
        Me.lbltimer.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Moccasin
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(0, 256)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(786, 19)
        Me.Panel7.TabIndex = 14
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(722, 68)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.Text = "Username"
        Me.lblUsername.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDrawDate)
        Me.GroupBox2.ForeColor = System.Drawing.Color.GreenYellow
        Me.GroupBox2.Location = New System.Drawing.Point(658, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 42)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "To View Draw Date"
        '
        'lblDrawDate
        '
        Me.lblDrawDate.AutoSize = True
        Me.lblDrawDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDrawDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrawDate.ForeColor = System.Drawing.Color.White
        Me.lblDrawDate.Location = New System.Drawing.Point(3, 16)
        Me.lblDrawDate.Name = "lblDrawDate"
        Me.lblDrawDate.Size = New System.Drawing.Size(97, 15)
        Me.lblDrawDate.TabIndex = 0
        Me.lblDrawDate.Text = "Click Gridview"
        '
        'btnViewDraw
        '
        Me.btnViewDraw.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewDraw.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDraw.ForeColor = System.Drawing.Color.DarkRed
        Me.btnViewDraw.Location = New System.Drawing.Point(664, 62)
        Me.btnViewDraw.Name = "btnViewDraw"
        Me.btnViewDraw.Size = New System.Drawing.Size(110, 43)
        Me.btnViewDraw.TabIndex = 17
        Me.btnViewDraw.Text = "Recent Draw Lotto Result"
        Me.btnViewDraw.UseVisualStyleBackColor = False
        '
        'btnGotMessage
        '
        Me.btnGotMessage.BackgroundImage = Global.LuckyLotto.My.Resources.Resources.MailNew
        Me.btnGotMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGotMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGotMessage.Location = New System.Drawing.Point(338, 11)
        Me.btnGotMessage.Name = "btnGotMessage"
        Me.btnGotMessage.Size = New System.Drawing.Size(40, 30)
        Me.btnGotMessage.TabIndex = 18
        Me.btnGotMessage.UseVisualStyleBackColor = True
        Me.btnGotMessage.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.LuckyLotto.My.Resources.Resources.animatedlotterywinner
        Me.PictureBox8.Location = New System.Drawing.Point(714, -2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(72, 58)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.LuckyLotto.My.Resources.Resources.Eclipse_0_7s_200px
        Me.PictureBox6.ImageLocation = ""
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(85, 80)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 17
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.LuckyLotto.My.Resources.Resources.Eclipse_0_7s_200px
        Me.PictureBox5.ImageLocation = ""
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(85, 80)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LuckyLotto.My.Resources.Resources.Eclipse_0_7s_200px
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.LuckyLotto.My.Resources.Resources.Eclipse_0_7s_200px
        Me.PictureBox3.ImageLocation = ""
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(85, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.LuckyLotto.My.Resources.Resources.Eclipse_0_7s_200px
        Me.PictureBox4.ImageLocation = ""
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(85, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LuckyLotto.My.Resources.Resources.Eclipse_0_7s_200px
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.LuckyLotto.My.Resources.Resources.Background
        Me.PictureBox7.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(786, 55)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'frmMyLuckyLotto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(786, 274)
        Me.Controls.Add(Me.btnGotMessage)
        Me.Controls.Add(Me.btnViewDraw)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.lbltimer)
        Me.Controls.Add(Me.cmbLottoType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLottoType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRollIt)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel7)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMyLuckyLotto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyLuckyLotto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnRollIt As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLottoType As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblNumber3 As System.Windows.Forms.Label
    Friend WithEvents lblNumber4 As System.Windows.Forms.Label
    Friend WithEvents lblNumber5 As System.Windows.Forms.Label
    Friend WithEvents lblNumber6 As System.Windows.Forms.Label
    Friend WithEvents cmbLottoType As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumber2 As System.Windows.Forms.Label
    Friend WithEvents LuckyPickID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeRolled As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Number6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LottoType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltimer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDrawDate As System.Windows.Forms.Label
    Friend WithEvents btnViewDraw As System.Windows.Forms.Button
    Friend WithEvents btnGotMessage As System.Windows.Forms.Button

End Class
