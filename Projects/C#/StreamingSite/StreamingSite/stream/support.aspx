<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="support.aspx.cs" Inherits="rad3k_eu.support" %>
<asp:Content ID="LeftMenu" ContentPlaceHolderID="LeftContent" runat="server">
    <h2><asp:Label ID="podpora" runat="server" Text="podpora"></asp:Label></h2>
    <p><img src="img/fire.gif" class="left" alt="image placeholder" />
        <asp:Label ID="popis" runat="server" Text="text"></asp:Label>
</asp:Content>
<asp:Content ID="RightMenu" ContentPlaceHolderID="RightContent" runat="server">
    <h2><asp:Label ID="odkazy" runat="server" Text="Odkazy"></asp:Label></h2>
    <ul class="links">
        <li><a href="http://www.youtube.com/user/Dragonmawcz?feature=mhee"><asp:Label ID="alias_1" runat="server" Text="alias_1"></asp:Label></a></li>
        <li><a href="http://cs.twitch.tv/achiiles"><asp:Label ID="alias_2" runat="server" Text="alias_2"></asp:Label></a></li>
        <li><a href="https://twitter.com/dragonmawcz"><asp:Label ID="alias_3" runat="server" Text="alias_3"></asp:Label></a></li>
        <li><a href="https://www.facebook.com/groups/282592581872106/"><asp:Label ID="alias_4" runat="server" Text="alias_4"></asp:Label></a></li>														
    </ul>

    <h2><asp:Label ID="support_me" runat="server" Text="podpora"></asp:Label></h2>
    <p><asp:Label ID="text" runat="server" Text="text"></asp:Label></p>
</asp:Content>
