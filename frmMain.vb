''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' 4Play: Classic Connect 4 against computer                  '
'                                                            '
' Copyright (c) Samuel Gomes, 1997-2020                      '
' All right reserved.                                        '
'                                                            '
' mailto: v_2samg@hotmail.com || gomes.samuel@gmail.com      '
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class FrmMain
	Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

		'Add any initialization after the InitializeComponent() call

	End Sub

	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
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
	Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
	Friend WithEvents mnuGame As System.Windows.Forms.MenuItem
	Friend WithEvents mnuGameNew As System.Windows.Forms.MenuItem
	Friend WithEvents mnuGameSeperator1 As System.Windows.Forms.MenuItem
	Friend WithEvents mnuGameExit As System.Windows.Forms.MenuItem
	Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
	Friend WithEvents mnuHelpHowTo As System.Windows.Forms.MenuItem
	Friend WithEvents mnuHelpHint As System.Windows.Forms.MenuItem
	Friend WithEvents mnuHelpSeperator1 As System.Windows.Forms.MenuItem
	Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
	Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
	Friend WithEvents pnlPawns As System.Windows.Forms.Panel
	Friend WithEvents pnlButtons As System.Windows.Forms.Panel
	Friend WithEvents cmd1 As System.Windows.Forms.Button
	Friend WithEvents txtStatus As System.Windows.Forms.TextBox
	Friend WithEvents lblPlayerScoreLbl As System.Windows.Forms.Label
	Friend WithEvents lblPlayerLastMoveLbl As System.Windows.Forms.Label
	Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
	Friend WithEvents lblPlayerLastMove As System.Windows.Forms.Label
	Friend WithEvents lblPlayerTime As System.Windows.Forms.Label
	Friend WithEvents cmd2 As System.Windows.Forms.Button
	Friend WithEvents cmd3 As System.Windows.Forms.Button
	Friend WithEvents cmd4 As System.Windows.Forms.Button
	Friend WithEvents cmd5 As System.Windows.Forms.Button
	Friend WithEvents cmd6 As System.Windows.Forms.Button
	Friend WithEvents cmd7 As System.Windows.Forms.Button
	Friend WithEvents pnlStatus As System.Windows.Forms.Panel
	Friend WithEvents lbl0_0 As System.Windows.Forms.Label
	Friend WithEvents lbl0_1 As System.Windows.Forms.Label
	Friend WithEvents lbl0_2 As System.Windows.Forms.Label
	Friend WithEvents lbl0_3 As System.Windows.Forms.Label
	Friend WithEvents lbl0_4 As System.Windows.Forms.Label
	Friend WithEvents lbl0_5 As System.Windows.Forms.Label
	Friend WithEvents lbl1_5 As System.Windows.Forms.Label
	Friend WithEvents lbl1_4 As System.Windows.Forms.Label
	Friend WithEvents lbl1_3 As System.Windows.Forms.Label
	Friend WithEvents lbl1_2 As System.Windows.Forms.Label
	Friend WithEvents lbl1_1 As System.Windows.Forms.Label
	Friend WithEvents lbl1_0 As System.Windows.Forms.Label
	Friend WithEvents lbl2_5 As System.Windows.Forms.Label
	Friend WithEvents lbl2_4 As System.Windows.Forms.Label
	Friend WithEvents lbl2_3 As System.Windows.Forms.Label
	Friend WithEvents lbl2_2 As System.Windows.Forms.Label
	Friend WithEvents lbl2_1 As System.Windows.Forms.Label
	Friend WithEvents lbl2_0 As System.Windows.Forms.Label
	Friend WithEvents lbl3_5 As System.Windows.Forms.Label
	Friend WithEvents lbl3_4 As System.Windows.Forms.Label
	Friend WithEvents lbl3_3 As System.Windows.Forms.Label
	Friend WithEvents lbl3_2 As System.Windows.Forms.Label
	Friend WithEvents lbl3_1 As System.Windows.Forms.Label
	Friend WithEvents lbl3_0 As System.Windows.Forms.Label
	Friend WithEvents lbl4_5 As System.Windows.Forms.Label
	Friend WithEvents lbl4_4 As System.Windows.Forms.Label
	Friend WithEvents lbl4_3 As System.Windows.Forms.Label
	Friend WithEvents lbl4_2 As System.Windows.Forms.Label
	Friend WithEvents lbl4_1 As System.Windows.Forms.Label
	Friend WithEvents lbl4_0 As System.Windows.Forms.Label
	Friend WithEvents lbl5_5 As System.Windows.Forms.Label
	Friend WithEvents lbl5_4 As System.Windows.Forms.Label
	Friend WithEvents lbl5_3 As System.Windows.Forms.Label
	Friend WithEvents lbl5_2 As System.Windows.Forms.Label
	Friend WithEvents lbl5_1 As System.Windows.Forms.Label
	Friend WithEvents lbl5_0 As System.Windows.Forms.Label
	Friend WithEvents lbl6_5 As System.Windows.Forms.Label
	Friend WithEvents lbl6_4 As System.Windows.Forms.Label
	Friend WithEvents lbl6_3 As System.Windows.Forms.Label
	Friend WithEvents lbl6_2 As System.Windows.Forms.Label
	Friend WithEvents lbl6_1 As System.Windows.Forms.Label
	Friend WithEvents lbl6_0 As System.Windows.Forms.Label
	Friend WithEvents grpPlayer As System.Windows.Forms.GroupBox
	Friend WithEvents grpComputer As System.Windows.Forms.GroupBox
	Friend WithEvents lblPlayerTimeLbl As System.Windows.Forms.Label
	Friend WithEvents lblComputerTime As System.Windows.Forms.Label
	Friend WithEvents lblComputerLastMove As System.Windows.Forms.Label
	Friend WithEvents lblComputerScore As System.Windows.Forms.Label
	Friend WithEvents lblComputerTimeLbl As System.Windows.Forms.Label
	Friend WithEvents lblComputerLastMoveLbl As System.Windows.Forms.Label
	Friend WithEvents lblComputerScoreLbl As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMain))
		Me.mnuMain = New System.Windows.Forms.MainMenu()
		Me.mnuGame = New System.Windows.Forms.MenuItem()
		Me.mnuGameNew = New System.Windows.Forms.MenuItem()
		Me.mnuGameSeperator1 = New System.Windows.Forms.MenuItem()
		Me.mnuGameExit = New System.Windows.Forms.MenuItem()
		Me.mnuHelp = New System.Windows.Forms.MenuItem()
		Me.mnuHelpHowTo = New System.Windows.Forms.MenuItem()
		Me.mnuHelpHint = New System.Windows.Forms.MenuItem()
		Me.mnuHelpSeperator1 = New System.Windows.Forms.MenuItem()
		Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
		Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
		Me.pnlPawns = New System.Windows.Forms.Panel()
		Me.lbl6_5 = New System.Windows.Forms.Label()
		Me.lbl6_4 = New System.Windows.Forms.Label()
		Me.lbl6_3 = New System.Windows.Forms.Label()
		Me.lbl6_2 = New System.Windows.Forms.Label()
		Me.lbl6_1 = New System.Windows.Forms.Label()
		Me.lbl6_0 = New System.Windows.Forms.Label()
		Me.lbl5_5 = New System.Windows.Forms.Label()
		Me.lbl5_4 = New System.Windows.Forms.Label()
		Me.lbl5_3 = New System.Windows.Forms.Label()
		Me.lbl5_2 = New System.Windows.Forms.Label()
		Me.lbl5_1 = New System.Windows.Forms.Label()
		Me.lbl5_0 = New System.Windows.Forms.Label()
		Me.lbl4_5 = New System.Windows.Forms.Label()
		Me.lbl4_4 = New System.Windows.Forms.Label()
		Me.lbl4_3 = New System.Windows.Forms.Label()
		Me.lbl4_2 = New System.Windows.Forms.Label()
		Me.lbl4_1 = New System.Windows.Forms.Label()
		Me.lbl4_0 = New System.Windows.Forms.Label()
		Me.lbl3_5 = New System.Windows.Forms.Label()
		Me.lbl3_4 = New System.Windows.Forms.Label()
		Me.lbl3_3 = New System.Windows.Forms.Label()
		Me.lbl3_2 = New System.Windows.Forms.Label()
		Me.lbl3_1 = New System.Windows.Forms.Label()
		Me.lbl3_0 = New System.Windows.Forms.Label()
		Me.lbl2_5 = New System.Windows.Forms.Label()
		Me.lbl2_4 = New System.Windows.Forms.Label()
		Me.lbl2_3 = New System.Windows.Forms.Label()
		Me.lbl2_2 = New System.Windows.Forms.Label()
		Me.lbl2_1 = New System.Windows.Forms.Label()
		Me.lbl2_0 = New System.Windows.Forms.Label()
		Me.lbl1_5 = New System.Windows.Forms.Label()
		Me.lbl1_4 = New System.Windows.Forms.Label()
		Me.lbl1_3 = New System.Windows.Forms.Label()
		Me.lbl1_2 = New System.Windows.Forms.Label()
		Me.lbl1_1 = New System.Windows.Forms.Label()
		Me.lbl1_0 = New System.Windows.Forms.Label()
		Me.lbl0_5 = New System.Windows.Forms.Label()
		Me.lbl0_4 = New System.Windows.Forms.Label()
		Me.lbl0_3 = New System.Windows.Forms.Label()
		Me.lbl0_2 = New System.Windows.Forms.Label()
		Me.lbl0_1 = New System.Windows.Forms.Label()
		Me.lbl0_0 = New System.Windows.Forms.Label()
		Me.pnlButtons = New System.Windows.Forms.Panel()
		Me.cmd7 = New System.Windows.Forms.Button()
		Me.cmd6 = New System.Windows.Forms.Button()
		Me.cmd5 = New System.Windows.Forms.Button()
		Me.cmd4 = New System.Windows.Forms.Button()
		Me.cmd3 = New System.Windows.Forms.Button()
		Me.cmd2 = New System.Windows.Forms.Button()
		Me.cmd1 = New System.Windows.Forms.Button()
		Me.pnlStatus = New System.Windows.Forms.Panel()
		Me.grpComputer = New System.Windows.Forms.GroupBox()
		Me.lblComputerTime = New System.Windows.Forms.Label()
		Me.lblComputerLastMove = New System.Windows.Forms.Label()
		Me.lblComputerScore = New System.Windows.Forms.Label()
		Me.lblComputerTimeLbl = New System.Windows.Forms.Label()
		Me.lblComputerLastMoveLbl = New System.Windows.Forms.Label()
		Me.lblComputerScoreLbl = New System.Windows.Forms.Label()
		Me.grpPlayer = New System.Windows.Forms.GroupBox()
		Me.lblPlayerTime = New System.Windows.Forms.Label()
		Me.lblPlayerLastMove = New System.Windows.Forms.Label()
		Me.lblPlayerScore = New System.Windows.Forms.Label()
		Me.lblPlayerTimeLbl = New System.Windows.Forms.Label()
		Me.lblPlayerLastMoveLbl = New System.Windows.Forms.Label()
		Me.lblPlayerScoreLbl = New System.Windows.Forms.Label()
		Me.txtStatus = New System.Windows.Forms.TextBox()
		Me.pnlPawns.SuspendLayout()
		Me.pnlButtons.SuspendLayout()
		Me.pnlStatus.SuspendLayout()
		Me.grpComputer.SuspendLayout()
		Me.grpPlayer.SuspendLayout()
		Me.SuspendLayout()
		'
		'mnuMain
		'
		Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGame, Me.mnuHelp})
		'
		'mnuGame
		'
		Me.mnuGame.Index = 0
		Me.mnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGameNew, Me.mnuGameSeperator1, Me.mnuGameExit})
		Me.mnuGame.Text = "&Game"
		'
		'mnuGameNew
		'
		Me.mnuGameNew.Index = 0
		Me.mnuGameNew.Shortcut = System.Windows.Forms.Shortcut.F2
		Me.mnuGameNew.Text = "&New"
		'
		'mnuGameSeperator1
		'
		Me.mnuGameSeperator1.Index = 1
		Me.mnuGameSeperator1.Text = "-"
		'
		'mnuGameExit
		'
		Me.mnuGameExit.Index = 2
		Me.mnuGameExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
		Me.mnuGameExit.Text = "E&xit"
		'
		'mnuHelp
		'
		Me.mnuHelp.Index = 1
		Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpHowTo, Me.mnuHelpHint, Me.mnuHelpSeperator1, Me.mnuHelpAbout})
		Me.mnuHelp.Text = "&Help"
		'
		'mnuHelpHowTo
		'
		Me.mnuHelpHowTo.Index = 0
		Me.mnuHelpHowTo.Shortcut = System.Windows.Forms.Shortcut.F1
		Me.mnuHelpHowTo.Text = "How &To..."
		'
		'mnuHelpHint
		'
		Me.mnuHelpHint.Index = 1
		Me.mnuHelpHint.Shortcut = System.Windows.Forms.Shortcut.ShiftF1
		Me.mnuHelpHint.Text = "Hi&nt..."
		'
		'mnuHelpSeperator1
		'
		Me.mnuHelpSeperator1.Index = 2
		Me.mnuHelpSeperator1.Text = "-"
		'
		'mnuHelpAbout
		'
		Me.mnuHelpAbout.Index = 3
		Me.mnuHelpAbout.Shortcut = System.Windows.Forms.Shortcut.AltF1
		Me.mnuHelpAbout.Text = "&About 4Play..."
		'
		'tmrUpdate
		'
		Me.tmrUpdate.Enabled = True
		'
		'pnlPawns
		'
		Me.pnlPawns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlPawns.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbl6_5, Me.lbl6_4, Me.lbl6_3, Me.lbl6_2, Me.lbl6_1, Me.lbl6_0, Me.lbl5_5, Me.lbl5_4, Me.lbl5_3, Me.lbl5_2, Me.lbl5_1, Me.lbl5_0, Me.lbl4_5, Me.lbl4_4, Me.lbl4_3, Me.lbl4_2, Me.lbl4_1, Me.lbl4_0, Me.lbl3_5, Me.lbl3_4, Me.lbl3_3, Me.lbl3_2, Me.lbl3_1, Me.lbl3_0, Me.lbl2_5, Me.lbl2_4, Me.lbl2_3, Me.lbl2_2, Me.lbl2_1, Me.lbl2_0, Me.lbl1_5, Me.lbl1_4, Me.lbl1_3, Me.lbl1_2, Me.lbl1_1, Me.lbl1_0, Me.lbl0_5, Me.lbl0_4, Me.lbl0_3, Me.lbl0_2, Me.lbl0_1, Me.lbl0_0})
		Me.pnlPawns.Location = New System.Drawing.Point(8, 8)
		Me.pnlPawns.Name = "pnlPawns"
		Me.pnlPawns.Size = New System.Drawing.Size(292, 252)
		Me.pnlPawns.TabIndex = 0
		'
		'lbl6_5
		'
		Me.lbl6_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl6_5.Location = New System.Drawing.Point(248, 8)
		Me.lbl6_5.Name = "lbl6_5"
		Me.lbl6_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_5.TabIndex = 41
		Me.lbl6_5.Text = "X"
		Me.lbl6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_5.UseMnemonic = False
		'
		'lbl6_4
		'
		Me.lbl6_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl6_4.Location = New System.Drawing.Point(248, 48)
		Me.lbl6_4.Name = "lbl6_4"
		Me.lbl6_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_4.TabIndex = 40
		Me.lbl6_4.Text = "X"
		Me.lbl6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_4.UseMnemonic = False
		'
		'lbl6_3
		'
		Me.lbl6_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl6_3.Location = New System.Drawing.Point(248, 88)
		Me.lbl6_3.Name = "lbl6_3"
		Me.lbl6_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_3.TabIndex = 39
		Me.lbl6_3.Text = "X"
		Me.lbl6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_3.UseMnemonic = False
		'
		'lbl6_2
		'
		Me.lbl6_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl6_2.Location = New System.Drawing.Point(248, 128)
		Me.lbl6_2.Name = "lbl6_2"
		Me.lbl6_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_2.TabIndex = 38
		Me.lbl6_2.Text = "X"
		Me.lbl6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_2.UseMnemonic = False
		'
		'lbl6_1
		'
		Me.lbl6_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl6_1.Location = New System.Drawing.Point(248, 168)
		Me.lbl6_1.Name = "lbl6_1"
		Me.lbl6_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_1.TabIndex = 37
		Me.lbl6_1.Text = "X"
		Me.lbl6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_1.UseMnemonic = False
		'
		'lbl6_0
		'
		Me.lbl6_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl6_0.Location = New System.Drawing.Point(248, 208)
		Me.lbl6_0.Name = "lbl6_0"
		Me.lbl6_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_0.TabIndex = 36
		Me.lbl6_0.Text = "X"
		Me.lbl6_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_0.UseMnemonic = False
		'
		'lbl5_5
		'
		Me.lbl5_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl5_5.Location = New System.Drawing.Point(208, 8)
		Me.lbl5_5.Name = "lbl5_5"
		Me.lbl5_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_5.TabIndex = 35
		Me.lbl5_5.Text = "X"
		Me.lbl5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_5.UseMnemonic = False
		'
		'lbl5_4
		'
		Me.lbl5_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl5_4.Location = New System.Drawing.Point(208, 48)
		Me.lbl5_4.Name = "lbl5_4"
		Me.lbl5_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_4.TabIndex = 34
		Me.lbl5_4.Text = "X"
		Me.lbl5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_4.UseMnemonic = False
		'
		'lbl5_3
		'
		Me.lbl5_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl5_3.Location = New System.Drawing.Point(208, 88)
		Me.lbl5_3.Name = "lbl5_3"
		Me.lbl5_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_3.TabIndex = 33
		Me.lbl5_3.Text = "X"
		Me.lbl5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_3.UseMnemonic = False
		'
		'lbl5_2
		'
		Me.lbl5_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl5_2.Location = New System.Drawing.Point(208, 128)
		Me.lbl5_2.Name = "lbl5_2"
		Me.lbl5_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_2.TabIndex = 32
		Me.lbl5_2.Text = "X"
		Me.lbl5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_2.UseMnemonic = False
		'
		'lbl5_1
		'
		Me.lbl5_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl5_1.Location = New System.Drawing.Point(208, 168)
		Me.lbl5_1.Name = "lbl5_1"
		Me.lbl5_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_1.TabIndex = 31
		Me.lbl5_1.Text = "X"
		Me.lbl5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_1.UseMnemonic = False
		'
		'lbl5_0
		'
		Me.lbl5_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl5_0.Location = New System.Drawing.Point(208, 208)
		Me.lbl5_0.Name = "lbl5_0"
		Me.lbl5_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_0.TabIndex = 30
		Me.lbl5_0.Text = "X"
		Me.lbl5_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_0.UseMnemonic = False
		'
		'lbl4_5
		'
		Me.lbl4_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl4_5.Location = New System.Drawing.Point(168, 8)
		Me.lbl4_5.Name = "lbl4_5"
		Me.lbl4_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_5.TabIndex = 29
		Me.lbl4_5.Text = "X"
		Me.lbl4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_5.UseMnemonic = False
		'
		'lbl4_4
		'
		Me.lbl4_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl4_4.Location = New System.Drawing.Point(168, 48)
		Me.lbl4_4.Name = "lbl4_4"
		Me.lbl4_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_4.TabIndex = 28
		Me.lbl4_4.Text = "X"
		Me.lbl4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_4.UseMnemonic = False
		'
		'lbl4_3
		'
		Me.lbl4_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl4_3.Location = New System.Drawing.Point(168, 88)
		Me.lbl4_3.Name = "lbl4_3"
		Me.lbl4_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_3.TabIndex = 27
		Me.lbl4_3.Text = "X"
		Me.lbl4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_3.UseMnemonic = False
		'
		'lbl4_2
		'
		Me.lbl4_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl4_2.Location = New System.Drawing.Point(168, 128)
		Me.lbl4_2.Name = "lbl4_2"
		Me.lbl4_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_2.TabIndex = 26
		Me.lbl4_2.Text = "X"
		Me.lbl4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_2.UseMnemonic = False
		'
		'lbl4_1
		'
		Me.lbl4_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl4_1.Location = New System.Drawing.Point(168, 168)
		Me.lbl4_1.Name = "lbl4_1"
		Me.lbl4_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_1.TabIndex = 25
		Me.lbl4_1.Text = "X"
		Me.lbl4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_1.UseMnemonic = False
		'
		'lbl4_0
		'
		Me.lbl4_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl4_0.Location = New System.Drawing.Point(168, 208)
		Me.lbl4_0.Name = "lbl4_0"
		Me.lbl4_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_0.TabIndex = 24
		Me.lbl4_0.Text = "X"
		Me.lbl4_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_0.UseMnemonic = False
		'
		'lbl3_5
		'
		Me.lbl3_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3_5.Location = New System.Drawing.Point(128, 8)
		Me.lbl3_5.Name = "lbl3_5"
		Me.lbl3_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_5.TabIndex = 23
		Me.lbl3_5.Text = "X"
		Me.lbl3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_5.UseMnemonic = False
		'
		'lbl3_4
		'
		Me.lbl3_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3_4.Location = New System.Drawing.Point(128, 48)
		Me.lbl3_4.Name = "lbl3_4"
		Me.lbl3_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_4.TabIndex = 22
		Me.lbl3_4.Text = "X"
		Me.lbl3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_4.UseMnemonic = False
		'
		'lbl3_3
		'
		Me.lbl3_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3_3.Location = New System.Drawing.Point(128, 88)
		Me.lbl3_3.Name = "lbl3_3"
		Me.lbl3_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_3.TabIndex = 21
		Me.lbl3_3.Text = "X"
		Me.lbl3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_3.UseMnemonic = False
		'
		'lbl3_2
		'
		Me.lbl3_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3_2.Location = New System.Drawing.Point(128, 128)
		Me.lbl3_2.Name = "lbl3_2"
		Me.lbl3_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_2.TabIndex = 20
		Me.lbl3_2.Text = "X"
		Me.lbl3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_2.UseMnemonic = False
		'
		'lbl3_1
		'
		Me.lbl3_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3_1.Location = New System.Drawing.Point(128, 168)
		Me.lbl3_1.Name = "lbl3_1"
		Me.lbl3_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_1.TabIndex = 19
		Me.lbl3_1.Text = "X"
		Me.lbl3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_1.UseMnemonic = False
		'
		'lbl3_0
		'
		Me.lbl3_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3_0.Location = New System.Drawing.Point(128, 208)
		Me.lbl3_0.Name = "lbl3_0"
		Me.lbl3_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_0.TabIndex = 18
		Me.lbl3_0.Text = "X"
		Me.lbl3_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_0.UseMnemonic = False
		'
		'lbl2_5
		'
		Me.lbl2_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2_5.Location = New System.Drawing.Point(88, 8)
		Me.lbl2_5.Name = "lbl2_5"
		Me.lbl2_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_5.TabIndex = 17
		Me.lbl2_5.Text = "X"
		Me.lbl2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_5.UseMnemonic = False
		'
		'lbl2_4
		'
		Me.lbl2_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2_4.Location = New System.Drawing.Point(88, 48)
		Me.lbl2_4.Name = "lbl2_4"
		Me.lbl2_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_4.TabIndex = 16
		Me.lbl2_4.Text = "X"
		Me.lbl2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_4.UseMnemonic = False
		'
		'lbl2_3
		'
		Me.lbl2_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2_3.Location = New System.Drawing.Point(88, 88)
		Me.lbl2_3.Name = "lbl2_3"
		Me.lbl2_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_3.TabIndex = 15
		Me.lbl2_3.Text = "X"
		Me.lbl2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_3.UseMnemonic = False
		'
		'lbl2_2
		'
		Me.lbl2_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2_2.Location = New System.Drawing.Point(88, 128)
		Me.lbl2_2.Name = "lbl2_2"
		Me.lbl2_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_2.TabIndex = 14
		Me.lbl2_2.Text = "X"
		Me.lbl2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_2.UseMnemonic = False
		'
		'lbl2_1
		'
		Me.lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2_1.Location = New System.Drawing.Point(88, 168)
		Me.lbl2_1.Name = "lbl2_1"
		Me.lbl2_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_1.TabIndex = 13
		Me.lbl2_1.Text = "X"
		Me.lbl2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_1.UseMnemonic = False
		'
		'lbl2_0
		'
		Me.lbl2_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl2_0.Location = New System.Drawing.Point(88, 208)
		Me.lbl2_0.Name = "lbl2_0"
		Me.lbl2_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_0.TabIndex = 12
		Me.lbl2_0.Text = "X"
		Me.lbl2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_0.UseMnemonic = False
		'
		'lbl1_5
		'
		Me.lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl1_5.Location = New System.Drawing.Point(48, 8)
		Me.lbl1_5.Name = "lbl1_5"
		Me.lbl1_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_5.TabIndex = 11
		Me.lbl1_5.Text = "X"
		Me.lbl1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_5.UseMnemonic = False
		'
		'lbl1_4
		'
		Me.lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl1_4.Location = New System.Drawing.Point(48, 48)
		Me.lbl1_4.Name = "lbl1_4"
		Me.lbl1_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_4.TabIndex = 10
		Me.lbl1_4.Text = "X"
		Me.lbl1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_4.UseMnemonic = False
		'
		'lbl1_3
		'
		Me.lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl1_3.Location = New System.Drawing.Point(48, 88)
		Me.lbl1_3.Name = "lbl1_3"
		Me.lbl1_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_3.TabIndex = 9
		Me.lbl1_3.Text = "X"
		Me.lbl1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_3.UseMnemonic = False
		'
		'lbl1_2
		'
		Me.lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl1_2.Location = New System.Drawing.Point(48, 128)
		Me.lbl1_2.Name = "lbl1_2"
		Me.lbl1_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_2.TabIndex = 8
		Me.lbl1_2.Text = "X"
		Me.lbl1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_2.UseMnemonic = False
		'
		'lbl1_1
		'
		Me.lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl1_1.Location = New System.Drawing.Point(48, 168)
		Me.lbl1_1.Name = "lbl1_1"
		Me.lbl1_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_1.TabIndex = 7
		Me.lbl1_1.Text = "X"
		Me.lbl1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_1.UseMnemonic = False
		'
		'lbl1_0
		'
		Me.lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl1_0.Location = New System.Drawing.Point(48, 208)
		Me.lbl1_0.Name = "lbl1_0"
		Me.lbl1_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_0.TabIndex = 6
		Me.lbl1_0.Text = "X"
		Me.lbl1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_0.UseMnemonic = False
		'
		'lbl0_5
		'
		Me.lbl0_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl0_5.Location = New System.Drawing.Point(8, 8)
		Me.lbl0_5.Name = "lbl0_5"
		Me.lbl0_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_5.TabIndex = 5
		Me.lbl0_5.Text = "X"
		Me.lbl0_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_5.UseMnemonic = False
		'
		'lbl0_4
		'
		Me.lbl0_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl0_4.Location = New System.Drawing.Point(8, 48)
		Me.lbl0_4.Name = "lbl0_4"
		Me.lbl0_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_4.TabIndex = 4
		Me.lbl0_4.Text = "X"
		Me.lbl0_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_4.UseMnemonic = False
		'
		'lbl0_3
		'
		Me.lbl0_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl0_3.Location = New System.Drawing.Point(8, 88)
		Me.lbl0_3.Name = "lbl0_3"
		Me.lbl0_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_3.TabIndex = 3
		Me.lbl0_3.Text = "X"
		Me.lbl0_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_3.UseMnemonic = False
		'
		'lbl0_2
		'
		Me.lbl0_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl0_2.Location = New System.Drawing.Point(8, 128)
		Me.lbl0_2.Name = "lbl0_2"
		Me.lbl0_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_2.TabIndex = 2
		Me.lbl0_2.Text = "X"
		Me.lbl0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_2.UseMnemonic = False
		'
		'lbl0_1
		'
		Me.lbl0_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl0_1.Location = New System.Drawing.Point(8, 168)
		Me.lbl0_1.Name = "lbl0_1"
		Me.lbl0_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_1.TabIndex = 1
		Me.lbl0_1.Text = "X"
		Me.lbl0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_1.UseMnemonic = False
		'
		'lbl0_0
		'
		Me.lbl0_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl0_0.Location = New System.Drawing.Point(8, 208)
		Me.lbl0_0.Name = "lbl0_0"
		Me.lbl0_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_0.TabIndex = 0
		Me.lbl0_0.Text = "X"
		Me.lbl0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_0.UseMnemonic = False
		'
		'pnlButtons
		'
		Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlButtons.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmd7, Me.cmd6, Me.cmd5, Me.cmd4, Me.cmd3, Me.cmd2, Me.cmd1})
		Me.pnlButtons.Location = New System.Drawing.Point(8, 268)
		Me.pnlButtons.Name = "pnlButtons"
		Me.pnlButtons.Size = New System.Drawing.Size(292, 52)
		Me.pnlButtons.TabIndex = 1
		'
		'cmd7
		'
		Me.cmd7.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd7.Location = New System.Drawing.Point(248, 8)
		Me.cmd7.Name = "cmd7"
		Me.cmd7.Size = New System.Drawing.Size(32, 32)
		Me.cmd7.TabIndex = 6
		Me.cmd7.Tag = "6"
		Me.cmd7.Text = "&7"
		'
		'cmd6
		'
		Me.cmd6.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd6.Location = New System.Drawing.Point(208, 8)
		Me.cmd6.Name = "cmd6"
		Me.cmd6.Size = New System.Drawing.Size(32, 32)
		Me.cmd6.TabIndex = 5
		Me.cmd6.Tag = "5"
		Me.cmd6.Text = "&6"
		'
		'cmd5
		'
		Me.cmd5.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd5.Location = New System.Drawing.Point(168, 8)
		Me.cmd5.Name = "cmd5"
		Me.cmd5.Size = New System.Drawing.Size(32, 32)
		Me.cmd5.TabIndex = 4
		Me.cmd5.Tag = "4"
		Me.cmd5.Text = "&5"
		'
		'cmd4
		'
		Me.cmd4.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd4.Location = New System.Drawing.Point(128, 8)
		Me.cmd4.Name = "cmd4"
		Me.cmd4.Size = New System.Drawing.Size(32, 32)
		Me.cmd4.TabIndex = 3
		Me.cmd4.Tag = "3"
		Me.cmd4.Text = "&4"
		'
		'cmd3
		'
		Me.cmd3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd3.Location = New System.Drawing.Point(88, 8)
		Me.cmd3.Name = "cmd3"
		Me.cmd3.Size = New System.Drawing.Size(32, 32)
		Me.cmd3.TabIndex = 2
		Me.cmd3.Tag = "2"
		Me.cmd3.Text = "&3"
		'
		'cmd2
		'
		Me.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd2.Location = New System.Drawing.Point(48, 8)
		Me.cmd2.Name = "cmd2"
		Me.cmd2.Size = New System.Drawing.Size(32, 32)
		Me.cmd2.TabIndex = 1
		Me.cmd2.Tag = "1"
		Me.cmd2.Text = "&2"
		'
		'cmd1
		'
		Me.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.cmd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmd1.Location = New System.Drawing.Point(8, 8)
		Me.cmd1.Name = "cmd1"
		Me.cmd1.Size = New System.Drawing.Size(32, 32)
		Me.cmd1.TabIndex = 0
		Me.cmd1.Tag = "0"
		Me.cmd1.Text = "&1"
		'
		'pnlStatus
		'
		Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnlStatus.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpComputer, Me.grpPlayer})
		Me.pnlStatus.Location = New System.Drawing.Point(308, 8)
		Me.pnlStatus.Name = "pnlStatus"
		Me.pnlStatus.Size = New System.Drawing.Size(188, 228)
		Me.pnlStatus.TabIndex = 2
		'
		'grpComputer
		'
		Me.grpComputer.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblComputerTime, Me.lblComputerLastMove, Me.lblComputerScore, Me.lblComputerTimeLbl, Me.lblComputerLastMoveLbl, Me.lblComputerScoreLbl})
		Me.grpComputer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpComputer.Location = New System.Drawing.Point(8, 116)
		Me.grpComputer.Name = "grpComputer"
		Me.grpComputer.Size = New System.Drawing.Size(168, 100)
		Me.grpComputer.TabIndex = 1
		Me.grpComputer.TabStop = False
		Me.grpComputer.Text = "Computer (O):"
		'
		'lblComputerTime
		'
		Me.lblComputerTime.AutoSize = True
		Me.lblComputerTime.Location = New System.Drawing.Point(104, 72)
		Me.lblComputerTime.Name = "lblComputerTime"
		Me.lblComputerTime.Size = New System.Drawing.Size(48, 13)
		Me.lblComputerTime.TabIndex = 5
		Me.lblComputerTime.Text = "00:00:00"
		Me.lblComputerTime.UseMnemonic = False
		'
		'lblComputerLastMove
		'
		Me.lblComputerLastMove.AutoSize = True
		Me.lblComputerLastMove.Location = New System.Drawing.Point(104, 48)
		Me.lblComputerLastMove.Name = "lblComputerLastMove"
		Me.lblComputerLastMove.Size = New System.Drawing.Size(10, 13)
		Me.lblComputerLastMove.TabIndex = 3
		Me.lblComputerLastMove.Text = "0"
		Me.lblComputerLastMove.UseMnemonic = False
		'
		'lblComputerScore
		'
		Me.lblComputerScore.AutoSize = True
		Me.lblComputerScore.Location = New System.Drawing.Point(104, 24)
		Me.lblComputerScore.Name = "lblComputerScore"
		Me.lblComputerScore.Size = New System.Drawing.Size(10, 13)
		Me.lblComputerScore.TabIndex = 1
		Me.lblComputerScore.Text = "0"
		Me.lblComputerScore.UseMnemonic = False
		'
		'lblComputerTimeLbl
		'
		Me.lblComputerTimeLbl.AutoSize = True
		Me.lblComputerTimeLbl.Location = New System.Drawing.Point(36, 72)
		Me.lblComputerTimeLbl.Name = "lblComputerTimeLbl"
		Me.lblComputerTimeLbl.Size = New System.Drawing.Size(33, 13)
		Me.lblComputerTimeLbl.TabIndex = 4
		Me.lblComputerTimeLbl.Text = "Time:"
		Me.lblComputerTimeLbl.UseMnemonic = False
		'
		'lblComputerLastMoveLbl
		'
		Me.lblComputerLastMoveLbl.AutoSize = True
		Me.lblComputerLastMoveLbl.Location = New System.Drawing.Point(12, 48)
		Me.lblComputerLastMoveLbl.Name = "lblComputerLastMoveLbl"
		Me.lblComputerLastMoveLbl.Size = New System.Drawing.Size(59, 13)
		Me.lblComputerLastMoveLbl.TabIndex = 2
		Me.lblComputerLastMoveLbl.Text = "Last Move:"
		Me.lblComputerLastMoveLbl.UseMnemonic = False
		'
		'lblComputerScoreLbl
		'
		Me.lblComputerScoreLbl.AutoSize = True
		Me.lblComputerScoreLbl.Location = New System.Drawing.Point(32, 24)
		Me.lblComputerScoreLbl.Name = "lblComputerScoreLbl"
		Me.lblComputerScoreLbl.Size = New System.Drawing.Size(37, 13)
		Me.lblComputerScoreLbl.TabIndex = 0
		Me.lblComputerScoreLbl.Text = "Score:"
		Me.lblComputerScoreLbl.UseMnemonic = False
		'
		'grpPlayer
		'
		Me.grpPlayer.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPlayerTime, Me.lblPlayerLastMove, Me.lblPlayerScore, Me.lblPlayerTimeLbl, Me.lblPlayerLastMoveLbl, Me.lblPlayerScoreLbl})
		Me.grpPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.grpPlayer.Location = New System.Drawing.Point(8, 8)
		Me.grpPlayer.Name = "grpPlayer"
		Me.grpPlayer.Size = New System.Drawing.Size(168, 100)
		Me.grpPlayer.TabIndex = 0
		Me.grpPlayer.TabStop = False
		Me.grpPlayer.Text = "Player (X):"
		'
		'lblPlayerTime
		'
		Me.lblPlayerTime.AutoSize = True
		Me.lblPlayerTime.Location = New System.Drawing.Point(104, 72)
		Me.lblPlayerTime.Name = "lblPlayerTime"
		Me.lblPlayerTime.Size = New System.Drawing.Size(48, 13)
		Me.lblPlayerTime.TabIndex = 5
		Me.lblPlayerTime.Text = "00:00:00"
		Me.lblPlayerTime.UseMnemonic = False
		'
		'lblPlayerLastMove
		'
		Me.lblPlayerLastMove.AutoSize = True
		Me.lblPlayerLastMove.Location = New System.Drawing.Point(104, 48)
		Me.lblPlayerLastMove.Name = "lblPlayerLastMove"
		Me.lblPlayerLastMove.Size = New System.Drawing.Size(10, 13)
		Me.lblPlayerLastMove.TabIndex = 3
		Me.lblPlayerLastMove.Text = "0"
		Me.lblPlayerLastMove.UseMnemonic = False
		'
		'lblPlayerScore
		'
		Me.lblPlayerScore.AutoSize = True
		Me.lblPlayerScore.Location = New System.Drawing.Point(104, 24)
		Me.lblPlayerScore.Name = "lblPlayerScore"
		Me.lblPlayerScore.Size = New System.Drawing.Size(10, 13)
		Me.lblPlayerScore.TabIndex = 1
		Me.lblPlayerScore.Text = "0"
		Me.lblPlayerScore.UseMnemonic = False
		'
		'lblPlayerTimeLbl
		'
		Me.lblPlayerTimeLbl.AutoSize = True
		Me.lblPlayerTimeLbl.Location = New System.Drawing.Point(36, 72)
		Me.lblPlayerTimeLbl.Name = "lblPlayerTimeLbl"
		Me.lblPlayerTimeLbl.Size = New System.Drawing.Size(33, 13)
		Me.lblPlayerTimeLbl.TabIndex = 4
		Me.lblPlayerTimeLbl.Text = "Time:"
		Me.lblPlayerTimeLbl.UseMnemonic = False
		'
		'lblPlayerLastMoveLbl
		'
		Me.lblPlayerLastMoveLbl.AutoSize = True
		Me.lblPlayerLastMoveLbl.Location = New System.Drawing.Point(12, 48)
		Me.lblPlayerLastMoveLbl.Name = "lblPlayerLastMoveLbl"
		Me.lblPlayerLastMoveLbl.Size = New System.Drawing.Size(59, 13)
		Me.lblPlayerLastMoveLbl.TabIndex = 2
		Me.lblPlayerLastMoveLbl.Text = "Last Move:"
		Me.lblPlayerLastMoveLbl.UseMnemonic = False
		'
		'lblPlayerScoreLbl
		'
		Me.lblPlayerScoreLbl.AutoSize = True
		Me.lblPlayerScoreLbl.Location = New System.Drawing.Point(32, 24)
		Me.lblPlayerScoreLbl.Name = "lblPlayerScoreLbl"
		Me.lblPlayerScoreLbl.Size = New System.Drawing.Size(37, 13)
		Me.lblPlayerScoreLbl.TabIndex = 0
		Me.lblPlayerScoreLbl.Text = "Score:"
		Me.lblPlayerScoreLbl.UseMnemonic = False
		'
		'txtStatus
		'
		Me.txtStatus.AutoSize = False
		Me.txtStatus.BackColor = System.Drawing.Color.Black
		Me.txtStatus.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStatus.ForeColor = System.Drawing.Color.Red
		Me.txtStatus.Location = New System.Drawing.Point(308, 244)
		Me.txtStatus.Multiline = True
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.ReadOnly = True
		Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtStatus.Size = New System.Drawing.Size(188, 76)
		Me.txtStatus.TabIndex = 3
		Me.txtStatus.TabStop = False
		Me.txtStatus.Text = "Ready!" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Ready!!" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Ready!!!" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Ready!!!!" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Ready!!!!!"
		'
		'frmMain
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(504, 327)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtStatus, Me.pnlStatus, Me.pnlButtons, Me.pnlPawns})
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Menu = Me.mnuMain
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "4Play"
		Me.pnlPawns.ResumeLayout(False)
		Me.pnlButtons.ResumeLayout(False)
		Me.pnlStatus.ResumeLayout(False)
		Me.grpComputer.ResumeLayout(False)
		Me.grpPlayer.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

#End Region

	' Win32 Shell About box
	Private Declare Function ShellAbout Lib "shell32" Alias "ShellAboutA" (ByVal hWnd As IntPtr, ByVal szApp As String, ByVal szOtherStuff As String, ByVal hIcon As IntPtr) As Integer

	' Maximum number of status line
	Private Const MaxStatusLine As Integer = 255

	Private PlayerTime, ComputerTime As Single
	Private PlayerScore, ComputerScore As Integer
	Private PlayerMove, ComputerMove As Integer
	Private WithEvents GameEngine As New Cls4Play()

	' Our game engine message handler
	Private Sub UpdateStatus(ByVal Note As String) Handles GameEngine.ProcessNote
		Static sMessages(MaxStatusLine) As String         ' this will hold all messages
		Static iMessageLine As Integer       ' message line pointer
		Dim i As Integer
		Dim sTmp As String = ""

		If (iMessageLine <= MaxStatusLine) Then
			sMessages(iMessageLine) = Note
			iMessageLine = iMessageLine + 1
		Else
			' We are past the last message line, so we need to shift all messages up
			For i = 1 To MaxStatusLine
				sMessages(i - 1) = sMessages(i)
			Next
			sMessages(MaxStatusLine) = Note
		End If

		' Now lets referesh out status box
		For i = 0 To MaxStatusLine
			If (sMessages(i) <> "") Then
				If (sTmp = "") Then
					sTmp = sMessages(i)
				Else
					sTmp = sTmp & vbNewLine & sMessages(i)
				End If
			End If
		Next

		txtStatus.Text = sTmp
		txtStatus.SelectionLength = 0
		txtStatus.SelectionStart = Len(sTmp)
		txtStatus.ScrollToCaret()
	End Sub

	Private Sub cmdColumn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click
		Static bInCmdColumnClick As Boolean
		Dim Index As Integer = CInt(CType(sender, Button).Tag)
		Dim i As Integer

		' Don't allow reentry by the user if computer is playing
		If (bInCmdColumnClick) Then Exit Sub
		bInCmdColumnClick = True

		' Player's move
		If (GameEngine.CurrentPlayer = Cls4Play.Player1Chip) Then
			If (GameEngine.PutChipInRow(Index)) Then
				PlayerMove = Index + 1
				DrawChips()
				GameEngine.SwitchPlayers()
				Application.DoEvents()
			End If
		End If

		' Disable housefull columns
		cmd1.Enabled = (GameEngine.GetTotalMovesInRow(0) <= Cls4Play.MaxY)
		cmd2.Enabled = (GameEngine.GetTotalMovesInRow(1) <= Cls4Play.MaxY)
		cmd3.Enabled = (GameEngine.GetTotalMovesInRow(2) <= Cls4Play.MaxY)
		cmd4.Enabled = (GameEngine.GetTotalMovesInRow(3) <= Cls4Play.MaxY)
		cmd5.Enabled = (GameEngine.GetTotalMovesInRow(4) <= Cls4Play.MaxY)
		cmd6.Enabled = (GameEngine.GetTotalMovesInRow(5) <= Cls4Play.MaxY)
		cmd7.Enabled = (GameEngine.GetTotalMovesInRow(6) <= Cls4Play.MaxY)

		' Check all possible cases (fixes an old bug)
		If (GameEngine.IsWinner(Cls4Play.Player1Chip)) Then
			DrawChips()
			tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
			MsgBox("You win!", MsgBoxStyle.Exclamation)
			NewGame()
			PlayerScore = PlayerScore + 1
			bInCmdColumnClick = False
			Exit Sub
		ElseIf (GameEngine.IsWinner(Cls4Play.Player2Chip)) Then
			DrawChips()
			tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
			MsgBox("I win!", MsgBoxStyle.Exclamation)
			NewGame()
			ComputerScore = ComputerScore + 1
			bInCmdColumnClick = False
			Exit Sub
		ElseIf (GameEngine.IsGameDraw()) Then
			tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
			MsgBox("It's a draw!", MsgBoxStyle.Exclamation)
			NewGame()
			bInCmdColumnClick = False
			Exit Sub
		End If

		' Computer's move
		If (GameEngine.CurrentPlayer = Cls4Play.Player2Chip) Then
			i = Math.Abs(GameEngine.Think())
			If (GameEngine.PutChipInRow(i)) Then
				ComputerMove = i + 1
				DrawChips()
				GameEngine.SwitchPlayers()
			Else
				Debug.Fail("frmMain::cmdColumn_Click: Game logic error!", "Computer failed to think for itself (" & i & ")!")
			End If
		End If

		' Disable housefull columns
		cmd1.Enabled = (GameEngine.GetTotalMovesInRow(0) <= Cls4Play.MaxY)
		cmd2.Enabled = (GameEngine.GetTotalMovesInRow(1) <= Cls4Play.MaxY)
		cmd3.Enabled = (GameEngine.GetTotalMovesInRow(2) <= Cls4Play.MaxY)
		cmd4.Enabled = (GameEngine.GetTotalMovesInRow(3) <= Cls4Play.MaxY)
		cmd5.Enabled = (GameEngine.GetTotalMovesInRow(4) <= Cls4Play.MaxY)
		cmd6.Enabled = (GameEngine.GetTotalMovesInRow(5) <= Cls4Play.MaxY)
		cmd7.Enabled = (GameEngine.GetTotalMovesInRow(6) <= Cls4Play.MaxY)

		' Recheck again
		If (GameEngine.IsWinner(Cls4Play.Player1Chip)) Then
			DrawChips()
			tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
			MsgBox("You win!", MsgBoxStyle.Exclamation)
			NewGame()
			PlayerScore = PlayerScore + 1
		ElseIf (GameEngine.IsWinner(Cls4Play.Player2Chip)) Then
			DrawChips()
			tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
			MsgBox("I win!", MsgBoxStyle.Exclamation)
			NewGame()
			ComputerScore = ComputerScore + 1
		ElseIf (GameEngine.IsGameDraw()) Then
			tmrUpdate_Tick(tmrUpdate, New System.EventArgs())
			MsgBox("It's a draw!", MsgBoxStyle.Exclamation)
			NewGame()
		End If

		bInCmdColumnClick = False
	End Sub

	' This used to be done using control arrays
	' But now we do it the manual way.
	' Too lazy to think of an idea. :(
	' The following function was generated programatically using QBasic. ;)
	' You crazy! I am gonna do this by hand?!!! No way!
#Region "DrawChips() [Autogenerated Using QBasic]"
	Private Sub DrawChips()
		Dim myChip As String

		myChip = GameEngine.GetMove(0, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_0.ForeColor = txtStatus.ForeColor
		Else
			lbl0_0.ForeColor = cmd1.ForeColor
		End If
		lbl0_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_1.ForeColor = txtStatus.ForeColor
		Else
			lbl0_1.ForeColor = cmd1.ForeColor
		End If
		lbl0_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_2.ForeColor = txtStatus.ForeColor
		Else
			lbl0_2.ForeColor = cmd1.ForeColor
		End If
		lbl0_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_3.ForeColor = txtStatus.ForeColor
		Else
			lbl0_3.ForeColor = cmd1.ForeColor
		End If
		lbl0_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_4.ForeColor = txtStatus.ForeColor
		Else
			lbl0_4.ForeColor = cmd1.ForeColor
		End If
		lbl0_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_5.ForeColor = txtStatus.ForeColor
		Else
			lbl0_5.ForeColor = cmd1.ForeColor
		End If
		lbl0_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_0.ForeColor = txtStatus.ForeColor
		Else
			lbl1_0.ForeColor = cmd2.ForeColor
		End If
		lbl1_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_1.ForeColor = txtStatus.ForeColor
		Else
			lbl1_1.ForeColor = cmd2.ForeColor
		End If
		lbl1_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_2.ForeColor = txtStatus.ForeColor
		Else
			lbl1_2.ForeColor = cmd2.ForeColor
		End If
		lbl1_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_3.ForeColor = txtStatus.ForeColor
		Else
			lbl1_3.ForeColor = cmd2.ForeColor
		End If
		lbl1_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_4.ForeColor = txtStatus.ForeColor
		Else
			lbl1_4.ForeColor = cmd2.ForeColor
		End If
		lbl1_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_5.ForeColor = txtStatus.ForeColor
		Else
			lbl1_5.ForeColor = cmd2.ForeColor
		End If
		lbl1_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_0.ForeColor = txtStatus.ForeColor
		Else
			lbl2_0.ForeColor = cmd3.ForeColor
		End If
		lbl2_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_1.ForeColor = txtStatus.ForeColor
		Else
			lbl2_1.ForeColor = cmd3.ForeColor
		End If
		lbl2_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_2.ForeColor = txtStatus.ForeColor
		Else
			lbl2_2.ForeColor = cmd3.ForeColor
		End If
		lbl2_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_3.ForeColor = txtStatus.ForeColor
		Else
			lbl2_3.ForeColor = cmd3.ForeColor
		End If
		lbl2_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_4.ForeColor = txtStatus.ForeColor
		Else
			lbl2_4.ForeColor = cmd3.ForeColor
		End If
		lbl2_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_5.ForeColor = txtStatus.ForeColor
		Else
			lbl2_5.ForeColor = cmd3.ForeColor
		End If
		lbl2_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_0.ForeColor = txtStatus.ForeColor
		Else
			lbl3_0.ForeColor = cmd4.ForeColor
		End If
		lbl3_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_1.ForeColor = txtStatus.ForeColor
		Else
			lbl3_1.ForeColor = cmd4.ForeColor
		End If
		lbl3_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_2.ForeColor = txtStatus.ForeColor
		Else
			lbl3_2.ForeColor = cmd4.ForeColor
		End If
		lbl3_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_3.ForeColor = txtStatus.ForeColor
		Else
			lbl3_3.ForeColor = cmd4.ForeColor
		End If
		lbl3_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_4.ForeColor = txtStatus.ForeColor
		Else
			lbl3_4.ForeColor = cmd4.ForeColor
		End If
		lbl3_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_5.ForeColor = txtStatus.ForeColor
		Else
			lbl3_5.ForeColor = cmd4.ForeColor
		End If
		lbl3_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_0.ForeColor = txtStatus.ForeColor
		Else
			lbl4_0.ForeColor = cmd5.ForeColor
		End If
		lbl4_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_1.ForeColor = txtStatus.ForeColor
		Else
			lbl4_1.ForeColor = cmd5.ForeColor
		End If
		lbl4_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_2.ForeColor = txtStatus.ForeColor
		Else
			lbl4_2.ForeColor = cmd5.ForeColor
		End If
		lbl4_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_3.ForeColor = txtStatus.ForeColor
		Else
			lbl4_3.ForeColor = cmd5.ForeColor
		End If
		lbl4_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_4.ForeColor = txtStatus.ForeColor
		Else
			lbl4_4.ForeColor = cmd5.ForeColor
		End If
		lbl4_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_5.ForeColor = txtStatus.ForeColor
		Else
			lbl4_5.ForeColor = cmd5.ForeColor
		End If
		lbl4_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_0.ForeColor = txtStatus.ForeColor
		Else
			lbl5_0.ForeColor = cmd6.ForeColor
		End If
		lbl5_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_1.ForeColor = txtStatus.ForeColor
		Else
			lbl5_1.ForeColor = cmd6.ForeColor
		End If
		lbl5_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_2.ForeColor = txtStatus.ForeColor
		Else
			lbl5_2.ForeColor = cmd6.ForeColor
		End If
		lbl5_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_3.ForeColor = txtStatus.ForeColor
		Else
			lbl5_3.ForeColor = cmd6.ForeColor
		End If
		lbl5_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_4.ForeColor = txtStatus.ForeColor
		Else
			lbl5_4.ForeColor = cmd6.ForeColor
		End If
		lbl5_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_5.ForeColor = txtStatus.ForeColor
		Else
			lbl5_5.ForeColor = cmd6.ForeColor
		End If
		lbl5_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_0.ForeColor = txtStatus.ForeColor
		Else
			lbl6_0.ForeColor = cmd7.ForeColor
		End If
		lbl6_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_1.ForeColor = txtStatus.ForeColor
		Else
			lbl6_1.ForeColor = cmd7.ForeColor
		End If
		lbl6_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_2.ForeColor = txtStatus.ForeColor
		Else
			lbl6_2.ForeColor = cmd7.ForeColor
		End If
		lbl6_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_3.ForeColor = txtStatus.ForeColor
		Else
			lbl6_3.ForeColor = cmd7.ForeColor
		End If
		lbl6_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_4.ForeColor = txtStatus.ForeColor
		Else
			lbl6_4.ForeColor = cmd7.ForeColor
		End If
		lbl6_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_5.ForeColor = txtStatus.ForeColor
		Else
			lbl6_5.ForeColor = cmd7.ForeColor
		End If
		lbl6_5.Text = UCase(myChip)
	End Sub
#End Region

	Private Sub cmdColumn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmd1.KeyPress, cmd2.KeyPress, cmd3.KeyPress, cmd4.KeyPress, cmd5.KeyPress, cmd6.KeyPress, cmd7.KeyPress
		Dim KeyAscii As Integer = Asc(e.KeyChar)
		Dim Index As Integer = CInt(CType(sender, Button).Tag)

		If (KeyAscii >= Asc("1") And KeyAscii <= Asc("7")) Then
			Dim btnMyButton As Button = Nothing

			Select Case Index
				Case Is = 0
					btnMyButton = cmd1
				Case Is = 1
					btnMyButton = cmd2
				Case Is = 2
					btnMyButton = cmd3
				Case Is = 3
					btnMyButton = cmd4
				Case Is = 4
					btnMyButton = cmd5
				Case Is = 5
					btnMyButton = cmd6
				Case Is = 6
					btnMyButton = cmd7
				Case Else
					Debug.Fail("Unhandled button!")
			End Select
			cmdColumn_Click(btnMyButton, New System.EventArgs())
		End If

		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub

	Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Randomize()
		RestartGame()
	End Sub

	Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		If (GameEngine.GetTotalMoves() > 0) Then
			If (MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to quit now?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes) Then
				e.Cancel = True
				Exit Sub
			End If
		End If

		e.Cancel = False
	End Sub

	Private Sub mnuGameNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGameNew.Click
		If (GameEngine.GetTotalMoves() > 0) Then
			If (MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to end this game?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes) Then
				RestartGame()
			End If
		Else
			RestartGame()
		End If
	End Sub

	Private Sub mnuGameExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGameExit.Click
		Close()
	End Sub

	Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
		' Display the about dialog box
		ShellAbout(Handle,
		 Application.ProductName,
		 Diagnostics.FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly.Location).LegalCopyright &
		 vbNewLine & "Version " & Application.ProductVersion,
		 Icon.Handle)
	End Sub

	Private Sub mnuHelpHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpHint.Click
		MsgBox("Try column " & (Math.Abs(GameEngine.Think()) + 1) & ".", MsgBoxStyle.Information, "Hint")
	End Sub

	Private Sub mnuHelpHowTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpHowTo.Click
		MsgBox("Your goal is to get your chip (" & Cls4Play.Player1Chip & ") in a straight line of four, in any direction. The moment you get your line, you win and your score increases by 1.", MsgBoxStyle.Information, "How To Play")
	End Sub

	Private Sub NewGame()
		GameEngine.RestartGame()
		DrawChips()
		PlayerTime = 0
		ComputerTime = 0
		PlayerMove = 0
		ComputerMove = 0
		GameEngine.CurrentPlayer = Cls4Play.Player1Chip
	End Sub

	Private Sub RestartGame()
		NewGame()
		PlayerScore = 0
		ComputerScore = 0
	End Sub

	Private Sub tmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdate.Tick
		' Check out buttons
		cmd1.Enabled = (GameEngine.GetTotalMovesInRow(0) <= Cls4Play.MaxY)
		cmd2.Enabled = (GameEngine.GetTotalMovesInRow(1) <= Cls4Play.MaxY)
		cmd3.Enabled = (GameEngine.GetTotalMovesInRow(2) <= Cls4Play.MaxY)
		cmd4.Enabled = (GameEngine.GetTotalMovesInRow(3) <= Cls4Play.MaxY)
		cmd5.Enabled = (GameEngine.GetTotalMovesInRow(4) <= Cls4Play.MaxY)
		cmd6.Enabled = (GameEngine.GetTotalMovesInRow(5) <= Cls4Play.MaxY)
		cmd7.Enabled = (GameEngine.GetTotalMovesInRow(6) <= Cls4Play.MaxY)

		' Update some status text; esp time and stuff
		lblPlayerTime.Text = Format(TimeSerial(0, 0, CInt(PlayerTime)), "HH:mm:ss")
		lblComputerTime.Text = Format(TimeSerial(0, 0, CInt(ComputerTime)), "HH:mm:ss")

		lblPlayerScore.Text = CStr(PlayerScore)
		lblComputerScore.Text = CStr(ComputerScore)
		lblPlayerLastMove.Text = CStr(PlayerMove)
		lblComputerLastMove.Text = CStr(ComputerMove)

		If GameEngine.CurrentPlayer = Cls4Play.Player1Chip Then
			If GameEngine.IsGameStarted() Then
				PlayerTime = PlayerTime + (CSng(tmrUpdate.Interval) / 1000.0!)
			End If
		Else
			ComputerTime = ComputerTime + (CSng(tmrUpdate.Interval) / 1000.0!)
		End If
	End Sub
End Class
