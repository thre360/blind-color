<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkorNyawaGlobalTimer
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKirimJawaban = New System.Windows.Forms.Button()
        Me.rbD = New System.Windows.Forms.RadioButton()
        Me.gbPertanyaan = New System.Windows.Forms.GroupBox()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.lblPertanyaan = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNyawa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.TPertanyaan1 = New System.Windows.Forms.Timer(Me.components)
        Me.TPertanyaan2 = New System.Windows.Forms.Timer(Me.components)
        Me.gbPertanyaan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nyawa"
        '
        'btnKirimJawaban
        '
        Me.btnKirimJawaban.Location = New System.Drawing.Point(41, 180)
        Me.btnKirimJawaban.Name = "btnKirimJawaban"
        Me.btnKirimJawaban.Size = New System.Drawing.Size(111, 37)
        Me.btnKirimJawaban.TabIndex = 0
        Me.btnKirimJawaban.Text = "Kirim Jawaban"
        Me.btnKirimJawaban.UseVisualStyleBackColor = True
        '
        'rbD
        '
        Me.rbD.AutoSize = True
        Me.rbD.Location = New System.Drawing.Point(311, 134)
        Me.rbD.Name = "rbD"
        Me.rbD.Size = New System.Drawing.Size(38, 20)
        Me.rbD.TabIndex = 4
        Me.rbD.TabStop = True
        Me.rbD.Text = "D"
        Me.rbD.UseVisualStyleBackColor = True
        '
        'gbPertanyaan
        '
        Me.gbPertanyaan.Controls.Add(Me.btnKirimJawaban)
        Me.gbPertanyaan.Controls.Add(Me.rbD)
        Me.gbPertanyaan.Controls.Add(Me.rbC)
        Me.gbPertanyaan.Controls.Add(Me.rbB)
        Me.gbPertanyaan.Controls.Add(Me.rbA)
        Me.gbPertanyaan.Controls.Add(Me.lblPertanyaan)
        Me.gbPertanyaan.Location = New System.Drawing.Point(83, 269)
        Me.gbPertanyaan.Name = "gbPertanyaan"
        Me.gbPertanyaan.Size = New System.Drawing.Size(494, 237)
        Me.gbPertanyaan.TabIndex = 16
        Me.gbPertanyaan.TabStop = False
        Me.gbPertanyaan.Text = "Grup Box"
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(311, 84)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(37, 20)
        Me.rbC.TabIndex = 3
        Me.rbC.TabStop = True
        Me.rbC.Text = "C"
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(41, 134)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(37, 20)
        Me.rbB.TabIndex = 2
        Me.rbB.TabStop = True
        Me.rbB.Text = "B"
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(41, 84)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(37, 20)
        Me.rbA.TabIndex = 1
        Me.rbA.TabStop = True
        Me.rbA.Text = "A"
        Me.rbA.UseVisualStyleBackColor = True
        '
        'lblPertanyaan
        '
        Me.lblPertanyaan.AutoSize = True
        Me.lblPertanyaan.Location = New System.Drawing.Point(38, 49)
        Me.lblPertanyaan.Name = "lblPertanyaan"
        Me.lblPertanyaan.Size = New System.Drawing.Size(79, 16)
        Me.lblPertanyaan.TabIndex = 0
        Me.lblPertanyaan.Text = "Pertanyaan "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(623, 79)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(73, 16)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "NIlai Score"
        '
        'lblNyawa
        '
        Me.lblNyawa.AutoSize = True
        Me.lblNyawa.Location = New System.Drawing.Point(514, 79)
        Me.lblNyawa.Name = "lblNyawa"
        Me.lblNyawa.Size = New System.Drawing.Size(79, 16)
        Me.lblNyawa.TabIndex = 15
        Me.lblNyawa.Text = "Nilai Nyawa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(629, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Waktu"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.Location = New System.Drawing.Point(612, 329)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(87, 33)
        Me.lblWaktu.TabIndex = 17
        Me.lblWaktu.Text = "00:00"
        '
        'TPertanyaan1
        '
        '
        'TPertanyaan2
        '
        '
        'frmSkorNyawaGlobalTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbPertanyaan)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNyawa)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmSkorNyawaGlobalTimer"
        Me.Text = "frmSkorNyawaGlobalTimer"
        Me.gbPertanyaan.ResumeLayout(False)
        Me.gbPertanyaan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnKirimJawaban As System.Windows.Forms.Button
    Friend WithEvents rbD As System.Windows.Forms.RadioButton
    Friend WithEvents gbPertanyaan As System.Windows.Forms.GroupBox
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents lblPertanyaan As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblNyawa As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblWaktu As System.Windows.Forms.Label
    Friend WithEvents TPertanyaan1 As System.Windows.Forms.Timer
    Friend WithEvents TPertanyaan2 As System.Windows.Forms.Timer
End Class
