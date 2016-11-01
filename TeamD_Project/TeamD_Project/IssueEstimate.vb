Public Class IssueEstimate
    Public Property First_Name As String
    Public Property Last_Name As String
    Public Property Phone_Number As String
    Public Property Email_Address As String
    Public Property Issue_String As String
    Public Property Comment_String As String
    Public Property Priority_String As String
    Public Property Date_Date As Date

    Dim PriorityCost As Integer = 0
    Dim IssueCost As Integer = 0 '
    Dim finalString As String = ""

    'Return to the first form
    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Dim obj As New Form1
        obj.Show()
        Me.Hide()
    End Sub

    'Load the form and show all information to the user right away
    Private Sub IssueEstimate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Priority_String = "High" Then
            ShowPriorityLbl.ForeColor = Color.Red
            PriorityCost = 48
        Else
            ShowPriorityLbl.ForeColor = Color.Green
            PriorityCost = 96
        End If

        If Issue_String = "Single light out" Or Issue_String = "Flickering light" Then
            IssueCost = 16
            MessageBox.Show(IssueCost)
        ElseIf Issue_String = "All lights out" Or Issue_String = "All lights flickering" Then
            IssueCost = 8
            MessageBox.Show(IssueCost)
        ElseIf Issue_String = "Multiple lights out" Then
            IssueCost = 12
            MessageBox.Show(IssueCost)
        ElseIf Issue_String = "Sign pole damage" Then
            IssueCost = 24
            MessageBox.Show(IssueCost)
        ElseIf Issue_String = "Light cover damage" Then
            IssueCost = 22
            MessageBox.Show(IssueCost)
        ElseIf Issue_String = "Sparking" Then
            IssueCost = 5
            MessageBox.Show(IssueCost)
        Else
            IssueCost = 0
        End If

        Dim addCosts As Integer = IssueCost + PriorityCost
        ShowIssueLbl.Text = "Issue: " & Issue_String
        ShowPriorityLbl.Text = "Priority Level: " & Priority_String
        ShowDateLbl.Text = "Date Submitted: " & Date_Date

        If Issue_String = "Other" Then
            finalString = "Do to unknown issue, you will be notified of a timeline within 24 hours!"
        Else
            finalString = First_Name & " " & Last_Name & ", based on the given issue and priority level," & vbCrLf & "the issue will begin maintenance in about " & addCosts & " hours from the submission date"
        End If
        Label1.Text = finalString

    End Sub
End Class