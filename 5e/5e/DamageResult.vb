Public Structure DamageResult

    Public Sub New(damageValue As UShort, damageType As Damage.DamageTypes)
        Me._damageValue = damageValue
        Me._damageType = damageType
    End Sub

    Public ReadOnly Property DamageValue As UShort
        Get
            Return _damageValue
        End Get
    End Property
    Private _damageValue As UShort

    Public ReadOnly Property DamageType As Damage.DamageTypes
        Get
            Return _damageType
        End Get
    End Property
    Private _damageType As Damage.DamageTypes

End Structure
