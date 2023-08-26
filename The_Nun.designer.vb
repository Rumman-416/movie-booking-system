<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class The_Nun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(The_Nun))
        Me.nun_format_pnl = New System.Windows.Forms.Panel()
        Me.format_nxt_btn = New System.Windows.Forms.Button()
        Me.btn_3d = New System.Windows.Forms.RadioButton()
        Me.btn_2d = New System.Windows.Forms.RadioButton()
        Me.select_format_lbl = New System.Windows.Forms.Label()
        Me.nun_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.vid_pnl = New System.Windows.Forms.Panel()
        Me.ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.username_lbl = New System.Windows.Forms.Label()
        Me.user_review_output = New System.Windows.Forms.Label()
        Me.add_review_lbl = New System.Windows.Forms.Label()
        Me.user_review_txt = New System.Windows.Forms.TextBox()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.user2_review_lbl = New System.Windows.Forms.Label()
        Me.user2_name_lbl = New System.Windows.Forms.Label()
        Me.user1_review_lbl = New System.Windows.Forms.Label()
        Me.user1_lbl = New System.Windows.Forms.Label()
        Me.reviews_lbl = New System.Windows.Forms.Label()
        Me.top_review_lbl = New System.Windows.Forms.Label()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.cname4 = New System.Windows.Forms.Label()
        Me.cname3 = New System.Windows.Forms.Label()
        Me.cname2 = New System.Windows.Forms.Label()
        Me.cname1 = New System.Windows.Forms.Label()
        Me.cast_img3 = New System.Windows.Forms.PictureBox()
        Me.cast_img2 = New System.Windows.Forms.PictureBox()
        Me.cast_img4 = New System.Windows.Forms.PictureBox()
        Me.cast_img1 = New System.Windows.Forms.PictureBox()
        Me.cast_lbl = New System.Windows.Forms.Label()
        Me.nun_desc = New System.Windows.Forms.Label()
        Me.dur_time_lbl = New System.Windows.Forms.Label()
        Me.rating_val_lbl = New System.Windows.Forms.Label()
        Me.star_pt_box = New System.Windows.Forms.PictureBox()
        Me.dur_lbl = New System.Windows.Forms.Label()
        Me.Rating_lbl = New System.Windows.Forms.Label()
        Me.trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.moviename_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.nun_format_pnl.SuspendLayout()
        Me.nun_panel.SuspendLayout()
        Me.vid_pnl.SuspendLayout()
        CType(Me.vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nun_format_pnl
        '
        Me.nun_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.nun_format_pnl.Controls.Add(Me.format_nxt_btn)
        Me.nun_format_pnl.Controls.Add(Me.btn_3d)
        Me.nun_format_pnl.Controls.Add(Me.btn_2d)
        Me.nun_format_pnl.Controls.Add(Me.select_format_lbl)
        Me.nun_format_pnl.Location = New System.Drawing.Point(0, 878)
        Me.nun_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nun_format_pnl.Name = "nun_format_pnl"
        Me.nun_format_pnl.Size = New System.Drawing.Size(1037, 151)
        Me.nun_format_pnl.TabIndex = 5
        Me.nun_format_pnl.Visible = False
        '
        'format_nxt_btn
        '
        Me.format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.format_nxt_btn.Name = "format_nxt_btn"
        Me.format_nxt_btn.Size = New System.Drawing.Size(1037, 60)
        Me.format_nxt_btn.TabIndex = 19
        Me.format_nxt_btn.Text = "Continue"
        Me.format_nxt_btn.UseVisualStyleBackColor = False
        '
        'btn_3d
        '
        Me.btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_3d.Name = "btn_3d"
        Me.btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.btn_3d.TabIndex = 7
        Me.btn_3d.TabStop = True
        Me.btn_3d.Text = "3D"
        Me.btn_3d.UseVisualStyleBackColor = True
        '
        'btn_2d
        '
        Me.btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2d.Location = New System.Drawing.Point(256, 19)
        Me.btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_2d.Name = "btn_2d"
        Me.btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.btn_2d.TabIndex = 6
        Me.btn_2d.TabStop = True
        Me.btn_2d.Text = "2D"
        Me.btn_2d.UseVisualStyleBackColor = True
        '
        'select_format_lbl
        '
        Me.select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.select_format_lbl.Name = "select_format_lbl"
        Me.select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.select_format_lbl.TabIndex = 5
        Me.select_format_lbl.Text = "Select Movie Format :"
        Me.select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nun_panel
        '
        Me.nun_panel.BackColor = System.Drawing.Color.Snow
        Me.nun_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nun_panel.Controls.Add(Me.BackButton)
        Me.nun_panel.Controls.Add(Me.vid_pnl)
        Me.nun_panel.Controls.Add(Me.username_lbl)
        Me.nun_panel.Controls.Add(Me.user_review_output)
        Me.nun_panel.Controls.Add(Me.add_review_lbl)
        Me.nun_panel.Controls.Add(Me.user_review_txt)
        Me.nun_panel.Controls.Add(Me.Add_btn)
        Me.nun_panel.Controls.Add(Me.user2_review_lbl)
        Me.nun_panel.Controls.Add(Me.user2_name_lbl)
        Me.nun_panel.Controls.Add(Me.user1_review_lbl)
        Me.nun_panel.Controls.Add(Me.user1_lbl)
        Me.nun_panel.Controls.Add(Me.reviews_lbl)
        Me.nun_panel.Controls.Add(Me.top_review_lbl)
        Me.nun_panel.Controls.Add(Me.next_btn)
        Me.nun_panel.Controls.Add(Me.cname4)
        Me.nun_panel.Controls.Add(Me.cname3)
        Me.nun_panel.Controls.Add(Me.cname2)
        Me.nun_panel.Controls.Add(Me.cname1)
        Me.nun_panel.Controls.Add(Me.cast_img3)
        Me.nun_panel.Controls.Add(Me.cast_img2)
        Me.nun_panel.Controls.Add(Me.cast_img4)
        Me.nun_panel.Controls.Add(Me.cast_img1)
        Me.nun_panel.Controls.Add(Me.cast_lbl)
        Me.nun_panel.Controls.Add(Me.nun_desc)
        Me.nun_panel.Controls.Add(Me.dur_time_lbl)
        Me.nun_panel.Controls.Add(Me.rating_val_lbl)
        Me.nun_panel.Controls.Add(Me.star_pt_box)
        Me.nun_panel.Controls.Add(Me.dur_lbl)
        Me.nun_panel.Controls.Add(Me.Rating_lbl)
        Me.nun_panel.Controls.Add(Me.trailer_bg_lbl)
        Me.nun_panel.Controls.Add(Me.moviename_lbl)
        Me.nun_panel.Location = New System.Drawing.Point(0, 41)
        Me.nun_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nun_panel.Name = "nun_panel"
        Me.nun_panel.Size = New System.Drawing.Size(1042, 829)
        Me.nun_panel.TabIndex = 4
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(3, 0)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(104, 53)
        Me.BackButton.TabIndex = 31
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'vid_pnl
        '
        Me.vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vid_pnl.Controls.Add(Me.ply_btn)
        Me.vid_pnl.Controls.Add(Me.play_btn)
        Me.vid_pnl.Controls.Add(Me.vid_sc)
        Me.vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.vid_pnl.Name = "vid_pnl"
        Me.vid_pnl.Size = New System.Drawing.Size(1040, 245)
        Me.vid_pnl.TabIndex = 30
        '
        'ply_btn
        '
        Me.ply_btn.BackgroundImage = CType(resources.GetObject("ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ply_btn.Location = New System.Drawing.Point(478, 75)
        Me.ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ply_btn.Name = "ply_btn"
        Me.ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.ply_btn.TabIndex = 2
        Me.ply_btn.UseVisualStyleBackColor = True
        '
        'play_btn
        '
        Me.play_btn.Image = CType(resources.GetObject("play_btn.Image"), System.Drawing.Image)
        Me.play_btn.Location = New System.Drawing.Point(110, -136)
        Me.play_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.play_btn.Name = "play_btn"
        Me.play_btn.Size = New System.Drawing.Size(1080, 12)
        Me.play_btn.TabIndex = 1
        Me.play_btn.UseVisualStyleBackColor = True
        '
        'vid_sc
        '
        Me.vid_sc.Enabled = True
        Me.vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.vid_sc.Name = "vid_sc"
        Me.vid_sc.OcxState = CType(resources.GetObject("vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vid_sc.Size = New System.Drawing.Size(596, 311)
        Me.vid_sc.TabIndex = 0
        '
        'username_lbl
        '
        Me.username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_lbl.Location = New System.Drawing.Point(676, 617)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.username_lbl.TabIndex = 29
        Me.username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_review_output
        '
        Me.user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_review_output.Location = New System.Drawing.Point(775, 621)
        Me.user_review_output.Name = "user_review_output"
        Me.user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.user_review_output.TabIndex = 28
        '
        'add_review_lbl
        '
        Me.add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.add_review_lbl.Location = New System.Drawing.Point(689, 670)
        Me.add_review_lbl.Name = "add_review_lbl"
        Me.add_review_lbl.Size = New System.Drawing.Size(129, 35)
        Me.add_review_lbl.TabIndex = 27
        Me.add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'user_review_txt
        '
        Me.user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.user_review_txt.Location = New System.Drawing.Point(686, 703)
        Me.user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.user_review_txt.Name = "user_review_txt"
        Me.user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.user_review_txt.TabIndex = 25
        '
        'Add_btn
        '
        Me.Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.Add_btn.Location = New System.Drawing.Point(960, 703)
        Me.Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(52, 35)
        Me.Add_btn.TabIndex = 26
        Me.Add_btn.Text = "ADD"
        Me.Add_btn.UseVisualStyleBackColor = False
        '
        'user2_review_lbl
        '
        Me.user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user2_review_lbl.Location = New System.Drawing.Point(775, 438)
        Me.user2_review_lbl.Name = "user2_review_lbl"
        Me.user2_review_lbl.Size = New System.Drawing.Size(245, 77)
        Me.user2_review_lbl.TabIndex = 24
        Me.user2_review_lbl.Text = "The only horror movie franchise that manage to scare shit out of me  : )"
        '
        'user2_name_lbl
        '
        Me.user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user2_name_lbl.Location = New System.Drawing.Point(676, 438)
        Me.user2_name_lbl.Name = "user2_name_lbl"
        Me.user2_name_lbl.Size = New System.Drawing.Size(98, 35)
        Me.user2_name_lbl.TabIndex = 23
        Me.user2_name_lbl.Text = "User715 :"
        Me.user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user1_review_lbl
        '
        Me.user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user1_review_lbl.Location = New System.Drawing.Point(771, 522)
        Me.user1_review_lbl.Name = "user1_review_lbl"
        Me.user1_review_lbl.Size = New System.Drawing.Size(245, 95)
        Me.user1_review_lbl.TabIndex = 22
        Me.user1_review_lbl.Text = "Doesn't matter if you like this movie or not, but the Haunter and Scary atmospher" &
    "e The Nun creates was uncomparable...!!!"
        '
        'user1_lbl
        '
        Me.user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user1_lbl.Location = New System.Drawing.Point(678, 522)
        Me.user1_lbl.Name = "user1_lbl"
        Me.user1_lbl.Size = New System.Drawing.Size(98, 35)
        Me.user1_lbl.TabIndex = 21
        Me.user1_lbl.Text = "User420 :"
        Me.user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reviews_lbl
        '
        Me.reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.reviews_lbl.Location = New System.Drawing.Point(671, 420)
        Me.reviews_lbl.Name = "reviews_lbl"
        Me.reviews_lbl.Size = New System.Drawing.Size(361, 334)
        Me.reviews_lbl.TabIndex = 20
        '
        'top_review_lbl
        '
        Me.top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.top_review_lbl.Location = New System.Drawing.Point(665, 364)
        Me.top_review_lbl.Name = "top_review_lbl"
        Me.top_review_lbl.Size = New System.Drawing.Size(364, 56)
        Me.top_review_lbl.TabIndex = 19
        Me.top_review_lbl.Text = "Top reviews"
        Me.top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'next_btn
        '
        Me.next_btn.BackColor = System.Drawing.Color.Brown
        Me.next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.next_btn.FlatAppearance.BorderSize = 0
        Me.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.next_btn.Location = New System.Drawing.Point(0, 769)
        Me.next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(1042, 60)
        Me.next_btn.TabIndex = 18
        Me.next_btn.Text = "Proceed To Next"
        Me.next_btn.UseVisualStyleBackColor = False
        '
        'cname4
        '
        Me.cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname4.Location = New System.Drawing.Point(506, 686)
        Me.cname4.Name = "cname4"
        Me.cname4.Size = New System.Drawing.Size(170, 51)
        Me.cname4.TabIndex = 17
        Me.cname4.Text = "Vera Farmiga" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Lorraine Warren)"
        Me.cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cname3
        '
        Me.cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname3.Location = New System.Drawing.Point(357, 686)
        Me.cname3.Name = "cname3"
        Me.cname3.Size = New System.Drawing.Size(130, 51)
        Me.cname3.TabIndex = 16
        Me.cname3.Text = "Demian Buchir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Father Burke)"
        Me.cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cname2
        '
        Me.cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname2.Location = New System.Drawing.Point(191, 686)
        Me.cname2.Name = "cname2"
        Me.cname2.Size = New System.Drawing.Size(127, 51)
        Me.cname2.TabIndex = 15
        Me.cname2.Text = "Bonie Aarons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Demon Nun)"
        Me.cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cname1
        '
        Me.cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname1.Location = New System.Drawing.Point(32, 686)
        Me.cname1.Name = "cname1"
        Me.cname1.Size = New System.Drawing.Size(136, 51)
        Me.cname1.TabIndex = 14
        Me.cname1.Text = "Taissa Farmiga" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Sister Irene)"
        Me.cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cast_img3
        '
        Me.cast_img3.Image = CType(resources.GetObject("cast_img3.Image"), System.Drawing.Image)
        Me.cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cast_img3.Name = "cast_img3"
        Me.cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cast_img3.TabIndex = 13
        Me.cast_img3.TabStop = False
        '
        'cast_img2
        '
        Me.cast_img2.Image = CType(resources.GetObject("cast_img2.Image"), System.Drawing.Image)
        Me.cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cast_img2.Name = "cast_img2"
        Me.cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cast_img2.TabIndex = 12
        Me.cast_img2.TabStop = False
        '
        'cast_img4
        '
        Me.cast_img4.Image = CType(resources.GetObject("cast_img4.Image"), System.Drawing.Image)
        Me.cast_img4.Location = New System.Drawing.Point(522, 560)
        Me.cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cast_img4.Name = "cast_img4"
        Me.cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cast_img4.TabIndex = 11
        Me.cast_img4.TabStop = False
        '
        'cast_img1
        '
        Me.cast_img1.Image = CType(resources.GetObject("cast_img1.Image"), System.Drawing.Image)
        Me.cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cast_img1.Name = "cast_img1"
        Me.cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cast_img1.TabIndex = 10
        Me.cast_img1.TabStop = False
        '
        'cast_lbl
        '
        Me.cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.cast_lbl.Name = "cast_lbl"
        Me.cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.cast_lbl.TabIndex = 9
        Me.cast_lbl.Text = "Cast"
        Me.cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nun_desc
        '
        Me.nun_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nun_desc.Location = New System.Drawing.Point(10, 420)
        Me.nun_desc.Name = "nun_desc"
        Me.nun_desc.Size = New System.Drawing.Size(648, 114)
        Me.nun_desc.TabIndex = 8
        Me.nun_desc.Text = resources.GetString("nun_desc.Text")
        '
        'dur_time_lbl
        '
        Me.dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.dur_time_lbl.Name = "dur_time_lbl"
        Me.dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.dur_time_lbl.TabIndex = 7
        Me.dur_time_lbl.Text = "1h 20m"
        '
        'rating_val_lbl
        '
        Me.rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.rating_val_lbl.Name = "rating_val_lbl"
        Me.rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.rating_val_lbl.TabIndex = 6
        Me.rating_val_lbl.Text = "9.5/10"
        '
        'star_pt_box
        '
        Me.star_pt_box.Image = CType(resources.GetObject("star_pt_box.Image"), System.Drawing.Image)
        Me.star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.star_pt_box.Name = "star_pt_box"
        Me.star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star_pt_box.TabIndex = 5
        Me.star_pt_box.TabStop = False
        '
        'dur_lbl
        '
        Me.dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.dur_lbl.Name = "dur_lbl"
        Me.dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.dur_lbl.TabIndex = 4
        Me.dur_lbl.Text = "Duration  :"
        Me.dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rating_lbl
        '
        Me.Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.Rating_lbl.Name = "Rating_lbl"
        Me.Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.Rating_lbl.TabIndex = 3
        Me.Rating_lbl.Text = "Ratings     :"
        Me.Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trailer_bg_lbl
        '
        Me.trailer_bg_lbl.BackColor = System.Drawing.Color.DimGray
        Me.trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.trailer_bg_lbl.Name = "trailer_bg_lbl"
        Me.trailer_bg_lbl.Size = New System.Drawing.Size(1133, 245)
        Me.trailer_bg_lbl.TabIndex = 1
        Me.trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'moviename_lbl
        '
        Me.moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.moviename_lbl.Location = New System.Drawing.Point(0, 0)
        Me.moviename_lbl.Name = "moviename_lbl"
        Me.moviename_lbl.Size = New System.Drawing.Size(1040, 53)
        Me.moviename_lbl.TabIndex = 0
        Me.moviename_lbl.Text = "THE NUN"
        Me.moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 6
        '
        'minus
        '
        Me.minus.BackgroundImage = CType(resources.GetObject("minus.BackgroundImage"), System.Drawing.Image)
        Me.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.minus.FlatAppearance.BorderSize = 0
        Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus.Location = New System.Drawing.Point(913, 0)
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
        Me.cross.Location = New System.Drawing.Point(956, 0)
        Me.cross.Name = "cross"
        Me.cross.Size = New System.Drawing.Size(37, 40)
        Me.cross.TabIndex = 9
        Me.cross.UseVisualStyleBackColor = True
        '
        'The_Nun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1032)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nun_format_pnl)
        Me.Controls.Add(Me.nun_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "The_Nun"
        Me.Text = "The Nun"
        Me.nun_format_pnl.ResumeLayout(False)
        Me.nun_panel.ResumeLayout(False)
        Me.nun_panel.PerformLayout()
        Me.vid_pnl.ResumeLayout(False)
        CType(Me.vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nun_format_pnl As Panel
    Friend WithEvents format_nxt_btn As Button
    Friend WithEvents btn_3d As RadioButton
    Friend WithEvents btn_2d As RadioButton
    Friend WithEvents select_format_lbl As Label
    Friend WithEvents nun_panel As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents vid_pnl As Panel
    Friend WithEvents ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents username_lbl As Label
    Friend WithEvents user_review_output As Label
    Friend WithEvents add_review_lbl As Label
    Friend WithEvents user_review_txt As TextBox
    Friend WithEvents Add_btn As Button
    Friend WithEvents user2_review_lbl As Label
    Friend WithEvents user2_name_lbl As Label
    Friend WithEvents user1_review_lbl As Label
    Friend WithEvents user1_lbl As Label
    Friend WithEvents reviews_lbl As Label
    Friend WithEvents top_review_lbl As Label
    Friend WithEvents next_btn As Button
    Friend WithEvents cname4 As Label
    Friend WithEvents cname3 As Label
    Friend WithEvents cname2 As Label
    Friend WithEvents cname1 As Label
    Friend WithEvents cast_img3 As PictureBox
    Friend WithEvents cast_img2 As PictureBox
    Friend WithEvents cast_img4 As PictureBox
    Friend WithEvents cast_img1 As PictureBox
    Friend WithEvents cast_lbl As Label
    Friend WithEvents nun_desc As Label
    Friend WithEvents dur_time_lbl As Label
    Friend WithEvents rating_val_lbl As Label
    Friend WithEvents star_pt_box As PictureBox
    Friend WithEvents dur_lbl As Label
    Friend WithEvents Rating_lbl As Label
    Friend WithEvents trailer_bg_lbl As Label
    Friend WithEvents moviename_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
End Class
