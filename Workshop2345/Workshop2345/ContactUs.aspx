<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Workshop2345.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Contact Us <br /> 
            <asp:Label ID="lblMessage" runat="server" ForeColor="#FF5050" Text="Label"></asp:Label>
            <br />
            <br />
            Category: <asp:DropDownList ID="DropdownList1" runat="server">
                <asp:ListItem Selected="True" Text="--Select--" Value="--Select--"></asp:ListItem>
                <asp:ListItem Text="--News--" Value="News"></asp:ListItem>
                <asp:ListItem Text="--Report--" Value="Report"></asp:ListItem>
                <asp:ListItem Text="--System--" Value="System"></asp:ListItem>
                <asp:ListItem Text="--Reminder--" Value="Reminder"></asp:ListItem>
                      </asp:DropDownList>
            <br />
            <br />
            Description : 
            <textarea id="txtDescription" cols="20" name="51" rows="2"></textarea><br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" Onclick="btnSubmit_Click" />
        </div>
        
    </form>
</body>
</html>
