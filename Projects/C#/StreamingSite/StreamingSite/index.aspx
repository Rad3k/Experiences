<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rad3k_eu.index" %>
<asp:Content ID="left_box_text_ID" ContentPlaceHolderID="left_box_text" runat="server">
    <h1>Informace</h1>
    <p>Vítejte na mém portóliu. Můžete zde shlédnout mnou aktuálně vedené projekty, které se zabývají recenzemi a streamováním her v realném čase, vývojem webových stránek a windows aplikací v jazyce C# a nebo drobnější grafické práce.<br/>
    <br/>Hlavním prvkem je, že široké veřejnosti dávám k dispozice své aktuální znalosti. Takže v případě, že i vy hledáte někoho, kdo by Vám vypomohl s Vaším projektem a nebo vytvořil webovou či interní aplikaci na míru, tak mě neváhejte kontaktovat.</p>
    <br/><b>Mohu nabídnout služby v tomto okruhu:</b>
    <ul>
        <li>Vývoj aplikací v C# (.NET, ASP.NET)</li>
        <li>Výpomoc s projekty na bázi C#, MSSQL, MySQL</li>
        <li>Kódování v HTML/HTML5 + CSS</li>
        <li>Tvorba video prezentací, krátkých spotů</li>
        <li>Recenze nejnovějších her včetně livestreamu</li>
    </ul>
</asp:Content>
<asp:Content ID="project_list_ID" ContentPlaceHolderID="project_list" runat="server">
    <br/><br/>
    <h1>Poslední projekty:</h1><br/>
    <table>
        <tr>
            <th id="nameProjects"><span class="pink">Jméno projektu</span></th>
            <th id="status"><span class="pink">Status</span></th>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td class="left"><span class="name"> Menší karetní hra pro děti a dospělé </span></td>
            <td><span class="orange"> Rozpracováno </span></td>
        </tr>
        <tr>
            <td class="left"><span class="name"> Evidence zaměstnaneckých smluv + upozornění na blížící se konec smlouvy </span></td>
            <td><span class="green"> Dokonceno </span></td>
        </tr>
        <tr>
            <td class="left"><span class="name"> Objednávkový systém na produkty v akci </span></td>
            <td><span class="green"> Dokončeno </span></td>
        </tr>
        <tr>
            <td class="left"><span class="name"> Tvorba video traileru pro guildu Semper Fidelis </span></td>
            <td><span class="green"> Dokončeno </span></td>
        </tr>
        <tr>
            <td class="left"><span class="name"> Tvorba video traileru pro členy Pillars of Jyggalag </span></td>
            <td><span class="green"> Dokonceno </span></td>
        </tr>
        </table>
    <br/><br/><a href="http://rad3k.eu" class="view_project">Seznam všech projektů</a>
</asp:Content>
