﻿<%@ Page Title="Support me" Language="C#" MasterPageFile="~/admin/manage.Master" AutoEventWireup="true" CodeBehind="manage-stream-support-me.aspx.cs" Inherits="rad3k_eu.admin.stream.manage_stream_support_me" %>
<asp:Content ID="support_me" ContentPlaceHolderID="WorkPlace" runat="server">
    <div id="manage-contain">
        <asp:Label ID="nadpis" runat="server" Text="Podpořte mě:"></asp:Label><br/>
        <asp:TextBox ID="nadpisText" runat="server" Width="899px"></asp:TextBox><br/>
        <asp:Label ID="text" runat="server" Text="Text:"></asp:Label><br/>
        <asp:TextBox ID="doplnText" runat="server" Width="899px" Height="343px" TextMode="MultiLine"></asp:TextBox><br/>
    </div>
    <div id="save-button">
        <asp:Button ID="save_id" runat="server" Text="Save" Height="30px" Width="450px" BackColor="#66FFFF" Font-Bold="True" OnClick="save_id_Click" />
    </div>
</asp:Content>
