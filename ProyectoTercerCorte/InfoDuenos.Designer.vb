<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoDuenos
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
        Me.addUser = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTorre = New System.Windows.Forms.TextBox()
        Me.TypeAccount = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.AppConjuntoPagos = New System.Windows.Forms.Label()
        Me.DataUsers = New System.Windows.Forms.DataGridView()
        Me.addUser.SuspendLayout()
        CType(Me.DataUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addUser
        '
        Me.addUser.Controls.Add(Me.Label2)
        Me.addUser.Controls.Add(Me.txtApto)
        Me.addUser.Controls.Add(Me.Label3)
        Me.addUser.Controls.Add(Me.txtTorre)
        Me.addUser.Controls.Add(Me.TypeAccount)
        Me.addUser.Controls.Add(Me.btnGuardar)
        Me.addUser.Controls.Add(Me.Label1)
        Me.addUser.Controls.Add(Me.txtContrasena)
        Me.addUser.Controls.Add(Me.lblUsername)
        Me.addUser.Controls.Add(Me.txtUsername)
        Me.addUser.Location = New System.Drawing.Point(25, 55)
        Me.addUser.Name = "addUser"
        Me.addUser.Size = New System.Drawing.Size(750, 95)
        Me.addUser.TabIndex = 7
        Me.addUser.TabStop = False
        Me.addUser.Text = "Agregar nuevo usuario"
        Me.addUser.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apto"
        '
        'txtApto
        '
        Me.txtApto.Location = New System.Drawing.Point(513, 62)
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(88, 23)
        Me.txtApto.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Torre"
        '
        'txtTorre
        '
        Me.txtTorre.Location = New System.Drawing.Point(513, 27)
        Me.txtTorre.Name = "txtTorre"
        Me.txtTorre.Size = New System.Drawing.Size(88, 23)
        Me.txtTorre.TabIndex = 6
        '
        'TypeAccount
        '
        Me.TypeAccount.FormattingEnabled = True
        Me.TypeAccount.Items.AddRange(New Object() {"Dueño", "Administrador"})
        Me.TypeAccount.Location = New System.Drawing.Point(25, 25)
        Me.TypeAccount.Name = "TypeAccount"
        Me.TypeAccount.Size = New System.Drawing.Size(160, 23)
        Me.TypeAccount.TabIndex = 5
        Me.TypeAccount.Text = "Seleccionar tipo usuario"
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
        Me.Label1.Location = New System.Drawing.Point(244, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(319, 61)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(140, 23)
        Me.txtContrasena.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(214, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(93, 15)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Nombre usuario"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(319, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(138, 23)
        Me.txtUsername.TabIndex = 0
        '
        'AppConjuntoPagos
        '
        Me.AppConjuntoPagos.AutoSize = True
        Me.AppConjuntoPagos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AppConjuntoPagos.Location = New System.Drawing.Point(253, 28)
        Me.AppConjuntoPagos.Name = "AppConjuntoPagos"
        Me.AppConjuntoPagos.Size = New System.Drawing.Size(273, 24)
        Me.AppConjuntoPagos.TabIndex = 6
        Me.AppConjuntoPagos.Text = "Tabla de Dueños/Usuarios"
        '
        'DataUsers
        '
        Me.DataUsers.AllowUserToAddRows = False
        Me.DataUsers.AllowUserToDeleteRows = False
        Me.DataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataUsers.Location = New System.Drawing.Point(25, 192)
        Me.DataUsers.Name = "DataUsers"
        Me.DataUsers.ReadOnly = True
        Me.DataUsers.RowTemplate.Height = 25
        Me.DataUsers.Size = New System.Drawing.Size(750, 230)
        Me.DataUsers.TabIndex = 5
        '
        'InfoDuenos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.addUser)
        Me.Controls.Add(Me.AppConjuntoPagos)
        Me.Controls.Add(Me.DataUsers)
        Me.Name = "InfoDuenos"
        Me.Text = "InfoDuenos"
        Me.addUser.ResumeLayout(False)
        Me.addUser.PerformLayout()
        CType(Me.DataUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addUser As GroupBox
    Friend WithEvents TypeAccount As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents AppConjuntoPagos As Label
    Friend WithEvents DataUsers As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTorre As TextBox
End Class
