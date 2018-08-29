<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
        Me.txtParam = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.EmisorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceptorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIdTipoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNombreLegalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNombreComercialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUrbanizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCorreoElectronicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIdUbigeoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUbigeoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpresa
        '
        Me.dgvEmpresa.AutoGenerateColumns = False
        Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.PNroDocumentoDataGridViewTextBoxColumn, Me.PIdTipoDocumentoDataGridViewTextBoxColumn, Me.PNombreLegalDataGridViewTextBoxColumn, Me.PNombreComercialDataGridViewTextBoxColumn, Me.PDireccionDataGridViewTextBoxColumn, Me.PUrbanizacionDataGridViewTextBoxColumn, Me.PCorreoElectronicoDataGridViewTextBoxColumn, Me.PIdUbigeoDataGridViewTextBoxColumn, Me.PUbigeoDataGridViewTextBoxColumn})
        Me.dgvEmpresa.DataSource = Me.EmpresaBindingSource
        Me.dgvEmpresa.Location = New System.Drawing.Point(11, 51)
        Me.dgvEmpresa.Name = "dgvEmpresa"
        Me.dgvEmpresa.Size = New System.Drawing.Size(679, 150)
        Me.dgvEmpresa.TabIndex = 0
        '
        'txtParam
        '
        Me.txtParam.Location = New System.Drawing.Point(21, 25)
        Me.txtParam.Name = "txtParam"
        Me.txtParam.Size = New System.Drawing.Size(252, 20)
        Me.txtParam.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(602, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(506, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Button2"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataSource = GetType(ProyectoFacturaElectronica.EmpresaEN)
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "pID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "pID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        '
        'PNroDocumentoDataGridViewTextBoxColumn
        '
        Me.PNroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "pNroDocumento"
        Me.PNroDocumentoDataGridViewTextBoxColumn.HeaderText = "pNroDocumento"
        Me.PNroDocumentoDataGridViewTextBoxColumn.Name = "PNroDocumentoDataGridViewTextBoxColumn"
        '
        'PIdTipoDocumentoDataGridViewTextBoxColumn
        '
        Me.PIdTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "pIdTipoDocumento"
        Me.PIdTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "pIdTipoDocumento"
        Me.PIdTipoDocumentoDataGridViewTextBoxColumn.Name = "PIdTipoDocumentoDataGridViewTextBoxColumn"
        '
        'PNombreLegalDataGridViewTextBoxColumn
        '
        Me.PNombreLegalDataGridViewTextBoxColumn.DataPropertyName = "pNombreLegal"
        Me.PNombreLegalDataGridViewTextBoxColumn.HeaderText = "pNombreLegal"
        Me.PNombreLegalDataGridViewTextBoxColumn.Name = "PNombreLegalDataGridViewTextBoxColumn"
        '
        'PNombreComercialDataGridViewTextBoxColumn
        '
        Me.PNombreComercialDataGridViewTextBoxColumn.DataPropertyName = "pNombreComercial"
        Me.PNombreComercialDataGridViewTextBoxColumn.HeaderText = "pNombreComercial"
        Me.PNombreComercialDataGridViewTextBoxColumn.Name = "PNombreComercialDataGridViewTextBoxColumn"
        '
        'PDireccionDataGridViewTextBoxColumn
        '
        Me.PDireccionDataGridViewTextBoxColumn.DataPropertyName = "pDireccion"
        Me.PDireccionDataGridViewTextBoxColumn.HeaderText = "pDireccion"
        Me.PDireccionDataGridViewTextBoxColumn.Name = "PDireccionDataGridViewTextBoxColumn"
        '
        'PUrbanizacionDataGridViewTextBoxColumn
        '
        Me.PUrbanizacionDataGridViewTextBoxColumn.DataPropertyName = "pUrbanizacion"
        Me.PUrbanizacionDataGridViewTextBoxColumn.HeaderText = "pUrbanizacion"
        Me.PUrbanizacionDataGridViewTextBoxColumn.Name = "PUrbanizacionDataGridViewTextBoxColumn"
        '
        'PCorreoElectronicoDataGridViewTextBoxColumn
        '
        Me.PCorreoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "pCorreoElectronico"
        Me.PCorreoElectronicoDataGridViewTextBoxColumn.HeaderText = "pCorreoElectronico"
        Me.PCorreoElectronicoDataGridViewTextBoxColumn.Name = "PCorreoElectronicoDataGridViewTextBoxColumn"
        '
        'PIdUbigeoDataGridViewTextBoxColumn
        '
        Me.PIdUbigeoDataGridViewTextBoxColumn.DataPropertyName = "pIdUbigeo"
        Me.PIdUbigeoDataGridViewTextBoxColumn.HeaderText = "pIdUbigeo"
        Me.PIdUbigeoDataGridViewTextBoxColumn.Name = "PIdUbigeoDataGridViewTextBoxColumn"
        '
        'PUbigeoDataGridViewTextBoxColumn
        '
        Me.PUbigeoDataGridViewTextBoxColumn.DataPropertyName = "pUbigeo"
        Me.PUbigeoDataGridViewTextBoxColumn.HeaderText = "pUbigeo"
        Me.PUbigeoDataGridViewTextBoxColumn.Name = "PUbigeoDataGridViewTextBoxColumn"
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 213)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtParam)
        Me.Controls.Add(Me.dgvEmpresa)
        Me.Name = "frmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmpresa"
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents txtParam As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents EmisorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceptorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNroDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIdTipoDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNombreLegalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNombreComercialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUrbanizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCorreoElectronicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIdUbigeoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUbigeoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
