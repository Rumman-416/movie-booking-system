<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUs))
        Me.abt_pnl = New System.Windows.Forms.Panel()
        Me.abt_us_detail_lbl = New System.Windows.Forms.Label()
        Me.abt_us_lbl = New System.Windows.Forms.Label()
        Me.abt_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'abt_pnl
        '
        Me.abt_pnl.Controls.Add(Me.abt_us_detail_lbl)
        Me.abt_pnl.Controls.Add(Me.abt_us_lbl)
        Me.abt_pnl.Location = New System.Drawing.Point(-1, 1)
        Me.abt_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.abt_pnl.Name = "abt_pnl"
        Me.abt_pnl.Size = New System.Drawing.Size(1047, 643)
        Me.abt_pnl.TabIndex = 0
        '
        'abt_us_detail_lbl
        '
        Me.abt_us_detail_lbl.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abt_us_detail_lbl.Location = New System.Drawing.Point(7, 61)
        Me.abt_us_detail_lbl.Name = "abt_us_detail_lbl"
        Me.abt_us_detail_lbl.Size = New System.Drawing.Size(1037, 582)
        Me.abt_us_detail_lbl.TabIndex = 2
        Me.abt_us_detail_lbl.Text = resources.GetString("abt_us_detail_lbl.Text")
        '
        'abt_us_lbl
        '
        Me.abt_us_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.abt_us_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.abt_us_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abt_us_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.abt_us_lbl.Location = New System.Drawing.Point(0, 0)
        Me.abt_us_lbl.Name = "abt_us_lbl"
        Me.abt_us_lbl.Size = New System.Drawing.Size(1047, 52)
        Me.abt_us_lbl.TabIndex = 1
        Me.abt_us_lbl.Text = "ABOUT US"
        Me.abt_us_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 647)
        Me.Controls.Add(Me.abt_pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AboutUs"
        Me.Text = "AboutUs"
        Me.abt_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents abt_pnl As Panel
    Friend WithEvents abt_us_detail_lbl As Label
    Friend WithEvents abt_us_lbl As Label
End Class
