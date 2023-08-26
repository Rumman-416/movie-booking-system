<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketForm))
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SeatLabel = New System.Windows.Forms.Label()
        Me.ScanLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BevLabel = New System.Windows.Forms.Label()
        Me.TotLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HomeBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(578, 196)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(48, 20)
        Me.TotalLabel.TabIndex = 9
        Me.TotalLabel.Text = "Label"
        '
        'SeatLabel
        '
        Me.SeatLabel.AutoSize = True
        Me.SeatLabel.Location = New System.Drawing.Point(589, 96)
        Me.SeatLabel.Name = "SeatLabel"
        Me.SeatLabel.Size = New System.Drawing.Size(82, 20)
        Me.SeatLabel.TabIndex = 8
        Me.SeatLabel.Text = "SeatLabel"
        '
        'ScanLabel
        '
        Me.ScanLabel.AutoSize = True
        Me.ScanLabel.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanLabel.Location = New System.Drawing.Point(0, 363)
        Me.ScanLabel.Name = "ScanLabel"
        Me.ScanLabel.Size = New System.Drawing.Size(363, 39)
        Me.ScanLabel.TabIndex = 7
        Me.ScanLabel.Text = "SCAN THIS AT ENTERANCE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 36)
        Me.Panel1.TabIndex = 10
        '
        'minus
        '
        Me.minus.BackgroundImage = CType(resources.GetObject("minus.BackgroundImage"), System.Drawing.Image)
        Me.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minus.FlatAppearance.BorderSize = 0
        Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus.Location = New System.Drawing.Point(719, 0)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(37, 40)
        Me.minus.TabIndex = 12
        Me.minus.UseVisualStyleBackColor = True
        '
        'cross
        '
        Me.cross.BackgroundImage = CType(resources.GetObject("cross.BackgroundImage"), System.Drawing.Image)
        Me.cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cross.FlatAppearance.BorderSize = 0
        Me.cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cross.Location = New System.Drawing.Point(762, 0)
        Me.cross.Name = "cross"
        Me.cross.Size = New System.Drawing.Size(37, 40)
        Me.cross.TabIndex = 11
        Me.cross.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel2.Controls.Add(Me.HomeBtn)
        Me.Panel2.Location = New System.Drawing.Point(0, 436)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 90)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Seat Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ticket price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Beverages"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total"
        '
        'BevLabel
        '
        Me.BevLabel.AutoSize = True
        Me.BevLabel.Location = New System.Drawing.Point(578, 257)
        Me.BevLabel.Name = "BevLabel"
        Me.BevLabel.Size = New System.Drawing.Size(48, 20)
        Me.BevLabel.TabIndex = 16
        Me.BevLabel.Text = "Label"
        '
        'TotLabel
        '
        Me.TotLabel.AutoSize = True
        Me.TotLabel.Location = New System.Drawing.Point(578, 319)
        Me.TotLabel.Name = "TotLabel"
        Me.TotLabel.Size = New System.Drawing.Size(48, 20)
        Me.TotLabel.TabIndex = 17
        Me.TotLabel.Text = "Label"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 29)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Mode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(578, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Label6"
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold)
        Me.HomeBtn.ForeColor = System.Drawing.Color.Black
        Me.HomeBtn.Location = New System.Drawing.Point(593, 19)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(187, 50)
        Me.HomeBtn.TabIndex = 2
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'TicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 527)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotLabel)
        Me.Controls.Add(Me.BevLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.SeatLabel)
        Me.Controls.Add(Me.ScanLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TicketForm"
        Me.Text = "TicketForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalLabel As Label
    Friend WithEvents SeatLabel As Label
    Friend WithEvents ScanLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BevLabel As Label
    Friend WithEvents TotLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents HomeBtn As Button
End Class
