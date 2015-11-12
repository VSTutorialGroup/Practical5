Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblResult.Text = "(a) " & Helper.GetTriangleArea(12.3, 45.6) & vbNewLine &
                         "(b) " & Helper.GetCircleArea(10.0) & vbNewLine &
                         "(c) " & Helper.InchToCM(10.0) & vbNewLine &
                         "(d) " & Helper.DayOfWeek(3) & vbNewLine &
                         "(e) " & Helper.GetGrade(67) & vbNewLine


    End Sub
End Class