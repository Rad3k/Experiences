<%@ Page Title="" Language="C#" MasterPageFile="~/podstranky.Master" AutoEventWireup="true" CodeBehind="projects.aspx.cs" Inherits="rad3k_eu.projects" %>
<asp:Content ID="left_projects" ContentPlaceHolderID="left_box_text" runat="server">
    <h1>Seznam všech zavedených projektů</h1>
    <table>
        <tr>
            <th id="nameProjects" style="width: 461px"><span class="pink">Jméno projektu</span></th>
            <th id="status"><span class="pink">Status</span></th>
        </tr>
        <tr>
            <td style="width: 461px"></td>
            <td></td>
        </tr>
        <tr>
            <td class="left" style="width: 461px"><span class="name"> Menší karetní hra pro děti a dospělé </span></td>
            <td><span class="orange"> Rozpracováno </span></td>
        </tr>
        <tr>
            <td class="left" style="width: 461px"><span class="name"> Evidence zaměstnaneckých smluv + upozornění na blížící se konec smlouvy </span></td>
            <td><span class="green"> Dokonceno </span></td>
        </tr>
        <tr>
            <td class="left" style="width: 461px"><span class="name"> Objednávkový systém na produkty v akci </span></td>
            <td><span class="green"> Dokončeno </span></td>
        </tr>
        <tr>
            <td class="left" style="width: 461px"><span class="name"> Tvorba video traileru pro guildu Semper Fidelis </span></td>
            <td><span class="green"> Dokončeno </span></td>
        </tr>
        <tr>
            <td class="left" style="width: 461px"><span class="name"> Tvorba video traileru pro členy Pillars of Jyggalag </span></td>
            <td><span class="green"> Dokonceno </span></td>
        </tr>
        </table>
</asp:Content>
