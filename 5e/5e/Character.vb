Public Class Character

#Region "Fields"

#End Region

#Region "Enumerations"

#End Region

#Region "Constructors"

    Public Sub New(strScore As Integer, dexScore As Integer, conScore As Integer,
                   intScore As Integer, wisScore As Integer, charScore As Integer)

        Me._stats = New StatBlock(strScore, dexScore, conScore, intScore, wisScore, charScore)

    End Sub

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

    Public ReadOnly Property Stats As StatBlock
        Get
            Return _stats
        End Get
    End Property
    Private _stats As StatBlock

    Private ReadOnly Property CheckDie As Die
        Get
            If _checkDie Is Nothing Then _checkDie = New Die(numOfSides:=20)
            Return _checkDie
        End Get
    End Property
    Private _checkDie As Die


#End Region

#Region "Methods"

    Public Function AbilityCheck(statType As Stat.StatType) As Integer

        Dim value = Me.CheckDie.RollValue()
        value += Me.Stats.Get(statType:=statType).Modifier
        Return value

    End Function

#End Region

#Region "Events"

#End Region

End Class
