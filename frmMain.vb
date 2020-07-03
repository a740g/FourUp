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
        lbl6_5 = New System.Windows.Forms.Label()
        lbl6_4 = New System.Windows.Forms.Label()
        lbl6_3 = New System.Windows.Forms.Label()
        lbl6_2 = New System.Windows.Forms.Label()
        lbl6_1 = New System.Windows.Forms.Label()
        lbl6_0 = New System.Windows.Forms.Label()
        lbl5_5 = New System.Windows.Forms.Label()
        lbl5_4 = New System.Windows.Forms.Label()
        lbl5_3 = New System.Windows.Forms.Label()
        lbl5_2 = New System.Windows.Forms.Label()
        lbl5_1 = New System.Windows.Forms.Label()
        lbl5_0 = New System.Windows.Forms.Label()
        lbl4_5 = New System.Windows.Forms.Label()
        lbl4_4 = New System.Windows.Forms.Label()
        lbl4_3 = New System.Windows.Forms.Label()
        lbl4_2 = New System.Windows.Forms.Label()
        lbl4_1 = New System.Windows.Forms.Label()
        lbl4_0 = New System.Windows.Forms.Label()
        lbl3_5 = New System.Windows.Forms.Label()
        lbl3_4 = New System.Windows.Forms.Label()
        lbl3_3 = New System.Windows.Forms.Label()
        lbl3_2 = New System.Windows.Forms.Label()
        lbl3_1 = New System.Windows.Forms.Label()
        lbl3_0 = New System.Windows.Forms.Label()
        lbl2_5 = New System.Windows.Forms.Label()
        lbl2_4 = New System.Windows.Forms.Label()
        lbl2_3 = New System.Windows.Forms.Label()
        lbl2_2 = New System.Windows.Forms.Label()
        lbl2_1 = New System.Windows.Forms.Label()
        lbl2_0 = New System.Windows.Forms.Label()
        lbl1_5 = New System.Windows.Forms.Label()
        lbl1_4 = New System.Windows.Forms.Label()
        lbl1_3 = New System.Windows.Forms.Label()
        lbl1_2 = New System.Windows.Forms.Label()
        lbl1_1 = New System.Windows.Forms.Label()
        lbl1_0 = New System.Windows.Forms.Label()
        lbl0_5 = New System.Windows.Forms.Label()
        lbl0_4 = New System.Windows.Forms.Label()
        lbl0_3 = New System.Windows.Forms.Label()
        lbl0_2 = New System.Windows.Forms.Label()
        lbl0_1 = New System.Windows.Forms.Label()
        lbl0_0 = New System.Windows.Forms.Label()
        PnlButtons = New System.Windows.Forms.Panel()
        cmd7 = New System.Windows.Forms.Button()
        cmd6 = New System.Windows.Forms.Button()
        cmd5 = New System.Windows.Forms.Button()
        cmd4 = New System.Windows.Forms.Button()
        cmd3 = New System.Windows.Forms.Button()
        cmd2 = New System.Windows.Forms.Button()
        cmd1 = New System.Windows.Forms.Button()
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
        MnuGameNew.Shortcut = System.Windows.Forms.Shortcut.F2
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
        MnuGameExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
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
        MnuHelpHowTo.Shortcut = System.Windows.Forms.Shortcut.F1
        MnuHelpHowTo.Text = "How &To..."
        '
        'MnuHelpHint
        '
        MnuHelpHint.Index = 1
        MnuHelpHint.Shortcut = System.Windows.Forms.Shortcut.ShiftF1
        MnuHelpHint.Text = "Hi&nt..."
        '
        'MnuHelpSeperator1
        '
        MnuHelpSeperator1.Index = 2
        MnuHelpSeperator1.Text = "-"
        '
        'MnuHelpAbout
        '
        MnuHelpAbout.Index = 3
        MnuHelpAbout.Shortcut = System.Windows.Forms.Shortcut.AltF1
        MnuHelpAbout.Text = "&About 4Play..."
        '
        'TmrUpdate
        '
        TmrUpdate.Enabled = True
        '
        'PnlPawns
        '
        PnlPawns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PnlPawns.Controls.Add(lbl6_5)
        PnlPawns.Controls.Add(lbl6_4)
        PnlPawns.Controls.Add(lbl6_3)
        PnlPawns.Controls.Add(lbl6_2)
        PnlPawns.Controls.Add(lbl6_1)
        PnlPawns.Controls.Add(lbl6_0)
        PnlPawns.Controls.Add(lbl5_5)
        PnlPawns.Controls.Add(lbl5_4)
        PnlPawns.Controls.Add(lbl5_3)
        PnlPawns.Controls.Add(lbl5_2)
        PnlPawns.Controls.Add(lbl5_1)
        PnlPawns.Controls.Add(lbl5_0)
        PnlPawns.Controls.Add(lbl4_5)
        PnlPawns.Controls.Add(lbl4_4)
        PnlPawns.Controls.Add(lbl4_3)
        PnlPawns.Controls.Add(lbl4_2)
        PnlPawns.Controls.Add(lbl4_1)
        PnlPawns.Controls.Add(lbl4_0)
        PnlPawns.Controls.Add(lbl3_5)
        PnlPawns.Controls.Add(lbl3_4)
        PnlPawns.Controls.Add(lbl3_3)
        PnlPawns.Controls.Add(lbl3_2)
        PnlPawns.Controls.Add(lbl3_1)
        PnlPawns.Controls.Add(lbl3_0)
        PnlPawns.Controls.Add(lbl2_5)
        PnlPawns.Controls.Add(lbl2_4)
        PnlPawns.Controls.Add(lbl2_3)
        PnlPawns.Controls.Add(lbl2_2)
        PnlPawns.Controls.Add(lbl2_1)
        PnlPawns.Controls.Add(lbl2_0)
        PnlPawns.Controls.Add(lbl1_5)
        PnlPawns.Controls.Add(lbl1_4)
        PnlPawns.Controls.Add(lbl1_3)
        PnlPawns.Controls.Add(lbl1_2)
        PnlPawns.Controls.Add(lbl1_1)
        PnlPawns.Controls.Add(lbl1_0)
        PnlPawns.Controls.Add(lbl0_5)
        PnlPawns.Controls.Add(lbl0_4)
        PnlPawns.Controls.Add(lbl0_3)
        PnlPawns.Controls.Add(lbl0_2)
        PnlPawns.Controls.Add(lbl0_1)
        PnlPawns.Controls.Add(lbl0_0)
        PnlPawns.Location = New System.Drawing.Point(8, 8)
        PnlPawns.Name = "PnlPawns"
        PnlPawns.Size = New System.Drawing.Size(292, 252)
        PnlPawns.TabIndex = 0
        '
        'lbl6_5
        '
        lbl6_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl6_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl6_5.Location = New System.Drawing.Point(248, 8)
        lbl6_5.Name = "lbl6_5"
        lbl6_5.Size = New System.Drawing.Size(32, 32)
        lbl6_5.TabIndex = 41
        lbl6_5.Text = "X"
        lbl6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl6_5.UseMnemonic = False
        '
        'lbl6_4
        '
        lbl6_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl6_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl6_4.Location = New System.Drawing.Point(248, 48)
        lbl6_4.Name = "lbl6_4"
        lbl6_4.Size = New System.Drawing.Size(32, 32)
        lbl6_4.TabIndex = 40
        lbl6_4.Text = "X"
        lbl6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl6_4.UseMnemonic = False
        '
        'lbl6_3
        '
        lbl6_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl6_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl6_3.Location = New System.Drawing.Point(248, 88)
        lbl6_3.Name = "lbl6_3"
        lbl6_3.Size = New System.Drawing.Size(32, 32)
        lbl6_3.TabIndex = 39
        lbl6_3.Text = "X"
        lbl6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl6_3.UseMnemonic = False
        '
        'lbl6_2
        '
        lbl6_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl6_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl6_2.Location = New System.Drawing.Point(248, 128)
        lbl6_2.Name = "lbl6_2"
        lbl6_2.Size = New System.Drawing.Size(32, 32)
        lbl6_2.TabIndex = 38
        lbl6_2.Text = "X"
        lbl6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl6_2.UseMnemonic = False
        '
        'lbl6_1
        '
        lbl6_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl6_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl6_1.Location = New System.Drawing.Point(248, 168)
        lbl6_1.Name = "lbl6_1"
        lbl6_1.Size = New System.Drawing.Size(32, 32)
        lbl6_1.TabIndex = 37
        lbl6_1.Text = "X"
        lbl6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl6_1.UseMnemonic = False
        '
        'lbl6_0
        '
        lbl6_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl6_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl6_0.Location = New System.Drawing.Point(248, 208)
        lbl6_0.Name = "lbl6_0"
        lbl6_0.Size = New System.Drawing.Size(32, 32)
        lbl6_0.TabIndex = 36
        lbl6_0.Text = "X"
        lbl6_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl6_0.UseMnemonic = False
        '
        'lbl5_5
        '
        lbl5_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl5_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl5_5.Location = New System.Drawing.Point(208, 8)
        lbl5_5.Name = "lbl5_5"
        lbl5_5.Size = New System.Drawing.Size(32, 32)
        lbl5_5.TabIndex = 35
        lbl5_5.Text = "X"
        lbl5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl5_5.UseMnemonic = False
        '
        'lbl5_4
        '
        lbl5_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl5_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl5_4.Location = New System.Drawing.Point(208, 48)
        lbl5_4.Name = "lbl5_4"
        lbl5_4.Size = New System.Drawing.Size(32, 32)
        lbl5_4.TabIndex = 34
        lbl5_4.Text = "X"
        lbl5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl5_4.UseMnemonic = False
        '
        'lbl5_3
        '
        lbl5_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl5_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl5_3.Location = New System.Drawing.Point(208, 88)
        lbl5_3.Name = "lbl5_3"
        lbl5_3.Size = New System.Drawing.Size(32, 32)
        lbl5_3.TabIndex = 33
        lbl5_3.Text = "X"
        lbl5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl5_3.UseMnemonic = False
        '
        'lbl5_2
        '
        lbl5_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl5_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl5_2.Location = New System.Drawing.Point(208, 128)
        lbl5_2.Name = "lbl5_2"
        lbl5_2.Size = New System.Drawing.Size(32, 32)
        lbl5_2.TabIndex = 32
        lbl5_2.Text = "X"
        lbl5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl5_2.UseMnemonic = False
        '
        'lbl5_1
        '
        lbl5_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl5_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl5_1.Location = New System.Drawing.Point(208, 168)
        lbl5_1.Name = "lbl5_1"
        lbl5_1.Size = New System.Drawing.Size(32, 32)
        lbl5_1.TabIndex = 31
        lbl5_1.Text = "X"
        lbl5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl5_1.UseMnemonic = False
        '
        'lbl5_0
        '
        lbl5_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl5_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl5_0.Location = New System.Drawing.Point(208, 208)
        lbl5_0.Name = "lbl5_0"
        lbl5_0.Size = New System.Drawing.Size(32, 32)
        lbl5_0.TabIndex = 30
        lbl5_0.Text = "X"
        lbl5_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl5_0.UseMnemonic = False
        '
        'lbl4_5
        '
        lbl4_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl4_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl4_5.Location = New System.Drawing.Point(168, 8)
        lbl4_5.Name = "lbl4_5"
        lbl4_5.Size = New System.Drawing.Size(32, 32)
        lbl4_5.TabIndex = 29
        lbl4_5.Text = "X"
        lbl4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl4_5.UseMnemonic = False
        '
        'lbl4_4
        '
        lbl4_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl4_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl4_4.Location = New System.Drawing.Point(168, 48)
        lbl4_4.Name = "lbl4_4"
        lbl4_4.Size = New System.Drawing.Size(32, 32)
        lbl4_4.TabIndex = 28
        lbl4_4.Text = "X"
        lbl4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl4_4.UseMnemonic = False
        '
        'lbl4_3
        '
        lbl4_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl4_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl4_3.Location = New System.Drawing.Point(168, 88)
        lbl4_3.Name = "lbl4_3"
        lbl4_3.Size = New System.Drawing.Size(32, 32)
        lbl4_3.TabIndex = 27
        lbl4_3.Text = "X"
        lbl4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl4_3.UseMnemonic = False
        '
        'lbl4_2
        '
        lbl4_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl4_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl4_2.Location = New System.Drawing.Point(168, 128)
        lbl4_2.Name = "lbl4_2"
        lbl4_2.Size = New System.Drawing.Size(32, 32)
        lbl4_2.TabIndex = 26
        lbl4_2.Text = "X"
        lbl4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl4_2.UseMnemonic = False
        '
        'lbl4_1
        '
        lbl4_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl4_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl4_1.Location = New System.Drawing.Point(168, 168)
        lbl4_1.Name = "lbl4_1"
        lbl4_1.Size = New System.Drawing.Size(32, 32)
        lbl4_1.TabIndex = 25
        lbl4_1.Text = "X"
        lbl4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl4_1.UseMnemonic = False
        '
        'lbl4_0
        '
        lbl4_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl4_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl4_0.Location = New System.Drawing.Point(168, 208)
        lbl4_0.Name = "lbl4_0"
        lbl4_0.Size = New System.Drawing.Size(32, 32)
        lbl4_0.TabIndex = 24
        lbl4_0.Text = "X"
        lbl4_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl4_0.UseMnemonic = False
        '
        'lbl3_5
        '
        lbl3_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl3_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl3_5.Location = New System.Drawing.Point(128, 8)
        lbl3_5.Name = "lbl3_5"
        lbl3_5.Size = New System.Drawing.Size(32, 32)
        lbl3_5.TabIndex = 23
        lbl3_5.Text = "X"
        lbl3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl3_5.UseMnemonic = False
        '
        'lbl3_4
        '
        lbl3_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl3_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl3_4.Location = New System.Drawing.Point(128, 48)
        lbl3_4.Name = "lbl3_4"
        lbl3_4.Size = New System.Drawing.Size(32, 32)
        lbl3_4.TabIndex = 22
        lbl3_4.Text = "X"
        lbl3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl3_4.UseMnemonic = False
        '
        'lbl3_3
        '
        lbl3_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl3_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl3_3.Location = New System.Drawing.Point(128, 88)
        lbl3_3.Name = "lbl3_3"
        lbl3_3.Size = New System.Drawing.Size(32, 32)
        lbl3_3.TabIndex = 21
        lbl3_3.Text = "X"
        lbl3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl3_3.UseMnemonic = False
        '
        'lbl3_2
        '
        lbl3_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl3_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl3_2.Location = New System.Drawing.Point(128, 128)
        lbl3_2.Name = "lbl3_2"
        lbl3_2.Size = New System.Drawing.Size(32, 32)
        lbl3_2.TabIndex = 20
        lbl3_2.Text = "X"
        lbl3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl3_2.UseMnemonic = False
        '
        'lbl3_1
        '
        lbl3_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl3_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl3_1.Location = New System.Drawing.Point(128, 168)
        lbl3_1.Name = "lbl3_1"
        lbl3_1.Size = New System.Drawing.Size(32, 32)
        lbl3_1.TabIndex = 19
        lbl3_1.Text = "X"
        lbl3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl3_1.UseMnemonic = False
        '
        'lbl3_0
        '
        lbl3_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl3_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl3_0.Location = New System.Drawing.Point(128, 208)
        lbl3_0.Name = "lbl3_0"
        lbl3_0.Size = New System.Drawing.Size(32, 32)
        lbl3_0.TabIndex = 18
        lbl3_0.Text = "X"
        lbl3_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl3_0.UseMnemonic = False
        '
        'lbl2_5
        '
        lbl2_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl2_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl2_5.Location = New System.Drawing.Point(88, 8)
        lbl2_5.Name = "lbl2_5"
        lbl2_5.Size = New System.Drawing.Size(32, 32)
        lbl2_5.TabIndex = 17
        lbl2_5.Text = "X"
        lbl2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl2_5.UseMnemonic = False
        '
        'lbl2_4
        '
        lbl2_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl2_4.Location = New System.Drawing.Point(88, 48)
        lbl2_4.Name = "lbl2_4"
        lbl2_4.Size = New System.Drawing.Size(32, 32)
        lbl2_4.TabIndex = 16
        lbl2_4.Text = "X"
        lbl2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl2_4.UseMnemonic = False
        '
        'lbl2_3
        '
        lbl2_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl2_3.Location = New System.Drawing.Point(88, 88)
        lbl2_3.Name = "lbl2_3"
        lbl2_3.Size = New System.Drawing.Size(32, 32)
        lbl2_3.TabIndex = 15
        lbl2_3.Text = "X"
        lbl2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl2_3.UseMnemonic = False
        '
        'lbl2_2
        '
        lbl2_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl2_2.Location = New System.Drawing.Point(88, 128)
        lbl2_2.Name = "lbl2_2"
        lbl2_2.Size = New System.Drawing.Size(32, 32)
        lbl2_2.TabIndex = 14
        lbl2_2.Text = "X"
        lbl2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl2_2.UseMnemonic = False
        '
        'lbl2_1
        '
        lbl2_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl2_1.Location = New System.Drawing.Point(88, 168)
        lbl2_1.Name = "lbl2_1"
        lbl2_1.Size = New System.Drawing.Size(32, 32)
        lbl2_1.TabIndex = 13
        lbl2_1.Text = "X"
        lbl2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl2_1.UseMnemonic = False
        '
        'lbl2_0
        '
        lbl2_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl2_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl2_0.Location = New System.Drawing.Point(88, 208)
        lbl2_0.Name = "lbl2_0"
        lbl2_0.Size = New System.Drawing.Size(32, 32)
        lbl2_0.TabIndex = 12
        lbl2_0.Text = "X"
        lbl2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl2_0.UseMnemonic = False
        '
        'lbl1_5
        '
        lbl1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1_5.Location = New System.Drawing.Point(48, 8)
        lbl1_5.Name = "lbl1_5"
        lbl1_5.Size = New System.Drawing.Size(32, 32)
        lbl1_5.TabIndex = 11
        lbl1_5.Text = "X"
        lbl1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl1_5.UseMnemonic = False
        '
        'lbl1_4
        '
        lbl1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1_4.Location = New System.Drawing.Point(48, 48)
        lbl1_4.Name = "lbl1_4"
        lbl1_4.Size = New System.Drawing.Size(32, 32)
        lbl1_4.TabIndex = 10
        lbl1_4.Text = "X"
        lbl1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl1_4.UseMnemonic = False
        '
        'lbl1_3
        '
        lbl1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1_3.Location = New System.Drawing.Point(48, 88)
        lbl1_3.Name = "lbl1_3"
        lbl1_3.Size = New System.Drawing.Size(32, 32)
        lbl1_3.TabIndex = 9
        lbl1_3.Text = "X"
        lbl1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl1_3.UseMnemonic = False
        '
        'lbl1_2
        '
        lbl1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1_2.Location = New System.Drawing.Point(48, 128)
        lbl1_2.Name = "lbl1_2"
        lbl1_2.Size = New System.Drawing.Size(32, 32)
        lbl1_2.TabIndex = 8
        lbl1_2.Text = "X"
        lbl1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl1_2.UseMnemonic = False
        '
        'lbl1_1
        '
        lbl1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1_1.Location = New System.Drawing.Point(48, 168)
        lbl1_1.Name = "lbl1_1"
        lbl1_1.Size = New System.Drawing.Size(32, 32)
        lbl1_1.TabIndex = 7
        lbl1_1.Text = "X"
        lbl1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl1_1.UseMnemonic = False
        '
        'lbl1_0
        '
        lbl1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl1_0.Location = New System.Drawing.Point(48, 208)
        lbl1_0.Name = "lbl1_0"
        lbl1_0.Size = New System.Drawing.Size(32, 32)
        lbl1_0.TabIndex = 6
        lbl1_0.Text = "X"
        lbl1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl1_0.UseMnemonic = False
        '
        'lbl0_5
        '
        lbl0_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl0_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl0_5.Location = New System.Drawing.Point(8, 8)
        lbl0_5.Name = "lbl0_5"
        lbl0_5.Size = New System.Drawing.Size(32, 32)
        lbl0_5.TabIndex = 5
        lbl0_5.Text = "X"
        lbl0_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl0_5.UseMnemonic = False
        '
        'lbl0_4
        '
        lbl0_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl0_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl0_4.Location = New System.Drawing.Point(8, 48)
        lbl0_4.Name = "lbl0_4"
        lbl0_4.Size = New System.Drawing.Size(32, 32)
        lbl0_4.TabIndex = 4
        lbl0_4.Text = "X"
        lbl0_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl0_4.UseMnemonic = False
        '
        'lbl0_3
        '
        lbl0_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl0_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl0_3.Location = New System.Drawing.Point(8, 88)
        lbl0_3.Name = "lbl0_3"
        lbl0_3.Size = New System.Drawing.Size(32, 32)
        lbl0_3.TabIndex = 3
        lbl0_3.Text = "X"
        lbl0_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl0_3.UseMnemonic = False
        '
        'lbl0_2
        '
        lbl0_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl0_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl0_2.Location = New System.Drawing.Point(8, 128)
        lbl0_2.Name = "lbl0_2"
        lbl0_2.Size = New System.Drawing.Size(32, 32)
        lbl0_2.TabIndex = 2
        lbl0_2.Text = "X"
        lbl0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl0_2.UseMnemonic = False
        '
        'lbl0_1
        '
        lbl0_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl0_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl0_1.Location = New System.Drawing.Point(8, 168)
        lbl0_1.Name = "lbl0_1"
        lbl0_1.Size = New System.Drawing.Size(32, 32)
        lbl0_1.TabIndex = 1
        lbl0_1.Text = "X"
        lbl0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl0_1.UseMnemonic = False
        '
        'lbl0_0
        '
        lbl0_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lbl0_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl0_0.Location = New System.Drawing.Point(8, 208)
        lbl0_0.Name = "lbl0_0"
        lbl0_0.Size = New System.Drawing.Size(32, 32)
        lbl0_0.TabIndex = 0
        lbl0_0.Text = "X"
        lbl0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lbl0_0.UseMnemonic = False
        '
        'PnlButtons
        '
        PnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PnlButtons.Controls.Add(cmd7)
        PnlButtons.Controls.Add(cmd6)
        PnlButtons.Controls.Add(cmd5)
        PnlButtons.Controls.Add(cmd4)
        PnlButtons.Controls.Add(cmd3)
        PnlButtons.Controls.Add(cmd2)
        PnlButtons.Controls.Add(cmd1)
        PnlButtons.Location = New System.Drawing.Point(8, 268)
        PnlButtons.Name = "PnlButtons"
        PnlButtons.Size = New System.Drawing.Size(292, 52)
        PnlButtons.TabIndex = 1
        '
        'cmd7
        '
        cmd7.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd7.Location = New System.Drawing.Point(248, 8)
        cmd7.Name = "cmd7"
        cmd7.Size = New System.Drawing.Size(32, 32)
        cmd7.TabIndex = 6
        cmd7.Tag = "6"
        cmd7.Text = "&7"
        '
        'cmd6
        '
        cmd6.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd6.Location = New System.Drawing.Point(208, 8)
        cmd6.Name = "cmd6"
        cmd6.Size = New System.Drawing.Size(32, 32)
        cmd6.TabIndex = 5
        cmd6.Tag = "5"
        cmd6.Text = "&6"
        '
        'cmd5
        '
        cmd5.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd5.Location = New System.Drawing.Point(168, 8)
        cmd5.Name = "cmd5"
        cmd5.Size = New System.Drawing.Size(32, 32)
        cmd5.TabIndex = 4
        cmd5.Tag = "4"
        cmd5.Text = "&5"
        '
        'cmd4
        '
        cmd4.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd4.Location = New System.Drawing.Point(128, 8)
        cmd4.Name = "cmd4"
        cmd4.Size = New System.Drawing.Size(32, 32)
        cmd4.TabIndex = 3
        cmd4.Tag = "3"
        cmd4.Text = "&4"
        '
        'cmd3
        '
        cmd3.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd3.Location = New System.Drawing.Point(88, 8)
        cmd3.Name = "cmd3"
        cmd3.Size = New System.Drawing.Size(32, 32)
        cmd3.TabIndex = 2
        cmd3.Tag = "2"
        cmd3.Text = "&3"
        '
        'cmd2
        '
        cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd2.Location = New System.Drawing.Point(48, 8)
        cmd2.Name = "cmd2"
        cmd2.Size = New System.Drawing.Size(32, 32)
        cmd2.TabIndex = 1
        cmd2.Tag = "1"
        cmd2.Text = "&2"
        '
        'cmd1
        '
        cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System
        cmd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd1.Location = New System.Drawing.Point(8, 8)
        cmd1.Name = "cmd1"
        cmd1.Size = New System.Drawing.Size(32, 32)
        cmd1.TabIndex = 0
        cmd1.Tag = "0"
        cmd1.Text = "&1"
        '
        'PnlStatus
        '
        PnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        GrpComputer.FlatStyle = System.Windows.Forms.FlatStyle.System
        GrpComputer.Location = New System.Drawing.Point(8, 116)
        GrpComputer.Name = "GrpComputer"
        GrpComputer.Size = New System.Drawing.Size(168, 100)
        GrpComputer.TabIndex = 1
        GrpComputer.TabStop = False
        GrpComputer.Text = "Computer (O):"
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
        GrpPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System
        GrpPlayer.Location = New System.Drawing.Point(8, 8)
        GrpPlayer.Name = "GrpPlayer"
        GrpPlayer.Size = New System.Drawing.Size(168, 100)
        GrpPlayer.TabIndex = 0
        GrpPlayer.TabStop = False
        GrpPlayer.Text = "Player (X):"
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
        TxtStatus.BackColor = System.Drawing.Color.Black
        TxtStatus.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TxtStatus.ForeColor = System.Drawing.Color.Red
        TxtStatus.Location = New System.Drawing.Point(308, 244)
        TxtStatus.Multiline = True
        TxtStatus.Name = "TxtStatus"
        TxtStatus.ReadOnly = True
        TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        TxtStatus.Size = New System.Drawing.Size(188, 76)
        TxtStatus.TabIndex = 3
        TxtStatus.TabStop = False
        TxtStatus.Text = "Ready!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ready!!!!!"
        '
        'FrmMain
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(504, 327)
        Controls.Add(TxtStatus)
        Controls.Add(PnlStatus)
        Controls.Add(PnlButtons)
        Controls.Add(PnlPawns)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MaximizeBox = False
        Menu = MnuMain
        Name = "FrmMain"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
			lbl0_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl0_0.ForeColor = cmd1.ForeColor
		End If
		lbl0_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl0_1.ForeColor = cmd1.ForeColor
		End If
		lbl0_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl0_2.ForeColor = cmd1.ForeColor
		End If
		lbl0_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl0_3.ForeColor = cmd1.ForeColor
		End If
		lbl0_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl0_4.ForeColor = cmd1.ForeColor
		End If
		lbl0_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(0, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl0_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl0_5.ForeColor = cmd1.ForeColor
		End If
		lbl0_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl1_0.ForeColor = cmd2.ForeColor
		End If
		lbl1_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl1_1.ForeColor = cmd2.ForeColor
		End If
		lbl1_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl1_2.ForeColor = cmd2.ForeColor
		End If
		lbl1_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl1_3.ForeColor = cmd2.ForeColor
		End If
		lbl1_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl1_4.ForeColor = cmd2.ForeColor
		End If
		lbl1_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(1, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl1_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl1_5.ForeColor = cmd2.ForeColor
		End If
		lbl1_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl2_0.ForeColor = cmd3.ForeColor
		End If
		lbl2_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl2_1.ForeColor = cmd3.ForeColor
		End If
		lbl2_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl2_2.ForeColor = cmd3.ForeColor
		End If
		lbl2_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl2_3.ForeColor = cmd3.ForeColor
		End If
		lbl2_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl2_4.ForeColor = cmd3.ForeColor
		End If
		lbl2_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(2, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl2_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl2_5.ForeColor = cmd3.ForeColor
		End If
		lbl2_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl3_0.ForeColor = cmd4.ForeColor
		End If
		lbl3_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl3_1.ForeColor = cmd4.ForeColor
		End If
		lbl3_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl3_2.ForeColor = cmd4.ForeColor
		End If
		lbl3_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl3_3.ForeColor = cmd4.ForeColor
		End If
		lbl3_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl3_4.ForeColor = cmd4.ForeColor
		End If
		lbl3_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(3, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl3_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl3_5.ForeColor = cmd4.ForeColor
		End If
		lbl3_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl4_0.ForeColor = cmd5.ForeColor
		End If
		lbl4_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl4_1.ForeColor = cmd5.ForeColor
		End If
		lbl4_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl4_2.ForeColor = cmd5.ForeColor
		End If
		lbl4_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl4_3.ForeColor = cmd5.ForeColor
		End If
		lbl4_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl4_4.ForeColor = cmd5.ForeColor
		End If
		lbl4_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(4, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl4_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl4_5.ForeColor = cmd5.ForeColor
		End If
		lbl4_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl5_0.ForeColor = cmd6.ForeColor
		End If
		lbl5_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl5_1.ForeColor = cmd6.ForeColor
		End If
		lbl5_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl5_2.ForeColor = cmd6.ForeColor
		End If
		lbl5_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl5_3.ForeColor = cmd6.ForeColor
		End If
		lbl5_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl5_4.ForeColor = cmd6.ForeColor
		End If
		lbl5_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(5, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl5_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl5_5.ForeColor = cmd6.ForeColor
		End If
		lbl5_5.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 0)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_0.ForeColor = TxtStatus.ForeColor
		Else
			lbl6_0.ForeColor = cmd7.ForeColor
		End If
		lbl6_0.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 1)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_1.ForeColor = TxtStatus.ForeColor
		Else
			lbl6_1.ForeColor = cmd7.ForeColor
		End If
		lbl6_1.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 2)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_2.ForeColor = TxtStatus.ForeColor
		Else
			lbl6_2.ForeColor = cmd7.ForeColor
		End If
		lbl6_2.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 3)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_3.ForeColor = TxtStatus.ForeColor
		Else
			lbl6_3.ForeColor = cmd7.ForeColor
		End If
		lbl6_3.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 4)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_4.ForeColor = TxtStatus.ForeColor
		Else
			lbl6_4.ForeColor = cmd7.ForeColor
		End If
		lbl6_4.Text = UCase(myChip)

		myChip = GameEngine.GetMove(6, 5)
		If myChip = Cls4Play.Player1WinChip Or myChip = Cls4Play.Player2WinChip Then
			lbl6_5.ForeColor = TxtStatus.ForeColor
		Else
			lbl6_5.ForeColor = cmd7.ForeColor
		End If
		lbl6_5.Text = UCase(myChip)
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
		 Diagnostics.FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly.Location).LegalCopyright &
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
