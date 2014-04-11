<%@ Page Title="" Language="C#" MasterPageFile="~/order/Site.Master" AutoEventWireup="true" CodeBehind="hry.aspx.cs" Inherits="rad3k_eu.order.hry" %>
<asp:Content ID="seznamHer" ContentPlaceHolderID="order" runat="server">
    <h4><asp:Label ID="nadpis" runat="server" Text="Aktuální seznam objednaných her"></asp:Label></h4>
    <div id="tableStyle">
        <asp:Label ID="labelOutput" runat="server"></asp:Label>
    </div>
</asp:Content>
