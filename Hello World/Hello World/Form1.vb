Imports System.ComponentModel

Public Class Form1
    Private Sub PushButton_Click(sender As Object, e As EventArgs) Handles PushButton.Click
        Message.Text = "Button Clicked!"
    End Sub

    Private Sub PushButton_DoubleClick(sender As Object, e As EventArgs) Handles PushButton.DoubleClick
        Message.Text = "Hola Mundo!"
    End Sub

    Private Sub Message_Click(sender As Object, e As EventArgs) Handles Message.Click
        Message.Clear()
    End Sub
End Class
