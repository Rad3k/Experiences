<%@ Page Title="" Language="C#" MasterPageFile="~/podstranky.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="rad3k_eu.contact1" %>
<asp:Content ID="left_contact" ContentPlaceHolderID="left_box_text" runat="server">
    <div class="left_content">
      <h1>Kontaktujte mě</h1>
      <div class="contact_form">
          <div class="form_row">
              <asp:Label ID="name_label" runat="server" Text="Jméno:" CssClass="contact"></asp:Label>
              <asp:TextBox ID="name_text" runat="server" CssClass="contact_input"></asp:TextBox>
          </div>
          <div class="form_row">
              <asp:Label ID="email_label" runat="server" Text="Email:" CssClass="contact"></asp:Label>
              <asp:TextBox ID="email_text" runat="server" CssClass="contact_input"></asp:TextBox>
          </div>
          <div class="form_row">
              <asp:Label ID="duvod_label" runat="server" Text="Předmět:" CssClass="contact"></asp:Label>
              <asp:TextBox ID="duvod_text" runat="server" CssClass="contact_input"></asp:TextBox>
          </div>
          <div class="form_row">
              <asp:Label ID="zprava_label" runat="server" Text="Zpráva:" CssClass="contact"></asp:Label>
              <asp:TextBox ID="full_text" runat="server" CssClass="contact_textarea" Height="249px" TextMode="MultiLine"></asp:TextBox>
          </div>
          <div class="form_row">
              <div id="button"><asp:Button ID="send_button" runat="server" Text="Send" CssClass="read_more" BorderStyle="None" OnClick="send_button_Click" /></div>
          </div>
      </div>
      <div class="contact_info">
          <h1 style="font-weight: bold">Kontaktní informace:</h1>
          <div class="contact-inform">
              <h3>
                  <strong><span class="name">Jméno: </span></strong>Radek Tarant<br/>
                  <strong><span class="name">Email:&nbsp;&nbsp; </span></strong>Rad3k.T@seznam.cz<br/>
                  <strong><span class="name">Mobil:&nbsp;&nbsp; </span></strong>721186883<br/>
                  <strong><span class="name">Web:&nbsp;&nbsp;&nbsp;&nbsp; </span></strong>
                  <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx" ForeColor="#FBD0DD">http://rad3k.eu</asp:HyperLink>
              </h3>
          </div>
      </div>
    </div>
</asp:Content>
