<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosAdicionales
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
        Me.cboCodigo = New System.Windows.Forms.ComboBox()
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.DatoAdicionalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDatoAdicionalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.DatoAdicionalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDatoAdicionalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contenido"
        '
        'cboCodigo
        '
        Me.cboCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCodigo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DatoAdicionalBindingSource, "Codigo", True))
        Me.cboCodigo.DataSource = Me.TipoDatoAdicionalBindingSource
        Me.cboCodigo.DisplayMember = "pDescripcionCompleja"
        Me.cboCodigo.FormattingEnabled = True
        Me.cboCodigo.Location = New System.Drawing.Point(118, 12)
        Me.cboCodigo.Name = "cboCodigo"
        Me.cboCodigo.Size = New System.Drawing.Size(315, 21)
        Me.cboCodigo.TabIndex = 2
        Me.cboCodigo.ValueMember = "pCodigo"
        '
        'txtContenido
        '
        Me.txtContenido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatoAdicionalBindingSource, "Contenido", True))
        Me.txtContenido.Location = New System.Drawing.Point(118, 46)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(155, 20)
        Me.txtContenido.TabIndex = 3
        '
        'DatoAdicionalBindingSource
        '
        Me.DatoAdicionalBindingSource.DataSource = GetType(ProyectoFacturaElectronica.DatoAdicional)
        '
        'TipoDatoAdicionalBindingSource
        '
        Me.TipoDatoAdicionalBindingSource.DataSource = GetType(ProyectoFacturaElectronica.TipoDatoAdicionalesEN)
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(94, 105)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(245, 105)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmDatosAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 162)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtContenido)
        Me.Controls.Add(Me.cboCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDatosAdicionales"
        Me.Text = "frmDatosAdicionales"
        CType(Me.DatoAdicionalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDatoAdicionalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatoAdicionalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox
    Friend WithEvents TipoDatoAdicionalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
