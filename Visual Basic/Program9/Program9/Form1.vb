Public Class Form1
    Dim nameArr(0) As String
    Dim scoreArr(0) As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Static i As Integer = 0
        ReDim Preserve nameArr(nameArr.Length)
        ReDim Preserve scoreArr(scoreArr.Length)
        Try
            If (nameArr.Contains(txtName.Text)) Then
                MessageBox.Show("The name " + txtName.Text + " already exists")
            Else
                nameArr(i) = txtName.Text
                scoreArr(i) = CInt(txtGrade.Text)
                i += 1
            End If
        Catch
            MessageBox.Show("Invalid Input")
        End Try

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim curve, largest As Integer
        Dim curveArr(scoreArr.Length - 1) As Integer

        largest = scoreArr(0)

        For index = 0 To scoreArr.Length - 1
            curveArr(index) = scoreArr(index)
            If scoreArr(0) < scoreArr(index) Then
                largest = scoreArr(index)
            End If
        Next

        curve = 100 - largest
        For index = 0 To curveArr.Length - 1
            curveArr(index) += curve
        Next

        For index = 0 To curveArr.Length - 1
            If nameArr(index) <> "" Then
                txtDisplay.Text += nameArr(index) + ControlChars.Tab + curveArr(index).ToString() + ControlChars.CrLf
            End If
        Next


    End Sub


End Class
