<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkorNyawaGlobal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNyawa = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.gbPertanyaan = New System.Windows.Forms.GroupBox()
        Me.btnKirimJawaban = New System.Windows.Forms.Button()
        Me.rbD = New System.Windows.Forms.RadioButton()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.lblPertanyaan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbPertanyaan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nyawa"
        '
        'lblNyawa
        '
        Me.lblNyawa.AutoSize = True
        Me.lblNyawa.Location = New System.Drawing.Point(514, 79)
        Me.lblNyawa.Name = "lblNyawa"
        Me.lblNyawa.Size = New System.Drawing.Size(79, 16)
        Me.lblNyawa.TabIndex = 10
        Me.lblNyawa.Text = "Nilai Nyawa"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(623, 79)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(73, 16)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "NIlai Score"
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
        Me.gbPertanyaan.Size = New System.Drawing.Size(571, 237)
        Me.gbPertanyaan.TabIndex = 11
        Me.gbPertanyaan.TabStop = False
        Me.gbPertanyaan.Text = "Grup Box"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Score"
        '
        'frmSkorNyawaGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNyawa)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.gbPertanyaan)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmSkorNyawaGlobal"
        Me.Text = "frmSkorNyawaGlobal"
        Me.gbPertanyaan.ResumeLayout(False)
        Me.gbPertanyaan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNyawa As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents gbPertanyaan As System.Windows.Forms.GroupBox
    Friend WithEvents btnKirimJawaban As System.Windows.Forms.Button
    Friend WithEvents rbD As System.Windows.Forms.RadioButton
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents lblPertanyaan As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
