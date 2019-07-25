Public Class DamageCollection

#Region "Fields"

#End Region

#Region "Enumerations"

#End Region

#Region "Constructors"

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

    Property Damages As New List(Of Damage)

#End Region

#Region "Methods"

    Public Sub Add(damage As Damage)
        Me.Damages.Add(damage)
    End Sub

    Public Sub AddRange(collection As IEnumerable(Of Damage))
        Me.Damages.AddRange(collection)
    End Sub

    Public Function GetDamage() As List(Of DamageResult)
        Dim results = New List(Of DamageResult)
        For Each damage In Me.Damages
            results.Add(damage.GetDamage())
        Next
        Return results
    End Function
#End Region

#Region "Events"

#End Region

End Class
