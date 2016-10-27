Public Class frmAdvOpt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbPeanut.CheckedChanged

    End Sub

    Private Sub lblAllergies_Click(sender As Object, e As EventArgs) Handles lblAllergies.Click

    End Sub

    Private Sub lblDiet_Click(sender As Object, e As EventArgs) Handles lblDiet.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.frmWelcome.Text = Now.ToString
        My.Forms.frmWelcome.Show()
        Me.Close()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).CheckState = CheckState.Unchecked
            End If
        Next
        rbNone.Checked = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        window_basicinfo.Show()
        Me.Close()
    End Sub
End Class
