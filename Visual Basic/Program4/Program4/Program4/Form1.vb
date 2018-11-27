Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click


        'CONSTANTS defined
        Const SIDE_ORDERS As Decimal = 1D
        Const TOPPINGS As Decimal = 0.5D

        'VARIABLES defined
        Dim itemChecked As Object
        Dim drinkAmount As Integer
        Dim totalPrice, sizeFee, crustFee, sideFee, toppingFee, drinkFee As Decimal

        'Check Textbox
        If Not Integer.TryParse(txtDrinks.Text, drinkAmount) Then
            drinkFee = CInt(drinkAmount) * 1D
        Else
            drinkFee = 0
        End If
        'Check Size
        If rdoSmall.Checked = True Then
            sizeFee = 7D
        ElseIf rdoMedium.Checked = True Then
            sizeFee = 13D
        ElseIf rdoLarge.Checked = True Then
            sizeFee = 16.5D
        End If
        'Check Crust
        If rdoThin.Checked = True Then
            crustFee = 0D
        ElseIf rdoThick.Checked = True Then
            crustFee = 1D
        ElseIf rdoPan.Checked = True Then
            crustFee = 1.5D
        End If
        'Check Side Orders
        If chkCheese.Checked Or chkSalad.Checked Or chkSticks.Checked = True Then
            sideFee = SIDE_ORDERS
        End If

        For Each itemChecked In CheckedListBox1.CheckedItems
            toppingFee += 0.5D
        Next

        totalPrice = sizeFee + crustFee + sideFee + toppingFee + drinkFee


        'Dialog
        Dim reply As DialogResult
        reply = MessageBox.Show("Is this what you want?", "Are you sure", MessageBoxButtons.YesNo)
        If reply = System.Windows.Forms.DialogResult.Yes Then
            Controls.Clear()
            InitializeComponent()
            rdoSmall.Checked = True
            rdoThin.Checked = True
            MessageBox.Show("Thank you for your order")

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        rdoSmall.Checked = True
        rdoThin.Checked = True
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("All ingredients are fresh when the pizza is delivered and if you have any questions about the amount of fat, salt, or calories in the pizza then you probably should not order one.", "About Us")
    End Sub
End Class
