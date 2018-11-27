Public Class Form1

    Const taxRate As Double = 0.05


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim listPrice As Double = CDbl(txtListPrice.Text)
            Dim discountPercent As Double = CDbl(txtDiscount.Text)
            Dim discountedPrice, taxedAmount, netAmount As Double
            If listPrice < 0 Or discountPercent < 0 Then
                MessageBox.Show("Negative numbers are not accepted")
            Else
                lblTotalPrice.Text = listPrice.ToString("c")
                'Calculate discount and tax
                discountedPrice = listPrice - (listPrice * (discountPercent / 100))
                taxedAmount = discountedPrice * taxRate
                netAmount = discountedPrice + taxedAmount

                lblDiscountAmount.Text = discountedPrice.ToString("c")
                lblTotalTax.Text = taxedAmount.ToString("c")
                lblNetPrice.Text = netAmount.ToString("c")


            End If

        Catch
            MessageBox.Show("Invalid Data")
        End Try





    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Program Ended")
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        lblDiscountAmount.Text = "0.00"
        lblNetPrice.Text = "0.00"
        lblTotalPrice.Text = "0.00"
        lblTotalTax.Text = "0.00"
        txtDiscount.Text = "0"
        txtListPrice.Text = "0"
        txtDiscount.Text = String.Empty
        txtListPrice.Text = String.Empty
        txtListPrice.Select()

    End Sub
End Class
