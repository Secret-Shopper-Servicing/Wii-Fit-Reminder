<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remind))
        Me.DebugButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NowButton = New System.Windows.Forms.Button()
        Me.RefuseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DebugButton
        '
        Me.DebugButton.Location = New System.Drawing.Point(-2, 1)
        Me.DebugButton.Name = "DebugButton"
        Me.DebugButton.Size = New System.Drawing.Size(75, 23)
        Me.DebugButton.TabIndex = 0
        Me.DebugButton.Text = "OpenMain"
        Me.DebugButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wii Fit Reminder ALERT !!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(20)
        Me.Label2.Size = New System.Drawing.Size(224, 66)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "You Need To Play The Wii Fit NOW!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or You Will Lose ......................."
        '
        'NowButton
        '
        Me.NowButton.Location = New System.Drawing.Point(357, 44)
        Me.NowButton.Name = "NowButton"
        Me.NowButton.Size = New System.Drawing.Size(75, 23)
        Me.NowButton.TabIndex = 3
        Me.NowButton.Text = "Do Now !"
        Me.NowButton.UseVisualStyleBackColor = True
        '
        'RefuseButton
        '
        Me.RefuseButton.Location = New System.Drawing.Point(357, 74)
        Me.RefuseButton.Name = "RefuseButton"
        Me.RefuseButton.Size = New System.Drawing.Size(75, 23)
        Me.RefuseButton.TabIndex = 4
        Me.RefuseButton.Text = "I REFUSE!!"
        Me.RefuseButton.UseVisualStyleBackColor = True
        '
        'Remind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Wii_Fit_Reminder.My.Resources.Resources.fitfit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(444, 128)
        Me.Controls.Add(Me.RefuseButton)
        Me.Controls.Add(Me.NowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DebugButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Remind"
        Me.Text = "Wii Fit Reminder (Unregistered)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DebugButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NowButton As System.Windows.Forms.Button
    Friend WithEvents RefuseButton As System.Windows.Forms.Button
End Class
