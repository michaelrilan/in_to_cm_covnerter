Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cm_txt.TextChanged
        in_txt.Text = 0

    End Sub

    Private Sub in_txt_TextChanged(sender As Object, e As EventArgs) Handles in_txt.TextChanged
        cm_txt.Text = 0
    End Sub

    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click
        Dim cm_get As Double = cm_txt.Text

        Dim in_get As Double = in_txt.Text
        Dim formula_to_in As Double = cm_get * 0.393701
        Dim formula_to_cm As Double = in_get * 2.54

        If cm_get = 0 Then
            MsgBox("Conversion to cm:" & formula_to_cm & "cm")
        ElseIf in_get = 0 Then
            MsgBox("Conversion to in:" & formula_to_in & "in")

        End If


    End Sub
End Class
