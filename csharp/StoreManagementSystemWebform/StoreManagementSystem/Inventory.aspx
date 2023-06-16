<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="StoreManagementSystem.Inventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 97%;
        }
        .auto-style3 {
            width: 302px;
        }
        .auto-style5 {
            width: 423px;
        }
        .auto-style6 {
            width: 441px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Store Management System ( Inventory )<br />
            <br />
            </strong>
        </div>
        <strong>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:Panel ID="Panel3" runat="server" Height="366px" Width="435px">
                        Product Details<br />
                        <br />
                        </strong>&nbsp;&nbsp;&nbsp; Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="172px">
                        </asp:DropDownList>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp; Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="172px">
                        </asp:DropDownList>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp; Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp; Balance Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server" Width="166px"></asp:TextBox>
                        &nbsp;</asp:Panel>
                </td>
                <strong>
                <td class="auto-style6">
                    <asp:Panel ID="Panel4" runat="server" Height="363px" Width="427px">
                        <strong>Customer Details<br />
                        <br />
                        &nbsp;&nbsp;&nbsp; </strong>Full Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server" Height="23px" Width="212px"></asp:TextBox>
                        <br />
                        <strong>
                        <br />
                        &nbsp;&nbsp;&nbsp; </strong>Gender<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp; </strong>Mobile no.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:TextBox ID="TextBox5" runat="server" MaxLength="10" TextMode="Number" Width="212px"></asp:TextBox>
                        </strong>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp; Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:TextBox ID="TextBox6" runat="server" Height="27px" TextMode="MultiLine" Width="214px"></asp:TextBox>
                        </strong>
                    </asp:Panel>
                </td>
                <td class="auto-style5">
                    <asp:Panel ID="Panel5" runat="server" Height="358px" Width="409px">
                        <strong>Transaction Details<br />
                        <br />
                        &nbsp;&nbsp; </strong>Transaction Date&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="DateTime"></asp:TextBox>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp; Department&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:TextBox ID="TextBox8" runat="server" Width="176px"></asp:TextBox>
                        </strong>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp; Vendor&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:TextBox ID="TextBox9" runat="server" Width="176px"></asp:TextBox>
                        </strong>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp; Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                        <asp:TextBox ID="TextBox10" runat="server" Width="176px"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <br />
                        </strong>
                    </asp:Panel>
                </td>
            </tr>
        </table>
        </strong>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
