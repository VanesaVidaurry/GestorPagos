<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_pagos.aspx.vb" Inherits="frm_pagos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ID<br />
        <asp:TextBox ID="TXT_IdPago" runat="server"></asp:TextBox>
        <br />
        <br />
        Detalle<br />
        <asp:TextBox ID="TXT_Detalle" runat="server"></asp:TextBox>
        <br />
        <br />
        Tipo de Pago<br />
        <asp:TextBox ID="TXT_TipoPago" runat="server"></asp:TextBox>
        <br />
        <br />
        Empresa<br />
        <asp:TextBox ID="TXT_Empresa" runat="server"></asp:TextBox>
        <br />
        <br />
        Beneficiario<br />
        <asp:TextBox ID="TXT_Beneficiario" runat="server"></asp:TextBox>
        <br />
        <br />
        Periodo de Pago<br />
        <asp:DropDownList ID="LIST_PeriodoPago" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Fecha de Pago<br />
        <asp:TextBox ID="TXT_FechaPago" runat="server"></asp:TextBox>
        <br />
        <br />
        Pagado<br />
        <asp:TextBox ID="TXT_Pagado" runat="server"></asp:TextBox>
        <br />
        <br />
        Persona Pago<br />
        <asp:TextBox ID="TXT_PersonaPago" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>