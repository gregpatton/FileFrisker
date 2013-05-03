<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMethod = New System.Windows.Forms.GroupBox()
        Me.rdbtnString = New System.Windows.Forms.RadioButton()
        Me.rdbtnDictionary = New System.Windows.Forms.RadioButton()
        Me.txtCustomString = New System.Windows.Forms.TextBox()
        Me.cmbDictionary = New System.Windows.Forms.ComboBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cmdSaveToFile = New System.Windows.Forms.Button()
        Me.lstSearchStrings = New System.Windows.Forms.ListBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.lstvwOutput = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdFrisk = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpMethod.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(728, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Frisker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMethod
        '
        Me.grpMethod.Controls.Add(Me.rdbtnString)
        Me.grpMethod.Controls.Add(Me.rdbtnDictionary)
        Me.grpMethod.Controls.Add(Me.txtCustomString)
        Me.grpMethod.Controls.Add(Me.cmbDictionary)
        Me.grpMethod.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMethod.Location = New System.Drawing.Point(383, 72)
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.Size = New System.Drawing.Size(354, 86)
        Me.grpMethod.TabIndex = 1
        Me.grpMethod.TabStop = False
        Me.grpMethod.Text = "Options"
        '
        'rdbtnString
        '
        Me.rdbtnString.AutoSize = True
        Me.rdbtnString.Location = New System.Drawing.Point(7, 52)
        Me.rdbtnString.Name = "rdbtnString"
        Me.rdbtnString.Size = New System.Drawing.Size(112, 17)
        Me.rdbtnString.TabIndex = 2
        Me.rdbtnString.TabStop = True
        Me.rdbtnString.Text = "Custom String:"
        Me.rdbtnString.UseVisualStyleBackColor = True
        '
        'rdbtnDictionary
        '
        Me.rdbtnDictionary.AutoSize = True
        Me.rdbtnDictionary.Location = New System.Drawing.Point(7, 21)
        Me.rdbtnDictionary.Name = "rdbtnDictionary"
        Me.rdbtnDictionary.Size = New System.Drawing.Size(88, 17)
        Me.rdbtnDictionary.TabIndex = 1
        Me.rdbtnDictionary.TabStop = True
        Me.rdbtnDictionary.Text = "Dictionary:"
        Me.rdbtnDictionary.UseVisualStyleBackColor = True
        '
        'txtCustomString
        '
        Me.txtCustomString.Location = New System.Drawing.Point(119, 52)
        Me.txtCustomString.Name = "txtCustomString"
        Me.txtCustomString.Size = New System.Drawing.Size(226, 21)
        Me.txtCustomString.TabIndex = 4
        '
        'cmbDictionary
        '
        Me.cmbDictionary.FormattingEnabled = True
        Me.cmbDictionary.Location = New System.Drawing.Point(119, 21)
        Me.cmbDictionary.Name = "cmbDictionary"
        Me.cmbDictionary.Size = New System.Drawing.Size(226, 21)
        Me.cmbDictionary.TabIndex = 3
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.ListBox1)
        Me.grpOutput.Controls.Add(Me.cmdSaveToFile)
        Me.grpOutput.Controls.Add(Me.lstSearchStrings)
        Me.grpOutput.Controls.Add(Me.cmdReset)
        Me.grpOutput.Controls.Add(Me.lstvwOutput)
        Me.grpOutput.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOutput.Location = New System.Drawing.Point(12, 164)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(725, 357)
        Me.grpOutput.TabIndex = 3
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(284, 329)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(118, 30)
        Me.ListBox1.TabIndex = 6
        Me.ListBox1.Visible = False
        '
        'cmdSaveToFile
        '
        Me.cmdSaveToFile.Location = New System.Drawing.Point(7, 329)
        Me.cmdSaveToFile.Name = "cmdSaveToFile"
        Me.cmdSaveToFile.Size = New System.Drawing.Size(89, 23)
        Me.cmdSaveToFile.TabIndex = 6
        Me.cmdSaveToFile.Text = "Save to File"
        Me.cmdSaveToFile.UseVisualStyleBackColor = True
        '
        'lstSearchStrings
        '
        Me.lstSearchStrings.FormattingEnabled = True
        Me.lstSearchStrings.Location = New System.Drawing.Point(202, 329)
        Me.lstSearchStrings.Name = "lstSearchStrings"
        Me.lstSearchStrings.Size = New System.Drawing.Size(75, 30)
        Me.lstSearchStrings.TabIndex = 5
        Me.lstSearchStrings.Visible = False
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(102, 329)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 7
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'lstvwOutput
        '
        Me.lstvwOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstvwOutput.FullRowSelect = True
        Me.lstvwOutput.GridLines = True
        Me.lstvwOutput.Location = New System.Drawing.Point(7, 21)
        Me.lstvwOutput.Name = "lstvwOutput"
        Me.lstvwOutput.Size = New System.Drawing.Size(709, 301)
        Me.lstvwOutput.TabIndex = 0
        Me.lstvwOutput.UseCompatibleStateImageBehavior = False
        Me.lstvwOutput.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Finding Type"
        Me.ColumnHeader1.Width = 167
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 145
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Character Location"
        Me.ColumnHeader3.Width = 177
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "File Location"
        Me.ColumnHeader4.Width = 207
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdFrisk)
        Me.GroupBox1.Controls.Add(Me.txtFileName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 86)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'cmdFrisk
        '
        Me.cmdFrisk.Location = New System.Drawing.Point(10, 52)
        Me.cmdFrisk.Name = "cmdFrisk"
        Me.cmdFrisk.Size = New System.Drawing.Size(75, 23)
        Me.cmdFrisk.TabIndex = 5
        Me.cmdFrisk.Text = "Frisk"
        Me.cmdFrisk.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(44, 21)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(298, 21)
        Me.txtFileName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "File:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(754, 533)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpMethod)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Frisker"
        Me.grpMethod.ResumeLayout(False)
        Me.grpMethod.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpMethod As System.Windows.Forms.GroupBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomString As System.Windows.Forms.TextBox
    Friend WithEvents cmbDictionary As System.Windows.Forms.ComboBox
    Friend WithEvents lstvwOutput As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdFrisk As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstSearchStrings As System.Windows.Forms.ListBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdSaveToFile As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents rdbtnString As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnDictionary As System.Windows.Forms.RadioButton

End Class
