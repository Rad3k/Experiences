<%@ Page Title="Registration" Language="C#" MasterPageFile="~/admin/login.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="rad3k_eu.admin.registration" %>
<asp:Content ID="RegistrationContent" ContentPlaceHolderID="loginScreen" runat="server">
    <p>
        <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameText" runat="server" CssClass="right" MaxLength="30"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label> 
        <asp:TextBox ID="passwordText" runat="server" TextMode="Password" CssClass="right" MaxLength="30"></asp:TextBox>
    </p>
    <asp:Button ID="Registration" runat="server" Text="Sign In" Height="40" Width="250" ToolTip="Registration to system" OnClick="Registration_Click" />
</asp:Content>
