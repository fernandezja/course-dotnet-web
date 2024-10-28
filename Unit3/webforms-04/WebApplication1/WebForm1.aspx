<%@ Page Language="C#" 
         AutoEventWireup="true" 
         CodeBehind="WebForm1.aspx.cs" 
         Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Webform1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Webform1</h1>
        </div>

        <h2>Titulo 2</h2>

        <p>
            <label>Name 1:</label>
            <input type="text" id="txtName1" value="" runat="server" />

            <br />

            <label>Name 2:</label>
            <asp:TextBox ID="txtName2" runat="server"></asp:TextBox>


            <br />
            <asp:Button ID="btnEnviar" runat="server" 
                        Text="Enviar" 
                        OnClick="btnEnviar_Click" />
        </p>
        <p>
            <asp:ListBox ID="listItems" runat="server" Height="179px" Width="222px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>

        
        Item Seleccionado: 
        <asp:Label ID="lblItemSeleccionado" runat="server" Text="Label"></asp:Label></form>
</body>
</html>
