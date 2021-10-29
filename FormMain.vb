' 4Play: Classic Connect 4 game
' Copyright (c) Samuel Gomes, 2020

' The code in this game has been migrated from QuickBASIC, VBDOS, VB6 to VB.Net
' As such the name conventions are clearly a mishmash from these eras
' I have tried my best to follow the MS VB.Net naming conventions whereever possbile while updating the code
' See here: https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/program-structure/naming-conventions

Public Class FormMain
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
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As IContainer

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
		Me.components = New Container()
		Dim resources As New ComponentResourceManager(GetType(FormMain))
		Me.MnuMain = New MainMenu(Me.components)
		Me.MnuGame = New MenuItem()
		Me.MnuGameNew = New MenuItem()
		Me.MnuGameSeperator1 = New MenuItem()
		Me.MnuGameExit = New MenuItem()
		Me.MnuHelp = New MenuItem()
		Me.MnuHelpHowTo = New MenuItem()
		Me.MnuHelpHint = New MenuItem()
		Me.MnuHelpSeperator1 = New MenuItem()
		Me.MnuHelpAbout = New MenuItem()
		Me.TmrUpdate = New Timer(Me.components)
		Me.PnlPawns = New Panel()
		Me.Lbl6_5 = New Label()
		Me.Lbl6_4 = New Label()
		Me.Lbl6_3 = New Label()
		Me.Lbl6_2 = New Label()
		Me.Lbl6_1 = New Label()
		Me.Lbl6_0 = New Label()
		Me.Lbl5_5 = New Label()
		Me.Lbl5_4 = New Label()
		Me.Lbl5_3 = New Label()
		Me.Lbl5_2 = New Label()
		Me.Lbl5_1 = New Label()
		Me.Lbl5_0 = New Label()
		Me.Lbl4_5 = New Label()
		Me.Lbl4_4 = New Label()
		Me.Lbl4_3 = New Label()
		Me.Lbl4_2 = New Label()
		Me.Lbl4_1 = New Label()
		Me.Lbl4_0 = New Label()
		Me.Lbl3_5 = New Label()
		Me.Lbl3_4 = New Label()
		Me.Lbl3_3 = New Label()
		Me.Lbl3_2 = New Label()
		Me.Lbl3_1 = New Label()
		Me.Lbl3_0 = New Label()
		Me.Lbl2_5 = New Label()
		Me.Lbl2_4 = New Label()
		Me.Lbl2_3 = New Label()
		Me.Lbl2_2 = New Label()
		Me.Lbl2_1 = New Label()
		Me.Lbl2_0 = New Label()
		Me.Lbl1_5 = New Label()
		Me.Lbl1_4 = New Label()
		Me.Lbl1_3 = New Label()
		Me.Lbl1_2 = New Label()
		Me.Lbl1_1 = New Label()
		Me.Lbl1_0 = New Label()
		Me.Lbl0_5 = New Label()
		Me.Lbl0_4 = New Label()
		Me.Lbl0_3 = New Label()
		Me.Lbl0_2 = New Label()
		Me.Lbl0_1 = New Label()
		Me.Lbl0_0 = New Label()
		Me.PnlButtons = New Panel()
		Me.Cmd7 = New Button()
		Me.Cmd6 = New Button()
		Me.Cmd5 = New Button()
		Me.Cmd4 = New Button()
		Me.Cmd3 = New Button()
		Me.Cmd2 = New Button()
		Me.Cmd1 = New Button()
		Me.PnlStatus = New Panel()
		Me.GrpComputer = New GroupBox()
		Me.LblComputerTime = New Label()
		Me.LblComputerLastMove = New Label()
		Me.LblComputerScore = New Label()
		Me.LblComputerTimeLbl = New Label()
		Me.LblComputerLastMoveLbl = New Label()
		Me.LblComputerScoreLbl = New Label()
		Me.GrpPlayer = New GroupBox()
		Me.LblPlayerTime = New Label()
		Me.LblPlayerLastMove = New Label()
		Me.LblPlayerScore = New Label()
		Me.LblPlayerTimeLbl = New Label()
		Me.LblPlayerLastMoveLbl = New Label()
		Me.LblPlayerScoreLbl = New Label()
		Me.TxtStatus = New TextBox()
		Me.PnlPawns.SuspendLayout()
		Me.PnlButtons.SuspendLayout()
		Me.PnlStatus.SuspendLayout()
		Me.GrpComputer.SuspendLayout()
		Me.GrpPlayer.SuspendLayout()
		Me.SuspendLayout()
		'
		'MnuMain
		'
		Me.MnuMain.MenuItems.AddRange(New MenuItem() {Me.MnuGame, Me.MnuHelp})
		'
		'MnuGame
		'
		Me.MnuGame.Index = 0
		Me.MnuGame.MenuItems.AddRange(New MenuItem() {Me.MnuGameNew, Me.MnuGameSeperator1, Me.MnuGameExit})
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
		Me.MnuHelp.MenuItems.AddRange(New MenuItem() {Me.MnuHelpHowTo, Me.MnuHelpHint, Me.MnuHelpSeperator1, Me.MnuHelpAbout})
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
		Me.MnuHelpHint.Text = "&Show AI Thinking"
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
		Me.MnuHelpAbout.Text = "&About 4 Play..."
		'
		'TmrUpdate
		'
		Me.TmrUpdate.Enabled = True
		'
		'PnlPawns
		'
		Me.PnlPawns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PnlPawns.Controls.Add(Me.Lbl6_5)
		Me.PnlPawns.Controls.Add(Me.Lbl6_4)
		Me.PnlPawns.Controls.Add(Me.Lbl6_3)
		Me.PnlPawns.Controls.Add(Me.Lbl6_2)
		Me.PnlPawns.Controls.Add(Me.Lbl6_1)
		Me.PnlPawns.Controls.Add(Me.Lbl6_0)
		Me.PnlPawns.Controls.Add(Me.Lbl5_5)
		Me.PnlPawns.Controls.Add(Me.Lbl5_4)
		Me.PnlPawns.Controls.Add(Me.Lbl5_3)
		Me.PnlPawns.Controls.Add(Me.Lbl5_2)
		Me.PnlPawns.Controls.Add(Me.Lbl5_1)
		Me.PnlPawns.Controls.Add(Me.Lbl5_0)
		Me.PnlPawns.Controls.Add(Me.Lbl4_5)
		Me.PnlPawns.Controls.Add(Me.Lbl4_4)
		Me.PnlPawns.Controls.Add(Me.Lbl4_3)
		Me.PnlPawns.Controls.Add(Me.Lbl4_2)
		Me.PnlPawns.Controls.Add(Me.Lbl4_1)
		Me.PnlPawns.Controls.Add(Me.Lbl4_0)
		Me.PnlPawns.Controls.Add(Me.Lbl3_5)
		Me.PnlPawns.Controls.Add(Me.Lbl3_4)
		Me.PnlPawns.Controls.Add(Me.Lbl3_3)
		Me.PnlPawns.Controls.Add(Me.Lbl3_2)
		Me.PnlPawns.Controls.Add(Me.Lbl3_1)
		Me.PnlPawns.Controls.Add(Me.Lbl3_0)
		Me.PnlPawns.Controls.Add(Me.Lbl2_5)
		Me.PnlPawns.Controls.Add(Me.Lbl2_4)
		Me.PnlPawns.Controls.Add(Me.Lbl2_3)
		Me.PnlPawns.Controls.Add(Me.Lbl2_2)
		Me.PnlPawns.Controls.Add(Me.Lbl2_1)
		Me.PnlPawns.Controls.Add(Me.Lbl2_0)
		Me.PnlPawns.Controls.Add(Me.Lbl1_5)
		Me.PnlPawns.Controls.Add(Me.Lbl1_4)
		Me.PnlPawns.Controls.Add(Me.Lbl1_3)
		Me.PnlPawns.Controls.Add(Me.Lbl1_2)
		Me.PnlPawns.Controls.Add(Me.Lbl1_1)
		Me.PnlPawns.Controls.Add(Me.Lbl1_0)
		Me.PnlPawns.Controls.Add(Me.Lbl0_5)
		Me.PnlPawns.Controls.Add(Me.Lbl0_4)
		Me.PnlPawns.Controls.Add(Me.Lbl0_3)
		Me.PnlPawns.Controls.Add(Me.Lbl0_2)
		Me.PnlPawns.Controls.Add(Me.Lbl0_1)
		Me.PnlPawns.Controls.Add(Me.Lbl0_0)
		Me.PnlPawns.Location = New Point(8, 8)
		Me.PnlPawns.Name = "PnlPawns"
		Me.PnlPawns.Size = New Size(292, 252)
		Me.PnlPawns.TabIndex = 0
		'
		'Lbl6_5
		'
		Me.Lbl6_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl6_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl6_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl6_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl6_5.Location = New Point(248, 8)
		Me.Lbl6_5.Name = "Lbl6_5"
		Me.Lbl6_5.Size = New Size(32, 32)
		Me.Lbl6_5.TabIndex = 41
		Me.Lbl6_5.Text = "n"
		Me.Lbl6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl6_5.UseMnemonic = False
		'
		'Lbl6_4
		'
		Me.Lbl6_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl6_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl6_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl6_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl6_4.Location = New Point(248, 48)
		Me.Lbl6_4.Name = "Lbl6_4"
		Me.Lbl6_4.Size = New Size(32, 32)
		Me.Lbl6_4.TabIndex = 40
		Me.Lbl6_4.Text = "n"
		Me.Lbl6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl6_4.UseMnemonic = False
		'
		'Lbl6_3
		'
		Me.Lbl6_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl6_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl6_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl6_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl6_3.Location = New Point(248, 88)
		Me.Lbl6_3.Name = "Lbl6_3"
		Me.Lbl6_3.Size = New Size(32, 32)
		Me.Lbl6_3.TabIndex = 39
		Me.Lbl6_3.Text = "n"
		Me.Lbl6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl6_3.UseMnemonic = False
		'
		'Lbl6_2
		'
		Me.Lbl6_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl6_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl6_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl6_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl6_2.Location = New Point(248, 128)
		Me.Lbl6_2.Name = "Lbl6_2"
		Me.Lbl6_2.Size = New Size(32, 32)
		Me.Lbl6_2.TabIndex = 38
		Me.Lbl6_2.Text = "n"
		Me.Lbl6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl6_2.UseMnemonic = False
		'
		'Lbl6_1
		'
		Me.Lbl6_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl6_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl6_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl6_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl6_1.Location = New Point(248, 168)
		Me.Lbl6_1.Name = "Lbl6_1"
		Me.Lbl6_1.Size = New Size(32, 32)
		Me.Lbl6_1.TabIndex = 37
		Me.Lbl6_1.Text = "n"
		Me.Lbl6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl6_1.UseMnemonic = False
		'
		'Lbl6_0
		'
		Me.Lbl6_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl6_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl6_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl6_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl6_0.Location = New Point(248, 208)
		Me.Lbl6_0.Name = "Lbl6_0"
		Me.Lbl6_0.Size = New Size(32, 32)
		Me.Lbl6_0.TabIndex = 36
		Me.Lbl6_0.Text = "n"
		Me.Lbl6_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl6_0.UseMnemonic = False
		'
		'Lbl5_5
		'
		Me.Lbl5_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl5_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl5_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl5_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl5_5.Location = New Point(208, 8)
		Me.Lbl5_5.Name = "Lbl5_5"
		Me.Lbl5_5.Size = New Size(32, 32)
		Me.Lbl5_5.TabIndex = 35
		Me.Lbl5_5.Text = "n"
		Me.Lbl5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl5_5.UseMnemonic = False
		'
		'Lbl5_4
		'
		Me.Lbl5_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl5_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl5_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl5_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl5_4.Location = New Point(208, 48)
		Me.Lbl5_4.Name = "Lbl5_4"
		Me.Lbl5_4.Size = New Size(32, 32)
		Me.Lbl5_4.TabIndex = 34
		Me.Lbl5_4.Text = "n"
		Me.Lbl5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl5_4.UseMnemonic = False
		'
		'Lbl5_3
		'
		Me.Lbl5_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl5_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl5_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl5_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl5_3.Location = New Point(208, 88)
		Me.Lbl5_3.Name = "Lbl5_3"
		Me.Lbl5_3.Size = New Size(32, 32)
		Me.Lbl5_3.TabIndex = 33
		Me.Lbl5_3.Text = "n"
		Me.Lbl5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl5_3.UseMnemonic = False
		'
		'Lbl5_2
		'
		Me.Lbl5_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl5_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl5_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl5_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl5_2.Location = New Point(208, 128)
		Me.Lbl5_2.Name = "Lbl5_2"
		Me.Lbl5_2.Size = New Size(32, 32)
		Me.Lbl5_2.TabIndex = 32
		Me.Lbl5_2.Text = "n"
		Me.Lbl5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl5_2.UseMnemonic = False
		'
		'Lbl5_1
		'
		Me.Lbl5_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl5_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl5_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl5_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl5_1.Location = New Point(208, 168)
		Me.Lbl5_1.Name = "Lbl5_1"
		Me.Lbl5_1.Size = New Size(32, 32)
		Me.Lbl5_1.TabIndex = 31
		Me.Lbl5_1.Text = "n"
		Me.Lbl5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl5_1.UseMnemonic = False
		'
		'Lbl5_0
		'
		Me.Lbl5_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl5_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl5_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl5_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl5_0.Location = New Point(208, 208)
		Me.Lbl5_0.Name = "Lbl5_0"
		Me.Lbl5_0.Size = New Size(32, 32)
		Me.Lbl5_0.TabIndex = 30
		Me.Lbl5_0.Text = "n"
		Me.Lbl5_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl5_0.UseMnemonic = False
		'
		'Lbl4_5
		'
		Me.Lbl4_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl4_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl4_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl4_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl4_5.Location = New Point(168, 8)
		Me.Lbl4_5.Name = "Lbl4_5"
		Me.Lbl4_5.Size = New Size(32, 32)
		Me.Lbl4_5.TabIndex = 29
		Me.Lbl4_5.Text = "n"
		Me.Lbl4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl4_5.UseMnemonic = False
		'
		'Lbl4_4
		'
		Me.Lbl4_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl4_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl4_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl4_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl4_4.Location = New Point(168, 48)
		Me.Lbl4_4.Name = "Lbl4_4"
		Me.Lbl4_4.Size = New Size(32, 32)
		Me.Lbl4_4.TabIndex = 28
		Me.Lbl4_4.Text = "n"
		Me.Lbl4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl4_4.UseMnemonic = False
		'
		'Lbl4_3
		'
		Me.Lbl4_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl4_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl4_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl4_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl4_3.Location = New Point(168, 88)
		Me.Lbl4_3.Name = "Lbl4_3"
		Me.Lbl4_3.Size = New Size(32, 32)
		Me.Lbl4_3.TabIndex = 27
		Me.Lbl4_3.Text = "n"
		Me.Lbl4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl4_3.UseMnemonic = False
		'
		'Lbl4_2
		'
		Me.Lbl4_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl4_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl4_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl4_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl4_2.Location = New Point(168, 128)
		Me.Lbl4_2.Name = "Lbl4_2"
		Me.Lbl4_2.Size = New Size(32, 32)
		Me.Lbl4_2.TabIndex = 26
		Me.Lbl4_2.Text = "n"
		Me.Lbl4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl4_2.UseMnemonic = False
		'
		'Lbl4_1
		'
		Me.Lbl4_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl4_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl4_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl4_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl4_1.Location = New Point(168, 168)
		Me.Lbl4_1.Name = "Lbl4_1"
		Me.Lbl4_1.Size = New Size(32, 32)
		Me.Lbl4_1.TabIndex = 25
		Me.Lbl4_1.Text = "n"
		Me.Lbl4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl4_1.UseMnemonic = False
		'
		'Lbl4_0
		'
		Me.Lbl4_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl4_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl4_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl4_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl4_0.Location = New Point(168, 208)
		Me.Lbl4_0.Name = "Lbl4_0"
		Me.Lbl4_0.Size = New Size(32, 32)
		Me.Lbl4_0.TabIndex = 24
		Me.Lbl4_0.Text = "n"
		Me.Lbl4_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl4_0.UseMnemonic = False
		'
		'Lbl3_5
		'
		Me.Lbl3_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl3_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl3_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl3_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl3_5.Location = New Point(128, 8)
		Me.Lbl3_5.Name = "Lbl3_5"
		Me.Lbl3_5.Size = New Size(32, 32)
		Me.Lbl3_5.TabIndex = 23
		Me.Lbl3_5.Text = "n"
		Me.Lbl3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl3_5.UseMnemonic = False
		'
		'Lbl3_4
		'
		Me.Lbl3_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl3_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl3_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl3_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl3_4.Location = New Point(128, 48)
		Me.Lbl3_4.Name = "Lbl3_4"
		Me.Lbl3_4.Size = New Size(32, 32)
		Me.Lbl3_4.TabIndex = 22
		Me.Lbl3_4.Text = "n"
		Me.Lbl3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl3_4.UseMnemonic = False
		'
		'Lbl3_3
		'
		Me.Lbl3_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl3_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl3_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl3_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl3_3.Location = New Point(128, 88)
		Me.Lbl3_3.Name = "Lbl3_3"
		Me.Lbl3_3.Size = New Size(32, 32)
		Me.Lbl3_3.TabIndex = 21
		Me.Lbl3_3.Text = "n"
		Me.Lbl3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl3_3.UseMnemonic = False
		'
		'Lbl3_2
		'
		Me.Lbl3_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl3_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl3_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl3_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl3_2.Location = New Point(128, 128)
		Me.Lbl3_2.Name = "Lbl3_2"
		Me.Lbl3_2.Size = New Size(32, 32)
		Me.Lbl3_2.TabIndex = 20
		Me.Lbl3_2.Text = "n"
		Me.Lbl3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl3_2.UseMnemonic = False
		'
		'Lbl3_1
		'
		Me.Lbl3_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl3_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl3_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl3_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl3_1.Location = New Point(128, 168)
		Me.Lbl3_1.Name = "Lbl3_1"
		Me.Lbl3_1.Size = New Size(32, 32)
		Me.Lbl3_1.TabIndex = 19
		Me.Lbl3_1.Text = "n"
		Me.Lbl3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl3_1.UseMnemonic = False
		'
		'Lbl3_0
		'
		Me.Lbl3_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl3_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl3_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl3_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl3_0.Location = New Point(128, 208)
		Me.Lbl3_0.Name = "Lbl3_0"
		Me.Lbl3_0.Size = New Size(32, 32)
		Me.Lbl3_0.TabIndex = 18
		Me.Lbl3_0.Text = "n"
		Me.Lbl3_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl3_0.UseMnemonic = False
		'
		'Lbl2_5
		'
		Me.Lbl2_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl2_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl2_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl2_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl2_5.Location = New Point(88, 8)
		Me.Lbl2_5.Name = "Lbl2_5"
		Me.Lbl2_5.Size = New Size(32, 32)
		Me.Lbl2_5.TabIndex = 17
		Me.Lbl2_5.Text = "n"
		Me.Lbl2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl2_5.UseMnemonic = False
		'
		'Lbl2_4
		'
		Me.Lbl2_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl2_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl2_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl2_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl2_4.Location = New Point(88, 48)
		Me.Lbl2_4.Name = "Lbl2_4"
		Me.Lbl2_4.Size = New Size(32, 32)
		Me.Lbl2_4.TabIndex = 16
		Me.Lbl2_4.Text = "n"
		Me.Lbl2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl2_4.UseMnemonic = False
		'
		'Lbl2_3
		'
		Me.Lbl2_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl2_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl2_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl2_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl2_3.Location = New Point(88, 88)
		Me.Lbl2_3.Name = "Lbl2_3"
		Me.Lbl2_3.Size = New Size(32, 32)
		Me.Lbl2_3.TabIndex = 15
		Me.Lbl2_3.Text = "n"
		Me.Lbl2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl2_3.UseMnemonic = False
		'
		'Lbl2_2
		'
		Me.Lbl2_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl2_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl2_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl2_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl2_2.Location = New Point(88, 128)
		Me.Lbl2_2.Name = "Lbl2_2"
		Me.Lbl2_2.Size = New Size(32, 32)
		Me.Lbl2_2.TabIndex = 14
		Me.Lbl2_2.Text = "n"
		Me.Lbl2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl2_2.UseMnemonic = False
		'
		'Lbl2_1
		'
		Me.Lbl2_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl2_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl2_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl2_1.Location = New Point(88, 168)
		Me.Lbl2_1.Name = "Lbl2_1"
		Me.Lbl2_1.Size = New Size(32, 32)
		Me.Lbl2_1.TabIndex = 13
		Me.Lbl2_1.Text = "n"
		Me.Lbl2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl2_1.UseMnemonic = False
		'
		'Lbl2_0
		'
		Me.Lbl2_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl2_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl2_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl2_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl2_0.Location = New Point(88, 208)
		Me.Lbl2_0.Name = "Lbl2_0"
		Me.Lbl2_0.Size = New Size(32, 32)
		Me.Lbl2_0.TabIndex = 12
		Me.Lbl2_0.Text = "n"
		Me.Lbl2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl2_0.UseMnemonic = False
		'
		'Lbl1_5
		'
		Me.Lbl1_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl1_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl1_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl1_5.Location = New Point(48, 8)
		Me.Lbl1_5.Name = "Lbl1_5"
		Me.Lbl1_5.Size = New Size(32, 32)
		Me.Lbl1_5.TabIndex = 11
		Me.Lbl1_5.Text = "n"
		Me.Lbl1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl1_5.UseMnemonic = False
		'
		'Lbl1_4
		'
		Me.Lbl1_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl1_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl1_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl1_4.Location = New Point(48, 48)
		Me.Lbl1_4.Name = "Lbl1_4"
		Me.Lbl1_4.Size = New Size(32, 32)
		Me.Lbl1_4.TabIndex = 10
		Me.Lbl1_4.Text = "n"
		Me.Lbl1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl1_4.UseMnemonic = False
		'
		'Lbl1_3
		'
		Me.Lbl1_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl1_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl1_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl1_3.Location = New Point(48, 88)
		Me.Lbl1_3.Name = "Lbl1_3"
		Me.Lbl1_3.Size = New Size(32, 32)
		Me.Lbl1_3.TabIndex = 9
		Me.Lbl1_3.Text = "n"
		Me.Lbl1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl1_3.UseMnemonic = False
		'
		'Lbl1_2
		'
		Me.Lbl1_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl1_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl1_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl1_2.Location = New Point(48, 128)
		Me.Lbl1_2.Name = "Lbl1_2"
		Me.Lbl1_2.Size = New Size(32, 32)
		Me.Lbl1_2.TabIndex = 8
		Me.Lbl1_2.Text = "n"
		Me.Lbl1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl1_2.UseMnemonic = False
		'
		'Lbl1_1
		'
		Me.Lbl1_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl1_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl1_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl1_1.Location = New Point(48, 168)
		Me.Lbl1_1.Name = "Lbl1_1"
		Me.Lbl1_1.Size = New Size(32, 32)
		Me.Lbl1_1.TabIndex = 7
		Me.Lbl1_1.Text = "n"
		Me.Lbl1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl1_1.UseMnemonic = False
		'
		'Lbl1_0
		'
		Me.Lbl1_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl1_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl1_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl1_0.Location = New Point(48, 208)
		Me.Lbl1_0.Name = "Lbl1_0"
		Me.Lbl1_0.Size = New Size(32, 32)
		Me.Lbl1_0.TabIndex = 6
		Me.Lbl1_0.Text = "n"
		Me.Lbl1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl1_0.UseMnemonic = False
		'
		'Lbl0_5
		'
		Me.Lbl0_5.BackColor = System.Drawing.Color.Blue
		Me.Lbl0_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl0_5.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl0_5.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl0_5.Location = New Point(8, 8)
		Me.Lbl0_5.Name = "Lbl0_5"
		Me.Lbl0_5.Size = New Size(32, 32)
		Me.Lbl0_5.TabIndex = 5
		Me.Lbl0_5.Text = "n"
		Me.Lbl0_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl0_5.UseMnemonic = False
		'
		'Lbl0_4
		'
		Me.Lbl0_4.BackColor = System.Drawing.Color.Blue
		Me.Lbl0_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl0_4.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl0_4.ForeColor = System.Drawing.Color.Red
		Me.Lbl0_4.Location = New Point(8, 48)
		Me.Lbl0_4.Name = "Lbl0_4"
		Me.Lbl0_4.Size = New Size(32, 32)
		Me.Lbl0_4.TabIndex = 4
		Me.Lbl0_4.Text = "n"
		Me.Lbl0_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl0_4.UseMnemonic = False
		'
		'Lbl0_3
		'
		Me.Lbl0_3.BackColor = System.Drawing.Color.Blue
		Me.Lbl0_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl0_3.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl0_3.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl0_3.Location = New Point(8, 88)
		Me.Lbl0_3.Name = "Lbl0_3"
		Me.Lbl0_3.Size = New Size(32, 32)
		Me.Lbl0_3.TabIndex = 3
		Me.Lbl0_3.Text = "n"
		Me.Lbl0_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl0_3.UseMnemonic = False
		'
		'Lbl0_2
		'
		Me.Lbl0_2.BackColor = System.Drawing.Color.Blue
		Me.Lbl0_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl0_2.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl0_2.ForeColor = System.Drawing.Color.Red
		Me.Lbl0_2.Location = New Point(8, 128)
		Me.Lbl0_2.Name = "Lbl0_2"
		Me.Lbl0_2.Size = New Size(32, 32)
		Me.Lbl0_2.TabIndex = 2
		Me.Lbl0_2.Text = "n"
		Me.Lbl0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl0_2.UseMnemonic = False
		'
		'Lbl0_1
		'
		Me.Lbl0_1.BackColor = System.Drawing.Color.Blue
		Me.Lbl0_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl0_1.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl0_1.ForeColor = System.Drawing.Color.Yellow
		Me.Lbl0_1.Location = New Point(8, 168)
		Me.Lbl0_1.Name = "Lbl0_1"
		Me.Lbl0_1.Size = New Size(32, 32)
		Me.Lbl0_1.TabIndex = 1
		Me.Lbl0_1.Text = "n"
		Me.Lbl0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl0_1.UseMnemonic = False
		'
		'Lbl0_0
		'
		Me.Lbl0_0.BackColor = System.Drawing.Color.Blue
		Me.Lbl0_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Lbl0_0.Font = New Font("Webdings", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2)
		Me.Lbl0_0.ForeColor = System.Drawing.Color.Red
		Me.Lbl0_0.Location = New Point(8, 208)
		Me.Lbl0_0.Name = "Lbl0_0"
		Me.Lbl0_0.Size = New Size(32, 32)
		Me.Lbl0_0.TabIndex = 0
		Me.Lbl0_0.Text = "n"
		Me.Lbl0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Lbl0_0.UseMnemonic = False
		'
		'PnlButtons
		'
		Me.PnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PnlButtons.Controls.Add(Me.Cmd7)
		Me.PnlButtons.Controls.Add(Me.Cmd6)
		Me.PnlButtons.Controls.Add(Me.Cmd5)
		Me.PnlButtons.Controls.Add(Me.Cmd4)
		Me.PnlButtons.Controls.Add(Me.Cmd3)
		Me.PnlButtons.Controls.Add(Me.Cmd2)
		Me.PnlButtons.Controls.Add(Me.Cmd1)
		Me.PnlButtons.Location = New Point(8, 268)
		Me.PnlButtons.Name = "PnlButtons"
		Me.PnlButtons.Size = New Size(292, 52)
		Me.PnlButtons.TabIndex = 1
		'
		'Cmd7
		'
		Me.Cmd7.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd7.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd7.Location = New Point(248, 8)
		Me.Cmd7.Name = "Cmd7"
		Me.Cmd7.Size = New Size(32, 32)
		Me.Cmd7.TabIndex = 6
		Me.Cmd7.Tag = "6"
		Me.Cmd7.Text = "&7"
		'
		'Cmd6
		'
		Me.Cmd6.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd6.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd6.Location = New Point(208, 8)
		Me.Cmd6.Name = "Cmd6"
		Me.Cmd6.Size = New Size(32, 32)
		Me.Cmd6.TabIndex = 5
		Me.Cmd6.Tag = "5"
		Me.Cmd6.Text = "&6"
		'
		'Cmd5
		'
		Me.Cmd5.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd5.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd5.Location = New Point(168, 8)
		Me.Cmd5.Name = "Cmd5"
		Me.Cmd5.Size = New Size(32, 32)
		Me.Cmd5.TabIndex = 4
		Me.Cmd5.Tag = "4"
		Me.Cmd5.Text = "&5"
		'
		'Cmd4
		'
		Me.Cmd4.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd4.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd4.Location = New Point(128, 8)
		Me.Cmd4.Name = "Cmd4"
		Me.Cmd4.Size = New Size(32, 32)
		Me.Cmd4.TabIndex = 3
		Me.Cmd4.Tag = "3"
		Me.Cmd4.Text = "&4"
		'
		'Cmd3
		'
		Me.Cmd3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd3.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd3.Location = New Point(88, 8)
		Me.Cmd3.Name = "Cmd3"
		Me.Cmd3.Size = New Size(32, 32)
		Me.Cmd3.TabIndex = 2
		Me.Cmd3.Tag = "2"
		Me.Cmd3.Text = "&3"
		'
		'Cmd2
		'
		Me.Cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd2.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd2.Location = New Point(48, 8)
		Me.Cmd2.Name = "Cmd2"
		Me.Cmd2.Size = New Size(32, 32)
		Me.Cmd2.TabIndex = 1
		Me.Cmd2.Tag = "1"
		Me.Cmd2.Text = "&2"
		'
		'Cmd1
		'
		Me.Cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Cmd1.Font = New Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.Cmd1.Location = New Point(8, 8)
		Me.Cmd1.Name = "Cmd1"
		Me.Cmd1.Size = New Size(32, 32)
		Me.Cmd1.TabIndex = 0
		Me.Cmd1.Tag = "0"
		Me.Cmd1.Text = "&1"
		'
		'PnlStatus
		'
		Me.PnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PnlStatus.Controls.Add(Me.GrpComputer)
		Me.PnlStatus.Controls.Add(Me.GrpPlayer)
		Me.PnlStatus.Location = New Point(308, 8)
		Me.PnlStatus.Name = "PnlStatus"
		Me.PnlStatus.Size = New Size(188, 228)
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
		Me.GrpComputer.Location = New Point(8, 116)
		Me.GrpComputer.Name = "GrpComputer"
		Me.GrpComputer.Size = New Size(168, 100)
		Me.GrpComputer.TabIndex = 1
		Me.GrpComputer.TabStop = False
		Me.GrpComputer.Text = "Computer (Yellow)"
		'
		'LblComputerTime
		'
		Me.LblComputerTime.AutoSize = True
		Me.LblComputerTime.Location = New Point(104, 72)
		Me.LblComputerTime.Name = "LblComputerTime"
		Me.LblComputerTime.Size = New Size(49, 13)
		Me.LblComputerTime.TabIndex = 5
		Me.LblComputerTime.Text = "00:00:00"
		Me.LblComputerTime.UseMnemonic = False
		'
		'LblComputerLastMove
		'
		Me.LblComputerLastMove.AutoSize = True
		Me.LblComputerLastMove.Location = New Point(104, 48)
		Me.LblComputerLastMove.Name = "LblComputerLastMove"
		Me.LblComputerLastMove.Size = New Size(13, 13)
		Me.LblComputerLastMove.TabIndex = 3
		Me.LblComputerLastMove.Text = "0"
		Me.LblComputerLastMove.UseMnemonic = False
		'
		'LblComputerScore
		'
		Me.LblComputerScore.AutoSize = True
		Me.LblComputerScore.Location = New Point(104, 24)
		Me.LblComputerScore.Name = "LblComputerScore"
		Me.LblComputerScore.Size = New Size(13, 13)
		Me.LblComputerScore.TabIndex = 1
		Me.LblComputerScore.Text = "0"
		Me.LblComputerScore.UseMnemonic = False
		'
		'LblComputerTimeLbl
		'
		Me.LblComputerTimeLbl.AutoSize = True
		Me.LblComputerTimeLbl.Location = New Point(36, 72)
		Me.LblComputerTimeLbl.Name = "LblComputerTimeLbl"
		Me.LblComputerTimeLbl.Size = New Size(33, 13)
		Me.LblComputerTimeLbl.TabIndex = 4
		Me.LblComputerTimeLbl.Text = "Time:"
		Me.LblComputerTimeLbl.UseMnemonic = False
		'
		'LblComputerLastMoveLbl
		'
		Me.LblComputerLastMoveLbl.AutoSize = True
		Me.LblComputerLastMoveLbl.Location = New Point(12, 48)
		Me.LblComputerLastMoveLbl.Name = "LblComputerLastMoveLbl"
		Me.LblComputerLastMoveLbl.Size = New Size(60, 13)
		Me.LblComputerLastMoveLbl.TabIndex = 2
		Me.LblComputerLastMoveLbl.Text = "Last Move:"
		Me.LblComputerLastMoveLbl.UseMnemonic = False
		'
		'LblComputerScoreLbl
		'
		Me.LblComputerScoreLbl.AutoSize = True
		Me.LblComputerScoreLbl.Location = New Point(32, 24)
		Me.LblComputerScoreLbl.Name = "LblComputerScoreLbl"
		Me.LblComputerScoreLbl.Size = New Size(38, 13)
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
		Me.GrpPlayer.Location = New Point(8, 8)
		Me.GrpPlayer.Name = "GrpPlayer"
		Me.GrpPlayer.Size = New Size(168, 100)
		Me.GrpPlayer.TabIndex = 0
		Me.GrpPlayer.TabStop = False
		Me.GrpPlayer.Text = "Player (Red)"
		'
		'LblPlayerTime
		'
		Me.LblPlayerTime.AutoSize = True
		Me.LblPlayerTime.Location = New Point(104, 72)
		Me.LblPlayerTime.Name = "LblPlayerTime"
		Me.LblPlayerTime.Size = New Size(49, 13)
		Me.LblPlayerTime.TabIndex = 5
		Me.LblPlayerTime.Text = "00:00:00"
		Me.LblPlayerTime.UseMnemonic = False
		'
		'LblPlayerLastMove
		'
		Me.LblPlayerLastMove.AutoSize = True
		Me.LblPlayerLastMove.Location = New Point(104, 48)
		Me.LblPlayerLastMove.Name = "LblPlayerLastMove"
		Me.LblPlayerLastMove.Size = New Size(13, 13)
		Me.LblPlayerLastMove.TabIndex = 3
		Me.LblPlayerLastMove.Text = "0"
		Me.LblPlayerLastMove.UseMnemonic = False
		'
		'LblPlayerScore
		'
		Me.LblPlayerScore.AutoSize = True
		Me.LblPlayerScore.Location = New Point(104, 24)
		Me.LblPlayerScore.Name = "LblPlayerScore"
		Me.LblPlayerScore.Size = New Size(13, 13)
		Me.LblPlayerScore.TabIndex = 1
		Me.LblPlayerScore.Text = "0"
		Me.LblPlayerScore.UseMnemonic = False
		'
		'LblPlayerTimeLbl
		'
		Me.LblPlayerTimeLbl.AutoSize = True
		Me.LblPlayerTimeLbl.Location = New Point(36, 72)
		Me.LblPlayerTimeLbl.Name = "LblPlayerTimeLbl"
		Me.LblPlayerTimeLbl.Size = New Size(33, 13)
		Me.LblPlayerTimeLbl.TabIndex = 4
		Me.LblPlayerTimeLbl.Text = "Time:"
		Me.LblPlayerTimeLbl.UseMnemonic = False
		'
		'LblPlayerLastMoveLbl
		'
		Me.LblPlayerLastMoveLbl.AutoSize = True
		Me.LblPlayerLastMoveLbl.Location = New Point(12, 48)
		Me.LblPlayerLastMoveLbl.Name = "LblPlayerLastMoveLbl"
		Me.LblPlayerLastMoveLbl.Size = New Size(60, 13)
		Me.LblPlayerLastMoveLbl.TabIndex = 2
		Me.LblPlayerLastMoveLbl.Text = "Last Move:"
		Me.LblPlayerLastMoveLbl.UseMnemonic = False
		'
		'LblPlayerScoreLbl
		'
		Me.LblPlayerScoreLbl.AutoSize = True
		Me.LblPlayerScoreLbl.Location = New Point(32, 24)
		Me.LblPlayerScoreLbl.Name = "LblPlayerScoreLbl"
		Me.LblPlayerScoreLbl.Size = New Size(38, 13)
		Me.LblPlayerScoreLbl.TabIndex = 0
		Me.LblPlayerScoreLbl.Text = "Score:"
		Me.LblPlayerScoreLbl.UseMnemonic = False
		'
		'TxtStatus
		'
		Me.TxtStatus.BackColor = System.Drawing.Color.Black
		Me.TxtStatus.Font = New Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.TxtStatus.ForeColor = System.Drawing.Color.Lime
		Me.TxtStatus.Location = New Point(308, 244)
		Me.TxtStatus.Multiline = True
		Me.TxtStatus.Name = "TxtStatus"
		Me.TxtStatus.ReadOnly = True
		Me.TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TxtStatus.Size = New Size(188, 76)
		Me.TxtStatus.TabIndex = 3
		Me.TxtStatus.TabStop = False
		'
		'FrmMain
		'
		Me.AutoScaleBaseSize = New Size(5, 13)
		Me.ClientSize = New Size(504, 327)
		Me.Controls.Add(Me.TxtStatus)
		Me.Controls.Add(Me.PnlStatus)
		Me.Controls.Add(Me.PnlButtons)
		Me.Controls.Add(Me.PnlPawns)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
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

	Private PlayerTime, ComputerTime As Single
	Public Connect4Board As New GameBoard(6, 5)         ' Our game board
	Private WithEvents GameEngine As New AIPlayer
	Private GameBusy As Boolean = False                 ' All UI input and AI play will be disabled if this is true

	' Our game engine message handler
	Private Sub UpdateStatus(Note As String) Handles GameEngine.ProcessNote
		TxtStatus.AppendText(If(TxtStatus.TextLength <= 0, Note, vbCrLf & Note))
		TxtStatus.SelectionLength = 0
		TxtStatus.SelectionStart = TxtStatus.TextLength
		TxtStatus.ScrollToCaret()
	End Sub

	' The following function was generated programatically:
	' https://www.onlinegdb.com/online_c_compiler
	'
	'#include <stdio.h>

	'int main()
	'{
	'    for (int x = 0; x < 7; x++)
	'	{
	'	    for (int y = 0; y < 6; y++)
	'        {
	'            printf("\nMyChip = Connect4Board.Position(%d, %d)\n", x, y);
	'            printf("If myChip = GameBoard.Player1WinningChecker Then\n");
	'	         printf("    Lbl%d_%d.ForeColor = Color.Red\n", x, y);
	'	         printf("    Lbl%d_%d.Text = Chr(&H98)\n", x, y);
	'	         printf("ElseIf myChip = GameBoard.Player2WinningChecker Then\n");
	'            printf("    Lbl%d_%d.ForeColor = Color.Yellow\n", x, y);
	'	         printf("    Lbl%d_%d.Text = Chr(&H98)\n", x, y);
	'	         printf("ElseIf myChip = GameBoard.Player1Checker Then\n");
	'	         printf("    Lbl%d_%d.ForeColor = Color.Red\n", x, y);
	'	         printf("    Lbl%d_%d.Text = Chr(&H6E)\n", x, y);
	'	         printf("ElseIf myChip = GameBoard.Player2Checker Then\n");
	'	         printf("    Lbl%d_%d.ForeColor = Color.Yellow\n", x, y);
	'	         printf("    Lbl%d_%d.Text = Chr(&H6E)\n", x, y);
	'	         printf("Else\n");
	'	         printf("    Lbl%d_%d.Text = vbNullChar\n", x, y);
	'	         printf("End If\n");
	'	    }
	'    }

	'    return 0;
	'}
#Region " DrawBoard() [Auto-generated using C] "
	Private Sub DrawBoard()
		Dim myChip As SByte

		myChip = Connect4Board.Position(0, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl0_0.ForeColor = Color.Red
			Lbl0_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl0_0.ForeColor = Color.Yellow
			Lbl0_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl0_0.ForeColor = Color.Red
			Lbl0_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl0_0.ForeColor = Color.Yellow
			Lbl0_0.Text = Chr(&H6E)
		Else
			Lbl0_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(0, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl0_1.ForeColor = Color.Red
			Lbl0_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl0_1.ForeColor = Color.Yellow
			Lbl0_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl0_1.ForeColor = Color.Red
			Lbl0_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl0_1.ForeColor = Color.Yellow
			Lbl0_1.Text = Chr(&H6E)
		Else
			Lbl0_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(0, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl0_2.ForeColor = Color.Red
			Lbl0_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl0_2.ForeColor = Color.Yellow
			Lbl0_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl0_2.ForeColor = Color.Red
			Lbl0_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl0_2.ForeColor = Color.Yellow
			Lbl0_2.Text = Chr(&H6E)
		Else
			Lbl0_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(0, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl0_3.ForeColor = Color.Red
			Lbl0_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl0_3.ForeColor = Color.Yellow
			Lbl0_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl0_3.ForeColor = Color.Red
			Lbl0_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl0_3.ForeColor = Color.Yellow
			Lbl0_3.Text = Chr(&H6E)
		Else
			Lbl0_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(0, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl0_4.ForeColor = Color.Red
			Lbl0_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl0_4.ForeColor = Color.Yellow
			Lbl0_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl0_4.ForeColor = Color.Red
			Lbl0_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl0_4.ForeColor = Color.Yellow
			Lbl0_4.Text = Chr(&H6E)
		Else
			Lbl0_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(0, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl0_5.ForeColor = Color.Red
			Lbl0_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl0_5.ForeColor = Color.Yellow
			Lbl0_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl0_5.ForeColor = Color.Red
			Lbl0_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl0_5.ForeColor = Color.Yellow
			Lbl0_5.Text = Chr(&H6E)
		Else
			Lbl0_5.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(1, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl1_0.ForeColor = Color.Red
			Lbl1_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl1_0.ForeColor = Color.Yellow
			Lbl1_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl1_0.ForeColor = Color.Red
			Lbl1_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl1_0.ForeColor = Color.Yellow
			Lbl1_0.Text = Chr(&H6E)
		Else
			Lbl1_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(1, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl1_1.ForeColor = Color.Red
			Lbl1_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl1_1.ForeColor = Color.Yellow
			Lbl1_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl1_1.ForeColor = Color.Red
			Lbl1_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl1_1.ForeColor = Color.Yellow
			Lbl1_1.Text = Chr(&H6E)
		Else
			Lbl1_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(1, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl1_2.ForeColor = Color.Red
			Lbl1_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl1_2.ForeColor = Color.Yellow
			Lbl1_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl1_2.ForeColor = Color.Red
			Lbl1_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl1_2.ForeColor = Color.Yellow
			Lbl1_2.Text = Chr(&H6E)
		Else
			Lbl1_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(1, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl1_3.ForeColor = Color.Red
			Lbl1_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl1_3.ForeColor = Color.Yellow
			Lbl1_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl1_3.ForeColor = Color.Red
			Lbl1_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl1_3.ForeColor = Color.Yellow
			Lbl1_3.Text = Chr(&H6E)
		Else
			Lbl1_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(1, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl1_4.ForeColor = Color.Red
			Lbl1_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl1_4.ForeColor = Color.Yellow
			Lbl1_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl1_4.ForeColor = Color.Red
			Lbl1_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl1_4.ForeColor = Color.Yellow
			Lbl1_4.Text = Chr(&H6E)
		Else
			Lbl1_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(1, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl1_5.ForeColor = Color.Red
			Lbl1_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl1_5.ForeColor = Color.Yellow
			Lbl1_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl1_5.ForeColor = Color.Red
			Lbl1_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl1_5.ForeColor = Color.Yellow
			Lbl1_5.Text = Chr(&H6E)
		Else
			Lbl1_5.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(2, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl2_0.ForeColor = Color.Red
			Lbl2_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl2_0.ForeColor = Color.Yellow
			Lbl2_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl2_0.ForeColor = Color.Red
			Lbl2_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl2_0.ForeColor = Color.Yellow
			Lbl2_0.Text = Chr(&H6E)
		Else
			Lbl2_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(2, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl2_1.ForeColor = Color.Red
			Lbl2_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl2_1.ForeColor = Color.Yellow
			Lbl2_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl2_1.ForeColor = Color.Red
			Lbl2_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl2_1.ForeColor = Color.Yellow
			Lbl2_1.Text = Chr(&H6E)
		Else
			Lbl2_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(2, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl2_2.ForeColor = Color.Red
			Lbl2_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl2_2.ForeColor = Color.Yellow
			Lbl2_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl2_2.ForeColor = Color.Red
			Lbl2_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl2_2.ForeColor = Color.Yellow
			Lbl2_2.Text = Chr(&H6E)
		Else
			Lbl2_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(2, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl2_3.ForeColor = Color.Red
			Lbl2_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl2_3.ForeColor = Color.Yellow
			Lbl2_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl2_3.ForeColor = Color.Red
			Lbl2_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl2_3.ForeColor = Color.Yellow
			Lbl2_3.Text = Chr(&H6E)
		Else
			Lbl2_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(2, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl2_4.ForeColor = Color.Red
			Lbl2_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl2_4.ForeColor = Color.Yellow
			Lbl2_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl2_4.ForeColor = Color.Red
			Lbl2_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl2_4.ForeColor = Color.Yellow
			Lbl2_4.Text = Chr(&H6E)
		Else
			Lbl2_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(2, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl2_5.ForeColor = Color.Red
			Lbl2_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl2_5.ForeColor = Color.Yellow
			Lbl2_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl2_5.ForeColor = Color.Red
			Lbl2_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl2_5.ForeColor = Color.Yellow
			Lbl2_5.Text = Chr(&H6E)
		Else
			Lbl2_5.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(3, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl3_0.ForeColor = Color.Red
			Lbl3_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl3_0.ForeColor = Color.Yellow
			Lbl3_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl3_0.ForeColor = Color.Red
			Lbl3_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl3_0.ForeColor = Color.Yellow
			Lbl3_0.Text = Chr(&H6E)
		Else
			Lbl3_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(3, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl3_1.ForeColor = Color.Red
			Lbl3_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl3_1.ForeColor = Color.Yellow
			Lbl3_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl3_1.ForeColor = Color.Red
			Lbl3_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl3_1.ForeColor = Color.Yellow
			Lbl3_1.Text = Chr(&H6E)
		Else
			Lbl3_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(3, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl3_2.ForeColor = Color.Red
			Lbl3_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl3_2.ForeColor = Color.Yellow
			Lbl3_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl3_2.ForeColor = Color.Red
			Lbl3_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl3_2.ForeColor = Color.Yellow
			Lbl3_2.Text = Chr(&H6E)
		Else
			Lbl3_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(3, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl3_3.ForeColor = Color.Red
			Lbl3_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl3_3.ForeColor = Color.Yellow
			Lbl3_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl3_3.ForeColor = Color.Red
			Lbl3_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl3_3.ForeColor = Color.Yellow
			Lbl3_3.Text = Chr(&H6E)
		Else
			Lbl3_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(3, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl3_4.ForeColor = Color.Red
			Lbl3_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl3_4.ForeColor = Color.Yellow
			Lbl3_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl3_4.ForeColor = Color.Red
			Lbl3_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl3_4.ForeColor = Color.Yellow
			Lbl3_4.Text = Chr(&H6E)
		Else
			Lbl3_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(3, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl3_5.ForeColor = Color.Red
			Lbl3_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl3_5.ForeColor = Color.Yellow
			Lbl3_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl3_5.ForeColor = Color.Red
			Lbl3_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl3_5.ForeColor = Color.Yellow
			Lbl3_5.Text = Chr(&H6E)
		Else
			Lbl3_5.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(4, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl4_0.ForeColor = Color.Red
			Lbl4_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl4_0.ForeColor = Color.Yellow
			Lbl4_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl4_0.ForeColor = Color.Red
			Lbl4_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl4_0.ForeColor = Color.Yellow
			Lbl4_0.Text = Chr(&H6E)
		Else
			Lbl4_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(4, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl4_1.ForeColor = Color.Red
			Lbl4_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl4_1.ForeColor = Color.Yellow
			Lbl4_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl4_1.ForeColor = Color.Red
			Lbl4_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl4_1.ForeColor = Color.Yellow
			Lbl4_1.Text = Chr(&H6E)
		Else
			Lbl4_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(4, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl4_2.ForeColor = Color.Red
			Lbl4_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl4_2.ForeColor = Color.Yellow
			Lbl4_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl4_2.ForeColor = Color.Red
			Lbl4_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl4_2.ForeColor = Color.Yellow
			Lbl4_2.Text = Chr(&H6E)
		Else
			Lbl4_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(4, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl4_3.ForeColor = Color.Red
			Lbl4_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl4_3.ForeColor = Color.Yellow
			Lbl4_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl4_3.ForeColor = Color.Red
			Lbl4_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl4_3.ForeColor = Color.Yellow
			Lbl4_3.Text = Chr(&H6E)
		Else
			Lbl4_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(4, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl4_4.ForeColor = Color.Red
			Lbl4_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl4_4.ForeColor = Color.Yellow
			Lbl4_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl4_4.ForeColor = Color.Red
			Lbl4_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl4_4.ForeColor = Color.Yellow
			Lbl4_4.Text = Chr(&H6E)
		Else
			Lbl4_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(4, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl4_5.ForeColor = Color.Red
			Lbl4_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl4_5.ForeColor = Color.Yellow
			Lbl4_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl4_5.ForeColor = Color.Red
			Lbl4_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl4_5.ForeColor = Color.Yellow
			Lbl4_5.Text = Chr(&H6E)
		Else
			Lbl4_5.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(5, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl5_0.ForeColor = Color.Red
			Lbl5_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl5_0.ForeColor = Color.Yellow
			Lbl5_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl5_0.ForeColor = Color.Red
			Lbl5_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl5_0.ForeColor = Color.Yellow
			Lbl5_0.Text = Chr(&H6E)
		Else
			Lbl5_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(5, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl5_1.ForeColor = Color.Red
			Lbl5_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl5_1.ForeColor = Color.Yellow
			Lbl5_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl5_1.ForeColor = Color.Red
			Lbl5_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl5_1.ForeColor = Color.Yellow
			Lbl5_1.Text = Chr(&H6E)
		Else
			Lbl5_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(5, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl5_2.ForeColor = Color.Red
			Lbl5_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl5_2.ForeColor = Color.Yellow
			Lbl5_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl5_2.ForeColor = Color.Red
			Lbl5_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl5_2.ForeColor = Color.Yellow
			Lbl5_2.Text = Chr(&H6E)
		Else
			Lbl5_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(5, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl5_3.ForeColor = Color.Red
			Lbl5_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl5_3.ForeColor = Color.Yellow
			Lbl5_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl5_3.ForeColor = Color.Red
			Lbl5_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl5_3.ForeColor = Color.Yellow
			Lbl5_3.Text = Chr(&H6E)
		Else
			Lbl5_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(5, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl5_4.ForeColor = Color.Red
			Lbl5_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl5_4.ForeColor = Color.Yellow
			Lbl5_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl5_4.ForeColor = Color.Red
			Lbl5_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl5_4.ForeColor = Color.Yellow
			Lbl5_4.Text = Chr(&H6E)
		Else
			Lbl5_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(5, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl5_5.ForeColor = Color.Red
			Lbl5_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl5_5.ForeColor = Color.Yellow
			Lbl5_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl5_5.ForeColor = Color.Red
			Lbl5_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl5_5.ForeColor = Color.Yellow
			Lbl5_5.Text = Chr(&H6E)
		Else
			Lbl5_5.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(6, 0)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl6_0.ForeColor = Color.Red
			Lbl6_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl6_0.ForeColor = Color.Yellow
			Lbl6_0.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl6_0.ForeColor = Color.Red
			Lbl6_0.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl6_0.ForeColor = Color.Yellow
			Lbl6_0.Text = Chr(&H6E)
		Else
			Lbl6_0.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(6, 1)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl6_1.ForeColor = Color.Red
			Lbl6_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl6_1.ForeColor = Color.Yellow
			Lbl6_1.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl6_1.ForeColor = Color.Red
			Lbl6_1.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl6_1.ForeColor = Color.Yellow
			Lbl6_1.Text = Chr(&H6E)
		Else
			Lbl6_1.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(6, 2)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl6_2.ForeColor = Color.Red
			Lbl6_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl6_2.ForeColor = Color.Yellow
			Lbl6_2.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl6_2.ForeColor = Color.Red
			Lbl6_2.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl6_2.ForeColor = Color.Yellow
			Lbl6_2.Text = Chr(&H6E)
		Else
			Lbl6_2.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(6, 3)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl6_3.ForeColor = Color.Red
			Lbl6_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl6_3.ForeColor = Color.Yellow
			Lbl6_3.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl6_3.ForeColor = Color.Red
			Lbl6_3.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl6_3.ForeColor = Color.Yellow
			Lbl6_3.Text = Chr(&H6E)
		Else
			Lbl6_3.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(6, 4)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl6_4.ForeColor = Color.Red
			Lbl6_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl6_4.ForeColor = Color.Yellow
			Lbl6_4.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl6_4.ForeColor = Color.Red
			Lbl6_4.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
			Lbl6_4.ForeColor = Color.Yellow
			Lbl6_4.Text = Chr(&H6E)
		Else
			Lbl6_4.Text = vbNullChar
		End If

		myChip = Connect4Board.Position(6, 5)
		If myChip = GameBoard.Player1WinningChecker Then
			Lbl6_5.ForeColor = Color.Red
			Lbl6_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player2WinningChecker Then
			Lbl6_5.ForeColor = Color.Yellow
			Lbl6_5.Text = Chr(&H98)
		ElseIf myChip = GameBoard.Player1Checker Then
			Lbl6_5.ForeColor = Color.Red
			Lbl6_5.Text = Chr(&H6E)
		ElseIf myChip = GameBoard.Player2Checker Then
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
		RestartGame()
	End Sub

	Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
		If Connect4Board.GetTotalMoves() > 0 Then
			If MsgBox("A game is in progress." & vbCrLf & "Are you sure you want to quit now?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
				e.Cancel = True
				Exit Sub
			End If
		End If

		e.Cancel = False

		' Force close if AI is busy
		If GameBusy Then End
	End Sub

	Private Sub MnuGameNew_Click(sender As Object, e As EventArgs) Handles MnuGameNew.Click
		If Connect4Board.GetTotalMoves() > 0 Then
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
		Connect4Board.Reset()
		DrawBoard()
		PlayerTime = 0
		ComputerTime = 0
		LblPlayerLastMove.Text = CStr(0)
		LblComputerLastMove.Text = CStr(0)
		UpdateStatus("Ready!")
	End Sub

	Private Sub RestartGame()
		NewGame()
		LblPlayerScore.Text = CStr(0)
		LblComputerScore.Text = CStr(0)
	End Sub

	Private Sub UpdateUI()
		' Disable housefull columns. The additional checks below will reject user input of AI or Player has already played in the UI but logic is not complete
		Cmd1.Enabled = Connect4Board.GetTotalMovesInColumn(0) <= Connect4Board.MaxY AndAlso Not GameBusy
		Cmd2.Enabled = Connect4Board.GetTotalMovesInColumn(1) <= Connect4Board.MaxY AndAlso Not GameBusy
		Cmd3.Enabled = Connect4Board.GetTotalMovesInColumn(2) <= Connect4Board.MaxY AndAlso Not GameBusy
		Cmd4.Enabled = Connect4Board.GetTotalMovesInColumn(3) <= Connect4Board.MaxY AndAlso Not GameBusy
		Cmd5.Enabled = Connect4Board.GetTotalMovesInColumn(4) <= Connect4Board.MaxY AndAlso Not GameBusy
		Cmd6.Enabled = Connect4Board.GetTotalMovesInColumn(5) <= Connect4Board.MaxY AndAlso Not GameBusy
		Cmd7.Enabled = Connect4Board.GetTotalMovesInColumn(6) <= Connect4Board.MaxY AndAlso Not GameBusy

		' Draw the game board
		If MnuHelpHint.Checked Or Not GameBusy Then
			DrawBoard()
		End If

		' Update some status text; esp time and stuff
		LblPlayerTime.Text = Format(TimeSerial(0, 0, CInt(PlayerTime)), "HH:mm:ss")
		LblComputerTime.Text = Format(TimeSerial(0, 0, CInt(ComputerTime)), "HH:mm:ss")

		' Check all possible cases and show and message depending on who won or if is a draw game
		Dim winner = Connect4Board.IsWinner(True)
		If winner <> GameBoard.EmptyCell Then
			If winner = GameBoard.Player2Checker Then
				UpdateStatus("I win!")
				LblComputerScore.Text = CStr(Val(LblComputerScore.Text) + 1)
			Else
				UpdateStatus("You win!")
				LblPlayerScore.Text = CStr(Val(LblPlayerScore.Text) + 1)
			End If
			' We call DrawBoard here to draw the winning positions
			DrawBoard()
			' Wait a bit and then reset the game board
			Application.DoEvents()
			Threading.Thread.Sleep(5000)
			NewGame()
		ElseIf Connect4Board.IsGameDraw() Then
			UpdateStatus("It's a draw!")
			' Wait a bit and then reset the game board
			Application.DoEvents()
			Threading.Thread.Sleep(5000)
			NewGame()
		End If
	End Sub

	Private Sub CmdColumn_Click(sender As Object, e As EventArgs) Handles Cmd1.Click, Cmd2.Click, Cmd3.Click, Cmd4.Click, Cmd5.Click, Cmd6.Click, Cmd7.Click
		' Don't allow reentry by the user if we are already processing a player move
		If GameBusy Or Connect4Board.GetNextPlayer() = GameBoard.Player2Checker Then Exit Sub

		' Set the busy flag to true until the player finishes playing
		GameBusy = True

		Dim i As Byte = CByte(CType(sender, Button).Tag)

		' Player's move
		If Connect4Board.PlayMove(i) Then
			LblPlayerLastMove.Text = CStr(i + 1)
		End If

		GameBusy = False
	End Sub

	Private Sub TmrUpdate_Tick(sender As Object, e As EventArgs) Handles TmrUpdate.Tick
		' Show the game board while AI is evaluating the board. This has to go. We cannot change the main game board when AI is evaluating
		' This does a lot of funny stuff to the UI code that depend on the class

		' Update the UI, board and stuff
		UpdateUI()

		If Connect4Board.GetNextPlayer() = GameBoard.Player2Checker Then
			' Tick AI time only if game has started
			If Connect4Board.HasGameStarted() And GameBusy Then
				ComputerTime += TmrUpdate.Interval / 1000.0!
			End If

			If Not GameBusy Then
				Dim i As Byte

				' Computer's move
				UpdateStatus("Thinking...")

				GameBusy = True

				i = GameEngine.Think(Connect4Board)
				If Connect4Board.PlayMove(i) Then
					LblComputerLastMove.Text = CStr(i + 1)
				Else
					Debug.Fail("TmrUpdate_Tick: Game logic error!", "Computer failed to think for itself (" & i & ")!")
				End If

				' Set busy flag to false so that player can now play
				GameBusy = False
			End If
		Else
			' Tick player time only if game has started
			If Connect4Board.HasGameStarted() And Not GameBusy Then
				PlayerTime += TmrUpdate.Interval / 1000.0!
			End If
		End If
	End Sub
End Class
