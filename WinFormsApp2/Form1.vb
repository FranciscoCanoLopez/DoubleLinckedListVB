Public Class Form1
    Inherits Form
    Private list As DoublyLinkedList = New DoublyLinkedList() ' Lista doblemente enlazada.

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAgg_Click(sender As Object, e As EventArgs)
        Dim value As Integer = Nothing

        If Integer.TryParse(txtData.Text, value) Then
            list.Add(value) ' Agregar en orden numérico.
            UpdateListView() ' Actualizar el ListView.
            MessageBox.Show($"Se agregó {value} a la lista.")
        Else
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
        End If
        txtData.Clear() ' Limpiar el TextBox.
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim value As Integer = Nothing

        If Integer.TryParse(txtData.Text, value) Then
            list.Delete(value) ' Eliminar el nodo con el valor.
            UpdateListView() ' Actualizar el ListView.
            MessageBox.Show($"Se eliminó {value} de la lista (si existía).")
        Else
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
        End If
        txtData.Clear() ' Limpiar el TextBox.
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Dim value As Integer = Nothing

        If Integer.TryParse(txtData.Text, value) Then
            Dim found As Boolean = list.Search(value) ' Buscar el valor.
            If found Then
                MessageBox.Show($"El número {value} se encuentra en la lista.")
            Else
                MessageBox.Show($"El número {value} no se encuentra en la lista.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
        End If
        txtData.Clear() ' Limpiar el TextBox.
    End Sub

    Private Sub UpdateListView()
        lvDisplay.Items.Clear() ' Limpiar el ListView.
        Dim current As Node = list.GetHead() ' Obtener la cabeza de la lista.
        Dim position = 1 ' Iniciar la posición desde 1.

        While current IsNot Nothing
            ' Crear un ítem de ListView con la posición como primer subitem.
            Dim item As ListViewItem = New ListViewItem(position.ToString())

            ' Añadir el dato del nodo como segundo subitem.
            item.SubItems.Add(current.Data.ToString())

            ' Agregar el ítem al ListView.
            lvDisplay.Items.Add(item)

            ' Avanzar al siguiente nodo.
            current = current.Next
            position += 1
        End While
    End Sub
End Class
