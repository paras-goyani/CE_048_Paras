<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="LAB6.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Order Page</h1>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log Out" />
            </p>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
