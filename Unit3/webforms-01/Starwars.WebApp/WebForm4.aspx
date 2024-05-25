<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Starwars.WebApp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    Hola Mundo
     <br />
    
    <input type="type" name="name" value="" />
     <br />
    <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
    
    <br />
    <br />
    
    <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />

                <asp:Button ID="Button3" runat="server" Text="Button3" OnClick="Button3_Click" />

    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            Hola
            <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" />
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        Cargando...
                    </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <br />
</asp:Content>
