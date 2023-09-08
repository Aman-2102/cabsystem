<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CABBOOKING.About" %>

<%--<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"><br />
<h2><asp:Label ID="USERID" runat="server" Text="userid"></asp:Label></h2>
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   
    <h2><asp:Label ID="PHONENUMBER" runat="server" Text="mobilenumber"></asp:Label></h2>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br><br>
     <asp:Button ID="Button1" runat="server" Text="GenerateOTP" OnClick="Button1_Click" />
    <h2></h2>
</asp:Content>--%>
<%--<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"><br />
<asp:Panel ID="pnl1" runat="server">
  <table>
    <tr>
      <td>Enter Your Mobile Number:</td>
      <td>
        <asp:TextBox ID="txtmobileNo" runat="server"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td></td>
      <td>
        <asp:Button ID="btnsendOtp" runat="server" Text="Send OTP" OnClick="btnsendOtp_Click" />
      </td>
    </tr>
  </table>
</asp:Panel>
<asp:Panel ID="pnl2" runat="server" Visible="false">
  <table>
    <tr>
      <td>Enter Your OTP:</td>
      <td>
        <asp:TextBox ID="txtverifyMobileNO" runat="server"></asp:TextBox>
      </td>
    </tr>
    <tr>--%>
    <%--  <td></td>
      <td>
        <asp:Button ID="btnverify" runat="server" Text="Verify" OnClick="btnverify_Click" />
      </td>
    </tr>
  </table>
</asp:Panel>
</asp:Content>--%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"><br />
<asp:Label ID="Label1" runat="server" Text="Email-Id" ></asp:Label>
<asp:TextBox ID="txtemail" runat="server"></asp:TextBox> <br><br />
<asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label>
<asp:TextBox ID="txtpass" runat="server"></asp:TextBox> <br><br />
<asp:Label ID="lblError" runat="server" Text="" ></asp:Label>
<asp:Button ID="Button1" runat="server" OnClick="button_login_Click" Text="Login" />
</asp:Content>
