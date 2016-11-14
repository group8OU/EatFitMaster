<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnBreakfast = New System.Windows.Forms.Button()
        Me.btnLunch = New System.Windows.Forms.Button()
        Me.btnDinner = New System.Windows.Forms.Button()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.btnLight = New System.Windows.Forms.Button()
        Me.btnHeavy = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblWorkout = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameTitle = New System.Windows.Forms.Label()
        Me.lblAgeTitle = New System.Windows.Forms.Label()
        Me.lblSexTitle = New System.Windows.Forms.Label()
        Me.lblHeightTitle = New System.Windows.Forms.Label()
        Me.lblWeightTitle = New System.Windows.Forms.Label()
        Me.lblBMITitle = New System.Windows.Forms.Label()
        Me.lblGDTitle = New System.Windows.Forms.Label()
        Me.lblGWTitle = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblGD = New System.Windows.Forms.Label()
        Me.lblGW = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBreakfast
        '
        Me.btnBreakfast.BackColor = System.Drawing.Color.Transparent
        Me.btnBreakfast.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBreakfast.Location = New System.Drawing.Point(29, 53)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Size = New System.Drawing.Size(80, 25)
        Me.btnBreakfast.TabIndex = 0
        Me.btnBreakfast.Text = "Breakfast"
        Me.btnBreakfast.UseVisualStyleBackColor = False
        '
        'btnLunch
        '
        Me.btnLunch.BackColor = System.Drawing.Color.Transparent
        Me.btnLunch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLunch.Location = New System.Drawing.Point(115, 53)
        Me.btnLunch.Name = "btnLunch"
        Me.btnLunch.Size = New System.Drawing.Size(80, 25)
        Me.btnLunch.TabIndex = 1
        Me.btnLunch.Text = "Lunch"
        Me.btnLunch.UseVisualStyleBackColor = False
        '
        'btnDinner
        '
        Me.btnDinner.BackColor = System.Drawing.Color.Transparent
        Me.btnDinner.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDinner.Location = New System.Drawing.Point(29, 101)
        Me.btnDinner.Name = "btnDinner"
        Me.btnDinner.Size = New System.Drawing.Size(80, 25)
        Me.btnDinner.TabIndex = 2
        Me.btnDinner.Text = "Dinner"
        Me.btnDinner.UseVisualStyleBackColor = False
        '
        'btnSnack
        '
        Me.btnSnack.BackColor = System.Drawing.Color.Transparent
        Me.btnSnack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSnack.Location = New System.Drawing.Point(115, 101)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(80, 25)
        Me.btnSnack.TabIndex = 3
        Me.btnSnack.Text = "Snack"
        Me.btnSnack.UseVisualStyleBackColor = False
        '
        'btnLight
        '
        Me.btnLight.BackColor = System.Drawing.Color.Transparent
        Me.btnLight.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLight.Location = New System.Drawing.Point(266, 64)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Size = New System.Drawing.Size(80, 25)
        Me.btnLight.TabIndex = 4
        Me.btnLight.Text = "Light"
        Me.btnLight.UseVisualStyleBackColor = False
        '
        'btnHeavy
        '
        Me.btnHeavy.BackColor = System.Drawing.Color.Transparent
        Me.btnHeavy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeavy.Location = New System.Drawing.Point(367, 64)
        Me.btnHeavy.Name = "btnHeavy"
        Me.btnHeavy.Size = New System.Drawing.Size(80, 25)
        Me.btnHeavy.TabIndex = 5
        Me.btnHeavy.Text = "Heavy"
        Me.btnHeavy.UseVisualStyleBackColor = False
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(25, 9)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(188, 23)
        Me.lblFullName.TabIndex = 6
        Me.lblFullName.Text = "Select a Meal Type"
        '
        'lblWorkout
        '
        Me.lblWorkout.AutoSize = True
        Me.lblWorkout.BackColor = System.Drawing.Color.Transparent
        Me.lblWorkout.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkout.Location = New System.Drawing.Point(248, 16)
        Me.lblWorkout.Name = "lblWorkout"
        Me.lblWorkout.Size = New System.Drawing.Size(224, 23)
        Me.lblWorkout.TabIndex = 7
        Me.lblWorkout.Text = "Select a Workout Type"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(138, 208)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.Text = "<- Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(328, 101)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(122, 20)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "User's full name"
        '
        'lblNameTitle
        '
        Me.lblNameTitle.AutoSize = True
        Me.lblNameTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblNameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameTitle.Location = New System.Drawing.Point(267, 101)
        Me.lblNameTitle.Name = "lblNameTitle"
        Me.lblNameTitle.Size = New System.Drawing.Size(55, 20)
        Me.lblNameTitle.TabIndex = 10
        Me.lblNameTitle.Text = "Name:"
        '
        'lblAgeTitle
        '
        Me.lblAgeTitle.AutoSize = True
        Me.lblAgeTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAgeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeTitle.Location = New System.Drawing.Point(280, 141)
        Me.lblAgeTitle.Name = "lblAgeTitle"
        Me.lblAgeTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblAgeTitle.TabIndex = 11
        Me.lblAgeTitle.Text = "Age:"
        '
        'lblSexTitle
        '
        Me.lblSexTitle.AutoSize = True
        Me.lblSexTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSexTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexTitle.Location = New System.Drawing.Point(282, 121)
        Me.lblSexTitle.Name = "lblSexTitle"
        Me.lblSexTitle.Size = New System.Drawing.Size(40, 20)
        Me.lblSexTitle.TabIndex = 12
        Me.lblSexTitle.Text = "Sex:"
        '
        'lblHeightTitle
        '
        Me.lblHeightTitle.AutoSize = True
        Me.lblHeightTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHeightTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightTitle.Location = New System.Drawing.Point(262, 161)
        Me.lblHeightTitle.Name = "lblHeightTitle"
        Me.lblHeightTitle.Size = New System.Drawing.Size(60, 20)
        Me.lblHeightTitle.TabIndex = 13
        Me.lblHeightTitle.Text = "Height:"
        '
        'lblWeightTitle
        '
        Me.lblWeightTitle.AutoSize = True
        Me.lblWeightTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblWeightTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightTitle.Location = New System.Drawing.Point(259, 181)
        Me.lblWeightTitle.Name = "lblWeightTitle"
        Me.lblWeightTitle.Size = New System.Drawing.Size(63, 20)
        Me.lblWeightTitle.TabIndex = 14
        Me.lblWeightTitle.Text = "Weight:"
        '
        'lblBMITitle
        '
        Me.lblBMITitle.AutoSize = True
        Me.lblBMITitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBMITitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMITitle.Location = New System.Drawing.Point(280, 201)
        Me.lblBMITitle.Name = "lblBMITitle"
        Me.lblBMITitle.Size = New System.Drawing.Size(42, 20)
        Me.lblBMITitle.TabIndex = 15
        Me.lblBMITitle.Text = "BMI:"
        '
        'lblGDTitle
        '
        Me.lblGDTitle.AutoSize = True
        Me.lblGDTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGDTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGDTitle.Location = New System.Drawing.Point(236, 221)
        Me.lblGDTitle.Name = "lblGDTitle"
        Me.lblGDTitle.Size = New System.Drawing.Size(86, 20)
        Me.lblGDTitle.TabIndex = 16
        Me.lblGDTitle.Text = "Goal Date:"
        '
        'lblGWTitle
        '
        Me.lblGWTitle.AutoSize = True
        Me.lblGWTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGWTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGWTitle.Location = New System.Drawing.Point(221, 241)
        Me.lblGWTitle.Name = "lblGWTitle"
        Me.lblGWTitle.Size = New System.Drawing.Size(101, 20)
        Me.lblGWTitle.TabIndex = 17
        Me.lblGWTitle.Text = "Goal Weight:"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(328, 121)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(85, 20)
        Me.lblSex.TabIndex = 18
        Me.lblSex.Text = "User's Sex"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(328, 141)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(87, 20)
        Me.lblAge.TabIndex = 19
        Me.lblAge.Text = "User's Age"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.Transparent
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(328, 161)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(105, 20)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "User's Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(328, 181)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(108, 20)
        Me.lblWeight.TabIndex = 21
        Me.lblWeight.Text = "User's Weight"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.BackColor = System.Drawing.Color.Transparent
        Me.lblBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMI.Location = New System.Drawing.Point(328, 201)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(87, 20)
        Me.lblBMI.TabIndex = 22
        Me.lblBMI.Text = "User's BMI"
        '
        'lblGD
        '
        Me.lblGD.AutoSize = True
        Me.lblGD.BackColor = System.Drawing.Color.Transparent
        Me.lblGD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGD.Location = New System.Drawing.Point(328, 221)
        Me.lblGD.Name = "lblGD"
        Me.lblGD.Size = New System.Drawing.Size(131, 20)
        Me.lblGD.TabIndex = 23
        Me.lblGD.Text = "User's Goal Date"
        '
        'lblGW
        '
        Me.lblGW.AutoSize = True
        Me.lblGW.BackColor = System.Drawing.Color.Transparent
        Me.lblGW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGW.Location = New System.Drawing.Point(328, 241)
        Me.lblGW.Name = "lblGW"
        Me.lblGW.Size = New System.Drawing.Size(146, 20)
        Me.lblGW.TabIndex = 24
        Me.lblGW.Text = "User's Goal Weight"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(515, 282)
        Me.Controls.Add(Me.lblGW)
        Me.Controls.Add(Me.lblGD)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblGWTitle)
        Me.Controls.Add(Me.lblGDTitle)
        Me.Controls.Add(Me.lblBMITitle)
        Me.Controls.Add(Me.lblWeightTitle)
        Me.Controls.Add(Me.lblHeightTitle)
        Me.Controls.Add(Me.lblSexTitle)
        Me.Controls.Add(Me.lblAgeTitle)
        Me.Controls.Add(Me.lblNameTitle)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblWorkout)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.btnHeavy)
        Me.Controls.Add(Me.btnLight)
        Me.Controls.Add(Me.btnSnack)
        Me.Controls.Add(Me.btnDinner)
        Me.Controls.Add(Me.btnLunch)
        Me.Controls.Add(Me.btnBreakfast)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBreakfast As Button
    Friend WithEvents btnLunch As Button
    Friend WithEvents btnDinner As Button
    Friend WithEvents btnSnack As Button
    Friend WithEvents btnLight As Button
    Friend WithEvents btnHeavy As Button
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblWorkout As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblNameTitle As Label
    Friend WithEvents lblAgeTitle As Label
    Friend WithEvents lblSexTitle As Label
    Friend WithEvents lblHeightTitle As Label
    Friend WithEvents lblWeightTitle As Label
    Friend WithEvents lblBMITitle As Label
    Friend WithEvents lblGDTitle As Label
    Friend WithEvents lblGWTitle As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblGD As Label
    Friend WithEvents lblGW As Label
End Class
