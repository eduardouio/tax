''' <summary>
''' Representa un cliente en el sistema
''' las clase permite administrar los clientes
''' </summary>
Public Class Coustomer
    Private Id_cliente_ As Integer
    Private Apellidos_ As String
    Private Nombres_ As String
    Private Tel1_ As String
    Private Tel2_ As String
    Private Resposable_ As String
    Private Equipo_ As String
    Private Registro_ As DateTime

    ''' <summary>
    ''' Crea una instancia del objeto sin datos
    ''' </summary>
    Public Sub New()
        Me.Id_cliente_ = Nothing
        Me.Apellidos_ = Nothing
        Me.Nombres_ = Nothing
        Me.Tel1_ = Nothing
        Me.Tel2_ = Nothing
        Me.Resposable_ = Nothing
        Me.Equipo_ = Nothing
        Me.Registro_ = Nothing
    End Sub

    ''' <summary>
    ''' Retonr aun objeto con datos
    ''' </summary>
    ''' <param name="id_cliente">Identificador del cliente</param>
    ''' <param name="apellidos">apellidos del cliente</param>
    ''' <param name="nombres">nombres de cliente</param>
    ''' <param name="tel1">Telefrono uno</param>
    ''' <param name="tel2">Telefono 2</param>
    ''' <param name="resposable">nombre del responsable</param>
    ''' <param name="equipo">Nombre del equipo desde el que se hace el registro</param>
    ''' <param name="registro">Fecha exacta del registro en el sistema</param>
    Public Sub New(ByVal id_cliente As String, ByVal apellidos As String, ByVal nombres As String,
                   ByVal tel1 As String, ByVal tel2 As String, ByVal resposable As String, ByVal equipo As String, ByVal registro As DateTime)
        Me.Id_cliente_ = id_cliente
        Me.Apellidos_ = apellidos
        Me.Nombres_ = nombres
        Me.Tel1_ = tel1
        Me.Tel2_ = tel2
        Me.Resposable_ = resposable
        Me.Equipo_ = equipo
        Me.Registro_ = registro
    End Sub

    ''' <summary>
    ''' Propiedad para id cliente
    ''' </summary>
    ''' <value>Id del cliente</value>
    ''' <returns>Id del clienye</returns>
    Public Property id_cliente As Integer
        Get
            Return Me.Id_cliente_
        End Get
        Set(ByVal value As Integer)
            Me.Id_cliente_ = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad para poner los apellidos
    ''' </summary>    
    Public Property apellidos As String
        Get
            Return Me.Apellidos_
        End Get
        Set(ByVal value As String)
            Me.Apellidos_ = value
        End Set
    End Property

    ''' <summary>
    ''' Propieda nombres 
    ''' </summary>    
    Public Property Nombres As String
        Get
            Return Me.Nombres_
        End Get
        Set(ByVal value As String)
            Me.Nombres_ = value
        End Set
    End Property

    ''' <summary>
    ''' Numero de telefono uno
    ''' </summary>    
    Public Property Tel1 As String
        Get
            Return Me.Tel1_
        End Get
        Set(ByVal value As String)
            Me.Tel1_ = value
        End Set
    End Property

    ''' <summary>
    ''' Numero de telefono dos
    ''' </summary>    
    Public Property Tel2 As String
        Get
            Return Me.Tel2_
        End Get
        Set(ByVal value As String)
            Me.Tel2_ = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del responsable que hizo el registro en la base de datos
    ''' </summary>
    Public Property Responsable As String
        Get
            Return Me.Resposable_
        End Get
        Set(ByVal value As String)
            Me.Resposable_ = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del equipo desde el que se hizo el registro
    ''' </summary>    
    Public Property Equipo As String
        Get
            Return Me.Equipo_
        End Get
        Set(ByVal value As String)
            Me.Equipo_ = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha en la que se grabo el registro en la base de datos
    ''' </summary>
    Public Property Registro As String
        Get
            Return Me.Registro_
        End Get
        Set(ByVal value As String)
            Me.Registro_ = value
        End Set
    End Property

End Class