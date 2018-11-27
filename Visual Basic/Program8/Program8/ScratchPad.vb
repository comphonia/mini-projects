Public Class ScratchPad


    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog.ShowDialog <> DialogResult.Cancel Then
            TextBox1.Font = FontDialog.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog.ShowDialog <> DialogResult.Cancel Then
            TextBox1.BackColor = ColorDialog.Color
        End If
    End Sub
End Class