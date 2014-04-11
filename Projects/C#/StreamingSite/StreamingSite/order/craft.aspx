<%@ Page Title="" Language="C#" MasterPageFile="~/order/Site.Master" AutoEventWireup="true" CodeBehind="craft.aspx.cs" Inherits="rad3k_eu.order.craft" %>
<asp:Content ID="craftContent" ContentPlaceHolderID="order" runat="server">
    <h4><asp:Label ID="nadpis" runat="server" Text="Aktuální seznam objednaných her"></asp:Label></h4>
    <div id="tableStyle">
        <asp:Label ID="labelOutputCraft" runat="server"></asp:Label>
    </div>
</asp:Content>
