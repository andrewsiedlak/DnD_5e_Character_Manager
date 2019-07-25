Public Class Die

    'Public Shared Function DieRoller(input As String) As Integer

    '    Dim arguments = input.Split("+")
    '    Dim sum = 0
    '    For Each arg In arguments
    '        If arg.ToLower.Contains("d") Then
    '            Dim dieRollArgs = arg.ToLower.Split("d")
    '            sum += (RollValue(dieRollArgs(0), dieRollArgs(1)))
    '        Else
    '            sum += CInt(arg)
    '        End If
    '    Next
    '    Return sum
    'End Function

    '''' <summary>
    '''' Rolls a die of a given number of sides a given number of times and returns the sum of the results
    '''' </summary>
    '''' <param name="numOfDie">The number of times to roll</param>
    '''' <param name="numOfSides">The number of sides of the die to roll</param>
    '''' <returns></returns>
    'Private Shared Function RollValue(numOfDie As String, numOfSides As String) As Integer
    '    Return RollValue(CInt(numOfDie), CInt(numOfSides))
    'End Function

    ''' <summary>
    ''' The theoretical number of sides of this die object, controlling the maximum value it can be
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property NumberOfSides As Integer
        Get
            Return _numberOfSides
        End Get
    End Property
    Private _numberOfSides As Integer

    ''' <summary>
    ''' Returns a random number of minimum 0 and maximum being the number of sides of the die
    ''' </summary>
    ''' <returns></returns>
    Public Function RollValue() As UShort
        Dim rand = New Random
        Return rand.Next(minValue:=1, maxValue:=Me.NumberOfSides + 1)
    End Function

End Class
