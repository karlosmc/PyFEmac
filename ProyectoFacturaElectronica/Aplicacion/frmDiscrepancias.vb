Public Class frmDiscrepancias

    Private ReadOnly _tipodoc As String
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(Discrepancia As Discrepancia, TipoDoc As String)
        InitializeComponent()
        _tipodoc = TipoDoc
        DiscrepanciaBindingSource.DataSource = Discrepancia
        DiscrepanciaBindingSource.ResetBindings(False)

        Dim TipoDiscrepanciaNE As New TipoDiscrepanciaNE
        Dim TipoDocumentNE As New TipoDocumentoNE
        Dim tipoDocumento = TipoDocumentNE.listarTipoDocumentoLisNoArg.SingleOrDefault(Function(p) p.pCodigo = _tipodoc)
        If tipoDocumento Is Nothing Then
            Return
        End If

        TipoDiscrepanciaBindingSource.DataSource = TipoDiscrepanciaNE.listarTipoDiscrepanciaLisNoArg.Where(Function(t) t.pIdTipoDocumento = tipoDocumento.pCodigo)
        TipoDiscrepanciaBindingSource.ResetBindings(False)
    End Sub



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DiscrepanciaBindingSource.EndEdit()
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class