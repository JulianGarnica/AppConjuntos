Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msgBienvenido.Text = "¡Bienvenido " & infoUser(2) & "!"
        If infoUser(1) = "1" Then
            btnInfoDuenos.Visible = True
        End If
    End Sub

    Private Sub btnNoticias_Click(sender As Object, e As EventArgs) Handles btnNoticias.Click
        Noticias.Show()
    End Sub

    Private Sub btnPagarAdmon_Click(sender As Object, e As EventArgs) Handles btnPagarAdmon.Click
        PagarAdmon.Show()
    End Sub

    Private Sub btnSeguimientoPagos_Click(sender As Object, e As EventArgs) Handles btnSeguimientoPagos.Click
        SegumientoPagos.Show()
    End Sub

    Private Sub btnInfoDuenos_Click(sender As Object, e As EventArgs) Handles btnInfoDuenos.Click
        InfoDuenos.Show()
    End Sub
End Class