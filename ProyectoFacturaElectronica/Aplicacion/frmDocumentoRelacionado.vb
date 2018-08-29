Public Class frmDocumentoRelacionado

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(DocumentoRelacionado As DocumentoRelacionado)
        InitializeComponent()
        DocumentoRelacionadoBindingSource.DataSource = DocumentoRelacionado
        DocumentoRelacionadoBindingSource.ResetBindings(False)

        Dim tipoDocumentoRelacionadoNE As New TipoDocumentoRelacionadosNE
        TipoDocumentoRelacionadoBindingSource.DataSource = tipoDocumentoRelacionadoNE.listarTipoDocumentoRelacionadosLisNoArg
        TipoDocumentoRelacionadoBindingSource.ResetBindings(False)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        DocumentoRelacionadoBindingSource.EndEdit()
        DocumentoRelacionadoBindingSource.RaiseListChangedEvents = False
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class