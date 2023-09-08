<%@ Page Title="location" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="location.aspx.cs"  Inherits="CABBOOKING.location" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"><br />
   <asp:Label ID="Label1" runat="server" Text="locationid"></asp:Label>      
    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="location name"></asp:Label>
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>    
    <asp:Button ID="Button1" runat="server" Text="insert" Height="23px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server"></asp:Label>
</asp:Content>
