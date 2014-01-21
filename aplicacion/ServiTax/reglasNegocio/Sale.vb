Imports reglasNegocio.Coustomer
''' <summary>
''' Representa un venta en el sistema, la venta se hace una a un cliente
''' </summary>
Public Class Sale
    Private nro_factura_ As Integer
    Private cliente_ As Coustomer
    Private responsable_ As String
    Private fecha_venta_ As Date
    Private tipo_registro_ As String
    Private tiempo_retorno_ As Date
    Private valor_ As Decimal
    Private comision_ As Decimal
    Private observacion_ As String
    Private equipo_ As String
    Private registro_ As DateTime

    ''' <summary>
    ''' Crea una factura vacia
    ''' </summary>

    Sub New()
        Me.nro_factura_ = Nothing
        Me.cliente_ = Nothing
        Me.responsable_ = Nothing
        Me.fecha_venta_ = Nothing
        Me.tipo_registro_ = Nothing
        Me.tiempo_retorno_ = Nothing
        Me.valor_ = Nothing
        Me.comision_ = Nothing
        Me.observacion_ = Nothing
        Me.equipo_ = Nothing
        Me.registro_ = Nothing
    End Sub


    Sub New(ByVal nro_factura As Integer, ByVal cliente As Coustomer, ByVal responsable As String, ByVal fecha_venta As Date,
            ByVal tipo_registro As String, ByVal tiempo_retorno As String, ByVal valor As Decimal, ByVal comision As Decimal,
            ByVal observacion As String, ByVal equipo As String, ByVal registro As DateTime)
        Me.nro_factura_ = nro_factura
        Me.cliente_ = cliente
        Me.responsable_ = responsable
        Me.fecha_venta_ = fecha_venta
        Me.tipo_registro_ = tipo_registro
        Me.tiempo_retorno_ = tiempo_retorno
        Me.valor_ = valor
        Me.comision_ = comision
        Me.observacion_ = observacion
        Me.equipo_ = equipo
        Me.registro_ = registro

    End Sub

    ''' <summary>
    ''' Numero de la factura
    ''' </summary>    
    Private Property Nro_Factura As Integer
        Get
            Return Me.nro_factura_
        End Get
        Set(ByVal value As Integer)
            Me.nro_factura_ = value
        End Set
    End Property

    ''' <summary>
    ''' Objeto tipo cliente
    ''' </summary>    
    Public Property Cliente As Coustomer
        Get
            Return Me.cliente_
        End Get
        Set(ByVal value As Coustomer)
            Me.cliente_ = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del responsable del registro
    ''' </summary>    
    Public Property Responsable As String
        Get
            Return Me.responsable_
        End Get
        Set(ByVal value As String)
            Me.responsable_ = value
        End Set
    End Property


    ''' <summary>
    ''' Fecha de venta
    ''' </summary>    
    Public Property Fecha_venta As Date
        Get
            Return Me.fecha_venta_
        End Get
        Set(ByVal value As Date)
            Me.fecha_venta_ = value
        End Set
    End Property


    ''' <summary>
    ''' Tipo de venta
    ''' </summary>    
    Public Property Tipo_registro As String
        Get
            Return Me.tipo_registro_
        End Get
        Set(ByVal value As String)
            Me.tipo_registro_ = value
        End Set
    End Property

    ''' <summary>
    ''' Tiempo de retorna AFG
    ''' </summary>    
    Public Property Tiempo_retorno As Date
        Get
            Return Me.tiempo_retorno_
        End Get
        Set(ByVal value As Date)
            Me.tiempo_retorno_ = value
        End Set
    End Property

    ''' <summary>
    ''' Valor a Neto Retornar
    ''' </summary>    
    Public Property Valor As Decimal
        Get
            Return Me.valor_
        End Get
        Set(ByVal value As Decimal)
            Me.valor_ = value
        End Set
    End Property

    ''' <summary>
    ''' Comision a cobrar
    ''' </summary>    
    Public Property Comision As Decimal
        Get
            Return Me.comision_
        End Get
        Set(ByVal value As Decimal)
            Me.comision_ = value
        End Set
    End Property

    ''' <summary>
    ''' Notas
    ''' </summary>    
    Public Property Observacion As String
        Get
            Return Me.observacion_
        End Get
        Set(ByVal value As String)
            Me.observacion_ = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre del equipo desde el que se hace ekl registro
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
    ''' fecha y hora del registro
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
