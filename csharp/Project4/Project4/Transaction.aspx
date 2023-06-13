<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="Project4.Transaction" %>

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
            width: 374px;
        }
        .auto-style4 {
            margin-left: 525px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Transaction Details</strong><br />
            <br />
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style3">Transaction ID</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Item ID</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Transaction Date</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Department ID</td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Vendor ID</td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;Quantity</td>
                    <td>
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Modify" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Search" />
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
