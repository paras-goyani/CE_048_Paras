<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="lab5.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left: 400px">
                Welcome
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
            </p>
        </div>
        

        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Electronics</asp:ListItem>
            <asp:ListItem>books</asp:ListItem>
        </asp:RadioButtonList>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:CheckBoxList ID="list" runat="server" >
            <asp:ListItem Value="50000">laptop , price = 50000</asp:ListItem>
            <asp:ListItem Value="999">Pen Drive , price = 999</asp:ListItem>
            <asp:ListItem Value="9999">Smart phone price = 9999</asp:ListItem>
            <asp:ListItem Value="499">Zindagi-Zindagi , price=499</asp:ListItem>
            <asp:ListItem Value="600">Mosad ,Price = 600</asp:ListItem>
            <asp:ListItem Value="589">Aghor Nagara Vage ,price=589</asp:ListItem>
        </asp:CheckBoxList>
        

        <p>
            &nbsp;</p>
        <asp:Button ID="place" runat="server" OnClick="place_Click" Text="Place Order" />
        

    </form>
</body>
</html>
