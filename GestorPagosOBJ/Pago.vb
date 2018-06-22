''' <summary>
''' Objeto que representa un pago que se realiza de la empresa a un proveedor de servicios.
''' </summary>
Public Class Pago

    ''' <summary>
    ''' Enumerador que enlista los diferentes periodos de pago
    ''' </summary>
    Enum pagoPeriodo
        diario
        semanal
        mensual
        anual
        personalizado
    End Enum

    ''' <summary>
    ''' Enumerador que enlista los tipos de pago
    ''' </summary>
    Enum pagotipo
        servicios
        materialOficina
    End Enum

    ''' <summary>
    ''' Identificador único del pago en el repositorio de información
    ''' </summary>
    ''' <returns></returns>
    Property ID As Decimal

    ''' <summary>
    ''' Detalle o descripción del pago
    ''' </summary>
    ''' <returns></returns>
    Property Detalle As String

    ''' <summary>
    ''' Tipo de pago realizado
    ''' </summary>
    ''' <returns></returns>
    Property TipoPago As pagotipo

    ''' <summary>
    ''' Nombre de la empresa que realiza el pago
    ''' </summary>
    ''' <returns></returns>
    Property Empresa As Empresa

    ''' <summary>
    '''  Empresa beneficiaria del pago
    ''' </summary>
    ''' <returns></returns>
    Property Beneficiario As Empresa

    ''' <summary>
    ''' Periodos disponibles para realizar un pago
    ''' </summary>
    ''' <returns></returns>
    Property PeriodoPago As pagoPeriodo

    ''' <summary>
    ''' Fecha en que se realiza el pago
    ''' </summary>
    ''' <returns></returns>
    Property FechaPago As Date

    ''' <summary>
    ''' Opcion de 
    ''' </summary>
    ''' <returns></returns>
    Property Pagado As Boolean

    ''' <summary>
    ''' Persona que realiza 
    ''' </summary>
    ''' <returns></returns>
    Property PersonaPago As String

End Class



'Class prueba

'Sub hola()

'Dim mypago As New Pago
'mypago.ID = 1
'mypago.PeriodoPago = Pago.pagoPeriodo.mensual
'mypago.Detalle = "Liverpool - sillas"

'Dim lcl_empresa As New Empresa With {.Nombre = "Liverpool"}
'Dim lcl_empresa As New Empresa
'lcl_empresa.Nombre = "Liverpool"

'mypago.Empresa = lcl_empresa

'End Sub
'End Class
