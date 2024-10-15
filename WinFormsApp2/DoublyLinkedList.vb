Friend Class DoublyLinkedList
    Private head As Node ' Puntero al primer nodo de la lista.

    ' Constructor que inicializa la lista como vacía (head es null).
    Public Sub New()

    End Sub

    ' Método para agregar un nodo manteniendo el orden numérico ascendente.
    Public Sub Add(data As Integer)
        Dim newNode As Node = New Node(data)

        If head Is Nothing OrElse head.Data >= data Then ' Insertar al inicio si está vacía o el valor es menor.
            If head IsNot Nothing Then head.Prev = newNode
            head = newNode
        Else
            Dim current As Node = head
            While current.Next IsNot Nothing AndAlso current.Next.Data < data
                current = current.Next
            End While
            If current.Next IsNot Nothing Then current.Next.Prev = newNode
            current.Next = newNode
            newNode.Prev = current
        End If
    End Sub

    ' Método para eliminar un nodo por su valor.
    Public Sub Delete(data As Integer)
        If head Is Nothing Then Return ' Si la lista está vacía, no hacer nada.

        Dim current As Node = head

        ' Buscar el nodo con el valor especificado.
        While current IsNot Nothing AndAlso current.Data <> data
            current = current.Next
        End While

        If current Is Nothing Then Return ' Si no se encontró el valor, salir.

        ' Ajustar los punteros de los nodos adyacentes.
        If current.Prev IsNot Nothing Then
            current.Prev.Next = current.Next
        Else
            head = current.Next ' Si el nodo a eliminar es la cabeza, mover la cabeza.
        End If

        If current.Next IsNot Nothing Then
        End If
    End Sub

    ' Método para buscar un número en la lista.
    Public Function Search(data As Integer) As Boolean
        Dim current As Node = head

        ' Recorrer la lista buscando el dato.
        While current IsNot Nothing
            If current.Data = data Then Return True
            current = current.Next
        End While
        Return False ' Retornar false si no se encontró el dato.
    End Function
    Public Function GetHead() As Node
        Return head
    End Function
End Class