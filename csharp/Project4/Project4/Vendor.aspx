<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="Project4.Vendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 50%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style3 {
            width: 368px;
        }
        .auto-style4 {
            margin-left: 494px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Vendor Details</strong><br />
            <br />
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style3">Vendor ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Vendor Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modify" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style4" Width="430px">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
