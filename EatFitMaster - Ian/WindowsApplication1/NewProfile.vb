Public Class NewProfile
    Private Sub UserProfilesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserProfilesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserProfilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EatFitDatabaseDataSet)

    End Sub

    Private Sub NewProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EatFitDatabaseDataSet.UserProfiles' table. You can move, or remove it, as needed.
        Me.UserProfilesTableAdapter.Fill(Me.EatFitDatabaseDataSet.UserProfiles)

    End Sub

    Private Sub VegetarianCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkVegetarian.CheckedChanged
        If chek Then
    End Sub

    Private Sub Goal_DateLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class