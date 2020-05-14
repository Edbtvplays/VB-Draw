Imports Nakov.TurtleGraphics
Public Class EquilateralTriangle
    Inherits Shape

    Private Property sideLength As Single

    'The 'Constructor'
    Public Sub New(xOrigin As Single, yOrigin As Single, sideLength As Single)
        MyBase.New(xOrigin, yOrigin)
        Me.XOrigin = xOrigin
        Me.YOrigin = yOrigin
        Me.sideLength = sideLength
    End Sub

    Public Overrides Sub Draw()
        ResetTurtle()
        Turtle.Rotate(30)
        For i = 1 To 3
            Turtle.Forward(sideLength)
            Turtle.Rotate(120)
        Next
    End Sub
    Public Overrides Sub Resize(x As Single, y As Single)
        sideLength = x
    End Sub

End Class
