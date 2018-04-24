Public Class Form1

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
top:

        Select Case from.SelectedIndex
            Case 0
                vars.fromA = amount.Text
                vars.ans = vars.fromA * rates.eur
                ans.Text = vars.ans
            Case 1
                vars.fromA = amount.Text
                vars.ans = vars.fromA * rates.usd
                ans.Text = vars.ans
            Case 2
                vars.fromA = amount.Text
                vars.ans = vars.fromA * rates.cad
                ans.Text = vars.ans
            Case 3
                vars.fromA = amount.Text
                vars.ans = vars.fromA * rates.aud
                ans.Text = vars.ans
            Case Else
                MsgBox("choose a currancy", MsgBoxStyle.OkOnly)
                'GoTo top
        End Select
    End Sub
End Class
