Public Class window_basicinfo
    'This form was created by Peter Iacona for CIT 280: Group 8
    'Class level variables
    Dim basic_errorflag As Boolean = False
    Dim basic_name, basic_sex, basic_Gdate As String
    Dim basic_age, basic_height, basic_weight, basic_BMI, basic_Gweight As Integer
    Private Sub btnBasicSubmit_Click(sender As Object, e As EventArgs) Handles btnBasicSubmit.Click
        checkname()
        checksex()
        checkage()
        checkheight()
        checkweight()
        checkBMI()
        checkgoalweight()
        checkgoaldate()
        checkerrors()
    End Sub
    Private Sub checkname()
        'check/store Name
        If txtName.Text.Length > 0 Then
            basic_name = txtName.Text
            basic_errorflag = False
        Else
            lblName.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checksex()
        'check/store Sex
        If radFemale.Checked Then
            basic_sex = "Female"
            basic_errorflag = False
        ElseIf radMale.Checked Then
            basic_sex = "Male"
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
        Try
            basic_height = (txtFt.Text * 12) + (txtInches.Text)
            basic_errorflag = False
        Catch heighterror As Exception
            lblHeight.ForeColor = Color.Red
            basic_errorflag = True
        End Try
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
    Private Sub btnBMICalculate_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        'formula from http://www.bmi-calculator.net/bmi-formula.php
        basic_weight = txtWeight.Text
        basic_height = (txtFt.Text * 12) + (txtInches.Text)
        Try
            basic_BMI = ((basic_weight / (basic_height * basic_height)) * 703)
            txtBMI.Text = basic_BMI
        Catch BMIerror As Exception
            MsgBox("Invalid Height or Weight")
        End Try
    End Sub
    Private Sub checkgoalweight()
        'check/store goal weight
        If IsNumeric(txtGweight.Text) Then
            basic_Gweight = txtGweight.Text
            basic_errorflag = False
        Else
            lblGWeight.ForeColor = Color.Red
            basic_errorflag = True
        End If
    End Sub
    Private Sub checkgoaldate()
        'store goal date
        basic_Gdate = dtpGdate.Text
    End Sub
    Private Sub checkerrors()
        'check errors/finalize
        If basic_errorflag = True Then
            MsgBox("Some fields are missing. Please correct those highlighted in red.")
        Else
            MsgBox("Successfully submitted!")
            lblName.ForeColor = Color.Black
            lblSex.ForeColor = Color.Black
            lblAge.ForeColor = Color.Black
            lblHeight.ForeColor = Color.Black
            lblWeight.ForeColor = Color.Black
            lblBMI.ForeColor = Color.Black
            lblGWeight.ForeColor = Color.Black
        End If
    End Sub
    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        rtbDebug.Clear()
        rtbDebug.AppendText("Name: " & basic_name & vbNewLine)
        rtbDebug.AppendText("Sex: " & basic_sex & vbNewLine)
        rtbDebug.AppendText("Age: " & basic_age & vbNewLine)
        rtbDebug.AppendText("Height: " & basic_height & vbNewLine)
        rtbDebug.AppendText("Weight: " & basic_weight & vbNewLine)
        rtbDebug.AppendText("BMI: " & basic_BMI & vbNewLine)
        rtbDebug.AppendText("Goal Weight: " & basic_Gweight & vbNewLine)
        rtbDebug.AppendText("Goal Date: " & basic_Gdate & vbNewLine)
    End Sub
End Class
