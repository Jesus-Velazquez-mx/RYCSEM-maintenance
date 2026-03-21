Module CN
    'Cadena de Conexion
    Public servidor, usuario, baseDatos, puerto, contrasena As String
    Function cadenConexion(Optional ByVal ConnPath As String = "connection.bin", Optional ByRef Dt As DS_FIniC.conexionDataTable = Nothing,
    Optional ByRef CnnStr As String = Nothing) As Boolean
        ConnPath = IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "connection.bin")
        If CN.LeerConexion(ConnPath, Dt, CnnStr) = False Then Return False
        Return True
    End Function
    Function LeerConexion(Optional ByVal ConnPath As String = "connection.bin",
                          Optional ByRef Dt As DS_FIniC.conexionDataTable = Nothing,
                          Optional ByRef CnnStr As String = "") As Boolean
        ''Inicializar
        'cab = Space(16)
        'cfl = Space(16)
        Dim fs As System.IO.FileStream
        Dim Sr As System.IO.StreamReader = Nothing
        Try
            fs = New System.IO.FileStream(ConnPath, IO.FileMode.Open, IO.FileAccess.Read)
        Catch
            MsgBox("No se pudo abrir el archivo " & ConnPath & vbCrLf & "", MsgBoxStyle.Exclamation)
            Return False
        End Try
        Try
            Sr = New System.IO.StreamReader(fs)
            Sr.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            Dim Linea As String = Sr.ReadLine
            Dim cnt As Integer = 1
            CN.LineaConexion(Linea, Dt, cnt)
            'MI.LineaCAB(Linea, CAB, CFL)
            'If IsNothing(Dt) And nEmpresa = 0 Then Return True
            'If IsNothing(Dt) And nEmpresa > 0 Then
            'Dt = New DS_FIni.empresasDataTable
            'End If
            'Dt.Clear()

            'Do While True
            'Linea = Sr.ReadLine
            'If CN.LineaConexion(Linea, Dt, cnt) Then
            '    cnt += 1
            'Else
            '    Exit Do
            'End If
            'Loop
            ''Rellenar las cadenas de claves a 16 caracteres para que no marque error 
            ''mas delante porque asume que tiene al menos 16 caracteres
            'CAB = CAB.PadRight(16)
            'CFL = CFL.PadRight(16)
            'Dim Identificador As String = MI.CadenaCAB()
            'MI.LicBMSValida(Dt, Identificador)
            'If nEmpresa > 0 And Dt.Count > 0 Then
            'If nEmpresa > Dt.Count Then
            '    MsgBox("Se especifica un número de empresa mayor a la lista", MsgBoxStyle.Exclamation, MI.vBMS)
            '    Return False
            'End If
            Dim Ind As Integer = 0 ' nEmpresa - 1
            CnnStr = CN.CnnX(Dt(Ind))
            'If Dt(Ind).licencia = False Then
            '    MsgBox("Esta empresa no tiene licencia para usar BMS" & vbCrLf & Dt(Ind).empresa, MsgBoxStyle.Exclamation, MI.vBMS)
            '    Return False
            'End If
            CnnStr = CN.CnnX(Dt(Ind))
            If CN.probarConexion(CnnStr, False, False) = False Then
                CnnStr = CN.CnnX(Dt(Ind), False)
                If CN.probarConexion(CnnStr, False) = False Then
                    Return False
                End If
            End If
            'End If
            Return True
        Catch
            MsgBox(Err.Description)
            Return False
        Finally
            If Not IsNothing(Sr) Then Sr.Close()
            If Not IsNothing(fs) Then fs.Close()
        End Try
    End Function


    'Sub EscribirConexion(ByVal CAB As String, ByVal CFL As String, ByVal ConnPath As String, ByRef Dt As DS_FIni.empresasDataTable)
    '    Dim fs As System.IO.FileStream = New System.IO.FileStream(ConnPath, IO.FileMode.Truncate)
    '    Dim Sw As New IO.StreamWriter(fs)
    '    Sw.Write(CAB & ",")
    '    Sw.Write(CFL & vbCrLf)
    '    Dim i As Integer
    '    For i = 0 To Dt.Count - 1
    '        MI.WriteElemento(Sw, Dt(i).empresa)
    '        MI.WriteElemento(Sw, Dt(i).abreviatura)
    '        MI.WriteElemento(Sw, Dt(i).data_source)
    '        MI.WriteElemento(Sw, Dt(i).usuario)
    '        MI.WriteElemento(Sw, MI.EncriptarIni(Dt(i).contraseña))
    '        MI.WriteElemento(Sw, Dt(i).catalogo_inicial)
    '        MI.WriteElemento(Sw, Dt(i).persist_security_info)
    '        MI.WriteElemento(Sw, Dt(i).packet_size)
    '        MI.WriteElemento(Sw, Dt(i).smtp)
    '        MI.WriteElemento(Sw, Dt(i).timeout)
    '        MI.WriteElemento(Sw, IIf(Dt(i).windowsSecurity, 1, 0))
    '        MI.WriteElemento(Sw, Dt(i).usoBMS)
    '        MI.WriteElemento(Sw, Dt(i).puerto, False)
    '        Sw.Write(vbCrLf)
    '    Next
    '    Sw.Flush()
    '    Sw.Close()
    '    fs.Close()
    'End Sub


    Sub EscribirConexion(ByVal ConnPath As String, ByRef Dt As DS_FIniC.conexionDataTable)
        Dim fs As System.IO.FileStream = New System.IO.FileStream(ConnPath, IO.FileMode.Truncate)
        Dim Sw As New IO.StreamWriter(fs)
        'Sw.Write(CAB & ",")
        'Sw.Write(CFL & vbCrLf)
        Dim i As Integer
        For i = 0 To Dt.Count - 1
            CN.WriteElemento(Sw, Dt(i).servidor)
            CN.WriteElemento(Sw, CN.encriptaPassword(Dt(i).contrasena))
            CN.WriteElemento(Sw, Dt(i).usuario)
            CN.WriteElemento(Sw, Dt(i).baseDatos)
            CN.WriteElemento(Sw, Dt(i).persist_security_info)
            CN.WriteElemento(Sw, Dt(i).packet_size)
            CN.WriteElemento(Sw, Dt(i).smtp)
            CN.WriteElemento(Sw, Dt(i).timeout)
            CN.WriteElemento(Sw, IIf(Dt(i).windowsSecurity, 1, 0))
            'CN.WriteElemento(Sw, Dt(i).usoBMS)
            CN.WriteElemento(Sw, Dt(i).puerto, False)
            Sw.Write(vbCrLf)
        Next
        Sw.Flush()
        Sw.Close()
        fs.Close()
    End Sub

    'Funcion para realizar encriptacion de texto
    Public Function encriptaPassword(ByVal Pass As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Clave = "%ü&/@#$A"
        Pass2 = ""
        For i = 1 To Len(Pass)
            CAR = Mid(Pass, i, 1)
            Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
        Next i
        Pass2 = System.Convert.ToBase64String(CN.StringToByte(Pass2))
        Return Pass2
    End Function
    'Function para realizar la desencriptacion de cadena encriptadas con la funcion 'Encriptar'
    Function DesEncriptarContra(ByVal Pass As String) As String
        Try
            Pass = CN.ByteToString(System.Convert.FromBase64String(Pass))
        Catch
            Err.Clear()
            Return Pass
        End Try
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Dim j As Integer
        Clave = "%ü&/@#$A"
        Pass2 = ""
        j = 1
        For i = 1 To Len(Pass) Step 2
            CAR = Mid(Pass, i, 2)
            Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        Return Pass2
    End Function
    Function StringToByte(ByVal Cadena As String) As Byte()
        'convertir del Array a String
        Dim AE As New System.Text.UTF8Encoding
        StringToByte = AE.GetBytes(Cadena)
    End Function
    Sub WriteElemento(ByRef Sw As IO.StreamWriter, ByVal Cadena As String, Optional ByVal Coma As Boolean = True)
        Dim cFinal As String
        If Coma Then
            cFinal = ","
        Else
            cFinal = ""
        End If
        Sw.Write(Cadena.Replace(",", "") & cFinal)
    End Sub

    Function LineaConexion(ByVal Linea As String,
                           ByRef Dt As DS_FIniC.conexionDataTable,
                           ByVal Id As Integer) As Boolean
        If IsNothing(Linea) Then Return False
        If Linea.Length = 0 Then Return False
        Dim Elementos() As String = Linea.Split(",")
        If Elementos.Length < 9 Then
            MsgBox("Faltan algunos datos para configurar la cadena de conexión", MsgBoxStyle.Information, "RYCSEM")
            Return False
        End If
        Dim Drow As DS_FIniC.conexionRow
        Drow = Dt.NewRow
        Drow.id = Id
        Drow.servidor = Elementos(0)
        servidor = Elementos(0)
        Drow.contrasena = Elementos(1)
        Drow.usuario = Elementos(2)
        usuario = Elementos(2)
        Drow.baseDatos = Elementos(3)
        baseDatos = Elementos(3)
        Drow.persist_security_info = Elementos(4)
        Drow.packet_size = Elementos(5)
        Drow.smtp = Elementos(6)
        Drow.timeout = Elementos(7)
        '  Drow.puerto = Elementos(8)
        Drow.windowsSecurity = Val(Elementos(8))
        Drow.puerto = "1433"
        If Elementos.Length > 9 Then Drow.puerto = Elementos(9)
        puerto = Drow.puerto
        contrasena = Drow.contrasena
        Dt.Rows.Add(Drow)
        Return True
    End Function
    Function leerConexion(ByRef CAB As String, ByRef CFL As String, Optional ByVal ConnPath As String = "connection.bin",
  Optional ByRef Dt As DS_FIniC.conexionDataTable = Nothing, Optional ByRef CnnStr As String = "",
  Optional ByVal nEmpresa As Integer = 0) As Boolean
        ' Inicializar
        CAB = Space(16)
        CFL = Space(16)
        Dim fs As System.IO.FileStream
        Dim Sr As System.IO.StreamReader = Nothing
        Try
            fs = New System.IO.FileStream(ConnPath, IO.FileMode.Open, IO.FileAccess.Read)
        Catch
            MsgBox("No se pudo abrir el archivo " & ConnPath & vbCrLf & "", MsgBoxStyle.Exclamation)
            Return False
        End Try
        Try
            Sr = New System.IO.StreamReader(fs)
            Sr.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            Dim Linea As String = Sr.ReadLine
            'MI.LineaCAB(Linea, CAB, CFL)
            'If IsNothing(Dt) And nEmpresa = 0 Then Return True
            'If IsNothing(Dt) And nEmpresa > 0 Then
            '    Dt = New DS_FIniC.conexionDataTable
            'End If
            'Dt.Clear()
            Dim cnt As Integer = 1
            Do While True
                Linea = Sr.ReadLine
                If CN.LineaConexion(Linea, Dt, cnt) Then
                    cnt += 1
                Else
                    Exit Do
                End If
            Loop
            ''Rellenar las cadenas de claves a 16 caracteres para que no marque error 
            ''mas delante porque asume que tiene al menos 16 caracteres
            'CAB = CAB.PadRight(16)
            'CFL = CFL.PadRight(16)
            'Dim Identificador As String = MI.CadenaCAB()
            'MI.LicBMSValida(Dt, Identificador)
            'If nEmpresa > 0 And Dt.Count > 0 Then
            'If nEmpresa > Dt.Count Then
            '    MsgBox("Se especifica un número de empresa mayor a la lista", MsgBoxStyle.Exclamation, MI.vBMS)
            '    Return False
            'End If
            Dim Ind As Integer = 0 'nEmpresa - 1
            CnnStr = CN.CnnX(Dt(Ind))
            'If Dt(Ind).licencia = False Then
            '    MsgBox("Esta empresa no tiene licencia para usar BMS" & vbCrLf & Dt(Ind).empresa, MsgBoxStyle.Exclamation, MI.vBMS)
            '    Return False
            'End If
            CnnStr = CN.CnnX(Dt(Ind))
            If CN.probarConexion(CnnStr, False, False) = False Then
                CnnStr = CN.CnnX(Dt(Ind), False)
                If CN.probarConexion(CnnStr, False) = False Then
                    Return False
                End If
            End If
            'End If
            Return True
        Catch
            MsgBox(Err.Description)
            Return False
        Finally
            If Not IsNothing(Sr) Then Sr.Close()
            If Not IsNothing(fs) Then fs.Close()
        End Try
    End Function
    Function CnnX(ByVal Drow As DS_FIniC.conexionRow, Optional ByVal Encriptado As Boolean = True) As String
        With Drow

            CnnX = "current language = spanish; data source=" & .servidor.Trim & "," & .puerto.Trim _
                & "; initial catalog=" & .baseDatos.Trim _
                & "; Persist Security Info=" & .persist_security_info.Trim _
                & "; packet size=" & .packet_size _
                & "; timeout=" & .timeout
            If .windowsSecurity Then
                CnnX &= "; Integrated Security = SSPI"
            Else
                If Encriptado Then
                    Dim PassWowdE As String = .contrasena
                    PassWowdE = CN.DesEncriptarContra(PassWowdE)
                    CnnX &= "; user id=" & .usuario _
                    & "; password=" & PassWowdE
                Else
                    CnnX &= "; user id=" & .usuario _
                   & "; password=" & .contrasena
                End If
            End If
        End With
    End Function

    Function probarConexion(ByVal CnnStr As String, Optional ByVal MsgExito As Boolean = True, Optional ByVal MsgError As Boolean = True) As Boolean
        Dim Cnn As New SqlClient.SqlConnection
        Cnn.ConnectionString = CnnStr
        Try
            Cnn.Open()
        Catch
            If MsgError Then MsgBox("Error al tratar de establecer la conexion", MsgBoxStyle.Critical)
            Return False
        End Try
        If Cnn.State = ConnectionState.Open Then
            Cnn.Close()
            If MsgExito Then MsgBox("La conexion se estableció correctamente", MsgBoxStyle.Information)
            Return True
        End If
        Return True
    End Function
    Function ByteToString(ByVal ByteArr As Byte()) As String
        'convertir del Array a String
        Dim AE As New System.Text.UTF8Encoding
        ByteToString = AE.GetString(ByteArr)
    End Function

End Module
