<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NowShowingForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NowShowingForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NextNSPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Nname4 = New System.Windows.Forms.Label()
        Me.RatingNM4 = New System.Windows.Forms.Label()
        Me.star4 = New System.Windows.Forms.PictureBox()
        Me.Nmovie4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Nname3 = New System.Windows.Forms.Label()
        Me.RatingNM3 = New System.Windows.Forms.Label()
        Me.star3 = New System.Windows.Forms.PictureBox()
        Me.Nmovie3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Nname1 = New System.Windows.Forms.Label()
        Me.RatingNM1 = New System.Windows.Forms.Label()
        Me.star1 = New System.Windows.Forms.PictureBox()
        Me.Nmovie1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Nname2 = New System.Windows.Forms.Label()
        Me.RatingNM2 = New System.Windows.Forms.Label()
        Me.star2 = New System.Windows.Forms.PictureBox()
        Me.Nmovie2 = New System.Windows.Forms.Button()
        Me.recommendedLabel = New System.Windows.Forms.Label()
        Me.NextNSPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.star4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.star3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.star1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.star2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'NextNSPanel
        '
        Me.NextNSPanel.Controls.Add(Me.PictureBox1)
        Me.NextNSPanel.Controls.Add(Me.Panel5)
        Me.NextNSPanel.Controls.Add(Me.Panel4)
        Me.NextNSPanel.Controls.Add(Me.Panel2)
        Me.NextNSPanel.Controls.Add(Me.Panel3)
        Me.NextNSPanel.Controls.Add(Me.recommendedLabel)
        Me.NextNSPanel.Location = New System.Drawing.Point(0, 0)
        Me.NextNSPanel.Name = "NextNSPanel"
        Me.NextNSPanel.Size = New System.Drawing.Size(1043, 707)
        Me.NextNSPanel.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(51, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(956, 301)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Nname4)
        Me.Panel5.Controls.Add(Me.RatingNM4)
        Me.Panel5.Controls.Add(Me.star4)
        Me.Panel5.Controls.Add(Me.Nmovie4)
        Me.Panel5.Location = New System.Drawing.Point(822, 377)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(185, 314)
        Me.Panel5.TabIndex = 9
        '
        'Nname4
        '
        Me.Nname4.AutoSize = True
        Me.Nname4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nname4.Location = New System.Drawing.Point(24, 278)
        Me.Nname4.Name = "Nname4"
        Me.Nname4.Size = New System.Drawing.Size(110, 22)
        Me.Nname4.TabIndex = 3
        Me.Nname4.Text = "Lallu Kei Laila"
        '
        'RatingNM4
        '
        Me.RatingNM4.AutoSize = True
        Me.RatingNM4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatingNM4.Location = New System.Drawing.Point(48, 253)
        Me.RatingNM4.Name = "RatingNM4"
        Me.RatingNM4.Size = New System.Drawing.Size(59, 22)
        Me.RatingNM4.TabIndex = 2
        Me.RatingNM4.Text = "9.6/10"
        '
        'star4
        '
        Me.star4.Image = CType(resources.GetObject("star4.Image"), System.Drawing.Image)
        Me.star4.Location = New System.Drawing.Point(19, 253)
        Me.star4.Name = "star4"
        Me.star4.Size = New System.Drawing.Size(23, 22)
        Me.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star4.TabIndex = 1
        Me.star4.TabStop = False
        '
        'Nmovie4
        '
        Me.Nmovie4.BackgroundImage = CType(resources.GetObject("Nmovie4.BackgroundImage"), System.Drawing.Image)
        Me.Nmovie4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nmovie4.FlatAppearance.BorderSize = 0
        Me.Nmovie4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nmovie4.Location = New System.Drawing.Point(0, 0)
        Me.Nmovie4.Name = "Nmovie4"
        Me.Nmovie4.Size = New System.Drawing.Size(185, 250)
        Me.Nmovie4.TabIndex = 0
        Me.Nmovie4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Nname3)
        Me.Panel4.Controls.Add(Me.RatingNM3)
        Me.Panel4.Controls.Add(Me.star3)
        Me.Panel4.Controls.Add(Me.Nmovie3)
        Me.Panel4.Location = New System.Drawing.Point(565, 377)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 314)
        Me.Panel4.TabIndex = 10
        '
        'Nname3
        '
        Me.Nname3.AutoSize = True
        Me.Nname3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nname3.Location = New System.Drawing.Point(24, 278)
        Me.Nname3.Name = "Nname3"
        Me.Nname3.Size = New System.Drawing.Size(73, 22)
        Me.Nname3.TabIndex = 3
        Me.Nname3.Text = "Pathaan"
        '
        'RatingNM3
        '
        Me.RatingNM3.AutoSize = True
        Me.RatingNM3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatingNM3.Location = New System.Drawing.Point(48, 253)
        Me.RatingNM3.Name = "RatingNM3"
        Me.RatingNM3.Size = New System.Drawing.Size(59, 22)
        Me.RatingNM3.TabIndex = 2
        Me.RatingNM3.Text = "8.7/10"
        '
        'star3
        '
        Me.star3.Image = CType(resources.GetObject("star3.Image"), System.Drawing.Image)
        Me.star3.Location = New System.Drawing.Point(19, 253)
        Me.star3.Name = "star3"
        Me.star3.Size = New System.Drawing.Size(23, 22)
        Me.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star3.TabIndex = 1
        Me.star3.TabStop = False
        '
        'Nmovie3
        '
        Me.Nmovie3.BackgroundImage = CType(resources.GetObject("Nmovie3.BackgroundImage"), System.Drawing.Image)
        Me.Nmovie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nmovie3.FlatAppearance.BorderSize = 0
        Me.Nmovie3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nmovie3.Location = New System.Drawing.Point(0, 0)
        Me.Nmovie3.Name = "Nmovie3"
        Me.Nmovie3.Size = New System.Drawing.Size(185, 250)
        Me.Nmovie3.TabIndex = 0
        Me.Nmovie3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Nname1)
        Me.Panel2.Controls.Add(Me.RatingNM1)
        Me.Panel2.Controls.Add(Me.star1)
        Me.Panel2.Controls.Add(Me.Nmovie1)
        Me.Panel2.Location = New System.Drawing.Point(57, 377)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 314)
        Me.Panel2.TabIndex = 7
        '
        'Nname1
        '
        Me.Nname1.AutoSize = True
        Me.Nname1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nname1.Location = New System.Drawing.Point(24, 278)
        Me.Nname1.Name = "Nname1"
        Me.Nname1.Size = New System.Drawing.Size(74, 22)
        Me.Nname1.TabIndex = 3
        Me.Nname1.Text = "The Nun"
        '
        'RatingNM1
        '
        Me.RatingNM1.AutoSize = True
        Me.RatingNM1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatingNM1.Location = New System.Drawing.Point(48, 253)
        Me.RatingNM1.Name = "RatingNM1"
        Me.RatingNM1.Size = New System.Drawing.Size(59, 22)
        Me.RatingNM1.TabIndex = 2
        Me.RatingNM1.Text = "9.5/10"
        '
        'star1
        '
        Me.star1.Image = CType(resources.GetObject("star1.Image"), System.Drawing.Image)
        Me.star1.Location = New System.Drawing.Point(19, 253)
        Me.star1.Name = "star1"
        Me.star1.Size = New System.Drawing.Size(23, 22)
        Me.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star1.TabIndex = 1
        Me.star1.TabStop = False
        '
        'Nmovie1
        '
        Me.Nmovie1.BackgroundImage = CType(resources.GetObject("Nmovie1.BackgroundImage"), System.Drawing.Image)
        Me.Nmovie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nmovie1.FlatAppearance.BorderSize = 0
        Me.Nmovie1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nmovie1.Location = New System.Drawing.Point(0, 0)
        Me.Nmovie1.Name = "Nmovie1"
        Me.Nmovie1.Size = New System.Drawing.Size(185, 250)
        Me.Nmovie1.TabIndex = 0
        Me.Nmovie1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Nname2)
        Me.Panel3.Controls.Add(Me.RatingNM2)
        Me.Panel3.Controls.Add(Me.star2)
        Me.Panel3.Controls.Add(Me.Nmovie2)
        Me.Panel3.Location = New System.Drawing.Point(307, 377)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 314)
        Me.Panel3.TabIndex = 11
        '
        'Nname2
        '
        Me.Nname2.AutoSize = True
        Me.Nname2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nname2.Location = New System.Drawing.Point(24, 278)
        Me.Nname2.Name = "Nname2"
        Me.Nname2.Size = New System.Drawing.Size(70, 22)
        Me.Nname2.TabIndex = 3
        Me.Nname2.Text = "Suzume"
        '
        'RatingNM2
        '
        Me.RatingNM2.AutoSize = True
        Me.RatingNM2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatingNM2.Location = New System.Drawing.Point(48, 253)
        Me.RatingNM2.Name = "RatingNM2"
        Me.RatingNM2.Size = New System.Drawing.Size(59, 22)
        Me.RatingNM2.TabIndex = 2
        Me.RatingNM2.Text = "8.2/10"
        '
        'star2
        '
        Me.star2.Image = CType(resources.GetObject("star2.Image"), System.Drawing.Image)
        Me.star2.Location = New System.Drawing.Point(19, 253)
        Me.star2.Name = "star2"
        Me.star2.Size = New System.Drawing.Size(23, 22)
        Me.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star2.TabIndex = 1
        Me.star2.TabStop = False
        '
        'Nmovie2
        '
        Me.Nmovie2.BackgroundImage = CType(resources.GetObject("Nmovie2.BackgroundImage"), System.Drawing.Image)
        Me.Nmovie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nmovie2.FlatAppearance.BorderSize = 0
        Me.Nmovie2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nmovie2.Location = New System.Drawing.Point(0, 0)
        Me.Nmovie2.Name = "Nmovie2"
        Me.Nmovie2.Size = New System.Drawing.Size(185, 250)
        Me.Nmovie2.TabIndex = 0
        Me.Nmovie2.UseVisualStyleBackColor = True
        '
        'recommendedLabel
        '
        Me.recommendedLabel.AutoSize = True
        Me.recommendedLabel.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recommendedLabel.Location = New System.Drawing.Point(36, 311)
        Me.recommendedLabel.Name = "recommendedLabel"
        Me.recommendedLabel.Size = New System.Drawing.Size(191, 35)
        Me.recommendedLabel.TabIndex = 6
        Me.recommendedLabel.Text = "Recommended"
        '
        'NowShowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 708)
        Me.Controls.Add(Me.NextNSPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NowShowingForm"
        Me.Text = "NowShowingForm"
        Me.NextNSPanel.ResumeLayout(False)
        Me.NextNSPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.star4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.star3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.star1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.star2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NextNSPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Nname4 As Label
    Friend WithEvents RatingNM4 As Label
    Friend WithEvents star4 As PictureBox
    Friend WithEvents Nmovie4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Nname3 As Label
    Friend WithEvents RatingNM3 As Label
    Friend WithEvents star3 As PictureBox
    Friend WithEvents Nmovie3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Nname1 As Label
    Friend WithEvents RatingNM1 As Label
    Friend WithEvents star1 As PictureBox
    Friend WithEvents Nmovie1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Nname2 As Label
    Friend WithEvents RatingNM2 As Label
    Friend WithEvents star2 As PictureBox
    Friend WithEvents Nmovie2 As Button
    Friend WithEvents recommendedLabel As Label
End Class
