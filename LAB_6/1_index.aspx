<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="lab6.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="insert_student" runat="server" OnClick="insert_student_Click" Text="insert" />
            <br />
            <br />
        </div>
        <asp:Button ID="edit_student" runat="server" OnClick="edit_student_Click" Text="Edit" />
        <br />
        <br />
        <br />
        <asp:Button ID="delete_student" runat="server" OnClick="delete_student_Click" Text="Delete" />
        <br />
        <br />
        <br />
        <asp:Button ID="show_student_details" runat="server" OnClick="show_student_details_Click" Text="Show" />
    </form>
</body>
</html>
