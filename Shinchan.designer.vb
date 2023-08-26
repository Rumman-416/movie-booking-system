<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shinchan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shinchan))
        Me.shinchan_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.sc_vid_pnl = New System.Windows.Forms.Panel()
        Me.sc_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.sc_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.sc_username_lbl = New System.Windows.Forms.Label()
        Me.sc_user_review_output = New System.Windows.Forms.Label()
        Me.sc_add_review_lbl = New System.Windows.Forms.Label()
        Me.sc_user_review_txt = New System.Windows.Forms.TextBox()
        Me.sc_Add_btn = New System.Windows.Forms.Button()
        Me.sc_user2_review_lbl = New System.Windows.Forms.Label()
        Me.sc_user2_name_lbl = New System.Windows.Forms.Label()
        Me.sc_user1_review_lbl = New System.Windows.Forms.Label()
        Me.sc_user1_lbl = New System.Windows.Forms.Label()
        Me.sc_reviews_lbl = New System.Windows.Forms.Label()
        Me.sc_top_review_lbl = New System.Windows.Forms.Label()
        Me.sc_next_btn = New System.Windows.Forms.Button()
        Me.sc_cname4 = New System.Windows.Forms.Label()
        Me.sc_cname3 = New System.Windows.Forms.Label()
        Me.sc_cname2 = New System.Windows.Forms.Label()
        Me.sc_cname1 = New System.Windows.Forms.Label()
        Me.sc_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.sc_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.sc_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.sc_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.sc_cast_lbl = New System.Windows.Forms.Label()
        Me.sc_desc = New System.Windows.Forms.Label()
        Me.sc_dur_time_lbl = New System.Windows.Forms.Label()
        Me.sc_rating_val_lbl = New System.Windows.Forms.Label()
        Me.sc_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.sc_dur_lbl = New System.Windows.Forms.Label()
        Me.sc_Rating_lbl = New System.Windows.Forms.Label()
        Me.trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.sc_moviename_lbl = New System.Windows.Forms.Label()
        Me.shinchan_format_pnl = New System.Windows.Forms.Panel()
        Me.sc_format_nxt_btn = New System.Windows.Forms.Button()
        Me.sc_btn_3d = New System.Windows.Forms.RadioButton()
        Me.sc_btn_2d = New System.Windows.Forms.RadioButton()
        Me.sc_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.shinchan_panel.SuspendLayout()
        Me.sc_vid_pnl.SuspendLayout()
        CType(Me.sc_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.shinchan_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'shinchan_panel
        '
        Me.shinchan_panel.BackColor = System.Drawing.Color.Snow
        Me.shinchan_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shinchan_panel.Controls.Add(Me.BackButton)
        Me.shinchan_panel.Controls.Add(Me.sc_vid_pnl)
        Me.shinchan_panel.Controls.Add(Me.sc_username_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_user_review_output)
        Me.shinchan_panel.Controls.Add(Me.sc_add_review_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_user_review_txt)
        Me.shinchan_panel.Controls.Add(Me.sc_Add_btn)
        Me.shinchan_panel.Controls.Add(Me.sc_user2_review_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_user2_name_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_user1_review_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_user1_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_reviews_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_top_review_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_next_btn)
        Me.shinchan_panel.Controls.Add(Me.sc_cname4)
        Me.shinchan_panel.Controls.Add(Me.sc_cname3)
        Me.shinchan_panel.Controls.Add(Me.sc_cname2)
        Me.shinchan_panel.Controls.Add(Me.sc_cname1)
        Me.shinchan_panel.Controls.Add(Me.sc_cast_img3)
        Me.shinchan_panel.Controls.Add(Me.sc_cast_img2)
        Me.shinchan_panel.Controls.Add(Me.sc_cast_img4)
        Me.shinchan_panel.Controls.Add(Me.sc_cast_img1)
        Me.shinchan_panel.Controls.Add(Me.sc_cast_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_desc)
        Me.shinchan_panel.Controls.Add(Me.sc_dur_time_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_rating_val_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_star_pt_box)
        Me.shinchan_panel.Controls.Add(Me.sc_dur_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_Rating_lbl)
        Me.shinchan_panel.Controls.Add(Me.trailer_bg_lbl)
        Me.shinchan_panel.Controls.Add(Me.sc_moviename_lbl)
        Me.shinchan_panel.Location = New System.Drawing.Point(0, 39)
        Me.shinchan_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.shinchan_panel.Name = "shinchan_panel"
        Me.shinchan_panel.Size = New System.Drawing.Size(1043, 821)
        Me.shinchan_panel.TabIndex = 1
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
        'sc_vid_pnl
        '
        Me.sc_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sc_vid_pnl.Controls.Add(Me.sc_ply_btn)
        Me.sc_vid_pnl.Controls.Add(Me.play_btn)
        Me.sc_vid_pnl.Controls.Add(Me.sc_vid_sc)
        Me.sc_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.sc_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_vid_pnl.Name = "sc_vid_pnl"
        Me.sc_vid_pnl.Size = New System.Drawing.Size(1037, 245)
        Me.sc_vid_pnl.TabIndex = 30
        '
        'sc_ply_btn
        '
        Me.sc_ply_btn.BackgroundImage = CType(resources.GetObject("sc_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.sc_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sc_ply_btn.Location = New System.Drawing.Point(478, 71)
        Me.sc_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_ply_btn.Name = "sc_ply_btn"
        Me.sc_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.sc_ply_btn.TabIndex = 2
        Me.sc_ply_btn.UseVisualStyleBackColor = True
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
        'sc_vid_sc
        '
        Me.sc_vid_sc.Enabled = True
        Me.sc_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.sc_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_vid_sc.Name = "sc_vid_sc"
        Me.sc_vid_sc.OcxState = CType(resources.GetObject("sc_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sc_vid_sc.Size = New System.Drawing.Size(596, 307)
        Me.sc_vid_sc.TabIndex = 0
        '
        'sc_username_lbl
        '
        Me.sc_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_username_lbl.Location = New System.Drawing.Point(679, 605)
        Me.sc_username_lbl.Name = "sc_username_lbl"
        Me.sc_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.sc_username_lbl.TabIndex = 29
        Me.sc_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sc_user_review_output
        '
        Me.sc_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_user_review_output.Location = New System.Drawing.Point(772, 605)
        Me.sc_user_review_output.Name = "sc_user_review_output"
        Me.sc_user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.sc_user_review_output.TabIndex = 28
        '
        'sc_add_review_lbl
        '
        Me.sc_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.sc_add_review_lbl.Location = New System.Drawing.Point(690, 665)
        Me.sc_add_review_lbl.Name = "sc_add_review_lbl"
        Me.sc_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.sc_add_review_lbl.TabIndex = 27
        Me.sc_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'sc_user_review_txt
        '
        Me.sc_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sc_user_review_txt.Location = New System.Drawing.Point(687, 698)
        Me.sc_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_user_review_txt.Name = "sc_user_review_txt"
        Me.sc_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.sc_user_review_txt.TabIndex = 25
        '
        'sc_Add_btn
        '
        Me.sc_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.sc_Add_btn.Location = New System.Drawing.Point(961, 698)
        Me.sc_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_Add_btn.Name = "sc_Add_btn"
        Me.sc_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.sc_Add_btn.TabIndex = 26
        Me.sc_Add_btn.Text = "ADD"
        Me.sc_Add_btn.UseVisualStyleBackColor = False
        '
        'sc_user2_review_lbl
        '
        Me.sc_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_user2_review_lbl.Location = New System.Drawing.Point(776, 433)
        Me.sc_user2_review_lbl.Name = "sc_user2_review_lbl"
        Me.sc_user2_review_lbl.Size = New System.Drawing.Size(245, 50)
        Me.sc_user2_review_lbl.TabIndex = 24
        Me.sc_user2_review_lbl.Text = "My favourite movie . Best movie still after 8 years"
        '
        'sc_user2_name_lbl
        '
        Me.sc_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_user2_name_lbl.Location = New System.Drawing.Point(677, 433)
        Me.sc_user2_name_lbl.Name = "sc_user2_name_lbl"
        Me.sc_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.sc_user2_name_lbl.TabIndex = 23
        Me.sc_user2_name_lbl.Text = "User852:"
        Me.sc_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sc_user1_review_lbl
        '
        Me.sc_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_user1_review_lbl.Location = New System.Drawing.Point(772, 495)
        Me.sc_user1_review_lbl.Name = "sc_user1_review_lbl"
        Me.sc_user1_review_lbl.Size = New System.Drawing.Size(245, 110)
        Me.sc_user1_review_lbl.TabIndex = 22
        Me.sc_user1_review_lbl.Text = "This movie is a bit emotional and scary thinking about cactus eating humans. But " &
    "this movie is still great at the ending."
        '
        'sc_user1_lbl
        '
        Me.sc_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_user1_lbl.Location = New System.Drawing.Point(679, 495)
        Me.sc_user1_lbl.Name = "sc_user1_lbl"
        Me.sc_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.sc_user1_lbl.TabIndex = 21
        Me.sc_user1_lbl.Text = "User456 :"
        Me.sc_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sc_reviews_lbl
        '
        Me.sc_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sc_reviews_lbl.Location = New System.Drawing.Point(666, 409)
        Me.sc_reviews_lbl.Name = "sc_reviews_lbl"
        Me.sc_reviews_lbl.Size = New System.Drawing.Size(361, 328)
        Me.sc_reviews_lbl.TabIndex = 20
        '
        'sc_top_review_lbl
        '
        Me.sc_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.sc_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sc_top_review_lbl.Location = New System.Drawing.Point(666, 359)
        Me.sc_top_review_lbl.Name = "sc_top_review_lbl"
        Me.sc_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.sc_top_review_lbl.TabIndex = 19
        Me.sc_top_review_lbl.Text = "Top reviews"
        Me.sc_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sc_next_btn
        '
        Me.sc_next_btn.BackColor = System.Drawing.Color.Brown
        Me.sc_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sc_next_btn.FlatAppearance.BorderSize = 0
        Me.sc_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sc_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sc_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.sc_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_next_btn.Name = "sc_next_btn"
        Me.sc_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.sc_next_btn.TabIndex = 18
        Me.sc_next_btn.Text = "Proceed To Next"
        Me.sc_next_btn.UseVisualStyleBackColor = False
        '
        'sc_cname4
        '
        Me.sc_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_cname4.Location = New System.Drawing.Point(516, 686)
        Me.sc_cname4.Name = "sc_cname4"
        Me.sc_cname4.Size = New System.Drawing.Size(155, 51)
        Me.sc_cname4.TabIndex = 17
        Me.sc_cname4.Text = "Daisuke" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Mariachi)"
        Me.sc_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sc_cname3
        '
        Me.sc_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_cname3.Location = New System.Drawing.Point(357, 686)
        Me.sc_cname3.Name = "sc_cname3"
        Me.sc_cname3.Size = New System.Drawing.Size(143, 51)
        Me.sc_cname3.TabIndex = 16
        Me.sc_cname3.Text = "Narahashi Miki" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Misae)"
        Me.sc_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sc_cname2
        '
        Me.sc_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_cname2.Location = New System.Drawing.Point(191, 686)
        Me.sc_cname2.Name = "sc_cname2"
        Me.sc_cname2.Size = New System.Drawing.Size(127, 51)
        Me.sc_cname2.TabIndex = 15
        Me.sc_cname2.Text = "Keiji Fujiwara" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Hiroshi)"
        Me.sc_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sc_cname1
        '
        Me.sc_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_cname1.Location = New System.Drawing.Point(30, 686)
        Me.sc_cname1.Name = "sc_cname1"
        Me.sc_cname1.Size = New System.Drawing.Size(137, 51)
        Me.sc_cname1.TabIndex = 14
        Me.sc_cname1.Text = "Akiko Yajima" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Shinchan)"
        Me.sc_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sc_cast_img3
        '
        Me.sc_cast_img3.ErrorImage = Nothing
        Me.sc_cast_img3.Image = CType(resources.GetObject("sc_cast_img3.Image"), System.Drawing.Image)
        Me.sc_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.sc_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_cast_img3.Name = "sc_cast_img3"
        Me.sc_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.sc_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sc_cast_img3.TabIndex = 13
        Me.sc_cast_img3.TabStop = False
        '
        'sc_cast_img2
        '
        Me.sc_cast_img2.Image = CType(resources.GetObject("sc_cast_img2.Image"), System.Drawing.Image)
        Me.sc_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.sc_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_cast_img2.Name = "sc_cast_img2"
        Me.sc_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.sc_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sc_cast_img2.TabIndex = 12
        Me.sc_cast_img2.TabStop = False
        '
        'sc_cast_img4
        '
        Me.sc_cast_img4.Image = CType(resources.GetObject("sc_cast_img4.Image"), System.Drawing.Image)
        Me.sc_cast_img4.Location = New System.Drawing.Point(521, 560)
        Me.sc_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_cast_img4.Name = "sc_cast_img4"
        Me.sc_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.sc_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sc_cast_img4.TabIndex = 11
        Me.sc_cast_img4.TabStop = False
        '
        'sc_cast_img1
        '
        Me.sc_cast_img1.Image = CType(resources.GetObject("sc_cast_img1.Image"), System.Drawing.Image)
        Me.sc_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.sc_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_cast_img1.Name = "sc_cast_img1"
        Me.sc_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.sc_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sc_cast_img1.TabIndex = 10
        Me.sc_cast_img1.TabStop = False
        '
        'sc_cast_lbl
        '
        Me.sc_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.sc_cast_lbl.Name = "sc_cast_lbl"
        Me.sc_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.sc_cast_lbl.TabIndex = 9
        Me.sc_cast_lbl.Text = "Cast"
        Me.sc_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sc_desc
        '
        Me.sc_desc.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_desc.Location = New System.Drawing.Point(6, 420)
        Me.sc_desc.Name = "sc_desc"
        Me.sc_desc.Size = New System.Drawing.Size(670, 108)
        Me.sc_desc.TabIndex = 8
        Me.sc_desc.Text = "Animation, Action, Adventure;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is the story of the transfer of shinchan's fa" &
    "mily to mexico where they unintentionaly unravel the secret of some mysterious c" &
    "actus"
        '
        'sc_dur_time_lbl
        '
        Me.sc_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.sc_dur_time_lbl.Name = "sc_dur_time_lbl"
        Me.sc_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.sc_dur_time_lbl.TabIndex = 7
        Me.sc_dur_time_lbl.Text = "1h 56m"
        '
        'sc_rating_val_lbl
        '
        Me.sc_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.sc_rating_val_lbl.Name = "sc_rating_val_lbl"
        Me.sc_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.sc_rating_val_lbl.TabIndex = 6
        Me.sc_rating_val_lbl.Text = "8.3/10"
        '
        'sc_star_pt_box
        '
        Me.sc_star_pt_box.Image = CType(resources.GetObject("sc_star_pt_box.Image"), System.Drawing.Image)
        Me.sc_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.sc_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_star_pt_box.Name = "sc_star_pt_box"
        Me.sc_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.sc_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sc_star_pt_box.TabIndex = 5
        Me.sc_star_pt_box.TabStop = False
        '
        'sc_dur_lbl
        '
        Me.sc_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.sc_dur_lbl.Name = "sc_dur_lbl"
        Me.sc_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.sc_dur_lbl.TabIndex = 4
        Me.sc_dur_lbl.Text = "Duration  :"
        Me.sc_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sc_Rating_lbl
        '
        Me.sc_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.sc_Rating_lbl.Name = "sc_Rating_lbl"
        Me.sc_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.sc_Rating_lbl.TabIndex = 3
        Me.sc_Rating_lbl.Text = "Ratings     :"
        Me.sc_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trailer_bg_lbl
        '
        Me.trailer_bg_lbl.BackColor = System.Drawing.Color.DimGray
        Me.trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.trailer_bg_lbl.Name = "trailer_bg_lbl"
        Me.trailer_bg_lbl.Size = New System.Drawing.Size(1037, 245)
        Me.trailer_bg_lbl.TabIndex = 1
        Me.trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sc_moviename_lbl
        '
        Me.sc_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.sc_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.sc_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.sc_moviename_lbl.Name = "sc_moviename_lbl"
        Me.sc_moviename_lbl.Size = New System.Drawing.Size(1037, 50)
        Me.sc_moviename_lbl.TabIndex = 0
        Me.sc_moviename_lbl.Text = "Shinchan : Mexico Cactus"
        Me.sc_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shinchan_format_pnl
        '
        Me.shinchan_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.shinchan_format_pnl.Controls.Add(Me.sc_format_nxt_btn)
        Me.shinchan_format_pnl.Controls.Add(Me.sc_btn_3d)
        Me.shinchan_format_pnl.Controls.Add(Me.sc_btn_2d)
        Me.shinchan_format_pnl.Controls.Add(Me.sc_select_format_lbl)
        Me.shinchan_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.shinchan_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.shinchan_format_pnl.Name = "shinchan_format_pnl"
        Me.shinchan_format_pnl.Size = New System.Drawing.Size(1043, 151)
        Me.shinchan_format_pnl.TabIndex = 2
        Me.shinchan_format_pnl.Visible = False
        '
        'sc_format_nxt_btn
        '
        Me.sc_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.sc_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sc_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.sc_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sc_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sc_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.sc_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_format_nxt_btn.Name = "sc_format_nxt_btn"
        Me.sc_format_nxt_btn.Size = New System.Drawing.Size(1043, 60)
        Me.sc_format_nxt_btn.TabIndex = 19
        Me.sc_format_nxt_btn.Text = "Continue"
        Me.sc_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'sc_btn_3d
        '
        Me.sc_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.sc_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_btn_3d.Name = "sc_btn_3d"
        Me.sc_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.sc_btn_3d.TabIndex = 7
        Me.sc_btn_3d.TabStop = True
        Me.sc_btn_3d.Text = "3D"
        Me.sc_btn_3d.UseVisualStyleBackColor = True
        '
        'sc_btn_2d
        '
        Me.sc_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_btn_2d.Location = New System.Drawing.Point(252, 19)
        Me.sc_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sc_btn_2d.Name = "sc_btn_2d"
        Me.sc_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.sc_btn_2d.TabIndex = 6
        Me.sc_btn_2d.TabStop = True
        Me.sc_btn_2d.Text = "2D"
        Me.sc_btn_2d.UseVisualStyleBackColor = True
        '
        'sc_select_format_lbl
        '
        Me.sc_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.sc_select_format_lbl.Name = "sc_select_format_lbl"
        Me.sc_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.sc_select_format_lbl.TabIndex = 5
        Me.sc_select_format_lbl.Text = "Select Movie Format :"
        Me.sc_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Shinchan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.shinchan_format_pnl)
        Me.Controls.Add(Me.shinchan_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Shinchan"
        Me.Text = "Shinchan"
        Me.shinchan_panel.ResumeLayout(False)
        Me.shinchan_panel.PerformLayout()
        Me.sc_vid_pnl.ResumeLayout(False)
        CType(Me.sc_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sc_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sc_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sc_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sc_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sc_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.shinchan_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents shinchan_panel As Panel
    Friend WithEvents sc_vid_pnl As Panel
    Friend WithEvents sc_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents sc_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents sc_username_lbl As Label
    Friend WithEvents sc_user_review_output As Label
    Friend WithEvents sc_add_review_lbl As Label
    Friend WithEvents sc_user_review_txt As TextBox
    Friend WithEvents sc_Add_btn As Button
    Friend WithEvents sc_user2_review_lbl As Label
    Friend WithEvents sc_user2_name_lbl As Label
    Friend WithEvents sc_user1_review_lbl As Label
    Friend WithEvents sc_user1_lbl As Label
    Friend WithEvents sc_reviews_lbl As Label
    Friend WithEvents sc_top_review_lbl As Label
    Friend WithEvents sc_next_btn As Button
    Friend WithEvents sc_cname4 As Label
    Friend WithEvents sc_cname3 As Label
    Friend WithEvents sc_cname2 As Label
    Friend WithEvents sc_cname1 As Label
    Friend WithEvents sc_cast_img3 As PictureBox
    Friend WithEvents sc_cast_img2 As PictureBox
    Friend WithEvents sc_cast_img4 As PictureBox
    Friend WithEvents sc_cast_img1 As PictureBox
    Friend WithEvents sc_cast_lbl As Label
    Friend WithEvents sc_desc As Label
    Friend WithEvents sc_dur_time_lbl As Label
    Friend WithEvents sc_rating_val_lbl As Label
    Friend WithEvents sc_star_pt_box As PictureBox
    Friend WithEvents sc_dur_lbl As Label
    Friend WithEvents sc_Rating_lbl As Label
    Friend WithEvents trailer_bg_lbl As Label
    Friend WithEvents sc_moviename_lbl As Label
    Friend WithEvents shinchan_format_pnl As Panel
    Friend WithEvents sc_format_nxt_btn As Button
    Friend WithEvents sc_btn_3d As RadioButton
    Friend WithEvents sc_btn_2d As RadioButton
    Friend WithEvents sc_select_format_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
