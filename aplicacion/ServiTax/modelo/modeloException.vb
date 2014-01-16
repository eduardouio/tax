''' <summary>
''' Registra los errores de la capa
''' </summary>
Public Class modeloException
    Inherits ApplicationException

    ''' <summary>
    ''' crea una instacia del error con cadena y ecxepcion en la capa Modelo
    ''' </summary>
    ''' <param name="mensaje">Cadena con el mensaje de error</param>
    ''' <param name="original">La excepcion original</param>
    Public Sub New(ByVal mensaje As String, ByVal original As Exception)
        MyBase.New(mensaje, original)
        MsgBox("Error: " + mensaje + " Mensaje del sistema : " + original.Message())
    End Sub

    ''' <summary>
    ''' Crea una instacia de error solo con la cadena del error
    ''' </summary>
    ''' <param name="mensaje"></param>
    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
        MsgBox("Error: " + mensaje)
    End Sub
End Class
