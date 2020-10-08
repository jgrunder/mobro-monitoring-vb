Imports System.Configuration

Public Class MonitorScreen
    ' Get all parameters from application configuration file
    Private ReadOnly Url As String = ConfigurationManager.AppSettings.Get("url")
    Private ReadOnly ScreenId As Integer = ConfigurationManager.AppSettings.Get("screen_id")
    Private ReadOnly ScreenWidth As Integer = ConfigurationManager.AppSettings.Get("screen_width")
    Private ReadOnly ScreenHeight As Integer = ConfigurationManager.AppSettings.Get("screen_height")
    Private Sub MonitorScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set application size
        Width = ScreenWidth
        Height = ScreenHeight
        ' Set WebView size
        webView.Width = ScreenWidth
        webView.Height = ScreenHeight
        Dim uri As Uri = New Uri(Url)
        webView.Source = uri
        Location = Screen.AllScreens(ScreenId).WorkingArea.Location
    End Sub
End Class
