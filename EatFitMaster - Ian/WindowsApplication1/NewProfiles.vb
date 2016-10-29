Public Class NewProfiles
    Dim basic_errorflag As Boolean = False
    Dim basic_name, basic_sex As String
    Dim basic_age, basic_height, basic_weight, basic_BMI, basic_Gweight As Integer
    Dim basic_Gdate As Date
    Private Sub UserProfilesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserProfilesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserProfilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EatFitDatabaseDataSet)

    End Sub

    Private Sub NewProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EatFitDatabaseDataSet.UserProfiles' table. You can move, or remove it, as needed.
        Me.UserProfilesTableAdapter.Fill(Me.EatFitDatabaseDataSet.UserProfiles)

    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Try
            basic_BMI = ((basic_weight / (basic_height * basic_height)) * 703)
            txtBMI.Text = basic_BMI
        Catch BMIerror As Exception
            MsgBox("Invalid Height or Weight")
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        checkfirstname()
        checksex()
        checkage()
        checkheight()
        checkweight()
        checkBMI()
        checkgoalweight()
        checkgoaldate()
        checkerrors()
    End Sub
    Private Sub checkfirstname()
        'check/store Name
        If txtFirstName.Text.Length > 0 Then
            basic_name = txtFirstName.Text
            basic_errorflag = False
        Else
            lblFirstName.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checksex()
        'check/store Sex
        If txtSex.Text = "F" Then
            basic_sex = "F"
            basic_errorflag = False
        ElseIf txtSex.Text = "M" Then
            basic_sex = "M"
            basic_errorflag = False
        Else
            lblSex.ForeColor = Color.Red
            basic_errorflag = True
        End If

    End Sub
    Private Sub checkage()
        'check/store Age
        If IsNumeric(txtAge.Text) Then
            basic_age = txtAge.Text
            basic_errorflag = False
        Else
            lblAge.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkheight()
        'check/store Height (convert height to inches)
        If IsNumeric(txtHeight) Then
            basic_height = txtHeight
            basic_errorflag = False
        Else
            lblHeight.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkweight()
        'check/store Weight
        If IsNumeric(txtWeight.Text) Then
            basic_weight = txtWeight.Text
            basic_errorflag = False
        Else
            lblWeight.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkBMI()
        'check/calculate BMI
        If IsNumeric(txtBMI.Text) Then
            basic_BMI = txtBMI.Text
            basic_errorflag = False
        Else
            lblBMI.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkgoalweight()
        'check/store goal weight
        If IsNumeric(txtGoalWeight.Text) Then
            basic_Gweight = txtGoalWeight.Text
            basic_errorflag = False
        Else
            lblGoalWeight.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkgoaldate()
        'store goal date
        basic_Gdate = datGoalDate.Value.Date
    End Sub
    Private Sub checkerrors()
        'check errors/finalize
        If basic_errorflag = True Then
            MsgBox("Some fields are missing. Please correct those highlighted in red.")
        Else
            MsgBox("Successfully submitted!")
            lblFirstName.ForeColor = Color.Black
            lblSex.ForeColor = Color.Black
            lblAge.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblWeight.ForeColor = Color.Black
            lblBMI.ForeColor = Color.Black
            lblGoalWeight.ForeColor = Color.Black
            frmWelcome.Show()
            Me.Close()
        End If
    End Sub
End Class