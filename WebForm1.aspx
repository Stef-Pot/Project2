<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CMPG323_P2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <link rel="stylesheet" href="StyleSheetMain.css">
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label4" runat="server" CssClass="heading" Text="Your Images"></asp:Label>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="278px" Width="326px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name" CssClass="lable"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nametx" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Location" CssClass="lable"></asp:Label>
        <asp:TextBox ID="locationtx" runat="server" CssClass="textbox"></asp:TextBox>
&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Date" CssClass="lable"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Update Meta Data" CssClass="button" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Delete phote" CssClass="button" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tags" CssClass="lable"></asp:Label>
        <br />
        <asp:ListBox ID="ListBoxTags" runat="server" CssClass="Listbox"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="addTagtx" runat="server" CssClass="textbox"></asp:TextBox>
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Add tag" CssClass="button" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Next Image" OnClick="Button2_Click" CssClass="button" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Home" CssClass="button" />
    </form>
</body>
</html>
