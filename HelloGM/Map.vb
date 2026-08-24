Public Class Map

    Private Enum MapUnit
        Kilometre = 1
        Mile = 2
        NauticalMile = 3
    End Enum

    Public Function GetMapWidth(ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Double
        Return DistanceBetweenTwoPoints(X1, Y1, X2, Y1, MapUnit.Kilometre)
    End Function

    Public Function GetMapHeight(ByVal X1 As Double, ByVal Y1 As Double, ByVal X2 As Double, ByVal Y2 As Double) As Double
        Return DistanceBetweenTwoPoints(X1, Y2, X2, Y2, MapUnit.Kilometre)
    End Function

    Private Function DistanceBetweenTwoPoints(ByVal Latitude1 As Double, ByVal Longitude1 As Double, ByVal Latitude2 As Double, ByVal Longitude2 As Double, ByVal Unit As MapUnit) As Double
        Dim Theta As Double = Longitude1 - Longitude2
        Dim Distance As Double = Math.Sin(DegreesToRadians(Latitude1)) * Math.Sin(DegreesToRadians(Latitude2)) + Math.Cos(DegreesToRadians(Latitude1)) * Math.Cos(DegreesToRadians(Latitude2)) * Math.Cos(DegreesToRadians(Theta))

        Distance = Math.Acos(Distance)
        Distance = RadiansToDegrees(Distance)
        Distance = Distance * 60 * 1.1515

        Select Case Unit
            Case MapUnit.Kilometre
                Distance = Distance * 1.609344
            Case MapUnit.NauticalMile
                Distance = Distance * 0.8684
        End Select

        Return Distance
    End Function

    Private Function DegreesToRadians(ByVal Degrees As Double) As Double
        Return (Degrees * Math.PI / 180.0)
    End Function

    Private Function RadiansToDegrees(ByVal Radians As Double) As Double
        Return Radians / Math.PI * 180.0
    End Function

End Class
