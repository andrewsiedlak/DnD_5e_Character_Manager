Public Class Stat

#Region "Fields"

#End Region

#Region "Enumerations"

    Public Enum StatType

        Strength
        Dexterity
        Constitution
        Intelligence
        Wisdom
        Charisma

    End Enum

#End Region

#Region "Constructors"

    Public Sub New(statType As StatType, value As Integer)

        Me._type = statType
        Me._value = value

    End Sub

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

#End Region

#Region "Methods"

    Public ReadOnly Property Type As StatType
        Get
            Return _type
        End Get
    End Property
    Private Property _type As StatType

    Public ReadOnly Property Value As Integer
        Get
            Return _value
        End Get
    End Property
    Private Property _value As Integer

    Public ReadOnly Property Modifier As Integer
        Get
            Dim value = Me.Value - 10
            Return If(value > 10, Math.Ceiling(value / 2), Math.Floor(value / 2))
        End Get
    End Property


#End Region

#Region "Events"

#End Region

End Class
