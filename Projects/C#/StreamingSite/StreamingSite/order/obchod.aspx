<%@ Page Title="" Language="C#" MasterPageFile="~/order/Site.Master" AutoEventWireup="true" CodeBehind="obchod.aspx.cs" Inherits="rad3k_eu.order.obchod" %>
<asp:Content ID="obchod" ContentPlaceHolderID="order" runat="server">
    <asp:Button ID="nakup" runat="server" Text="Nakoupím" BorderStyle="None" Width="150px" OnClick="nakup_Click" />
    <asp:Button ID="prodej" runat="server" Text="Prodám" BorderStyle="None" Width="150px" OnClick="prodej_Click" />
    <asp:Button ID="vymena" runat="server" Text="Vyměním" BorderStyle="None" Width="150px" OnClick="vymena_Click" />
    <div id="tableStyle">
        <br/><asp:Label ID="labelOutput" runat="server"></asp:Label>
    </div>
</asp:Content>
