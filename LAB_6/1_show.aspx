﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="lab6.show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
         <div>
            <br />
        </div>
         <asp:GridView ID="GridViewStudent" runat="server">
         </asp:GridView>
         <p>
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
         </p>
    </form>
</body>
</html>
