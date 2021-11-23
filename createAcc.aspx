<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAcc.aspx.cs" Inherits="CMPG323_P2.createAcc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="FirstName"></asp:Label>
            <asp:TextBox ID="Firstname" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Lastname"></asp:Label>
            <asp:TextBox ID="Lastname" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="Username" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="create account" />
            <br />
        </div>
    </form>
</body>
</html>
