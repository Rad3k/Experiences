<%@ Page Title="Manage" Language="C#" MasterPageFile="~/admin/manage.Master" AutoEventWireup="true" CodeBehind="manage-stream-links.aspx.cs" Inherits="rad3k_eu.admin.manage_stream_links" %>
<asp:Content ID="Links" ContentPlaceHolderID="WorkPlace" runat="server">
    <div id="manage-contain">
        <h4 style="text-align: left">Odkazy a Aliasy</h4>
        <ul style="float: left">
            <li><asp:TextBox ID="program_1" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_2" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_3" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_4" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_5" runat="server" Width="235px"></asp:TextBox></li>
        </ul>
        <ul style="float: left">
            <li><asp:TextBox ID="alisy_1" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="alisy_2" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="alisy_3" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="alisy_4" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="alisy_5" runat="server" Width="235px"></asp:TextBox></li>
        </ul>
    </div>
    <div id="save-button">
        <asp:Button ID="hLeftButton" runat="server" Text="Save" Height="30px" Width="450px" BackColor="#66FFFF" Font-Bold="True" />
    </div>
</asp:Content>
