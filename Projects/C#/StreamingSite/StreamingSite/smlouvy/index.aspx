<%@ Page Title="" Language="C#" MasterPageFile="~/smlouvy/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rad3k_eu.smlouvy.smlouvy" %>
<asp:Content ID="smlouvy" ContentPlaceHolderID="smlouvy" runat="server">
    <h4><asp:Label ID="nadpis" runat="server" Text="Přidat smlouvu"></asp:Label></h4>
    <div id="add">
        <div id="folders-left"><br/>
            <asp:Label ID="jmeno" runat="server" Text="Jmeno: "></asp:Label><br/>
            <asp:Label ID="prijmeni" runat="server" Text="Přijmení: "></asp:Label><br/>
            <asp:Label ID="pozice" runat="server" Text="Pozice: "></asp:Label><br/><br/>
            <div id="calendar">
                <asp:Label ID="datumNastupu" runat="server" Text="Datum nástupu"></asp:Label><br/>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </div>
        </div>
        <div id="folders-right"><br/>
            <asp:TextBox ID="jmenoText" runat="server" Width="150px" MaxLength="80"></asp:TextBox><br/>
            <asp:TextBox ID="prijmeniText" runat="server" Width="150px" MaxLength="80"></asp:TextBox><br/>
            <asp:TextBox ID="poziceText" runat="server" Width="150px" MaxLength="80"></asp:TextBox><br/><br/>
            <asp:Label ID="datumUkonceni" runat="server" Text="Datum ukončení"></asp:Label><br/>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </div>
        <div id="message">
            <asp:Label ID="doplnInformaceLabel" runat="server" Text="Zde vložte doplňující informace: " Visible="False"></asp:Label><br/>
            <asp:TextBox ID="doplnInformaceText" runat="server" Height="250px" Width="300px" MaxLength="255" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div id="under-context">
        <asp:Button ID="addData" runat="server" Text="Přidat smlouvu" BorderStyle="None" BackColor="#00CCFF" Width="400" OnClick="addData_Click" />
    </div>
</asp:Content>
