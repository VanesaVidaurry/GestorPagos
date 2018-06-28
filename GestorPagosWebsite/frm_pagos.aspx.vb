Imports GestorPagosOBJ.Pago
Partial Class frm_pagos
    Inherits System.Web.UI.Page


    Protected Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        Dim MiPago As New GestorPagosOBJ.Pago

        MiPago.Detalle = TXT_Detalle.Text
        MiPago.TipoPago = TXT_TipoPago.Text
        MiPago.Empresa = TXT_Empresa.Text
        MiPago.Beneficiario = TXT_Beneficiario.Text
        MiPago.PeriodoPago = Cbx_PeriodoPago.Text
        MiPago.Pagado = Cbx_EstatusPago.Value
        MiPago.PersonaPago = TXT_PersonaPago.Text
        GestorDePagosDAO.PagoDAO.GeneraPagos(MiPago)


    End Sub
End Class
