Imports System.IO

Public Class Joseph_Freese_P5

    Dim applianceKilos(8) As Double  ' an array of 8 kWh values'
    Dim currentCost As Double   'stores the most recent calculated cost
    Dim count As Integer        'keeps track of whether the reset button is clicked, will be either 0 or 1
    Dim index As Integer        'keeps track of the index of the selected appliance

    Private Sub Joseph_Freese_P5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Items are added to the list box at the start of the form opening
        ApplianceListBox.Items.Add("None")
        ApplianceListBox.Items.Add("Refrigerator")
        ApplianceListBox.Items.Add("TV")
        ApplianceListBox.Items.Add("Space Heater")
        ApplianceListBox.Items.Add("Fan")
        ApplianceListBox.Items.Add("Laundry Washer")
        ApplianceListBox.Items.Add("Laundry Dryer")
        ApplianceListBox.Items.Add("Oven")

        ' Each appliance in the array is set to its default value
        applianceKilos(0) = 0
        applianceKilos(1) = 1
        applianceKilos(2) = 1.1
        applianceKilos(3) = 1.2
        applianceKilos(4) = 1.3
        applianceKilos(5) = 1.4
        applianceKilos(6) = 1.5
        applianceKilos(7) = 1.6
    End Sub

    Private Sub Joseph_Freese_P5_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            Dim iterate As Integer = 0
            For Each path In files

                ' Create new StreamReader instance with Using block.
                Using reader As StreamReader = New StreamReader(path)
                    ' Store contents in this String.
                    Dim line As String

                    ' Read first line.
                    line = reader.ReadLine

                    ' Loop over each line in file, While list is Not Nothing.
                    Do While (Not line Is Nothing)

                        applianceKilos(iterate) = line
                        iterate = iterate + 1

                        ' Read in the next line.
                        line = reader.ReadLine

                    Loop

                End Using

                For i = 0 To applianceKilos.Count - 1
                    Console.WriteLine("Element({0}) = {1}", i, applianceKilos(i))

                Next i

                index = ApplianceListBox.SelectedIndex

                If index < 0 Then
                    KiloPowerTxtBox.Text = Nothing
                ElseIf index >= 0 Then
                    KiloPowerTxtBox.Text = applianceKilos(index)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Joseph_Freese_P5_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    'This event updates the CalcLbl label with the new item that the user selected and sets the start of the layout
    Private Sub ApplianceListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApplianceListBox.SelectedIndexChanged
        Dim finalCost = currentCost.ToString("C")

        If count = 0 Then   'if this is the first selection, set proper labels to false visibility and textbox values to 0
            lblSelected.Text = ApplianceListBox.SelectedItem.ToString()
            CalcLbl.Text = "$0.00"
            Calc2Lbl.Text = "$0.00"
            Calc3Lbl.Text = "$0.00"
            CalcLbl.BorderStyle = BorderStyle.Fixed3D
            Calc2Lbl.BorderStyle = BorderStyle.Fixed3D
            Calc3Lbl.BorderStyle = BorderStyle.Fixed3D
            lblSelected.BorderStyle = BorderStyle.Fixed3D

            'labels and textboxes for laundry washer will be invisible unless laundry washer is selected
            Waterlbl.Visible = False
            PerGAllonlbl.Visible = False
            WaterPerHourTxt.Visible = False
            CostPerGallonTxt.Visible = False
            GroupBox1.Visible = False
            KiloCostTxtBox.Text = 0
            KiloPowerTxtBox.Text = 0
            HoursPerDayTxtBox.Text = 0
            WaterPerHourTxt.Text = 0
            CostPerGallonTxt.Text = 0

            'if laundry washer is selected, set its labels and textboxes to True
            If ApplianceListBox.SelectedItem.ToString() = "Laundry Washer" Then
                Waterlbl.Visible = True
                PerGAllonlbl.Visible = True
                WaterPerHourTxt.Visible = True
                CostPerGallonTxt.Visible = True
                GroupBox1.Visible = True
            End If

        End If

        count = 0

        index = ApplianceListBox.SelectedIndex

        'display the default kWh in the textbox based on selected appliance
        If index < 0 Then
            KiloPowerTxtBox.Text = 0
        ElseIf index >= 0 Then
            KiloPowerTxtBox.Text = applianceKilos(index)
        End If
    End Sub

    'This event updates the total cost when the information in KiloCostTxtBox is changed
    Private Sub KiloCostTxtBox_TextChanged(sender As Object, e As EventArgs) Handles KiloCostTxtBox.TextChanged
        Dim Cost As Double        'Variable Cost stores the users entered value
        Dim Selected As String      'Variable Selected stores the selected appliance
        Dim multiply As Double      'Varable that stores the total cost based on all user input
        Dim multiplyMonthly As Double      'Varable that stores the total Monthly cost based on all user input
        Dim multiplyYearly As Double      'Varable that stores the total Yearly cost based on all user input

        'Check if an appliance has been selected, otherwise display a message for user to select an appliance
        Try
            Selected = ApplianceListBox.SelectedItem.ToString()

            'Check if the cost input is valid input, otherwise tell user to enter an actual number
            Try
                'Get the user's input and convert it to a Decimal.
                Cost = CDbl(KiloCostTxtBox.Text)
                If Cost > 0 Then

                    If Selected = "Laundry Washer" Then
                        multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text)) + (Val(WaterPerHourTxt.Text) * Val(CostPerGallonTxt.Text))
                        multiplyMonthly = multiply * 30
                        multiplyYearly = multiply * 365
                        CalcLbl.Text = multiply.ToString("C")
                        Calc2Lbl.Text = multiplyMonthly.ToString("C")
                        Calc3Lbl.Text = multiplyYearly.ToString("C")
                        currentCost = multiply.ToString("C")
                        Exit Sub
                    ElseIf Selected <> "Laundry Washer" Then
                        multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text))
                        multiplyMonthly = multiply * 30
                        multiplyYearly = multiply * 365
                        CalcLbl.Text = multiply.ToString("C")
                        Calc2Lbl.Text = multiplyMonthly.ToString("C")
                        Calc3Lbl.Text = multiplyYearly.ToString("C")
                        currentCost = multiply.ToString("C")
                        Exit Sub
                    End If
                ElseIf Cost < 0 Then
                    MsgBox("no negative values allowed!")
                    KiloCostTxtBox.Text = 0
                    CalcLbl.Text = ""
                    Calc2Lbl.Text = ""
                    Calc3Lbl.Text = ""
                End If

            Catch
                'Display an error message.
                CalcLbl.Text = ""
                Calc2Lbl.Text = ""
                Calc3Lbl.Text = ""
                MsgBox("Input a number value! NO NEGATIVES OR CHARACTERS!")
                KiloCostTxtBox.Text = 0
            End Try
        Catch
            'Display an error message.
            MsgBox("Select an appliance before entering values!")
        End Try
    End Sub

    'This event updates the total cost when the information in KiloPowerTxtBox is changed 
    Private Sub KiloPowerTxtBox_TextChanged(sender As Object, e As EventArgs) Handles KiloPowerTxtBox.TextChanged
        Dim Power As Double        'Variable Cost stores the users entered value
        Dim Selected As String      'Variable Selected stores the selected appliance
        Dim multiply As Double      'Varable that stores the total cost based on all user input
        Dim multiplyMonthly As Double      'Varable that stores the total Monthly cost based on all user input
        Dim multiplyYearly As Double      'Varable that stores the total Yearly cost based on all user input

        'Check if an appliance has been selected, otherwise display a message for user to select an appliance
        Try
            Selected = ApplianceListBox.SelectedItem.ToString()

            'Check if the cost input is valid input, otherwise tell user to enter an actual number
            Try
                'Get the user's input and convert it to a Decimal.
                Power = CDbl(KiloPowerTxtBox.Text)
                If Power > 0 Then

                    If Selected = "Laundry Washer" Then
                        multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text)) + (Val(WaterPerHourTxt.Text) * Val(CostPerGallonTxt.Text))
                        multiplyMonthly = multiply * 30
                        multiplyYearly = multiply * 365
                        CalcLbl.Text = multiply.ToString("C")
                        Calc2Lbl.Text = multiplyMonthly.ToString("C")
                        Calc3Lbl.Text = multiplyYearly.ToString("C")
                        currentCost = multiply.ToString("C")
                        Exit Sub
                    ElseIf Selected <> "Laundry Washer" Then
                        multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text))
                        multiplyMonthly = multiply * 30
                        multiplyYearly = multiply * 365
                        CalcLbl.Text = multiply.ToString("C")
                        Calc2Lbl.Text = multiplyMonthly.ToString("C")
                        Calc3Lbl.Text = multiplyYearly.ToString("C")
                        currentCost = multiply.ToString("C")
                        Exit Sub
                    End If
                ElseIf Power < 0 Then
                    MsgBox("no negative values allowed!")
                    KiloPowerTxtBox.Text = 0
                    CalcLbl.Text = ""
                    Calc2Lbl.Text = ""
                    Calc3Lbl.Text = ""
                End If

            Catch
                'Display an error message.
                CalcLbl.Text = ""
                Calc2Lbl.Text = ""
                Calc3Lbl.Text = ""
                MsgBox("Input a number value! NO NEGATIVES OR CHARACTERS!")
                KiloPowerTxtBox.Text = 0
            End Try
        Catch
            'Display an error message.
            MsgBox("Select an appliance before entering values!")
        End Try
    End Sub

    'This event updates the total cost when the information in HoursPerDayTxtBox is changed 
    Private Sub HoursPerDayTxtBox_TextChanged(sender As Object, e As EventArgs) Handles HoursPerDayTxtBox.TextChanged
        Dim Hour As Double          'Variable Cost stores the users entered value
        Dim Selected As String      'Variable Selected stores the selected appliance
        Dim multiply As Double      'Varable that stores the total cost based on all user input
        Dim multiplyMonthly As Double      'Varable that stores the total Monthly cost based on all user input
        Dim multiplyYearly As Double      'Varable that stores the total Yearly cost based on all user input

        'Check if an appliance has been selected, otherwise display a message for user to select an appliance
        Try
            Selected = ApplianceListBox.SelectedItem.ToString()

            Try
                Hour = CDbl(HoursPerDayTxtBox.Text)
                If Hour > 0 Then

                    If Selected = "Laundry Washer" Then
                        multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text)) + (Val(WaterPerHourTxt.Text) * Val(CostPerGallonTxt.Text))
                        multiplyMonthly = multiply * 30
                        multiplyYearly = multiply * 365
                        'check the value is in range of 24 hours
                        If Hour > 24 Then
                            CalcLbl.Text = ""
                            Calc2Lbl.Text = ""
                            Calc3Lbl.Text = ""
                            HoursPerDayTxtBox.Text = 0
                            MsgBox("Hours must be in the range of 0 to 24!")
                            Exit Sub
                        ElseIf Hour >= 0 Or Hour <= 24 Then
                            CalcLbl.Text = multiply.ToString("C")
                            Calc2Lbl.Text = multiplyMonthly.ToString("C")
                            Calc3Lbl.Text = multiplyYearly.ToString("C")
                            currentCost = multiply.ToString("C")
                            Hour = 0
                            Exit Sub
                        End If
                        Exit Sub

                    ElseIf Selected <> "Laundry Washer" Then
                        multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text))
                        multiplyMonthly = multiply * 30
                        multiplyYearly = multiply * 365
                        'check the value is in range of 24 hours
                        If Hour > 24 Then
                            CalcLbl.Text = ""
                            Calc2Lbl.Text = ""
                            Calc3Lbl.Text = ""
                            HoursPerDayTxtBox.Text = 0
                            MsgBox("Hours must be in the range of 0 to 24!")
                            Exit Sub
                        ElseIf Hour >= 0 Or Hour <= 24 Then
                            CalcLbl.Text = multiply.ToString("C")
                            Calc2Lbl.Text = multiplyMonthly.ToString("C")
                            Calc3Lbl.Text = multiplyYearly.ToString("C")
                            currentCost = multiply.ToString("C")
                            Hour = 0
                            Exit Sub
                        End If
                    End If
                ElseIf Hour < 0 Then
                    MsgBox("no negative values allowed!")
                    HoursPerDayTxtBox.Text = 0
                    CalcLbl.Text = ""
                    Calc2Lbl.Text = ""
                    Calc3Lbl.Text = ""
                End If

            Catch
                'Display an error message.
                CalcLbl.Text = ""
                Calc2Lbl.Text = ""
                Calc3Lbl.Text = ""
                MsgBox("Input a number value! NO NEGATIVES OR CHARACTERS!")
                HoursPerDayTxtBox.Text = 0
            End Try

        Catch
            'Display an error message.
            MsgBox("Select an appliance before entering values!")

        End Try
    End Sub

    'This event resets each value to zero, clears the bottom label, and deselects the item in ApplianceListBox
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        HoursPerDayTxtBox.Text = 0
        KiloPowerTxtBox.Text = 0
        KiloCostTxtBox.Text = 0
        WaterPerHourTxt.Text = 0
        CostPerGallonTxt.Text = 0
        applianceKilos(0) = 0
        applianceKilos(1) = 1
        applianceKilos(2) = 1.1
        applianceKilos(3) = 1.2
        applianceKilos(4) = 1.3
        applianceKilos(5) = 1.4
        applianceKilos(6) = 1.5
        applianceKilos(7) = 1.6

        count = 1
        CalcLbl.Text = "$0.00"
        Calc2Lbl.Text = "$0.00"
        Calc3Lbl.Text = "$0.00"
        lblSelected.Text = "None"
        ListView1.Items.Clear()
        ApplianceListBox.ClearSelected()
    End Sub

    'This event updates the total water used when the information in WaterPerHourTxt is changed 
    Private Sub WaterPerHourTxt_TextChanged(sender As Object, e As EventArgs) Handles WaterPerHourTxt.TextChanged
        Dim Cost As Double          'Variable Cost stores the users entered value
        Dim Selected As String      'Variable Selected stores the selected appliance

        'Check if an appliance has been selected, otherwise display a message for user to select an appliance
        Try
            Selected = ApplianceListBox.SelectedItem.ToString()
            'Check if the cost input is valid input, otherwise tell user to enter an actual number
            Try
                'Get the user's input and convert it to a Decimal.
                Cost = CDbl(WaterPerHourTxt.Text)
                If Cost > 0 Then

                    Dim multiply As Double = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text)) + (Val(WaterPerHourTxt.Text) * Val(CostPerGallonTxt.Text))
                    Dim multiplyMonthly As Double = multiply * 30
                    Dim multiplyYearly As Double = multiply * 365
                    Dim finalCost = multiply.ToString("C")
                    CalcLbl.Text = finalCost
                    Calc2Lbl.Text = multiplyMonthly.ToString("C")
                    Calc3Lbl.Text = multiplyYearly.ToString("C")
                    currentCost = finalCost
                ElseIf Cost < 0 Then
                    MsgBox("no negative values allowed!")
                    WaterPerHourTxt.Text = 0
                    CalcLbl.Text = ""
                    Calc2Lbl.Text = ""
                    Calc3Lbl.Text = ""
                End If

            Catch
                'Display an error message.
                CalcLbl.Text = ""
                Calc2Lbl.Text = ""
                Calc3Lbl.Text = ""
                MsgBox("Input a number value! NO NEGATIVES OR CHARACTERS!")
                WaterPerHourTxt.Text = 0
            End Try
        Catch
            'Display an error message.
            MsgBox("Select an appliance before entering values!")

        End Try
    End Sub

    'This event updates the total gallon cost used when the information in CostPerGallonTxt is changed 
    Private Sub CostPerGallonTxt_TextChanged(sender As Object, e As EventArgs) Handles CostPerGallonTxt.TextChanged
        Dim Cost As Double          'Variable Cost stores the users entered value
        Dim Selected As String      'Variable Selected stores the selected appliance

        'Check if an appliance has been selected, otherwise display a message for user to select an appliance
        Try
            Selected = ApplianceListBox.SelectedItem.ToString()
            'Check if the cost input is valid input, otherwise tell user to enter an actual number
            Try
                'Get the user's input and convert it to a Decimal.
                Cost = CDbl(CostPerGallonTxt.Text)
                If Cost > 0 Then
                    Dim multiply As Double = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text)) + (Val(WaterPerHourTxt.Text) * Val(CostPerGallonTxt.Text))
                    Dim multiplyMonthly As Double = multiply * 30
                    Dim multiplyYearly As Double = multiply * 365
                    Dim finalCost = multiply.ToString("C")
                    CalcLbl.Text = finalCost
                    Calc2Lbl.Text = multiplyMonthly.ToString("C")
                    Calc3Lbl.Text = multiplyYearly.ToString("C")
                    currentCost = finalCost
                ElseIf Cost < 0 Then
                    MsgBox("no negative values allowed!")
                    CostPerGallonTxt.Text = 0
                    CalcLbl.Text = ""
                    Calc2Lbl.Text = ""
                    Calc3Lbl.Text = ""
                End If

            Catch
                'Display an error message.
                CalcLbl.Text = ""
                Calc2Lbl.Text = ""
                Calc3Lbl.Text = ""
                MsgBox("Input a number value! NO NEGATIVES OR CHARACTERS!")
                CostPerGallonTxt.Text = 0
            End Try
        Catch
            'Display an error message.
            MsgBox("Select an appliance before entering values!")

        End Try
    End Sub

    'Add the selected appliance and total price to the listview
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim AList As ListViewItem
        Dim costInput As Integer = Val(HoursPerDayTxtBox.Text)
        Dim KiloInput As Integer = Val(KiloPowerTxtBox.Text)
        Dim hourInput As Integer = Val(KiloCostTxtBox.Text)
        Dim multiply As Double
        Dim multiplyMonthly As Double
        Dim multiplyYearly As Double

        Dim Selected As String

        Try

            Selected = ApplianceListBox.SelectedItem.ToString()
            If Selected = "None" Then
                MsgBox("Select an appliance before adding to the list!")
                Exit Try
            End If

            If Val(HoursPerDayTxtBox.Text) >= 0 And Val(KiloPowerTxtBox.Text) >= 0 And Val(KiloCostTxtBox.Text) >= 0 Then

                If Selected = "Laundry Washer" Then
                    multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text)) + (Val(WaterPerHourTxt.Text) * Val(CostPerGallonTxt.Text))
                    multiplyMonthly = multiply * 30
                    multiplyYearly = multiply * 365
                    'CalcLbl.Text = multiply.ToString("C")
                    'Calc2Lbl.Text = multiplyMonthly.ToString("C")
                    ' Calc3Lbl.Text = multiplyYearly.ToString("C")
                    AList = ListView1.Items.Add(Selected)
                    AList.SubItems.Add(HoursPerDayTxtBox.Text)
                    AList.SubItems.Add(multiply.ToString("C"))
                    AList.SubItems.Add(multiplyMonthly.ToString("C"))
                    AList.SubItems.Add(multiplyYearly.ToString("C"))
                    Exit Sub

                ElseIf Selected <> "Laundry Washer" Then
                    multiply = (Val(HoursPerDayTxtBox.Text) * Val(KiloPowerTxtBox.Text) * Val(KiloCostTxtBox.Text))
                    multiplyMonthly = multiply * 30
                    multiplyYearly = multiply * 365
                    'CalcLbl.Text = multiply.ToString("C")
                    'Calc2Lbl.Text = multiplyMonthly.ToString("C")
                    'Calc3Lbl.Text = multiplyYearly.ToString("C")
                    AList = ListView1.Items.Add(Selected)
                    AList.SubItems.Add(HoursPerDayTxtBox.Text)
                    AList.SubItems.Add(multiply.ToString("C"))
                    AList.SubItems.Add(multiplyMonthly.ToString("C"))
                    AList.SubItems.Add(multiplyYearly.ToString("C"))
                End If

                lblSelected.Text = Selected
                'CalcLbl.BorderStyle = BorderStyle.None
                'Calc2Lbl.BorderStyle = BorderStyle.None
                ' Calc3Lbl.BorderStyle = BorderStyle.None

                Exit Sub
            ElseIf hourInput < 0 Or KiloInput < 0 Or costInput < 0 Then
                MsgBox("Fill in all textboxes with values greater than 0 before adding! " & Val(HoursPerDayTxtBox.Text))
                Exit Sub
            End If

        Catch
            MsgBox("Select an appliance before adding to the list!")
        End Try
    End Sub

    'Save contents to a text document after reading items from ListView1
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        Dim myString As String = ""

        For Each item As ListViewItem In ListView1.Items
            myString = myString & item.Text & "   " & item.SubItems(1).Text & "   " & item.SubItems(2).Text & "   " & item.SubItems(3).Text & "   " & item.SubItems(4).Text & Environment.NewLine
        Next

        Try

            SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
            SaveFileDialog1.FileName = "Joseph_Freese_P5"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                'Open the file.
                Using studentFile As StreamWriter = New StreamWriter(SaveFileDialog1.FileName)
                    studentFile.WriteLine(myString)

                End Using

            End If

        Catch
            MessageBox.Show("Error: The file cannot be created.")
        End Try

    End Sub

    'View the currently set kWh for each appliance
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        Dim myString As String = ""
        Dim count As Integer = 0

        For count = 0 To ApplianceListBox.Items.Count - 1
            myString = myString & ApplianceListBox.Items(count) & " = " & applianceKilos(count) & vbCrLf

        Next
        MsgBox(myString)
    End Sub
End Class
