Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim isValid As Boolean = login(username.Text, password.Text)
        If isValid = True Then
            Me.Hide()
            MenuPrincipal.Show()
        End If
    End Sub

End Class
