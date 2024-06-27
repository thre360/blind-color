<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTentang
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Location = New System.Drawing.Point(365, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 44)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.ListBox1.Font = New System.Drawing.Font("Bahnschrift Condensed", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Items.AddRange(New Object() {"", "Tentang Proyek Game", "", "Judul Proyek: Blind Colour", "", "Deskripsi Singkat", "Blind Colour adalah sebuah game inovatif yang dirancang sebagai bagian dari proye" &
                "k akhir untuk menyelesaikan Ujian Akhir Semester (UAS).", "Game ini menggabungkan elemen-elemen puzzle, ketajaman mata atau ketelitian] untu" &
                "k memberikan pengalaman bermain yang menarik dan edukatif.", "", "Latar Belakang", "Proyek ini dikembangkan dengan tujuan untuk menerapkan berbagai konsep dan ketera" &
                "mpilan yang telah dipelajari selama perkuliahan.", "Mulai dari pemrograman, desain grafis, hingga pembuatan narasi, semua aspek terse" &
                "but diintegrasikan untuk menciptakan sebuah game ", "yang tidak hanya menyenangkan tetapi juga memiliki nilai pendidikan.", "", "Fitur Utama", "1. Gameplay Inovatif: Menawarkan mekanika permainan yang unik dan mengasah.", "2. Grafis Menarik: Desain visual yang yang cukup sederhana namun memiliki nilai e" &
                "dukasi tinggi.", "3. Tingkat Kesulitan yang Beragam: Menyediakan berbagai level yang dirancang untu" &
                "k menguji keterampilan pemain.", "", "Tim Pengembang", "Proyek ini dikembangkan oleh tim yang terdiri dari 2 anggota yaitu Agriva Abel P." &
                " dan Stevensensius mahasiswa dari STMIK Palangka Raya.", "Setiap anggota tim memiliki peran spesifik dalam pengembangan game ini, mulai dar" &
                "i pemrograman, desain grafis, hingga pengujian.", "", "Tujuan dan Manfaat", "Tujuan utama dari pengembangan game ini adalah untuk:", "- Menerapkan teori dan keterampilan yang telah dipelajari dalam lingkungan prakti" &
                "s.", "- Menghasilkan produk kreatif yang dapat dinikmati oleh khalayak luas.", "- Meningkatkan kemampuan kerja sama tim dan manajemen proyek.", "", "Kami berharap bahwa game ini tidak hanya menjadi sarana untuk memenuhi syarat kel" &
                "ulusan, tetapi juga sebagai portofolio yang membanggakan", "dan inspirasi untuk proyek-proyek di masa depan."})
        Me.ListBox1.Location = New System.Drawing.Point(61, 121)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(842, 251)
        Me.ListBox1.TabIndex = 59
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 18.15652!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(938, 39)
        Me.TextBox1.TabIndex = 58
        Me.TextBox1.Text = "TENTANG"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTentang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(962, 487)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmTentang"
        Me.Text = "frmTentang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
End Class
