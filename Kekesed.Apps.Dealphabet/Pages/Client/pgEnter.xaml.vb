Class pgEnter

    Private Sub btnAl_Click(sender As Object, e As RoutedEventArgs) Handles btnAl.Click
        Dim Res As New pgResult
        Res.txtResult.Text = Algorithm.Alphabetizor.Convert(txtInput.Text, txtAlphabetDelimiter.Text)

        NavigationService.Navigate(Res)
    End Sub

    Private Sub btnDe_Click(sender As Object, e As RoutedEventArgs) Handles btnDe.Click
        Dim Res As New pgResult
        Res.txtResult.Text = Algorithm.Dealphabetizor.Convert(txtInput.Text, txtAlphabetDelimiter.Text)

        NavigationService.Navigate(Res)
    End Sub
End Class
