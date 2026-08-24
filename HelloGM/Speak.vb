Namespace HelloGM

    Public Class Speak

        Public Function Talk() As String
            Return "Hello GameMaker"
        End Function

        Public Function Number() As Double
            Return 9
        End Function

        Public Function HelloName(ByVal YourName As String) As String
            Return "Yo " & YourName
        End Function

        Public Function HelloNumber(ByVal YourName As String) As Double
            Select Case YourName.ToLower
                Case "jase"
                    Return 1.1
                Case "cody"
                    Return 2.2
                Case Else
                    Return 3.3
            End Select

        End Function

        Public Function ReturnAString(ByVal Number As Double) As String
            Return "Yo " & Number.ToString
        End Function

        Public Function ReturnANumber(ByVal Number As Double) As Double
            Return Number * 2
        End Function

        Public Function DoLoop(ByVal Number As Double) As String
            For a As Int64 = 1 To Number

            Next
            Return "Complete"
        End Function

    End Class

End Namespace
