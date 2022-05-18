Public Class InfoDuenos

    Private Sub InfoDuenos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim users As DataSet = getUsers()
        If users.Tables(0).Rows.Count > 0 Then
            DataUsers.DataSource = users.Tables(0)
        Else
            DataUsers.DataSource = Nothing
        End If

        If infoUser(1) = "1" Then
            addUser.Visible = True
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim typeUserSelected As String = TypeAccount.SelectedIndex.ToString
        Dim username As String = txtUsername.Text
        Dim contrasena As String = txtContrasena.Text
        Dim torre As String = txtTorre.Text
        Dim apto As String = txtApto.Text

        addNewUser(typeUserSelected, username, contrasena, torre, apto)
        Me.Controls.Clear()
        InitializeComponent()
        InfoDuenos_Load(e, e)
    End Sub


End Class