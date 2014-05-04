<%@ Page Title="Manage" Language="C#" MasterPageFile="~/admin/manage.Master" AutoEventWireup="true" CodeBehind="manage-stream-hLeft.aspx.cs" Inherits="rad3k_eu.admin.homeLeft" %>
<asp:Content ID="subLeft" ContentPlaceHolderID="WorkPlace" runat="server">
    <div id="manage-contain">
        <p>
            <asp:Label ID="actualLabel" runat="server" Text="Titul 1:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nameProgram" runat="server" Width="797px"></asp:TextBox>
        </p>
         <p>
            <asp:Label ID="timeStream" runat="server" Text="Titul 2:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="timeProgram" runat="server" Width="797px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="nameStreamers" runat="server" Text="Titul 2:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="namePeople" runat="server" Width="797px"></asp:TextBox>
        </p>
        <h4 style="text-align: left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Aktuální program&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Čas streamování&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Streameři
        </h4>
        <ul style="float: left">
            <li><asp:TextBox ID="program_1" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_2" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_3" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_4" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_5" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="program_6" runat="server" Width="235px"></asp:TextBox></li>
        </ul>
        <ul style="float: left">
            <li><asp:TextBox ID="time_1" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="time_2" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="time_3" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="time_4" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="time_5" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="time_6" runat="server" Width="235px"></asp:TextBox></li>
        </ul>
        <ul style="float: left">
            <li><asp:TextBox ID="name_1" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="name_2" runat="server" Width="235px"></asp:TextBox></li>
            <li><asp:TextBox ID="name_3" runat="server" Width="235px"></asp:TextBox></li>
        </ul>
    </div>
    <div id="save-button">
        <asp:Button ID="hLeftButton" runat="server" Text="Save" Height="30px" Width="450px" BackColor="#66FFFF" Font-Bold="True" OnClick="hLeftButton_Click" />
    </div>
</asp:Content>
