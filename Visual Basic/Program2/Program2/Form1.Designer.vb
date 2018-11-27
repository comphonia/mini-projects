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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblPaint = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtPaint = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtGallon = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResGallons = New System.Windows.Forms.Label()
        Me.lblResCost = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(44, 80)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(76, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "&Length of Wall"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(44, 119)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(71, 13)
        Me.lblWidth.TabIndex = 3
        Me.lblWidth.Text = "&Width of Wall"
        '
        'lblPaint
        '
        Me.lblPaint.AutoSize = True
        Me.lblPaint.Location = New System.Drawing.Point(44, 158)
        Me.lblPaint.Name = "lblPaint"
        Me.lblPaint.Size = New System.Drawing.Size(105, 13)
        Me.lblPaint.TabIndex = 5
        Me.lblPaint.Text = "&No. of Coats of Paint"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(44, 197)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(138, 13)
        Me.lblArea.TabIndex = 7
        Me.lblArea.Text = "Coverage (&Square ft/gallon)"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(44, 236)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(118, 13)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "Cost per &Gallon of Paint"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount of paint needed to paint a wall"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(200, 73)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 2
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(200, 112)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 4
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPaint
        '
        Me.txtPaint.Location = New System.Drawing.Point(200, 151)
        Me.txtPaint.Name = "txtPaint"
        Me.txtPaint.Size = New System.Drawing.Size(100, 20)
        Me.txtPaint.TabIndex = 6
        Me.txtPaint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(200, 190)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 8
        Me.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGallon
        '
        Me.txtGallon.Location = New System.Drawing.Point(200, 229)
        Me.txtGallon.Name = "txtGallon"
        Me.txtGallon.Size = New System.Drawing.Size(100, 20)
        Me.txtGallon.TabIndex = 10
        Me.txtGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(41, 369)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(140, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResGallons
        '
        Me.lblResGallons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResGallons.Location = New System.Drawing.Point(189, 288)
        Me.lblResGallons.Name = "lblResGallons"
        Me.lblResGallons.Size = New System.Drawing.Size(111, 25)
        Me.lblResGallons.TabIndex = 12
        Me.lblResGallons.Text = "0"
        Me.lblResGallons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResCost
        '
        Me.lblResCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResCost.Location = New System.Drawing.Point(189, 316)
        Me.lblResCost.Name = "lblResCost"
        Me.lblResCost.Size = New System.Drawing.Size(111, 25)
        Me.lblResCost.TabIndex = 14
        Me.lblResCost.Text = "0"
        Me.lblResCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(239, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Gallons needed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total Cost"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResCost)
        Me.Controls.Add(Me.lblResGallons)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtGallon)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtPaint)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblPaint)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Name = "Form1"
        Me.Text = "Paint Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblPaint As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtPaint As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtGallon As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblResGallons As Label
    Friend WithEvents lblResCost As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
