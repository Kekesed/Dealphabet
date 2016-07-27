Class pgAbout

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblVer.Content = "v" & My.Application.Info.Version.ToString
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        NavigationService.GoBack()
    End Sub
End Class
