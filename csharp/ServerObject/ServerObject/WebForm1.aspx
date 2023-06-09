<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServerObject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Webform 1 page<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Execute Method" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer Method" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Html Encode Server" />
&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="URL Encode" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="URL Method2" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="URL Method3" />
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="MapPath Method" />
        </div>
    </form>
</body>
</html>
