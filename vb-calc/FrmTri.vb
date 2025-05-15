Public Class FrmTri
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim teihen As Integer = txtTeihen.Text
        Dim takasa As Integer = txtTakasa.Text
        Dim menseki As Integer

        menseki = teihen * takasa
        lblMenseki.Text = menseki

    End Sub
End Class