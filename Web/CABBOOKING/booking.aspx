<%@ Page Title="booking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="booking.aspx.cs"  Inherits="CABBOOKING.booking" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"><br />
        <asp:Label ID="Lb1" runat="server" Text="bookingid"></asp:Label>
        <asp:TextBox ID="TB1" runat="server"></asp:TextBox><br>
         <asp:Label ID="Ll2" runat="server" Text="usermaappingid"></asp:Label>
        <asp:TextBox ID="TB2" runat="server"></asp:TextBox><br/>
         <asp:Label ID="Ll3" runat="server" Text="charge"></asp:Label>
        <asp:TextBox ID="TB3" runat="server"></asp:TextBox><br>
         <asp:Label ID="Ll4" runat="server" Text="paymentid"></asp:Label>
        <asp:TextBox ID="TB4" runat="server"></asp:TextBox><br>
         <asp:Label ID="Ll5" runat="server" Text="canclebooking"></asp:Label>
        <asp:TextBox ID="TB5" runat="server" OnTextChanged="TB5_TextChanged"></asp:TextBox><br>
         <asp:Label ID="Ll6" runat="server" Text="driverid"></asp:Label>
        <asp:TextBox ID="TB6" runat="server"></asp:TextBox><br>
         <asp:Label ID="Ll7" runat="server" Text="tripstatus"></asp:Label>
        <asp:TextBox ID="TB7" runat="server"></asp:TextBox><br>
        <asp:Button ID="Bt1" runat="server" Text="insert" OnClick="Button1_Click" style="width: 48px" />
</asp:Content>