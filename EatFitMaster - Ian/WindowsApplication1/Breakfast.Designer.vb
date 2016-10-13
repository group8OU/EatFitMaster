<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreakfast
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
        Me.txtBDrink = New System.Windows.Forms.TextBox()
        Me.txtBFruit = New System.Windows.Forms.TextBox()
        Me.txtBGrain = New System.Windows.Forms.TextBox()
        Me.txtBProtein = New System.Windows.Forms.TextBox()
        Me.pbBDrink = New System.Windows.Forms.PictureBox()
        Me.pbBFruit = New System.Windows.Forms.PictureBox()
        Me.pbBGrain = New System.Windows.Forms.PictureBox()
        Me.pbBProtein = New System.Windows.Forms.PictureBox()
        CType(Me.pbBDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBGrain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBProtein, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBDrink
        '
        Me.txtBDrink.Location = New System.Drawing.Point(351, 112)
        Me.txtBDrink.Name = "txtBDrink"
        Me.txtBDrink.Size = New System.Drawing.Size(100, 20)
        Me.txtBDrink.TabIndex = 27
        '
        'txtBFruit
        '
        Me.txtBFruit.Location = New System.Drawing.Point(245, 112)
        Me.txtBFruit.Name = "txtBFruit"
        Me.txtBFruit.Size = New System.Drawing.Size(100, 20)
        Me.txtBFruit.TabIndex = 26
        '
        'txtBGrain
        '
        Me.txtBGrain.Location = New System.Drawing.Point(139, 112)
        Me.txtBGrain.Name = "txtBGrain"
        Me.txtBGrain.Size = New System.Drawing.Size(100, 20)
        Me.txtBGrain.TabIndex = 25
        '
        'txtBProtein
        '
        Me.txtBProtein.Location = New System.Drawing.Point(33, 112)
        Me.txtBProtein.Name = "txtBProtein"
        Me.txtBProtein.Size = New System.Drawing.Size(100, 20)
        Me.txtBProtein.TabIndex = 24
        '
        'pbBDrink
        '
        Me.pbBDrink.Location = New System.Drawing.Point(351, 28)
        Me.pbBDrink.Name = "pbBDrink"
        Me.pbBDrink.Size = New System.Drawing.Size(100, 78)
        Me.pbBDrink.TabIndex = 23
        Me.pbBDrink.TabStop = False
        '
        'pbBFruit
        '
        Me.pbBFruit.Location = New System.Drawing.Point(245, 28)
        Me.pbBFruit.Name = "pbBFruit"
        Me.pbBFruit.Size = New System.Drawing.Size(100, 78)
        Me.pbBFruit.TabIndex = 22
        Me.pbBFruit.TabStop = False
        '
        'pbBGrain
        '
        Me.pbBGrain.Location = New System.Drawing.Point(139, 28)
        Me.pbBGrain.Name = "pbBGrain"
        Me.pbBGrain.Size = New System.Drawing.Size(100, 78)
        Me.pbBGrain.TabIndex = 21
        Me.pbBGrain.TabStop = False
        '
        'pbBProtein
        '
        Me.pbBProtein.Location = New System.Drawing.Point(33, 28)
        Me.pbBProtein.Name = "pbBProtein"
        Me.pbBProtein.Size = New System.Drawing.Size(100, 78)
        Me.pbBProtein.TabIndex = 20
        Me.pbBProtein.TabStop = False
        '
        'frmBreakfast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(484, 161)
        Me.Controls.Add(Me.txtBDrink)
        Me.Controls.Add(Me.txtBFruit)
        Me.Controls.Add(Me.txtBGrain)
        Me.Controls.Add(Me.txtBProtein)
        Me.Controls.Add(Me.pbBDrink)
        Me.Controls.Add(Me.pbBFruit)
        Me.Controls.Add(Me.pbBGrain)
        Me.Controls.Add(Me.pbBProtein)
        Me.Name = "frmBreakfast"
        Me.Text = "Breakfast"
        CType(Me.pbBDrink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBGrain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBProtein, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtBDrink As TextBox
    Private WithEvents txtBFruit As TextBox
    Private WithEvents txtBGrain As TextBox
    Private WithEvents txtBProtein As TextBox
    Private WithEvents pbBDrink As PictureBox
    Private WithEvents pbBFruit As PictureBox
    Private WithEvents pbBGrain As PictureBox
    Private WithEvents pbBProtein As PictureBox
End Class
