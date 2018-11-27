Public Class Form1
    Dim infoList As New List(Of Student)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ccontrol As Control
        For Each ccontrol In Me.Controls
            If (TypeOf ccontrol IsNot Label) Then
                ccontrol.Enabled = False
            End If
        Next
        btnNew.Enabled = True
        btnFind.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim ccontrol As Control
        For Each ccontrol In Me.Controls
            If (TypeOf ccontrol IsNot Label) Then
                ccontrol.Enabled = True
            End If
            btnNew.Enabled = False
            btnFind.Enabled = False
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim thisStudent As Student
        Try
            With thisStudent
                ReDim .pointsEarned(2)
                ReDim .pointsPossible(2)
                .name = txtName.Text
                .pointsEarned(0) = CDbl(txtPE1.Text)
                .pointsEarned(1) = CDbl(txtPE2.Text)
                .pointsEarned(2) = CDbl(txtPE3.Text)
                .pointsPossible(0) = CDbl(txtPP1.Text)
                .pointsPossible(1) = CDbl(txtPP2.Text)
                .pointsPossible(2) = CDbl(txtPP3.Text)
            End With
            infoList.Add(thisStudent)
        Catch ex As Exception
            MessageBox.Show("Bad data")
        End Try
        For Each ccontrol As Control In Me.Controls
            ccontrol.Enabled = True

        Next

    End Sub

    Dim i As Integer = 0
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        txtName.Text = infoList(i).name
        txtPE1.Text = infoList(i).pointsPossible(0).ToString()
        txtPE2.Text = infoList(i).pointsPossible(1).ToString()
        txtPE3.Text = infoList(i).pointsPossible(2).ToString()
        txtPP1.Text = infoList(i).pointsPossible(0).ToString()
        txtPP2.Text = infoList(i).pointsPossible(1).ToString()
        txtPP3.Text = infoList(i).pointsPossible(2).ToString()

        If i = infoList.Count - 1 Then
            i = 0
        Else i += 1
        End If
    End Sub


End Class
