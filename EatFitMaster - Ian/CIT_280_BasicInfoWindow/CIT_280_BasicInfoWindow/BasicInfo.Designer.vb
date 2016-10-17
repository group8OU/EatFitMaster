<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class window_basicinfo
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
        Me.tcBasicInfo = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.tabBody = New System.Windows.Forms.TabPage()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblLbs = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblFt = New System.Windows.Forms.Label()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.txtFt = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.tabGoals = New System.Windows.Forms.TabPage()
        Me.btnBasicSubmit = New System.Windows.Forms.Button()
        Me.dtpGdate = New System.Windows.Forms.DateTimePicker()
        Me.lblGdate = New System.Windows.Forms.Label()
        Me.txtGweight = New System.Windows.Forms.TextBox()
        Me.lblGWeight = New System.Windows.Forms.Label()
        Me.tabDebug = New System.Windows.Forms.TabPage()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.rtbDebug = New System.Windows.Forms.RichTextBox()
        Me.tcBasicInfo.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabBody.SuspendLayout()
        Me.tabGoals.SuspendLayout()
        Me.tabDebug.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcBasicInfo
        '
        Me.tcBasicInfo.Controls.Add(Me.tabGeneral)
        Me.tcBasicInfo.Controls.Add(Me.tabBody)
        Me.tcBasicInfo.Controls.Add(Me.tabGoals)
        Me.tcBasicInfo.Controls.Add(Me.tabDebug)
        Me.tcBasicInfo.Location = New System.Drawing.Point(12, 12)
        Me.tcBasicInfo.Name = "tcBasicInfo"
        Me.tcBasicInfo.SelectedIndex = 0
        Me.tcBasicInfo.Size = New System.Drawing.Size(348, 235)
        Me.tcBasicInfo.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.radFemale)
        Me.tabGeneral.Controls.Add(Me.radMale)
        Me.tabGeneral.Controls.Add(Me.txtName)
        Me.tabGeneral.Controls.Add(Me.txtAge)
        Me.tabGeneral.Controls.Add(Me.lblName)
        Me.tabGeneral.Controls.Add(Me.lblSex)
        Me.tabGeneral.Controls.Add(Me.lblAge)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(340, 209)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(198, 100)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 6
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(144, 100)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 5
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(144, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(80, 20)
        Me.txtName.TabIndex = 4
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(144, 134)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(43, 20)
        Me.txtAge.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(102, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(113, 100)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 1
        Me.lblSex.Text = "Sex"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(112, 137)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'tabBody
        '
        Me.tabBody.Controls.Add(Me.btnBMI)
        Me.tabBody.Controls.Add(Me.txtBMI)
        Me.tabBody.Controls.Add(Me.lblBMI)
        Me.tabBody.Controls.Add(Me.lblLbs)
        Me.tabBody.Controls.Add(Me.lblWeight)
        Me.tabBody.Controls.Add(Me.txtWeight)
        Me.tabBody.Controls.Add(Me.lblInches)
        Me.tabBody.Controls.Add(Me.lblFt)
        Me.tabBody.Controls.Add(Me.txtInches)
        Me.tabBody.Controls.Add(Me.txtFt)
        Me.tabBody.Controls.Add(Me.lblHeight)
        Me.tabBody.Location = New System.Drawing.Point(4, 22)
        Me.tabBody.Name = "tabBody"
        Me.tabBody.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBody.Size = New System.Drawing.Size(340, 209)
        Me.tabBody.TabIndex = 1
        Me.tabBody.Text = "Body"
        Me.tabBody.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(187, 134)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(68, 20)
        Me.btnBMI.TabIndex = 14
        Me.btnBMI.Text = "Calculate"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'txtBMI
        '
        Me.txtBMI.Location = New System.Drawing.Point(139, 134)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(42, 20)
        Me.txtBMI.TabIndex = 13
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(107, 137)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(26, 13)
        Me.lblBMI.TabIndex = 12
        Me.lblBMI.Text = "BMI"
        '
        'lblLbs
        '
        Me.lblLbs.AutoSize = True
        Me.lblLbs.Location = New System.Drawing.Point(185, 101)
        Me.lblLbs.Name = "lblLbs"
        Me.lblLbs.Size = New System.Drawing.Size(20, 13)
        Me.lblLbs.TabIndex = 11
        Me.lblLbs.Text = "lbs"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(95, 101)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 10
        Me.lblWeight.Text = "Weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(139, 98)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(42, 20)
        Me.txtWeight.TabIndex = 9
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(217, 62)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(38, 13)
        Me.lblInches.TabIndex = 8
        Me.lblInches.Text = "inches"
        '
        'lblFt
        '
        Me.lblFt.AutoSize = True
        Me.lblFt.Location = New System.Drawing.Point(168, 62)
        Me.lblFt.Name = "lblFt"
        Me.lblFt.Size = New System.Drawing.Size(13, 13)
        Me.lblFt.TabIndex = 7
        Me.lblFt.Text = "ft"
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(188, 59)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(23, 20)
        Me.txtInches.TabIndex = 6
        '
        'txtFt
        '
        Me.txtFt.Location = New System.Drawing.Point(139, 59)
        Me.txtFt.Name = "txtFt"
        Me.txtFt.Size = New System.Drawing.Size(23, 20)
        Me.txtFt.TabIndex = 5
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(95, 62)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Height"
        '
        'tabGoals
        '
        Me.tabGoals.Controls.Add(Me.btnBasicSubmit)
        Me.tabGoals.Controls.Add(Me.dtpGdate)
        Me.tabGoals.Controls.Add(Me.lblGdate)
        Me.tabGoals.Controls.Add(Me.txtGweight)
        Me.tabGoals.Controls.Add(Me.lblGWeight)
        Me.tabGoals.Location = New System.Drawing.Point(4, 22)
        Me.tabGoals.Name = "tabGoals"
        Me.tabGoals.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGoals.Size = New System.Drawing.Size(340, 209)
        Me.tabGoals.TabIndex = 2
        Me.tabGoals.Text = "Goals"
        Me.tabGoals.UseVisualStyleBackColor = True
        '
        'btnBasicSubmit
        '
        Me.btnBasicSubmit.Location = New System.Drawing.Point(124, 133)
        Me.btnBasicSubmit.Name = "btnBasicSubmit"
        Me.btnBasicSubmit.Size = New System.Drawing.Size(99, 33)
        Me.btnBasicSubmit.TabIndex = 13
        Me.btnBasicSubmit.Text = "Submit"
        Me.btnBasicSubmit.UseVisualStyleBackColor = True
        '
        'dtpGdate
        '
        Me.dtpGdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGdate.Location = New System.Drawing.Point(161, 93)
        Me.dtpGdate.Name = "dtpGdate"
        Me.dtpGdate.Size = New System.Drawing.Size(99, 20)
        Me.dtpGdate.TabIndex = 12
        '
        'lblGdate
        '
        Me.lblGdate.AutoSize = True
        Me.lblGdate.Location = New System.Drawing.Point(100, 93)
        Me.lblGdate.Name = "lblGdate"
        Me.lblGdate.Size = New System.Drawing.Size(55, 13)
        Me.lblGdate.TabIndex = 11
        Me.lblGdate.Text = "Goal Date"
        '
        'txtGweight
        '
        Me.txtGweight.Location = New System.Drawing.Point(161, 55)
        Me.txtGweight.Name = "txtGweight"
        Me.txtGweight.Size = New System.Drawing.Size(42, 20)
        Me.txtGweight.TabIndex = 10
        '
        'lblGWeight
        '
        Me.lblGWeight.AutoSize = True
        Me.lblGWeight.Location = New System.Drawing.Point(89, 58)
        Me.lblGWeight.Name = "lblGWeight"
        Me.lblGWeight.Size = New System.Drawing.Size(66, 13)
        Me.lblGWeight.TabIndex = 6
        Me.lblGWeight.Text = "Goal Weight"
        '
        'tabDebug
        '
        Me.tabDebug.Controls.Add(Me.btnDebug)
        Me.tabDebug.Controls.Add(Me.rtbDebug)
        Me.tabDebug.ForeColor = System.Drawing.Color.Black
        Me.tabDebug.Location = New System.Drawing.Point(4, 22)
        Me.tabDebug.Name = "tabDebug"
        Me.tabDebug.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDebug.Size = New System.Drawing.Size(340, 209)
        Me.tabDebug.TabIndex = 3
        Me.tabDebug.Text = "Debug"
        Me.tabDebug.UseVisualStyleBackColor = True
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(204, 81)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(98, 50)
        Me.btnDebug.TabIndex = 1
        Me.btnDebug.Text = "Pull Values"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'rtbDebug
        '
        Me.rtbDebug.Location = New System.Drawing.Point(6, 6)
        Me.rtbDebug.Name = "rtbDebug"
        Me.rtbDebug.Size = New System.Drawing.Size(164, 197)
        Me.rtbDebug.TabIndex = 0
        Me.rtbDebug.Text = ""
        '
        'window_basicinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 259)
        Me.Controls.Add(Me.tcBasicInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "window_basicinfo"
        Me.Text = "Basic Info"
        Me.tcBasicInfo.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabBody.ResumeLayout(False)
        Me.tabBody.PerformLayout()
        Me.tabGoals.ResumeLayout(False)
        Me.tabGoals.PerformLayout()
        Me.tabDebug.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcBasicInfo As System.Windows.Forms.TabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabBody As System.Windows.Forms.TabPage
    Friend WithEvents tabGoals As System.Windows.Forms.TabPage
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtFt As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtInches As System.Windows.Forms.TextBox
    Friend WithEvents lblInches As System.Windows.Forms.Label
    Friend WithEvents lblFt As System.Windows.Forms.Label
    Friend WithEvents btnBMI As System.Windows.Forms.Button
    Friend WithEvents txtBMI As System.Windows.Forms.TextBox
    Friend WithEvents lblBMI As System.Windows.Forms.Label
    Friend WithEvents lblLbs As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtGweight As System.Windows.Forms.TextBox
    Friend WithEvents lblGWeight As System.Windows.Forms.Label
    Friend WithEvents dtpGdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGdate As System.Windows.Forms.Label
    Friend WithEvents btnBasicSubmit As System.Windows.Forms.Button
    Friend WithEvents tabDebug As System.Windows.Forms.TabPage
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents rtbDebug As System.Windows.Forms.RichTextBox

End Class
