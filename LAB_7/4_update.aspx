﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="LAB71.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Update Page</h1>
<form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="insert.aspx">Insert</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/update.aspx">Update</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/delete.aspx">Delete</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/show.aspx">Show</asp:HyperLink>
            <br />
            <br />
            ID:&nbsp;
            <asp:TextBox ID="TextBox6" AutoPostBack OnTextChanged="TextBox6_TextChanged" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Sem: <asp:TextBox ID="TextBox2" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            CPI:
            <asp:TextBox ID="TextBox3" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            Mobile No.:
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Phone"></asp:TextBox>
            <br />
            <br />
            Email ID:
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        </div>
    </form>
</body>
</html>
