Public Class UserAgreement

    Private user_has_agreed As Boolean = False

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        user_has_agreed = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If user_has_agreed Then
            Hide()
            Question_1.Show()
        Else
            MessageBox.Show("You first need to agree with the conditions stated.")
        End If
    End Sub
End Class