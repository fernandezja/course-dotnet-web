<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForms4Ajax.aspx.cs" Inherits="Starwars.WebApp.WebForms4Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Ajax con ASP.NET Webforms</h1>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1"  runat="server">
        </asp:ScriptManager>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
         <asp:Button ID="Button1" runat="server" Text="Button 1" OnClick="Button1_Click" />

         <asp:Button ID="Button3" runat="server" Text="Button 3" OnClick="Button3_Click"  />
        <br />
        <br />
        <div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                     Update Panel...<br />
                     <br />
                     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                     <br />
                     <br />
                     <asp:Button ID="Button2" runat="server" Text="Button 2" OnClick="Button2_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
          

        </div>
       
                <p>
                    &nbsp;</p>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
                        </asp:Timer>
                    </ContentTemplate>
                </asp:UpdatePanel>
       
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
