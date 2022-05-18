Public Class SegumientoPagos
    Private Sub SegumientoPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idSearch As Integer = infoUser(0)

        'Valida si el usuario es admin
        If infoUser(1) = "1" Then
            idSearch = "-1"
        End If

        Dim news As DataSet = getPayments(idSearch)
        If news.Tables(0).Rows.Count > 0 Then
            DataNoticias.DataSource = news.Tables(0)
        Else
            DataNoticias.DataSource = Nothing
        End If


    End Sub
End Class