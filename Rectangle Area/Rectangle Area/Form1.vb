Public Class Form1
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Result.Text = Val(Length.Text) * Val(Breadth.Text)
        Clear.Select()
    End Sub

    Private Sub Result_GotFocus(sender As Object, e As EventArgs) Handles Result.GotFocus
        ' If the Result gets focus, then populate it with the area
        ' For this we just emulate the click on Calculate button using `.PerformClick()`
        Calculate.PerformClick()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()  ' Dispose and thus close the form
    End Sub

    Private Sub Length_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Length.KeyPress
        ' KeyPressEventArgs encapsulates the entered key in string format.
        ' Using the `Asc()`,  we got the ASCII value
        ' Now if the value is 13, i.e ASCII value for __ENTER__ key, then select the Breadth field
        If Asc(e.KeyChar) = 13 Then
            Breadth.Select()
        End If
    End Sub

    Private Sub Breadth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Breadth.KeyPress
        ' KeyPressEventArgs encapsulates the entered key in string format.
        ' Using the `Asc()`,  we got the ASCII value
        ' Now if the value is 13, i.e ASCII value for __ENTER__ key, then emulate the click on **Calculate** using `.PerformClick()`
        If Asc(e.KeyChar) = 13 Then
            Calculate.PerformClick()
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Length.Clear()
        Breadth.Clear()
        Result.Clear()
        Length.Select()
    End Sub
End Class
