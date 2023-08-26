<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class poster_boys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(poster_boys))
        Me.poster_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.pb_vid_pnl = New System.Windows.Forms.Panel()
        Me.pb_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.pb_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pb_username_lbl = New System.Windows.Forms.Label()
        Me.pb_user_review_output = New System.Windows.Forms.Label()
        Me.pb_add_review_lbl = New System.Windows.Forms.Label()
        Me.pb_user_review_txt = New System.Windows.Forms.TextBox()
        Me.pb_Add_btn = New System.Windows.Forms.Button()
        Me.pb_user2_review_lbl = New System.Windows.Forms.Label()
        Me.pb_user2_name_lbl = New System.Windows.Forms.Label()
        Me.pb_user1_review_lbl = New System.Windows.Forms.Label()
        Me.pb_user1_lbl = New System.Windows.Forms.Label()
        Me.pb_reviews_lbl = New System.Windows.Forms.Label()
        Me.pb_top_review_lbl = New System.Windows.Forms.Label()
        Me.pb_next_btn = New System.Windows.Forms.Button()
        Me.pb_cname4 = New System.Windows.Forms.Label()
        Me.pb_cname3 = New System.Windows.Forms.Label()
        Me.pb_cname2 = New System.Windows.Forms.Label()
        Me.pb_cname1 = New System.Windows.Forms.Label()
        Me.pb_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.pb_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.pb_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.pb_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.pb_cast_lbl = New System.Windows.Forms.Label()
        Me.pb_desc = New System.Windows.Forms.Label()
        Me.pb_dur_time_lbl = New System.Windows.Forms.Label()
        Me.pb_rating_val_lbl = New System.Windows.Forms.Label()
        Me.pb_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.pb_dur_lbl = New System.Windows.Forms.Label()
        Me.pb_Rating_lbl = New System.Windows.Forms.Label()
        Me.trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.pb_moviename_lbl = New System.Windows.Forms.Label()
        Me.poster_format_pnl = New System.Windows.Forms.Panel()
        Me.pb_format_nxt_btn = New System.Windows.Forms.Button()
        Me.pb_btn_3d = New System.Windows.Forms.RadioButton()
        Me.pb_btn_2d = New System.Windows.Forms.RadioButton()
        Me.pb_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.poster_panel.SuspendLayout()
        Me.pb_vid_pnl.SuspendLayout()
        CType(Me.pb_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.poster_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'poster_panel
        '
        Me.poster_panel.BackColor = System.Drawing.Color.Snow
        Me.poster_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.poster_panel.Controls.Add(Me.BackButton)
        Me.poster_panel.Controls.Add(Me.pb_vid_pnl)
        Me.poster_panel.Controls.Add(Me.pb_username_lbl)
        Me.poster_panel.Controls.Add(Me.pb_user_review_output)
        Me.poster_panel.Controls.Add(Me.pb_add_review_lbl)
        Me.poster_panel.Controls.Add(Me.pb_user_review_txt)
        Me.poster_panel.Controls.Add(Me.pb_Add_btn)
        Me.poster_panel.Controls.Add(Me.pb_user2_review_lbl)
        Me.poster_panel.Controls.Add(Me.pb_user2_name_lbl)
        Me.poster_panel.Controls.Add(Me.pb_user1_review_lbl)
        Me.poster_panel.Controls.Add(Me.pb_user1_lbl)
        Me.poster_panel.Controls.Add(Me.pb_reviews_lbl)
        Me.poster_panel.Controls.Add(Me.pb_top_review_lbl)
        Me.poster_panel.Controls.Add(Me.pb_next_btn)
        Me.poster_panel.Controls.Add(Me.pb_cname4)
        Me.poster_panel.Controls.Add(Me.pb_cname3)
        Me.poster_panel.Controls.Add(Me.pb_cname2)
        Me.poster_panel.Controls.Add(Me.pb_cname1)
        Me.poster_panel.Controls.Add(Me.pb_cast_img3)
        Me.poster_panel.Controls.Add(Me.pb_cast_img2)
        Me.poster_panel.Controls.Add(Me.pb_cast_img4)
        Me.poster_panel.Controls.Add(Me.pb_cast_img1)
        Me.poster_panel.Controls.Add(Me.pb_cast_lbl)
        Me.poster_panel.Controls.Add(Me.pb_desc)
        Me.poster_panel.Controls.Add(Me.pb_dur_time_lbl)
        Me.poster_panel.Controls.Add(Me.pb_rating_val_lbl)
        Me.poster_panel.Controls.Add(Me.pb_star_pt_box)
        Me.poster_panel.Controls.Add(Me.pb_dur_lbl)
        Me.poster_panel.Controls.Add(Me.pb_Rating_lbl)
        Me.poster_panel.Controls.Add(Me.trailer_bg_lbl)
        Me.poster_panel.Controls.Add(Me.pb_moviename_lbl)
        Me.poster_panel.Location = New System.Drawing.Point(0, 39)
        Me.poster_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.poster_panel.Name = "poster_panel"
        Me.poster_panel.Size = New System.Drawing.Size(1043, 821)
        Me.poster_panel.TabIndex = 1
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
        Me.BackButton.TabIndex = 34
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'pb_vid_pnl
        '
        Me.pb_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pb_vid_pnl.Controls.Add(Me.pb_ply_btn)
        Me.pb_vid_pnl.Controls.Add(Me.play_btn)
        Me.pb_vid_pnl.Controls.Add(Me.pb_vid_sc)
        Me.pb_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.pb_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_vid_pnl.Name = "pb_vid_pnl"
        Me.pb_vid_pnl.Size = New System.Drawing.Size(1037, 245)
        Me.pb_vid_pnl.TabIndex = 30
        '
        'pb_ply_btn
        '
        Me.pb_ply_btn.BackgroundImage = CType(resources.GetObject("pb_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.pb_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_ply_btn.Location = New System.Drawing.Point(481, 72)
        Me.pb_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_ply_btn.Name = "pb_ply_btn"
        Me.pb_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.pb_ply_btn.TabIndex = 2
        Me.pb_ply_btn.UseVisualStyleBackColor = True
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
        'pb_vid_sc
        '
        Me.pb_vid_sc.Enabled = True
        Me.pb_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.pb_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_vid_sc.Name = "pb_vid_sc"
        Me.pb_vid_sc.OcxState = CType(resources.GetObject("pb_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pb_vid_sc.Size = New System.Drawing.Size(596, 299)
        Me.pb_vid_sc.TabIndex = 0
        '
        'pb_username_lbl
        '
        Me.pb_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_username_lbl.Location = New System.Drawing.Point(682, 616)
        Me.pb_username_lbl.Name = "pb_username_lbl"
        Me.pb_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.pb_username_lbl.TabIndex = 29
        Me.pb_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_user_review_output
        '
        Me.pb_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_user_review_output.Location = New System.Drawing.Point(775, 616)
        Me.pb_user_review_output.Name = "pb_user_review_output"
        Me.pb_user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.pb_user_review_output.TabIndex = 28
        '
        'pb_add_review_lbl
        '
        Me.pb_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.pb_add_review_lbl.Location = New System.Drawing.Point(693, 676)
        Me.pb_add_review_lbl.Name = "pb_add_review_lbl"
        Me.pb_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.pb_add_review_lbl.TabIndex = 27
        Me.pb_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pb_user_review_txt
        '
        Me.pb_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pb_user_review_txt.Location = New System.Drawing.Point(690, 709)
        Me.pb_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_user_review_txt.Name = "pb_user_review_txt"
        Me.pb_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.pb_user_review_txt.TabIndex = 25
        '
        'pb_Add_btn
        '
        Me.pb_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.pb_Add_btn.Location = New System.Drawing.Point(964, 709)
        Me.pb_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_Add_btn.Name = "pb_Add_btn"
        Me.pb_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.pb_Add_btn.TabIndex = 26
        Me.pb_Add_btn.Text = "ADD"
        Me.pb_Add_btn.UseVisualStyleBackColor = False
        '
        'pb_user2_review_lbl
        '
        Me.pb_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_user2_review_lbl.Location = New System.Drawing.Point(775, 430)
        Me.pb_user2_review_lbl.Name = "pb_user2_review_lbl"
        Me.pb_user2_review_lbl.Size = New System.Drawing.Size(245, 98)
        Me.pb_user2_review_lbl.TabIndex = 24
        Me.pb_user2_review_lbl.Text = "I love this movie very much. The plot of the movie is good. Besides, the songs ar" &
    "e nice to hear and enjoy."
        '
        'pb_user2_name_lbl
        '
        Me.pb_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_user2_name_lbl.Location = New System.Drawing.Point(682, 428)
        Me.pb_user2_name_lbl.Name = "pb_user2_name_lbl"
        Me.pb_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.pb_user2_name_lbl.TabIndex = 23
        Me.pb_user2_name_lbl.Text = "User233 :"
        Me.pb_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_user1_review_lbl
        '
        Me.pb_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_user1_review_lbl.Location = New System.Drawing.Point(775, 528)
        Me.pb_user1_review_lbl.Name = "pb_user1_review_lbl"
        Me.pb_user1_review_lbl.Size = New System.Drawing.Size(245, 89)
        Me.pb_user1_review_lbl.TabIndex = 22
        Me.pb_user1_review_lbl.Text = "A gr888 movie with excellent script and best ending totally loved the movie"
        '
        'pb_user1_lbl
        '
        Me.pb_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_user1_lbl.Location = New System.Drawing.Point(682, 528)
        Me.pb_user1_lbl.Name = "pb_user1_lbl"
        Me.pb_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.pb_user1_lbl.TabIndex = 21
        Me.pb_user1_lbl.Text = "User374 :"
        Me.pb_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_reviews_lbl
        '
        Me.pb_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_reviews_lbl.Location = New System.Drawing.Point(669, 420)
        Me.pb_reviews_lbl.Name = "pb_reviews_lbl"
        Me.pb_reviews_lbl.Size = New System.Drawing.Size(361, 328)
        Me.pb_reviews_lbl.TabIndex = 20
        '
        'pb_top_review_lbl
        '
        Me.pb_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.pb_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.pb_top_review_lbl.Location = New System.Drawing.Point(669, 370)
        Me.pb_top_review_lbl.Name = "pb_top_review_lbl"
        Me.pb_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.pb_top_review_lbl.TabIndex = 19
        Me.pb_top_review_lbl.Text = "Top reviews"
        Me.pb_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_next_btn
        '
        Me.pb_next_btn.BackColor = System.Drawing.Color.Brown
        Me.pb_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb_next_btn.FlatAppearance.BorderSize = 0
        Me.pb_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pb_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pb_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.pb_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_next_btn.Name = "pb_next_btn"
        Me.pb_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.pb_next_btn.TabIndex = 18
        Me.pb_next_btn.Text = "Proceed To Next"
        Me.pb_next_btn.UseVisualStyleBackColor = False
        '
        'pb_cname4
        '
        Me.pb_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_cname4.Location = New System.Drawing.Point(507, 686)
        Me.pb_cname4.Name = "pb_cname4"
        Me.pb_cname4.Size = New System.Drawing.Size(170, 51)
        Me.pb_cname4.TabIndex = 17
        Me.pb_cname4.Text = "Tripti Dimri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Riya)"
        Me.pb_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pb_cname3
        '
        Me.pb_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_cname3.Location = New System.Drawing.Point(357, 686)
        Me.pb_cname3.Name = "pb_cname3"
        Me.pb_cname3.Size = New System.Drawing.Size(144, 51)
        Me.pb_cname3.TabIndex = 16
        Me.pb_cname3.Text = "Shreyas Talpade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Arjun Singh)"
        Me.pb_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pb_cname2
        '
        Me.pb_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_cname2.Location = New System.Drawing.Point(191, 686)
        Me.pb_cname2.Name = "pb_cname2"
        Me.pb_cname2.Size = New System.Drawing.Size(135, 51)
        Me.pb_cname2.TabIndex = 15
        Me.pb_cname2.Text = "Bobby Deol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Vinay Sharma)"
        Me.pb_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pb_cname1
        '
        Me.pb_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_cname1.Location = New System.Drawing.Point(32, 686)
        Me.pb_cname1.Name = "pb_cname1"
        Me.pb_cname1.Size = New System.Drawing.Size(136, 51)
        Me.pb_cname1.TabIndex = 14
        Me.pb_cname1.Text = "Sunny Deol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Jagaavar)"
        Me.pb_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pb_cast_img3
        '
        Me.pb_cast_img3.Image = CType(resources.GetObject("pb_cast_img3.Image"), System.Drawing.Image)
        Me.pb_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.pb_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_cast_img3.Name = "pb_cast_img3"
        Me.pb_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.pb_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cast_img3.TabIndex = 13
        Me.pb_cast_img3.TabStop = False
        '
        'pb_cast_img2
        '
        Me.pb_cast_img2.Image = CType(resources.GetObject("pb_cast_img2.Image"), System.Drawing.Image)
        Me.pb_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.pb_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_cast_img2.Name = "pb_cast_img2"
        Me.pb_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.pb_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cast_img2.TabIndex = 12
        Me.pb_cast_img2.TabStop = False
        '
        'pb_cast_img4
        '
        Me.pb_cast_img4.Image = CType(resources.GetObject("pb_cast_img4.Image"), System.Drawing.Image)
        Me.pb_cast_img4.Location = New System.Drawing.Point(522, 560)
        Me.pb_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_cast_img4.Name = "pb_cast_img4"
        Me.pb_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.pb_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cast_img4.TabIndex = 11
        Me.pb_cast_img4.TabStop = False
        '
        'pb_cast_img1
        '
        Me.pb_cast_img1.Image = CType(resources.GetObject("pb_cast_img1.Image"), System.Drawing.Image)
        Me.pb_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.pb_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_cast_img1.Name = "pb_cast_img1"
        Me.pb_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.pb_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cast_img1.TabIndex = 10
        Me.pb_cast_img1.TabStop = False
        '
        'pb_cast_lbl
        '
        Me.pb_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.pb_cast_lbl.Name = "pb_cast_lbl"
        Me.pb_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.pb_cast_lbl.TabIndex = 9
        Me.pb_cast_lbl.Text = "Cast"
        Me.pb_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_desc
        '
        Me.pb_desc.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_desc.Location = New System.Drawing.Point(10, 420)
        Me.pb_desc.Name = "pb_desc"
        Me.pb_desc.Size = New System.Drawing.Size(648, 85)
        Me.pb_desc.TabIndex = 8
        Me.pb_desc.Text = "Comedy, Family;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Life of three men comes in trouble when their photos appear on a" &
    "dvertisement for sterilization."
        '
        'pb_dur_time_lbl
        '
        Me.pb_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.pb_dur_time_lbl.Name = "pb_dur_time_lbl"
        Me.pb_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.pb_dur_time_lbl.TabIndex = 7
        Me.pb_dur_time_lbl.Text = "2h 8m"
        '
        'pb_rating_val_lbl
        '
        Me.pb_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.pb_rating_val_lbl.Name = "pb_rating_val_lbl"
        Me.pb_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.pb_rating_val_lbl.TabIndex = 6
        Me.pb_rating_val_lbl.Text = "7.2/10"
        '
        'pb_star_pt_box
        '
        Me.pb_star_pt_box.Image = CType(resources.GetObject("pb_star_pt_box.Image"), System.Drawing.Image)
        Me.pb_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.pb_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_star_pt_box.Name = "pb_star_pt_box"
        Me.pb_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.pb_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_star_pt_box.TabIndex = 5
        Me.pb_star_pt_box.TabStop = False
        '
        'pb_dur_lbl
        '
        Me.pb_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.pb_dur_lbl.Name = "pb_dur_lbl"
        Me.pb_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.pb_dur_lbl.TabIndex = 4
        Me.pb_dur_lbl.Text = "Duration  :"
        Me.pb_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_Rating_lbl
        '
        Me.pb_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.pb_Rating_lbl.Name = "pb_Rating_lbl"
        Me.pb_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.pb_Rating_lbl.TabIndex = 3
        Me.pb_Rating_lbl.Text = "Ratings     :"
        Me.pb_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trailer_bg_lbl
        '
        Me.trailer_bg_lbl.BackColor = System.Drawing.Color.DimGray
        Me.trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.trailer_bg_lbl.Name = "trailer_bg_lbl"
        Me.trailer_bg_lbl.Size = New System.Drawing.Size(1040, 245)
        Me.trailer_bg_lbl.TabIndex = 1
        Me.trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pb_moviename_lbl
        '
        Me.pb_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pb_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.pb_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.pb_moviename_lbl.Name = "pb_moviename_lbl"
        Me.pb_moviename_lbl.Size = New System.Drawing.Size(1040, 50)
        Me.pb_moviename_lbl.TabIndex = 0
        Me.pb_moviename_lbl.Text = "Poster Boys"
        Me.pb_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'poster_format_pnl
        '
        Me.poster_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.poster_format_pnl.Controls.Add(Me.pb_format_nxt_btn)
        Me.poster_format_pnl.Controls.Add(Me.pb_btn_3d)
        Me.poster_format_pnl.Controls.Add(Me.pb_btn_2d)
        Me.poster_format_pnl.Controls.Add(Me.pb_select_format_lbl)
        Me.poster_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.poster_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.poster_format_pnl.Name = "poster_format_pnl"
        Me.poster_format_pnl.Size = New System.Drawing.Size(1043, 151)
        Me.poster_format_pnl.TabIndex = 31
        Me.poster_format_pnl.Visible = False
        '
        'pb_format_nxt_btn
        '
        Me.pb_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.pb_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.pb_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pb_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pb_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.pb_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_format_nxt_btn.Name = "pb_format_nxt_btn"
        Me.pb_format_nxt_btn.Size = New System.Drawing.Size(1043, 60)
        Me.pb_format_nxt_btn.TabIndex = 19
        Me.pb_format_nxt_btn.Text = "Continue"
        Me.pb_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'pb_btn_3d
        '
        Me.pb_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.pb_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_btn_3d.Name = "pb_btn_3d"
        Me.pb_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.pb_btn_3d.TabIndex = 7
        Me.pb_btn_3d.TabStop = True
        Me.pb_btn_3d.Text = "3D"
        Me.pb_btn_3d.UseVisualStyleBackColor = True
        '
        'pb_btn_2d
        '
        Me.pb_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_btn_2d.Location = New System.Drawing.Point(252, 19)
        Me.pb_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pb_btn_2d.Name = "pb_btn_2d"
        Me.pb_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.pb_btn_2d.TabIndex = 6
        Me.pb_btn_2d.TabStop = True
        Me.pb_btn_2d.Text = "2D"
        Me.pb_btn_2d.UseVisualStyleBackColor = True
        '
        'pb_select_format_lbl
        '
        Me.pb_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pb_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.pb_select_format_lbl.Name = "pb_select_format_lbl"
        Me.pb_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.pb_select_format_lbl.TabIndex = 5
        Me.pb_select_format_lbl.Text = "Select Movie Format :"
        Me.pb_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 32
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
        'poster_boys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.poster_format_pnl)
        Me.Controls.Add(Me.poster_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "poster_boys"
        Me.Text = "poster_boys"
        Me.poster_panel.ResumeLayout(False)
        Me.poster_panel.PerformLayout()
        Me.pb_vid_pnl.ResumeLayout(False)
        CType(Me.pb_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.poster_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents poster_panel As Panel
    Friend WithEvents pb_vid_pnl As Panel
    Friend WithEvents pb_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents pb_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pb_username_lbl As Label
    Friend WithEvents pb_user_review_output As Label
    Friend WithEvents pb_add_review_lbl As Label
    Friend WithEvents pb_user_review_txt As TextBox
    Friend WithEvents pb_Add_btn As Button
    Friend WithEvents pb_user2_review_lbl As Label
    Friend WithEvents pb_user2_name_lbl As Label
    Friend WithEvents pb_user1_review_lbl As Label
    Friend WithEvents pb_user1_lbl As Label
    Friend WithEvents pb_reviews_lbl As Label
    Friend WithEvents pb_top_review_lbl As Label
    Friend WithEvents pb_next_btn As Button
    Friend WithEvents pb_cname4 As Label
    Friend WithEvents pb_cname3 As Label
    Friend WithEvents pb_cname2 As Label
    Friend WithEvents pb_cname1 As Label
    Friend WithEvents pb_cast_img3 As PictureBox
    Friend WithEvents pb_cast_img2 As PictureBox
    Friend WithEvents pb_cast_img4 As PictureBox
    Friend WithEvents pb_cast_img1 As PictureBox
    Friend WithEvents pb_cast_lbl As Label
    Friend WithEvents pb_desc As Label
    Friend WithEvents pb_dur_time_lbl As Label
    Friend WithEvents pb_rating_val_lbl As Label
    Friend WithEvents pb_star_pt_box As PictureBox
    Friend WithEvents pb_dur_lbl As Label
    Friend WithEvents pb_Rating_lbl As Label
    Friend WithEvents trailer_bg_lbl As Label
    Friend WithEvents pb_moviename_lbl As Label
    Friend WithEvents poster_format_pnl As Panel
    Friend WithEvents pb_format_nxt_btn As Button
    Friend WithEvents pb_btn_3d As RadioButton
    Friend WithEvents pb_btn_2d As RadioButton
    Friend WithEvents pb_select_format_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
