<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="WebParametros._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta con parametros</title>
</head>
<body>
    <h1>Consulta con parametros</h1>
    <form id="form1" runat="server">
        <div>





            <asp:Label ID="Label1" runat="server" Text="Codigo de Cliente"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label4" runat="server" Text="Codigo de distrito"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            
            <br />
            <br />
             <asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <br />
            <br />
             <asp:Label ID="Label6" runat="server" Text="DNI"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label7" runat="server" Text="Ruc"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label9" runat="server" Text="Celular"></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>






            <br />
            <br />
            <br />






        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
