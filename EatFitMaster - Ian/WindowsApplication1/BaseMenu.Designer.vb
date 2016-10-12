<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.btnBreakfast = New System.Windows.Forms.Button()
        Me.btnLunch = New System.Windows.Forms.Button()
        Me.btnDinner = New System.Windows.Forms.Button()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.btnLight = New System.Windows.Forms.Button()
        Me.btnHeavy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWorkout = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBreakfast
        '
        Me.btnBreakfast.Location = New System.Drawing.Point(29, 93)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Size = New System.Drawing.Size(75, 23)
        Me.btnBreakfast.TabIndex = 0
        Me.btnBreakfast.Text = "Breakfast"
        Me.btnBreakfast.UseVisualStyleBackColor = True
        '
        'btnLunch
        '
        Me.btnLunch.Location = New System.Drawing.Point(110, 93)
        Me.btnLunch.Name = "btnLunch"
        Me.btnLunch.Size = New System.Drawing.Size(75, 23)
        Me.btnLunch.TabIndex = 1
        Me.btnLunch.Text = "Lunch"
        Me.btnLunch.UseVisualStyleBackColor = True
        '
        'btnDinner
        '
        Me.btnDinner.Location = New System.Drawing.Point(29, 122)
        Me.btnDinner.Name = "btnDinner"
        Me.btnDinner.Size = New System.Drawing.Size(75, 23)
        Me.btnDinner.TabIndex = 2
        Me.btnDinner.Text = "Dinner"
        Me.btnDinner.UseVisualStyleBackColor = True
        '
        'btnSnack
        '
        Me.btnSnack.Location = New System.Drawing.Point(110, 122)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(75, 23)
        Me.btnSnack.TabIndex = 3
        Me.btnSnack.Text = "Snack"
        Me.btnSnack.UseVisualStyleBackColor = True
        '
        'btnLight
        '
        Me.btnLight.Location = New System.Drawing.Point(308, 93)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Size = New System.Drawing.Size(75, 23)
        Me.btnLight.TabIndex = 4
        Me.btnLight.Text = "Light"
        Me.btnLight.UseVisualStyleBackColor = True
        '
        'btnHeavy
        '
        Me.btnHeavy.Location = New System.Drawing.Point(308, 122)
        Me.btnHeavy.Name = "btnHeavy"
        Me.btnHeavy.Size = New System.Drawing.Size(75, 23)
        Me.btnHeavy.TabIndex = 5
        Me.btnHeavy.Text = "Heavy"
        Me.btnHeavy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select a Meal Type"
        '
        'lblWorkout
        '
        Me.lblWorkout.AutoSize = True
        Me.lblWorkout.Location = New System.Drawing.Point(288, 62)
        Me.lblWorkout.Name = "lblWorkout"
        Me.lblWorkout.Size = New System.Drawing.Size(117, 13)
        Me.lblWorkout.TabIndex = 7
        Me.lblWorkout.Text = "Select a Workout Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Please select an option!"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 161)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
End Class
