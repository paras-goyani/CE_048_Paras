<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="LAB71.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Delete Page</h1>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="insert.aspx">Insert</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/update.aspx">Update</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/delete.aspx">Delete</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/show.aspx">Show</asp:HyperLink>
            <br />
            <br />
    <form id="form1" runat="server">
        <div>
            ID:
            <asp:TextBox ID="TextBox1" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>
