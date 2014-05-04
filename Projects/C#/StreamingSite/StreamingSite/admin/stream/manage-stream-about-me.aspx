<%@ Page Title="Manage" Language="C#" MasterPageFile="~/admin/manage.Master" AutoEventWireup="true" CodeBehind="manage-stream-about-me.aspx.cs" Inherits="rad3k_eu.manage_stream_favourite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WorkPlace" runat="server">
    <div id="manage-contain">
        <asp:Label ID="nadpis" runat="server" Text="Nadpis"></asp:Label><br/>
        <asp:TextBox ID="nadpisText" runat="server" Width="850px"></asp:TextBox><br/>
        <asp:Label ID="popis" runat="server" Text="Popis"></asp:Label><br/>
        <asp:TextBox ID="popisText" runat="server" Height="59px" TextMode="MultiLine" Width="854px"></asp:TextBox><br/>
        <div style="float: left">
            <p>
                <asp:Label ID="nadpis_2" runat="server" Text="Oblíbené hry:"></asp:Label>
                <asp:TextBox ID="favouriteGames" runat="server" Width="214px"></asp:TextBox>
            </p>
            <ul>
                <li><asp:TextBox ID="program_1" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="program_2" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="program_3" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="program_4" runat="server" Width="235px"></asp:TextBox></li>
            </ul>
        </div>
        <div style="float: right">
            <p>
                <asp:Label ID="doplnText" runat="server" Text="Doplňující informace"></asp:Label><br/>
                <asp:TextBox ID="doplnInformace" runat="server" Width="578px" Height="153px" TextMode="MultiLine"></asp:TextBox>
            </p>
        </div>
    </div>
    <div id="save-button">
        <asp:Button ID="hLeftButton" runat="server" Text="Save" Height="30px" Width="450px" BackColor="#66FFFF" Font-Bold="True" />
    </div>
</asp:Content>
