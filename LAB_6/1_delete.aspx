<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="lab6.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            select student ID:<asp:DropDownList ID="id" runat="server">
            </asp:DropDownList>
        <br />
        <div>
            <asp:Button ID="delete_record" runat="server" OnClick="delete_record_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
