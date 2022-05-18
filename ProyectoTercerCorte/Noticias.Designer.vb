<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Noticias
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
        Me.DataNoticias = New System.Windows.Forms.DataGridView()
        Me.AppConjuntoPagos = New System.Windows.Forms.Label()
        Me.addNotice = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.lblTitular = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        CType(Me.DataNoticias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addNotice.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataNoticias
        '
        Me.DataNoticias.AllowUserToAddRows = False
        Me.DataNoticias.AllowUserToDeleteRows = False
        Me.DataNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataNoticias.Location = New System.Drawing.Point(24, 120)
        Me.DataNoticias.Name = "DataNoticias"
        Me.DataNoticias.ReadOnly = True
        Me.DataNoticias.RowTemplate.Height = 25
        Me.DataNoticias.Size = New System.Drawing.Size(750, 300)
        Me.DataNoticias.TabIndex = 0
        '
        'AppConjuntoPagos
        '
        Me.AppConjuntoPagos.AutoSize = True
        Me.AppConjuntoPagos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppConjuntoPagos.Location = New System.Drawing.Point(252, 26)
        Me.AppConjuntoPagos.Name = "AppConjuntoPagos"
        Me.AppConjuntoPagos.Size = New System.Drawing.Size(300, 24)
        Me.AppConjuntoPagos.TabIndex = 2
        Me.AppConjuntoPagos.Text = "Últimas noticias del conjunto"
        '
        'addNotice
        '
        Me.addNotice.Controls.Add(Me.btnGuardar)
        Me.addNotice.Controls.Add(Me.Label1)
        Me.addNotice.Controls.Add(Me.txtContenido)
        Me.addNotice.Controls.Add(Me.lblTitular)
        Me.addNotice.Controls.Add(Me.txtTitular)
        Me.addNotice.Location = New System.Drawing.Point(24, 53)
        Me.addNotice.Name = "addNotice"
        Me.addNotice.Size = New System.Drawing.Size(750, 57)
        Me.addNotice.TabIndex = 4
        Me.addNotice.TabStop = False
        Me.addNotice.Text = "Agregar nueva noticia"
        Me.addNotice.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(657, 25)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contenido"
        '
        'txtContenido
        '
        Me.txtContenido.Location = New System.Drawing.Point(314, 22)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(272, 23)
        Me.txtContenido.TabIndex = 2
        '
        'lblTitular
        '
        Me.lblTitular.AutoSize = True
        Me.lblTitular.Location = New System.Drawing.Point(17, 25)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(40, 15)
        Me.lblTitular.TabIndex = 1
        Me.lblTitular.Text = "Titular"
        '
        'txtTitular
        '
        Me.txtTitular.Location = New System.Drawing.Point(74, 22)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(138, 23)
        Me.txtTitular.TabIndex = 0
        '
        'Noticias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.addNotice)
        Me.Controls.Add(Me.AppConjuntoPagos)
        Me.Controls.Add(Me.DataNoticias)
        Me.Name = "Noticias"
        Me.Text = "Noticias"
        CType(Me.DataNoticias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addNotice.ResumeLayout(False)
        Me.addNotice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataNoticias As DataGridView
    Friend WithEvents AppConjuntoPagos As Label
    Friend WithEvents addNotice As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContenido As TextBox
    Friend WithEvents lblTitular As Label
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents btnGuardar As Button
End Class
