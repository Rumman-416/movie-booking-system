<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.Logopanel = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.SlideButton1 = New AltoControls.SlideButton()
        Me.HighlightBeverages = New System.Windows.Forms.Panel()
        Me.BeverageBTN = New System.Windows.Forms.Button()
        Me.HighlightScreen = New System.Windows.Forms.Panel()
        Me.ScreenBTN = New System.Windows.Forms.Button()
        Me.HighlightGenre = New System.Windows.Forms.Panel()
        Me.GenreBTN = New System.Windows.Forms.Button()
        Me.HighlightMain = New System.Windows.Forms.Panel()
        Me.MainBTN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.LeftPanel.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.DisplayLabel)
        Me.LeftPanel.Controls.Add(Me.Logopanel)
        Me.LeftPanel.Controls.Add(Me.Logo)
        Me.LeftPanel.Controls.Add(Me.SlideButton1)
        Me.LeftPanel.Controls.Add(Me.HighlightBeverages)
        Me.LeftPanel.Controls.Add(Me.BeverageBTN)
        Me.LeftPanel.Controls.Add(Me.HighlightScreen)
        Me.LeftPanel.Controls.Add(Me.ScreenBTN)
        Me.LeftPanel.Controls.Add(Me.HighlightGenre)
        Me.LeftPanel.Controls.Add(Me.GenreBTN)
        Me.LeftPanel.Controls.Add(Me.HighlightMain)
        Me.LeftPanel.Controls.Add(Me.MainBTN)
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(257, 739)
        Me.LeftPanel.TabIndex = 0
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DisplayLabel.Location = New System.Drawing.Point(62, 693)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(125, 29)
        Me.DisplayLabel.TabIndex = 11
        Me.DisplayLabel.Text = "Light Mode"
        '
        'Logopanel
        '
        Me.Logopanel.AutoSize = True
        Me.Logopanel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logopanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Logopanel.Location = New System.Drawing.Point(82, 52)
        Me.Logopanel.Name = "Logopanel"
        Me.Logopanel.Size = New System.Drawing.Size(185, 37)
        Me.Logopanel.TabIndex = 10
        Me.Logopanel.Text = "Movie Dekh"
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(-19, 3)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(139, 113)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 9
        Me.Logo.TabStop = False
        '
        'SlideButton1
        '
        Me.SlideButton1.BorderColor = System.Drawing.Color.LightGray
        Me.SlideButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SlideButton1.IsOn = True
        Me.SlideButton1.Location = New System.Drawing.Point(86, 637)
        Me.SlideButton1.Name = "SlideButton1"
        Me.SlideButton1.Size = New System.Drawing.Size(70, 37)
        Me.SlideButton1.TabIndex = 0
        Me.SlideButton1.Text = "SlideButton1"
        Me.SlideButton1.TextEnabled = True
        '
        'HighlightBeverages
        '
        Me.HighlightBeverages.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.HighlightBeverages.Location = New System.Drawing.Point(3, 294)
        Me.HighlightBeverages.Name = "HighlightBeverages"
        Me.HighlightBeverages.Size = New System.Drawing.Size(11, 66)
        Me.HighlightBeverages.TabIndex = 8
        '
        'BeverageBTN
        '
        Me.BeverageBTN.FlatAppearance.BorderSize = 0
        Me.BeverageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BeverageBTN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeverageBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.BeverageBTN.Image = CType(resources.GetObject("BeverageBTN.Image"), System.Drawing.Image)
        Me.BeverageBTN.Location = New System.Drawing.Point(3, 294)
        Me.BeverageBTN.Name = "BeverageBTN"
        Me.BeverageBTN.Size = New System.Drawing.Size(254, 66)
        Me.BeverageBTN.TabIndex = 7
        Me.BeverageBTN.Text = "Beverages"
        Me.BeverageBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BeverageBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BeverageBTN.UseVisualStyleBackColor = True
        '
        'HighlightScreen
        '
        Me.HighlightScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.HighlightScreen.Location = New System.Drawing.Point(2, 379)
        Me.HighlightScreen.Name = "HighlightScreen"
        Me.HighlightScreen.Size = New System.Drawing.Size(11, 66)
        Me.HighlightScreen.TabIndex = 6
        '
        'ScreenBTN
        '
        Me.ScreenBTN.FlatAppearance.BorderSize = 0
        Me.ScreenBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScreenBTN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ScreenBTN.Image = CType(resources.GetObject("ScreenBTN.Image"), System.Drawing.Image)
        Me.ScreenBTN.Location = New System.Drawing.Point(2, 379)
        Me.ScreenBTN.Name = "ScreenBTN"
        Me.ScreenBTN.Size = New System.Drawing.Size(254, 66)
        Me.ScreenBTN.TabIndex = 5
        Me.ScreenBTN.Text = "About Us"
        Me.ScreenBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ScreenBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ScreenBTN.UseVisualStyleBackColor = True
        '
        'HighlightGenre
        '
        Me.HighlightGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.HighlightGenre.Location = New System.Drawing.Point(3, 209)
        Me.HighlightGenre.Name = "HighlightGenre"
        Me.HighlightGenre.Size = New System.Drawing.Size(11, 67)
        Me.HighlightGenre.TabIndex = 4
        '
        'GenreBTN
        '
        Me.GenreBTN.FlatAppearance.BorderSize = 0
        Me.GenreBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenreBTN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GenreBTN.Image = Global.movie_ticket.My.Resources.Resources.masks1
        Me.GenreBTN.Location = New System.Drawing.Point(3, 209)
        Me.GenreBTN.Name = "GenreBTN"
        Me.GenreBTN.Size = New System.Drawing.Size(254, 67)
        Me.GenreBTN.TabIndex = 3
        Me.GenreBTN.Text = "Genre"
        Me.GenreBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenreBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GenreBTN.UseVisualStyleBackColor = True
        '
        'HighlightMain
        '
        Me.HighlightMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.HighlightMain.Location = New System.Drawing.Point(3, 120)
        Me.HighlightMain.Name = "HighlightMain"
        Me.HighlightMain.Size = New System.Drawing.Size(11, 67)
        Me.HighlightMain.TabIndex = 2
        '
        'MainBTN
        '
        Me.MainBTN.FlatAppearance.BorderSize = 0
        Me.MainBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainBTN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.MainBTN.Image = Global.movie_ticket.My.Resources.Resources.reel
        Me.MainBTN.Location = New System.Drawing.Point(3, 120)
        Me.MainBTN.Name = "MainBTN"
        Me.MainBTN.Size = New System.Drawing.Size(254, 67)
        Me.MainBTN.TabIndex = 0
        Me.MainBTN.Text = "Now Streaming"
        Me.MainBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MainBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainBTN.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(257, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 1
        '
        'minus
        '
        Me.minus.BackgroundImage = CType(resources.GetObject("minus.BackgroundImage"), System.Drawing.Image)
        Me.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minus.FlatAppearance.BorderSize = 0
        Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus.Location = New System.Drawing.Point(958, 3)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(37, 40)
        Me.minus.TabIndex = 10
        Me.minus.UseVisualStyleBackColor = True
        '
        'cross
        '
        Me.cross.BackgroundImage = CType(resources.GetObject("cross.BackgroundImage"), System.Drawing.Image)
        Me.cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cross.FlatAppearance.BorderSize = 0
        Me.cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cross.Location = New System.Drawing.Point(1001, 3)
        Me.cross.Name = "cross"
        Me.cross.Size = New System.Drawing.Size(37, 40)
        Me.cross.TabIndex = 9
        Me.cross.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.Location = New System.Drawing.Point(257, 42)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1043, 697)
        Me.MainPanel.TabIndex = 2
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 740)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LeftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.Text = "Form1"
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MainBTN As Button
    Friend WithEvents HighlightMain As Panel
    Friend WithEvents HighlightBeverages As Panel
    Friend WithEvents BeverageBTN As Button
    Friend WithEvents HighlightScreen As Panel
    Friend WithEvents ScreenBTN As Button
    Friend WithEvents HighlightGenre As Panel
    Friend WithEvents GenreBTN As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SlideButton1 As AltoControls.SlideButton
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents Logopanel As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents DisplayLabel As Label
End Class
