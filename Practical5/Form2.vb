Public Class Form2


    Private Function GetInterest(principal As Decimal, rate As Decimal, duration As Integer)

        Dim interest As Double
            interest = principal * rate * duration
       

        Return interest

    End Function


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtPrincipal.Clear()
        txtDuration.Clear()
        txtInterestRate.Clear()
        lblInterest.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim answer As Double = GetInterest(Double.Parse(txtPrincipal.Text), Double.Parse(txtInterestRate.Text), Double.Parse(txtDuration.Text))
            lblInterest.Text = Double.Parse(answer)
        Catch ex As Exception

            lblInterest.Text = "N/A"
        End Try


    End Sub
End Class