Public Class PagoDAO

    Public Shared Function GeneraPagos(MiPago As GestorPagosOBJ.Pago)

        Try
            'SE OBTIENE LA CADENA DE CONEXION
            Dim CS As String = "Data Source=Dell; Initial Catalog=GestorDePagos; Integrated Security=True"
            'SE OBTIENE EL NOMBRE DEL STORE PROCEDURE QUE GENERA EL PAGO
            Dim SP_comando As String = "SP_Pagos"
            'SE DECLARA LA LISTA DE PARAMETROS PARA EL SP
            Dim ListaParametros As New List(Of H_SQLDB.MSSQL.SqlParam)
            'SE AGREGAN LOS PARAMETROS 
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@Accion", 1, SqlDbType.Int))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cDetalle", MiPago.Detalle, SqlDbType.Text))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cTipo", MiPago.TipoPago, SqlDbType.Text))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cEmpresaPago", MiPago.Empresa, SqlDbType.Text))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cEmpresaBeneficiaria", MiPago.Beneficiario, SqlDbType.Text))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cPeriodoPago", MiPago.PeriodoPago, SqlDbType.Text))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cEstutusPago", MiPago.Pagado, SqlDbType.Int))
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@cPersonaPago", MiPago.PersonaPago, SqlDbType.Text))
            'Se ejecuta el comando de base de datos.
            Dim SP As Integer = H_SQLDB.MSSQL.ejecutaComando(CS, H_SQLDB.MSSQL.generaCommand("SP_Pagos", CommandType.StoredProcedure, ListaParametros))
            'Procedimiento que arroja un mensaje cuando ay un error.
        Catch ex As Exception
            Err.Raise(50001, "frm_pagos.Btn_GuardaPago_Click().ejecutaComando()", "Error al ejecutar el procedimiento en la base de datos: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MiPago"></param>
    ''' <returns></returns>
    Public Shared Function MuestraPagos(MiPago As GestorPagosOBJ.Pago) As DataTable
        Try

            'SE CREA LA TABLA PARA PODER OBTENER 
            Dim Tabla As DataTable = Nothing
            'SE OBTIENE LA CADENA DE CONEXION
            Dim CS As String = "Data Source=Dell; Initial Catalog=GestorDePagos; Integrated Security=True"
            'SE OBTIENE EL NOMBRE DEL STORE PROCEDURE QUE GENERA EL PAGO
            Dim SP_comando As String = "SP_Pagos"
            'SE DECLARA LA LISTA DE PARAMETROS PARA EL SP
            Dim ListaParametros As New List(Of H_SQLDB.MSSQL.SqlParam)
            'SE AGREGAN LOS PARAMETROS 
            ListaParametros.Add(New H_SQLDB.MSSQL.SqlParam("@Accion", 2, SqlDbType.Int))

            'Se ejecuta el comando de base de datos.
            Return H_SQLDB.MSSQL.obtenerDataTable(CS, H_SQLDB.MSSQL.generaCommand("SP_Pagos", CommandType.StoredProcedure, ListaParametros))
            'Procedimiento que arroja un mensaje cuando ay un error.
        Catch ex As Exception
            Err.Raise(50001, "frm_pagos.Btn_consutar_Click().obtenerDataTable()", "Error al ejecutar el procedimiento en la base de datos: " & ex.Message)
        End Try
    End Function


End Class
