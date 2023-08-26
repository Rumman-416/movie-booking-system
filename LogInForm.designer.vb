<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textusername = New System.Windows.Forms.TextBox()
        Me.textpassword = New System.Windows.Forms.TextBox()
        Me.Buttonlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logopanel = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(28, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(28, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Textusername
        '
        Me.Textusername.Location = New System.Drawing.Point(177, 255)
        Me.Textusername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Textusername.Name = "Textusername"
        Me.Textusername.Size = New System.Drawing.Size(187, 26)
        Me.Textusername.TabIndex = 2
        '
        'textpassword
        '
        Me.textpassword.Location = New System.Drawing.Point(177, 308)
        Me.textpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textpassword.Name = "textpassword"
        Me.textpassword.Size = New System.Drawing.Size(187, 26)
        Me.textpassword.TabIndex = 3
        '
        'Buttonlogin
        '
        Me.Buttonlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Buttonlogin.FlatAppearance.BorderSize = 0
        Me.Buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonlogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Buttonlogin.ForeColor = System.Drawing.Color.White
        Me.Buttonlogin.Location = New System.Drawing.Point(23, 537)
        Me.Buttonlogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Buttonlogin.Name = "Buttonlogin"
        Me.Buttonlogin.Size = New System.Drawing.Size(341, 42)
        Me.Buttonlogin.TabIndex = 4
        Me.Buttonlogin.Text = "Login"
        Me.Buttonlogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(74, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 44)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Login Form"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Buttonlogin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Textusername)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.textpassword)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 632)
        Me.Panel1.TabIndex = 7
        '
        'Logopanel
        '
        Me.Logopanel.AutoSize = True
        Me.Logopanel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logopanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Logopanel.Location = New System.Drawing.Point(513, 383)
        Me.Logopanel.Name = "Logopanel"
        Me.Logopanel.Size = New System.Drawing.Size(185, 37)
        Me.Logopanel.TabIndex = 12
        Me.Logopanel.Text = "Movie Dekh"
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(501, 87)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(215, 245)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 11
        Me.Logo.TabStop = False
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 628)
        Me.Controls.Add(Me.Logopanel)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Location = New System.Drawing.Point(350, 175)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LogInForm"
        Me.Text = "RenameForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Textusername As TextBox
    Friend WithEvents textpassword As TextBox
    Friend WithEvents Buttonlogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Logopanel As Label
    Friend WithEvents Logo As PictureBox
End Class
