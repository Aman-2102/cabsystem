<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridview.aspx.cs" Inherits="CABBOOKING.gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="UserId" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="UserId" HeaderText="UserId" ReadOnly="True" SortExpression="UserId" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="WalletAmount" HeaderText="WalletAmount" SortExpression="WalletAmount" />
                <asp:BoundField DataField="usertype" HeaderText="usertype" SortExpression="usertype" />
                <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" />
                <asp:BoundField DataField="useremail" HeaderText="useremail" SortExpression="useremail" />
                <asp:BoundField DataField="userpass" HeaderText="userpass" SortExpression="userpass" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [UserDetail]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>

<asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
<ItemTemplate>
<div class="rptr">
<table>
<tr><th>UserId<%#Eval("UserId") %></th></tr><br />
<tr><td>UserName<%#Eval("UserName") %><td></tr>
<tr><td>Gender<%#Eval("Gender") %><td></tr>
<tr><td>WalletAmount<%#Eval("WalletAmount") %><td></tr>
<tr><td>usertype<%#Eval("usertype") %><td></tr>
<tr><td>usertype<%#Eval("phoneNumber") %><td></tr>
<tr><td>useremail <%#Eval("useremail") %><td></tr>
 <tr><td>userpass<%#Eval("userpass") %><td></tr>
</table>
</div>
</ItemTemplate>
</asp:Repeater>