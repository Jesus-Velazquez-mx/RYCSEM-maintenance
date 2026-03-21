Partial Class DS_FV001
    Partial Public Class articulosDataTable
        Private Sub articulosDataTable_articulosRowChanging(sender As Object, e As articulosRowChangeEvent) Handles Me.articulosRowChanging

        End Sub

        Private Sub articulosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.imagenColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class notas_venta_detalleDataTable
        Private Sub notas_venta_detalleDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nombre_imagenColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
