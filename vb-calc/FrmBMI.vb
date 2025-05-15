Public Class FrmBMI
    Private sintyo As Double
    Private taijyu As Double
    Private bmi As Double
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        sintyo = txtSincyo.Text / 100
        taijyu = txtTaijyu.Text

        bmi = taijyu / (sintyo * sintyo)
        lblBMI.Text = bmi
    End Sub
End Class