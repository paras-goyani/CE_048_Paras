﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="LAB71.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Product Information</h1>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="pid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="pid" HeaderText="pid" InsertVisible="False" ReadOnly="True" SortExpression="pid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                    <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [pid] = @original_pid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([category] = @original_category) OR ([category] IS NULL AND @original_category IS NULL)) AND (([price] = @original_price) OR ([price] IS NULL AND @original_price IS NULL))" InsertCommand="INSERT INTO [Product] ([name], [description], [category], [price]) VALUES (@name, @description, @category, @price)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Product] WHERE ([pid] = @pid)" UpdateCommand="UPDATE [Product] SET [name] = @name, [description] = @description, [category] = @category, [price] = @price WHERE [pid] = @original_pid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([category] = @original_category) OR ([category] IS NULL AND @original_category IS NULL)) AND (([price] = @original_price) OR ([price] IS NULL AND @original_price IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_pid" Type="Int32" />
                    <asp:Parameter Name="original_name" Type="String" />
                    <asp:Parameter Name="original_description" Type="String" />
                    <asp:Parameter Name="original_category" Type="String" />
                    <asp:Parameter Name="original_price" Type="Decimal" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="description" Type="String" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="price" Type="Decimal" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="6" Name="pid" QueryStringField="pid" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="description" Type="String" />
                    <asp:Parameter Name="category" Type="String" />
                    <asp:Parameter Name="price" Type="Decimal" />
                    <asp:Parameter Name="original_pid" Type="Int32" />
                    <asp:Parameter Name="original_name" Type="String" />
                    <asp:Parameter Name="original_description" Type="String" />
                    <asp:Parameter Name="original_category" Type="String" />
                    <asp:Parameter Name="original_price" Type="Decimal" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
