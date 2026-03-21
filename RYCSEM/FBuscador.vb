Public Class FBuscador
    Dim TabBuscar As String = ""
    Dim FiltroTab As String = ""
    Public codigo As String = ""
    Public Sub New(Tabla As String, Optional Filtro As String = "")
        InitializeComponent()
        Me.TabBuscar = Tabla
        Me.FiltroTab = Filtro
    End Sub


    Private Sub FBuscador_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Help.inicializa() Then Me.Close()
        Me.SqlCnn.ConnectionString = Help.stringConexion
        If Me.TabBuscar.ToString.Trim <> "" Then Me.Refrescar()
        Me.MyDataGrid1.Focus()
        If Me.DvDatos.Count > 0 Then
            Me.BindingContext(Me.DvDatos).Position = 0    '    
            Me.MyDataGrid1.CurrentCell = New DataGridCell(0, 0)
            Me.MyDataGrid1.Focus()
        End If
        'Me.txtFiltro.SelectAll()
        Me.MyDataGrid1.Focus()
        Me.txtFiltro.Focus()
    End Sub

    Private Sub Refrescar()
        Me.DS_Buscador.datos.Clear()
        Me.DS_Buscador.columnas.Clear()
        Me.SdaDatos.SelectCommand.Parameters("@Tabla").Value = Me.TabBuscar
        Me.SdaDatos.SelectCommand.Parameters("@Filtro").Value = Me.FiltroTab
        Me.SdaDatos.Fill(Me.DS_Buscador)
        Me.ConfiguraColumnas()
        Me.filtrar()
        Me.MyDataGrid1.CaptionText = Me.TabBuscar.ToUpper
    End Sub

    Private Sub ConfiguraColumnas()
        If Me.DS_Buscador.columnas.Count() = 4 Then
            Me.ColCodigo.HeaderText = Me.DS_Buscador.columnas(0).nombre
            Me.ColNombre.HeaderText = Me.DS_Buscador.columnas(1).nombre
            Me.ColMonto.HeaderText = Me.DS_Buscador.columnas(2).nombre & "."
            Me.ColCantidad.HeaderText = Me.DS_Buscador.columnas(3).nombre & "."
        End If
        If Me.DS_Buscador.datos.Count > 0 Then
            With Me.DS_Buscador.datos(0)
                If .visible_f Then
                    Me.ColFecha.Width = 75
                    Me.ColFecha.HeaderText = "Fecha"
                Else
                    Me.ColFecha.Width = 0
                    Me.ColFecha.HeaderText = ""
                End If
                If .visible_m Then
                    Me.ColMonto.Width = 75
                Else
                    Me.ColMonto.Width = 0
                    Me.ColMonto.HeaderText = ""
                End If
                If .visible_c Then
                    Me.ColCantidad.Width = 75
                    Me.ColCantidad.Format = "###0"

                Else
                    Me.ColCantidad.Width = 0
                    Me.ColCantidad.HeaderText = ""
                End If
            End With
        End If
    End Sub

    Private Sub MyDataGrid1_DoubleClick(sender As Object, e As EventArgs) Handles MyDataGrid1.DoubleClick
        Dim p As Integer = Me.BindingContext(Me.DvDatos).Position
        If p > -1 Then
            Me.codigo = Me.DvDatos(p)!codigo.ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub MyDataGrid1_PresionarTeclas(Tecla As Keys) Handles MyDataGrid1.PresionarTeclas
        If Tecla = Keys.Enter Then
            Dim p As Integer = Me.BindingContext(Me.DvDatos).Position
            If p > -1 Then
                Me.codigo = Me.DvDatos(p)!codigo.ToString.Trim
                Me.Close()
            End If
        End If
    End Sub

    Private Sub MT_reportes1_ButtonClick(indice As Integer) Handles MT_reportes1.ButtonClick
        Select Case indice
            Case 1 'Refrescar
                Me.Refrescar()
        End Select
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Me.filtrar()
    End Sub

    Private Sub filtrar()
        Dim Filtro As String = ""
        Filtro = Me.txtFiltro.Text.Trim
        If Filtro.Trim = "" Then
            Me.DvDatos.RowFilter = ""
        Else
            Me.DvDatos.RowFilter = "codigo like '%" & Filtro.Trim & "%' or nombre like '%" & Filtro.Trim & "%'"
        End If
    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.DvDatos.Count = 0 Then Exit Sub
            Me.codigo = Me.DvDatos(0)!codigo.ToString.Trim
            Me.Close()
        End If
    End Sub

    Private Sub FBuscador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.txtFiltro.Focus()
    End Sub

End Class