Module Module1
    Structure JobStuff
        Dim theName As String
        Dim theHours As Double

        Public Overrides Function ToString() As String
            Return theName
        End Function
    End Structure
End Module
