<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userdetail.aspx.cs" Inherits="CABBOOKING.userdetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="userid"></asp:Label>
      
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          <asp:Label ID="Label2" runat="server" Text=" name"></asp:Label>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <asp:Label ID="Label3" runat="server" Text=" gender"></asp:Label>
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
             <asp:Label ID="Label4" runat="server" Text=" wallet amount"></asp:Label>
             <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
             <asp:Label ID="Label5" runat="server" Text=" type of user"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
             <%--<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="usertype" DataValueField="usertype" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged2">
            <asp:ListItem>user</asp:ListItem>
            <asp:ListItem>driver</asp:ListItem>
        </asp:DropDownList>--%>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [usertype] FROM [UserDetail]"></asp:SqlDataSource>
             <asp:Label ID="Label6" runat="server" Text=" phone number"></asp:Label>
             <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            <br />

            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" style="height: 26px" />

            <br />
            <br />


        </div>
       
    </form>
</body>
</html>
