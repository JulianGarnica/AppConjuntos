Public Class PagarAdmon
    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        addPayment(CDbl(Val(txtValorPagar.Text)), infoUser(0))
    End Sub

End Class