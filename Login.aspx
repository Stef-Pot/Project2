<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CMPG323_P2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheetMain.css">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 209px;
            width: 480px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" CssClass="heading" Text="Welcom back"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" CssClass="lable" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameTX" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password" CssClass="lable"></asp:Label>
        <asp:TextBox ID="PasswordTX" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Login" />
    </form>
</body>
</html>
