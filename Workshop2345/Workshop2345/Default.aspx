<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Workshop2345._Default" %>

<%@ Register Src="~/UserControll/LeftMessage.ascx" TagPrefix="uc1" TagName="LeftMessage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form ID="form1" runat="sever">
        <div >
        <uc1:LeftMessage runat="sever" ID="LeftMessage"/>
    </div>
        <h3> Welcome! </h3>
        <div>
        </div>
        </form>
</body>
</html>


