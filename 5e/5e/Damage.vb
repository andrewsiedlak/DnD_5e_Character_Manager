Public Class Damage

#Region "Fields"

#End Region

#Region "Enumerations"

    Public Enum DamageTypes

        Bludgeoning
        Slashing
        Piercing
        Fire
        Water
        Thunder
        Frost
        Necrotic
        Radiant

    End Enum

#End Region

#Region "Constructors"

    Public Sub New(damageDie As Die, damageType As DamageTypes)

        Me._damageDie = damageDie
        Me._damageType = damageType
    End Sub

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

    Public ReadOnly Property DamageType As DamageTypes
        Get
            Return _damageType
        End Get
    End Property
    Private _damageType As DamageTypes

    Public ReadOnly Property DamageDie As Die
        Get
            Return _damageDie
        End Get
    End Property
    Private _damageDie As Die

    Public ReadOnly Property ConstantDamage As Integer?
        Get
            Return _constantDamage
        End Get
    End Property
    Private _constantDamage As Integer

#End Region

#Region "Methods"

    Public Function GetDamage() As DamageResult

        If Not IsNothing(DamageDie) AndAlso Not IsNothing(ConstantDamage) Or
                IsNothing(DamageDie) AndAlso IsNothing(ConstantDamage) Then
            Throw New InvalidOperationException("Damage cannot have both a damage die and constant damage")
        End If

        If DamageDie IsNot Nothing Then
            Return New DamageResult(damageValue:=Me.DamageDie.RollValue(), damageType:=Me.DamageType)
        ElseIf ConstantDamage IsNot Nothing Then
            Return ConstantDamage
        End If

    End Function

#End Region

#Region "Events"

#End Region

End Class
