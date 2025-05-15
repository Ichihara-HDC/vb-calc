Public Class FrmTra
    Private joutei As Integer
    Private katei As Integer
    Private takasa As Integer
    Private menseki As Integer
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        joutei = txtJyotei.Text
        katei = txtKatei.Text
        takasa = txtTakasa.Text

        menseki = (joutei + katei) * takasa / 2
        lblMenseki.Text = menseki
    End Sub
End Class