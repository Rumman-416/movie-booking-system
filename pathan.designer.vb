<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pathan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pathan))
        Me.pathan_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.pt_vid_pnl = New System.Windows.Forms.Panel()
        Me.pt_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.pt_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pt_username_lbl = New System.Windows.Forms.Label()
        Me.pt_user_review_output = New System.Windows.Forms.Label()
        Me.pt_add_review_lbl = New System.Windows.Forms.Label()
        Me.pt_user_review_txt = New System.Windows.Forms.TextBox()
        Me.pt_Add_btn = New System.Windows.Forms.Button()
        Me.pt_user2_review_lbl = New System.Windows.Forms.Label()
        Me.pt_user2_name_lbl = New System.Windows.Forms.Label()
        Me.pt_user1_review_lbl = New System.Windows.Forms.Label()
        Me.pt_user1_lbl = New System.Windows.Forms.Label()
        Me.pt_reviews_lbl = New System.Windows.Forms.Label()
        Me.pt_top_review_lbl = New System.Windows.Forms.Label()
        Me.pt_next_btn = New System.Windows.Forms.Button()
        Me.pt_cname4 = New System.Windows.Forms.Label()
        Me.pt_cname3 = New System.Windows.Forms.Label()
        Me.pt_cname2 = New System.Windows.Forms.Label()
        Me.pt_cname1 = New System.Windows.Forms.Label()
        Me.pt_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.pt_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.pt_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.pt_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.pt_cast_lbl = New System.Windows.Forms.Label()
        Me.pt_desc = New System.Windows.Forms.Label()
        Me.pt_dur_time_lbl = New System.Windows.Forms.Label()
        Me.pt_rating_val_lbl = New System.Windows.Forms.Label()
        Me.pt_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.pt_dur_lbl = New System.Windows.Forms.Label()
        Me.pt_Rating_lbl = New System.Windows.Forms.Label()
        Me.pt_trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.pt_moviename_lbl = New System.Windows.Forms.Label()
        Me.pathan_format_pnl = New System.Windows.Forms.Panel()
        Me.pt_format_nxt_btn = New System.Windows.Forms.Button()
        Me.pt_btn_3d = New System.Windows.Forms.RadioButton()
        Me.pt_btn_2d = New System.Windows.Forms.RadioButton()
        Me.pt_select_format_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.pathan_panel.SuspendLayout()
        Me.pt_vid_pnl.SuspendLayout()
        CType(Me.pt_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pt_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pt_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pt_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pt_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pt_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pathan_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pathan_panel
        '
        Me.pathan_panel.BackColor = System.Drawing.Color.Snow
        Me.pathan_panel.Controls.Add(Me.BackButton)
        Me.pathan_panel.Controls.Add(Me.pt_vid_pnl)
        Me.pathan_panel.Controls.Add(Me.pt_username_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_user_review_output)
        Me.pathan_panel.Controls.Add(Me.pt_add_review_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_user_review_txt)
        Me.pathan_panel.Controls.Add(Me.pt_Add_btn)
        Me.pathan_panel.Controls.Add(Me.pt_user2_review_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_user2_name_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_user1_review_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_user1_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_reviews_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_top_review_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_next_btn)
        Me.pathan_panel.Controls.Add(Me.pt_cname4)
        Me.pathan_panel.Controls.Add(Me.pt_cname3)
        Me.pathan_panel.Controls.Add(Me.pt_cname2)
        Me.pathan_panel.Controls.Add(Me.pt_cname1)
        Me.pathan_panel.Controls.Add(Me.pt_cast_img3)
        Me.pathan_panel.Controls.Add(Me.pt_cast_img2)
        Me.pathan_panel.Controls.Add(Me.pt_cast_img4)
        Me.pathan_panel.Controls.Add(Me.pt_cast_img1)
        Me.pathan_panel.Controls.Add(Me.pt_cast_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_desc)
        Me.pathan_panel.Controls.Add(Me.pt_dur_time_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_rating_val_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_star_pt_box)
        Me.pathan_panel.Controls.Add(Me.pt_dur_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_Rating_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_trailer_bg_lbl)
        Me.pathan_panel.Controls.Add(Me.pt_moviename_lbl)
        Me.pathan_panel.Location = New System.Drawing.Point(0, 39)
        Me.pathan_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pathan_panel.Name = "pathan_panel"
        Me.pathan_panel.Size = New System.Drawing.Size(1043, 821)
        Me.pathan_panel.TabIndex = 1
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
        Me.BackButton.TabIndex = 33
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'pt_vid_pnl
        '
        Me.pt_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pt_vid_pnl.Controls.Add(Me.pt_ply_btn)
        Me.pt_vid_pnl.Controls.Add(Me.play_btn)
        Me.pt_vid_pnl.Controls.Add(Me.pt_vid_sc)
        Me.pt_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.pt_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_vid_pnl.Name = "pt_vid_pnl"
        Me.pt_vid_pnl.Size = New System.Drawing.Size(1037, 245)
        Me.pt_vid_pnl.TabIndex = 31
        '
        'pt_ply_btn
        '
        Me.pt_ply_btn.BackgroundImage = CType(resources.GetObject("pt_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.pt_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pt_ply_btn.Location = New System.Drawing.Point(471, 72)
        Me.pt_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_ply_btn.Name = "pt_ply_btn"
        Me.pt_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.pt_ply_btn.TabIndex = 2
        Me.pt_ply_btn.UseVisualStyleBackColor = True
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
        'pt_vid_sc
        '
        Me.pt_vid_sc.Enabled = True
        Me.pt_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.pt_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_vid_sc.Name = "pt_vid_sc"
        Me.pt_vid_sc.OcxState = CType(resources.GetObject("pt_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.pt_vid_sc.Size = New System.Drawing.Size(596, 299)
        Me.pt_vid_sc.TabIndex = 0
        '
        'pt_username_lbl
        '
        Me.pt_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_username_lbl.Location = New System.Drawing.Point(663, 616)
        Me.pt_username_lbl.Name = "pt_username_lbl"
        Me.pt_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.pt_username_lbl.TabIndex = 29
        Me.pt_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_user_review_output
        '
        Me.pt_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_user_review_output.Location = New System.Drawing.Point(756, 616)
        Me.pt_user_review_output.Name = "pt_user_review_output"
        Me.pt_user_review_output.Size = New System.Drawing.Size(235, 55)
        Me.pt_user_review_output.TabIndex = 28
        '
        'pt_add_review_lbl
        '
        Me.pt_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.pt_add_review_lbl.Location = New System.Drawing.Point(674, 676)
        Me.pt_add_review_lbl.Name = "pt_add_review_lbl"
        Me.pt_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.pt_add_review_lbl.TabIndex = 27
        Me.pt_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pt_user_review_txt
        '
        Me.pt_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pt_user_review_txt.Location = New System.Drawing.Point(671, 709)
        Me.pt_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_user_review_txt.Name = "pt_user_review_txt"
        Me.pt_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.pt_user_review_txt.TabIndex = 25
        '
        'pt_Add_btn
        '
        Me.pt_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.pt_Add_btn.Location = New System.Drawing.Point(945, 709)
        Me.pt_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_Add_btn.Name = "pt_Add_btn"
        Me.pt_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.pt_Add_btn.TabIndex = 26
        Me.pt_Add_btn.Text = "ADD"
        Me.pt_Add_btn.UseVisualStyleBackColor = False
        '
        'pt_user2_review_lbl
        '
        Me.pt_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_user2_review_lbl.Location = New System.Drawing.Point(760, 444)
        Me.pt_user2_review_lbl.Name = "pt_user2_review_lbl"
        Me.pt_user2_review_lbl.Size = New System.Drawing.Size(245, 71)
        Me.pt_user2_review_lbl.TabIndex = 24
        Me.pt_user2_review_lbl.Text = "Everyone was eager for SRK in action but John came out of syllabus ( ;"
        '
        'pt_user2_name_lbl
        '
        Me.pt_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_user2_name_lbl.Location = New System.Drawing.Point(661, 444)
        Me.pt_user2_name_lbl.Name = "pt_user2_name_lbl"
        Me.pt_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.pt_user2_name_lbl.TabIndex = 23
        Me.pt_user2_name_lbl.Text = "User356 :"
        Me.pt_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_user1_review_lbl
        '
        Me.pt_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_user1_review_lbl.Location = New System.Drawing.Point(756, 528)
        Me.pt_user1_review_lbl.Name = "pt_user1_review_lbl"
        Me.pt_user1_review_lbl.Size = New System.Drawing.Size(245, 89)
        Me.pt_user1_review_lbl.TabIndex = 22
        Me.pt_user1_review_lbl.Text = "What a comeback of SRK, this movie will break all the previous record "
        '
        'pt_user1_lbl
        '
        Me.pt_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_user1_lbl.Location = New System.Drawing.Point(663, 528)
        Me.pt_user1_lbl.Name = "pt_user1_lbl"
        Me.pt_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.pt_user1_lbl.TabIndex = 21
        Me.pt_user1_lbl.Text = "User145 :"
        Me.pt_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_reviews_lbl
        '
        Me.pt_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pt_reviews_lbl.Location = New System.Drawing.Point(650, 420)
        Me.pt_reviews_lbl.Name = "pt_reviews_lbl"
        Me.pt_reviews_lbl.Size = New System.Drawing.Size(361, 328)
        Me.pt_reviews_lbl.TabIndex = 20
        '
        'pt_top_review_lbl
        '
        Me.pt_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.pt_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.pt_top_review_lbl.Location = New System.Drawing.Point(650, 370)
        Me.pt_top_review_lbl.Name = "pt_top_review_lbl"
        Me.pt_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.pt_top_review_lbl.TabIndex = 19
        Me.pt_top_review_lbl.Text = "Top reviews"
        Me.pt_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_next_btn
        '
        Me.pt_next_btn.BackColor = System.Drawing.Color.Brown
        Me.pt_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pt_next_btn.FlatAppearance.BorderSize = 0
        Me.pt_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pt_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pt_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.pt_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_next_btn.Name = "pt_next_btn"
        Me.pt_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.pt_next_btn.TabIndex = 18
        Me.pt_next_btn.Text = "Proceed To Next"
        Me.pt_next_btn.UseVisualStyleBackColor = False
        '
        'pt_cname4
        '
        Me.pt_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_cname4.Location = New System.Drawing.Point(507, 686)
        Me.pt_cname4.Name = "pt_cname4"
        Me.pt_cname4.Size = New System.Drawing.Size(170, 51)
        Me.pt_cname4.TabIndex = 17
        Me.pt_cname4.Text = "Salman Khan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Tiger)"
        Me.pt_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pt_cname3
        '
        Me.pt_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_cname3.Location = New System.Drawing.Point(357, 686)
        Me.pt_cname3.Name = "pt_cname3"
        Me.pt_cname3.Size = New System.Drawing.Size(130, 51)
        Me.pt_cname3.TabIndex = 16
        Me.pt_cname3.Text = "John Abraham" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(JIm)"
        Me.pt_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pt_cname2
        '
        Me.pt_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_cname2.Location = New System.Drawing.Point(170, 686)
        Me.pt_cname2.Name = "pt_cname2"
        Me.pt_cname2.Size = New System.Drawing.Size(180, 51)
        Me.pt_cname2.TabIndex = 15
        Me.pt_cname2.Text = "Deepika Padukone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Rubina)"
        Me.pt_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pt_cname1
        '
        Me.pt_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_cname1.Location = New System.Drawing.Point(32, 686)
        Me.pt_cname1.Name = "pt_cname1"
        Me.pt_cname1.Size = New System.Drawing.Size(136, 51)
        Me.pt_cname1.TabIndex = 14
        Me.pt_cname1.Text = "Shahrukh Khan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pathaan)"
        Me.pt_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pt_cast_img3
        '
        Me.pt_cast_img3.Image = CType(resources.GetObject("pt_cast_img3.Image"), System.Drawing.Image)
        Me.pt_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.pt_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_cast_img3.Name = "pt_cast_img3"
        Me.pt_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.pt_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pt_cast_img3.TabIndex = 13
        Me.pt_cast_img3.TabStop = False
        '
        'pt_cast_img2
        '
        Me.pt_cast_img2.Image = CType(resources.GetObject("pt_cast_img2.Image"), System.Drawing.Image)
        Me.pt_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.pt_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_cast_img2.Name = "pt_cast_img2"
        Me.pt_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.pt_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pt_cast_img2.TabIndex = 12
        Me.pt_cast_img2.TabStop = False
        '
        'pt_cast_img4
        '
        Me.pt_cast_img4.Image = CType(resources.GetObject("pt_cast_img4.Image"), System.Drawing.Image)
        Me.pt_cast_img4.Location = New System.Drawing.Point(522, 560)
        Me.pt_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_cast_img4.Name = "pt_cast_img4"
        Me.pt_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.pt_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pt_cast_img4.TabIndex = 11
        Me.pt_cast_img4.TabStop = False
        '
        'pt_cast_img1
        '
        Me.pt_cast_img1.Image = CType(resources.GetObject("pt_cast_img1.Image"), System.Drawing.Image)
        Me.pt_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.pt_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_cast_img1.Name = "pt_cast_img1"
        Me.pt_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.pt_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pt_cast_img1.TabIndex = 10
        Me.pt_cast_img1.TabStop = False
        '
        'pt_cast_lbl
        '
        Me.pt_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.pt_cast_lbl.Name = "pt_cast_lbl"
        Me.pt_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.pt_cast_lbl.TabIndex = 9
        Me.pt_cast_lbl.Text = "Cast"
        Me.pt_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_desc
        '
        Me.pt_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_desc.Location = New System.Drawing.Point(14, 432)
        Me.pt_desc.Name = "pt_desc"
        Me.pt_desc.Size = New System.Drawing.Size(648, 85)
        Me.pt_desc.TabIndex = 8
        Me.pt_desc.Text = "Action, Adventure, Thriller ; " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An Indian agent races against a doomsday clock as" &
    " a ruthless mercenary, with a bitter vendetta, mounts an apocalyptic attack agai" &
    "nst the country." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pt_dur_time_lbl
        '
        Me.pt_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.pt_dur_time_lbl.Name = "pt_dur_time_lbl"
        Me.pt_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.pt_dur_time_lbl.TabIndex = 7
        Me.pt_dur_time_lbl.Text = "2h 26m"
        '
        'pt_rating_val_lbl
        '
        Me.pt_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.pt_rating_val_lbl.Name = "pt_rating_val_lbl"
        Me.pt_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.pt_rating_val_lbl.TabIndex = 6
        Me.pt_rating_val_lbl.Text = "8.7/10"
        '
        'pt_star_pt_box
        '
        Me.pt_star_pt_box.Image = CType(resources.GetObject("pt_star_pt_box.Image"), System.Drawing.Image)
        Me.pt_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.pt_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_star_pt_box.Name = "pt_star_pt_box"
        Me.pt_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.pt_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pt_star_pt_box.TabIndex = 5
        Me.pt_star_pt_box.TabStop = False
        '
        'pt_dur_lbl
        '
        Me.pt_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.pt_dur_lbl.Name = "pt_dur_lbl"
        Me.pt_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.pt_dur_lbl.TabIndex = 4
        Me.pt_dur_lbl.Text = "Duration  :"
        Me.pt_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_Rating_lbl
        '
        Me.pt_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.pt_Rating_lbl.Name = "pt_Rating_lbl"
        Me.pt_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.pt_Rating_lbl.TabIndex = 3
        Me.pt_Rating_lbl.Text = "Ratings     :"
        Me.pt_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pt_trailer_bg_lbl
        '
        Me.pt_trailer_bg_lbl.BackColor = System.Drawing.Color.Black
        Me.pt_trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.pt_trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.pt_trailer_bg_lbl.Name = "pt_trailer_bg_lbl"
        Me.pt_trailer_bg_lbl.Size = New System.Drawing.Size(1037, 245)
        Me.pt_trailer_bg_lbl.TabIndex = 1
        Me.pt_trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pt_moviename_lbl
        '
        Me.pt_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pt_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.pt_moviename_lbl.Location = New System.Drawing.Point(3, 11)
        Me.pt_moviename_lbl.Name = "pt_moviename_lbl"
        Me.pt_moviename_lbl.Size = New System.Drawing.Size(1040, 50)
        Me.pt_moviename_lbl.TabIndex = 0
        Me.pt_moviename_lbl.Text = "PATHAN"
        Me.pt_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pathan_format_pnl
        '
        Me.pathan_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.pathan_format_pnl.Controls.Add(Me.pt_format_nxt_btn)
        Me.pathan_format_pnl.Controls.Add(Me.pt_btn_3d)
        Me.pathan_format_pnl.Controls.Add(Me.pt_btn_2d)
        Me.pathan_format_pnl.Controls.Add(Me.pt_select_format_lbl)
        Me.pathan_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.pathan_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pathan_format_pnl.Name = "pathan_format_pnl"
        Me.pathan_format_pnl.Size = New System.Drawing.Size(1043, 151)
        Me.pathan_format_pnl.TabIndex = 30
        Me.pathan_format_pnl.Visible = False
        '
        'pt_format_nxt_btn
        '
        Me.pt_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.pt_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pt_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.pt_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pt_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pt_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.pt_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_format_nxt_btn.Name = "pt_format_nxt_btn"
        Me.pt_format_nxt_btn.Size = New System.Drawing.Size(1043, 60)
        Me.pt_format_nxt_btn.TabIndex = 19
        Me.pt_format_nxt_btn.Text = "Continue"
        Me.pt_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'pt_btn_3d
        '
        Me.pt_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_btn_3d.Location = New System.Drawing.Point(330, 19)
        Me.pt_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_btn_3d.Name = "pt_btn_3d"
        Me.pt_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.pt_btn_3d.TabIndex = 7
        Me.pt_btn_3d.TabStop = True
        Me.pt_btn_3d.Text = "3D"
        Me.pt_btn_3d.UseVisualStyleBackColor = True
        '
        'pt_btn_2d
        '
        Me.pt_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_btn_2d.Location = New System.Drawing.Point(252, 19)
        Me.pt_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pt_btn_2d.Name = "pt_btn_2d"
        Me.pt_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.pt_btn_2d.TabIndex = 6
        Me.pt_btn_2d.TabStop = True
        Me.pt_btn_2d.Text = "2D"
        Me.pt_btn_2d.UseVisualStyleBackColor = True
        '
        'pt_select_format_lbl
        '
        Me.pt_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pt_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.pt_select_format_lbl.Name = "pt_select_format_lbl"
        Me.pt_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.pt_select_format_lbl.TabIndex = 5
        Me.pt_select_format_lbl.Text = "Select Movie Format :"
        Me.pt_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.cross)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 40)
        Me.Panel1.TabIndex = 31
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
        'pathan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pathan_format_pnl)
        Me.Controls.Add(Me.pathan_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "pathan"
        Me.Text = "Pathan"
        Me.pathan_panel.ResumeLayout(False)
        Me.pathan_panel.PerformLayout()
        Me.pt_vid_pnl.ResumeLayout(False)
        CType(Me.pt_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pt_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pt_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pt_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pt_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pt_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pathan_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pathan_panel As Panel
    Friend WithEvents pt_username_lbl As Label
    Friend WithEvents pt_user_review_output As Label
    Friend WithEvents pt_add_review_lbl As Label
    Friend WithEvents pt_user_review_txt As TextBox
    Friend WithEvents pt_Add_btn As Button
    Friend WithEvents pt_user2_review_lbl As Label
    Friend WithEvents pt_user2_name_lbl As Label
    Friend WithEvents pt_user1_review_lbl As Label
    Friend WithEvents pt_user1_lbl As Label
    Friend WithEvents pt_reviews_lbl As Label
    Friend WithEvents pt_top_review_lbl As Label
    Friend WithEvents pt_next_btn As Button
    Friend WithEvents pt_cname4 As Label
    Friend WithEvents pt_cname3 As Label
    Friend WithEvents pt_cname2 As Label
    Friend WithEvents pt_cname1 As Label
    Friend WithEvents pt_cast_img3 As PictureBox
    Friend WithEvents pt_cast_img2 As PictureBox
    Friend WithEvents pt_cast_img4 As PictureBox
    Friend WithEvents pt_cast_img1 As PictureBox
    Friend WithEvents pt_cast_lbl As Label
    Friend WithEvents pt_desc As Label
    Friend WithEvents pt_dur_time_lbl As Label
    Friend WithEvents pt_rating_val_lbl As Label
    Friend WithEvents pt_star_pt_box As PictureBox
    Friend WithEvents pt_dur_lbl As Label
    Friend WithEvents pt_Rating_lbl As Label
    Friend WithEvents pt_trailer_bg_lbl As Label
    Friend WithEvents pt_moviename_lbl As Label
    Friend WithEvents pathan_format_pnl As Panel
    Friend WithEvents pt_format_nxt_btn As Button
    Friend WithEvents pt_btn_3d As RadioButton
    Friend WithEvents pt_btn_2d As RadioButton
    Friend WithEvents pt_select_format_lbl As Label
    Friend WithEvents pt_vid_pnl As Panel
    Friend WithEvents pt_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents pt_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
    Friend WithEvents BackButton As Button
End Class
