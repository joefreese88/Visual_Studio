
''' <summary>
'''  Author: Joseph Freese and my class team
'''  Program: TeamD_Project
'''  Description: 
''' 
''' </summary>



Public Class Form1

    Dim First_Name_Pass As String = ""      'Used to send the first name to the second form
    Dim Last_Name_Pass As String = ""       'Used to send the last name to the second form
    Dim Phone_Number_Pass As String = ""       'Used to send the phone number to the second form
    Dim Email_Address_Pass As String = ""       'Used to send the Email address to the second form
    Dim Issue_String_Pass As String = ""        'Used to send the Issue to the second form
    Dim Comment_String_Pass As String = ""      'Used to send the comment to the second form
    Dim Priority_String_Pass As String = ""     'Used to send the priority to the second form
    Dim Date_Date_Pass As Date = #8/13/2002 12:14 PM#   'Used to send the Date to the second form

    'Upon opening the form, the comboboxes are being filled with their options
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IssueTableDataSet.IssueTable' table. You can move, or remove it, as needed.
        Me.IssueTableTableAdapter.Fill(Me.IssueTableDataSet.IssueTable)

        'Add the selection options for the issue
        IssueComboBox.Items.Add("Single light out")
        IssueComboBox.Items.Add("Multiple lights out")
        IssueComboBox.Items.Add("All lights out")
        IssueComboBox.Items.Add("Flickering light")
        IssueComboBox.Items.Add("All lights flickering")
        IssueComboBox.Items.Add("Sign pole damage")
        IssueComboBox.Items.Add("Light cover damage")
        IssueComboBox.Items.Add("Sparking")
        IssueComboBox.Items.Add("Other")
        IssueComboBox.Items.Add("")

        'Add the priority options
        Priority_lvlComboBox.Items.Add("High")
        Priority_lvlComboBox.Items.Add("Low")
        Priority_lvlComboBox.Items.Add("")

        IssueTableDataGridView.ClearSelection()

    End Sub

    'The user clicks the New Issue button and must input all fields before hitting Submit. The proper controls are enabled/disabled
    Private Sub NewIssueBtn_Click(sender As Object, e As EventArgs) Handles NewIssueBtn.Click
        IssueTableBindingSource.AddNew()
        First_NameTextBox.Visible = True
        Last_NameTextBox.Visible = True
        PhoneTextBox.Visible = True
        Email_AddressTextBox.Visible = True
        IssueComboBox.Visible = True
        CommentsTextBox.Visible = True
        Priority_lvlComboBox.Visible = True
        DateDateTimePicker.Visible = True
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False

        NewIssueBtn.Enabled = False
        SubmitBtn.Enabled = True
        Search.Enabled = False
        CancelSearchBtn.Enabled = False
        Delete.Enabled = False
        TimeEstimateBtn.Enabled = False
        IssueTableDataGridView.ClearSelection()
    End Sub

    'Allows the user to delete a row from the database
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        IssueTableBindingSource.RemoveCurrent()
        IssueTableBindingSource.EndEdit()
        IssueTableTableAdapter.Update(IssueTableDataSet.IssueTable)
    End Sub

    'Submit button adds the fields data to the database
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        'see if the information will add, otherwise it will prompt user to fill in all fields
        Try
            IssueTableBindingSource.EndEdit()
            IssueTableTableAdapter.Update(IssueTableDataSet.IssueTable)
            MessageBox.Show("Thank you for submitting! Click 'New Issue' to submit another issue")
            NewIssueBtn.Enabled = True
            SubmitBtn.Enabled = False
            Search.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Please fill in all fields befor submitting!")
        End Try

    End Sub

    'Search for data in the database connected to the entered phone number
    Private Sub PhoneToolStripButton_Click(sender As Object, e As EventArgs) Handles PhoneToolStripButton.Click
        Try
            Me.IssueTableTableAdapter.Phone(Me.IssueTableDataSet.IssueTable, PhoneToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Search.Visible = True
        Delete.Enabled = True
        IssueTableDataGridView.Visible = True
        lblDirection.Visible = True
    End Sub

    'CLicking this button allows the user to use search options
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        PhoneToolStrip.Enabled = True
        NewIssueBtn.Enabled = False
        Delete.Enabled = True
        CancelSearchBtn.Enabled = True
        TimeEstimateBtn.Enabled = True
        PhoneToolStrip.Visible = True



        MessageBox.Show("Enter your phone number in the textbox and click the search!")  'column always starts at zero

    End Sub

    Private Sub IssueComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        If IssueComboBox.SelectedItem = "Other" Then
            MessageBox.Show("you selected 'Other', use Comments box to describe the issue!")
        End If
    End Sub

    'Switches to the second form to provide information on how long it will take to start fixing the issue
    Private Sub TimeEstimateBtn_Click(sender As Object, e As EventArgs) Handles TimeEstimateBtn.Click
        Dim obj As New IssueEstimate
        Dim Together As String = ""
        Dim Index As Integer = 0
        Dim Row As Integer = IssueTableDataGridView.CurrentCell.RowIndex
        Dim Column As Integer = IssueTableDataGridView.CurrentCell.ColumnIndex

        First_Name_Pass = IssueTableDataGridView(1, Row).Value
        Last_Name_Pass = IssueTableDataGridView(2, Row).Value
        Phone_Number_Pass = IssueTableDataGridView(3, Row).Value
        Email_Address_Pass = IssueTableDataGridView(4, Row).Value
        Issue_String_Pass = IssueTableDataGridView(5, Row).Value
        Comment_String_Pass = IssueTableDataGridView(6, Row).Value
        Priority_String_Pass = IssueTableDataGridView(7, Row).Value
        Date_Date_Pass = IssueTableDataGridView(8, Row).Value

        obj.First_Name = First_Name_Pass
        obj.Last_Name = Last_Name_Pass
        obj.Phone_Number = Phone_Number_Pass
        obj.Email_Address = Email_Address_Pass
        obj.Issue_String = Issue_String_Pass
        obj.Comment_String = Comment_String_Pass
        obj.Priority_String = Priority_String_Pass
        obj.Date_Date = Date_Date_Pass
        obj.Show()
        Me.Hide()
    End Sub

    'When the cancel button is clicked, all search options are cancelled, and the new Issue button is available again
    Private Sub CancelSearchBtn_Click(sender As Object, e As EventArgs) Handles CancelSearchBtn.Click
        NewIssueBtn.Enabled = True
        IssueTableDataGridView.Visible = False
        PhoneToolStrip.Visible = False
        lblDirection.Visible = False
    End Sub

End Class
