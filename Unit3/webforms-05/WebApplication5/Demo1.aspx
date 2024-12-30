<%@ Page Language="C#" 
         AutoEventWireup="true" 
         CodeBehind="Demo1.aspx.cs" Inherits="WebApplication5.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Demo 1 </h1>
            <asp:Button ID="btn1" runat="server" Text="Button" 
                        OnClick="btn1_Click" />
            <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>

            <hr />

            <input type="text" name="txt1" value="" />
            <br />
            <asp:TextBox ID="txt2" runat="server"></asp:TextBox>

            <hr />
            <asp:ListBox ID="ListBox1" runat="server">
               
            </asp:ListBox>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

            <br />
            <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
            <br />
             <asp:Label ID="lblSeleccion" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
