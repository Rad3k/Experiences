<%@ Page Title="" Language="C#" MasterPageFile="~/order/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rad3k_eu.order.index" %>
<asp:Content ID="MainPage" ContentPlaceHolderID="order" runat="server">
    <h4><asp:Label ID="nadpis" runat="server" Text="Vítejte v systému objednávek v kategorii her a craftu"></asp:Label></h4>
    <p>V tomto systému si každý uživatel naší členské komunity může přímo zažádat nebo objednat věc dle typu potřeby.</p>
    <div id="main">
        <h5>Aktuální systém funguje stylem</h5>
        <ul>
            <li><span>Dotazů</span></li>
            <li><span>Objednávek</span></li>
        </ul>
        <p></p>
        <ul>
            <li><span>Hry</span></li>
            <li><span>Craft</span></li>
            <li><span>Přidat</span></li>
        </ul>
    </div>
    <div id="description">
        <b>- Jakmile bude přidán dotaz, tak mi na email ihned přijde zpráva o daném dotazu s informacemi. Dotaz lze uskutečnit ke kategorii her i craftu. Z hlediska her na zeptání se ceny a u craftu nějaké druhu dotazu</b>
        <br/>
        <b>- V případě zadání objednávky je opět důležité zdali vybere hru nebo craft. V případě, že vyberete hru po Vás budou žádány doplňující informace. Například kolik kusů bude chtít objednat, email a samozřejmě jméno hry o kterou máte zájem. Ke zjištění ceny dané hry slouží právě systém dotazů. Systém objednávek už je na konkrétní zboží. Z hlediska craftu tu máme i další věci, kterými jsou typ potionu a jeho případné vlastnosti, které budete chtít vyrobit.</b>
        <p>
            <b> - Seznam všech objednávek v kategorii her.</b><br/>
            <b> - Seznam všech objednávek v kategorii craft. </b><br/>
            <b> - Zde vkládáte vaše dotazy a objednávky. </b>
        </p>
    </div>
</asp:Content>
