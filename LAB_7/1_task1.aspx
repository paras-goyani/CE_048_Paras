<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task1.aspx.cs" Inherits="LAB71.task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get even" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get odd" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 26px" Text="Get all" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Get maximum and minimun" />
            <br />
            <br />
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Get average" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
