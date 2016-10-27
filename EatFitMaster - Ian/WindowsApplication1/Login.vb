Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmWelcome.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        window_basicinfo.Show()
        Me.Close()
    End Sub

    Private Sub txtAccount_TextChanged(sender As Object, e As EventArgs) Handles txtAccount.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
