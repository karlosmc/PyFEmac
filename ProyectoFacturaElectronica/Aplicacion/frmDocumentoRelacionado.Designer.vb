<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentoRelacionado
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
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.TipoDocumentoRelacionadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.DocumentoRelacionadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.TipoDocumentoRelacionadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentoRelacionadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro. Documento"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DocumentoRelacionadoBindingSource, "TipoDocumento", True))
        Me.cboTipoDocumento.DataSource = Me.TipoDocumentoRelacionadoBindingSource
        Me.cboTipoDocumento.DisplayMember = "pDescripcionCompleja"
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(152, 29)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoDocumento.TabIndex = 2
        Me.cboTipoDocumento.ValueMember = "pCodigo"
        '
        'TipoDocumentoRelacionadoBindingSource
        '
        Me.TipoDocumentoRelacionadoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoDocumentoRelacionadosEN)
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentoRelacionadoBindingSource, "NroDocumento", True))
        Me.txtNroDocumento.Location = New System.Drawing.Point(152, 76)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(121, 20)
        Me.txtNroDocumento.TabIndex = 3
        '
        'DocumentoRelacionadoBindingSource
        '
        Me.DocumentoRelacionadoBindingSource.DataSource = GetType(ProyectoFacturaElectronica.DocumentoRelacionado)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(103, 131)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(221, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmDocumentoRelacionado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 182)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNroDocumento)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDocumentoRelacionado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDocumentoRelacionado"
        CType(Me.TipoDocumentoRelacionadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentoRelacionadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents TipoDocumentoRelacionadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocumentoRelacionadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
