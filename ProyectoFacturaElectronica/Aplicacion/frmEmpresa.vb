Public Class frmEmpresa

    Private Property _emisor As Contribuyente


    Private Property _receptor As Contribuyente

    Private Sub CargarDatos()
        Dim EmpresaNE As New EmpresaNE
        Dim resultados = EmpresaNE.LoadEmpresa().Where(Function(p) p.pNombreLegal.Contains(txtParam.Text))
        If resultados.Count = 0 Then
            resultados = EmpresaNE.LoadEmpresa().Where(Function(p) p.pNroDocumento.Contains(txtParam.Text))
        End If

        EmpresaBindingSource.DataSource = resultados
        EmpresaBindingSource.ResetBindings(False)
    

        ''Dim listEmpresa As New List(Of EmpresaEN)
        ''Dim resultados As New List(Of EmpresaEN)
        ''        listEmpresa = objEmpresa.LoadEmpresa()
        'Return objEmpresa.LoadEmpresa()
        ''Dim query = listEmpresa.Where(Function(p) p.pNombreLegal.Contains(param))
        ''If query.Count <= 0 Then
        ''    query = listEmpresa.Where(Function(p) p.pNroDocumento.Contains(param))
        ''End If
        ''For Each result In query
        ''    resultados.Add(result)
        ''Next
        ''Return resultados


    End Sub
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(emisor As Contribuyente, receptor As Contribuyente)
        InitializeComponent()
        _emisor = emisor
        _receptor = receptor
        Dim EmpresaNE As New EmpresaNE
        Dim resultados = EmpresaNE.LoadEmpresa().Where(Function(p) p.pNombreLegal.Contains(txtParam.Text))
        If resultados Is Nothing Then
            resultados = EmpresaNE.LoadEmpresa().Where(Function(p) p.pNroDocumento.Contains(txtParam.Text))
        End If
        EmpresaBindingSource.DataSource = resultados
        EmpresaBindingSource.ResetBindings(False)
      
    End Sub

    Private Sub dgvEmpresa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim empresa = TryCast(EmpresaBindingSource.Current, EmpresaEN)

        If _receptor Is Nothing Then
            If empresa Is Nothing Then Return
            _emisor.Direccion = empresa.pDireccion
            _emisor.TipoDocumento = empresa.pIdTipoDocumento
            _emisor.Ubigeo = empresa.pUbigeo
            _emisor.Urbanizacion = empresa.pUrbanizacion
            _emisor.NombreLegal = empresa.pNombreLegal
            _emisor.NombreComercial = empresa.pNombreComercial
            _emisor.NroDocumento = empresa.pNroDocumento

        Else

            If empresa Is Nothing Then Return
            _receptor.Direccion = empresa.pDireccion
            _receptor.TipoDocumento = empresa.pIdTipoDocumento
            _receptor.Ubigeo = empresa.pUbigeo
            _receptor.Urbanizacion = empresa.pUrbanizacion
            _receptor.NombreLegal = empresa.pNombreLegal
            _receptor.NombreComercial = empresa.pNombreComercial
            _receptor.NroDocumento = empresa.pNroDocumento

        End If

        '_Empresa = empresaNE.listarEmpresa(dgvEmpresa.Rows(e.RowIndex).Cells("pID").Value)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CargarDatos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarDatos()
    End Sub
End Class