<%@ Page Title="" Language="C#" MasterPageFile="~/order/Site.Master" AutoEventWireup="true" CodeBehind="orderAdd.aspx.cs" Inherits="rad3k_eu.order.orderAdd" %>
<asp:Content ID="orderAdd" ContentPlaceHolderID="order" runat="server">
    <h4><asp:Label ID="nadpis" runat="server" Text="Přidat dotaz nebo objednávku"></asp:Label></h4>
    <div id="add">
        <div id="folders-left">
            <asp:Label ID="dropDownList" runat="server" Text="Vyberte si typ požadavku: "></asp:Label><br/>
            <asp:Label ID="Type" runat="server" Text="Možnosti vašeho požadavku: " Visible="False"></asp:Label><br/>
            <asp:Label ID="typZboziLabel" runat="server" Text="Zvolte typ obchodu: " Visible="false"></asp:Label>
            <div id="under-navigation">
                <asp:Label ID="name" runat="server" Visible="False"></asp:Label><br/>
                <asp:Label ID="value" runat="server" Visible="False"></asp:Label><br/>
                <asp:Label ID="email" runat="server" Visible="False"></asp:Label>
            </div>
        </div>
        <div id="folders-right">
            <asp:DropDownList ID="Orders" runat="server" Width="150" OnSelectedIndexChanged="Orders_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="" Value="0"></asp:ListItem>
                <asp:ListItem Text="Dotaz" Value="1"></asp:ListItem>
                <asp:ListItem Text="Objednávka" Value="2"></asp:ListItem>
                <asp:ListItem Text="Obchod" Value="3"></asp:ListItem>
            </asp:DropDownList><br/>
            <asp:DropDownList ID="Obchod" runat="server" Width="150" Visible="False" AutoPostBack="True">
                <asp:ListItem Text="Nakoupím" Value="0"></asp:ListItem>
                <asp:ListItem Text="Prodám" Value="1"></asp:ListItem>
                <asp:ListItem Text="Vyměním" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="nextStep" runat="server" Width="150" OnSelectedIndexChanged="nextStep_SelectedIndexChanged" Visible="False" AutoPostBack="True">
                <asp:ListItem Text="" Value="0"></asp:ListItem>
                <asp:ListItem Text="Hry" Value="1"></asp:ListItem>
                <asp:ListItem Text="Craft" Value="2"></asp:ListItem>
            </asp:DropDownList><br/>
            <asp:DropDownList ID="typZbozi" runat="server" Width="150" Visible="false" AutoPostBack="true">
                <asp:ListItem Text="Vybavení" Value="0"></asp:ListItem>
                <asp:ListItem Text="Materiál" Value="1"></asp:ListItem>
            </asp:DropDownList>
            <div id="under-droplist">
                <asp:DropDownList ID="typPotionu" runat="server" Width="150" Visible="False" AutoPostBack="True">
                    <asp:ListItem Text="Health" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Magicka" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Stamina" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Vlastnost" Value="3"></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="nameText" runat="server" Visible="False" MaxLength="80"></asp:TextBox><br/>
                <asp:TextBox ID="valueText" runat="server" Visible="False" MaxLength="80"></asp:TextBox><br/>
                <asp:TextBox ID="emailText" runat="server" Visible="False" MaxLength="80"></asp:TextBox>
            </div>
        </div>
        <div id="message">
            <asp:Label ID="doplnInformaceLabel" runat="server" Text="Zde vložte doplňující informace: " Visible="False"></asp:Label><br/>
            <asp:TextBox ID="doplnInformace" runat="server" Height="250px" Width="300px" Visible="False" MaxLength="255" TextMode="MultiLine"></asp:TextBox>
        </div>
    </div>
    <div id="under-context">
        <asp:Button ID="addData" runat="server" Text="Přidat požadavek" BorderStyle="None" BackColor="#00CCFF" Width="400" Visible="False" OnClick="addData_Click" />
    </div>
</asp:Content>
