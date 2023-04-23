<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportPatientForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFileLoc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.brwsFile = New Guna.UI2.WinForms.Guna2Button()
        Me.impProgBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.upFileBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.imprtDGW = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ProgStat = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.imprtDGW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(554, 19)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(7, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(78, 15)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Import Patient"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(506, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(18, 17)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(527, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(18, 17)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(7, 24)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(257, 22)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Import Patient Record From Excel"
        '
        'txtFileLoc
        '
        Me.txtFileLoc.Animated = True
        Me.txtFileLoc.BorderRadius = 5
        Me.txtFileLoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileLoc.DefaultText = ""
        Me.txtFileLoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFileLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFileLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFileLoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFileLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFileLoc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFileLoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFileLoc.Location = New System.Drawing.Point(47, 52)
        Me.txtFileLoc.Name = "txtFileLoc"
        Me.txtFileLoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFileLoc.PlaceholderText = ""
        Me.txtFileLoc.SelectedText = ""
        Me.txtFileLoc.Size = New System.Drawing.Size(372, 27)
        Me.txtFileLoc.TabIndex = 2
        '
        'brwsFile
        '
        Me.brwsFile.Animated = True
        Me.brwsFile.BorderRadius = 5
        Me.brwsFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.brwsFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.brwsFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.brwsFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.brwsFile.FillColor = System.Drawing.Color.DodgerBlue
        Me.brwsFile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.brwsFile.ForeColor = System.Drawing.Color.White
        Me.brwsFile.Location = New System.Drawing.Point(425, 52)
        Me.brwsFile.Name = "brwsFile"
        Me.brwsFile.Size = New System.Drawing.Size(117, 27)
        Me.brwsFile.TabIndex = 3
        Me.brwsFile.Text = "Browse File"
        '
        'impProgBar
        '
        Me.impProgBar.BorderRadius = 5
        Me.impProgBar.Location = New System.Drawing.Point(47, 85)
        Me.impProgBar.Name = "impProgBar"
        Me.impProgBar.Size = New System.Drawing.Size(372, 25)
        Me.impProgBar.TabIndex = 4
        Me.impProgBar.Text = "Guna2ProgressBar1"
        Me.impProgBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'upFileBtn
        '
        Me.upFileBtn.Animated = True
        Me.upFileBtn.BorderRadius = 5
        Me.upFileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.upFileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.upFileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.upFileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.upFileBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.upFileBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.upFileBtn.ForeColor = System.Drawing.Color.White
        Me.upFileBtn.Location = New System.Drawing.Point(425, 85)
        Me.upFileBtn.Name = "upFileBtn"
        Me.upFileBtn.Size = New System.Drawing.Size(117, 27)
        Me.upFileBtn.TabIndex = 5
        Me.upFileBtn.Text = "Upload File"
        '
        'imprtDGW
        '
        Me.imprtDGW.AllowUserToAddRows = False
        Me.imprtDGW.AllowUserToDeleteRows = False
        Me.imprtDGW.AllowUserToResizeColumns = False
        Me.imprtDGW.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.imprtDGW.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.imprtDGW.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imprtDGW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.imprtDGW.ColumnHeadersHeight = 15
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.imprtDGW.DefaultCellStyle = DataGridViewCellStyle6
        Me.imprtDGW.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.imprtDGW.Location = New System.Drawing.Point(47, 143)
        Me.imprtDGW.Name = "imprtDGW"
        Me.imprtDGW.ReadOnly = True
        Me.imprtDGW.RowHeadersVisible = False
        Me.imprtDGW.Size = New System.Drawing.Size(477, 162)
        Me.imprtDGW.TabIndex = 6
        Me.imprtDGW.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.imprtDGW.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.imprtDGW.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.imprtDGW.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.imprtDGW.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.imprtDGW.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.imprtDGW.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.imprtDGW.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.imprtDGW.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.imprtDGW.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprtDGW.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.imprtDGW.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.imprtDGW.ThemeStyle.HeaderStyle.Height = 15
        Me.imprtDGW.ThemeStyle.ReadOnly = True
        Me.imprtDGW.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.imprtDGW.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.imprtDGW.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprtDGW.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.imprtDGW.ThemeStyle.RowsStyle.Height = 22
        Me.imprtDGW.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.imprtDGW.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(239, 116)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(95, 22)
        Me.Guna2HtmlLabel3.TabIndex = 7
        Me.Guna2HtmlLabel3.Text = "Data Preview"
        '
        'ProgStat
        '
        '
        'ImportPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 317)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.imprtDGW)
        Me.Controls.Add(Me.upFileBtn)
        Me.Controls.Add(Me.impProgBar)
        Me.Controls.Add(Me.brwsFile)
        Me.Controls.Add(Me.txtFileLoc)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImportPatientForm"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.imprtDGW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents imprtDGW As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents upFileBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents impProgBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents brwsFile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFileLoc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ProgStat As Timer
End Class
