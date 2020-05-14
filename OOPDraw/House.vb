Public Class House
    Inherits Shape
    Private Property Width As Single
    Private Property WallHeight As Single
    Private Property Walls As Rectangle
    Private Property Roof As EquilateralTriangle

    Public Sub New(originX As Single, originY As Single, Width As Single, WallHeight As Single)
        MyBase.New(originX, originY)
        Me.Width = Width
        Me.WallHeight = WallHeight
        Walls = New Rectangle(originX, originY, Width, WallHeight)
        Roof = New EquilateralTriangle(originX, originY + WallHeight, Width)
    End Sub

    Public Overrides Sub Draw()
        Walls.Draw()
        Roof.Draw()
    End Sub

    Public Overrides Sub MoveTo(x As Single, y As Single)
        MyBase.MoveTo(x, y)
        Walls.MoveTo(x, y)
        Roof.MoveTo(x, y + WallHeight)
    End Sub


    Public Overrides Sub SelectShape()
        Walls.SelectShape()
        Roof.SelectShape()
    End Sub

    Public Overrides Sub UnselectShape()
        Walls.UnselectShape()
        Roof.UnselectShape()
    End Sub

    Public Overrides Sub Resize(x As Single, y As Single)
        Width = x
        Dim yDiff = y - WallHeight
        WallHeight = y
        Walls.Resize(x, y)
        Roof.Resize(x, 0)
        Roof.MoveBy(0, yDiff)
    End Sub

End Class

