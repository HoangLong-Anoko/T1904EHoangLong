<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ws3webform.aspx.cs" Inherits="Workshop2345.ws3webform" %>
<%@ Register Src="~/UserControll/LeftMessage.ascx" TagPrefix="uc1" TagName="LeftMessage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <uc1:LeftMessage runat="server" ID="LeftMessage"/>
    </div>
        <h3> Welcome! </h3>
        <div>
        </div>
        </form>
</body>
</html>
