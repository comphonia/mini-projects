Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim length, width, sqft As Double

        length = CDbl(txtLength1.Text)
        width = CDbl(txtWidth1.Text)
        sqft = length * width
        CalculateRoom1(sqft)
        length = CDbl(txtLength2.Text)
        width = CDbl(txtWidth2.Text)
        sqft = length * width
        CalculateRoom2(sqft)
        length = CDbl(txtLength3.Text)
        width = CDbl(txtWidth3.Text)
        sqft = length * width
        CalculateRoom3(sqft)
        lblTotal.Text = totalCost.ToString


    End Sub

    Dim cost1, cost2, cost3, totalCost As Double
    Const PRICE_SQ_FT As Double = 5.0
    Const PRICE_FLOORING As Double = 1.5
    Const PRICE_FINISHING As Double = 2.0
    Sub CalculateRoom1(ByVal squareFt As Double)
        cost1 += squareFt * PRICE_SQ_FT
        If (chkFlooring1.Checked) Then cost1 += (squareFt * PRICE_FLOORING)
        If (chkFinish1.Checked) Then cost1 += (squareFt * PRICE_FINISHING)
        lblCost1.Text = cost1.ToString
        totalCost += cost1
    End Sub

    Sub CalculateRoom2(ByVal squareFt As Double)
        cost2 += squareFt * PRICE_SQ_FT
        If (chkFlooring2.Checked) Then cost2 += (squareFt * PRICE_FLOORING)
        If (chkFinish2.Checked) Then cost2 += (squareFt * PRICE_FINISHING)
        lblCost2.Text = cost2.ToString
        totalCost += cost2

    End Sub

    Sub CalculateRoom3(ByVal squareFt As Double)
        cost3 += squareFt * PRICE_SQ_FT
        If (chkFlooring3.Checked) Then cost3 += (squareFt * PRICE_FLOORING)
        If (chkFinish3.Checked) Then cost3 += (squareFt * PRICE_FINISHING)
        lblCost3.Text = cost3.ToString
        totalCost += cost3
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim toolTip As New ToolTip
        Me.Text = "Flooring Cost Estimates " + Now.ToString

        toolTip.SetToolTip(Me.txtLength1, "Enter measurement in Ft.")
        toolTip.SetToolTip(Me.txtLength2, "Enter measurement in Ft.")
        toolTip.SetToolTip(Me.txtLength3, "Enter measurement in Ft.")
        toolTip.SetToolTip(Me.txtWidth1, "Enter measurement in Ft.")
        toolTip.SetToolTip(Me.txtWidth2, "Enter measurement in Ft.")
        toolTip.SetToolTip(Me.txtWidth3, "Enter measurement in Ft.")
    End Sub
End Class
