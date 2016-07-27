Class pgStart

    Private Sub IdentityPresentationDone(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("pack://application:,,,/Pages/pgMainScreen.xaml", UriKind.Absolute))
    End Sub
End Class
