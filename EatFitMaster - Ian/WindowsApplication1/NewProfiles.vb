Public Class NewProfiles
    Dim basic_errorflag As Boolean = False
    Public Shared basic_firstname, basic_lastname, basic_sex As String
    Public Shared basic_age, basic_height, basic_weight, basic_BMI, basic_Gweight As Integer
    Public Shared basic_Gdate As Date


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
            txtBMI.Text = ""
            basic_weight = txtWeight.Text
            basic_height = txtHeight.Text
            basic_BMI = ((basic_weight / (basic_height * basic_height)) * 703)
            txtBMI.Text = basic_BMI
            lblBMI.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblWeight.ForeColor = Color.Black
        Catch BMIerror As Exception
            MsgBox("Invalid Height or Weight")
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        checkfirstname()
        checklastname()
        checksex()
        checkage()
        checkheight()
        checkweight()
        checkgoalweight()
        checkgoaldate()
        checkBMI()
        If basic_errorflag = True Then
            checkerrors()
        Else
            UserProfilesBindingSource.EndEdit()
            UserProfilesTableAdapter.Update(EatFitDatabaseDataSet.UserProfiles)
            MessageBox.Show("Data Submitted!", "Successful Save")
            frmWelcome.Show()
            Me.Close()
        End If


    End Sub
    Private Sub checkfirstname()
        'check/store Name
        If txtFirstName.Text.Length > 0 Then
            basic_firstname = txtFirstName.Text
            basic_errorflag = False
            lblFirstName.ForeColor = Color.Black
        Else
            lblFirstName.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checklastname()
        'check/store Name
        If txtLastName.Text.Length > 0 Then
            basic_lastname = txtLastName.Text
            basic_errorflag = False
            lblLastName.ForeColor = Color.Black
        Else
            lblLastName.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checksex()
        'check/store Sex
        If txtSex.Text.ToUpper = "F" Then
            basic_sex = "F"
            txtSex.Text = "F"
            basic_errorflag = False
            lblSex.ForeColor = Color.Black
        ElseIf txtSex.Text.ToUpper = "M" Then
            basic_sex = "M"
            txtSex.Text = "M"
            basic_errorflag = False
            lblSex.ForeColor = Color.Black
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
            lblAge.ForeColor = Color.Black
        Else
            lblAge.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkheight()
        'check/store Height (convert height to inches)
        If IsNumeric(txtHeight.Text) Then
            basic_height = txtHeight.Text
            basic_errorflag = False
            lblHeight.ForeColor = Color.Black
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
            lblWeight.ForeColor = Color.Black
        Else
            lblWeight.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        UserProfilesBindingSource.AddNew() 'adds new user to prevent user mistake of not creating new entry
        enableobjects() 'unlocks form to enter information
    End Sub

    Private Sub btnReturningUser_Click(sender As Object, e As EventArgs) Handles btnReturningUser.Click
        'unlocks form to allow user to find profile
        enableobjects()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            UserProfilesBindingSource.RemoveCurrent()
        Catch ex As Exception
            MessageBox.Show("No More Profiles to Delete", "Deletion Error")
        End Try

    End Sub

    Private Sub btnTempNav_Click(sender As Object, e As EventArgs) Handles btnTempNav.Click
        frmWelcome.Show()
        Me.Close()
    End Sub

    Private Sub checkBMI()
        'check/calculate BMI
        If IsNumeric(txtBMI.Text) Then
            basic_BMI = txtBMI.Text
            basic_errorflag = False
            lblBMI.ForeColor = Color.Black
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
            lblGoalWeight.ForeColor = Color.Black
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
            MsgBox("Some fields are missing or incorrect. Please correct those highlighted in red.", , "Error")
        Else
            lblFirstName.ForeColor = Color.Black
            lblSex.ForeColor = Color.Black
            lblAge.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblWeight.ForeColor = Color.Black
            lblBMI.ForeColor = Color.Black
            lblGoalWeight.ForeColor = Color.Black
            lblLastName.ForeColor = Color.Black
            UserProfilesBindingSource.EndEdit()
            UserProfilesTableAdapter.Update(EatFitDatabaseDataSet.UserProfiles)
            MessageBox.Show("Data Submitted!", "Successful Save")
            frmWelcome.Show()
            Me.Close()
        End If
    End Sub
    Private Sub enableobjects()
        txtAge.Enabled = True
        txtBMI.Enabled = True
        txtFirstName.Enabled = True
        txtGoalWeight.Enabled = True
        txtHeight.Enabled = True
        txtLastName.Enabled = True
        txtSex.Enabled = True
        txtWeight.Enabled = True
        btnBMI.Enabled = True
        btnDelete.Enabled = True
        btnNext.Enabled = True
        chkEgg.Enabled = True
        chkFish.Enabled = True
        chkGlutenFree.Enabled = True
        chkLactose.Enabled = True
        chkNoRestrictions.Enabled = True
        chkPeanut.Enabled = True
        chkShellfish.Enabled = True
        chkSoy.Enabled = True
        chkTreeNut.Enabled = True
        chkVegan.Enabled = True
        chkVegetarian.Enabled = True
        chkWheat.Enabled = True
        datGoalDate.Enabled = True
        UserProfilesBindingNavigator.Enabled = True
    End Sub
End Class