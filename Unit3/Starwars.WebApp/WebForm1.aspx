<%@ Page Language="C#" 
        AutoEventWireup="true" 
        CodeBehind="WebForm1.aspx.cs" 
        Inherits="Starwars.WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" name="txtName" id="txtName" runat="server" />
            <input type="text" name="txtEmail" id="txtEmail" runat="server" />

            <br />
            Coleccion de webcontrols mismo ID (no recomendado)
            <%
                for (int i = 0; i < 10; i++)
                {
                    %>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <%
                }

            %>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button 1" />
            <br />
               <asp:Button ID="Button2" runat="server" Text="Button 2" />
            <br />
        </div>

        

       <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
         
</body>
</html>
