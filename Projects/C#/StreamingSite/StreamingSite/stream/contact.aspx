<%@ Page Title="Contact" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="rad3k_eu.contact" %>
<asp:Content ID="RightLinks" ContentPlaceHolderID="LeftContent" runat="server">
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
<asp:Content ID="FormContent" ContentPlaceHolderID="RightContent" runat="server">
    <h2><asp:Label ID="nadpis" runat="server" Text="nadpis"></asp:Label></h2>
    <asp:Label ID="popis" runat="server" Text="text"></asp:Label><br/>
    <asp:Panel ID="contactForm" runat="server" BorderStyle="Groove">
        <div id="contact">
            <asp:Label ID="informationLabel" runat="server" Text="Kontaktní formulář" Font-Bold="True" CssClass="text"></asp:Label>          
            <p>
                <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="nameText" runat="server" MaxLength="30" Width="185" CssClass="right"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="emailText" runat="server" MaxLength="30" Width="185" CssClass="right"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="subjectLabel" runat="server" Text="Subject"></asp:Label>
                <asp:DropDownList ID="type" runat="server" style="width: 202px; float: right;">
                    <asp:ListItem>Otázka</asp:ListItem>
                    <asp:ListItem>Žádost</asp:ListItem>
                    <asp:ListItem>Ohlášení chyb</asp:ListItem>
                    <asp:ListItem>Jiné</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="messageLabel" runat="server" Text="Message"></asp:Label>
                <asp:TextBox ID="messageText" runat="server" MaxLength="255" Height="200" TextMode="MultiLine" Width="185" CssClass="right"></asp:TextBox>
            </p>
            <p><asp:Button ID="sendEmail" runat="server" Text="Send" BorderStyle="NotSet" Font-Bold="True" Width="50" Height="30" CssClass="btn" OnClick="sendEmail_Click" /></p>
        </div>
    </asp:Panel>
</asp:Content>
