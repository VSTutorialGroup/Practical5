Public Class Form1

    Private Const BASE_PAY As Decimal = 250D
    Private Const QUOTA As Decimal = 1000D
    Private Const COMM_RATE As Decimal = 0.15D
    Public count As Decimal = 0D
    Public totalSales As Double = 0
    Public totalCommission As Double = 0
    Public totalPay As Double = 0

    Private Function GetComm(sales As Decimal)
        Dim comm As Double = 0.0


        If (sales >= QUOTA) Then
            comm = sales * COMM_RATE

        Else
            comm = 0


        End If





        Return comm

    End Function


    Private Sub mnuFilePay_Click(sender As Object, e As EventArgs) Handles mnuFilePay.Click

        Dim pay As Double = 0.0


        Try
            Dim num As Double = GetComm(Double.Parse(txtSales.Text))
            pay = BASE_PAY + num
            txtPay.Text = Double.Parse(pay)
            txtCommission.Text = Double.Parse(num)
            totalSales += Double.Parse(txtSales.Text)
            totalCommission += num
            totalPay += pay

        Catch ex As Exception
            MsgBox("Invalid Input", MsgBoxStyle.Critical, "Error")
            txtCommission.Text = "N/A"
            txtPay.Text = "N/A"
        End Try

        count += 1



    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtName.Clear()
        txtSales.Clear()
        txtCommission.Clear()
        txtPay.Clear()
        txtName.Focus()


    End Sub

    Private Sub mnuFileSummary_Click(sender As Object, e As EventArgs) Handles mnuFileSummary.Click
        Dim message As String = "Record Process = " & count & vbNewLine & "Total Sales = " & totalSales & vbNewLine & "Total Commission= " & totalCommission & vbNewLine & " Total Pay = " & totalPay

        MsgBox(message, MsgBoxStyle.Information, "Summary")
        

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        txtPay.Font = FontDialog1.Font
        txtCommission.Font = FontDialog1.Font

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        count = 0
        totalCommission = 0
        totalPay = 0
        totalSales = 0
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        txtCommission.ForeColor = ColorDialog1.Color
        txtPay.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim developer As String = "Programmed by SOMEBOBY"

        MsgBox(developer, MsgBoxStyle.Information, "About")
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
