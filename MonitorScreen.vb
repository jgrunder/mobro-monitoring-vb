Public Class MonitorScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Screen.AllScreens(1).WorkingArea.Location
    End Sub
End Class
