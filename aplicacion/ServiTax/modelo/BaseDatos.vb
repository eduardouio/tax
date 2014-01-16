Imports MySql.Data.MySqlClient
Imports System.Data
''' <summary>
''' representa a la base de datos en el sistema
''' </summary>
Public Class BaseDatos
    Protected myCad As String = Nothing
    Protected myConn As MySqlConnection = Nothing
    Protected myCommand As MySqlCommand = Nothing
    Protected myDa As MySqlDataAdapter = Nothing

    ''' <summary>
    ''' Crea una conexion a la base de datos si no existe
    ''' </summary>
    Public Sub New()
        myCad = "server=192.168.0.109;uid=root;pwd=elian;database=taxService"

    End Sub

    ''' <summary>
    ''' Crea un comando en la clase para ejecutar una consulta Eduardo Villota
    ''' </summary>
    ''' <param name="sql">Cadena de consulta SQL</param>
    ''' <remarks></remarks>
    Public Sub createCommand(ByVal sql As String)
        Try
            Me.myCommand = New MySqlCommand()
            Me.myCommand.Connection = Me.myConn
            Me.myCommand.CommandType = CommandType.Text
            Me.myCommand.CommandText = sql
        Catch ex As Exception
            Throw New modeloException("Error para crear el comando de consulta "
        End Try
        
    End Sub

End Class
