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
        Me.FatRadio = New System.Windows.Forms.RadioButton()
        Me.SizeLabel = New System.Windows.Forms.Label()
        Me.HumanRadio = New System.Windows.Forms.RadioButton()
        Me.SmallRadio = New System.Windows.Forms.RadioButton()
        Me.NotifyMe = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.ConfigureMeButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntervalBox = New System.Windows.Forms.TextBox()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DebugButton = New System.Windows.Forms.Button()
        Me.Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByeButton
        '
        Me.ByeButton.Location = New System.Drawing.Point(181, 175)
        Me.ByeButton.Name = "ByeButton"
        Me.ByeButton.Size = New System.Drawing.Size(105, 23)
        Me.ByeButton.TabIndex = 1
        Me.ByeButton.Text = "No More Remind!"
        Me.ByeButton.UseVisualStyleBackColor = True
        '
        'CreditButton
        '
        Me.CreditButton.Location = New System.Drawing.Point(120, 175)
        Me.CreditButton.Name = "CreditButton"
        Me.CreditButton.Size = New System.Drawing.Size(55, 23)
        Me.CreditButton.TabIndex = 2
        Me.CreditButton.Text = "Credit ..."
        Me.CreditButton.UseVisualStyleBackColor = True
        '
        'FatRadio
        '
        Me.FatRadio.AutoSize = True
        Me.FatRadio.Location = New System.Drawing.Point(22, 97)
        Me.FatRadio.Name = "FatRadio"
        Me.FatRadio.Size = New System.Drawing.Size(81, 17)
        Me.FatRadio.TabIndex = 4
        Me.FatRadio.TabStop = True
        Me.FatRadio.Text = "Fat Peoples"
        Me.FatRadio.UseVisualStyleBackColor = True
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Location = New System.Drawing.Point(12, 71)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(57, 13)
        Me.SizeLabel.TabIndex = 5
        Me.SizeLabel.Text = "Size Mode"
        '
        'HumanRadio
        '
        Me.HumanRadio.AutoSize = True
        Me.HumanRadio.Location = New System.Drawing.Point(22, 120)
        Me.HumanRadio.Name = "HumanRadio"
        Me.HumanRadio.Size = New System.Drawing.Size(63, 17)
        Me.HumanRadio.TabIndex = 6
        Me.HumanRadio.TabStop = True
        Me.HumanRadio.Text = "Peoples"
        Me.HumanRadio.UseVisualStyleBackColor = True
        '
        'SmallRadio
        '
        Me.SmallRadio.AutoSize = True
        Me.SmallRadio.Location = New System.Drawing.Point(22, 143)
        Me.SmallRadio.Name = "SmallRadio"
        Me.SmallRadio.Size = New System.Drawing.Size(91, 17)
        Me.SmallRadio.TabIndex = 7
        Me.SmallRadio.TabStop = True
        Me.SmallRadio.Text = "Short Peoples"
        Me.SmallRadio.UseVisualStyleBackColor = True
        '
        'NotifyMe
        '
        Me.NotifyMe.Icon = CType(resources.GetObject("NotifyMe.Icon"), System.Drawing.Icon)
        Me.NotifyMe.Text = "Wii Fit Reminder"
        Me.NotifyMe.Visible = True
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigureMeButton, Me.ExitButton})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(298, 24)
        Me.Menu.TabIndex = 8
        Me.Menu.Text = "Menu"
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
        Me.IntervalBox.Location = New System.Drawing.Point(234, 94)
        Me.IntervalBox.Name = "IntervalBox"
        Me.IntervalBox.ReadOnly = True
        Me.IntervalBox.Size = New System.Drawing.Size(52, 20)
        Me.IntervalBox.TabIndex = 9
        '
        'IntervalLabel
        '
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Location = New System.Drawing.Point(244, 71)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(42, 13)
        Me.IntervalLabel.TabIndex = 10
        Me.IntervalLabel.Text = "Interval"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(12, 175)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(57, 23)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Finish!"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Wii_Fit_Reminder.My.Resources.Resources.wiiwii
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 59)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DebugButton
        '
        Me.DebugButton.Location = New System.Drawing.Point(209, 12)
        Me.DebugButton.Name = "DebugButton"
        Me.DebugButton.Size = New System.Drawing.Size(77, 23)
        Me.DebugButton.TabIndex = 12
        Me.DebugButton.Text = "OpenRemind"
        Me.DebugButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 210)
        Me.Controls.Add(Me.DebugButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.IntervalLabel)
        Me.Controls.Add(Me.IntervalBox)
        Me.Controls.Add(Me.SmallRadio)
        Me.Controls.Add(Me.HumanRadio)
        Me.Controls.Add(Me.SizeLabel)
        Me.Controls.Add(Me.FatRadio)
        Me.Controls.Add(Me.CreditButton)
        Me.Controls.Add(Me.ByeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Wii Fit Reminder (Unregistered)"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ByeButton As System.Windows.Forms.Button
    Friend WithEvents CreditButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FatRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SizeLabel As System.Windows.Forms.Label
    Friend WithEvents HumanRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SmallRadio As System.Windows.Forms.RadioButton
    Friend WithEvents NotifyMe As System.Windows.Forms.NotifyIcon
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfigureMeButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntervalBox As System.Windows.Forms.TextBox
    Friend WithEvents IntervalLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DebugButton As System.Windows.Forms.Button

End Class
