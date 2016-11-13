Public Class frmWelcome
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

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        NewProfiles.Show()
        Me.Close()
    End Sub

    Private Sub btnLight_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        My.Forms.frmLight.Text = Now.ToString
        My.Forms.frmLight.Show()
        Label2.Text = NewProfiles.basic_firstname

    End Sub

    Private Sub btnHeavy_Click(sender As Object, e As EventArgs) Handles btnHeavy.Click
        My.Forms.frmHeavy.Text = Now.ToString
        My.Forms.frmHeavy.Show()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class