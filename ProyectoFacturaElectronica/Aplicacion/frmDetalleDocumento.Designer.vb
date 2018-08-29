<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleDocumento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.DetalleDocBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtPrecioReferencial = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.cboTipoImpuesto = New System.Windows.Forms.ComboBox()
        Me.TipoImpuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtImpuestoSelectivo = New System.Windows.Forms.TextBox()
        Me.txtOtroImpuesto = New System.Windows.Forms.TextBox()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.cboTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.TipoPrecioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nudID = New System.Windows.Forms.NumericUpDown()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.btnCalcIgv = New System.Windows.Forms.Button()
        Me.btnCalcIsc = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DetalleDocBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoImpuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoPrecioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Unitario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio referencial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Unidade de medida"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(390, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Impuesto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tipo Impuesto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(390, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Impuesto Selectivo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Otro Impuesto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(391, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Total Venta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(392, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Tipo Precio"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(390, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Descuento"
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "CodigoItem", True))
        Me.txtCodigo.Location = New System.Drawing.Point(130, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 15
        '
        'DetalleDocBindingSource1
        '
        Me.DetalleDocBindingSource1.DataSource = GetType(ProyectoFacturaElectronica.DetalleDocumento)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "Descripcion", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 48)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 16
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "PrecioUnitario", True))
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(130, 70)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioUnitario.TabIndex = 17
        '
        'txtPrecioReferencial
        '
        Me.txtPrecioReferencial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "PrecioReferencial", True))
        Me.txtPrecioReferencial.Location = New System.Drawing.Point(130, 95)
        Me.txtPrecioReferencial.Name = "txtPrecioReferencial"
        Me.txtPrecioReferencial.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioReferencial.TabIndex = 18
        '
        'txtCantidad
        '
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "Cantidad", True))
        Me.txtCantidad.Location = New System.Drawing.Point(130, 125)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 19
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "UnidadMedida", True))
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.Items.AddRange(New Object() {"NIU", "KG", "ONZ", "LTR"})
        Me.cboUnidadMedida.Location = New System.Drawing.Point(130, 147)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(100, 21)
        Me.cboUnidadMedida.TabIndex = 20
        Me.cboUnidadMedida.Text = "NIU"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "Impuesto", True))
        Me.txtImpuesto.Location = New System.Drawing.Point(483, 6)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuesto.TabIndex = 21
        '
        'cboTipoImpuesto
        '
        Me.cboTipoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DetalleDocBindingSource1, "TipoImpuesto", True))
        Me.cboTipoImpuesto.DataSource = Me.TipoImpuestoBindingSource
        Me.cboTipoImpuesto.DisplayMember = "pDescripcionCompleta"
        Me.cboTipoImpuesto.FormattingEnabled = True
        Me.cboTipoImpuesto.Location = New System.Drawing.Point(130, 172)
        Me.cboTipoImpuesto.Name = "cboTipoImpuesto"
        Me.cboTipoImpuesto.Size = New System.Drawing.Size(193, 21)
        Me.cboTipoImpuesto.TabIndex = 22
        Me.cboTipoImpuesto.ValueMember = "pCodigo"
        '
        'TipoImpuestoBindingSource
        '
        Me.TipoImpuestoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoImpuestosEN)
        '
        'txtImpuestoSelectivo
        '
        Me.txtImpuestoSelectivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "ImpuestoSelectivo", True))
        Me.txtImpuestoSelectivo.Location = New System.Drawing.Point(483, 51)
        Me.txtImpuestoSelectivo.Name = "txtImpuestoSelectivo"
        Me.txtImpuestoSelectivo.Size = New System.Drawing.Size(100, 20)
        Me.txtImpuestoSelectivo.TabIndex = 23
        '
        'txtOtroImpuesto
        '
        Me.txtOtroImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "OtroImpuesto", True))
        Me.txtOtroImpuesto.Location = New System.Drawing.Point(483, 74)
        Me.txtOtroImpuesto.Name = "txtOtroImpuesto"
        Me.txtOtroImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtOtroImpuesto.TabIndex = 24
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "TotalVenta", True))
        Me.txtTotalVenta.Location = New System.Drawing.Point(483, 169)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalVenta.TabIndex = 25
        '
        'cboTipoPrecio
        '
        Me.cboTipoPrecio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DetalleDocBindingSource1, "TipoPrecio", True))
        Me.cboTipoPrecio.DataSource = Me.TipoPrecioBindingSource
        Me.cboTipoPrecio.DisplayMember = "pDescripcionCompleja"
        Me.cboTipoPrecio.FormattingEnabled = True
        Me.cboTipoPrecio.Location = New System.Drawing.Point(483, 126)
        Me.cboTipoPrecio.Name = "cboTipoPrecio"
        Me.cboTipoPrecio.Size = New System.Drawing.Size(193, 21)
        Me.cboTipoPrecio.TabIndex = 26
        Me.cboTipoPrecio.ValueMember = "pCodigo"
        '
        'TipoPrecioBindingSource
        '
        Me.TipoPrecioBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoPrecioEN)
        '
        'nudID
        '
        Me.nudID.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetalleDocBindingSource1, "ID", True))
        Me.nudID.Location = New System.Drawing.Point(130, 7)
        Me.nudID.Name = "nudID"
        Me.nudID.Size = New System.Drawing.Size(100, 20)
        Me.nudID.TabIndex = 27
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "Descuento", True))
        Me.txtDescuento.Location = New System.Drawing.Point(483, 100)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 28
        '
        'btnCalcIgv
        '
        Me.btnCalcIgv.Location = New System.Drawing.Point(208, 199)
        Me.btnCalcIgv.Name = "btnCalcIgv"
        Me.btnCalcIgv.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcIgv.TabIndex = 29
        Me.btnCalcIgv.Text = "Calcular IGV"
        Me.btnCalcIgv.UseVisualStyleBackColor = True
        '
        'btnCalcIsc
        '
        Me.btnCalcIsc.Location = New System.Drawing.Point(289, 199)
        Me.btnCalcIsc.Name = "btnCalcIsc"
        Me.btnCalcIsc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcIsc.TabIndex = 30
        Me.btnCalcIsc.Text = "Calcular ISC"
        Me.btnCalcIsc.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(289, 231)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(208, 231)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 31
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtValorTotal
        '
        Me.txtValorTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "ValorTotal", True))
        Me.txtValorTotal.Location = New System.Drawing.Point(483, 149)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(391, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Valor Total"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetalleDocBindingSource1, "ValorUnitario", True))
        Me.txtValorUnitario.Location = New System.Drawing.Point(483, 28)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtValorUnitario.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(390, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Valor Unitario"
        '
        'frmDetalleDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 266)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCalcIsc)
        Me.Controls.Add(Me.btnCalcIgv)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.nudID)
        Me.Controls.Add(Me.cboTipoPrecio)
        Me.Controls.Add(Me.txtTotalVenta)
        Me.Controls.Add(Me.txtOtroImpuesto)
        Me.Controls.Add(Me.txtImpuestoSelectivo)
        Me.Controls.Add(Me.cboTipoImpuesto)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecioReferencial)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDetalleDocumento"
        Me.Text = "frmDetalleDocumento"
        CType(Me.DetalleDocBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoImpuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoPrecioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioReferencial As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cboUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoImpuesto As System.Windows.Forms.ComboBox
    Friend WithEvents txtImpuestoSelectivo As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalVenta As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents nudID As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcIgv As System.Windows.Forms.Button
    Friend WithEvents btnCalcIsc As System.Windows.Forms.Button
    Friend WithEvents TipoImpuestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoPrecioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents DetalleDocBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
