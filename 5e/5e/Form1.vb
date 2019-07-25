Public Class Form1


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Generate()
    End Sub

    Private Property Character As Character

    Private Sub Generate()

        Me.Character = New Character(strScore:=strBox.Text, dexScore:=dxBox.Text, conScore:=conBox.Text, intScore:=intBox.Text, wisScore:=wisBox.Text, charScore:=charBox.Text)

        Me.strModBox.Text = Me.Character.Stats.Get(Stat.StatType.Strength).Modifier
        Me.dexModBox.Text = Me.Character.Stats.Get(Stat.StatType.Dexterity).Modifier
        Me.conModBox.Text = Me.Character.Stats.Get(Stat.StatType.Constitution).Modifier
        Me.intModBox.Text = Me.Character.Stats.Get(Stat.StatType.Intelligence).Modifier
        Me.wisModBox.Text = Me.Character.Stats.Get(Stat.StatType.Wisdom).Modifier
        Me.charModBox.Text = Me.Character.Stats.Get(Stat.StatType.Charisma).Modifier

    End Sub

    Private Function MakeCheck(statType As Stat.StatType) As UShort
        Dim value = Me.Character.AbilityCheck(statType:=statType)
        Console.WriteLine(String.Format("Rolled: {0}", value))
    End Function

    Private Sub StButton_Click(sender As Object, e As EventArgs) Handles StButton.Click
        MakeCheck(Stat.StatType.Strength)
    End Sub

    Private Sub DxButton_Click(sender As Object, e As EventArgs) Handles DxButton.Click
        MakeCheck(Stat.StatType.Dexterity)
    End Sub

End Class
