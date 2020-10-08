Imports System.Configuration

Public Class MonitorScreen
    ' Get all parameters from application configuration file
    Private ReadOnly Url As String = ConfigurationManager.AppSettings.Get("url")
    Private ReadOnly ScreenId As Integer = ConfigurationManager.AppSettings.Get("screen_id")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uri As Uri = New Uri(Url)
        webView.Source = uri
        Location = Screen.AllScreens(ScreenId).WorkingArea.Location
    End Sub
End Class
