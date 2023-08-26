<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Titanic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Titanic))
        Me.Titanic_panel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TT_vid_pnl = New System.Windows.Forms.Panel()
        Me.TT_ply_btn = New System.Windows.Forms.Button()
        Me.play_btn = New System.Windows.Forms.Button()
        Me.TT_vid_sc = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TT_username_lbl = New System.Windows.Forms.Label()
        Me.TT_user_review_output = New System.Windows.Forms.Label()
        Me.TT_add_review_lbl = New System.Windows.Forms.Label()
        Me.TT_user_review_txt = New System.Windows.Forms.TextBox()
        Me.TT_Add_btn = New System.Windows.Forms.Button()
        Me.TT_user2_review_lbl = New System.Windows.Forms.Label()
        Me.TT_user2_name_lbl = New System.Windows.Forms.Label()
        Me.TT_user1_review_lbl = New System.Windows.Forms.Label()
        Me.TT_user1_lbl = New System.Windows.Forms.Label()
        Me.TT_reviews_lbl = New System.Windows.Forms.Label()
        Me.TT_top_review_lbl = New System.Windows.Forms.Label()
        Me.TT_next_btn = New System.Windows.Forms.Button()
        Me.TT_cname4 = New System.Windows.Forms.Label()
        Me.TT_cname3 = New System.Windows.Forms.Label()
        Me.TT_cname2 = New System.Windows.Forms.Label()
        Me.TT_cname1 = New System.Windows.Forms.Label()
        Me.TT_cast_img3 = New System.Windows.Forms.PictureBox()
        Me.TT_cast_img2 = New System.Windows.Forms.PictureBox()
        Me.TT_cast_img4 = New System.Windows.Forms.PictureBox()
        Me.TT_cast_img1 = New System.Windows.Forms.PictureBox()
        Me.tt_cast_lbl = New System.Windows.Forms.Label()
        Me.titanic_desc = New System.Windows.Forms.Label()
        Me.TT_dur_time_lbl = New System.Windows.Forms.Label()
        Me.TT_rating_val_lbl = New System.Windows.Forms.Label()
        Me.TT_star_pt_box = New System.Windows.Forms.PictureBox()
        Me.TT_dur_lbl = New System.Windows.Forms.Label()
        Me.TT_Rating_lbl = New System.Windows.Forms.Label()
        Me.TT_trailer_bg_lbl = New System.Windows.Forms.Label()
        Me.TT_moviename_lbl = New System.Windows.Forms.Label()
        Me.titanic_format_pnl = New System.Windows.Forms.Panel()
        Me.TT_format_nxt_btn = New System.Windows.Forms.Button()
        Me.TT_btn_3d = New System.Windows.Forms.RadioButton()
        Me.TT_btn_2d = New System.Windows.Forms.RadioButton()
        Me.TT_select_format_lbl = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minus = New System.Windows.Forms.Button()
        Me.cross = New System.Windows.Forms.Button()
        Me.Titanic_panel.SuspendLayout()
        Me.TT_vid_pnl.SuspendLayout()
        CType(Me.TT_vid_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TT_cast_img3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TT_cast_img2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TT_cast_img4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TT_cast_img1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TT_star_pt_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.titanic_format_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titanic_panel
        '
        Me.Titanic_panel.BackColor = System.Drawing.Color.Snow
        Me.Titanic_panel.Controls.Add(Me.BackButton)
        Me.Titanic_panel.Controls.Add(Me.TT_vid_pnl)
        Me.Titanic_panel.Controls.Add(Me.TT_username_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_user_review_output)
        Me.Titanic_panel.Controls.Add(Me.TT_add_review_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_user_review_txt)
        Me.Titanic_panel.Controls.Add(Me.TT_Add_btn)
        Me.Titanic_panel.Controls.Add(Me.TT_user2_review_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_user2_name_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_user1_review_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_user1_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_reviews_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_top_review_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_next_btn)
        Me.Titanic_panel.Controls.Add(Me.TT_cname4)
        Me.Titanic_panel.Controls.Add(Me.TT_cname3)
        Me.Titanic_panel.Controls.Add(Me.TT_cname2)
        Me.Titanic_panel.Controls.Add(Me.TT_cname1)
        Me.Titanic_panel.Controls.Add(Me.TT_cast_img3)
        Me.Titanic_panel.Controls.Add(Me.TT_cast_img2)
        Me.Titanic_panel.Controls.Add(Me.TT_cast_img4)
        Me.Titanic_panel.Controls.Add(Me.TT_cast_img1)
        Me.Titanic_panel.Controls.Add(Me.tt_cast_lbl)
        Me.Titanic_panel.Controls.Add(Me.titanic_desc)
        Me.Titanic_panel.Controls.Add(Me.TT_dur_time_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_rating_val_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_star_pt_box)
        Me.Titanic_panel.Controls.Add(Me.TT_dur_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_Rating_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_trailer_bg_lbl)
        Me.Titanic_panel.Controls.Add(Me.TT_moviename_lbl)
        Me.Titanic_panel.Location = New System.Drawing.Point(0, 39)
        Me.Titanic_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Titanic_panel.Name = "Titanic_panel"
        Me.Titanic_panel.Size = New System.Drawing.Size(1043, 821)
        Me.Titanic_panel.TabIndex = 1
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
        Me.BackButton.Size = New System.Drawing.Size(126, 62)
        Me.BackButton.TabIndex = 32
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'TT_vid_pnl
        '
        Me.TT_vid_pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TT_vid_pnl.Controls.Add(Me.TT_ply_btn)
        Me.TT_vid_pnl.Controls.Add(Me.play_btn)
        Me.TT_vid_pnl.Controls.Add(Me.TT_vid_sc)
        Me.TT_vid_pnl.Location = New System.Drawing.Point(3, 74)
        Me.TT_vid_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_vid_pnl.Name = "TT_vid_pnl"
        Me.TT_vid_pnl.Size = New System.Drawing.Size(1040, 245)
        Me.TT_vid_pnl.TabIndex = 31
        '
        'TT_ply_btn
        '
        Me.TT_ply_btn.BackgroundImage = CType(resources.GetObject("TT_ply_btn.BackgroundImage"), System.Drawing.Image)
        Me.TT_ply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TT_ply_btn.Location = New System.Drawing.Point(477, 72)
        Me.TT_ply_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_ply_btn.Name = "TT_ply_btn"
        Me.TT_ply_btn.Size = New System.Drawing.Size(89, 90)
        Me.TT_ply_btn.TabIndex = 2
        Me.TT_ply_btn.UseVisualStyleBackColor = True
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
        'TT_vid_sc
        '
        Me.TT_vid_sc.Enabled = True
        Me.TT_vid_sc.Location = New System.Drawing.Point(226, -7)
        Me.TT_vid_sc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_vid_sc.Name = "TT_vid_sc"
        Me.TT_vid_sc.OcxState = CType(resources.GetObject("TT_vid_sc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TT_vid_sc.Size = New System.Drawing.Size(596, 307)
        Me.TT_vid_sc.TabIndex = 0
        '
        'TT_username_lbl
        '
        Me.TT_username_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_username_lbl.Location = New System.Drawing.Point(682, 604)
        Me.TT_username_lbl.Name = "TT_username_lbl"
        Me.TT_username_lbl.Size = New System.Drawing.Size(98, 29)
        Me.TT_username_lbl.TabIndex = 29
        Me.TT_username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TT_user_review_output
        '
        Me.TT_user_review_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_user_review_output.Location = New System.Drawing.Point(786, 604)
        Me.TT_user_review_output.Name = "TT_user_review_output"
        Me.TT_user_review_output.Size = New System.Drawing.Size(224, 55)
        Me.TT_user_review_output.TabIndex = 28
        '
        'TT_add_review_lbl
        '
        Me.TT_add_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_add_review_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TT_add_review_lbl.Location = New System.Drawing.Point(693, 664)
        Me.TT_add_review_lbl.Name = "TT_add_review_lbl"
        Me.TT_add_review_lbl.Size = New System.Drawing.Size(129, 29)
        Me.TT_add_review_lbl.TabIndex = 27
        Me.TT_add_review_lbl.Text = "Add your review" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TT_user_review_txt
        '
        Me.TT_user_review_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TT_user_review_txt.Location = New System.Drawing.Point(690, 697)
        Me.TT_user_review_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_user_review_txt.Name = "TT_user_review_txt"
        Me.TT_user_review_txt.Size = New System.Drawing.Size(266, 26)
        Me.TT_user_review_txt.TabIndex = 25
        '
        'TT_Add_btn
        '
        Me.TT_Add_btn.BackColor = System.Drawing.Color.LightGray
        Me.TT_Add_btn.Location = New System.Drawing.Point(962, 696)
        Me.TT_Add_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_Add_btn.Name = "TT_Add_btn"
        Me.TT_Add_btn.Size = New System.Drawing.Size(52, 29)
        Me.TT_Add_btn.TabIndex = 26
        Me.TT_Add_btn.Text = "ADD"
        Me.TT_Add_btn.UseVisualStyleBackColor = False
        '
        'TT_user2_review_lbl
        '
        Me.TT_user2_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_user2_review_lbl.Location = New System.Drawing.Point(779, 432)
        Me.TT_user2_review_lbl.Name = "TT_user2_review_lbl"
        Me.TT_user2_review_lbl.Size = New System.Drawing.Size(254, 115)
        Me.TT_user2_review_lbl.TabIndex = 24
        Me.TT_user2_review_lbl.Text = "I'm sure I'm not the only one who is obsessed with this movie no matter how many " &
    "times I've watched this, it gives me chills and emotion all the times."
        '
        'TT_user2_name_lbl
        '
        Me.TT_user2_name_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_user2_name_lbl.Location = New System.Drawing.Point(680, 432)
        Me.TT_user2_name_lbl.Name = "TT_user2_name_lbl"
        Me.TT_user2_name_lbl.Size = New System.Drawing.Size(98, 29)
        Me.TT_user2_name_lbl.TabIndex = 23
        Me.TT_user2_name_lbl.Text = "User456 :"
        Me.TT_user2_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TT_user1_review_lbl
        '
        Me.TT_user1_review_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_user1_review_lbl.Location = New System.Drawing.Point(779, 552)
        Me.TT_user1_review_lbl.Name = "TT_user1_review_lbl"
        Me.TT_user1_review_lbl.Size = New System.Drawing.Size(245, 52)
        Me.TT_user1_review_lbl.TabIndex = 22
        Me.TT_user1_review_lbl.Text = "This movie never gets old! Feels like the first time!"
        '
        'TT_user1_lbl
        '
        Me.TT_user1_lbl.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_user1_lbl.Location = New System.Drawing.Point(680, 552)
        Me.TT_user1_lbl.Name = "TT_user1_lbl"
        Me.TT_user1_lbl.Size = New System.Drawing.Size(98, 29)
        Me.TT_user1_lbl.TabIndex = 21
        Me.TT_user1_lbl.Text = "User225 :"
        Me.TT_user1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TT_reviews_lbl
        '
        Me.TT_reviews_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TT_reviews_lbl.Location = New System.Drawing.Point(669, 408)
        Me.TT_reviews_lbl.Name = "TT_reviews_lbl"
        Me.TT_reviews_lbl.Size = New System.Drawing.Size(361, 328)
        Me.TT_reviews_lbl.TabIndex = 20
        '
        'TT_top_review_lbl
        '
        Me.TT_top_review_lbl.BackColor = System.Drawing.Color.Gray
        Me.TT_top_review_lbl.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_top_review_lbl.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TT_top_review_lbl.Location = New System.Drawing.Point(669, 358)
        Me.TT_top_review_lbl.Name = "TT_top_review_lbl"
        Me.TT_top_review_lbl.Size = New System.Drawing.Size(364, 50)
        Me.TT_top_review_lbl.TabIndex = 19
        Me.TT_top_review_lbl.Text = "Top reviews"
        Me.TT_top_review_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TT_next_btn
        '
        Me.TT_next_btn.BackColor = System.Drawing.Color.Brown
        Me.TT_next_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TT_next_btn.FlatAppearance.BorderSize = 0
        Me.TT_next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TT_next_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TT_next_btn.Location = New System.Drawing.Point(0, 761)
        Me.TT_next_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_next_btn.Name = "TT_next_btn"
        Me.TT_next_btn.Size = New System.Drawing.Size(1043, 60)
        Me.TT_next_btn.TabIndex = 18
        Me.TT_next_btn.Text = "Proceed To Next"
        Me.TT_next_btn.UseVisualStyleBackColor = False
        '
        'TT_cname4
        '
        Me.TT_cname4.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_cname4.Location = New System.Drawing.Point(507, 686)
        Me.TT_cname4.Name = "TT_cname4"
        Me.TT_cname4.Size = New System.Drawing.Size(170, 51)
        Me.TT_cname4.TabIndex = 17
        Me.TT_cname4.Text = "Kathy Bates" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Margaret Brown)"
        Me.TT_cname4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TT_cname3
        '
        Me.TT_cname3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_cname3.Location = New System.Drawing.Point(339, 686)
        Me.TT_cname3.Name = "TT_cname3"
        Me.TT_cname3.Size = New System.Drawing.Size(162, 51)
        Me.TT_cname3.TabIndex = 16
        Me.TT_cname3.Text = "Bily Zane" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Caledon Hockley)"
        Me.TT_cname3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TT_cname2
        '
        Me.TT_cname2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_cname2.Location = New System.Drawing.Point(183, 686)
        Me.TT_cname2.Name = "TT_cname2"
        Me.TT_cname2.Size = New System.Drawing.Size(166, 51)
        Me.TT_cname2.TabIndex = 15
        Me.TT_cname2.Text = "Leonardo Dicaprio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Jack Dawson)"
        Me.TT_cname2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TT_cname1
        '
        Me.TT_cname1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_cname1.Location = New System.Drawing.Point(32, 686)
        Me.TT_cname1.Name = "TT_cname1"
        Me.TT_cname1.Size = New System.Drawing.Size(136, 51)
        Me.TT_cname1.TabIndex = 14
        Me.TT_cname1.Text = "Kate Winslet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Rose Bukater)"
        Me.TT_cname1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TT_cast_img3
        '
        Me.TT_cast_img3.Image = CType(resources.GetObject("TT_cast_img3.Image"), System.Drawing.Image)
        Me.TT_cast_img3.Location = New System.Drawing.Point(361, 560)
        Me.TT_cast_img3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_cast_img3.Name = "TT_cast_img3"
        Me.TT_cast_img3.Size = New System.Drawing.Size(124, 112)
        Me.TT_cast_img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TT_cast_img3.TabIndex = 13
        Me.TT_cast_img3.TabStop = False
        '
        'TT_cast_img2
        '
        Me.TT_cast_img2.Image = CType(resources.GetObject("TT_cast_img2.Image"), System.Drawing.Image)
        Me.TT_cast_img2.Location = New System.Drawing.Point(196, 560)
        Me.TT_cast_img2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_cast_img2.Name = "TT_cast_img2"
        Me.TT_cast_img2.Size = New System.Drawing.Size(124, 112)
        Me.TT_cast_img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TT_cast_img2.TabIndex = 12
        Me.TT_cast_img2.TabStop = False
        '
        'TT_cast_img4
        '
        Me.TT_cast_img4.Image = CType(resources.GetObject("TT_cast_img4.Image"), System.Drawing.Image)
        Me.TT_cast_img4.Location = New System.Drawing.Point(522, 554)
        Me.TT_cast_img4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_cast_img4.Name = "TT_cast_img4"
        Me.TT_cast_img4.Size = New System.Drawing.Size(124, 112)
        Me.TT_cast_img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TT_cast_img4.TabIndex = 11
        Me.TT_cast_img4.TabStop = False
        '
        'TT_cast_img1
        '
        Me.TT_cast_img1.Image = CType(resources.GetObject("TT_cast_img1.Image"), System.Drawing.Image)
        Me.TT_cast_img1.Location = New System.Drawing.Point(35, 560)
        Me.TT_cast_img1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_cast_img1.Name = "TT_cast_img1"
        Me.TT_cast_img1.Size = New System.Drawing.Size(124, 112)
        Me.TT_cast_img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TT_cast_img1.TabIndex = 10
        Me.TT_cast_img1.TabStop = False
        '
        'tt_cast_lbl
        '
        Me.tt_cast_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tt_cast_lbl.Location = New System.Drawing.Point(6, 528)
        Me.tt_cast_lbl.Name = "tt_cast_lbl"
        Me.tt_cast_lbl.Size = New System.Drawing.Size(61, 29)
        Me.tt_cast_lbl.TabIndex = 9
        Me.tt_cast_lbl.Text = "Cast"
        Me.tt_cast_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titanic_desc
        '
        Me.titanic_desc.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titanic_desc.Location = New System.Drawing.Point(14, 420)
        Me.titanic_desc.Name = "titanic_desc"
        Me.titanic_desc.Size = New System.Drawing.Size(663, 114)
        Me.titanic_desc.TabIndex = 8
        Me.titanic_desc.Text = resources.GetString("titanic_desc.Text")
        '
        'TT_dur_time_lbl
        '
        Me.TT_dur_time_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_dur_time_lbl.Location = New System.Drawing.Point(132, 391)
        Me.TT_dur_time_lbl.Name = "TT_dur_time_lbl"
        Me.TT_dur_time_lbl.Size = New System.Drawing.Size(87, 29)
        Me.TT_dur_time_lbl.TabIndex = 7
        Me.TT_dur_time_lbl.Text = "3h 14m"
        '
        'TT_rating_val_lbl
        '
        Me.TT_rating_val_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_rating_val_lbl.Location = New System.Drawing.Point(174, 346)
        Me.TT_rating_val_lbl.Name = "TT_rating_val_lbl"
        Me.TT_rating_val_lbl.Size = New System.Drawing.Size(87, 29)
        Me.TT_rating_val_lbl.TabIndex = 6
        Me.TT_rating_val_lbl.Text = "9.8/10"
        '
        'TT_star_pt_box
        '
        Me.TT_star_pt_box.Image = CType(resources.GetObject("TT_star_pt_box.Image"), System.Drawing.Image)
        Me.TT_star_pt_box.Location = New System.Drawing.Point(126, 338)
        Me.TT_star_pt_box.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_star_pt_box.Name = "TT_star_pt_box"
        Me.TT_star_pt_box.Size = New System.Drawing.Size(42, 40)
        Me.TT_star_pt_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TT_star_pt_box.TabIndex = 5
        Me.TT_star_pt_box.TabStop = False
        '
        'TT_dur_lbl
        '
        Me.TT_dur_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_dur_lbl.Location = New System.Drawing.Point(10, 391)
        Me.TT_dur_lbl.Name = "TT_dur_lbl"
        Me.TT_dur_lbl.Size = New System.Drawing.Size(115, 29)
        Me.TT_dur_lbl.TabIndex = 4
        Me.TT_dur_lbl.Text = "Duration  :"
        Me.TT_dur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TT_Rating_lbl
        '
        Me.TT_Rating_lbl.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_Rating_lbl.Location = New System.Drawing.Point(10, 345)
        Me.TT_Rating_lbl.Name = "TT_Rating_lbl"
        Me.TT_Rating_lbl.Size = New System.Drawing.Size(119, 29)
        Me.TT_Rating_lbl.TabIndex = 3
        Me.TT_Rating_lbl.Text = "Ratings     :"
        Me.TT_Rating_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TT_trailer_bg_lbl
        '
        Me.TT_trailer_bg_lbl.BackColor = System.Drawing.Color.Black
        Me.TT_trailer_bg_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_trailer_bg_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.TT_trailer_bg_lbl.Location = New System.Drawing.Point(3, 74)
        Me.TT_trailer_bg_lbl.Name = "TT_trailer_bg_lbl"
        Me.TT_trailer_bg_lbl.Size = New System.Drawing.Size(1133, 245)
        Me.TT_trailer_bg_lbl.TabIndex = 1
        Me.TT_trailer_bg_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TT_moviename_lbl
        '
        Me.TT_moviename_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TT_moviename_lbl.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_moviename_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.TT_moviename_lbl.Location = New System.Drawing.Point(3, 9)
        Me.TT_moviename_lbl.Name = "TT_moviename_lbl"
        Me.TT_moviename_lbl.Size = New System.Drawing.Size(1040, 61)
        Me.TT_moviename_lbl.TabIndex = 0
        Me.TT_moviename_lbl.Text = "TITANIC"
        Me.TT_moviename_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titanic_format_pnl
        '
        Me.titanic_format_pnl.BackColor = System.Drawing.Color.Snow
        Me.titanic_format_pnl.Controls.Add(Me.TT_format_nxt_btn)
        Me.titanic_format_pnl.Controls.Add(Me.TT_btn_3d)
        Me.titanic_format_pnl.Controls.Add(Me.TT_btn_2d)
        Me.titanic_format_pnl.Controls.Add(Me.TT_select_format_lbl)
        Me.titanic_format_pnl.Location = New System.Drawing.Point(0, 864)
        Me.titanic_format_pnl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.titanic_format_pnl.Name = "titanic_format_pnl"
        Me.titanic_format_pnl.Size = New System.Drawing.Size(1043, 151)
        Me.titanic_format_pnl.TabIndex = 2
        Me.titanic_format_pnl.Visible = False
        '
        'TT_format_nxt_btn
        '
        Me.TT_format_nxt_btn.BackColor = System.Drawing.Color.Brown
        Me.TT_format_nxt_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TT_format_nxt_btn.FlatAppearance.BorderSize = 0
        Me.TT_format_nxt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TT_format_nxt_btn.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_format_nxt_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TT_format_nxt_btn.Location = New System.Drawing.Point(0, 91)
        Me.TT_format_nxt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_format_nxt_btn.Name = "TT_format_nxt_btn"
        Me.TT_format_nxt_btn.Size = New System.Drawing.Size(1043, 60)
        Me.TT_format_nxt_btn.TabIndex = 19
        Me.TT_format_nxt_btn.Text = "Continue"
        Me.TT_format_nxt_btn.UseVisualStyleBackColor = False
        '
        'TT_btn_3d
        '
        Me.TT_btn_3d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_btn_3d.Location = New System.Drawing.Point(344, 19)
        Me.TT_btn_3d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_btn_3d.Name = "TT_btn_3d"
        Me.TT_btn_3d.Size = New System.Drawing.Size(64, 30)
        Me.TT_btn_3d.TabIndex = 7
        Me.TT_btn_3d.TabStop = True
        Me.TT_btn_3d.Text = "3D"
        Me.TT_btn_3d.UseVisualStyleBackColor = True
        '
        'TT_btn_2d
        '
        Me.TT_btn_2d.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_btn_2d.Location = New System.Drawing.Point(268, 18)
        Me.TT_btn_2d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TT_btn_2d.Name = "TT_btn_2d"
        Me.TT_btn_2d.Size = New System.Drawing.Size(68, 30)
        Me.TT_btn_2d.TabIndex = 6
        Me.TT_btn_2d.TabStop = True
        Me.TT_btn_2d.Text = "2D"
        Me.TT_btn_2d.UseVisualStyleBackColor = True
        '
        'TT_select_format_lbl
        '
        Me.TT_select_format_lbl.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_select_format_lbl.Location = New System.Drawing.Point(14, 14)
        Me.TT_select_format_lbl.Name = "TT_select_format_lbl"
        Me.TT_select_format_lbl.Size = New System.Drawing.Size(248, 35)
        Me.TT_select_format_lbl.TabIndex = 5
        Me.TT_select_format_lbl.Text = "Select Movie Format :"
        Me.TT_select_format_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Titanic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 1018)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.titanic_format_pnl)
        Me.Controls.Add(Me.Titanic_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Titanic"
        Me.Text = "Titanic"
        Me.Titanic_panel.ResumeLayout(False)
        Me.Titanic_panel.PerformLayout()
        Me.TT_vid_pnl.ResumeLayout(False)
        CType(Me.TT_vid_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TT_cast_img3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TT_cast_img2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TT_cast_img4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TT_cast_img1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TT_star_pt_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.titanic_format_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Titanic_panel As Panel
    Friend WithEvents TT_username_lbl As Label
    Friend WithEvents TT_user_review_output As Label
    Friend WithEvents TT_add_review_lbl As Label
    Friend WithEvents TT_user_review_txt As TextBox
    Friend WithEvents TT_Add_btn As Button
    Friend WithEvents TT_user2_review_lbl As Label
    Friend WithEvents TT_user2_name_lbl As Label
    Friend WithEvents TT_user1_review_lbl As Label
    Friend WithEvents TT_user1_lbl As Label
    Friend WithEvents TT_reviews_lbl As Label
    Friend WithEvents TT_top_review_lbl As Label
    Friend WithEvents TT_next_btn As Button
    Friend WithEvents TT_cname4 As Label
    Friend WithEvents TT_cname3 As Label
    Friend WithEvents TT_cname2 As Label
    Friend WithEvents TT_cname1 As Label
    Friend WithEvents TT_cast_img3 As PictureBox
    Friend WithEvents TT_cast_img2 As PictureBox
    Friend WithEvents TT_cast_img4 As PictureBox
    Friend WithEvents TT_cast_img1 As PictureBox
    Friend WithEvents tt_cast_lbl As Label
    Friend WithEvents titanic_desc As Label
    Friend WithEvents TT_dur_time_lbl As Label
    Friend WithEvents TT_rating_val_lbl As Label
    Friend WithEvents TT_star_pt_box As PictureBox
    Friend WithEvents TT_dur_lbl As Label
    Friend WithEvents TT_Rating_lbl As Label
    Friend WithEvents TT_trailer_bg_lbl As Label
    Friend WithEvents TT_moviename_lbl As Label
    Friend WithEvents titanic_format_pnl As Panel
    Friend WithEvents TT_format_nxt_btn As Button
    Friend WithEvents TT_btn_3d As RadioButton
    Friend WithEvents TT_btn_2d As RadioButton
    Friend WithEvents TT_select_format_lbl As Label
    Friend WithEvents TT_vid_pnl As Panel
    Friend WithEvents TT_ply_btn As Button
    Friend WithEvents play_btn As Button
    Friend WithEvents TT_vid_sc As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents minus As Button
    Friend WithEvents cross As Button
End Class
