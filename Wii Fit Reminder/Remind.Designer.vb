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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.WaitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reminder!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The timer has ended;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It is time for you to play Wii Fit!"
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.SystemColors.Control
        Me.DoneButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DoneButton.FlatAppearance.BorderSize = 2
        Me.DoneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DoneButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DoneButton.Location = New System.Drawing.Point(97, 72)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(65, 23)
        Me.DoneButton.TabIndex = 3
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'WaitButton
        '
        Me.WaitButton.BackColor = System.Drawing.SystemColors.Control
        Me.WaitButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.WaitButton.FlatAppearance.BorderSize = 2
        Me.WaitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WaitButton.Location = New System.Drawing.Point(16, 72)
        Me.WaitButton.Name = "WaitButton"
        Me.WaitButton.Size = New System.Drawing.Size(79, 23)
        Me.WaitButton.TabIndex = 4
        Me.WaitButton.Text = "Postpone"
        Me.WaitButton.UseVisualStyleBackColor = True
        '
        'Remind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(177, 107)
        Me.Controls.Add(Me.WaitButton)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Remind"
        Me.Text = "Wii Fit Reminder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents WaitButton As System.Windows.Forms.Button
End Class
