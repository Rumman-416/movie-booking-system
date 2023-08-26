<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suzume
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(suzume))
        Me.suz_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.s_vid_pnl = New System.Windows.Forms.Panel()
        Me.s_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.s_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.s_username_lbl = New System.Windows.Forms.Label()
        Me.s_user_review_output = New System.Windows.Forms.Label()
        Me.s_add_review_lbl = New System.Windows.Forms.Label()
        Me.s_user_review_txt = New System.Windows.Forms.TextBox()
        Me.s_Add_btn = New System.Windows.Forms.Button()
        Me.s_user2_review_lbl = New System.Windows.Forms.Label()
        Me.s_user2_name_lbl = New System.Windows.Forms.Label()
        Me.s_user1_review_lbl = New System.Windows.Forms.Label()
        Me.s_user1_lbl = New System.Windows.Forms.Label()
        Me.s_reviews_lbl = New System.Windows.Forms.Label()
        Me.s_top_review_lbl = New System.Windows.Forms.Label()
        Me.s_next_btn = New System.Windows.Forms.Button()
        Me.s_cname4 = New System.Windows.Forms.Label()
        Me.s_cname3 = New System.Windows.Forms.Label()
        Me.s_cname2 = New System.Windows.Forms.Label()
        Me.s_cname1 = New System.Windows.Forms.Label()
        Me.s_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.s_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.s_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.s_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.s_cast_lbl = New System.Windows.Forms.Label()
        Me.s_desc = New System.Windows.Forms.Label()
        Me.s_dur_time_lbl = New System.Windows.Forms.Label()
        Me.s_rating_val_lbl = New System.Windows.Forms.Label()
        Me.s_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.s_dur_lbl = New System.Windows.Forms.Label()
        Me.s_Rating_lbl = New System.Windows.Forms.Label()
        Me.s_trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.s_moviename_lbl = New System.Windows.Forms.Label()
        Me.suz_format_pnl = New System.Windows.Forms.Panel()
        Me.s_format_nxt_btn = New System.Windows.Forms.Button()
        Me.s_btn_3d = New System.Windows.Forms.RadioButton()
        Me.s_btn_2d = New System.Windows.Forms.RadioButton()
        Me.s_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.suz_panel.SuspendLayout()
        Me.s_vid_pnl.SuspendLayout()
        CType(Me.s_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.s_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.suz_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'suz_panel
        '
        Me.suz_panel.BackColor = System.Drawing.Color.Snow
        Me.suz_panel.Controls.Add(Me.BackButton)
        Me.suz_panel.Controls.Add(Me.s_vid_pnl)
        Me.suz_panel.Controls.Add(Me.s_username_lbl)
        Me.suz_panel.Controls.Add(Me.s_user_review_output)
        Me.suz_panel.Controls.Add(Me.s_add_review_lbl)
        Me.suz_panel.Controls.Add(Me.s_user_review_txt)
        Me.suz_panel.Controls.Add(Me.s_Add_btn)
        Me.suz_panel.Controls.Add(Me.s_user2_review_lbl)
        Me.suz_panel.Controls.Add(Me.s_user2_name_lbl)
        Me.suz_panel.Controls.Add(Me.s_user1_review_lbl)
        Me.suz_panel.Controls.Add(Me.s_user1_lbl)
        Me.suz_panel.Controls.Add(Me.s_reviews_lbl)
        Me.suz_panel.Controls.Add(Me.s_top_review_lbl)
        Me.suz_panel.Controls.Add(Me.s_next_btn)
        Me.suz_panel.Controls.Add(Me.s_cname4)
        Me.suz_panel.Controls.Add(Me.s_cname3)
        Me.suz_panel.Controls.Add(Me.s_cname2)
        Me.suz_panel.Controls.Add(Me.s_cname1)
        Me.suz_panel.Controls.Add(Me.s_cast_img3)
        Me.suz_panel.Controls.Add(Me.s_cast_img2)
        Me.suz_panel.Controls.Add(Me.s_cast_img4)
        Me.suz_panel.Controls.Add(Me.s_cast_img1)
        Me.suz_panel.Controls.Add(Me.s_cast_lbl)
        Me.suz_panel.Controls.Add(Me.s_desc)
        Me.suz_panel.Controls.Add(Me.s_dur_time_lbl)
        Me.suz_panel.Controls.Add(Me.s_rating_val_lbl)
        Me.suz_panel.Controls.Add(Me.s_star_pt_box)
        Me.suz_panel.Controls.Add(Me.s_dur_lbl)
        Me.suz_panel.Controls.Add(Me.s_Rating_lbl)
        Me.suz_panel.Controls.Add(Me.s_trailer_bg_lbl)
        Me.suz_panel.Controls.Add(Me.s_moviename_lbl)
        Me.suz_panel.Location = New System.Drawing.Point(0, 39)
        Me.suz_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.suz_panel.Name = "suz_panel"
        Me.suz_panel.Size = New System.Drawing.Size(1043, 821)
        Me.suz_panel.TabIndex = 1
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
        's_vid_pnl
        '
        Me.s_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.s_vid_pnl.Controls.Add(Me.s_ply_btn)
        Me.s_vid_pnl.Controls.Add(Me.play_btn)
        Me.s_vid_pnl.Controls.Add(Me.s_vid_sc)
        Me.s_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.s_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_vid_pnl.Name = "s_vid_pnl"
        Me.s_vid_pnl.Size = New System.Drawing.Size(1037, 245)
        Me.s_vid_pnl.TabIndex = 31
        '
        's_ply_btn
        '
        Me.s_ply_btn.BackgroundImage = CType(resources.GetObject("s_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.s_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.s_ply_btn.Location = New System.Drawing.Point(486, 72)
        Me.s_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_ply_btn.Name = "s_ply_btn"
        Me.s_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.s_ply_btn.TabIndex = 2
        Me.s_ply_btn.UseVisualStyleBackColor = True
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
        's_vid_sc
        '
        Me.s_vid_sc.Enabled = True
        Me.s_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.s_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_vid_sc.Name = "s_vid_sc"
        Me.s_vid_sc.OcxState = CType(resources.GetObject("s_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.s_vid_sc.Size = New System.Drawing.Size(596, 295)
        Me.s_vid_sc.TabIndex = 0
        '
        's_username_lbl
        '
        Me.s_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_username_lbl.Location = New System.Drawing.Point(678, 577)
        Me.s_username_lbl.Name = "s_username_lbl"
        Me.s_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.s_username_lbl.TabIndex = 29
        Me.s_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_user_review_output
        '
        Me.s_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_user_review_output.Location = New System.Drawing.Point(773, 577)
        Me.s_user_review_output.Name = "s_user_review_output"
        Me.s_user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.s_user_review_output.TabIndex = 28
        '
        's_add_review_lbl
        '
        Me.s_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.s_add_review_lbl.Location = New System.Drawing.Point(691, 652)
        Me.s_add_review_lbl.Name = "s_add_review_lbl"
        Me.s_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.s_add_review_lbl.TabIndex = 27
        Me.s_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        's_user_review_txt
        '
        Me.s_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.s_user_review_txt.Location = New System.Drawing.Point(688, 685)
        Me.s_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_user_review_txt.Name = "s_user_review_txt"
        Me.s_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.s_user_review_txt.TabIndex = 25
        '
        's_Add_btn
        '
        Me.s_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.s_Add_btn.Location = New System.Drawing.Point(962, 685)
        Me.s_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_Add_btn.Name = "s_Add_btn"
        Me.s_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.s_Add_btn.TabIndex = 26
        Me.s_Add_btn.Text = "ADD"
        Me.s_Add_btn.UseVisualStyleBackColor = False
        '
        's_user2_review_lbl
        '
        Me.s_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_user2_review_lbl.Location = New System.Drawing.Point(777, 408)
        Me.s_user2_review_lbl.Name = "s_user2_review_lbl"
        Me.s_user2_review_lbl.Size = New System.Drawing.Size(254, 100)
        Me.s_user2_review_lbl.TabIndex = 24
        Me.s_user2_review_lbl.Text = "I usually don't watch this type of movies/shows but the animation and art style o" &
    "f this movie is just WOW!!!"
        '
        's_user2_name_lbl
        '
        Me.s_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_user2_name_lbl.Location = New System.Drawing.Point(678, 406)
        Me.s_user2_name_lbl.Name = "s_user2_name_lbl"
        Me.s_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.s_user2_name_lbl.TabIndex = 23
        Me.s_user2_name_lbl.Text = "User953:"
        Me.s_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_user1_review_lbl
        '
        Me.s_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_user1_review_lbl.Location = New System.Drawing.Point(773, 504)
        Me.s_user1_review_lbl.Name = "s_user1_review_lbl"
        Me.s_user1_review_lbl.Size = New System.Drawing.Size(245, 62)
        Me.s_user1_review_lbl.TabIndex = 22
        Me.s_user1_review_lbl.Text = "Your Name, Weathering with you  and now this....Incredible!!!"
        '
        's_user1_lbl
        '
        Me.s_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_user1_lbl.Location = New System.Drawing.Point(678, 504)
        Me.s_user1_lbl.Name = "s_user1_lbl"
        Me.s_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.s_user1_lbl.TabIndex = 21
        Me.s_user1_lbl.Text = "User895 :"
        Me.s_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_reviews_lbl
        '
        Me.s_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.s_reviews_lbl.Location = New System.Drawing.Point(667, 396)
        Me.s_reviews_lbl.Name = "s_reviews_lbl"
        Me.s_reviews_lbl.Size = New System.Drawing.Size(361, 328)
        Me.s_reviews_lbl.TabIndex = 20
        '
        's_top_review_lbl
        '
        Me.s_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.s_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.s_top_review_lbl.Location = New System.Drawing.Point(667, 346)
        Me.s_top_review_lbl.Name = "s_top_review_lbl"
        Me.s_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.s_top_review_lbl.TabIndex = 19
        Me.s_top_review_lbl.Text = "Top reviews"
        Me.s_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_next_btn
        '
        Me.s_next_btn.BackColor = System.Drawing.Color.Brown
        Me.s_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.s_next_btn.FlatAppearance.BorderSize = 0
        Me.s_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.s_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.s_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.s_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_next_btn.Name = "s_next_btn"
        Me.s_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.s_next_btn.TabIndex = 18
        Me.s_next_btn.Text = "Proceed To Next"
        Me.s_next_btn.UseVisualStyleBackColor = False
        '
        's_cname4
        '
        Me.s_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_cname4.Location = New System.Drawing.Point(507, 686)
        Me.s_cname4.Name = "s_cname4"
        Me.s_cname4.Size = New System.Drawing.Size(175, 51)
        Me.s_cname4.TabIndex = 17
        Me.s_cname4.Text = "Ryûnosuke" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Tomoya Serizawa)"
        Me.s_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        's_cname3
        '
        Me.s_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_cname3.Location = New System.Drawing.Point(351, 686)
        Me.s_cname3.Name = "s_cname3"
        Me.s_cname3.Size = New System.Drawing.Size(169, 51)
        Me.s_cname3.TabIndex = 16
        Me.s_cname3.Text = "Kana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Tzubame Iwato)"
        Me.s_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        's_cname2
        '
        Me.s_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_cname2.Location = New System.Drawing.Point(191, 686)
        Me.s_cname2.Name = "s_cname2"
        Me.s_cname2.Size = New System.Drawing.Size(154, 51)
        Me.s_cname2.TabIndex = 15
        Me.s_cname2.Text = "Hokuto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Sota Munkata)"
        Me.s_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        's_cname1
        '
        Me.s_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_cname1.Location = New System.Drawing.Point(32, 686)
        Me.s_cname1.Name = "s_cname1"
        Me.s_cname1.Size = New System.Drawing.Size(166, 51)
        Me.s_cname1.TabIndex = 14
        Me.s_cname1.Text = "Nanako Hara" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Suzume Iwato)"
        Me.s_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        's_cast_img3
        '
        Me.s_cast_img3.Image = CType(resources.GetObject("s_cast_img3.Image"), System.Drawing.Image)
        Me.s_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.s_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_cast_img3.Name = "s_cast_img3"
        Me.s_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.s_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s_cast_img3.TabIndex = 13
        Me.s_cast_img3.TabStop = False
        '
        's_cast_img2
        '
        Me.s_cast_img2.Image = CType(resources.GetObject("s_cast_img2.Image"), System.Drawing.Image)
        Me.s_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.s_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_cast_img2.Name = "s_cast_img2"
        Me.s_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.s_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s_cast_img2.TabIndex = 12
        Me.s_cast_img2.TabStop = False
        '
        's_cast_img4
        '
        Me.s_cast_img4.Image = CType(resources.GetObject("s_cast_img4.Image"), System.Drawing.Image)
        Me.s_cast_img4.Location = New System.Drawing.Point(522, 560)
        Me.s_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_cast_img4.Name = "s_cast_img4"
        Me.s_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.s_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s_cast_img4.TabIndex = 11
        Me.s_cast_img4.TabStop = False
        '
        's_cast_img1
        '
        Me.s_cast_img1.Image = CType(resources.GetObject("s_cast_img1.Image"), System.Drawing.Image)
        Me.s_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.s_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_cast_img1.Name = "s_cast_img1"
        Me.s_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.s_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s_cast_img1.TabIndex = 10
        Me.s_cast_img1.TabStop = False
        '
        's_cast_lbl
        '
        Me.s_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.s_cast_lbl.Name = "s_cast_lbl"
        Me.s_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.s_cast_lbl.TabIndex = 9
        Me.s_cast_lbl.Text = "Cast"
        Me.s_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_desc
        '
        Me.s_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_desc.Location = New System.Drawing.Point(14, 420)
        Me.s_desc.Name = "s_desc"
        Me.s_desc.Size = New System.Drawing.Size(632, 114)
        Me.s_desc.TabIndex = 8
        Me.s_desc.Text = resources.GetString("s_desc.Text")
        '
        's_dur_time_lbl
        '
        Me.s_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.s_dur_time_lbl.Name = "s_dur_time_lbl"
        Me.s_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.s_dur_time_lbl.TabIndex = 7
        Me.s_dur_time_lbl.Text = "2h 07m"
        '
        's_rating_val_lbl
        '
        Me.s_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.s_rating_val_lbl.Name = "s_rating_val_lbl"
        Me.s_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.s_rating_val_lbl.TabIndex = 6
        Me.s_rating_val_lbl.Text = "8.2/10"
        '
        's_star_pt_box
        '
        Me.s_star_pt_box.Image = CType(resources.GetObject("s_star_pt_box.Image"), System.Drawing.Image)
        Me.s_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.s_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_star_pt_box.Name = "s_star_pt_box"
        Me.s_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.s_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s_star_pt_box.TabIndex = 5
        Me.s_star_pt_box.TabStop = False
        '
        's_dur_lbl
        '
        Me.s_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.s_dur_lbl.Name = "s_dur_lbl"
        Me.s_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.s_dur_lbl.TabIndex = 4
        Me.s_dur_lbl.Text = "Duration  :"
        Me.s_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_Rating_lbl
        '
        Me.s_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.s_Rating_lbl.Name = "s_Rating_lbl"
        Me.s_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.s_Rating_lbl.TabIndex = 3
        Me.s_Rating_lbl.Text = "Ratings     :"
        Me.s_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_trailer_bg_lbl
        '
        Me.s_trailer_bg_lbl.BackColor = System.Drawing.Color.Black
        Me.s_trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.s_trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.s_trailer_bg_lbl.Name = "s_trailer_bg_lbl"
        Me.s_trailer_bg_lbl.Size = New System.Drawing.Size(1040, 245)
        Me.s_trailer_bg_lbl.TabIndex = 1
        Me.s_trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        's_moviename_lbl
        '
        Me.s_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.s_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.s_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.s_moviename_lbl.Name = "s_moviename_lbl"
        Me.s_moviename_lbl.Size = New System.Drawing.Size(1040, 50)
        Me.s_moviename_lbl.TabIndex = 0
        Me.s_moviename_lbl.Text = "SUZUME : NO TOJIMARI"
        Me.s_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'suz_format_pnl
        '
        Me.suz_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.suz_format_pnl.Controls.Add(Me.s_format_nxt_btn)
        Me.suz_format_pnl.Controls.Add(Me.s_btn_3d)
        Me.suz_format_pnl.Controls.Add(Me.s_btn_2d)
        Me.suz_format_pnl.Controls.Add(Me.s_select_format_lbl)
        Me.suz_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.suz_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.suz_format_pnl.Name = "suz_format_pnl"
        Me.suz_format_pnl.Size = New System.Drawing.Size(1043, 151)
        Me.suz_format_pnl.TabIndex = 2
        Me.suz_format_pnl.Visible = False
        '
        's_format_nxt_btn
        '
        Me.s_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.s_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.s_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.s_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.s_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.s_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.s_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_format_nxt_btn.Name = "s_format_nxt_btn"
        Me.s_format_nxt_btn.Size = New System.Drawing.Size(1043, 60)
        Me.s_format_nxt_btn.TabIndex = 19
        Me.s_format_nxt_btn.Text = "Continue"
        Me.s_format_nxt_btn.UseVisualStyleBackColor = False
        '
        's_btn_3d
        '
        Me.s_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.s_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_btn_3d.Name = "s_btn_3d"
        Me.s_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.s_btn_3d.TabIndex = 7
        Me.s_btn_3d.TabStop = True
        Me.s_btn_3d.Text = "3D"
        Me.s_btn_3d.UseVisualStyleBackColor = True
        '
        's_btn_2d
        '
        Me.s_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_btn_2d.Location = New System.Drawing.Point(252, 19)
        Me.s_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.s_btn_2d.Name = "s_btn_2d"
        Me.s_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.s_btn_2d.TabIndex = 6
        Me.s_btn_2d.TabStop = True
        Me.s_btn_2d.Text = "2D"
        Me.s_btn_2d.UseVisualStyleBackColor = True
        '
        's_select_format_lbl
        '
        Me.s_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.s_select_format_lbl.Name = "s_select_format_lbl"
        Me.s_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.s_select_format_lbl.TabIndex = 5
        Me.s_select_format_lbl.Text = "Select Movie Format :"
        Me.s_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 4
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
        'suzume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.suz_format_pnl)
        Me.Controls.Add(Me.suz_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "suzume"
        Me.Text = "Suzume"
        Me.suz_panel.ResumeLayout(False)
        Me.suz_panel.PerformLayout()
        Me.s_vid_pnl.ResumeLayout(False)
        CType(Me.s_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.s_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.suz_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents suz_panel As Panel
    Friend WithEvents s_username_lbl As Label
    Friend WithEvents s_user_review_output As Label
    Friend WithEvents s_add_review_lbl As Label
    Friend WithEvents s_user_review_txt As TextBox
    Friend WithEvents s_Add_btn As Button
    Friend WithEvents s_user2_review_lbl As Label
    Friend WithEvents s_user2_name_lbl As Label
    Friend WithEvents s_user1_review_lbl As Label
    Friend WithEvents s_user1_lbl As Label
    Friend WithEvents s_reviews_lbl As Label
    Friend WithEvents s_top_review_lbl As Label
    Friend WithEvents s_next_btn As Button
    Friend WithEvents s_cname4 As Label
    Friend WithEvents s_cname3 As Label
    Friend WithEvents s_cname2 As Label
    Friend WithEvents s_cname1 As Label
    Friend WithEvents s_cast_img3 As PictureBox
    Friend WithEvents s_cast_img2 As PictureBox
    Friend WithEvents s_cast_img4 As PictureBox
    Friend WithEvents s_cast_img1 As PictureBox
    Friend WithEvents s_cast_lbl As Label
    Friend WithEvents s_desc As Label
    Friend WithEvents s_dur_time_lbl As Label
    Friend WithEvents s_rating_val_lbl As Label
    Friend WithEvents s_star_pt_box As PictureBox
    Friend WithEvents s_dur_lbl As Label
    Friend WithEvents s_Rating_lbl As Label
    Friend WithEvents s_trailer_bg_lbl As Label
    Friend WithEvents s_moviename_lbl As Label
    Friend WithEvents suz_format_pnl As Panel
    Friend WithEvents s_format_nxt_btn As Button
    Friend WithEvents s_btn_3d As RadioButton
    Friend WithEvents s_btn_2d As RadioButton
    Friend WithEvents s_select_format_lbl As Label
    Friend WithEvents s_vid_pnl As Panel
    Friend WithEvents s_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents s_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
