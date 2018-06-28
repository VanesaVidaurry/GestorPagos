<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frm_pagos.aspx.vb" Inherits="frm_pagos" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
    
        ID
        <br />
        
        <asp:Label ID="Lbl_ID" runat="server"></asp:Label>
        <br />
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
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" Height="32px" Width="178px">
            <Items>
                <dx:ListEditItem Text="Diario" Value="Diario" />
                <dx:ListEditItem Text="Semanal" Value="Semanal" />
                <dx:ListEditItem Text="Mensual" Value="Mensual" />
                <dx:ListEditItem Text="Anual" Value="Anual" />
                <dx:ListEditItem Text="Personalizado" Value="Personalizado" />
            </Items>
        </dx:ASPxComboBox>
        <br />
        <br />
        Fecha de Pago<br />
        <asp:TextBox ID="TXT_FechaPago" runat="server"></asp:TextBox>
        <br />
        <br />
        Pagado<dx:ASPxComboBox ID="Cbx_EstatusPago" runat="server" Height="30px" Width="184px">
            <Items>
                <dx:ListEditItem Text="Si" Value="1" />
                <dx:ListEditItem Text="No" Value="0" />
            </Items>
        </dx:ASPxComboBox>
        <br />
        &nbsp;<br />
        Persona Pago<br />
        <asp:TextBox ID="TXT_PersonaPago" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <br />
        <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" />
        <br />
    
    </div>
    </form>
</body>
</html>