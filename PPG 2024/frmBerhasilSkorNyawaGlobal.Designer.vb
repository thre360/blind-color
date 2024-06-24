<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBerhasilSkorNyawaGlobal
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
        Me.lblSkorGlobal = New System.Windows.Forms.Label()
        Me.lblNyawaGlobal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SKOR DAN NYAWA GLOBAL"
        '
        'lblSkorGlobal
        '
        Me.lblSkorGlobal.AutoSize = True
        Me.lblSkorGlobal.Location = New System.Drawing.Point(114, 162)
        Me.lblSkorGlobal.Name = "lblSkorGlobal"
        Me.lblSkorGlobal.Size = New System.Drawing.Size(47, 17)
        Me.lblSkorGlobal.TabIndex = 0
        Me.lblSkorGlobal.Text = "SKOR"
        '
        'lblNyawaGlobal
        '
        Me.lblNyawaGlobal.AutoSize = True
        Me.lblNyawaGlobal.Location = New System.Drawing.Point(114, 211)
        Me.lblNyawaGlobal.Name = "lblNyawaGlobal"
        Me.lblNyawaGlobal.Size = New System.Drawing.Size(58, 17)
        Me.lblNyawaGlobal.TabIndex = 0
        Me.lblNyawaGlobal.Text = "NYAWA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 113)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 113)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmBerhasilSkorNyawaGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 438)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNyawaGlobal)
        Me.Controls.Add(Me.lblSkorGlobal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBerhasilSkorNyawaGlobal"
        Me.Text = "frmBerhasilSkorNyawaGlobal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSkorGlobal As System.Windows.Forms.Label
    Friend WithEvents lblNyawaGlobal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
