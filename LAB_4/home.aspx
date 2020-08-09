<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="lab4_e.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <asp:Label ID="Label1" runat="server" Text="Full Name" ></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="fullname" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:RequiredFieldValidator ID="fname" runat="server" ControlToValidate="fullname" ErrorMessage="RequiredFieldValidator">name required</asp:RequiredFieldValidator>
        <br />
        <br />
        Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="age" runat="server" MaxLength="3" TextMode="Number"></asp:TextBox>
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" BorderColor="Red" MaximumValue="50" MinimumValue="18" ErrorMessage="RangeValidator">enter valid age</asp:RangeValidator>
        <br />
        <br />
        password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="password" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        confirm Password&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="confirmpassword" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="confirmpassword"   
ControlToValidate="password" Display="Dynamic" ErrorMessage="Re-entered password is not matching!" ></asp:CompareValidator>
            <br />
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:RadioButton ID="female" runat="server" GroupName="gender" Text="female" />
&nbsp;&nbsp;
        <asp:RadioButton ID="male" runat="server" GroupName="gender" Text="male" />
        <asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <br />
        Mobile No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="mobileno" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="mobileno"   
ErrorMessage="enter valid Mobile number!"  ValidationExpression="\d{10}" BorderColor="Red"></asp:RegularExpressionValidator>
            <br />
        <br />
        <br />
        Hobbies&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<div style="margin-left: 160px">
            <asp:CheckBoxList ID="hobbies" runat="server" Width="108px">
                <asp:ListItem>singing</asp:ListItem>
                <asp:ListItem>dancing</asp:ListItem>
                <asp:ListItem>reading</asp:ListItem>
                <asp:ListItem>playing</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Label ID="Label8" runat="server"></asp:Label>
        </div>
        <br />
        State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="state" runat="server" AutoPostBack="True" OnSelectedIndexChanged="state_SelectedIndexChanged" >
            <asp:ListItem>gujarat</asp:ListItem>
            <asp:ListItem>maharashtra</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label12" runat="server"></asp:Label>
        <br />
        <br />
        City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="city" runat="server" AutoPostBack="True">
            <asp:ListItem Enabled="False">ahmedabad</asp:ListItem>
            <asp:ListItem Enabled="False">vadodara</asp:ListItem>
            <asp:ListItem Enabled="False">mumbai</asp:ListItem>
            <asp:ListItem Enabled="False">pune</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label13" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        PAN number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="pan" runat="server"></asp:TextBox>
        <asp:Label ID="Label11" runat="server"></asp:Label>
        <asp:CustomValidator runat="server" id="Custom" controltovalidate="pan" Display="Dynamic" 
                onservervalidate="pan_verify" errormessage="Enter a valid PAN Number!!"  ValidateEmptyText="true" />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
    </form>
</body>
</html>
