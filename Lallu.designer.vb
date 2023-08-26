<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lallu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lallu))
        Me.lallu_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ll_vid_pnl = New System.Windows.Forms.Panel()
        Me.ll_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.ll_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ll_username_lbl = New System.Windows.Forms.Label()
        Me.ll_user_review_output = New System.Windows.Forms.Label()
        Me.ll_add_review_lbl = New System.Windows.Forms.Label()
        Me.ll_user_review_txt = New System.Windows.Forms.TextBox()
        Me.ll_Add_btn = New System.Windows.Forms.Button()
        Me.ll_user2_review_lbl = New System.Windows.Forms.Label()
        Me.ll_user2_name_lbl = New System.Windows.Forms.Label()
        Me.ll_user1_review_lbl = New System.Windows.Forms.Label()
        Me.ll_user1_lbl = New System.Windows.Forms.Label()
        Me.ll_reviews_lbl = New System.Windows.Forms.Label()
        Me.ll_top_review_lbl = New System.Windows.Forms.Label()
        Me.ll_next_btn = New System.Windows.Forms.Button()
        Me.ll_cname4 = New System.Windows.Forms.Label()
        Me.ll_cname3 = New System.Windows.Forms.Label()
        Me.ll_cname2 = New System.Windows.Forms.Label()
        Me.ll_cname1 = New System.Windows.Forms.Label()
        Me.ll_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.ll_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.ll_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.ll_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.ll_cast_lbl = New System.Windows.Forms.Label()
        Me.ll_desc = New System.Windows.Forms.Label()
        Me.ll_dur_time_lbl = New System.Windows.Forms.Label()
        Me.ll_rating_val_lbl = New System.Windows.Forms.Label()
        Me.ll_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.ll_dur_lbl = New System.Windows.Forms.Label()
        Me.ll_Rating_lbl = New System.Windows.Forms.Label()
        Me.trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.ll_moviename_lbl = New System.Windows.Forms.Label()
        Me.lallu_format_pnl = New System.Windows.Forms.Panel()
        Me.ll_format_nxt_btn = New System.Windows.Forms.Button()
        Me.ll_btn_3d = New System.Windows.Forms.RadioButton()
        Me.ll_btn_2d = New System.Windows.Forms.RadioButton()
        Me.II_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.lallu_panel.SuspendLayout()
        Me.ll_vid_pnl.SuspendLayout()
        CType(Me.ll_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ll_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ll_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ll_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ll_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ll_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lallu_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lallu_panel
        '
        Me.lallu_panel.BackColor = System.Drawing.Color.Snow
        Me.lallu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lallu_panel.Controls.Add(Me.BackButton)
        Me.lallu_panel.Controls.Add(Me.ll_vid_pnl)
        Me.lallu_panel.Controls.Add(Me.ll_username_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_user_review_output)
        Me.lallu_panel.Controls.Add(Me.ll_add_review_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_user_review_txt)
        Me.lallu_panel.Controls.Add(Me.ll_Add_btn)
        Me.lallu_panel.Controls.Add(Me.ll_user2_review_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_user2_name_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_user1_review_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_user1_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_reviews_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_top_review_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_next_btn)
        Me.lallu_panel.Controls.Add(Me.ll_cname4)
        Me.lallu_panel.Controls.Add(Me.ll_cname3)
        Me.lallu_panel.Controls.Add(Me.ll_cname2)
        Me.lallu_panel.Controls.Add(Me.ll_cname1)
        Me.lallu_panel.Controls.Add(Me.ll_cast_img3)
        Me.lallu_panel.Controls.Add(Me.ll_cast_img2)
        Me.lallu_panel.Controls.Add(Me.ll_cast_img4)
        Me.lallu_panel.Controls.Add(Me.ll_cast_img1)
        Me.lallu_panel.Controls.Add(Me.ll_cast_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_desc)
        Me.lallu_panel.Controls.Add(Me.ll_dur_time_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_rating_val_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_star_pt_box)
        Me.lallu_panel.Controls.Add(Me.ll_dur_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_Rating_lbl)
        Me.lallu_panel.Controls.Add(Me.trailer_bg_lbl)
        Me.lallu_panel.Controls.Add(Me.ll_moviename_lbl)
        Me.lallu_panel.Location = New System.Drawing.Point(0, 39)
        Me.lallu_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lallu_panel.Name = "lallu_panel"
        Me.lallu_panel.Size = New System.Drawing.Size(1040, 821)
        Me.lallu_panel.TabIndex = 1
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(3, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(104, 53)
        Me.BackButton.TabIndex = 32
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'll_vid_pnl
        '
        Me.ll_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ll_vid_pnl.Controls.Add(Me.ll_ply_btn)
        Me.ll_vid_pnl.Controls.Add(Me.play_btn)
        Me.ll_vid_pnl.Controls.Add(Me.ll_vid_sc)
        Me.ll_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.ll_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_vid_pnl.Name = "ll_vid_pnl"
        Me.ll_vid_pnl.Size = New System.Drawing.Size(1037, 245)
        Me.ll_vid_pnl.TabIndex = 30
        '
        'll_ply_btn
        '
        Me.ll_ply_btn.BackgroundImage = CType(resources.GetObject("ll_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.ll_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ll_ply_btn.Location = New System.Drawing.Point(475, 73)
        Me.ll_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_ply_btn.Name = "ll_ply_btn"
        Me.ll_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.ll_ply_btn.TabIndex = 2
        Me.ll_ply_btn.UseVisualStyleBackColor = True
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
        'll_vid_sc
        '
        Me.ll_vid_sc.Enabled = True
        Me.ll_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.ll_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_vid_sc.Name = "ll_vid_sc"
        Me.ll_vid_sc.OcxState = CType(resources.GetObject("ll_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ll_vid_sc.Size = New System.Drawing.Size(596, 297)
        Me.ll_vid_sc.TabIndex = 0
        '
        'll_username_lbl
        '
        Me.ll_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_username_lbl.Location = New System.Drawing.Point(664, 605)
        Me.ll_username_lbl.Name = "ll_username_lbl"
        Me.ll_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.ll_username_lbl.TabIndex = 29
        Me.ll_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'll_user_review_output
        '
        Me.ll_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_user_review_output.Location = New System.Drawing.Point(757, 605)
        Me.ll_user_review_output.Name = "ll_user_review_output"
        Me.ll_user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.ll_user_review_output.TabIndex = 28
        '
        'll_add_review_lbl
        '
        Me.ll_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ll_add_review_lbl.Location = New System.Drawing.Point(675, 665)
        Me.ll_add_review_lbl.Name = "ll_add_review_lbl"
        Me.ll_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.ll_add_review_lbl.TabIndex = 27
        Me.ll_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'll_user_review_txt
        '
        Me.ll_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ll_user_review_txt.Location = New System.Drawing.Point(672, 698)
        Me.ll_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_user_review_txt.Name = "ll_user_review_txt"
        Me.ll_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.ll_user_review_txt.TabIndex = 25
        '
        'll_Add_btn
        '
        Me.ll_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.ll_Add_btn.Location = New System.Drawing.Point(946, 698)
        Me.ll_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_Add_btn.Name = "ll_Add_btn"
        Me.ll_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.ll_Add_btn.TabIndex = 26
        Me.ll_Add_btn.Text = "ADD"
        Me.ll_Add_btn.UseVisualStyleBackColor = False
        '
        'll_user2_review_lbl
        '
        Me.ll_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_user2_review_lbl.Location = New System.Drawing.Point(761, 433)
        Me.ll_user2_review_lbl.Name = "ll_user2_review_lbl"
        Me.ll_user2_review_lbl.Size = New System.Drawing.Size(245, 71)
        Me.ll_user2_review_lbl.TabIndex = 24
        Me.ll_user2_review_lbl.Text = "YAMINI SINGH IS A REALLY GORGEOUS ACTOR. LOVE YOU YAMINI"
        '
        'll_user2_name_lbl
        '
        Me.ll_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_user2_name_lbl.Location = New System.Drawing.Point(662, 433)
        Me.ll_user2_name_lbl.Name = "ll_user2_name_lbl"
        Me.ll_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.ll_user2_name_lbl.TabIndex = 23
        Me.ll_user2_name_lbl.Text = "User122 :"
        Me.ll_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'll_user1_review_lbl
        '
        Me.ll_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_user1_review_lbl.Location = New System.Drawing.Point(757, 517)
        Me.ll_user1_review_lbl.Name = "ll_user1_review_lbl"
        Me.ll_user1_review_lbl.Size = New System.Drawing.Size(245, 89)
        Me.ll_user1_review_lbl.TabIndex = 22
        Me.ll_user1_review_lbl.Text = "Kisine sach kaha tha sacha pyaar hamesha adhura reh jata hai"
        '
        'll_user1_lbl
        '
        Me.ll_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_user1_lbl.Location = New System.Drawing.Point(664, 517)
        Me.ll_user1_lbl.Name = "ll_user1_lbl"
        Me.ll_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.ll_user1_lbl.TabIndex = 21
        Me.ll_user1_lbl.Text = "User844 :"
        Me.ll_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'll_reviews_lbl
        '
        Me.ll_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ll_reviews_lbl.Location = New System.Drawing.Point(651, 409)
        Me.ll_reviews_lbl.Name = "ll_reviews_lbl"
        Me.ll_reviews_lbl.Size = New System.Drawing.Size(366, 328)
        Me.ll_reviews_lbl.TabIndex = 20
        '
        'll_top_review_lbl
        '
        Me.ll_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.ll_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ll_top_review_lbl.Location = New System.Drawing.Point(651, 359)
        Me.ll_top_review_lbl.Name = "ll_top_review_lbl"
        Me.ll_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.ll_top_review_lbl.TabIndex = 19
        Me.ll_top_review_lbl.Text = "Top reviews"
        Me.ll_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'll_next_btn
        '
        Me.ll_next_btn.BackColor = System.Drawing.Color.Brown
        Me.ll_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ll_next_btn.FlatAppearance.BorderSize = 0
        Me.ll_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ll_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ll_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.ll_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_next_btn.Name = "ll_next_btn"
        Me.ll_next_btn.Size = New System.Drawing.Size(1040, 60)
        Me.ll_next_btn.TabIndex = 18
        Me.ll_next_btn.Text = "Proceed To Next"
        Me.ll_next_btn.UseVisualStyleBackColor = False
        '
        'll_cname4
        '
        Me.ll_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_cname4.Location = New System.Drawing.Point(490, 708)
        Me.ll_cname4.Name = "ll_cname4"
        Me.ll_cname4.Size = New System.Drawing.Size(170, 51)
        Me.ll_cname4.TabIndex = 17
        Me.ll_cname4.Text = "Amrapali Dubey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Divya)"
        Me.ll_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'll_cname3
        '
        Me.ll_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_cname3.Location = New System.Drawing.Point(341, 708)
        Me.ll_cname3.Name = "ll_cname3"
        Me.ll_cname3.Size = New System.Drawing.Size(130, 51)
        Me.ll_cname3.TabIndex = 16
        Me.ll_cname3.Text = "Sanjay Pandey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Dilawar)"
        Me.ll_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'll_cname2
        '
        Me.ll_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_cname2.Location = New System.Drawing.Point(175, 708)
        Me.ll_cname2.Name = "ll_cname2"
        Me.ll_cname2.Size = New System.Drawing.Size(150, 51)
        Me.ll_cname2.TabIndex = 15
        Me.ll_cname2.Text = "Kanak Pandey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Laila)"
        Me.ll_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'll_cname1
        '
        Me.ll_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_cname1.Location = New System.Drawing.Point(16, 708)
        Me.ll_cname1.Name = "ll_cname1"
        Me.ll_cname1.Size = New System.Drawing.Size(136, 51)
        Me.ll_cname1.TabIndex = 14
        Me.ll_cname1.Text = "Dinesh Lal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Lallu)"
        Me.ll_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'll_cast_img3
        '
        Me.ll_cast_img3.Image = CType(resources.GetObject("ll_cast_img3.Image"), System.Drawing.Image)
        Me.ll_cast_img3.Location = New System.Drawing.Point(345, 582)
        Me.ll_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_cast_img3.Name = "ll_cast_img3"
        Me.ll_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.ll_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ll_cast_img3.TabIndex = 13
        Me.ll_cast_img3.TabStop = False
        '
        'll_cast_img2
        '
        Me.ll_cast_img2.Image = CType(resources.GetObject("ll_cast_img2.Image"), System.Drawing.Image)
        Me.ll_cast_img2.Location = New System.Drawing.Point(180, 582)
        Me.ll_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_cast_img2.Name = "ll_cast_img2"
        Me.ll_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.ll_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ll_cast_img2.TabIndex = 12
        Me.ll_cast_img2.TabStop = False
        '
        'll_cast_img4
        '
        Me.ll_cast_img4.Image = CType(resources.GetObject("ll_cast_img4.Image"), System.Drawing.Image)
        Me.ll_cast_img4.Location = New System.Drawing.Point(506, 582)
        Me.ll_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_cast_img4.Name = "ll_cast_img4"
        Me.ll_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.ll_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ll_cast_img4.TabIndex = 11
        Me.ll_cast_img4.TabStop = False
        '
        'll_cast_img1
        '
        Me.ll_cast_img1.Image = CType(resources.GetObject("ll_cast_img1.Image"), System.Drawing.Image)
        Me.ll_cast_img1.Location = New System.Drawing.Point(19, 582)
        Me.ll_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_cast_img1.Name = "ll_cast_img1"
        Me.ll_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.ll_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ll_cast_img1.TabIndex = 10
        Me.ll_cast_img1.TabStop = False
        '
        'll_cast_lbl
        '
        Me.ll_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_cast_lbl.Location = New System.Drawing.Point(14, 549)
        Me.ll_cast_lbl.Name = "ll_cast_lbl"
        Me.ll_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.ll_cast_lbl.TabIndex = 9
        Me.ll_cast_lbl.Text = "Cast"
        Me.ll_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'll_desc
        '
        Me.ll_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_desc.Location = New System.Drawing.Point(5, 420)
        Me.ll_desc.Name = "ll_desc"
        Me.ll_desc.Size = New System.Drawing.Size(641, 126)
        Me.ll_desc.TabIndex = 8
        Me.ll_desc.Text = resources.GetString("ll_desc.Text")
        '
        'll_dur_time_lbl
        '
        Me.ll_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.ll_dur_time_lbl.Name = "ll_dur_time_lbl"
        Me.ll_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.ll_dur_time_lbl.TabIndex = 7
        Me.ll_dur_time_lbl.Text = "2h 23m"
        '
        'll_rating_val_lbl
        '
        Me.ll_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.ll_rating_val_lbl.Name = "ll_rating_val_lbl"
        Me.ll_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.ll_rating_val_lbl.TabIndex = 6
        Me.ll_rating_val_lbl.Text = "9.6/10"
        '
        'll_star_pt_box
        '
        Me.ll_star_pt_box.Image = CType(resources.GetObject("ll_star_pt_box.Image"), System.Drawing.Image)
        Me.ll_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.ll_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_star_pt_box.Name = "ll_star_pt_box"
        Me.ll_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.ll_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ll_star_pt_box.TabIndex = 5
        Me.ll_star_pt_box.TabStop = False
        '
        'll_dur_lbl
        '
        Me.ll_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.ll_dur_lbl.Name = "ll_dur_lbl"
        Me.ll_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.ll_dur_lbl.TabIndex = 4
        Me.ll_dur_lbl.Text = "Duration  :"
        Me.ll_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'll_Rating_lbl
        '
        Me.ll_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.ll_Rating_lbl.Name = "ll_Rating_lbl"
        Me.ll_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.ll_Rating_lbl.TabIndex = 3
        Me.ll_Rating_lbl.Text = "Ratings     :"
        Me.ll_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trailer_bg_lbl
        '
        Me.trailer_bg_lbl.BackColor = System.Drawing.Color.DimGray
        Me.trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.trailer_bg_lbl.Name = "trailer_bg_lbl"
        Me.trailer_bg_lbl.Size = New System.Drawing.Size(1043, 245)
        Me.trailer_bg_lbl.TabIndex = 1
        Me.trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'll_moviename_lbl
        '
        Me.ll_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ll_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.ll_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.ll_moviename_lbl.Name = "ll_moviename_lbl"
        Me.ll_moviename_lbl.Size = New System.Drawing.Size(1037, 50)
        Me.ll_moviename_lbl.TabIndex = 0
        Me.ll_moviename_lbl.Text = "Lallu Ki Laila"
        Me.ll_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lallu_format_pnl
        '
        Me.lallu_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.lallu_format_pnl.Controls.Add(Me.ll_format_nxt_btn)
        Me.lallu_format_pnl.Controls.Add(Me.ll_btn_3d)
        Me.lallu_format_pnl.Controls.Add(Me.ll_btn_2d)
        Me.lallu_format_pnl.Controls.Add(Me.II_select_format_lbl)
        Me.lallu_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.lallu_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lallu_format_pnl.Name = "lallu_format_pnl"
        Me.lallu_format_pnl.Size = New System.Drawing.Size(1040, 151)
        Me.lallu_format_pnl.TabIndex = 2
        Me.lallu_format_pnl.Visible = False
        '
        'll_format_nxt_btn
        '
        Me.ll_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.ll_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ll_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.ll_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ll_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ll_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.ll_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_format_nxt_btn.Name = "ll_format_nxt_btn"
        Me.ll_format_nxt_btn.Size = New System.Drawing.Size(1040, 60)
        Me.ll_format_nxt_btn.TabIndex = 19
        Me.ll_format_nxt_btn.Text = "Continue"
        Me.ll_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'll_btn_3d
        '
        Me.ll_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_btn_3d.Location = New System.Drawing.Point(341, 19)
        Me.ll_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_btn_3d.Name = "ll_btn_3d"
        Me.ll_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.ll_btn_3d.TabIndex = 7
        Me.ll_btn_3d.TabStop = True
        Me.ll_btn_3d.Text = "3D"
        Me.ll_btn_3d.UseVisualStyleBackColor = True
        '
        'll_btn_2d
        '
        Me.ll_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ll_btn_2d.Location = New System.Drawing.Point(266, 19)
        Me.ll_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ll_btn_2d.Name = "ll_btn_2d"
        Me.ll_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.ll_btn_2d.TabIndex = 6
        Me.ll_btn_2d.TabStop = True
        Me.ll_btn_2d.Text = "2D"
        Me.ll_btn_2d.UseVisualStyleBackColor = True
        '
        'II_select_format_lbl
        '
        Me.II_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.II_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.II_select_format_lbl.Name = "II_select_format_lbl"
        Me.II_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.II_select_format_lbl.TabIndex = 5
        Me.II_select_format_lbl.Text = "Select Movie Format :"
        Me.II_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Lallu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lallu_format_pnl)
        Me.Controls.Add(Me.lallu_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Lallu"
        Me.Text = "Lallu"
        Me.lallu_panel.ResumeLayout(False)
        Me.lallu_panel.PerformLayout()
        Me.ll_vid_pnl.ResumeLayout(False)
        CType(Me.ll_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ll_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ll_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ll_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ll_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ll_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lallu_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lallu_panel As Panel
    Friend WithEvents ll_vid_pnl As Panel
    Friend WithEvents ll_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents ll_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ll_username_lbl As Label
    Friend WithEvents ll_user_review_output As Label
    Friend WithEvents ll_add_review_lbl As Label
    Friend WithEvents ll_user_review_txt As TextBox
    Friend WithEvents ll_Add_btn As Button
    Friend WithEvents ll_user2_review_lbl As Label
    Friend WithEvents ll_user2_name_lbl As Label
    Friend WithEvents ll_user1_review_lbl As Label
    Friend WithEvents ll_user1_lbl As Label
    Friend WithEvents ll_reviews_lbl As Label
    Friend WithEvents ll_top_review_lbl As Label
    Friend WithEvents ll_next_btn As Button
    Friend WithEvents ll_cname4 As Label
    Friend WithEvents ll_cname3 As Label
    Friend WithEvents ll_cname2 As Label
    Friend WithEvents ll_cname1 As Label
    Friend WithEvents ll_cast_img3 As PictureBox
    Friend WithEvents ll_cast_img2 As PictureBox
    Friend WithEvents ll_cast_img4 As PictureBox
    Friend WithEvents ll_cast_img1 As PictureBox
    Friend WithEvents ll_cast_lbl As Label
    Friend WithEvents ll_desc As Label
    Friend WithEvents ll_dur_time_lbl As Label
    Friend WithEvents ll_rating_val_lbl As Label
    Friend WithEvents ll_star_pt_box As PictureBox
    Friend WithEvents ll_dur_lbl As Label
    Friend WithEvents ll_Rating_lbl As Label
    Friend WithEvents trailer_bg_lbl As Label
    Friend WithEvents ll_moviename_lbl As Label
    Friend WithEvents lallu_format_pnl As Panel
    Friend WithEvents ll_format_nxt_btn As Button
    Friend WithEvents ll_btn_3d As RadioButton
    Friend WithEvents ll_btn_2d As RadioButton
    Friend WithEvents II_select_format_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
