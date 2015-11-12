Module Helper

    Public Function GetTriangleArea(a As Double, b As Double)
        Dim area As Double
        area = 0.5 * a * b

        Return area
    End Function

    Public Function GetCircleArea(radius As Double)
        Dim area As Double
        area = Math.PI * Math.Pow(radius, 2)

        Return area
    End Function

    Public Function InchToCM(inch As Double)
        Dim cm As Double

        cm = inch * 2.54

        Return cm
    End Function

    Public Function DayOfWeek(day As Integer)

        Dim d As String

        If (day = 0) Then
            d = "Sunday"

        ElseIf (day = 1) Then
            d = "Monday"

        ElseIf (day = 2) Then
            d = "Tuesday"

        ElseIf (day = 3) Then
            d = "Wednesday"

        ElseIf (day = 4) Then
            d = "Thursday"

        ElseIf (day = 5) Then
            d = "Friday"

        Else
            d = "Saturday"

        End If

        Return d

    End Function

    Public Function GetGrade(mark As Integer)

        Dim grade As String

        If (mark >= 90 And mark <= 100) Then
            grade = "A"

        ElseIf (mark >= 80) Then
            grade = "B"

        ElseIf (mark >= 60) Then
            grade = "C"

        ElseIf (mark >= 50) Then
            grade = "D"

        ElseIf (mark >= 0) Then
            grade = "F"

        Else
            grade = "x"


        End If

        Return grade

    End Function

End Module
