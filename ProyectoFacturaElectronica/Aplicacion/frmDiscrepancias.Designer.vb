<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscrepancias
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
        Me.cboTipoDiscrepancia = New System.Windows.Forms.ComboBox()
        Me.txtNroReferencia = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DiscrepanciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDiscrepanciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DiscrepanciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDiscrepanciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nro. Referencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion:"
        '
        'cboTipoDiscrepancia
        '
        Me.cboTipoDiscrepancia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiscrepanciaBindingSource, "Tipo", True))
        Me.cboTipoDiscrepancia.DataSource = Me.TipoDiscrepanciaBindingSource
        Me.cboTipoDiscrepancia.DisplayMember = "pDescripcionCompleja"
        Me.cboTipoDiscrepancia.FormattingEnabled = True
        Me.cboTipoDiscrepancia.Location = New System.Drawing.Point(143, 12)
        Me.cboTipoDiscrepancia.Name = "cboTipoDiscrepancia"
        Me.cboTipoDiscrepancia.Size = New System.Drawing.Size(257, 21)
        Me.cboTipoDiscrepancia.TabIndex = 3
        Me.cboTipoDiscrepancia.ValueMember = "pCodigo"
        '
        'txtNroReferencia
        '
        Me.txtNroReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiscrepanciaBindingSource, "NroReferencia", True))
        Me.txtNroReferencia.Location = New System.Drawing.Point(143, 39)
        Me.txtNroReferencia.Name = "txtNroReferencia"
        Me.txtNroReferencia.Size = New System.Drawing.Size(257, 20)
        Me.txtNroReferencia.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiscrepanciaBindingSource, "Descripcion", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(143, 62)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(257, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(98, 101)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 22)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(259, 101)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 22)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'DiscrepanciaBindingSource
        '
        Me.DiscrepanciaBindingSource.DataSource = GetType(ProyectoFacturaElectronica.Discrepancia)
        '
        'TipoDiscrepanciaBindingSource
        '
        Me.TipoDiscrepanciaBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoDiscrepanciaEN)
        '
        'frmDiscrepancias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 147)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNroReferencia)
        Me.Controls.Add(Me.cboTipoDiscrepancia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDiscrepancias"
        Me.Text = "frmDiscrepancias"
        CType(Me.DiscrepanciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDiscrepanciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDiscrepancia As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TipoDiscrepanciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DiscrepanciaBindingSource As System.Windows.Forms.BindingSource
End Class
