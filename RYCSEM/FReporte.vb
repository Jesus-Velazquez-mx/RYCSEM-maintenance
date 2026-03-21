Imports CrystalDecisions.CrystalReports.Engine  'Vista previa de reportes BM Systems
Imports CrystalDecisions.Shared
Public Class FReporte
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Opcion As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Me.OpcionBMS = Opcion
    End Sub

    Public Sub New(ByVal Opcion As String, ByVal Folio As String, ByVal Trans As String)
        Me.New(Opcion)
        Me.FolioDoc = Folio
        Me.TransDoc = Trans
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEmail As System.Windows.Forms.ToolStripButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents sdaUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents btnPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcelDatos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRtf As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FReporte))
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPDF = New System.Windows.Forms.ToolStripButton()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnExcelDatos = New System.Windows.Forms.ToolStripButton()
        Me.btnWord = New System.Windows.Forms.ToolStripButton()
        Me.btnRtf = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEmail = New System.Windows.Forms.ToolStripButton()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sdaUsuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 25)
        Me.CRV.Name = "CRV"
        Me.CRV.SelectionFormula = ""
        Me.CRV.ShowCloseButton = False
        Me.CRV.Size = New System.Drawing.Size(792, 548)
        Me.CRV.TabIndex = 1
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CRV.ViewTimeSelectionFormula = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPDF, Me.btnExcel, Me.btnExcelDatos, Me.btnWord, Me.btnRtf, Me.ToolStripSeparator1, Me.btnEmail})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPDF
        '
        Me.btnPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(23, 22)
        Me.btnPDF.Text = "Exportar PDF"
        '
        'btnExcel
        '
        Me.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(23, 22)
        Me.btnExcel.Text = "Exportar a Excel"
        '
        'btnExcelDatos
        '
        Me.btnExcelDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcelDatos.Image = CType(resources.GetObject("btnExcelDatos.Image"), System.Drawing.Image)
        Me.btnExcelDatos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcelDatos.Name = "btnExcelDatos"
        Me.btnExcelDatos.Size = New System.Drawing.Size(23, 22)
        Me.btnExcelDatos.Text = "Exportar solo datos a Excel"
        '
        'btnWord
        '
        Me.btnWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnWord.Image = CType(resources.GetObject("btnWord.Image"), System.Drawing.Image)
        Me.btnWord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(23, 22)
        Me.btnWord.Text = "Exportar a Word"
        '
        'btnRtf
        '
        Me.btnRtf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRtf.Image = CType(resources.GetObject("btnRtf.Image"), System.Drawing.Image)
        Me.btnRtf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRtf.Name = "btnRtf"
        Me.btnRtf.Size = New System.Drawing.Size(23, 22)
        Me.btnRtf.Text = "Exportar Texto Enriquecido"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEmail
        '
        Me.btnEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(23, 22)
        Me.btnEmail.Text = "Enviar Email"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "select usuario, e_mail from usuarios where usuario = @Usuario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.[Char], 5, "usuario")})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=LUNAPOON;Initial Catalog=RYCSEM;Persist Security Info=True;User ID=sa;Password=luna"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sdaUsuarios
        '
        Me.sdaUsuarios.SelectCommand = Me.SqlSelectCommand1
        Me.sdaUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("usuario", "usuario"), New System.Data.Common.DataColumnMapping("e_mail", "e_mail")})})
        '
        'FReporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RYCSEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Rd As ReportDocument
    Dim Archivo As String
    Dim OpcionBMS As String
    Dim FolioDoc As String = "", TransDoc As String = ""
    Dim Email As String = ""


    Private Function ExportarPDF() As Boolean
        Try
            Rd = Me.CRV.ReportSource
            Dim ArchAdjunto As String = System.IO.Path.GetTempFileName
            ArchAdjunto = ArchAdjunto.Replace("tmp", "pdf")
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = ArchAdjunto
            CrExportOptions = Rd.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            Rd.Export()
            Me.Archivo = ArchAdjunto
            Return True
        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.Information)
        End Try

    End Function

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        ''If Not Me.ExportarPDF Then Exit Sub
        ''Dim FMail As New Fcorreo
        ''FMail.ArchivoAdjunto = Me.Archivo
        ''FMail.TituloyFiltro = Me.Rd.SummaryInfo.ReportTitle
        ''FMail.txtPara.Text = Me.Email
        ''FMail.ShowDialog()
    End Sub

    Private Sub Reporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''If Not MG.PrintExport(Me.OpcionBMS, "E", False) Then Me.CRV.ShowExportButton = False
        If Not Help.inicializa() Then Me.Close()
        Me.SqlConnection1.ConnectionString = Help.stringConexion
        Me.ConfigurarExportar()
        ''If Me.FolioDoc.Trim <> "" Then
        ''    Me.Email = MG.Dato("select dbo.DestinatarioRpt('" & Me.FolioDoc & "','" & Me.TransDoc & "')")
        ''End If
    End Sub

    Private Sub ConfigurarExportar()
        Me.btnPDF.Visible = True
        Me.btnExcel.Visible = True
        Me.btnExcelDatos.Visible = False
        Me.btnWord.Visible = False
        Me.btnRtf.Visible = False
        Me.ToolStripSeparator1.Visible = False
        ''Try
        ''    Dim sda As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand())
        ''    sda.SelectCommand.Connection = New SqlClient.SqlConnection(Help.stringConexion)
        ''    sda.SelectCommand.CommandText = "select * from opciones_usuario where usuario = '" & MG.UserCode & "' and opcion = '" & Me.OpcionBMS & "'"
        ''    Dim dt As New DataTable
        ''    If sda.Fill(dt) = 0 Then Return
        ''    With dt.Rows(0)
        ''        If .Item("exportar_pdf") AndAlso .Item("exportar_excel") AndAlso .Item("exportar_datos_excel") AndAlso .Item("exportar_word") AndAlso .Item("exportar_texto_enriquecido") Then Return
        ''        Me.CRV.ShowExportButton = False
        ''        Me.ToolStripSeparator1.Visible = True
        ''        Me.btnPDF.Visible = .Item("exportar_pdf")
        ''        Me.btnExcel.Visible = .Item("exportar_excel")
        ''        Me.btnExcelDatos.Visible = .Item("exportar_datos_excel")
        ''        Me.btnWord.Visible = .Item("exportar_word")
        ''        Me.btnRtf.Visible = .Item("exportar_texto_enriquecido")
        ''    End With
        ''Catch
        ''    MG.Manejo_errores()
        ''End Try
    End Sub


    Private Sub Exportar(ByVal Formato As ExportFormatType)
        Try
            Rd = Me.CRV.ReportSource
            Dim Filtro As String = ""
            Dim CrFormatTypeOptions As Object
            Select Case Formato
                Case ExportFormatType.PortableDocFormat
                    Filtro = "PDF|*.pdf"
                    CrFormatTypeOptions = New PdfRtfWordFormatOptions
                Case ExportFormatType.Excel
                    Filtro = "Micorsoft Excel|*.xls"
                    CrFormatTypeOptions = New ExcelFormatOptions
                Case ExportFormatType.ExcelRecord
                    Filtro = "Solo datos de Micorsoft Excel|*.xls"
                    CrFormatTypeOptions = New ExcelFormatOptions
                Case ExportFormatType.WordForWindows
                    Filtro = "Microsoft Word|*.doc"
                    CrFormatTypeOptions = New PdfRtfWordFormatOptions
                Case ExportFormatType.RichText
                    Filtro = "Formato de texto enriquecido|.rtf"
                    CrFormatTypeOptions = New PdfRtfWordFormatOptions
            End Select
            Dim Fsd As New SaveFileDialog
            Fsd.Filter = Filtro
            Fsd.ShowDialog()
            Dim Archivo As String = Fsd.FileName
            If Archivo.Trim = "" Then Return
            Fsd.Dispose()
            If IO.File.Exists(Archivo) Then IO.File.Delete(Archivo)

            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            CrDiskFileDestinationOptions.DiskFileName = Archivo
            CrExportOptions = Rd.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = Formato
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            Rd.Export()
            MsgBox("La información se exportó correctamente", MsgBoxStyle.Information)
        Catch err As Exception
            MsgBox(err.Message, MsgBoxStyle.Information) 'MG.Manejo_errores()
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Me.Exportar(ExportFormatType.Excel)
    End Sub

    Private Sub btnExcelDatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcelDatos.Click
        Me.Exportar(ExportFormatType.ExcelRecord)
    End Sub

    Private Sub btnPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        Me.Exportar(ExportFormatType.PortableDocFormat)
    End Sub

    Private Sub btnRtf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRtf.Click
        Me.Exportar(ExportFormatType.RichText)
    End Sub

    Private Sub btnWord_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWord.Click
        Me.Exportar(ExportFormatType.WordForWindows)
    End Sub
End Class
