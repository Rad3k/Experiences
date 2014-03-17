<%@ Page Title="Login In" Language="C#" MasterPageFile="~/admin/login.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rad3k_eu.admin.login1" %>
<asp:Content ID="loginSite" ContentPlaceHolderID="loginScreen" runat="server">
    <p>
        <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameText" runat="server" CssClass="right" MaxLength="30"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label> 
        <asp:TextBox ID="passwordText" runat="server" TextMode="Password" CssClass="right" MaxLength="30"></asp:TextBox>
    </p>
    <asp:Button ID="Login" runat="server" Text="Login" Height="40" Width="250" ToolTip="Login to system" OnClick="Login_Click" />
</asp:Content>
