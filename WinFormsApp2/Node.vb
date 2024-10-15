Public Class Node
    Public Property Data As Integer
    Public Property [Next] As Node
    Public Property Prev As Node

    Public Sub New(data As Integer)
        Me.Data = data
    End Sub
End Class
