Imports reglasNegocio.Sale

''' <summary>
''' Representa el proceso de una venta
''' el proceso de la venta el el tiempo que toma realizar l el seguimiento del
''' tramite para la devolucion de los impuestos
''' </summary>
Public Class Processed
    Private venta_ As Sale
    Private estado_ As String
    Private resposable_ As String
    Private notas_ As String
    Private equipo_ As String
    Private registro_ As DateTime

    ''' <summary>
    ''' Cionstructor que retorna un objeto vacio
    ''' </summary>
    Public Sub New()
        Me.venta_ = Nothing
        Me.estado_ = Nothing
        Me.resposable_ = Nothing
        Me.notas_ = Nothing
        Me.equipo_ = Nothing
        Me.registro_ = Nothing
    End Sub


    ''' <summary>
    ''' Constructor que retorna un objeto completo
    ''' </summary>
    ''' <param name="venta">objeto venta</param>
    ''' <param name="estado">Estado del tramite</param>
    ''' <param name="responsable">Reposable del tramite</param>
    ''' <param name="notas">Notas del tramite</param>
    ''' <param name="equipo">Nombre del equipo desde el que se hace el registro</param>
    ''' <param name="registro">Fecha exacta del registro</param>
    Public Sub New(ByVal venta As Sale, ByVal estado As String, ByVal responsable As String, ByVal notas As String,
                   ByVal equipo As String, ByVal registro As DateTime)
        Me.venta_ = venta
        Me.estado_ = estado
        Me.resposable_ = responsable
        Me.notas_ = notas
        Me.equipo_ = equipo
        Me.registro_ = registro
    End Sub

    ''' <summary>
    ''' Objeto tipo venta
    ''' </summary>    
    Public Property Venta As Sale
        Get
            Return Me.venta_
        End Get
        Set(ByVal value As Sale)
            Me.venta_ = value
        End Set
    End Property

    ''' <summary>
    ''' Objeto tipo venta
    ''' </summary>
    Public Property Estado As String
        Get
            Return Me.estado_
        End Get
        Set(ByVal value As String)
            Me.estado_ = value
        End Set
    End Property

    ''' <summary>
    ''' Objeto tipo venta
    ''' </summary>
    Public Property Responsable As String
        Get
            Return Me.resposable_
        End Get
        Set(ByVal value As String)
            Me.resposable_ = value
        End Set
    End Property

    ''' <summary>
    ''' Objeto tipo venta
    ''' </summary>
    Public Property Notas As String
        Get
            Return Me.notas_
        End Get
        Set(ByVal value As String)
            Me.notas_ = value
        End Set
    End Property

    ''' <summary>
    ''' Objeto tipo venta
    ''' </summary>
    Public Property Equipo As String
        Get
            Return Me.equipo_
        End Get
        Set(ByVal value As String)
            Me.equipo_ = value
        End Set
    End Property

    ''' <summary>
    ''' Objeto tipo venta
    ''' </summary>
    Public Property Registro As DateTime
        Get
            Return Me.registro_
        End Get
        Set(ByVal value As DateTime)
            Me.registro_ = value
        End Set
    End Property
    


End Class
