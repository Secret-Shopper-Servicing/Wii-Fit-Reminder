<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ByeButton = New System.Windows.Forms.Button()
        Me.CreditButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExpertRadio = New System.Windows.Forms.RadioButton()
        Me.MedRadio = New System.Windows.Forms.RadioButton()
        Me.EasyRadio = New System.Windows.Forms.RadioButton()
        Me.NotifyMe = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureMeButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervalBox = New System.Windows.Forms.TextBox()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TrayMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByeButton
        '
        Me.ByeButton.BackColor = System.Drawing.SystemColors.Control
        Me.ByeButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ByeButton.FlatAppearance.BorderSize = 2
        Me.ByeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ByeButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ByeButton.Location = New System.Drawing.Point(217, 175)
        Me.ByeButton.Name = "ByeButton"
        Me.ByeButton.Size = New System.Drawing.Size(69, 23)
        Me.ByeButton.TabIndex = 1
        Me.ByeButton.Text = "Close"
        Me.ByeButton.UseVisualStyleBackColor = True
        '
        'CreditButton
        '
        Me.CreditButton.BackColor = System.Drawing.SystemColors.Control
        Me.CreditButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CreditButton.FlatAppearance.BorderSize = 2
        Me.CreditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CreditButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CreditButton.Location = New System.Drawing.Point(12, 175)
        Me.CreditButton.Name = "CreditButton"
        Me.CreditButton.Size = New System.Drawing.Size(69, 23)
        Me.CreditButton.TabIndex = 8
        Me.CreditButton.Text = "Credits"
        Me.CreditButton.UseVisualStyleBackColor = True
        '
        'ExpertRadio
        '
        Me.ExpertRadio.AutoSize = True
        Me.ExpertRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpertRadio.Location = New System.Drawing.Point(14, 19)
        Me.ExpertRadio.Name = "ExpertRadio"
        Me.ExpertRadio.Size = New System.Drawing.Size(55, 17)
        Me.ExpertRadio.TabIndex = 4
        Me.ExpertRadio.TabStop = True
        Me.ExpertRadio.Text = "Expert"
        Me.ExpertRadio.UseVisualStyleBackColor = True
        '
        'MedRadio
        '
        Me.MedRadio.AutoSize = True
        Me.MedRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedRadio.Location = New System.Drawing.Point(14, 42)
        Me.MedRadio.Name = "MedRadio"
        Me.MedRadio.Size = New System.Drawing.Size(83, 17)
        Me.MedRadio.TabIndex = 6
        Me.MedRadio.TabStop = True
        Me.MedRadio.Text = "Intermediate"
        Me.MedRadio.UseVisualStyleBackColor = True
        '
        'EasyRadio
        '
        Me.EasyRadio.AutoSize = True
        Me.EasyRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyRadio.Location = New System.Drawing.Point(14, 65)
        Me.EasyRadio.Name = "EasyRadio"
        Me.EasyRadio.Size = New System.Drawing.Size(48, 17)
        Me.EasyRadio.TabIndex = 7
        Me.EasyRadio.TabStop = True
        Me.EasyRadio.Text = "Easy"
        Me.EasyRadio.UseVisualStyleBackColor = True
        '
        'NotifyMe
        '
        Me.NotifyMe.ContextMenuStrip = Me.TrayMenu
        Me.NotifyMe.Icon = CType(resources.GetObject("NotifyMe.Icon"), System.Drawing.Icon)
        Me.NotifyMe.Text = "Wii Fit Reminder"
        Me.NotifyMe.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(153, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Image = Global.Wii_Fit_Reminder.My.Resources.Resources.AppIcon
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Options"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Show"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'ConfigureMeButton
        '
        Me.ConfigureMeButton.Name = "ConfigureMeButton"
        Me.ConfigureMeButton.Size = New System.Drawing.Size(92, 20)
        Me.ConfigureMeButton.Text = "Configure Me"
        '
        'ExitButton
        '
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(63, 20)
        Me.ExitButton.Text = "ByeBye !"
        '
        'IntervalBox
        '
        Me.IntervalBox.Location = New System.Drawing.Point(187, 145)
        Me.IntervalBox.Name = "IntervalBox"
        Me.IntervalBox.ReadOnly = True
        Me.IntervalBox.Size = New System.Drawing.Size(99, 20)
        Me.IntervalBox.TabIndex = 9
        '
        'IntervalLabel
        '
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.IntervalLabel.Location = New System.Drawing.Point(244, 129)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(42, 13)
        Me.IntervalLabel.TabIndex = 10
        Me.IntervalLabel.Text = "Interval"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SaveButton.FlatAppearance.BorderSize = 2
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.SaveButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaveButton.Location = New System.Drawing.Point(142, 175)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(69, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Apply"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExpertRadio)
        Me.GroupBox1.Controls.Add(Me.MedRadio)
        Me.GroupBox1.Controls.Add(Me.EasyRadio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Intensity Levels"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Wii_Fit_Reminder.My.Resources.Resources.Wiibo
        Me.PictureBox2.Location = New System.Drawing.Point(187, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Wii_Fit_Reminder.My.Resources.Resources.Banner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 210)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.IntervalLabel)
        Me.Controls.Add(Me.IntervalBox)
        Me.Controls.Add(Me.CreditButton)
        Me.Controls.Add(Me.ByeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Wii Fit Reminder"
        Me.TrayMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ByeButton As System.Windows.Forms.Button
    Friend WithEvents CreditButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ExpertRadio As System.Windows.Forms.RadioButton
    Friend WithEvents MedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents EasyRadio As System.Windows.Forms.RadioButton
    Friend WithEvents NotifyMe As System.Windows.Forms.NotifyIcon
    Friend WithEvents ConfigureMeButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntervalBox As System.Windows.Forms.TextBox
    Friend WithEvents IntervalLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
