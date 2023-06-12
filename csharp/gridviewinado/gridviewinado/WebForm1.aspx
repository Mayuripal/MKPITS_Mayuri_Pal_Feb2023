<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="gridviewinado.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 488px;
        }
        .auto-style3 {
            width: 506px;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            <div class="auto-style4">
                Grid view in asp.net
                <br />
                <br />
            </div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <br />
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <br />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Load" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    &nbsp;<br />
                Total Amount
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Paid Amount&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="mode" Text="Cash" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="mode" Text="EMI" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show emi" />
                    </td>
                </tr>
            </table>
            <br />
                        <asp:GridView ID="GridView3" runat="server">
                        </asp:GridView>
                        <asp:Button ID="Button3" runat="server" Text="Show detail" OnClick="Button3_Click" />
            <br />
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
