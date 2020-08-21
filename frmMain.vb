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
	Friend WithEvents MnuMain As System.Windows.Forms.MainMenu
	Friend WithEvents MnuGame As System.Windows.Forms.MenuItem
	Friend WithEvents MnuGameNew As System.Windows.Forms.MenuItem
	Friend WithEvents MnuGameSeperator1 As System.Windows.Forms.MenuItem
	Friend WithEvents MnuGameExit As System.Windows.Forms.MenuItem
	Friend WithEvents MnuHelp As System.Windows.Forms.MenuItem
	Friend WithEvents MnuHelpHowTo As System.Windows.Forms.MenuItem
	Friend WithEvents MnuHelpHint As System.Windows.Forms.MenuItem
	Friend WithEvents MnuHelpSeperator1 As System.Windows.Forms.MenuItem
	Friend WithEvents MnuHelpAbout As System.Windows.Forms.MenuItem
	Friend WithEvents TmrUpdate As System.Windows.Forms.Timer
	Friend WithEvents PnlPawns As System.Windows.Forms.Panel
	Friend WithEvents PnlButtons As System.Windows.Forms.Panel
	Friend WithEvents cmd1 As System.Windows.Forms.Button
	Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
	Friend WithEvents LblPlayerScoreLbl As System.Windows.Forms.Label
	Friend WithEvents LblPlayerLastMoveLbl As System.Windows.Forms.Label
	Friend WithEvents LblPlayerScore As System.Windows.Forms.Label
	Friend WithEvents LblPlayerLastMove As System.Windows.Forms.Label
	Friend WithEvents LblPlayerTime As System.Windows.Forms.Label
	Friend WithEvents cmd2 As System.Windows.Forms.Button
	Friend WithEvents cmd3 As System.Windows.Forms.Button
	Friend WithEvents cmd4 As System.Windows.Forms.Button
	Friend WithEvents cmd5 As System.Windows.Forms.Button
	Friend WithEvents cmd6 As System.Windows.Forms.Button
	Friend WithEvents cmd7 As System.Windows.Forms.Button
	Friend WithEvents PnlStatus As System.Windows.Forms.Panel
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
	Friend WithEvents GrpPlayer As System.Windows.Forms.GroupBox
	Friend WithEvents GrpComputer As System.Windows.Forms.GroupBox
	Friend WithEvents LblPlayerTimeLbl As System.Windows.Forms.Label
	Friend WithEvents LblComputerTime As System.Windows.Forms.Label
	Friend WithEvents LblComputerLastMove As System.Windows.Forms.Label
	Friend WithEvents LblComputerScore As System.Windows.Forms.Label
	Friend WithEvents LblComputerTimeLbl As System.Windows.Forms.Label
	Friend WithEvents LblComputerLastMoveLbl As System.Windows.Forms.Label
	Friend WithEvents LblComputerScoreLbl As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
		Me.MnuMain = New System.Windows.Forms.MainMenu(Me.components)
		Me.MnuGame = New System.Windows.Forms.MenuItem()
		Me.MnuGameNew = New System.Windows.Forms.MenuItem()
		Me.MnuGameSeperator1 = New System.Windows.Forms.MenuItem()
		Me.MnuGameExit = New System.Windows.Forms.MenuItem()
		Me.MnuHelp = New System.Windows.Forms.MenuItem()
		Me.MnuHelpHowTo = New System.Windows.Forms.MenuItem()
		Me.MnuHelpHint = New System.Windows.Forms.MenuItem()
		Me.MnuHelpSeperator1 = New System.Windows.Forms.MenuItem()
		Me.MnuHelpAbout = New System.Windows.Forms.MenuItem()
		Me.TmrUpdate = New System.Windows.Forms.Timer(Me.components)
		Me.PnlPawns = New System.Windows.Forms.Panel()
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
		Me.PnlButtons = New System.Windows.Forms.Panel()
		Me.cmd7 = New System.Windows.Forms.Button()
		Me.cmd6 = New System.Windows.Forms.Button()
		Me.cmd5 = New System.Windows.Forms.Button()
		Me.cmd4 = New System.Windows.Forms.Button()
		Me.cmd3 = New System.Windows.Forms.Button()
		Me.cmd2 = New System.Windows.Forms.Button()
		Me.cmd1 = New System.Windows.Forms.Button()
		Me.PnlStatus = New System.Windows.Forms.Panel()
		Me.GrpComputer = New System.Windows.Forms.GroupBox()
		Me.LblComputerTime = New System.Windows.Forms.Label()
		Me.LblComputerLastMove = New System.Windows.Forms.Label()
		Me.LblComputerScore = New System.Windows.Forms.Label()
		Me.LblComputerTimeLbl = New System.Windows.Forms.Label()
		Me.LblComputerLastMoveLbl = New System.Windows.Forms.Label()
		Me.LblComputerScoreLbl = New System.Windows.Forms.Label()
		Me.GrpPlayer = New System.Windows.Forms.GroupBox()
		Me.LblPlayerTime = New System.Windows.Forms.Label()
		Me.LblPlayerLastMove = New System.Windows.Forms.Label()
		Me.LblPlayerScore = New System.Windows.Forms.Label()
		Me.LblPlayerTimeLbl = New System.Windows.Forms.Label()
		Me.LblPlayerLastMoveLbl = New System.Windows.Forms.Label()
		Me.LblPlayerScoreLbl = New System.Windows.Forms.Label()
		Me.TxtStatus = New System.Windows.Forms.TextBox()
		Me.PnlPawns.SuspendLayout()
		Me.PnlButtons.SuspendLayout()
		Me.PnlStatus.SuspendLayout()
		Me.GrpComputer.SuspendLayout()
		Me.GrpPlayer.SuspendLayout()
		Me.SuspendLayout()
		'
		'MnuMain
		'
		Me.MnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGame, Me.MnuHelp})
		'
		'MnuGame
		'
		Me.MnuGame.Index = 0
		Me.MnuGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuGameNew, Me.MnuGameSeperator1, Me.MnuGameExit})
		Me.MnuGame.Text = "&Game"
		'
		'MnuGameNew
		'
		Me.MnuGameNew.Index = 0
		Me.MnuGameNew.Shortcut = System.Windows.Forms.Shortcut.F2
		Me.MnuGameNew.Text = "&New"
		'
		'MnuGameSeperator1
		'
		Me.MnuGameSeperator1.Index = 1
		Me.MnuGameSeperator1.Text = "-"
		'
		'MnuGameExit
		'
		Me.MnuGameExit.Index = 2
		Me.MnuGameExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
		Me.MnuGameExit.Text = "E&xit"
		'
		'MnuHelp
		'
		Me.MnuHelp.Index = 1
		Me.MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuHelpHowTo, Me.MnuHelpHint, Me.MnuHelpSeperator1, Me.MnuHelpAbout})
		Me.MnuHelp.Text = "&Help"
		'
		'MnuHelpHowTo
		'
		Me.MnuHelpHowTo.Index = 0
		Me.MnuHelpHowTo.Shortcut = System.Windows.Forms.Shortcut.F1
		Me.MnuHelpHowTo.Text = "How &To..."
		'
		'MnuHelpHint
		'
		Me.MnuHelpHint.Index = 1
		Me.MnuHelpHint.Shortcut = System.Windows.Forms.Shortcut.ShiftF1
		Me.MnuHelpHint.Text = "Hi&nt..."
		'
		'MnuHelpSeperator1
		'
		Me.MnuHelpSeperator1.Index = 2
		Me.MnuHelpSeperator1.Text = "-"
		'
		'MnuHelpAbout
		'
		Me.MnuHelpAbout.Index = 3
		Me.MnuHelpAbout.Shortcut = System.Windows.Forms.Shortcut.AltF1
		Me.MnuHelpAbout.Text = "&About 4Play..."
		'
		'TmrUpdate
		'
		Me.TmrUpdate.Enabled = True
		'
		'PnlPawns
		'
		Me.PnlPawns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PnlPawns.Controls.Add(Me.lbl6_5)
		Me.PnlPawns.Controls.Add(Me.lbl6_4)
		Me.PnlPawns.Controls.Add(Me.lbl6_3)
		Me.PnlPawns.Controls.Add(Me.lbl6_2)
		Me.PnlPawns.Controls.Add(Me.lbl6_1)
		Me.PnlPawns.Controls.Add(Me.lbl6_0)
		Me.PnlPawns.Controls.Add(Me.lbl5_5)
		Me.PnlPawns.Controls.Add(Me.lbl5_4)
		Me.PnlPawns.Controls.Add(Me.lbl5_3)
		Me.PnlPawns.Controls.Add(Me.lbl5_2)
		Me.PnlPawns.Controls.Add(Me.lbl5_1)
		Me.PnlPawns.Controls.Add(Me.lbl5_0)
		Me.PnlPawns.Controls.Add(Me.lbl4_5)
		Me.PnlPawns.Controls.Add(Me.lbl4_4)
		Me.PnlPawns.Controls.Add(Me.lbl4_3)
		Me.PnlPawns.Controls.Add(Me.lbl4_2)
		Me.PnlPawns.Controls.Add(Me.lbl4_1)
		Me.PnlPawns.Controls.Add(Me.lbl4_0)
		Me.PnlPawns.Controls.Add(Me.lbl3_5)
		Me.PnlPawns.Controls.Add(Me.lbl3_4)
		Me.PnlPawns.Controls.Add(Me.lbl3_3)
		Me.PnlPawns.Controls.Add(Me.lbl3_2)
		Me.PnlPawns.Controls.Add(Me.lbl3_1)
		Me.PnlPawns.Controls.Add(Me.lbl3_0)
		Me.PnlPawns.Controls.Add(Me.lbl2_5)
		Me.PnlPawns.Controls.Add(Me.lbl2_4)
		Me.PnlPawns.Controls.Add(Me.lbl2_3)
		Me.PnlPawns.Controls.Add(Me.lbl2_2)
		Me.PnlPawns.Controls.Add(Me.lbl2_1)
		Me.PnlPawns.Controls.Add(Me.lbl2_0)
		Me.PnlPawns.Controls.Add(Me.lbl1_5)
		Me.PnlPawns.Controls.Add(Me.lbl1_4)
		Me.PnlPawns.Controls.Add(Me.lbl1_3)
		Me.PnlPawns.Controls.Add(Me.lbl1_2)
		Me.PnlPawns.Controls.Add(Me.lbl1_1)
		Me.PnlPawns.Controls.Add(Me.lbl1_0)
		Me.PnlPawns.Controls.Add(Me.lbl0_5)
		Me.PnlPawns.Controls.Add(Me.lbl0_4)
		Me.PnlPawns.Controls.Add(Me.lbl0_3)
		Me.PnlPawns.Controls.Add(Me.lbl0_2)
		Me.PnlPawns.Controls.Add(Me.lbl0_1)
		Me.PnlPawns.Controls.Add(Me.lbl0_0)
		Me.PnlPawns.Location = New System.Drawing.Point(8, 8)
		Me.PnlPawns.Name = "PnlPawns"
		Me.PnlPawns.Size = New System.Drawing.Size(292, 252)
		Me.PnlPawns.TabIndex = 0
		'
		'lbl6_5
		'
		Me.lbl6_5.BackColor = System.Drawing.Color.Blue
		Me.lbl6_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl6_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl6_5.Location = New System.Drawing.Point(248, 8)
		Me.lbl6_5.Name = "lbl6_5"
		Me.lbl6_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_5.TabIndex = 41
		Me.lbl6_5.Text = "n"
		Me.lbl6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_5.UseMnemonic = False
		'
		'lbl6_4
		'
		Me.lbl6_4.BackColor = System.Drawing.Color.Blue
		Me.lbl6_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl6_4.ForeColor = System.Drawing.Color.Red
		Me.lbl6_4.Location = New System.Drawing.Point(248, 48)
		Me.lbl6_4.Name = "lbl6_4"
		Me.lbl6_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_4.TabIndex = 40
		Me.lbl6_4.Text = "n"
		Me.lbl6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_4.UseMnemonic = False
		'
		'lbl6_3
		'
		Me.lbl6_3.BackColor = System.Drawing.Color.Blue
		Me.lbl6_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl6_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl6_3.Location = New System.Drawing.Point(248, 88)
		Me.lbl6_3.Name = "lbl6_3"
		Me.lbl6_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_3.TabIndex = 39
		Me.lbl6_3.Text = "n"
		Me.lbl6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_3.UseMnemonic = False
		'
		'lbl6_2
		'
		Me.lbl6_2.BackColor = System.Drawing.Color.Blue
		Me.lbl6_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl6_2.ForeColor = System.Drawing.Color.Red
		Me.lbl6_2.Location = New System.Drawing.Point(248, 128)
		Me.lbl6_2.Name = "lbl6_2"
		Me.lbl6_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_2.TabIndex = 38
		Me.lbl6_2.Text = "n"
		Me.lbl6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_2.UseMnemonic = False
		'
		'lbl6_1
		'
		Me.lbl6_1.BackColor = System.Drawing.Color.Blue
		Me.lbl6_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl6_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl6_1.Location = New System.Drawing.Point(248, 168)
		Me.lbl6_1.Name = "lbl6_1"
		Me.lbl6_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_1.TabIndex = 37
		Me.lbl6_1.Text = "n"
		Me.lbl6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_1.UseMnemonic = False
		'
		'lbl6_0
		'
		Me.lbl6_0.BackColor = System.Drawing.Color.Blue
		Me.lbl6_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl6_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl6_0.ForeColor = System.Drawing.Color.Red
		Me.lbl6_0.Location = New System.Drawing.Point(248, 208)
		Me.lbl6_0.Name = "lbl6_0"
		Me.lbl6_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl6_0.TabIndex = 36
		Me.lbl6_0.Text = "n"
		Me.lbl6_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl6_0.UseMnemonic = False
		'
		'lbl5_5
		'
		Me.lbl5_5.BackColor = System.Drawing.Color.Blue
		Me.lbl5_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl5_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl5_5.Location = New System.Drawing.Point(208, 8)
		Me.lbl5_5.Name = "lbl5_5"
		Me.lbl5_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_5.TabIndex = 35
		Me.lbl5_5.Text = "n"
		Me.lbl5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_5.UseMnemonic = False
		'
		'lbl5_4
		'
		Me.lbl5_4.BackColor = System.Drawing.Color.Blue
		Me.lbl5_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl5_4.ForeColor = System.Drawing.Color.Red
		Me.lbl5_4.Location = New System.Drawing.Point(208, 48)
		Me.lbl5_4.Name = "lbl5_4"
		Me.lbl5_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_4.TabIndex = 34
		Me.lbl5_4.Text = "n"
		Me.lbl5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_4.UseMnemonic = False
		'
		'lbl5_3
		'
		Me.lbl5_3.BackColor = System.Drawing.Color.Blue
		Me.lbl5_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl5_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl5_3.Location = New System.Drawing.Point(208, 88)
		Me.lbl5_3.Name = "lbl5_3"
		Me.lbl5_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_3.TabIndex = 33
		Me.lbl5_3.Text = "n"
		Me.lbl5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_3.UseMnemonic = False
		'
		'lbl5_2
		'
		Me.lbl5_2.BackColor = System.Drawing.Color.Blue
		Me.lbl5_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl5_2.ForeColor = System.Drawing.Color.Red
		Me.lbl5_2.Location = New System.Drawing.Point(208, 128)
		Me.lbl5_2.Name = "lbl5_2"
		Me.lbl5_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_2.TabIndex = 32
		Me.lbl5_2.Text = "n"
		Me.lbl5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_2.UseMnemonic = False
		'
		'lbl5_1
		'
		Me.lbl5_1.BackColor = System.Drawing.Color.Blue
		Me.lbl5_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl5_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl5_1.Location = New System.Drawing.Point(208, 168)
		Me.lbl5_1.Name = "lbl5_1"
		Me.lbl5_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_1.TabIndex = 31
		Me.lbl5_1.Text = "n"
		Me.lbl5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_1.UseMnemonic = False
		'
		'lbl5_0
		'
		Me.lbl5_0.BackColor = System.Drawing.Color.Blue
		Me.lbl5_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl5_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl5_0.ForeColor = System.Drawing.Color.Red
		Me.lbl5_0.Location = New System.Drawing.Point(208, 208)
		Me.lbl5_0.Name = "lbl5_0"
		Me.lbl5_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl5_0.TabIndex = 30
		Me.lbl5_0.Text = "n"
		Me.lbl5_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl5_0.UseMnemonic = False
		'
		'lbl4_5
		'
		Me.lbl4_5.BackColor = System.Drawing.Color.Blue
		Me.lbl4_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl4_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl4_5.Location = New System.Drawing.Point(168, 8)
		Me.lbl4_5.Name = "lbl4_5"
		Me.lbl4_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_5.TabIndex = 29
		Me.lbl4_5.Text = "n"
		Me.lbl4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_5.UseMnemonic = False
		'
		'lbl4_4
		'
		Me.lbl4_4.BackColor = System.Drawing.Color.Blue
		Me.lbl4_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl4_4.ForeColor = System.Drawing.Color.Red
		Me.lbl4_4.Location = New System.Drawing.Point(168, 48)
		Me.lbl4_4.Name = "lbl4_4"
		Me.lbl4_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_4.TabIndex = 28
		Me.lbl4_4.Text = "n"
		Me.lbl4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_4.UseMnemonic = False
		'
		'lbl4_3
		'
		Me.lbl4_3.BackColor = System.Drawing.Color.Blue
		Me.lbl4_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl4_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl4_3.Location = New System.Drawing.Point(168, 88)
		Me.lbl4_3.Name = "lbl4_3"
		Me.lbl4_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_3.TabIndex = 27
		Me.lbl4_3.Text = "n"
		Me.lbl4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_3.UseMnemonic = False
		'
		'lbl4_2
		'
		Me.lbl4_2.BackColor = System.Drawing.Color.Blue
		Me.lbl4_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl4_2.ForeColor = System.Drawing.Color.Red
		Me.lbl4_2.Location = New System.Drawing.Point(168, 128)
		Me.lbl4_2.Name = "lbl4_2"
		Me.lbl4_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_2.TabIndex = 26
		Me.lbl4_2.Text = "n"
		Me.lbl4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_2.UseMnemonic = False
		'
		'lbl4_1
		'
		Me.lbl4_1.BackColor = System.Drawing.Color.Blue
		Me.lbl4_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl4_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl4_1.Location = New System.Drawing.Point(168, 168)
		Me.lbl4_1.Name = "lbl4_1"
		Me.lbl4_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_1.TabIndex = 25
		Me.lbl4_1.Text = "n"
		Me.lbl4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_1.UseMnemonic = False
		'
		'lbl4_0
		'
		Me.lbl4_0.BackColor = System.Drawing.Color.Blue
		Me.lbl4_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl4_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl4_0.ForeColor = System.Drawing.Color.Red
		Me.lbl4_0.Location = New System.Drawing.Point(168, 208)
		Me.lbl4_0.Name = "lbl4_0"
		Me.lbl4_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl4_0.TabIndex = 24
		Me.lbl4_0.Text = "n"
		Me.lbl4_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl4_0.UseMnemonic = False
		'
		'lbl3_5
		'
		Me.lbl3_5.BackColor = System.Drawing.Color.Blue
		Me.lbl3_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl3_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl3_5.Location = New System.Drawing.Point(128, 8)
		Me.lbl3_5.Name = "lbl3_5"
		Me.lbl3_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_5.TabIndex = 23
		Me.lbl3_5.Text = "n"
		Me.lbl3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_5.UseMnemonic = False
		'
		'lbl3_4
		'
		Me.lbl3_4.BackColor = System.Drawing.Color.Blue
		Me.lbl3_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl3_4.ForeColor = System.Drawing.Color.Red
		Me.lbl3_4.Location = New System.Drawing.Point(128, 48)
		Me.lbl3_4.Name = "lbl3_4"
		Me.lbl3_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_4.TabIndex = 22
		Me.lbl3_4.Text = "n"
		Me.lbl3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_4.UseMnemonic = False
		'
		'lbl3_3
		'
		Me.lbl3_3.BackColor = System.Drawing.Color.Blue
		Me.lbl3_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl3_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl3_3.Location = New System.Drawing.Point(128, 88)
		Me.lbl3_3.Name = "lbl3_3"
		Me.lbl3_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_3.TabIndex = 21
		Me.lbl3_3.Text = "n"
		Me.lbl3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_3.UseMnemonic = False
		'
		'lbl3_2
		'
		Me.lbl3_2.BackColor = System.Drawing.Color.Blue
		Me.lbl3_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl3_2.ForeColor = System.Drawing.Color.Red
		Me.lbl3_2.Location = New System.Drawing.Point(128, 128)
		Me.lbl3_2.Name = "lbl3_2"
		Me.lbl3_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_2.TabIndex = 20
		Me.lbl3_2.Text = "n"
		Me.lbl3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_2.UseMnemonic = False
		'
		'lbl3_1
		'
		Me.lbl3_1.BackColor = System.Drawing.Color.Blue
		Me.lbl3_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl3_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl3_1.Location = New System.Drawing.Point(128, 168)
		Me.lbl3_1.Name = "lbl3_1"
		Me.lbl3_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_1.TabIndex = 19
		Me.lbl3_1.Text = "n"
		Me.lbl3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_1.UseMnemonic = False
		'
		'lbl3_0
		'
		Me.lbl3_0.BackColor = System.Drawing.Color.Blue
		Me.lbl3_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl3_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl3_0.ForeColor = System.Drawing.Color.Red
		Me.lbl3_0.Location = New System.Drawing.Point(128, 208)
		Me.lbl3_0.Name = "lbl3_0"
		Me.lbl3_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl3_0.TabIndex = 18
		Me.lbl3_0.Text = "n"
		Me.lbl3_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl3_0.UseMnemonic = False
		'
		'lbl2_5
		'
		Me.lbl2_5.BackColor = System.Drawing.Color.Blue
		Me.lbl2_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl2_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl2_5.Location = New System.Drawing.Point(88, 8)
		Me.lbl2_5.Name = "lbl2_5"
		Me.lbl2_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_5.TabIndex = 17
		Me.lbl2_5.Text = "n"
		Me.lbl2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_5.UseMnemonic = False
		'
		'lbl2_4
		'
		Me.lbl2_4.BackColor = System.Drawing.Color.Blue
		Me.lbl2_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl2_4.ForeColor = System.Drawing.Color.Red
		Me.lbl2_4.Location = New System.Drawing.Point(88, 48)
		Me.lbl2_4.Name = "lbl2_4"
		Me.lbl2_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_4.TabIndex = 16
		Me.lbl2_4.Text = "n"
		Me.lbl2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_4.UseMnemonic = False
		'
		'lbl2_3
		'
		Me.lbl2_3.BackColor = System.Drawing.Color.Blue
		Me.lbl2_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl2_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl2_3.Location = New System.Drawing.Point(88, 88)
		Me.lbl2_3.Name = "lbl2_3"
		Me.lbl2_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_3.TabIndex = 15
		Me.lbl2_3.Text = "n"
		Me.lbl2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_3.UseMnemonic = False
		'
		'lbl2_2
		'
		Me.lbl2_2.BackColor = System.Drawing.Color.Blue
		Me.lbl2_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl2_2.ForeColor = System.Drawing.Color.Red
		Me.lbl2_2.Location = New System.Drawing.Point(88, 128)
		Me.lbl2_2.Name = "lbl2_2"
		Me.lbl2_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_2.TabIndex = 14
		Me.lbl2_2.Text = "n"
		Me.lbl2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_2.UseMnemonic = False
		'
		'lbl2_1
		'
		Me.lbl2_1.BackColor = System.Drawing.Color.Blue
		Me.lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl2_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl2_1.Location = New System.Drawing.Point(88, 168)
		Me.lbl2_1.Name = "lbl2_1"
		Me.lbl2_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_1.TabIndex = 13
		Me.lbl2_1.Text = "n"
		Me.lbl2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_1.UseMnemonic = False
		'
		'lbl2_0
		'
		Me.lbl2_0.BackColor = System.Drawing.Color.Blue
		Me.lbl2_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl2_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl2_0.ForeColor = System.Drawing.Color.Red
		Me.lbl2_0.Location = New System.Drawing.Point(88, 208)
		Me.lbl2_0.Name = "lbl2_0"
		Me.lbl2_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl2_0.TabIndex = 12
		Me.lbl2_0.Text = "n"
		Me.lbl2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl2_0.UseMnemonic = False
		'
		'lbl1_5
		'
		Me.lbl1_5.BackColor = System.Drawing.Color.Blue
		Me.lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl1_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl1_5.Location = New System.Drawing.Point(48, 8)
		Me.lbl1_5.Name = "lbl1_5"
		Me.lbl1_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_5.TabIndex = 11
		Me.lbl1_5.Text = "n"
		Me.lbl1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_5.UseMnemonic = False
		'
		'lbl1_4
		'
		Me.lbl1_4.BackColor = System.Drawing.Color.Blue
		Me.lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl1_4.ForeColor = System.Drawing.Color.Red
		Me.lbl1_4.Location = New System.Drawing.Point(48, 48)
		Me.lbl1_4.Name = "lbl1_4"
		Me.lbl1_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_4.TabIndex = 10
		Me.lbl1_4.Text = "n"
		Me.lbl1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_4.UseMnemonic = False
		'
		'lbl1_3
		'
		Me.lbl1_3.BackColor = System.Drawing.Color.Blue
		Me.lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl1_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl1_3.Location = New System.Drawing.Point(48, 88)
		Me.lbl1_3.Name = "lbl1_3"
		Me.lbl1_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_3.TabIndex = 9
		Me.lbl1_3.Text = "n"
		Me.lbl1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_3.UseMnemonic = False
		'
		'lbl1_2
		'
		Me.lbl1_2.BackColor = System.Drawing.Color.Blue
		Me.lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl1_2.ForeColor = System.Drawing.Color.Red
		Me.lbl1_2.Location = New System.Drawing.Point(48, 128)
		Me.lbl1_2.Name = "lbl1_2"
		Me.lbl1_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_2.TabIndex = 8
		Me.lbl1_2.Text = "n"
		Me.lbl1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_2.UseMnemonic = False
		'
		'lbl1_1
		'
		Me.lbl1_1.BackColor = System.Drawing.Color.Blue
		Me.lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl1_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl1_1.Location = New System.Drawing.Point(48, 168)
		Me.lbl1_1.Name = "lbl1_1"
		Me.lbl1_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_1.TabIndex = 7
		Me.lbl1_1.Text = "n"
		Me.lbl1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_1.UseMnemonic = False
		'
		'lbl1_0
		'
		Me.lbl1_0.BackColor = System.Drawing.Color.Blue
		Me.lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl1_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl1_0.ForeColor = System.Drawing.Color.Red
		Me.lbl1_0.Location = New System.Drawing.Point(48, 208)
		Me.lbl1_0.Name = "lbl1_0"
		Me.lbl1_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl1_0.TabIndex = 6
		Me.lbl1_0.Text = "n"
		Me.lbl1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl1_0.UseMnemonic = False
		'
		'lbl0_5
		'
		Me.lbl0_5.BackColor = System.Drawing.Color.Blue
		Me.lbl0_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_5.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl0_5.ForeColor = System.Drawing.Color.Yellow
		Me.lbl0_5.Location = New System.Drawing.Point(8, 8)
		Me.lbl0_5.Name = "lbl0_5"
		Me.lbl0_5.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_5.TabIndex = 5
		Me.lbl0_5.Text = "n"
		Me.lbl0_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_5.UseMnemonic = False
		'
		'lbl0_4
		'
		Me.lbl0_4.BackColor = System.Drawing.Color.Blue
		Me.lbl0_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_4.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl0_4.ForeColor = System.Drawing.Color.Red
		Me.lbl0_4.Location = New System.Drawing.Point(8, 48)
		Me.lbl0_4.Name = "lbl0_4"
		Me.lbl0_4.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_4.TabIndex = 4
		Me.lbl0_4.Text = "n"
		Me.lbl0_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_4.UseMnemonic = False
		'
		'lbl0_3
		'
		Me.lbl0_3.BackColor = System.Drawing.Color.Blue
		Me.lbl0_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_3.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl0_3.ForeColor = System.Drawing.Color.Yellow
		Me.lbl0_3.Location = New System.Drawing.Point(8, 88)
		Me.lbl0_3.Name = "lbl0_3"
		Me.lbl0_3.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_3.TabIndex = 3
		Me.lbl0_3.Text = "n"
		Me.lbl0_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_3.UseMnemonic = False
		'
		'lbl0_2
		'
		Me.lbl0_2.BackColor = System.Drawing.Color.Blue
		Me.lbl0_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_2.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl0_2.ForeColor = System.Drawing.Color.Red
		Me.lbl0_2.Location = New System.Drawing.Point(8, 128)
		Me.lbl0_2.Name = "lbl0_2"
		Me.lbl0_2.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_2.TabIndex = 2
		Me.lbl0_2.Text = "n"
		Me.lbl0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_2.UseMnemonic = False
		'
		'lbl0_1
		'
		Me.lbl0_1.BackColor = System.Drawing.Color.Blue
		Me.lbl0_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl0_1.ForeColor = System.Drawing.Color.Yellow
		Me.lbl0_1.Location = New System.Drawing.Point(8, 168)
		Me.lbl0_1.Name = "lbl0_1"
		Me.lbl0_1.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_1.TabIndex = 1
		Me.lbl0_1.Text = "n"
		Me.lbl0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_1.UseMnemonic = False
		'
		'lbl0_0
		'
		Me.lbl0_0.BackColor = System.Drawing.Color.Blue
		Me.lbl0_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lbl0_0.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lbl0_0.ForeColor = System.Drawing.Color.Red
		Me.lbl0_0.Location = New System.Drawing.Point(8, 208)
		Me.lbl0_0.Name = "lbl0_0"
		Me.lbl0_0.Size = New System.Drawing.Size(32, 32)
		Me.lbl0_0.TabIndex = 0
		Me.lbl0_0.Text = "n"
		Me.lbl0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.lbl0_0.UseMnemonic = False
		'
		'PnlButtons
		'
		Me.PnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PnlButtons.Controls.Add(Me.cmd7)
		Me.PnlButtons.Controls.Add(Me.cmd6)
		Me.PnlButtons.Controls.Add(Me.cmd5)
		Me.PnlButtons.Controls.Add(Me.cmd4)
		Me.PnlButtons.Controls.Add(Me.cmd3)
		Me.PnlButtons.Controls.Add(Me.cmd2)
		Me.PnlButtons.Controls.Add(Me.cmd1)
		Me.PnlButtons.Location = New System.Drawing.Point(8, 268)
		Me.PnlButtons.Name = "PnlButtons"
		Me.PnlButtons.Size = New System.Drawing.Size(292, 52)
		Me.PnlButtons.TabIndex = 1
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
		'PnlStatus
		'
		Me.PnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PnlStatus.Controls.Add(Me.GrpComputer)
		Me.PnlStatus.Controls.Add(Me.GrpPlayer)
		Me.PnlStatus.Location = New System.Drawing.Point(308, 8)
		Me.PnlStatus.Name = "PnlStatus"
		Me.PnlStatus.Size = New System.Drawing.Size(188, 228)
		Me.PnlStatus.TabIndex = 2
		'
		'GrpComputer
		'
		Me.GrpComputer.Controls.Add(Me.LblComputerTime)
		Me.GrpComputer.Controls.Add(Me.LblComputerLastMove)
		Me.GrpComputer.Controls.Add(Me.LblComputerScore)
		Me.GrpComputer.Controls.Add(Me.LblComputerTimeLbl)
		Me.GrpComputer.Controls.Add(Me.LblComputerLastMoveLbl)
		Me.GrpComputer.Controls.Add(Me.LblComputerScoreLbl)
		Me.GrpComputer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.GrpComputer.Location = New System.Drawing.Point(8, 116)
		Me.GrpComputer.Name = "GrpComputer"
		Me.GrpComputer.Size = New System.Drawing.Size(168, 100)
		Me.GrpComputer.TabIndex = 1
		Me.GrpComputer.TabStop = False
		Me.GrpComputer.Text = "Computer (O):"
		'
		'LblComputerTime
		'
		Me.LblComputerTime.AutoSize = True
		Me.LblComputerTime.Location = New System.Drawing.Point(104, 72)
		Me.LblComputerTime.Name = "LblComputerTime"
		Me.LblComputerTime.Size = New System.Drawing.Size(49, 13)
		Me.LblComputerTime.TabIndex = 5
		Me.LblComputerTime.Text = "00:00:00"
		Me.LblComputerTime.UseMnemonic = False
		'
		'LblComputerLastMove
		'
		Me.LblComputerLastMove.AutoSize = True
		Me.LblComputerLastMove.Location = New System.Drawing.Point(104, 48)
		Me.LblComputerLastMove.Name = "LblComputerLastMove"
		Me.LblComputerLastMove.Size = New System.Drawing.Size(13, 13)
		Me.LblComputerLastMove.TabIndex = 3
		Me.LblComputerLastMove.Text = "0"
		Me.LblComputerLastMove.UseMnemonic = False
		'
		'LblComputerScore
		'
		Me.LblComputerScore.AutoSize = True
		Me.LblComputerScore.Location = New System.Drawing.Point(104, 24)
		Me.LblComputerScore.Name = "LblComputerScore"
		Me.LblComputerScore.Size = New System.Drawing.Size(13, 13)
		Me.LblComputerScore.TabIndex = 1
		Me.LblComputerScore.Text = "0"
		Me.LblComputerScore.UseMnemonic = False
		'
		'LblComputerTimeLbl
		'
		Me.LblComputerTimeLbl.AutoSize = True
		Me.LblComputerTimeLbl.Location = New System.Drawing.Point(36, 72)
		Me.LblComputerTimeLbl.Name = "LblComputerTimeLbl"
		Me.LblComputerTimeLbl.Size = New System.Drawing.Size(33, 13)
		Me.LblComputerTimeLbl.TabIndex = 4
		Me.LblComputerTimeLbl.Text = "Time:"
		Me.LblComputerTimeLbl.UseMnemonic = False
		'
		'LblComputerLastMoveLbl
		'
		Me.LblComputerLastMoveLbl.AutoSize = True
		Me.LblComputerLastMoveLbl.Location = New System.Drawing.Point(12, 48)
		Me.LblComputerLastMoveLbl.Name = "LblComputerLastMoveLbl"
		Me.LblComputerLastMoveLbl.Size = New System.Drawing.Size(60, 13)
		Me.LblComputerLastMoveLbl.TabIndex = 2
		Me.LblComputerLastMoveLbl.Text = "Last Move:"
		Me.LblComputerLastMoveLbl.UseMnemonic = False
		'
		'LblComputerScoreLbl
		'
		Me.LblComputerScoreLbl.AutoSize = True
		Me.LblComputerScoreLbl.Location = New System.Drawing.Point(32, 24)
		Me.LblComputerScoreLbl.Name = "LblComputerScoreLbl"
		Me.LblComputerScoreLbl.Size = New System.Drawing.Size(38, 13)
		Me.LblComputerScoreLbl.TabIndex = 0
		Me.LblComputerScoreLbl.Text = "Score:"
		Me.LblComputerScoreLbl.UseMnemonic = False
		'
		'GrpPlayer
		'
		Me.GrpPlayer.Controls.Add(Me.LblPlayerTime)
		Me.GrpPlayer.Controls.Add(Me.LblPlayerLastMove)
		Me.GrpPlayer.Controls.Add(Me.LblPlayerScore)
		Me.GrpPlayer.Controls.Add(Me.LblPlayerTimeLbl)
		Me.GrpPlayer.Controls.Add(Me.LblPlayerLastMoveLbl)
		Me.GrpPlayer.Controls.Add(Me.LblPlayerScoreLbl)
		Me.GrpPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.GrpPlayer.Location = New System.Drawing.Point(8, 8)
		Me.GrpPlayer.Name = "GrpPlayer"
		Me.GrpPlayer.Size = New System.Drawing.Size(168, 100)
		Me.GrpPlayer.TabIndex = 0
		Me.GrpPlayer.TabStop = False
		Me.GrpPlayer.Text = "Player (X):"
		'
		'LblPlayerTime
		'
		Me.LblPlayerTime.AutoSize = True
		Me.LblPlayerTime.Location = New System.Drawing.Point(104, 72)
		Me.LblPlayerTime.Name = "LblPlayerTime"
		Me.LblPlayerTime.Size = New System.Drawing.Size(49, 13)
		Me.LblPlayerTime.TabIndex = 5
		Me.LblPlayerTime.Text = "00:00:00"
		Me.LblPlayerTime.UseMnemonic = False
		'
		'LblPlayerLastMove
		'
		Me.LblPlayerLastMove.AutoSize = True
		Me.LblPlayerLastMove.Location = New System.Drawing.Point(104, 48)
		Me.LblPlayerLastMove.Name = "LblPlayerLastMove"
		Me.LblPlayerLastMove.Size = New System.Drawing.Size(13, 13)
		Me.LblPlayerLastMove.TabIndex = 3
		Me.LblPlayerLastMove.Text = "0"
		Me.LblPlayerLastMove.UseMnemonic = False
		'
		'LblPlayerScore
		'
		Me.LblPlayerScore.AutoSize = True
		Me.LblPlayerScore.Location = New System.Drawing.Point(104, 24)
		Me.LblPlayerScore.Name = "LblPlayerScore"
		Me.LblPlayerScore.Size = New System.Drawing.Size(13, 13)
		Me.LblPlayerScore.TabIndex = 1
		Me.LblPlayerScore.Text = "0"
		Me.LblPlayerScore.UseMnemonic = False
		'
		'LblPlayerTimeLbl
		'
		Me.LblPlayerTimeLbl.AutoSize = True
		Me.LblPlayerTimeLbl.Location = New System.Drawing.Point(36, 72)
		Me.LblPlayerTimeLbl.Name = "LblPlayerTimeLbl"
		Me.LblPlayerTimeLbl.Size = New System.Drawing.Size(33, 13)
		Me.LblPlayerTimeLbl.TabIndex = 4
		Me.LblPlayerTimeLbl.Text = "Time:"
		Me.LblPlayerTimeLbl.UseMnemonic = False
		'
		'LblPlayerLastMoveLbl
		'
		Me.LblPlayerLastMoveLbl.AutoSize = True
		Me.LblPlayerLastMoveLbl.Location = New System.Drawing.Point(12, 48)
		Me.LblPlayerLastMoveLbl.Name = "LblPlayerLastMoveLbl"
		Me.LblPlayerLastMoveLbl.Size = New System.Drawing.Size(60, 13)
		Me.LblPlayerLastMoveLbl.TabIndex = 2
		Me.LblPlayerLastMoveLbl.Text = "Last Move:"
		Me.LblPlayerLastMoveLbl.UseMnemonic = False
		'
		'LblPlayerScoreLbl
		'
		Me.LblPlayerScoreLbl.AutoSize = True
		Me.LblPlayerScoreLbl.Location = New System.Drawing.Point(32, 24)
		Me.LblPlayerScoreLbl.Name = "LblPlayerScoreLbl"
		Me.LblPlayerScoreLbl.Size = New System.Drawing.Size(38, 13)
		Me.LblPlayerScoreLbl.TabIndex = 0
		Me.LblPlayerScoreLbl.Text = "Score:"
		Me.LblPlayerScoreLbl.UseMnemonic = False
		'
		'TxtStatus
		'
		Me.TxtStatus.BackColor = System.Drawing.Color.Black
		Me.TxtStatus.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtStatus.ForeColor = System.Drawing.Color.Red
		Me.TxtStatus.Location = New System.Drawing.Point(308, 244)
		Me.TxtStatus.Multiline = True
		Me.TxtStatus.Name = "TxtStatus"
		Me.TxtStatus.ReadOnly = True
		Me.TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxtStatus.Size = New System.Drawing.Size(188, 76)
		Me.TxtStatus.TabIndex = 3
		Me.TxtStatus.TabStop = False
		Me.TxtStatus.Text = "Ready!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!!!!"
		'
		'FrmMain
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(504, 327)
		Me.Controls.Add(Me.TxtStatus)
		Me.Controls.Add(Me.PnlStatus)
		Me.Controls.Add(Me.PnlButtons)
		Me.Controls.Add(Me.PnlPawns)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Menu = Me.MnuMain
		Me.Name = "FrmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "4Play"
		Me.PnlPawns.ResumeLayout(False)
		Me.PnlButtons.ResumeLayout(False)
		Me.PnlStatus.ResumeLayout(False)
		Me.GrpComputer.ResumeLayout(False)
		Me.GrpComputer.PerformLayout()
		Me.GrpPlayer.ResumeLayout(False)
		Me.GrpPlayer.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

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
		Dim sTmp As String = vbNullString

		If iMessageLine <= MaxStatusLine Then
			sMessages(iMessageLine) = Note
			iMessageLine += 1
		Else
			' We are past the last message line, so we need to shift all messages up
			For i = 1 To MaxStatusLine
				sMessages(i - 1) = sMessages(i)
			Next
			sMessages(MaxStatusLine) = Note
		End If

		' Now lets referesh out status box
		For i = 0 To MaxStatusLine
			If sMessages(i) <> vbNullString Then
				If sTmp = vbNullString Then
					sTmp = sMessages(i)
				Else
					sTmp = sTmp & vbNewLine & sMessages(i)
				End If
			End If
		Next

		TxtStatus.Text = sTmp
		TxtStatus.SelectionLength = 0
		TxtStatus.SelectionStart = Len(sTmp)
		TxtStatus.ScrollToCaret()
	End Sub

	Private Sub CmdColumn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click
		Static bInCmdColumnClick As Boolean
		Dim Index As Integer = CInt(CType(sender, Button).Tag)
		Dim i As Integer

		' Don't allow reentry by the user if computer is playing
		If bInCmdColumnClick Then Exit Sub
		bInCmdColumnClick = True

		' Player's move
		If GameEngine.CurrentPlayer = Cls4Play.Player1Chip Then
			If GameEngine.PutChipInRow(Index) Then
				PlayerMove = Index + 1
				DrawChips()
				GameEngine.SwitchPlayers()
				Application.DoEvents()
			End If
		End If

		' Disable housefull columns
		cmd1.Enabled = GameEngine.GetTotalMovesInRow(0) <= Cls4Play.MaxY
		cmd2.Enabled = GameEngine.GetTotalMovesInRow(1) <= Cls4Play.MaxY
		cmd3.Enabled = GameEngine.GetTotalMovesInRow(2) <= Cls4Play.MaxY
		cmd4.Enabled = GameEngine.GetTotalMovesInRow(3) <= Cls4Play.MaxY
		cmd5.Enabled = GameEngine.GetTotalMovesInRow(4) <= Cls4Play.MaxY
		cmd6.Enabled = GameEngine.GetTotalMovesInRow(5) <= Cls4Play.MaxY
		cmd7.Enabled = GameEngine.GetTotalMovesInRow(6) <= Cls4Play.MaxY

		' Check all possible cases (fixes an old bug)
		If GameEngine.IsWinner(Cls4Play.Player1Chip) Then
			DrawChips()
			TmrUpdate_Tick(TmrUpdate, New System.EventArgs())
			MsgBox("You win!", MsgBoxStyle.Exclamation)
			NewGame()
			PlayerScore += 1
			bInCmdColumnClick = False
			Exit Sub
		ElseIf GameEngine.IsWinner(Cls4Play.Player2Chip) Then
			DrawChips()
			TmrUpdate_Tick(TmrUpdate, New System.EventArgs())
			MsgBox("I win!", MsgBoxStyle.Exclamation)
			NewGame()
			ComputerScore += 1
			bInCmdColumnClick = False
			Exit Sub
		ElseIf GameEngine.IsGameDraw() Then
			TmrUpdate_Tick(TmrUpdate, New System.EventArgs())
			MsgBox("It's a draw!", MsgBoxStyle.Exclamation)
			NewGame()
			bInCmdColumnClick = False
			Exit Sub
		End If

		' Computer's move
		If GameEngine.CurrentPlayer = Cls4Play.Player2Chip Then
			i = Math.Abs(GameEngine.Think())
			If GameEngine.PutChipInRow(i) Then
				ComputerMove = i + 1
				DrawChips()
				GameEngine.SwitchPlayers()
			Else
				Debug.Fail("frmMain::cmdColumn_Click: Game logic error!", "Computer failed to think for itself (" & i & ")!")
			End If
		End If

		' Disable housefull columns
		cmd1.Enabled = GameEngine.GetTotalMovesInRow(0) <= Cls4Play.MaxY
		cmd2.Enabled = GameEngine.GetTotalMovesInRow(1) <= Cls4Play.MaxY
		cmd3.Enabled = GameEngine.GetTotalMovesInRow(2) <= Cls4Play.MaxY
		cmd4.Enabled = GameEngine.GetTotalMovesInRow(3) <= Cls4Play.MaxY
		cmd5.Enabled = GameEngine.GetTotalMovesInRow(4) <= Cls4Play.MaxY
		cmd6.Enabled = GameEngine.GetTotalMovesInRow(5) <= Cls4Play.MaxY
		cmd7.Enabled = GameEngine.GetTotalMovesInRow(6) <= Cls4Play.MaxY

		' Recheck again
		If GameEngine.IsWinner(Cls4Play.Player1Chip) Then
			DrawChips()
			TmrUpdate_Tick(TmrUpdate, New System.EventArgs())
			MsgBox("You win!", MsgBoxStyle.Exclamation)
			NewGame()
			PlayerScore += 1
		ElseIf GameEngine.IsWinner(Cls4Play.Player2Chip) Then
			DrawChips()
			TmrUpdate_Tick(TmrUpdate, New System.EventArgs())
			MsgBox("I win!", MsgBoxStyle.Exclamation)
			NewGame()
			ComputerScore += 1
		ElseIf GameEngine.IsGameDraw() Then
			TmrUpdate_Tick(TmrUpdate, New System.EventArgs())
			MsgBox("It's a draw!", MsgBoxStyle.Exclamation)
			NewGame()
		End If

		bInCmdColumnClick = False
	End Sub

	' The following function was generated programatically:
	' https://www.onlinegdb.com/online_c_compiler
	' int x, y;
	'
	' for (x = 0; x < 7; x++)
	' {
	'	for (y = 0; y < 6; y++)
	'   {
	'		printf("\nmyChip = GameEngine.GetMove(%d, %d)\n", x, y);
	'       printf("If myChip = Cls4Play.Player1WinChip Then\n");
	'       printf("    lbl%d_%d.ForeColor = Color.Red\n", x, y);
	'       printf("    lbl%d_%d.Text = Chr(&H98)\n", x, y);
	'       printf("ElseIf myChip = Cls4Play.Player2WinChip Then\n");
	'       printf("    lbl%d_%d.ForeColor = Color.Yellow\n", x, y);
	'       printf("    lbl%d_%d.Text = Chr(&H98)\n", x, y);
	'       printf("ElseIf myChip = Cls4Play.Player1Chip Then\n");
	'       printf("    lbl%d_%d.ForeColor = Color.Red\n", x, y);
	'       printf("    lbl%d_%d.Text = Chr(&H6E)\n", x, y);
	'       printf("ElseIf myChip = Cls4Play.Player2Chip Then\n");
	'       printf("    lbl%d_%d.ForeColor = Color.Yellow\n", x, y);
	'       printf("    lbl%d_%d.Text = Chr(&H6E)\n", x, y);
	'       printf("Else\n");
	'       printf("    lbl%d_%d.Text = vbNullChar\n", x, y);
	'       printf("End If\n");
	'    }
	' }
#Region "DrawChips() [Autogenerated using C ] "
	Private Sub DrawChips()
		Dim myChip As String


		myChip = GameEngine.GetMove(0, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl0_0.ForeColor = Color.Red
			lbl0_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl0_0.ForeColor = Color.Yellow
			lbl0_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl0_0.ForeColor = Color.Red
			lbl0_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl0_0.ForeColor = Color.Yellow
			lbl0_0.Text = Chr(&H6E)
		Else
			lbl0_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(0, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl0_1.ForeColor = Color.Red
			lbl0_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl0_1.ForeColor = Color.Yellow
			lbl0_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl0_1.ForeColor = Color.Red
			lbl0_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl0_1.ForeColor = Color.Yellow
			lbl0_1.Text = Chr(&H6E)
		Else
			lbl0_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(0, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl0_2.ForeColor = Color.Red
			lbl0_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl0_2.ForeColor = Color.Yellow
			lbl0_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl0_2.ForeColor = Color.Red
			lbl0_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl0_2.ForeColor = Color.Yellow
			lbl0_2.Text = Chr(&H6E)
		Else
			lbl0_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(0, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl0_3.ForeColor = Color.Red
			lbl0_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl0_3.ForeColor = Color.Yellow
			lbl0_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl0_3.ForeColor = Color.Red
			lbl0_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl0_3.ForeColor = Color.Yellow
			lbl0_3.Text = Chr(&H6E)
		Else
			lbl0_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(0, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl0_4.ForeColor = Color.Red
			lbl0_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl0_4.ForeColor = Color.Yellow
			lbl0_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl0_4.ForeColor = Color.Red
			lbl0_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl0_4.ForeColor = Color.Yellow
			lbl0_4.Text = Chr(&H6E)
		Else
			lbl0_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(0, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl0_5.ForeColor = Color.Red
			lbl0_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl0_5.ForeColor = Color.Yellow
			lbl0_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl0_5.ForeColor = Color.Red
			lbl0_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl0_5.ForeColor = Color.Yellow
			lbl0_5.Text = Chr(&H6E)
		Else
			lbl0_5.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(1, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl1_0.ForeColor = Color.Red
			lbl1_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl1_0.ForeColor = Color.Yellow
			lbl1_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl1_0.ForeColor = Color.Red
			lbl1_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl1_0.ForeColor = Color.Yellow
			lbl1_0.Text = Chr(&H6E)
		Else
			lbl1_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(1, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl1_1.ForeColor = Color.Red
			lbl1_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl1_1.ForeColor = Color.Yellow
			lbl1_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl1_1.ForeColor = Color.Red
			lbl1_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl1_1.ForeColor = Color.Yellow
			lbl1_1.Text = Chr(&H6E)
		Else
			lbl1_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(1, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl1_2.ForeColor = Color.Red
			lbl1_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl1_2.ForeColor = Color.Yellow
			lbl1_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl1_2.ForeColor = Color.Red
			lbl1_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl1_2.ForeColor = Color.Yellow
			lbl1_2.Text = Chr(&H6E)
		Else
			lbl1_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(1, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl1_3.ForeColor = Color.Red
			lbl1_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl1_3.ForeColor = Color.Yellow
			lbl1_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl1_3.ForeColor = Color.Red
			lbl1_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl1_3.ForeColor = Color.Yellow
			lbl1_3.Text = Chr(&H6E)
		Else
			lbl1_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(1, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl1_4.ForeColor = Color.Red
			lbl1_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl1_4.ForeColor = Color.Yellow
			lbl1_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl1_4.ForeColor = Color.Red
			lbl1_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl1_4.ForeColor = Color.Yellow
			lbl1_4.Text = Chr(&H6E)
		Else
			lbl1_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(1, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl1_5.ForeColor = Color.Red
			lbl1_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl1_5.ForeColor = Color.Yellow
			lbl1_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl1_5.ForeColor = Color.Red
			lbl1_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl1_5.ForeColor = Color.Yellow
			lbl1_5.Text = Chr(&H6E)
		Else
			lbl1_5.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(2, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl2_0.ForeColor = Color.Red
			lbl2_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl2_0.ForeColor = Color.Yellow
			lbl2_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl2_0.ForeColor = Color.Red
			lbl2_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl2_0.ForeColor = Color.Yellow
			lbl2_0.Text = Chr(&H6E)
		Else
			lbl2_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(2, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl2_1.ForeColor = Color.Red
			lbl2_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl2_1.ForeColor = Color.Yellow
			lbl2_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl2_1.ForeColor = Color.Red
			lbl2_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl2_1.ForeColor = Color.Yellow
			lbl2_1.Text = Chr(&H6E)
		Else
			lbl2_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(2, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl2_2.ForeColor = Color.Red
			lbl2_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl2_2.ForeColor = Color.Yellow
			lbl2_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl2_2.ForeColor = Color.Red
			lbl2_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl2_2.ForeColor = Color.Yellow
			lbl2_2.Text = Chr(&H6E)
		Else
			lbl2_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(2, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl2_3.ForeColor = Color.Red
			lbl2_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl2_3.ForeColor = Color.Yellow
			lbl2_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl2_3.ForeColor = Color.Red
			lbl2_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl2_3.ForeColor = Color.Yellow
			lbl2_3.Text = Chr(&H6E)
		Else
			lbl2_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(2, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl2_4.ForeColor = Color.Red
			lbl2_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl2_4.ForeColor = Color.Yellow
			lbl2_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl2_4.ForeColor = Color.Red
			lbl2_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl2_4.ForeColor = Color.Yellow
			lbl2_4.Text = Chr(&H6E)
		Else
			lbl2_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(2, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl2_5.ForeColor = Color.Red
			lbl2_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl2_5.ForeColor = Color.Yellow
			lbl2_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl2_5.ForeColor = Color.Red
			lbl2_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl2_5.ForeColor = Color.Yellow
			lbl2_5.Text = Chr(&H6E)
		Else
			lbl2_5.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(3, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl3_0.ForeColor = Color.Red
			lbl3_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl3_0.ForeColor = Color.Yellow
			lbl3_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl3_0.ForeColor = Color.Red
			lbl3_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl3_0.ForeColor = Color.Yellow
			lbl3_0.Text = Chr(&H6E)
		Else
			lbl3_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(3, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl3_1.ForeColor = Color.Red
			lbl3_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl3_1.ForeColor = Color.Yellow
			lbl3_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl3_1.ForeColor = Color.Red
			lbl3_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl3_1.ForeColor = Color.Yellow
			lbl3_1.Text = Chr(&H6E)
		Else
			lbl3_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(3, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl3_2.ForeColor = Color.Red
			lbl3_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl3_2.ForeColor = Color.Yellow
			lbl3_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl3_2.ForeColor = Color.Red
			lbl3_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl3_2.ForeColor = Color.Yellow
			lbl3_2.Text = Chr(&H6E)
		Else
			lbl3_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(3, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl3_3.ForeColor = Color.Red
			lbl3_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl3_3.ForeColor = Color.Yellow
			lbl3_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl3_3.ForeColor = Color.Red
			lbl3_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl3_3.ForeColor = Color.Yellow
			lbl3_3.Text = Chr(&H6E)
		Else
			lbl3_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(3, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl3_4.ForeColor = Color.Red
			lbl3_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl3_4.ForeColor = Color.Yellow
			lbl3_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl3_4.ForeColor = Color.Red
			lbl3_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl3_4.ForeColor = Color.Yellow
			lbl3_4.Text = Chr(&H6E)
		Else
			lbl3_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(3, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl3_5.ForeColor = Color.Red
			lbl3_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl3_5.ForeColor = Color.Yellow
			lbl3_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl3_5.ForeColor = Color.Red
			lbl3_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl3_5.ForeColor = Color.Yellow
			lbl3_5.Text = Chr(&H6E)
		Else
			lbl3_5.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(4, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl4_0.ForeColor = Color.Red
			lbl4_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl4_0.ForeColor = Color.Yellow
			lbl4_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl4_0.ForeColor = Color.Red
			lbl4_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl4_0.ForeColor = Color.Yellow
			lbl4_0.Text = Chr(&H6E)
		Else
			lbl4_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(4, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl4_1.ForeColor = Color.Red
			lbl4_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl4_1.ForeColor = Color.Yellow
			lbl4_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl4_1.ForeColor = Color.Red
			lbl4_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl4_1.ForeColor = Color.Yellow
			lbl4_1.Text = Chr(&H6E)
		Else
			lbl4_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(4, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl4_2.ForeColor = Color.Red
			lbl4_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl4_2.ForeColor = Color.Yellow
			lbl4_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl4_2.ForeColor = Color.Red
			lbl4_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl4_2.ForeColor = Color.Yellow
			lbl4_2.Text = Chr(&H6E)
		Else
			lbl4_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(4, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl4_3.ForeColor = Color.Red
			lbl4_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl4_3.ForeColor = Color.Yellow
			lbl4_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl4_3.ForeColor = Color.Red
			lbl4_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl4_3.ForeColor = Color.Yellow
			lbl4_3.Text = Chr(&H6E)
		Else
			lbl4_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(4, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl4_4.ForeColor = Color.Red
			lbl4_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl4_4.ForeColor = Color.Yellow
			lbl4_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl4_4.ForeColor = Color.Red
			lbl4_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl4_4.ForeColor = Color.Yellow
			lbl4_4.Text = Chr(&H6E)
		Else
			lbl4_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(4, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl4_5.ForeColor = Color.Red
			lbl4_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl4_5.ForeColor = Color.Yellow
			lbl4_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl4_5.ForeColor = Color.Red
			lbl4_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl4_5.ForeColor = Color.Yellow
			lbl4_5.Text = Chr(&H6E)
		Else
			lbl4_5.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(5, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl5_0.ForeColor = Color.Red
			lbl5_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl5_0.ForeColor = Color.Yellow
			lbl5_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl5_0.ForeColor = Color.Red
			lbl5_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl5_0.ForeColor = Color.Yellow
			lbl5_0.Text = Chr(&H6E)
		Else
			lbl5_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(5, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl5_1.ForeColor = Color.Red
			lbl5_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl5_1.ForeColor = Color.Yellow
			lbl5_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl5_1.ForeColor = Color.Red
			lbl5_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl5_1.ForeColor = Color.Yellow
			lbl5_1.Text = Chr(&H6E)
		Else
			lbl5_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(5, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl5_2.ForeColor = Color.Red
			lbl5_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl5_2.ForeColor = Color.Yellow
			lbl5_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl5_2.ForeColor = Color.Red
			lbl5_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl5_2.ForeColor = Color.Yellow
			lbl5_2.Text = Chr(&H6E)
		Else
			lbl5_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(5, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl5_3.ForeColor = Color.Red
			lbl5_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl5_3.ForeColor = Color.Yellow
			lbl5_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl5_3.ForeColor = Color.Red
			lbl5_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl5_3.ForeColor = Color.Yellow
			lbl5_3.Text = Chr(&H6E)
		Else
			lbl5_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(5, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl5_4.ForeColor = Color.Red
			lbl5_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl5_4.ForeColor = Color.Yellow
			lbl5_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl5_4.ForeColor = Color.Red
			lbl5_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl5_4.ForeColor = Color.Yellow
			lbl5_4.Text = Chr(&H6E)
		Else
			lbl5_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(5, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl5_5.ForeColor = Color.Red
			lbl5_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl5_5.ForeColor = Color.Yellow
			lbl5_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl5_5.ForeColor = Color.Red
			lbl5_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl5_5.ForeColor = Color.Yellow
			lbl5_5.Text = Chr(&H6E)
		Else
			lbl5_5.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(6, 0)
		If myChip = Cls4Play.Player1WinChip Then
			lbl6_0.ForeColor = Color.Red
			lbl6_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl6_0.ForeColor = Color.Yellow
			lbl6_0.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl6_0.ForeColor = Color.Red
			lbl6_0.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl6_0.ForeColor = Color.Yellow
			lbl6_0.Text = Chr(&H6E)
		Else
			lbl6_0.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(6, 1)
		If myChip = Cls4Play.Player1WinChip Then
			lbl6_1.ForeColor = Color.Red
			lbl6_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl6_1.ForeColor = Color.Yellow
			lbl6_1.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl6_1.ForeColor = Color.Red
			lbl6_1.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl6_1.ForeColor = Color.Yellow
			lbl6_1.Text = Chr(&H6E)
		Else
			lbl6_1.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(6, 2)
		If myChip = Cls4Play.Player1WinChip Then
			lbl6_2.ForeColor = Color.Red
			lbl6_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl6_2.ForeColor = Color.Yellow
			lbl6_2.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl6_2.ForeColor = Color.Red
			lbl6_2.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl6_2.ForeColor = Color.Yellow
			lbl6_2.Text = Chr(&H6E)
		Else
			lbl6_2.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(6, 3)
		If myChip = Cls4Play.Player1WinChip Then
			lbl6_3.ForeColor = Color.Red
			lbl6_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl6_3.ForeColor = Color.Yellow
			lbl6_3.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl6_3.ForeColor = Color.Red
			lbl6_3.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl6_3.ForeColor = Color.Yellow
			lbl6_3.Text = Chr(&H6E)
		Else
			lbl6_3.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(6, 4)
		If myChip = Cls4Play.Player1WinChip Then
			lbl6_4.ForeColor = Color.Red
			lbl6_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl6_4.ForeColor = Color.Yellow
			lbl6_4.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl6_4.ForeColor = Color.Red
			lbl6_4.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl6_4.ForeColor = Color.Yellow
			lbl6_4.Text = Chr(&H6E)
		Else
			lbl6_4.Text = vbNullChar
		End If

		myChip = GameEngine.GetMove(6, 5)
		If myChip = Cls4Play.Player1WinChip Then
			lbl6_5.ForeColor = Color.Red
			lbl6_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player2WinChip Then
			lbl6_5.ForeColor = Color.Yellow
			lbl6_5.Text = Chr(&H98)
		ElseIf myChip = Cls4Play.Player1Chip Then
			lbl6_5.ForeColor = Color.Red
			lbl6_5.Text = Chr(&H6E)
		ElseIf myChip = Cls4Play.Player2Chip Then
			lbl6_5.ForeColor = Color.Yellow
			lbl6_5.Text = Chr(&H6E)
		Else
			lbl6_5.Text = vbNullChar
		End If
	End Sub
#End Region

	Private Sub CmdColumn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmd1.KeyPress, cmd2.KeyPress, cmd3.KeyPress, cmd4.KeyPress, cmd5.KeyPress, cmd6.KeyPress, cmd7.KeyPress
		Dim KeyAscii As Integer = Asc(e.KeyChar)
		Dim Index As Integer = CInt(CType(sender, Button).Tag)

		If KeyAscii >= Asc("1") And KeyAscii <= Asc("7") Then
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
			CmdColumn_Click(btnMyButton, New System.EventArgs())
		End If

		If KeyAscii = 0 Then
			e.Handled = True
		End If
	End Sub

	Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Randomize()
		RestartGame()
	End Sub

	Private Sub FrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		If GameEngine.GetTotalMoves() > 0 Then
			If MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to quit now?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
				e.Cancel = True
				Exit Sub
			End If
		End If

		e.Cancel = False
	End Sub

	Private Sub MnuGameNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGameNew.Click
		If GameEngine.GetTotalMoves() > 0 Then
			If MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to end this game?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
				RestartGame()
			End If
		Else
			RestartGame()
		End If
	End Sub

	Private Sub MnuGameExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGameExit.Click
		Close()
	End Sub

	Private Sub MnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpAbout.Click
		' Display the about dialog box
		ShellAbout(Handle,
		 Application.ProductName,
		 FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly.Location).LegalCopyright &
		 vbNewLine & "Version " & Application.ProductVersion,
		 Icon.Handle)
	End Sub

	Private Sub MnuHelpHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpHint.Click
		MsgBox("Try column " & (Math.Abs(GameEngine.Think()) + 1) & ".", MsgBoxStyle.Information, "Hint")
	End Sub

	Private Sub MnuHelpHowTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpHowTo.Click
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

	Private Sub TmrUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrUpdate.Tick
		' Check the buttons
		cmd1.Enabled = GameEngine.GetTotalMovesInRow(0) <= Cls4Play.MaxY
		cmd2.Enabled = GameEngine.GetTotalMovesInRow(1) <= Cls4Play.MaxY
		cmd3.Enabled = GameEngine.GetTotalMovesInRow(2) <= Cls4Play.MaxY
		cmd4.Enabled = GameEngine.GetTotalMovesInRow(3) <= Cls4Play.MaxY
		cmd5.Enabled = GameEngine.GetTotalMovesInRow(4) <= Cls4Play.MaxY
		cmd6.Enabled = GameEngine.GetTotalMovesInRow(5) <= Cls4Play.MaxY
		cmd7.Enabled = GameEngine.GetTotalMovesInRow(6) <= Cls4Play.MaxY

		' Update some status text; esp time and stuff
		LblPlayerTime.Text = Format(TimeSerial(0, 0, CInt(PlayerTime)), "HH:mm:ss")
		LblComputerTime.Text = Format(TimeSerial(0, 0, CInt(ComputerTime)), "HH:mm:ss")

		LblPlayerScore.Text = CStr(PlayerScore)
		LblComputerScore.Text = CStr(ComputerScore)
		LblPlayerLastMove.Text = CStr(PlayerMove)
		LblComputerLastMove.Text = CStr(ComputerMove)

		If GameEngine.CurrentPlayer = Cls4Play.Player1Chip Then
			If GameEngine.IsGameStarted() Then
				PlayerTime += CSng(TmrUpdate.Interval) / 1000.0!
			End If
		Else
			ComputerTime += CSng(TmrUpdate.Interval) / 1000.0!
		End If
	End Sub
End Class
