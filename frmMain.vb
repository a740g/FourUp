' 4Play: Classic Connect 4 game against AI
' Copyright (c) Samuel Gomes, 2020

Public Class FrmMain
	Inherits Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

	End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
		If disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents MnuMain As MainMenu
	Friend WithEvents MnuGame As MenuItem
	Friend WithEvents MnuGameNew As MenuItem
	Friend WithEvents MnuGameSeperator1 As MenuItem
	Friend WithEvents MnuGameExit As MenuItem
	Friend WithEvents MnuHelp As MenuItem
	Friend WithEvents MnuHelpHowTo As MenuItem
	Friend WithEvents MnuHelpHint As MenuItem
	Friend WithEvents MnuHelpSeperator1 As MenuItem
	Friend WithEvents MnuHelpAbout As MenuItem
	Friend WithEvents TmrUpdate As Timer
	Friend WithEvents PnlPawns As Panel
	Friend WithEvents PnlButtons As Panel
	Friend WithEvents Cmd1 As Button
	Friend WithEvents TxtStatus As TextBox
	Friend WithEvents LblPlayerScoreLbl As Label
	Friend WithEvents LblPlayerLastMoveLbl As Label
	Friend WithEvents LblPlayerScore As Label
	Friend WithEvents LblPlayerLastMove As Label
	Friend WithEvents LblPlayerTime As Label
	Friend WithEvents Cmd2 As Button
	Friend WithEvents Cmd3 As Button
	Friend WithEvents Cmd4 As Button
	Friend WithEvents Cmd5 As Button
	Friend WithEvents Cmd6 As Button
	Friend WithEvents Cmd7 As Button
	Friend WithEvents PnlStatus As Panel
	Friend WithEvents Lbl0_0 As Label
	Friend WithEvents Lbl0_1 As Label
	Friend WithEvents Lbl0_2 As Label
	Friend WithEvents Lbl0_3 As Label
	Friend WithEvents Lbl0_4 As Label
	Friend WithEvents Lbl0_5 As Label
	Friend WithEvents Lbl1_5 As Label
	Friend WithEvents Lbl1_4 As Label
	Friend WithEvents Lbl1_3 As Label
	Friend WithEvents Lbl1_2 As Label
	Friend WithEvents Lbl1_1 As Label
	Friend WithEvents Lbl1_0 As Label
	Friend WithEvents Lbl2_5 As Label
	Friend WithEvents Lbl2_4 As Label
	Friend WithEvents Lbl2_3 As Label
	Friend WithEvents Lbl2_2 As Label
	Friend WithEvents Lbl2_1 As Label
	Friend WithEvents Lbl2_0 As Label
	Friend WithEvents Lbl3_5 As Label
	Friend WithEvents Lbl3_4 As Label
	Friend WithEvents Lbl3_3 As Label
	Friend WithEvents Lbl3_2 As Label
	Friend WithEvents Lbl3_1 As Label
	Friend WithEvents Lbl3_0 As Label
	Friend WithEvents Lbl4_5 As Label
	Friend WithEvents Lbl4_4 As Label
	Friend WithEvents Lbl4_3 As Label
	Friend WithEvents Lbl4_2 As Label
	Friend WithEvents Lbl4_1 As Label
	Friend WithEvents Lbl4_0 As Label
	Friend WithEvents Lbl5_5 As Label
	Friend WithEvents Lbl5_4 As Label
	Friend WithEvents Lbl5_3 As Label
	Friend WithEvents Lbl5_2 As Label
	Friend WithEvents Lbl5_1 As Label
	Friend WithEvents Lbl5_0 As Label
	Friend WithEvents Lbl6_5 As Label
	Friend WithEvents Lbl6_4 As Label
	Friend WithEvents Lbl6_3 As Label
	Friend WithEvents Lbl6_2 As Label
	Friend WithEvents Lbl6_1 As Label
	Friend WithEvents Lbl6_0 As Label
	Friend WithEvents GrpPlayer As GroupBox
	Friend WithEvents GrpComputer As GroupBox
	Friend WithEvents LblPlayerTimeLbl As Label
	Friend WithEvents LblComputerTime As Label
	Friend WithEvents LblComputerLastMove As Label
	Friend WithEvents LblComputerScore As Label
	Friend WithEvents LblComputerTimeLbl As Label
	Friend WithEvents LblComputerLastMoveLbl As Label
	Friend WithEvents LblComputerScoreLbl As Label
	<DebuggerStepThrough()> Private Sub InitializeComponent()
		components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
		MnuMain = New System.Windows.Forms.MainMenu(components)
		MnuGame = New System.Windows.Forms.MenuItem()
		MnuGameNew = New System.Windows.Forms.MenuItem()
		MnuGameSeperator1 = New System.Windows.Forms.MenuItem()
		MnuGameExit = New System.Windows.Forms.MenuItem()
		MnuHelp = New System.Windows.Forms.MenuItem()
		MnuHelpHowTo = New System.Windows.Forms.MenuItem()
		MnuHelpHint = New System.Windows.Forms.MenuItem()
		MnuHelpSeperator1 = New System.Windows.Forms.MenuItem()
		MnuHelpAbout = New System.Windows.Forms.MenuItem()
		TmrUpdate = New System.Windows.Forms.Timer(components)
		PnlPawns = New System.Windows.Forms.Panel()
		Lbl6_5 = New System.Windows.Forms.Label()
		Lbl6_4 = New System.Windows.Forms.Label()
		Lbl6_3 = New System.Windows.Forms.Label()
		Lbl6_2 = New System.Windows.Forms.Label()
		Lbl6_1 = New System.Windows.Forms.Label()
		Lbl6_0 = New System.Windows.Forms.Label()
		Lbl5_5 = New System.Windows.Forms.Label()
		Lbl5_4 = New System.Windows.Forms.Label()
		Lbl5_3 = New System.Windows.Forms.Label()
		Lbl5_2 = New System.Windows.Forms.Label()
		Lbl5_1 = New System.Windows.Forms.Label()
		Lbl5_0 = New System.Windows.Forms.Label()
		Lbl4_5 = New System.Windows.Forms.Label()
		Lbl4_4 = New System.Windows.Forms.Label()
		Lbl4_3 = New System.Windows.Forms.Label()
		Lbl4_2 = New System.Windows.Forms.Label()
		Lbl4_1 = New System.Windows.Forms.Label()
		Lbl4_0 = New System.Windows.Forms.Label()
		Lbl3_5 = New System.Windows.Forms.Label()
		Lbl3_4 = New System.Windows.Forms.Label()
		Lbl3_3 = New System.Windows.Forms.Label()
		Lbl3_2 = New System.Windows.Forms.Label()
		Lbl3_1 = New System.Windows.Forms.Label()
		Lbl3_0 = New System.Windows.Forms.Label()
		Lbl2_5 = New System.Windows.Forms.Label()
		Lbl2_4 = New System.Windows.Forms.Label()
		Lbl2_3 = New System.Windows.Forms.Label()
		Lbl2_2 = New System.Windows.Forms.Label()
		Lbl2_1 = New System.Windows.Forms.Label()
		Lbl2_0 = New System.Windows.Forms.Label()
		Lbl1_5 = New System.Windows.Forms.Label()
		Lbl1_4 = New System.Windows.Forms.Label()
		Lbl1_3 = New System.Windows.Forms.Label()
		Lbl1_2 = New System.Windows.Forms.Label()
		Lbl1_1 = New System.Windows.Forms.Label()
		Lbl1_0 = New System.Windows.Forms.Label()
		Lbl0_5 = New System.Windows.Forms.Label()
		Lbl0_4 = New System.Windows.Forms.Label()
		Lbl0_3 = New System.Windows.Forms.Label()
		Lbl0_2 = New System.Windows.Forms.Label()
		Lbl0_1 = New System.Windows.Forms.Label()
		Lbl0_0 = New System.Windows.Forms.Label()
		PnlButtons = New System.Windows.Forms.Panel()
		Cmd7 = New System.Windows.Forms.Button()
		Cmd6 = New System.Windows.Forms.Button()
		Cmd5 = New System.Windows.Forms.Button()
		Cmd4 = New System.Windows.Forms.Button()
		Cmd3 = New System.Windows.Forms.Button()
		Cmd2 = New System.Windows.Forms.Button()
		Cmd1 = New System.Windows.Forms.Button()
		PnlStatus = New System.Windows.Forms.Panel()
		GrpComputer = New System.Windows.Forms.GroupBox()
		LblComputerTime = New System.Windows.Forms.Label()
		LblComputerLastMove = New System.Windows.Forms.Label()
		LblComputerScore = New System.Windows.Forms.Label()
		LblComputerTimeLbl = New System.Windows.Forms.Label()
		LblComputerLastMoveLbl = New System.Windows.Forms.Label()
		LblComputerScoreLbl = New System.Windows.Forms.Label()
		GrpPlayer = New System.Windows.Forms.GroupBox()
		LblPlayerTime = New System.Windows.Forms.Label()
		LblPlayerLastMove = New System.Windows.Forms.Label()
		LblPlayerScore = New System.Windows.Forms.Label()
		LblPlayerTimeLbl = New System.Windows.Forms.Label()
		LblPlayerLastMoveLbl = New System.Windows.Forms.Label()
		LblPlayerScoreLbl = New System.Windows.Forms.Label()
		TxtStatus = New System.Windows.Forms.TextBox()
		PnlPawns.SuspendLayout()
		PnlButtons.SuspendLayout()
		PnlStatus.SuspendLayout()
		GrpComputer.SuspendLayout()
		GrpPlayer.SuspendLayout()
		SuspendLayout()
		'
		'MnuMain
		'
		MnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MnuGame, MnuHelp})
		'
		'MnuGame
		'
		MnuGame.Index = 0
		MnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MnuGameNew, MnuGameSeperator1, MnuGameExit})
		MnuGame.Text = "&Game"
		'
		'MnuGameNew
		'
		MnuGameNew.Index = 0
		MnuGameNew.Shortcut = Shortcut.F2
		MnuGameNew.Text = "&New"
		'
		'MnuGameSeperator1
		'
		MnuGameSeperator1.Index = 1
		MnuGameSeperator1.Text = "-"
		'
		'MnuGameExit
		'
		MnuGameExit.Index = 2
		MnuGameExit.Shortcut = Shortcut.AltF4
		MnuGameExit.Text = "E&xit"
		'
		'MnuHelp
		'
		MnuHelp.Index = 1
		MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MnuHelpHowTo, MnuHelpHint, MnuHelpSeperator1, MnuHelpAbout})
		MnuHelp.Text = "&Help"
		'
		'MnuHelpHowTo
		'
		MnuHelpHowTo.Index = 0
		MnuHelpHowTo.Shortcut = Shortcut.F1
		MnuHelpHowTo.Text = "How &To..."
		'
		'MnuHelpHint
		'
		MnuHelpHint.Index = 1
		MnuHelpHint.Shortcut = Shortcut.ShiftF1
		MnuHelpHint.Text = "&Show AI Thinking"
		'
		'MnuHelpSeperator1
		'
		MnuHelpSeperator1.Index = 2
		MnuHelpSeperator1.Text = "-"
		'
		'MnuHelpAbout
		'
		MnuHelpAbout.Index = 3
		MnuHelpAbout.Shortcut = Shortcut.AltF1
		MnuHelpAbout.Text = "&About 4Play..."
		'
		'TmrUpdate
		'
		TmrUpdate.Enabled = True
		'
		'PnlPawns
		'
		PnlPawns.BorderStyle = BorderStyle.Fixed3D
		PnlPawns.Controls.Add(Lbl6_5)
		PnlPawns.Controls.Add(Lbl6_4)
		PnlPawns.Controls.Add(Lbl6_3)
		PnlPawns.Controls.Add(Lbl6_2)
		PnlPawns.Controls.Add(Lbl6_1)
		PnlPawns.Controls.Add(Lbl6_0)
		PnlPawns.Controls.Add(Lbl5_5)
		PnlPawns.Controls.Add(Lbl5_4)
		PnlPawns.Controls.Add(Lbl5_3)
		PnlPawns.Controls.Add(Lbl5_2)
		PnlPawns.Controls.Add(Lbl5_1)
		PnlPawns.Controls.Add(Lbl5_0)
		PnlPawns.Controls.Add(Lbl4_5)
		PnlPawns.Controls.Add(Lbl4_4)
		PnlPawns.Controls.Add(Lbl4_3)
		PnlPawns.Controls.Add(Lbl4_2)
		PnlPawns.Controls.Add(Lbl4_1)
		PnlPawns.Controls.Add(Lbl4_0)
		PnlPawns.Controls.Add(Lbl3_5)
		PnlPawns.Controls.Add(Lbl3_4)
		PnlPawns.Controls.Add(Lbl3_3)
		PnlPawns.Controls.Add(Lbl3_2)
		PnlPawns.Controls.Add(Lbl3_1)
		PnlPawns.Controls.Add(Lbl3_0)
		PnlPawns.Controls.Add(Lbl2_5)
		PnlPawns.Controls.Add(Lbl2_4)
		PnlPawns.Controls.Add(Lbl2_3)
		PnlPawns.Controls.Add(Lbl2_2)
		PnlPawns.Controls.Add(Lbl2_1)
		PnlPawns.Controls.Add(Lbl2_0)
		PnlPawns.Controls.Add(Lbl1_5)
		PnlPawns.Controls.Add(Lbl1_4)
		PnlPawns.Controls.Add(Lbl1_3)
		PnlPawns.Controls.Add(Lbl1_2)
		PnlPawns.Controls.Add(Lbl1_1)
		PnlPawns.Controls.Add(Lbl1_0)
		PnlPawns.Controls.Add(Lbl0_5)
		PnlPawns.Controls.Add(Lbl0_4)
		PnlPawns.Controls.Add(Lbl0_3)
		PnlPawns.Controls.Add(Lbl0_2)
		PnlPawns.Controls.Add(Lbl0_1)
		PnlPawns.Controls.Add(Lbl0_0)
		PnlPawns.Location = New System.Drawing.Point(8, 8)
		PnlPawns.Name = "PnlPawns"
		PnlPawns.Size = New System.Drawing.Size(292, 252)
		PnlPawns.TabIndex = 0
		'
		'Lbl6_5
		'
		Lbl6_5.BackColor = Color.Blue
		Lbl6_5.BorderStyle = BorderStyle.Fixed3D
		Lbl6_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl6_5.ForeColor = Color.Yellow
		Lbl6_5.Location = New System.Drawing.Point(248, 8)
		Lbl6_5.Name = "Lbl6_5"
		Lbl6_5.Size = New System.Drawing.Size(32, 32)
		Lbl6_5.TabIndex = 41
		Lbl6_5.Text = "n"
		Lbl6_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl6_5.UseMnemonic = False
		'
		'Lbl6_4
		'
		Lbl6_4.BackColor = Color.Blue
		Lbl6_4.BorderStyle = BorderStyle.Fixed3D
		Lbl6_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl6_4.ForeColor = Color.Red
		Lbl6_4.Location = New System.Drawing.Point(248, 48)
		Lbl6_4.Name = "Lbl6_4"
		Lbl6_4.Size = New System.Drawing.Size(32, 32)
		Lbl6_4.TabIndex = 40
		Lbl6_4.Text = "n"
		Lbl6_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl6_4.UseMnemonic = False
		'
		'Lbl6_3
		'
		Lbl6_3.BackColor = Color.Blue
		Lbl6_3.BorderStyle = BorderStyle.Fixed3D
		Lbl6_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl6_3.ForeColor = Color.Yellow
		Lbl6_3.Location = New System.Drawing.Point(248, 88)
		Lbl6_3.Name = "Lbl6_3"
		Lbl6_3.Size = New System.Drawing.Size(32, 32)
		Lbl6_3.TabIndex = 39
		Lbl6_3.Text = "n"
		Lbl6_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl6_3.UseMnemonic = False
		'
		'Lbl6_2
		'
		Lbl6_2.BackColor = Color.Blue
		Lbl6_2.BorderStyle = BorderStyle.Fixed3D
		Lbl6_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl6_2.ForeColor = Color.Red
		Lbl6_2.Location = New System.Drawing.Point(248, 128)
		Lbl6_2.Name = "Lbl6_2"
		Lbl6_2.Size = New System.Drawing.Size(32, 32)
		Lbl6_2.TabIndex = 38
		Lbl6_2.Text = "n"
		Lbl6_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl6_2.UseMnemonic = False
		'
		'Lbl6_1
		'
		Lbl6_1.BackColor = Color.Blue
		Lbl6_1.BorderStyle = BorderStyle.Fixed3D
		Lbl6_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl6_1.ForeColor = Color.Yellow
		Lbl6_1.Location = New System.Drawing.Point(248, 168)
		Lbl6_1.Name = "Lbl6_1"
		Lbl6_1.Size = New System.Drawing.Size(32, 32)
		Lbl6_1.TabIndex = 37
		Lbl6_1.Text = "n"
		Lbl6_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl6_1.UseMnemonic = False
		'
		'Lbl6_0
		'
		Lbl6_0.BackColor = Color.Blue
		Lbl6_0.BorderStyle = BorderStyle.Fixed3D
		Lbl6_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl6_0.ForeColor = Color.Red
		Lbl6_0.Location = New System.Drawing.Point(248, 208)
		Lbl6_0.Name = "Lbl6_0"
		Lbl6_0.Size = New System.Drawing.Size(32, 32)
		Lbl6_0.TabIndex = 36
		Lbl6_0.Text = "n"
		Lbl6_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl6_0.UseMnemonic = False
		'
		'Lbl5_5
		'
		Lbl5_5.BackColor = Color.Blue
		Lbl5_5.BorderStyle = BorderStyle.Fixed3D
		Lbl5_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl5_5.ForeColor = Color.Yellow
		Lbl5_5.Location = New System.Drawing.Point(208, 8)
		Lbl5_5.Name = "Lbl5_5"
		Lbl5_5.Size = New System.Drawing.Size(32, 32)
		Lbl5_5.TabIndex = 35
		Lbl5_5.Text = "n"
		Lbl5_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl5_5.UseMnemonic = False
		'
		'Lbl5_4
		'
		Lbl5_4.BackColor = Color.Blue
		Lbl5_4.BorderStyle = BorderStyle.Fixed3D
		Lbl5_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl5_4.ForeColor = Color.Red
		Lbl5_4.Location = New System.Drawing.Point(208, 48)
		Lbl5_4.Name = "Lbl5_4"
		Lbl5_4.Size = New System.Drawing.Size(32, 32)
		Lbl5_4.TabIndex = 34
		Lbl5_4.Text = "n"
		Lbl5_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl5_4.UseMnemonic = False
		'
		'Lbl5_3
		'
		Lbl5_3.BackColor = Color.Blue
		Lbl5_3.BorderStyle = BorderStyle.Fixed3D
		Lbl5_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl5_3.ForeColor = Color.Yellow
		Lbl5_3.Location = New System.Drawing.Point(208, 88)
		Lbl5_3.Name = "Lbl5_3"
		Lbl5_3.Size = New System.Drawing.Size(32, 32)
		Lbl5_3.TabIndex = 33
		Lbl5_3.Text = "n"
		Lbl5_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl5_3.UseMnemonic = False
		'
		'Lbl5_2
		'
		Lbl5_2.BackColor = Color.Blue
		Lbl5_2.BorderStyle = BorderStyle.Fixed3D
		Lbl5_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl5_2.ForeColor = Color.Red
		Lbl5_2.Location = New System.Drawing.Point(208, 128)
		Lbl5_2.Name = "Lbl5_2"
		Lbl5_2.Size = New System.Drawing.Size(32, 32)
		Lbl5_2.TabIndex = 32
		Lbl5_2.Text = "n"
		Lbl5_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl5_2.UseMnemonic = False
		'
		'Lbl5_1
		'
		Lbl5_1.BackColor = Color.Blue
		Lbl5_1.BorderStyle = BorderStyle.Fixed3D
		Lbl5_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl5_1.ForeColor = Color.Yellow
		Lbl5_1.Location = New System.Drawing.Point(208, 168)
		Lbl5_1.Name = "Lbl5_1"
		Lbl5_1.Size = New System.Drawing.Size(32, 32)
		Lbl5_1.TabIndex = 31
		Lbl5_1.Text = "n"
		Lbl5_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl5_1.UseMnemonic = False
		'
		'Lbl5_0
		'
		Lbl5_0.BackColor = Color.Blue
		Lbl5_0.BorderStyle = BorderStyle.Fixed3D
		Lbl5_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl5_0.ForeColor = Color.Red
		Lbl5_0.Location = New System.Drawing.Point(208, 208)
		Lbl5_0.Name = "Lbl5_0"
		Lbl5_0.Size = New System.Drawing.Size(32, 32)
		Lbl5_0.TabIndex = 30
		Lbl5_0.Text = "n"
		Lbl5_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl5_0.UseMnemonic = False
		'
		'Lbl4_5
		'
		Lbl4_5.BackColor = Color.Blue
		Lbl4_5.BorderStyle = BorderStyle.Fixed3D
		Lbl4_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl4_5.ForeColor = Color.Yellow
		Lbl4_5.Location = New System.Drawing.Point(168, 8)
		Lbl4_5.Name = "Lbl4_5"
		Lbl4_5.Size = New System.Drawing.Size(32, 32)
		Lbl4_5.TabIndex = 29
		Lbl4_5.Text = "n"
		Lbl4_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl4_5.UseMnemonic = False
		'
		'Lbl4_4
		'
		Lbl4_4.BackColor = Color.Blue
		Lbl4_4.BorderStyle = BorderStyle.Fixed3D
		Lbl4_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl4_4.ForeColor = Color.Red
		Lbl4_4.Location = New System.Drawing.Point(168, 48)
		Lbl4_4.Name = "Lbl4_4"
		Lbl4_4.Size = New System.Drawing.Size(32, 32)
		Lbl4_4.TabIndex = 28
		Lbl4_4.Text = "n"
		Lbl4_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl4_4.UseMnemonic = False
		'
		'Lbl4_3
		'
		Lbl4_3.BackColor = Color.Blue
		Lbl4_3.BorderStyle = BorderStyle.Fixed3D
		Lbl4_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl4_3.ForeColor = Color.Yellow
		Lbl4_3.Location = New System.Drawing.Point(168, 88)
		Lbl4_3.Name = "Lbl4_3"
		Lbl4_3.Size = New System.Drawing.Size(32, 32)
		Lbl4_3.TabIndex = 27
		Lbl4_3.Text = "n"
		Lbl4_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl4_3.UseMnemonic = False
		'
		'Lbl4_2
		'
		Lbl4_2.BackColor = Color.Blue
		Lbl4_2.BorderStyle = BorderStyle.Fixed3D
		Lbl4_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl4_2.ForeColor = Color.Red
		Lbl4_2.Location = New System.Drawing.Point(168, 128)
		Lbl4_2.Name = "Lbl4_2"
		Lbl4_2.Size = New System.Drawing.Size(32, 32)
		Lbl4_2.TabIndex = 26
		Lbl4_2.Text = "n"
		Lbl4_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl4_2.UseMnemonic = False
		'
		'Lbl4_1
		'
		Lbl4_1.BackColor = Color.Blue
		Lbl4_1.BorderStyle = BorderStyle.Fixed3D
		Lbl4_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl4_1.ForeColor = Color.Yellow
		Lbl4_1.Location = New System.Drawing.Point(168, 168)
		Lbl4_1.Name = "Lbl4_1"
		Lbl4_1.Size = New System.Drawing.Size(32, 32)
		Lbl4_1.TabIndex = 25
		Lbl4_1.Text = "n"
		Lbl4_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl4_1.UseMnemonic = False
		'
		'Lbl4_0
		'
		Lbl4_0.BackColor = Color.Blue
		Lbl4_0.BorderStyle = BorderStyle.Fixed3D
		Lbl4_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl4_0.ForeColor = Color.Red
		Lbl4_0.Location = New System.Drawing.Point(168, 208)
		Lbl4_0.Name = "Lbl4_0"
		Lbl4_0.Size = New System.Drawing.Size(32, 32)
		Lbl4_0.TabIndex = 24
		Lbl4_0.Text = "n"
		Lbl4_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl4_0.UseMnemonic = False
		'
		'Lbl3_5
		'
		Lbl3_5.BackColor = Color.Blue
		Lbl3_5.BorderStyle = BorderStyle.Fixed3D
		Lbl3_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl3_5.ForeColor = Color.Yellow
		Lbl3_5.Location = New System.Drawing.Point(128, 8)
		Lbl3_5.Name = "Lbl3_5"
		Lbl3_5.Size = New System.Drawing.Size(32, 32)
		Lbl3_5.TabIndex = 23
		Lbl3_5.Text = "n"
		Lbl3_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl3_5.UseMnemonic = False
		'
		'Lbl3_4
		'
		Lbl3_4.BackColor = Color.Blue
		Lbl3_4.BorderStyle = BorderStyle.Fixed3D
		Lbl3_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl3_4.ForeColor = Color.Red
		Lbl3_4.Location = New System.Drawing.Point(128, 48)
		Lbl3_4.Name = "Lbl3_4"
		Lbl3_4.Size = New System.Drawing.Size(32, 32)
		Lbl3_4.TabIndex = 22
		Lbl3_4.Text = "n"
		Lbl3_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl3_4.UseMnemonic = False
		'
		'Lbl3_3
		'
		Lbl3_3.BackColor = Color.Blue
		Lbl3_3.BorderStyle = BorderStyle.Fixed3D
		Lbl3_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl3_3.ForeColor = Color.Yellow
		Lbl3_3.Location = New System.Drawing.Point(128, 88)
		Lbl3_3.Name = "Lbl3_3"
		Lbl3_3.Size = New System.Drawing.Size(32, 32)
		Lbl3_3.TabIndex = 21
		Lbl3_3.Text = "n"
		Lbl3_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl3_3.UseMnemonic = False
		'
		'Lbl3_2
		'
		Lbl3_2.BackColor = Color.Blue
		Lbl3_2.BorderStyle = BorderStyle.Fixed3D
		Lbl3_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl3_2.ForeColor = Color.Red
		Lbl3_2.Location = New System.Drawing.Point(128, 128)
		Lbl3_2.Name = "Lbl3_2"
		Lbl3_2.Size = New System.Drawing.Size(32, 32)
		Lbl3_2.TabIndex = 20
		Lbl3_2.Text = "n"
		Lbl3_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl3_2.UseMnemonic = False
		'
		'Lbl3_1
		'
		Lbl3_1.BackColor = Color.Blue
		Lbl3_1.BorderStyle = BorderStyle.Fixed3D
		Lbl3_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl3_1.ForeColor = Color.Yellow
		Lbl3_1.Location = New System.Drawing.Point(128, 168)
		Lbl3_1.Name = "Lbl3_1"
		Lbl3_1.Size = New System.Drawing.Size(32, 32)
		Lbl3_1.TabIndex = 19
		Lbl3_1.Text = "n"
		Lbl3_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl3_1.UseMnemonic = False
		'
		'Lbl3_0
		'
		Lbl3_0.BackColor = Color.Blue
		Lbl3_0.BorderStyle = BorderStyle.Fixed3D
		Lbl3_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl3_0.ForeColor = Color.Red
		Lbl3_0.Location = New System.Drawing.Point(128, 208)
		Lbl3_0.Name = "Lbl3_0"
		Lbl3_0.Size = New System.Drawing.Size(32, 32)
		Lbl3_0.TabIndex = 18
		Lbl3_0.Text = "n"
		Lbl3_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl3_0.UseMnemonic = False
		'
		'Lbl2_5
		'
		Lbl2_5.BackColor = Color.Blue
		Lbl2_5.BorderStyle = BorderStyle.Fixed3D
		Lbl2_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl2_5.ForeColor = Color.Yellow
		Lbl2_5.Location = New System.Drawing.Point(88, 8)
		Lbl2_5.Name = "Lbl2_5"
		Lbl2_5.Size = New System.Drawing.Size(32, 32)
		Lbl2_5.TabIndex = 17
		Lbl2_5.Text = "n"
		Lbl2_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl2_5.UseMnemonic = False
		'
		'Lbl2_4
		'
		Lbl2_4.BackColor = Color.Blue
		Lbl2_4.BorderStyle = BorderStyle.Fixed3D
		Lbl2_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl2_4.ForeColor = Color.Red
		Lbl2_4.Location = New System.Drawing.Point(88, 48)
		Lbl2_4.Name = "Lbl2_4"
		Lbl2_4.Size = New System.Drawing.Size(32, 32)
		Lbl2_4.TabIndex = 16
		Lbl2_4.Text = "n"
		Lbl2_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl2_4.UseMnemonic = False
		'
		'Lbl2_3
		'
		Lbl2_3.BackColor = Color.Blue
		Lbl2_3.BorderStyle = BorderStyle.Fixed3D
		Lbl2_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl2_3.ForeColor = Color.Yellow
		Lbl2_3.Location = New System.Drawing.Point(88, 88)
		Lbl2_3.Name = "Lbl2_3"
		Lbl2_3.Size = New System.Drawing.Size(32, 32)
		Lbl2_3.TabIndex = 15
		Lbl2_3.Text = "n"
		Lbl2_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl2_3.UseMnemonic = False
		'
		'Lbl2_2
		'
		Lbl2_2.BackColor = Color.Blue
		Lbl2_2.BorderStyle = BorderStyle.Fixed3D
		Lbl2_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl2_2.ForeColor = Color.Red
		Lbl2_2.Location = New System.Drawing.Point(88, 128)
		Lbl2_2.Name = "Lbl2_2"
		Lbl2_2.Size = New System.Drawing.Size(32, 32)
		Lbl2_2.TabIndex = 14
		Lbl2_2.Text = "n"
		Lbl2_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl2_2.UseMnemonic = False
		'
		'Lbl2_1
		'
		Lbl2_1.BackColor = Color.Blue
		Lbl2_1.BorderStyle = BorderStyle.Fixed3D
		Lbl2_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl2_1.ForeColor = Color.Yellow
		Lbl2_1.Location = New System.Drawing.Point(88, 168)
		Lbl2_1.Name = "Lbl2_1"
		Lbl2_1.Size = New System.Drawing.Size(32, 32)
		Lbl2_1.TabIndex = 13
		Lbl2_1.Text = "n"
		Lbl2_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl2_1.UseMnemonic = False
		'
		'Lbl2_0
		'
		Lbl2_0.BackColor = Color.Blue
		Lbl2_0.BorderStyle = BorderStyle.Fixed3D
		Lbl2_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl2_0.ForeColor = Color.Red
		Lbl2_0.Location = New System.Drawing.Point(88, 208)
		Lbl2_0.Name = "Lbl2_0"
		Lbl2_0.Size = New System.Drawing.Size(32, 32)
		Lbl2_0.TabIndex = 12
		Lbl2_0.Text = "n"
		Lbl2_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl2_0.UseMnemonic = False
		'
		'Lbl1_5
		'
		Lbl1_5.BackColor = Color.Blue
		Lbl1_5.BorderStyle = BorderStyle.Fixed3D
		Lbl1_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl1_5.ForeColor = Color.Yellow
		Lbl1_5.Location = New System.Drawing.Point(48, 8)
		Lbl1_5.Name = "Lbl1_5"
		Lbl1_5.Size = New System.Drawing.Size(32, 32)
		Lbl1_5.TabIndex = 11
		Lbl1_5.Text = "n"
		Lbl1_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl1_5.UseMnemonic = False
		'
		'Lbl1_4
		'
		Lbl1_4.BackColor = Color.Blue
		Lbl1_4.BorderStyle = BorderStyle.Fixed3D
		Lbl1_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl1_4.ForeColor = Color.Red
		Lbl1_4.Location = New System.Drawing.Point(48, 48)
		Lbl1_4.Name = "Lbl1_4"
		Lbl1_4.Size = New System.Drawing.Size(32, 32)
		Lbl1_4.TabIndex = 10
		Lbl1_4.Text = "n"
		Lbl1_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl1_4.UseMnemonic = False
		'
		'Lbl1_3
		'
		Lbl1_3.BackColor = Color.Blue
		Lbl1_3.BorderStyle = BorderStyle.Fixed3D
		Lbl1_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl1_3.ForeColor = Color.Yellow
		Lbl1_3.Location = New System.Drawing.Point(48, 88)
		Lbl1_3.Name = "Lbl1_3"
		Lbl1_3.Size = New System.Drawing.Size(32, 32)
		Lbl1_3.TabIndex = 9
		Lbl1_3.Text = "n"
		Lbl1_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl1_3.UseMnemonic = False
		'
		'Lbl1_2
		'
		Lbl1_2.BackColor = Color.Blue
		Lbl1_2.BorderStyle = BorderStyle.Fixed3D
		Lbl1_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl1_2.ForeColor = Color.Red
		Lbl1_2.Location = New System.Drawing.Point(48, 128)
		Lbl1_2.Name = "Lbl1_2"
		Lbl1_2.Size = New System.Drawing.Size(32, 32)
		Lbl1_2.TabIndex = 8
		Lbl1_2.Text = "n"
		Lbl1_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl1_2.UseMnemonic = False
		'
		'Lbl1_1
		'
		Lbl1_1.BackColor = Color.Blue
		Lbl1_1.BorderStyle = BorderStyle.Fixed3D
		Lbl1_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl1_1.ForeColor = Color.Yellow
		Lbl1_1.Location = New System.Drawing.Point(48, 168)
		Lbl1_1.Name = "Lbl1_1"
		Lbl1_1.Size = New System.Drawing.Size(32, 32)
		Lbl1_1.TabIndex = 7
		Lbl1_1.Text = "n"
		Lbl1_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl1_1.UseMnemonic = False
		'
		'Lbl1_0
		'
		Lbl1_0.BackColor = Color.Blue
		Lbl1_0.BorderStyle = BorderStyle.Fixed3D
		Lbl1_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl1_0.ForeColor = Color.Red
		Lbl1_0.Location = New System.Drawing.Point(48, 208)
		Lbl1_0.Name = "Lbl1_0"
		Lbl1_0.Size = New System.Drawing.Size(32, 32)
		Lbl1_0.TabIndex = 6
		Lbl1_0.Text = "n"
		Lbl1_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl1_0.UseMnemonic = False
		'
		'Lbl0_5
		'
		Lbl0_5.BackColor = Color.Blue
		Lbl0_5.BorderStyle = BorderStyle.Fixed3D
		Lbl0_5.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl0_5.ForeColor = Color.Yellow
		Lbl0_5.Location = New System.Drawing.Point(8, 8)
		Lbl0_5.Name = "Lbl0_5"
		Lbl0_5.Size = New System.Drawing.Size(32, 32)
		Lbl0_5.TabIndex = 5
		Lbl0_5.Text = "n"
		Lbl0_5.TextAlign = ContentAlignment.MiddleCenter
		Lbl0_5.UseMnemonic = False
		'
		'Lbl0_4
		'
		Lbl0_4.BackColor = Color.Blue
		Lbl0_4.BorderStyle = BorderStyle.Fixed3D
		Lbl0_4.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl0_4.ForeColor = Color.Red
		Lbl0_4.Location = New System.Drawing.Point(8, 48)
		Lbl0_4.Name = "Lbl0_4"
		Lbl0_4.Size = New System.Drawing.Size(32, 32)
		Lbl0_4.TabIndex = 4
		Lbl0_4.Text = "n"
		Lbl0_4.TextAlign = ContentAlignment.MiddleCenter
		Lbl0_4.UseMnemonic = False
		'
		'Lbl0_3
		'
		Lbl0_3.BackColor = Color.Blue
		Lbl0_3.BorderStyle = BorderStyle.Fixed3D
		Lbl0_3.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl0_3.ForeColor = Color.Yellow
		Lbl0_3.Location = New System.Drawing.Point(8, 88)
		Lbl0_3.Name = "Lbl0_3"
		Lbl0_3.Size = New System.Drawing.Size(32, 32)
		Lbl0_3.TabIndex = 3
		Lbl0_3.Text = "n"
		Lbl0_3.TextAlign = ContentAlignment.MiddleCenter
		Lbl0_3.UseMnemonic = False
		'
		'Lbl0_2
		'
		Lbl0_2.BackColor = Color.Blue
		Lbl0_2.BorderStyle = BorderStyle.Fixed3D
		Lbl0_2.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl0_2.ForeColor = Color.Red
		Lbl0_2.Location = New System.Drawing.Point(8, 128)
		Lbl0_2.Name = "Lbl0_2"
		Lbl0_2.Size = New System.Drawing.Size(32, 32)
		Lbl0_2.TabIndex = 2
		Lbl0_2.Text = "n"
		Lbl0_2.TextAlign = ContentAlignment.MiddleCenter
		Lbl0_2.UseMnemonic = False
		'
		'Lbl0_1
		'
		Lbl0_1.BackColor = Color.Blue
		Lbl0_1.BorderStyle = BorderStyle.Fixed3D
		Lbl0_1.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl0_1.ForeColor = Color.Yellow
		Lbl0_1.Location = New System.Drawing.Point(8, 168)
		Lbl0_1.Name = "Lbl0_1"
		Lbl0_1.Size = New System.Drawing.Size(32, 32)
		Lbl0_1.TabIndex = 1
		Lbl0_1.Text = "n"
		Lbl0_1.TextAlign = ContentAlignment.MiddleCenter
		Lbl0_1.UseMnemonic = False
		'
		'Lbl0_0
		'
		Lbl0_0.BackColor = Color.Blue
		Lbl0_0.BorderStyle = BorderStyle.Fixed3D
		Lbl0_0.Font = New System.Drawing.Font("Webdings", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(2, Byte))
		Lbl0_0.ForeColor = Color.Red
		Lbl0_0.Location = New System.Drawing.Point(8, 208)
		Lbl0_0.Name = "Lbl0_0"
		Lbl0_0.Size = New System.Drawing.Size(32, 32)
		Lbl0_0.TabIndex = 0
		Lbl0_0.Text = "n"
		Lbl0_0.TextAlign = ContentAlignment.MiddleCenter
		Lbl0_0.UseMnemonic = False
		'
		'PnlButtons
		'
		PnlButtons.BorderStyle = BorderStyle.Fixed3D
		PnlButtons.Controls.Add(Cmd7)
		PnlButtons.Controls.Add(Cmd6)
		PnlButtons.Controls.Add(Cmd5)
		PnlButtons.Controls.Add(Cmd4)
		PnlButtons.Controls.Add(Cmd3)
		PnlButtons.Controls.Add(Cmd2)
		PnlButtons.Controls.Add(Cmd1)
		PnlButtons.Location = New System.Drawing.Point(8, 268)
		PnlButtons.Name = "PnlButtons"
		PnlButtons.Size = New System.Drawing.Size(292, 52)
		PnlButtons.TabIndex = 1
		'
		'Cmd7
		'
		Cmd7.FlatStyle = FlatStyle.System
		Cmd7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd7.Location = New System.Drawing.Point(248, 8)
		Cmd7.Name = "Cmd7"
		Cmd7.Size = New System.Drawing.Size(32, 32)
		Cmd7.TabIndex = 6
		Cmd7.Tag = "6"
		Cmd7.Text = "&7"
		'
		'Cmd6
		'
		Cmd6.FlatStyle = FlatStyle.System
		Cmd6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd6.Location = New System.Drawing.Point(208, 8)
		Cmd6.Name = "Cmd6"
		Cmd6.Size = New System.Drawing.Size(32, 32)
		Cmd6.TabIndex = 5
		Cmd6.Tag = "5"
		Cmd6.Text = "&6"
		'
		'Cmd5
		'
		Cmd5.FlatStyle = FlatStyle.System
		Cmd5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd5.Location = New System.Drawing.Point(168, 8)
		Cmd5.Name = "Cmd5"
		Cmd5.Size = New System.Drawing.Size(32, 32)
		Cmd5.TabIndex = 4
		Cmd5.Tag = "4"
		Cmd5.Text = "&5"
		'
		'Cmd4
		'
		Cmd4.FlatStyle = FlatStyle.System
		Cmd4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd4.Location = New System.Drawing.Point(128, 8)
		Cmd4.Name = "Cmd4"
		Cmd4.Size = New System.Drawing.Size(32, 32)
		Cmd4.TabIndex = 3
		Cmd4.Tag = "3"
		Cmd4.Text = "&4"
		'
		'Cmd3
		'
		Cmd3.FlatStyle = FlatStyle.System
		Cmd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd3.Location = New System.Drawing.Point(88, 8)
		Cmd3.Name = "Cmd3"
		Cmd3.Size = New System.Drawing.Size(32, 32)
		Cmd3.TabIndex = 2
		Cmd3.Tag = "2"
		Cmd3.Text = "&3"
		'
		'Cmd2
		'
		Cmd2.FlatStyle = FlatStyle.System
		Cmd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd2.Location = New System.Drawing.Point(48, 8)
		Cmd2.Name = "Cmd2"
		Cmd2.Size = New System.Drawing.Size(32, 32)
		Cmd2.TabIndex = 1
		Cmd2.Tag = "1"
		Cmd2.Text = "&2"
		'
		'Cmd1
		'
		Cmd1.FlatStyle = FlatStyle.System
		Cmd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		Cmd1.Location = New System.Drawing.Point(8, 8)
		Cmd1.Name = "Cmd1"
		Cmd1.Size = New System.Drawing.Size(32, 32)
		Cmd1.TabIndex = 0
		Cmd1.Tag = "0"
		Cmd1.Text = "&1"
		'
		'PnlStatus
		'
		PnlStatus.BorderStyle = BorderStyle.Fixed3D
		PnlStatus.Controls.Add(GrpComputer)
		PnlStatus.Controls.Add(GrpPlayer)
		PnlStatus.Location = New System.Drawing.Point(308, 8)
		PnlStatus.Name = "PnlStatus"
		PnlStatus.Size = New System.Drawing.Size(188, 228)
		PnlStatus.TabIndex = 2
		'
		'GrpComputer
		'
		GrpComputer.Controls.Add(LblComputerTime)
		GrpComputer.Controls.Add(LblComputerLastMove)
		GrpComputer.Controls.Add(LblComputerScore)
		GrpComputer.Controls.Add(LblComputerTimeLbl)
		GrpComputer.Controls.Add(LblComputerLastMoveLbl)
		GrpComputer.Controls.Add(LblComputerScoreLbl)
		GrpComputer.FlatStyle = FlatStyle.System
		GrpComputer.Location = New System.Drawing.Point(8, 116)
		GrpComputer.Name = "GrpComputer"
		GrpComputer.Size = New System.Drawing.Size(168, 100)
		GrpComputer.TabIndex = 1
		GrpComputer.TabStop = False
		GrpComputer.Text = "Computer (Yellow)"
		'
		'LblComputerTime
		'
		LblComputerTime.AutoSize = True
		LblComputerTime.Location = New System.Drawing.Point(104, 72)
		LblComputerTime.Name = "LblComputerTime"
		LblComputerTime.Size = New System.Drawing.Size(49, 13)
		LblComputerTime.TabIndex = 5
		LblComputerTime.Text = "00:00:00"
		LblComputerTime.UseMnemonic = False
		'
		'LblComputerLastMove
		'
		LblComputerLastMove.AutoSize = True
		LblComputerLastMove.Location = New System.Drawing.Point(104, 48)
		LblComputerLastMove.Name = "LblComputerLastMove"
		LblComputerLastMove.Size = New System.Drawing.Size(13, 13)
		LblComputerLastMove.TabIndex = 3
		LblComputerLastMove.Text = "0"
		LblComputerLastMove.UseMnemonic = False
		'
		'LblComputerScore
		'
		LblComputerScore.AutoSize = True
		LblComputerScore.Location = New System.Drawing.Point(104, 24)
		LblComputerScore.Name = "LblComputerScore"
		LblComputerScore.Size = New System.Drawing.Size(13, 13)
		LblComputerScore.TabIndex = 1
		LblComputerScore.Text = "0"
		LblComputerScore.UseMnemonic = False
		'
		'LblComputerTimeLbl
		'
		LblComputerTimeLbl.AutoSize = True
		LblComputerTimeLbl.Location = New System.Drawing.Point(36, 72)
		LblComputerTimeLbl.Name = "LblComputerTimeLbl"
		LblComputerTimeLbl.Size = New System.Drawing.Size(33, 13)
		LblComputerTimeLbl.TabIndex = 4
		LblComputerTimeLbl.Text = "Time:"
		LblComputerTimeLbl.UseMnemonic = False
		'
		'LblComputerLastMoveLbl
		'
		LblComputerLastMoveLbl.AutoSize = True
		LblComputerLastMoveLbl.Location = New System.Drawing.Point(12, 48)
		LblComputerLastMoveLbl.Name = "LblComputerLastMoveLbl"
		LblComputerLastMoveLbl.Size = New System.Drawing.Size(60, 13)
		LblComputerLastMoveLbl.TabIndex = 2
		LblComputerLastMoveLbl.Text = "Last Move:"
		LblComputerLastMoveLbl.UseMnemonic = False
		'
		'LblComputerScoreLbl
		'
		LblComputerScoreLbl.AutoSize = True
		LblComputerScoreLbl.Location = New System.Drawing.Point(32, 24)
		LblComputerScoreLbl.Name = "LblComputerScoreLbl"
		LblComputerScoreLbl.Size = New System.Drawing.Size(38, 13)
		LblComputerScoreLbl.TabIndex = 0
		LblComputerScoreLbl.Text = "Score:"
		LblComputerScoreLbl.UseMnemonic = False
		'
		'GrpPlayer
		'
		GrpPlayer.Controls.Add(LblPlayerTime)
		GrpPlayer.Controls.Add(LblPlayerLastMove)
		GrpPlayer.Controls.Add(LblPlayerScore)
		GrpPlayer.Controls.Add(LblPlayerTimeLbl)
		GrpPlayer.Controls.Add(LblPlayerLastMoveLbl)
		GrpPlayer.Controls.Add(LblPlayerScoreLbl)
		GrpPlayer.FlatStyle = FlatStyle.System
		GrpPlayer.Location = New System.Drawing.Point(8, 8)
		GrpPlayer.Name = "GrpPlayer"
		GrpPlayer.Size = New System.Drawing.Size(168, 100)
		GrpPlayer.TabIndex = 0
		GrpPlayer.TabStop = False
		GrpPlayer.Text = "Player (Red)"
		'
		'LblPlayerTime
		'
		LblPlayerTime.AutoSize = True
		LblPlayerTime.Location = New System.Drawing.Point(104, 72)
		LblPlayerTime.Name = "LblPlayerTime"
		LblPlayerTime.Size = New System.Drawing.Size(49, 13)
		LblPlayerTime.TabIndex = 5
		LblPlayerTime.Text = "00:00:00"
		LblPlayerTime.UseMnemonic = False
		'
		'LblPlayerLastMove
		'
		LblPlayerLastMove.AutoSize = True
		LblPlayerLastMove.Location = New System.Drawing.Point(104, 48)
		LblPlayerLastMove.Name = "LblPlayerLastMove"
		LblPlayerLastMove.Size = New System.Drawing.Size(13, 13)
		LblPlayerLastMove.TabIndex = 3
		LblPlayerLastMove.Text = "0"
		LblPlayerLastMove.UseMnemonic = False
		'
		'LblPlayerScore
		'
		LblPlayerScore.AutoSize = True
		LblPlayerScore.Location = New System.Drawing.Point(104, 24)
		LblPlayerScore.Name = "LblPlayerScore"
		LblPlayerScore.Size = New System.Drawing.Size(13, 13)
		LblPlayerScore.TabIndex = 1
		LblPlayerScore.Text = "0"
		LblPlayerScore.UseMnemonic = False
		'
		'LblPlayerTimeLbl
		'
		LblPlayerTimeLbl.AutoSize = True
		LblPlayerTimeLbl.Location = New System.Drawing.Point(36, 72)
		LblPlayerTimeLbl.Name = "LblPlayerTimeLbl"
		LblPlayerTimeLbl.Size = New System.Drawing.Size(33, 13)
		LblPlayerTimeLbl.TabIndex = 4
		LblPlayerTimeLbl.Text = "Time:"
		LblPlayerTimeLbl.UseMnemonic = False
		'
		'LblPlayerLastMoveLbl
		'
		LblPlayerLastMoveLbl.AutoSize = True
		LblPlayerLastMoveLbl.Location = New System.Drawing.Point(12, 48)
		LblPlayerLastMoveLbl.Name = "LblPlayerLastMoveLbl"
		LblPlayerLastMoveLbl.Size = New System.Drawing.Size(60, 13)
		LblPlayerLastMoveLbl.TabIndex = 2
		LblPlayerLastMoveLbl.Text = "Last Move:"
		LblPlayerLastMoveLbl.UseMnemonic = False
		'
		'LblPlayerScoreLbl
		'
		LblPlayerScoreLbl.AutoSize = True
		LblPlayerScoreLbl.Location = New System.Drawing.Point(32, 24)
		LblPlayerScoreLbl.Name = "LblPlayerScoreLbl"
		LblPlayerScoreLbl.Size = New System.Drawing.Size(38, 13)
		LblPlayerScoreLbl.TabIndex = 0
		LblPlayerScoreLbl.Text = "Score:"
		LblPlayerScoreLbl.UseMnemonic = False
		'
		'TxtStatus
		'
		TxtStatus.BackColor = Color.Black
		TxtStatus.Font = New System.Drawing.Font("Courier New", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
		TxtStatus.ForeColor = Color.Lime
		TxtStatus.Location = New System.Drawing.Point(308, 244)
		TxtStatus.Multiline = True
		TxtStatus.Name = "TxtStatus"
		TxtStatus.ReadOnly = True
		TxtStatus.ScrollBars = ScrollBars.Vertical
		TxtStatus.Size = New System.Drawing.Size(188, 76)
		TxtStatus.TabIndex = 3
		TxtStatus.TabStop = False
		'
		'FrmMain
		'
		AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		ClientSize = New System.Drawing.Size(504, 327)
		Controls.Add(TxtStatus)
		Controls.Add(PnlStatus)
		Controls.Add(PnlButtons)
		Controls.Add(PnlPawns)
		FormBorderStyle = FormBorderStyle.FixedSingle
		Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		MaximizeBox = False
		Menu = MnuMain
		Name = "FrmMain"
		StartPosition = FormStartPosition.CenterScreen
		Text = "4Play"
		PnlPawns.ResumeLayout(False)
		PnlButtons.ResumeLayout(False)
		PnlStatus.ResumeLayout(False)
		GrpComputer.ResumeLayout(False)
		GrpComputer.PerformLayout()
		GrpPlayer.ResumeLayout(False)
		GrpPlayer.PerformLayout()
		ResumeLayout(False)
		PerformLayout()

	End Sub

#End Region

	Private PlayerTime, ComputerTime As Single
	Private WithEvents GameEngine As New Cls4Play()
	Private PlayerBusy As Boolean = False               ' this is set to true when the player has clicked a column button

	' Our game engine message handler
	Private Sub UpdateStatus(Note As String) Handles GameEngine.ProcessNote
		If TxtStatus.TextLength <= 0 Then
			TxtStatus.AppendText(Note)
		Else
			TxtStatus.AppendText(vbCrLf & Note)
		End If
		TxtStatus.SelectionLength = 0
		TxtStatus.SelectionStart = TxtStatus.TextLength
		TxtStatus.ScrollToCaret()
	End Sub

	' The following function was generated programatically:
	' https://www.onlinegdb.com/online_c_compiler
	'
	' for (int x = 0; x < 7; x++)
	' {
	'	for (int y = 0; y < 6; y++)
	'   {
	'		printf("\nMyChip = GameEngine.Board(%d, %d)\n", x, y);
	'       printf("If myChip = Cls4Play.Player1WinChip Then\n");
	'       printf("    Lbl%d_%d.ForeColor = Color.Red\n", x, y);
	'       printf("    Lbl%d_%d.Text = Chr(&H98)\n", x, y);
	'       printf("ElseIf myChip = Cls4Play.Player2WinChip Then\n");
	'       printf("    Lbl%d_%d.ForeColor = Color.Yellow\n", x, y);
	'       printf("    Lbl%d_%d.Text = Chr(&H98)\n", x, y);
	'       printf("ElseIf myChip = Cls4Play.Player1Chip Then\n");
	'       printf("    Lbl%d_%d.ForeColor = Color.Red\n", x, y);
	'       printf("    Lbl%d_%d.Text = Chr(&H6E)\n", x, y);
	'       printf("ElseIf myChip = Cls4Play.Player2Chip Then\n");
	'       printf("    Lbl%d_%d.ForeColor = Color.Yellow\n", x, y);
	'       printf("    Lbl%d_%d.Text = Chr(&H6E)\n", x, y);
	'       printf("Else\n");
	'       printf("    Lbl%d_%d.Text = vbNullChar\n", x, y);
	'       printf("End If\n");
	'    }
	' }
#Region " DrawChips() [Auto-generated using C] "
	Private Sub DrawChips()
		Dim myChip As Integer


		myChip = GameEngine.Board(0, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl0_0.ForeColor = Color.Red
			Lbl0_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl0_0.ForeColor = Color.Yellow
			Lbl0_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl0_0.ForeColor = Color.Red
			Lbl0_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl0_0.ForeColor = Color.Yellow
			Lbl0_0.Text = Chr(&H6E)
		Else
			Lbl0_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(0, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl0_1.ForeColor = Color.Red
			Lbl0_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl0_1.ForeColor = Color.Yellow
			Lbl0_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl0_1.ForeColor = Color.Red
			Lbl0_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl0_1.ForeColor = Color.Yellow
			Lbl0_1.Text = Chr(&H6E)
		Else
			Lbl0_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(0, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl0_2.ForeColor = Color.Red
			Lbl0_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl0_2.ForeColor = Color.Yellow
			Lbl0_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl0_2.ForeColor = Color.Red
			Lbl0_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl0_2.ForeColor = Color.Yellow
			Lbl0_2.Text = Chr(&H6E)
		Else
			Lbl0_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(0, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl0_3.ForeColor = Color.Red
			Lbl0_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl0_3.ForeColor = Color.Yellow
			Lbl0_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl0_3.ForeColor = Color.Red
			Lbl0_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl0_3.ForeColor = Color.Yellow
			Lbl0_3.Text = Chr(&H6E)
		Else
			Lbl0_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(0, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl0_4.ForeColor = Color.Red
			Lbl0_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl0_4.ForeColor = Color.Yellow
			Lbl0_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl0_4.ForeColor = Color.Red
			Lbl0_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl0_4.ForeColor = Color.Yellow
			Lbl0_4.Text = Chr(&H6E)
		Else
			Lbl0_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(0, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl0_5.ForeColor = Color.Red
			Lbl0_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl0_5.ForeColor = Color.Yellow
			Lbl0_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl0_5.ForeColor = Color.Red
			Lbl0_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl0_5.ForeColor = Color.Yellow
			Lbl0_5.Text = Chr(&H6E)
		Else
			Lbl0_5.Text = vbNullChar
		End If

		myChip = GameEngine.Board(1, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl1_0.ForeColor = Color.Red
			Lbl1_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl1_0.ForeColor = Color.Yellow
			Lbl1_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl1_0.ForeColor = Color.Red
			Lbl1_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl1_0.ForeColor = Color.Yellow
			Lbl1_0.Text = Chr(&H6E)
		Else
			Lbl1_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(1, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl1_1.ForeColor = Color.Red
			Lbl1_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl1_1.ForeColor = Color.Yellow
			Lbl1_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl1_1.ForeColor = Color.Red
			Lbl1_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl1_1.ForeColor = Color.Yellow
			Lbl1_1.Text = Chr(&H6E)
		Else
			Lbl1_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(1, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl1_2.ForeColor = Color.Red
			Lbl1_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl1_2.ForeColor = Color.Yellow
			Lbl1_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl1_2.ForeColor = Color.Red
			Lbl1_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl1_2.ForeColor = Color.Yellow
			Lbl1_2.Text = Chr(&H6E)
		Else
			Lbl1_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(1, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl1_3.ForeColor = Color.Red
			Lbl1_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl1_3.ForeColor = Color.Yellow
			Lbl1_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl1_3.ForeColor = Color.Red
			Lbl1_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl1_3.ForeColor = Color.Yellow
			Lbl1_3.Text = Chr(&H6E)
		Else
			Lbl1_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(1, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl1_4.ForeColor = Color.Red
			Lbl1_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl1_4.ForeColor = Color.Yellow
			Lbl1_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl1_4.ForeColor = Color.Red
			Lbl1_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl1_4.ForeColor = Color.Yellow
			Lbl1_4.Text = Chr(&H6E)
		Else
			Lbl1_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(1, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl1_5.ForeColor = Color.Red
			Lbl1_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl1_5.ForeColor = Color.Yellow
			Lbl1_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl1_5.ForeColor = Color.Red
			Lbl1_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl1_5.ForeColor = Color.Yellow
			Lbl1_5.Text = Chr(&H6E)
		Else
			Lbl1_5.Text = vbNullChar
		End If

		myChip = GameEngine.Board(2, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl2_0.ForeColor = Color.Red
			Lbl2_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl2_0.ForeColor = Color.Yellow
			Lbl2_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl2_0.ForeColor = Color.Red
			Lbl2_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl2_0.ForeColor = Color.Yellow
			Lbl2_0.Text = Chr(&H6E)
		Else
			Lbl2_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(2, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl2_1.ForeColor = Color.Red
			Lbl2_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl2_1.ForeColor = Color.Yellow
			Lbl2_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl2_1.ForeColor = Color.Red
			Lbl2_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl2_1.ForeColor = Color.Yellow
			Lbl2_1.Text = Chr(&H6E)
		Else
			Lbl2_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(2, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl2_2.ForeColor = Color.Red
			Lbl2_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl2_2.ForeColor = Color.Yellow
			Lbl2_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl2_2.ForeColor = Color.Red
			Lbl2_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl2_2.ForeColor = Color.Yellow
			Lbl2_2.Text = Chr(&H6E)
		Else
			Lbl2_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(2, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl2_3.ForeColor = Color.Red
			Lbl2_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl2_3.ForeColor = Color.Yellow
			Lbl2_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl2_3.ForeColor = Color.Red
			Lbl2_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl2_3.ForeColor = Color.Yellow
			Lbl2_3.Text = Chr(&H6E)
		Else
			Lbl2_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(2, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl2_4.ForeColor = Color.Red
			Lbl2_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl2_4.ForeColor = Color.Yellow
			Lbl2_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl2_4.ForeColor = Color.Red
			Lbl2_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl2_4.ForeColor = Color.Yellow
			Lbl2_4.Text = Chr(&H6E)
		Else
			Lbl2_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(2, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl2_5.ForeColor = Color.Red
			Lbl2_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl2_5.ForeColor = Color.Yellow
			Lbl2_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl2_5.ForeColor = Color.Red
			Lbl2_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl2_5.ForeColor = Color.Yellow
			Lbl2_5.Text = Chr(&H6E)
		Else
			Lbl2_5.Text = vbNullChar
		End If

		myChip = GameEngine.Board(3, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl3_0.ForeColor = Color.Red
			Lbl3_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl3_0.ForeColor = Color.Yellow
			Lbl3_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl3_0.ForeColor = Color.Red
			Lbl3_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl3_0.ForeColor = Color.Yellow
			Lbl3_0.Text = Chr(&H6E)
		Else
			Lbl3_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(3, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl3_1.ForeColor = Color.Red
			Lbl3_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl3_1.ForeColor = Color.Yellow
			Lbl3_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl3_1.ForeColor = Color.Red
			Lbl3_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl3_1.ForeColor = Color.Yellow
			Lbl3_1.Text = Chr(&H6E)
		Else
			Lbl3_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(3, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl3_2.ForeColor = Color.Red
			Lbl3_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl3_2.ForeColor = Color.Yellow
			Lbl3_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl3_2.ForeColor = Color.Red
			Lbl3_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl3_2.ForeColor = Color.Yellow
			Lbl3_2.Text = Chr(&H6E)
		Else
			Lbl3_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(3, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl3_3.ForeColor = Color.Red
			Lbl3_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl3_3.ForeColor = Color.Yellow
			Lbl3_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl3_3.ForeColor = Color.Red
			Lbl3_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl3_3.ForeColor = Color.Yellow
			Lbl3_3.Text = Chr(&H6E)
		Else
			Lbl3_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(3, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl3_4.ForeColor = Color.Red
			Lbl3_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl3_4.ForeColor = Color.Yellow
			Lbl3_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl3_4.ForeColor = Color.Red
			Lbl3_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl3_4.ForeColor = Color.Yellow
			Lbl3_4.Text = Chr(&H6E)
		Else
			Lbl3_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(3, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl3_5.ForeColor = Color.Red
			Lbl3_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl3_5.ForeColor = Color.Yellow
			Lbl3_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl3_5.ForeColor = Color.Red
			Lbl3_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl3_5.ForeColor = Color.Yellow
			Lbl3_5.Text = Chr(&H6E)
		Else
			Lbl3_5.Text = vbNullChar
		End If

		myChip = GameEngine.Board(4, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl4_0.ForeColor = Color.Red
			Lbl4_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl4_0.ForeColor = Color.Yellow
			Lbl4_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl4_0.ForeColor = Color.Red
			Lbl4_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl4_0.ForeColor = Color.Yellow
			Lbl4_0.Text = Chr(&H6E)
		Else
			Lbl4_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(4, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl4_1.ForeColor = Color.Red
			Lbl4_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl4_1.ForeColor = Color.Yellow
			Lbl4_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl4_1.ForeColor = Color.Red
			Lbl4_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl4_1.ForeColor = Color.Yellow
			Lbl4_1.Text = Chr(&H6E)
		Else
			Lbl4_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(4, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl4_2.ForeColor = Color.Red
			Lbl4_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl4_2.ForeColor = Color.Yellow
			Lbl4_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl4_2.ForeColor = Color.Red
			Lbl4_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl4_2.ForeColor = Color.Yellow
			Lbl4_2.Text = Chr(&H6E)
		Else
			Lbl4_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(4, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl4_3.ForeColor = Color.Red
			Lbl4_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl4_3.ForeColor = Color.Yellow
			Lbl4_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl4_3.ForeColor = Color.Red
			Lbl4_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl4_3.ForeColor = Color.Yellow
			Lbl4_3.Text = Chr(&H6E)
		Else
			Lbl4_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(4, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl4_4.ForeColor = Color.Red
			Lbl4_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl4_4.ForeColor = Color.Yellow
			Lbl4_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl4_4.ForeColor = Color.Red
			Lbl4_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl4_4.ForeColor = Color.Yellow
			Lbl4_4.Text = Chr(&H6E)
		Else
			Lbl4_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(4, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl4_5.ForeColor = Color.Red
			Lbl4_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl4_5.ForeColor = Color.Yellow
			Lbl4_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl4_5.ForeColor = Color.Red
			Lbl4_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl4_5.ForeColor = Color.Yellow
			Lbl4_5.Text = Chr(&H6E)
		Else
			Lbl4_5.Text = vbNullChar
		End If

		myChip = GameEngine.Board(5, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl5_0.ForeColor = Color.Red
			Lbl5_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl5_0.ForeColor = Color.Yellow
			Lbl5_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl5_0.ForeColor = Color.Red
			Lbl5_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl5_0.ForeColor = Color.Yellow
			Lbl5_0.Text = Chr(&H6E)
		Else
			Lbl5_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(5, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl5_1.ForeColor = Color.Red
			Lbl5_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl5_1.ForeColor = Color.Yellow
			Lbl5_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl5_1.ForeColor = Color.Red
			Lbl5_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl5_1.ForeColor = Color.Yellow
			Lbl5_1.Text = Chr(&H6E)
		Else
			Lbl5_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(5, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl5_2.ForeColor = Color.Red
			Lbl5_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl5_2.ForeColor = Color.Yellow
			Lbl5_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl5_2.ForeColor = Color.Red
			Lbl5_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl5_2.ForeColor = Color.Yellow
			Lbl5_2.Text = Chr(&H6E)
		Else
			Lbl5_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(5, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl5_3.ForeColor = Color.Red
			Lbl5_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl5_3.ForeColor = Color.Yellow
			Lbl5_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl5_3.ForeColor = Color.Red
			Lbl5_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl5_3.ForeColor = Color.Yellow
			Lbl5_3.Text = Chr(&H6E)
		Else
			Lbl5_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(5, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl5_4.ForeColor = Color.Red
			Lbl5_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl5_4.ForeColor = Color.Yellow
			Lbl5_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl5_4.ForeColor = Color.Red
			Lbl5_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl5_4.ForeColor = Color.Yellow
			Lbl5_4.Text = Chr(&H6E)
		Else
			Lbl5_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(5, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl5_5.ForeColor = Color.Red
			Lbl5_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl5_5.ForeColor = Color.Yellow
			Lbl5_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl5_5.ForeColor = Color.Red
			Lbl5_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl5_5.ForeColor = Color.Yellow
			Lbl5_5.Text = Chr(&H6E)
		Else
			Lbl5_5.Text = vbNullChar
		End If

		myChip = GameEngine.Board(6, 0)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl6_0.ForeColor = Color.Red
			Lbl6_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl6_0.ForeColor = Color.Yellow
			Lbl6_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl6_0.ForeColor = Color.Red
			Lbl6_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl6_0.ForeColor = Color.Yellow
			Lbl6_0.Text = Chr(&H6E)
		Else
			Lbl6_0.Text = vbNullChar
		End If

		myChip = GameEngine.Board(6, 1)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl6_1.ForeColor = Color.Red
			Lbl6_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl6_1.ForeColor = Color.Yellow
			Lbl6_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl6_1.ForeColor = Color.Red
			Lbl6_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl6_1.ForeColor = Color.Yellow
			Lbl6_1.Text = Chr(&H6E)
		Else
			Lbl6_1.Text = vbNullChar
		End If

		myChip = GameEngine.Board(6, 2)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl6_2.ForeColor = Color.Red
			Lbl6_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl6_2.ForeColor = Color.Yellow
			Lbl6_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl6_2.ForeColor = Color.Red
			Lbl6_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl6_2.ForeColor = Color.Yellow
			Lbl6_2.Text = Chr(&H6E)
		Else
			Lbl6_2.Text = vbNullChar
		End If

		myChip = GameEngine.Board(6, 3)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl6_3.ForeColor = Color.Red
			Lbl6_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl6_3.ForeColor = Color.Yellow
			Lbl6_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl6_3.ForeColor = Color.Red
			Lbl6_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl6_3.ForeColor = Color.Yellow
			Lbl6_3.Text = Chr(&H6E)
		Else
			Lbl6_3.Text = vbNullChar
		End If

		myChip = GameEngine.Board(6, 4)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl6_4.ForeColor = Color.Red
			Lbl6_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl6_4.ForeColor = Color.Yellow
			Lbl6_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl6_4.ForeColor = Color.Red
			Lbl6_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl6_4.ForeColor = Color.Yellow
			Lbl6_4.Text = Chr(&H6E)
		Else
			Lbl6_4.Text = vbNullChar
		End If

		myChip = GameEngine.Board(6, 5)
		If myChip = Cls4Play.Player1WinChip Then
			Lbl6_5.ForeColor = Color.Red
			Lbl6_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			Lbl6_5.ForeColor = Color.Yellow
			Lbl6_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			Lbl6_5.ForeColor = Color.Red
			Lbl6_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			Lbl6_5.ForeColor = Color.Yellow
			Lbl6_5.Text = Chr(&H6E)
		Else
			Lbl6_5.Text = vbNullChar
		End If
	End Sub
#End Region

	Private Sub CmdColumn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmd1.KeyPress, Cmd2.KeyPress, Cmd3.KeyPress, Cmd4.KeyPress, Cmd5.KeyPress, Cmd6.KeyPress, Cmd7.KeyPress
		Dim KeyAscii As Integer = Asc(e.KeyChar)
		Dim Index As Integer = CInt(CType(sender, Button).Tag)

		If KeyAscii >= Asc("1") And KeyAscii <= Asc("7") Then
			Dim btnMyButton As Button = Nothing

			Select Case Index
				Case Is = 0
					btnMyButton = Cmd1
				Case Is = 1
					btnMyButton = Cmd2
				Case Is = 2
					btnMyButton = Cmd3
				Case Is = 3
					btnMyButton = Cmd4
				Case Is = 4
					btnMyButton = Cmd5
				Case Is = 5
					btnMyButton = Cmd6
				Case Is = 6
					btnMyButton = Cmd7
				Case Else
					Debug.Fail("CmdColumn_KeyPress: UI Error", "Unhandled button!")
			End Select
			CmdColumn_Click(btnMyButton, New EventArgs())
		End If

		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub

	Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Text = My.Application.Info.Title
		Randomize()
		RestartGame()
	End Sub

	Private Sub FrmMain_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		If GameEngine.GetTotalMoves() > 0 Then
			If MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to quit now?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
				e.Cancel = True
				Exit Sub
			End If
		End If

		e.Cancel = False

		' Force close if AI is busy
		If GameEngine.Thinking Then End
	End Sub

	Private Sub MnuGameNew_Click(sender As Object, e As EventArgs) Handles MnuGameNew.Click
		If GameEngine.GetTotalMoves() > 0 Then
			If MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to end this game?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
				RestartGame()
			End If
		Else
			RestartGame()
		End If
	End Sub

	Private Sub MnuGameExit_Click(sender As Object, e As EventArgs) Handles MnuGameExit.Click
		Close()
	End Sub

	Private Sub MnuHelpAbout_Click(sender As Object, e As EventArgs) Handles MnuHelpAbout.Click
		' Display the about dialog box
		AboutBox.ShowDialog()
	End Sub

	Private Sub MnuHelpHint_Click(sender As Object, e As EventArgs) Handles MnuHelpHint.Click
		MnuHelpHint.Checked = Not MnuHelpHint.Checked
	End Sub

	Private Sub MnuHelpHowTo_Click(sender As Object, e As EventArgs) Handles MnuHelpHowTo.Click
		MsgBox("Your goal is to get your red chip in a straight line of four, in any direction. The moment you get your line, you win and your score increases by 1.", MsgBoxStyle.Information, "How To Play")
	End Sub

	Private Sub NewGame()
		GameEngine.RestartGame()
		DrawChips()
		PlayerTime = 0
		ComputerTime = 0
		LblPlayerLastMove.Text = CStr(0)
		LblComputerLastMove.Text = CStr(0)
	End Sub

	Private Sub RestartGame()
		NewGame()
		LblPlayerScore.Text = CStr(0)
		LblComputerScore.Text = CStr(0)
	End Sub

	Private Sub UpdateUI()
		' Disable housefull columns
		Cmd1.Enabled = GameEngine.GetTotalMovesInColumn(0) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd2.Enabled = GameEngine.GetTotalMovesInColumn(1) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd3.Enabled = GameEngine.GetTotalMovesInColumn(2) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd4.Enabled = GameEngine.GetTotalMovesInColumn(3) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd5.Enabled = GameEngine.GetTotalMovesInColumn(4) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd6.Enabled = GameEngine.GetTotalMovesInColumn(5) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd7.Enabled = GameEngine.GetTotalMovesInColumn(6) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy

		' Check all possible cases
		If GameEngine.IsWinner(True, Cls4Play.Player1Chip) Then
			' Player 2 goes first if Player 1 wins
			DrawChips()
			UpdateStatus("You win!")
			Application.DoEvents()
			Threading.Thread.Sleep(5000)
			NewGame()
			LblPlayerScore.Text = CStr(Val(LblPlayerScore.Text) + 1)
			GameEngine.Player = Cls4Play.Player2Chip
		ElseIf GameEngine.IsWinner(True, Cls4Play.Player2Chip) Then
			' Player 1 goes first if Player 2 wins
			DrawChips()
			UpdateStatus("I win!")
			Application.DoEvents()
			Threading.Thread.Sleep(5000)
			NewGame()
			LblComputerScore.Text = CStr(Val(LblComputerScore.Text) + 1)
			GameEngine.Player = Cls4Play.Player1Chip
			PlayerBusy = False
		ElseIf GameEngine.IsGameDraw() Then
			UpdateStatus("It's a draw!")
			Application.DoEvents()
			Threading.Thread.Sleep(5000)
			NewGame()
			If GameEngine.Player = Cls4Play.Player1Chip Then PlayerBusy = False
		End If
	End Sub

	Private Sub CmdColumn_Click(sender As Object, e As EventArgs) Handles Cmd1.Click, Cmd2.Click, Cmd3.Click, Cmd4.Click, Cmd5.Click, Cmd6.Click, Cmd7.Click
		' Don't allow reentry by the user if we are already processing a player move
		If PlayerBusy Or GameEngine.Player = Cls4Play.Player2Chip Or GameEngine.Thinking Then Exit Sub

		' Set the busy flag to true until the player and AI finishes playing
		PlayerBusy = True

		Dim i As Integer = CInt(CType(sender, Button).Tag)

		' Player's move
		If GameEngine.Player = Cls4Play.Player1Chip Then
			If GameEngine.PutChipInColumn(i, GameEngine.Player) Then
				LblPlayerLastMove.Text = CStr(i + 1)
				DrawChips()
				GameEngine.SwitchPlayers()
			End If
		End If

		UpdateUI()
	End Sub

	Private Sub TmrUpdate_Tick(sender As Object, e As EventArgs) Handles TmrUpdate.Tick
		If MnuHelpHint.Checked Then DrawChips()

		' Check the buttons
		Cmd1.Enabled = GameEngine.GetTotalMovesInColumn(0) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd2.Enabled = GameEngine.GetTotalMovesInColumn(1) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd3.Enabled = GameEngine.GetTotalMovesInColumn(2) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd4.Enabled = GameEngine.GetTotalMovesInColumn(3) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd5.Enabled = GameEngine.GetTotalMovesInColumn(4) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd6.Enabled = GameEngine.GetTotalMovesInColumn(5) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy
		Cmd7.Enabled = GameEngine.GetTotalMovesInColumn(6) <= Cls4Play.MaxY AndAlso Not GameEngine.Thinking AndAlso Not PlayerBusy

		' Update some status text; esp time and stuff
		LblPlayerTime.Text = Format(TimeSerial(0, 0, CInt(PlayerTime)), "HH:mm:ss")
		LblComputerTime.Text = Format(TimeSerial(0, 0, CInt(ComputerTime)), "HH:mm:ss")

		If GameEngine.Player = Cls4Play.Player1Chip Then
			If GameEngine.IsGameStarted() Then
				PlayerTime += CSng(TmrUpdate.Interval) / 1000.0!
			End If
		Else
			If GameEngine.IsGameStarted() Then
				ComputerTime += CSng(TmrUpdate.Interval) / 1000.0!
			End If
			If GameEngine.Player = Cls4Play.Player2Chip And Not GameEngine.Thinking Then
				Dim i As Integer

				' Computer's move
				i = GameEngine.Think()
				If GameEngine.PutChipInColumn(i, GameEngine.Player) Then
					LblComputerLastMove.Text = CStr(i + 1)
					DrawChips()
					GameEngine.SwitchPlayers()
				Else
					Debug.Fail("TmrUpdate_Tick: Game logic error!", "Computer failed to think for itself (" & i & ")!")
				End If

				PlayerBusy = False

				UpdateUI()
			End If
		End If
	End Sub
End Class
