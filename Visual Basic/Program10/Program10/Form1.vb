Imports System.IO

Public Class Form1
    Dim theFileName As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        cboThings.Items.Clear()
        cboThings.Text = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        Dim inFile As StreamReader
        Dim theButton As DialogResult
        Dim aJob As JobStuff
        OpenFileDialog1.FileName = theFileName
        theButton = OpenFileDialog1.ShowDialog()
        If theButton = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("File not read")
        Else
            theFileName = OpenFileDialog1.FileName
            inFile = File.OpenText(theFileName)
            Do Until inFile.EndOfStream
                aJob.theName = inFile.ReadLine
                aJob.theHours = CDbl(inFile.ReadLine)
                cboThings.Items.Add(aJob)
            Loop
            inFile.Close()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim theButton As DialogResult
        Dim outFile As StreamWriter
        Dim aJob As JobStuff
        'SaveFileDialog1.FileName = theFileName

        theButton = SaveFileDialog1.ShowDialog()
        If theButton = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("File not read")
        Else
            theFileName = SaveFileDialog1.FileName
            outFile = File.CreateText(theFileName)
            For Each aJob In cboThings.Items
                outFile.WriteLine(aJob.theName)
                outFile.WriteLine(aJob.theHours)
            Next
            outFile.Close()
        End If
    End Sub

    Private Sub EXitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim helpForm As New HelpForm
        helpForm.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim thisJob As New JobStuff
        If cboThings.Text.Trim <> "" Then
            Try
                thisJob.theName = cboThings.Text.Trim
                thisJob.theHours = CDbl(txtEstHours.Text)
                cboThings.Items.Add(thisJob)
                txtEstHours.Clear()
                cboThings.Focus()
            Catch ex As Exception
                MessageBox.Show("Cannot add item", "Error")
            End Try
        Else
            MessageBox.Show("Job name missing")
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim currentJob As JobStuff
        Try
            If cboThings.SelectedIndex > -1 Then
                currentJob = CType(cboThings.SelectedItem, JobStuff)
                currentJob.theHours = CDbl(txtEstHours.Text)
                cboThings.Items(cboThings.SelectedIndex) = currentJob
            Else
                MessageBox.Show("Select item to change")
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot update hours")
        End Try
    End Sub

    Private Sub bntChange_Click(sender As Object, e As EventArgs) Handles bntChange.Click
        If cboThings.SelectedIndex > -1 Then
            cboThings.Items.RemoveAt(cboThings.SelectedIndex)
            txtEstHours.Clear()
        Else
            MessageBox.Show("Select the item to delete")
        End If
    End Sub

    Private Sub cboThings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboThings.SelectedIndexChanged
        Dim currentJob As JobStuff
        If cboThings.SelectedIndex > -1 Then
            currentJob = CType(cboThings.SelectedItem, JobStuff)
            txtEstHours.Text = currentJob.theHours.ToString
        End If
    End Sub
End Class
