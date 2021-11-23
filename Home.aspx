<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CMPG323_P2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <link rel="stylesheet" href="StyleSheetMain.css">
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" CssClass="heading" Text="Welcome, share and view "></asp:Label>
        <br />
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="My Images" CssClass="button" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Share images" CssClass="button" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="Sign Out" CssClass="button" />
        </div>
    </form>
</body>
</html>
