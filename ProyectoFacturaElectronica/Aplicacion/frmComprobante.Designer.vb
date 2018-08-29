<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.DocumentoElectronicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.MonedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboTipoOperacion = New System.Windows.Forms.ComboBox()
        Me.TipoOperacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDocumentoAnticipo = New System.Windows.Forms.ComboBox()
        Me.DocumentoAnticipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPaginas = New System.Windows.Forms.TabControl()
        Me.tpDetalles = New System.Windows.Forms.TabPage()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioReferencialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpuestoSelectivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtroImpuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpAdicionales = New System.Windows.Forms.TabPage()
        Me.dgvDatoAdicionales = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContenidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatoAdicionalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpRelacionados = New System.Windows.Forms.TabPage()
        Me.dgvRelacionados = New System.Windows.Forms.DataGridView()
        Me.TipoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelacionadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpDiscrepancias = New System.Windows.Forms.TabPage()
        Me.dgvDiscrepancias = New System.Windows.Forms.DataGridView()
        Me.NroReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscrepanciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpEmisor = New System.Windows.Forms.GroupBox()
        Me.btnBuscarEmisor = New System.Windows.Forms.Button()
        Me.txtUbigeoEm = New System.Windows.Forms.TextBox()
        Me.EmisorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProvinciaEm = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDepartamentoEm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDistritoEm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUrbanizacionEm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccionEm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreLegalEm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreComercialEm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNroDocEm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpReceptor = New System.Windows.Forms.GroupBox()
        Me.btnBuscarReceptor = New System.Windows.Forms.Button()
        Me.cboTipoDocRec = New System.Windows.Forms.ComboBox()
        Me.ReceptorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDocumentoContribuyenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNombreLegalRec = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNroDocRec = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMontoEnLetras = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtMontoEnLetras = New System.Windows.Forms.TextBox()
        Me.txtPlacaVehiculo = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cboMonedaAnticipo = New System.Windows.Forms.ComboBox()
        Me.MonedaAnticipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCalculoDetraccion = New System.Windows.Forms.TextBox()
        Me.txtMontoDetraccion = New System.Windows.Forms.TextBox()
        Me.txtPercepcion = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txtGravadas = New System.Windows.Forms.TextBox()
        Me.txtExoneradas = New System.Windows.Forms.TextBox()
        Me.txtTotalISC = New System.Windows.Forms.TextBox()
        Me.txtInafectas = New System.Windows.Forms.TextBox()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.txtTotalIGV = New System.Windows.Forms.TextBox()
        Me.txtGratuitas = New System.Windows.Forms.TextBox()
        Me.txtTotalOtrosTributos = New System.Windows.Forms.TextBox()
        Me.txtDescuentoGlobal = New System.Windows.Forms.TextBox()
        Me.txtCalculoIGV = New System.Windows.Forms.TextBox()
        Me.txtCalculoISC = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNrodoc = New System.Windows.Forms.TextBox()
        Me.btnGenerarXml = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DocumentoElectronicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoOperacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentoAnticipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPaginas.SuspendLayout()
        Me.tpDetalles.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAdicionales.SuspendLayout()
        CType(Me.dgvDatoAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatoAdicionalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRelacionados.SuspendLayout()
        CType(Me.dgvRelacionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelacionadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDiscrepancias.SuspendLayout()
        CType(Me.dgvDiscrepancias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscrepanciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmisor.SuspendLayout()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReceptor.SuspendLayout()
        CType(Me.ReceptorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocumentoContribuyenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedaAnticipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentoElectronicoBindingSource, "TipoDocumento", True))
        Me.cboTipoDocumento.DataSource = Me.TipoDocumentoBindingSource
        Me.cboTipoDocumento.DisplayMember = "pDescripcionCompleja"
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(493, 269)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(91, 21)
        Me.cboTipoDocumento.TabIndex = 0
        Me.cboTipoDocumento.ValueMember = "pCodigo"
        '
        'DocumentoElectronicoBindingSource
        '
        Me.DocumentoElectronicoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.DocumentoElectronico)
        '
        'TipoDocumentoBindingSource
        '
        Me.TipoDocumentoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoDocumentoEN)
        '
        'cboMoneda
        '
        Me.cboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentoElectronicoBindingSource, "Moneda", True))
        Me.cboMoneda.DataSource = Me.MonedaBindingSource
        Me.cboMoneda.DisplayMember = "pDescripcionCompleja"
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(493, 217)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(91, 21)
        Me.cboMoneda.TabIndex = 1
        Me.cboMoneda.ValueMember = "pCodigo"
        '
        'MonedaBindingSource
        '
        Me.MonedaBindingSource.DataSource = GetType(ProyectoFacturaElectronica.MonedaEN)
        '
        'cboTipoOperacion
        '
        Me.cboTipoOperacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentoElectronicoBindingSource, "TipoOperacion", True))
        Me.cboTipoOperacion.DataSource = Me.TipoOperacionBindingSource
        Me.cboTipoOperacion.DisplayMember = "pDescripcionCompleja"
        Me.cboTipoOperacion.FormattingEnabled = True
        Me.cboTipoOperacion.Location = New System.Drawing.Point(493, 244)
        Me.cboTipoOperacion.Name = "cboTipoOperacion"
        Me.cboTipoOperacion.Size = New System.Drawing.Size(91, 21)
        Me.cboTipoOperacion.TabIndex = 2
        Me.cboTipoOperacion.ValueMember = "pCodigo"
        '
        'TipoOperacionBindingSource
        '
        Me.TipoOperacionBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoOperacionesEN)
        '
        'cboDocumentoAnticipo
        '
        Me.cboDocumentoAnticipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentoElectronicoBindingSource, "TipoDocAnticipo", True))
        Me.cboDocumentoAnticipo.DataSource = Me.DocumentoAnticipoBindingSource
        Me.cboDocumentoAnticipo.DisplayMember = "pDescripcionCompleja"
        Me.cboDocumentoAnticipo.FormattingEnabled = True
        Me.cboDocumentoAnticipo.Location = New System.Drawing.Point(101, 39)
        Me.cboDocumentoAnticipo.Name = "cboDocumentoAnticipo"
        Me.cboDocumentoAnticipo.Size = New System.Drawing.Size(127, 21)
        Me.cboDocumentoAnticipo.TabIndex = 3
        Me.cboDocumentoAnticipo.ValueMember = "pCodigo"
        '
        'DocumentoAnticipoBindingSource
        '
        Me.DocumentoAnticipoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoDocumentoAnticiposEN)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Moneda:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Operacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Documento Anticipo"
        '
        'tbPaginas
        '
        Me.tbPaginas.Controls.Add(Me.tpDetalles)
        Me.tbPaginas.Controls.Add(Me.tpAdicionales)
        Me.tbPaginas.Controls.Add(Me.tpRelacionados)
        Me.tbPaginas.Controls.Add(Me.tpDiscrepancias)
        Me.tbPaginas.Location = New System.Drawing.Point(16, 294)
        Me.tbPaginas.Name = "tbPaginas"
        Me.tbPaginas.SelectedIndex = 0
        Me.tbPaginas.Size = New System.Drawing.Size(769, 173)
        Me.tbPaginas.TabIndex = 21
        '
        'tpDetalles
        '
        Me.tpDetalles.Controls.Add(Me.dgvDetalle)
        Me.tpDetalles.Location = New System.Drawing.Point(4, 22)
        Me.tpDetalles.Name = "tpDetalles"
        Me.tpDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetalles.Size = New System.Drawing.Size(761, 147)
        Me.tpDetalles.TabIndex = 0
        Me.tpDetalles.Text = "Detalles"
        Me.tpDetalles.UseVisualStyleBackColor = True
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AutoGenerateColumns = False
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.UnidadMedidaDataGridViewTextBoxColumn, Me.CodigoItemDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.ValorUnitarioDataGridViewTextBoxColumn, Me.PrecioReferencialDataGridViewTextBoxColumn, Me.TipoPrecioDataGridViewTextBoxColumn, Me.TipoImpuestoDataGridViewTextBoxColumn, Me.ImpuestoDataGridViewTextBoxColumn, Me.ImpuestoSelectivoDataGridViewTextBoxColumn, Me.OtroImpuestoDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.ValorTotalDataGridViewTextBoxColumn, Me.TotalVentaDataGridViewTextBoxColumn, Me.SumaDataGridViewTextBoxColumn})
        Me.dgvDetalle.DataSource = Me.DetallesBindingSource
        Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 3)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(755, 141)
        Me.dgvDetalle.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "1"
        Me.IDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle8.Format = "N3"
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 74
        '
        'UnidadMedidaDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.HeaderText = "UnidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Name = "UnidadMedidaDataGridViewTextBoxColumn"
        Me.UnidadMedidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadMedidaDataGridViewTextBoxColumn.Width = 101
        '
        'CodigoItemDataGridViewTextBoxColumn
        '
        Me.CodigoItemDataGridViewTextBoxColumn.DataPropertyName = "CodigoItem"
        Me.CodigoItemDataGridViewTextBoxColumn.HeaderText = "CodigoItem"
        Me.CodigoItemDataGridViewTextBoxColumn.Name = "CodigoItemDataGridViewTextBoxColumn"
        Me.CodigoItemDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoItemDataGridViewTextBoxColumn.Width = 85
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 88
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Width = 98
        '
        'ValorUnitarioDataGridViewTextBoxColumn
        '
        Me.ValorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario"
        Me.ValorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario"
        Me.ValorUnitarioDataGridViewTextBoxColumn.Name = "ValorUnitarioDataGridViewTextBoxColumn"
        Me.ValorUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorUnitarioDataGridViewTextBoxColumn.Width = 92
        '
        'PrecioReferencialDataGridViewTextBoxColumn
        '
        Me.PrecioReferencialDataGridViewTextBoxColumn.DataPropertyName = "PrecioReferencial"
        Me.PrecioReferencialDataGridViewTextBoxColumn.HeaderText = "PrecioReferencial"
        Me.PrecioReferencialDataGridViewTextBoxColumn.Name = "PrecioReferencialDataGridViewTextBoxColumn"
        Me.PrecioReferencialDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioReferencialDataGridViewTextBoxColumn.Width = 116
        '
        'TipoPrecioDataGridViewTextBoxColumn
        '
        Me.TipoPrecioDataGridViewTextBoxColumn.DataPropertyName = "TipoPrecio"
        Me.TipoPrecioDataGridViewTextBoxColumn.HeaderText = "TipoPrecio"
        Me.TipoPrecioDataGridViewTextBoxColumn.Name = "TipoPrecioDataGridViewTextBoxColumn"
        Me.TipoPrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoPrecioDataGridViewTextBoxColumn.Width = 83
        '
        'TipoImpuestoDataGridViewTextBoxColumn
        '
        Me.TipoImpuestoDataGridViewTextBoxColumn.DataPropertyName = "TipoImpuesto"
        Me.TipoImpuestoDataGridViewTextBoxColumn.HeaderText = "TipoImpuesto"
        Me.TipoImpuestoDataGridViewTextBoxColumn.Name = "TipoImpuestoDataGridViewTextBoxColumn"
        Me.TipoImpuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoImpuestoDataGridViewTextBoxColumn.Width = 96
        '
        'ImpuestoDataGridViewTextBoxColumn
        '
        Me.ImpuestoDataGridViewTextBoxColumn.DataPropertyName = "Impuesto"
        Me.ImpuestoDataGridViewTextBoxColumn.HeaderText = "Impuesto"
        Me.ImpuestoDataGridViewTextBoxColumn.Name = "ImpuestoDataGridViewTextBoxColumn"
        Me.ImpuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoDataGridViewTextBoxColumn.Width = 75
        '
        'ImpuestoSelectivoDataGridViewTextBoxColumn
        '
        Me.ImpuestoSelectivoDataGridViewTextBoxColumn.DataPropertyName = "ImpuestoSelectivo"
        Me.ImpuestoSelectivoDataGridViewTextBoxColumn.HeaderText = "ImpuestoSelectivo"
        Me.ImpuestoSelectivoDataGridViewTextBoxColumn.Name = "ImpuestoSelectivoDataGridViewTextBoxColumn"
        Me.ImpuestoSelectivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpuestoSelectivoDataGridViewTextBoxColumn.Width = 119
        '
        'OtroImpuestoDataGridViewTextBoxColumn
        '
        Me.OtroImpuestoDataGridViewTextBoxColumn.DataPropertyName = "OtroImpuesto"
        Me.OtroImpuestoDataGridViewTextBoxColumn.HeaderText = "OtroImpuesto"
        Me.OtroImpuestoDataGridViewTextBoxColumn.Name = "OtroImpuestoDataGridViewTextBoxColumn"
        Me.OtroImpuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtroImpuestoDataGridViewTextBoxColumn.Width = 95
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescuentoDataGridViewTextBoxColumn.Width = 84
        '
        'ValorTotalDataGridViewTextBoxColumn
        '
        Me.ValorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal"
        Me.ValorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal"
        Me.ValorTotalDataGridViewTextBoxColumn.Name = "ValorTotalDataGridViewTextBoxColumn"
        Me.ValorTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorTotalDataGridViewTextBoxColumn.Width = 80
        '
        'TotalVentaDataGridViewTextBoxColumn
        '
        Me.TotalVentaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenta"
        Me.TotalVentaDataGridViewTextBoxColumn.HeaderText = "TotalVenta"
        Me.TotalVentaDataGridViewTextBoxColumn.Name = "TotalVentaDataGridViewTextBoxColumn"
        Me.TotalVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalVentaDataGridViewTextBoxColumn.Width = 84
        '
        'SumaDataGridViewTextBoxColumn
        '
        Me.SumaDataGridViewTextBoxColumn.DataPropertyName = "Suma"
        Me.SumaDataGridViewTextBoxColumn.HeaderText = "Suma"
        Me.SumaDataGridViewTextBoxColumn.Name = "SumaDataGridViewTextBoxColumn"
        Me.SumaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SumaDataGridViewTextBoxColumn.Width = 59
        '
        'DetallesBindingSource
        '
        Me.DetallesBindingSource.DataMember = "Items"
        Me.DetallesBindingSource.DataSource = Me.DocumentoElectronicoBindingSource
        '
        'tpAdicionales
        '
        Me.tpAdicionales.Controls.Add(Me.dgvDatoAdicionales)
        Me.tpAdicionales.Location = New System.Drawing.Point(4, 22)
        Me.tpAdicionales.Name = "tpAdicionales"
        Me.tpAdicionales.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAdicionales.Size = New System.Drawing.Size(761, 147)
        Me.tpAdicionales.TabIndex = 1
        Me.tpAdicionales.Text = "Adicionales"
        Me.tpAdicionales.UseVisualStyleBackColor = True
        '
        'dgvDatoAdicionales
        '
        Me.dgvDatoAdicionales.AllowUserToAddRows = False
        Me.dgvDatoAdicionales.AutoGenerateColumns = False
        Me.dgvDatoAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatoAdicionales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.ContenidoDataGridViewTextBoxColumn})
        Me.dgvDatoAdicionales.DataSource = Me.DatoAdicionalBindingSource
        Me.dgvDatoAdicionales.Location = New System.Drawing.Point(3, 3)
        Me.dgvDatoAdicionales.Name = "dgvDatoAdicionales"
        Me.dgvDatoAdicionales.Size = New System.Drawing.Size(749, 138)
        Me.dgvDatoAdicionales.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'ContenidoDataGridViewTextBoxColumn
        '
        Me.ContenidoDataGridViewTextBoxColumn.DataPropertyName = "Contenido"
        Me.ContenidoDataGridViewTextBoxColumn.HeaderText = "Contenido"
        Me.ContenidoDataGridViewTextBoxColumn.Name = "ContenidoDataGridViewTextBoxColumn"
        '
        'DatoAdicionalBindingSource
        '
        Me.DatoAdicionalBindingSource.DataMember = "DatoAdicionales"
        Me.DatoAdicionalBindingSource.DataSource = Me.DocumentoElectronicoBindingSource
        '
        'tpRelacionados
        '
        Me.tpRelacionados.Controls.Add(Me.dgvRelacionados)
        Me.tpRelacionados.Location = New System.Drawing.Point(4, 22)
        Me.tpRelacionados.Name = "tpRelacionados"
        Me.tpRelacionados.Size = New System.Drawing.Size(761, 147)
        Me.tpRelacionados.TabIndex = 3
        Me.tpRelacionados.Text = "Relacionados"
        Me.tpRelacionados.UseVisualStyleBackColor = True
        '
        'dgvRelacionados
        '
        Me.dgvRelacionados.AllowUserToAddRows = False
        Me.dgvRelacionados.AutoGenerateColumns = False
        Me.dgvRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelacionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoDocumentoDataGridViewTextBoxColumn, Me.NroDocumento})
        Me.dgvRelacionados.DataSource = Me.RelacionadosBindingSource
        Me.dgvRelacionados.Location = New System.Drawing.Point(4, 3)
        Me.dgvRelacionados.Name = "dgvRelacionados"
        Me.dgvRelacionados.Size = New System.Drawing.Size(754, 138)
        Me.dgvRelacionados.TabIndex = 0
        '
        'TipoDocumentoDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.HeaderText = "TipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.Name = "TipoDocumentoDataGridViewTextBoxColumn"
        '
        'NroDocumento
        '
        Me.NroDocumento.DataPropertyName = "NroDocumento"
        Me.NroDocumento.HeaderText = "NroDocumento"
        Me.NroDocumento.Name = "NroDocumento"
        '
        'RelacionadosBindingSource
        '
        Me.RelacionadosBindingSource.DataMember = "Relacionados"
        Me.RelacionadosBindingSource.DataSource = Me.DocumentoElectronicoBindingSource
        '
        'tpDiscrepancias
        '
        Me.tpDiscrepancias.Controls.Add(Me.dgvDiscrepancias)
        Me.tpDiscrepancias.Location = New System.Drawing.Point(4, 22)
        Me.tpDiscrepancias.Name = "tpDiscrepancias"
        Me.tpDiscrepancias.Size = New System.Drawing.Size(761, 147)
        Me.tpDiscrepancias.TabIndex = 2
        Me.tpDiscrepancias.Text = "Discrepancias"
        Me.tpDiscrepancias.UseVisualStyleBackColor = True
        '
        'dgvDiscrepancias
        '
        Me.dgvDiscrepancias.AllowUserToAddRows = False
        Me.dgvDiscrepancias.AutoGenerateColumns = False
        Me.dgvDiscrepancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiscrepancias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroReferenciaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn1})
        Me.dgvDiscrepancias.DataSource = Me.DiscrepanciasBindingSource
        Me.dgvDiscrepancias.Location = New System.Drawing.Point(4, 3)
        Me.dgvDiscrepancias.Name = "dgvDiscrepancias"
        Me.dgvDiscrepancias.Size = New System.Drawing.Size(754, 138)
        Me.dgvDiscrepancias.TabIndex = 0
        '
        'NroReferenciaDataGridViewTextBoxColumn
        '
        Me.NroReferenciaDataGridViewTextBoxColumn.DataPropertyName = "NroReferencia"
        Me.NroReferenciaDataGridViewTextBoxColumn.HeaderText = "NroReferencia"
        Me.NroReferenciaDataGridViewTextBoxColumn.Name = "NroReferenciaDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        '
        'DiscrepanciasBindingSource
        '
        Me.DiscrepanciasBindingSource.DataMember = "Discrepancias"
        Me.DiscrepanciasBindingSource.DataSource = Me.DocumentoElectronicoBindingSource
        '
        'grpEmisor
        '
        Me.grpEmisor.Controls.Add(Me.btnBuscarEmisor)
        Me.grpEmisor.Controls.Add(Me.txtUbigeoEm)
        Me.grpEmisor.Controls.Add(Me.Label13)
        Me.grpEmisor.Controls.Add(Me.txtProvinciaEm)
        Me.grpEmisor.Controls.Add(Me.Label12)
        Me.grpEmisor.Controls.Add(Me.txtDepartamentoEm)
        Me.grpEmisor.Controls.Add(Me.Label11)
        Me.grpEmisor.Controls.Add(Me.txtDistritoEm)
        Me.grpEmisor.Controls.Add(Me.Label10)
        Me.grpEmisor.Controls.Add(Me.txtUrbanizacionEm)
        Me.grpEmisor.Controls.Add(Me.Label9)
        Me.grpEmisor.Controls.Add(Me.txtDireccionEm)
        Me.grpEmisor.Controls.Add(Me.Label8)
        Me.grpEmisor.Controls.Add(Me.txtNombreLegalEm)
        Me.grpEmisor.Controls.Add(Me.Label7)
        Me.grpEmisor.Controls.Add(Me.txtNombreComercialEm)
        Me.grpEmisor.Controls.Add(Me.Label6)
        Me.grpEmisor.Controls.Add(Me.txtNroDocEm)
        Me.grpEmisor.Controls.Add(Me.Label5)
        Me.grpEmisor.Location = New System.Drawing.Point(16, 9)
        Me.grpEmisor.Name = "grpEmisor"
        Me.grpEmisor.Size = New System.Drawing.Size(634, 145)
        Me.grpEmisor.TabIndex = 22
        Me.grpEmisor.TabStop = False
        Me.grpEmisor.Text = "Emisor"
        '
        'btnBuscarEmisor
        '
        Me.btnBuscarEmisor.Location = New System.Drawing.Point(218, 16)
        Me.btnBuscarEmisor.Name = "btnBuscarEmisor"
        Me.btnBuscarEmisor.Size = New System.Drawing.Size(118, 23)
        Me.btnBuscarEmisor.TabIndex = 69
        Me.btnBuscarEmisor.Text = "Emisor"
        Me.btnBuscarEmisor.UseVisualStyleBackColor = True
        '
        'txtUbigeoEm
        '
        Me.txtUbigeoEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Ubigeo", True))
        Me.txtUbigeoEm.Location = New System.Drawing.Point(460, 117)
        Me.txtUbigeoEm.Name = "txtUbigeoEm"
        Me.txtUbigeoEm.Size = New System.Drawing.Size(84, 20)
        Me.txtUbigeoEm.TabIndex = 17
        '
        'EmisorBindingSource
        '
        Me.EmisorBindingSource.DataSource = GetType(ProyectoFacturaElectronica.Contribuyente)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(363, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Ubigeo"
        '
        'txtProvinciaEm
        '
        Me.txtProvinciaEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Provincia", True))
        Me.txtProvinciaEm.Location = New System.Drawing.Point(460, 65)
        Me.txtProvinciaEm.Name = "txtProvinciaEm"
        Me.txtProvinciaEm.Size = New System.Drawing.Size(165, 20)
        Me.txtProvinciaEm.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(363, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Provincia"
        '
        'txtDepartamentoEm
        '
        Me.txtDepartamentoEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Departamento", True))
        Me.txtDepartamentoEm.Location = New System.Drawing.Point(460, 39)
        Me.txtDepartamentoEm.Name = "txtDepartamentoEm"
        Me.txtDepartamentoEm.Size = New System.Drawing.Size(165, 20)
        Me.txtDepartamentoEm.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(363, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Departamento :"
        '
        'txtDistritoEm
        '
        Me.txtDistritoEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Distrito", True))
        Me.txtDistritoEm.Location = New System.Drawing.Point(460, 91)
        Me.txtDistritoEm.Name = "txtDistritoEm"
        Me.txtDistritoEm.Size = New System.Drawing.Size(165, 20)
        Me.txtDistritoEm.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Distrito"
        '
        'txtUrbanizacionEm
        '
        Me.txtUrbanizacionEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Urbanizacion", True))
        Me.txtUrbanizacionEm.Location = New System.Drawing.Point(460, 13)
        Me.txtUrbanizacionEm.Name = "txtUrbanizacionEm"
        Me.txtUrbanizacionEm.Size = New System.Drawing.Size(165, 20)
        Me.txtUrbanizacionEm.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Urbanización:"
        '
        'txtDireccionEm
        '
        Me.txtDireccionEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Direccion", True))
        Me.txtDireccionEm.Location = New System.Drawing.Point(102, 112)
        Me.txtDireccionEm.Name = "txtDireccionEm"
        Me.txtDireccionEm.Size = New System.Drawing.Size(234, 20)
        Me.txtDireccionEm.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Dirección:"
        '
        'txtNombreLegalEm
        '
        Me.txtNombreLegalEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "NombreLegal", True))
        Me.txtNombreLegalEm.Location = New System.Drawing.Point(102, 54)
        Me.txtNombreLegalEm.Name = "txtNombreLegalEm"
        Me.txtNombreLegalEm.Size = New System.Drawing.Size(234, 20)
        Me.txtNombreLegalEm.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nombre Legal :"
        '
        'txtNombreComercialEm
        '
        Me.txtNombreComercialEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "NombreComercial", True))
        Me.txtNombreComercialEm.Location = New System.Drawing.Point(102, 86)
        Me.txtNombreComercialEm.Name = "txtNombreComercialEm"
        Me.txtNombreComercialEm.Size = New System.Drawing.Size(234, 20)
        Me.txtNombreComercialEm.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nombre Comercial :"
        '
        'txtNroDocEm
        '
        Me.txtNroDocEm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "NroDocumento", True))
        Me.txtNroDocEm.Location = New System.Drawing.Point(102, 19)
        Me.txtNroDocEm.Name = "txtNroDocEm"
        Me.txtNroDocEm.Size = New System.Drawing.Size(110, 20)
        Me.txtNroDocEm.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nro. Documento :"
        '
        'grpReceptor
        '
        Me.grpReceptor.Controls.Add(Me.btnBuscarReceptor)
        Me.grpReceptor.Controls.Add(Me.cboTipoDocRec)
        Me.grpReceptor.Controls.Add(Me.Label16)
        Me.grpReceptor.Controls.Add(Me.txtNombreLegalRec)
        Me.grpReceptor.Controls.Add(Me.Label15)
        Me.grpReceptor.Controls.Add(Me.txtNroDocRec)
        Me.grpReceptor.Controls.Add(Me.Label14)
        Me.grpReceptor.Location = New System.Drawing.Point(16, 175)
        Me.grpReceptor.Name = "grpReceptor"
        Me.grpReceptor.Size = New System.Drawing.Size(355, 114)
        Me.grpReceptor.TabIndex = 23
        Me.grpReceptor.TabStop = False
        Me.grpReceptor.Text = "Cliente"
        '
        'btnBuscarReceptor
        '
        Me.btnBuscarReceptor.Location = New System.Drawing.Point(229, 52)
        Me.btnBuscarReceptor.Name = "btnBuscarReceptor"
        Me.btnBuscarReceptor.Size = New System.Drawing.Size(118, 23)
        Me.btnBuscarReceptor.TabIndex = 70
        Me.btnBuscarReceptor.Text = "Receptor"
        Me.btnBuscarReceptor.UseVisualStyleBackColor = True
        '
        'cboTipoDocRec
        '
        Me.cboTipoDocRec.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptorBindingSource, "TipoDocumento", True))
        Me.cboTipoDocRec.DataSource = Me.TipoDocumentoContribuyenteBindingSource
        Me.cboTipoDocRec.DisplayMember = "pDescripcionCompleja"
        Me.cboTipoDocRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocRec.FormattingEnabled = True
        Me.cboTipoDocRec.Location = New System.Drawing.Point(113, 22)
        Me.cboTipoDocRec.Name = "cboTipoDocRec"
        Me.cboTipoDocRec.Size = New System.Drawing.Size(234, 21)
        Me.cboTipoDocRec.TabIndex = 9
        Me.cboTipoDocRec.ValueMember = "pCodigo"
        '
        'ReceptorBindingSource
        '
        Me.ReceptorBindingSource.DataSource = GetType(ProyectoFacturaElectronica.Contribuyente)
        '
        'TipoDocumentoContribuyenteBindingSource
        '
        Me.TipoDocumentoContribuyenteBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoDocumentoContribuyenteEN)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Nro. Documento"
        '
        'txtNombreLegalRec
        '
        Me.txtNombreLegalRec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptorBindingSource, "NombreLegal", True))
        Me.txtNombreLegalRec.Location = New System.Drawing.Point(113, 86)
        Me.txtNombreLegalRec.Name = "txtNombreLegalRec"
        Me.txtNombreLegalRec.Size = New System.Drawing.Size(223, 20)
        Me.txtNombreLegalRec.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Nombre Legal :"
        '
        'txtNroDocRec
        '
        Me.txtNroDocRec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptorBindingSource, "NroDocumento", True))
        Me.txtNroDocRec.Location = New System.Drawing.Point(113, 54)
        Me.txtNroDocRec.Name = "txtNroDocRec"
        Me.txtNroDocRec.Size = New System.Drawing.Size(110, 20)
        Me.txtNroDocRec.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Tipo Doc."
        '
        'lblMontoEnLetras
        '
        Me.lblMontoEnLetras.AutoSize = True
        Me.lblMontoEnLetras.Location = New System.Drawing.Point(13, 628)
        Me.lblMontoEnLetras.Name = "lblMontoEnLetras"
        Me.lblMontoEnLetras.Size = New System.Drawing.Size(84, 13)
        Me.lblMontoEnLetras.TabIndex = 24
        Me.lblMontoEnLetras.Text = "Monto en Letras"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 470)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Gravadas"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(32, 492)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Exoneradas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(37, 515)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Inafectas"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(290, 515)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Gratuitas"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(37, 560)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Total IGV"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(40, 537)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Total ISC"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(290, 492)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 13)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Total Otros Tributos"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(29, 582)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Total Venta"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(587, 576)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Calculo IGV"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(588, 603)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 13)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "Calculo ISC"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(583, 470)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(94, 13)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "CalculoDetraccion"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(290, 470)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 13)
        Me.Label30.TabIndex = 38
        Me.Label30.Text = "Descuento Global"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(586, 530)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 13)
        Me.Label31.TabIndex = 39
        Me.Label31.Text = "MontoPercepcion"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(583, 497)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(89, 13)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "MontoDetraccion"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(2, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 13)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "Nro. Doc. Anticipo"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(8, 91)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(78, 13)
        Me.Label35.TabIndex = 43
        Me.Label35.Text = "Monto Anticipo"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(4, 64)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(87, 13)
        Me.Label36.TabIndex = 44
        Me.Label36.Text = "Moneda Anticipo"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(635, 199)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(37, 13)
        Me.Label37.TabIndex = 45
        Me.Label37.Text = "Placa:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(493, 191)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecha.TabIndex = 46
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(429, 195)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 13)
        Me.Label38.TabIndex = 47
        Me.Label38.Text = "Fecha:"
        '
        'txtMontoEnLetras
        '
        Me.txtMontoEnLetras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "MontoEnLetras", True))
        Me.txtMontoEnLetras.Location = New System.Drawing.Point(118, 625)
        Me.txtMontoEnLetras.Name = "txtMontoEnLetras"
        Me.txtMontoEnLetras.Size = New System.Drawing.Size(581, 20)
        Me.txtMontoEnLetras.TabIndex = 48
        '
        'txtPlacaVehiculo
        '
        Me.txtPlacaVehiculo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "PlacaVehiculo", True))
        Me.txtPlacaVehiculo.Location = New System.Drawing.Point(707, 196)
        Me.txtPlacaVehiculo.Name = "txtPlacaVehiculo"
        Me.txtPlacaVehiculo.Size = New System.Drawing.Size(165, 20)
        Me.txtPlacaVehiculo.TabIndex = 49
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "DocAnticipo", True))
        Me.TextBox3.Location = New System.Drawing.Point(101, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 20)
        Me.TextBox3.TabIndex = 50
        '
        'cboMonedaAnticipo
        '
        Me.cboMonedaAnticipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentoElectronicoBindingSource, "MonedaAnticipo", True))
        Me.cboMonedaAnticipo.DataSource = Me.MonedaAnticipoBindingSource
        Me.cboMonedaAnticipo.DisplayMember = "pDescripcionCompleja"
        Me.cboMonedaAnticipo.FormattingEnabled = True
        Me.cboMonedaAnticipo.Location = New System.Drawing.Point(101, 61)
        Me.cboMonedaAnticipo.Name = "cboMonedaAnticipo"
        Me.cboMonedaAnticipo.Size = New System.Drawing.Size(127, 21)
        Me.cboMonedaAnticipo.TabIndex = 51
        Me.cboMonedaAnticipo.ValueMember = "pCodigo"
        '
        'MonedaAnticipoBindingSource
        '
        Me.MonedaAnticipoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.MonedaEN)
        '
        'txtCalculoDetraccion
        '
        Me.txtCalculoDetraccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "CalculoDetraccion", True))
        Me.txtCalculoDetraccion.Location = New System.Drawing.Point(693, 463)
        Me.txtCalculoDetraccion.Name = "txtCalculoDetraccion"
        Me.txtCalculoDetraccion.Size = New System.Drawing.Size(165, 20)
        Me.txtCalculoDetraccion.TabIndex = 52
        '
        'txtMontoDetraccion
        '
        Me.txtMontoDetraccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "MontoDetraccion", True))
        Me.txtMontoDetraccion.Location = New System.Drawing.Point(693, 490)
        Me.txtMontoDetraccion.Name = "txtMontoDetraccion"
        Me.txtMontoDetraccion.Size = New System.Drawing.Size(165, 20)
        Me.txtMontoDetraccion.TabIndex = 53
        '
        'txtPercepcion
        '
        Me.txtPercepcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "MontoPercepcion", True))
        Me.txtPercepcion.Location = New System.Drawing.Point(693, 527)
        Me.txtPercepcion.Name = "txtPercepcion"
        Me.txtPercepcion.Size = New System.Drawing.Size(165, 20)
        Me.txtPercepcion.TabIndex = 54
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "MontoAnticipo", True))
        Me.TextBox7.Location = New System.Drawing.Point(101, 88)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(127, 20)
        Me.TextBox7.TabIndex = 55
        '
        'txtGravadas
        '
        Me.txtGravadas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "Gravadas", True))
        Me.txtGravadas.Location = New System.Drawing.Point(118, 467)
        Me.txtGravadas.Name = "txtGravadas"
        Me.txtGravadas.Size = New System.Drawing.Size(165, 20)
        Me.txtGravadas.TabIndex = 56
        '
        'txtExoneradas
        '
        Me.txtExoneradas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "Exoneradas", True))
        Me.txtExoneradas.Location = New System.Drawing.Point(118, 489)
        Me.txtExoneradas.Name = "txtExoneradas"
        Me.txtExoneradas.Size = New System.Drawing.Size(165, 20)
        Me.txtExoneradas.TabIndex = 57
        '
        'txtTotalISC
        '
        Me.txtTotalISC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "TotalIsc", True))
        Me.txtTotalISC.Location = New System.Drawing.Point(118, 534)
        Me.txtTotalISC.Name = "txtTotalISC"
        Me.txtTotalISC.Size = New System.Drawing.Size(165, 20)
        Me.txtTotalISC.TabIndex = 59
        '
        'txtInafectas
        '
        Me.txtInafectas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "Inafectas", True))
        Me.txtInafectas.Location = New System.Drawing.Point(118, 512)
        Me.txtInafectas.Name = "txtInafectas"
        Me.txtInafectas.Size = New System.Drawing.Size(165, 20)
        Me.txtInafectas.TabIndex = 58
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "TotalVenta", True))
        Me.txtTotalVenta.Location = New System.Drawing.Point(118, 579)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(165, 20)
        Me.txtTotalVenta.TabIndex = 61
        '
        'txtTotalIGV
        '
        Me.txtTotalIGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "TotalIgv", True))
        Me.txtTotalIGV.Location = New System.Drawing.Point(118, 557)
        Me.txtTotalIGV.Name = "txtTotalIGV"
        Me.txtTotalIGV.Size = New System.Drawing.Size(165, 20)
        Me.txtTotalIGV.TabIndex = 60
        '
        'txtGratuitas
        '
        Me.txtGratuitas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "Gratuitas", True))
        Me.txtGratuitas.Location = New System.Drawing.Point(395, 512)
        Me.txtGratuitas.Name = "txtGratuitas"
        Me.txtGratuitas.Size = New System.Drawing.Size(120, 20)
        Me.txtGratuitas.TabIndex = 64
        '
        'txtTotalOtrosTributos
        '
        Me.txtTotalOtrosTributos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "TotalOtrosTributos", True))
        Me.txtTotalOtrosTributos.Location = New System.Drawing.Point(395, 489)
        Me.txtTotalOtrosTributos.Name = "txtTotalOtrosTributos"
        Me.txtTotalOtrosTributos.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalOtrosTributos.TabIndex = 63
        '
        'txtDescuentoGlobal
        '
        Me.txtDescuentoGlobal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "DescuentoGlobal", True))
        Me.txtDescuentoGlobal.Location = New System.Drawing.Point(395, 467)
        Me.txtDescuentoGlobal.Name = "txtDescuentoGlobal"
        Me.txtDescuentoGlobal.Size = New System.Drawing.Size(120, 20)
        Me.txtDescuentoGlobal.TabIndex = 62
        '
        'txtCalculoIGV
        '
        Me.txtCalculoIGV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "CalculoIgv", True))
        Me.txtCalculoIGV.Location = New System.Drawing.Point(684, 573)
        Me.txtCalculoIGV.Name = "txtCalculoIGV"
        Me.txtCalculoIGV.Size = New System.Drawing.Size(165, 20)
        Me.txtCalculoIGV.TabIndex = 65
        '
        'txtCalculoISC
        '
        Me.txtCalculoISC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "CalculoIsc", True))
        Me.txtCalculoISC.Location = New System.Drawing.Point(684, 600)
        Me.txtCalculoISC.Name = "txtCalculoISC"
        Me.txtCalculoISC.Size = New System.Drawing.Size(165, 20)
        Me.txtCalculoISC.TabIndex = 66
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(791, 316)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(59, 23)
        Me.btnAgregar.TabIndex = 67
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(791, 345)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(59, 23)
        Me.btnEliminar.TabIndex = 68
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.cboDocumentoAnticipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.cboMonedaAnticipo)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(658, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 119)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(390, 171)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 13)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Nro. Documento:"
        '
        'txtNrodoc
        '
        Me.txtNrodoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoElectronicoBindingSource, "IdDocumento", True))
        Me.txtNrodoc.Location = New System.Drawing.Point(707, 168)
        Me.txtNrodoc.Name = "txtNrodoc"
        Me.txtNrodoc.Size = New System.Drawing.Size(91, 20)
        Me.txtNrodoc.TabIndex = 71
        '
        'btnGenerarXml
        '
        Me.btnGenerarXml.Location = New System.Drawing.Point(344, 550)
        Me.btnGenerarXml.Name = "btnGenerarXml"
        Me.btnGenerarXml.Size = New System.Drawing.Size(134, 23)
        Me.btnGenerarXml.TabIndex = 72
        Me.btnGenerarXml.Text = "GENERAR XML"
        Me.btnGenerarXml.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 582)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "GENERAR PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 657)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGenerarXml)
        Me.Controls.Add(Me.txtNrodoc)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCalculoISC)
        Me.Controls.Add(Me.txtCalculoIGV)
        Me.Controls.Add(Me.txtGratuitas)
        Me.Controls.Add(Me.txtTotalOtrosTributos)
        Me.Controls.Add(Me.txtDescuentoGlobal)
        Me.Controls.Add(Me.txtTotalVenta)
        Me.Controls.Add(Me.txtTotalIGV)
        Me.Controls.Add(Me.txtTotalISC)
        Me.Controls.Add(Me.txtInafectas)
        Me.Controls.Add(Me.txtExoneradas)
        Me.Controls.Add(Me.txtGravadas)
        Me.Controls.Add(Me.txtPercepcion)
        Me.Controls.Add(Me.txtMontoDetraccion)
        Me.Controls.Add(Me.txtCalculoDetraccion)
        Me.Controls.Add(Me.txtPlacaVehiculo)
        Me.Controls.Add(Me.txtMontoEnLetras)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblMontoEnLetras)
        Me.Controls.Add(Me.grpReceptor)
        Me.Controls.Add(Me.grpEmisor)
        Me.Controls.Add(Me.tbPaginas)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoOperacion)
        Me.Controls.Add(Me.cboMoneda)
        Me.Name = "frmComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar"
        CType(Me.DocumentoElectronicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoOperacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentoAnticipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPaginas.ResumeLayout(False)
        Me.tpDetalles.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAdicionales.ResumeLayout(False)
        CType(Me.dgvDatoAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatoAdicionalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRelacionados.ResumeLayout(False)
        CType(Me.dgvRelacionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelacionadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDiscrepancias.ResumeLayout(False)
        CType(Me.dgvDiscrepancias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscrepanciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmisor.ResumeLayout(False)
        Me.grpEmisor.PerformLayout()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReceptor.ResumeLayout(False)
        Me.grpReceptor.PerformLayout()
        CType(Me.ReceptorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocumentoContribuyenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedaAnticipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents cboDocumentoAnticipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPaginas As System.Windows.Forms.TabControl
    Friend WithEvents tpDetalles As System.Windows.Forms.TabPage
    Friend WithEvents tpAdicionales As System.Windows.Forms.TabPage
    Friend WithEvents tpRelacionados As System.Windows.Forms.TabPage
    Friend WithEvents tpDiscrepancias As System.Windows.Forms.TabPage
    Friend WithEvents grpEmisor As System.Windows.Forms.GroupBox
    Friend WithEvents grpReceptor As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroDocEm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombreLegalEm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNombreComercialEm As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDistritoEm As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtUrbanizacionEm As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionEm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProvinciaEm As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDepartamentoEm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUbigeoEm As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocRec As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNombreLegalRec As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocRec As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblMontoEnLetras As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtMontoEnLetras As System.Windows.Forms.TextBox
    Friend WithEvents txtPlacaVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents cboMonedaAnticipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtCalculoDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents txtPercepcion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents txtGravadas As System.Windows.Forms.TextBox
    Friend WithEvents txtExoneradas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalISC As System.Windows.Forms.TextBox
    Friend WithEvents txtInafectas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtGratuitas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalOtrosTributos As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuentoGlobal As System.Windows.Forms.TextBox
    Friend WithEvents txtCalculoIGV As System.Windows.Forms.TextBox
    Friend WithEvents txtCalculoISC As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarEmisor As System.Windows.Forms.Button
    Friend WithEvents btnBuscarReceptor As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDatoAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRelacionados As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDiscrepancias As System.Windows.Forms.DataGridView
    Friend WithEvents TipoDocumentoContribuyenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentoAnticipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonedaAnticipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonedaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoOperacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDocumentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmisorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetallesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentoElectronicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioReferencialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpuestoSelectivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtroImpuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceptorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatoAdicionalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContenidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelacionadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscrepanciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNrodoc As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarXml As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
