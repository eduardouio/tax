Imports MySql.Data.MySqlClient
Imports System.Data
''' <summary>
''' esta clase representa a la base de datos en el sistema
''' ofrece metos de acceso a los datos en la base de datos
''' este software es una emulacion del DCE05 pero para mysql
''' ev_villota@hotmail.es
''' No es la mejor forma de hacerlo pero es la que entiendo
''' </summary>
Public Class Modelo
    Public _conexion As MySqlConnection = Nothing
    Private _Comando As MySqlCommand = Nothing
    Private _Dataadapter As MySqlDataAdapter = Nothing
    Private _CadenaConexion As String

    Public Sub New()
        Configurar()
    End Sub

    ''' <summary>
    ''' en este metodo de la clase establecemos la configuracion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Configurar()
        Try
            Me._CadenaConexion = "server=192.168.0.109;uid=root;pwd=;database=taxService"
        Catch ex As Exception
            Throw New modeloException("Error al cargar la configuracion!", ex)
        End Try
    End Sub

    Public Sub Desconectar()
        If Me._conexion.State.Equals(ConnectionState.Open) Then
            Me._conexion.Close()
        End If
    End Sub

    ''' <summary>
    ''' encagado de armar la conexion a la base de datos
    ''' </summary>
    Public Sub Conectar()
        'primero se comprueba que la cnexion no exists
        If Not Me._conexion Is Nothing Then
            If Not Me._conexion.State.Equals(ConnectionState.Open) Then
                Throw New modeloException("La conexión ya esta abierta.")
            End If
        End If

        Try
            If Me._conexion Is Nothing Then
                Me._conexion = New MySqlConnection()
                Me._conexion.ConnectionString = _CadenaConexion
                Me._conexion.Open()
            End If
        Catch ex As MySqlException
            Throw New modeloException("Error al conectarse", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Se crea un comando del Tipo SQL  
    ''' </summary>
    ''' <param name="sql">Sentencia tipo SQL con formato. SENTENCIA [PARAM=@PARAM]</param>
    Public Sub CrearComando(ByVal sql As String)
        Me._Comando = New MySqlCommand()

        With Me._Comando
            .CommandText = sql
            .Connection = Me._conexion
        End With
        
    End Sub

    ''' <summary>
    ''' funcion que se encarga de asignar y armar bien los parametros en las consultas, para
    ''' (arma una consulta bien echa insert int usuarios (eduardo, vinicio,25.32,""); despues => insert int usuarios ('eduardo', 'vinicio',25.32,null);
    ''' ello separa los parametros y los trata por separado con funciones deribadas
    ''' indice= es la posicion que ocupa la primera letra de la palabra del parametro
    ''' Prefijo= es un substring que tiene la cadena desde 0 hasta la primera letra del parametro
    ''' sujfijo= es un substring que tiene la cadena la ultima letra de la palabra hasta el final del texto
    ''' nos retorna un comando segmentado 
    ''' </summary>
    ''' <param name="nombre">Nombre del Parametro</param>
    ''' <param name="separador">Este separador será agregado al Valor del Parámetro</param>
    ''' <param name="valor">Vaor del parametro</param>
    Private Sub AsignarParametro(ByVal nombre As String, ByVal separador As String, ByVal valor As String)
        Dim indice As Integer = Me._Comando.CommandText.IndexOf(nombre)
        Dim prefijo As String = Me._Comando.CommandText.Substring(0, indice)
        Dim sufijo As String = Me._Comando.CommandText.Substring(indice + nombre.Length)
        Me._Comando.CommandText = prefijo + separador + valor + separador + sufijo
    End Sub

    ''' <summary>
    ''' en una sentencia Sql del tipo update y insert, las mismas
    ''' que reciben los datos de las tablas como parametros 
    ''' insert into usuarios ("eduardo", "", "lokjhmn");
    ''' lo que hace esta funcion es que al parametro "" se le cambien con null
    ''' que dando asi
    ''' insert into usuarios ("eduardo", null, "lokjhmn");
    ''' para hacer el remplazo usa la funcion Asignar Parametro
    ''' lo quehace esta funcion es pasar por parametros por programacion hacia
    ''' la funcion que hace el cambio
    ''' </summary>
    ''' <param name="nombre">parametro cuyo valor sera null</param>
    Public Sub AsignarParametroNulo(ByVal nombre As String)
        AsignarParametro(nombre, "", "Null")
    End Sub

    ''' <summary>
    ''' fncion que asigna un paramerto string a un comando creado
    ''' </summary>
    ''' <param name="nombre">nombre del parametro, o edl segmento ed la cadena</param>
    ''' <param name="valor">valor del parametro</param>
    Public Sub AsignarParametroCadena(ByVal nombre As String, ByVal valor As String)
        AsignarParametro(nombre, "'", valor.ToString())
    End Sub

    ''' <summary>
    ''' funcion que asigna un entero a un comand
    ''' </summary>
    ''' <param name="nombre"> nombre del parametro</param>
    ''' <param name="valor">valor del parametro</param>
    Public Sub AsignarParametroEntero(ByVal nombre As String, ByVal valor As Integer)
        AsignarParametro(nombre, "", valor.ToString())
    End Sub
    ''' <summary>
    ''' funcion que asigna la manera correcta de enviar las fechas al motor si se tiene problema con las fechas modificar aqui
    ''' </summary>
    ''' <param name="nombre">Nombre del Parametro</param>
    ''' <param name="valor">valor del Parametro</param>
    Public Sub AsignarParametroFecha(ByVal nombre As String, ByVal valor As String)
        AsignarParametro(nombre, "", valor.ToString())
    End Sub
    ''' <summary>
    ''' Se ejecuta un comando en la base de datos como el comando ya esta depurado no hay problema
    ''' </summary>
    ''' <returns>Resultado de la consulta</returns>
    '''<exception cref="modeloException">nos ayuda con un error en caso falla la ejecucion del comando</exception>
    Public Function EjecutarConsulta() As MySqlDataReader
        Return Me._Comando.ExecuteReader()
    End Function
    ''' <summary>
    ''' ejecuta un escalar el escalar. Ejecuta la consulta y devuelve la primera columna de la 
    ''' primera fila del conjunto de resultados devuelto por la consulta.
    ''' este escalar se usa porque sabes que tienes que resivir el id de la iutima insercion
    ''' y esto te sirve para luego ingresar datos referenciados a esa tabla
    ''' </summary>
    ''' <returns>escalar</returns>
    ''' <exception cref="modeloException">Te envia un mensaje de error</exception>
    Public Function EjecutarEscalar() As Integer
        Dim escalar As Integer = 0
        Try
            escalar = Integer.Parse(Me._Comando.ExecuteScalar().ToString())
        Catch ex As Exception
            Throw New modeloException("Error al Ejecutar el Escalar", ex)
        End Try
        Return escalar
    End Function

    ''' <summary>
    ''' ejecuta un comando
    ''' </summary>
    Public Sub EjecutarComando()
        Me._Comando.ExecuteNonQuery()
    End Sub

End Class
