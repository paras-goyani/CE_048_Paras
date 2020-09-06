<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="LAB6.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Product Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
            <p>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log Out" />
            </p>
            <p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
            <p>
                <asp:ListBox ID="ListBox2" runat="server" DataSourceID="SqlDataSource1" SelectionMode="Multiple" DataTextField="pname" DataValueField="pid"></asp:ListBox>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Place Order" />
            </p>
        </div>
    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
    </body>
</html>
