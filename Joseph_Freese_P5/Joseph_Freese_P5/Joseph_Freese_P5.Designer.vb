<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Joseph_Freese_P5
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
        Me.ApplianceListBox = New System.Windows.Forms.ListBox()
        Me.SelectedLbl = New System.Windows.Forms.Label()
        Me.CostLbl = New System.Windows.Forms.Label()
        Me.MontylyLbl = New System.Windows.Forms.Label()
        Me.YearlyLbl = New System.Windows.Forms.Label()
        Me.costsGroup = New System.Windows.Forms.GroupBox()
        Me.Calc3Lbl = New System.Windows.Forms.Label()
        Me.CalcLbl = New System.Windows.Forms.Label()
        Me.Calc2Lbl = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.KiloCostLbl = New System.Windows.Forms.Label()
        Me.KiloPowerLbl = New System.Windows.Forms.Label()
        Me.KiloHourLbl = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Appliance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Hours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Monthly = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Yearly = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KiloCostTxtBox = New System.Windows.Forms.TextBox()
        Me.KiloPowerTxtBox = New System.Windows.Forms.TextBox()
        Me.HoursPerDayTxtBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CostPerGallonTxt = New System.Windows.Forms.TextBox()
        Me.WaterPerHourTxt = New System.Windows.Forms.TextBox()
        Me.PerGAllonlbl = New System.Windows.Forms.Label()
        Me.Waterlbl = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.costsGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Appliance Here!"
        '
        'ApplianceListBox
        '
        Me.ApplianceListBox.FormattingEnabled = True
        Me.ApplianceListBox.Location = New System.Drawing.Point(15, 25)
        Me.ApplianceListBox.Name = "ApplianceListBox"
        Me.ApplianceListBox.Size = New System.Drawing.Size(121, 56)
        Me.ApplianceListBox.TabIndex = 1
        '
        'SelectedLbl
        '
        Me.SelectedLbl.AutoSize = True
        Me.SelectedLbl.Location = New System.Drawing.Point(6, 31)
        Me.SelectedLbl.Name = "SelectedLbl"
        Me.SelectedLbl.Size = New System.Drawing.Size(57, 13)
        Me.SelectedLbl.TabIndex = 2
        Me.SelectedLbl.Text = "Appliance:"
        '
        'CostLbl
        '
        Me.CostLbl.AutoSize = True
        Me.CostLbl.Location = New System.Drawing.Point(6, 59)
        Me.CostLbl.Name = "CostLbl"
        Me.CostLbl.Size = New System.Drawing.Size(57, 13)
        Me.CostLbl.TabIndex = 3
        Me.CostLbl.Text = "Daily Cost:"
        '
        'MontylyLbl
        '
        Me.MontylyLbl.AutoSize = True
        Me.MontylyLbl.Location = New System.Drawing.Point(6, 90)
        Me.MontylyLbl.Name = "MontylyLbl"
        Me.MontylyLbl.Size = New System.Drawing.Size(71, 13)
        Me.MontylyLbl.TabIndex = 4
        Me.MontylyLbl.Text = "Monthly Cost:"
        '
        'YearlyLbl
        '
        Me.YearlyLbl.AutoSize = True
        Me.YearlyLbl.Location = New System.Drawing.Point(6, 121)
        Me.YearlyLbl.Name = "YearlyLbl"
        Me.YearlyLbl.Size = New System.Drawing.Size(63, 13)
        Me.YearlyLbl.TabIndex = 5
        Me.YearlyLbl.Text = "Yearly Cost:"
        '
        'costsGroup
        '
        Me.costsGroup.Controls.Add(Me.Calc3Lbl)
        Me.costsGroup.Controls.Add(Me.CalcLbl)
        Me.costsGroup.Controls.Add(Me.Calc2Lbl)
        Me.costsGroup.Controls.Add(Me.SelectedLbl)
        Me.costsGroup.Controls.Add(Me.lblSelected)
        Me.costsGroup.Controls.Add(Me.CostLbl)
        Me.costsGroup.Controls.Add(Me.MontylyLbl)
        Me.costsGroup.Controls.Add(Me.YearlyLbl)
        Me.costsGroup.Location = New System.Drawing.Point(15, 265)
        Me.costsGroup.Name = "costsGroup"
        Me.costsGroup.Size = New System.Drawing.Size(180, 152)
        Me.costsGroup.TabIndex = 6
        Me.costsGroup.TabStop = False
        Me.costsGroup.Text = "Total Costs Summary:"
        '
        'Calc3Lbl
        '
        Me.Calc3Lbl.AutoSize = True
        Me.Calc3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Calc3Lbl.Location = New System.Drawing.Point(85, 119)
        Me.Calc3Lbl.Name = "Calc3Lbl"
        Me.Calc3Lbl.Size = New System.Drawing.Size(36, 15)
        Me.Calc3Lbl.TabIndex = 10
        Me.Calc3Lbl.Text = "$0.00"
        '
        'CalcLbl
        '
        Me.CalcLbl.AutoSize = True
        Me.CalcLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CalcLbl.Location = New System.Drawing.Point(85, 57)
        Me.CalcLbl.Name = "CalcLbl"
        Me.CalcLbl.Size = New System.Drawing.Size(36, 15)
        Me.CalcLbl.TabIndex = 7
        Me.CalcLbl.Text = "$0.00"
        '
        'Calc2Lbl
        '
        Me.Calc2Lbl.AutoSize = True
        Me.Calc2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Calc2Lbl.Location = New System.Drawing.Point(85, 88)
        Me.Calc2Lbl.Name = "Calc2Lbl"
        Me.Calc2Lbl.Size = New System.Drawing.Size(36, 15)
        Me.Calc2Lbl.TabIndex = 9
        Me.Calc2Lbl.Text = "$0.00"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelected.Location = New System.Drawing.Point(85, 29)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(35, 15)
        Me.lblSelected.TabIndex = 8
        Me.lblSelected.Text = "None"
        '
        'KiloCostLbl
        '
        Me.KiloCostLbl.AutoSize = True
        Me.KiloCostLbl.Location = New System.Drawing.Point(12, 95)
        Me.KiloCostLbl.Name = "KiloCostLbl"
        Me.KiloCostLbl.Size = New System.Drawing.Size(139, 13)
        Me.KiloCostLbl.TabIndex = 7
        Me.KiloCostLbl.Text = "Enter cost per kilowatt-hour:"
        '
        'KiloPowerLbl
        '
        Me.KiloPowerLbl.AutoSize = True
        Me.KiloPowerLbl.Location = New System.Drawing.Point(12, 117)
        Me.KiloPowerLbl.Name = "KiloPowerLbl"
        Me.KiloPowerLbl.Size = New System.Drawing.Size(143, 13)
        Me.KiloPowerLbl.TabIndex = 8
        Me.KiloPowerLbl.Text = "Enter kilowatts for appliance:"
        '
        'KiloHourLbl
        '
        Me.KiloHourLbl.AutoSize = True
        Me.KiloHourLbl.Location = New System.Drawing.Point(12, 141)
        Me.KiloHourLbl.Name = "KiloHourLbl"
        Me.KiloHourLbl.Size = New System.Drawing.Size(128, 13)
        Me.KiloHourLbl.TabIndex = 9
        Me.KiloHourLbl.Text = "Enter hours used per day:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Appliance, Me.Hours, Me.Cost, Me.Monthly, Me.Yearly})
        Me.ListView1.Location = New System.Drawing.Point(363, 9)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(460, 350)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Appliance
        '
        Me.Appliance.Text = "Appliance"
        Me.Appliance.Width = 100
        '
        'Hours
        '
        Me.Hours.Text = "Hours"
        '
        'Cost
        '
        Me.Cost.Text = "Daily Cost"
        Me.Cost.Width = 100
        '
        'Monthly
        '
        Me.Monthly.Text = "Monthly Cost"
        Me.Monthly.Width = 100
        '
        'Yearly
        '
        Me.Yearly.Text = "Yearly Cost"
        Me.Yearly.Width = 100
        '
        'KiloCostTxtBox
        '
        Me.KiloCostTxtBox.Location = New System.Drawing.Point(166, 92)
        Me.KiloCostTxtBox.Name = "KiloCostTxtBox"
        Me.KiloCostTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.KiloCostTxtBox.TabIndex = 11
        '
        'KiloPowerTxtBox
        '
        Me.KiloPowerTxtBox.Location = New System.Drawing.Point(166, 117)
        Me.KiloPowerTxtBox.Name = "KiloPowerTxtBox"
        Me.KiloPowerTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.KiloPowerTxtBox.TabIndex = 12
        '
        'HoursPerDayTxtBox
        '
        Me.HoursPerDayTxtBox.Location = New System.Drawing.Point(166, 143)
        Me.HoursPerDayTxtBox.Name = "HoursPerDayTxtBox"
        Me.HoursPerDayTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursPerDayTxtBox.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CostPerGallonTxt)
        Me.GroupBox1.Controls.Add(Me.WaterPerHourTxt)
        Me.GroupBox1.Controls.Add(Me.PerGAllonlbl)
        Me.GroupBox1.Controls.Add(Me.Waterlbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 84)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Water and Cost for Washer!"
        '
        'CostPerGallonTxt
        '
        Me.CostPerGallonTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostPerGallonTxt.Location = New System.Drawing.Point(141, 49)
        Me.CostPerGallonTxt.Name = "CostPerGallonTxt"
        Me.CostPerGallonTxt.Size = New System.Drawing.Size(100, 20)
        Me.CostPerGallonTxt.TabIndex = 3
        '
        'WaterPerHourTxt
        '
        Me.WaterPerHourTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterPerHourTxt.Location = New System.Drawing.Point(141, 23)
        Me.WaterPerHourTxt.Name = "WaterPerHourTxt"
        Me.WaterPerHourTxt.Size = New System.Drawing.Size(100, 20)
        Me.WaterPerHourTxt.TabIndex = 2
        '
        'PerGAllonlbl
        '
        Me.PerGAllonlbl.AutoSize = True
        Me.PerGAllonlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerGAllonlbl.Location = New System.Drawing.Point(20, 52)
        Me.PerGAllonlbl.Name = "PerGAllonlbl"
        Me.PerGAllonlbl.Size = New System.Drawing.Size(111, 13)
        Me.PerGAllonlbl.TabIndex = 1
        Me.PerGAllonlbl.Text = "Enter Cost Per Gallon:"
        '
        'Waterlbl
        '
        Me.Waterlbl.AutoSize = True
        Me.Waterlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waterlbl.Location = New System.Drawing.Point(20, 26)
        Me.Waterlbl.Name = "Waterlbl"
        Me.Waterlbl.Size = New System.Drawing.Size(112, 13)
        Me.Waterlbl.TabIndex = 0
        Me.Waterlbl.Text = "Enter Water Per Hour:"
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(201, 275)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(156, 34)
        Me.AddBtn.TabIndex = 15
        Me.AddBtn.Text = "Add to List"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(201, 319)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(156, 34)
        Me.SaveBtn.TabIndex = 16
        Me.SaveBtn.Text = "Save to document"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(201, 35)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(156, 26)
        Me.ResetBtn.TabIndex = 17
        Me.ResetBtn.Text = "Reset Form"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'ViewBtn
        '
        Me.ViewBtn.Location = New System.Drawing.Point(290, 113)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(67, 26)
        Me.ViewBtn.TabIndex = 18
        Me.ViewBtn.Text = "View kWh"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "*Drag and Drop a text file anywhere on the form to "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "update the amount of kilowatts for the appliance!"
        '
        'Joseph_Freese_P5
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 420)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HoursPerDayTxtBox)
        Me.Controls.Add(Me.KiloPowerTxtBox)
        Me.Controls.Add(Me.KiloCostTxtBox)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.KiloHourLbl)
        Me.Controls.Add(Me.KiloPowerLbl)
        Me.Controls.Add(Me.KiloCostLbl)
        Me.Controls.Add(Me.costsGroup)
        Me.Controls.Add(Me.ApplianceListBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Joseph_Freese_P5"
        Me.Text = "Home Utility Form"
        Me.costsGroup.ResumeLayout(False)
        Me.costsGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ApplianceListBox As ListBox
    Friend WithEvents SelectedLbl As Label
    Friend WithEvents CostLbl As Label
    Friend WithEvents MontylyLbl As Label
    Friend WithEvents YearlyLbl As Label
    Friend WithEvents costsGroup As GroupBox
    Friend WithEvents CalcLbl As Label
    Friend WithEvents lblSelected As Label
    Friend WithEvents Calc2Lbl As Label
    Friend WithEvents Calc3Lbl As Label
    Friend WithEvents KiloCostLbl As Label
    Friend WithEvents KiloPowerLbl As Label
    Friend WithEvents KiloHourLbl As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents KiloCostTxtBox As TextBox
    Friend WithEvents KiloPowerTxtBox As TextBox
    Friend WithEvents HoursPerDayTxtBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PerGAllonlbl As Label
    Friend WithEvents Waterlbl As Label
    Friend WithEvents CostPerGallonTxt As TextBox
    Friend WithEvents WaterPerHourTxt As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents ViewBtn As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Appliance As ColumnHeader
    Friend WithEvents Hours As ColumnHeader
    Friend WithEvents Cost As ColumnHeader
    Friend WithEvents Monthly As ColumnHeader
    Friend WithEvents Yearly As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
