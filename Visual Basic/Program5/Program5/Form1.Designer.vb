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
        Me.lstLeft = New System.Windows.Forms.ListBox()
        Me.lstRight = New System.Windows.Forms.ListBox()
        Me.cboNames = New System.Windows.Forms.ComboBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnLeftAdd = New System.Windows.Forms.Button()
        Me.btnLeftRemove = New System.Windows.Forms.Button()
        Me.btnRightAdd = New System.Windows.Forms.Button()
        Me.btnRightRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstLeft
        '
        Me.lstLeft.AllowDrop = True
        Me.lstLeft.FormattingEnabled = True
        Me.lstLeft.Location = New System.Drawing.Point(104, 297)
        Me.lstLeft.Name = "lstLeft"
        Me.lstLeft.Size = New System.Drawing.Size(120, 95)
        Me.lstLeft.Sorted = True
        Me.lstLeft.TabIndex = 1
        '
        'lstRight
        '
        Me.lstRight.AllowDrop = True
        Me.lstRight.FormattingEnabled = True
        Me.lstRight.Location = New System.Drawing.Point(309, 297)
        Me.lstRight.Name = "lstRight"
        Me.lstRight.Size = New System.Drawing.Size(120, 95)
        Me.lstRight.Sorted = True
        Me.lstRight.TabIndex = 2
        '
        'cboNames
        '
        Me.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboNames.FormattingEnabled = True
        Me.cboNames.Items.AddRange(New Object() {"Alice", "Betty", "Buck", "Cathy", "Dawn", "Eve", "Francis", "Gail", "Helen", "Matt"})
        Me.cboNames.Location = New System.Drawing.Point(188, 60)
        Me.cboNames.Name = "cboNames"
        Me.cboNames.Size = New System.Drawing.Size(169, 150)
        Me.cboNames.TabIndex = 3
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(234, 216)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 4
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnLeftAdd
        '
        Me.btnLeftAdd.Location = New System.Drawing.Point(129, 426)
        Me.btnLeftAdd.Name = "btnLeftAdd"
        Me.btnLeftAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnLeftAdd.TabIndex = 5
        Me.btnLeftAdd.Text = "&Add"
        Me.btnLeftAdd.UseVisualStyleBackColor = True
        '
        'btnLeftRemove
        '
        Me.btnLeftRemove.Location = New System.Drawing.Point(129, 476)
        Me.btnLeftRemove.Name = "btnLeftRemove"
        Me.btnLeftRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnLeftRemove.TabIndex = 6
        Me.btnLeftRemove.Text = "Remove"
        Me.btnLeftRemove.UseVisualStyleBackColor = True
        '
        'btnRightAdd
        '
        Me.btnRightAdd.Location = New System.Drawing.Point(332, 426)
        Me.btnRightAdd.Name = "btnRightAdd"
        Me.btnRightAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnRightAdd.TabIndex = 7
        Me.btnRightAdd.Text = "Add"
        Me.btnRightAdd.UseVisualStyleBackColor = True
        '
        'btnRightRemove
        '
        Me.btnRightRemove.Location = New System.Drawing.Point(332, 477)
        Me.btnRightRemove.Name = "btnRightRemove"
        Me.btnRightRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRightRemove.TabIndex = 8
        Me.btnRightRemove.Text = "Remove"
        Me.btnRightRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "First Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Second Team"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 547)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRightRemove)
        Me.Controls.Add(Me.btnRightAdd)
        Me.Controls.Add(Me.btnLeftRemove)
        Me.Controls.Add(Me.btnLeftAdd)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.cboNames)
        Me.Controls.Add(Me.lstRight)
        Me.Controls.Add(Me.lstLeft)
        Me.Name = "Form1"
        Me.Text = "Select Players"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLeft As ListBox
    Friend WithEvents lstRight As ListBox
    Friend WithEvents cboNames As ComboBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnLeftAdd As Button
    Friend WithEvents btnLeftRemove As Button
    Friend WithEvents btnRightAdd As Button
    Friend WithEvents btnRightRemove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
