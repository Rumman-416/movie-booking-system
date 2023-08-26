<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(saw))
        Me.saw_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.sw_vid_pnl = New System.Windows.Forms.Panel()
        Me.sw_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.sw_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.sw_username_lbl = New System.Windows.Forms.Label()
        Me.sw_user_review_output = New System.Windows.Forms.Label()
        Me.sw_add_review_lbl = New System.Windows.Forms.Label()
        Me.sw_user_review_txt = New System.Windows.Forms.TextBox()
        Me.sw_Add_btn = New System.Windows.Forms.Button()
        Me.sw_user2_review_lbl = New System.Windows.Forms.Label()
        Me.sw_user2_name_lbl = New System.Windows.Forms.Label()
        Me.sw_user1_review_lbl = New System.Windows.Forms.Label()
        Me.sw_user1_lbl = New System.Windows.Forms.Label()
        Me.reviews_lbl = New System.Windows.Forms.Label()
        Me.sw_top_review_lbl = New System.Windows.Forms.Label()
        Me.sw_next_btn = New System.Windows.Forms.Button()
        Me.sw_cname4 = New System.Windows.Forms.Label()
        Me.sw_cname3 = New System.Windows.Forms.Label()
        Me.sw_cname2 = New System.Windows.Forms.Label()
        Me.sw_cname1 = New System.Windows.Forms.Label()
        Me.sw_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.sw_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.sw_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.sw_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.sw_cast_lbl = New System.Windows.Forms.Label()
        Me.sw_desc = New System.Windows.Forms.Label()
        Me.sw_dur_time_lbl = New System.Windows.Forms.Label()
        Me.sw_rating_val_lbl = New System.Windows.Forms.Label()
        Me.sw_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.sw_dur_lbl = New System.Windows.Forms.Label()
        Me.sw_Rating_lbl = New System.Windows.Forms.Label()
        Me.sw_trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.sw_moviename_lbl = New System.Windows.Forms.Label()
        Me.sw_format_pnl = New System.Windows.Forms.Panel()
        Me.sw_format_nxt_btn = New System.Windows.Forms.Button()
        Me.sw_btn_3d = New System.Windows.Forms.RadioButton()
        Me.sw_btn_2d = New System.Windows.Forms.RadioButton()
        Me.sw_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.saw_panel.SuspendLayout()
        Me.sw_vid_pnl.SuspendLayout()
        CType(Me.sw_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sw_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'saw_panel
        '
        Me.saw_panel.BackColor = System.Drawing.Color.Snow
        Me.saw_panel.Controls.Add(Me.BackButton)
        Me.saw_panel.Controls.Add(Me.sw_vid_pnl)
        Me.saw_panel.Controls.Add(Me.sw_username_lbl)
        Me.saw_panel.Controls.Add(Me.sw_user_review_output)
        Me.saw_panel.Controls.Add(Me.sw_add_review_lbl)
        Me.saw_panel.Controls.Add(Me.sw_user_review_txt)
        Me.saw_panel.Controls.Add(Me.sw_Add_btn)
        Me.saw_panel.Controls.Add(Me.sw_user2_review_lbl)
        Me.saw_panel.Controls.Add(Me.sw_user2_name_lbl)
        Me.saw_panel.Controls.Add(Me.sw_user1_review_lbl)
        Me.saw_panel.Controls.Add(Me.sw_user1_lbl)
        Me.saw_panel.Controls.Add(Me.reviews_lbl)
        Me.saw_panel.Controls.Add(Me.sw_top_review_lbl)
        Me.saw_panel.Controls.Add(Me.sw_next_btn)
        Me.saw_panel.Controls.Add(Me.sw_cname4)
        Me.saw_panel.Controls.Add(Me.sw_cname3)
        Me.saw_panel.Controls.Add(Me.sw_cname2)
        Me.saw_panel.Controls.Add(Me.sw_cname1)
        Me.saw_panel.Controls.Add(Me.sw_cast_img3)
        Me.saw_panel.Controls.Add(Me.sw_cast_img2)
        Me.saw_panel.Controls.Add(Me.sw_cast_img4)
        Me.saw_panel.Controls.Add(Me.sw_cast_img1)
        Me.saw_panel.Controls.Add(Me.sw_cast_lbl)
        Me.saw_panel.Controls.Add(Me.sw_desc)
        Me.saw_panel.Controls.Add(Me.sw_dur_time_lbl)
        Me.saw_panel.Controls.Add(Me.sw_rating_val_lbl)
        Me.saw_panel.Controls.Add(Me.sw_star_pt_box)
        Me.saw_panel.Controls.Add(Me.sw_dur_lbl)
        Me.saw_panel.Controls.Add(Me.sw_Rating_lbl)
        Me.saw_panel.Controls.Add(Me.sw_trailer_bg_lbl)
        Me.saw_panel.Controls.Add(Me.sw_moviename_lbl)
        Me.saw_panel.Location = New System.Drawing.Point(0, 39)
        Me.saw_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.saw_panel.Name = "saw_panel"
        Me.saw_panel.Size = New System.Drawing.Size(1043, 821)
        Me.saw_panel.TabIndex = 1
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(0, 11)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(104, 50)
        Me.BackButton.TabIndex = 35
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'sw_vid_pnl
        '
        Me.sw_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sw_vid_pnl.Controls.Add(Me.sw_ply_btn)
        Me.sw_vid_pnl.Controls.Add(Me.play_btn)
        Me.sw_vid_pnl.Controls.Add(Me.sw_vid_sc)
        Me.sw_vid_pnl.Location = New System.Drawing.Point(6, 74)
        Me.sw_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_vid_pnl.Name = "sw_vid_pnl"
        Me.sw_vid_pnl.Size = New System.Drawing.Size(1034, 245)
        Me.sw_vid_pnl.TabIndex = 31
        '
        'sw_ply_btn
        '
        Me.sw_ply_btn.BackgroundImage = CType(resources.GetObject("sw_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.sw_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sw_ply_btn.Location = New System.Drawing.Point(471, 90)
        Me.sw_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_ply_btn.Name = "sw_ply_btn"
        Me.sw_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.sw_ply_btn.TabIndex = 2
        Me.sw_ply_btn.UseVisualStyleBackColor = True
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
        'sw_vid_sc
        '
        Me.sw_vid_sc.Enabled = True
        Me.sw_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.sw_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_vid_sc.Name = "sw_vid_sc"
        Me.sw_vid_sc.OcxState = CType(resources.GetObject("sw_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sw_vid_sc.Size = New System.Drawing.Size(596, 307)
        Me.sw_vid_sc.TabIndex = 0
        '
        'sw_username_lbl
        '
        Me.sw_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_username_lbl.Location = New System.Drawing.Point(661, 603)
        Me.sw_username_lbl.Name = "sw_username_lbl"
        Me.sw_username_lbl.Size = New System.Drawing.Size(86, 29)
        Me.sw_username_lbl.TabIndex = 29
        Me.sw_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_user_review_output
        '
        Me.sw_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_user_review_output.Location = New System.Drawing.Point(754, 603)
        Me.sw_user_review_output.Name = "sw_user_review_output"
        Me.sw_user_review_output.Size = New System.Drawing.Size(223, 55)
        Me.sw_user_review_output.TabIndex = 28
        '
        'sw_add_review_lbl
        '
        Me.sw_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.sw_add_review_lbl.Location = New System.Drawing.Point(672, 663)
        Me.sw_add_review_lbl.Name = "sw_add_review_lbl"
        Me.sw_add_review_lbl.Size = New System.Drawing.Size(117, 29)
        Me.sw_add_review_lbl.TabIndex = 27
        Me.sw_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'sw_user_review_txt
        '
        Me.sw_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sw_user_review_txt.Location = New System.Drawing.Point(669, 696)
        Me.sw_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_user_review_txt.Name = "sw_user_review_txt"
        Me.sw_user_review_txt.Size = New System.Drawing.Size(254, 26)
        Me.sw_user_review_txt.TabIndex = 25
        '
        'sw_Add_btn
        '
        Me.sw_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.sw_Add_btn.Location = New System.Drawing.Point(943, 696)
        Me.sw_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_Add_btn.Name = "sw_Add_btn"
        Me.sw_Add_btn.Size = New System.Drawing.Size(40, 29)
        Me.sw_Add_btn.TabIndex = 26
        Me.sw_Add_btn.Text = "ADD"
        Me.sw_Add_btn.UseVisualStyleBackColor = False
        '
        'sw_user2_review_lbl
        '
        Me.sw_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_user2_review_lbl.Location = New System.Drawing.Point(758, 431)
        Me.sw_user2_review_lbl.Name = "sw_user2_review_lbl"
        Me.sw_user2_review_lbl.Size = New System.Drawing.Size(233, 71)
        Me.sw_user2_review_lbl.TabIndex = 24
        Me.sw_user2_review_lbl.Text = "To this day, the ending of Saw Still blows my brain !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seriously Iconic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'sw_user2_name_lbl
        '
        Me.sw_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_user2_name_lbl.Location = New System.Drawing.Point(659, 431)
        Me.sw_user2_name_lbl.Name = "sw_user2_name_lbl"
        Me.sw_user2_name_lbl.Size = New System.Drawing.Size(86, 29)
        Me.sw_user2_name_lbl.TabIndex = 23
        Me.sw_user2_name_lbl.Text = "User546 :"
        Me.sw_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_user1_review_lbl
        '
        Me.sw_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_user1_review_lbl.Location = New System.Drawing.Point(754, 517)
        Me.sw_user1_review_lbl.Name = "sw_user1_review_lbl"
        Me.sw_user1_review_lbl.Size = New System.Drawing.Size(233, 50)
        Me.sw_user1_review_lbl.TabIndex = 22
        Me.sw_user1_review_lbl.Text = "I want to forget this movie and watch it again........"
        '
        'sw_user1_lbl
        '
        Me.sw_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_user1_lbl.Location = New System.Drawing.Point(659, 517)
        Me.sw_user1_lbl.Name = "sw_user1_lbl"
        Me.sw_user1_lbl.Size = New System.Drawing.Size(86, 29)
        Me.sw_user1_lbl.TabIndex = 21
        Me.sw_user1_lbl.Text = "User420 :"
        Me.sw_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reviews_lbl
        '
        Me.reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.reviews_lbl.Location = New System.Drawing.Point(648, 407)
        Me.reviews_lbl.Name = "reviews_lbl"
        Me.reviews_lbl.Size = New System.Drawing.Size(349, 328)
        Me.reviews_lbl.TabIndex = 20
        '
        'sw_top_review_lbl
        '
        Me.sw_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.sw_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sw_top_review_lbl.Location = New System.Drawing.Point(648, 357)
        Me.sw_top_review_lbl.Name = "sw_top_review_lbl"
        Me.sw_top_review_lbl.Size = New System.Drawing.Size(352, 50)
        Me.sw_top_review_lbl.TabIndex = 19
        Me.sw_top_review_lbl.Text = "Top reviews"
        Me.sw_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_next_btn
        '
        Me.sw_next_btn.BackColor = System.Drawing.Color.Brown
        Me.sw_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sw_next_btn.FlatAppearance.BorderSize = 0
        Me.sw_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sw_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sw_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.sw_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_next_btn.Name = "sw_next_btn"
        Me.sw_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.sw_next_btn.TabIndex = 18
        Me.sw_next_btn.Text = "Proceed To Next"
        Me.sw_next_btn.UseVisualStyleBackColor = False
        '
        'sw_cname4
        '
        Me.sw_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_cname4.Location = New System.Drawing.Point(518, 686)
        Me.sw_cname4.Name = "sw_cname4"
        Me.sw_cname4.Size = New System.Drawing.Size(136, 51)
        Me.sw_cname4.TabIndex = 17
        Me.sw_cname4.Text = "Shawnee Smith" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Amanda)"
        Me.sw_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sw_cname3
        '
        Me.sw_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_cname3.Location = New System.Drawing.Point(357, 686)
        Me.sw_cname3.Name = "sw_cname3"
        Me.sw_cname3.Size = New System.Drawing.Size(130, 51)
        Me.sw_cname3.TabIndex = 16
        Me.sw_cname3.Text = "Leigh Whannel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Adam)"
        Me.sw_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sw_cname2
        '
        Me.sw_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_cname2.Location = New System.Drawing.Point(192, 686)
        Me.sw_cname2.Name = "sw_cname2"
        Me.sw_cname2.Size = New System.Drawing.Size(127, 51)
        Me.sw_cname2.TabIndex = 15
        Me.sw_cname2.Text = "Cary Elwins" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Lawrence)"
        Me.sw_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sw_cname1
        '
        Me.sw_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_cname1.Location = New System.Drawing.Point(48, 686)
        Me.sw_cname1.Name = "sw_cname1"
        Me.sw_cname1.Size = New System.Drawing.Size(94, 51)
        Me.sw_cname1.TabIndex = 14
        Me.sw_cname1.Text = "Tobin Bell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Jigsaw)"
        Me.sw_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sw_cast_img3
        '
        Me.sw_cast_img3.Image = CType(resources.GetObject("sw_cast_img3.Image"), System.Drawing.Image)
        Me.sw_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.sw_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_cast_img3.Name = "sw_cast_img3"
        Me.sw_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.sw_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sw_cast_img3.TabIndex = 13
        Me.sw_cast_img3.TabStop = False
        '
        'sw_cast_img2
        '
        Me.sw_cast_img2.Image = CType(resources.GetObject("sw_cast_img2.Image"), System.Drawing.Image)
        Me.sw_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.sw_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_cast_img2.Name = "sw_cast_img2"
        Me.sw_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.sw_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sw_cast_img2.TabIndex = 12
        Me.sw_cast_img2.TabStop = False
        '
        'sw_cast_img4
        '
        Me.sw_cast_img4.Image = CType(resources.GetObject("sw_cast_img4.Image"), System.Drawing.Image)
        Me.sw_cast_img4.Location = New System.Drawing.Point(522, 560)
        Me.sw_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_cast_img4.Name = "sw_cast_img4"
        Me.sw_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.sw_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sw_cast_img4.TabIndex = 11
        Me.sw_cast_img4.TabStop = False
        '
        'sw_cast_img1
        '
        Me.sw_cast_img1.Image = CType(resources.GetObject("sw_cast_img1.Image"), System.Drawing.Image)
        Me.sw_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.sw_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_cast_img1.Name = "sw_cast_img1"
        Me.sw_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.sw_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sw_cast_img1.TabIndex = 10
        Me.sw_cast_img1.TabStop = False
        '
        'sw_cast_lbl
        '
        Me.sw_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.sw_cast_lbl.Name = "sw_cast_lbl"
        Me.sw_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.sw_cast_lbl.TabIndex = 9
        Me.sw_cast_lbl.Text = "Cast"
        Me.sw_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_desc
        '
        Me.sw_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_desc.Location = New System.Drawing.Point(14, 420)
        Me.sw_desc.Name = "sw_desc"
        Me.sw_desc.Size = New System.Drawing.Size(632, 114)
        Me.sw_desc.TabIndex = 8
        Me.sw_desc.Text = "Horror, Mystery, Thriller ; 18+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Two strangers awaken in a room with no recollect" &
    "ion of how they got there, and soon discover they're pawns in a deadly game perp" &
    "etrated by a notorious serial killer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'sw_dur_time_lbl
        '
        Me.sw_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.sw_dur_time_lbl.Name = "sw_dur_time_lbl"
        Me.sw_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.sw_dur_time_lbl.TabIndex = 7
        Me.sw_dur_time_lbl.Text = "1h 43m"
        '
        'sw_rating_val_lbl
        '
        Me.sw_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.sw_rating_val_lbl.Name = "sw_rating_val_lbl"
        Me.sw_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.sw_rating_val_lbl.TabIndex = 6
        Me.sw_rating_val_lbl.Text = "7.6/10"
        '
        'sw_star_pt_box
        '
        Me.sw_star_pt_box.Image = CType(resources.GetObject("sw_star_pt_box.Image"), System.Drawing.Image)
        Me.sw_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.sw_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_star_pt_box.Name = "sw_star_pt_box"
        Me.sw_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.sw_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sw_star_pt_box.TabIndex = 5
        Me.sw_star_pt_box.TabStop = False
        '
        'sw_dur_lbl
        '
        Me.sw_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.sw_dur_lbl.Name = "sw_dur_lbl"
        Me.sw_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.sw_dur_lbl.TabIndex = 4
        Me.sw_dur_lbl.Text = "Duration  :"
        Me.sw_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_Rating_lbl
        '
        Me.sw_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.sw_Rating_lbl.Name = "sw_Rating_lbl"
        Me.sw_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.sw_Rating_lbl.TabIndex = 3
        Me.sw_Rating_lbl.Text = "Ratings     :"
        Me.sw_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_trailer_bg_lbl
        '
        Me.sw_trailer_bg_lbl.BackColor = System.Drawing.Color.Black
        Me.sw_trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.sw_trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.sw_trailer_bg_lbl.Name = "sw_trailer_bg_lbl"
        Me.sw_trailer_bg_lbl.Size = New System.Drawing.Size(1040, 245)
        Me.sw_trailer_bg_lbl.TabIndex = 1
        Me.sw_trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sw_moviename_lbl
        '
        Me.sw_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.sw_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.sw_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.sw_moviename_lbl.Name = "sw_moviename_lbl"
        Me.sw_moviename_lbl.Size = New System.Drawing.Size(1040, 50)
        Me.sw_moviename_lbl.TabIndex = 0
        Me.sw_moviename_lbl.Text = "SAW - I"
        Me.sw_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sw_format_pnl
        '
        Me.sw_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.sw_format_pnl.Controls.Add(Me.sw_format_nxt_btn)
        Me.sw_format_pnl.Controls.Add(Me.sw_btn_3d)
        Me.sw_format_pnl.Controls.Add(Me.sw_btn_2d)
        Me.sw_format_pnl.Controls.Add(Me.sw_select_format_lbl)
        Me.sw_format_pnl.Location = New System.Drawing.Point(3, 864)
        Me.sw_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_format_pnl.Name = "sw_format_pnl"
        Me.sw_format_pnl.Size = New System.Drawing.Size(1040, 151)
        Me.sw_format_pnl.TabIndex = 2
        Me.sw_format_pnl.Visible = False
        '
        'sw_format_nxt_btn
        '
        Me.sw_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.sw_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sw_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.sw_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sw_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sw_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.sw_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_format_nxt_btn.Name = "sw_format_nxt_btn"
        Me.sw_format_nxt_btn.Size = New System.Drawing.Size(1040, 60)
        Me.sw_format_nxt_btn.TabIndex = 19
        Me.sw_format_nxt_btn.Text = "Continue"
        Me.sw_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'sw_btn_3d
        '
        Me.sw_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.sw_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_btn_3d.Name = "sw_btn_3d"
        Me.sw_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.sw_btn_3d.TabIndex = 7
        Me.sw_btn_3d.TabStop = True
        Me.sw_btn_3d.Text = "3D"
        Me.sw_btn_3d.UseVisualStyleBackColor = True
        '
        'sw_btn_2d
        '
        Me.sw_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_btn_2d.Location = New System.Drawing.Point(252, 19)
        Me.sw_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sw_btn_2d.Name = "sw_btn_2d"
        Me.sw_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.sw_btn_2d.TabIndex = 6
        Me.sw_btn_2d.TabStop = True
        Me.sw_btn_2d.Text = "2D"
        Me.sw_btn_2d.UseVisualStyleBackColor = True
        '
        'sw_select_format_lbl
        '
        Me.sw_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sw_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.sw_select_format_lbl.Name = "sw_select_format_lbl"
        Me.sw_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.sw_select_format_lbl.TabIndex = 5
        Me.sw_select_format_lbl.Text = "Select Movie Format :"
        Me.sw_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 3
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
        'saw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sw_format_pnl)
        Me.Controls.Add(Me.saw_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "saw"
        Me.Text = "Saw"
        Me.saw_panel.ResumeLayout(False)
        Me.saw_panel.PerformLayout()
        Me.sw_vid_pnl.ResumeLayout(False)
        CType(Me.sw_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sw_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents saw_panel As Panel
    Friend WithEvents sw_username_lbl As Label
    Friend WithEvents sw_user_review_output As Label
    Friend WithEvents sw_add_review_lbl As Label
    Friend WithEvents sw_user_review_txt As TextBox
    Friend WithEvents sw_Add_btn As Button
    Friend WithEvents sw_user2_review_lbl As Label
    Friend WithEvents sw_user2_name_lbl As Label
    Friend WithEvents sw_user1_review_lbl As Label
    Friend WithEvents sw_user1_lbl As Label
    Friend WithEvents reviews_lbl As Label
    Friend WithEvents sw_top_review_lbl As Label
    Friend WithEvents sw_next_btn As Button
    Friend WithEvents sw_cname4 As Label
    Friend WithEvents sw_cname3 As Label
    Friend WithEvents sw_cname2 As Label
    Friend WithEvents sw_cname1 As Label
    Friend WithEvents sw_cast_img3 As PictureBox
    Friend WithEvents sw_cast_img2 As PictureBox
    Friend WithEvents sw_cast_img4 As PictureBox
    Friend WithEvents sw_cast_img1 As PictureBox
    Friend WithEvents sw_cast_lbl As Label
    Friend WithEvents sw_desc As Label
    Friend WithEvents sw_dur_time_lbl As Label
    Friend WithEvents sw_rating_val_lbl As Label
    Friend WithEvents sw_star_pt_box As PictureBox
    Friend WithEvents sw_dur_lbl As Label
    Friend WithEvents sw_Rating_lbl As Label
    Friend WithEvents sw_trailer_bg_lbl As Label
    Friend WithEvents sw_moviename_lbl As Label
    Friend WithEvents sw_format_pnl As Panel
    Friend WithEvents sw_format_nxt_btn As Button
    Friend WithEvents sw_btn_3d As RadioButton
    Friend WithEvents sw_btn_2d As RadioButton
    Friend WithEvents sw_select_format_lbl As Label
    Friend WithEvents sw_vid_pnl As Panel
    Friend WithEvents sw_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents sw_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
