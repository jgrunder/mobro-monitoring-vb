<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonitorScreen
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.SuspendLayout()
        '
        'webView
        '
        Me.webView.Location = New System.Drawing.Point(0, 0)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(1024, 600)
        Me.webView.Source = New System.Uri("http://localhost", System.UriKind.Absolute)
        Me.webView.TabIndex = 0
        Me.webView.Text = "Monitoring"
        Me.webView.ZoomFactor = 1.0R
        '
        'MonitorScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.webView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MonitorScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
