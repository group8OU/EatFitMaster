Public Class frmWelcome
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLunch_Click(sender As Object, e As EventArgs) Handles btnLunch.Click
        My.Forms.frmLunch.Text = Now.ToString
        My.Forms.frmLunch.Show()
    End Sub

    Private Sub btnBreakfast_Click(sender As Object, e As EventArgs) Handles btnBreakfast.Click
        My.Forms.frmBreakfast.Text = Now.ToString
        My.Forms.frmBreakfast.Show()
    End Sub

    Private Sub btnDinner_Click(sender As Object, e As EventArgs) Handles btnDinner.Click
        My.Forms.frmDinner.Text = Now.ToString
        My.Forms.frmDinner.Show()
    End Sub

    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        My.Forms.frmSnack.Text = Now.ToString
        My.Forms.frmSnack.Show()
    End Sub
End Class