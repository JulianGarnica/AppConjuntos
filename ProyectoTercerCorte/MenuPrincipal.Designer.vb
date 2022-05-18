<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msgBienvenido = New System.Windows.Forms.Label()
        Me.btnNoticias = New System.Windows.Forms.Button()
        Me.btnPagarAdmon = New System.Windows.Forms.Button()
        Me.btnSeguimientoPagos = New System.Windows.Forms.Button()
        Me.btnInfoDuenos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(157, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menú principal  App Conjunto Pagos"
        '
        'msgBienvenido
        '
        Me.msgBienvenido.AutoSize = True
        Me.msgBienvenido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.msgBienvenido.Location = New System.Drawing.Point(348, 50)
        Me.msgBienvenido.Name = "msgBienvenido"
        Me.msgBienvenido.Size = New System.Drawing.Size(87, 16)
        Me.msgBienvenido.TabIndex = 1
        Me.msgBienvenido.Text = "¡Bienvenido!"
        '
        'btnNoticias
        '
        Me.btnNoticias.Location = New System.Drawing.Point(129, 136)
        Me.btnNoticias.Name = "btnNoticias"
        Me.btnNoticias.Size = New System.Drawing.Size(203, 77)
        Me.btnNoticias.TabIndex = 2
        Me.btnNoticias.Text = "Noticias"
        Me.btnNoticias.UseVisualStyleBackColor = True
        '
        'btnPagarAdmon
        '
        Me.btnPagarAdmon.Location = New System.Drawing.Point(463, 136)
        Me.btnPagarAdmon.Name = "btnPagarAdmon"
        Me.btnPagarAdmon.Size = New System.Drawing.Size(203, 77)
        Me.btnPagarAdmon.TabIndex = 3
        Me.btnPagarAdmon.Text = "Pagar Administración"
        Me.btnPagarAdmon.UseVisualStyleBackColor = True
        '
        'btnSeguimientoPagos
        '
        Me.btnSeguimientoPagos.Location = New System.Drawing.Point(129, 261)
        Me.btnSeguimientoPagos.Name = "btnSeguimientoPagos"
        Me.btnSeguimientoPagos.Size = New System.Drawing.Size(203, 77)
        Me.btnSeguimientoPagos.TabIndex = 4
        Me.btnSeguimientoPagos.Text = "Seguimiento Pagos"
        Me.btnSeguimientoPagos.UseVisualStyleBackColor = True
        '
        'btnInfoDuenos
        '
        Me.btnInfoDuenos.Location = New System.Drawing.Point(463, 261)
        Me.btnInfoDuenos.Name = "btnInfoDuenos"
        Me.btnInfoDuenos.Size = New System.Drawing.Size(203, 77)
        Me.btnInfoDuenos.TabIndex = 5
        Me.btnInfoDuenos.Text = "Información de dueños"
        Me.btnInfoDuenos.UseVisualStyleBackColor = True
        Me.btnInfoDuenos.Visible = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInfoDuenos)
        Me.Controls.Add(Me.btnSeguimientoPagos)
        Me.Controls.Add(Me.btnPagarAdmon)
        Me.Controls.Add(Me.btnNoticias)
        Me.Controls.Add(Me.msgBienvenido)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents msgBienvenido As Label
    Friend WithEvents btnNoticias As Button
    Friend WithEvents btnPagarAdmon As Button
    Friend WithEvents btnSeguimientoPagos As Button
    Friend WithEvents btnInfoDuenos As Button
End Class
