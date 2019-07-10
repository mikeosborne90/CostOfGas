Public Class GasCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim miles As Decimal = CDec(textBoxMilesDriven.Text)
            Dim mpg As Decimal = CDec(textBoxMpg.Text)
            Dim gasPrice As Decimal = CDec(textBoxGasPrice.Text)

            lblResult.Text = "$" & CStr(Decimal.Round(((miles / mpg) * gasPrice), 2))
        Catch ex As Exception

        End Try
    End Sub
End Class
