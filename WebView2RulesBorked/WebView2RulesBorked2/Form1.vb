Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Resources.dostuff
        WebView21 = new Microsoft.Web.WebView2.WinForms.WebView2()
        WebView21.Name = My.Resources.dostuff
    End Sub
End Class
