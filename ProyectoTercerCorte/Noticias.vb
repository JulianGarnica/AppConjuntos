Public Class Noticias

    Private Sub Noticias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim news As DataSet = getNews()
        If news.Tables(0).Rows.Count > 0 Then
            DataNoticias.DataSource = news.Tables(0)
        Else
            DataNoticias.DataSource = Nothing
        End If

        If infoUser(1) = "1" Then
            addNotice.Visible = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        addNews(txtTitular.Text, txtContenido.Text)
        Me.Controls.Clear()
        InitializeComponent()
        Noticias_Load(e, e)
    End Sub
End Class