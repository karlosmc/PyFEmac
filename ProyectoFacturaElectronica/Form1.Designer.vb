<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnGenResumen = New System.Windows.Forms.Button()
        Me.txtNroTicket = New System.Windows.Forms.TextBox()
        Me.btnConsultarTicket = New System.Windows.Forms.Button()
        Me.btnGenerarBaja = New System.Windows.Forms.Button()
        Me.btnGenerarNC = New System.Windows.Forms.Button()
        Me.btnGenerarND = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(32, 42)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar FT"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnGenResumen
        '
        Me.btnGenResumen.Location = New System.Drawing.Point(32, 71)
        Me.btnGenResumen.Name = "btnGenResumen"
        Me.btnGenResumen.Size = New System.Drawing.Size(129, 23)
        Me.btnGenResumen.TabIndex = 1
        Me.btnGenResumen.Text = "Generar Resumen"
        Me.btnGenResumen.UseVisualStyleBackColor = True
        '
        'txtNroTicket
        '
        Me.txtNroTicket.Location = New System.Drawing.Point(192, 161)
        Me.txtNroTicket.Name = "txtNroTicket"
        Me.txtNroTicket.Size = New System.Drawing.Size(129, 20)
        Me.txtNroTicket.TabIndex = 2
        '
        'btnConsultarTicket
        '
        Me.btnConsultarTicket.Location = New System.Drawing.Point(192, 71)
        Me.btnConsultarTicket.Name = "btnConsultarTicket"
        Me.btnConsultarTicket.Size = New System.Drawing.Size(129, 23)
        Me.btnConsultarTicket.TabIndex = 3
        Me.btnConsultarTicket.Text = "Consultar Ticket"
        Me.btnConsultarTicket.UseVisualStyleBackColor = True
        '
        'btnGenerarBaja
        '
        Me.btnGenerarBaja.Location = New System.Drawing.Point(32, 103)
        Me.btnGenerarBaja.Name = "btnGenerarBaja"
        Me.btnGenerarBaja.Size = New System.Drawing.Size(129, 23)
        Me.btnGenerarBaja.TabIndex = 4
        Me.btnGenerarBaja.Text = "GenerarBaja (FT)"
        Me.btnGenerarBaja.UseVisualStyleBackColor = True
        '
        'btnGenerarNC
        '
        Me.btnGenerarNC.Location = New System.Drawing.Point(32, 132)
        Me.btnGenerarNC.Name = "btnGenerarNC"
        Me.btnGenerarNC.Size = New System.Drawing.Size(129, 23)
        Me.btnGenerarNC.TabIndex = 5
        Me.btnGenerarNC.Text = "Generar NC"
        Me.btnGenerarNC.UseVisualStyleBackColor = True
        '
        'btnGenerarND
        '
        Me.btnGenerarND.Location = New System.Drawing.Point(32, 161)
        Me.btnGenerarND.Name = "btnGenerarND"
        Me.btnGenerarND.Size = New System.Drawing.Size(129, 23)
        Me.btnGenerarND.TabIndex = 6
        Me.btnGenerarND.Text = "Generar ND"
        Me.btnGenerarND.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 385)
        Me.Controls.Add(Me.btnGenerarND)
        Me.Controls.Add(Me.btnGenerarNC)
        Me.Controls.Add(Me.btnGenerarBaja)
        Me.Controls.Add(Me.btnConsultarTicket)
        Me.Controls.Add(Me.txtNroTicket)
        Me.Controls.Add(Me.btnGenResumen)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnGenResumen As System.Windows.Forms.Button
    Friend WithEvents txtNroTicket As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultarTicket As System.Windows.Forms.Button
    Friend WithEvents btnGenerarBaja As System.Windows.Forms.Button
    Friend WithEvents btnGenerarNC As System.Windows.Forms.Button
    Friend WithEvents btnGenerarND As System.Windows.Forms.Button

End Class
