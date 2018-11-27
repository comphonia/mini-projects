Public Class Form1
    Dim length, width, gallonsNeeded, areaPerGallon, areaPainted, gallonCost, resGallons, resCost As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        length = CInt(txtLength.Text)
        width = CInt(txtWidth.Text)
        gallonsNeeded = CInt(txtPaint.Text)
        areaPerGallon = CInt(txtArea.Text)
        gallonCost = CInt(txtGallon.Text)
        areaPainted = length * width * gallonsNeeded
        gallonsNeeded = areaPainted / areaPerGallon
        resCost = gallonsNeeded * gallonCost
        resGallons = gallonsNeeded
        lblResCost.Text = resCost.ToString
        lblResGallons.Text = resGallons.ToString


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLength.Clear()
        txtWidth.Clear()
        txtArea.Clear()
        txtGallon.Clear()
        txtPaint.Clear()
        lblResCost.Text = String.Empty
        lblResGallons.Text = String.Empty
        txtLength.Select()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
