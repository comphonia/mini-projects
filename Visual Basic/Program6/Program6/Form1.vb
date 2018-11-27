Public Class Form1


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If lstBread.SelectedIndex < 0 Then
            MessageBox.Show("Please select a bread")
            Exit Sub
        ElseIf lstBread.SelectedIndex > 0 Then
            lstOrder.Items.Add(lstBread.SelectedItem)
        End If

        If lstMeat.SelectedIndex < 0 Then
            MessageBox.Show("Please select a meat")
            Exit Sub
        ElseIf lstMeat.SelectedIndex > 0 Then
            lstOrder.Items.Add(lstMeat.SelectedItem)
        End If

        If lstCheese.SelectedIndex < 0 Then
            MessageBox.Show("Please select a cheese")
            Exit Sub
        ElseIf lstCheese.SelectedIndex > 0 Then
            lstOrder.Items.Add(lstCheese.SelectedItem)
        End If


        With clbCondiments
            For n As Integer = 0 To .Items.Count - 1
                If .GetItemChecked(n) Then
                    lstOrder.Items.Add(.Items(n))
                End If
            Next
        End With


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For n As Integer = 0 To clbCondiments.Items.Count - 1
            clbCondiments.SetItemChecked(n, False)

        Next
        lstBread.SelectedIndex = -1
        lstMeat.SelectedIndex = -1
        lstCheese.SelectedIndex = -1
        lstOrder.Items.Clear()
        clbCondiments.SelectedIndex = -1

    End Sub
End Class
