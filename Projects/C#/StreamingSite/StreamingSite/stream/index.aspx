<%@ Page Title="Home Page" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="rad3k_eu.home" %>

<asp:Content ID="StreamPlayer" ContentPlaceHolderID="StreamContent" runat="server">
    <object type="application/x-shockwave-flash" height="378" width="680" id="live_embed_player_flash" data="http://www.twitch.tv/widgets/live_embed_player.swf?channel=achiiles"><param name="allowFullScreen" value="true" /><param name="allowScriptAccess" value="always" /><param name="allowNetworking" value="all" /><param name="movie" value="http://www.twitch.tv/widgets/live_embed_player.swf" /><param name="flashvars" value="hostname=www.twitch.tv&channel=achiiles&auto_play=true&start_volume=25" /></object>
    <a href="http://www.twitch.tv/achiiles" style="padding:2px 0px 4px; display:block; width:345px; font-weight:normal; font-size:10px;text-decoration:underline; text-align:center;">Watch live video from Rad3k on www.twitch.tv</a>
</asp:Content>

<asp:Content ID="LeftMenu" ContentPlaceHolderID="LeftContent" runat="server">
    <h2>Livestream with modern games</h2>
    <p>Zde můžete sledovat náš stream ať z her z koutku těch nejhranějších, tak i novinky na trhu, které se teprve snaží dostat na světlo světa herního trhu.</p>  
    <p><b>Hry, které můžete u nás vidět nejčastěji?</b></p>		
    <ul>
        <li><span>League of Legends</span></li>
        <li><span>Heartstone</span></li>
        <li><span>CS: Global Offensive</span></li>
        <li><span>Co-op games</span></li>
        <li><span>Path of Exile</span></li>
    </ul>			
    <p><b>Informace o streamu a kvalitě.</b></p>    
    <ul>
        <li><span>Rozlišení mého PC: 1920x1080 Full HD</span></li>
        <li><span>Rozlišení streamu: 1280x720 HD Quality</span></li>
        <li><span>Quality: 10</span></li>    
        <li><span>Upload: 18 mb/s</span></li> 
        <li><span>Odezva: 3s</span></li> 
    </ul>
</asp:Content>

<asp:Content ID="RightMenu" ContentPlaceHolderID="RightContent" runat="server">
    <p><b>Aktuální program pro streaming.</b></p>          
    <ul>
        <li><span>01.11.2013 - League of Legends </span></li>
        <li><span>02.11.2013 - League of Legends </span></li>    
        <li><span>03.11.2013 - League of Legends </span></li> 
        <li><span>04.11.2013 - League of Legends</span></li> 
        <li><span>05.11.2013 - League of Legends</span></li>     
        <li><span>06.11.2013 - League of Legends</span></li>
    </ul>      
    <p><b>Čas, kdy bude náš stream aktivní.</b></p>	
    <ul>
        <li><span>Pondělí: 16:00 - 23:30 hodin</span></li>
        <li><span>Úterý:   16:00 - 23:30 hodin</span></li>
        <li><span>Středa:  16:00 - 23:30 hodin</span></li>
        <li><span>Čtvrtek: 16:00 - 23:30 hodin</span></li>
        <li><span>Pátek:   18:00 - 02:00 hodin</span></li>
        <li><span>So + Ne: 13:00 - 02:00 hodin (v případě změny budete informováni)</span></li>
    </ul>    
    <p><b>Let´s playeři</b></p>	        
    <ul>
        <li><span>Dandus - RTS Hry, CS:GO</span></li>
        <li><span>Gaper - Recenze, RTS Hry</span></li>
        <li><span>Terquil - Recenze, Beta Testy</span></li>
    </ul>
</asp:Content>
