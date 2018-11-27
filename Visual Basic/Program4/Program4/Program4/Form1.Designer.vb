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
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoLarge = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoThin = New System.Windows.Forms.RadioButton()
        Me.rdoThick = New System.Windows.Forms.RadioButton()
        Me.rdoPan = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkSalad = New System.Windows.Forms.CheckBox()
        Me.chkSticks = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDrinks
        '
        Me.txtDrinks.Location = New System.Drawing.Point(268, 263)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(100, 20)
        Me.txtDrinks.TabIndex = 0
        Me.txtDrinks.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. of Drinks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Crust"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Side Orders"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(501, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Toppings"
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Location = New System.Drawing.Point(24, 48)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(86, 17)
        Me.rdoSmall.TabIndex = 6
        Me.rdoSmall.TabStop = True
        Me.rdoSmall.Text = "&Small - $7.00"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Location = New System.Drawing.Point(24, 84)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(104, 17)
        Me.rdoMedium.TabIndex = 7
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "&Medium - $13.00"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoLarge
        '
        Me.rdoLarge.AutoSize = True
        Me.rdoLarge.Location = New System.Drawing.Point(24, 121)
        Me.rdoLarge.Name = "rdoLarge"
        Me.rdoLarge.Size = New System.Drawing.Size(94, 17)
        Me.rdoLarge.TabIndex = 8
        Me.rdoLarge.TabStop = True
        Me.rdoLarge.Text = "&Large - $16.50"
        Me.rdoLarge.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoLarge)
        Me.GroupBox1.Controls.Add(Me.rdoMedium)
        Me.GroupBox1.Controls.Add(Me.rdoSmall)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 164)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'rdoThin
        '
        Me.rdoThin.AutoSize = True
        Me.rdoThin.Location = New System.Drawing.Point(13, 43)
        Me.rdoThin.Name = "rdoThin"
        Me.rdoThin.Size = New System.Drawing.Size(82, 17)
        Me.rdoThin.TabIndex = 10
        Me.rdoThin.TabStop = True
        Me.rdoThin.Text = "T&hin - $0.00"
        Me.rdoThin.UseVisualStyleBackColor = True
        '
        'rdoThick
        '
        Me.rdoThick.AutoSize = True
        Me.rdoThick.Location = New System.Drawing.Point(13, 79)
        Me.rdoThick.Name = "rdoThick"
        Me.rdoThick.Size = New System.Drawing.Size(88, 17)
        Me.rdoThick.TabIndex = 11
        Me.rdoThick.TabStop = True
        Me.rdoThick.Text = "Thi&ck - $1.00"
        Me.rdoThick.UseVisualStyleBackColor = True
        '
        'rdoPan
        '
        Me.rdoPan.AutoSize = True
        Me.rdoPan.Location = New System.Drawing.Point(13, 116)
        Me.rdoPan.Name = "rdoPan"
        Me.rdoPan.Size = New System.Drawing.Size(80, 17)
        Me.rdoPan.TabIndex = 12
        Me.rdoPan.TabStop = True
        Me.rdoPan.Text = "&Pan - $1.50"
        Me.rdoPan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoPan)
        Me.GroupBox2.Controls.Add(Me.rdoThick)
        Me.GroupBox2.Controls.Add(Me.rdoThin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(167, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(124, 158)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(14, 39)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(129, 17)
        Me.chkCheese.TabIndex = 14
        Me.chkCheese.Text = "Cheese &Bread - $1.00"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkSalad
        '
        Me.chkSalad.AutoSize = True
        Me.chkSalad.Location = New System.Drawing.Point(14, 76)
        Me.chkSalad.Name = "chkSalad"
        Me.chkSalad.Size = New System.Drawing.Size(89, 17)
        Me.chkSalad.TabIndex = 15
        Me.chkSalad.Text = "Sa&lad - $1.00"
        Me.chkSalad.UseVisualStyleBackColor = True
        '
        'chkSticks
        '
        Me.chkSticks.AutoSize = True
        Me.chkSticks.Location = New System.Drawing.Point(14, 113)
        Me.chkSticks.Name = "chkSticks"
        Me.chkSticks.Size = New System.Drawing.Size(151, 17)
        Me.chkSticks.TabIndex = 16
        Me.chkSticks.Text = "Fried &Cheesesticks - $1.00"
        Me.chkSticks.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSticks)
        Me.GroupBox3.Controls.Add(Me.chkSalad)
        Me.GroupBox3.Controls.Add(Me.chkCheese)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 154)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Bacon", "Black Olives", "Green Olives", "Green Peppers", "Hamburger", "Mushrooms", "Onions", "Sausage"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(489, 58)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(104, 124)
        Me.CheckedListBox1.TabIndex = 18
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(180, 350)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 19
        Me.btnOrder.Text = "&Order in"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(394, 350)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 20
        Me.btnAbout.Text = "&About Us"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(520, 269)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 470)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDrinks)
        Me.Name = "Form1"
        Me.Text = "Pizza Ordering App"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDrinks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rdoSmall As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoLarge As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoThin As RadioButton
    Friend WithEvents rdoThick As RadioButton
    Friend WithEvents rdoPan As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkSalad As CheckBox
    Friend WithEvents chkSticks As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents lblTotal As Label
End Class
