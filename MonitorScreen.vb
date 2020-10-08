Imports System.Configuration

Public Class MonitorScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uri As Uri = New Uri(ConfigurationManager.AppSettings.Get("url"))
        webView.Source = uri
        Location = Screen.AllScreens(1).WorkingArea.Location
    End Sub
End Class
