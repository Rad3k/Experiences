<%@ Page Title="Home Page" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rad3k_eu.home" %>

<asp:Content ID="StreamPlayer" ContentPlaceHolderID="StreamContent" runat="server">
    <object type="application/x-shockwave-flash" height="378" width="680" id="live_embed_player_flash" data="http://www.twitch.tv/widgets/live_embed_player.swf?channel=achiiles"><param name="allowFullScreen" value="true" /><param name="allowScriptAccess" value="always" /><param name="allowNetworking" value="all" /><param name="movie" value="http://www.twitch.tv/widgets/live_embed_player.swf" /><param name="flashvars" value="hostname=www.twitch.tv&channel=achiiles&auto_play=true&start_volume=25" /></object>
    <a href="http://www.twitch.tv/achiiles" style="padding:2px 0px 4px; display:block; width:345px; font-weight:normal; font-size:10px;text-decoration:underline; text-align:center;">Watch live video from Rad3k on www.twitch.tv</a>
</asp:Content>

<asp:Content ID="LeftMenu" ContentPlaceHolderID="LeftContent" runat="server">
    <h2><asp:Label ID="hlavniNadpis" runat="server" Text="nadPis"></asp:Label></h2>
    <p><asp:Label ID="popisPrace" runat="server" Text="popisPrace"></asp:Label></p>  
    <p><b><asp:Label ID="nadpisHry" runat="server" Text="nadpisHry"></asp:Label></b></p>		
    <ul>
        <li><span><asp:Label ID="hra_1" runat="server" Text="hra_1"></asp:Label></span></li>
        <li><span><asp:Label ID="hra_2" runat="server" Text="hra_2"></asp:Label></span></li>
        <li><span><asp:Label ID="hra_3" runat="server" Text="hra_3"></asp:Label></span></li>
        <li><span><asp:Label ID="hra_4" runat="server" Text="hra_4"></asp:Label></span></li>
        <li><span><asp:Label ID="hra_5" runat="server" Text="hra_5"></asp:Label></span></li>
    </ul>			
    <p><b><asp:Label ID="InformaceNadpis" runat="server" Text="informaceNadpis"></asp:Label></b></p>    
    <ul>
        <li><span><asp:Label ID="rozliseniPC" runat="server" Text="rozliseniPC"></asp:Label></span></li>
        <li><span><asp:Label ID="rozliseniStream" runat="server" Text="rozliseniStream"></asp:Label></span></li>
        <li><span><asp:Label ID="Kvalita" runat="server" Text="kvalita"></asp:Label></span></li>    
        <li><span><asp:Label ID="upload" runat="server" Text="upload"></asp:Label></span></li> 
        <li><span><asp:Label ID="odezva" runat="server" Text="Odezva"></asp:Label></span></li> 
    </ul>
</asp:Content>

<asp:Content ID="RightMenu" ContentPlaceHolderID="RightContent" runat="server">
    <p><b><asp:Label ID="nadpisProgram" runat="server" Text="nadpisProgram"></asp:Label></b></p>          
    <ul>
        <li><span><asp:Label ID="program_1" runat="server" Text="program_1"></asp:Label></span></li>
        <li><span><asp:Label ID="program_2" runat="server" Text="program_2"></asp:Label></span></li>    
        <li><span><asp:Label ID="program_3" runat="server" Text="program_3"></asp:Label></span></li> 
        <li><span><asp:Label ID="program_4" runat="server" Text="program_4"></asp:Label></span></li> 
        <li><span><asp:Label ID="program_5" runat="server" Text="program_5"></asp:Label></span></li>     
        <li><span><asp:Label ID="program_6" runat="server" Text="program_6"></asp:Label></span></li>
    </ul>      
    <p><b><asp:Label ID="casStream" runat="server" Text="casStream"></asp:Label></b></p>	
    <ul>
        <li><span><asp:Label ID="cas_1" runat="server" Text="cas_1"></asp:Label></span></li>
        <li><span><asp:Label ID="cas_2" runat="server" Text="cas_2"></asp:Label></span></li>
        <li><span><asp:Label ID="cas_3" runat="server" Text="cas_3"></asp:Label></span></li>
        <li><span><asp:Label ID="cas_4" runat="server" Text="cas_4"></asp:Label></span></li>
        <li><span><asp:Label ID="cas_5" runat="server" Text="cas_5"></asp:Label></span></li>
        <li><span><asp:Label ID="cas_6" runat="server" Text="cas_6"></asp:Label></span></li>
    </ul>    
    <p><b><asp:Label ID="playerNadpis" runat="server" Text="playerNadpis"></asp:Label></b></p>	        
    <ul>
        <li><span><asp:Label ID="jmeno_1" runat="server" Text="jmeno_1"></asp:Label></span></li>
        <li><span><asp:Label ID="jmeno_2" runat="server" Text="jmeno_2"></asp:Label></span></li>
        <li><span><asp:Label ID="jmeno_3" runat="server" Text="jmeno_3"></asp:Label></span></li>
    </ul>
</asp:Content>
