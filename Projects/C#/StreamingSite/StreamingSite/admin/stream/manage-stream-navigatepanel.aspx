<%@ Page Title="Navigate" Language="C#" MasterPageFile="~/admin/manage.Master" AutoEventWireup="true" CodeBehind="manage-stream-navigatepanel.aspx.cs" Inherits="rad3k_eu.admin.manage_stream_links" %>
<asp:Content ID="Links" ContentPlaceHolderID="WorkPlace" runat="server">
    <div id="manage-contain">
        <asp:Label ID="nadpis" runat="server" Text="Podpořte mě:"></asp:Label><br/>
        <asp:TextBox ID="nadpisText" runat="server" Width="899px"></asp:TextBox><br/>
        <asp:Label ID="text" runat="server" Text="Text:"></asp:Label><br/>
        <asp:TextBox ID="doplnText" runat="server" Width="899px" Height="130px" TextMode="MultiLine"></asp:TextBox><br/>
        <div style="float: left; text-align: left">
            <h5>Odkazy a Aliasy</h5>
            <ul>
                <li><asp:TextBox ID="program_1" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="program_2" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="program_3" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="program_4" runat="server" Width="235px"></asp:TextBox></li>
            </ul>
        </div>
        <div style="float: left">
            <br/><br/><ul>
                <li><asp:TextBox ID="alisy_1" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="alisy_2" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="alisy_3" runat="server" Width="235px"></asp:TextBox></li>
                <li><asp:TextBox ID="alisy_4" runat="server" Width="235px"></asp:TextBox></li>
            </ul>
        </div>
    </div>
    <div id="save-button">
        <asp:Button ID="navigatePanel" runat="server" Text="Save" Height="30px" Width="450px" BackColor="#66FFFF" Font-Bold="True" OnClick="navigatePanel_Click" />
    </div>
</asp:Content>
