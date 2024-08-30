<%@ Page Language="C#" 
         AutoEventWireup="true" 
         CodeBehind="WebForm1.aspx.cs" 
         Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
             <h1 runat="server" id="h1">Demo 1</h1>

            
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button runat="server" 
                    Text="Hello" ID="btnHello" 
                    OnClick="btnHello_Click"></asp:Button>


            <hr />

      <asp:Calendar runat="server" ID="calendar1"></asp:Calendar>
      <asp:LinkButton runat="server" ID="link1" OnClick="link1_Click">LinkButton</asp:LinkButton>
     
             <br />
             <br />
             <asp:DropDownList ID="DropDownList1" runat="server">
                 <asp:ListItem Value="1">Item 1</asp:ListItem>
                 <asp:ListItem Value="2">Item 2</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:DropDownList ID="DropDownList2" runat="server">
             </asp:DropDownList>
     
             <br />
             <asp:Panel ID="Panel1" runat="server">
                
             </asp:Panel>
            
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
     
        </div>
    </form>
</body>
</html>
