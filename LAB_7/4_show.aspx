<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="LAB71.show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Show Details</h1>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="insert.aspx">Insert</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/update.aspx">Update</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/delete.aspx">Delete</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/show.aspx">Show</asp:HyperLink>
            <br />
            <br />
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="sid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" DeleteCommand="DELETE FROM [student] WHERE [sid] = @original_sid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL))" InsertCommand="INSERT INTO [student] ([name]) VALUES (@name)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [sid], [name] FROM [student]" UpdateCommand="UPDATE [student] SET [name] = @name WHERE [sid] = @original_sid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_sid" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="original_sid" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <div>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                    <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                    <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
                    <asp:BoundField DataField="emailid" HeaderText="emailid" SortExpression="emailid" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" DeleteCommand="DELETE FROM [student] WHERE [sid] = @original_sid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([sem] = @original_sem) OR ([sem] IS NULL AND @original_sem IS NULL)) AND (([cpi] = @original_cpi) OR ([cpi] IS NULL AND @original_cpi IS NULL)) AND (([contactno] = @original_contactno) OR ([contactno] IS NULL AND @original_contactno IS NULL)) AND (([emailid] = @original_emailid) OR ([emailid] IS NULL AND @original_emailid IS NULL))" InsertCommand="INSERT INTO [student] ([name], [sem], [cpi], [contactno], [emailid]) VALUES (@name, @sem, @cpi, @contactno, @emailid)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [student] WHERE ([sid] = @sid)" UpdateCommand="UPDATE [student] SET [name] = @name, [sem] = @sem, [cpi] = @cpi, [contactno] = @contactno, [emailid] = @emailid WHERE [sid] = @original_sid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([sem] = @original_sem) OR ([sem] IS NULL AND @original_sem IS NULL)) AND (([cpi] = @original_cpi) OR ([cpi] IS NULL AND @original_cpi IS NULL)) AND (([contactno] = @original_contactno) OR ([contactno] IS NULL AND @original_contactno IS NULL)) AND (([emailid] = @original_emailid) OR ([emailid] IS NULL AND @original_emailid IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_sid" Type="Int32" />
                    <asp:Parameter Name="original_name" Type="String" />
                    <asp:Parameter Name="original_sem" Type="String" />
                    <asp:Parameter Name="original_cpi" Type="Decimal" />
                    <asp:Parameter Name="original_contactno" Type="String" />
                    <asp:Parameter Name="original_emailid" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="sem" Type="String" />
                    <asp:Parameter Name="cpi" Type="Decimal" />
                    <asp:Parameter Name="contactno" Type="String" />
                    <asp:Parameter Name="emailid" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" DefaultValue="1" Name="sid" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="sem" Type="String" />
                    <asp:Parameter Name="cpi" Type="Decimal" />
                    <asp:Parameter Name="contactno" Type="String" />
                    <asp:Parameter Name="emailid" Type="String" />
                    <asp:Parameter Name="original_sid" Type="Int32" />
                    <asp:Parameter Name="original_name" Type="String" />
                    <asp:Parameter Name="original_sem" Type="String" />
                    <asp:Parameter Name="original_cpi" Type="Decimal" />
                    <asp:Parameter Name="original_contactno" Type="String" />
                    <asp:Parameter Name="original_emailid" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
