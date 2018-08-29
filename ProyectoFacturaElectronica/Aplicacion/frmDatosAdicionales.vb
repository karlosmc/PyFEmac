Public Class frmDatosAdicionales

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(Dato As DatoAdicional)
        InitializeComponent()

        DatoAdicionalBindingSource.DataSource = Dato
        DatoAdicionalBindingSource.ResetBindings(False)

        Dim TipoDatoAdicionalNE As New TipoDatoAdicionalesNE
        TipoDatoAdicionalBindingSource.DataSource = TipoDatoAdicionalNE.listarTipoDatoAdicionalesLisNoArg
        TipoDatoAdicionalBindingSource.ResetBindings(False)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            DatoAdicionalBindingSource.EndEdit()
            DatoAdicionalBindingSource.RaiseListChangedEvents = False
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            DatoAdicionalBindingSource.RaiseListChangedEvents = True
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class