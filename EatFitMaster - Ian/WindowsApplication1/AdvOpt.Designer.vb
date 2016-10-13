<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvOpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvOpt))
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.rbVege = New System.Windows.Forms.RadioButton()
        Me.rbVegan = New System.Windows.Forms.RadioButton()
        Me.rbGluten = New System.Windows.Forms.RadioButton()
        Me.cbPeanut = New System.Windows.Forms.CheckBox()
        Me.cbTreeNut = New System.Windows.Forms.CheckBox()
        Me.cbSoy = New System.Windows.Forms.CheckBox()
        Me.cbEggs = New System.Windows.Forms.CheckBox()
        Me.cbFish = New System.Windows.Forms.CheckBox()
        Me.chShellfish = New System.Windows.Forms.CheckBox()
        Me.cbLactose = New System.Windows.Forms.CheckBox()
        Me.cbWheat = New System.Windows.Forms.CheckBox()
        Me.lblDiet = New System.Windows.Forms.Label()
        Me.lblAllergies = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNone.Location = New System.Drawing.Point(72, 51)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(59, 20)
        Me.rbNone.TabIndex = 12
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'rbVege
        '
        Me.rbVege.AutoSize = True
        Me.rbVege.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVege.Location = New System.Drawing.Point(72, 74)
        Me.rbVege.Name = "rbVege"
        Me.rbVege.Size = New System.Drawing.Size(92, 20)
        Me.rbVege.TabIndex = 13
        Me.rbVege.TabStop = True
        Me.rbVege.Text = "Vegetarian"
        Me.rbVege.UseVisualStyleBackColor = True
        '
        'rbVegan
        '
        Me.rbVegan.AutoSize = True
        Me.rbVegan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVegan.Location = New System.Drawing.Point(72, 97)
        Me.rbVegan.Name = "rbVegan"
        Me.rbVegan.Size = New System.Drawing.Size(66, 20)
        Me.rbVegan.TabIndex = 14
        Me.rbVegan.TabStop = True
        Me.rbVegan.Text = "Vegan"
        Me.rbVegan.UseVisualStyleBackColor = True
        '
        'rbGluten
        '
        Me.rbGluten.AutoSize = True
        Me.rbGluten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGluten.Location = New System.Drawing.Point(72, 120)
        Me.rbGluten.Name = "rbGluten"
        Me.rbGluten.Size = New System.Drawing.Size(95, 20)
        Me.rbGluten.TabIndex = 15
        Me.rbGluten.TabStop = True
        Me.rbGluten.Text = "Gluten Free"
        Me.rbGluten.UseVisualStyleBackColor = True
        '
        'cbPeanut
        '
        Me.cbPeanut.AutoSize = True
        Me.cbPeanut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeanut.Location = New System.Drawing.Point(247, 52)
        Me.cbPeanut.Name = "cbPeanut"
        Me.cbPeanut.Size = New System.Drawing.Size(76, 20)
        Me.cbPeanut.TabIndex = 16
        Me.cbPeanut.Text = "Peanuts"
        Me.cbPeanut.UseVisualStyleBackColor = True
        '
        'cbTreeNut
        '
        Me.cbTreeNut.AutoSize = True
        Me.cbTreeNut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTreeNut.Location = New System.Drawing.Point(247, 75)
        Me.cbTreeNut.Name = "cbTreeNut"
        Me.cbTreeNut.Size = New System.Drawing.Size(86, 20)
        Me.cbTreeNut.TabIndex = 17
        Me.cbTreeNut.Text = "Tree Nuts"
        Me.cbTreeNut.UseVisualStyleBackColor = True
        '
        'cbSoy
        '
        Me.cbSoy.AutoSize = True
        Me.cbSoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSoy.Location = New System.Drawing.Point(247, 97)
        Me.cbSoy.Name = "cbSoy"
        Me.cbSoy.Size = New System.Drawing.Size(51, 20)
        Me.cbSoy.TabIndex = 18
        Me.cbSoy.Text = "Soy"
        Me.cbSoy.UseVisualStyleBackColor = True
        '
        'cbEggs
        '
        Me.cbEggs.AutoSize = True
        Me.cbEggs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEggs.Location = New System.Drawing.Point(247, 121)
        Me.cbEggs.Name = "cbEggs"
        Me.cbEggs.Size = New System.Drawing.Size(59, 20)
        Me.cbEggs.TabIndex = 19
        Me.cbEggs.Text = "Eggs"
        Me.cbEggs.UseVisualStyleBackColor = True
        '
        'cbFish
        '
        Me.cbFish.AutoSize = True
        Me.cbFish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFish.Location = New System.Drawing.Point(340, 52)
        Me.cbFish.Name = "cbFish"
        Me.cbFish.Size = New System.Drawing.Size(52, 20)
        Me.cbFish.TabIndex = 20
        Me.cbFish.Text = "Fish"
        Me.cbFish.UseVisualStyleBackColor = True
        '
        'chShellfish
        '
        Me.chShellfish.AutoSize = True
        Me.chShellfish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chShellfish.Location = New System.Drawing.Point(340, 74)
        Me.chShellfish.Name = "chShellfish"
        Me.chShellfish.Size = New System.Drawing.Size(77, 20)
        Me.chShellfish.TabIndex = 21
        Me.chShellfish.Text = "Shellfish"
        Me.chShellfish.UseVisualStyleBackColor = True
        '
        'cbLactose
        '
        Me.cbLactose.AutoSize = True
        Me.cbLactose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLactose.Location = New System.Drawing.Point(340, 97)
        Me.cbLactose.Name = "cbLactose"
        Me.cbLactose.Size = New System.Drawing.Size(75, 20)
        Me.cbLactose.TabIndex = 22
        Me.cbLactose.Text = "Lactose"
        Me.cbLactose.UseVisualStyleBackColor = True
        '
        'cbWheat
        '
        Me.cbWheat.AutoSize = True
        Me.cbWheat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWheat.Location = New System.Drawing.Point(340, 121)
        Me.cbWheat.Name = "cbWheat"
        Me.cbWheat.Size = New System.Drawing.Size(66, 20)
        Me.cbWheat.TabIndex = 23
        Me.cbWheat.Text = "Wheat"
        Me.cbWheat.UseVisualStyleBackColor = True
        '
        'lblDiet
        '
        Me.lblDiet.AutoSize = True
        Me.lblDiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiet.Location = New System.Drawing.Point(50, 20)
        Me.lblDiet.Name = "lblDiet"
        Me.lblDiet.Size = New System.Drawing.Size(143, 24)
        Me.lblDiet.TabIndex = 24
        Me.lblDiet.Text = "Diet Restrictions"
        '
        'lblAllergies
        '
        Me.lblAllergies.AutoSize = True
        Me.lblAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllergies.Location = New System.Drawing.Point(215, 20)
        Me.lblAllergies.Name = "lblAllergies"
        Me.lblAllergies.Size = New System.Drawing.Size(259, 24)
        Me.lblAllergies.TabIndex = 25
        Me.lblAllergies.Text = "Allergies (Select all that apply)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(196, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Finish!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAdvOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 188)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAllergies)
        Me.Controls.Add(Me.cbWheat)
        Me.Controls.Add(Me.cbLactose)
        Me.Controls.Add(Me.chShellfish)
        Me.Controls.Add(Me.cbFish)
        Me.Controls.Add(Me.cbEggs)
        Me.Controls.Add(Me.cbSoy)
        Me.Controls.Add(Me.cbTreeNut)
        Me.Controls.Add(Me.cbPeanut)
        Me.Controls.Add(Me.lblDiet)
        Me.Controls.Add(Me.rbGluten)
        Me.Controls.Add(Me.rbVegan)
        Me.Controls.Add(Me.rbVege)
        Me.Controls.Add(Me.rbNone)
        Me.Name = "frmAdvOpt"
        Me.Text = "Advanced Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents rbVege As RadioButton
    Friend WithEvents rbVegan As RadioButton
    Friend WithEvents rbGluten As RadioButton
    Friend WithEvents cbPeanut As CheckBox
    Friend WithEvents cbTreeNut As CheckBox
    Friend WithEvents cbSoy As CheckBox
    Friend WithEvents cbEggs As CheckBox
    Friend WithEvents cbFish As CheckBox
    Friend WithEvents chShellfish As CheckBox
    Friend WithEvents cbLactose As CheckBox
    Friend WithEvents cbWheat As CheckBox
    Friend WithEvents lblDiet As Label
    Friend WithEvents lblAllergies As Label
    Friend WithEvents Button1 As Button
End Class
