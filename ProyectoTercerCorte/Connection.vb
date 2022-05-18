Imports System.Data
Imports System.Data.OleDb
Module Connection
    Public Connection As New OleDbConnection
    Public dr As OleDbDataReader
    Public infoUser(5) As String

    Public Sub OpenConnection()
        Try
            Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source='D:\Programación\VS\ProyectoTercerCorte\BD_AppConjunto.accdb'"
            Connection.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a BD: " + ex.Message, vbCritical, "Aviso")
        End Try

    End Sub

    Public Function login(Username As String, Password As String) As Boolean
        Try
            Dim stringQuery As String = "SELECT * FROM tb_Users WHERE Username='" & Username & "' AND UserPassword='" & Password & "'"
            Dim query As New OleDbCommand(stringQuery, Connection)
            dr = query.ExecuteReader()
            Dim responseQuery = dr.Read()

            If responseQuery = True Then
                infoUser(0) = dr("Id")
                infoUser(1) = dr("TypeAccount")
                infoUser(2) = dr("Username")
                infoUser(3) = dr("UserPassword")
                infoUser(4) = dr("NumberBuilding")
                infoUser(5) = dr("NumberApartment")
                'MsgBox("¡Usuario encontrado, iniciando sesión!", vbInformation, "Aviso")
                Return True
            End If

            MsgBox("¡El usuario no es válido! ", vbCritical, "Aviso")

        Catch ex As Exception
            MsgBox("Error al consultar en bd: " & ex.Message, vbCritical, "Aviso")
        End Try

        Return False
    End Function

    Public Function getNews() As DataSet
        Dim stringQuery As String = "SELECT * FROM tb_News"
        Dim query As New OleDbDataAdapter(stringQuery, Connection)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds
    End Function

    Public Function getPayments(idUser As String) As DataSet
        Dim stringQuery As String
        If (idUser = "-1") Then
            stringQuery = "SELECT * FROM tb_AdministrationPayments"
        Else
            stringQuery = "SELECT * FROM tb_AdministrationPayments WHERE IdUser=" & idUser
        End If

        Dim query As New OleDbDataAdapter(stringQuery, Connection)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds
    End Function

    Public Function getUsers() As DataSet
        Dim stringQuery = "SELECT * FROM tb_Users"
        Dim query As New OleDbDataAdapter(stringQuery, Connection)
        Dim ds As New DataSet
        query.Fill(ds)
        Return ds
    End Function

    Public Sub addNews(HeadLine As String, Content As String)
        Try
            Dim timeNow = Format(Now, “dd-mm-yyyy”)
            Dim stringQuery As String = "INSERT INTO tb_News(Headline, Content, DateTimeNews) VALUES(" _
                & "'" & HeadLine & "'," _
                & "'" & Content & "'," _
                & "'" & timeNow.ToString & "')"
            Dim query As New OleDbCommand(stringQuery, Connection)
            query.ExecuteNonQuery()

            MsgBox("¡Noticia agregada con éxito!", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("Error al insertar dato: " + ex.Message, vbCritical, "Aviso")
        End Try
    End Sub

    Public Sub addPayment(Cost As Double, IdUser As Integer)
        Try
            Dim timeNow = Format(Now, “dd-mm-yyyy”)
            Dim stringQuery As String = "INSERT INTO tb_AdministrationPayments(PaymentDate, IdUser, Cost) VALUES(" _
                & "'" & timeNow.ToString & "'," _
                & "" & IdUser & "," _
                & "" & Cost & ")"
            Dim query As New OleDbCommand(stringQuery, Connection)
            query.ExecuteNonQuery()

            MsgBox("¡Pago agregado con éxito!", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("Error al insertar dato: " + ex.Message, vbCritical, "Aviso")
        End Try
    End Sub
    Public Sub addNewUser(typeAccount As String, Username As String, Password As String, NumberBuilding As String, NumberApartment As String)
        Try

            Dim stringQuery As String = "INSERT INTO tb_Users(TypeAccount, Username, UserPassword, NumberBuilding, NumberApartment) VALUES(" _
                & "'" & typeAccount & "'," _
                & "'" & Username & "'," _
                & "'" & Password & "'," _
                & "'" & NumberBuilding & "'," _
                & "'" & NumberApartment & "')"
            Dim query As New OleDbCommand(stringQuery, Connection)
            query.ExecuteNonQuery()

            MsgBox("¡Usuario agregado con éxito!", vbInformation, "Aviso")
        Catch ex As Exception
            MsgBox("Error al insertar dato: " + ex.Message, vbCritical, "Aviso")
        End Try
    End Sub
End Module
