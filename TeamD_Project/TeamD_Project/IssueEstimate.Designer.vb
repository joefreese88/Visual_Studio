<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueEstimate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReturnBtn = New System.Windows.Forms.Button()
        Me.ShowIssueLbl = New System.Windows.Forms.Label()
        Me.ShowPriorityLbl = New System.Windows.Forms.Label()
        Me.ShowDateLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "description"
        '
        'ReturnBtn
        '
        Me.ReturnBtn.Location = New System.Drawing.Point(12, 225)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReturnBtn.TabIndex = 4
        Me.ReturnBtn.Text = "<-- Return"
        Me.ReturnBtn.UseVisualStyleBackColor = True
        '
        'ShowIssueLbl
        '
        Me.ShowIssueLbl.AutoSize = True
        Me.ShowIssueLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowIssueLbl.Location = New System.Drawing.Point(8, 20)
        Me.ShowIssueLbl.Name = "ShowIssueLbl"
        Me.ShowIssueLbl.Size = New System.Drawing.Size(42, 20)
        Me.ShowIssueLbl.TabIndex = 5
        Me.ShowIssueLbl.Text = "label"
        '
        'ShowPriorityLbl
        '
        Me.ShowPriorityLbl.AutoSize = True
        Me.ShowPriorityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPriorityLbl.Location = New System.Drawing.Point(283, 20)
        Me.ShowPriorityLbl.Name = "ShowPriorityLbl"
        Me.ShowPriorityLbl.Size = New System.Drawing.Size(47, 20)
        Me.ShowPriorityLbl.TabIndex = 6
        Me.ShowPriorityLbl.Text = "label"
        '
        'ShowDateLbl
        '
        Me.ShowDateLbl.AutoSize = True
        Me.ShowDateLbl.Location = New System.Drawing.Point(9, 49)
        Me.ShowDateLbl.Name = "ShowDateLbl"
        Me.ShowDateLbl.Size = New System.Drawing.Size(29, 13)
        Me.ShowDateLbl.TabIndex = 8
        Me.ShowDateLbl.Text = "label"
        '
        'IssueEstimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(488, 260)
        Me.Controls.Add(Me.ShowDateLbl)
        Me.Controls.Add(Me.ShowPriorityLbl)
        Me.Controls.Add(Me.ShowIssueLbl)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IssueEstimate"
        Me.Text = "Issue Time Estimation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents ShowIssueLbl As Label
    Friend WithEvents ShowPriorityLbl As Label
    Friend WithEvents ShowDateLbl As Label
End Class
