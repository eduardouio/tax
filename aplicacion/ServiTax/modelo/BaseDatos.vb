Imports MySql.Data.MySqlClient
Imports System.Data

''' <summary>
''' representa a la base de datos en el sistema
''' </summary>
Public Class BaseDatos
    Private myCad As String = Nothing
    Private myConn As MySqlConnection = Nothing
    Private myCommand As MySqlCommand = Nothing
    Private myDa As MySqlDataAdapter = Nothing

    ''' <summary>
    ''' Crea una conexion a la base de datos si no existe
    ''' </summary>
    Public Sub New()
        Me.myCad = "server=192.168.0.109;uid=root;pwd=elian;database=taxService"
        Try
            Me.myConn = New MySqlConnection(Me.myCad)
        Catch ex As Exception
            Throw New modeloException("No se puede establecer una conexion con el Servidor el problema es " & ex.Message, ex)
        End Try
    End Sub

    ''' <summary>
    ''' Cierra una conexion
    ''' </summary>
    Public Sub disconnectDB()
        If Not Me.myConn.State.Equals(ConnectionState.Open) Then
            MsgBox("La conexion ya esta Cerrada!", MsgBoxStyle.Exclamation)
        Else
            Me.myConn.Close()
        End If
    End Sub

    ''' <summary>
    ''' Crea un comando ejectutable en la base de datos a partir de
    ''' una query
    ''' </summary>
    ''' <param name="query">Cadena de consulta SQL</param>
    Public Sub createCommand(ByVal query As String)
        Try
            If Not query Is Nothing Then
                Me.myCommand = New MySqlCommand(query, Me.myConn)
            End If
        Catch ex As Exception
            Throw New modeloException("Problemas para crear un comando" & ex.Message, ex)
        End Try

    End Sub


    ''' <summary>
    ''' Ejecuta un comando en la base de datos
    ''' </summary>
    Protected Sub execCommand()
        Try
            If Not Me.myCommand Is Nothing Then
                Me.myCommand.ExecuteNonQuery()
            Else
                Throw New modeloException("Error al crear el comando")
            End If
        Catch ex2 As MySqlException
            Throw New modeloException("La consulta tiene problemas para ejecutarse " & ex2.Message, ex2)
        Catch ex As Exception
            Throw New modeloException("Problemas para intentar ejecutar una consulta" & ex.Message, ex)
        End Try
    End Sub

    ''' <summary>
    ''' Reemplaza los valores de las cadenas SQL 
    ''' </summary>
    ''' <param name="name">Nombre del parametro a reemplazar</param>
    ''' <param name="separator">Separador</param>
    ''' <param name="value">Valor del parametro que se reemplaza</param>
    Private Sub setParam(ByRef name As String, ByVal separator As String, ByVal value As String)
        Dim index As Integer = Me.myCommand.CommandText.IndexOf(name)
        Dim pref As Integer = Me.myCommand.CommandText.Substring(0, index)
        Dim suf As Integer = Me.myCommand.CommandText.Substring(index + name.Length)
        Me.myCommand.CommandText = pref + separator + value + separator + suf
    End Sub


    ''' <summary>
    ''' Asigna un parámetro tipo cadena
    ''' </summary>
    ''' <param name="name">Nombre del parpametro a reemplazar</param>
    ''' <param name="value">Valor del parametro a reemplazar</param>
    Public Sub setSqtringParam(ByVal name As String, ByVal value As String)
        Me.setParam(name, "'", value)
    End Sub


    ''' <summary>
    ''' Asigna un parametro tipo numero a la cadena
    ''' </summary>
    ''' <param name="name">Nombre del parametro a reemplazar</param>
    ''' <param name="value">Valor del parametro a reemplazar</param>
    Public Sub setNumberParam(ByVal name As String, ByVal value As Double)
        Me.setParam(name, "", value)
    End Sub


    ''' <summary>
    ''' Coloca un parametro como nulo
    ''' </summary>
    ''' <param name="name">Nombre del parametroa poner como nulo</param>
    ''' <remarks></remarks>
    Public Sub setNullParam(ByVal name As String)
        Me.setParam(name, "", "NULL")
    End Sub
End Class
