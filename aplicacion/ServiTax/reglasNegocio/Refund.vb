Imports reglasNegocio.Sale

''' <summary>
''' Representa una devolucion de dinero echa a un cliente
''' </summary>
Public Class Refund
    Private venta_ As Sale
    Private nro_cheque_ As String
    Private valor_ As Decimal
    Private entregado_ As Boolean
    Private fecha_entrega_ As DateTime

    ''' <summary>
    ''' Constructor para objeto vacio
    ''' </summary>
    Public Sub New()
        Me.venta_ = Nothing
        Me.nro_cheque_ = Nothing
        Me.valor_ = Nothing
        Me.entregado_ = Nothing
        Me.fecha_entrega_ = Nothing
    End Sub


    ''' <summary>
    ''' Constructor para objeto completo
    ''' </summary>
    ''' <param name="venta">objeto venta</param>
    ''' <param name="nro_cheque">Nro de cheque</param>
    ''' <param name="valor">Valor del cheque</param>
    ''' <param name="entregado">Esta entregado?</param>
    ''' <param name="fecha_entrega">Fecha de entrega</param>
    Public Sub New(ByVal venta As Sale, ByVal nro_cheque As String, ByVal valor As Decimal,
                   ByVal entregado As Boolean, ByVal fecha_entrega As DateTime)
        Me.venta_ = venta
        Me.nro_cheque_ = nro_cheque
        Me.valor_ = valor_
        Me.entregado_ = entregado_
        Me.fecha_entrega_ = fecha_entrega_

    End Sub


    ''' <summary>
    ''' Constructor para objeto completo
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
    ''' Constructor para objeto completo
    ''' </summary>
    Public Property Nro_cheque As String
        Get
            Return Me.nro_cheque_
        End Get
        Set(ByVal value As String)
            Me.nro_cheque_ = value
        End Set
    End Property


    ''' <summary>
    ''' Constructor para objeto completo
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
    ''' Constructor para objeto completo
    ''' </summary>
    Public Property Entregado As Boolean
        Get
            Return Me.entregado_
        End Get
        Set(ByVal value As Boolean)
            Me.entregado_ = value
        End Set
    End Property


    ''' <summary>
    ''' Constructor para objeto completo
    ''' </summary>
    Public Property Fecha_entrega As DateTime
        Get
            Return Me.fecha_entrega_
        End Get
        Set(ByVal value As DateTime)
            Me.fecha_entrega_ = value
        End Set
    End Property

End Class
