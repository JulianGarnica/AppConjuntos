<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegumientoPagos
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
        Me.SeguimientoPagos = New System.Windows.Forms.Label()
        Me.DataNoticias = New System.Windows.Forms.DataGridView()
        CType(Me.DataNoticias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeguimientoPagos
        '
        Me.SeguimientoPagos.AutoSize = True
        Me.SeguimientoPagos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SeguimientoPagos.Location = New System.Drawing.Point(288, 28)
        Me.SeguimientoPagos.Name = "SeguimientoPagos"
        Me.SeguimientoPagos.Size = New System.Drawing.Size(206, 24)
        Me.SeguimientoPagos.TabIndex = 6
        Me.SeguimientoPagos.Text = "Seguimiento Pagos"
        '
        'DataNoticias
        '
        Me.DataNoticias.AllowUserToAddRows = False
        Me.DataNoticias.AllowUserToDeleteRows = False
        Me.DataNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataNoticias.Location = New System.Drawing.Point(22, 99)
        Me.DataNoticias.Name = "DataNoticias"
        Me.DataNoticias.ReadOnly = True
        Me.DataNoticias.RowTemplate.Height = 25
        Me.DataNoticias.Size = New System.Drawing.Size(750, 300)
        Me.DataNoticias.TabIndex = 5
        '
        'SegumientoPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SeguimientoPagos)
        Me.Controls.Add(Me.DataNoticias)
        Me.Name = "SegumientoPagos"
        Me.Text = "SegumientoPagos"
        CType(Me.DataNoticias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SeguimientoPagos As Label
    Friend WithEvents DataNoticias As DataGridView
End Class
