Class pgMainScreen

    Private Sub mnuAbout_Click(sender As Object, e As RoutedEventArgs)
        NavigationService.Navigate(New Uri("pack://application:,,,/Pages/pgAbout.xaml", UriKind.Absolute))
    End Sub
End Class
