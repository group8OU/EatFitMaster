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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWorkout = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select a Meal Type"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 243)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblWorkout)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWorkout As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label2 As Label
End Class
