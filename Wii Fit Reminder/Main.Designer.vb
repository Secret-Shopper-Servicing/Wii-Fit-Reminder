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
        Me.HumanRadio = New System.Windows.Forms.RadioButton()
        Me.SmallRadio = New System.Windows.Forms.RadioButton()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrayMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByeButton
        '
        Me.ByeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ByeButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ByeButton.FlatAppearance.BorderSize = 2
        Me.ByeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ByeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByeButton.ForeColor = System.Drawing.Color.White
        Me.ByeButton.Location = New System.Drawing.Point(142, 175)
        Me.ByeButton.Name = "ByeButton"
        Me.ByeButton.Size = New System.Drawing.Size(83, 23)
        Me.ByeButton.TabIndex = 1
        Me.ByeButton.Text = "No More!!!"
        Me.ByeButton.UseVisualStyleBackColor = False
        '
        'CreditButton
        '
        Me.CreditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreditButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CreditButton.FlatAppearance.BorderSize = 2
        Me.CreditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditButton.ForeColor = System.Drawing.Color.White
        Me.CreditButton.Location = New System.Drawing.Point(75, 175)
        Me.CreditButton.Name = "CreditButton"
        Me.CreditButton.Size = New System.Drawing.Size(61, 23)
        Me.CreditButton.TabIndex = 2
        Me.CreditButton.Text = "Credit ..."
        Me.CreditButton.UseVisualStyleBackColor = False
        '
        'FatRadio
        '
        Me.FatRadio.AutoSize = True
        Me.FatRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FatRadio.Location = New System.Drawing.Point(6, 22)
        Me.FatRadio.Name = "FatRadio"
        Me.FatRadio.Size = New System.Drawing.Size(160, 19)
        Me.FatRadio.TabIndex = 4
        Me.FatRadio.TabStop = True
        Me.FatRadio.Text = "Fat Peoples (Every Hour)"
        Me.FatRadio.UseVisualStyleBackColor = True
        '
        'HumanRadio
        '
        Me.HumanRadio.AutoSize = True
        Me.HumanRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HumanRadio.Location = New System.Drawing.Point(6, 45)
        Me.HumanRadio.Name = "HumanRadio"
        Me.HumanRadio.Size = New System.Drawing.Size(140, 19)
        Me.HumanRadio.TabIndex = 6
        Me.HumanRadio.TabStop = True
        Me.HumanRadio.Text = "Peoples (Every 12Hr)"
        Me.HumanRadio.UseVisualStyleBackColor = True
        '
        'SmallRadio
        '
        Me.SmallRadio.AutoSize = True
        Me.SmallRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmallRadio.Location = New System.Drawing.Point(6, 68)
        Me.SmallRadio.Name = "SmallRadio"
        Me.SmallRadio.Size = New System.Drawing.Size(124, 19)
        Me.SmallRadio.TabIndex = 7
        Me.SmallRadio.TabStop = True
        Me.SmallRadio.Text = "Short (Every 24Hr)"
        Me.SmallRadio.UseVisualStyleBackColor = True
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
        Me.TrayMenu.Size = New System.Drawing.Size(177, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Image = Global.Wii_Fit_Reminder.My.Resources.Resources.TheLittleone
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem1.Text = "Wii Fit Reminder v1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(173, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem2.Text = "Open Software ..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 22)
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
        Me.IntervalBox.Location = New System.Drawing.Point(183, 145)
        Me.IntervalBox.Name = "IntervalBox"
        Me.IntervalBox.ReadOnly = True
        Me.IntervalBox.Size = New System.Drawing.Size(103, 20)
        Me.IntervalBox.TabIndex = 9
        '
        'IntervalLabel
        '
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalLabel.Location = New System.Drawing.Point(183, 121)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(66, 21)
        Me.IntervalLabel.TabIndex = 10
        Me.IntervalLabel.Text = "Interval"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SaveButton.FlatAppearance.BorderSize = 2
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Location = New System.Drawing.Point(6, 175)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(63, 23)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Finish!"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FatRadio)
        Me.GroupBox1.Controls.Add(Me.HumanRadio)
        Me.GroupBox1.Controls.Add(Me.SmallRadio)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interval Presets .."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Friend"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Wii_Fit_Reminder.My.Resources.Resources.WiiFrend
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(187, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(231, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 210)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IntervalLabel)
        Me.Controls.Add(Me.IntervalBox)
        Me.Controls.Add(Me.CreditButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ByeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Wii Fit Reminder (Unregistered)"
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
    Friend WithEvents FatRadio As System.Windows.Forms.RadioButton
    Friend WithEvents HumanRadio As System.Windows.Forms.RadioButton
    Friend WithEvents SmallRadio As System.Windows.Forms.RadioButton
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
