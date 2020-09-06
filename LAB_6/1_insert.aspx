<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="lab6.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Student Details:<br />
            <br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <br />
            Sem&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="sem" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Mobile_no :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="mobile_no" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <br />
            Email_id&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email_id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="enter" runat="server" Text="submit" OnClick="enter_Click"/>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
