Public Class Form1

    Private Sub Cbonames_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNames.KeyPress
        If e.KeyChar = ControlChars.Cr And cboNames.Text.Trim <> "" Then
            cboNames.Items.Add(cboNames.Text.Trim)
            cboNames.Text = ""

        End If
    End Sub

    Private Sub btnLeftAdd_Click(sender As Object, e As EventArgs) Handles btnLeftAdd.Click
        If cboNames.SelectedIndex > -1 Then
            lstLeft.Items.Add(cboNames.SelectedItem.ToString)
            cboNames.Items.Remove(cboNames.SelectedItem)
        End If
    End Sub

    Private Sub btnLeftRemove_Click(sender As Object, e As EventArgs) Handles btnLeftRemove.Click
        If lstLeft.SelectedIndex > -1 Then
            cboNames.Items.Add(lstLeft.SelectedItem.ToString)
            lstLeft.Items.Remove(lstLeft.SelectedItem)
        End If
    End Sub

    Private Sub btnRightAdd_Click(sender As Object, e As EventArgs) Handles btnRightAdd.Click
        If cboNames.SelectedIndex > -1 Then
            lstRight.Items.Add(cboNames.SelectedItem.ToString)
            cboNames.Items.Remove(cboNames.SelectedItem)
        End If
    End Sub

    Private Sub btnRightRemove_Click(sender As Object, e As EventArgs) Handles btnRightRemove.Click
        If lstRight.SelectedIndex > -1 Then
            cboNames.Items.Add(lstRight.SelectedItem.ToString)
            lstRight.Items.Remove(lstRight.SelectedItem)
        End If


    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Controls.Clear()
        InitializeComponent()


    End Sub
End Class
