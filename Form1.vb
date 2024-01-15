Public Class Form1
    'Define the constants used in the program'
    Const intTime_Interval As Integer = 5
    Const intTime_Begin As Integer = 10
    Const intTime_End As Integer = 30
    'Define the variable used to display the number of calories burned per minute'
    Dim dblCaloriesPerMinute As Double
    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        lstOutput.Items.Clear()

        Select Case comboSpeed.Text
            Case Is = "Low"
                dblCaloriesPerMinute = 3.5
            Case Is = "Medium"
                dblCaloriesPerMinute = 4.5
            Case Is = "High"
                dblCaloriesPerMinute = 6
        End Select
        Dim dblCaloriesBurned As Double = dblCaloriesPerMinute * intTime_Interval
        For intCount = 10 To 30 Step 5
            dblCaloriesBurned = dblCaloriesBurned + 5 * dblCaloriesPerMinute
            lstOutput.Items.Add("Minutes " & intCount.ToString & ControlChars.Tab & "Calories Burned: " & dblCaloriesBurned.ToString)

        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class


