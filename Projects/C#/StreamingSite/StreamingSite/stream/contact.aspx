<%@ Page Title="Contact" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="rad3k_eu.contact" %>
<asp:Content ID="RightLinks" ContentPlaceHolderID="LeftContent" runat="server">
    <h2>Odkazy</h2>
    <ul class="links">
        <li><a href="http://www.youtube.com/user/Dragonmawcz?feature=mhee">Youtube</a></li>
        <li><a href="http://cs.twitch.tv/achiiles">Twitch</a></li>
        <li><a href="https://twitter.com/dragonmawcz">Twitter</a></li>
        <li><a href="https://www.facebook.com/groups/282592581872106/">Facebook</a></li>														
    </ul>
			
    <h2>Jak pomoct?</h2>
    <p>Podpořte mou sledovanost.</p>
</asp:Content>
<asp:Content ID="FormContent" ContentPlaceHolderID="RightContent" runat="server">
    <h2>Kontakt</h2>
    <p>V případě dotazů nebo žádosti mě kontaktujte prostřednictvím tohoto formuláře. Žádosti beru jen z pohledu, že chcete, abych streamoval určitý neboli specifický druh hry. Také mě prostřednictvím tohoto formuláře můžete informovat o vadách streamu nebo nápadech, jak streamování zlepšit.</p>

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
                <select id="typ" style="width: 202px; float: right;">
                    <option value="Enquiry">Otázka</option>
                    <option value="Support">Žádost</option>
                    <option value="Report bug">Ohlášení chyb</option>
                    <option value="Other">Jiné</option>
                </select>
            </p>
            <p>
                <asp:Label ID="messageLabel" runat="server" Text="Message"></asp:Label>
                <asp:TextBox ID="messageText" runat="server" MaxLength="255" Height="200" TextMode="MultiLine" Width="185" CssClass="right"></asp:TextBox>
            </p>
            <p><asp:Button ID="sendEmail" runat="server" Text="Send" BorderStyle="NotSet" Font-Bold="True" Width="50" Height="30" CssClass="btn" /></p>
        </div>
    </asp:Panel>
</asp:Content>
