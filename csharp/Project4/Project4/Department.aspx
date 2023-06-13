<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Project4.Department" %>

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
            width: 443px;
        }
        .auto-style4 {
            margin-left: 525px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Department Details</strong><br />
            <br />
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style3">Department ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Department Name</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Modify" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Search" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style4" Width="430px">
            </asp:GridView>
            <br />
        </div>
        <div>
        </div>
    </form>
</body>
</html>
