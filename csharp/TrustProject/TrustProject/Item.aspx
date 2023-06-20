<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="TrustProject.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Item Details</p>
    <table class="w-50" style="width: 27%; height: 220px; margin-left: 33px">
        <tr>
            <td style="width: 314px">Item Id</td>
            <td style="width: 663px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td style="width: 314px">Item Name</td>
            <td style="width: 663px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 314px">Categorgy</td>
            <td style="width: 663px">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="204px">
                    <asp:ListItem>Electronics</asp:ListItem>
                    <asp:ListItem>Stationary</asp:ListItem>
                    <asp:ListItem>Furniture</asp:ListItem>
                    <asp:ListItem>Consumables</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 314px">Rate</td>
            <td style="width: 663px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 314px">Balance Quantity</td>
            <td style="width: 663px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modify" />
&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
