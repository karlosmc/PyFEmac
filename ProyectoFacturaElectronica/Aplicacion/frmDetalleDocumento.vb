Public Class frmDetalleDocumento


    Private ReadOnly _detalle As DetalleDocumento
    Private ReadOnly _documento As DocumentoElectronico
    'Private ReadOnly Property detalle As DetalleDocumento
    '    Get
    '        Return _detalle
    '    End Get
    'End Property
    'Private ReadOnly Property documento As DocumentoElectronico
    '    Get
    '        Return _documento
    '    End Get
    'End Property
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(detalle As DetalleDocumento, documento As DocumentoElectronico)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _detalle = detalle
        _documento = documento
        DetalleDocBindingSource1.DataSource = _detalle
        DetalleDocBindingSource1.ResetBindings(False)

        Dim TipoImpuestosNE As New TipoImpuestosNE
        TipoImpuestoBindingSource.DataSource = TipoImpuestosNE.listarTipoImpuestosLisNoArg

        Dim TipoPrecioNE As New TipoPrecioNE
        TipoPrecioBindingSource.DataSource = TipoPrecioNE.listarTipoPrecioLisNoArg
        TipoPrecioBindingSource.ResetBindings(False)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'Private Sub LoadTipoImpuestos()
    '    Dim TipoImpuestosNE As New TipoImpuestosNE
    '    Dim dt As New DataTable
    '    dt = TipoImpuestosNE.LoadTipoImpuestos
    '    cboTipoImpuesto.DataSource = dt
    '    cboTipoImpuesto.ValueMember = dt.Columns(1).ToString
    '    cboTipoImpuesto.DisplayMember = dt.Columns(3).ToString
    'End Sub

    'Private Sub LoadTipoPrecio()
    '    Dim TipoPrecioNE As New TipoPrecioNE
    '    TipoPrecioBindingSource.DataSource = TipoPrecioNE.listarTipoPrecioLisNoArg
    '    TipoPrecioBindingSource.ResetBindings(False)

    'End Sub

    Private Sub frmDetalleDocumento_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        cboTipoPrecio.Focus()
        _detalle.UnidadMedida = cboUnidadMedida.Text
        If Not (_detalle.TipoImpuesto.StartsWith("1")) Then
            _detalle.Suma = _detalle.PrecioUnitario * _detalle.Cantidad
            _detalle.TotalVenta = _detalle.Suma - _detalle.Descuento
        Else
            If (_detalle.OtroImpuesto > 0) Then
                _detalle.TotalVenta = _detalle.TotalVenta + _detalle.OtroImpuesto
            End If
        End If
        DialogResult = DialogResult.OK
    End Sub


    Private Sub btnCalcIgv_Click(sender As Object, e As EventArgs) Handles btnCalcIgv.Click
        _detalle.ValorUnitario = _detalle.PrecioUnitario / (_documento.CalculoIgv + 1)
        _detalle.Suma = _detalle.ValorUnitario * _detalle.Cantidad
        _detalle.Impuesto = _detalle.Suma * _documento.CalculoIgv
        _detalle.TotalVenta = _detalle.Suma + _detalle.Impuesto - _detalle.Descuento
        _detalle.ValorTotal = _detalle.Suma
        DetalleDocBindingSource1.ResetBindings(False)
    End Sub

    Private Sub btnCalcIsc_Click(sender As Object, e As EventArgs) Handles btnCalcIsc.Click
        _detalle.Suma = _detalle.PrecioUnitario * _detalle.Cantidad
        _detalle.ImpuestoSelectivo = _detalle.Suma * _documento.CalculoIsc

        DetalleDocBindingSource1.ResetBindings(False)
    End Sub
End Class