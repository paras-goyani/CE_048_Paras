<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="lab6.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            select student ID:<asp:DropDownList ID="id" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="fetch" runat="server" OnClick="fetch_Click" Text="fetch" />
        </p>
        <p>
            <asp:Label ID="extra" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lname" runat="server" Text="Name" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lsem" runat="server" Text="Sem" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="sem" runat="server" Visible="False">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lmobile_no" runat="server" Text="Mobile_no" Visible="False"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="mobile_no" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lemail_id" runat="server" Text="Email_id" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email_id" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="sedit" runat="server" OnClick="sedit_Click" Text="Edit" Visible="False" />
        </p>
        <p>
            <asp:Label ID="complete" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>
