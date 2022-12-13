Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim name_val As String
        Dim fave_num_val As String
        name_val = namee.Text
        fave_num_val = fave_num.Text

        recieved.Text = "Information Saved!!"
        name_out.Text = "Name: " & name_val
        fave_num_out.Text = "Favorite Number: " & fave_num_val

    End Sub
End Class
