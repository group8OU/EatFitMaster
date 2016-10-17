<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(39, 104)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(153, 20)
        Me.txtAccount.TabIndex = 0
        Me.txtAccount.Text = "Account"
        Me.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(39, 130)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(153, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.Text = "Password"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(39, 156)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(153, 40)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Returning User"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(39, 202)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(153, 60)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New User"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 292)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "EatFit Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAccount As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnNew As Button
End Class
