<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="lab51.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;<asp:Button ID="create" runat="server" OnClick="create_Click" Text="Create Cookie" />
&nbsp;&nbsp; :&nbsp;&nbsp;
            <asp:TextBox ID="t1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="retrive" runat="server" OnClick="retrive_Click" Text="Retrive Cookie" />
&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
            <asp:TextBox ID="t2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Cookie" />
&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
            <asp:TextBox ID="t3" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
