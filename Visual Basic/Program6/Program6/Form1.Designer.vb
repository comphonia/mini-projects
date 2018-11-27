<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstBread = New System.Windows.Forms.ListBox()
        Me.lstMeat = New System.Windows.Forms.ListBox()
        Me.lstCheese = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clbCondiments = New System.Windows.Forms.CheckedListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstOrder = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstBread
        '
        Me.lstBread.FormattingEnabled = True
        Me.lstBread.Items.AddRange(New Object() {"White", "Wheat", "Rye", "Pita"})
        Me.lstBread.Location = New System.Drawing.Point(36, 166)
        Me.lstBread.Name = "lstBread"
        Me.lstBread.Size = New System.Drawing.Size(120, 95)
        Me.lstBread.TabIndex = 0
        '
        'lstMeat
        '
        Me.lstMeat.FormattingEnabled = True
        Me.lstMeat.Items.AddRange(New Object() {"Beef", "Chicken", "Turkey", "Ham", "Sardine", "No"})
        Me.lstMeat.Location = New System.Drawing.Point(199, 166)
        Me.lstMeat.Name = "lstMeat"
        Me.lstMeat.Size = New System.Drawing.Size(120, 95)
        Me.lstMeat.TabIndex = 1
        '
        'lstCheese
        '
        Me.lstCheese.FormattingEnabled = True
        Me.lstCheese.Items.AddRange(New Object() {"American", "Swiss", "Pepper Jack", "Chedder", "Blue", "No"})
        Me.lstCheese.Location = New System.Drawing.Point(362, 166)
        Me.lstCheese.Name = "lstCheese"
        Me.lstCheese.Size = New System.Drawing.Size(120, 95)
        Me.lstCheese.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bread"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Meat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cheese"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(547, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Condiments"
        '
        'clbCondiments
        '
        Me.clbCondiments.CheckOnClick = True
        Me.clbCondiments.FormattingEnabled = True
        Me.clbCondiments.Items.AddRange(New Object() {"Mustard", "Mayo", "BBQ Sauce", "Lettuce", "Tomato", "Onion"})
        Me.clbCondiments.Location = New System.Drawing.Point(523, 167)
        Me.clbCondiments.Name = "clbCondiments"
        Me.clbCondiments.Size = New System.Drawing.Size(120, 94)
        Me.clbCondiments.TabIndex = 8
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(235, 312)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(362, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Order"
        '
        'lstOrder
        '
        Me.lstOrder.FormattingEnabled = True
        Me.lstOrder.Location = New System.Drawing.Point(281, 403)
        Me.lstOrder.Name = "lstOrder"
        Me.lstOrder.Size = New System.Drawing.Size(120, 95)
        Me.lstOrder.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 522)
        Me.Controls.Add(Me.lstOrder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.clbCondiments)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCheese)
        Me.Controls.Add(Me.lstMeat)
        Me.Controls.Add(Me.lstBread)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBread As ListBox
    Friend WithEvents lstMeat As ListBox
    Friend WithEvents lstCheese As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents clbCondiments As CheckedListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lstOrder As ListBox
End Class
