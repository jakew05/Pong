<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblP2Points = New System.Windows.Forms.Label()
        Me.lblP1Points = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(340, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Swis721 BdOul BT", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(317, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pong"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(650, 326)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "W"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(716, 392)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 60)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "D"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(651, 392)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 60)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "S"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(585, 392)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 60)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "A"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(248, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(418, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 7
        '
        'lblP2Points
        '
        Me.lblP2Points.AutoSize = True
        Me.lblP2Points.Font = New System.Drawing.Font("Swis721 Blk BT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblP2Points.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblP2Points.Location = New System.Drawing.Point(402, 9)
        Me.lblP2Points.Name = "lblP2Points"
        Me.lblP2Points.Size = New System.Drawing.Size(23, 24)
        Me.lblP2Points.TabIndex = 8
        Me.lblP2Points.Text = "0"
        '
        'lblP1Points
        '
        Me.lblP1Points.AutoSize = True
        Me.lblP1Points.Font = New System.Drawing.Font("Swis721 Blk BT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblP1Points.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblP1Points.Location = New System.Drawing.Point(356, 9)
        Me.lblP1Points.Name = "lblP1Points"
        Me.lblP1Points.Size = New System.Drawing.Size(23, 24)
        Me.lblP1Points.TabIndex = 9
        Me.lblP1Points.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lblP1Points)
        Me.Controls.Add(Me.lblP2Points)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gameTimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblP2Points As Label
    Friend WithEvents lblP1Points As Label
End Class
