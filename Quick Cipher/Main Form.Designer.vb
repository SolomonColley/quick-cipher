<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.StatsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConversionTimeTextBox = New System.Windows.Forms.TextBox()
        Me.WordCountTextBox = New System.Windows.Forms.TextBox()
        Me.CharCountTextBox = New System.Windows.Forms.TextBox()
        Me.ConversionTimeLabel = New System.Windows.Forms.Label()
        Me.WordCountLabel = New System.Windows.Forms.Label()
        Me.CharCountLabel = New System.Windows.Forms.Label()
        Me.ButtonPanel = New System.Windows.Forms.Panel()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.FromBinaryButton = New System.Windows.Forms.Button()
        Me.ToBinaryButton = New System.Windows.Forms.Button()
        Me.FromBase64Button = New System.Windows.Forms.Button()
        Me.ToBase64Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatsGroupBox.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Location = New System.Drawing.Point(13, 13)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(62, 28)
        Me.InputLabel.TabIndex = 0
        Me.InputLabel.Text = "&Input:"
        '
        'InputTextBox
        '
        Me.InputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InputTextBox.Location = New System.Drawing.Point(18, 45)
        Me.InputTextBox.Multiline = True
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InputTextBox.Size = New System.Drawing.Size(325, 200)
        Me.InputTextBox.TabIndex = 1
        '
        'OutputLabel
        '
        Me.OutputLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(386, 13)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(79, 28)
        Me.OutputLabel.TabIndex = 2
        Me.OutputLabel.Text = "&Output:"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputTextBox.Location = New System.Drawing.Point(391, 45)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputTextBox.Size = New System.Drawing.Size(325, 200)
        Me.OutputTextBox.TabIndex = 3
        '
        'StatsGroupBox
        '
        Me.StatsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatsGroupBox.Controls.Add(Me.ConversionTimeTextBox)
        Me.StatsGroupBox.Controls.Add(Me.WordCountTextBox)
        Me.StatsGroupBox.Controls.Add(Me.CharCountTextBox)
        Me.StatsGroupBox.Controls.Add(Me.ConversionTimeLabel)
        Me.StatsGroupBox.Controls.Add(Me.WordCountLabel)
        Me.StatsGroupBox.Controls.Add(Me.CharCountLabel)
        Me.StatsGroupBox.Location = New System.Drawing.Point(18, 251)
        Me.StatsGroupBox.Name = "StatsGroupBox"
        Me.StatsGroupBox.Size = New System.Drawing.Size(325, 181)
        Me.StatsGroupBox.TabIndex = 4
        Me.StatsGroupBox.TabStop = False
        Me.StatsGroupBox.Text = "Stats"
        '
        'ConversionTimeTextBox
        '
        Me.ConversionTimeTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConversionTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConversionTimeTextBox.Location = New System.Drawing.Point(219, 136)
        Me.ConversionTimeTextBox.Name = "ConversionTimeTextBox"
        Me.ConversionTimeTextBox.ReadOnly = True
        Me.ConversionTimeTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ConversionTimeTextBox.TabIndex = 6
        '
        'WordCountTextBox
        '
        Me.WordCountTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WordCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WordCountTextBox.Location = New System.Drawing.Point(219, 84)
        Me.WordCountTextBox.Name = "WordCountTextBox"
        Me.WordCountTextBox.ReadOnly = True
        Me.WordCountTextBox.Size = New System.Drawing.Size(100, 26)
        Me.WordCountTextBox.TabIndex = 4
        '
        'CharCountTextBox
        '
        Me.CharCountTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CharCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CharCountTextBox.Location = New System.Drawing.Point(219, 32)
        Me.CharCountTextBox.Name = "CharCountTextBox"
        Me.CharCountTextBox.ReadOnly = True
        Me.CharCountTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CharCountTextBox.TabIndex = 3
        '
        'ConversionTimeLabel
        '
        Me.ConversionTimeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConversionTimeLabel.AutoSize = True
        Me.ConversionTimeLabel.Location = New System.Drawing.Point(6, 136)
        Me.ConversionTimeLabel.Name = "ConversionTimeLabel"
        Me.ConversionTimeLabel.Size = New System.Drawing.Size(158, 28)
        Me.ConversionTimeLabel.TabIndex = 2
        Me.ConversionTimeLabel.Text = "Conversion time:"
        '
        'WordCountLabel
        '
        Me.WordCountLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WordCountLabel.AutoSize = True
        Me.WordCountLabel.Location = New System.Drawing.Point(6, 84)
        Me.WordCountLabel.Name = "WordCountLabel"
        Me.WordCountLabel.Size = New System.Drawing.Size(120, 28)
        Me.WordCountLabel.TabIndex = 1
        Me.WordCountLabel.Text = "Word count:"
        '
        'CharCountLabel
        '
        Me.CharCountLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CharCountLabel.AutoSize = True
        Me.CharCountLabel.Location = New System.Drawing.Point(6, 32)
        Me.CharCountLabel.Name = "CharCountLabel"
        Me.CharCountLabel.Size = New System.Drawing.Size(154, 28)
        Me.CharCountLabel.TabIndex = 0
        Me.CharCountLabel.Text = "Character count:"
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPanel.Controls.Add(Me.CopyButton)
        Me.ButtonPanel.Controls.Add(Me.ClearButton)
        Me.ButtonPanel.Controls.Add(Me.FromBinaryButton)
        Me.ButtonPanel.Controls.Add(Me.ToBinaryButton)
        Me.ButtonPanel.Controls.Add(Me.FromBase64Button)
        Me.ButtonPanel.Controls.Add(Me.ToBase64Button)
        Me.ButtonPanel.Controls.Add(Me.ExitButton)
        Me.ButtonPanel.Location = New System.Drawing.Point(391, 251)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(325, 181)
        Me.ButtonPanel.TabIndex = 5
        '
        'CopyButton
        '
        Me.CopyButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyButton.Location = New System.Drawing.Point(167, 4)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(155, 38)
        Me.CopyButton.TabIndex = 6
        Me.CopyButton.Text = "C&opy output"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(167, 94)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(155, 38)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FromBinaryButton
        '
        Me.FromBinaryButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FromBinaryButton.Location = New System.Drawing.Point(3, 139)
        Me.FromBinaryButton.Name = "FromBinaryButton"
        Me.FromBinaryButton.Size = New System.Drawing.Size(155, 38)
        Me.FromBinaryButton.TabIndex = 8
        Me.FromBinaryButton.Text = "From binary"
        Me.FromBinaryButton.UseVisualStyleBackColor = True
        '
        'ToBinaryButton
        '
        Me.ToBinaryButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToBinaryButton.Location = New System.Drawing.Point(3, 94)
        Me.ToBinaryButton.Name = "ToBinaryButton"
        Me.ToBinaryButton.Size = New System.Drawing.Size(155, 38)
        Me.ToBinaryButton.TabIndex = 7
        Me.ToBinaryButton.Text = "To binary"
        Me.ToBinaryButton.UseVisualStyleBackColor = True
        '
        'FromBase64Button
        '
        Me.FromBase64Button.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FromBase64Button.Location = New System.Drawing.Point(3, 49)
        Me.FromBase64Button.Name = "FromBase64Button"
        Me.FromBase64Button.Size = New System.Drawing.Size(155, 38)
        Me.FromBase64Button.TabIndex = 6
        Me.FromBase64Button.Text = "From base64"
        Me.FromBase64Button.UseVisualStyleBackColor = True
        '
        'ToBase64Button
        '
        Me.ToBase64Button.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToBase64Button.Location = New System.Drawing.Point(3, 4)
        Me.ToBase64Button.Name = "ToBase64Button"
        Me.ToBase64Button.Size = New System.Drawing.Size(155, 38)
        Me.ToBase64Button.TabIndex = 6
        Me.ToBase64Button.Text = "To base64"
        Me.ToBase64Button.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(167, 139)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(155, 38)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 444)
        Me.Controls.Add(Me.ButtonPanel)
        Me.Controls.Add(Me.StatsGroupBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.InputLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "MainForm"
        Me.Text = "Quick Cipher"
        Me.StatsGroupBox.ResumeLayout(False)
        Me.StatsGroupBox.PerformLayout()
        Me.ButtonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputLabel As Label
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents StatsGroupBox As GroupBox
    Friend WithEvents ConversionTimeTextBox As TextBox
    Friend WithEvents WordCountTextBox As TextBox
    Friend WithEvents CharCountTextBox As TextBox
    Friend WithEvents ConversionTimeLabel As Label
    Friend WithEvents WordCountLabel As Label
    Friend WithEvents CharCountLabel As Label
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents FromBinaryButton As Button
    Friend WithEvents ToBinaryButton As Button
    Friend WithEvents FromBase64Button As Button
    Friend WithEvents ToBase64Button As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CopyButton As Button
    Friend WithEvents ClearButton As Button
End Class
