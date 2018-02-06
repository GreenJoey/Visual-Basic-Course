Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If RadioButton1.IsChecked Then
            MessageBox.Show("Hello.")
        ElseIf RadioButton2.IsChecked Then
            MessageBox.Show("Goodbye.")
        End If
    End Sub
End Class
