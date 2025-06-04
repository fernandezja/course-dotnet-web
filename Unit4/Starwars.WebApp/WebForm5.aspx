<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Starwars.WebApp.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            <br />
            <br />
            <asp:TextBox ID="txtDemo" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtDemoApp" runat="server"></asp:TextBox>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" >LinkButton</asp:LinkButton>
        </div>
    </form>
</body>
</html>
