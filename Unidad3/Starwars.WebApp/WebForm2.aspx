<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Starwars.WebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            
            <asp:Button runat="server" 
                         Text="Enviar" 
                        ID="btnEnviar" 
                         OnClick="btnEnviar_Click"></asp:Button>
        </div>
        <div class="">&nbsp;</div>
        <div class="">&nbsp;</div>

            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

        
        <div class="">
            <asp:Button runat="server" Text="Button" OnClick="Unnamed3_Click"></asp:Button>&nbsp;</div>
        <div class="">&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
