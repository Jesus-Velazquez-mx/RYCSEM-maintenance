Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles
Imports System.Drawing.Printing


Module Help
    Public MyTrans As SqlClient.SqlTransaction
    Public stringConexion As String
    Public usuario As String
    Public Function inicializa() As Boolean
        Dim dt As New DS_FIniC.conexionDataTable
        If Not CN.cadenConexion(, dt, Help.stringConexion) Then
            MsgBox("Error al obtener la conexion", MsgBoxStyle.Information)
            Return False
        End If
        Return True
    End Function
    Public Function obtieneDato(ByVal Comando As String, Optional ByVal TimeOut As Integer = 30) As Object
        Dim SqlCnn As New SqlClient.SqlConnection(stringConexion)
        Try
            Dim SqlC As New SqlClient.SqlCommand(Comando, SqlCnn)
            SqlC.CommandTimeout = TimeOut
            If SqlCnn.State <> ConnectionState.Open Then SqlCnn.Open()
            Return SqlC.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Information)
            ' MG.Manejo_errores()
            Return Nothing
        Finally
            If SqlCnn.State <> ConnectionState.Closed Then SqlCnn.Close()
        End Try
    End Function
    Public Function dataViewPos(ByVal dv As DataView, ByVal codigo As String, Optional ByVal indice As Integer = 0, Optional ByVal countmenos As Integer = 1) As Integer
        Dim i As Long
        For i = 0 To dv.Count - countmenos
            If codigo.Trim.ToLower = dv.Item(i).Item(indice).ToString.Trim.ToLower Then
                Return i
                Exit Function
            End If
        Next
        Return -1
    End Function
    Public Function generaFolio(ByVal conexion As SqlClient.SqlConnection, ByVal transaccion As String) As String ', ByRef folioNvo As String, ByVal errores As String) As String
        Dim bandera As Boolean
        Dim folioNvo, errores As String
        folioNvo = "" : errores = ""
        Dim scmdfolio As New SqlClient.SqlCommand
        scmdfolio.Transaction = MyTrans
        scmdfolio.Connection = conexion
        scmdfolio.CommandType = CommandType.StoredProcedure
        scmdfolio.CommandText = "dbo.[generaFolio]"
        scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@RETURN_VALUE", SqlDbType.Char, 10, ParameterDirection.ReturnValue, False, CType(10, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        'scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, False, CType(10, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        scmdfolio.Parameters.Add("@trans", SqlDbType.VarChar, 5).Value = transaccion
        scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@msg", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Output, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@folio", System.Data.SqlDbType.Char, 10, System.Data.ParameterDirection.Output, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        'scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@folio", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        'scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@folio", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        'scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@maxreng", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Output, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        'scmdfolio.Parameters.Add("@equipcode", SqlDbType.VarChar, 5).Value = Equipo
        'scmdfolio.Parameters.Add(New SqlClient.SqlParameter("@unidadpermitida", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Output, False, CType(0, Byte), CType(0, Byte), "", DataRowVersion.Current, UnidadPermitida))

        If conexion.State = ConnectionState.Closed Then
            scmdfolio.Connection.Open()
            bandera = True
        End If
        scmdfolio.ExecuteNonQuery()

        'Dim var As Integer
        'folioNvo = scmdfolio.Parameters(0).Value
        'folioNvo = scmdfolio.Parameters("@folio").Value
        'errores = scmdfolio.Parameters("@msg").Value

        folioNvo = scmdfolio.Parameters("@folio").Value.ToString()
        errores = scmdfolio.Parameters("@msg").Value.ToString()

        If bandera Then scmdfolio.Connection.Close()
        If errores Is Nothing Then
            errores = ""
        Else
            If errores.Trim <> "" Then
                MsgBox(errores, MsgBoxStyle.Information)
                Return ""
            End If
        End If
        If folioNvo Is Nothing Then folioNvo = ""
        Return folioNvo
    End Function

    Sub SetAll(ByVal grupo As Object, ByVal prop As String, ByVal val As Object, Optional ByVal clase As String = "")
        ' grupo --> objeto contenedor
        ' val --> valor asignado a la propiedad
        ' clase --> clase de objetos a cambiar propiedad si el prametro es nothing 
        '           afecta todos los objetos
        If clase.Trim.ToLower = "numericupdown" Then
            clase &= "mynumeric"
        End If
        Dim obj As Object
        For Each obj In grupo.Controls
            'Si va a afectar a una clase de objetos o a todos
            If clase = "" Then
                SelProp(obj, prop, val)
            Else
                ' Si encuentra el objeto actual es de el tipo de losque se van a cambiar
                If InStr(1, clase, TypeName(obj), CompareMethod.Text) > 0 Then
                    'asignar el valor de la propiedad
                    SelProp(obj, prop, val)
                End If
            End If
            ' si el objeto es a su vez contenedor se hace una llamada recursiva
            If obj.controls.count > 0 Then
                SetAll(obj, prop, val, clase)
            End If
        Next
    End Sub

    Sub SelProp(ByVal obj As Object, ByVal prop As String, ByVal val As Object)
        Select Case prop.ToUpper
            Case Is = "ENABLED"
                obj.enabled = val
            Case Is = "VISIBLE"
                obj.visible = val
            Case Is = "READONLY"
                obj.Readonly = val
            Case Is = "VALUE"
                obj.value = val
            Case Is = "SELECTEDVALUE"
                obj.selectedvalue = val
            Case Is = "CHECKED"
                obj.checked = val
            Case Is = "SELECTEDVALUE"
                obj.selectedvalue = val
            Case Is = "SELECTEDINDEX"
                obj.selectedindex = val
            Case Is = "PASSWORDCHAR"
                obj.passwordchar = val
            Case Is = "TEXT"
                obj.text = val
        End Select
    End Sub

    Public Sub ImagenBD(ByVal Folio As String, ByVal Trans As String, ByVal Tipo As String, ByRef PictureBox As PictureBox,
  Optional ByVal Ajustar As Boolean = False, Optional ByVal Msg As Boolean = True)
        Try
            PictureBox.Image = Nothing
            Dim C As String = "select top 1 ruta, imagen, ltrim(rtrim(nombre)) as nombre from imagenes where transaccion = '" & Trans & "' and tipo_imagen = '" & Tipo & "'"
            If Folio.Trim <> "" Then C &= " and folio = '" & Folio & "'"
            Dim SDA_Img As New SqlClient.SqlDataAdapter(C, stringConexion)
            SDA_Img.SelectCommand.CommandTimeout = 600
            Dim DS As New DataSet
            If SDA_Img.Fill(DS, "Img") = 0 Then Return
            With DS.Tables("Img").Rows(0)
                If Not IsDBNull(!imagen) Then
                    Dim Img() As Byte = CType(.Item("imagen"), Byte())
                    Dim m As New MemoryStream(Img)
                    PictureBox.Image = Image.FromStream(m)
                Else
                    If Not File.Exists(.Item("ruta").ToString.Trim) Then
                        If Msg Then MsgBox("La ruta de la imagen no es válida", MsgBoxStyle.Information)
                        Return
                    End If
                    PictureBox.Image = Image.FromFile(.Item("ruta").ToString.Trim)
                End If
            End With
            If Ajustar Then
                Dim W, H As Int16
                W = PictureBox.Width
                H = PictureBox.Height
                PictureBox.SuspendLayout()
                Dim WI As Int16 = PictureBox.Image.Width
                Dim HI As Int16 = PictureBox.Image.Height
                Dim WT, HT As Int16
                Dim FW, FH As Decimal
                FW = W / WI : FH = H / HI
                If WI > W Or HI > H Then 'si excede
                    If FW < FH Then
                        WT = WI * FW
                        HT = HI * FW
                    Else
                        WT = WI * FH
                        HT = HI * FH
                    End If
                Else 'si no excede
                    If FW < FH Then
                        WT = WI * FW
                        HT = HI * FW
                    Else
                        WT = WI * FH
                        HT = HI * FH
                    End If
                End If
                Dim Inptr As IntPtr
                Dim Abort As Image.GetThumbnailImageAbort = Nothing
                PictureBox.Image = PictureBox.Image.GetThumbnailImage(WT, HT, Abort, Inptr)
                PictureBox.ResumeLayout()
            End If
        Catch
            If Msg Then
                MsgBox(Msg, MsgBoxStyle.Information)
            End If
        End Try
    End Sub

    ' Este método mandaba un null. Se ha corregido
    Public Sub Imagen(ByVal imagen As Object, ByRef PictureBox As PictureBox, Optional ByVal Msg As Boolean = True)
        If PictureBox Is Nothing Then Return

        Try
            ' Clear previous image safely (dispose to avoid GDI leaks)
            If PictureBox.Image IsNot Nothing Then
                PictureBox.Image.Dispose()
                PictureBox.Image = Nothing
            End If

            If imagen Is Nothing OrElse IsDBNull(imagen) Then
                Dim W_ph As Integer = If(PictureBox.Width > 0, PictureBox.Width, 100)
                Dim H_ph As Integer = If(PictureBox.Height > 0, PictureBox.Height, 100)
                Dim placeholder As New Bitmap(W_ph, H_ph)
                Using g As Graphics = Graphics.FromImage(placeholder)
                    g.Clear(Color.WhiteSmoke)
                    Using f As New Font("Arial", Math.Max(8, W_ph \ 10), FontStyle.Bold)
                        Dim sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                        g.DrawString("Sin Imagen", f, Brushes.Silver, New RectangleF(0, 0, W_ph, H_ph), sf)
                    End Using
                End Using
                PictureBox.Image = placeholder
                Return
            End If

            Dim ImgData As Byte() = TryCast(imagen, Byte())
            If ImgData Is Nothing Then
                If Msg Then MsgBox("Formato de imagen inválido", MsgBoxStyle.Information)
                Return
            End If

            Using m As New MemoryStream(ImgData)
                Dim loaded As Image = Image.FromStream(m)
                PictureBox.Image = New Bitmap(loaded) ' clone to detach from stream
            End Using

            Dim imgLocal As Image = PictureBox.Image
            If imgLocal IsNot Nothing AndAlso imgLocal.Width > 0 AndAlso imgLocal.Height > 0 Then
                PictureBox.SuspendLayout()
                Dim W As Integer = PictureBox.Width
                Dim H As Integer = PictureBox.Height
                Dim WI As Integer = imgLocal.Width
                Dim HI As Integer = imgLocal.Height
                Dim WT As Integer = WI
                Dim HT As Integer = HI
                Dim FW As Decimal = W / WI
                Dim FH As Decimal = H / HI

                If WI > W Or HI > H Then
                    If FW < FH Then
                        WT = CInt(WI * FW)
                        HT = CInt(HI * FW)
                    Else
                        WT = CInt(WI * FH)
                        HT = CInt(HI * FH)
                    End If
                End If

                Dim Abort As Image.GetThumbnailImageAbort = Nothing
                Dim thumb As Image = imgLocal.GetThumbnailImage(WT, HT, Abort, IntPtr.Zero)
                imgLocal.Dispose()
                PictureBox.Image = thumb
                PictureBox.ResumeLayout()
            End If

        Catch ex As Exception
            If Msg Then MsgBox("Error al cargar la imagen: " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub imprimeReporte(ByVal reporte As String, ByRef DS As System.Data.DataSet,
                              Optional ByVal opcion As String = "", Optional ByVal Folio As String = "", Optional ByVal Transaccion As String = "", Optional ByVal parametros(,) As Object = Nothing)
        Dim RD As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ruta As String = Application.StartupPath.Trim
        Dim impresora As String = Impresora_equipo("IM")
        Dim RutaReporte As String = ruta.Trim & "\" & reporte.Trim & ".rpt"
        RD = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not Help.configurar_reporte(RD, RutaReporte, DS) Then Exit Sub ', Dv, parametros, AceptarOrden, Formato_papel, reporte) Then Exit Sub
        Dim Vista_previa As Boolean = True
        If Vista_previa Then
            Dim rfrm As New FReporte(opcion, Folio, Transaccion)
            rfrm.CRV.ReportSource = RD
            ' Parametros
            If Not IsNothing(parametros) Then
                rfrm.CRV.ShowRefreshButton = False
            End If
            rfrm.Text &= " " & RutaReporte
            rfrm.ShowDialog()
        Else
            Dim PD As New System.Windows.Forms.PrintDialog
            Dim Doc As New System.Drawing.Printing.PrintDocument

            PD.Document = Doc
            PD.PrintToFile = False
            If impresora.Trim.Length > 0 Then
                Dim pSet As New PrinterSettings
                pSet.PrinterName = impresora
                RD.PrintToPrinter(pSet, New PageSettings, False)
            Else
                PD.AllowSomePages = True
                PD.PrinterSettings.Copies = 1 ' CopiasReporte
                If PD.ShowDialog() = DialogResult.OK Then
                    'establecer la impresora seleccionada
                    impresora = PD.PrinterSettings.PrinterName
                    RD.PrintOptions.PrinterName = PD.PrinterSettings.PrinterName
                    RD.PrintToPrinter(PD.PrinterSettings.Copies, PD.PrinterSettings.Collate, PD.PrinterSettings.FromPage, PD.PrinterSettings.ToPage)
                End If
            End If
        End If



    End Sub
    Public Function Impresora_equipo(ByVal impresora As String) As String '  ByVal Folio As String, ByVal Trans As String, ByVal Equipo As String, ByVal Estab As String) As String

        Dim ImpresoraEquipo As String = ""
        ' If Equipo.Trim.Length = 0 Then Return ""
        Dim Con As New SqlClient.SqlConnection
        'If Estab.Trim = "" Then Estab = "1" ' MG.EstabCode
        Try
            'Con.ConnectionString = Help.stringConexion ' MG.ScsBMS
            'Con.Open()
            'Dim SqlC As New SqlClient.SqlCommand("dbo.ImpresoraEquipo", Con)
            'SqlC.CommandType = CommandType.StoredProcedure
            'SqlC.Parameters.AddWithValue("@Folio", Folio)
            'SqlC.Parameters.AddWithValue("@Trans", Trans)
            'SqlC.Parameters.AddWithValue("@Equipo", Equipo)
            'SqlC.Parameters.AddWithValue("@Estab", Estab)
            'SqlC.Parameters.Add(New SqlClient.SqlParameter("@Impresora", SqlDbType.VarChar, 100, ParameterDirection.InputOutput, False, 0, 0, "", DataRowVersion.Current, ""))
            'SqlC.Parameters.Add(New SqlClient.SqlParameter("@Prefijo", SqlDbType.VarChar, 100, ParameterDirection.InputOutput, False, 0, 0, "", DataRowVersion.Current, ""))
            'SqlC.ExecuteNonQuery()
            Dim Impresora_ As String = "" ' = SqlC.Parameters("@Impresora").Value
            Dim Prefijo As String = "" ' SqlC.Parameters("@Prefijo").Value
            If impresora.Trim = "" AndAlso Prefijo.Trim = "" Then Return ""
            Dim ImpInst As String = ""
            For Each ImpInst In PrinterSettings.InstalledPrinters
                If ImpInst.Trim.ToLower = impresora.Trim.ToLower Then
                    ImpresoraEquipo = ImpInst
                    Exit For
                End If
            Next
            If ImpresoraEquipo.Trim <> "" Then Return ImpresoraEquipo
            If Prefijo.Trim <> "" Then
                For Each ImpInst In PrinterSettings.InstalledPrinters
                    If ImpInst.Trim.ToLower.StartsWith(Prefijo.Trim.ToLower) Then
                        ImpresoraEquipo = ImpInst
                        Exit For
                    End If
                Next
            End If
            Return ImpresoraEquipo
        Catch
            MsgBox(Err, MsgBoxStyle.Information)
            Return ""
        Finally
            If Con.State <> ConnectionState.Closed Then Con.Close()
        End Try
    End Function
    Private Function configurar_reporte(ByRef RD As CrystalDecisions.CrystalReports.Engine.ReportDocument _
        , ByVal RutaReporte As String, ByVal DS As DataSet) As Boolean
        ', ByVal DV As DataView, ByVal Parametros(,) As Object _
        ', ByVal AceptarOrden As Boolean, ByVal FormatoPapel As String, ByVal Reporte As String

        configurar_reporte = False
        Try
            RD.Load(RutaReporte, CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)
        Catch
            If Err.Description.ToLower.IndexOf("load report failed") > -1 Or Err.Description.ToLower.IndexOf("cargar el informe") > -1 Then
                MsgBox("El archivo de reporte " & RutaReporte & " no se encuentra" & vbCrLf & "No se puede imprimir", MsgBoxStyle.Exclamation)
                Return False
            Else
                MsgBox(Err.Description, MsgBoxStyle.Information) ' MG.Manejo_errores()
            End If
        End Try
        Try
            RD.SetDataSource(DS)
            Help.Reporte_ConfiguracionBD(RD)
            Dim i As Integer
            Dim j As Integer
            'If Not IsNothing(Parametros) Then
            '    Dim nparam As Integer
            '    Dim Enc As Boolean
            '    nparam = Parametros.Length / Parametros.Rank
            '    'Si viene un numero que no es para se hace le contador a pares
            '    'El numero de elementos en este array debe ser para porque son dos valores por parametro
            '    For i = 0 To nparam - 1 Step 1
            '        Enc = False
            '        For j = 0 To RD.DataDefinition.ParameterFields.Count - 1
            '            If Parametros(i, 0).trim.tolower = RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower Then
            '                Help.AsignarValoresParametros(RD, j, Parametros(i, 1))
            '                Enc = True
            '            End If
            '        Next
            '        If Not Enc Then ' And MG.ModoRevision Then
            '            MsgBox("El parámetro " & Parametros(i, 0).trim & ", no existe en el archivo " & Reporte & ".RPT", MsgBoxStyle.Information)
            '        End If
            '    Next
            'End If
            'Aplicar valores a parametros default
            For j = 0 To RD.DataDefinition.ParameterFields.Count - 1
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresa" Then Help.AsignarValoresParametros(RD, "empresa", "1") 'MG.Empresa)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresacalle" Then Help.AsignarValoresParametros(RD, "empresacalle", "Juventino Rosas") ' MG.EmpresaCalle)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresacodpostal" Then Help.AsignarValoresParametros(RD, "empresacodpostal", "80290") ' MG.EmpresaCodPostal)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresacolonia" Then Help.AsignarValoresParametros(RD, "empresacolonia", "Centro") ' MG.EmpresaColonia)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresapobmunedo" Then Help.AsignarValoresParametros(RD, "empresapobmunedo", "Culiacán, Sin.") 'MG.EmpresaPobmunedo)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresarfc" Then Help.AsignarValoresParametros(RD, "empresarfc", "RRR0542D45R2") 'MG.EmpresaRFC)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "empresadelegacion" Then Help.AsignarValoresParametros(RD, "empresadelegacion", "RYCSEM") ' MG.EmpresaDelegacion)
                If RD.DataDefinition.ParameterFields(j).Name.Trim.ToLower = "usuario" Then Help.AsignarValoresParametros(RD, "usuario", "1") 'MG.UserCode)
            Next
            'If RD.DataDefinition.Groups.Count > 0 Then AceptarOrden = False
            'If Not IsNothing(DV) AndAlso AceptarOrden Then
            '    Dim sort As String = ""
            '    Dim Orden As String = ""
            '    Dim CampoOrden As String = ""
            '    Dim tabla As String
            '    Dim poscoma As Integer
            '    j = 0
            '    tabla = DV.Table.TableName
            '    Orden = DV.Sort
            '    'Orden del reporte
            '    Dim bEncOrden As Boolean = False
            '    For k As Integer = 0 To RD.Database.Tables.Count - 1
            '        If RD.Database.Tables(k).Name.Trim.ToLower = tabla.Trim.ToLower Then
            '            bEncOrden = True
            '            Exit For
            '        End If
            '    Next
            '    If bEncOrden Then
            '        bEncOrden = False
            '        If Not String.IsNullOrEmpty(Orden) Then CampoOrden = Orden.Replace("[", "").Replace("]", "").Split(" ")(0)
            '        For k As Integer = 0 To RD.Database.Tables(tabla).Fields.Count - 1
            '            If RD.Database.Tables(tabla).Fields(k).Name.Trim.ToLower = CampoOrden.Trim.ToLower Then
            '                bEncOrden = True
            '                Exit For
            '            End If
            '        Next
            '    End If
            '    If Not bEncOrden Then
            '        tabla = Nothing
            '        Orden = Nothing
            '    End If
            '    If Not IsNothing(Orden) And Not IsNothing(tabla) Then
            '        While 1
            '            poscoma = Orden.IndexOf(",")
            '            If poscoma >= 0 Then
            '                sort = Orden.Substring(0, poscoma)
            '                Orden = Orden.Substring(poscoma + 1)
            '            Else
            '                sort = Orden
            '                Orden = ""
            '            End If
            '            If sort.Trim.Length > 0 Then
            '                Dim ord As String = ""
            '                i = InStr(sort, "]", CompareMethod.Text)
            '                If i > 0 And sort.Length > 0 Then
            '                    ord = sort.Substring(i, Len(sort) - i).Trim
            '                    sort = sort.Substring(1, i - 2)
            '                End If
            '                sort = sort.Trim
            '                If sort.Length > 0 Then
            '                    Dim fieldDef As CrystalDecisions.CrystalReports.Engine.FieldDefinition
            '                    fieldDef = RD.Database.Tables(tabla).Fields(sort)



            '                    If j <= RD.DataDefinition.SortFields.Count - 1 Then
            '                        RD.DataDefinition.SortFields.Item(j).Field = fieldDef
            '                        If ord.Trim = "DESC" Then
            '                            RD.DataDefinition.SortFields.Item(j).SortDirection = CrystalDecisions.[Shared].SortDirection.DescendingOrder
            '                        Else
            '                            RD.DataDefinition.SortFields.Item(j).SortDirection = CrystalDecisions.[Shared].SortDirection.AscendingOrder
            '                        End If
            '                    End If
            '                End If
            '            End If
            '            If Orden.Trim.Length = 0 Then Exit While
            '            If j + 1 > RD.DataDefinition.SortFields.Count - 1 Then Exit While
            '            j += 1
            '        End While
            '    End If
            'End If
            Dim Vista_previa As Boolean = True
            ' formulario de Reporte
            Dim Idx As Integer = 1 ' MG.IndiceTamañoPapel(FormatoPapel)
            If Idx <> -1 Then RD.PrintOptions.PaperSize = Idx
            If Not Vista_previa Then
                'Verificar que se hayan proporcionado valores para todos los parametros para que no falle
                For j = 0 To RD.DataDefinition.ParameterFields.Count - 1
                    If RD.DataDefinition.ParameterFields(j).HasCurrentValue = False _
                    And RD.DataDefinition.ParameterFields(j).IsLinked = False _
                    And RD.DataDefinition.ParameterFields(j).ParameterType = CrystalDecisions.Shared.ParameterType.ReportParameter Then
                        Dim Val As Object = ""
                        Select Case RD.DataDefinition.ParameterFields(j).ParameterValueKind
                            Case CrystalDecisions.Shared.ParameterValueKind.DateParameter, CrystalDecisions.Shared.ParameterValueKind.DateTimeParameter
                                Val = "01/01/2000 00:00"
                            Case CrystalDecisions.Shared.ParameterValueKind.TimeParameter
                                Val = "12:00"
                            Case CrystalDecisions.Shared.ParameterValueKind.BooleanParameter, CrystalDecisions.Shared.ParameterValueKind.NumberParameter, CrystalDecisions.Shared.ParameterValueKind.CurrencyParameter
                                Val = 0
                        End Select
                        Val = InputBox("Proporcione un valor para " & RD.DataDefinition.ParameterFields(j).Name, "Asignar valor", Val)
                        Select Case RD.DataDefinition.ParameterFields(j).ParameterValueKind
                            Case CrystalDecisions.Shared.ParameterValueKind.DateParameter, CrystalDecisions.Shared.ParameterValueKind.DateTimeParameter, CrystalDecisions.Shared.ParameterValueKind.TimeParameter
                                If IsDate(Val) = False Then Val = "01/01/2000 00:00"
                            Case CrystalDecisions.Shared.ParameterValueKind.BooleanParameter, CrystalDecisions.Shared.ParameterValueKind.NumberParameter, CrystalDecisions.Shared.ParameterValueKind.CurrencyParameter
                                If IsNumeric(Val) = False Then Val = 0
                        End Select
                        Help.AsignarValoresParametros(RD, j, Val)
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function
    Public Sub AsignarValoresParametros(ByRef RD As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal Parametro As String, ByVal Valor As Object)
        Dim ParamValues As New CrystalDecisions.Shared.ParameterValues
        Dim ParamValue As New CrystalDecisions.Shared.ParameterDiscreteValue
        ParamValue.Value = Valor
        For i As Integer = 0 To RD.DataDefinition.ParameterFields.Count - 1
            If RD.DataDefinition.ParameterFields(i).Name.Trim.ToLower <> Parametro.Trim.ToLower Then Continue For
            RD.DataDefinition.ParameterFields(i).CurrentValues.AddValue(Valor)
            ParamValues.Add(ParamValue)
            RD.DataDefinition.ParameterFields(i).ApplyCurrentValues(ParamValues)
        Next
    End Sub
    Public Sub Reporte_ConfiguracionBD(ByVal Rd As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim i As Integer = 0
        Dim DS As String
        While Rd.DataSourceConnections.Count > i
            DS = CN.servidor.Trim '"RYCSEM" ' CN.servidor (database)CnnDataSource
            If CN.puerto.Trim <> "1433" Then DS &= "," & CN.puerto.Trim
            Rd.DataSourceConnections(i).SetConnection(DS, CN.baseDatos, CN.usuario.Trim, CN.contrasena)
            i += 1
        End While
        Rd.SetDatabaseLogon(CN.usuario, CN.contrasena)
        If Not Rd.IsSubreport Then
            For i = 0 To Rd.Subreports.Count - 1
                Help.Reporte_ConfiguracionBD(Rd.Subreports(i))
            Next
        End If
    End Sub
    'Public Function Impresora_equipo(ByVal Folio As String, ByVal Trans As String, ByVal Equipo As String, ByVal Estab As String) As String
    '    Dim ImpresoraEquipo As String = ""
    '    If Equipo.Trim.Length = 0 Then Return ""
    '    Dim Con As New SqlClient.SqlConnection
    '    If Estab.Trim = "" Then Estab = "1" ' MG.EstabCode
    '    Try
    '        Con.ConnectionString = Help.stringConexion ' MG.ScsBMS
    '        Con.Open()
    '        Dim SqlC As New SqlClient.SqlCommand("dbo.ImpresoraEquipo", Con)
    '        SqlC.CommandType = CommandType.StoredProcedure
    '        SqlC.Parameters.AddWithValue("@Folio", Folio)
    '        SqlC.Parameters.AddWithValue("@Trans", Trans)
    '        SqlC.Parameters.AddWithValue("@Equipo", Equipo)
    '        SqlC.Parameters.AddWithValue("@Estab", Estab)
    '        SqlC.Parameters.Add(New SqlClient.SqlParameter("@Impresora", SqlDbType.VarChar, 100, ParameterDirection.InputOutput, False, 0, 0, "", DataRowVersion.Current, ""))
    '        SqlC.Parameters.Add(New SqlClient.SqlParameter("@Prefijo", SqlDbType.VarChar, 100, ParameterDirection.InputOutput, False, 0, 0, "", DataRowVersion.Current, ""))
    '        SqlC.ExecuteNonQuery()
    '        Dim Impresora As String = SqlC.Parameters("@Impresora").Value
    '        Dim Prefijo As String = SqlC.Parameters("@Prefijo").Value
    '        If Impresora.Trim = "" AndAlso Prefijo.Trim = "" Then Return ""
    '        Dim ImpInst As String = ""
    '        For Each ImpInst In PrinterSettings.InstalledPrinters
    '            If ImpInst.Trim.ToLower = Impresora.Trim.ToLower Then
    '                ImpresoraEquipo = ImpInst
    '                Exit For
    '            End If
    '        Next
    '        If ImpresoraEquipo.Trim <> "" Then Return ImpresoraEquipo
    '        If Prefijo.Trim <> "" Then
    '            For Each ImpInst In PrinterSettings.InstalledPrinters
    '                If ImpInst.Trim.ToLower.StartsWith(Prefijo.Trim.ToLower) Then
    '                    ImpresoraEquipo = ImpInst
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '        Return ImpresoraEquipo
    '    Catch
    '        MsgBox(Err, MsgBoxStyle.Information) ' MG.Manejo_errores(Err)
    '        Return ""
    '    Finally
    '        If Con.State <> ConnectionState.Closed Then Con.Close()
    '    End Try
    'End Function
    Public Sub ImprimirPuertoCom(ByVal Puerto As String, ByVal Cadena As String)
        Try
            Dim Com As String = "Com" & Puerto
            Dim Port As New Ports.SerialPort(Com, 9600, Ports.Parity.None, 8, Ports.StopBits.One)
            Port.Open()
            Port.Write(StringToByte(Cadena), 0, Cadena.Length)
            Port.Close()
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function CreateFile(ByVal lpFileName As String, ByVal dwDesiredAccess As System.UInt32,
        ByVal dwShareMode As System.UInt32, ByVal lpSecurityAttributes As IntPtr,
        ByVal dwCreationDisposition As System.UInt32, ByVal dwFlagsAndAttributes As System.UInt32,
        ByVal hTemplateFile As IntPtr) As SafeFileHandle
    End Function

    'Declare Auto Function CreateFile Lib "kernel32" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Int16, ByVal lpSecurityAttributes As Short, ByVal dwCreationDisposition As Int16, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Int16) As IntPtr
    Const Create_Always As Integer = 2
    Const File_Flag_Overlapped As Integer = &H40000000
    Const Generic_write As UInteger = &H40000000
    Const File_attribute_normal As Integer = &H80
    Const OPEN_EXISTING As UInteger = 3
    Public Sub ImprimirPuerto(ByVal Cadena As String) 'D -> directo
        Try
            'Dim Hn As IntPtr
            Dim Handler As Microsoft.Win32.SafeHandles.SafeFileHandle
            Handler = CreateFile("lpt1:", Generic_write, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero)
            'Hn = CreateFile("lpt1:", Generic_write, 0, Nothing, Create_Always, File_attribute_normal Or File_Flag_Overlapped, Nothing)
            Dim Fs1 As New FileStream(Handler, FileAccess.Write, 1024, False)
            'Dim Fs As New System.IO.FileStream(Hn, IO.FileAccess.Write, False, 1024, True)

            Fs1.Write(StringToByte(Cadena), 0, Cadena.Length)
            Fs1.Flush()
            Fs1.Dispose()
            Fs1.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Sub Imprimir_MSDOS(ByVal Cadena As String)
        Dim Fn As String
        Dim tk As String
        tk = Now.Ticks.ToString
        tk = tk.Substring(tk.Length - 8)
        Fn = "c:\bms\" & tk & ".txt"
        Dim Fs As New FileStream(Fn, FileMode.CreateNew)
        Dim i As Integer
        For i = 0 To Cadena.Length - 1
            Fs.WriteByte(Asc(Cadena.Substring(i, 1)))
        Next
        Fs.Flush()
        Fs.Close()
        Dim Comando As String
        Comando = "print " & Fn
        Shell(Comando, AppWinStyle.Hide, True)
        System.IO.File.Delete(Fn)
    End Sub
    Function StringToByte(ByVal Cadena As String) As Byte()
        'convertir del Array a String
        Dim AE As New System.Text.UTF8Encoding
        StringToByte = AE.GetBytes(Cadena)
    End Function
End Module
