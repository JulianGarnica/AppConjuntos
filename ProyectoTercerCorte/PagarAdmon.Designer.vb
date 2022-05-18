<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarAdmon
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
        Me.AppConjuntoPagos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorPagar = New System.Windows.Forms.TextBox()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AppConjuntoPagos
        '
        Me.AppConjuntoPagos.AutoSize = True
        Me.AppConjuntoPagos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppConjuntoPagos.Location = New System.Drawing.Point(292, 57)
        Me.AppConjuntoPagos.Name = "AppConjuntoPagos"
        Me.AppConjuntoPagos.Size = New System.Drawing.Size(224, 24)
        Me.AppConjuntoPagos.TabIndex = 3
        Me.AppConjuntoPagos.Text = "Pagar administración"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(355, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Valor a pagar"
        '
        'txtValorPagar
        '
        Me.txtValorPagar.AccessibleDescription = ""
        Me.txtValorPagar.AccessibleName = ""
        Me.txtValorPagar.Location = New System.Drawing.Point(305, 180)
        Me.txtValorPagar.Name = "txtValorPagar"
        Me.txtValorPagar.Size = New System.Drawing.Size(197, 23)
        Me.txtValorPagar.TabIndex = 5
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(305, 252)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(197, 67)
        Me.btnPagar.TabIndex = 7
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'PagarAdmon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValorPagar)
        Me.Controls.Add(Me.AppConjuntoPagos)
        Me.Name = "PagarAdmon"
        Me.Text = "PagarAdmon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AppConjuntoPagos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorPagar As TextBox
    Friend WithEvents btnPagar As Button
End Class
