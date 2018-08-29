Imports System.Configuration
Imports System.IO
Public Class frmComprobante

    Dim PATH_certificado As String = ConfigurationManager.AppSettings("path_certificado").ToString
    Dim pwdCertificado As String = ConfigurationManager.AppSettings("key1pass").ToString

    'Private _documento As DocumentoElectronico
    Private ReadOnly _documento As DocumentoElectronico
    '    Get
    '        Return _documento
    '    End Get
    'End Property
    Private Sub CargarDatos()
        LoadTipoDocumento()
        LoadTipoOperacion()
        LoadMoneda()
        LoadDocumentoAnticipo()
        LoadTipoDocContribuyente()
    End Sub

    Private Sub LoadTipoOperacion()
        Dim TipoOperacionNE As New TipoOperacionesNE
        'Dim dt As New DataTable
        TipoOperacionBindingSource.DataSource = TipoOperacionNE.listarTipoOperacionesLisNoArg
        'cboTipoOperacion.DataSource = dt
        'cboTipoOperacion.ValueMember = dt.Columns(1).ToString
        'cboTipoOperacion.DisplayMember = dt.Columns(3).ToString
    End Sub

    Private Sub LoadDocumentoAnticipo()
        Dim TipoDocumentoAnticipoNE As New TipoDocumentoAnticiposNE
        ' Dim dt As New DataTable
        DocumentoAnticipoBindingSource.DataSource = TipoDocumentoAnticipoNE.listarTipoDocumentoAnticiposLisNoArg
        'cboDocumentoAnticipo.DataSource = dt
        'cboDocumentoAnticipo.ValueMember = dt.Columns(1).ToString
        'cboDocumentoAnticipo.DisplayMember = dt.Columns(3).ToString
    End Sub
    Private Sub LoadTipoDocContribuyente()

        Dim tipoDocumentoContribuyenteNE As New TipoDocumentoContribuyenteNE
        'Dim dt As New DataTable
        TipoDocumentoContribuyenteBindingSource.DataSource = tipoDocumentoContribuyenteNE.listarTipoDocumentoContribuyenteLisNoArg
        'TipoDocumentoContribuyenteBindingSource.ResetBindings(False)
        'cboTipoDocRec.DataSource = dt
        'cboTipoDocRec.ValueMember = dt.Columns(1).ToString
        'cboTipoDocRec.DisplayMember = dt.Columns(3).ToString
    End Sub

    Private Sub LoadMoneda()
        Dim MonedaNE As New MonedaNE
        'Dim dt As New DataTable
        MonedaBindingSource.DataSource = MonedaNE.listarMonedaLisNoArg
        'cboMoneda.DataSource = dt
        'cboMoneda.ValueMember = dt.Columns(1).ToString
        'cboMoneda.DisplayMember = dt.Columns(3).ToString


        'Dim dt1 As New DataTable
        MonedaAnticipoBindingSource.DataSource = MonedaNE.listarMonedaLisNoArg
        'dt1 = MonedaNE.ListarMonedas()
        'cboMonedaAnticipo.DataSource = dt1
        'cboMonedaAnticipo.ValueMember = dt1.Columns(1).ToString
        'cboMonedaAnticipo.DisplayMember = dt1.Columns(3).ToString


    End Sub

    Private Sub LoadTipoDocumento()
        Dim TipoDocumento As New TipoDocumentoNE
        'Dim dt As New DataTable
        TipoDocumentoBindingSource.DataSource = TipoDocumento.listarTipoDocumentoLisNoArg
        'cboTipoDocumento.DataSource = dt
        'cboTipoDocumento.ValueMember = dt.Columns(1).ToString
        'cboTipoDocumento.DisplayMember = dt.Columns(3).ToString
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _documento = New DocumentoElectronico With {
            .FechaEmision = dtpFecha.Value.ToString("yyyy-MM-dd"),
            .IdDocumento = "F040-00000012"}
        ''_documento = documento
        '_documento.FechaEmision = dtpFecha.Value.ToString("yyyy-MM-dd")
        '_documento.IdDocumento = 

        inicializar()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub inicializar()
        DocumentoElectronicoBindingSource.DataSource = _documento
        DocumentoElectronicoBindingSource.ResetBindings(False)
        EmisorBindingSource.DataSource = _documento.Emisor
        EmisorBindingSource.ResetBindings(False)
        ReceptorBindingSource.DataSource = _documento.Receptor
        EmisorBindingSource.ResetBindings(False)
    End Sub
    Public Sub New(documento As DocumentoElectronico)
        InitializeComponent()
        _documento = documento
        'CargarDatos()
    End Sub
    Private Sub frmComprobante_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            CargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'Dim s As String = InputBox("hola", "hola")

        'Dim a As New InputBox2
        'MsgBox(a.ShowDialog("Titulo", "escribir", "", False, 1))

        'If  Then

        'End If
    End Sub


    Private Sub CalcularTotales()
        _documento.TotalIgv = _documento.Items.Sum(Function(d) d.Impuesto)
        _documento.TotalIsc = _documento.Items.Sum(Function(d) d.ImpuestoSelectivo)
        _documento.TotalOtrosTributos = _documento.Items.Sum(Function(d) d.OtroImpuesto)

        _documento.Gravadas = _documento.Items.Where(Function(d) d.TipoImpuesto.StartsWith("1")).Sum(Function(d) d.Suma)
        _documento.Exoneradas = _documento.Items.Where(Function(d) d.TipoImpuesto.StartsWith("20")).Sum(Function(d) d.Suma)
        _documento.Inafectas = _documento.Items.Where(Function(d) d.TipoImpuesto.StartsWith("3") Or d.TipoImpuesto.Contains("40")).Sum(Function(d) d.Suma)
        _documento.Gratuitas = _documento.Items.Where(Function(d) d.TipoImpuesto.Contains("21")).Sum(Function(d) d.Suma)

        If _documento.TotalIsc > 0 Then
            _documento.TotalIgv = (_documento.Gravadas + _documento.TotalIsc) * _documento.CalculoIgv
        End If

        _documento.TotalVenta = _documento.Gravadas + _documento.Exoneradas + _documento.Inafectas + _
                                _documento.TotalIgv + _documento.TotalIsc + _documento.TotalOtrosTributos

        DocumentoElectronicoBindingSource.ResetBindings(False)

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Select Case tbPaginas.SelectedIndex
                Case 0
                    Dim detalle = New DetalleDocumento
                    Using frm As New frmDetalleDocumento(detalle, _documento)
                        If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
                            Return
                        Else
                            _documento.Items.Add(detalle)
                            CalcularTotales()
                        End If
                    End Using
                Case 1
                    Dim datoAdicional = New DatoAdicional
                    Using frm As New frmDatosAdicionales(datoAdicional)
                        If (frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK) Then
                            Return
                        Else
                            _documento.DatoAdicionales.Add(datoAdicional)
                            DocumentoElectronicoBindingSource.ResetBindings(False)
                        End If

                    End Using
                Case 2
                    Dim documentoRelacionado = New DocumentoRelacionado
                    Using frm = New frmDocumentoRelacionado(documentoRelacionado)
                        If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
                            Return
                        Else
                            _documento.Relacionados.Add(documentoRelacionado)
                            DocumentoElectronicoBindingSource.ResetBindings(False)
                        End If
                    End Using

                Case 3
                    If _documento.TipoDocumento <> "07" And _documento.TipoDocumento <> "08" Then Return
                    Dim discrepancia = New Discrepancia
                    Using frm = New frmDiscrepancias(discrepancia, _documento.TipoDocumento)
                        If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
                            Return
                        Else
                            _documento.Discrepancias.Add(discrepancia)
                            DocumentoElectronicoBindingSource.ResetBindings(False)
                        End If
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Select Case tbPaginas.SelectedIndex
                Case 0
                    Dim registro = TryCast(DetallesBindingSource.Current, DetalleDocumento)
                    If registro Is Nothing Then Return
                    _documento.Items.Remove(registro)
                    CalcularTotales()
                Case 1
                    Dim docAdicional = TryCast(DatoAdicionalBindingSource.Current, DatoAdicional)
                    If docAdicional Is Nothing Then Return
                    _documento.DatoAdicionales.Remove(docAdicional)
                Case 2
                    Dim docRelacionado = TryCast(RelacionadosBindingSource.Current, DocumentoRelacionado)
                    If docRelacionado Is Nothing Then Return
                    _documento.Relacionados.Remove(docRelacionado)
                Case 3
                    Dim discrepancia = TryCast(DiscrepanciasBindingSource.Current, Discrepancia)
                    If discrepancia Is Nothing Then Return
                    _documento.Discrepancias.Remove(discrepancia)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            DocumentoElectronicoBindingSource.ResetBindings(False)

        End Try
    End Sub

    Private Sub btnGenerarXml_Click(sender As Object, e As EventArgs) Handles btnGenerarXml.Click
        Try
        DocumentoElectronicoBindingSource.EndEdit()
        txtTotalVenta.Focus()
        Dim response As New DocumentoResponse

        Dim generaSUNAT As New GeneraSUNAT

        Select Case _documento.TipoDocumento
            Case "07"
                response = generaSUNAT.GenerarDocumentoSinFirma(_documento, 1)
            Case "08"
                response = generaSUNAT.GenerarDocumentoSinFirma(_documento, 2)
            Case Else
                response = generaSUNAT.GenerarDocumentoSinFirma(_documento, 0)
        End Select
        If Not response.Exito Then
            Throw New ApplicationException(response.MensajeError)
        End If
        Dim rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _documento.IdDocumento & ".xml")

        File.WriteAllBytes(rutaArchivo, Convert.FromBase64String(response.TramaXmlSinFirma))
        DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscarEmisor_Click(sender As Object, e As EventArgs) Handles btnBuscarEmisor.Click

        Dim emisor = New Contribuyente
        Using frm As New frmEmpresa(emisor, Nothing)
            If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then Return
            EmisorBindingSource.DataSource = emisor
            EmisorBindingSource.ResetBindings(False)
            _documento.Emisor = emisor
            DocumentoElectronicoBindingSource.ResetBindings(False)
        End Using

    End Sub

    'Dim detalle = New DetalleDocumento
    '                Using frm As New frmDetalleDocumento(detalle, _documento)
    '                    If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
    '                        Return
    '                    Else
    '                        _documento.Items.Add(detalle)
    '                        CalcularTotales()
    '                    End If
    '                End Using

    Private Sub btnBuscarReceptor_Click(sender As Object, e As EventArgs) Handles btnBuscarReceptor.Click
        Dim receptor = New Contribuyente

        Using frm As New frmEmpresa(Nothing, receptor)
            If frm.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then Return
            ReceptorBindingSource.DataSource = receptor
            ReceptorBindingSource.ResetBindings(False)
            _documento.Receptor = receptor
            DocumentoElectronicoBindingSource.ResetBindings(False)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class