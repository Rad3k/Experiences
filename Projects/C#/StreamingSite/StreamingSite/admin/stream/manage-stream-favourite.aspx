<%@ Page Title="Manage" Language="C#" MasterPageFile="~/admin/manage.Master" AutoEventWireup="true" CodeBehind="manage-stream-favourite.aspx.cs" Inherits="rad3k_eu.manage_stream_favourite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WorkPlace" runat="server">
    <div id="manage-contain">
        <h4 style="text-align: left">Oblíbené hry</h4>
        <ul style="float: left;">
            <li><asp:TextBox ID="program_1" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_2" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_3" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_4" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_5" runat="server" Width="235px"></asp:TextBox></li>
        </ul>
    </div>
    <div id="save-button">
        <asp:Button ID="hLeftButton" runat="server" Text="Save" Height="30px" Width="450px" BackColor="#66FFFF" Font-Bold="True" />
    </div>
</asp:Content>
