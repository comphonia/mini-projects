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
        Me.lblLength1 = New System.Windows.Forms.Label()
        Me.txtLength1 = New System.Windows.Forms.TextBox()
        Me.txtWidth1 = New System.Windows.Forms.TextBox()
        Me.lblWidth1 = New System.Windows.Forms.Label()
        Me.chkFlooring1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCost1 = New System.Windows.Forms.Label()
        Me.chkFinish1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCost2 = New System.Windows.Forms.Label()
        Me.chkFinish2 = New System.Windows.Forms.CheckBox()
        Me.chkFlooring2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWidth2 = New System.Windows.Forms.TextBox()
        Me.txtLength2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCost3 = New System.Windows.Forms.Label()
        Me.chkFinish3 = New System.Windows.Forms.CheckBox()
        Me.chkFlooring3 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWidth3 = New System.Windows.Forms.TextBox()
        Me.txtLength3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLength1
        '
        Me.lblLength1.AutoSize = True
        Me.lblLength1.Location = New System.Drawing.Point(15, 32)
        Me.lblLength1.Name = "lblLength1"
        Me.lblLength1.Size = New System.Drawing.Size(40, 13)
        Me.lblLength1.TabIndex = 0
        Me.lblLength1.Text = "Length"
        '
        'txtLength1
        '
        Me.txtLength1.Location = New System.Drawing.Point(86, 25)
        Me.txtLength1.Name = "txtLength1"
        Me.txtLength1.Size = New System.Drawing.Size(100, 20)
        Me.txtLength1.TabIndex = 1
        '
        'txtWidth1
        '
        Me.txtWidth1.Location = New System.Drawing.Point(86, 79)
        Me.txtWidth1.Name = "txtWidth1"
        Me.txtWidth1.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth1.TabIndex = 2
        '
        'lblWidth1
        '
        Me.lblWidth1.AutoSize = True
        Me.lblWidth1.Location = New System.Drawing.Point(15, 85)
        Me.lblWidth1.Name = "lblWidth1"
        Me.lblWidth1.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth1.TabIndex = 3
        Me.lblWidth1.Text = "Width"
        '
        'chkFlooring1
        '
        Me.chkFlooring1.AutoSize = True
        Me.chkFlooring1.Location = New System.Drawing.Point(86, 131)
        Me.chkFlooring1.Name = "chkFlooring1"
        Me.chkFlooring1.Size = New System.Drawing.Size(93, 17)
        Me.chkFlooring1.TabIndex = 4
        Me.chkFlooring1.Text = "Install Flooring"
        Me.chkFlooring1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCost1)
        Me.GroupBox1.Controls.Add(Me.chkFinish1)
        Me.GroupBox1.Controls.Add(Me.chkFlooring1)
        Me.GroupBox1.Controls.Add(Me.lblLength1)
        Me.GroupBox1.Controls.Add(Me.lblWidth1)
        Me.GroupBox1.Controls.Add(Me.txtWidth1)
        Me.GroupBox1.Controls.Add(Me.txtLength1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 220)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room1"
        '
        'lblCost1
        '
        Me.lblCost1.AutoSize = True
        Me.lblCost1.Location = New System.Drawing.Point(94, 200)
        Me.lblCost1.Name = "lblCost1"
        Me.lblCost1.Size = New System.Drawing.Size(33, 13)
        Me.lblCost1.TabIndex = 6
        Me.lblCost1.Text = "cost :"
        '
        'chkFinish1
        '
        Me.chkFinish1.AutoSize = True
        Me.chkFinish1.Location = New System.Drawing.Point(86, 164)
        Me.chkFinish1.Name = "chkFinish1"
        Me.chkFinish1.Size = New System.Drawing.Size(83, 17)
        Me.chkFinish1.TabIndex = 5
        Me.chkFinish1.Text = "Install Finish"
        Me.chkFinish1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCost2)
        Me.GroupBox2.Controls.Add(Me.chkFinish2)
        Me.GroupBox2.Controls.Add(Me.chkFlooring2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtWidth2)
        Me.GroupBox2.Controls.Add(Me.txtLength2)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 220)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room2"
        '
        'lblCost2
        '
        Me.lblCost2.AutoSize = True
        Me.lblCost2.Location = New System.Drawing.Point(86, 200)
        Me.lblCost2.Name = "lblCost2"
        Me.lblCost2.Size = New System.Drawing.Size(33, 13)
        Me.lblCost2.TabIndex = 6
        Me.lblCost2.Text = "cost :"
        '
        'chkFinish2
        '
        Me.chkFinish2.AutoSize = True
        Me.chkFinish2.Location = New System.Drawing.Point(86, 164)
        Me.chkFinish2.Name = "chkFinish2"
        Me.chkFinish2.Size = New System.Drawing.Size(83, 17)
        Me.chkFinish2.TabIndex = 5
        Me.chkFinish2.Text = "Install Finish"
        Me.chkFinish2.UseVisualStyleBackColor = True
        '
        'chkFlooring2
        '
        Me.chkFlooring2.AutoSize = True
        Me.chkFlooring2.Location = New System.Drawing.Point(86, 131)
        Me.chkFlooring2.Name = "chkFlooring2"
        Me.chkFlooring2.Size = New System.Drawing.Size(93, 17)
        Me.chkFlooring2.TabIndex = 4
        Me.chkFlooring2.Text = "Install Flooring"
        Me.chkFlooring2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width"
        '
        'txtWidth2
        '
        Me.txtWidth2.Location = New System.Drawing.Point(86, 79)
        Me.txtWidth2.Name = "txtWidth2"
        Me.txtWidth2.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth2.TabIndex = 2
        '
        'txtLength2
        '
        Me.txtLength2.Location = New System.Drawing.Point(86, 25)
        Me.txtLength2.Name = "txtLength2"
        Me.txtLength2.Size = New System.Drawing.Size(100, 20)
        Me.txtLength2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCost3)
        Me.GroupBox3.Controls.Add(Me.chkFinish3)
        Me.GroupBox3.Controls.Add(Me.chkFlooring3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtWidth3)
        Me.GroupBox3.Controls.Add(Me.txtLength3)
        Me.GroupBox3.Location = New System.Drawing.Point(572, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 220)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Room3"
        '
        'lblCost3
        '
        Me.lblCost3.AutoSize = True
        Me.lblCost3.Location = New System.Drawing.Point(90, 201)
        Me.lblCost3.Name = "lblCost3"
        Me.lblCost3.Size = New System.Drawing.Size(33, 13)
        Me.lblCost3.TabIndex = 6
        Me.lblCost3.Text = "cost :"
        '
        'chkFinish3
        '
        Me.chkFinish3.AutoSize = True
        Me.chkFinish3.Location = New System.Drawing.Point(86, 164)
        Me.chkFinish3.Name = "chkFinish3"
        Me.chkFinish3.Size = New System.Drawing.Size(83, 17)
        Me.chkFinish3.TabIndex = 5
        Me.chkFinish3.Text = "Install Finish"
        Me.chkFinish3.UseVisualStyleBackColor = True
        '
        'chkFlooring3
        '
        Me.chkFlooring3.AutoSize = True
        Me.chkFlooring3.Location = New System.Drawing.Point(86, 131)
        Me.chkFlooring3.Name = "chkFlooring3"
        Me.chkFlooring3.Size = New System.Drawing.Size(93, 17)
        Me.chkFlooring3.TabIndex = 4
        Me.chkFlooring3.Text = "Install Flooring"
        Me.chkFlooring3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Length"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Width"
        '
        'txtWidth3
        '
        Me.txtWidth3.Location = New System.Drawing.Point(86, 79)
        Me.txtWidth3.Name = "txtWidth3"
        Me.txtWidth3.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth3.TabIndex = 2
        '
        'txtLength3
        '
        Me.txtLength3.Location = New System.Drawing.Point(86, 25)
        Me.txtLength3.Name = "txtLength3"
        Me.txtLength3.Size = New System.Drawing.Size(100, 20)
        Me.txtLength3.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(386, 374)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Grand Total   ="
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(461, 437)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 534)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Flooring Cost Estimate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength1 As Label
    Friend WithEvents txtLength1 As TextBox
    Friend WithEvents txtWidth1 As TextBox
    Friend WithEvents lblWidth1 As Label
    Friend WithEvents chkFlooring1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkFinish1 As CheckBox
    Friend WithEvents lblCost1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCost2 As Label
    Friend WithEvents chkFinish2 As CheckBox
    Friend WithEvents chkFlooring2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWidth2 As TextBox
    Friend WithEvents txtLength2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblCost3 As Label
    Friend WithEvents chkFinish3 As CheckBox
    Friend WithEvents chkFlooring3 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWidth3 As TextBox
    Friend WithEvents txtLength3 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
End Class
