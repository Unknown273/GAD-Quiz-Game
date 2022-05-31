Public Class Question_1

    Private correct_answer_selected As Boolean

    Private Sub Option1_CheckedChanged(sender As Object, e As EventArgs) Handles Option1.CheckedChanged
        correct_answer_selected = False
    End Sub

    Private Sub Option2_CheckedChanged(sender As Object, e As EventArgs) Handles Option2.CheckedChanged
        correct_answer_selected = True
    End Sub

    Private Sub Option3_CheckedChanged(sender As Object, e As EventArgs) Handles Option3.CheckedChanged
        correct_answer_selected = False
    End Sub

    Private Sub Option4_CheckedChanged(sender As Object, e As EventArgs) Handles Option4.CheckedChanged
        correct_answer_selected = False
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Not correct_answer_selected Then
            MessageBox.Show("That's wrong! You loose!!!!!")
            Application.Exit()
        Else
            Hide()
            Question_2.Show()
        End If
    End Sub
End Class