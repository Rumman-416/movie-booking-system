<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Radhe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Radhe))
        Me.radhe_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.rd_vid_pnl = New System.Windows.Forms.Panel()
        Me.rd_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.rd_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.rd_username_lbl = New System.Windows.Forms.Label()
        Me.rd_user_review_output = New System.Windows.Forms.Label()
        Me.rd_add_review_lbl = New System.Windows.Forms.Label()
        Me.rd_user_review_txt = New System.Windows.Forms.TextBox()
        Me.rd_Add_btn = New System.Windows.Forms.Button()
        Me.rd_user2_review_lbl = New System.Windows.Forms.Label()
        Me.rd_user2_name_lbl = New System.Windows.Forms.Label()
        Me.rd_user1_review_lbl = New System.Windows.Forms.Label()
        Me.rd_user1_lbl = New System.Windows.Forms.Label()
        Me.rd_reviews_lbl = New System.Windows.Forms.Label()
        Me.rd_top_review_lbl = New System.Windows.Forms.Label()
        Me.rd_next_btn = New System.Windows.Forms.Button()
        Me.rd_cname4 = New System.Windows.Forms.Label()
        Me.rd_cname3 = New System.Windows.Forms.Label()
        Me.rd_cname2 = New System.Windows.Forms.Label()
        Me.rd_cname1 = New System.Windows.Forms.Label()
        Me.rd_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.rd_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.rd_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.rd_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.rd_cast_lbl = New System.Windows.Forms.Label()
        Me.rd_desc = New System.Windows.Forms.Label()
        Me.rd_dur_time_lbl = New System.Windows.Forms.Label()
        Me.rd_rating_val_lbl = New System.Windows.Forms.Label()
        Me.rd_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.rd_dur_lbl = New System.Windows.Forms.Label()
        Me.rd_Rating_lbl = New System.Windows.Forms.Label()
        Me.rd_trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.rd_moviename_lbl = New System.Windows.Forms.Label()
        Me.radhe_format_pnl = New System.Windows.Forms.Panel()
        Me.rd_format_nxt_btn = New System.Windows.Forms.Button()
        Me.rd_btn_3d = New System.Windows.Forms.RadioButton()
        Me.rd_btn_2d = New System.Windows.Forms.RadioButton()
        Me.rd_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.radhe_panel.SuspendLayout()
        Me.rd_vid_pnl.SuspendLayout()
        CType(Me.rd_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rd_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radhe_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radhe_panel
        '
        Me.radhe_panel.BackColor = System.Drawing.Color.Snow
        Me.radhe_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.radhe_panel.Controls.Add(Me.BackButton)
        Me.radhe_panel.Controls.Add(Me.rd_vid_pnl)
        Me.radhe_panel.Controls.Add(Me.rd_username_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_user_review_output)
        Me.radhe_panel.Controls.Add(Me.rd_add_review_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_user_review_txt)
        Me.radhe_panel.Controls.Add(Me.rd_Add_btn)
        Me.radhe_panel.Controls.Add(Me.rd_user2_review_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_user2_name_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_user1_review_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_user1_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_reviews_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_top_review_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_next_btn)
        Me.radhe_panel.Controls.Add(Me.rd_cname4)
        Me.radhe_panel.Controls.Add(Me.rd_cname3)
        Me.radhe_panel.Controls.Add(Me.rd_cname2)
        Me.radhe_panel.Controls.Add(Me.rd_cname1)
        Me.radhe_panel.Controls.Add(Me.rd_cast_img3)
        Me.radhe_panel.Controls.Add(Me.rd_cast_img2)
        Me.radhe_panel.Controls.Add(Me.rd_cast_img4)
        Me.radhe_panel.Controls.Add(Me.rd_cast_img1)
        Me.radhe_panel.Controls.Add(Me.rd_cast_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_desc)
        Me.radhe_panel.Controls.Add(Me.rd_dur_time_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_rating_val_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_star_pt_box)
        Me.radhe_panel.Controls.Add(Me.rd_dur_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_Rating_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_trailer_bg_lbl)
        Me.radhe_panel.Controls.Add(Me.rd_moviename_lbl)
        Me.radhe_panel.Location = New System.Drawing.Point(0, 39)
        Me.radhe_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radhe_panel.Name = "radhe_panel"
        Me.radhe_panel.Size = New System.Drawing.Size(1043, 821)
        Me.radhe_panel.TabIndex = 3
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
        'rd_vid_pnl
        '
        Me.rd_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rd_vid_pnl.Controls.Add(Me.rd_ply_btn)
        Me.rd_vid_pnl.Controls.Add(Me.play_btn)
        Me.rd_vid_pnl.Controls.Add(Me.rd_vid_sc)
        Me.rd_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.rd_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_vid_pnl.Name = "rd_vid_pnl"
        Me.rd_vid_pnl.Size = New System.Drawing.Size(1040, 245)
        Me.rd_vid_pnl.TabIndex = 30
        '
        'rd_ply_btn
        '
        Me.rd_ply_btn.BackgroundImage = CType(resources.GetObject("rd_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.rd_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rd_ply_btn.Location = New System.Drawing.Point(482, 63)
        Me.rd_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_ply_btn.Name = "rd_ply_btn"
        Me.rd_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.rd_ply_btn.TabIndex = 2
        Me.rd_ply_btn.UseVisualStyleBackColor = True
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
        'rd_vid_sc
        '
        Me.rd_vid_sc.Enabled = True
        Me.rd_vid_sc.Location = New System.Drawing.Point(235, -7)
        Me.rd_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_vid_sc.Name = "rd_vid_sc"
        Me.rd_vid_sc.OcxState = CType(resources.GetObject("rd_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.rd_vid_sc.Size = New System.Drawing.Size(587, 299)
        Me.rd_vid_sc.TabIndex = 0
        '
        'rd_username_lbl
        '
        Me.rd_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_username_lbl.Location = New System.Drawing.Point(680, 616)
        Me.rd_username_lbl.Name = "rd_username_lbl"
        Me.rd_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.rd_username_lbl.TabIndex = 29
        Me.rd_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_user_review_output
        '
        Me.rd_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_user_review_output.Location = New System.Drawing.Point(773, 616)
        Me.rd_user_review_output.Name = "rd_user_review_output"
        Me.rd_user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.rd_user_review_output.TabIndex = 28
        '
        'rd_add_review_lbl
        '
        Me.rd_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.rd_add_review_lbl.Location = New System.Drawing.Point(691, 676)
        Me.rd_add_review_lbl.Name = "rd_add_review_lbl"
        Me.rd_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.rd_add_review_lbl.TabIndex = 27
        Me.rd_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'rd_user_review_txt
        '
        Me.rd_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rd_user_review_txt.Location = New System.Drawing.Point(688, 709)
        Me.rd_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_user_review_txt.Name = "rd_user_review_txt"
        Me.rd_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.rd_user_review_txt.TabIndex = 25
        '
        'rd_Add_btn
        '
        Me.rd_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.rd_Add_btn.Location = New System.Drawing.Point(962, 709)
        Me.rd_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_Add_btn.Name = "rd_Add_btn"
        Me.rd_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.rd_Add_btn.TabIndex = 26
        Me.rd_Add_btn.Text = "ADD"
        Me.rd_Add_btn.UseVisualStyleBackColor = False
        '
        'rd_user2_review_lbl
        '
        Me.rd_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_user2_review_lbl.Location = New System.Drawing.Point(777, 444)
        Me.rd_user2_review_lbl.Name = "rd_user2_review_lbl"
        Me.rd_user2_review_lbl.Size = New System.Drawing.Size(245, 71)
        Me.rd_user2_review_lbl.TabIndex = 24
        Me.rd_user2_review_lbl.Text = "Soo.... Funny that I even Forget To laugh LMAO..... ><"
        '
        'rd_user2_name_lbl
        '
        Me.rd_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_user2_name_lbl.Location = New System.Drawing.Point(678, 444)
        Me.rd_user2_name_lbl.Name = "rd_user2_name_lbl"
        Me.rd_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.rd_user2_name_lbl.TabIndex = 23
        Me.rd_user2_name_lbl.Text = "User715 :"
        Me.rd_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_user1_review_lbl
        '
        Me.rd_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_user1_review_lbl.Location = New System.Drawing.Point(773, 528)
        Me.rd_user1_review_lbl.Name = "rd_user1_review_lbl"
        Me.rd_user1_review_lbl.Size = New System.Drawing.Size(245, 89)
        Me.rd_user1_review_lbl.TabIndex = 22
        Me.rd_user1_review_lbl.Text = "As expected bakwas movie. Bad movie. Bekar ending. Farzi looking action."
        '
        'rd_user1_lbl
        '
        Me.rd_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_user1_lbl.Location = New System.Drawing.Point(680, 528)
        Me.rd_user1_lbl.Name = "rd_user1_lbl"
        Me.rd_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.rd_user1_lbl.TabIndex = 21
        Me.rd_user1_lbl.Text = "User420 :"
        Me.rd_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_reviews_lbl
        '
        Me.rd_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rd_reviews_lbl.Location = New System.Drawing.Point(667, 420)
        Me.rd_reviews_lbl.Name = "rd_reviews_lbl"
        Me.rd_reviews_lbl.Size = New System.Drawing.Size(361, 328)
        Me.rd_reviews_lbl.TabIndex = 20
        '
        'rd_top_review_lbl
        '
        Me.rd_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.rd_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rd_top_review_lbl.Location = New System.Drawing.Point(667, 370)
        Me.rd_top_review_lbl.Name = "rd_top_review_lbl"
        Me.rd_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.rd_top_review_lbl.TabIndex = 19
        Me.rd_top_review_lbl.Text = "Top reviews"
        Me.rd_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_next_btn
        '
        Me.rd_next_btn.BackColor = System.Drawing.Color.Brown
        Me.rd_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rd_next_btn.FlatAppearance.BorderSize = 0
        Me.rd_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rd_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.rd_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_next_btn.Name = "rd_next_btn"
        Me.rd_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.rd_next_btn.TabIndex = 18
        Me.rd_next_btn.Text = "Proceed To Next"
        Me.rd_next_btn.UseVisualStyleBackColor = False
        '
        'rd_cname4
        '
        Me.rd_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cname4.Location = New System.Drawing.Point(507, 686)
        Me.rd_cname4.Name = "rd_cname4"
        Me.rd_cname4.Size = New System.Drawing.Size(170, 51)
        Me.rd_cname4.TabIndex = 17
        Me.rd_cname4.Text = "Megha Akash" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Nikisha)"
        Me.rd_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rd_cname3
        '
        Me.rd_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cname3.Location = New System.Drawing.Point(357, 686)
        Me.rd_cname3.Name = "rd_cname3"
        Me.rd_cname3.Size = New System.Drawing.Size(144, 51)
        Me.rd_cname3.TabIndex = 16
        Me.rd_cname3.Text = "Randeep Hooda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Rana)"
        Me.rd_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rd_cname2
        '
        Me.rd_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cname2.Location = New System.Drawing.Point(191, 686)
        Me.rd_cname2.Name = "rd_cname2"
        Me.rd_cname2.Size = New System.Drawing.Size(127, 51)
        Me.rd_cname2.TabIndex = 15
        Me.rd_cname2.Text = "Disha Patani" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Diya)"
        Me.rd_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rd_cname1
        '
        Me.rd_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cname1.Location = New System.Drawing.Point(32, 686)
        Me.rd_cname1.Name = "rd_cname1"
        Me.rd_cname1.Size = New System.Drawing.Size(136, 51)
        Me.rd_cname1.TabIndex = 14
        Me.rd_cname1.Text = "Salman Khan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Radhe)"
        Me.rd_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rd_cast_img3
        '
        Me.rd_cast_img3.Image = CType(resources.GetObject("rd_cast_img3.Image"), System.Drawing.Image)
        Me.rd_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.rd_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_cast_img3.Name = "rd_cast_img3"
        Me.rd_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.rd_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rd_cast_img3.TabIndex = 13
        Me.rd_cast_img3.TabStop = False
        '
        'rd_cast_img2
        '
        Me.rd_cast_img2.Image = CType(resources.GetObject("rd_cast_img2.Image"), System.Drawing.Image)
        Me.rd_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.rd_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_cast_img2.Name = "rd_cast_img2"
        Me.rd_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.rd_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rd_cast_img2.TabIndex = 12
        Me.rd_cast_img2.TabStop = False
        '
        'rd_cast_img4
        '
        Me.rd_cast_img4.Image = CType(resources.GetObject("rd_cast_img4.Image"), System.Drawing.Image)
        Me.rd_cast_img4.Location = New System.Drawing.Point(522, 560)
        Me.rd_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_cast_img4.Name = "rd_cast_img4"
        Me.rd_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.rd_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rd_cast_img4.TabIndex = 11
        Me.rd_cast_img4.TabStop = False
        '
        'rd_cast_img1
        '
        Me.rd_cast_img1.Image = CType(resources.GetObject("rd_cast_img1.Image"), System.Drawing.Image)
        Me.rd_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.rd_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_cast_img1.Name = "rd_cast_img1"
        Me.rd_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.rd_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rd_cast_img1.TabIndex = 10
        Me.rd_cast_img1.TabStop = False
        '
        'rd_cast_lbl
        '
        Me.rd_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.rd_cast_lbl.Name = "rd_cast_lbl"
        Me.rd_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.rd_cast_lbl.TabIndex = 9
        Me.rd_cast_lbl.Text = "Cast"
        Me.rd_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_desc
        '
        Me.rd_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_desc.Location = New System.Drawing.Point(10, 420)
        Me.rd_desc.Name = "rd_desc"
        Me.rd_desc.Size = New System.Drawing.Size(648, 114)
        Me.rd_desc.TabIndex = 8
        Me.rd_desc.Text = "Comedy, Action, Crime;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "After taking the dreaded gangster Gani Bhai, ACP Rajveer " &
    "Shikawat aka Radhe goes on a manhunt to find the wealthiest man of the town secr" &
    "etly running a crime syndicate."
        '
        'rd_dur_time_lbl
        '
        Me.rd_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.rd_dur_time_lbl.Name = "rd_dur_time_lbl"
        Me.rd_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.rd_dur_time_lbl.TabIndex = 7
        Me.rd_dur_time_lbl.Text = "1h 55m"
        '
        'rd_rating_val_lbl
        '
        Me.rd_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.rd_rating_val_lbl.Name = "rd_rating_val_lbl"
        Me.rd_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.rd_rating_val_lbl.TabIndex = 6
        Me.rd_rating_val_lbl.Text = "6.5/10"
        '
        'rd_star_pt_box
        '
        Me.rd_star_pt_box.Image = CType(resources.GetObject("rd_star_pt_box.Image"), System.Drawing.Image)
        Me.rd_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.rd_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_star_pt_box.Name = "rd_star_pt_box"
        Me.rd_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.rd_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rd_star_pt_box.TabIndex = 5
        Me.rd_star_pt_box.TabStop = False
        '
        'rd_dur_lbl
        '
        Me.rd_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.rd_dur_lbl.Name = "rd_dur_lbl"
        Me.rd_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.rd_dur_lbl.TabIndex = 4
        Me.rd_dur_lbl.Text = "Duration  :"
        Me.rd_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_Rating_lbl
        '
        Me.rd_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.rd_Rating_lbl.Name = "rd_Rating_lbl"
        Me.rd_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.rd_Rating_lbl.TabIndex = 3
        Me.rd_Rating_lbl.Text = "Ratings     :"
        Me.rd_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rd_trailer_bg_lbl
        '
        Me.rd_trailer_bg_lbl.BackColor = System.Drawing.Color.DimGray
        Me.rd_trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.rd_trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.rd_trailer_bg_lbl.Name = "rd_trailer_bg_lbl"
        Me.rd_trailer_bg_lbl.Size = New System.Drawing.Size(1040, 245)
        Me.rd_trailer_bg_lbl.TabIndex = 1
        Me.rd_trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rd_moviename_lbl
        '
        Me.rd_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.rd_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.rd_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.rd_moviename_lbl.Name = "rd_moviename_lbl"
        Me.rd_moviename_lbl.Size = New System.Drawing.Size(1040, 50)
        Me.rd_moviename_lbl.TabIndex = 0
        Me.rd_moviename_lbl.Text = "RADHE"
        Me.rd_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radhe_format_pnl
        '
        Me.radhe_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.radhe_format_pnl.Controls.Add(Me.rd_format_nxt_btn)
        Me.radhe_format_pnl.Controls.Add(Me.rd_btn_3d)
        Me.radhe_format_pnl.Controls.Add(Me.rd_btn_2d)
        Me.radhe_format_pnl.Controls.Add(Me.rd_select_format_lbl)
        Me.radhe_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.radhe_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radhe_format_pnl.Name = "radhe_format_pnl"
        Me.radhe_format_pnl.Size = New System.Drawing.Size(1043, 151)
        Me.radhe_format_pnl.TabIndex = 4
        Me.radhe_format_pnl.Visible = False
        '
        'rd_format_nxt_btn
        '
        Me.rd_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.rd_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rd_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.rd_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rd_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rd_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.rd_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_format_nxt_btn.Name = "rd_format_nxt_btn"
        Me.rd_format_nxt_btn.Size = New System.Drawing.Size(1043, 60)
        Me.rd_format_nxt_btn.TabIndex = 19
        Me.rd_format_nxt_btn.Text = "Continue"
        Me.rd_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'rd_btn_3d
        '
        Me.rd_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.rd_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_btn_3d.Name = "rd_btn_3d"
        Me.rd_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.rd_btn_3d.TabIndex = 7
        Me.rd_btn_3d.TabStop = True
        Me.rd_btn_3d.Text = "3D"
        Me.rd_btn_3d.UseVisualStyleBackColor = True
        '
        'rd_btn_2d
        '
        Me.rd_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_btn_2d.Location = New System.Drawing.Point(252, 19)
        Me.rd_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rd_btn_2d.Name = "rd_btn_2d"
        Me.rd_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.rd_btn_2d.TabIndex = 6
        Me.rd_btn_2d.TabStop = True
        Me.rd_btn_2d.Text = "2D"
        Me.rd_btn_2d.UseVisualStyleBackColor = True
        '
        'rd_select_format_lbl
        '
        Me.rd_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.rd_select_format_lbl.Name = "rd_select_format_lbl"
        Me.rd_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.rd_select_format_lbl.TabIndex = 5
        Me.rd_select_format_lbl.Text = "Select Movie Format :"
        Me.rd_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 5
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
        'Radhe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.radhe_format_pnl)
        Me.Controls.Add(Me.radhe_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Radhe"
        Me.Text = "Radhe"
        Me.radhe_panel.ResumeLayout(False)
        Me.radhe_panel.PerformLayout()
        Me.rd_vid_pnl.ResumeLayout(False)
        CType(Me.rd_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rd_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radhe_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radhe_panel As Panel
    Friend WithEvents rd_vid_pnl As Panel
    Friend WithEvents rd_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents rd_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents rd_username_lbl As Label
    Friend WithEvents rd_user_review_output As Label
    Friend WithEvents rd_add_review_lbl As Label
    Friend WithEvents rd_user_review_txt As TextBox
    Friend WithEvents rd_Add_btn As Button
    Friend WithEvents rd_user2_review_lbl As Label
    Friend WithEvents rd_user2_name_lbl As Label
    Friend WithEvents rd_user1_review_lbl As Label
    Friend WithEvents rd_user1_lbl As Label
    Friend WithEvents rd_reviews_lbl As Label
    Friend WithEvents rd_top_review_lbl As Label
    Friend WithEvents rd_next_btn As Button
    Friend WithEvents rd_cname4 As Label
    Friend WithEvents rd_cname3 As Label
    Friend WithEvents rd_cname2 As Label
    Friend WithEvents rd_cname1 As Label
    Friend WithEvents rd_cast_img3 As PictureBox
    Friend WithEvents rd_cast_img2 As PictureBox
    Friend WithEvents rd_cast_img4 As PictureBox
    Friend WithEvents rd_cast_img1 As PictureBox
    Friend WithEvents rd_cast_lbl As Label
    Friend WithEvents rd_desc As Label
    Friend WithEvents rd_dur_time_lbl As Label
    Friend WithEvents rd_rating_val_lbl As Label
    Friend WithEvents rd_star_pt_box As PictureBox
    Friend WithEvents rd_dur_lbl As Label
    Friend WithEvents rd_Rating_lbl As Label
    Friend WithEvents rd_trailer_bg_lbl As Label
    Friend WithEvents rd_moviename_lbl As Label
    Friend WithEvents radhe_format_pnl As Panel
    Friend WithEvents rd_format_nxt_btn As Button
    Friend WithEvents rd_btn_3d As RadioButton
    Friend WithEvents rd_btn_2d As RadioButton
    Friend WithEvents rd_select_format_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
