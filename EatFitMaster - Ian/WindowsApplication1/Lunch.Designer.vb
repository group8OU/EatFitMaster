<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLunch
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
        Me.txtLDrink = New System.Windows.Forms.TextBox()
        Me.txtLFruit = New System.Windows.Forms.TextBox()
        Me.txtLGrain = New System.Windows.Forms.TextBox()
        Me.txtLVegetable = New System.Windows.Forms.TextBox()
        Me.txtLProtein = New System.Windows.Forms.TextBox()
        Me.pbLDrink = New System.Windows.Forms.PictureBox()
        Me.pbLFruit = New System.Windows.Forms.PictureBox()
        Me.pbLGrain = New System.Windows.Forms.PictureBox()
        Me.pbLVegetable = New System.Windows.Forms.PictureBox()
        Me.pbLProtein = New System.Windows.Forms.PictureBox()
        CType(Me.pbLDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLGrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLVegetable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLProtein, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLDrink
        '
        Me.txtLDrink.Location = New System.Drawing.Point(454, 112)
        Me.txtLDrink.Name = "txtLDrink"
        Me.txtLDrink.Size = New System.Drawing.Size(100, 20)
        Me.txtLDrink.TabIndex = 29
        '
        'txtLFruit
        '
        Me.txtLFruit.Location = New System.Drawing.Point(348, 112)
        Me.txtLFruit.Name = "txtLFruit"
        Me.txtLFruit.Size = New System.Drawing.Size(100, 20)
        Me.txtLFruit.TabIndex = 28
        '
        'txtLGrain
        '
        Me.txtLGrain.Location = New System.Drawing.Point(242, 112)
        Me.txtLGrain.Name = "txtLGrain"
        Me.txtLGrain.Size = New System.Drawing.Size(100, 20)
        Me.txtLGrain.TabIndex = 27
        '
        'txtLVegetable
        '
        Me.txtLVegetable.Location = New System.Drawing.Point(136, 112)
        Me.txtLVegetable.Name = "txtLVegetable"
        Me.txtLVegetable.Size = New System.Drawing.Size(100, 20)
        Me.txtLVegetable.TabIndex = 26
        '
        'txtLProtein
        '
        Me.txtLProtein.Location = New System.Drawing.Point(30, 112)
        Me.txtLProtein.Name = "txtLProtein"
        Me.txtLProtein.Size = New System.Drawing.Size(100, 20)
        Me.txtLProtein.TabIndex = 25
        '
        'pbLDrink
        '
        Me.pbLDrink.Location = New System.Drawing.Point(454, 28)
        Me.pbLDrink.Name = "pbLDrink"
        Me.pbLDrink.Size = New System.Drawing.Size(100, 78)
        Me.pbLDrink.TabIndex = 24
        Me.pbLDrink.TabStop = False
        '
        'pbLFruit
        '
        Me.pbLFruit.Location = New System.Drawing.Point(348, 28)
        Me.pbLFruit.Name = "pbLFruit"
        Me.pbLFruit.Size = New System.Drawing.Size(100, 78)
        Me.pbLFruit.TabIndex = 23
        Me.pbLFruit.TabStop = False
        '
        'pbLGrain
        '
        Me.pbLGrain.Location = New System.Drawing.Point(242, 28)
        Me.pbLGrain.Name = "pbLGrain"
        Me.pbLGrain.Size = New System.Drawing.Size(100, 78)
        Me.pbLGrain.TabIndex = 22
        Me.pbLGrain.TabStop = False
        '
        'pbLVegetable
        '
        Me.pbLVegetable.Location = New System.Drawing.Point(136, 28)
        Me.pbLVegetable.Name = "pbLVegetable"
        Me.pbLVegetable.Size = New System.Drawing.Size(100, 78)
        Me.pbLVegetable.TabIndex = 21
        Me.pbLVegetable.TabStop = False
        '
        'pbLProtein
        '
        Me.pbLProtein.Location = New System.Drawing.Point(30, 28)
        Me.pbLProtein.Name = "pbLProtein"
        Me.pbLProtein.Size = New System.Drawing.Size(100, 78)
        Me.pbLProtein.TabIndex = 20
        Me.pbLProtein.TabStop = False
        '
        'frmLunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(584, 161)
        Me.Controls.Add(Me.txtLDrink)
        Me.Controls.Add(Me.txtLFruit)
        Me.Controls.Add(Me.txtLGrain)
        Me.Controls.Add(Me.txtLVegetable)
        Me.Controls.Add(Me.txtLProtein)
        Me.Controls.Add(Me.pbLDrink)
        Me.Controls.Add(Me.pbLFruit)
        Me.Controls.Add(Me.pbLGrain)
        Me.Controls.Add(Me.pbLVegetable)
        Me.Controls.Add(Me.pbLProtein)
        Me.Name = "frmLunch"
        Me.Text = "Lunch"
        CType(Me.pbLDrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLGrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLVegetable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLProtein, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtLDrink As TextBox
    Private WithEvents txtLFruit As TextBox
    Private WithEvents txtLGrain As TextBox
    Private WithEvents txtLVegetable As TextBox
    Private WithEvents txtLProtein As TextBox
    Private WithEvents pbLDrink As PictureBox
    Private WithEvents pbLFruit As PictureBox
    Private WithEvents pbLGrain As PictureBox
    Private WithEvents pbLVegetable As PictureBox
    Private WithEvents pbLProtein As PictureBox
End Class
